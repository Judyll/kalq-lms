using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class RegularLoanMultiplePayment
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private CashieringLogic _cashieringManager;

        private CommonExchange.RegularLoan _regularLoanInfo;

        private Int32 _rowIndex = -1;
        private Int32 _columnIndex = -1;
        #endregion

        #region Class Constructors
        public RegularLoanMultiplePayment(CommonExchange.SysAccess userInfo, CashieringLogic cashieringManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _cashieringManager = cashieringManager;

            this.Load += new EventHandler(ClassLoad);
            this.dgvPaymentList.CellClick += new DataGridViewCellEventHandler(dgvPaymentListCellClick);
            this.dgvPaymentList.MouseDown += new MouseEventHandler(dgvPaymentListMouseDown);
            this.dgvPaymentList.CellValidated += new DataGridViewCellEventHandler(dgvPaymentListCellValidated);
            this.dgvPaymentList.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvPaymentListEditingControlShowing);
            this.chkIncludeInterest.CheckedChanged += new EventHandler(chkIncludeInterestCheckedChanged);
            this.dtpReflectedDate.ValueChanged += new EventHandler(dtpReflectedDateValueChanged);
            this.dtpReceiptDate.ValueChanged += new EventHandler(dtpReceiptDateValueChanged);
            this.btnSearchCreditEntry.Click += new EventHandler(btnSearchCreditEntryClick);
            this.btnCancel.Click += new EventHandler(btnCancelClick);
            this.btnRecord.Click += new EventHandler(btnRecordClick);
        }
        #endregion

        #region Class Event Void Procedures
        //###########################################CLASS RegularLoanMultiplePayment EVENTS#####################################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            this.dgvPaymentList.DataSource = _cashieringManager.InitializeRegularLoanMultiplePayment();
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvPaymentList, false);
        }//------------------------------
        //###########################################END CLASS RegularLoanMultiplePayment EVENTS#####################################################

        //##################################DATAGRIDVIEW dgvPaymentList EVENTS##########################################################
        //event is raised when control cell is clicked
        private void dgvPaymentListCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.RowIndex, e.ColumnIndex);

            //column 3 is equal to account_no column
            if ((e.ColumnIndex == 3) && (hitTest.ColumnIndex != -1))
            {
                using (RegularLoanSearchOnTextBoxList frmSearch = new RegularLoanSearchOnTextBoxList(_userInfo, _cashieringManager,
                    this.dgvPaymentList.Rows[e.RowIndex].Cells["sysid_member_hidden"].Value.ToString()))
                {
                    frmSearch.AdoptGridSize = false;

                    frmSearch.ShowDialog(this);

                    if (frmSearch.HasSelected)
                    {
                        _regularLoanInfo = _cashieringManager.GetDetailsRegularLoanInformation(_userInfo, frmSearch.PrimaryId);

                        this.dgvPaymentList.Rows[e.RowIndex].Cells["account_no"].Value = _regularLoanInfo.AccountNo;
                        this.dgvPaymentList.Rows[e.RowIndex].Cells["sysid_regular_hidden"].Value = _regularLoanInfo.RegularLoanSysId;

                        this.dgvPaymentList.ReadOnly = false;

                        this.dgvPaymentList.Columns["sysid_member_hidden"].ReadOnly = true;
                        this.dgvPaymentList.Columns["person_name_forzeen"].ReadOnly = true;
                        this.dgvPaymentList.Columns["account_no"].ReadOnly = true;
                        this.dgvPaymentList.Columns["reflected_date"].ReadOnly = true;
                        this.dgvPaymentList.Columns["receipt_date"].ReadOnly = true;
                        this.dgvPaymentList.Columns["sysid_account_credit"].ReadOnly = true;
                    }
                }
            }
            else if ((e.ColumnIndex == 10 || e.ColumnIndex == 11) && (hitTest.ColumnIndex != -1))
            {
                this.Cursor = Cursors.WaitCursor;

                DateTime date = DateTime.MinValue;

                if (String.IsNullOrEmpty(this.dgvPaymentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    date = DateTime.Parse(_cashieringManager.ServerDateTime);
                }
                else
                {
                    date = DateTime.Parse(this.dgvPaymentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }

                using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(date))
                {
                    frmPicker.ShowDialog(this);

                    if (frmPicker.HasSelectedDate)
                    {
                        if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                                DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out date))
                        {
                            this.dgvPaymentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = date.ToLongDateString();
                        }

                        if (e.ColumnIndex == 10)
                        {
                            this.IsRecordLocked(date, e.RowIndex);
                        }
                        else
                        {
                            this.IsRecordLocked(date, DateTime.Parse(_cashieringManager.ServerDateTime), e.RowIndex);
                        }
                    }
                }

                this.Cursor = Cursors.Arrow;
            }
            else if ((e.ColumnIndex == 12) && (hitTest.ColumnIndex != -1))
            {
                using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
                {
                    frmSearch.AdoptGridSize = true;
                    frmSearch.ShowDialog(this);

                    if (frmSearch.HasSelected)
                    {
                        CommonExchange.ChartOfAccount accountInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                        this.dgvPaymentList.Rows[e.RowIndex].Cells["account_code_name_not_frozen"].Value = accountInfo.AccountName + "(" + accountInfo.AccountCode + ")";
                        this.dgvPaymentList.Rows[e.RowIndex].Cells["sysid_account_credit"].Value = accountInfo.AccountSysId;
                    }
                }
            }
        }//---------------------------

        //event is raised when the mouse is down
        private void dgvPaymentListMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndex = hitTest.RowIndex;
                        _columnIndex = hitTest.ColumnIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndex = hitTest.RowIndex;
                        _columnIndex = hitTest.ColumnIndex;
                        break;
                    default:
                        _rowIndex = -1;
                        _columnIndex = -1;
                        break;
                }
            }
        }//----------------------------

        //event is raised when control cell is validated
        private void dgvPaymentListCellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8)
            {
                Decimal amount = 0;

                if (Decimal.TryParse(this.dgvPaymentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out amount))
                {
                    if (e.ColumnIndex == 4)
                    {
                        if (amount > 0)
                        {
                            if (this.chkIncludeInterest.Checked)
                            {
                                Decimal totalInterestLessPrePaidInterest = (_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                                    (_regularLoanInfo.LoanTerms - _regularLoanInfo.NoPrepaidInterest));
                                Decimal intrestAmount = totalInterestLessPrePaidInterest / (_regularLoanInfo.LoanTerms - _regularLoanInfo.NoPrepaidInterest);

                                if (amount >= intrestAmount)
                                {
                                    this.dgvPaymentList.Rows[e.RowIndex].Cells["interest_paid"].Value = intrestAmount.ToString("N");
                                    this.dgvPaymentList.Rows[e.RowIndex].Cells["principal_paid"].Value = (amount - intrestAmount).ToString("N");
                                }
                                else
                                {
                                    this.dgvPaymentList.Rows[e.RowIndex].Cells["interest_paid"].Value = amount.ToString("N");
                                    this.dgvPaymentList.Rows[e.RowIndex].Cells["principal_paid"].Value = 0;
                                }
                            }
                            else
                            {
                                this.dgvPaymentList.Rows[e.RowIndex].Cells["interest_paid"].Value = "0.00";
                                this.dgvPaymentList.Rows[e.RowIndex].Cells["principal_paid"].Value = amount.ToString("N");
                            }
                        }
                    }

                    this.dgvPaymentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = amount.ToString("N");
                }
            }
        }//---------------------------

        //event is raised when the control is showing
        private void dgvPaymentListEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(ControlKeyPress);
        }//------------------------------

        //event is raised when the control key is pressed
        private void ControlKeyPress(object sender, KeyPressEventArgs e)
        {
            if (_rowIndex != -1 && _columnIndex != -1)
            {
                if (_columnIndex == 4 || _columnIndex == 5 || _columnIndex == 6 || _columnIndex == 7 || _columnIndex == 8)
                {
                    if (e.KeyChar != '.' && e.KeyChar != ',' && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
        }//---------------------------
        //##################################END DATAGRIDVIEW dgvPaymentList EVENTS##########################################################

        //##################################CHECKBOX chkIncludeInterest EVENTS##########################################################
        //event is raised when checked is change
        private void chkIncludeInterestCheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            foreach (DataGridViewRow dgvRow in this.dgvPaymentList.Rows)
            {
                  Decimal amount = 0;

                  if (Decimal.TryParse(dgvRow.Cells["amount_paid"].Value.ToString(), out amount))
                  {
                      if ((amount > 0 && (!String.IsNullOrEmpty(dgvRow.Cells["sysid_regular_hidden"].Value.ToString()))))
                      {
                          if (this.chkIncludeInterest.Checked)
                          {
                              _regularLoanInfo = _cashieringManager.GetDetailsRegularLoanInformation(_userInfo, dgvRow.Cells["sysid_regular_hidden"].Value.ToString());

                              Decimal totalInterestLessPrePaidInterest = (_regularLoanInfo.LoanAmount * (Decimal)(_regularLoanInfo.InterestRate / 100) *
                                  (_regularLoanInfo.LoanTerms - _regularLoanInfo.NoPrepaidInterest));
                              Decimal intrestAmount = totalInterestLessPrePaidInterest / (_regularLoanInfo.LoanTerms - _regularLoanInfo.NoPrepaidInterest);

                              if (amount >= intrestAmount)
                              {
                                  dgvRow.Cells["interest_paid"].Value = intrestAmount.ToString("N");
                                  dgvRow.Cells["principal_paid"].Value = (amount - intrestAmount).ToString("N");
                              }
                              else
                              {
                                  dgvRow.Cells["interest_paid"].Value = amount.ToString("N");
                                  dgvRow.Cells["principal_paid"].Value = 0;
                              }
                          }
                          else
                          {
                              dgvRow.Cells["interest_paid"].Value = "0.00";
                              dgvRow.Cells["principal_paid"].Value = amount.ToString("N");
                          }
                      }
                  }
            }

            this.Cursor = Cursors.Arrow; 
        }//--------------------------
        //##################################END CHECKBOX chkIncludeInterest EVENTS##########################################################

        //##################################DATETIME PICKER dtpReceiptDate EVENTS##########################################################
        //event is raised when control value is changed
        private void dtpReceiptDateValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            foreach (DataGridViewRow dgvRow in this.dgvPaymentList.Rows)
            {
                dgvRow.Cells["receipt_date"].Value = this.dtpReceiptDate.Value.ToLongDateString();
            }

            this.Cursor = Cursors.Arrow; 
        }//--------------------------------
        //##################################END DATETIME PICKER dtpReceiptDate EVENTS##########################################################

        //##################################DATETIME PICKER dtpReflectedDate EVENTS##########################################################
        //event is raised when control value is changed
        private void dtpReflectedDateValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            foreach (DataGridViewRow dgvRow in this.dgvPaymentList.Rows)
            {
                dgvRow.Cells["reflected_date"].Value = this.dtpReflectedDate.Value.ToLongDateString();
            }

            this.Cursor = Cursors.Arrow; 
        }//----------------------------------
        //##################################END DATETIME PICKER dtpReflectedDate EVENTS##########################################################

        //########################################BUTTON btnSearchCreditEntry EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnSearchCreditEntryClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    CommonExchange.ChartOfAccount accountInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    foreach (DataGridViewRow dgvRow in this.dgvPaymentList.Rows)
                    {
                        dgvRow.Cells["account_code_name_not_frozen"].Value = accountInfo.AccountName + " (" + accountInfo.AccountCode + ")";
                        dgvRow.Cells["sysid_account_credit"].Value = accountInfo.AccountSysId;                        
                    }

                    this.txtCreditEntry.Text = accountInfo.AccountName + " (" + accountInfo.AccountCode + ")"; 
                }
            }

            this.Cursor = Cursors.Arrow; 
        }//----------------------------
        //########################################END BUTTON btnSearchCreditEntry EVENTS#####################################################

        //##################################BUTTON btnCancel EVENTS##########################################################
        //event is raised when control is clicked
        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }//-------------------------
        //##################################END BUTTON btnCancel EVENTS##########################################################

        //##################################BUTTON btnRecord EVENTS##########################################################
        //event is raised when control is clicked
        private void btnRecordClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls())
                {
                    String strMsg = "Are you sure you want to record the new regular loan multiple payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The regular loan multiple payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _cashieringManager.InsertUpdateDeleteRegularLoanPayments(_userInfo, (DataTable)this.dgvPaymentList.DataSource);

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.Cursor = Cursors.Arrow;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error inserting regular loan multiple payment.\n\n" + ex.Message, "Error Inserting");
            }
        }//--------------------------
        //##################################END BUTTON btnRecord EVENTS##########################################################

        #endregion

        #region Programmer's Defined Functions
        //this function will vaidate controls
        private Boolean ValidateControls()
        {
            Boolean isValid = true;

            this.dgvPaymentList.ShowCellErrors = false;

            foreach (DataGridViewRow dgvRow in this.dgvPaymentList.Rows)
            {
                if (String.IsNullOrEmpty(dgvRow.Cells["sysid_regular_hidden"].Value.ToString()))
                {
                    dgvRow.Cells["account_no"].ErrorText = "You must select a regular loan information.";

                    isValid = false;
                }

                if (String.IsNullOrEmpty(dgvRow.Cells["reflected_date"].Value.ToString()))
                {
                    dgvRow.Cells["reflected_date"].ErrorText = "Payment reflected date is required.";

                    isValid = false;
                }

                if (String.IsNullOrEmpty(dgvRow.Cells["receipt_date"].Value.ToString()))
                {
                    dgvRow.Cells["receipt_date"].ErrorText = "Payment receipt date is required.";

                    isValid = false;
                }

                if (String.IsNullOrEmpty(dgvRow.Cells["receipt_no"].Value.ToString()))
                {
                    dgvRow.Cells["receipt_no"].ErrorText = "You must provide a receipt number.";

                    isValid = false;
                }

                if (String.IsNullOrEmpty(dgvRow.Cells["sysid_account_credit"].Value.ToString()))
                {
                    dgvRow.Cells["account_code_name_not_frozen"].ErrorText = "You must select a credit entry.";

                    isValid = false;
                }

                if (!String.IsNullOrEmpty(dgvRow.Cells["amount_paid"].Value.ToString()) &&
                    Decimal.Parse(dgvRow.Cells["amount_paid"].Value.ToString()) <= 0)
                {
                    dgvRow.Cells["amount_paid"].ErrorText = "Payment amount must be greater than zero.";

                    isValid = false;
                }
                else if (String.IsNullOrEmpty(dgvRow.Cells["amount_paid"].Value.ToString()))
                {
                    dgvRow.Cells["amount_paid"].ErrorText = "Payment amount is required.";

                    isValid = false;
                }

                if (!String.IsNullOrEmpty(dgvRow.Cells["interest_paid"].Value.ToString()) &&
                     Decimal.Parse(dgvRow.Cells["interest_paid"].Value.ToString()) <= 0)
                {
                    dgvRow.Cells["interest_paid"].ErrorText = "Interest paid must be greater than zero.";

                    isValid = false;
                }
                else if (String.IsNullOrEmpty(dgvRow.Cells["interest_paid"].Value.ToString()))
                {
                    dgvRow.Cells["interest_paid"].ErrorText = "Interest paid is required.";

                    isValid = false;
                }

                if (!String.IsNullOrEmpty(dgvRow.Cells["principal_paid"].Value.ToString()) &&
                     Decimal.Parse(dgvRow.Cells["principal_paid"].Value.ToString()) <= 0)
                {
                    dgvRow.Cells["principal_paid"].ErrorText = "Principal paid must be greater than zero.";

                    isValid = false;
                }
                else if (String.IsNullOrEmpty(dgvRow.Cells["principal_paid"].Value.ToString()))
                {
                    dgvRow.Cells["principal_paid"].ErrorText = "Principal paid is required.";

                    isValid = false;
                }
            }

            this.dgvPaymentList.ShowCellErrors = true;

            return isValid;
        }//----------------------

        //this procedure will set record status
        //Code History: Priviews code calls (_cashieringManager.GetReflectedDate(<parameters>)) to supply the reflected date.
        //reflected date is delete because of the new record locking feature. (can backward payments more than 4 months)
        private void IsRecordLocked(DateTime receiveDate, Int32 rowIndex)
        {
             this.dgvPaymentList.ShowCellErrors = false;

            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiveDate, DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                this.btnRecord.Enabled = false;

                DataGridViewRow dgvRow = this.dgvPaymentList.Rows[rowIndex];

                if (String.IsNullOrEmpty(dgvRow.Cells["reflected_date"].Value.ToString()))
                {
                    dgvRow.Cells["reflected_date"].ErrorText = "Invalid reflected date. This record is LOCKED.";                    
                }
            }
            else
            {
                this.btnRecord.Enabled = true;
            }

            this.dgvPaymentList.ShowCellErrors = true;
        }//---------------------

        //this procedure will set record locking for receipt date
        //Code Added: September 2, 2010
        private void IsRecordLocked(DateTime receiptDate, DateTime receiveDate, Int32 rowIndex)
        {
            this.dgvPaymentList.ShowCellErrors = false;

            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiptDate, receiveDate,
                DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                this.btnRecord.Enabled = false;

                DataGridViewRow dgvRow = this.dgvPaymentList.Rows[rowIndex];

                if (String.IsNullOrEmpty(dgvRow.Cells["receipt_date"].Value.ToString()))
                {
                    dgvRow.Cells["receipt_date"].ErrorText = "Invalid receipt date. This record is LOCKED.";
                }
            }
            else
            {
                this.btnRecord.Enabled = true;
            }

            this.dgvPaymentList.ShowCellErrors = true;
        }//---------------------
        #endregion
    }
}
