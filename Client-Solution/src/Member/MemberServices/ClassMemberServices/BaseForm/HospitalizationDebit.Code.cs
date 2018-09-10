using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MemberServices
{
    partial class HospitalizationDebit
    {
        #region Unmanaged Code
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0;    // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1;    // 'Small icon

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath,
                                        uint dwFileAttributes,
                                        ref SHFILEINFO psfi,
                                        uint cbSizeFileInfo,
                                        uint uFlags);
        }

        // 
        [Serializable]
        public struct ShellExecuteInfo
        {
            public int Size;
            public uint Mask;
            public IntPtr hwnd;
            public string Verb;
            public string File;
            public string Parameters;
            public string Directory;
            public uint Show;
            public IntPtr InstApp;
            public IntPtr IDList;
            public string Class;
            public IntPtr hkeyClass;
            public uint HotKey;
            public IntPtr Icon;
            public IntPtr Monitor;
        }


        // Code For OpenWithDialog Box
        [DllImport("shell32.dll", SetLastError = true)]
        extern public static bool
               ShellExecuteEx(ref ShellExecuteInfo lpExecInfo);
        #endregion

        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.InHouseHospitalizationDebit _inHouseHospitalizationDebitInfo;
        protected CommonExchange.Member _memberInfo;
        protected MemberLogic _memberManager;
        protected Decimal _hospitalizationRunningBalanceForTheYear;
        protected Decimal _hospitalizationMaximumAmount = 0;

        private ErrorProvider _errProvider;

        private String _inHouseHospitalizationDebitDocumentOriginalName = String.Empty;

        private List<Process> _processListHospitalizationDebitDocument;
        private List<String> _docomentOpenListHospitalizationDebitDocument;

        private Int32 _imageIndexHospitalizationDebitDocument = 0;

        private const uint SW_NORMAL = 1;

        private Boolean _hasQueryHospitalizationDebitnDocument = false;
        #endregion

        #region Class Constructos
        public HospitalizationDebit()
        {
            this.InitializeComponent();
        }

        public HospitalizationDebit(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, MemberLogic memberManager,
            Decimal hospitalizationRunningBalanceForTheYear, Decimal hospitalizationMaximumAmount, String memberName)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberInfo = memberInfo;
            _memberManager = memberManager;
            _hospitalizationRunningBalanceForTheYear = hospitalizationRunningBalanceForTheYear;
            _hospitalizationMaximumAmount = hospitalizationMaximumAmount;

            this.Text = memberName;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.lnkChangeReflectedDate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeReflectedDateLinkClicked);
            this.lnkChangeDateFrom.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeDateFromLinkClicked);
            this.lnkChangeDateTo.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeDateToLinkClicked);
            this.txtNetAssistanceAmount.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtNetAssistanceAmount.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtNetAssistanceAmount.Validated += new EventHandler(txtNetAssistanceAmountValidated);
            this.txtHospitalname.Validated += new EventHandler(txtHospitalnameValidated);
            this.txtCauseOfAdmission.Validated += new EventHandler(txtCauseOfAdmissionValidated);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
            //this.btnExcludeCoverage.Click += new EventHandler(btnExcludeCoverageClick);
            this.btnIncludeCoverage.Click += new EventHandler(btnIncludeCoverageClick);
            this.lsvChargesSummary.MouseDoubleClick += new MouseEventHandler(lsvChargesSummaryMouseDoubleClick);
            this.btnAddDocument.Click += new EventHandler(btnAddDocumentClick);
            this.btnShowDocument.Click += new EventHandler(btnShowDocumentClick);
            this.lsvHospitalizationDocument.MouseDown += new MouseEventHandler(lsvHospitalizationDocumentMouseDown);
            this.lsvHospitalizationDocument.SelectedIndexChanged += new EventHandler(lsvHospitalizationDocumentSelectedIndexChanged);
            this.lsvHospitalizationDocument.MouseDoubleClick += new MouseEventHandler(lsvHospitalizationDocumentMouseDoubleClick);
            this.btnList.Click += new EventHandler(btnListClick);
            this.btnIcon.Click += new EventHandler(btnIconClick);
            this.lblDeleteInHouseHospitailzationDebitDocument.Click += new EventHandler(lblDeleteInHouseHospitailzationDebitDocumentClick);
            this.btnPrint.Click += new EventHandler(btnPrintClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS HospitalizationDebit EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _inHouseHospitalizationDebitInfo = new CommonExchange.InHouseHospitalizationDebit();

            _inHouseHospitalizationDebitInfo.MemberInfo = _memberInfo;
        }//-----------------------------

        //event is raised when the class is clossing
        protected virtual void ClassClossing(object sender, FormClosingEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (_hasQueryHospitalizationDebitnDocument)
            {
                _memberManager.KillProcess(_processListHospitalizationDebitDocument);

                Thread.Sleep(500);

                _memberManager.InsertUpdateDeleteInHouseHospitaliationDebitDocumentInformation(_userInfo, 
                    _inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath));
            }

            this.Cursor = Cursors.Arrow;
        }//-------------------------
        //####################################################END CLASS HospitalizationDebit EVENTS###############################################

        //####################################################LINKLABEL lnkChangeReflectedDate EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeReflectedDateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime reflectedDate = DateTime.MinValue;
            
            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.ReflectedDate))
            {
                reflectedDate = DateTime.Parse(_memberManager.ServerDateTime);
            }
            else
            {
                reflectedDate = DateTime.Parse(_inHouseHospitalizationDebitInfo.ReflectedDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(reflectedDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_memberManager.ServerDateTime).ToLongTimeString(), out reflectedDate))
                    {
                        _inHouseHospitalizationDebitInfo.ReflectedDate = reflectedDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtReflectedDate.Text = reflectedDate.ToLongDateString();                   
                }
            }

            if (!String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.ReflectedDate) &&
                !String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.DateFrom) &&
                !String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.DateTo))
            {
                this.btnPrint.Enabled = true;
            }
            else
            {
                this.btnPrint.Enabled = false;
            }

            this.Cursor = Cursors.Arrow;
        }//--------------------------------
        //####################################################END LINKLABEL lnkChangeReflectedDate EVENTS###############################################

        //####################################################LINKLABEL lnkChangeDateFrom EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeDateFromLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateFrom = DateTime.MinValue;

            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.DateFrom))
            {
                dateFrom = DateTime.Parse(_memberManager.ServerDateTime);
            }
            else
            {
                dateFrom = DateTime.Parse(_inHouseHospitalizationDebitInfo.DateFrom);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateFrom))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_memberManager.ServerDateTime).ToLongTimeString(), out dateFrom))
                    {
                        _inHouseHospitalizationDebitInfo.DateFrom = dateFrom.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtDateFrom.Text = dateFrom.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //####################################################END LINKLABEL lnkChangeDateFrom EVENTS###############################################

        //####################################################LINKLABEL lnkChangeDateTo EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeDateToLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateTo = DateTime.MinValue;

            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.DateTo))
            {
                dateTo = DateTime.Parse(_memberManager.ServerDateTime);
            }
            else
            {
                dateTo = DateTime.Parse(_inHouseHospitalizationDebitInfo.DateTo);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateTo))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_memberManager.ServerDateTime).ToLongTimeString(), out dateTo))
                    {
                        _inHouseHospitalizationDebitInfo.DateTo = dateTo.ToShortDateString() + " 11:59:59 PM";
                    }

                    this.txtDateTo.Text = dateTo.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------------
        //####################################################END LINKLABEL lnkChangeDateTo EVENTS###############################################


        //####################################################TEXTBOX textBoxDecimal EVENTS###############################################
        //event is raised when the control is validating
        private void txtDecimalValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//--------------------------

        //event is raised when the key is pressed
        private void txtDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//-------------------------
        //####################################################END TEXTBOX textBoxDecimal EVENTS###############################################  

        //####################################################TEXTBOX txtNetAssistanceAmountV EVENTS###############################################
        //event is raised when the control is validating
        private void txtNetAssistanceAmountValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtNetAssistanceAmount.Text, out amount))
            {
                _inHouseHospitalizationDebitInfo.NetAssistanceAmount = amount;

                _errProvider.SetError(this.txtNetAssistanceAmount, String.Empty);

                if (amount > _hospitalizationRunningBalanceForTheYear)
                {
                    _errProvider.SetError(this.txtNetAssistanceAmount, "Net Assistance Amount must be lesser than hospitalization running balance for the year.");
                    _errProvider.SetIconAlignment(this.txtNetAssistanceAmount, ErrorIconAlignment.MiddleRight);
                }
                else
                {
                    _memberManager.InitializeInHouseHospitalizationDebitChargesSummary(this.lsvChargesSummary, _inHouseHospitalizationDebitInfo, 
                        _hospitalizationRunningBalanceForTheYear, _hospitalizationMaximumAmount);
                }
            }
        }//------------------------------
        //####################################################END TEXTBOX txtNetAssistanceAmountV EVENTS###############################################

        //####################################################TEXTBOX txtHospitalname EVENTS###############################################
        //event is raised when the control is validating
        private void txtHospitalnameValidated(object sender, EventArgs e)
        {
            _inHouseHospitalizationDebitInfo.HospitalName = BaseServices.ProcStatic.TrimStartEndString(this.txtHospitalname.Text);
        }//-------------------------------
        //####################################################END TEXTBOX txtHospitalname EVENTS###############################################

        //####################################################TEXTBOX txtCauseOfAdmission EVENTS###############################################
        //event is raised when the control is validating
        private void txtCauseOfAdmissionValidated(object sender, EventArgs e)
        {
            _inHouseHospitalizationDebitInfo.CauseOfAdmission = BaseServices.ProcStatic.TrimStartEndString(this.txtCauseOfAdmission.Text);
        }//----------------------------------
        //####################################################END TEXTBOX txtCauseOfAdmission EVENTS###############################################

        //####################################################TEXTBOX txtRemarks EVENTS###############################################
        //event is raised when the control is validating
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _inHouseHospitalizationDebitInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);

            if (this.lsvHospitalizationDocument.SelectedItems.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                _memberManager.InsertUpdateInHouseHospitalizationDebitDocumentInformationInformation(this.lsvHospitalizationDocument.SelectedItems[0].Text,
                    BaseServices.ProcStatic.TrimStartEndString(this.txtHospitalizationDebitDocumentRemarks.Text));

                MessageBox.Show("The in house hospitalization debit document information has been successfully inserted.");

                this.Cursor = Cursors.Arrow;
            }
        }//-------------------------------
        //####################################################END TEXTBOX txtRemarks EVENTS###############################################

        //####################################################BUTTON btnIncludeCoverage EVENTS###############################################
        //event is raised when the control is clicked
        private void btnIncludeCoverageClick(object sender, EventArgs e)
        {
            this.ShowMultipleAddIncludeCoverage(false);
        }//---------------------------  
        //####################################################END BUTTON btnIncludeCoverage EVENTS###############################################

        //####################################################BUTTON btnExcludeCoverage EVENTS###############################################
        //event is raised when the control is clicked
        //private void btnExcludeCoverageClick(object sender, EventArgs e)
        //{
        //    using (InHouseExcludeCoverageCreate frmCreate = new InHouseExcludeCoverageCreate(_userInfo, _memberManager))
        //    {
        //        frmCreate.ShowDialog(this);

        //        if (frmCreate.HasCreated)
        //        {
        //            _inHouseHospitalizationDebitInfo.ExcludeCoverageList.Add(frmCreate.InHouseExcludeCoverageInfo);

        //            _memberManager.InitializeInHouseHospitalizationDebitChargesSummary(this.lsvChargesSummary, _inHouseHospitalizationDebitInfo,
        //                _hospitalizationRunningBalanceForTheYear, _hospitalizationMaximumAmount);
        //        }
        //    }
        //}//----------------------------
        //####################################################END BUTTON btnExcludeCoverage EVENTS###############################################

        //####################################################LISTVIEW lsvChargesSummaryMouseDouble EVENTS###############################################
        //event is raised when the control is double clicked
        private void lsvChargesSummaryMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((this.lsvChargesSummary.Items.Count > 0 && this.lsvChargesSummary.FocusedItem != null) &&
                    this.lsvChargesSummary.GetItemAt(e.X, e.Y) != null) &&
                    !String.IsNullOrEmpty(this.lsvChargesSummary.GetItemAt(e.X, e.Y).SubItems[3].Text))
                {
                    Int64 debitId = 0;
                    Boolean isInclude = false;

                    if (Int64.TryParse(this.lsvChargesSummary.GetItemAt(e.X, e.Y).SubItems[3].Text, out debitId) &&
                        Boolean.TryParse(this.lsvChargesSummary.GetItemAt(e.X, e.Y).SubItems[4].Text, out isInclude))
                    {
                        if (isInclude)
                        {
                            using (InHouseIncludeCoverageUpate frmUpdate = new InHouseIncludeCoverageUpate(_userInfo,
                                _memberManager.GetDetailsInHouseIncludeCoverage(debitId, _inHouseHospitalizationDebitInfo.IncludeCoverageList), _memberManager, 
                                _inHouseHospitalizationDebitInfo.IncludeCoverageList))
                            {
                                frmUpdate.ShowDialog(this);

                                if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                                {
                                    Decimal netAssistanceAmount = 0;

                                    foreach (CommonExchange.InHouseIncludeCoverage list in _inHouseHospitalizationDebitInfo.IncludeCoverageList)
                                    {
                                        if (list.ObjectState != DataRowState.Deleted)
                                        {
                                            netAssistanceAmount += list.IncludeAmount;
                                        }
                                    }

                                    _inHouseHospitalizationDebitInfo.NetAssistanceAmount = netAssistanceAmount;
                                    this.txtNetAssistanceAmount.Text = netAssistanceAmount.ToString("N");

                                    _memberManager.InitializeInHouseHospitalizationDebitChargesSummary(this.lsvChargesSummary, _inHouseHospitalizationDebitInfo,
                                        _hospitalizationRunningBalanceForTheYear, _hospitalizationMaximumAmount);
                                }
                            }
                        }
                        else
                        {
                            using (InHouseExcludeCoverageUpdate frmUpdate = new InHouseExcludeCoverageUpdate(_userInfo,
                                _memberManager.GetDetailsInHouseExcludeCoverage(debitId, _inHouseHospitalizationDebitInfo.ExcludeCoverageList), _memberManager))
                            {
                                frmUpdate.ShowDialog(this);

                                if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                                {
                                    Decimal netAssistanceAmount = 0;

                                    foreach (CommonExchange.InHouseIncludeCoverage list in _inHouseHospitalizationDebitInfo.IncludeCoverageList)
                                    {
                                        if (list.ObjectState != DataRowState.Deleted)
                                        {
                                            netAssistanceAmount += list.IncludeAmount;
                                        }
                                    }

                                    _inHouseHospitalizationDebitInfo.NetAssistanceAmount = netAssistanceAmount;
                                    this.txtNetAssistanceAmount.Text = netAssistanceAmount.ToString("N");

                                    _memberManager.InitializeInHouseHospitalizationDebitChargesSummary(this.lsvChargesSummary, _inHouseHospitalizationDebitInfo,
                                        _hospitalizationRunningBalanceForTheYear, _hospitalizationMaximumAmount);
                                }
                            }
                        }
                    }
                }
            }
        }//-----------------------------
        //####################################################END LISTVIEW lsvChargesSummaryMouseDouble EVENTS###############################################

        //####################################################BUTTON btnAddDocument EVENTS###############################################
        //event is raised when the control is clicked
        private void btnAddDocumentClick(object sender, EventArgs e)
        {
            OpenFileDialog imageChooser = new OpenFileDialog();
            imageChooser.InitialDirectory = "c:\\temp\\";
            imageChooser.Filter = "All files (*.*)|*.*";
            imageChooser.FilterIndex = 2;
            imageChooser.RestoreDirectory = true;

            if (imageChooser.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;

                if (!_memberManager.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument(_userInfo, -1, 
                    _inHouseHospitalizationDebitInfo.InHouseDebitSysId, imageChooser.FileName) &&
                    !File.Exists(_inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath) + Path.GetFileName(imageChooser.FileName)))
                {
                    _memberManager.InsertInHouseHospitalizationDebitDocument(_inHouseHospitalizationDebitInfo, Path.GetFileName(imageChooser.FileName),
                        BaseServices.ProcStatic.GetFileArrayBytes(imageChooser.FileName));

                    File.Copy(imageChooser.FileName, _inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath) + @"\" +
                        Path.GetFileName(imageChooser.FileName));

                    this.InitializeFileListView(_inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath), Path.GetFileName(imageChooser.FileName));

                    imageChooser.Dispose();
                }
                else
                {
                    MessageBox.Show("The document file name already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Cursor = Cursors.Arrow;
            }
        }//-----------------------------
        //####################################################END BUTTON btnAddDocument EVENTS###############################################

        //####################################################BUTTON btnShowDocument EVENTS###############################################
        //event is raised when the control is clicked
        private void btnShowDocumentClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (!_hasQueryHospitalizationDebitnDocument)
            {
                _processListHospitalizationDebitDocument = new List<Process>();
                _docomentOpenListHospitalizationDebitDocument = new List<String>();

                this.btnAddDocument.Enabled = this.btnDropDownIcon.Enabled = true;
                _hasQueryHospitalizationDebitnDocument = true;

                this.btnShowDocument.Enabled = false;
            }

            _memberManager.InitializeInHospitalizationDebitDocument(_userInfo, _inHouseHospitalizationDebitInfo);

            this.InitializeFileListView(_inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath), String.Empty);

            this.Cursor = Cursors.Arrow;
        }//----------------------------
        //####################################################END BUTTON btnShowDocument EVENTS##############################################

        //####################################################LISTVIEW lsvHospitalizationDocument EVENTS###############################################
        //event is raised when the mouse is down
        private void lsvHospitalizationDocumentMouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right || e.Button == MouseButtons.Left) &&
                 (this.lsvHospitalizationDocument.Items.Count > 0 && this.lsvHospitalizationDocument.FocusedItem != null))
            {
                if (this.lsvHospitalizationDocument.SelectedItems.Count > 0)
                {
                    if (this.lsvHospitalizationDocument.GetItemAt(e.X, e.Y) != null && e.Button == MouseButtons.Right)
                    {
                        String strMsg = "Delete - [" + this.lsvHospitalizationDocument.GetItemAt(e.X, e.Y).Text + "].";

                        _inHouseHospitalizationDebitDocumentOriginalName = this.lsvHospitalizationDocument.GetItemAt(e.X, e.Y).Text;

                        this.cmsInHouseHospitalizationDebitDocuments.Items[0].Text = strMsg;
                        this.cmsInHouseHospitalizationDebitDocuments.Show(this.lsvHospitalizationDocument, new Point(e.X, e.Y));
                    }
                }
            }
        }//----------------------------

        //event is raised when the item selection is changed
        private void lsvHospitalizationDocumentSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvHospitalizationDocument.SelectedItems.Count > 0)
            {
                this.txtHospitalizationDebitDocumentRemarks.Enabled = true;

                this.txtHospitalizationDebitDocumentRemarks.Text =
                    _memberManager.GetInHouseHospitalizationDebitDocumentInformation(this.lsvHospitalizationDocument.SelectedItems[0].Text);

                this.txtHospitalizationDebitDocumentRemarks.FindForm();
            }
        }//----------------------

        //event is raised when the mouse is double clicked
        private void lsvHospitalizationDocumentMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process prcs = new Process();

                    prcs.StartInfo.FileName = 
                        _inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath) + 
                        this.lsvHospitalizationDocument.SelectedItems[0].Text;

                    prcs.Start();

                    _processListHospitalizationDebitDocument.Add(prcs);
                    _docomentOpenListHospitalizationDebitDocument.Add(this.lsvHospitalizationDocument.SelectedItems[0].Text);
                }
                catch
                {
                    ShellExecuteInfo sei = new ShellExecuteInfo();
                    sei.Size = Marshal.SizeOf(sei);
                    sei.Verb = "openas";
                    sei.File = this.lsvHospitalizationDocument.SelectedItems[0].Text;
                    sei.Show = SW_NORMAL;

                    if (!ShellExecuteEx(ref sei))
                    {
                        throw new System.ComponentModel.Win32Exception();
                    }
                }
            }
        }//-------------------------
        //####################################################END LISTVIEW lsvHospitalizationDocument EVENTS###############################################

        //####################################################BUTTON btnList EVENTS###############################################
        //event is raised when the control is clicked
        private void btnListClick(object sender, EventArgs e)
        {
            this.lsvHospitalizationDocument.View = View.List;
        }//-------------------------
        //####################################################END BUTTON btnList EVENTS###############################################

        //####################################################BUTTON btnIcon EVENTS###############################################
        //event is raised when the is clicked
        private void btnIconClick(object sender, EventArgs e)
        {
            this.lsvLoanDocuments.View = View.LargeIcon;
        }//-------------------------
        //####################################################END BUTTON btnIcon EVENTS###############################################
     
        //####################################################LINKLABEL lblDeleteInHouseHospitailzationDebitDocument EVENTS#################################
        //event is raised when the is clicked
        private void lblDeleteInHouseHospitailzationDebitDocumentClick(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(_inHouseHospitalizationDebitDocumentOriginalName))
                {
                    _memberManager.DeleteInHouseHospitalizationDebitDocument(_inHouseHospitalizationDebitInfo,
                        _inHouseHospitalizationDebitDocumentOriginalName, Application.StartupPath);

                    MessageBox.Show("The in house hospitalization debit document has been successfully deleted.");

                    this.InitializeFileListView(_inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath), String.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting in house hospitalization debit document./n/n" + ex.Message, "Error");
            }
        }//-------------------------
        //####################################################END LINKLABEL lblDeleteInHouseHospitailzationDebitDocument EVENTS#################################

        //####################################################BUTTON btnPrint EVENTS#################################
        //event is raised when the is clicked
        private void btnPrintClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;            

            _memberManager.PrintInHouseHospitalizationDebit(_userInfo, _inHouseHospitalizationDebitInfo, _hospitalizationRunningBalanceForTheYear,
                _hospitalizationMaximumAmount, this);

            this.Cursor = Cursors.Arrow;
        }//----------------------------
        //####################################################END BUTTON btnPrint EVENTS#################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will allow to show multiple add included coverage
        private void ShowMultipleAddIncludeCoverage(Boolean isMultipleInsert)
        {
            using (InHouseIncludeCoverageCreate frmCreate = new InHouseIncludeCoverageCreate(_userInfo, _memberManager, _inHouseHospitalizationDebitInfo.IncludeCoverageList))
            {
                frmCreate.MultipleInsert = isMultipleInsert;
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    _inHouseHospitalizationDebitInfo.IncludeCoverageList.Add(frmCreate.InHouseIncludeCoverageInfo);

                    Decimal netAssistanceAmount = 0;

                    foreach (CommonExchange.InHouseIncludeCoverage list in _inHouseHospitalizationDebitInfo.IncludeCoverageList)
                    {
                        if (list.ObjectState != DataRowState.Deleted)
                        {
                            netAssistanceAmount += list.IncludeAmount;
                        }
                    }

                    _inHouseHospitalizationDebitInfo.NetAssistanceAmount = netAssistanceAmount;
                    this.txtNetAssistanceAmount.Text = netAssistanceAmount.ToString("N");

                    _memberManager.InitializeInHouseHospitalizationDebitChargesSummary(this.lsvChargesSummary, _inHouseHospitalizationDebitInfo,
                        _hospitalizationRunningBalanceForTheYear, _hospitalizationMaximumAmount);                    
                }

                isMultipleInsert = frmCreate.MultipleInsert;
            }

            if (isMultipleInsert)
            {
                this.ShowMultipleAddIncludeCoverage(isMultipleInsert);
            }
        }//--------------------------

        //this procedure will initialize file list
        private void InitializeFileListView(String dirPath, String firstOriginalName)
        {
            this.lsvHospitalizationDocument.Items.Clear();

            IntPtr hImgSmall;    //the handle to the system image list
            IntPtr hImgLarge;    //the handle to the system image list
            String fName;        // 'the file name to get icon from

            SHFILEINFO shinfo = new SHFILEINFO();

            this.lsvHospitalizationDocument.SmallImageList = this.lsvHospitalizationDocument.LargeImageList = this.imgIcon;

            DirectoryInfo dir = new DirectoryInfo(dirPath);

            Int32 index = 0;

            foreach (FileInfo file in dir.GetFiles())
            {
                if (!String.Equals("~", file.Name.Substring(0, 1)))
                {
                    fName = file.FullName;

                    //Use this to get the small Icon
                    hImgSmall = Win32.SHGetFileInfo(fName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

                    //Use this to get the large Icon
                    hImgLarge = Win32.SHGetFileInfo(fName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);

                    try
                    {
                        Image img = Image.FromFile(fName);

                        this.imgIcon.Images.Add(this.GetThumbnailImage(this.imgIcon.ImageSize.Width, img));

                        img.Dispose();
                    }
                    catch
                    {
                        //The icon is returned in the hIcon member of the shinfo
                        Icon myIcon = Icon.FromHandle(shinfo.hIcon);

                        this.imgIcon.Images.Add(myIcon);
                    }

                    //Add file name and icon to listview
                    this.lsvHospitalizationDocument.Items.Add(file.Name, _imageIndexHospitalizationDebitDocument++);

                    if (String.Equals(firstOriginalName, file.Name))
                    {
                        this.lsvHospitalizationDocument.Items[index].Selected = true;
                    }

                    index++;
                }
            }

            if (String.IsNullOrEmpty(firstOriginalName) && this.lsvHospitalizationDocument.Items.Count > 0)
            {
                this.lsvHospitalizationDocument.Items[0].Selected = true;
            }
        }//--------------------------

        //this procudre will set Thumbnail Images
        private Image GetThumbnailImage(int width, Image img)
        {
            Image thumb = new Bitmap(width, width);

            Image tmp = null;

            if (img.Width < width && img.Height < width)
            {
                using (Graphics g = Graphics.FromImage(thumb))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    int xoffset = (int)((width - img.Width) / 2);
                    int yoffset = (int)((width - img.Height) / 2);

                    g.DrawImage(img, xoffset, yoffset, img.Width, img.Height);
                }
            }
            else
            {
                Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

                if (img.Width == img.Height)
                {
                    thumb = img.GetThumbnailImage(width, width, myCallback, IntPtr.Zero);
                }
                else
                {
                    int k = 0;
                    int xoffset = 0;
                    int yoffset = 0;

                    if (img.Width < img.Height)
                    {

                        k = (int)(width * img.Width / img.Height);

                        tmp = img.GetThumbnailImage(k, width, myCallback, IntPtr.Zero);

                        xoffset = (int)((width - k) / 2);
                    }

                    if (img.Width > img.Height)
                    {
                        k = (int)(width * img.Height / img.Width);

                        tmp = img.GetThumbnailImage(width, k, myCallback, IntPtr.Zero);

                        yoffset = (int)((width - k) / 2);
                    }

                    using (Graphics g = Graphics.FromImage(thumb))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.DrawImage(tmp, xoffset, yoffset, tmp.Width, tmp.Height);
                    }
                }
            }

            using (Graphics g = Graphics.FromImage(thumb))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawRectangle(Pens.Green, 0, 0, thumb.Width - 1, thumb.Height - 1);
            }

            return thumb;
        }//--------------------------

        //this procedure will set thumbnail call back
        public bool ThumbnailCallback()
        {
            return true;
        }//--------------------------
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtReflectedDate, String.Empty);
            _errProvider.SetError(this.txtNetAssistanceAmount, String.Empty);
            _errProvider.SetError(this.txtHospitalname, String.Empty);
            _errProvider.SetError(this.txtDateFrom, String.Empty);
            _errProvider.SetError(this.txtDateTo, String.Empty);
            _errProvider.SetError(this.txtNetAssistanceAmount, String.Empty);

            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.txtReflectedDate, "A member information is required.");
                _errProvider.SetIconAlignment(this.txtReflectedDate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.ReflectedDate))
            {
                _errProvider.SetError(this.txtReflectedDate, "You must select a reflected date.");
                _errProvider.SetIconAlignment(this.txtReflectedDate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_inHouseHospitalizationDebitInfo.NetAssistanceAmount <= 0)
            {
                _errProvider.SetError(this.txtNetAssistanceAmount, "Net assistance Amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtNetAssistanceAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }
            
            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.InHouseDebitSysId) &&
                (_inHouseHospitalizationDebitInfo.NetAssistanceAmount > _hospitalizationRunningBalanceForTheYear))
            {
                _errProvider.SetError(this.txtNetAssistanceAmount, "Net assistance Amount must be lesser than hospitalization running balance for the year.");
                _errProvider.SetIconAlignment(this.txtNetAssistanceAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.HospitalName))
            {
                _errProvider.SetError(this.txtHospitalname, "Hospitalization name is required.");
                _errProvider.SetIconAlignment(this.txtHospitalname, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.DateFrom))
            {
                _errProvider.SetError(this.txtDateFrom, "You must select a date from.");
                _errProvider.SetIconAlignment(this.txtDateFrom, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.DateTo))
            {
                _errProvider.SetError(this.txtDateTo, "You must select a date to.");
                _errProvider.SetIconAlignment(this.txtDateTo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//------------------------------
        #endregion
    }
}
