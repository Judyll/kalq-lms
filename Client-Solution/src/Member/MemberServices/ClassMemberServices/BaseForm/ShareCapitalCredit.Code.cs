using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    internal partial class ShareCapitalCredit
    {
        #region Class Properties Declaration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.ShareCapitalCredit _shareCapitalCreditInfo;
        protected CommonExchange.Member _memberInfo;
        protected MemberLogic _memberManager;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructors
        public ShareCapitalCredit()
        {
            this.InitializeComponent();
        }

        public ShareCapitalCredit(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, MemberLogic memberManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberInfo = memberInfo;
            _memberManager = memberManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);

            //----------------- FOR SHARED CAPITAL CONTROLS ----------------------
            this.txtShareAmountTendered.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtSharePayment.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);

            this.txtSharePayment.KeyPress += new KeyPressEventHandler(txtSharePaymentKeyPress);
            this.txtSharePayment.KeyUp += new KeyEventHandler(txtSharePaymentKeyUp);
            this.txtSharePayment.Validated += new EventHandler(txtSharePaymentValidated);

            this.txtShareAmountTendered.KeyPress += new KeyPressEventHandler(txtShareAmountTenderedKeyPress);
            this.txtShareAmountTendered.KeyUp += new KeyEventHandler(txtShareAmountTenderedKeyUp);
            this.txtShareAmountTendered.Validated += new EventHandler(txtShareAmountTenderedValidated);

            this.txtShareReceiptNo.Validated += new EventHandler(txtShareReceiptNoValidated);
            this.txtShareReceiptNo.KeyPress += new KeyPressEventHandler(txtShareReceiptNoKeyPress);

            this.txtShareRemarks.Validated += new EventHandler(txtShareRemarksValidated);
            this.txtShareRemarks.KeyPress += new KeyPressEventHandler(txtShareRemarksKeyPress);

            this.txtShareBank.Validated += new EventHandler(txtShareBankValidated);
            this.txtShareBank.KeyPress += new KeyPressEventHandler(txtShareBankKeyPress);

            this.txtShareCheckNo.Validated += new EventHandler(txtShareCheckNoValidated);

            this.btnShareSearchCreditEntry.Click += new EventHandler(btnShareSearchCreditEntryClick);
            //----------------------------------------------------------------
        }

        
        #endregion

        #region Class Properties Declaration
        //####################################################CLASS ShareCapitalCredit EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();

            _shareCapitalCreditInfo.MemberInfo = _memberInfo;

            _shareCapitalCreditInfo.IsMigratedEntry = true;

            _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(_memberManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

            this.lblShareReceivedDate.Text = DateTime.Parse(_memberManager.ServerDateTime).ToLongDateString();
            this.lblShareReflectedDate.Text = DateTime.Parse(_memberManager.ServerDateTime).ToLongDateString();
            this.lblShareReceiptDate.Text = DateTime.Parse(_memberManager.ServerDateTime).ToLongDateString();
        }//--------------------------
        //####################################################END CLASS ShareCapitalCredit EVENTS###############################################

        //###########################################TEXTBOX txtAmount EVENTS#####################################################
        //event is raised when the control is validating
        private void txtAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//---------------------        
        //###########################################END TEXTBOX txtAmount EVENTS#####################################################

        //###########################################TEXTBOX txtSharePayment EVENTS#####################################################
        //event is raised when the key is up
        private void txtSharePaymentKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtShareAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtSharePayment.Text, out paymentAmount)) { }

            this.lblShareChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//----------------------

        //event is raised when the control is validated
        private void txtSharePaymentValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtSharePayment.Text, out amount))
            {
                _shareCapitalCreditInfo.CreditAmount = amount;
            }
        }//-------------------------

        //evet is raised when the key is pressed
        private void txtSharePaymentKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtShareAmountTendered.Focus();
            }
        }//-----------------------------
        //###########################################END TEXTBOX txtSharePayment EVENTS#####################################################

        //###########################################TEXTBOX txtShareAmountTendered EVENTS#####################################################
        //event is raised when the control is validated
        private void txtShareAmountTenderedValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtShareAmountTendered.Text, out amount))
            {
                _shareCapitalCreditInfo.AmountTendered = amount;
            }
        }//-------------------------

        //event is raised when the key is up
        private void txtShareAmountTenderedKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtShareAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtSharePayment.Text, out paymentAmount)) { }

            this.lblShareChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//---------------------------

        //event is raised when the key is pressed
        private void txtShareAmountTenderedKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtShareReceiptNo.Focus();
            }
        }//---------------------------
        //###########################################END TEXTBOX txtShareAmountTendered EVENTS#####################################################

        //###########################################TEXTBOX txtReceiptNo EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtShareReceiptNoKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.btnShareSearchCreditEntry.Focus();
            }
        }//----------------------

        //event is raised when the control is validated
        private void txtShareReceiptNoValidated(object sender, EventArgs e)
        {
            _shareCapitalCreditInfo.ReceiptNo = this.txtShareReceiptNo.Text = BaseServices.ProcStatic.TrimStartEndString(this.txtShareReceiptNo.Text);
        }//------------------------
        //###########################################END TEXTBOX txtReceiptNo EVENTS#####################################################

        //###########################################TEXTBOX txtShareCheckNo EVENTS#####################################################
        //event is raised when the control is validated
        private void txtShareCheckNoValidated(object sender, EventArgs e)
        {
            _shareCapitalCreditInfo.CheckNo = this.txtShareCheckNo.Text = BaseServices.ProcStatic.TrimStartEndString(this.txtShareCheckNo.Text);
        }//-----------------------
        //###########################################END TEXTBOX txtShareCheckNo EVENTS#####################################################

        //###########################################TEXTBOX txtShareBank EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtShareBankKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtShareCheckNo.Focus();
            }
        }//----------------------------

        //event is raised when the control is validated
        private void txtShareBankValidated(object sender, EventArgs e)
        {
            _shareCapitalCreditInfo.Bank = this.txtShareBank.Text = BaseServices.ProcStatic.TrimStartEndString(this.txtShareBank.Text);
        }//---------------------------
        //###########################################END TEXTBOX txtShareBank EVENTS#####################################################

        //###########################################TEXTBOX txtShareRemarks EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtShareRemarksKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtShareBank.Focus();
            }
        }//------------------------
        //###########################################END TEXTBOX txtShareRemarks EVENTS#####################################################

        //event is raised when the control is validated
        private void txtShareRemarksValidated(object sender, EventArgs e)
        {
            _shareCapitalCreditInfo.Remarks = this.txtShareRemarks.Text = BaseServices.ProcStatic.TrimStartEndString(this.txtShareRemarks.Text);
        }//-------------------------
        //###########################################END TEXTBOX txtShareRemarks EVENTS#####################################################

        //########################################BUTTON btnShareSearchCreditEntry EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnShareSearchCreditEntryClick(object sender, EventArgs e)
        {
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _memberManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _shareCapitalCreditInfo.AccountCreditInfo = _memberManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtShareCreditEntry.Text = _shareCapitalCreditInfo.AccountCreditInfo.AccountName + "(" + _shareCapitalCreditInfo.AccountCreditInfo.AccountCode + ")";
                }
            }
        }//-----------------------
        //########################################END BUTTON btnShareSearchCreditEntry EVENTS#####################################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will assign control values for shared capital
        public void AssignConrolValuesShareCapital()
        {
            this.lblShareChange.Text = "-";
            this.txtSharePayment.Focus();
            this.txtSharePayment.Text = _shareCapitalCreditInfo.CreditAmount.ToString("N");
            this.txtShareAmountTendered.Text = _shareCapitalCreditInfo.AmountTendered.ToString("N");

            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtShareAmountTendered.Text, out amountTendered)) { }
            if (Decimal.TryParse(this.txtSharePayment.Text, out paymentAmount)) { }
            this.lblShareChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));


            this.lblShareReceivedDate.Text = DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate).ToLongDateString();
            this.lblShareReflectedDate.Text = DateTime.Parse(_shareCapitalCreditInfo.ReflectedDate).ToLongDateString();
            this.lblShareReceiptDate.Text = DateTime.Parse(_shareCapitalCreditInfo.ReceiptDate).ToLongDateString();

            this.txtShareReceiptNo.Text = !String.IsNullOrEmpty(_shareCapitalCreditInfo.ReceiptNo) ? _shareCapitalCreditInfo.ReceiptNo :
                BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");

            String strShareCreditEntry = !String.IsNullOrEmpty(_shareCapitalCreditInfo.AccountCreditInfo.AccountName) ?
                _shareCapitalCreditInfo.AccountCreditInfo.AccountName + "(" + _shareCapitalCreditInfo.AccountCreditInfo.AccountCode + ")" : String.Empty;

            this.txtShareCreditEntry.Text = strShareCreditEntry;
            this.txtShareRemarks.Text = _shareCapitalCreditInfo.Remarks;
            this.txtShareBank.Text = _shareCapitalCreditInfo.Bank;
            this.txtShareCheckNo.Text = _shareCapitalCreditInfo.CheckNo;
        }//-----------------------------
        #endregion

        #region Programmer's Defined Functions
        //ths fucntion will will validate controls for share capital credit
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtSharePayment, String.Empty);
            _errProvider.SetError(this.txtSharePayment, String.Empty);
            _errProvider.SetError(this.txtShareCreditEntry, String.Empty);

            if (String.IsNullOrEmpty(_shareCapitalCreditInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.txtSharePayment, "A member information is required.");
                _errProvider.SetIconAlignment(this.txtSharePayment, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_shareCapitalCreditInfo.CreditAmount <= 0)
            {
                _errProvider.SetError(this.txtSharePayment, "Credit Amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtSharePayment, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_shareCapitalCreditInfo.AccountCreditInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtShareCreditEntry, "You must select a credit entry.");
                _errProvider.SetIconAlignment(this.txtShareCreditEntry, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//---------------------
        #endregion
    }
}
