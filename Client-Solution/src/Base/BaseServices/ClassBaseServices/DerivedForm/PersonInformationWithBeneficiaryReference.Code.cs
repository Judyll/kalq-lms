using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Threading;

namespace BaseServices
{
    partial class PersonInformationWithBeneficiaryReference
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

        #region Class Properties Decleration
        private Boolean _hasRecorded = false;
        public Boolean HasRecorded
        {
            get { return _hasRecorded; }
        }
        #endregion

        #region Class Data Member Decleration
        private List<Process> _processList;
        private List<String> _docomentOpenList;

        private Int32 _imageIndex = 0;

        private const uint SW_NORMAL = 1;

        private Boolean _hasQueryPersonDocument = false;
        protected Boolean _hasAddedRelationshipReference = false;
        protected Boolean _hasUpdateRelationshipReference = false;

        private Int32 _primaryIndexBeneficiary = 0;
        private Int32 _primaryIndexReference = 0;
        private Int32 _rowIndexBeneficiary = -1;
        private Int32 _rowIndexReference = -1;
        private String _primaryIdBeneficiary = String.Empty;
        private String _primaryIdReference = String.Empty;
        private String _personDocumentOriginalName = String.Empty;
        #endregion

        #region Class Constructors
        public PersonInformationWithBeneficiaryReference()
        {
            this.InitializeComponent();
        }

        public PersonInformationWithBeneficiaryReference(CommonExchange.SysAccess userInfo, BaseServicesLogic baseMananager)
            : base(userInfo, baseMananager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;

            
            this.lnkCreateBeneficiary.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateBeneficiaryLinkClicked);
            this.dgvPersonBenificiaries.MouseDown += new MouseEventHandler(dgvPersonBenificiariesMouseDown);
            this.dgvPersonBenificiaries.KeyPress += new KeyPressEventHandler(dgvPersonBenificiariesKeyPress);
            this.dgvPersonBenificiaries.KeyDown += new KeyEventHandler(dgvPersonBenificiariesKeyDown);
            this.dgvPersonBenificiaries.DataSourceChanged += new EventHandler(dgvPersonBenificiariesDataSourceChanged);
            this.dgvPersonBenificiaries.SelectionChanged += new EventHandler(dgvPersonBenificiariesSelectionChanged);
            this.dgvPersonBenificiaries.DoubleClick += new EventHandler(dgvPersonBenificiariesDoubleClick);
            this.lnkCreateReference.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateReferenceLinkClicked);
            this.dgvPersonReference.MouseDown += new MouseEventHandler(dgvPersonReferenceMouseDown);
            this.dgvPersonReference.KeyPress += new KeyPressEventHandler(dgvPersonReferenceKeyPress);
            this.dgvPersonReference.KeyDown += new KeyEventHandler(dgvPersonReferenceKeyDown);
            this.dgvPersonReference.DataSourceChanged += new EventHandler(dgvPersonReferenceDataSourceChanged);
            this.dgvPersonReference.SelectionChanged += new EventHandler(dgvPersonReferenceSelectionChanged);
            this.dgvPersonReference.DoubleClick += new EventHandler(dgvPersonReferenceDoubleClick);
            this.btnShowDocument.Click += new EventHandler(btnShowDocumentClick);
            this.btnAddDocument.Click += new EventHandler(btnAddDocumentClick);
            this.btnIcon.Click += new EventHandler(btnIconClick);
            this.btnList.Click += new EventHandler(btnListClick);
            this.txtPersonDocumentRemarks.Validated += new EventHandler(txtPersonDocumentRemarksValidated);
            this.lsvFileList.MouseDown += new MouseEventHandler(lsvFileListMouseDown);
            this.lsvFileList.MouseDoubleClick += new MouseEventHandler(lsvFileListMouseDoubleClick);
            this.lsvFileList.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(lsvFileListItemSelectionChanged);
            this.pbxBeneficiaries.Click += new EventHandler(pbxBeneficiariesClick);
            this.pbxBeneficiaries.MouseEnter += new EventHandler(pbxBeneficiariesMouseEnter);
            this.pbxBeneficiaries.MouseLeave += new EventHandler(pbxBeneficiariesMouseLeave);
            this.pbxReferences.Click += new EventHandler(pbxReferencesClick);
            this.pbxReferences.MouseEnter += new EventHandler(pbxReferencesMouseEnter);
            this.pbxReferences.MouseLeave += new EventHandler(pbxReferencesMouseLeave);
            this.pbxPersonalDocument.Click += new EventHandler(pbxPersonalDocumentClick);
            this.pbxPersonalDocument.MouseEnter += new EventHandler(pbxPersonalDocumentMouseEnter);
            this.pbxPersonalDocument.MouseLeave += new EventHandler(pbxPersonalDocumentMouseLeave);
            this.lblDeletePersonDocument.Click += new EventHandler(lblDeletePersonDocumentClick);
           
        }      
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS PersonInformationCreateUpdate EVENTS###############################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            base.ClassLoad(sender, e);

            //base.AssingControlsValue();

            _baseServiceManager.InitializePersonBeneficiaryDataGridView(this.dgvPersonBenificiaries, 
                _personInfo.PersonBeneficiaryList, this.lblBeneficiariesStatus);
            _baseServiceManager.InitializePersonReferenceDataGridView(this.dgvPersonReference, _personInfo.PersonReferenceList);

            ProcStatic.SetDataGridViewColumns(this.dgvPersonBenificiaries, false);
            ProcStatic.SetDataGridViewColumns(this.dgvPersonReference, false);
        }//----------------------

        //event is raised when the class is clossing
        protected override void ClassClosing(object sender, FormClosingEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (_hasQueryPersonDocument)
            {
                _baseServiceManager.KillProcess(_processList);

                Thread.Sleep(500);

                _baseServiceManager.InsertUpdateDeletePersonDocumentInformation(_userInfo, _personInfo, _personInfo.PersonDocumentsFolder(Application.StartupPath));
            }

            base.ClassClosing(sender, e);

            this.Cursor = Cursors.Arrow;
        }//------------------------
        //####################################################END CLASS PersonInformationCreateUpdate EVENTS###############################################

        //####################################################LINKLABEL lnkCreateBeneficiary EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkCreateBeneficiaryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (PersonBeneficiariesCreate frmCreate = new PersonBeneficiariesCreate(_userInfo, _baseServiceManager,
                _baseServiceManager.GetPersonRelationshipExcludeListStringFormat(_personInfo.PersonBeneficiaryList, _personInfo.PersonReferenceList,
                _personInfo.PersonSysId)))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasAdded)
                {
                    _personInfo.PersonBeneficiaryList.Add(frmCreate.PersonBeneficiaryInfo);

                    _baseServiceManager.InitializePersonBeneficiaryDataGridView(this.dgvPersonBenificiaries,
                        _personInfo.PersonBeneficiaryList, this.lblBeneficiariesStatus);

                    _hasAddedRelationshipReference = true;
                }
            }
        }//-----------------------
        //####################################################END LINKLABEL lnkCreateBeneficiary EVENTS###############################################

        //####################################################DATAGRIDVIEW dgvPersonBeneficiary EVENTS####################################################
        //event is raised when the mouse is down
        private void dgvPersonBenificiariesMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexBeneficiary = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexBeneficiary = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexBeneficiary = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexBeneficiary = -1;
                        _primaryIdBeneficiary = String.Empty;
                        break;
                }

                if (_rowIndexBeneficiary != -1)
                {
                    _primaryIdBeneficiary = dgvBase[_primaryIndexBeneficiary, _rowIndexBeneficiary].Value.ToString();
                }
            }
        }//--------------------

        //event is raised when the key is presssed
        private void dgvPersonBenificiariesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdBeneficiary = row.Cells[_primaryIndexBeneficiary].Value.ToString();
                    _primaryIndexBeneficiary = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//----------------------

        //event is raised when the key is pressed
        private void dgvPersonBenificiariesKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//-------------------------

        //event is raised when the data source is changed
        private void dgvPersonBenificiariesDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdBeneficiary = dgvBase[_primaryIndexBeneficiary, 0].Value.ToString();
            }
            else
            {
                _primaryIdBeneficiary = String.Empty;
            }
        }//----------------------------

        //event is raised when the selection is changed
        private void dgvPersonBenificiariesSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdBeneficiary = row.Cells[_primaryIndexBeneficiary].Value.ToString();
            }
        }//-------------------

        //event is raised when the control is double clicked
        private void dgvPersonBenificiariesDoubleClick(object sender, EventArgs e)
        {
            if (_rowIndexBeneficiary != -1)
            {
                using (PersonBeneficiariesUpdate frmUpdate = new PersonBeneficiariesUpdate(_userInfo,
                    _baseServiceManager.GetDetailsPersonBeneficiary(_personInfo.PersonBeneficiaryList, _primaryIdBeneficiary),
                    _baseServiceManager, _personInfo.PersonSysId))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        _baseServiceManager.UpdatePersonBeneficiaryInformation(_personInfo.PersonBeneficiaryList, frmUpdate.PersonBeneficiaryInfo);

                        _baseServiceManager.InitializePersonBeneficiaryDataGridView(this.dgvPersonBenificiaries,
                            _personInfo.PersonBeneficiaryList, this.lblBeneficiariesStatus);

                        _hasUpdateRelationshipReference = true;
                    }
                }
            }
        }//--------------------
        //####################################################END DATAGRIDVIEW dgvPersonBeneficiary EVENTS####################################################

        //####################################################LINKLABEL lnkCreateReference EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkCreateReferenceLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (PersonReferenceCreate frmCreate = new PersonReferenceCreate(_userInfo, _baseServiceManager,
                _baseServiceManager.GetPersonRelationshipExcludeListStringFormat(_personInfo.PersonBeneficiaryList, _personInfo.PersonReferenceList,
                _personInfo.PersonSysId)))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasAdded)
                {
                    _personInfo.PersonReferenceList.Add(frmCreate.PersonReferenceInfo);

                    _baseServiceManager.InitializePersonReferenceDataGridView(this.dgvPersonReference, _personInfo.PersonReferenceList);

                    _hasAddedRelationshipReference = true;
                }
            }
        }//-----------------------
        //####################################################END LINKLABEL lnkCreateReference EVENTS###############################################

        //####################################################DATAGRIDVIEW dgvPersonReference EVENTS###############################################
        //event is raised when the mouse is down
        private void dgvPersonReferenceMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexReference = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexReference = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexReference = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexReference = -1;
                        _primaryIdReference = String.Empty;
                        break;
                }

                if (_rowIndexBeneficiary != -1)
                {
                    _primaryIdReference = dgvBase[_primaryIndexReference, _rowIndexReference].Value.ToString();
                }
            }
        }//---------------------

        //event is raised when the key is pressed
        private void dgvPersonReferenceKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdReference = row.Cells[_primaryIndexReference].Value.ToString();
                    _primaryIndexReference = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//----------------------

        //envet is raised when the key is down
        private void dgvPersonReferenceKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//----------------------

        //event is raised when the data source is changed
        private void dgvPersonReferenceDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdReference = dgvBase[_primaryIndexReference, 0].Value.ToString();
            }
            else
            {
                _primaryIdReference = String.Empty;
            }
        }//---------------------- 

        //event is raised when the selection is changed
        private void dgvPersonReferenceSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdReference = row.Cells[_primaryIndexReference].Value.ToString();
            }
        }//----------------------

        //event is raised when the control is double clicked
        private void dgvPersonReferenceDoubleClick(object sender, EventArgs e)
        {
            if (_rowIndexReference != -1)
            {
                using (PersonReferenceUpdate frmUpdate = new PersonReferenceUpdate(_userInfo,
                    _baseServiceManager.GetDetailsPersonReference(_personInfo.PersonReferenceList, _primaryIdReference),
                    _baseServiceManager, _personInfo.PersonSysId))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasDeleted)
                    {
                        _baseServiceManager.InitializePersonReferenceDataGridView(this.dgvPersonReference, _personInfo.PersonReferenceList);

                        _hasUpdateRelationshipReference = true;
                    }
                }
            }
        }//-----------------------
        //####################################################END DATAGRIDVIEW dgvPersonReference EVENTS###############################################

        //####################################################BUTTON btnShowDocument EVENTS###############################################
        //event is raised when the control is clicked
        private void btnShowDocumentClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (!_hasQueryPersonDocument)
            {
                _processList = new List<Process>();
                _docomentOpenList = new List<String>();

                this.btnAddDocument.Enabled = this.btnDropDownIcon.Enabled = true;
                _hasQueryPersonDocument = true;

                this.btnShowDocument.Enabled = false;
            }

            _baseServiceManager.InitializePersonDocument(_userInfo, _personInfo, false);

            this.InitializeFileListView(_personInfo.PersonDocumentsFolder(Application.StartupPath), String.Empty);

            this.Cursor = Cursors.Arrow;
        }//-----------------------
        //####################################################END BUTTON btnShowDocument EVENTS###############################################

        //####################################################BUTTON btnAddDocument EVENTS###############################################
        //event is raised when the is clicked
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

                if (!_baseServiceManager.IsExistsSysIDPersonOriginalNamePersonDocument(_userInfo, _personInfo.PersonSysId, imageChooser.FileName, -1) &&
                    !File.Exists(_personInfo.PersonDocumentsFolder(Application.StartupPath) + Path.GetFileName(imageChooser.FileName)))
                {
                    _baseServiceManager.InsertPersonDocument(_personInfo, Path.GetFileName(imageChooser.FileName),
                        ProcStatic.GetFileArrayBytes(imageChooser.FileName), false);

                    File.Copy(imageChooser.FileName, _personInfo.PersonDocumentsFolder(Application.StartupPath) + @"\" +
                        Path.GetFileName(imageChooser.FileName));

                    this.InitializeFileListView(_personInfo.PersonDocumentsFolder(Application.StartupPath), Path.GetFileName(imageChooser.FileName));

                    imageChooser.Dispose();
                }
                else
                {
                    MessageBox.Show("The document file name already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Cursor = Cursors.Arrow;
            }
        }//--------------------------
        //####################################################END BUTTON btnAddDocument EVENTS###############################################

        //####################################################BUTTON btnList EVENTS###############################################
        //event is raised when the control is clicked
        private void btnListClick(object sender, EventArgs e)
        {
            this.lsvFileList.View = View.List;
        }//-------------------------
        //####################################################END BUTTON btnList EVENTS###############################################

        //####################################################BUTTON btnIcon EVENTS###############################################
        //event is raised when the is clicked
        private void btnIconClick(object sender, EventArgs e)
        {
            this.lsvFileList.View = View.LargeIcon;
        }//-------------------------
        //####################################################END BUTTON btnIcon EVENTS###############################################

        //####################################################TEXTBOX txtPersonDocument EVENTS###############################################
        //event is raised when the is clicked
        void txtPersonDocumentRemarksValidated(object sender, EventArgs e)
        {
            if (this.lsvFileList.SelectedItems.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                _baseServiceManager.InsertUpdatePersonDocumentInformationInformation(this.lsvFileList.SelectedItems[0].Text,
                    ProcStatic.TrimStartEndString(this.txtPersonDocumentRemarks.Text));

                this.Cursor = Cursors.Arrow;
            }
        }//---------------------------
        //####################################################END TEXTBOX txtPersonDocument EVENTS###############################################

        //####################################################LISTVIEW lsvFileList EVENTS###############################################
        //event is raised when the mouse is down
        private void lsvFileListMouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right || e.Button == MouseButtons.Left) &&
                (this.lsvFileList.Items.Count > 0 && this.lsvFileList.FocusedItem != null))
            {
                if (this.lsvFileList.SelectedItems.Count > 0)
                {
                    if (this.lsvFileList.GetItemAt(e.X, e.Y) != null && e.Button == MouseButtons.Right)
                    {
                        String strMsg = "Delete - [" + this.lsvFileList.GetItemAt(e.X, e.Y).Text + "].";

                        _personDocumentOriginalName = this.lsvFileList.GetItemAt(e.X, e.Y).Text;

                        this.cmsPersonDocuments.Items[0].Text = strMsg;
                        this.cmsPersonDocuments.Show(this.lsvFileList, new Point(e.X, e.Y));

                        this.cmsPersonDocuments.Items[0].Enabled = _baseServiceManager.IsPersonDocumentPrimaryImage(_personDocumentOriginalName) ? false : true;
                    }
                }
            }
        }//----------------------

        //event is raised when the mouse is double clicked
        private void lsvFileListMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process prcs = new Process();

                    prcs.StartInfo.FileName = _personInfo.PersonDocumentsFolder(Application.StartupPath) + this.lsvFileList.SelectedItems[0].Text;

                    prcs.Start();

                    _processList.Add(prcs);
                    _docomentOpenList.Add(this.lsvFileList.SelectedItems[0].Text);
                }
                catch
                {
                    ShellExecuteInfo sei = new ShellExecuteInfo();
                    sei.Size = Marshal.SizeOf(sei);
                    sei.Verb = "openas";
                    sei.File = this.lsvFileList.SelectedItems[0].Text;
                    sei.Show = SW_NORMAL;

                    if (!ShellExecuteEx(ref sei))
                    {
                        throw new System.ComponentModel.Win32Exception();
                    }
                }
            }
        }//-------------------------

        //event is raised when the item selection is changed
        private void lsvFileListItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.lsvFileList.SelectedItems.Count > 0)
            {
                this.txtPersonDocumentRemarks.Enabled = true;

                this.txtPersonDocumentRemarks.Text = _baseServiceManager.GetPersonDocumentInformation(this.lsvFileList.SelectedItems[0].Text);

                this.txtPersonDocumentRemarks.FindForm();
            }
        }
        //####################################################END LISTVIEW lsvFileList EVENTS###############################################

        //####################################################PICTUREBOX pbxPersonalDocument EVENTS###############################################
        //event is raised when the control is clicked
        private void pbxPersonalDocumentClick(object sender, EventArgs e)
        {
            this.tabCntPerson.SelectedIndex = 3;
        }//---------------------------

        //event is raised when the mouse leaves
        private void pbxPersonalDocumentMouseEnter(object sender, EventArgs e)
        {
            this.pbxPersonalDocument.Image = global::BaseServices.Properties.Resources.Personal_Documents_hover;
        }//-------------------------

        //event is raised when the mouse leaves
        private void pbxPersonalDocumentMouseLeave(object sender, EventArgs e)
        {
            this.pbxPersonalDocument.Image = global::BaseServices.Properties.Resources.Personal_Documents;
        }//-------------------------
        //####################################################END PICTUREBOX pbxPersonalDocument EVENTS###############################################

        //####################################################PICTUREBOX pbxReferences EVENTS###############################################
        //event is raised when the control is clicked
        private void pbxReferencesClick(object sender, EventArgs e)
        {
            this.tabCntPerson.SelectedIndex = 2;
        }//-----------------------------

        //event is raised when the mouse enters
        private void pbxReferencesMouseEnter(object sender, EventArgs e)
        {
            this.pbxReferences.Image = global::BaseServices.Properties.Resources.References_hover;
        }//---------------------------

        //event is raised when the mouse leaves
        private void pbxReferencesMouseLeave(object sender, EventArgs e)
        {
            this.pbxReferences.Image = global::BaseServices.Properties.Resources.References;
        }//----------------------
        //####################################################END PICTUREBOX pbxReferences EVENTS###############################################

        //####################################################PICTUREBOX pbxBeneficiaries EVENTS###############################################
        //event is raised when the control is clicked
        private void pbxBeneficiariesClick(object sender, EventArgs e)
        {
            this.tabCntPerson.SelectedIndex = 1;
        }//----------------------------

        //event is raised when the mouses enters
        private void pbxBeneficiariesMouseEnter(object sender, EventArgs e)
        {
            this.pbxBeneficiaries.Image = global::BaseServices.Properties.Resources.Beneficiaries_hover;
        }//---------------------------

        //event is raised when the mouse leaves
        private void pbxBeneficiariesMouseLeave(object sender, EventArgs e)
        {
            this.pbxBeneficiaries.Image = global::BaseServices.Properties.Resources.Beneficiaries;
        }//-----------------------------
        //####################################################END PICTUREBOX pbxBeneficiaries EVENTS###############################################

        //####################################################LABEL lblDeletePersonDocument EVENTS###############################################
        //event is raised when the control is clicked
        private void lblDeletePersonDocumentClick(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(_personDocumentOriginalName))
                {
                    _baseServiceManager.DeletePersonDocument(_personInfo, _personDocumentOriginalName, Application.StartupPath);

                    MessageBox.Show("The person document has been successfully deleted.");

                    this.InitializeFileListView(_personInfo.PersonDocumentsFolder(Application.StartupPath), String.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting person document./n/n" + ex.Message, "Error");
            }
        }//-------------------
        //####################################################END LABEL lblDeletePersonDocument EVENTS###############################################
        #endregion

        #region Programmers-Defined Void Procedures
        //this procedure will initialize file list
        private void InitializeFileListView(String dirPath, String firstOriginalName)
        {
            this.lsvFileList.Items.Clear();

            IntPtr hImgSmall;    //the handle to the system image list
            IntPtr hImgLarge;    //the handle to the system image list
            String fName;        // 'the file name to get icon from

            SHFILEINFO shinfo = new SHFILEINFO();

            this.lsvFileList.SmallImageList = this.lsvFileList.LargeImageList = this.imgIcon;

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
                    this.lsvFileList.Items.Add(file.Name, _imageIndex++);

                    if (String.Equals(firstOriginalName, file.Name))
                    {
                        this.lsvFileList.Items[index].Selected = true;
                    }

                    index++;
                }
            }

            if (String.IsNullOrEmpty(firstOriginalName) && this.lsvFileList.Items.Count > 0)
            {
                this.lsvFileList.Items[0].Selected = true;
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
    }
}
