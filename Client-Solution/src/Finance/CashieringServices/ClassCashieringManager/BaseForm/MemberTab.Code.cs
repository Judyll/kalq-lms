using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class MemberTab : IDisposable
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private CommonExchange.Member _memberInfo;
        private CommonExchange.ShareCapitalCredit _shareCapitalCreditInfo;
        private CommonExchange.MemberEquityCredit _membersEquityInfo;
        private CommonExchange.InHouseHospitalizationCredit _inHouseHospitalizationCreditInfo;

        private CashieringLogic _cashieringManager;

        private Int32 _primaryIndexRegularLoad = 0;
        private Int32 _rowIndexRegularLoan = -1;
        private String _primaryIdRegularLoan = String.Empty;

        private Int32 _primaryIndexShareCapital = 0;
        private Int32 _rowIndexShareCapital = -1;
        private String _primaryIdShareCapital = String.Empty;

        private Int32 _primaryIndexMembersEquity = 0;
        private Int32 _rowIndexMembersEquity = -1;
        private String _primaryIdMembersEquity = String.Empty;

        private Int32 _primaryIndexInHouse = 0;
        private Int32 _rowIndexInHouse = -1;
        private String _primaryIdInHouse = String.Empty;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructors
        public MemberTab(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, CashieringLogic cashieringManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberInfo = memberInfo;
            _cashieringManager = cashieringManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(MemberTabLoad);

            this.dgvRegularLoan.MouseDown += new MouseEventHandler(dgvRegularLoanMouseDown);
            this.dgvRegularLoan.KeyPress += new KeyPressEventHandler(dgvRegularLoanKeyPress);
            this.dgvRegularLoan.KeyDown += new KeyEventHandler(dgvRegularLoanKeyDown);
            this.dgvRegularLoan.DataSourceChanged += new EventHandler(dgvRegularLoanDataSourceChanged);
            this.dgvRegularLoan.SelectionChanged += new EventHandler(dgvRegularLoanSelectionChanged);
            this.dgvRegularLoan.DoubleClick += new EventHandler(dgvRegularLoanDoubleClick);

            this.btnClose.Click += new EventHandler(btnCloseClick);

            //----------------- FOR SHARED CAPITAL CONTROLS ----------------------
            this.txtShareAmountTendered.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtSharePayment.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);

            this.txtSharePayment.KeyPress += new KeyPressEventHandler(txtSharePaymentKeyPress);
            this.txtSharePayment.KeyUp += new KeyEventHandler(txtSharePaymentKeyUp);
            this.txtSharePayment.Validated += new EventHandler(txtSharePaymentValidated);

            this.txtShareAmountTendered.KeyPress += new KeyPressEventHandler(txtShareAmountTenderedKeyPress);
            this.txtShareAmountTendered.KeyUp += new KeyEventHandler(txtShareAmountTenderedKeyUp);
            this.txtShareAmountTendered.Validated += new EventHandler(txtShareAmountTenderedValidated);

            this.lblShareReflectedDate.Click += new EventHandler(lblShareReflectedDateClick);
            this.lblShareReceiptDate.Click += new EventHandler(lblShareReceiptDateClick);

            this.txtShareReceiptNo.Validated += new EventHandler(txtShareReceiptNoValidated);
            this.txtShareReceiptNo.KeyPress += new KeyPressEventHandler(txtShareReceiptNoKeyPress);

            this.txtShareRemarks.Validated += new EventHandler(txtShareRemarksValidated);
            this.txtShareRemarks.KeyPress += new KeyPressEventHandler(txtShareRemarksKeyPress);

            this.txtShareBank.Validated += new EventHandler(txtShareBankValidated);
            this.txtShareBank.KeyPress += new KeyPressEventHandler(txtShareBankKeyPress);

            this.txtShareCheckNo.Validated += new EventHandler(txtShareCheckNoValidated);

            this.btnShareSearchCreditEntry.Click += new EventHandler(btnShareSearchCreditEntryClick);

            this.dgvSharedCapital.MouseDown += new MouseEventHandler(dgvSharedCapitalMouseDown);
            this.dgvSharedCapital.DoubleClick += new EventHandler(dgvSharedCapitalDoubleClick);
            this.dgvSharedCapital.DataSourceChanged += new EventHandler(dgvSharedCapitalDataSourceChanged);
            this.dgvSharedCapital.SelectionChanged += new EventHandler(dgvSharedCapitalSelectionChanged);

            this.btnShareRecord.Click += new EventHandler(btnShareRecordClick);
            this.btnShareUpdate.Click += new EventHandler(btnShareUpdateClick);
            this.btnShareDelete.Click += new EventHandler(btnShareDeleteClick);
            //----------------------------------------------------------------

            //--------------- MEMBER'S EQUITY INFORMATION CONTROLS ------------------------
            this.txtEquityAmountTendered.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtEquityAmountPaid.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);

            this.txtEquityAmountPaid.KeyPress += new KeyPressEventHandler(txtEquityAmountPaidKeyPress);
            this.txtEquityAmountPaid.KeyUp += new KeyEventHandler(txtEquityAmountPaidKeyUp);
            this.txtEquityAmountPaid.Validated += new EventHandler(txtEquityAmountPaidValidated);

            this.txtEquityAmountTendered.KeyPress += new KeyPressEventHandler(txtEquityAmountTenderedKeyPress);
            this.txtEquityAmountTendered.KeyUp += new KeyEventHandler(txtEquityAmountTenderedKeyUp);
            this.txtEquityAmountTendered.Validated += new EventHandler(txtEquityAmountTenderedValidated);

            this.lblEquityReflectedDate.Click += new EventHandler(lblEquityReflectedDateClick);
            this.lblEquityReceiptDate.Click += new EventHandler(lblEquityReceiptDateClick);

            this.txtEquityReceiptNo.Validated += new EventHandler(txtEquityReceiptNoValidated);
            this.txtEquityReceiptNo.KeyPress += new KeyPressEventHandler(txtEquityReceiptNoKeyPress);

            this.txtEquityRemarks.Validated += new EventHandler(txtEquityRemarksValidated);
            this.txtEquityRemarks.KeyPress += new KeyPressEventHandler(txtEquityRemarksKeyPress);

            this.txtEquityBank.Validated += new EventHandler(txtEquityBankValidated);
            this.txtEquityBank.KeyPress += new KeyPressEventHandler(txtEquityBankKeyPress);

            this.txtEquityCheckNo.Validated += new EventHandler(txtEquityCheckNoValidated);

            this.btnEquitySearchCreditEntry.Click += new EventHandler(btnEquitySearchCreditEntryClick);

            this.dgvMembersEquity.MouseDown += new MouseEventHandler(dgvMembersEquityMouseDown);
            this.dgvMembersEquity.DoubleClick += new EventHandler(dgvMembersEquityDoubleClick);
            this.dgvMembersEquity.DataSourceChanged += new EventHandler(dgvMembersEquityDataSourceChanged);
            this.dgvMembersEquity.SelectionChanged += new EventHandler(dgvMembersEquitySelectionChanged);

            this.btnEquityRecord.Click += new EventHandler(btnEquityRecordClick);
            this.btnEquityUpdate.Click += new EventHandler(btnEquityUpdateClick);
            this.btnEquityDelete.Click += new EventHandler(btnEquityDeleteClick);
            //-----------------------------------------------------------------------------

            //----------- FOR IN-HOUSE HOSPITALIZATION CREDIT CONTROLS ------------------
            this.txtHpPayment.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            this.txtHpAmountTendered.Validating += new System.ComponentModel.CancelEventHandler(txtAmountValidating);
            
            this.txtHpPayment.KeyPress += new KeyPressEventHandler(txtHpPaymentKeyPress);
            this.txtHpPayment.KeyUp += new KeyEventHandler(txtHpPaymentKeyUp);
            this.txtHpPayment.Validated += new EventHandler(txtHpPaymentValidated);

            this.txtHpAmountTendered.KeyPress += new KeyPressEventHandler(txtHpAmountTenderedKeyPress);
            this.txtHpAmountTendered.KeyUp += new KeyEventHandler(txtHpAmountTenderedKeyUp);
            this.txtHpAmountTendered.Validated += new EventHandler(txtHpAmountTenderedValidated);

            this.lblHpReflectedDate.Click += new EventHandler(lblHpReflectedDateClick);
            this.lblHpReceiptDate.Click += new EventHandler(lblHpReceiptDateClick);

            this.txtHpReceiptNo.KeyPress += new KeyPressEventHandler(txtHpReceiptNoKeyPress);
            this.txtHpReceiptNo.Validated += new EventHandler(txtHpReceiptNoValidated);

            this.txtHpRemarks.KeyPress += new KeyPressEventHandler(txtHpRemarksKeyPress);
            this.txtHpRemarks.Validated += new EventHandler(txtHpRemarksValidated);

            this.txtHpBank.KeyPress += new KeyPressEventHandler(txtHpBankKeyPress);
            this.txtHpBank.Validated += new EventHandler(txtHpBankValidated);

            this.txtHpCheckNo.Validated += new EventHandler(txtHpCheckNoValidated);

            this.btnHpSearchCreditEntry.Click += new EventHandler(btnHpSearchCreditEntryClick);

            this.dgvHospitalization.MouseDown += new MouseEventHandler(dgvHospitalizationMouseDown);
            this.dgvHospitalization.MouseDoubleClick += new MouseEventHandler(dgvHospitalizationMouseDoubleClick);
            this.dgvHospitalization.DataSourceChanged += new EventHandler(dgvHospitalizationDataSourceChanged);
            this.dgvHospitalization.SelectionChanged += new EventHandler(dgvHospitalizationSelectionChanged);

            this.btnHpRecord.Click += new EventHandler(btnHpRecordClick);
            this.btnHpUpdate.Click += new EventHandler(btnHpUpdateClick);
            this.btnHpDelete.Click += new EventHandler(btnHpDeleteClick);
            //---------------------------------------------------------------------------
        }

       
        #endregion

        #region IDisposable Members
        void IDisposable.Dispose()
        {
            if (this.pbxMember.Image != null)
            {
                this.pbxMember.Image.Dispose();
                this.pbxMember.Image = null;

                this.pbxMember.Dispose();
                this.pbxMember = null;
            }

            GC.SuppressFinalize(this);
            GC.Collect();
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS MemberTab EVENTS###############################################
        //event is raised when the class is loaded
        private void MemberTabLoad(object sender, EventArgs e)
        {
            this.Text = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_memberInfo.PersonInfo.LastName, _memberInfo.PersonInfo.FirstName,
                _memberInfo.PersonInfo.MiddleName);

            this.txtMemberId.Text = _memberInfo.MemberId;
            this.txtLastName.Text = _memberInfo.PersonInfo.LastName;
            this.txtFirstName.Text = _memberInfo.PersonInfo.FirstName;
            this.txtMiddleName.Text = _memberInfo.PersonInfo.MiddleName;

            String personImagePath = _cashieringManager.GetPersonPrimaryImagePath(_userInfo, _memberInfo.PersonInfo, true);

            if (!String.IsNullOrEmpty(personImagePath) && File.Exists(personImagePath))
            {
                this.pbxMember.Image = Image.FromFile(personImagePath);
            }

            this.dgvRegularLoan.DataSource = _cashieringManager.GetSearchedRegularLoanInformation(_userInfo, _memberInfo.MemberSysId, false, true);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvRegularLoan, false);

            this.dgvCompletedLoan.DataSource = _cashieringManager.GetSearchedRegularLoanInformation(_userInfo, _memberInfo.MemberSysId, false, false);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvCompletedLoan, false);

            //----------------- FOR SHARED CAPITAL CONTROLS ----------------------
            _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();

            _shareCapitalCreditInfo.MemberInfo = _memberInfo;

            _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

            this.lblShareReceivedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblShareReflectedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblShareReceiptDate.Text = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToLongDateString();
            _shareCapitalCreditInfo.ReceiptNo = this.txtShareReceiptNo.Text = BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");

            this.dgvSharedCapital.DataSource = _cashieringManager.GetShareCapitalCredits(_userInfo, _memberInfo.MemberSysId);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvSharedCapital, false);
            //--------------------------------------------------------------------

            //----------------------- FRO MEMBER'S EQUITY CONTROLS -------------------------
            _membersEquityInfo = new CommonExchange.MemberEquityCredit();

            _membersEquityInfo.MemberInfo = _memberInfo;

            _membersEquityInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _membersEquityInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _membersEquityInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

            this.lblEquityReceivedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblEquityReflectedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblEquityReceiptDate.Text = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToLongDateString();
            _membersEquityInfo.ReceiptNo = this.txtEquityReceiptNo.Text = BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");

            this.dgvMembersEquity.DataSource = _cashieringManager.GetMembersEquity(_userInfo, _memberInfo.MemberSysId);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvMembersEquity, false);
            //------------------------------------------------------------------------------

            //----------------------- FOR IN-HOUSE HOSPITALIZATION CREDIT CONTROLS -----------------------------------
            _inHouseHospitalizationCreditInfo = new CommonExchange.InHouseHospitalizationCredit();

            _inHouseHospitalizationCreditInfo.MemberInfo = _memberInfo;

            _inHouseHospitalizationCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _inHouseHospitalizationCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
            _inHouseHospitalizationCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

            this.lblHpReceivedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblHpReflectedDate.Text = DateTime.Parse(_cashieringManager.ServerDateTime).ToLongDateString();
            this.lblHpReceiptDate.Text = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToLongDateString();
            _inHouseHospitalizationCreditInfo.ReceiptNo = this.txtHpReceiptNo.Text = BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");

            this.dgvHospitalization.DataSource = _cashieringManager.GetInHouseHospitalizations(_userInfo, _memberInfo.MemberSysId);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvHospitalization, false);
            //--------------------------------------------------------------------------------------------------------

        }//----------------------
        //####################################################END CLASS MemberTab EVENTS###############################################

        //############################################BUTTON btnClose EVENTS######################################
        //event is raised when the mouse is down
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-------------------------
        //############################################END BUTTON btnClose EVENTS######################################

        //############################################DATAGRIDVIEW dgvRegularLoan EVENTS######################################
        //event is raised when the mouse is down
        private void dgvRegularLoanMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexRegularLoan = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexRegularLoan = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexRegularLoan = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexRegularLoan = -1;
                        _primaryIdRegularLoan = String.Empty;
                        break;
                }

                if (_rowIndexRegularLoan != -1)
                {
                    _primaryIdRegularLoan = dgvBase[_primaryIndexRegularLoad, _rowIndexRegularLoan].Value.ToString();
                }
            }
        }//-----------------------------

        //event is raised when the key is pressed
        private void dgvRegularLoanKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdRegularLoan = row.Cells[_primaryIndexRegularLoad].Value.ToString();
                    _primaryIndexRegularLoad = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//------------------------

        //event is raised when the key is down
        private void dgvRegularLoanKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//---------------------------

        //event is raised when the data source is changed
        private void dgvRegularLoanDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdRegularLoan = dgvBase[_primaryIndexRegularLoad, 0].Value.ToString();
            }
            else
            {
                _primaryIdRegularLoan = String.Empty;
            }
        }//---------------------

        //event is raised when the selection is chaged
        private void dgvRegularLoanSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdRegularLoan = row.Cells[_primaryIndexRegularLoad].Value.ToString();
            }
        }//-------------------------

        //event is raised when the control is double clicked
        private void dgvRegularLoanDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdRegularLoan))
            {
                using (RegularLoadPayment frmPayment = new RegularLoadPayment(_userInfo, 
                    _cashieringManager.GetDetailsRegularLoanInformation(_userInfo, _primaryIdRegularLoan), _cashieringManager, this.Text))
                {
                    frmPayment.ShowDialog(this);
                }
            }
        }//------------------------
        //############################################END DATAGRIDVIEW dgvRegularLoan EVENTS######################################

        //###########################################TEXTBOX txtAmount EVENTS#####################################################
        //event is raised when the control is validating
        private void txtAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//---------------------        
        //###########################################END TEXTBOX txtAmount EVENTS#####################################################


        // -------------------------------------- SHARE CAPITAL CREDIT CONTROLS ----------------------------------------------

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

        //###########################################LABEL lblShareReceiptDate EVENTS#####################################################
        //event is raised when the control is clicked
        private void lblShareReceiptDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime receiptDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_shareCapitalCreditInfo.ReceiptDate))
            {
                receiptDate = DateTime.Parse(CashieringLogic.ReceiptDate);
            }
            else
            {
                receiptDate = DateTime.Parse(_shareCapitalCreditInfo.ReceiptDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(receiptDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out receiptDate))
                    {
                        _shareCapitalCreditInfo.ReceiptDate = receiptDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblShareReceiptDate.Text = receiptDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_shareCapitalCreditInfo.ReceiptDate), DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate), true, false);
                }
            }

            this.Cursor = Cursors.Arrow;
        }//--------------------------
        //###########################################END LABEL lblShareReceiptDate EVENTS#####################################################

        //###########################################LABEL lblShareReflectedDate EVENTS#####################################################
        //event is raised when the mouse double clicked
        private void lblShareReflectedDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime paymentDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_shareCapitalCreditInfo.ReflectedDate))
            {
                paymentDate = DateTime.Parse(_cashieringManager.ServerDateTime);
            }
            else
            {
                paymentDate = DateTime.Parse(_shareCapitalCreditInfo.ReflectedDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(paymentDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out paymentDate))
                    {
                        _shareCapitalCreditInfo.ReflectedDate = paymentDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblShareReflectedDate.Text = paymentDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate), true, false);
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------------
        //###########################################END LABEL lblShareReflectedDate EVENTS#####################################################

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
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _shareCapitalCreditInfo.AccountCreditInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtShareCreditEntry.Text = _shareCapitalCreditInfo.AccountCreditInfo.AccountName + "(" + _shareCapitalCreditInfo.AccountCreditInfo.AccountCode + ")";
                }
            }
        }//-----------------------
        //########################################END BUTTON btnShareSearchCreditEntry EVENTS#####################################################

        //####################################################DATAGRIDVIEW dgvSharedCapital EVENTS####################################################
        //event is raised when the selction is changed
        private void dgvSharedCapitalSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdShareCapital = row.Cells[_primaryIndexShareCapital].Value.ToString();
            }
        }//-----------------------

        //event is raised when the data source is changed
        private void dgvSharedCapitalDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdShareCapital = dgvBase[_primaryIndexShareCapital, 0].Value.ToString();
            }
            else
            {
                _primaryIdShareCapital = "";
            }
        }//--------------------

        //event is raised when the control is double clicked
        private void dgvSharedCapitalDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdShareCapital))
            {
                _shareCapitalCreditInfo = _cashieringManager.GetDetailsShareCapitalInformationDetails(_primaryIdShareCapital);
                _shareCapitalCreditInfo.MemberInfo = _memberInfo;

                this.AssignConrolValuesShareCapital(false);

                if (_shareCapitalCreditInfo.CapitalCreditId <= 0)
                {
                    this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = false;
                    this.btnShareRecord.Enabled = true;
                }
                else
                {
                    this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = true;
                    this.btnShareRecord.Enabled = false;
                }

                this.IsRecordLocked(DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate), true, false);
                this.IsRecordLocked(DateTime.Parse(_shareCapitalCreditInfo.ReceiptDate), DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate), true, false);
            }
        }//-------------------

        //event is raised when the mouse is down
        private void dgvSharedCapitalMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexShareCapital = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexShareCapital = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexShareCapital = -1;
                        _primaryIdShareCapital = "";
                        break;
                }

                if (_rowIndexShareCapital != -1)
                {
                    _primaryIdShareCapital = dgvBase[_primaryIndexShareCapital, _rowIndexShareCapital].Value.ToString();
                }
            }
        }//-----------------------
        //####################################################END DATAGRIDVIEW dgvSharedCapital EVENTS####################################################

        //########################################BUTTON btnCreate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnShareRecordClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsShareCapital())
                {
                    String strMsg = "Are you sure you want to record the new share capital credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The share capital credit payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _shareCapitalCreditInfo.ObjectState = DataRowState.Added;

                        _cashieringManager.InsertShareCapital(_userInfo, _shareCapitalCreditInfo);

                        _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();
                        _shareCapitalCreditInfo.MemberInfo = _memberInfo;

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssignConrolValuesShareCapital(true);

                        this.btnShareRecord.Enabled = true;
                        this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error inserting share capital credit payment.\n\n" + ex.Message, "Error Inserting");
            }
        }//-----------------------
        //########################################END BUTTON btnCreate EVENTS#####################################################

        //########################################BUTTON btnUpdate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnShareUpdateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsShareCapital())
                {
                    String strMsg = "Are you sure you want to update the share capital credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The share capital credit payment has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _shareCapitalCreditInfo.ObjectState = DataRowState.Modified;

                        _cashieringManager.UpdateShareCapital(_userInfo, _shareCapitalCreditInfo);

                        _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();
                        _shareCapitalCreditInfo.MemberInfo = _memberInfo;

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssignConrolValuesShareCapital(true);

                        this.btnShareRecord.Enabled = true;
                        this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error updating share capital credit payment.\n\n" + ex.Message, "Error Updating");
            }
        }//-----------------------
        //########################################BUTTON btnUpdate EVENTS#####################################################

        //########################################BUTTON btnDelete EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnShareDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsShareCapital())
                {
                    String strMsg = "Are you sure you want to delete the share capital credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The share capital credit payment has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _shareCapitalCreditInfo.ObjectState = DataRowState.Deleted;

                        _cashieringManager.DeleteShareCapital(_userInfo, _shareCapitalCreditInfo);

                        _shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();
                        _shareCapitalCreditInfo.MemberInfo = _memberInfo;

                        _shareCapitalCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _shareCapitalCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssignConrolValuesShareCapital(true);

                        this.btnShareRecord.Enabled = true;
                        this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error deleting share capital credit payment.\n\n" + ex.Message, "Error Deleting");
            }
        }//------------------------
        //########################################END BUTTON btnDelete EVENTS#####################################################

        //------------------------------------------- END SHARE CAPITAL CREDIT CONTROLS ----------------------------------------


        //-------------------------------------------- MEMBER'S EQUITY CONTROLS ------------------------------------------------

        //########################################TEXTBOX txtEquityamountPaid EVENTS#####################################################
        //event is raised when the control is validated
        private void txtEquityAmountPaidValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtEquityAmountPaid.Text, out amount))
            {
                _membersEquityInfo.CreditAmount = amount;
            }
        }//---------------------

        //event is raised when the key is up
        private void txtEquityAmountPaidKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtEquityAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtEquityAmountPaid.Text, out paymentAmount)) { }

            this.lblChangeEquity.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//------------------------

        //event is raised when the key is pressed
        private void txtEquityAmountPaidKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtEquityAmountTendered.Focus();
            }
        }//------------------------------
        //########################################END TEXTBOX txtEquityamountPaid EVENTS#####################################################

        //########################################TEXTBOX txtEquityAmountTendered EVENTS#####################################################
        //event is raised when the control is validated
        private void txtEquityAmountTenderedValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtEquityAmountTendered.Text, out amount))
            {
                _membersEquityInfo.AmountTendered = amount;
            }
        }//------------------------------

        //event is raised when the key is up
        private void txtEquityAmountTenderedKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtEquityAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtEquityAmountPaid.Text, out paymentAmount)) { }

            this.lblChangeEquity.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//----------------------------

        //event is raised when the key is pressed
        private void txtEquityAmountTenderedKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtEquityReceiptNo.Focus();
            }
        }//--------------------------------
        //########################################END TEXTBOX txtEquityAmountTendered EVENTS#####################################################

        //########################################LABEL lblEquityReflectedDate EVENTS#####################################################
        //event is raised when the control is validated
        private void lblEquityReflectedDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime paymentDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_membersEquityInfo.ReflectedDate))
            {
                paymentDate = DateTime.Parse(_cashieringManager.ServerDateTime);
            }
            else
            {
                paymentDate = DateTime.Parse(_membersEquityInfo.ReflectedDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(paymentDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out paymentDate))
                    {
                        _membersEquityInfo.ReflectedDate = paymentDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblEquityReflectedDate.Text = paymentDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_membersEquityInfo.ReceivedDate), false, true);
                }
            }

            this.Cursor = Cursors.Arrow;
        }//----------------------------------
        //########################################END LABEL lblEquityReflectedDate EVENTS#####################################################

        //########################################LABEL lblEquityReceiptDate EVENTS#####################################################
        //event is raised when the control is validated
        private void lblEquityReceiptDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime receiptDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_membersEquityInfo.ReceiptDate))
            {
                receiptDate = DateTime.Parse(CashieringLogic.ReceiptDate);
            }
            else
            {
                receiptDate = DateTime.Parse(_membersEquityInfo.ReceiptDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(receiptDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out receiptDate))
                    {
                        _membersEquityInfo.ReceiptDate = receiptDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblEquityReceiptDate.Text = receiptDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_shareCapitalCreditInfo.ReceiptDate), DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate), false, true);
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //########################################END LABEL lblEquityReceiptDate EVENTS#####################################################

        //########################################TEXTBOX txtEquityReceiptNo EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtEquityReceiptNoKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.btnEquitySearchCreditEntry.Focus();
            }
        }//-----------------------------------

        //event is raised when the control is validated
        private void txtEquityReceiptNoValidated(object sender, EventArgs e)
        {
           _membersEquityInfo.ReceiptNo = BaseServices.ProcStatic.TrimStartEndString(this.txtEquityReceiptNo.Text);
        }//--------------------------------
        //########################################END TEXTBOX txtEquityReceiptNo EVENTS#####################################################

        //########################################TEXTBOX txtEquityRemarks EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtEquityRemarksKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtEquityBank.Focus();
            }
        }//------------------------

        //event is raised when the control is validated
        private void txtEquityRemarksValidated(object sender, EventArgs e)
        {
            _membersEquityInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtEquityRemarks.Text);
        }//-------------------------
        //########################################END TEXTBOX txtEquityRemarks EVENTS#####################################################

        //########################################TEXTBOX txtEquityBank EVENTS#####################################################
        //event is raised when the key is pressed
        private void txtEquityBankKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtEquityCheckNo.Focus();
            }
        }//--------------------

        //event is raised when the control is validated
        private void txtEquityBankValidated(object sender, EventArgs e)
        {
            _membersEquityInfo.Bank = BaseServices.ProcStatic.TrimStartEndString(this.txtEquityBank.Text);
        }//---------------------------
        //########################################END TEXTBOX txtEquityBank EVENTS#####################################################

        //########################################TEXTBOX txtEquityCheckno EVENTS#####################################################
        //eveit is raised when the control is validated
        private void txtEquityCheckNoValidated(object sender, EventArgs e)
        {
            _membersEquityInfo.CheckNo = BaseServices.ProcStatic.TrimStartEndString(this.txtEquityCheckNo.Text);
        }//-------------------------
        //########################################END TEXTBOX txtEquityCheckno EVENTS#####################################################

        //########################################BUTTON btnEquitySearchCreditEntry EVENTS#####################################################
        //eveit is raised when the control is validated
        private void btnEquitySearchCreditEntryClick(object sender, EventArgs e)
        {
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _membersEquityInfo.AccountCreditInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtEquityCreditEntry.Text = _membersEquityInfo.AccountCreditInfo.AccountName + "(" + _membersEquityInfo.AccountCreditInfo.AccountCode + ")";
                }
            }
        }//--------------------------
        //########################################END BUTTON btnEquitySearchCreditEntry EVENTS#####################################################

        //########################################DATAGRIDVIEW dgvMembersEquity EVENTS#####################################################
        //eveit is raised when the selection chanted
        private void dgvMembersEquitySelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdMembersEquity = row.Cells[_primaryIndexMembersEquity].Value.ToString();
            }
        }//--------------------------

        //event is raised when the data source is chanted
        private void dgvMembersEquityDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdMembersEquity = dgvBase[_primaryIndexMembersEquity, 0].Value.ToString();
            }
            else
            {
                _primaryIdMembersEquity = "";
            }
        }//---------------------------

        //event is raised when te control is double clicked
        private void dgvMembersEquityDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdMembersEquity))
            {
                _membersEquityInfo = _cashieringManager.GetDetailsMembersEquityInformationDetails(_primaryIdMembersEquity);                
                _membersEquityInfo.MemberInfo = _memberInfo;

                this.AssignConrolValuesMembersEquuity(false);

                if (_membersEquityInfo.EquityId <= 0)
                {
                    this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = false;
                    this.btnEquityRecord.Enabled = true;
                }
                else
                {
                    this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = true;
                    this.btnEquityRecord.Enabled = false;
                }

                this.IsRecordLocked(DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate), false, true);
                this.IsRecordLocked(DateTime.Parse(_shareCapitalCreditInfo.ReceiptDate), DateTime.Parse(_shareCapitalCreditInfo.ReceivedDate), false, true);
            }
        }//-----------------------------

        //event is raised when the mouse is down
        private void dgvMembersEquityMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                         _rowIndexMembersEquity = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                         _rowIndexMembersEquity = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexMembersEquity = -1;
                        _primaryIdMembersEquity = "";
                        break;
                }

                if (_rowIndexMembersEquity != -1)
                {
                    _primaryIdMembersEquity = dgvBase[_primaryIndexMembersEquity, _rowIndexMembersEquity].Value.ToString();
                }
            }
        }//--------------------------------
        //########################################END DATAGRIDVIEW dgvMembersEquity EVENTS#####################################################

        //########################################BUTTON btnEquityRecord EVENTS#####################################################
        //eveit is raised when the control is clicked
        private void btnEquityRecordClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsMembersEquity())
                {
                    String strMsg = "Are you sure you want to record the new member's equity payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The member's equity payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _membersEquityInfo.ObjectState = DataRowState.Added;

                        _cashieringManager.InsertMembersEquity(_userInfo, _membersEquityInfo);

                        _membersEquityInfo = new CommonExchange.MemberEquityCredit();
                        _membersEquityInfo.MemberInfo = _memberInfo;

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssignConrolValuesMembersEquuity(true);

                        this.btnEquityRecord.Enabled = true;
                        this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error inserting member's equity payment.\n\n" + ex.Message, "Error Inserting");
            }
        }//---------------------------
        //########################################END BUTTON btnEquityRecord EVENTS#####################################################

        //########################################BUTTON btnEquityUpdate EVENTS#####################################################
        //eveit is raised when the control is clicked
        private void btnEquityUpdateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsMembersEquity())
                {
                    String strMsg = "Are you sure you want to update the member's equity payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The member's equity payment has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _membersEquityInfo.ObjectState = DataRowState.Modified;

                        _cashieringManager.UpdateMembersEquity(_userInfo, _membersEquityInfo);

                        _membersEquityInfo = new CommonExchange.MemberEquityCredit();
                        _membersEquityInfo.MemberInfo = _memberInfo;

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssignConrolValuesMembersEquuity(true);

                        this.btnEquityRecord.Enabled = true;
                        this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error updating member's equity payment.\n\n" + ex.Message, "Error Updating");
            }
        }//--------------------------
        //########################################END BUTTON btnEquityUpdate EVENTS#####################################################

        //########################################BUTTON btnEquityDelete EVENTS#####################################################
        //eveit is raised when the control is clicked
        private void btnEquityDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsMembersEquity())
                {
                    String strMsg = "Are you sure you want to delete the member's equity payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The member's equity payment has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _membersEquityInfo.ObjectState = DataRowState.Deleted;

                        _cashieringManager.DeleteMembersEquity(_userInfo, _membersEquityInfo);

                        _membersEquityInfo = new CommonExchange.MemberEquityCredit();
                        _membersEquityInfo.MemberInfo = _memberInfo;

                        _membersEquityInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _membersEquityInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssignConrolValuesMembersEquuity(true);

                        this.btnEquityRecord.Enabled = true;
                        this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = false;


                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error deleting member's equity payment.\n\n" + ex.Message, "Error Deleting");
            }
        }//-------------------------------
        //########################################END BUTTON btnEquityDelete EVENTS#####################################################
       
        //---------------------------------- END MEMBER'S EQUITY CONTROLS ---------------------------------------






        //-------------------------------- IN-HOUSE HOSPITALIZATION CONTROLS ------------------------------------


        //###########################################TEXTBOX txtHpPayment EVENTS#####################################################
        //event is raised when the control is validated
        private void txtHpPaymentValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtHpPayment.Text, out amount))
            {
                _inHouseHospitalizationCreditInfo.CreditAmount = amount;
            }
        }//-------------------

        //envet is raised when the key is up
        private void txtHpPaymentKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtHpAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtHpPayment.Text, out paymentAmount)) { }

            this.lblHpChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//--------------

        //event is raised when the key is presssed
        private void txtHpPaymentKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtHpAmountTendered.Focus();
            }
        }//----------------------
        //###########################################END TEXTBOX txtHpPayment EVENTS#####################################################

        //###########################################TEXTBOX txtHpAmountTendered EVENTS#####################################################
        //event is raised when the control is validated
        private void txtHpAmountTenderedValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtHpAmountTendered.Text, out amount))
            {
                _inHouseHospitalizationCreditInfo.AmountTendered = amount;
            }
        }//---------------------

        //event is raised when the key is up
        private void txtHpAmountTenderedKeyUp(object sender, KeyEventArgs e)
        {
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtHpAmountTendered.Text, out amountTendered)) { }

            if (Decimal.TryParse(this.txtHpPayment.Text, out paymentAmount)) { }

            this.lblHpChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));
        }//------------------

        //event is raised when the key is pressed
        private void txtHpAmountTenderedKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.txtHpReceiptNo.Focus();
            }
        }//--------------------
        //###########################################END TEXTBOX txtHpAmountTendered EVENTS#####################################################           

        //###########################################LABEL lblHpReceiptDate EVENTS#####################################################
        //event is raised when the control is clicked
        private void lblHpReceiptDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime receiptDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_inHouseHospitalizationCreditInfo.ReceiptDate))
            {
                receiptDate = DateTime.Parse(CashieringLogic.ReceiptDate);
            }
            else
            {
                receiptDate = DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceiptDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(receiptDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out receiptDate))
                    {
                        _inHouseHospitalizationCreditInfo.ReceiptDate = receiptDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblHpReceiptDate.Text = receiptDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceiptDate), DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceivedDate), false, false);
                }
            }

            this.Cursor = Cursors.Arrow;
        }//--------------------------
        //###########################################END LABEL lblHpReceiptDate EVENTS#####################################################

        //###########################################LABEL lblHpReflectedDate EVENTS#####################################################
        //event is raised when the mouse double clicked
        private void lblHpReflectedDateClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime paymentDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_inHouseHospitalizationCreditInfo.ReflectedDate))
            {
                paymentDate = DateTime.Parse(_cashieringManager.ServerDateTime);
            }
            else
            {
                paymentDate = DateTime.Parse(_inHouseHospitalizationCreditInfo.ReflectedDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(paymentDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_cashieringManager.ServerDateTime).ToLongTimeString(), out paymentDate))
                    {
                        _inHouseHospitalizationCreditInfo.ReflectedDate = paymentDate.ToShortDateString() + " 12:00:00 AM";
                    }

                    this.lblHpReflectedDate.Text = paymentDate.ToLongDateString();

                    this.IsRecordLocked(DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceivedDate), false, false);
                }
            }

            this.Cursor = Cursors.Arrow;
        }//--------------------------
        //###########################################END LABEL lblHpReflectedDate EVENTS#####################################################   

        //###########################################TEXTBOX txtHpReceiptNo EVENTS#####################################################
        //event is raised when the control is validated
        private void txtHpReceiptNoValidated(object sender, EventArgs e)
        {
            _inHouseHospitalizationCreditInfo.ReceiptNo = BaseServices.ProcStatic.TrimStartEndString(this.txtHpReceiptNo.Text);
        }//-------------------------

        //event is raised when the key is pressed
        private void txtHpReceiptNoKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);

            if (e.KeyChar == '\r')
            {
                this.btnHpSearchCreditEntry.Focus();
            }
        }//---------------------------
        //###########################################END TEXTBOX txtHpReceiptNo EVENTS#####################################################

        //###########################################TEXTBOX txtHpRemarks EVENTS#####################################################
        //event is raised when the control is validated
        private void txtHpRemarksValidated(object sender, EventArgs e)
        {
            _inHouseHospitalizationCreditInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtHpRemarks.Text);
        }//----------------------

        //event is raised when the key is presssed
        private void txtHpRemarksKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtHpBank.Focus();
            }
        }//------------------------
        //###########################################END TEXTBOX txtHpRemarks EVENTS#####################################################

        //###########################################TEXTBOX txtHpBank EVENTS#####################################################
        //event is raised when the control is validated
        private void txtHpBankValidated(object sender, EventArgs e)
        {
            _inHouseHospitalizationCreditInfo.Bank = BaseServices.ProcStatic.TrimStartEndString(this.txtHpBank.Text);
        }//------------------------

        //event is raised when the key is pressed
        private void txtHpBankKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtHpCheckNo.Focus();
            }
        }//------------------------
        //###########################################END TEXTBOX txtHpBank EVENTS#####################################################

        //###########################################TEXTBOX  txtHpCheckNo EVENTS#####################################################
        //event is raised when the control is validated
        private void txtHpCheckNoValidated(object sender, EventArgs e)
        {
            _inHouseHospitalizationCreditInfo.CheckNo = BaseServices.ProcStatic.TrimStartEndString(this.txtHpCheckNo.Text);
        }//----------------------
        //###########################################END TEXTBOX  txtHpCheckNo EVENTS#####################################################

        //########################################BUTTON btnHpSearchCreditEntry EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnHpSearchCreditEntryClick(object sender, EventArgs e)
        {
            using (BaseServices.ChartOfAccountSearchOnTextBoxList frmSearch = new BaseServices.ChartOfAccountSearchOnTextBoxList(_userInfo, _cashieringManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _inHouseHospitalizationCreditInfo.AccountCreditInfo = _cashieringManager.GetDetailsChartOfAccount(_userInfo, frmSearch.PrimaryId);

                    this.txtHpCreditEntry.Text = _inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountName + "(" +
                        _inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountCode + ")";
                }
            }
        }//-----------------------
        //########################################END BUTTON btnHpSearchCreditEntry EVENTS#####################################################

        //####################################################DATAGRIDVIEW dgvHospitalization EVENTS####################################################
        //event is raised when the selction is changed
        private void dgvHospitalizationSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdInHouse = row.Cells[_primaryIndexInHouse].Value.ToString();
            }
        }//-------------------------

        //event is raised when the data source is changed
        private void dgvHospitalizationDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;
            Int32 result = dgvBase.Rows.Count;

            if (result == 1)
            {
                _primaryIdInHouse = dgvBase[_primaryIndexInHouse, 0].Value.ToString();
            }
            else
            {
                _primaryIdInHouse = "";
            }
        }//----------------------

        //event is raised when the control is double clicked
        private void dgvHospitalizationMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdInHouse))
            {
                _inHouseHospitalizationCreditInfo = _cashieringManager.GetDetailsInHouseHospitalizationCredit(_primaryIdInHouse);
                _inHouseHospitalizationCreditInfo.MemberInfo = _memberInfo;

                this.AssingConrolValuesInHouseHospitalizationCredit(true);

                if (_inHouseHospitalizationCreditInfo.HospitalizationCreditId <= 0)
                {
                    this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = false;
                    this.btnHpRecord.Enabled = true;
                }
                else
                {
                    this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = true;
                    this.btnHpRecord.Enabled = false;
                }

                this.IsRecordLocked(DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceivedDate), false, false);
                this.IsRecordLocked(DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceiptDate), DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceivedDate), false, false);
            }
        }//----------------------

        //event is raised when the mouse is down
        private void dgvHospitalizationMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexInHouse = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexInHouse = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexInHouse = -1;
                        _primaryIdInHouse = "";
                        break;
                }

                if (_rowIndexInHouse != -1)
                {
                    _primaryIdInHouse = dgvBase[_primaryIndexInHouse, _rowIndexInHouse].Value.ToString();
                }
            }
        }//--------------------------
        //####################################################END DATAGRIDVIEW dgvHospitalization EVENTS####################################################

        //########################################BUTTON btnCreate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnHpRecordClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsInHouseHospitalization())
                {
                    String strMsg = "Are you sure you want to record the new in-house hospitalization credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The in-house hospitaliation credit payment has been successfully recorded.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseHospitalizationCreditInfo.ObjectState = DataRowState.Added;

                        _cashieringManager.InsertInHouseHospitalization(_userInfo, _inHouseHospitalizationCreditInfo);

                        _inHouseHospitalizationCreditInfo = new CommonExchange.InHouseHospitalizationCredit();
                        _inHouseHospitalizationCreditInfo.MemberInfo = _memberInfo;

                        _inHouseHospitalizationCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _inHouseHospitalizationCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _inHouseHospitalizationCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";


                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssingConrolValuesInHouseHospitalizationCredit(true);

                        this.btnHpRecord.Enabled = true;
                        this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error inserting in-house hospitalization credit payment.\n\n" + ex.Message, "Error Inserting");
            }
        }//---------------------
        //########################################END BUTTON btnCreate EVENTS#####################################################

        //########################################BUTTON btnUpdate EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnHpUpdateClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsInHouseHospitalization())
                {
                    String strMsg = "Are you sure you want to update the in-house hospitalization credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The in-house hospitaliation credit payment has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseHospitalizationCreditInfo.ObjectState = DataRowState.Modified;

                        _cashieringManager.UpdateInHouseHospitalization(_userInfo, _inHouseHospitalizationCreditInfo);

                        _inHouseHospitalizationCreditInfo = new CommonExchange.InHouseHospitalizationCredit();
                        _inHouseHospitalizationCreditInfo.MemberInfo = _memberInfo;

                        _inHouseHospitalizationCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _inHouseHospitalizationCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _inHouseHospitalizationCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";


                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssingConrolValuesInHouseHospitalizationCredit(true);

                        this.btnHpRecord.Enabled = true;
                        this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error updating in-house hospitalization credit payment.\n\n" + ex.Message, "Error Updating");
            }
        }//-------------------------
        //########################################END BUTTON btnUpdate EVENTS#####################################################

        //########################################BUTTON btnDelete EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnHpDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControlsInHouseHospitalization())
                {
                    String strMsg = "Are you sure you want to delete the in-house hospitalization credit payment?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The in-house hospitaliation credit payment has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseHospitalizationCreditInfo.ObjectState = DataRowState.Deleted;

                        _cashieringManager.DeleteInHouseHospitalization(_userInfo, _inHouseHospitalizationCreditInfo);

                        _inHouseHospitalizationCreditInfo = new CommonExchange.InHouseHospitalizationCredit();
                        _inHouseHospitalizationCreditInfo.MemberInfo = _memberInfo;

                        _inHouseHospitalizationCreditInfo.ReceivedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _inHouseHospitalizationCreditInfo.ReflectedDate = DateTime.Parse(_cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";
                        _inHouseHospitalizationCreditInfo.ReceiptDate = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToShortDateString() + " 12:00:00 AM";

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.AssingConrolValuesInHouseHospitalizationCredit(true);

                        this.btnHpRecord.Enabled = true;
                        this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = false;

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error deleting in-house hospitalization credit payment.\n\n" + ex.Message, "Error Deleting");
            }
        }//-----------------------------
        //########################################END BUTTON btnDelete EVENTS#####################################################

        //----------------------------------------- END IN - HOUSE HOSPITALIZATION CONTROLS ------------------------------------------------------
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will assign control values for shared capital
        public void AssignConrolValuesShareCapital(Boolean inCludeDataGrid)
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

            if (inCludeDataGrid)
            {
                this.dgvSharedCapital.DataSource = _cashieringManager.GetShareCapitalCredits(_userInfo, _memberInfo.MemberSysId);
            }
        }//-----------------------------

        //this procedure will assign control values for member's equity conrols
        public void AssignConrolValuesMembersEquuity(Boolean inCludeDataGrid)
        {
            this.lblChangeEquity.Text = "-";
            this.txtEquityAmountPaid.Focus();
            this.txtEquityAmountPaid.Text = _membersEquityInfo.CreditAmount.ToString("N");
            this.txtEquityAmountTendered.Text = _membersEquityInfo.AmountTendered.ToString("N");

            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtEquityAmountTendered.Text, out amountTendered)) { }
            if (Decimal.TryParse(this.txtEquityAmountPaid.Text, out paymentAmount)) { }
            this.lblChangeEquity.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));

            this.lblEquityReceivedDate.Text = DateTime.Parse(_membersEquityInfo.ReceivedDate).ToLongDateString();
            this.lblEquityReflectedDate.Text = DateTime.Parse(_membersEquityInfo.ReflectedDate).ToLongDateString();
            this.lblEquityReceiptDate.Text = DateTime.Parse(_membersEquityInfo.ReceiptDate).ToLongDateString();

            this.txtEquityReceiptNo.Text = !String.IsNullOrEmpty(_membersEquityInfo.ReceiptNo) ? _membersEquityInfo.ReceiptNo :
                BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");

            String strMembersCreditEntry = !String.IsNullOrEmpty(_membersEquityInfo.AccountCreditInfo.AccountName) ?
                _membersEquityInfo.AccountCreditInfo.AccountName + "(" + _membersEquityInfo.AccountCreditInfo.AccountCode + ")" : String.Empty;

            this.txtEquityCreditEntry.Text = strMembersCreditEntry;
            this.txtEquityRemarks.Text = _membersEquityInfo.Remarks;
            this.txtEquityBank.Text = _membersEquityInfo.Bank;
            this.txtEquityCheckNo.Text = _membersEquityInfo.CheckNo;

            if (inCludeDataGrid)
            {
                this.dgvMembersEquity.DataSource = _cashieringManager.GetMembersEquity(_userInfo, _memberInfo.MemberSysId);
            }
        }//-----------------------------

        //this procedure will assign control values for inhouse hospitalization credit
        public void AssingConrolValuesInHouseHospitalizationCredit(Boolean inCludeDataGrid)
        {
            this.lblHpChange.Text = "-";
            this.txtHpPayment.Focus();
            this.txtHpPayment.Text = _inHouseHospitalizationCreditInfo.CreditAmount.ToString("N");
            this.txtHpAmountTendered.Text = _inHouseHospitalizationCreditInfo.AmountTendered.ToString("N");
            
            Decimal amountTendered = 0;
            Decimal paymentAmount = 0;

            if (Decimal.TryParse(this.txtHpAmountTendered.Text, out amountTendered)) { }
            if (Decimal.TryParse(this.txtHpPayment.Text, out paymentAmount)) { }
            this.lblHpChange.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (amountTendered - paymentAmount));

            this.lblHpReceivedDate.Text = DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceivedDate).ToLongDateString();
            this.lblHpReflectedDate.Text = DateTime.Parse(_inHouseHospitalizationCreditInfo.ReflectedDate).ToLongDateString();
            this.lblHpReceiptDate.Text = DateTime.Parse(_inHouseHospitalizationCreditInfo.ReceiptDate).ToLongDateString();

            this.txtShareReceiptNo.Text = !String.IsNullOrEmpty(_inHouseHospitalizationCreditInfo.ReceiptNo) ? _inHouseHospitalizationCreditInfo.ReceiptNo :
                BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");

            String strCreditEntry = !String.IsNullOrEmpty(_inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountName) ?
                _inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountName + "(" + _inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountCode + ")" : String.Empty;

            this.txtHpCreditEntry.Text = strCreditEntry;
            this.txtHpRemarks.Text = _inHouseHospitalizationCreditInfo.Remarks;
            this.txtHpBank.Text = _inHouseHospitalizationCreditInfo.Bank;
            this.txtHpCheckNo.Text = _inHouseHospitalizationCreditInfo.CheckNo;

            if (inCludeDataGrid)
            {
                this.dgvHospitalization.DataSource = _cashieringManager.GetInHouseHospitalizations(_userInfo, _memberInfo.MemberSysId);
            }
        }//--------------------------

        //this procedure will set record status
        //Code History: Priviews code calls (_cashieringManager.GetReflectedDate(<parameters>)) to supply the reflected date.
        //reflected date is delete because of the new record locking feature. (can backward payments more than 4 months)
        private void IsRecordLocked(DateTime receiveDate, Boolean isSharedCapital, Boolean isMemberEquity)
        {
            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiveDate, DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                if (isSharedCapital)
                {
                    this.btnShareRecord.Enabled = this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = false;

                    this.lblShareRecordStatus.Text = "This record is LOCKED";

                    this.txtSharePayment.ReadOnly = this.txtShareAmountTendered.ReadOnly = true;

                    this.pbxShareLock.Visible = true;
                    this.pbxShareUnLock.Visible = false;
                }
                else if (isMemberEquity)
                {
                    this.btnEquityRecord.Enabled = this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = false;

                    this.lblMERecordStatus.Text = "This record is LOCKED";

                    this.txtEquityAmountPaid.ReadOnly = this.txtEquityAmountTendered.ReadOnly = true;

                    this.pbxMELock.Visible = true;
                    this.pbxMEUnlock.Visible = false;
                }
                else if (!isSharedCapital)
                {
                    this.btnHpRecord.Enabled = this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = false;

                    this.lblHpRecordStatus.Text = "This record is LOCKED";

                    this.txtHpPayment.ReadOnly = this.txtHpAmountTendered.ReadOnly = true;

                    this.pbxHpLock.Visible = true;
                    this.pbxHpUnlock.Visible = false;
                }
            }
            else
            {
                if (isSharedCapital)
                {
                    this.btnShareRecord.Enabled = _shareCapitalCreditInfo.CapitalCreditId > 0 ? false : true;
                    this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = _shareCapitalCreditInfo.CapitalCreditId > 0 ? true : false;

                    this.txtSharePayment.ReadOnly = this.txtShareAmountTendered.ReadOnly = false;

                    this.lblShareRecordStatus.Text = "This record is OPEN";

                    this.pbxShareLock.Visible = false;
                    this.pbxShareUnLock.Visible = true;
                }
                else if (isMemberEquity)
                {
                    this.btnEquityRecord.Enabled = _membersEquityInfo.EquityId > 0 ? false : true;
                    this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = _membersEquityInfo.EquityId > 0 ? true : false;

                    this.txtEquityAmountPaid.ReadOnly = this.txtEquityAmountTendered.ReadOnly = false;

                    this.lblMERecordStatus.Text = "This record is OPEN";

                    this.pbxMELock.Visible = false;
                    this.pbxMEUnlock.Visible = true;
                }
                else if (!isSharedCapital)
                {
                    this.btnHpRecord.Enabled = _inHouseHospitalizationCreditInfo.HospitalizationCreditId > 0 ? false : true;
                    this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = _inHouseHospitalizationCreditInfo.HospitalizationCreditId > 0 ? true : false;

                    this.txtHpPayment.ReadOnly = this.txtHpAmountTendered.ReadOnly = false;

                    this.lblHpRecordStatus.Text = "This record is OPEN";

                    this.pbxHpLock.Visible = false;
                    this.pbxHpUnlock.Visible = true;
                }
            }
        }//---------------------

        //this procedure will set record locking for receipt date
        //Code Added: September 2, 2010
        private void IsRecordLocked(DateTime receiptDate, DateTime receiveDate, Boolean isSharedCapital, Boolean isMemberEquity)
        {
            if (RemoteClient.ProcStatic.IsRecordLocked((Int32)CommonExchange.SystemRange.ReceivedDateAllowance, receiptDate, receiveDate,
                DateTime.Parse(_cashieringManager.ServerDateTime)))
            {
                if (isSharedCapital)
                {
                    this.btnShareRecord.Enabled = this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = false;

                    this.lblShareRecordStatus.Text = "This record is LOCKED";

                    this.txtSharePayment.ReadOnly = this.txtShareAmountTendered.ReadOnly = true;

                    this.pbxShareLock.Visible = true;
                    this.pbxShareUnLock.Visible = false;
                }
                else if (isMemberEquity)
                {
                    this.btnEquityRecord.Enabled = this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = false;

                    this.lblMERecordStatus.Text = "This record is LOCKED";

                    this.txtEquityAmountPaid.ReadOnly = this.txtEquityAmountTendered.ReadOnly = true;

                    this.pbxMELock.Visible = true;
                    this.pbxMEUnlock.Visible = false;
                }
                else if (!isSharedCapital)
                {
                    this.btnHpRecord.Enabled = this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = false;

                    this.lblHpRecordStatus.Text = "This record is LOCKED";

                    this.txtHpPayment.ReadOnly = this.txtHpAmountTendered.ReadOnly = true;

                    this.pbxHpLock.Visible = true;
                    this.pbxHpUnlock.Visible = false;
                }
            }
            else
            {
                if (isSharedCapital)
                {
                    this.btnShareRecord.Enabled = _shareCapitalCreditInfo.CapitalCreditId > 0 ? false : true;
                    this.btnShareUpdate.Enabled = this.btnShareDelete.Enabled = _shareCapitalCreditInfo.CapitalCreditId > 0 ? true : false;

                    this.txtSharePayment.ReadOnly = this.txtShareAmountTendered.ReadOnly = false;

                    this.lblShareRecordStatus.Text = "This record is OPEN";

                    this.pbxShareLock.Visible = false;
                    this.pbxShareUnLock.Visible = true;
                }
                else if (isMemberEquity)
                {
                    this.btnEquityRecord.Enabled = _membersEquityInfo.EquityId > 0 ? false : true;
                    this.btnEquityUpdate.Enabled = this.btnEquityDelete.Enabled = _membersEquityInfo.EquityId > 0 ? true : false;

                    this.txtEquityAmountPaid.ReadOnly = this.txtEquityAmountTendered.ReadOnly = false;

                    this.lblMERecordStatus.Text = "This record is OPEN";

                    this.pbxMELock.Visible = false;
                    this.pbxMEUnlock.Visible = true;
                }
                else if (!isSharedCapital)
                {
                    this.btnHpRecord.Enabled = _inHouseHospitalizationCreditInfo.HospitalizationCreditId > 0 ? false : true;
                    this.btnHpUpdate.Enabled = this.btnHpDelete.Enabled = _inHouseHospitalizationCreditInfo.HospitalizationCreditId > 0 ? true : false;

                    this.txtHpPayment.ReadOnly = this.txtHpAmountTendered.ReadOnly = false;

                    this.lblHpRecordStatus.Text = "This record is OPEN";

                    this.pbxHpLock.Visible = false;
                    this.pbxHpUnlock.Visible = true;
                }
            }
        }//---------------------
        #endregion

        #region Programmer's Defined Functions
        //ths fucntion will will validate controls for share capital credit
        private Boolean ValidateControlsShareCapital()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.pbxMember, String.Empty);
            _errProvider.SetError(this.txtSharePayment, String.Empty);
            _errProvider.SetError(this.txtShareCreditEntry, String.Empty);

            if (String.IsNullOrEmpty(_shareCapitalCreditInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.pbxMember, "A member information is required.");
                _errProvider.SetIconAlignment(this.pbxMember, ErrorIconAlignment.MiddleRight);

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

        //ths fucntion will will validate controls for member equity
        private Boolean ValidateControlsMembersEquity()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.pbxMember, String.Empty);
            _errProvider.SetError(this.txtEquityAmountPaid, String.Empty);
            _errProvider.SetError(this.txtEquityCreditEntry, String.Empty);

            if (String.IsNullOrEmpty(_membersEquityInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.pbxMember, "A member information is required.");
                _errProvider.SetIconAlignment(this.pbxMember, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_membersEquityInfo.CreditAmount <= 0)
            {
                _errProvider.SetError(this.txtEquityAmountPaid, "Credit Amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtEquityAmountPaid, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_membersEquityInfo.AccountCreditInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtEquityCreditEntry, "You must select a credit entry.");
                _errProvider.SetIconAlignment(this.txtEquityCreditEntry, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//---------------------

        //ths fucntion will will validate controls for in-house hospitalization
        private Boolean ValidateControlsInHouseHospitalization()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.pbxMember, String.Empty);
            _errProvider.SetError(this.txtHpPayment, String.Empty);
            _errProvider.SetError(this.txtHpCreditEntry, String.Empty);

            if (String.IsNullOrEmpty(_inHouseHospitalizationCreditInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.pbxMember, "A member information is required.");
                _errProvider.SetIconAlignment(this.pbxMember, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_inHouseHospitalizationCreditInfo.CreditAmount <= 0)
            {
                _errProvider.SetError(this.txtHpPayment, "Credit Amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtHpPayment, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountSysId))
            {
                _errProvider.SetError(this.txtHpCreditEntry, "You must select a credit entry.");
                _errProvider.SetIconAlignment(this.txtHpCreditEntry, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//---------------------
        #endregion
    }
}
