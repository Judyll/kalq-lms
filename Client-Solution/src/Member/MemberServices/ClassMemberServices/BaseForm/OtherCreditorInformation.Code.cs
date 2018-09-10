using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class OtherCreditorInformation
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        
        protected MemberLogic _memberManager;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Properties Decleration
        protected CommonExchange.OtherCreditor _otherCreditorInfo;
        public CommonExchange.OtherCreditor OtherCreditorInfo
        {
            get { return _otherCreditorInfo; }
        }
        #endregion

        #region Class Constructors
        public OtherCreditorInformation()
        {
            this.InitializeComponent();
        }

        public OtherCreditorInformation(CommonExchange.SysAccess userInfo, MemberLogic memberManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.txtCreditorName.Validated += new EventHandler(txtCreditorNameValidated);
            this.txtAmountOwned.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtAmountOwned.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtAmountOwned.Validated += new EventHandler(txtAmountOwnedValidated);
            this.txtAmortizationAmount.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtAmortizationAmount.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtAmortizationAmount.Validated += new EventHandler(txtAmortizationAmountValidated);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
            this.lnkChageDueDate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChageDueDateLinkClicked);
            this.cboPaymentInterval.SelectedIndexChanged += new EventHandler(cboPaymentIntervalSelectedIndexChanged);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS OtherCreditorInformation EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _otherCreditorInfo = new CommonExchange.OtherCreditor();

            _memberManager.InitializePaymentIntervalComboBox(this.cboPaymentInterval);
        }//------------------------
        //####################################################END CLASS OtherCreditorInformation EVENTS###############################################

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
 
        //####################################################TEXTBOX txtCreditorName EVENTS###############################################
        //event is raised when the control is validated
        private void txtCreditorNameValidated(object sender, EventArgs e)
        {
            _otherCreditorInfo.CreditorName = BaseServices.ProcStatic.TrimStartEndString(this.txtCreditorName.Text);
        }//-------------------------
        //####################################################END TEXTBOX txtCreditorName EVENTS###############################################

        //####################################################TEXTBOX AmountOwned EVENTS###############################################
        //event is raised when the control is validated
        private void txtAmountOwnedValidated(object sender, EventArgs e)
        {
            Decimal amountOwned = 0;

            if (Decimal.TryParse(this.txtAmountOwned.Text, out amountOwned))
            {
                _otherCreditorInfo.AmountOwned = amountOwned;
            }
        }//-------------------------
        //####################################################END TEXTBOX AmountOwned EVENTS###############################################

        //####################################################TEXTBOX txtAmortizationAmount EVENTS###############################################
        //event is raised when the control is validated
        private void txtAmortizationAmountValidated(object sender, EventArgs e)
        {
            Decimal amortizationAmount = 0;

            if (Decimal.TryParse(this.txtAmortizationAmount.Text, out amortizationAmount))
            {
                _otherCreditorInfo.AmortizationAmount = amortizationAmount;
            }
        }//----------------------------
        //####################################################END TEXTBOX txtAmortizationAmount EVENTS###############################################

        //####################################################TEXTBOX txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _otherCreditorInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//-----------------------------
        //####################################################END TEXTBOX txtRemarks EVENTS###############################################

        //####################################################LINKLABEL lnkChageDueDate EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChageDueDateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dueDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_otherCreditorInfo.DateDue))
            {
                dueDate = DateTime.Parse(_memberManager.ServerDateTime);
            }
            else
            {
                dueDate = DateTime.Parse(_otherCreditorInfo.DateDue);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dueDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_memberManager.ServerDateTime).ToLongTimeString(), out dueDate))
                    {
                        _otherCreditorInfo.DateDue = dueDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtDueDate.Text = dueDate.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//-------------------------------
        //####################################################END LINKLABEL lnkChageDueDate EVENTS###############################################

        //####################################################COMBOBOX cboPaymentInterval EVENTS###############################################
        //event is raised when the control is clicked
        private void cboPaymentIntervalSelectedIndexChanged(object sender, EventArgs e)
        {
            _otherCreditorInfo.RepaymentScheduleInfo = _memberManager.GetRepaymentscheduleInformation(this.cboPaymentInterval.SelectedIndex);
        }//--------------------------
        //####################################################END COMBOBOX cboPaymentInterval EVENTS###############################################
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            
            _errProvider.SetError(this.txtCreditorName, String.Empty);
            _errProvider.SetError(this.txtAmountOwned, String.Empty);
            _errProvider.SetError(this.txtDueDate, String.Empty);
            _errProvider.SetError(this.cboPaymentInterval, String.Empty);
            _errProvider.SetError(this.txtAmortizationAmount, String.Empty);

            if (String.IsNullOrEmpty(_otherCreditorInfo.CreditorName))
            {
                _errProvider.SetError(this.txtCreditorName, "A creditor name is required.");
                _errProvider.SetIconAlignment(this.txtCreditorName, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_otherCreditorInfo.AmountOwned <= 0)
            {
                _errProvider.SetError(this.txtAmountOwned, "Amount owned must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtAmountOwned, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_otherCreditorInfo.DateDue))
            {
                _errProvider.SetError(this.txtDueDate, "Due date is required");
                _errProvider.SetIconAlignment(this.txtDueDate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_otherCreditorInfo.RepaymentScheduleInfo.RepaymentId))
            {
                _errProvider.SetError(this.cboPaymentInterval, "You must select a payment interval.");
                _errProvider.SetIconAlignment(this.cboPaymentInterval, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_otherCreditorInfo.AmortizationAmount <= 0)
            {
                _errProvider.SetError(this.txtAmortizationAmount, "Amortization amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtAmortizationAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//------------------------
        #endregion
    }
}
