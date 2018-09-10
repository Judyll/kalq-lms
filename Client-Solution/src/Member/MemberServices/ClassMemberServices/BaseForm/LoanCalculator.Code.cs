using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    partial class LoanCalculator
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private CommonExchange.Member _memberInfo;
        private CommonExchange.RegularLoan _regularLoanInfo;

        private LoanLogic _loanManager;
        #endregion

        #region Class Constructors
        public LoanCalculator(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, LoanLogic loanManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberInfo = memberInfo;
            _loanManager = loanManager;

            this.Load += new EventHandler(ClassLoad);
            this.txtPrincipalAmount.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtPrincipalAmount.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtPrincipalAmount.Validated += new EventHandler(txtPrincipalAmountValidated);
            this.txtInterestRate.KeyPress += new KeyPressEventHandler(txtFloatKeyPress);
            this.txtInterestRate.Validating += new System.ComponentModel.CancelEventHandler(txtFloatValidating);
            this.txtInterestRate.Validated += new EventHandler(txtInterestRateValidated);
            this.txtNoOfPrepaidInterest.KeyPress += new KeyPressEventHandler(txtIntegerKeyPress);
            this.txtNoOfPrepaidInterest.Validating += new System.ComponentModel.CancelEventHandler(txtIntegerValidating);
            this.txtNoOfPrepaidInterest.Validated += new EventHandler(txtNoOfPrepaidInterestValidated);
            this.txtTerm.KeyPress += new KeyPressEventHandler(txtIntegerKeyPress);
            this.txtTerm.Validating += new System.ComponentModel.CancelEventHandler(txtIntegerValidating);
            this.txtTerm.Validated += new EventHandler(txtTermValidated);
            this.cboPaymentInterval.SelectedIndexChanged += new EventHandler(cboPaymentIntervalSelectedIndexChanged);
            this.btnAddCharges.Click += new EventHandler(btnAddChargesClick);
            this.btnAddAdditionals.Click += new EventHandler(btnAddAdditionalsClick);
            this.lsvChargesAdditions.MouseDoubleClick += new MouseEventHandler(lsvChargesAdditionsMouseDoubleClick);
            this.lnkChageReleaseDate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChageReleaseDateLinkClicked);
            this.lnkChangeMaturityDate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkChangeMaturityDateLinkClicked);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnPrint.Click += new EventHandler(btnPrintClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS LoanCalculator EVENTS###############################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            _regularLoanInfo = new CommonExchange.RegularLoan();

            _regularLoanInfo.MemberInfo = _memberInfo;

            this.lblApplicantName.Text = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_memberInfo.PersonInfo.LastName, _memberInfo.PersonInfo.FirstName,
                _memberInfo.PersonInfo.MiddleName);
            this.lblMonthlySalary.Text = _memberInfo.PersonInfo.SalaryIncome.ToString("N");
            this.lblOffice.Text = _memberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerName;

            _loanManager.InitializePaymentIntervalComboBox(this.cboPaymentInterval);
        }//--------------------------------
        //####################################################END CLASS LoanCalculator EVENTS###############################################

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

        //####################################################TEXTBOX textBoxInterger EVENTS###############################################
        //event is raised when the control is validating
        private void txtIntegerValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateInteger((TextBox)sender);
        }//---------------------------

        //event is raised when the control key is pressed
        private void txtIntegerKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxIntegersOnly(e);
        }//--------------------------
        //####################################################END TEXTBOX textBoxInterger EVENTS###############################################

        //####################################################TEXTBOX txtPrincipalAmount EVENTS###############################################
        //event is raised when the control is validated
        private void txtPrincipalAmountValidated(object sender, EventArgs e)
        {
            Decimal pAmount = 0;

            if (Decimal.TryParse(this.txtPrincipalAmount.Text, out pAmount))
            {
                _regularLoanInfo.LoanAmount = pAmount;

                _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);

                this.gbxChargesAdditionals.Enabled = pAmount > 0 ? true : false;

                if (_regularLoanInfo.LoanAmount > 0 && _regularLoanInfo.InterestRate > 0 && _regularLoanInfo.LoanTerms > 0 && _regularLoanInfo.NoPrepaidInterest > 0)
                {
                    this.btnPrint.Enabled = true;
                }
                else
                {
                    this.btnPrint.Enabled = false;
                }
            }
        }//-------------------------------
        //####################################################END TEXTBOX txtPrincipalAmount EVENTS###############################################

        //####################################################TEXTBOX txtInterestRate EVENTS###############################################
        //event is raised when the control is validated
        private void txtInterestRateValidated(object sender, EventArgs e)
        {
            Single interest = 0;

            if (Single.TryParse(this.txtInterestRate.Text, out interest))
            {
                _regularLoanInfo.InterestRate = interest;

                if (_regularLoanInfo.LoanAmount > 0 && _regularLoanInfo.InterestRate > 0 && _regularLoanInfo.LoanTerms > 0)
                {
                    this.btnPrint.Enabled = true;
                }
                else
                {
                    this.btnPrint.Enabled = false;
                }
            }
        }//---------------------------        
        //####################################################END TEXTBOX txtInterestRate EVENTS###############################################

        //####################################################TEXTBOX txtNoOfPrepaidInterest EVENTS###############################################
        //event is raised when the control is validated
        private void txtNoOfPrepaidInterestValidated(object sender, EventArgs e)
        {
            Int16 noPrepaidInterest = 0;

            if (Int16.TryParse(this.txtNoOfPrepaidInterest.Text, out noPrepaidInterest))
            {
                _regularLoanInfo.NoPrepaidInterest = noPrepaidInterest;
                
                this.lblPrePaidInterest.Text = (_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                              (_regularLoanInfo.NoPrepaidInterest)).ToString("N");

                if (!String.IsNullOrEmpty(_regularLoanInfo.DateFirstPayment))
                {
                    this.lblRealizedInterest.Text = (((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                            (_regularLoanInfo.NoPrepaidInterest)) / 12) * (12 - (DateTime.Parse(_regularLoanInfo.DateFirstPayment).Month - 1))).ToString("N");

                    this.lblDeferredInterest.Text = ((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                        (_regularLoanInfo.NoPrepaidInterest)) - (((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                        (_regularLoanInfo.NoPrepaidInterest)) / 12) * (12 - (DateTime.Parse(_regularLoanInfo.DateFirstPayment).Month - 1)))).ToString("N");
                }

                if (_regularLoanInfo.LoanAmount > 0 && _regularLoanInfo.InterestRate > 0 && _regularLoanInfo.LoanTerms > 0 && 
                    ((_regularLoanInfo.LoanTerms - _regularLoanInfo.NoPrepaidInterest) > 0))
                {
                    this.btnPrint.Enabled = true;
                }
                else
                {
                    this.btnPrint.Enabled = false;
                }
            }
        }//---------------------------
        //####################################################END TEXTBOX txtNoOfPrepaidInterest EVENTS###############################################

        //####################################################TEXTBOX txtTerm EVENTS###############################################
        //event is raised when the control is validated
        private void txtTermValidated(object sender, EventArgs e)
        {
            Int16 loanTerm = 0;

            if (Int16.TryParse(this.txtTerm.Text, out loanTerm))
            {
                _regularLoanInfo.LoanTerms = loanTerm;

                if (_regularLoanInfo.LoanAmount > 0 && _regularLoanInfo.InterestRate > 0 && _regularLoanInfo.LoanTerms > 0)
                {
                    this.btnPrint.Enabled = true;
                }
                else
                {
                    this.btnPrint.Enabled = false;
                }
            }
        }//---------------------------
        //####################################################END TEXTBOX txtTerm EVENTS###############################################

        //####################################################COMBOBOX cboPaymentInterval EVENTS###############################################
        //event is raised when the control is validated
        private void cboPaymentIntervalSelectedIndexChanged(object sender, EventArgs e)
        {
            _regularLoanInfo.RepaymentScheduleInfo = _loanManager.GetRepaymentscheduleInformation(this.cboPaymentInterval.SelectedIndex);
        }//------------------------
        //####################################################END COMBOBOX cboPaymentInterval EVENTS###############################################

        //####################################################BUTTON btnAddAdditions EVENTS###############################################
        //event is raised when the control is clicked
        private void btnAddAdditionalsClick(object sender, EventArgs e)
        {
            this.ShowAdditionals(false);
        }//-----------------------
        //####################################################END BUTTON btnAddAdditions EVENTS###############################################

        //####################################################BUTTON btnCharges EVENTS###############################################
        //event is raised when the control is clicked
        private void btnAddChargesClick(object sender, EventArgs e)
        {
            this.ShowAddCharges(false);
        }//-----------------------
        //####################################################END BUTTON btnCharges EVENTS###############################################       

        //####################################################LISTVIEW lsvChargesAdditions EVENTS###############################################
        //event is raised when the control is double clicked
        private void lsvChargesAdditionsMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((this.lsvChargesAdditions.Items.Count > 0 && this.lsvChargesAdditions.FocusedItem != null) &&
                    this.lsvChargesAdditions.GetItemAt(e.X, e.Y) != null) &&
                    !String.IsNullOrEmpty(this.lsvChargesAdditions.GetItemAt(e.X, e.Y).SubItems[2].Text))
                {
                    Int64 loanId = 0;
                    Boolean isLoanCharge = false;

                    if (Int64.TryParse(this.lsvChargesAdditions.GetItemAt(e.X, e.Y).SubItems[2].Text, out loanId) &&
                        Boolean.TryParse(this.lsvChargesAdditions.GetItemAt(e.X, e.Y).SubItems[3].Text, out isLoanCharge))
                    {
                        if (isLoanCharge)
                        {
                            using (RegularLoanChargesUpdate frmUpdate = new RegularLoanChargesUpdate(_userInfo,
                                _loanManager.GetRegularLoanChargesInformation(_regularLoanInfo, loanId), _loanManager, _regularLoanInfo.RegularLoanSysId))
                            {
                                frmUpdate.ShowDialog(this);

                                if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                                {
                                    _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                                }
                            }
                        }
                        else
                        {
                            using (RegularLoanAdditionsUpdate frmUpdate = new RegularLoanAdditionsUpdate(_userInfo,
                                _loanManager.GetRegularLoanAdditionsInformation(_regularLoanInfo, loanId), _loanManager))
                            {
                                frmUpdate.ShowDialog(this);

                                if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                                {
                                    _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                                }
                            }
                        }
                    }
                }
            }
        }//-----------------------
        //####################################################END LISTVIEW lsvChargesAdditions EVENTS###############################################

        //####################################################LINKLABEL lnkChageReleaseDate EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChageReleaseDateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime firstPaymentDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanInfo.DateFirstPayment))
            {
                firstPaymentDate = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                firstPaymentDate = DateTime.Parse(_regularLoanInfo.DateFirstPayment);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(firstPaymentDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out firstPaymentDate))
                    {
                        _regularLoanInfo.DateFirstPayment = firstPaymentDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtFirstPaymentDate.Text = firstPaymentDate.ToLongDateString();

                    _regularLoanInfo.DateMaturity = _loanManager.CalculateMaturityDate(_regularLoanInfo).ToShortDateString() + " 12:00:00 AM";

                    this.txtMaturityDate.Text = DateTime.Parse(_regularLoanInfo.DateMaturity).ToLongDateString();
                }
            }

            if (!String.IsNullOrEmpty(_regularLoanInfo.DateFirstPayment))
            {
                this.lblRealizedInterest.Text = (((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                           (_regularLoanInfo.NoPrepaidInterest)) / 12) * (12 - (DateTime.Parse(_regularLoanInfo.DateFirstPayment).Month - 1))).ToString("N");

                this.lblDeferredInterest.Text = ((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                    (_regularLoanInfo.NoPrepaidInterest)) - (((_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                    (_regularLoanInfo.NoPrepaidInterest)) / 12) * (12 - (DateTime.Parse(_regularLoanInfo.DateFirstPayment).Month - 1)))).ToString("N");
            }

            this.Cursor = Cursors.Arrow;
        }//-----------------------------
        //####################################################END LINKLABEL lnkChageReleaseDate EVENTS###############################################

        //####################################################LINKLABEL lnkChangeMaturityDate EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkChangeMaturityDateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime dateMaturity = DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanInfo.DateMaturity))
            {
                dateMaturity = DateTime.Parse(_loanManager.ServerDateTime);
            }
            else
            {
                dateMaturity = DateTime.Parse(_regularLoanInfo.DateMaturity);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(dateMaturity))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_loanManager.ServerDateTime).ToLongTimeString(), out dateMaturity))
                    {
                        _regularLoanInfo.DateMaturity = dateMaturity.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.txtMaturityDate.Text = dateMaturity.ToLongDateString();
                }
            }

            this.Cursor = Cursors.Arrow;
        }//-------------------------------
        //####################################################END LINKLABEL lnkChangeMaturityDate EVENTS###############################################

        //####################################################BUTTON btnClose EVENTS###############################################
        //event is raised when the control is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//------------------------
        //####################################################END BUTTON btnClose EVENTS###############################################

        //####################################################BUTTON btnPrint EVENTS###############################################
        //event is raised when the control is clicked
        private void btnPrintClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            _loanManager.PrintLoanChargesAmortization(_userInfo, _regularLoanInfo, 
                _loanManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanInfo, false), true, null, this);

            this.Cursor = Cursors.Arrow;
        }//----------------------------
        //####################################################END BUTTON btnPrint EVENTS###############################################
        #endregion

        #region Programmer's Defined Void Procedure
        //this procedure will allow to add additionals
        private void ShowAdditionals(Boolean multipleInsert)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using (RegularLoanAdditionsCreate frmCreate = new RegularLoanAdditionsCreate(_userInfo, _loanManager))
                {
                    frmCreate.MultipleInsert = multipleInsert;
                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasCreated)
                    {
                        _regularLoanInfo.LoanAdditionsList.Add(frmCreate.RegularLoanAdditionsInfo);

                        _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                    }

                    multipleInsert = frmCreate.MultipleInsert;
                }               
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message + "\n\nError Loading Loan Additional Module", "Error Loading");
            }

            this.Cursor = Cursors.Arrow;

            if (multipleInsert)
            {
                this.ShowAdditionals(multipleInsert);
            }
        }//----------------------------

        //this procedure will allow to add charges
        private void ShowAddCharges(Boolean multipleInsert)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using (RegularLoanChargesCreate frmCreate = new RegularLoanChargesCreate(_userInfo, _loanManager, _regularLoanInfo.RegularLoanSysId))
                {
                    frmCreate.MultipleInsert = multipleInsert;
                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasCreated)
                    {
                        _regularLoanInfo.LoanChargesList.Add(frmCreate.RegularLoanChargesInfo);

                        _loanManager.InitializeLoanChargesAdditionsListView(this.lsvChargesAdditions, _regularLoanInfo, this.lblNetLoanAmount);
                    }

                    multipleInsert = frmCreate.MultipleInsert;
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message + "\n\nError Loading Loan Charges Module", "Error Loading");
            }

            this.Cursor = Cursors.Arrow;

            if (multipleInsert)
            {
                this.ShowAddCharges(multipleInsert);
            }
        }//-----------------------------
        #endregion
    }
}
