using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace MemberServices
{
    partial class ShareCapitalCreditCreate
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
        public ShareCapitalCreditCreate(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, MemberLogic memberManager)
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
                String strMsg = "Are you sure you want to cancel the share capital credit information create?";
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
                    String strMsg = "Are you sure you want to record the new share capital credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The share capital credit payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _shareCapitalCreditInfo.ObjectState = DataRowState.Added;

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        
                        _memberManager.InsertShareCapital(_userInfo, _shareCapitalCreditInfo);

                        _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();
                        _shareCapitalCreditInfo.MemberInfo = _memberInfo;
                       
                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasCreated = true;

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        
                        this.AssignConrolValuesShareCapital();

                        this.Cursor = Cursors.Arrow;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error inserting share capital credit payment.\n\n" + ex.Message, "Error Inserting");
            }
        }//-------------------------
        //#############################################END BUTTON btnProceed EVENTS########################################################
        #endregion
    }
}
