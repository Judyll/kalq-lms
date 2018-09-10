    using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class RegularLoadPayment
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private CommonExchange.RegularLoan _regularLoanInfo;
        private CommonExchange.RegularLoanPayments _regularLoanPaymentInfo;
        private CashieringLogic _cashieringManager;

        private ErrorProvider _errProvider;

        private String _paymentId = "";
        private Int32 _primaryIndex = 0;
        private Int32 _rowIndex = -1;
        #endregion

        #region Class Constructors
        public RegularLoadPayment(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo, 
            CashieringLogic cashieringManager, String memberName)
        {
            this.InitializeComponent();

            this.Text = memberName;

            _userInfo = userInfo;
            _regularLoanInfo = regularLoanInfo;
            _cashieringManager = cashieringManager;

            this.Load += new EventHandler(ClassLoad);

            this.txtPayment.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtPrincipalPaid.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtInterestPaid.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtRebate.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);            
            this.txtAmountTendered.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);

            this.txtPayment.KeyPress += new KeyPressEventHandler(txtPaymentKeyPress);
            this.txtPayment.KeyUp += new KeyEventHandler(txtPaymentKeyUp);
            this.txtPayment.Validated += new EventHandler(txtPaymentValidated);

            this.txtPrincipalPaid.Validated += new EventHandler(txtPrincipalPaidValidated);
            this.txtPrincipalPaid.KeyPress += new KeyPressEventHandler(txtPrincipalPaidKeyPress);

            this.txtInterestPaid.Validated += new EventHandler(txtInterestPaidValidated);
            this.txtInterestPaid.KeyPress += new KeyPressEventHandler(txtInterestPaidKeyPress);

            this.txtRebate.Validated += new EventHandler(txtRebateAmountValidated);
            this.txtRebate.KeyPress += new KeyPressEventHandler(txtRebateAmountKeyPress);

            this.txtAmountTendered.KeyPress += new KeyPressEventHandler(txtAmountTenderedKeyPress);
            this.txtAmountTendered.KeyUp += new KeyEventHandler(txtAmountTenderedKeyUp);
            this.txtAmountTendered.Validated += new EventHandler(txtAmountTenderedValidated);

            this.txtReceiptNo.KeyPress += new KeyPressEventHandler(txtReceiptNoKeyPress);
            this.txtReceiptNo.Validated += new EventHandler(txtReceiptNoValidated);

            this.txtRemarks.KeyPress += new KeyPressEventHandler(txtRemarksKeyPress);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);

            this.txtBank.KeyPress += new KeyPressEventHandler(txtBankKeyPress);
            this.txtBank.Validated += new EventHandler(txtBankValidated);

            this.txtCheck.KeyPress += new KeyPressEventHandler(txtCheckKeyPress);
            this.txtCheck.Validated += new EventHandler(txtCheckValidated);

            this.lblReflectedDate.Click += new EventHandler(lblReflectedDateClick);
            this.lblReceiptDate.Click += new EventHandler(lblReceiptDateClick);

            this.chkIncludeInterest.CheckedChanged += new EventHandler(chkIncludeInterestCheckedChanged);

            this.btnSearchCreditEntry.Click += new EventHandler(btnSearchCreditEntryClick);
            this.btnSearchCreditEntryRebate.Click += new EventHandler(btnSearchCreditEntryRebateClick);

            this.btnRecord.Click += new EventHandler(btnCreateClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
            this.btnClose.Click += new EventHandler(btnCloseClick);

            this.dgvPaymentHistory.MouseDown += new MouseEventHandler(dgvPaymentHistoryMouseDown);
            this.dgvPaymentHistory.DoubleClick += new EventHandler(dgvPaymentHistoryDoubleClick);
            this.dgvPaymentHistory.DataSourceChanged += new EventHandler(dgvPaymentHistoryDataSourceChanged);
            this.dgvPaymentHistory.SelectionChanged += new EventHandler(dgvPaymentHistorySelectionChanged);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS RegularLoadPayment EVENTS####################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            _errProvider = new ErrorProvider();

            _regularLoanPaymentInfo = new CommonExchange.RegularLoanPayments();

            _regularLoanPaymentInfo.RegularLoanInfo = _regularLoanInfo;

            _regularLoanPaymentInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _regularLoanPaymentInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _regularLoanPaymentInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

            this.lblReceivedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblReflectedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblReceiptDate.Text = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToLongDateString();
            _regularLoanPaymentInfo.ReceiptNo = this.txtReceiptNo.Text = BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");

            this.dgvAmortizationList.DataSource = _cashieringManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanPaymentInfo.RegularLoanInfo, this.lblTotalInterestPayable);
            this.dgvPaymentHistory.DataSource = _cashieringManager.GetRegularLoanPayments(_userInfo, _regularLoanPaymentInfo.RegularLoanInfo.RegularLoanSysId, this.lblTotalPayment);
                       
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvAmortizationList, false);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvPaymentHistory, false);
           
        }//----------------------------
        //####################################END CLASS RegularLoadPayment EVENTS####################################

        //###########################################TEXTBOX txtAmount EVENTS#####################################################
        //event is raised when the control is validating
        private void txtAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//---------------------        
        //###########################################END TEXTBOX txtAmount EVENTS#####################################################

        //###########################################TEXTBOX txtPayment EVENTS#####################################################
        //event is raised when the control is validated
        private void txtPaymentValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtPayment.Text, out amount))
            {
                _regularLoanPaymentInfo.PaymentAmount = amount;

                if (this.chkIncludeInterest.Checked)
                {
                    if (amount > 0)
                    {
                        Decimal totalInterestLessPrePaidInterest = (_regularLoanPaymentInfo.RegularLoanInfo.LoanAmount * (Decimal)(_regularLoanPaymentInfo.RegularLoanInfo.InterestRate / 100) *
                            (_regularLoanPaymentInfo.RegularLoanInfo.LoanTerms - _regularLoanPaymentInfo.RegularLoanInfo.NoPrepaidInterest));
                        Decimal intrestAmount = totalInterestLessPrePaidInterest / (_regularLoanPaymentInfo.RegularLoanInfo.LoanTerms - _regularLoanPaymentInfo.RegularLoanInfo.NoPrepaidInterest);

                        if (amount >= intrestAmount)
                        {
                            _regularLoanPaymentInfo.InterestPaid = intrestAmount;
                            _regularLoanPaymentInfo.PrincipalPaid = amount - intrestAmount;
                        }
                        else
                        {
                            _regularLoanPaymentInfo.InterestPaid = amount;
                            _regularLoanPaymentInfo.PrincipalPaid = 0;
                        }                    
                    }
                }
                else
                {
                    _regularLoanPaymentInfo.InterestPaid = 0;
                    _regularLoanPaymentInfo.PrincipalPaid = amount;
                }

                this.txtInterestPaid.Text = _regularLoanPaymentInfo.InterestPaid.ToString("N");
                this.txtPrincipalPaid.Text = _regularLoanPaymentInfo.PrincipalPaid.ToString("N");
            }
        }//--------------------------

        //event is raised when the key is up
        private void    txtPaymentKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtPayment.Text, out paymentAmount)) { }

            this.lblChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//------------------------

        //event is raised when the key is pressed
        private void txtPaymentKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtAmountTendered.Focus();
            }
        }//-----------------------------
        //###########################################END TEXTBOX txtPayment EVENTS#####################################################

        //###########################################TEXTBOX txtPrincipalPaid EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtPrincipalPaidKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtInterestPaid.Focus();
            }
        }//-----------------------------

        //event is raised when the control is validated
        private void txtPrincipalPaidValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtPrincipalPaid.Text, out amount))
            {
                _regularLoanPaymentInfo.PrincipalPaid = amount;
            }
        }//-------------------------
        //###########################################END TEXTBOX txtPrincipalPaid EVENTS#####################################################

        //###########################################TEXTBOX txtInterestPaid EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtInterestPaidKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtAmountTendered.Focus();
            }
        }//-----------------------

        //event is raised when the control is validated
        private void txtInterestPaidValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtInterestPaid.Text, out amount))
            {
                _regularLoanPaymentInfo.InterestPaid = amount;
            }
        }//-------------------------
        //###########################################END TEXTBOX txtInterestPaid EVENTS#####################################################

        //###########################################TEXTBOX txtDiscountedAmount EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtRebateAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//--------------------------

        //event is raised when the control is validated
        private void txtRebateAmountValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtRebate.Text, out amount))
            {
                _regularLoanPaymentInfo.RebateAmount = amount;
            }
        }//----------------------------
        //###########################################END TEXTBOX txtDiscountedAmount EVENTS#####################################################

        //###########################################TEXTBOX txtAmountTendered EVENTS#####################################################
        //event is raised when the control is validated
        private void txtAmountTenderedValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtAmountTendered.Text, out amount))
            {
                _regularLoanPaymentInfo.AmountTendered = amount;
            }
        }//-----------------------

        //event is raised when the key is up
        private void txtAmountTenderedKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtPayment.Text, out paymentAmount)) { }

            this.lblChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//---------------------------

        //event is raised when the key is up
        private void txtAmountTenderedKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.lblReflectedDate.Focus();
            }
        }//-----------------------------
        //###########################################END TEXTBOX txtAmountTendered EVENTS#####################################################

        //###########################################TEXTBOX txtReceiptNo EVENTS#####################################################
        //event is raised when the control is validated
        private void txtReceiptNoValidated(object sender, EventArgs e)
        {
            _regularLoanPaymentInfo.ReceiptNo = this.txtReceiptNo.Text = BaseServices.ProcStatic.TrimStartEndString(this.txtReceiptNo.Text);

            BaseServices.BaseServicesLogic.ReceiptNumber = Int32.Parse(_regularLoanPaymentInfo.ReceiptNo);
        }//-----------------------------

        //event is raised when key is up
        private void txtReceiptNoKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.btnSearchCreditEntry.Focus();
            }
        }//---------------------------
        //###########################################END TEXTBOX txtReceiptNo EVENTS#####################################################

        //###########################################TEXTBOX txtRemarks EVENTS#####################################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _regularLoanPaymentInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//-------------------------

        //event is raised when the key is pressed
        private void txtRemarksKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtBank.Focus();
            }
        }//--------------------------
        //###########################################END TEXTBOX txtRemarks EVENTS#####################################################

        //###########################################TEXTBOX txtBank EVENTS#####################################################
        //event is raised when the control is validated
        private void txtBankValidated(object sender, EventArgs e)
        {
            _regularLoanPaymentInfo.Bank = BaseServices.ProcStatic.TrimStartEndString(this.txtBank.Text);
        }//-----------------------------

        //event is raised when the key is pressed
        private void txtBankKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtCheck.Focus();
            }
        }//------------------------
        //###########################################END TEXTBOX txtBank EVENTS#####################################################

        //###########################################TEXTBOX txtCheck EVENTS#####################################################
        //event is raised when the control is validated
        private void txtCheckValidated(object sender, EventArgs e)
        {
            _regularLoanPaymentInfo.CheckNo = BaseServices.ProcStatic.TrimStartEndString(this.txtCheck.Text);
        }//-----------------------------

        //event is raised when key is pressed
        private void txtCheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.btnRecord.Focus();
            }
        }//------------------------
        //###########################################END TEXTBOX txtCheck EVENTS#####################################################

        //###########################################LABEL lblPaymentReflectedDate EVENTS#####################################################
        //event is raised when the mouse double clicked
        private void lblReflectedDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime paymentDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.ReflectedDate))
            {
                paymentDate = DateTime.Parse(_cashieringManager.ServerDateTime);
            }
            else
            {
                paymentDate = DateTime.Parse(_regularLoanPaymentInfo.ReflectedDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(paymentDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out paymentDate))
                    {
                        _regularLoanPaymentInfo.ReflectedDate = paymentDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblReflectedDate.Text = paymentDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_regularLoanPaymentInfo.ReceivedDate));
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //###########################################END LABEL lblPaymentReflectedDate EVENTS#####################################################

        //###########################################LABEL lblReceiptDate EVENTS#####################################################
        //event is raised when the control is clicked
        private void lblReceiptDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime receiptDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.ReceiptDate))
            {
                receiptDate = DateTime.Parse(CashieringLogic.ReceiptDate);
            }
            else
            {
                receiptDate = DateTime.Parse(_regularLoanPaymentInfo.ReceiptDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(receiptDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out receiptDate))
                    {
                        _regularLoanPaymentInfo.ReceiptDate = receiptDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblReceiptDate.Text = receiptDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_regularLoanPaymentInfo.ReceiptDate), DateTime.Parse(_regularLoanPaymentInfo.ReceivedDate));
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------------
        //###########################################END LABEL lblReceiptDate EVENTS#####################################################

        //########################################CHECKBOX chkIncludeInterest EVENTS#####################################################
        //event is raised when the control checked is changed
        void chkIncludeInterestCheckedChanged(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtPayment.Text, out amount))
            {
                _regularLoanPaymentInfo.PaymentAmount = amount;

                if (this.chkIncludeInterest.Checked)
                {
                    if (amount > 0)
                    {
                        Decimal totalInterestLessPrePaidInterest = (_regularLoanPaymentInfo.RegularLoanInfo.LoanAmount * (Decimal)(_regularLoanPaymentInfo.RegularLoanInfo.InterestRate / 100) *
                            (_regularLoanPaymentInfo.RegularLoanInfo.LoanTerms - _regularLoanPaymentInfo.RegularLoanInfo.NoPrepaidInterest));
                        Decimal intrestAmount = totalInterestLessPrePaidInterest > 0 ?
                            (totalInterestLessPrePaidInterest / 
                            (_regularLoanPaymentInfo.RegularLoanInfo.LoanTerms - _regularLoanPaymentInfo.RegularLoanInfo.NoPrepaidInterest)) : 0;

                        if (amount >= intrestAmount)
                        {
                            _regularLoanPaymentInfo.InterestPaid = intrestAmount;
                            _regularLoanPaymentInfo.PrincipalPaid = amount - intrestAmount;
                        }
                        else
                        {
                            _regularLoanPaymentInfo.InterestPaid = amount;
                            _regularLoanPaymentInfo.PrincipalPaid = 0;
                        }
                    }
                }
                else
                {
                    _regularLoanPaymentInfo.InterestPaid = 0;
                    _regularLoanPaymentInfo.PrincipalPaid = amount;
                }

                this.txtInterestPaid.Text = _regularLoanPaymentInfo.InterestPaid.ToString("N");
                this.txtPrincipalPaid.Text = _regularLoanPaymentInfo.PrincipalPaid.ToString("N");
            }
        }//----------------------------
        //########################################END CHECKBOX chkIncludeInterest EVENTS#####################################################

        //########################################BUTTON btnSearchCreditEntry EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchCreditEntryClick(object sender, EventArgs e)
        {
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _regularLoanPaymentInfo.AccountCreditInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtCreditEntry.Text = _regularLoanPaymentInfo.AccountCreditInfo.AccountName + "(" + _regularLoanPaymentInfo.AccountCreditInfo.AccountCode + ")";
                }
            }
        }//----------------------------
        //########################################END BUTTON btnSearchCreditEntry EVENTS#####################################################

        //########################################BUTTON btnSearchCreditEntryRebate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchCreditEntryRebateClick(object sender, EventArgs e)
        {
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _regularLoanPaymentInfo.AccountRebateInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtCreditEntryRebate.Text = _regularLoanPaymentInfo.AccountRebateInfo.AccountName + "(" + _regularLoanPaymentInfo.AccountRebateInfo.AccountCode + ")";
                }
            }
        }//------------------------------
        //########################################END BUTTON btnSearchCreditEntryRebate EVENTS#####################################################

        //########################################BUTTON btnCreate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnCreateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                     String strMsg = "Are you sure you want to record the new regular loan payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The regular loan payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _regularLoanPaymentInfo.ObjectState = DataRowState.Added;

                        _cashieringManager.InsertRegularLoanPayment(_userInfo, _regularLoanPaymentInfo);

                        _regularLoanPaymentInfo = new CommonExchange.RegularLoanPayments();
                        _regularLoanPaymentInfo.RegularLoanInfo = _regularLoanInfo;

                        _regularLoanPaymentInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _regularLoanPaymentInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _regularLoanPaymentInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";              

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.Close();
                        //this.SetControlValues(true);

                        //this.btnRecord.Enabled = true;
                        //this.btnUpdate.Enabled = this.btnDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error inserting regular loan payment.\n\n" + ex.Message, "Error Inserting");
            }
        }//---------------------------
        //########################################END BUTTON btnCreate EVENTS#####################################################

        //########################################BUTTON btnDelete EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to delete the regular loan payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The regular loan payment has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _regularLoanPaymentInfo.ObjectState = DataRowState.Deleted;

                        _cashieringManager.DeleteRegularLoanPayment(_userInfo, _regularLoanPaymentInfo);

                        _regularLoanPaymentInfo = new CommonExchange.RegularLoanPayments();
                        _regularLoanPaymentInfo.RegularLoanInfo = _regularLoanInfo;

                        _regularLoanPaymentInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _regularLoanPaymentInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _regularLoanPaymentInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.SetControlValues(true);

                        this.btnRecord.Enabled = true;
                        this.btnUpdate.Enabled = this.btnDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error deleting regular loan payment.\n\n" + ex.Message, "Error Deleting");
            }
        }//-----------------------------
        //########################################END BUTTON btnDelete EVENTS#####################################################

        //########################################BUTTON btnUpdate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnUpdateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to update the regular loan payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The regular loan payment has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _regularLoanPaymentInfo.ObjectState = DataRowState.Modified;

                        _cashieringManager.UpdateRegularLoanPayment(_userInfo, _regularLoanPaymentInfo);

                        _regularLoanPaymentInfo = new CommonExchange.RegularLoanPayments();
                        _regularLoanPaymentInfo.RegularLoanInfo = _regularLoanInfo;

                        _regularLoanPaymentInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _regularLoanPaymentInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _regularLoanPaymentInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.SetControlValues(true);

                        this.btnRecord.Enabled = true;
                        this.btnUpdate.Enabled = this.btnDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error updating regular loan payment.\n\n" + ex.Message, "Error Updating");
            }
        }//-------------------------------
        //########################################END BUTTON btnUpdate EVENTS#####################################################

        //########################################BUTTON btnClose EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//--------------------------------
        //########################################END BUTTON btnClose EVENTS#####################################################

        //####################################################DATAGRIDVIEW dgvPaymentHistory EVENTS####################################################
        //event is raised when the selction is changed
        private void dgvPaymentHistorySelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _paymentId = row.Cells[_primaryIndex].Value.ToString();
            }
        }//--------------------------

        //event is raised when the data source is changed
        private void dgvPaymentHistoryDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _paymentId = dgvBase[_primaryIndex, 0].Value.ToString();
            }
            else
            {
                _paymentId = "";
            }
        }//--------------------------

        //event is raised when the control is double clicked
        private void dgvPaymentHistoryDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_paymentId))
            {
                _regularLoanPaymentInfo = _cashieringManager.GetDetailsRegularLoanPaymentsInformation(_paymentId);
                _regularLoanPaymentInfo.RegularLoanInfo = _regularLoanInfo;

                this.SetControlValues(false);

                if (_regularLoanPaymentInfo.PaymentId <= 0)
                {
                    this.btnUpdate.Enabled = this.btnDelete.Enabled = false;
                    this.btnRecord.Enabled = true;
                }
                else
                {
                    this.btnUpdate.Enabled = this.btnDelete.Enabled = true;
                    this.btnRecord.Enabled = false;
                }

                this.IsRecordLocked(DateTime.Parse(_regularLoanPaymentInfo.ReceivedDate));
                this.IsRecordLocked(DateTime.Parse(_regularLoanPaymentInfo.ReceiptDate), DateTime.Parse(_regularLoanPaymentInfo.ReceivedDate));
            }
        }//-------------------------

        //event is raised when the mouse is down
        private void dgvPaymentHistoryMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndex = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndex = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndex = -1;
                        _paymentId = "";
                        break;
                }

                if (_rowIndex != -1)
                {
                    _paymentId = dgvBase[_primaryIndex, _rowIndex].Value.ToString();
                }
            }
        }//---------------------------
        //####################################################END DATAGRIDVIEW dgvPaymentHistory EVENTS####################################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will set controls values
        private void SetControlValues(Boolean includeDataGridViews)
        {
            this.lblChange.Text = "-";
            this.txtPayment.Text = _regularLoanPaymentInfo.PaymentAmount.ToString("N");
            this.txtPrincipalPaid.Text = _regularLoanPaymentInfo.PrincipalPaid.ToString("N");
            this.txtInterestPaid.Text = _regularLoanPaymentInfo.InterestPaid.ToString("N");
            this.txtRebate.Text = _regularLoanPaymentInfo.RebateAmount.ToString("N");
            this.txtAmountTendered.Text = _regularLoanPaymentInfo.AmountTendered.ToString("N");

            //this.chkIncludeInterest.Checked = _regularLoanPaymentInfo.InterestPaid > 0 ? true : false;

            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtAmountTendered.Text, out amountTendered)) { }
            if (Decimal.TryParse(this.txtPayment.Text, out paymentAmount)) { }
            this.lblChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));

            this.lblReceivedDate.Text = DateTime.Parse(_regularLoanPaymentInfo.ReceivedDate).ToLongDateString();
            this.lblReflectedDate.Text = DateTime.Parse(_regularLoanPaymentInfo.ReflectedDate).ToLongDateString();
            this.lblReceiptDate.Text = DateTime.Parse(_regularLoanPaymentInfo.ReceiptDate).ToLongDateString();

            this.txtReceiptNo.Text = !String.IsNullOrEmpty(_regularLoanPaymentInfo.ReceiptNo) ? _regularLoanPaymentInfo.ReceiptNo :
                BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");
            
            String strCredit = !String.IsNullOrEmpty(_regularLoanPaymentInfo.AccountCreditInfo.AccountName) ?
                _regularLoanPaymentInfo.AccountCreditInfo.AccountName + " (" + _regularLoanPaymentInfo.AccountCreditInfo.AccountCode + ")" : String.Empty;

            String strRebate = !String.IsNullOrEmpty(_regularLoanPaymentInfo.AccountRebateInfo.AccountName) ?
                _regularLoanPaymentInfo.AccountRebateInfo.AccountName + " (" + _regularLoanPaymentInfo.AccountRebateInfo.AccountCode + ")" : String.Empty;

            this.txtCreditEntry.Text = strCredit;
            this.txtCreditEntryRebate.Text = strRebate;
            this.txtRemarks.Text = _regularLoanPaymentInfo.Remarks;
            this.txtBank.Text = _regularLoanPaymentInfo.Bank;
            this.txtCheck.Text = _regularLoanPaymentInfo.CheckNo;

            this.chkIncludeInterest.Checked = true;

            if (includeDataGridViews)
            {
                this.dgvAmortizationList.DataSource = _cashieringManager.InitializeLoanAmortizationScheduleDataGridView(_regularLoanPaymentInfo.RegularLoanInfo, this.lblTotalInterestPayable);
                this.dgvPaymentHistory.DataSource = _cashieringManager.GetRegularLoanPayments(_userInfo, _regularLoanPaymentInfo.RegularLoanInfo.RegularLoanSysId, this.lblTotalPayment);
            }
        }//-------------------------

        //this procedure will set record status
        //Code History: Priviews code calls (_cashieringManager.GetReflectedDate(<parameters>)) to supply the reflected date.
        //reflected date is delete because of the new record locking feature. (can backward payments more than 4 months)
        private void IsRecordLocked(DateTime receiveDate)
        {
            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiveDate, DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                this.btnRecord.Enabled = this.btnUpdate.Enabled = this.btnDelete.Enabled = false;

                this.lblStatusPayment.Text = "This record is LOCKED";

                this.txtPayment.ReadOnly = this.txtPrincipalPaid.ReadOnly = this.txtInterestPaid.ReadOnly = this.txtRebate.ReadOnly =
                    this.txtAmountTendered.ReadOnly = true;

                this.pbxLockedPayment.Visible = true;
                this.pbxUnlockPayment.Visible = false;                         
            }
            else
            {
                this.btnRecord.Enabled = _regularLoanPaymentInfo.PaymentId > 0 ? false : true;
                this.btnUpdate.Enabled = this.btnDelete.Enabled = _regularLoanPaymentInfo.PaymentId > 0 ? true : false;

                this.txtPayment.ReadOnly = this.txtPrincipalPaid.ReadOnly = this.txtInterestPaid.ReadOnly = this.txtRebate.ReadOnly =
                    this.txtAmountTendered.ReadOnly = false;

                this.lblStatusPayment.Text = "This record is OPEN";

                this.pbxLockedPayment.Visible = false;
                this.pbxUnlockPayment.Visible = true;
            }
        }//---------------------

        //this procedure will set record locking for receipt date
        //Code Added: September 2, 2010
        private void IsRecordLocked(DateTime receiptDate, DateTime receiveDate)
        {
            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiptDate, receiveDate,
                DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                this.btnRecord.Enabled = this.btnUpdate.Enabled = this.btnDelete.Enabled = false;

                this.lblStatusPayment.Text = "This record is LOCKED";

                this.txtPayment.ReadOnly = this.txtPrincipalPaid.ReadOnly = this.txtInterestPaid.ReadOnly = this.txtRebate.ReadOnly =
                    this.txtAmountTendered.ReadOnly = true;

                this.pbxLockedPayment.Visible = true;
                this.pbxUnlockPayment.Visible = false;
            
            }
            else
            {
                this.btnRecord.Enabled = _regularLoanPaymentInfo.PaymentId > 0 ? false : true;
                this.btnUpdate.Enabled = this.btnDelete.Enabled = _regularLoanPaymentInfo.PaymentId > 0 ? true : false;

                this.txtPayment.ReadOnly = this.txtPrincipalPaid.ReadOnly = this.txtInterestPaid.ReadOnly = this.txtRebate.ReadOnly =
                    this.txtAmountTendered.ReadOnly = false;

                this.lblStatusPayment.Text = "This record is OPEN";

                this.pbxLockedPayment.Visible = false;
                this.pbxUnlockPayment.Visible = true;
            }
        }//---------------------
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        private Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnRecord, String.Empty);
            _errProvider.SetError(this.lblReflectedDate, String.Empty);
            _errProvider.SetError(this.lblReceiptDate, String.Empty);
            _errProvider.SetError(this.lblReceivedDate, String.Empty);
            _errProvider.SetError(this.txtReceiptNo, String.Empty);
            _errProvider.SetError(this.txtPayment, String.Empty);
            _errProvider.SetError(this.txtPrincipalPaid, String.Empty);
            //_errProvider.SetError(this.txtInterestPaid, String.Empty);
            _errProvider.SetError(this.txtCreditEntry, String.Empty);
            _errProvider.SetError(this.txtCreditEntryRebate, String.Empty);
            _errProvider.SetError(this.txtRebate, String.Empty);

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.RegularLoanInfo.RegularLoanSysId))
            {
                _errProvider.SetError(this.btnRecord, "A regular loan information is required.");
                _errProvider.SetIconAlignment(this.btnRecord, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.ReflectedDate))
            {
                _errProvider.SetError(this.lblReflectedDate, "Payment reflected date is required.");
                _errProvider.SetIconAlignment(this.lblReflectedDate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.ReceiptDate))
            {
                _errProvider.SetError(this.lblReceiptDate, "Payment receipt date is required.");
                _errProvider.SetIconAlignment(this.lblReceiptDate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.ReceivedDate))
            {
                _errProvider.SetError(this.lblReceivedDate, "Payment received date is required.");
                _errProvider.SetIconAlignment(this.lblReceivedDate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.ReceiptNo))
            {
                _errProvider.SetError(this.txtReceiptNo, "You must provide a receipt number.");
                _errProvider.SetIconAlignment(this.txtReceiptNo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_regularLoanPaymentInfo.AccountCreditInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtCreditEntry, "You must select a credit entry.");
                _errProvider.SetIconAlignment(this.txtCreditEntry, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_regularLoanPaymentInfo.PaymentAmount <= 0)
            {
                _errProvider.SetError(this.txtPayment, "Payment amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtPayment, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            //if (_regularLoanPaymentInfo.InterestPaid <= 0)
            //{
            //    _errProvider.SetError(this.txtInterestPaid, "Interest paid must be greater than zero.");
            //    _errProvider.SetIconAlignment(this.txtInterestPaid, ErrorIconAlignment.MiddleRight);

            //    isValid = false;
            //}

            //if (_regularLoanPaymentInfo.PrincipalPaid <= 0)
            //{
            //    _errProvider.SetError(this.txtPrincipalPaid, "Principal paid must be greater than zero.");
            //    _errProvider.SetIconAlignment(this.txtPrincipalPaid, ErrorIconAlignment.MiddleRight);

            //    isValid = false;
            //}

            if (_regularLoanPaymentInfo.RebateAmount > 0 && String.IsNullOrEmpty(_regularLoanPaymentInfo.AccountRebateInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtCreditEntryRebate, "You must select a rebate credit entry.");
                _errProvider.SetIconAlignment(this.txtCreditEntryRebate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }
            else if (!String.IsNullOrEmpty(_regularLoanPaymentInfo.AccountRebateInfo.AccountSysId) && _regularLoanPaymentInfo.RebateAmount <= 0)
            {
                _errProvider.SetError(this.txtRebate, "Rebate amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtRebate, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//-----------------------
        #endregion
    }
}