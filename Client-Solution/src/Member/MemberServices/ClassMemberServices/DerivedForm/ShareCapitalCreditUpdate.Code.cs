using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class ShareCapitalCreditUpdate
    {
        #region Class Data Member Declaration
        private CommonExchange.ShareCapitalCredit _tempShareCapitalInfo;
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
        public ShareCapitalCreditUpdate(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, CommonExchange.ShareCapitalCredit shareCapitalInfo,
            MemberLogic memberManager)
            : base(userInfo, memberInfo, memberManager)
        {
            this.InitializeComponent();

            shareCapitalInfo.MemberInfo = memberInfo;
            _shareCapitalCreditInfo = shareCapitalInfo;
            _tempShareCapitalInfo = (CommonExchange.ShareCapitalCredit)shareCapitalInfo.Clone();

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
            this.AssignConrolValuesShareCapital();
        }//--------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if ((!_hasUpdated && !_hasDeleted) && (!_shareCapitalCreditInfo.Equals(_tempShareCapitalInfo)))
            {
                String strMsg = "There has been changes made in the current share capital information. \nExiting will not save this changes." +
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
                    String strMsg = "Are you sure you want to update the share capital credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The share capital credit payment has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _shareCapitalCreditInfo.ObjectState = DataRowState.Modified;

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        _memberManager.UpdateShareCapital(_userInfo, _shareCapitalCreditInfo);

                        _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();
                        _shareCapitalCreditInfo.MemberInfo = _memberInfo;                       

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        this.AssignConrolValuesShareCapital();

                        _hasUpdated = true;

                        this.Cursor = Cursors.Arrow;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error updating share capital credit payment.\n\n" + ex.Message, "Error Updating");
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
                    String strMsg = "Are you sure you want to delete the share capital credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The share capital credit payment has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _shareCapitalCreditInfo.ObjectState = DataRowState.Deleted;

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";


                        _memberManager.DeleteShareCapital(_userInfo, _shareCapitalCreditInfo);

                        _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();
                        _shareCapitalCreditInfo.MemberInfo = _memberInfo;
                      
                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        this.AssignConrolValuesShareCapital();

                        _hasDeleted = true;

                        this.Cursor = Cursors.Arrow;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error deleting share capital credit payment.\n\n" + ex.Message, "Error Deleting");
            }
        }//---------------------------
        //##############################################END BUTTON btnDelete EVENTS########################################################
        #endregion
    }
}
