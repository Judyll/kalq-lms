using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class RegularLoanInformation
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
        protected CommonExchange.RegularLoan _regularLoanInfo;
        protected CommonExchange.Member _memberInfo;
        protected LoanLogic _loanManager;

        private MemberLogic _memberManager;

        protected Boolean _hasAddedUpdatedRegularLoanCollateral = false;

        private ErrorProvider _errProvider;

        private Int32 _primaryIndexAmortization = 8;
        private Int32 _rowIndexAmortization = -1;
        private String _primaryIdAmortization = String.Empty;
        private String _loanDocumentOriginalName = String.Empty;

        private Int32 _primaryIndexRegularLoanCollateral = 0;
        private Int32 _rowIndexRegularLoanCollateral = -1;
        private String _primaryIdRegularLoanCollateral = String.Empty;

        private Int32 _primaryIndexCoMaker = 0;
        private Int32 _rowIndexCoMaker = -1;
        private String _primaryIdCoMaker = String.Empty;

        private List<Process> _processListLoanDocument;
        private List<String> _docomentOpenListLoanDocument;

        private Int32 _imageIndexLoanDocument = 0;

        private const uint SW_NORMAL = 1;

        private Boolean _hasQueryLoanDocument = false;
        #endregion

        #region Class Properties Decleration
        private Boolean _isForCreate = true;
        public Boolean IsForCreate
        {
            set { _isForCreate = value; }
        }
        #endregion

        #region Class Constructors
        public RegularLoanInformation()
        {
            this.InitializeComponent();
        }

        public RegularLoanInformation(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, LoanLogic loanManager, MemberLogic memberManager, String memberName)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _loanManager = loanManager;
            _memberManager = memberManager;
            _memberInfo = memberInfo;

            this.Text = memberName;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.txtAccountNumber.Validated += new EventHandler(txtAccountNumberValidated);
            this.txtPrincipalAmount.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtPrincipalAmount.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtPrincipalAmount.Validated += new EventHandler(txtPrincipalAmountValidated);
            this.txtInterestRate.KeyPress += new KeyPressEventHandler(txtFloatKeyPress);
            this.txtInterestRate.Validating += new System.ComponentModel.CancelEventHandler(txtFloatValidating);
            this.txtInterestRate.Validated += new EventHandler(txtInterestRateValidated);
            this.txtNoOfPrepaidInterest.KeyPress += new KeyPressEventHandler(txtIntegerKeyPress);
            this.txtNoOfPrepaidInterest.Validating += new System.ComponentModel.CancelEventHandler(txtIntegerValidating);
            this.txtNoOfPrepaidInterest.Validated += new EventHandler(txtNoOfPrepaidInterestValidated);
            this.txtTerm.KeyPress += new KeyPressEventHandler(txtIntegerKeyPress);
            this.txtTerm.Validating += new System.ComponentModel.CancelEventHandler(txtIntegerValidating);
            this.txtTerm.Validated += new EventHandler(txtTermValidated);
            this.txtGracePeriod.KeyPress += new KeyPressEventHandler(txtIntegerKeyPress);
            this.txtGracePeriod.Validating += new System.ComponentModel.CancelEventHandler(txtIntegerValidating);
            this.txtGracePeriod.Validated += new EventHandler(txtGracePeriodValidated);
            this.txtPurposeOfLoan.Validated += new EventHandler(txtPurposeOfLoanValidated);
            this.txtLoanRequirements.Validated += new EventHandler(txtLoanRequirementsValidated);
            this.txtApprovalEvaluation.Validated += new EventHandler(txtApprovalEvaluationValidated);
            this.txtPenaltyRate.KeyPress += new KeyPressEventHandler(txtFloatKeyPress);
            this.txtPenaltyRate.Validating += new System.ComponentModel.CancelEventHandler(txtFloatValidating);
            this.txtPenaltyRate.Validated += new EventHandler(txtPenaltyRateValidated);
            this.txtNoOfDefaultPayments.KeyPress += new KeyPressEventHandler(txtIntegerKeyPress);
            this.txtNoOfDefaultPayments.Validating += new System.ComponentModel.CancelEventHandler(txtIntegerValidating);
            this.txtNoOfDefaultPayments.Validated += new EventHandler(txtNoOfDefaultPaymentsValidated);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
            this.txtLoanDocumentRemarks.Validated += new EventHandler(txtLoanDocumentRemarksValidated);
            this.cboLoanType.SelectedIndexChanged += new EventHandler(cboLoanTypeSelectedIndexChanged);
            this.cboPaymentInterval.SelectedIndexChanged += new EventHandler(cboPaymentIntervalSelectedIndexChanged);
            this.lnkChangeDateApplied.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeDateAppliedLinkClicked);
            this.lnkChangeDateApproved.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeDateApprovedLinkClicked);
            this.lnkChageReleaseDate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChageReleaseDateLinkClicked);
            this.lnkChangeMaturityDate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeMaturityDateLinkClicked);
            this.rdbStraight.CheckedChanged += new EventHandler(rdbStraightCheckedChanged);
            this.rdbProductive.CheckedChanged += new EventHandler(rdbProductiveCheckedChanged);
            this.btnAddCharges.Click += new EventHandler(btnAddChargesClick);
            this.btnAddAdditionals.Click += new EventHandler(btnAddAdditionalsClick);
            this.lsvChargesAdditions.MouseDoubleClick += new MouseEventHandler(lsvChargesAdditionsMouseDoubleClick);
            //this.btnCalculate.Click += new EventHandler(btnCalculateClick);
            this.dgvAmortizationList.MouseDown += new MouseEventHandler(dgvAmortizationListMouseDown);
            this.dgvAmortizationList.KeyPress += new KeyPressEventHandler(dgvAmortizationListKeyPress);
            this.dgvAmortizationList.KeyDown += new KeyEventHandler(dgvAmortizationListKeyDown);
            this.dgvAmortizationList.DataSourceChanged += new EventHandler(dgvAmortizationListDataSourceChanged);
            this.dgvAmortizationList.DoubleClick += new EventHandler(dgvAmortizationListDoubleClick);
            this.dgvRegularLoanCollateral.MouseDown += new MouseEventHandler(dgvRegularLoanCollateralMouseDown);
            this.dgvRegularLoanCollateral.KeyPress += new KeyPressEventHandler(dgvRegularLoanCollateralKeyPress);
            this.dgvRegularLoanCollateral.KeyDown += new KeyEventHandler(dgvRegularLoanCollateralKeyDown);
            this.dgvRegularLoanCollateral.DataSourceChanged += new EventHandler(dgvRegularLoanCollateralDataSourceChanged);
            this.dgvCoMaker.MouseDown += new MouseEventHandler(dgvCoMakerMouseDown);
            this.dgvCoMaker.KeyDown += new KeyEventHandler(dgvCoMakerKeyDown);
            this.dgvCoMaker.KeyPress += new KeyPressEventHandler(dgvCoMakerKeyPress);
            this.dgvCoMaker.DataSourceChanged += new EventHandler(dgvCoMakerDataSourceChanged);
            this.dgvCoMaker.DoubleClick += new EventHandler(dgvCoMakerDoubleClick);
            this.lsvLoanDocuments.MouseDown += new MouseEventHandler(lsvLoanDocumentsMouseDown);
            this.lsvLoanDocuments.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(lsvLoanDocumentsItemSelectionChanged);
            this.lsvLoanDocuments.MouseDoubleClick += new MouseEventHandler(lsvLoanDocumentsMouseDoubleClick);
            this.btnShowDocument.Click += new EventHandler(btnShowDocumentClick);
            this.btnAddDocument.Click += new EventHandler(btnAddDocumentClick);
            this.btnIcon.Click += new EventHandler(btnIconClick);
            this.btnList.Click += new EventHandler(btnListClick);
            this.btnPrintChargeAdditionAmortization.Click += new EventHandler(btnPrintChargeAdditionAmortizationClick);
            this.btnPrintStatementOfAccount.Click += new EventHandler(btnPrintStatementOfAccountClick);
            this.lblDeleteLoanDocument.Click += new EventHandler(lblDeleteLoanDocumentClick);
            this.lnkCreateRegularLoanCollateral.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateRegularLoanCollateralLinkClicked);
            this.lblDeleteRegularLoanCollateral.Click += new EventHandler(lblDeleteRegularLoanCollateralClick);
            this.lnkCreateCoMaker.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateCoMakerLinkClicked);
            this.lnkReGenerateAccountNumber.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkReGenerateAccountNumberLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS RegularLoanInformation EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _regularLoanInfo = new CommonExchange.RegularLoan();

            _regularLoanInfo.MemberInfo = _memberInfo;

            _regularLoanInfo.IsStraightLoan = true;

            this.dgvAmortizationList.DataSource = _loanManager.LoanAmortizationTable;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvAmortizationList, false);

            Decimal totalLoan = 0;

            this.dgvPaymentList.DataSource = _loanManager.GetRegularLoanPayments(_userInfo, _regularLoanInfo.RegularLoanSysId, this.lblTotalPayment, ref totalLoan);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvPaymentList, false);

            _loanManager.InitializeLoanTypeCombobox(this.cboLoanType);
            _loanManager.InitializePaymentIntervalComboBox(this.cboPaymentInterval);

            this.dgvRegularLoanCollateral.DataSource = _loanManager.GetSearchedRegularLoanCollaterals(_userInfo, _regularLoanInfo.RegularLoanSysId, true);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvRegularLoanCollateral, false);

            this.dgvCoMaker.DataSource = _loanManager.GetSearchedRegularLoanCoMaker(_userInfo, _regularLoanInfo.RegularLoanSysId, true);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvCoMaker, false);

            Byte gracePeriod = 0;

            if (Byte.TryParse(this.txtGracePeriod.Text, out gracePeriod))
            {
                _regularLoanInfo.GracePeriod = gracePeriod;
            }

            Single penaltyRate = 0;

            if (Single.TryParse(this.txtPenaltyRate.Text, out penaltyRate))
            {
                _regularLoanInfo.PenaltyRate = penaltyRate;
            }

            Byte defaultPayments = 0;

            if (Byte.TryParse(this.txtNoOfDefaultPayments.Text, out defaultPayments))
            {
                _regularLoanInfo.NoDefaultPayment = defaultPayments;
            }
        }//---------------------------

        //envet is raised when the class is clossing
        protected virtual void ClassClossing(object sender, FormClosingEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (_hasQueryLoanDocument)
            {
                _loanManager.KillProcess(_processListLoanDocument);

                Thread.Sleep(500);

                _loanManager.InsertUpdateDeleteLoanDocumentInformation(_userInfo, _regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath));
            }

            this.Cursor = Cursors.Arrow;
        }//------------------------------
        //####################################################END CLASS RegularLoanInformation EVENTS###############################################

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

        //####################################################TEXTBOX textBoxInterger EVENTS###############################################
        //event is raised when the control is validating
        private void txtIntegerValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateInteger((TextBox)sender);
        }//---------------------------

        //event is raised when the control key is pressed
        private void txtIntegerKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxIntegersOnly(e);
        }//--------------------------
        //####################################################END TEXTBOX textBoxInterger EVENTS###############################################

        //####################################################TEXTBOX textBoxFloat EVENTS###############################################
        //event is raised when the control is validated
        private void txtFloatValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateFloatMaxTwoDecimal((TextBox)sender);
        }//------------------------------

        //event is raised when the key is pressed
        private void txtFloatKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxFloatDecimalOnly(e);
        }//----------------------------
        //####################################################END TEXTBOX textBoxFloat EVENTS###############################################

        //####################################################TEXTBOX txtAccountNumber EVENTS###############################################
        //event is raised when the control is validated
        private void txtAccountNumberValidated(object sender, EventArgs e)
        {
            _regularLoanInfo.AccountNo = BaseServices.ProcStatic.TrimStartEndString(this.txtAccountNumber.Text);
        }//------------------------------
        //####################################################END TEXTBOX txtAccountNumber EVENTS###############################################

        //####################################################TEXTBOX txtPrincipalAmount EVENTS###############################################
        //event is raised when the control is validated
        private void txtPrincipalAmountValidated(object sender, EventArgs e)
        {
            Decimal pAmount = 0;

            if (Decimal.TryParse(this.txtPrincipalAmount.Text, out pAmount))
            {
                _regularLoanInfo.LoanAmount = pAmount;

                _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);

                this.gbxChargesAdditionals.Enabled = pAmount > 0 ? true : false;               
            }

            this.ReCalculateLoanAmortization();
        }//-------------------------------
        //####################################################END TEXTBOX txtPrincipalAmount EVENTS###############################################

        //####################################################TEXTBOX txtInterestRate EVENTS###############################################
        //event is raised when the control is validated
        private void txtInterestRateValidated(object sender, EventArgs e)
        {
            Single interest = 0;

            if (Single.TryParse(this.txtInterestRate.Text, out interest))
            {
                _regularLoanInfo.InterestRate = interest;
            }

            this.ReCalculateLoanAmortization();
        }//---------------------------        
        //####################################################END TEXTBOX txtInterestRate EVENTS###############################################

        //####################################################TEXTBOX txtNoOfPrepaidInterest EVENTS###############################################
        //event is raised when the control is validated
        private void txtNoOfPrepaidInterestValidated(object sender, EventArgs e)
        {
            DateTime approvedDate = DateTime.MinValue;

            if (DateTime.TryParse(_regularLoanInfo.DateApproved, out approvedDate) && DateTime.Compare(approvedDate, DateTime.MinValue) != 0)
            {
                this.SetFirtPaymentDate(approvedDate);
            }

            this.ReCalculateLoanAmortization();
        }//---------------------------
        //####################################################END TEXTBOX txtNoOfPrepaidInterest EVENTS###############################################

        //####################################################TEXTBOX txtTerm EVENTS###############################################
        //event is raised when the control is validated
        private void txtTermValidated(object sender, EventArgs e)
        {
            Int16 loanTerm = 0;

            if (Int16.TryParse(this.txtTerm.Text, out loanTerm))
            {
                _regularLoanInfo.LoanTerms = loanTerm;
            }

            DateTime approvedDate = DateTime.MinValue;

            if (DateTime.TryParse(_regularLoanInfo.DateApproved, out approvedDate) && DateTime.Compare(approvedDate, DateTime.MinValue) != 0)
            {
                this.SetFirtPaymentDate(approvedDate);
            }

            this.ReCalculateLoanAmortization();
        }//---------------------------
        //####################################################END TEXTBOX txtTerm EVENTS###############################################

        //####################################################TEXTBOX txtGracePeriod EVENTS###############################################
        //event is raised when the control is validated
        private void txtGracePeriodValidated(object sender, EventArgs e)
        {
            Byte gracePeriod = 0;

            if (Byte.TryParse(this.txtGracePeriod.Text, out gracePeriod))
            {
                _regularLoanInfo.GracePeriod = gracePeriod;               
            }
        }//------------------------------
        //####################################################END TEXTBOX txtGracePeriod EVENTS###############################################

        //####################################################TEXTBOX txtPurposeOfLoan EVENTS###############################################
        //event is raised when the control is validated
        private void txtPurposeOfLoanValidated(object sender, EventArgs e)
        {
            _regularLoanInfo.PurposeOfLoan = BaseServices.ProcStatic.TrimStartEndString(this.txtPurposeOfLoan.Text);
        }//-----------------------------
        //####################################################END TEXTBOX txtPurposeOfLoan EVENTS###############################################

        //####################################################TEXTBOX txtLoanRequirements EVENTS###############################################
        //event is raised when the control is validated
        private void txtLoanRequirementsValidated(object sender, EventArgs e)
        {
            _regularLoanInfo.LoanRequirements = BaseServices.ProcStatic.TrimStartEndString(this.txtLoanRequirements.Text);
        }//----------------------------
        //####################################################END TEXTBOX txtLoanRequirements EVENTS###############################################

        //####################################################TEXTBOX txtApprovedEvaluation EVENTS###############################################
        //event is raised when the control is validated
        private void txtApprovalEvaluationValidated(object sender, EventArgs e)
        {
            _regularLoanInfo.ApprovalEvaluation = BaseServices.ProcStatic.TrimStartEndString(this.txtApprovalEvaluation.Text);
        }//-----------------------------
        //####################################################END TEXTBOX txtApprovedEvaluation EVENTS###############################################

        //####################################################TEXTBOX txtPenaltyRate EVENTS###############################################
        //event is raised when the control is validated
        private void txtPenaltyRateValidated(object sender, EventArgs e)
        {
            Single penaltyRate = 0;

            if (Single.TryParse(this.txtPenaltyRate.Text, out penaltyRate))
            {
                _regularLoanInfo.PenaltyRate = penaltyRate;
            }
        }//-------------------------------
        //####################################################END TEXTBOX txtPenaltyRate EVENTS###############################################

        //####################################################TEXTBOX txtNoOfDefaultPayments EVENTS###############################################
        //event is raised when the control is validated
        private void txtNoOfDefaultPaymentsValidated(object sender, EventArgs e)
        {
            Byte defaultPayments = 0;

            if (Byte.TryParse(this.txtNoOfDefaultPayments.Text, out defaultPayments))
            {
                _regularLoanInfo.NoDefaultPayment = defaultPayments;
            }
        }//-------------------------------
        //####################################################END TEXTBOX txtNoOfDefaultPayments EVENTS###############################################

        //####################################################TEXTBOX txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _regularLoanInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//-----------------------------
        //####################################################END TEXTBOX txtRemarks EVENTS###############################################

        //####################################################TEXTBOX txtLoanDocumentRemarks EVENTS###############################################
        //event is raised when the is clicked
        private void txtLoanDocumentRemarksValidated(object sender, EventArgs e)
        {
            if (this.lsvLoanDocuments.SelectedItems.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                _loanManager.InsertUpdateLoanDocumentInformationInformation(this.lsvLoanDocuments.SelectedItems[0].Text,
                    BaseServices.ProcStatic.TrimStartEndString(this.txtLoanDocumentRemarks.Text));

                MessageBox.Show("The loan document information has been successfully inserted.");

                this.Cursor = Cursors.Arrow;
            }
        }//--------------------------
        //####################################################TEXTBOX txtLoanDocumentRemarks EVENTS###############################################      

        //####################################################COMBOBOX cboLoanTypte EVENTS###############################################
        //event is raised when the control is validated
        private void cboLoanTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            _regularLoanInfo.RegularLoanTypeInfo = _loanManager.GetRegularLoanTypeInformation(this.cboLoanType.SelectedIndex);

            //if (String.IsNullOrEmpty(_regularLoanInfo.RegularLoanSysId))
            //{
            //    _loanManager.InitializePreviousLoanOustandingBalance(_userInfo, _regularLoanInfo);
            //}

            if (String.IsNullOrEmpty(_regularLoanInfo.RegularLoanSysId) &&
                (!String.IsNullOrEmpty(_regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId) && !String.IsNullOrEmpty(_regularLoanInfo.DateApproved)))
            {
                this.txtAccountNumber.Enabled = true;

                _regularLoanInfo.AccountNo = this.txtAccountNumber.Text = _loanManager.GetRegularLoanAccountNumber(_userInfo,
                    _regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId, _regularLoanInfo.DateApproved);
            }
        }//---------------------------
        //####################################################END COMBOBOX cboLoanTypte EVENTS###############################################

        //####################################################COMBOBOX cboPaymentInterval EVENTS###############################################
        //event is raised when the control is validated
        private void cboPaymentIntervalSelectedIndexChanged(object sender, EventArgs e)
        {
            _regularLoanInfo.RepaymentScheduleInfo = _loanManager.GetRepaymentscheduleInformation(this.cboPaymentInterval.SelectedIndex);

            if (_isForCreate)
            {
                DateTime approvedDate = DateTime.MinValue;

                if (DateTime.TryParse(_regularLoanInfo.DateApproved, out approvedDate) && DateTime.Compare(approvedDate, DateTime.MinValue) != 0)
                {
                    this.SetFirtPaymentDate(approvedDate);
                }
            }
        }//------------------------
        //####################################################END COMBOBOX cboPaymentInterval EVENTS###############################################

        //####################################################LINKLABEL lnkChangeDateApplied EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeDateAppliedLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateApplied = DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanInfo.DateApplied))
            {
                dateApplied = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                dateApplied = DateTime.Parse(_regularLoanInfo.DateApplied);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateApplied))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out dateApplied))
                    {
                        _regularLoanInfo.DateApplied = dateApplied.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtDateApplied.Text = dateApplied.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------------
        //####################################################END LINKLABEL lnkChangeDateApplied EVENTS###############################################

        //####################################################LINKLABEL lnkChangeDateApproved EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeDateApprovedLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateApproved = DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanInfo.DateApproved))
            {
                dateApproved = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                dateApproved = DateTime.Parse(_regularLoanInfo.DateApproved);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateApproved))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out dateApproved))
                    {
                        _regularLoanInfo.DateApproved = dateApproved.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtDateApproved.Text = dateApproved.ToLongDateString();

                    if (String.IsNullOrEmpty(_regularLoanInfo.RegularLoanSysId) &&
                        (!String.IsNullOrEmpty(_regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId) && !String.IsNullOrEmpty(_regularLoanInfo.DateApproved)))
                    {
                        this.txtAccountNumber.Enabled = true;

                        _regularLoanInfo.AccountNo = this.txtAccountNumber.Text = _loanManager.GetRegularLoanAccountNumber(_userInfo,
                            _regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId, _regularLoanInfo.DateApproved);
                    }

                    //this.SetFirtPaymentDate(dateApproved);

                    this.txtPrincipalAmount.Focus();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//----------------------------
        //####################################################END LINKLABEL lnkChangeDateApproved EVENTS###############################################

        //####################################################LINKLABEL lnkChageReleaseDate EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChageReleaseDateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime firstPaymentDate= DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanInfo.DateFirstPayment))
            {
                firstPaymentDate = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                firstPaymentDate = DateTime.Parse(_regularLoanInfo.DateFirstPayment);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(firstPaymentDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out firstPaymentDate))
                    {
                        //firstPaymentDate = firstPaymentDate.Day == 31 || firstPaymentDate.Day == 29 ? firstPaymentDate.AddDays(-1) : firstPaymentDate;

                        _regularLoanInfo.DateFirstPayment = firstPaymentDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtFirstPaymentDate.Text = firstPaymentDate.ToLongDateString();

                    _regularLoanInfo.DateMaturity = _loanManager.CalculateMaturityDate(_regularLoanInfo).ToShortDateString() + " 12:00:00 AM";

                    this.txtMaturityDate.Text = DateTime.Parse(_regularLoanInfo.DateMaturity).ToLongDateString();
                }
            }

            this.ReCalculateLoanAmortization();

            this.Cursor = Cursors.Arrow;
        }//-----------------------------
        //####################################################END LINKLABEL lnkChageReleaseDate EVENTS###############################################

        //####################################################LINKLABEL lnkChangeMaturityDate EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeMaturityDateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateMaturity = DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanInfo.DateMaturity))
            {
                dateMaturity = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                dateMaturity = DateTime.Parse(_regularLoanInfo.DateMaturity);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateMaturity))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out dateMaturity))
                    {
                        _regularLoanInfo.DateMaturity = dateMaturity.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtMaturityDate.Text = dateMaturity.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//-------------------------------
        //####################################################END LINKLABEL lnkChangeMaturityDate EVENTS###############################################

        //####################################################RADIOBUTTON rdbProductive EVENTS###############################################
        //event is raised when the control checked changed
        private void rdbProductiveCheckedChanged(object sender, EventArgs e)
        {
            _regularLoanInfo.IsProductive = this.rdbProductive.Checked;
        }//--------------------------------
        //####################################################END RADIOBUTTON rdbProductive EVENTS###############################################
            
        //####################################################RADIOBUTTON rdbStraight EVENTS###############################################
        //event is raised when the control checked changed
        private void rdbStraightCheckedChanged(object sender, EventArgs e)
        {
            _regularLoanInfo.IsStraightLoan = this.rdbStraight.Checked;
        }//-----------------------------------
        //####################################################END RADIOBUTTON rdbStraight EVENTS###############################################

        //####################################################BUTTON btnAddAdditions EVENTS###############################################
        //event is raised when the control is clicked
        private void btnAddAdditionalsClick(object sender, EventArgs e)
        {
            this.ShowAdditionals(false);
        }//-----------------------
        //####################################################END BUTTON btnAddAdditions EVENTS###############################################

        //####################################################BUTTON btnCharges EVENTS###############################################
        //event is raised when the control is clicked
        private void btnAddChargesClick(object sender, EventArgs e)
        {
            this.ShowAddCharges(false);
        }//-----------------------
        //####################################################END BUTTON btnCharges EVENTS###############################################

        //####################################################LISTVIEW lsvChargesAdditions EVENTS###############################################
        //event is raised when the control is double clicked
        private void lsvChargesAdditionsMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((this.lsvChargesAdditions.Items.Count > 0 && this.lsvChargesAdditions.FocusedItem != null) &&
                    this.lsvChargesAdditions.GetItemAt(e.X, e.Y) != null) && 
                    !String.IsNullOrEmpty(this.lsvChargesAdditions.GetItemAt(e.X, e.Y).SubItems[2].Text))
                {
                    Int64 loanId = 0;
                    Boolean isLoanCharge = false;

                    if (Int64.TryParse(this.lsvChargesAdditions.GetItemAt(e.X, e.Y).SubItems[2].Text, out loanId) &&
                        Boolean.TryParse(this.lsvChargesAdditions.GetItemAt(e.X, e.Y).SubItems[3].Text, out isLoanCharge))
                    {
                        if (isLoanCharge)
                        {
                            using (RegularLoanChargesUpdate frmUpdate = new RegularLoanChargesUpdate(_userInfo,
                                _loanManager.GetRegularLoanChargesInformation(_regularLoanInfo, loanId), _loanManager, _regularLoanInfo.RegularLoanSysId))
                            {
                                frmUpdate.ShowDialog(this);

                                if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                                {
                                    _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                                }
                            }
                        }
                        else
                        {
                            using (RegularLoanAdditionsUpdate frmUpdate = new RegularLoanAdditionsUpdate(_userInfo,
                                _loanManager.GetRegularLoanAdditionsInformation(_regularLoanInfo, loanId), _loanManager))
                            {
                                frmUpdate.ShowDialog(this);

                                if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                                {
                                    _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                                }
                            }
                        }
                    }
                }
            }
        }//-----------------------
        //####################################################END LISTVIEW lsvChargesAdditions EVENTS###############################################
                
        ////####################################################BUTTON btnCalculate EVENTS###############################################
        ////event is raised when the control is double clicked
        //protected void btnCalculateClick(object sender, EventArgs e)
        //{   
        //    this.dgvAmortizationList.Focus();                      

        //    if (this.ValidateControlPrepaidInterestTerm() && _regularLoanInfo.LoanTerms > 0)
        //    {
        //        this.dgvAmortizationList.DataSource = _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo,
        //            this.lblTotalInterestPayable, true, true);
        //    }
        //}//------------------------
        ////####################################################END BUTTON btnCalculate EVENTS###############################################

        //############################################DATAGRIDVIEW dgvAmortizationList EVENTS######################################
        //event is raised when the mouse is down
        private void dgvAmortizationListMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexAmortization = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexAmortization = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexAmortization = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexAmortization = -1;
                        _primaryIdAmortization = String.Empty;
                        break;
                }

                if (_rowIndexAmortization != -1)
                {
                    _primaryIdAmortization = dgvBase[_primaryIndexAmortization, _rowIndexAmortization].Value.ToString();
                }
            }
        }//--------------------------------

        //event is raised when the key is pressed
        private void dgvAmortizationListKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdAmortization = row.Cells[_primaryIndexAmortization].Value.ToString();
                    _primaryIndexAmortization = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//--------------------------

        //event is raised when the key is down
        private void dgvAmortizationListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//--------------------------

        //event is raised when the data source is changed
        private void dgvAmortizationListDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdAmortization = row.Cells[_primaryIndexAmortization].Value.ToString();
            } 
        }//-----------------------------

        //event is raised when the control is clicked
        protected virtual void dgvAmortizationListDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdAmortization))
            {
                using (LoanAmortizationUpdate frmUpdate = new LoanAmortizationUpdate(_userInfo,
                    _loanManager.GetDetailsAmortizationSchedule(_primaryIdAmortization, _regularLoanInfo), _loanManager, _regularLoanInfo.RegularLoanSysId))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        Int32 index = 0;

                        foreach (CommonExchange.RegularLoanAmortization list in _regularLoanInfo.LoanAmortizationList)
                        {
                            if (String.Equals(list.AmortizationId.ToString(), _primaryIdAmortization))
                            {

                                _regularLoanInfo.LoanAmortizationList.RemoveAt(index);

                                break;
                            }

                            index++;
                        }

                        _regularLoanInfo.LoanAmortizationList.Add(frmUpdate.RegularLoanAmortization);

                        Decimal totalLoan = 0;
                        
                        this.dgvAmortizationList.DataSource = _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo, 
                             this.lblTotalInterestPayable, false, false, true, ref totalLoan);
                    }
                }
            }
        }//-------------------------------
        //############################################END DATAGRIDVIEW dgvAmortizationList EVENTS######################################

        //############################################DATAGRIDVIEW dgvRegularLoanCollateral EVENTS######################################
        //event is raised when the mouse is down
        private void dgvRegularLoanCollateralMouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexRegularLoanCollateral = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexRegularLoanCollateral = hitTest.RowIndex;
                        this.dgvRegularLoanCollateral.ContextMenuStrip = this.cmsDeleteRegularLoanCollateral;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexRegularLoanCollateral = hitTest.RowIndex;
                        this.dgvRegularLoanCollateral.ContextMenuStrip = this.cmsDeleteRegularLoanCollateral;
                        break;
                    default:
                        _rowIndexRegularLoanCollateral = -1;
                        _primaryIdRegularLoanCollateral = String.Empty;
                        this.dgvRegularLoanCollateral.ContextMenuStrip = null;
                        break;
                }

                if (_rowIndexRegularLoanCollateral != -1)
                {
                    _primaryIdRegularLoanCollateral = dgvBase[_primaryIndexRegularLoanCollateral, _rowIndexRegularLoanCollateral].Value.ToString();
                }
            //}
        }//-------------------------------

        //event is raised when the control key is pressed
        private void dgvRegularLoanCollateralKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdRegularLoanCollateral = row.Cells[_primaryIndexRegularLoanCollateral].Value.ToString();
                    _primaryIndexRegularLoanCollateral = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//-----------------------------

        //event is raised when the control key is down
        private void dgvRegularLoanCollateralKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//------------------------------

        //event is raised when the data source is changed
        private void dgvRegularLoanCollateralDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdRegularLoanCollateral = row.Cells[_primaryIndexRegularLoanCollateral].Value.ToString();
            } 
        }//----------------------------
        //############################################END DATAGRIDVIEW dgvRegularLoanCollateral EVENTS######################################

        //############################################DATAGRIDVIEW dgvCoMaker EVENTS######################################
        //event is raised when the mouse is down
        private void dgvCoMakerMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexCoMaker = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexCoMaker = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexCoMaker = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexCoMaker = -1;
                        _primaryIdCoMaker = String.Empty;
                        break;
                }

                if (_rowIndexCoMaker != -1)
                {
                    _primaryIdCoMaker = dgvBase[_primaryIndexCoMaker, _rowIndexCoMaker].Value.ToString();
                }
            }
        }//---------------------------

        //event is raised whent the key is pressed
        private void dgvCoMakerKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdCoMaker = row.Cells[_primaryIndexCoMaker].Value.ToString();
                    _primaryIndexCoMaker = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//------------------------

        //event is raised when the key is down
        private void dgvCoMakerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//---------------------------

        //event is raised when the data source is chanted
        private void dgvCoMakerDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdCoMaker = row.Cells[_primaryIndexCoMaker].Value.ToString();
            } 
        }//---------------------------

        //evet is raised when the control is double clicked
        protected virtual void dgvCoMakerDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdCoMaker))
            {   
                using (CoMakerInformationUpdate frmUpdate = new CoMakerInformationUpdate(_userInfo, _regularLoanInfo,
                    _loanManager.GetDetailsRegularLoanCoMaker(_primaryIdCoMaker), _loanManager, _regularLoanInfo.MemberInfo.MemberSysId))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        this.dgvCoMaker.DataSource = _loanManager.GetSearchedRegularLoanCoMaker(_userInfo, _regularLoanInfo.RegularLoanSysId, false);
                    }
                }
            }
        }//-------------------------
        //############################################END DATAGRIDVIEW dgvCoMaker EVENTS######################################

        //####################################################LISTVIEW lsvLoanDocuments EVENTS###############################################
        //event is raised when the mouse is down
        private void lsvLoanDocumentsMouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right || e.Button == MouseButtons.Left) &&
                 (this.lsvLoanDocuments.Items.Count > 0 && this.lsvLoanDocuments.FocusedItem != null))
            {
                if (this.lsvLoanDocuments.SelectedItems.Count > 0)
                {
                    if (this.lsvLoanDocuments.GetItemAt(e.X, e.Y) != null && e.Button == MouseButtons.Right)
                    {
                        String strMsg = "Delete - [" + this.lsvLoanDocuments.GetItemAt(e.X, e.Y).Text + "].";

                        _loanDocumentOriginalName = this.lsvLoanDocuments.GetItemAt(e.X, e.Y).Text;

                        this.cmsLoanDocuments.Items[0].Text = strMsg;
                        this.cmsLoanDocuments.Show(this.lsvLoanDocuments, new Point(e.X, e.Y));
                    }
                }
            }
        }//------------------------------

        //event is raised when the item selection is changed
        private void lsvLoanDocumentsItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.lsvLoanDocuments.SelectedItems.Count > 0)
            {
                this.txtLoanDocumentRemarks.Enabled = true;

                this.txtLoanDocumentRemarks.Text = _loanManager.GetLoanDocumentInformation(this.lsvLoanDocuments.SelectedItems[0].Text);

                this.txtLoanDocumentRemarks.FindForm();
            }
        }//------------------------------

        //event is raised when the mouse is double clicked
        private void lsvLoanDocumentsMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process prcs = new Process();

                    prcs.StartInfo.FileName = _regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath) + this.lsvLoanDocuments.SelectedItems[0].Text;

                    prcs.Start();

                    _processListLoanDocument.Add(prcs);
                    _docomentOpenListLoanDocument.Add(this.lsvLoanDocuments.SelectedItems[0].Text);
                }
                catch
                {
                    ShellExecuteInfo sei = new ShellExecuteInfo();
                    sei.Size = Marshal.SizeOf(sei);
                    sei.Verb = "openas";
                    sei.File = this.lsvLoanDocuments.SelectedItems[0].Text;
                    sei.Show = SW_NORMAL;

                    if (!ShellExecuteEx(ref sei))
                    {
                        throw new System.ComponentModel.Win32Exception();
                    }
                }
            }
        }//-----------------------------
        //####################################################END LISTVIEW lsvLoanDocuments EVENTS###############################################

        //####################################################BUTTON btnShowDocument EVENTS###############################################
        //event is raised when the control is clicked
        private void btnShowDocumentClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (!_hasQueryLoanDocument)
            {
                _processListLoanDocument = new List<Process>();
                _docomentOpenListLoanDocument = new List<String>();

                if (!_regularLoanInfo.IsRecordLocked)
                {
                    this.btnAddDocument.Enabled = this.btnDropDownIcon.Enabled = true;
                }

                _hasQueryLoanDocument = true;

                this.btnShowDocument.Enabled = false;
            }

            _loanManager.InitializeLoanDocument(_userInfo, _regularLoanInfo);

            this.InitializeFileListView(_regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath), String.Empty);

            this.Cursor = Cursors.Arrow;
        }//--------------------------------
        //####################################################END BUTTON btnShowDocument EVENTS###############################################

        //####################################################BUTTON btnAddDocument EVENTS###############################################
        //event is raised when the control is clicked
        protected virtual void btnAddDocumentClick(object sender, EventArgs e)
        {
            OpenFileDialog imageChooser = new OpenFileDialog();
            imageChooser.InitialDirectory = "c:\\temp\\";
            imageChooser.Filter = "All files (*.*)|*.*";
            imageChooser.FilterIndex = 2;
            imageChooser.RestoreDirectory = true;

            if (imageChooser.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;

                if (!_loanManager.IsExistsSysIDRegularOriginalNameRegularLoanDocument(_userInfo, -1, _regularLoanInfo.RegularLoanSysId, imageChooser.FileName) &&
                    !File.Exists(_regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath) + Path.GetFileName(imageChooser.FileName)))
                {
                    _loanManager.InsertLoanDocument(_regularLoanInfo, Path.GetFileName(imageChooser.FileName),
                        BaseServices.ProcStatic.GetFileArrayBytes(imageChooser.FileName));

                    File.Copy(imageChooser.FileName, _regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath) + @"\" +
                        Path.GetFileName(imageChooser.FileName));

                    this.InitializeFileListView(_regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath), Path.GetFileName(imageChooser.FileName));

                    imageChooser.Dispose();
                }
                else
                {
                    MessageBox.Show("The document file name already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Cursor = Cursors.Arrow;
            }
        }//-------------------------
        //####################################################END BUTTON btnAddDocument EVENTS###############################################

        //####################################################BUTTON btnList EVENTS###############################################
        //event is raised when the control is clicked
        private void btnListClick(object sender, EventArgs e)
        {
            this.lsvLoanDocuments.View = View.List;
        }//-------------------------
        //####################################################END BUTTON btnList EVENTS###############################################

        //####################################################BUTTON btnPrintChargeAdditionAmortization EVENTS#########################################
        //event is raised when the control is clicked
        private void btnPrintChargeAdditionAmortizationClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //_loanManager.PrintLoanChargesAmortization(_userInfo, _regularLoanInfo, (DataTable)this.dgvAmortizationList.DataSource, false, this, null);

            _regularLoanInfo.MemberInfo = _memberInfo;

            _loanManager.PrintLoanChargesAmortization(_userInfo, _regularLoanInfo,
                _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo, true), false, this, null);

            this.Cursor = Cursors.Arrow;
        }//-------------------------
        //####################################################END BUTTON btnPrintChargeAdditionAmortization EVENTS#########################################

        //####################################################BUTTON btnPrintStatementOfAccount EVENTS#########################################
        //event is raised when the control is clicked
        private void btnPrintStatementOfAccountClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            _loanManager.PrintLoanStatementOfAccount(_userInfo, _regularLoanInfo, _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo, true));

            this.Cursor = Cursors.Arrow;
        }//------------------------
        //####################################################END BUTTON btnPrintStatementOfAccount EVENTS#########################################

        //####################################################BUTTON btnIcon EVENTS###############################################
        //event is raised when the is clicked
        private void btnIconClick(object sender, EventArgs e)
        {
            this.lsvLoanDocuments.View = View.LargeIcon;
        }//-------------------------
        //####################################################END BUTTON btnIcon EVENTS###############################################       

        //####################################################LINKLABEL lblDeleteLoanDocument EVENTS###############################################
        //event is raised when the is clicked
        private void lblDeleteLoanDocumentClick(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(_loanDocumentOriginalName))
                {
                    _loanManager.DeleteLoanDocument(_regularLoanInfo, _loanDocumentOriginalName, Application.StartupPath);

                    MessageBox.Show("The loan document has been successfully deleted.");

                    this.InitializeFileListView(_regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath), String.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting loan document./n/n" + ex.Message, "Error");
            }
        }//-------------------------
        //####################################################END LINKLABEL lblDeleteLoanDocument EVENTS###############################################

        //####################################################LINKLABEL lnkCreateRegularLoanCollateral EVENTS###############################################
        //event is raised when the is clicked
        private void lnkCreateRegularLoanCollateralLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegularLoanCollateralSearchOnTextBoxList frmSearch = new RegularLoanCollateralSearchOnTextBoxList(_userInfo, _memberInfo, _loanManager, _memberManager))
            {
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected && !String.IsNullOrEmpty(frmSearch.PrimaryId))
                {
                    CommonExchange.RegularLoanCollateral regularLoanCollateral = new CommonExchange.RegularLoanCollateral();

                    regularLoanCollateral.CollateralInfo = _loanManager.GetDetailsCollateralInformation(frmSearch.PrimaryId);
                    regularLoanCollateral.RegularLoanInfo = _regularLoanInfo;

                    _loanManager.InsertRegularLoanCollateralInformation(regularLoanCollateral);

                    this.dgvRegularLoanCollateral.DataSource = _loanManager.GetSearchedRegularLoanCollaterals(_userInfo, _regularLoanInfo.RegularLoanSysId, false);

                    _hasAddedUpdatedRegularLoanCollateral = true;
                }
            }
        }//-----------------------
        //####################################################END LINKLABEL lnkCreateRegularLoanCollateral EVENTS###############################################

        //####################################################LINKLABEL lblbDeleteRegularLoanCollateral EVENTS###############################################
        //event is raised when the is clicked
        private void lblDeleteRegularLoanCollateralClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdRegularLoanCollateral))
            {
                _loanManager.DeleteRegularLoanCollateralInformation(_primaryIdRegularLoanCollateral);

                this.dgvRegularLoanCollateral.DataSource = _loanManager.GetSearchedRegularLoanCollaterals(_userInfo, _regularLoanInfo.RegularLoanSysId, false);

                _hasAddedUpdatedRegularLoanCollateral = true;
            }
        }//----------------------
        //####################################################END LINKLABEL lblbDeleteRegularLoanCollateral EVENTS###############################################

        //####################################################LINKLABEL lnkCreateCoMaker EVENTS###############################################
        //event is raised when the is clicked
        private void lnkCreateCoMakerLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (CoMakerInformationCreate frmCreate = new CoMakerInformationCreate(_userInfo, _regularLoanInfo, _loanManager, _regularLoanInfo.MemberInfo.MemberSysId))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    this.dgvCoMaker.DataSource = _loanManager.GetSearchedRegularLoanCoMaker(_userInfo, _regularLoanInfo.RegularLoanSysId, false);
                }
            }
        }//---------------------
        //####################################################END LINKLABEL lnkCreateCoMaker EVENTS###############################################

        //####################################################LINKLABEL lnkReGenerateAccountNumber EVENTS###############################################
        //event is raised when the is clicked
        private void lnkReGenerateAccountNumberLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtAccountNumber.Text = _regularLoanInfo.AccountNo = _loanManager.GetRegularLoanAccountNumber(_userInfo,
                _regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId, _regularLoanInfo.DateApproved);
        }//-----------------------
        //####################################################END LINKLABEL lnkReGenerateAccountNumber EVENTS###############################################
        #endregion

        #region Programmer's Void Procedures   
        //this procedure will allow to add additionals
        private void ShowAdditionals(Boolean multipleInsert)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using (RegularLoanAdditionsCreate frmCreate = new RegularLoanAdditionsCreate(_userInfo, _loanManager))
                {
                    frmCreate.MultipleInsert = multipleInsert;
                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasCreated)
                    {
                        _regularLoanInfo.LoanAdditionsList.Add(frmCreate.RegularLoanAdditionsInfo);

                        _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                    }

                    multipleInsert = frmCreate.MultipleInsert;
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message + "\n\nError Loading Loan Additional Module", "Error Loading");
            }

            this.Cursor = Cursors.Arrow;

            if (multipleInsert)
            {
                this.ShowAdditionals(multipleInsert);
            }
        }//----------------------------

        //this procedure will allow to add charges
        private void ShowAddCharges(Boolean multipleInsert)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using (RegularLoanChargesCreate frmCreate = new RegularLoanChargesCreate(_userInfo, _loanManager, _regularLoanInfo.RegularLoanSysId))
                {
                    frmCreate.MultipleInsert = multipleInsert;
                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasCreated)
                    {
                        _regularLoanInfo.LoanChargesList.Add(frmCreate.RegularLoanChargesInfo);
                        
                        _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                    }

                    multipleInsert = frmCreate.MultipleInsert;
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message + "\n\nError Loading Loan Charges Module", "Error Loading");
            }

            this.Cursor = Cursors.Arrow;

            if (multipleInsert)
            {
                this.ShowAddCharges(multipleInsert);
            }
        }//-----------------------------

        //this procedure will Assing values in regular laon information controls
        public void AssingControlValuesRegularLoan()
        {
            //For Regular Loan Information (including charges and additionals)
            this.txtAccountNumber.Text = _regularLoanInfo.AccountNo;
            this.txtPrincipalAmount.Text = _regularLoanInfo.LoanAmount.ToString("N");

            _loanManager.InitializeLoanTypeCombobox(this.cboLoanType, _regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId);

            this.txtInterestRate.Text = _regularLoanInfo.InterestRate.ToString();
            this.txtNoOfPrepaidInterest.Text = _regularLoanInfo.NoPrepaidInterest.ToString();

            _loanManager.InitializePaymentIntervalComboBox(this.cboPaymentInterval, _regularLoanInfo.RepaymentScheduleInfo.RepaymentId);

            this.txtTerm.Text = _regularLoanInfo.LoanTerms.ToString();
            this.txtGracePeriod.Text = _regularLoanInfo.GracePeriod.ToString();

            this.rdbStraight.Checked = _regularLoanInfo.IsStraightLoan;
            this.rdbBasedUnpaidBalance.Checked = _regularLoanInfo.IsStraightLoan ? false : true;

            this.txtPurposeOfLoan.Text = _regularLoanInfo.PurposeOfLoan;

            this.rdbProductive.Checked = _regularLoanInfo.IsProductive;
            this.rdbProvident.Checked = _regularLoanInfo.IsProductive ? false : true;

            this.txtLoanRequirements.Text = _regularLoanInfo.LoanRequirements;

            DateTime dateApplied = DateTime.MinValue;

            this.txtDateApplied.Clear();

            if (DateTime.TryParse(_regularLoanInfo.DateApplied, out dateApplied))
            {
                this.txtDateApplied.Text = DateTime.Compare(dateApplied, DateTime.MinValue) == 0 ? String.Empty : dateApplied.ToLongDateString();
            }

            DateTime dateApproved = DateTime.MinValue;

            this.txtDateApproved.Clear();

            if (DateTime.TryParse(_regularLoanInfo.DateApproved, out dateApproved))
            {
                this.txtDateApproved.Text = DateTime.Compare(dateApproved, DateTime.MinValue) == 0 ? String.Empty : dateApproved.ToLongDateString();
            }

            this.txtApprovalEvaluation.Text = _regularLoanInfo.ApprovalEvaluation;

            DateTime releaseDate = DateTime.MinValue;

            this.txtFirstPaymentDate.Clear();

            if (DateTime.TryParse(_regularLoanInfo.DateFirstPayment, out releaseDate))
            {
                this.txtFirstPaymentDate.Text = DateTime.Compare(releaseDate, DateTime.MinValue) == 0 ? String.Empty : releaseDate.ToLongDateString();
            }

            DateTime maturityDate = DateTime.MinValue;

            this.txtMaturityDate.Clear();

            if (DateTime.TryParse(_regularLoanInfo.DateMaturity, out maturityDate))
            {
                this.txtMaturityDate.Text = DateTime.Compare(maturityDate, DateTime.MinValue) == 0 ? String.Empty : maturityDate.ToLongDateString();
            }

            this.txtPenaltyRate.Text = _regularLoanInfo.PenaltyRate.ToString();
            this.txtNoOfDefaultPayments.Text = _regularLoanInfo.NoDefaultPayment.ToString();
            this.txtRemarks.Text = _regularLoanInfo.Remarks;
            //End------------------------------
        }//-------------------------------

        //this procedure will set first payment date and maturity date
        private void SetFirtPaymentDate(DateTime approvedDate)
        {
            if (_regularLoanInfo.LoanTerms > 0)
            {
                _regularLoanInfo.DateFirstPayment = _loanManager.LastDayOfMonthFromDateTime(approvedDate.AddMonths(1)).ToShortDateString() + " 12:00:00 AM";
                this.txtFirstPaymentDate.Text = DateTime.Parse(_regularLoanInfo.DateFirstPayment).ToLongDateString();
                
                _regularLoanInfo.DateMaturity = _loanManager.CalculateMaturityDate(_regularLoanInfo).ToShortDateString() + " 12:00:00 AM";

                this.txtMaturityDate.Text = DateTime.Parse(_regularLoanInfo.DateMaturity).ToLongDateString();
            }

            Int16 noPrepaidInterest = 0;

            if (Int16.TryParse(this.txtNoOfPrepaidInterest.Text, out noPrepaidInterest))
            {
                _regularLoanInfo.NoPrepaidInterest = noPrepaidInterest;

                if (_regularLoanInfo.NoPrepaidInterest >= 0)
                {
                    this.lblPrePaidInterest.Text = (_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                        (_regularLoanInfo.NoPrepaidInterest)).ToString("N");


                    if (!String.IsNullOrEmpty(_regularLoanInfo.DateFirstPayment))
                    {
                        this.lblRealizedInterest.Text = (((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                           (_regularLoanInfo.NoPrepaidInterest)) / 12) * (12 - (DateTime.Parse(_regularLoanInfo.DateFirstPayment).Month - 1))).ToString("N");

                        this.lblDeferredInterest.Text = ((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                            (_regularLoanInfo.NoPrepaidInterest)) - (((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                            (_regularLoanInfo.NoPrepaidInterest)) / 12) * (12 - (DateTime.Parse(_regularLoanInfo.DateFirstPayment).Month - 1)))).ToString("N");
                    }
                }
                else
                {
                    this.lblPrePaidInterest.Text = this.lblDeferredInterest.Text =  this.lblRealizedInterest.Text = "0.00";
                }
            }           
        }//--------------------------------

        //this procedure will recalculate loan amortization
        private void ReCalculateLoanAmortization()
        {
            if (this.ValidateControlPrepaidInterestTerm() && _regularLoanInfo.LoanTerms > 0 && !_regularLoanInfo.IsRecordLocked)
            {
                Boolean isForCreate = String.IsNullOrEmpty(_regularLoanInfo.RegularLoanSysId) ? true : false;
                Decimal totalLoan = 0;
                
                this.dgvAmortizationList.DataSource = _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo,
                    this.lblTotalInterestPayable, isForCreate, !isForCreate, true, ref totalLoan);
            }
        }//-----------------------------

        //this procedure will initialize file list
        private void InitializeFileListView(String dirPath, String firstOriginalName)
        {
            this.lsvLoanDocuments.Items.Clear();

            IntPtr hImgSmall;    //the handle to the system image list
            IntPtr hImgLarge;    //the handle to the system image list
            String fName;        // 'the file name to get icon from

            SHFILEINFO shinfo = new SHFILEINFO();

            this.lsvLoanDocuments.SmallImageList = this.lsvLoanDocuments.LargeImageList = this.imgIcon;

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
                    this.lsvLoanDocuments.Items.Add(file.Name, _imageIndexLoanDocument++);

                    if (String.Equals(firstOriginalName, file.Name))
                    {
                        this.lsvLoanDocuments.Items[index].Selected = true;
                    }

                    index++;
                }
            }

            if (String.IsNullOrEmpty(firstOriginalName) && this.lsvLoanDocuments.Items.Count > 0)
            {
                this.lsvLoanDocuments.Items[0].Selected = true;
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

        #region Programmer's-Defined Functions
        //this procedure will validate term and prepaid interest control
        private Boolean ValidateControlPrepaidInterestTerm()
        {
            Boolean isValide = true;

            _errProvider.SetError(this.txtTerm, String.Empty);

            if (_regularLoanInfo.LoanTerms < _regularLoanInfo.NoPrepaidInterest)
            {
                _errProvider.SetError(this.txtTerm, "Loan term must be greater than loan number of preapaid interest.");
                _errProvider.SetIconAlignment(this.txtTerm, ErrorIconAlignment.MiddleLeft);

                isValide = false;
            }

            return isValide;
        }//----------------------
        
        //this procedure will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.tabAmortization, String.Empty);
            _errProvider.SetError(this.txtAccountNumber, String.Empty);
            _errProvider.SetError(this.txtPrincipalAmount, String.Empty);
            _errProvider.SetError(this.txtPurposeOfLoan, String.Empty);
            _errProvider.SetError(this.cboLoanType, String.Empty);
            _errProvider.SetError(this.txtTerm, String.Empty);
            _errProvider.SetError(this.txtNoOfPrepaidInterest, String.Empty);
            _errProvider.SetError(this.txtInterestRate, String.Empty);
            _errProvider.SetError(this.txtGracePeriod, String.Empty);
            _errProvider.SetError(this.txtDateApplied, String.Empty);
            _errProvider.SetError(this.txtDateApproved, String.Empty);
            _errProvider.SetError(this.txtFirstPaymentDate, String.Empty);
            _errProvider.SetError(this.txtMaturityDate, String.Empty);
            _errProvider.SetError(this.txtPenaltyRate, String.Empty);
            _errProvider.SetError(this.txtNoOfDefaultPayments, String.Empty);

            if (String.IsNullOrEmpty(_regularLoanInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.tabAmortization, "You must select a member information.");
                _errProvider.SetIconAlignment(this.tabAmortization, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanInfo.AccountNo))
            {
                _errProvider.SetError(this.txtAccountNumber, "You must input an account number.");
                _errProvider.SetIconAlignment(this.txtAccountNumber, ErrorIconAlignment.MiddleLeft);

                this.txtAccountNumber.Focus();

                isValid = false;
            }
            else if ((_loanManager.IsExistsAccountNumberRegularLoanInformation(_userInfo, _regularLoanInfo.RegularLoanSysId, _regularLoanInfo.AccountNo) &&
                String.IsNullOrEmpty(_regularLoanInfo.RegularLoanSysId)))
            {
                _errProvider.SetError(this.txtAccountNumber, "Account number already exist.");
                _errProvider.SetIconAlignment(this.txtAccountNumber, ErrorIconAlignment.MiddleLeft);

                this.txtAccountNumber.Focus();

                isValid = false;

                this.lnkReGenerateAccountNumber.Enabled = true;
            }

            if (_regularLoanInfo.LoanAmount <= 0)
            {
                _errProvider.SetError(this.txtPrincipalAmount, "Principal amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtPrincipalAmount, ErrorIconAlignment.MiddleLeft);

                this.txtPrincipalAmount.Focus();

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanInfo.PurposeOfLoan))
            {
                _errProvider.SetError(this.txtPurposeOfLoan, "You must input purpose of loan information.");
                _errProvider.SetIconAlignment(this.txtPurposeOfLoan, ErrorIconAlignment.MiddleLeft);

                this.txtPurposeOfLoan.Focus();

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId))
            {
                _errProvider.SetError(this.cboLoanType, "You must select a loan type information");
                _errProvider.SetIconAlignment(this.cboLoanType, ErrorIconAlignment.MiddleLeft);

                this.cboLoanType.Focus();

                isValid = false;
            }

            if (_regularLoanInfo.LoanTerms <= 0)
            {
                _errProvider.SetError(this.txtTerm, "Loan term must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtTerm, ErrorIconAlignment.MiddleLeft);

                this.txtTerm.Focus();

                isValid = false;
            }

            if (_regularLoanInfo.NoPrepaidInterest < 0)
            {
                _errProvider.SetError(this.txtNoOfPrepaidInterest, "No of prepaid interest must be greater or equal to zero.");
                _errProvider.SetIconAlignment(this.txtNoOfPrepaidInterest, ErrorIconAlignment.MiddleLeft);

                this.txtNoOfPrepaidInterest.Focus();

                isValid = false;
            }

            if (_regularLoanInfo.NoPrepaidInterest > _regularLoanInfo.LoanTerms)
            {
                _errProvider.SetError(this.txtNoOfPrepaidInterest, "No of prepaid interest must be lesser than loan terms");
                _errProvider.SetIconAlignment(this.txtNoOfPrepaidInterest, ErrorIconAlignment.MiddleLeft);

                this.txtNoOfPrepaidInterest.Focus();

                isValid = false;
            }

            if (_regularLoanInfo.InterestRate <= 0)
            {
                _errProvider.SetError(this.txtInterestRate, "Interest rate must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtInterestRate, ErrorIconAlignment.MiddleLeft);

                this.txtInterestRate.Focus();

                isValid = false;
            }

            if (_regularLoanInfo.GracePeriod <= 0)
            {
                _errProvider.SetError(this.txtGracePeriod, "Grace period must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtGracePeriod, ErrorIconAlignment.MiddleLeft);

                this.txtGracePeriod.Focus();

                isValid = false;
            }

            if (!this.IsGracePeriodValid(_regularLoanInfo.GracePeriod, _regularLoanInfo.RepaymentScheduleInfo.RepaymentNo))
            {
                _errProvider.SetError(this.txtGracePeriod, "Grace period is not valid");
                _errProvider.SetIconAlignment(this.txtGracePeriod, ErrorIconAlignment.MiddleLeft);

                this.txtGracePeriod.Focus();

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanInfo.DateApplied))
            {
                _errProvider.SetError(this.txtDateApplied, "You must select a date applied.");
                _errProvider.SetIconAlignment(this.txtDateApplied, ErrorIconAlignment.MiddleLeft);

                this.txtDateApplied.Focus();

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanInfo.DateApproved))
            {
                _errProvider.SetError(this.txtDateApproved, "You must select a date approved.");
                _errProvider.SetIconAlignment(this.txtDateApproved, ErrorIconAlignment.MiddleLeft);

                this.txtDateApproved.Focus();

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanInfo.DateFirstPayment))
            {
                _errProvider.SetError(this.txtFirstPaymentDate, "You must select a first payment date.");
                _errProvider.SetIconAlignment(this.txtFirstPaymentDate, ErrorIconAlignment.MiddleLeft);

                this.txtFirstPaymentDate.Focus();

                isValid = false;
            }
            else if (DateTime.Compare(DateTime.Parse(_regularLoanInfo.DateApproved), DateTime.Parse(_regularLoanInfo.DateFirstPayment)) >= 0)
            {
                _errProvider.SetError(this.txtFirstPaymentDate, "First Payment must be greater than approved date.");
                _errProvider.SetIconAlignment(this.txtFirstPaymentDate, ErrorIconAlignment.MiddleLeft);

                this.txtFirstPaymentDate.Focus();

                isValid = false;
            }
            //else if (DateTime.Compare(DateTime.Parse(_regularLoanInfo.DateApproved).AddDays(_regularLoanInfo.GracePeriod), 
            //    DateTime.Parse(_regularLoanInfo.DateFirstPayment)) > 0)
            //{
            //    _errProvider.SetError(this.txtGracePeriod, "Invalid grace period.");
            //    _errProvider.SetIconAlignment(this.txtGracePeriod, ErrorIconAlignment.MiddleLeft);

            //    this.txtGracePeriod.Focus();

            //    isValid = false;
            //}
            
            if (String.IsNullOrEmpty(_regularLoanInfo.DateMaturity))
            {
                _errProvider.SetError(this.txtMaturityDate, "You must select a maturity date.");
                _errProvider.SetIconAlignment(this.txtMaturityDate, ErrorIconAlignment.MiddleLeft);

                this.txtMaturityDate.Focus();

                isValid = false;
            }

            if (_regularLoanInfo.PenaltyRate <= 0)
            {
                _errProvider.SetError(this.txtPenaltyRate, "Penalty rate must be greater than zero");
                _errProvider.SetIconAlignment(this.txtPenaltyRate, ErrorIconAlignment.MiddleLeft);

                this.txtPenaltyRate.Focus();

                isValid = false;
            }

            if (_regularLoanInfo.NoDefaultPayment <= 0)
            {
                _errProvider.SetError(this.txtNoOfDefaultPayments, "No of default payment be greater than zero");
                _errProvider.SetIconAlignment(this.txtNoOfDefaultPayments, ErrorIconAlignment.MiddleLeft);

                this.txtNoOfDefaultPayments.Focus();

                isValid = false;
            }
                        
            return isValid;
        }//----------------------

        //this function will check if the grace period is valid
        private Boolean IsGracePeriodValid(Int16 gracePeriod, Int16 rePaymentNumber)
        {
            if (rePaymentNumber == 1 && (gracePeriod == 1))
            {
                return true;
            }
            else if (rePaymentNumber == 2 && (gracePeriod >= 1 && gracePeriod < 7))
            {
                return true;
            }
            else if (rePaymentNumber == 3 && (gracePeriod >= 1 && gracePeriod < 14))
            {
                return true;
            }
            else if (rePaymentNumber == 4 && (gracePeriod >= 1 && gracePeriod < 29))
            {
                return true;
            }
            else if (rePaymentNumber == 5 && (gracePeriod >= 1 && gracePeriod < 40))
            {
                return true;
            }
            else if (rePaymentNumber == 6 && (gracePeriod >= 1 && gracePeriod < 90))
            {
                return true;
            }
            else if (rePaymentNumber == 7 && (gracePeriod >= 1 && gracePeriod < 365))
            {
                return true;
            }

            return false;
        }//-------------------------
        #endregion
    }
}
