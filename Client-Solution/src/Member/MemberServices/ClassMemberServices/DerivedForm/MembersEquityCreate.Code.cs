using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace MemberServices
{
    partial class MembersEquityCreate
    {
        #region Class Properties Declaration
        private Boolean _hasCreated = false;
        public Boolean HasCreated
        {
            get { return _hasCreated; }
        }

        private Boolean _allowMultipleInsert = false;
        public Boolean AllowMultipleInsert
        {
            get { return _allowMultipleInsert; }
            set { _allowMultipleInsert = value; }
        }
        #endregion  

        #region Class Constructors
        public MembersEquityCreate(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, MemberLogic memberManager)
            : base(userInfo, memberInfo, memberManager)
        {
            this.InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.chkAllowMultipleInsert.CheckedChanged += new EventHandler(chkAllowMultipleInsertCheckedChanged);
            this.btnCancel.Click += new EventHandler(btnCancelClick);
            this.btnCreate.Click += new EventHandler(btnCreateClick);
        }
        #endregion

        #region Class Event Void Procedures
        //############################################CLASS ShareCapitalCreditCreate EVENTS#######################################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            base.ClassLoad(sender, e);

            this.chkAllowMultipleInsert.Checked = _allowMultipleInsert;
        }//--------------------

        //event is raised when the class is closing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasCreated)
            {
                String strMsg = "Are you sure you want to cancel the member's equity information create?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//---------------------
        //############################################END CLASS ShareCapitalCreditCreate EVENTS#######################################################

        //##################################CHECKBOX chkAllowMultipleInsert EVENTS######################################################
        //event is raised when the checked status is changed
        private void chkAllowMultipleInsertCheckedChanged(object sender, EventArgs e)
        {
            _allowMultipleInsert = this.chkAllowMultipleInsert.Checked;
        }//--------------------
        //##################################END CHECKBOX chkAllowMultipleInsert EVENTS######################################################

        //##############################################BUTTON btnCancel EVENTS########################################################
        //event is raised when the button is clicked
        private void btnCancelClick(object sender, EventArgs e)
        {
            _allowMultipleInsert = false;

            this.Close();
        }//-----------------------------
        //##############################################END BUTTON btnCancel EVENTS########################################################

        //#############################################BUTTON btnCreate EVENTS########################################################
        //event is raised when the button is clicked
        private void btnCreateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to record the new member's equity payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The member's equity payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _membersEquityInfo.ObjectState = DataRowState.Added;

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        _memberManager.InsertMembersEquity(_userInfo, _membersEquityInfo);

                        _membersEquityInfo = new CommonExchange.MemberEquityCredit();
                        _membersEquityInfo.MemberInfo = _memberInfo;                       

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasCreated = true;

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        this.AssignConrolValuesMembersEquity();

                        this.Cursor = Cursors.Arrow;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error inserting member's equity payment.\n\n" + ex.Message, "Error Inserting");
            }
        }//-------------------------
        //#############################################END BUTTON btnProceed EVENTS########################################################
        #endregion
    }
}
