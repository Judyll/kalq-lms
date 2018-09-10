using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class DisbursementVoucher
    {
        #region Class Data Memember Declaration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.DisbursementVoucher _disbursementInfo;
        protected DisbursementVoucherLogic _disbursementManager;

        private Int32 _rowIndex = -1;
        private String _primaryId = String.Empty;
        private Int32 _primaryIndex = 0;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructors
        public DisbursementVoucher()
        {
            this.InitializeComponent();
        }

        public DisbursementVoucher(CommonExchange.SysAccess userInfo, DisbursementVoucherLogic disbursementManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _disbursementManager = disbursementManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.txtCheckNo.Validated += new EventHandler(txtCheckNoValidated);
            this.txtPayee.Validated += new EventHandler(txtPayeeValidated);
            this.txtParticulars.Validated += new EventHandler(txtParticularsValidated);
            this.txtCheckAmount.KeyPress += new KeyPressEventHandler(txtCheckAmountKeyPress);
            this.txtCheckAmount.Validating += new System.ComponentModel.CancelEventHandler(txtCheckAmountValidating);
            this.txtCheckAmount.Validated += new EventHandler(txtCheckAmountValidated);
            this.dtpCheckDate.ValueChanged += new EventHandler(dtpCheckDateValueChanged);
            this.btnSearchBank.Click += new EventHandler(btnSearchBankClick);
            this.btnSearchPayee.Click += new EventHandler(btnSearchPayeeClick);
            this.btnRemovePayee.Click += new EventHandler(btnRemovePayeeClick);
            this.dgvList.MouseDown += new MouseEventHandler(dgvListMouseDown);
            this.dgvList.DoubleClick += new EventHandler(dgvListDoubleClick);
            this.dgvList.KeyPress += new KeyPressEventHandler(dgvListKeyPress);
            this.dgvList.KeyDown += new KeyEventHandler(dgvListKeyDown);
            this.dgvList.DataSourceChanged += new EventHandler(dgvListDataSourceChanged);
            this.dgvList.SelectionChanged += new EventHandler(dgvListSelectionChanged);
            this.lnkCreateVouchEntry.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateVouchEntryLinkClicked);
            this.lblAddVoucherBefore.Click += new EventHandler(lblAddVoucherBeforeClick);
            this.lblAddVoucherAfter.Click += new EventHandler(lblAddVoucherAfterClick);
            this.lblDeleteVoucherEntry.Click += new EventHandler(lblDeleteVoucherEntryClick);
            this.lnkPrintVoucher.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkPrintVoucherLinkClicked);
        }        
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS DisbursementVoucher EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _disbursementInfo = new CommonExchange.DisbursementVoucher();

            _disbursementInfo.CheckDate = this.dtpCheckDate.Value.ToShortDateString();

            this.dgvList.DataSource = _disbursementManager.VoucherEntryTable;

            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvList, false);
        }//---------------------------
        //####################################################END CLASS DisbursementVoucher EVENTS###############################################

        //###########################################TEXTBOX txtCheckAmount EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtCheckAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//-------------------------

        //event is raised when the control is validating
        private void txtCheckAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//----------------------------

        //event is raised when the control is validated
        private void txtCheckAmountValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtCheckAmount.Text, out amount))
            {
                _disbursementInfo.CheckAmount = amount;

                this.lnkPrintVoucher.Enabled = false;
            }
        }//-----------------------------
        //###########################################END TEXTBOX txtCheckAmount EVENTS#####################################################

        //########################################TEXTBOX txtCheckNo EVENTS#####################################################
        //event is raised when the control is validated
        private void txtCheckNoValidated(object sender, EventArgs e)
        {
            _disbursementInfo.CheckNo = BaseServices.ProcStatic.TrimStartEndString(this.txtCheckNo.Text);

            this.lnkPrintVoucher.Enabled = false;
        }//------------------------
        //########################################END TEXTBOX txtCheckNo EVENTS#####################################################

        //########################################TEXTBOX txtPayee EVENTS#####################################################
        //event is raised when the control is validated
        private void txtPayeeValidated(object sender, EventArgs e)
        {
            _disbursementInfo.Payee = BaseServices.ProcStatic.TrimStartEndString(this.txtPayee.Text);

            this.lnkPrintVoucher.Enabled = false;
        }//-----------------------
        //########################################END TEXTBOX txtPayee EVENTS#####################################################

        //########################################TEXTBOX txtParticulars EVENTS#####################################################
        //event is raised when the control is validated
        private void txtParticularsValidated(object sender, EventArgs e)
        {
            _disbursementInfo.Particulars = BaseServices.ProcStatic.TrimStartEndString(this.txtParticulars.Text);

            this.lnkPrintVoucher.Enabled = false;
        }//-----------------------
        //########################################END TEXTBOX txtParticulars EVENTS#####################################################

        //########################################DATETIMEPICKER dtpCheckDate EVENTS#####################################################
        //event is raised when the value is changed
        protected virtual void dtpCheckDateValueChanged(object sender, EventArgs e)
        {
            _disbursementInfo.CheckDate = this.dtpCheckDate.Value.ToShortDateString();

            this.lnkPrintVoucher.Enabled = false;
        }//----------------------
        //########################################END DATETIMEPICKER dtpCheckDate EVENTS#####################################################

        //########################################BUTTON btnSearchBank EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchBankClick(object sender, EventArgs e)
        {
            using (SearchBankInformationOnTextBoxList frmSearch = new SearchBankInformationOnTextBoxList(_userInfo, _disbursementManager))
            {
                frmSearch.AdoptGridSize = false;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _disbursementInfo.BankInfo = _disbursementManager.GetBankInformationDetails(frmSearch.PrimaryId);

                    this.txtBank.Text = _disbursementInfo.BankInfo.BankName;

                    this.lnkPrintVoucher.Enabled = false;
                }
            }
        }//---------------------
        //########################################END BUTTON btnSearchBank EVENTS#####################################################

        //########################################BUTTON btnSearchPayee EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchPayeeClick(object sender, EventArgs e)
        {
            using (DisbursementPayeeSearchOnTextBoxList frmSearch = new DisbursementPayeeSearchOnTextBoxList(_userInfo, _disbursementManager))
            {
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    if (!_disbursementManager.IsPayeeForRegularLoan(frmSearch.PrimaryId))
                    {
                        _disbursementInfo.InHouseDebitInfo = _disbursementManager.GetInHouseHospitalizationDebitInfoDetails(frmSearch.PrimaryId,
                            this.txtParticulars, this.txtCheckAmount);
                 
                        this.txtPayee.Text = _disbursementInfo.Payee =
                            BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_disbursementInfo.InHouseDebitInfo.MemberInfo.PersonInfo.LastName,
                            _disbursementInfo.InHouseDebitInfo.MemberInfo.PersonInfo.FirstName, _disbursementInfo.InHouseDebitInfo.MemberInfo.PersonInfo.MiddleName);

                        _disbursementInfo.Particulars = this.txtParticulars.Text;
                        _disbursementInfo.CheckAmount = Decimal.Parse(this.txtCheckAmount.Text);
                    }
                    else
                    {
                        _disbursementInfo.RegularLoanInfo = _disbursementManager.GetRegularLoanInfoForDisbursmentDetails(frmSearch.PrimaryId, 
                            this.txtParticulars, this.txtCheckAmount);

                        this.txtPayee.Text = _disbursementInfo.Payee =
                            BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_disbursementInfo.RegularLoanInfo.MemberInfo.PersonInfo.LastName,
                            _disbursementInfo.RegularLoanInfo.MemberInfo.PersonInfo.FirstName, _disbursementInfo.RegularLoanInfo.MemberInfo.PersonInfo.MiddleName);

                        _disbursementInfo.Particulars = this.txtParticulars.Text;
                        _disbursementInfo.CheckAmount = Decimal.Parse(this.txtCheckAmount.Text);
                    }

                    this.lnkPrintVoucher.Enabled = false;
                    this.txtCheckAmount.ReadOnly = true;
                }
            }
        }//---------------------
        //########################################END BUTTON btnSearchPayee EVENTS#####################################################

        //########################################BUTTON btnRemovePayee EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnRemovePayeeClick(object sender, EventArgs e)
        {
            _disbursementInfo.InHouseDebitInfo = new CommonExchange.InHouseHospitalizationDebit();
            _disbursementInfo.RegularLoanInfo = new CommonExchange.RegularLoan();

            _disbursementInfo.CheckAmount = 0;
            _disbursementInfo.Particulars = String.Empty;

            this.txtPayee.Text = this.txtParticulars.Text = this.txtCheckAmount.Text = String.Empty;

            this.txtCheckAmount.ReadOnly = false;
        }//-----------------------
        //########################################END BUTTON btnRemovePayee EVENTS#####################################################

        //##################################DATAGRIDVIEW dgvList EVENTS##########################################################
        //event is raised when the mouse is down
        protected virtual void dgvListMouseDown(object sender, MouseEventArgs e)
        {
            this.dgvList.Focus();

            DataGridView.HitTestInfo hitTest = this.dgvList.HitTest(e.X, e.Y);

            switch (hitTest.Type)
            {
                case DataGridViewHitTestType.RowHeader:
                    _rowIndex = hitTest.RowIndex;
                    this.dgvList.ContextMenuStrip = lnkAddVoucherEntry;

                    this.dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    this.dgvList.Rows[hitTest.RowIndex].Selected = true;
                    break;
                case DataGridViewHitTestType.Cell:
                    this.dgvList.ContextMenuStrip = null;
                    this.dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                default:
                    _rowIndex = -1;
                    this.dgvList.ContextMenuStrip = null;
                    break;
            }
        }//---------------------

        //event is raised when the mouse is double clicked
        protected virtual void dgvListDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryId))
            {
                using (VoucherEntryUpdate frmUpdate = new VoucherEntryUpdate(_userInfo, _disbursementManager.GetVoucherEntryInformationDetails(_disbursementInfo.VoucherEntryList,
                    _primaryId), _disbursementManager, _disbursementInfo.Payee))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        // _disbursementInfo.VoucherEntryList.RemoveAt(_rowIndex);
                        //_disbursementInfo.VoucherEntryList.Insert(_rowIndex, frmUpdate.VoucherEntryInfo);

                        _disbursementManager.SetVoucherEntrySequenceNo(_disbursementInfo.VoucherEntryList);
                        this.dgvList.DataSource = _disbursementManager.SetVoucherEntryTable(_disbursementInfo.VoucherEntryList, this.lblDebit, this.lblCredit);

                        this.lnkPrintVoucher.Enabled = false;
                    }
                }
            }
        } //---------------------------------

        //event is raised when the key is pressed        
        protected virtual void dgvListKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryId = row.Cells[_primaryIndex].Value.ToString();
                }
            }
            else
            {
                e.Handled = true;
            }
        } //-----------------------------------

        //event is raised when the key is up
        protected virtual void dgvListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        } //--------------------------------------

        //event is raised when the data source is changed
        protected virtual void dgvListDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryId = dgvBase[_primaryIndex, 0].Value.ToString();
            }
            else
            {
                _primaryId = "";
            }
        } //--------------------------------

        //event is raised when the selection is changed
        protected virtual void dgvListSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryId = row.Cells[_primaryIndex].Value.ToString();
                _rowIndex = row.Index;
            }
        } //------------------------------------
        //##################################END DATAGRIDVIEW dgvList EVENTS##########################################################

        //########################################LINK LABEL lnkCreateVouchEntry EVENTS#####################################################
        //event is raised when the control link is clicked
        private void lnkCreateVouchEntryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (VoucherEntryCreate frmCreate = new VoucherEntryCreate(_userInfo, _disbursementManager, _disbursementInfo.Payee))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    _disbursementInfo.VoucherEntryList.Add(frmCreate.VoucherEntryInfo);

                    this.lnkPrintVoucher.Enabled = false;
                }
            }

            _disbursementManager.SetVoucherEntrySequenceNo(_disbursementInfo.VoucherEntryList);
            this.dgvList.DataSource = _disbursementManager.SetVoucherEntryTable(_disbursementInfo.VoucherEntryList, this.lblDebit, this.lblCredit);
        }//---------------------------
        //########################################END LINK LABEL lnkCreateVouchEntry EVENTS#####################################################

        //########################################LABEL lblAddVoucherBefore EVENTS#####################################################
        //event is raised when the control link is clicked
        private void lblAddVoucherBeforeClick(object sender, EventArgs e)
        {
            using (VoucherEntryCreate frmCreate = new VoucherEntryCreate(_userInfo, _disbursementManager, _disbursementInfo.Payee))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    if (_rowIndex > 0)
                    {
                        _disbursementInfo.VoucherEntryList.Insert(_rowIndex, frmCreate.VoucherEntryInfo);
                    }
                    else
                    {
                        _disbursementInfo.VoucherEntryList.Insert(0, frmCreate.VoucherEntryInfo);
                    }

                    this.lnkPrintVoucher.Enabled = false;
                }
            }

            _disbursementManager.SetVoucherEntrySequenceNo(_disbursementInfo.VoucherEntryList);
            this.dgvList.DataSource = _disbursementManager.SetVoucherEntryTable(_disbursementInfo.VoucherEntryList, this.lblDebit, this.lblCredit);
        }//----------------------
        //########################################END LABEL lblAddVoucherBefore EVENTS#####################################################

        //########################################LABEL lblAddVoucherAfter EVENTS#####################################################
        //event is raised when the control link is clicked
        private void lblAddVoucherAfterClick(object sender, EventArgs e)
        {
            using (VoucherEntryCreate frmCreate = new VoucherEntryCreate(_userInfo, _disbursementManager, _disbursementInfo.Payee))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    _disbursementInfo.VoucherEntryList.Insert(_rowIndex + 1, frmCreate.VoucherEntryInfo);

                    this.lnkPrintVoucher.Enabled = false;
                }
            }

            _disbursementManager.SetVoucherEntrySequenceNo(_disbursementInfo.VoucherEntryList);
            this.dgvList.DataSource = _disbursementManager.SetVoucherEntryTable(_disbursementInfo.VoucherEntryList, this.lblDebit, this.lblCredit);
        }//---------------------------
        //########################################END LABEL lblAddVoucherAfter EVENTS#####################################################

        //########################################LABEL lblDeleteVoucherEntry EVENTS#####################################################
        //event is raised when the control link is clicked
        private void lblDeleteVoucherEntryClick(object sender, EventArgs e)
        {
            _disbursementInfo.VoucherEntryList[_rowIndex].ObjectState = DataRowState.Deleted;

            _disbursementManager.SetVoucherEntrySequenceNo(_disbursementInfo.VoucherEntryList);
            this.dgvList.DataSource = _disbursementManager.SetVoucherEntryTable(_disbursementInfo.VoucherEntryList, this.lblDebit, this.lblCredit);
        }//-----------------------------
        //########################################END LABEL lblDeleteVoucherEntry EVENTS#####################################################

        //########################################LINKLABEL lnkPrintVoucher EVENTS#####################################################
        //event is raised when the control link is clicked
        private void lnkPrintVoucherLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _disbursementManager.PrintDisbursementVoucher(_disbursementInfo, this);

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error Printing Disbursement Voucher. \n" + ex.Message, "Error Printing");
            }
        }//---------------------------
        //########################################END LINKLABEL lnkPrintVoucher EVENTS#####################################################
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnSearchBank, String.Empty);
            _errProvider.SetError(this.txtCheckNo, String.Empty);
            _errProvider.SetError(this.dtpCheckDate, String.Empty);
            _errProvider.SetError(this.txtPayee, String.Empty);
            _errProvider.SetError(this.txtCheckAmount, String.Empty);
            _errProvider.SetError(this.gbxVoucherEntry, String.Empty);
            _errProvider.SetError(this.txtCheckAmount, String.Empty);
            _errProvider.SetError(this.lblCredit, String.Empty);
            _errProvider.SetError(this.lblDebit, String.Empty);

            if (String.IsNullOrEmpty(_disbursementInfo.BankInfo.BankSysId))
            {
                _errProvider.SetError(this.btnSearchBank, "You must select a bank information.");
                _errProvider.SetIconAlignment(this.btnSearchBank, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_disbursementInfo.CheckNo))
            {
                _errProvider.SetError(this.txtCheckNo, "Checked number is required.");
                _errProvider.SetIconAlignment(this.txtCheckNo, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }
            else if (_disbursementManager.IsExistsBankCheckNoDisbursementVoucherInformation(_userInfo, _disbursementInfo.VoucherSysId,
                _disbursementInfo.BankInfo.BankSysId, _disbursementInfo.CheckNo))
            {
                _errProvider.SetError(this.txtCheckNo, "Checked number is already exist.");
                _errProvider.SetIconAlignment(this.txtCheckNo, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_disbursementInfo.CheckDate))
            {
                _errProvider.SetError(this.dtpCheckDate, "Checked date is required.");
                _errProvider.SetIconAlignment(this.dtpCheckDate, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_disbursementInfo.Payee))
            {
                _errProvider.SetError(this.txtPayee, "You must provide a payee information.");
                _errProvider.SetIconAlignment(this.txtPayee, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }

            if (_disbursementInfo.CheckAmount <= 0)
            {
                _errProvider.SetError(this.txtCheckAmount, "Check amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtCheckAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (!_disbursementManager.IsValidVoucherEntryList(_disbursementInfo.VoucherEntryList))
            {
                _errProvider.SetError(this.gbxVoucherEntry, "At least one voucher entry is required.");
                _errProvider.SetIconAlignment(this.gbxVoucherEntry, ErrorIconAlignment.TopLeft);

                isValid = false;
            }

            if (Decimal.Parse(this.lblDebit.Text) != Decimal.Parse(this.lblCredit.Text))
            {
                _errProvider.SetError(this.lblDebit, "Debit must be equal to credit amount.");
                _errProvider.SetIconAlignment(this.lblDebit, ErrorIconAlignment.BottomRight);

                _errProvider.SetError(this.lblCredit, "Credit must be equal to debit amount.");
                _errProvider.SetIconAlignment(this.lblCredit, ErrorIconAlignment.BottomRight);

                isValid = false;
            }
            //else if (Decimal.Parse(this.lblDebit.Text) != _disbursementInfo.CheckAmount)
            //{
            //    _errProvider.SetError(this.lblDebit, "Debit and Credit amount must be equal to check amount.");
            //    _errProvider.SetIconAlignment(this.lblDebit, ErrorIconAlignment.BottomRight);

            //    _errProvider.SetError(this.lblCredit, "Debit and Credit amount must be equal to check amount.");
            //    _errProvider.SetIconAlignment(this.lblCredit, ErrorIconAlignment.BottomRight);

            //    _errProvider.SetError(this.txtCheckAmount, "Debit and Credit amount must be equal to check amount.");
            //    _errProvider.SetIconAlignment(this.txtCheckAmount, ErrorIconAlignment.BottomRight);

            //    isValid = false;
            //}

            return isValid;
        }//---------------
        #endregion
    }
}
