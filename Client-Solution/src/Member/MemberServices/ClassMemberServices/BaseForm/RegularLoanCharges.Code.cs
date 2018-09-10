using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    partial class RegularLoanCharges
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.RegularLoanCharges _regularloanChargesInfo;
        protected LoanLogic _loanManager;

        private String _regularLoanSysId = String.Empty;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Properties Declearation
        public CommonExchange.RegularLoanCharges RegularLoanChargesInfo
        {
            get { return _regularloanChargesInfo; }
        }
        #endregion

        #region Class Constructors
        public RegularLoanCharges()
        {
            this.InitializeComponent();
        }

        public RegularLoanCharges(CommonExchange.SysAccess userInfo, LoanLogic loanManager, String regularLoanSysId)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _loanManager = loanManager;

            _regularLoanSysId = regularLoanSysId;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.btnSearchLoanCharges.Click += new EventHandler(btnSearchLoanChargesClick);
            this.txtChargeAmount.KeyPress += new KeyPressEventHandler(txtChargeAmountKeyPress);
            this.txtChargeAmount.Validating += new System.ComponentModel.CancelEventHandler(txtChargeAmountValidating);
            this.txtChargeAmount.Validated += new EventHandler(txtChargeAmountValidated);
            this.txtLoanCharges.Validated += new EventHandler(txtLoanChargesValidated);
            this.btnClearSummaryAccount.Click += new EventHandler(btnClearSummaryAccountClick);
        }         
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS RegularLoanCharges EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _regularloanChargesInfo = new CommonExchange.RegularLoanCharges();
        }//---------------------------
        //####################################################END CLASS RegularLoanCharges EVENTS###############################################    

        //####################################################BUTTON btnSearchLoanCharges EVENTS###############################################
        //event is raised when the control is clicked
        private void btnSearchLoanChargesClick(object sender, EventArgs e)
        {
            using (LoanChargesSearchOnTextBoxList frmSearch = new LoanChargesSearchOnTextBoxList(_userInfo, _loanManager))
            {
                frmSearch.AdoptGridSize = false;
                frmSearch.PrimaryIndex = 4;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _regularloanChargesInfo.AccountInfo = _loanManager.GetChartOfAccountInformation(frmSearch.PrimaryId);

                    this.txtLoanCharges.Text = _regularloanChargesInfo.ChargeDescription =
                        _regularloanChargesInfo.ChargeDescription = !String.IsNullOrEmpty(_regularloanChargesInfo.AccountInfo.AccountSysId) ?
                        _regularloanChargesInfo.AccountInfo.AccountCode + " - " + _regularloanChargesInfo.AccountInfo.AccountName : String.Empty;

                    this.txtChargeAmount.Focus();

                    this.btnClearSummaryAccount.Visible = true;
                }
            }
        }//---------------------------
        //####################################################END BUTTON btnSearchLoanCharges EVENTS###############################################

        //####################################################TEXTBOX txtChargeAmount EVENTS###############################################
        //event is raised when the control is validated
        private void txtChargeAmountValidated(object sender, EventArgs e)
        {
            Decimal chargeAmount = 0;

            if (Decimal.TryParse(this.txtChargeAmount.Text, out chargeAmount))
            {
                _regularloanChargesInfo.ChargeAmount = chargeAmount;
            }
        }//---------------------

        //event is raised when the control is validating
        private void txtChargeAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//-----------------------

        //event is raised when the the control key is pressed
        private void txtChargeAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//-----------------------
        //####################################################END TEXTBOX txtChargeAmount EVENTS###############################################

        //####################################################TEXTBOX txtLoanCharges EVENTS###############################################
        //event is raised when the control is validated
        private void txtLoanChargesValidated(object sender, EventArgs e)
        {
            _regularloanChargesInfo.ChargeDescription = BaseServices.ProcStatic.TrimStartEndString(this.txtLoanCharges.Text);
        }//-------------------------
        //####################################################END TEXTBOX txtLoanCharges EVENTS###############################################

        //##################################BUTTON btnClearSummaryAccount EVENTS##########################################################
        //event is raised when the control is clicked
        private void btnClearSummaryAccountClick(object sender, EventArgs e)
        {
            String strMsg = "Are you sure you want to delete the summary account information?";

            DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgResult == DialogResult.Yes)
            {
                strMsg = "The summary account information has been successfully deleted.";

                CommonExchange.ChartOfAccount accountInfo = new CommonExchange.ChartOfAccount();

                _regularloanChargesInfo.AccountInfo = accountInfo;

                this.txtLoanCharges.Text = _regularloanChargesInfo.ChargeDescription = String.Empty;

                MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }//-------------------
        //##################################END BUTTON btnClearSummaryAccount EVENTS##########################################################
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtLoanCharges, String.Empty);
            _errProvider.SetError(this.txtChargeAmount, String.Empty);

            if (String.IsNullOrEmpty(_regularloanChargesInfo.ChargeDescription))
            {
                _errProvider.SetError(this.txtLoanCharges, "Charge Description must be required.");
                _errProvider.SetIconAlignment(this.txtLoanCharges, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_regularloanChargesInfo.ChargeAmount <= 0)
            {
                _errProvider.SetError(this.txtChargeAmount, "Charges amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtChargeAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_loanManager.IsExistsChargeRegularLoanCharges(_userInfo, _regularloanChargesInfo.RegularChargesId, _regularLoanSysId, 
                _regularloanChargesInfo.ChargeDescription, _regularloanChargesInfo.AccountInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtLoanCharges, "Loan charge information already exist.");
                _errProvider.SetIconAlignment(this.txtLoanCharges, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//-----------------------
        #endregion
    }
}
