using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class HospitalizationDebitRecord
    {
        #region Class Data Member Decleration
        private CommonExchange.InHouseHospitalizationDebit _tempInHouseHospitalizationDebitInfo;

        private Boolean _hasEnterClossingEvent = false;
        #endregion

        #region Class Properties Declarations
        private Boolean _hasRecorded = false;
        public Boolean HasRecorded
        {
            get { return _hasRecorded; }
        }
        #endregion

        #region Class Constructos
        public HospitalizationDebitRecord(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, MemberLogic memberManager,
             Decimal hospitalizationRunningBalanceForTheYear, Decimal hospitalizationMaximumAmount, String memberName)
            : base(userInfo, memberInfo, memberManager, hospitalizationRunningBalanceForTheYear, hospitalizationMaximumAmount, memberName)
        {
            this.InitializeComponent();

            _inHouseHospitalizationDebitInfo = new CommonExchange.InHouseHospitalizationDebit();

            _hospitalizationRunningBalanceForTheYear = hospitalizationRunningBalanceForTheYear;
            _hospitalizationMaximumAmount = hospitalizationMaximumAmount;

            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnRecord.Click += new EventHandler(btnRecordClick);
        }

        public HospitalizationDebitRecord(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo,
            CommonExchange.InHouseHospitalizationDebit inHouseHospitalizationInfo, MemberLogic memberManager, 
            Decimal hospitalizationRunningBalanceForTheYear, Decimal hospitalizationMaximumAmount, String memberName)
            : base(userInfo, memberInfo, memberManager, hospitalizationRunningBalanceForTheYear, hospitalizationMaximumAmount, memberName)
        {
            this.InitializeComponent();

            _inHouseHospitalizationDebitInfo = inHouseHospitalizationInfo;
            _tempInHouseHospitalizationDebitInfo = (CommonExchange.InHouseHospitalizationDebit)inHouseHospitalizationInfo.Clone();

            _hospitalizationRunningBalanceForTheYear = hospitalizationRunningBalanceForTheYear;
            _hospitalizationMaximumAmount = hospitalizationMaximumAmount;

            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnRecord.Click += new EventHandler(btnRecordClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }             
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS HospitalizationDebitRecord EVENTS###############################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.InHouseDebitSysId))
            {
                base.ClassLoad(sender, e);

                this.btnPrint.Enabled = this.btnDelete.Enabled = false;
            }
            else
            {
                this.btnPrint.Enabled = this.btnDelete.Enabled = true;

                _inHouseHospitalizationDebitInfo.MemberInfo = _memberInfo;

                DateTime reflectedDate = DateTime.MinValue;

                this.txtReflectedDate.Clear();

                if (DateTime.TryParse(_inHouseHospitalizationDebitInfo.ReflectedDate, out reflectedDate))
                {
                    this.txtReflectedDate.Text = DateTime.Compare(reflectedDate, DateTime.MinValue) == 0 ? String.Empty : reflectedDate.ToLongDateString();
                }

                this.txtNetAssistanceAmount.Text = _inHouseHospitalizationDebitInfo.NetAssistanceAmount.ToString("N");

                DateTime dateFrom = DateTime.MinValue;

                this.txtDateFrom.Clear();

                if (DateTime.TryParse(_inHouseHospitalizationDebitInfo.DateFrom, out dateFrom))
                {
                    this.txtDateFrom.Text = DateTime.Compare(dateFrom, DateTime.MinValue) == 0 ? String.Empty : dateFrom.ToLongDateString();
                }

                DateTime dateTo = DateTime.MinValue;

                this.txtDateTo.Clear();

                if (DateTime.TryParse(_inHouseHospitalizationDebitInfo.DateTo, out dateTo))
                {
                    this.txtDateTo.Text = DateTime.Compare(dateTo, DateTime.MinValue) == 0 ? String.Empty : dateTo.ToLongDateString();
                }

                this.txtHospitalname.Text = _inHouseHospitalizationDebitInfo.HospitalName;
                this.txtCauseOfAdmission.Text = _inHouseHospitalizationDebitInfo.CauseOfAdmission;
                this.txtRemarks.Text = _inHouseHospitalizationDebitInfo.Remarks;

                this.btnPrint.Enabled = true;

                _memberManager.InitializeInHouseHospitalizationDebitChargesSummary(this.lsvChargesSummary, _inHouseHospitalizationDebitInfo,
                          _hospitalizationRunningBalanceForTheYear, _hospitalizationMaximumAmount);
            }
        }//----------------------------

        //event is raised when the class is clossing
        protected override void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasEnterClossingEvent)
            {
                if (!_hasRecorded)
                {
                    String strMsg = "There has been changes made in the ih-house hospitalization module. \nExiting will not save this changes." + "\n\nAre you sure you want to exit?";
                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }

                base.ClassClossing(sender, e);
            }
            else
            {
                _hasEnterClossingEvent = false;
            }
        }//-----------------------
        //####################################################END CLASS HospitalizationDebitRecord EVENTS###############################################

        //################################################BUTTON btnCancel EVENTS####################################################
        //event is raised when btnCancel is Clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------
        //################################################END BUTTON btnCancel EVENTS####################################################

        //################################################BUTTON btnRecord EVENTS####################################################
        //event is raised when control is Clicked
        private void btnRecordClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to record a hospitalization debit information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The hospitalization debit information has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        if (String.IsNullOrEmpty(_inHouseHospitalizationDebitInfo.InHouseDebitSysId))
                        {
                            _inHouseHospitalizationDebitInfo.ObjectState = DataRowState.Added;

                            _hospitalizationRunningBalanceForTheYear -= _inHouseHospitalizationDebitInfo.NetAssistanceAmount;
                        }
                        else
                        {
                            _inHouseHospitalizationDebitInfo.ObjectState = DataRowState.Modified;                            
                        }

                        
                        _memberManager.InsertUpdateInHouseHospitalizationDebitInfo(_userInfo, ref _inHouseHospitalizationDebitInfo);

                        foreach (CommonExchange.InHouseIncludeCoverage list in _inHouseHospitalizationDebitInfo.IncludeCoverageList)
                        {
                            list.ObjectState = DataRowState.Unchanged;
                        }

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasRecorded = true;

                        this.btnPrint.Enabled = true;
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
        }//---------------------
        //################################################END BUTTON btnRecord EVENTS####################################################

        //#####################################BUTTON btnDelete EVENTS########################################
        //event is raised when the control is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to delete the hospitalization debit information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The hospitalization debit information has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseHospitalizationDebitInfo.ObjectState = DataRowState.Deleted;

                        _memberManager.DeleteInHouseHospitalizationDebit(_userInfo, _inHouseHospitalizationDebitInfo);

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
    }
}
