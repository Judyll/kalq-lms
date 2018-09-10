using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class MembersEquityUpdate
    {
        #region Class Data Member Declaration
        private CommonExchange.MemberEquityCredit _tempMembersEquityInfo;
        #endregion

        #region Class Properties Declaration
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
        public MembersEquityUpdate(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, CommonExchange.MemberEquityCredit membersEquityInfo,
            MemberLogic memberManager)
            : base(userInfo, memberInfo, memberManager)
        {
            this.InitializeComponent();

            membersEquityInfo.MemberInfo = memberInfo;
            _membersEquityInfo = membersEquityInfo;
            _tempMembersEquityInfo = (CommonExchange.MemberEquityCredit)membersEquityInfo.Clone();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }
        #endregion

        #region Class Event Void Procedures
        //############################################CLASS ShareCapitalCreditUpdate EVENTS#######################################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.AssignConrolValuesMembersEquity();
        }//--------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if ((!_hasUpdated && !_hasDeleted) && (!_membersEquityInfo.Equals(_tempMembersEquityInfo)))
            {
                String strMsg = "There has been changes made in the current member's equity information. \nExiting will not save this changes." +
                                "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//-----------------------
        //############################################END CLASS ShareCapitalCreditUpdate EVENTS#######################################################

        //##############################################BUTTON btnClose EVENTS########################################################
        //event is raised when the button is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//--------------------------
        //##############################################END BUTTON btnClose EVENTS########################################################

        //##############################################BUTTON btnUpdate EVENTS########################################################
        //event is raised when the button is clicked
        private void btnUpdateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to update the member's equity payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The member's equity payment has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _membersEquityInfo.ObjectState = DataRowState.Modified;

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        _memberManager.UpdateMembersEquity(_userInfo, _membersEquityInfo);

                        _membersEquityInfo = new CommonExchange.MemberEquityCredit();
                        _membersEquityInfo.MemberInfo = _memberInfo;                       

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        this.AssignConrolValuesMembersEquity();

                        _hasUpdated = true;

                        this.Cursor = Cursors.Arrow;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error updating member's equity payment.\n\n" + ex.Message, "Error Updating");
            }
        }//----------------------------
        //##############################################END BUTTON btnUpdate EVENTS########################################################

        //##############################################BUTTON btnDelete EVENTS########################################################
        //event is raised when the button is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to delete the member's equity payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The member's equity payment has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _membersEquityInfo.ObjectState = DataRowState.Deleted;

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        _memberManager.DeleteMembersEquity(_userInfo, _membersEquityInfo);

                        _membersEquityInfo = new CommonExchange.MemberEquityCredit();
                        _membersEquityInfo.MemberInfo = _memberInfo;                       

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        this.AssignConrolValuesMembersEquity();

                        _hasDeleted = true;

                        this.Cursor = Cursors.Arrow;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error deleting member's equity payment.\n\n" + ex.Message, "Error Deleting");
            }
        }//---------------------------
        //##############################################END BUTTON btnDelete EVENTS########################################################
        #endregion
    }
}
