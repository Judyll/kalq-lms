using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class MiscellaneousIncome
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private CommonExchange.MiscellaneousIncome _miscellaneousIncomeInfo;
        private CashieringLogic _cashieringManager;

        private String _miscellaneousePaymentId = String.Empty;

        private ErrorProvider _errProvider;

        private ToolTip _tTool;
        #endregion

        #region Class Constructors
        public MiscellaneousIncome(CommonExchange.SysAccess userInfo, CashieringLogic cashieringManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _cashieringManager = cashieringManager;

            this.Load += new EventHandler(ClassLoad);
            this.txtReceivedFrom.Validated += new EventHandler(txtReceivedFromValidated);
            this.txtReceivedFrom.KeyPress += new KeyPressEventHandler(txtReceivedFromKeyPress);
            this.txtPaymentAmount.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtDiscountedAmount.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtAmountTendered.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtPaymentAmount.KeyPress += new KeyPressEventHandler(txtPaymentAmountKeyPress);
            this.txtPaymentAmount.Validated += new EventHandler(txtPaymentAmountValidated);
            this.txtPaymentAmount.KeyUp += new KeyEventHandler(txtPaymentAmountKeyUp);
            this.txtDiscountedAmount.KeyPress += new KeyPressEventHandler(txtDiscountedAmountKeyPress);
            this.txtDiscountedAmount.Validated += new EventHandler(txtDiscountedAmountValidated);
            this.txtAmountTendered.KeyPress += new KeyPressEventHandler(txtAmountTenderedKeyPress);
            this.txtAmountTendered.Validated += new EventHandler(txtAmountTenderedValidated);
            this.txtAmountTendered.KeyUp += new KeyEventHandler(txtAmountTenderedKeyUp);
            this.txtReceipNo.KeyPress += new KeyPressEventHandler(txtReceipNoKeyPress);
            this.txtReceipNo.Validated += new EventHandler(txtReceipNoValidated);
            this.txtCreditEntry.KeyPress += new KeyPressEventHandler(txtCreditEntryKeyPress);
            this.txtPaymentRemarks.KeyPress += new KeyPressEventHandler(txtPaymentRemarksKeyPress);
            this.txtPaymentRemarks.Validated += new EventHandler(txtPaymentRemarksValidated);
            this.txtBank.KeyPress += new KeyPressEventHandler(txtBankKeyPress);
            this.txtBank.Validated += new EventHandler(txtBankValidated);
            this.txtCheckNo.Validated += new EventHandler(txtCheckNoValidated);
            this.txtSearch.KeyPress += new KeyPressEventHandler(txtSearchKeyPress);
            this.chkIncludeDate.CheckedChanged += new EventHandler(chkIncludeDateCheckedChanged);
            this.lsvMiscellaneousPaymentHistory.MouseDoubleClick += new MouseEventHandler(lsvMiscellaneousPaymentHistoryMouseDoubleClick);
            this.lsvMiscellaneousPaymentHistory.MouseDown += new MouseEventHandler(lsvMiscellaneousPaymentHistoryMouseDown);
            this.dtpStart.ValueChanged += new EventHandler(dateTimePickerValueChage);
            this.dtpEnd.ValueChanged += new EventHandler(dateTimePickerValueChage);
            this.lblPaymentReflectedDate.Click += new EventHandler(lblPaymentReflectedDateClick);
            this.lblReceiptDate.Click += new EventHandler(lblReceiptDateClick);
            this.btnSearchedStudent.Click += new EventHandler(btnSearchedStudentClick);
            this.btnSearchedAccountTitle.Click += new EventHandler(btnSearchedAccountTitleClick);
            this.btnCreate.Click += new EventHandler(btnCreateClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
            this.btnClose.Click += new EventHandler(btnCloseClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS MiscellaneousIncome EVENTS####################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            _errProvider = new ErrorProvider();

            _tTool = new ToolTip();

            _tTool.SetToolTip(this.btnSearchedStudent, "Member and Employee Search");

            _miscellaneousIncomeInfo = new CommonExchange.MiscellaneousIncome();

            this.txtReceipNo.Text = _miscellaneousIncomeInfo.ReceiptNo = CashieringLogic.ReceiptNumber.ToString("000000");

            _miscellaneousIncomeInfo.ReceivedDate = _cashieringManager.ServerDateTime;
            _miscellaneousIncomeInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

            this.lblPaymentReceivedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblPaymentReflectedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();

            _miscellaneousIncomeInfo.ReceiptDate = DateTime.Parse(CashieringLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

            this.lblReceiptDate.Text = DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate).ToLongDateString();

            this.IsRecordLocked(DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate), DateTime.Parse(_miscellaneousIncomeInfo.ReceivedDate));
        }//---------------------------
        //####################################END CLASS MiscellaneousIncome EVENTS####################################

        //###########################################TEXTBOX txtAmount EVENTS#####################################################
        //event is raised when the control is validating
        private void txtAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//---------------------        
        //###########################################END TEXTBOX txtAmount EVENTS#####################################################

        //###########################################TEXTBOX txtReceivedFrom EVENTS#####################################################
        //event is raised when the control is validated
        private void txtReceivedFromValidated(object sender, EventArgs e)
        {
            _miscellaneousIncomeInfo.ReceivedFrom = BaseServices.ProcStatic.TrimStartEndString(this.txtReceivedFrom.Text);
        }//-------------------------

        //event is raised when the key is pressed
        private void txtReceivedFromKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtPaymentAmount.Focus();
            }
        }//--------------------
        //###########################################END TEXTBOX txtReceivedFrom EVENTS#####################################################

        //###########################################TEXTBOX txtPaymentAmount EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtPaymentAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtDiscountedAmount.Focus();
            }
        }//-----------------------------

        //event is raised when the control is validated
        private void txtPaymentAmountValidated(object sender, EventArgs e)
        {
            Decimal amount;

            if (Decimal.TryParse(txtPaymentAmount.Text, out amount))
            {
                _miscellaneousIncomeInfo.MiscellaneousAmount = amount;
            }
        }//------------------

        //event is raised when the key is up
        private void txtPaymentAmountKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtPaymentAmount.Text, out paymentAmount)) { }

            this.lblChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//----------------------------------
        //###########################################END TEXTBOX txtPaymentAmount EVENTS#####################################################

        //###########################################TEXTBOX txtDiscountedAmount EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtDiscountedAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtAmountTendered.Focus();
            }
        }//-------------------------

        //event is raised when the control is validated
        private void txtDiscountedAmountValidated(object sender, EventArgs e)
        {
            Decimal amount;

            if (Decimal.TryParse(this.txtDiscountedAmount.Text, out amount))
            {
                _miscellaneousIncomeInfo.DiscountAmount = amount;
            }
        }//------------------
        //##########################################END TEXTBOX txtDiscountedAmount EVENTS#####################################################

        //###########################################TEXTBOX txtAmountTendered EVENTS#####################################################
        //event is raised whent the control is validated
        private void txtAmountTenderedValidated(object sender, EventArgs e)
        {
            Decimal amountTendered;

            if (Decimal.TryParse(this.txtAmountTendered.Text, out amountTendered))
            {
                _miscellaneousIncomeInfo.AmountTendered = amountTendered;
            }
        }//------------------

        //event is raised when the key is pressed
        private void txtAmountTenderedKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtReceipNo.Focus();
            }
        }//----------------------

        //event is raised when the key is up
        private void txtAmountTenderedKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtPaymentAmount.Text, out paymentAmount)) { }

            this.lblChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//---------------------------
        //###########################################END TEXTBOX txtAmountTendered EVENTS#####################################################

        //###########################################TEXTBOX txtReceipNo EVENTS#####################################################
        //event is raised whent the key is pressed
        private void txtReceipNoKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxIntegersOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtCreditEntry.Focus();
            }
        }//-----------------

        //event is raised when the control is validated
        private void txtReceipNoValidated(object sender, EventArgs e)
        {
            _miscellaneousIncomeInfo.ReceiptNo = this.txtReceipNo.Text = BaseServices.ProcStatic.TrimStartEndString(this.txtReceipNo.Text);
        }//--------------------
        //###########################################TEXTBOX txtReceipNo EVENTS#####################################################

        //###########################################TEXTBOX txtCreditEntry EVENTS#####################################################
        //event is raised whent the key is pressed
        private void txtCreditEntryKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxIntegersOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtPaymentRemarks.Focus();
            }
        }//----------------------
        //###########################################END TEXTBOX txtCreditEntry EVENTS#####################################################

        //###########################################TEXTBOX txtRemarks EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtPaymentRemarksKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtBank.Focus();
            }
        }//---------------------------

        //event is raised when the control is validated
        private void txtPaymentRemarksValidated(object sender, EventArgs e)
        {
            _miscellaneousIncomeInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtPaymentRemarks.Text);
        }//--------------------
        //###########################################END TEXTBOX txtRemarks EVENTS#####################################################

        //###########################################TEXTBOX txtBank EVENTS#####################################################
        //event is raised when the control is validated
        private void txtBankValidated(object sender, EventArgs e)
        {
            _miscellaneousIncomeInfo.Bank = BaseServices.ProcStatic.TrimStartEndString(this.txtBank.Text);
        }//----------------

        //event is raised when the key is pressed
        private void txtBankKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtCheckNo.Focus();
            }
        }//-------------------
        //###########################################END TEXTBOX txtBank EVENTS#####################################################

        //###########################################TEXTBOX txtCheckNo EVENTS#####################################################
        //event is raised when the control is validated
        private void txtCheckNoValidated(object sender, EventArgs e)
        {
            _miscellaneousIncomeInfo.CheckNo = BaseServices.ProcStatic.TrimStartEndString(this.txtCheckNo.Text);
        }//------------------------
        //###########################################END TEXTBOX txtCheckNo EVENTS#####################################################

        //###########################################TEXTBOX txtSearch EVENTS#####################################################
        //event is raised when the control key is pressed
        private void txtSearchKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (this.chkIncludeDate.Checked)
                {
                    String dateStart, dateEnd = String.Empty;

                    dateStart = this.dtpStart.Value.ToShortDateString() + " 12:00:00 AM";
                    dateEnd = this.dtpEnd.Value.ToShortDateString() + " 11:59:59 PM";

                    if (DateTime.Compare(DateTime.Parse(dateStart), DateTime.Parse(dateEnd)) < 0)
                    {
                        _cashieringManager.InitializeMiscellaneousePaymentListView(this.lsvMiscellaneousPaymentHistory, _userInfo,
                            this.txtSearch.Text, dateStart, dateEnd);
                    }
                    else
                    {
                        MessageBox.Show("Date start must me greater than date end.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _cashieringManager.InitializeMiscellaneousePaymentListView(this.lsvMiscellaneousPaymentHistory, _userInfo,
                        this.txtSearch.Text, String.Empty, String.Empty);
                }
            }
        }//------------------------
        //###########################################END TEXTBOX txtSearch EVENTS#####################################################

        //###########################################CHECKEDBOX chkIncludeDate EVENTS#####################################################
        //event is raised when the control key is pressed
        private void chkIncludeDateCheckedChanged(object sender, EventArgs e)
        {
            this.dtpStart.Enabled = this.dtpEnd.Enabled = this.chkIncludeDate.Checked ? true : false;

            this.txtSearch.Focus();
        }//------------------------
        //###########################################END CHECKEDBOX chkIncludeDate EVENTS#####################################################

        //###########################################LISTVIEW lsvMiscellaneousPaymentHistory EVENTS#####################################################
        //event is raised when the mouse double clicked
        private void lsvMiscellaneousPaymentHistoryMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((this.lsvMiscellaneousPaymentHistory.Items.Count > 0 && this.lsvMiscellaneousPaymentHistory.FocusedItem != null) &&
                    this.lsvMiscellaneousPaymentHistory.GetItemAt(e.X, e.Y) != null)
                {
                    _miscellaneousIncomeInfo =
                        _cashieringManager.GetDetailsMiscellaneousIncomeInformation(this.lsvMiscellaneousPaymentHistory.GetItemAt(e.X, e.Y).SubItems[9].Text);

                    this.AssignedValuesToMiscellaneousControls();

                    this.IsRecordLocked(DateTime.Parse(_miscellaneousIncomeInfo.ReceivedDate));
                }
            }
        }//-------------------------

        //event is raised when the mouse is down
        private void lsvMiscellaneousPaymentHistoryMouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right || e.Button == MouseButtons.Left) &&
             (this.lsvMiscellaneousPaymentHistory.Items.Count > 0 && this.lsvMiscellaneousPaymentHistory.FocusedItem != null))
            {
                if (this.lsvMiscellaneousPaymentHistory.SelectedItems.Count > 0)
                {
                    if (this.lsvMiscellaneousPaymentHistory.GetItemAt(e.X, e.Y) != null && e.Button == MouseButtons.Right)
                    {
                        String strMsg = "Print - [" + this.lsvMiscellaneousPaymentHistory.GetItemAt(e.X, e.Y).Text + "].";

                        _miscellaneousePaymentId = this.lsvMiscellaneousPaymentHistory.GetItemAt(e.X, e.Y).SubItems[9].Text;
                    }
                }
            }
        }//---------------------------
        //###########################################END LISTVIEW lsvMiscellaneousPaymentHistory EVENTS#####################################################

        //###########################################DATE TIME PICKER dtpDateStartEnd EVENTS#####################################################
        //event is raised when the mouse double clicked
        private void dateTimePickerValueChage(object sender, EventArgs e)
        {
            this.txtSearch.Focus();
        }//-------------------------
        //###########################################END DATE TIME PICKER dtpDateStartEnd EVENTS#####################################################

        //###########################################LABEL lblPaymentReflectedDate EVENTS#####################################################
        //event is raised when the mouse double clicked
        private void lblPaymentReflectedDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime paymentDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_miscellaneousIncomeInfo.ReflectedDate))
            {
                paymentDate = DateTime.Parse(_cashieringManager.ServerDateTime);
            }
            else
            {
                paymentDate = DateTime.Parse(_miscellaneousIncomeInfo.ReflectedDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(paymentDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out paymentDate))
                    {
                        _miscellaneousIncomeInfo.ReflectedDate = paymentDate.ToShortDateString() + " 12:00:00 AM";

                        if (DateTime.Compare(paymentDate, DateTime.Parse(_miscellaneousIncomeInfo.ReceivedDate)) != 0)
                        {
                            _miscellaneousIncomeInfo.AccountCreditInfo.AccountSysId = String.Empty;

                            this.txtCreditEntry.Text = String.Empty;
                        }
                    }

                    this.lblPaymentReflectedDate.Text = paymentDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_miscellaneousIncomeInfo.ReceivedDate));
                }
            }

            this.Cursor = Cursors.Arrow;
        }//-----------------------
        //###########################################END LABEL lblPaymentReflectedDate EVENTS#####################################################

        //###########################################LABEL lblReceiptDate EVENTS#####################################################
        //event is raised when the control is clicked
        private void lblReceiptDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime receiptDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_miscellaneousIncomeInfo.ReceiptDate))
            {
                receiptDate = DateTime.Parse(CashieringLogic.ReceiptDate);
            }
            else
            {
                receiptDate = DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(receiptDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out receiptDate))
                    {
                        _miscellaneousIncomeInfo.ReceiptDate = receiptDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblReceiptDate.Text = receiptDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate), DateTime.Parse(_miscellaneousIncomeInfo.ReceivedDate));
                }
            }

            this.Cursor = Cursors.Arrow;
        }//------------------
        //###########################################END LABEL lblReceiptDate EVENTS#####################################################

        //###########################################BUTTON btnSearchedStudent EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchedStudentClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (MemberEmployeeSearchOnTextBoxList frmSearched = new MemberEmployeeSearchOnTextBoxList(_userInfo, _cashieringManager))
                {
                    frmSearched.ShowDialog(this);

                    if (frmSearched.HasSelected)
                    {
                        if (_cashieringManager.IsMemberInformation(frmSearched.PrimaryId))
                        {
                            _miscellaneousIncomeInfo.MemberInfo = _cashieringManager.GetDetailsMemberInformationMiscallaneousIncome(frmSearched.PrimaryId);

                            this.txtReceivedFrom.Text = _miscellaneousIncomeInfo.ReceivedFrom =
                                BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_miscellaneousIncomeInfo.MemberInfo.PersonInfo.LastName,
                                _miscellaneousIncomeInfo.MemberInfo.PersonInfo.FirstName, _miscellaneousIncomeInfo.MemberInfo.PersonInfo.MiddleName) +
                                " (" + _miscellaneousIncomeInfo.MemberInfo.MemberId + ")";

                            _miscellaneousIncomeInfo.CollectorInfo.CollectorSysId = String.Empty;
                        }
                        else
                        {
                            _miscellaneousIncomeInfo.CollectorInfo = _cashieringManager.GetDetailsCollectorInformation(frmSearched.PrimaryId);

                            this.txtReceivedFrom.Text = _miscellaneousIncomeInfo.ReceivedFrom =
                                BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_miscellaneousIncomeInfo.CollectorInfo.PersonInfo.LastName,
                                _miscellaneousIncomeInfo.CollectorInfo.PersonInfo.FirstName, _miscellaneousIncomeInfo.CollectorInfo.PersonInfo.MiddleName) +
                                " (" + _miscellaneousIncomeInfo.CollectorInfo.EmployeeId + ")";

                            _miscellaneousIncomeInfo.MemberInfo.MemberSysId = String.Empty;
                        }
                    }
                }

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
            }
        }//--------------------------
        //###########################################END BUTTON btnSearchedStudent EVENTS#####################################################

        //###########################################BUTTON btnSearchedAccountTitle EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchedAccountTitleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
                {
                    frmSearch.AdoptGridSize = true;
                    frmSearch.ShowDialog(this);

                    if (frmSearch.HasSelected)
                    {
                        _miscellaneousIncomeInfo.AccountCreditInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                        this.txtCreditEntry.Text = !String.IsNullOrEmpty(_miscellaneousIncomeInfo.AccountCreditInfo.AccountSysId) ?
                            _miscellaneousIncomeInfo.AccountCreditInfo.AccountCode + " - " + _miscellaneousIncomeInfo.AccountCreditInfo.AccountName : String.Empty;
                    }
                }

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
            }
        }//----------------------
        //###########################################END BUTTON btnSearchedAccountTitle EVENTS#####################################################

        //###########################################BUTTON btnCreate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnCreateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to record the new miscellaneous payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The miscellaneous payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _miscellaneousIncomeInfo.ObjectState = DataRowState.Added;

                        _cashieringManager.InsertMiscellaneousIncome(_userInfo, _miscellaneousIncomeInfo);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        long wholeNum = _cashieringManager.GetWholeNumberTenthDecimal(_miscellaneousIncomeInfo.MiscellaneousAmount, true);
                        int decNum = (int)_cashieringManager.GetWholeNumberTenthDecimal(_miscellaneousIncomeInfo.MiscellaneousAmount, false);

                        //_cashieringManager.PrintReceiptMiscellaneousIncome(_userInfo, _miscellaneousIncomeInfo, wholeNum, decNum);
                                              
                        _miscellaneousIncomeInfo = new CommonExchange.MiscellaneousIncome();

                        this.InitializeMiscellaneouseIncomeControls();

                        _miscellaneousIncomeInfo.ReceiptDate = CashieringLogic.ReceiptDate;

                        this.lblReceiptDate.Text = DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate).ToLongDateString();
                    }
                    else
                    {
                        CashieringLogic.ReceiptNumber -= 1;
                    }
                }
            }
            catch (Exception ex)
            {
                 BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Recording");
            }
        }//-------------------------
        //###########################################END BUTTON btnCreate EVENTS#####################################################

        //###########################################BUTTON btnUpdate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnUpdateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to update the miscellaneous payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The miscellaneous payment has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _miscellaneousIncomeInfo.ObjectState = DataRowState.Modified;

                        _cashieringManager.UpdateMiscellaneousIncome(_userInfo, _miscellaneousIncomeInfo);

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _miscellaneousIncomeInfo = new CommonExchange.MiscellaneousIncome();

                        this.InitializeMiscellaneouseIncomeControls();

                        this.btnCreate.Enabled = true;
                        this.btnUpdate.Enabled = this.btnDelete.Enabled = false;
                        this.txtPaymentAmount.ReadOnly = this.txtReceipNo.ReadOnly = this.txtPaymentRemarks.ReadOnly = this.txtDiscountedAmount.ReadOnly = false;

                        _miscellaneousIncomeInfo.ReceiptDate = CashieringLogic.ReceiptDate;

                        this.lblReceiptDate.Text = DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate).ToLongDateString();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Updating");
            }
        }//----------------------
        //###########################################END BUTTON btnUpdate EVENTS#####################################################

        //###########################################BUTTON btnDelete EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to delete the miscellaneous payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The mescellaneous payment has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        Boolean hasProcedded = false;

                        try
                        {
                            this.Cursor = Cursors.WaitCursor;

                            _miscellaneousIncomeInfo.ObjectState = DataRowState.Deleted;

                            _cashieringManager.DeleteMiscellaneousIncome(_userInfo, _miscellaneousIncomeInfo);

                            _miscellaneousIncomeInfo = new CommonExchange.MiscellaneousIncome();

                            this.InitializeMiscellaneouseIncomeControls();

                            this.btnDelete.Enabled = this.btnUpdate.Enabled = false;
                            this.btnCreate.Enabled = true;

                            _miscellaneousIncomeInfo.ReceiptDate = CashieringLogic.ReceiptDate;

                            this.lblReceiptDate.Text = DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate).ToLongDateString();

                            this.Cursor = Cursors.Arrow;
                        }
                        catch (Exception ex)
                        {
                            BaseServices.ProcStatic.ShowErrorDialog("Error loading receipt information module./n/n" + ex.Message, "Error Loading");
                        }

                        this.Cursor = Cursors.Arrow;

                        if (hasProcedded)
                        {
                            MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Deleting");
            }
        }//-----------------------
        //###########################################END BUTTON btnDelete EVENTS#####################################################

        //###########################################BUTTON btnClose EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//--------------------------
        //###########################################END BUTTON btnClose EVENTS#####################################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will reset miscellaneous income controls
        private void InitializeMiscellaneouseIncomeControls()
        {
            this.txtReceivedFrom.Clear();
            this.txtPaymentAmount.Clear();
            this.txtReceipNo.Text = CashieringLogic.ReceiptNumber.ToString("000000");
            this.txtPaymentRemarks.Clear();
            this.txtDiscountedAmount.Clear();
            this.txtAmountTendered.Clear();
            this.txtCreditEntry.Clear();
            this.txtBank.Clear();
            this.txtCheckNo.Clear();
            this.lblChange.Text = "-";

            this.txtReceivedFrom.Focus();

            _miscellaneousIncomeInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _miscellaneousIncomeInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

            this.lblPaymentReceivedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblPaymentReflectedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();

            this.lblPaymentReflectedDate.Cursor = Cursors.Hand;
        }//--------------------------

        //this procedure will assigned values to miscellaneous income controls
        private void AssignedValuesToMiscellaneousControls()
        {
            this.txtReceivedFrom.Text = _miscellaneousIncomeInfo.ReceivedFrom;
            this.txtPaymentAmount.Text = _miscellaneousIncomeInfo.MiscellaneousAmount.ToString("N");
            this.txtDiscountedAmount.Text = _miscellaneousIncomeInfo.DiscountAmount.ToString("N");
            this.txtAmountTendered.Text = _miscellaneousIncomeInfo.AmountTendered.ToString("N");
            this.txtReceipNo.Text = _miscellaneousIncomeInfo.ReceiptNo;
            this.lblChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (_miscellaneousIncomeInfo.AmountTendered - _miscellaneousIncomeInfo.MiscellaneousAmount));
            this.txtBank.Text = _miscellaneousIncomeInfo.Bank;
            this.txtCheckNo.Text = _miscellaneousIncomeInfo.CheckNo;
            this.txtPaymentRemarks.Text = _miscellaneousIncomeInfo.Remarks;
            this.txtCreditEntry.Text = !String.IsNullOrEmpty(_miscellaneousIncomeInfo.AccountCreditInfo.AccountSysId) ?
                _miscellaneousIncomeInfo.AccountCreditInfo.AccountCode + " - " + _miscellaneousIncomeInfo.AccountCreditInfo.AccountName : String.Empty;

            if (_miscellaneousIncomeInfo.PaymentId <= 0)
            {
                this.btnUpdate.Enabled = this.btnDelete.Enabled = false;
                this.btnCreate.Enabled = true;

                this.lblPaymentReceivedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
                this.lblPaymentReflectedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();

            }
            else
            {
                this.btnUpdate.Enabled = this.btnDelete.Enabled = true;
                this.btnCreate.Enabled = false;

                this.lblPaymentReceivedDate.Text = DateTime.Parse(_miscellaneousIncomeInfo.ReceivedDate).ToLongDateString();
                this.lblPaymentReflectedDate.Text = DateTime.Parse(_miscellaneousIncomeInfo.ReflectedDate.ToString()).ToLongDateString();
            }

            this.lblReceiptDate.Text = DateTime.Parse(_miscellaneousIncomeInfo.ReceiptDate).ToLongDateString();
        }//-------------------------------
        #endregion

        #region Programmer's Defined Function
        //this procedure will set record status
        private void IsRecordLocked(DateTime receiveDate)
        {
            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiveDate, DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                this.btnCreate.Enabled = this.btnUpdate.Enabled = this.btnDelete.Enabled =
                    this.btnSearchedStudent.Enabled = this.btnSearchedAccountTitle.Enabled = false;

                this.lblStatusPayment.Text = "This record is LOCKED";

                this.txtPaymentAmount.ReadOnly = this.txtDiscountedAmount.ReadOnly = this.txtReceipNo.ReadOnly = this.txtPaymentRemarks.ReadOnly =
                    this.txtReceivedFrom.ReadOnly = this.txtAmountTendered.ReadOnly = this.txtBank.ReadOnly = this.txtCheckNo.ReadOnly = true;

                this.pbxLockedPayment.Visible = true;
                this.pbxUnlockPayment.Visible = false;
            }
            else
            {
                this.btnCreate.Enabled = _miscellaneousIncomeInfo.PaymentId > 0 ? false : true;
                this.btnUpdate.Enabled = this.btnDelete.Enabled = _miscellaneousIncomeInfo.PaymentId > 0 ? true : false;

                this.lblStatusPayment.Text = "This record is OPEN";

                this.txtPaymentAmount.ReadOnly = this.txtDiscountedAmount.ReadOnly = this.txtReceipNo.ReadOnly = this.txtPaymentRemarks.ReadOnly =
                    this.txtReceivedFrom.ReadOnly = this.txtAmountTendered.ReadOnly = this.txtBank.ReadOnly = this.txtCheckNo.ReadOnly = false;

                this.btnSearchedStudent.Enabled = this.btnSearchedAccountTitle.Enabled =  true;

                this.pbxLockedPayment.Visible = false;
                this.pbxUnlockPayment.Visible = true;

                this.lblPaymentReflectedDate.Cursor = Cursors.Hand;
            }
        }//---------------------

        //this procedure will set record locking for receipt date
        //Code Added: September 2, 2010
        private void IsRecordLocked(DateTime receiptDate, DateTime receiveDate)
        {
            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiptDate, receiveDate,
                DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                this.btnCreate.Enabled = this.btnUpdate.Enabled = this.btnDelete.Enabled =
                     this.btnSearchedStudent.Enabled = this.btnSearchedAccountTitle.Enabled = false;

                this.lblStatusPayment.Text = "This record is LOCKED";

                this.txtPaymentAmount.ReadOnly = this.txtDiscountedAmount.ReadOnly = this.txtReceipNo.ReadOnly = this.txtPaymentRemarks.ReadOnly =
                    this.txtReceivedFrom.ReadOnly = this.txtAmountTendered.ReadOnly = this.txtBank.ReadOnly = this.txtCheckNo.ReadOnly = true;

                this.pbxLockedPayment.Visible = true;
                this.pbxUnlockPayment.Visible = false;

                this.lblReceiptDate.Cursor = Cursors.Hand;
            }
            else
            {

                this.btnCreate.Enabled = _miscellaneousIncomeInfo.PaymentId > 0 ? false : true;
                this.btnUpdate.Enabled = this.btnDelete.Enabled = _miscellaneousIncomeInfo.PaymentId > 0 ? true : false;

                this.lblStatusPayment.Text = "This record is OPEN";

                this.txtPaymentAmount.ReadOnly = this.txtDiscountedAmount.ReadOnly = this.txtReceipNo.ReadOnly = this.txtPaymentRemarks.ReadOnly =
                    this.txtReceivedFrom.ReadOnly = this.txtAmountTendered.ReadOnly = this.txtBank.ReadOnly = this.txtCheckNo.ReadOnly = false;

                this.btnSearchedStudent.Enabled = this.btnSearchedAccountTitle.Enabled = true;

                this.pbxLockedPayment.Visible = false;
                this.pbxUnlockPayment.Visible = true;

                this.lblReceiptDate.Cursor = Cursors.Hand;
            }
        }//---------------------

        //this function will validate controls
        private Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtPaymentAmount, "");
            _errProvider.SetError(this.txtReceipNo, "");
            _errProvider.SetError(this.txtReceivedFrom, "");
            _errProvider.SetError(this.txtCreditEntry, "");

            if (_miscellaneousIncomeInfo.MiscellaneousAmount <= 0)
            {
                _errProvider.SetError(this.txtPaymentAmount, "Amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtPaymentAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_miscellaneousIncomeInfo.ReceiptNo))
            {
                _errProvider.SetError(this.txtReceipNo, "You must input a receipt number.");
                _errProvider.SetIconAlignment(this.txtReceipNo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_miscellaneousIncomeInfo.AccountCreditInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtCreditEntry, "You must select a credit entry information.");
                _errProvider.SetIconAlignment(this.txtCreditEntry, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }


            if (String.IsNullOrEmpty(_miscellaneousIncomeInfo.ReceivedFrom))
            {
                _errProvider.SetError(this.txtReceivedFrom, "Received from is required.");
                _errProvider.SetIconAlignment(this.txtReceivedFrom, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//--------------------------
        #endregion
    }
}
