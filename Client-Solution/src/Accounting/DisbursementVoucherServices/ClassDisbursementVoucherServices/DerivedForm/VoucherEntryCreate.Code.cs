using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class VoucherEntryCreate
    {
        #region Class Properties Declarations
        private Boolean _hasCreated = false;
        public Boolean HasCreated
        {
            get { return _hasCreated; }
        }
        #endregion

        #region Class Constructors
        public VoucherEntryCreate(CommonExchange.SysAccess userInfo, DisbursementVoucherLogic disbursementManager, String payee)
            : base(userInfo, disbursementManager, payee)
        {
            this.InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnCancel.Click += new EventHandler(btnCancelClick);
            this.btnCreate.Click += new EventHandler(btnCreateClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS VoucherEntryCreate EVENTS###############################################
        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasCreated)
            {
                String strMsg = "Are you sure you want to cancel the creation of the new voucher entry?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }  
        }//--------------------------
        //####################################################END CLASS VoucherEntryCreate EVENTS###############################################

        //################################################BUTTON btnCancel EVENTS####################################################
        //event is raised when btnCancel is Clicked
        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------
        //################################################END BUTTON btnCancel EVENTS####################################################

        //################################################BUTTON btnCreate EVENTS####################################################
        //event is raised when btnAdd is Clicked
        private void btnCreateClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to create a voucher entry?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The voucher entry has been successfully created.";

                        this.Cursor = Cursors.WaitCursor;

                        _disbursmentManager.SequenceNo += 1;

                        _voucherEntryInfo.VoucherEntryId = _disbursmentManager.TempVoucherentryId;
                        _voucherEntryInfo.SequenceNo = _disbursmentManager.SequenceNo;

                        _disbursmentManager.TempVoucherentryId -= 1;

                        _voucherEntryInfo.ObjectState = DataRowState.Added;

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasCreated = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Createting");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//--------------------------
        //################################################END BUTTON btnCreate EVENTS####################################################
        #endregion
    }
}
