using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class VoucherEntryUpdate
    {
        #region Class Data Member Declaration
        private CommonExchange.VoucherEntry _tempVoucherEntry;
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
        public VoucherEntryUpdate(CommonExchange.SysAccess userInfo, CommonExchange.VoucherEntry voucherEntryInfo, 
            DisbursementVoucherLogic disbursmentManager, String payee)
            : base(userInfo, disbursmentManager, payee)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _disbursmentManager = disbursmentManager;

            _voucherEntryInfo = voucherEntryInfo;
            _tempVoucherEntry = (CommonExchange.VoucherEntry)voucherEntryInfo.Clone();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS VoucherEntryUpdate EVENTS###############################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.txtAccount.Text = _voucherEntryInfo.AccountInfo.AccountName + "(" + _voucherEntryInfo.AccountInfo.AccountCode + ")";
            this.txtDepartment.Text = _voucherEntryInfo.CostCenterInfo.DepartmentName;
            this.txtCredit.Text = _voucherEntryInfo.CreditAmount.ToString("N");
            this.txtDebit.Text = _voucherEntryInfo.DebitAmount.ToString("N");
        }//------------------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!(_hasUpdated || _hasDeleted) && !_voucherEntryInfo.Equals(_tempVoucherEntry))
            {
                String strMsg = "There has been changes made in the current voucher entry. \nExiting will not save this changes." +
                                "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//--------------------------
        //####################################################END CLASS VoucherEntryUpdate EVENTS###############################################

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
                    String strMsg = "Are you sure you want to update the voucher entry?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The voucher entry has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        if (_voucherEntryInfo.ObjectState != DataRowState.Added)
                        {
                            _voucherEntryInfo.ObjectState = DataRowState.Modified;
                        }

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
                    String strMsg = "Are you sure you want to delete the voucher entry?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The voucher entry has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        //if (_voucherEntryInfo.ObjectState != DataRowState.Added)
                        //{
                            _voucherEntryInfo.ObjectState = DataRowState.Deleted;
                        //}
                      
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
        }//------------------------
        //#####################################END BUTTON btnDelete EVENTS########################################
        #endregion
    }
}
