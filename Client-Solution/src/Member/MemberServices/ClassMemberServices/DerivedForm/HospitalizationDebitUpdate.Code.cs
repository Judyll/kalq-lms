using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class HospitalizationDebitUpdate
    {
        #region Class Data Member Decleration
        private CommonExchange.InHouseHospitalizationDebit _tempInHouseHospitalizationDebitInfo;

        private Boolean _hasEnterClossingEvent = false;
        #endregion

        #region Class Properties Declarations
        private Boolean _hasUpdated = false;
        public Boolean HasUpdated
        {
            get { return _hasUpdated; }
        }

        private Boolean _hasDeleted = false;
        public Boolean HasDeleted
        {
            get { return _hasDeleted; }
        }
        #endregion

        #region Class Constructors
        public HospitalizationDebitUpdate(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo,
            CommonExchange.InHouseHospitalizationDebit inHouseHospitalizationInfo, MemberLogic memberManager, 
            Decimal hospitalizationRunningBalanceForTheYear, Decimal hospitalizationMaximumAmount, String membeName)
            : base(userInfo, memberInfo, memberManager, hospitalizationRunningBalanceForTheYear, hospitalizationMaximumAmount, membeName)
        {
            this.InitializeComponent();

            _inHouseHospitalizationDebitInfo = inHouseHospitalizationInfo;
            _tempInHouseHospitalizationDebitInfo = (CommonExchange.InHouseHospitalizationDebit)inHouseHospitalizationInfo.Clone();

            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }      
        #endregion

        #region Class Event Void Procedures
        //#####################################CLASS HospitalizationDebitUpdate EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
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
        }//----------------------------

        //event is raised when the Class is Clossing
        protected override void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasEnterClossingEvent)
            {
                if ((!_hasUpdated || !_hasDeleted) && !_inHouseHospitalizationDebitInfo.Equals(_tempInHouseHospitalizationDebitInfo))
                {
                    String strMsg = "There has been changes made in the current hospitalization debit information. \nExiting will not save this changes." +
                                    "\n\nAre you sure you want to exit?";
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
        }//----------------------------
        //#####################################END CLASS HospitalizationDebitUpdate EVENTS########################################

        //#####################################BUTTON btnClose EVENTS########################################
        //event is raised when the control is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------------
        //#####################################END BUTTON btnClose EVENTS########################################

        //#####################################BUTTON btnUpdate EVENTS########################################
        //event is raised when the control is clicked
        private void btnUpdateClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to update the hospitalization debit information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The hospitalization debit information has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseHospitalizationDebitInfo.ObjectState = DataRowState.Modified;

                        //_memberManager.UpdateInHouseHospitalizationDebitInfo(_userInfo, _inHouseHospitalizationDebitInfo);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasUpdated = _hasDeleted = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Updating");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//------------------------
        //#####################################END BUTTON btnUpdate EVENTS########################################

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

                        _hasUpdated = _hasDeleted = true;

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
