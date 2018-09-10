using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class VoucherEntry
    {
        #region Class Data Member Declaration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.VoucherEntry _voucherEntryInfo;
        protected DisbursementVoucherLogic _disbursmentManager;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Properties Declaration
        public CommonExchange.VoucherEntry VoucherEntryInfo
        {
            get { return _voucherEntryInfo; }
        }
        #endregion

        #region Class Constructors
        public VoucherEntry()
        {
            this.InitializeComponent();
        }

        public VoucherEntry(CommonExchange.SysAccess userInfo, DisbursementVoucherLogic disbursmentManager, String payee)
        {
            this.InitializeComponent();

            this.Text = payee;

            _userInfo = userInfo;
            _disbursmentManager = disbursmentManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.btnSearchAccount.Click += new EventHandler(btnSearchAccountClick);
            this.btnSearchDepartment.Click += new EventHandler(btnSearchDepartmentClick);
            this.txtDebit.KeyPress += new KeyPressEventHandler(txtAmountKeyPress);
            this.txtDebit.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtDebit.Validated += new EventHandler(txtDebitValidated);
            this.txtCredit.KeyPress += new KeyPressEventHandler(txtAmountKeyPress);
            this.txtCredit.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtCredit.Validated += new EventHandler(txtCreditValidated);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS Voucher Entry EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _voucherEntryInfo = new CommonExchange.VoucherEntry();
        }//------------------------
        //####################################################END CLASS Voucher Entry EVENTS###############################################

        //########################################BUTTON btnSearchAccount EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchAccountClick(object sender, EventArgs e)
        {
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _disbursmentManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);
                
                if (frmSearch.HasSelected)
                {
                    _voucherEntryInfo.AccountInfo = _disbursmentManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtAccount.Text = _voucherEntryInfo.AccountInfo.AccountName + "(" + _voucherEntryInfo.AccountInfo.AccountCode + ")";
                }
            }
        }//--------------------------
        //########################################END BUTTON btnSearchAccount EVENTS#####################################################

        //########################################BUTTON btnSearchDepartment EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchDepartmentClick(object sender, EventArgs e)
        {
            using (CostCenterSearchOnTextBoxList frmSearch = new CostCenterSearchOnTextBoxList(_userInfo, _disbursmentManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _voucherEntryInfo.CostCenterInfo = _disbursmentManager.GetCostCenterDetails(frmSearch.PrimaryId);

                    this.txtDepartment.Text = _voucherEntryInfo.CostCenterInfo.DepartmentName;
                }
            }
        }//-------------------------
        //########################################END BUTTON btnSearchDepartment EVENTS#####################################################

        //###########################################TEXTBOX txtAmount EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//-------------------------

        //event is raised when the control is validating
        private void txtAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//----------------------------
        //###########################################END TEXTBOX txtAmount EVENTS#####################################################

        //###########################################TEXTBOX txtCredit EVENTS#####################################################
        //event is raised when the key is validated
        private void txtCreditValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtCredit.Text, out amount))
            {
                _voucherEntryInfo.CreditAmount = amount;
            }
        }//------------------------
        //###########################################END TEXTBOX txtCredit EVENTS#####################################################

        //###########################################TEXTBOX txtDebit EVENTS#####################################################
        //event is raised when the key is validated
        private void txtDebitValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtDebit.Text, out amount))
            {
                _voucherEntryInfo.DebitAmount = amount;
            }
        }//------------------------
        //###########################################END TEXTBOX txtDebit EVENTS#####################################################
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtAccount, String.Empty);
            _errProvider.SetError(this.txtDepartment, String.Empty);
            _errProvider.SetError(this.txtCredit, String.Empty);
            _errProvider.SetError(this.txtDebit, String.Empty);

            if (String.IsNullOrEmpty(_voucherEntryInfo.AccountInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtAccount, "You must select an account information.");
                _errProvider.SetIconAlignment(this.txtAccount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_voucherEntryInfo.CostCenterInfo.DepartmentId))
            {
                _errProvider.SetError(this.txtDepartment, "You must select a department information.");
                _errProvider.SetIconAlignment(this.txtDepartment, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_voucherEntryInfo.DebitAmount <= 0 && _voucherEntryInfo.CreditAmount <= 0)
            {
                _errProvider.SetError(this.txtDebit, "A debit or a credit amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtDebit, ErrorIconAlignment.MiddleRight);

                _errProvider.SetError(this.txtCredit, "A debit or a credit amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtCredit, ErrorIconAlignment.MiddleRight);

                isValid = false;           
            }

            return isValid;
        }//-------------------------
        #endregion
    }
}
