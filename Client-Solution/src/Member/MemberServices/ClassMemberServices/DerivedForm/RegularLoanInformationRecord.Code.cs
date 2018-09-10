using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class RegularLoanInformationRecord
    {
        #region Class Data Member Decleration
        private CommonExchange.RegularLoan _tempRegularLoanInfo;

        private Boolean _hasEnterClossingEvent = false;
        #endregion

        #region Class Properties Declarations
        private Boolean _hasRecorded = false;
        public Boolean HasRecorded
        {
            get { return _hasRecorded; }
        }
        #endregion

        #region Class Constructors
        public RegularLoanInformationRecord(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, LoanLogic loanManager, MemberLogic memberManager, String memberName)
            : base(userInfo, memberInfo, loanManager, memberManager, memberName)
        {
            this.InitializeComponent();

            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnRecord.Click += new EventHandler(btnRecordClick);
        }

        public RegularLoanInformationRecord(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo,
            CommonExchange.RegularLoan regularLoanInfo, LoanLogic loanManager, MemberLogic memberManager, String memberName)
            : base(userInfo, memberInfo, loanManager, memberManager, memberName)
        {
            this.InitializeComponent();

            regularLoanInfo.MemberInfo = memberInfo;
            _regularLoanInfo = regularLoanInfo;
            _tempRegularLoanInfo = (CommonExchange.RegularLoan)regularLoanInfo.Clone();


            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnRecord.Click += new EventHandler(btnRecordClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS RegularLoanInformationRecord EVENTS###############################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            if (_regularLoanInfo == null) // (String.IsNullOrEmpty(_regularLoanInfo.RegularLoanSysId))
            {
                base.ClassLoad(sender, e);

                this.btnDelete.Enabled = this.btnPrintChargeAdditionAmortization.Enabled = false;
            }
            else
            {                
                if (_regularLoanInfo.IsRecordLocked)
                {
                    lblStatus.Text = "This record is LOCKED.";

                    this.pbxLocked.Visible = true;
                    this.pbxUnlock.Visible = false;

                    this.btnCalculate.Enabled = this.btnRecord.Enabled = this.btnDelete.Enabled = this.lnkCreateRegularLoanCollateral.Enabled =
                        this.lnkCreateCoMaker.Enabled = this.lnkChangeDateApplied.Enabled = this.lnkChangeDateApproved.Enabled = this.lnkChageReleaseDate.Enabled =
                        this.lnkChangeMaturityDate.Enabled = this.cboPaymentInterval.Enabled = false;

                    this.txtPrincipalAmount.ReadOnly = this.txtInterestRate.ReadOnly = this.txtTerm.ReadOnly = this.txtNoOfPrepaidInterest.ReadOnly = true;

                    this.btnAddDocument.Click -= new EventHandler(btnAddDocumentClick);
                    this.dgvAmortizationList.DoubleClick -= new EventHandler(dgvAmortizationListDoubleClick);//enable this code if we dont allow the user to update if the record is locked
                    this.dgvCoMaker.DoubleClick += new EventHandler(dgvCoMakerDoubleClick);
                }
                else
                {
                    lblStatus.Text = "This record is OPEN.";

                    this.pbxLocked.Visible = false;
                    this.pbxUnlock.Visible = true;
                }

                this.btnPrintChargeAdditionAmortization.Enabled = this.btnPrintStatementOfAccount.Enabled = true;

                Decimal totalLoan = 0;
                Decimal totalPayment = 0;

                this.dgvAmortizationList.DataSource = _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo,
                    this.lblTotalInterestPayable, false, false, true, ref totalLoan);
                BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvAmortizationList, false);

                this.dgvPaymentList.DataSource = _loanManager.GetRegularLoanPayments(_userInfo, _regularLoanInfo.RegularLoanSysId, this.lblTotalPayment, ref totalPayment);
                BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvPaymentList, false);

                this.lblLoanBalance.Text = "Loan Balance: " + (totalLoan - totalPayment).ToString("N");

                this.dgvRegularLoanCollateral.DataSource = _loanManager.GetSearchedRegularLoanCollaterals(_userInfo, _regularLoanInfo.RegularLoanSysId, true);
                BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvRegularLoanCollateral, false);

                this.dgvCoMaker.DataSource = _loanManager.GetSearchedRegularLoanCoMaker(_userInfo, _regularLoanInfo.RegularLoanSysId, true);
                BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvCoMaker, false);

                this.AssingControlValuesRegularLoan();

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
                    this.lblPrePaidInterest.Text = this.lblDeferredInterest.Text = this.lblRealizedInterest.Text = "0.00";
                }

                if (_regularLoanInfo.LoanAmount > 0)
                {
                    _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);

                    this.gbxChargesAdditionals.Enabled = true;
                }

                this.btnCalculate.Enabled = false;
                this.cboLoanType.Enabled = false;
                this.lnkChangeDateApproved.Enabled = this.lnkChangeDateApplied.Enabled = false;

                this.SetAccessRights();
            }
        }//---------------------------

        //event is raised when the class is clossing
        protected override void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasEnterClossingEvent)
            {
                if (!_hasRecorded && !_regularLoanInfo.Equals(_tempRegularLoanInfo))
                {
                    String strMsg = "There has been changes made in the current regular loan module. \nExiting will not save this changes." + "\n\nAre you sure you want to exit?";
                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }

                base.ClassClossing(sender, e);

                _hasEnterClossingEvent = true;
            }
            else
            {
                _hasEnterClossingEvent = false;
            }
        }//--------------------------
        //####################################################END CLASS RegularLoanInformationRecord EVENTS###############################################

        //################################################BUTTON btnClose EVENTS####################################################
        //event is raised when btnCancel is Clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------
        //################################################END BUTTON btnClose EVENTS####################################################

        //################################################BUTTON btnRecord EVENTS####################################################
        //event is raised when the control is Clicked
        private void btnRecordClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to record a regular loan information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The regular loan information has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        if (String.IsNullOrEmpty(_regularLoanInfo.RegularLoanSysId))
                        {
                            List<CommonExchange.RegularLoanAmortization> amortizationList = _loanManager.GetListLoanAmortizationSchedule(_regularLoanInfo, true);

                            foreach (CommonExchange.RegularLoanAmortization list in amortizationList)
                            {
                                _regularLoanInfo.LoanAmortizationList.Add(list);
                            }

                            _regularLoanInfo.ObjectState = DataRowState.Added;

                            this.btnCalculate.Enabled = false;
                        }
                        else
                        {
                            _regularLoanInfo.ObjectState = DataRowState.Modified;
                        }

                        _loanManager.InsertUpdateRegularLoanInformation(_userInfo,ref _regularLoanInfo);

                        _regularLoanInfo.MemberInfo = _memberInfo;

                        _regularLoanInfo = _loanManager.GetDetailsRegularLoanInformation(_userInfo, _regularLoanInfo.RegularLoanSysId);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasRecorded = true;
                        
                        Decimal totalLoan = 0;
                        
                        this.dgvAmortizationList.DataSource = _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo,
                            this.lblTotalInterestPayable, false, false, true, ref totalLoan);
                        this.dgvRegularLoanCollateral.DataSource = _loanManager.GetSearchedRegularLoanCollaterals(_userInfo, _regularLoanInfo.RegularLoanSysId, true);
                        this.dgvCoMaker.DataSource = _loanManager.GetSearchedRegularLoanCoMaker(_userInfo, _regularLoanInfo.RegularLoanSysId, true);

                        this.btnPrintChargeAdditionAmortization.Enabled = this.btnPrintStatementOfAccount.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Recording");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//--------------------------
        //################################################END BUTTON btnRecord EVENTS####################################################

        //#####################################BUTTON btnDelete EVENTS########################################
        //event is raised when the control is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to delete the regular loan information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The regular loan information has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _regularLoanInfo.ObjectState = DataRowState.Deleted;

                        _loanManager.DeleteRegularLoanInfomation(_userInfo, _regularLoanInfo);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasRecorded = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Deleting");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//----------------------
        //#####################################END BUTTON btnDelete EVENTS########################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will set access rights functionality
        private void SetAccessRights()
        {
            if (!RemoteServerLib.ProcStatic.IsSystemAccessAdmin(_userInfo) && !RemoteServerLib.ProcStatic.IsSystemAccessLoanOfficer(_userInfo))
            {
                this.btnRecord.Enabled = this.btnDelete.Enabled = this.btnShowDocument.Enabled = this.lnkCreateRegularLoanCollateral.Enabled =
                    this.lnkCreateCoMaker.Enabled = false;

                this.dgvAmortizationList.DoubleClick -= new EventHandler(dgvAmortizationListDoubleClick);
                this.dgvCoMaker.DoubleClick -= new EventHandler(dgvCoMakerDoubleClick);
            }
        }//--------------------
        #endregion
    }
}
