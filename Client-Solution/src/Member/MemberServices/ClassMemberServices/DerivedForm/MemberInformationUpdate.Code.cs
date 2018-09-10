using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class MemberInformationUpdate
    {
        #region Class Data Member Decleration
        private CommonExchange.Member _tempMemberInfo;
        private CommonExchange.ShareCapitalInformation _sharedCapitalInfo;
        private CommonExchange.InHouseHospitalizationInformation _hospitalizationInfo;
        private LoanLogic _loanManager;

        private Int32 _primaryIndexRegularLoad = 0;
        private Int32 _rowIndexRegularLoan = -1;
        private String _primaryIdRegularLoan = String.Empty;

        private Int32 _primaryIndexRegularLoadCompleted = 0;
        private Int32 _rowIndexRegularLoanCompleted = -1;
        private String _primaryIdRegularLoanCompleted = String.Empty;

        private Int32 _primaryIndexHospitalizationDebit = 0;
        private Int32 _rowIndexHospitalizationDebit = -1;
        private String _primaryIdHospitalizationDebit = String.Empty;
         
        private Int32 _primaryIndexShareCapitalCredit = 0;
        private Int32 _rowIndexShareCapitalCredit = -1;
        private String _primaryIdShareCapitalCredit = String.Empty;

        private Int32 _primaryIndexMembersEquity = 0;
        private Int32 _rowIndexMembersEquity = -1;
        private String _primaryIdMembersEquity = String.Empty;

        private Decimal _totalShareCapitalContribution = 0;
        private Decimal _totalMembersEquity = 0;
        private Decimal _totalHospitalizationContribution = 0;

        private Boolean _hasEnterClossingEvent = false;
        #endregion

        #region Class Properties Declaration
        private Boolean _hasUpDated = false;
        public Boolean HasUpDated
        {
            get { return _hasUpDated; }
        }
        #endregion

        #region Class Constructors
        public MemberInformationUpdate(CommonExchange.SysAccess userInfo, BaseServices.BaseServicesLogic baseServicesManager,
            CommonExchange.Member memberInfo, MemberLogic memberManager)
            : base(userInfo, memberManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;
            _baseServiceManager = baseServicesManager;
            _memberInfo = memberInfo;
            _tempMemberInfo = (CommonExchange.Member)memberInfo.Clone();

            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.pbxServices.Click += new EventHandler(pbxServicesClick);
            this.pbxServices.MouseLeave += new EventHandler(pbxServicesMouseLeave);
            this.pbxServices.MouseEnter += new EventHandler(pbxServicesMouseEnter);
            this.pbxHospitalization.Click += new EventHandler(pbxHospitalizationClick);
            this.pbxHospitalization.MouseEnter += new EventHandler(pbxHospitalizationMouseEnter);
            this.pbxHospitalization.MouseLeave += new EventHandler(pbxHospitalizationMouseLeave);

            this.dgvRegularLoan.MouseDown += new MouseEventHandler(dgvRegularLoanMouseDown);
            this.dgvRegularLoan.KeyPress += new KeyPressEventHandler(dgvRegularLoanKeyPress);
            this.dgvRegularLoan.KeyDown += new KeyEventHandler(dgvRegularLoanKeyDown);
            this.dgvRegularLoan.DataSourceChanged += new EventHandler(dgvRegularLoanDataSourceChanged);
            this.dgvRegularLoan.SelectionChanged += new EventHandler(dgvRegularLoanSelectionChanged);
            this.dgvRegularLoan.DoubleClick += new EventHandler(dgvRegularLoanDoubleClick);

            this.dgvCompletedLoan.MouseDown += new MouseEventHandler(dgvCompletedLoanMouseDown);
            this.dgvCompletedLoan.KeyPress += new KeyPressEventHandler(dgvCompletedLoanKeyPress);
            this.dgvCompletedLoan.KeyDown += new KeyEventHandler(dgvCompletedLoanKeyDown);
            this.dgvCompletedLoan.DataSourceChanged += new EventHandler(dgvCompletedLoanDataSourceChanged);
            this.dgvCompletedLoan.SelectionChanged += new EventHandler(dgvCompletedLoanSelectionChanged);
            this.dgvCompletedLoan.DoubleClick += new EventHandler(dgvCompletedLoanDoubleClick);

            this.dgvHospitalizationDebit.MouseDown += new MouseEventHandler(dgvHospitalizationDebitMouseDown);
            this.dgvHospitalizationDebit.KeyPress += new KeyPressEventHandler(dgvHospitalizationDebitKeyPress);
            this.dgvHospitalizationDebit.KeyDown += new KeyEventHandler(dgvHospitalizationDebitKeyDown);
            this.dgvHospitalizationDebit.DataSourceChanged += new EventHandler(dgvHospitalizationDebitDataSourceChanged);
            this.dgvHospitalizationDebit.SelectionChanged += new EventHandler(dgvHospitalizationDebitSelectionChanged);
            this.dgvHospitalizationDebit.DoubleClick += new EventHandler(dgvHospitalizationDebitDoubleClick);

            this.lnkCreateRegularLoan.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateRegularLoanLinkClicked);
            this.lnkLoanCalculator.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkLoanCalculatorLinkClicked);
            this.txtRemarksSharedCapital.Validated += new EventHandler(txtRemarksSharedCapitalValidated);
            this.txtAmountSharedCapital.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtAmountSharedCapital.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtAmountSharedCapital.Validated += new EventHandler(txtAmountSharedCapitalValidated);
            this.btnRecordSharedCapital.Click += new EventHandler(btnRecordSharedCapitalClick);
            this.rdbWithdrawal.CheckedChanged += new EventHandler(rdbWithdrawalCheckedChanged);
            this.txtHospitalizationPremiumAmountDue.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtHospitalizationPremiumAmountDue.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtHospitalizationPremiumAmountDue.Validated += new EventHandler(txtHospitalizationPremiumAmountDueValidated);
            this.txtHospitalizationMaximumAmount.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtHospitalizationMaximumAmount.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtHospitalizationMaximumAmount.Validated += new EventHandler(txtHospitalizationMaximumAmountValidated);
            this.txtHospitalizationCertificateNo.Validated += new EventHandler(txtHospitalizationCertificateNoValidated);
            this.txtHospitalizationRemarks.Validated += new EventHandler(txtHospitalizationRemarksValidated);
            this.btnRecordHospitalization.Click += new EventHandler(btnRecordHospitalizationClick);
            this.chkHospitalizationPrecluded.CheckedChanged += new EventHandler(chkHospitalizationPrecludedCheckedChanged);
            this.lnkCreateHospitalizationDebit.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateHospitalizationDebitLinkClicked);
            this.btnRefresh.Click += new EventHandler(btnRefreshClick);
            this.pbxGenerateId.Click += new EventHandler(pbxGenerateIdClick);

            if (RemoteServerLib.ProcStatic.IsSystemAccessAdmin(_userInfo) || RemoteServerLib.ProcStatic.IsSystemAccessCashier(_userInfo))
            {
                this.lnkShareCapitalCreditCreate.Enabled = this.lnkMembersEquityCreate.Enabled = true;

                this.lnkShareCapitalCreditCreate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkShareCapitalCreditCreateLinkClicked);

                this.dgvShareRemittance.MouseDown += new MouseEventHandler(dgvShareRemittanceMouseDown);
                this.dgvShareRemittance.KeyPress += new KeyPressEventHandler(dgvShareRemittanceKeyPress);
                this.dgvShareRemittance.KeyDown += new KeyEventHandler(dgvShareRemittanceKeyDown);
                this.dgvShareRemittance.DataSourceChanged += new EventHandler(dgvShareRemittanceDataSourceChanged);
                this.dgvShareRemittance.SelectionChanged += new EventHandler(dgvShareRemittanceSelectionChanged);
                this.dgvShareRemittance.DoubleClick += new EventHandler(dgvShareRemittanceDoubleClick);

                this.lnkMembersEquityCreate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkMembersEquityCreateLinkClicked);

                this.dgvMembersEquity.MouseDown += new MouseEventHandler(dgvMembersEquityMouseDown);
                this.dgvMembersEquity.KeyPress += new KeyPressEventHandler(dgvMembersEquityKeyPress);
                this.dgvMembersEquity.KeyDown += new KeyEventHandler(dgvMembersEquityKeyDown);
                this.dgvMembersEquity.DataSourceChanged += new EventHandler(dgvMembersEquityDataSourceChanged);
                this.dgvMembersEquity.SelectionChanged += new EventHandler(dgvMembersEquitySelectionChanged);
                this.dgvMembersEquity.DoubleClick += new EventHandler(dgvMembersEquityDoubleClick);
            }
        }    
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS MemberInformationUpdate EVENTS###############################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            _personInfo = _memberInfo.PersonInfo;

            this.Text = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_personInfo.LastName, _personInfo.FirstName, _personInfo.MiddleName);

            _sharedCapitalInfo = new CommonExchange.ShareCapitalInformation();
            _hospitalizationInfo = new CommonExchange.InHouseHospitalizationInformation();

            _sharedCapitalInfo.MemberInfo = _memberInfo;
            _hospitalizationInfo.MemberInfo = _memberInfo;

            this.dgvPersonSpouce.DataSource = _baseServiceManager.PersonSpouceTable;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvPersonSpouce, false);

            this.dgvSharedCapital.DataSource = _memberManager.ShareCapitalInformationTable;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvSharedCapital, false);

            this.dgvShareRemittance.DataSource = _memberManager.ShareCapitalCreditTable;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvShareRemittance, false);

            this.dgvMembersEquity.DataSource = _memberManager.MembersEquityTable;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvMembersEquity, false);

            this.dgvHospitalization.DataSource = _memberManager.HospitalizationInformation;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvHospitalization, false);

            this.dgvHospitalizationDebit.DataSource = _memberManager.HospitalizationDebitTable;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvHospitalizationDebit, false);

            this.dgvHospitalizationCredit.DataSource = _memberManager.InHouseHospitalizationTable;
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvHospitalizationCredit, false);

            this.InitializeSharedCapitalInformationControls();
            this.InitializeHospitalizationDebitInformationControls(true);
            this.InitializeHospitalizationInformationControls();
            
            this.AssingControlsValue();

            this.SetPersonInformationControls(true);

            this.btnUpdate.Enabled = true;

            _baseServiceManager.InitializePersonBeneficiaryDataGridView(this.dgvPersonBenificiaries,
               _personInfo.PersonBeneficiaryList, this.lblBeneficiariesStatus);
            _baseServiceManager.InitializePersonReferenceDataGridView(this.dgvPersonReference, _personInfo.PersonReferenceList);

            this.dgvCollateral.DataSource = _memberManager.GetSearchedCollateralInformation(_userInfo, _memberInfo.MemberSysId, false, true);

            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvCollateral, false);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvPersonBenificiaries, false);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvPersonReference, false);

            this.txtMemberId.Text = _memberInfo.MemberId;

            this.lnkMembershipDate.Enabled = false;

            DateTime dMemDate = DateTime.MinValue;

            this.txtMembershipDate.Clear(); 

            if (DateTime.TryParse(_memberInfo.MembershipDate, out dMemDate))
            {
                this.txtMembershipDate.Text = DateTime.Compare(dMemDate, DateTime.MinValue) == 0 ? String.Empty : dMemDate.ToLongDateString();
            }

            _memberManager.InitializeClassificationCombo(this.cboMemberClassification, _memberInfo.ClassificationInfo.ClassificationId);
            _memberManager.InitializeMemberTypeComboBox(this.cboMemberType, _memberInfo.MemberTypeInfo.MemberTypeId);

            this.txtReasonOfMembership.Text = _memberInfo.ReasonForMembership;
            this.txtCertificationInformation.Text = _memberInfo.CertificationInformation;
            this.txtOtherCooperativeMembership.Text = _memberInfo.OtherCoopMembership;
            this.txtOtherMemberInformation.Text = _memberInfo.OtherMemberInformation;

            if (_memberInfo.IsActive)
            {
                this.lblMemberStatus.Text = "ACTIVE";
                this.lblMemberStatus.ForeColor = Color.Green;
            }
            else
            {
                this.lblMemberStatus.Text = "DEACTIVATED";
                this.lblMemberStatus.ForeColor = Color.Red;
            }


            _loanManager = new LoanLogic(_userInfo);

            this.dgvRegularLoan.DataSource = _loanManager.GetSearchedRegularLoanInformation(_userInfo, _memberInfo.MemberSysId, false, true, true);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvRegularLoan, false);

            this.dgvCompletedLoan.DataSource = _loanManager.GetSearchedRegularLoanInformation(_userInfo, _memberInfo.MemberSysId, false, false, false);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvCompletedLoan, false);

            this.dgvOtherCreditor.DataSource = _memberManager.InitializeOtherCreditorDataGridView(_memberInfo.OtherCreditorInfoList);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvOtherCreditor, false);

            _memberManager.InitializeMemberSummaryListView(_userInfo, this.lsvMemberSummary, _memberInfo,
                _memberManager.FirstDayOfMonthFromDateTime(DateTime.Parse(_memberManager.ServerDateTime)).ToShortDateString() + " 12:00:00 AM",
                _memberManager.LastDayOfMonthFromDateTime(DateTime.Parse(_memberManager.ServerDateTime)).ToShortDateString() + " 11:59:59 PM",
                _totalShareCapitalContribution, _totalMembersEquity, _totalHospitalizationContribution, _loanManager.RegularLoanInformationTableTable);
            
            this.lnkVerify.Enabled = this.lnkPersonArchive.Visible = false;

            this.SetAccessRights();
        }//----------------------------------

        //event is raised when the class is clossing
        protected override void ClassClosing(object sender, FormClosingEventArgs e)
        {
            if (!_hasEnterClossingEvent)
            {
                if (!_hasUpDated && !_memberInfo.Equals(_tempMemberInfo))
                {
                    String strMsg = "There has been changes made in the current member information. \nExiting will not save this changes." +
                                    "\n\nAre you sure you want to exit?";

                    DialogResult msgResutl = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResutl == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }

                base.ClassClosing(sender, e);

                _hasEnterClossingEvent = true;
            }
            else
            {
                _hasEnterClossingEvent = false;
            }
        }//--------------------------
        //####################################################END CLASS MemberInformationUpdate EVENTS###############################################

        ////#####################################TEXTBOX txtLastName EVENTS########################################
        ////event is raised when the control is validated
        //protected override void txtLastNameValidated(object sender, EventArgs e)
        //{
        //    base.txtLastNameValidated(sender, e);

        //    this.btnUpdate.Enabled = false;
        //}//-------------------------
        ////#####################################END TEXTBOX txtLastName EVENTS########################################

        ////#####################################TEXTBOX txtFirstName EVENTS########################################
        ////event is raised when the control is validated
        //protected override void txtFirstNameValidated(object sender, EventArgs e)
        //{
        //    base.txtFirstNameValidated(sender, e);

        //    this.btnUpdate.Enabled = false;
        //}//----------------------
        ////#####################################END TEXTBOX txtFirstName EVENTS###############################################

        ////####################################################LINKLABEL lnkVerify EVENTS###############################################
        ////event is raised when the control is clicked
        //protected override void lnkVerifyLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.IsForUpdatePerson = false;

        //    base.lnkVerifyLinkClicked(sender, e);

        //    this.btnUpdate.Enabled = this.IsVerifiedUpdatedName;
        //}//---------------------
        ////####################################################END LINKLABEL lnkVerify EVENTS###############################################

        //#########################################BUTTON btnClose EVENTS##################################################
        //event is raised when the button is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-------------------
        //#########################################END BUTTON btnClose EVENTS##################################################

        //#########################################BUTTON btnUpdate EVENTS#####################################################
        //event is raised when the button is clicked
        private void btnUpdateClick(object sender, EventArgs e)
        {
            if (this.MemberValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to update the member information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The member information has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _personInfo.ObjectState = DataRowState.Modified;
                        _memberInfo.PersonInfo = _personInfo;
                        _memberInfo.ObjectState = DataRowState.Modified;

                        _memberManager.UpdateMemberInformation(_userInfo, _memberInfo);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasUpDated = true;
  
                        this.Close();
                    }
                    else if (msgResult == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error in Updating");
                }
            }
        }//----------------------
        //###########################################END BUTTON btnUpdate EVENTS#####################################################

        //############################################PICTUREBOX pbxServices EVENTS######################################
        //event is raised when the mouse is down
        private void pbxServicesClick(object sender, EventArgs e)
        {
            this.tabCntPerson.SelectedIndex = 5;
        }//----------------------

        //evet is raised when the mouse enters
        private void pbxServicesMouseEnter(object sender, EventArgs e)
        {
            this.pbxServices.Image = global::MemberServices.Properties.Resources.Services_hover;
        }//-----------------------

        //event is raised when the mouse leaves
        private void pbxServicesMouseLeave(object sender, EventArgs e)
        {
            this.pbxServices.Image = global::MemberServices.Properties.Resources.Services;
        }//-----------------------
        //############################################END PICTUREBOX pbxServices EVENTS######################################

        //############################################PICTUREBOX pbxHospitalization EVENTS######################################
        //event is raised when the mouse is leaves
        private void pbxHospitalizationMouseLeave(object sender, EventArgs e)
        {
            this.pbxHospitalization.Image = global::MemberServices.Properties.Resources.lmsHospitalization;
        }//-------------------------------

        //event is raised when the mouse enters
        private void pbxHospitalizationMouseEnter(object sender, EventArgs e)
        {
            this.pbxHospitalization.Image = global::MemberServices.Properties.Resources.lmsHospitalization_hover;
        }//------------------------------

        //event is raised when the control is clicked
        private void pbxHospitalizationClick(object sender, EventArgs e)
        {
            this.tabCntPerson.SelectedIndex = 6;
        }//-----------------------
        //############################################END PICTUREBOX pbxHospitalization EVENTS######################################

        //############################################DATAGRIDVIEW dgvRegularLoan EVENTS######################################
        //event is raised when the mouse is down
        private void dgvRegularLoanMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexRegularLoan = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexRegularLoan = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexRegularLoan = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexRegularLoan = -1;
                        _primaryIdRegularLoan = String.Empty;
                        break;
                }

                if (_rowIndexRegularLoan != -1)
                {
                    _primaryIdRegularLoan = dgvBase[_primaryIndexRegularLoad, _rowIndexRegularLoan].Value.ToString();
                }
            }
        }//-----------------------------

        //event is raised when the key is pressed
        private void dgvRegularLoanKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdRegularLoan = row.Cells[_primaryIndexRegularLoad].Value.ToString();
                    _primaryIndexRegularLoad = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//------------------------

        //event is raised when the key is down
        private void dgvRegularLoanKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//---------------------------

        //event is raised when the data source is changed
        private void dgvRegularLoanDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdRegularLoan = dgvBase[_primaryIndexRegularLoad, 0].Value.ToString();
            }
            else
            {
                _primaryIdRegularLoan = String.Empty;
            }
        }//---------------------

        //event is raised when the selection is chaged
        private void dgvRegularLoanSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdRegularLoan = row.Cells[_primaryIndexRegularLoad].Value.ToString();
            }
        }//-------------------------

        //event is raised when the control is double clicked
        private void dgvRegularLoanDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdRegularLoan))
            {
                using (RegularLoanInformationRecord frmUpdate = new RegularLoanInformationRecord(_userInfo, _memberInfo,
                    _loanManager.GetDetailsRegularLoanInformation(_userInfo, _primaryIdRegularLoan), _loanManager, _memberManager, this.lblPersonName.Text))
                {
                    frmUpdate.IsForCreate = false;
                    frmUpdate.ShowDialog(this);
                    
                    if (frmUpdate.HasRecorded)
                    {
                        this.dgvRegularLoan.DataSource = _loanManager.GetSearchedRegularLoanInformation(_userInfo, _memberInfo.MemberSysId, false, false, true);
                    }
                }
            }
        }//------------------------
        //############################################END DATAGRIDVIEW dgvRegularLoan EVENTS######################################

        //############################################DATAGRIDVIEW dgvCompletedLoan EVENTS######################################
        //event is raised when the control is double clicked
        private void dgvCompletedLoanDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdRegularLoanCompleted))
            {
                using (RegularLoanInformationRecord frmUpdate = new RegularLoanInformationRecord(_userInfo, _memberInfo,
                    _loanManager.GetDetailsRegularLoanInformation(_userInfo, _primaryIdRegularLoanCompleted), _loanManager, _memberManager, this.lblPersonName.Text))
                {
                    frmUpdate.IsForCreate = false;
                    frmUpdate.ShowDialog(this);               
                }
            }
        }//--------------------------

        //event is raised when the selection is changed
        private void dgvCompletedLoanSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdRegularLoanCompleted = row.Cells[_primaryIndexRegularLoadCompleted].Value.ToString();
            }
        }//------------------

        //event is raised when the datasource is chanted
        private void dgvCompletedLoanDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdRegularLoanCompleted = dgvBase[_primaryIndexRegularLoadCompleted, 0].Value.ToString();
            }
            else
            {
                _primaryIdRegularLoanCompleted = String.Empty;
            }
        }//----------------------

        //event is raised when the key is down
        private void dgvCompletedLoanKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//--------------------

        //event is raised when the key is pressed
        private void dgvCompletedLoanKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdRegularLoanCompleted = row.Cells[_primaryIndexRegularLoadCompleted].Value.ToString();
                    _primaryIndexRegularLoadCompleted = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//------------------

        //event is raised when the mouse is down
        private void dgvCompletedLoanMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexRegularLoan = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexRegularLoanCompleted = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexRegularLoanCompleted = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexRegularLoanCompleted = -1;
                        _primaryIdRegularLoanCompleted = String.Empty;
                        break;
                }

                if (_rowIndexRegularLoanCompleted != -1)
                {
                    _primaryIdRegularLoanCompleted = dgvBase[_primaryIndexRegularLoadCompleted, _rowIndexRegularLoanCompleted].Value.ToString();
                }
            }
        }//--------------------
        //############################################ENDDATAGRIDVIEW dgvCompletedLoan EVENTS######################################

        //############################################DATAGRIDVIEW dgvShareRemittance EVENTS######################################
        //event is raised when the control is double clicked
        private void dgvShareRemittanceDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdShareCapitalCredit))
            {
                using (ShareCapitalCreditUpdate frmUpdate = new ShareCapitalCreditUpdate(_userInfo, _memberInfo,
                    _memberManager.GetDetailsShareCapitalCreditInformation(_primaryIdShareCapitalCredit), _memberManager))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        this.dgvShareRemittance.DataSource = _memberManager.GetShareCapitalCredits(_userInfo, _memberInfo.MemberSysId, ref _totalShareCapitalContribution,
                            this.lblShareCapitalCreditTotatContribution);
                    }
                }
            }
        }//-------------------------

        //event is raised when the selection is change
        private void dgvShareRemittanceSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdShareCapitalCredit = row.Cells[_primaryIndexShareCapitalCredit].Value.ToString();
            }
        }//----------------------
        
        //event is raised when the data source is chanted
        private void dgvShareRemittanceDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdShareCapitalCredit = dgvBase[_primaryIndexShareCapitalCredit, 0].Value.ToString();
            }
            else
            {
                _primaryIdShareCapitalCredit = String.Empty;
            }
        }//------------------

        //event is raised when the key is down
        private void dgvShareRemittanceKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//----------------------

        //event is raised when the key is pressed
        private void dgvShareRemittanceKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdShareCapitalCredit = row.Cells[_primaryIndexShareCapitalCredit].Value.ToString();
                    _primaryIndexShareCapitalCredit = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//-----------------------

        //event is raised when the mouse is down
        private void dgvShareRemittanceMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexShareCapitalCredit = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexShareCapitalCredit = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexShareCapitalCredit = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexShareCapitalCredit = -1;
                        _primaryIdShareCapitalCredit = String.Empty;
                        break;
                }

                if (_rowIndexShareCapitalCredit != -1)
                {
                    _primaryIdShareCapitalCredit = dgvBase[_primaryIndexShareCapitalCredit, _rowIndexShareCapitalCredit].Value.ToString();
                }
            }
        }//------------------------
        //############################################END DATAGRIDVIEW dgvShareRemittance EVENTS######################################

        //############################################DATAGRIDVIEW dgvMembers'sEquity EVENTS######################################
        //event is raised when the control is double clicked
        private void dgvMembersEquityDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdMembersEquity))
            {
                using (MembersEquityUpdate frmUpdate = new MembersEquityUpdate(_userInfo, _memberInfo,
                    _memberManager.GetDetailsMembersEquityInformation(_primaryIdMembersEquity), _memberManager))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        this.dgvMembersEquity.DataSource = _memberManager.GetMembersEquity(_userInfo, _memberInfo.MemberSysId, ref _totalMembersEquity,
                            this.lblMembersEquityTotal);
                    }
                }
            }
        }//-------------------------

        //event is raised when the selection is change
        private void dgvMembersEquitySelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdMembersEquity = row.Cells[_primaryIndexMembersEquity].Value.ToString();
            }
        }//-----------------------------

        //event is raised when the data source is changed
        private void dgvMembersEquityDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdMembersEquity = dgvBase[_primaryIndexMembersEquity, 0].Value.ToString();
            }
            else
            {
                _primaryIdMembersEquity = String.Empty;
            }
        }//----------------------

        //event is raised when the key is down
        private void dgvMembersEquityKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//----------------------

        //event is raised when the key is pressed
        private void dgvMembersEquityKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdMembersEquity = row.Cells[_primaryIndexMembersEquity].Value.ToString();
                    _primaryIndexMembersEquity = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//-------------------------------

        //event is raised when the mouse is down
        private void dgvMembersEquityMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexMembersEquity = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexMembersEquity = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexMembersEquity = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexMembersEquity = -1;
                        _primaryIdMembersEquity = String.Empty;
                        break;
                }

                if (_rowIndexMembersEquity != -1)
                {
                    _primaryIdMembersEquity = dgvBase[_primaryIndexMembersEquity, _rowIndexMembersEquity].Value.ToString();
                }
            }
        }//-----------------------------
        //############################################END DATAGRIDVIEW dgvMembers'sEquity EVENTS######################################

        //############################################DATAGRIDVIEW dgvHospitalizationDebit EVENTS######################################
        //event is raised when the mouse is down
        private void dgvHospitalizationDebitMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexHospitalizationDebit = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexHospitalizationDebit = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexHospitalizationDebit = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexHospitalizationDebit = -1;
                        _primaryIdHospitalizationDebit = String.Empty;
                        break;
                }

                if (_rowIndexHospitalizationDebit != -1)
                {
                    _primaryIdHospitalizationDebit = dgvBase[_primaryIndexHospitalizationDebit, _rowIndexHospitalizationDebit].Value.ToString();
                }
            }
        }//-------------------------

        //event is raised when the control key is pressed
        private void dgvHospitalizationDebitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdHospitalizationDebit = row.Cells[_primaryIndexHospitalizationDebit].Value.ToString();
                    _primaryIndexHospitalizationDebit = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//-------------------------------

        //event is raised when the key is down
        private void dgvHospitalizationDebitKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//-------------------------------

        //event is raised when the data source is changed
        private void dgvHospitalizationDebitDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdHospitalizationDebit = dgvBase[_primaryIndexHospitalizationDebit, 0].Value.ToString();
            }
            else
            {
                _primaryIdHospitalizationDebit = String.Empty;
            }
        }//---------------------------

        //event is raised when the selection is changed
        private void dgvHospitalizationDebitSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdHospitalizationDebit = row.Cells[_primaryIndexHospitalizationDebit].Value.ToString();
            }
        }//--------------------------------

        //event is raised when the control is double clicked
        private void dgvHospitalizationDebitDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdHospitalizationDebit))
            {
                using (HospitalizationDebitRecord frmUpdate = new HospitalizationDebitRecord(_userInfo, _memberInfo,
                    _memberManager.GetDetailsInHouseHospitalizationDebitInformation(_userInfo, _primaryIdHospitalizationDebit), _memberManager,
                    _memberManager.GetHospitalizationRunningBalance(_hospitalizationInfo), _hospitalizationInfo.MaximumAmount, this.lblPersonName.Text))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasRecorded)
                    {
                        this.InitializeHospitalizationDebitInformationControls(false);

                        this.lblRunningBalance.Text = _memberManager.GetHospitalizationRunningBalance(_hospitalizationInfo).ToString("N");
                    }
                }
            }
        }//-----------------------------
        //############################################END DATAGRIDVIEW dgvHospitalizationDebit EVENTS######################################

        //############################################LINKLABEL lnkCreateRegularLoan EVENTS######################################
        //event is raised when control is clicked
        private void lnkCreateRegularLoanLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegularLoanInformationRecord frmCreate = new RegularLoanInformationRecord(_userInfo, _memberInfo, _loanManager, _memberManager, this.lblPersonName.Text))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasRecorded)
                {
                    this.dgvRegularLoan.DataSource = _loanManager.GetSearchedRegularLoanInformation(_userInfo, _memberInfo.MemberSysId, false, false, true);
                }
            }
        }//----------------------------
        //############################################END LINKLABEL lnkCreateRegularLoan EVENTS######################################

        //############################################LINKLABEL lnkLoanCalculator EVENTS######################################
        //event is raised when control is clicked
        private void lnkLoanCalculatorLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (LoanCalculator frmShow = new LoanCalculator(_userInfo, _memberInfo, _loanManager))
            {
                frmShow.ShowDialog(this);
            }
        }//-----------------------------
        //############################################END LINKLABEL lnkLoanCalculator EVENTS######################################

        //############################################TEXTBOX txtRemarksSharedCapital EVENTS######################################
        //event is raised when control is clicked
        private void txtRemarksSharedCapitalValidated(object sender, EventArgs e)
        {
            _sharedCapitalInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarksSharedCapital.Text);
        }//----------------------------
        //############################################END TEXTBOX txtRemarksSharedCapital EVENTS######################################

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

        //############################################TEXTBOX txtAmountSharedCapital EVENTS######################################
        //event is raised when control is clicked
        private void txtAmountSharedCapitalValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtAmountSharedCapital.Text, out amount))
            {
                _sharedCapitalInfo.PremiumAmountDue = amount;
            }
        }//--------------------------
        //############################################END TEXTBOX txtAmountSharedCapital EVENTS######################################

        //############################################RADIOBUTTON rdbWithdrawal EVENTS######################################
        //event is raised when control is clicked
        private void rdbWithdrawalCheckedChanged(object sender, EventArgs e)
        {
            _sharedCapitalInfo.IsPrecludedRetirement = this.rdbRetirement.Checked;
            _sharedCapitalInfo.IsPrecludedWithdrawal = this.rdbWithdrawal.Checked;
        }//---------------------------
        //############################################END RADIOBUTTON rdbWithdrawal EVENTS######################################

        //############################################BUTTON btnRecordSharedCapital EVENTS######################################
        //event is raised when control is clicked
        private void btnRecordSharedCapitalClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsSharedCapital())
                {
                    String strMsg = "Are you sure you want to create a shared capital information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The shared capital information has been successfully created.";

                        this.Cursor = Cursors.WaitCursor;

                        _sharedCapitalInfo.ObjectState = _sharedCapitalInfo.ShareCapitalId <= 0 ? DataRowState.Added : DataRowState.Modified;

                        _memberManager.InsertUpdateShareCapitalInformation(_userInfo, _sharedCapitalInfo);

                        this.InitializeSharedCapitalInformationControls();

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Recording");
            }
        }//---------------------------
        //############################################END BUTTON btnRecordSharedCapital EVENTS######################################

        //############################################TEXTBOX txtHospitalizationPremiumAmountDueValidated EVENTS######################################
        //event is raised when control is clicked
        private void txtHospitalizationPremiumAmountDueValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtHospitalizationPremiumAmountDue.Text, out amount))
            {
                _hospitalizationInfo.PremiumAmountDue = amount;
            }
        }//------------------------
        //############################################END TEXTBOX txtHospitalizationPremiumAmountDueValidated EVENTS######################################

        //############################################TEXTBOX txtHospitalizationMaximumAmount EVENTS######################################
        //event is raised when control is clicked
        private void txtHospitalizationMaximumAmountValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtHospitalizationMaximumAmount.Text, out amount))
            {
                _hospitalizationInfo.MaximumAmount = amount;
            }
        }//------------------------
        //############################################END TEXTBOX txtHospitalizationMaximumAmount EVENTS######################################

        //############################################TEXTBOX txtHospitalizationRemarks EVENTS######################################
        //event is raised when control is clicked
        private void txtHospitalizationRemarksValidated(object sender, EventArgs e)
        {
            _hospitalizationInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtHospitalizationRemarks.Text);
        }//------------------------
        //############################################END TEXTBOX txtHospitalizationRemarks EVENTS######################################

        //############################################TEXTBOX txtHospitalizationCertificateNo EVENTS######################################
        //event is raised when control is clicked
        private void txtHospitalizationCertificateNoValidated(object sender, EventArgs e)
        {
            _hospitalizationInfo.CertificateNo = BaseServices.ProcStatic.TrimStartEndString(this.txtHospitalizationCertificateNo.Text);
        }//-------------------------
        //############################################END TEXTBOX txtHospitalizationCertificateNo EVENTS######################################

        //############################################BUTTON btnRecordHospitalization EVENTS######################################
        //event is raised when control is clicked
        private void btnRecordHospitalizationClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsHospitalization())
                {
                    String strMsg = "Are you sure you want to create a in house hospitalization information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The in house hospitalization information has been successfully created.";

                        this.Cursor = Cursors.WaitCursor;

                        _hospitalizationInfo.ObjectState = _hospitalizationInfo.InHouseId <= 0 ? DataRowState.Added : DataRowState.Modified;

                        _memberManager.InsertUpdateHospitalizationInformation(_userInfo, _hospitalizationInfo);

                        this.InitializeHospitalizationInformationControls();

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Recording");
            }
        }//--------------------------
        //############################################END BUTTON btnRecordHospitalization EVENTS######################################

        //############################################BUTTON chkHospitalizationPrecluded EVENTS######################################
        //event is raised when control is clicked
        private void chkHospitalizationPrecludedCheckedChanged(object sender, EventArgs e)
        {
            _hospitalizationInfo.IsPrecluded = this.chkHospitalizationPrecluded.Checked;
        }//---------------------------
        //############################################END BUTTON chkHospitalizationPrecluded EVENTS######################################

        //############################################LINKLABEL lnkCreateHospitalizationDebit EVENTS######################################
        //event is raised when control is clicked
        private void lnkCreateHospitalizationDebitLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (HospitalizationDebitRecord frmCreate = new HospitalizationDebitRecord(_userInfo, _memberInfo, _memberManager,
                _memberManager.GetHospitalizationRunningBalance(_hospitalizationInfo), _hospitalizationInfo.MaximumAmount, this.lblPersonName.Text))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasRecorded)
                {
                    this.InitializeHospitalizationDebitInformationControls(false);

                    this.lblRunningBalance.Text = _memberManager.GetHospitalizationRunningBalance(_hospitalizationInfo).ToString("N");
                }
            }
        }//--------------------------
        //############################################END LINKLABEL lnkCreateHospitalizationDebit EVENTS######################################

        //############################################BUTTON btnRefresh EVENTS######################################
        //event is raised when control is clicked
        private void btnRefreshClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.dgvShareRemittance.DataSource = _memberManager.GetShareCapitalCredits(_userInfo, _memberInfo.MemberSysId, ref _totalShareCapitalContribution,
               this.lblShareCapitalCreditTotatContribution);

            this.dgvMembersEquity.DataSource = _memberManager.GetMembersEquity(_userInfo, _memberInfo.MemberSysId, ref _totalMembersEquity,
               this.lblMembersEquityTotal);

            this.dgvHospitalizationCredit.DataSource = _memberManager.GetInHouseHospitalizations(_userInfo, _memberInfo.MemberSysId, ref _totalHospitalizationContribution);

            this.dgvRegularLoan.DataSource = _loanManager.GetSearchedRegularLoanInformation(_userInfo, _memberInfo.MemberSysId, false, true, true);

            _memberManager.InitializeMemberSummaryListView(_userInfo, this.lsvMemberSummary, _memberInfo,
                _memberManager.FirstDayOfMonthFromDateTime(DateTime.Parse(_memberManager.ServerDateTime)).ToShortDateString() + " 12:00:00 AM",
                _memberManager.LastDayOfMonthFromDateTime(DateTime.Parse(_memberManager.ServerDateTime)).ToShortDateString() + " 11:59:59 PM",
                _totalShareCapitalContribution, _totalMembersEquity, _totalHospitalizationContribution, _loanManager.RegularLoanInformationTableTable);

            this.Cursor = Cursors.Arrow;

        }//---------------------
        //############################################END BUTTON btnRefresh EVENTS######################################

        //############################################PICTUREBOX pbxGenerateId EVENTS######################################
        //event is raised when control is clicked
        private void pbxGenerateIdClick(object sender, EventArgs e)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                this.txtHospitalizationCertificateNo.Text = remClient.SelectCountForCertificateNoInHouseHospitalizationInformation(_userInfo);

                _hospitalizationInfo.CertificateNo = BaseServices.ProcStatic.TrimStartEndString(this.txtHospitalizationCertificateNo.Text);
            }
        }//-----------------------
        //############################################PICTUREBOX pbxGenerateId EVENTS######################################

        //############################################LINKLABEL lnkShareCapitalCreditCreate EVENTS######################################
        //event is raised when control is clicked
        private void lnkShareCapitalCreditCreateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowShareCapitalCreditCreate(false);
        }//-------------------------
        //############################################END LINKLABEL lnkShareCapitalCreditCreate EVENTS######################################

        //############################################LINKLABEL lnkMembersEquityCreate EVENTS######################################
        //event is raised when control is clicked
        private void lnkMembersEquityCreateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMembersEquityCreate(false);
        }//---------------------------
        //############################################END LINKLABEL lnkMembersEquityCreate EVENTS######################################
        #endregion

        #region Programmer's Defined void procedures
        //this procedure will set access rights functionality
        private void SetAccessRights()
        {
            if (RemoteServerLib.ProcStatic.IsSystemAccessDataController(_userInfo) || RemoteServerLib.ProcStatic.IsSystemAccessDisbursementOfficer(_userInfo))
            {
                this.btnUpdate.Enabled = false;

                this.lnkLoanCalculator.Enabled = this.lnkCreateRegularLoan.Enabled = this.lnkCreateCollateral.Enabled =
                    this.btnRecordHospitalization.Enabled = this.lnkCreateHospitalizationDebit.Enabled = this.btnRecordSharedCapital.Enabled =
                    this.lnkShareCapitalCreditCreate.Enabled = this.lnkMembersEquityCreate.Enabled = false;
            }
            else if (RemoteServerLib.ProcStatic.IsSystemAccessLoanOfficer(_userInfo))
            {
                this.lnkCreateSpouce.Enabled = this.lnkCreateBeneficiary.Enabled = this.lnkCreateReference.Enabled = this.btnShowDocument.Enabled =
                    this.lnkCreateCollateral.Enabled = this.lnkCreateOtherCreditor.Enabled = this.btnRecordSharedCapital.Enabled =
                    this.lnkShareCapitalCreditCreate.Enabled = this.lnkMembersEquityCreate.Enabled = false;
            }
            else if (RemoteServerLib.ProcStatic.IsSystemAccessCashier(_userInfo))
            {
                this.lnkCreateSpouce.Enabled = this.lnkCreateBeneficiary.Enabled = this.lnkCreateReference.Enabled = this.btnShowDocument.Enabled =
                    this.lnkCreateOtherCreditor.Enabled = this.lnkLoanCalculator.Enabled = this.lnkCreateRegularLoan.Enabled =
                    this.btnRecordHospitalization.Enabled = this.lnkCreateHospitalizationDebit.Enabled = false;
            }           
        }//-------------------------

        //this procedure will initialize shared capital information controls
        private void InitializeSharedCapitalInformationControls()
        {
            this.dgvSharedCapital.DataSource = _memberManager.GetSearchedSharedCapitalInformation(_userInfo, _memberInfo.MemberSysId, true);
            this.dgvShareRemittance.DataSource = _memberManager.GetShareCapitalCredits(_userInfo, _memberInfo.MemberSysId, ref _totalShareCapitalContribution,
                this.lblShareCapitalCreditTotatContribution);
            this.dgvMembersEquity.DataSource = _memberManager.GetMembersEquity(_userInfo, _memberInfo.MemberSysId, ref _totalMembersEquity,
               this.lblMembersEquityTotal);

            _sharedCapitalInfo = _memberManager.GetDetailsSharedCapitalInformation();
            _sharedCapitalInfo.MemberInfo = _memberInfo;

            DateTime effectivityDate = DateTime.MinValue;

            this.lblEffictivityDate.Text = String.Empty;

            if (DateTime.TryParse(_sharedCapitalInfo.EffectivityDate, out effectivityDate))
            {
                this.lblEffictivityDate.Text = DateTime.Compare(effectivityDate, DateTime.MinValue) == 0 ? String.Empty : effectivityDate.ToLongDateString();
            }

            this.txtAmountSharedCapital.Text = _sharedCapitalInfo.PremiumAmountDue.ToString("N");
            this.txtRemarksSharedCapital.Text = _sharedCapitalInfo.Remarks;

            this.rdbWithdrawal.Checked = _sharedCapitalInfo.IsPrecludedWithdrawal;
            this.rdbRetirement.Checked = _sharedCapitalInfo.IsPrecludedRetirement;
        }//------------------------

        //this procedure will initialize hospitalization information controls
        private void InitializeHospitalizationInformationControls()
        {
            this.dgvHospitalization.DataSource = _memberManager.GetSearchedHospitalizationInformation(_userInfo, _memberInfo.MemberSysId, true);
            this.dgvHospitalizationCredit.DataSource = _memberManager.GetInHouseHospitalizations(_userInfo, _memberInfo.MemberSysId, ref _totalHospitalizationContribution);

            _hospitalizationInfo = _memberManager.GetDetailsCurrentHospitalizationInformaion();
            _hospitalizationInfo.MemberInfo = _memberInfo;

            DateTime effectivityDate = DateTime.MinValue;

            this.lblHospitalizationEffectivityDate.Text = String.Empty;

            if (DateTime.TryParse(_hospitalizationInfo.EffectivityDate, out effectivityDate))
            {
                this.lblHospitalizationEffectivityDate.Text = DateTime.Compare(effectivityDate, DateTime.MinValue) == 0 ? String.Empty : effectivityDate.ToLongDateString();
            }

            this.txtHospitalizationCertificateNo.Text = _hospitalizationInfo.CertificateNo;
            this.txtHospitalizationPremiumAmountDue.Text = _hospitalizationInfo.PremiumAmountDue.ToString("N");
            this.txtHospitalizationMaximumAmount.Text = _hospitalizationInfo.MaximumAmount.ToString("N");
            this.txtHospitalizationRemarks.Text = _hospitalizationInfo.Remarks;

            this.chkHospitalizationPrecluded.Checked = _hospitalizationInfo.IsPrecluded;

            this.lblRunningBalance.Text = _memberManager.GetHospitalizationRunningBalance(_hospitalizationInfo).ToString("N");
        }//------------------------

        //this procedure will initialize hospitalization debit information controls
        private void InitializeHospitalizationDebitInformationControls(Boolean isNewQuery)
        {
            this.dgvHospitalizationDebit.DataSource = _memberManager.GetSearchedHospitalizationDebit(_userInfo, _memberInfo.MemberSysId, false, isNewQuery);
        }//---------------------

        //this procedure will call the share capital credit create moudule recursively
        private void ShowShareCapitalCreditCreate(Boolean allowMultipleInsert)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (ShareCapitalCreditCreate frmCreate = new ShareCapitalCreditCreate(_userInfo, _memberInfo, _memberManager))
                {
                    frmCreate.AllowMultipleInsert = allowMultipleInsert;
                    frmCreate.ShowDialog(this);

                    allowMultipleInsert = frmCreate.AllowMultipleInsert;
                }

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message + "\n\nError Share Capital Credit Create Module", "Error Loading");
            }

            if (allowMultipleInsert)
            {
                this.ShowShareCapitalCreditCreate(allowMultipleInsert);
            }
            else
            {
                this.dgvShareRemittance.DataSource = _memberManager.GetShareCapitalCredits(_userInfo, _memberInfo.MemberSysId, ref _totalShareCapitalContribution,
                    this.lblShareCapitalCreditTotatContribution);
            }
        }//--------------------------

        //this procedure will call the share capital credit create moudule recursively
        private void ShowMembersEquityCreate(Boolean allowMultipleInsert)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (MembersEquityCreate frmCreate = new MembersEquityCreate(_userInfo, _memberInfo, _memberManager))
                {
                    frmCreate.AllowMultipleInsert = allowMultipleInsert;
                    frmCreate.ShowDialog(this);

                    allowMultipleInsert = frmCreate.AllowMultipleInsert;
                }

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message + "\n\nError Member's Equity Create Module", "Error Loading");
            }

            if (allowMultipleInsert)
            {
                this.ShowMembersEquityCreate(allowMultipleInsert);
            }
            else
            {
                this.dgvMembersEquity.DataSource = _memberManager.GetMembersEquity(_userInfo, _memberInfo.MemberSysId, ref _totalMembersEquity,
                    this.lblMembersEquityTotal);
            }
        }//--------------------------
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls shared capital information
        private Boolean ValidateControlsSharedCapital()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnRecordSharedCapital, String.Empty);
            _errProvider.SetError(this.txtAmountSharedCapital, String.Empty);

            if (String.IsNullOrEmpty(_sharedCapitalInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.btnRecordSharedCapital, "Member information is required.");
                _errProvider.SetIconAlignment(this.btnRecordSharedCapital, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_sharedCapitalInfo.PremiumAmountDue <= 0)
            {
                _errProvider.SetError(this.txtAmountSharedCapital, "Amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtAmountSharedCapital, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//-----------------------------------

        //this function will validate controls hospitalization information
        public Boolean ValidateControlsHospitalization()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnRecordHospitalization, String.Empty);
            _errProvider.SetError(this.txtHospitalizationCertificateNo, String.Empty);
            _errProvider.SetError(this.txtHospitalizationPremiumAmountDue, String.Empty);
            _errProvider.SetError(this.txtHospitalizationMaximumAmount, String.Empty);

            if (String.IsNullOrEmpty(_hospitalizationInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.btnRecordHospitalization, "Member information is required.");
                _errProvider.SetIconAlignment(this.btnRecordHospitalization, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_hospitalizationInfo.CertificateNo))
            {
                _errProvider.SetError(this.txtHospitalizationCertificateNo, "Certificate number required.");
                _errProvider.SetIconAlignment(this.txtHospitalizationCertificateNo, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }

            if (_hospitalizationInfo.PremiumAmountDue <= 0)
            {
                _errProvider.SetError(this.txtHospitalizationPremiumAmountDue, "Premium amount due must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtHospitalizationPremiumAmountDue, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_hospitalizationInfo.MaximumAmount <= 0)
            {
                _errProvider.SetError(this.txtHospitalizationMaximumAmount, "Maximun amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtHospitalizationMaximumAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//------------------------
        #endregion
    }
}
