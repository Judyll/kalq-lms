using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class RegularLoanAdditions
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.RegularLoanAdditions _regularloanAdditionsInfo;
        protected LoanLogic _loanManager;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Properties Decleration
        public CommonExchange.RegularLoanAdditions RegularLoanAdditionsInfo
        {
            get { return _regularloanAdditionsInfo; }
        }
        #endregion

        #region Class Constructos
        public RegularLoanAdditions()
        {
            this.InitializeComponent();
        }

        public RegularLoanAdditions(CommonExchange.SysAccess userInfo, LoanLogic loanManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _loanManager = loanManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.btnSearchLoanAdditions.Click += new EventHandler(btnSearchLoanAdditionsClick);
            this.txtAdditionsAmount.KeyPress += new KeyPressEventHandler(txtAdditionsAmountKeyPress);
            this.txtAdditionsAmount.Validating += new System.ComponentModel.CancelEventHandler(txtAdditionsAmountValidating);
            this.txtAdditionsAmount.Validated += new EventHandler(txtAdditionsAmountValidated);
            this.txtLoanAdditions.Validated += new EventHandler(txtLoanAdditionsValidated);
            this.btnClearSummaryAccount.Click += new EventHandler(btnClearSummaryAccountClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS RegularLoanAdditions EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _regularloanAdditionsInfo = new CommonExchange.RegularLoanAdditions();
        }//-------------------------
        //####################################################END CLASS RegularLoanAdditions EVENTS###############################################

        //####################################################BUTTON btnSearchLoanAdditions EVENTS###############################################
        //event is raised when the control is clicked
        private void btnSearchLoanAdditionsClick(object sender, EventArgs e)
        {
            using (LoanAdditionsSearchOnTextBoxList frmSearch = new LoanAdditionsSearchOnTextBoxList(_userInfo, _loanManager))
            {
                frmSearch.AdoptGridSize = false;
                frmSearch.PrimaryIndex = 4;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _regularloanAdditionsInfo.AccountInfo = _loanManager.GetChartOfAccountInformation(frmSearch.PrimaryId);

                    this.txtLoanAdditions.Text = _regularloanAdditionsInfo.AdditionDescription =
                        _regularloanAdditionsInfo.AdditionDescription = !String.IsNullOrEmpty(_regularloanAdditionsInfo.AccountInfo.AccountSysId) ?
                        _regularloanAdditionsInfo.AccountInfo.AccountCode + " - " + _regularloanAdditionsInfo.AccountInfo.AccountName : String.Empty;

                    this.txtAdditionsAmount.Focus();

                    this.btnClearSummaryAccount.Visible = true;
                }
            }
        }//-----------------------
        //####################################################END BUTTON btnSearchLoanAdditions EVENTS###############################################

        //####################################################BUTTON  txtAdditionsAmount EVENTS###############################################
        //event is raised when the control is validated
        private void txtAdditionsAmountValidated(object sender, EventArgs e)
        {
            Decimal additionalAmount = 0;

            if (Decimal.TryParse(this.txtAdditionsAmount.Text, out additionalAmount))
            {
                _regularloanAdditionsInfo.AdditionAmount = additionalAmount;
            }
        }//------------------------

        //event is raised whent the control is validating
        private void txtAdditionsAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//------------------------

        //event is raised when the control key is pressed
        private void txtAdditionsAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//-------------------------
        //####################################################END BUTTON  txtAdditionsAmount EVENTS###############################################

        //####################################################BUTTON  txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtLoanAdditionsValidated(object sender, EventArgs e)
        {
            _regularloanAdditionsInfo.AdditionDescription = BaseServices.ProcStatic.TrimStartEndString(this.txtLoanAdditions.Text);
        }//------------------------
        //####################################################END BUTTON  txtRemarks EVENTS###############################################

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

                _regularloanAdditionsInfo.AccountInfo = accountInfo;

                this.txtLoanAdditions.Text = _regularloanAdditionsInfo.AdditionDescription = String.Empty;

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

            _errProvider.SetError(this.txtLoanAdditions, String.Empty);
            _errProvider.SetError(this.txtAdditionsAmount, String.Empty);

            if (String.IsNullOrEmpty(_regularloanAdditionsInfo.AdditionDescription))
            {
                _errProvider.SetError(this.txtLoanAdditions, "Loan additions is required.");
                _errProvider.SetIconAlignment(this.txtLoanAdditions, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_regularloanAdditionsInfo.AdditionAmount <= 0)
            {
                _errProvider.SetError(this.txtAdditionsAmount, "Addition amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtAdditionsAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//--------------------------
        #endregion
    }
}
