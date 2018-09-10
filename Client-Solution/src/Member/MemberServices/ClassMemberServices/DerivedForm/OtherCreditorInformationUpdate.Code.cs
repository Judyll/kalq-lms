using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class OtherCreditorInformationUpdate
    {
        #region Class Data Member Decleration
        private CommonExchange.OtherCreditor _tempOtherCreditorInfo;
        private CommonExchange.Member _memberInfo;
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
        public OtherCreditorInformationUpdate(CommonExchange.SysAccess userInfo, CommonExchange.OtherCreditor otherCreditorInfo,
            CommonExchange.Member memberInfo, MemberLogic memberManager)
            : base(userInfo, memberManager)
        {
            this.InitializeComponent();

            _otherCreditorInfo = otherCreditorInfo;
            _tempOtherCreditorInfo = (CommonExchange.OtherCreditor)otherCreditorInfo.Clone();

            _memberInfo = memberInfo;

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }
        #endregion

        #region Class Event Void Procedures
        //#####################################CLASS OtherCreditorInformationUpdate EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.txtCreditorName.Text = _otherCreditorInfo.CreditorName;
            this.txtAmountOwned.Text = _otherCreditorInfo.AmountOwned.ToString("N");

            _memberManager.InitializePaymentIntervalComboBox(this.cboPaymentInterval, _otherCreditorInfo.RepaymentScheduleInfo.RepaymentId);

            DateTime dueDate = DateTime.MinValue;

            this.txtDueDate.Clear();

            if (DateTime.TryParse(_otherCreditorInfo.DateDue, out dueDate))
            {
                this.txtDueDate.Text = DateTime.Compare(dueDate, DateTime.MinValue) == 0 ? String.Empty : dueDate.ToLongDateString();
            }

            this.txtAmortizationAmount.Text = _otherCreditorInfo.AmortizationAmount.ToString("N");
            this.txtRemarks.Text = _otherCreditorInfo.Remarks;
        }//--------------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if ((!_hasUpdated || !_hasDeleted) && !_otherCreditorInfo.Equals(_tempOtherCreditorInfo))
            {
                String strMsg = "There has been changes made in the current other creditor information. \nExiting will not save this changes." +
                                "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//-------------------------
        //#####################################END  CLASS OtherCreditorInformationUpdate EVENTS########################################

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
                    String strMsg = "Are you sure you want to update the other creditor information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The other creditor information has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _otherCreditorInfo.ObjectState = DataRowState.Modified;

                        _memberManager.UpdateDeleteMemberOtherCreditorInformation(_memberInfo.OtherCreditorInfoList, _otherCreditorInfo);

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
                    String strMsg = "Are you sure you want to delete the other creditor information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The other creditor information has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _otherCreditorInfo.ObjectState = DataRowState.Deleted;

                        _memberManager.UpdateDeleteMemberOtherCreditorInformation(_memberInfo.OtherCreditorInfoList, _otherCreditorInfo);

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
