using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class BankInformation
    {
        #region Class Data Member Declaration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.Bank _bankInfo;
        protected DisbursementVoucherLogic _disbursementManager;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructors
        public BankInformation()
        {
            this.InitializeComponent();
        }

        public BankInformation(CommonExchange.SysAccess userInfo, DisbursementVoucherLogic disbursementManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _disbursementManager = disbursementManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.txtBankName.Validated += new EventHandler(txtBankNameValidated);
            this.txtBankAddress.Validated += new EventHandler(txtBankAddressValidated);
            this.txtAccountNo.Validated += new EventHandler(txtAccountNoValidated);
            this.btnSearchAccountInformation.Click += new EventHandler(btnSearchAccountInformationClick);
            this.lblBankActive.Click += new EventHandler(lblBankActiveClick);
        }
        #endregion

        #region Class Properties Decleration
        //####################################################CLASS BankInformation EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _bankInfo = new CommonExchange.Bank();

            _bankInfo.IsActiveAccount = false;

            this.SetBankControlStatus();
        }//-------------------------
        //####################################################END CLASS BankInformation EVENTS###############################################

        //####################################################TEXTBOX txtBankName EVENTS###############################################
        //event is raised when the control is validate
        private void txtBankNameValidated(object sender, EventArgs e)
        {
            _bankInfo.BankName = BaseServices.ProcStatic.TrimStartEndString(this.txtBankName.Text);
        }//---------------------
        //####################################################END TEXTBOX txtBankName EVENTS###############################################

        //####################################################TEXTBOX txtBankAddress EVENTS###############################################
        //event is raised when the control is validate
        private void txtBankAddressValidated(object sender, EventArgs e)
        {
            _bankInfo.BankAddress = BaseServices.ProcStatic.TrimStartEndString(this.txtBankAddress.Text);
        }//--------------------
        //####################################################END TEXTBOX txtBankAddress EVENTS###############################################

        //####################################################TEXTBOX txtAccountNo. EVENTS###############################################
        //event is raised when the control is validate
        private void txtAccountNoValidated(object sender, EventArgs e)
        {
            _bankInfo.AccountNo = BaseServices.ProcStatic.TrimStartEndString(this.txtAccountNo.Text);
        }//-------------------
        //####################################################END TEXTBOX txtAccountNo. EVENTS###############################################

        //####################################################BUTTON btnSearchAccountInformation EVENTS###############################################
        //event is raised when the control is clicked
        private void btnSearchAccountInformationClick(object sender, EventArgs e)
        {
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _disbursementManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _bankInfo.AccountInfo = _disbursementManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtAccountInformation.Text = _bankInfo.AccountInfo.AccountCode + " - " + _bankInfo.AccountInfo.AccountName;
                }
            }
        }//---------------------------------
        //####################################################END BUTTON btnSearchAccountInformation EVENTS###############################################

        //####################################################LABEL lblBankActive EVENTS###############################################
        //event is raised when the control is clicked
        private void lblBankActiveClick(object sender, EventArgs e)
        {
            this.SetBankControlStatus();
        }//---------------------------------
        //####################################################END LABEL lblBankActive EVENTS###############################################
        #endregion

        #region Programmers-Defined Void Procedures
        //this procedure will set user status control
        public void SetBankControlStatus()
        {
            _bankInfo.IsActiveAccount = !_bankInfo.IsActiveAccount;

            if (_bankInfo.IsActiveAccount)
            {
                this.lblBankActive.Text = "ACTIVE";
                this.lblBankActive.ForeColor = Color.Green;
            }
            else
            {
                this.lblBankActive.Text = "DEACTIVATED";
                this.lblBankActive.ForeColor = Color.Red;
            }
        }//-----------------------
        #endregion

        #region Programmers-Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtBankName, String.Empty);
            _errProvider.SetError(this.txtBankAddress, String.Empty);
            _errProvider.SetError(this.txtAccountNo, String.Empty);
            _errProvider.SetError(this.txtAccountInformation, String.Empty);


            if (String.IsNullOrEmpty(_bankInfo.BankName))
            {
                _errProvider.SetError(this.txtBankName, "A bank name is required.");
                _errProvider.SetIconAlignment(this.txtBankName, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_bankInfo.BankAddress))
            {
                _errProvider.SetError(this.txtBankAddress, "A bank address is required.");
                _errProvider.SetIconAlignment(this.txtBankAddress, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_bankInfo.AccountNo))
            {
                _errProvider.SetError(this.txtAccountNo, "A bank account number is required.");
                _errProvider.SetIconAlignment(this.txtAccountNo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_bankInfo.AccountInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtAccountInformation, "You must select a account information.");
                _errProvider.SetIconAlignment(this.txtAccountInformation, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_disbursementManager.IsExistsBankNameAccountNumberBankInformation(_userInfo, _bankInfo.BankSysId, _bankInfo.BankName, _bankInfo.AccountNo))
            {
                _errProvider.SetError(this.txtBankName, "A bank name and account number already exist!");
                _errProvider.SetIconAlignment(this.txtBankName, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//---------------------------------
        #endregion
    }
}
