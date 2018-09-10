using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class DisbursementVoucherRecord
    {
        #region Class Data Member Declaration
        private CommonExchange.DisbursementVoucher _tempDisbursementVoucherInfo;
        #endregion

        #region Class Properties Declarations
        private Boolean _hasRecorded = false;
        public Boolean HasRecorded
        {
            get { return _hasRecorded; }
        }
        #endregion

        #region Class Data Member Declaration
        public DisbursementVoucherRecord(CommonExchange.SysAccess userInfo, DisbursementVoucherLogic disbursementManager)
            : base(userInfo, disbursementManager)
        {
            this.InitializeComponent();

            _disbursementInfo = new CommonExchange.DisbursementVoucher();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnRecord.Click += new EventHandler(btnRecordClick);
        }

        public DisbursementVoucherRecord(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher disbursementInfo, DisbursementVoucherLogic disbursementManager)
            : base(userInfo, disbursementManager)
        {
            this.InitializeComponent();            

            _disbursementInfo = disbursementInfo;

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnRecord.Click += new EventHandler(btnRecordClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS DisbursementVoucherRecord EVENTS###############################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_disbursementInfo.VoucherSysId))
            {
                base.ClassLoad(sender, e);

                this.btnDelete.Enabled = this.lnkPrintVoucher.Enabled = false;                
            }
            else
            {
                this.btnDelete.Enabled = true;

                this.lblSysID.Text = _disbursementInfo.VoucherSysId;
                this.txtCheckNo.Text = _disbursementInfo.CheckNo;
                this.txtPayee.Text = _disbursementInfo.Payee;
                this.txtParticulars.Text = _disbursementInfo.Particulars;
                this.txtCheckAmount.Text = _disbursementInfo.CheckAmount.ToString("N");
                this.txtBank.Text = _disbursementInfo.BankInfo.BankName;

                this.Text = _disbursementInfo.Payee;

                if (!String.IsNullOrEmpty(_disbursementInfo.InHouseDebitInfo.InHouseDebitSysId) ||
                    !String.IsNullOrEmpty(_disbursementInfo.RegularLoanInfo.RegularLoanSysId))
                {
                    this.txtCheckAmount.ReadOnly = true;
                }
                else
                {
                    this.txtCheckAmount.ReadOnly = false;
                }

                DateTime chkDate = DateTime.MinValue;

                if (DateTime.TryParse(_disbursementInfo.CheckDate, out chkDate))
                {
                    this.dtpCheckDate.Value = chkDate;
                }

                _tempDisbursementVoucherInfo = (CommonExchange.DisbursementVoucher)_disbursementInfo.Clone();

                this.dgvList.DataSource = _disbursementManager.SetVoucherEntryTable(_disbursementInfo.VoucherEntryList, this.lblDebit, this.lblCredit);
                BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvList, false);

                this.SetRecordLocking();

                if (_disbursementInfo.IsMarkedDeleted)
                {
                    this.lblStatus.Text = "C A N C E L L E D";
                    this.lnkPrintVoucher.Enabled = this.btnDelete.Enabled = this.btnRecord.Enabled = this.btnSearchBank.Enabled =
                        this.btnSearchPayee.Enabled = this.lnkCreateVouchEntry.Enabled = false;

                    this.dgvList.MouseDown -= new MouseEventHandler(dgvListMouseDown);
                    this.dgvList.DoubleClick -= new EventHandler(dgvListDoubleClick);
                    this.dgvList.KeyPress -= new KeyPressEventHandler(dgvListKeyPress);
                    this.dgvList.KeyDown -= new KeyEventHandler(dgvListKeyDown);
                    this.dgvList.DataSourceChanged -= new EventHandler(dgvListDataSourceChanged);
                    this.dgvList.SelectionChanged -= new EventHandler(dgvListSelectionChanged);
                }
                else
                {
                    this.lnkPrintVoucher.Enabled = true;
                }               
            }
        }//------------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasRecorded && (_tempDisbursementVoucherInfo != null && !_disbursementInfo.Equals(_tempDisbursementVoucherInfo)))
            {
                String strMsg = "There has been changes made in the current disbursement voucher module. \nExiting will not save this changes." + "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//--------------------------
        //####################################################END CLASS VoucherEntryRecored EVENTS###############################################

        //################################################BUTTON btnCancel EVENTS####################################################
        //event is raised when btnCancel is Clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------
        //################################################END BUTTON btnCancel EVENTS####################################################

        //########################################DATETIMEPICKER dtpCheckDate EVENTS#####################################################
        //event is raised when the value is changed
        protected override void dtpCheckDateValueChanged(object sender, EventArgs e)
        {
            this.SetRecordLocking();
        }//----------------------
        //########################################END DATETIMEPICKER dtpCheckDate EVENTS#####################################################

        //################################################BUTTON btnRecord EVENTS####################################################
        //event is raised when control is clicked
        private void btnRecordClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to record a disbursement voucher information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The disbursement voucher information has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        if (String.IsNullOrEmpty(_disbursementInfo.VoucherSysId))
                        {
                            _disbursementInfo.ObjectState = DataRowState.Added;
                        }
                        else
                        {
                            _disbursementInfo.ObjectState = DataRowState.Modified;
                        }

                        _disbursementManager.InsertUpdateDisbursementVoucherInformation(_userInfo,ref _disbursementInfo);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasRecorded = true;

                        this.lnkPrintVoucher.Enabled = true;
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
        }//--------------------------
        //################################################END BUTTON btnCreate EVENTS####################################################

        //#####################################BUTTON btnDelete EVENTS########################################
        //event is raised when the control is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to delete the disbursement voucher information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The disbursement voucher information has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _disbursementInfo.ObjectState = DataRowState.Deleted;

                        _disbursementManager.DeleteDisbursementVoucherInformation(_userInfo, _disbursementInfo);

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
        }//------------------------
        //#####################################END BUTTON btnDelete EVENTS########################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will set record locking
        private void SetRecordLocking()
        {
            if (!String.IsNullOrEmpty(_disbursementInfo.CheckDate) && !String.IsNullOrEmpty(_disbursementManager.ServerDateTime))
            {
                if (RemoteClient.ProcStatic.IsRecordLocked(4, DateTime.Parse(_disbursementInfo.CheckDate), DateTime.Parse(_disbursementManager.ServerDateTime)))
                {
                    lblStatus.Text = "This record is LOCKED.";

                    this.pbxLocked.Visible = true;
                    this.pbxUnlock.Visible = false;

                    this.btnRecord.Enabled = this.btnDelete.Enabled = this.lnkCreateVouchEntry.Enabled = false;
                }
                else
                {
                    lblStatus.Text = "This record is OPEN.";

                    this.pbxLocked.Visible = false;
                    this.pbxUnlock.Visible = true;

                    this.btnRecord.Enabled = this.btnDelete.Enabled = this.lnkCreateVouchEntry.Enabled = true;
                }
            }

        }//--------------------------
        #endregion
    }
}
