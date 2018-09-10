using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class BankInformationUpdate
    {
        #region Class Data Member Declaration
        private CommonExchange.Bank _tempBankInfo;
        #endregion

        #region Class Properties Declarations
        private Boolean _hasUpdated = false;
        public Boolean HasUpdated
        {
            get { return _hasUpdated; }
        }
        #endregion

        #region Class Constructors
        public BankInformationUpdate(CommonExchange.SysAccess userInfo, CommonExchange.Bank bankInfo, DisbursementVoucherLogic disbursementManager)
            : base(userInfo, disbursementManager)
        {
            this.InitializeComponent();

            _bankInfo = bankInfo;
            _tempBankInfo = (CommonExchange.Bank)bankInfo.Clone();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
        }

        
        #endregion

        #region Class Event Void Procedures
        //#####################################CLASS BankInformationUpdate EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.txtBankName.Text = _bankInfo.BankName;
            this.txtBankAddress.Text = _bankInfo.BankAddress;
            this.txtAccountNo.Text = _bankInfo.AccountNo;
            this.txtAccountInformation.Text = _bankInfo.AccountInfo.AccountCode + " - " + _bankInfo.AccountInfo.AccountName;
        }//------------------------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasUpdated && !_bankInfo.Equals(_tempBankInfo))
            {
                String strMsg = "There has been changes made in the current bank information. \nExiting will not save this changes." +
                                "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//-----------------------
        //#####################################END CLASS BankInformationUpdate EVENTS########################################

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
                    String strMsg = "Are you sure you want to update the bank information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The bank information has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _bankInfo.ObjectState = DataRowState.Modified;

                        _disbursementManager.UpdateBankInformation(_userInfo, _bankInfo);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasUpdated = true;

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

        #endregion
    }
}
