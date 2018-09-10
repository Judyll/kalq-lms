using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    internal partial class LoanAmortization
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.RegularLoanAmortization _amortizationInfo;

        protected LoanLogic _loanManager;

        private ErrorProvider _errProvider;

        private String _regularLoanSysId;
        #endregion

        #region Class Properties Decleration
        public CommonExchange.RegularLoanAmortization RegularLoanAmortization
        {
            get { return _amortizationInfo; }
        }
        #endregion

        #region Class Constructors
        public LoanAmortization()
        {
            this.InitializeComponent();
        }

        public LoanAmortization(CommonExchange.SysAccess userInfo, LoanLogic loanManager, String regularLoanSysId)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _loanManager = loanManager;

            _regularLoanSysId = regularLoanSysId;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.lnkChangeDateFrom.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeDateFromLinkClicked);
            this.lnkChangeDateTo.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeDateToLinkClicked);
            this.lnkChangeDateGracePeriod.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeDateGracePeriodLinkClicked);
            this.txtIntrestRate.KeyPress += new KeyPressEventHandler(txtFloatKeyPress);
            this.txtIntrestRate.Validating += new System.ComponentModel.CancelEventHandler(txtFloatValidating);
            this.txtPenaltyRate.KeyPress += new KeyPressEventHandler(txtFloatKeyPress);
            this.txtPenaltyRate.Validating += new System.ComponentModel.CancelEventHandler(txtFloatValidating);
            this.txtPenaltyRate.Validated += new EventHandler(txtPenaltyRateValidated);
            this.txtIntrestRate.Validated += new EventHandler(txtIntrestRateValidated);
            this.txtScheduleOfPayment.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtScheduleOfPayment.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtScheduleOfPayment.Validated += new EventHandler(txtScheduleOfPaymentValidated);
            this.txtBeginningBalance.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtBeginningBalance.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtBeginningBalance.Validated += new EventHandler(txtBeginningBalanceValidated);
            this.txtPrincipalPaid.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtPrincipalPaid.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtPrincipalPaid.Validated += new EventHandler(txtPrincipalPaidValidated);
            this.txtInterestPaid.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtInterestPaid.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtInterestPaid.Validated += new EventHandler(txtInterestPaidValidated);
            this.txtEndingBalance.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtEndingBalance.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtEndingBalance.Validated += new EventHandler(txtEndingBalanceValidated);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
        }  
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS LoanAmortization EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _amortizationInfo = new CommonExchange.RegularLoanAmortization();
        }//-----------------------
        //####################################################END CLASS LoanAmortization EVENTS###############################################

        //####################################################LINKLABEL lnkChangeDateFrom EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeDateFromLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateFrom = DateTime.MinValue;

            if (String.IsNullOrEmpty(_amortizationInfo.PaymentDateFrom))
            {
                dateFrom = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                dateFrom = DateTime.Parse(_amortizationInfo.PaymentDateFrom);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateFrom))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out dateFrom))
                    {
                        _amortizationInfo.PaymentDateFrom = dateFrom.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtPaymentDateFrom.Text = dateFrom.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//-------------------------
        //####################################################END LINKLABEL lnkChangeDateFrom EVENTS###############################################

        //####################################################LINKLABEL lnkChangeDateTo EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeDateToLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateTo = DateTime.MinValue;

            if (String.IsNullOrEmpty(_amortizationInfo.PaymentDateTo))
            {
                dateTo = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                dateTo = DateTime.Parse(_amortizationInfo.PaymentDateTo);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateTo))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out dateTo))
                    {
                        _amortizationInfo.PaymentDateTo = dateTo.ToShortDateString() + " 11:59:59 PM";
                    }

                    this.txtPaymentDateTo.Text = dateTo.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//-------------------------
        //####################################################END LINKLABEL lnkChangeDateTo EVENTS###############################################

        //####################################################LINKLABEL lnkChangeDateGracePeriod EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeDateGracePeriodLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateGracePeriod = DateTime.MinValue;

            if (String.IsNullOrEmpty(_amortizationInfo.PaymentDateGracePeriod))
            {
                dateGracePeriod = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                dateGracePeriod = DateTime.Parse(_amortizationInfo.PaymentDateGracePeriod);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateGracePeriod))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out dateGracePeriod))
                    {
                        _amortizationInfo.PaymentDateGracePeriod = dateGracePeriod.ToShortDateString() + " 11:59:59 PM";
                    }

                    this.txtPaymentDateGracePeriod.Text = dateGracePeriod.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//-------------------------
        //####################################################END LINKLABEL lnkChangeDateGracePeriod EVENTS###############################################

        //####################################################TEXTBOX textBoxFloat EVENTS###############################################
        //event is raised when the control is validated
        private void txtFloatValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateFloatMaxTwoDecimal((TextBox)sender);
        }//------------------------------

        //event is raised when the key is pressed
        private void txtFloatKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxFloatDecimalOnly(e);
        }//----------------------------
        //####################################################END TEXTBOX textBoxFloat EVENTS###############################################

        //####################################################TEXTBOX textBoxDecimal EVENTS###############################################
        //event is raised when the control is validating
        private void txtDecimalValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//--------------------------

        //event is raised when the key is pressed
        private void txtDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//-------------------------

        //####################################################END TEXTBOX textBoxDecimal EVENTS###############################################  

        //####################################################TEXTBOX txtInterestRate EVENTS###############################################
        //event is raised when the control is validated
        private void txtIntrestRateValidated(object sender, EventArgs e)
        {
            Single interest = 0;

            if (Single.TryParse(this.txtIntrestRate.Text, out interest))
            {
                _amortizationInfo.InterestRate = interest;
            }
        }//------------------------------
        //####################################################END TEXTBOX txtInterestRate EVENTS###############################################

        //####################################################TEXTBOX txtPenaltyRate EVENTS###############################################
        //event is raised when the control is validated
        private void txtPenaltyRateValidated(object sender, EventArgs e)
        {
            Single penalty = 0;

            if (Single.TryParse(this.txtPenaltyRate.Text, out penalty))
            {
                _amortizationInfo.PenaltyRate = penalty;
            }
        }//------------------------------
        //####################################################END TEXTBOX txtPenaltyRate EVENTS###############################################

        //####################################################TEXTBOX txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _amortizationInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//--------------------------
        //####################################################END TEXTBOX txtRemarks EVENTS###############################################

        //####################################################TEXTBOX txtInterestRate EVENTS###############################################
        //event is raised when the control is validated
        private void txtInterestPaidValidated(object sender, EventArgs e)
        {
            Decimal interestPaid = 0;

            if (Decimal.TryParse(this.txtInterestPaid.Text, out interestPaid))
            {
                _amortizationInfo.InterestPaid = interestPaid;
            }
        }//-------------------------
        //####################################################END TEXTBOX txtInterestRate EVENTS###############################################

        //####################################################TEXTBOX txtPrincipalPaid EVENTS###############################################
        //event is raised when the control is validated
        private void txtPrincipalPaidValidated(object sender, EventArgs e)
        {
            Decimal principalPaid = 0;

            if (Decimal.TryParse(this.txtPrincipalPaid.Text, out principalPaid))
            {
                _amortizationInfo.PrincipalPaid = principalPaid;
            }
        }//------------------------
        //####################################################END TEXTBOX txtPrincipalPaid EVENTS###############################################

        //####################################################TEXTBOX txtBeginningBalance EVENTS###############################################
        //event is raised when the control is validated
        private void txtBeginningBalanceValidated(object sender, EventArgs e)
        {
            Decimal beginningBalance = 0;

            if (Decimal.TryParse(this.txtBeginningBalance.Text, out beginningBalance))
            {
                _amortizationInfo.BalanceBeginning = beginningBalance;
            }
        }//----------------------
        //####################################################END TEXTBOX txtBeginningBalance EVENTS###############################################

        //####################################################TEXTBOX txtScheduleOfPayment EVENTS###############################################
        //event is raised when the control is validated
        private void txtScheduleOfPaymentValidated(object sender, EventArgs e)
        {
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtScheduleOfPayment.Text, out paymentAmount))
            {
                _amortizationInfo.PaymentAmount = paymentAmount;
            }
        }//----------------------
        //####################################################END TEXTBOX txtScheduleOfPayment EVENTS###############################################

        //####################################################TEXTBOX txtEndingBalance EVENTS###############################################
        //event is raised when the control is validated
        private void txtEndingBalanceValidated(object sender, EventArgs e)
        {
            Decimal endingBalance = 0;

            if (Decimal.TryParse(this.txtEndingBalance.Text, out endingBalance))
            {
                _amortizationInfo.BalanceEnding = endingBalance;
            }
        }//----------------------
        //####################################################END TEXTBOX txtEndingBalance EVENTS###############################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will control value
        public void AssignControlValues()
        {
            DateTime dateFrom = DateTime.MinValue;

            this.txtPaymentDateFrom.Clear();

            if (DateTime.TryParse(_amortizationInfo.PaymentDateFrom, out dateFrom))
            {
                this.txtPaymentDateFrom.Text = DateTime.Compare(dateFrom, DateTime.MinValue) == 0 ? String.Empty : dateFrom.ToLongDateString();
            }

            DateTime dateTo = DateTime.MinValue;

            this.txtPaymentDateTo.Clear();

            if (DateTime.TryParse(_amortizationInfo.PaymentDateTo, out dateTo))
            {
                this.txtPaymentDateTo.Text = DateTime.Compare(dateTo, DateTime.MinValue) == 0 ? String.Empty : dateTo.ToLongDateString();
            }

            DateTime gracePeriodDate = DateTime.MinValue;

            this.txtPaymentDateGracePeriod.Clear();

            if (DateTime.TryParse(_amortizationInfo.PaymentDateGracePeriod, out gracePeriodDate))
            {
                this.txtPaymentDateGracePeriod.Text = DateTime.Compare(gracePeriodDate, DateTime.MinValue) == 0 ? String.Empty : gracePeriodDate.ToLongDateString();
            }

            this.txtIntrestRate.Text = _amortizationInfo.InterestRate.ToString();
            this.txtBeginningBalance.Text = _amortizationInfo.BalanceBeginning.ToString("N");
            this.txtScheduleOfPayment.Text = _amortizationInfo.PaymentAmount.ToString("N");
            this.txtPrincipalPaid.Text = _amortizationInfo.PrincipalPaid.ToString("N");
            this.txtInterestPaid.Text = _amortizationInfo.InterestPaid.ToString("N");
            this.txtEndingBalance.Text = _amortizationInfo.BalanceEnding.ToString("N");
            this.txtPenaltyRate.Text = _amortizationInfo.PenaltyRate.ToString();
            this.txtRemarks.Text = _amortizationInfo.Remarks;

        }//----------------------------
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtPaymentDateFrom, String.Empty);
            _errProvider.SetError(this.txtPaymentDateTo, String.Empty);
            _errProvider.SetError(this.txtPaymentDateGracePeriod, String.Empty);
            _errProvider.SetError(this.txtIntrestRate, String.Empty);
            _errProvider.SetError(this.txtBeginningBalance, String.Empty);
            _errProvider.SetError(this.txtScheduleOfPayment, String.Empty);
            _errProvider.SetError(this.txtPrincipalPaid, String.Empty);
            _errProvider.SetError(this.txtInterestPaid, String.Empty);
            _errProvider.SetError(this.txtEndingBalance, String.Empty);
            _errProvider.SetError(this.txtPenaltyRate, String.Empty);
            _errProvider.SetError(this.gbxDate, String.Empty);

            if (String.IsNullOrEmpty(_amortizationInfo.PaymentDateFrom))
            {
                _errProvider.SetError(this.txtPaymentDateFrom, "You must select a payment date from.");
                _errProvider.SetIconAlignment(this.txtPaymentDateFrom, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_amortizationInfo.PaymentDateTo))
            {
                _errProvider.SetError(this.txtPaymentDateTo, "You must select a payment date to.");
                _errProvider.SetIconAlignment(this.txtPaymentDateTo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_amortizationInfo.PaymentDateGracePeriod))
            {
                _errProvider.SetError(this.txtPaymentDateGracePeriod, "You must select a payment date grace period.");
                _errProvider.SetIconAlignment(this.txtPaymentDateGracePeriod, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_amortizationInfo.InterestRate <= 0)
            {
                _errProvider.SetError(this.txtIntrestRate, "Interest rate must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtIntrestRate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_amortizationInfo.BalanceBeginning <= 0)
            {
                _errProvider.SetError(this.txtBeginningBalance, "Beginning balance must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtBeginningBalance, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_amortizationInfo.PaymentAmount <= 0)
            {
                _errProvider.SetError(this.txtScheduleOfPayment, "Schedule of payment must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtScheduleOfPayment, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_amortizationInfo.PrincipalPaid <= 0)
            {
                _errProvider.SetError(this.txtPrincipalPaid, "Principal paid must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtPrincipalPaid, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }
                      

            if (_amortizationInfo.BalanceEnding <= 0)
            {
                _errProvider.SetError(this.txtEndingBalance, "Ending balance must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtEndingBalance, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_amortizationInfo.PenaltyRate <= 0)
            {
                _errProvider.SetError(this.txtPenaltyRate, "Penalty rate must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtPenaltyRate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_loanManager.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization(_userInfo, _amortizationInfo.AmortizationId,
                    _regularLoanSysId, _amortizationInfo.PaymentDateFrom, _amortizationInfo.PaymentDateTo))
            {
                _errProvider.SetError(this.gbxDate, "Payment Dates already exist.");
                _errProvider.SetIconAlignment(this.gbxDate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//---------------------
        #endregion
    }
}
