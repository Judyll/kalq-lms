using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class CashieringManager
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private CashieringLogic _cashieringManager;

        private MemberSearchList _frmMemberSearch;
        #endregion

        #region Class Constructors
        public CashieringManager(CommonExchange.SysAccess userInfo)
        {
            this.InitializeComponent();

            _userInfo = userInfo;

            this.Load += new EventHandler(CashieringManagerLoad);
            this.ctlManager.OnMiscellaneousIncome += new BaseServices.Controls.ControlCashieringManagerMiscellaneousIncomeClick(ctlManagerOnMiscellaneousIncome);
            this.ctlManager.OnRefresh += new BaseServices.Control.ClickEvent(ctlManagerOnRefresh);
            this.ctlManager.OnClose += new BaseServices.Control.ClickEvent(ctlManagerOnClose);
            this.ctlManager.OnTextBoxKeyUpQuery += new KeyEventHandler(ctlManagerOnTextBoxKeyUpQuery);
            this.ctlManager.OnPressEnterQuery += new BaseServices.Control.KeyPressEnter(ctlManagerOnPressEnterQuery);
            this.ctlManager.OnOfficeEmployerSelectedIndexChanged += 
                new BaseServices.Controls.ControlCashieringManagerCheckedListBoxSelectedIndexChanged(ctlManagerOnOfficeEmployerSelectedIndexChanged);
            //this.ctlManager.OnMemberClassificationSelectedIndexChanged +=
            //    new BaseServices.Controls.ControlCashieringManagerCheckedListBoxSelectedIndexChanged(ctlManagerOnMemberClassificationSelectedIndexChanged);
            //this.ctlManager.OnMemberTypeSelectedIndexChanged +=
            //    new BaseServices.Controls.ControlCashieringManagerCheckedListBoxSelectedIndexChanged(ctlManagerOnMemberTypeSelectedIndexChanged);
            this.ctlManager.OnReceiptNoTextBoxValidated += new BaseServices.Controls.ControlCashieringManagerReceiptNoTextBoxValidated(ctlManagerOnReceiptNoTextBoxValidated);
            this.ctlManager.OnIncrementLinkClicked += new BaseServices.Controls.ControlCashieringManagerIncrementLinkClicked(ctlManagerOnIncrementLinkClicked);
            this.ctlManager.OnDecrementLinkClicked += new BaseServices.Controls.ControlCashieringManagerDecrementLinkClicked(ctlManagerOnDecrementLinkClicked);
            this.ctlManager.OnReceiptDateValueChanged += new BaseServices.Controls.ControlCashieringManagerReceiptDateValueChanged(ctlManagerOnReceiptDateValueChanged);
            this.ctlManager.OnResetLinkClicked += new BaseServices.Controls.ControlCashieringManagerResetQueryLinkClicked(ctlManagerOnResetLinkClicked);

            this.ctlManager.OnCashReceiptsDetailedLinkClicked += 
                new BaseServices.Controls.ControlCashieringManagerCashReceiptsDetailedLinkClicked(ctlManagerOnCashReceiptsDetailedLinkClicked);
            this.ctlManager.OnCashReceiptsSummarizedLinkClicked += 
                new BaseServices.Controls.ControlCashieringManagerCashReceiptsSummarizedLinkClicked(ctlManagerOnCashReceiptsSummarizedLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //###########################################CLASS CashieringManager EVENTS#####################################################
        //event is raised when the class is loaded
        private void CashieringManagerLoad(object sender, EventArgs e)
        {
            if (!RemoteServerLib.ProcStatic.IsSystemAccessAdmin(_userInfo) && !RemoteServerLib.ProcStatic.IsSystemAccessCashier(_userInfo))
            {
                throw new Exception("You are not authorized to access this module.");
            }
            
            _cashieringManager = new CashieringLogic(_userInfo);

            _frmMemberSearch = new MemberSearchList();
            _frmMemberSearch.OnDoubleClickEnter += new BaseServices.SearchListDataGridDoubleClickEnter(_frmMemberSearchOnDoubleClickEnter);
            _frmMemberSearch.OnRegularLoanMultipleClick += new MemberSearchListButtonClick(_frmMemberSearchOnRegularLoanMultipleClick);
            _frmMemberSearch.OnShareCapitalMultipleClick += new MemberSearchListButtonClick(_frmMemberSearchOnShareCapitalMultipleClick);
            _frmMemberSearch.OnInHouseMultipleClick += new MemberSearchListButtonClick(_frmMemberSearchOnInHouseMultipleClick);
            _frmMemberSearch.OnBillingClick += new MemberSearchListButtonClick(_frmMemberSearchOnBillingClick);
            _frmMemberSearch.LocationPoint = new Point(14, 300);
            _frmMemberSearch.AdoptGridSize = false;
            _frmMemberSearch.MdiParent = this;

            this.lblRecordDate.Text = "Record Date: " + DateTime.Parse(_cashieringManager.ServerDateTime).ToString();

            _cashieringManager.InitializeOfficeEmployerCheckedListBox(this.ctlManager.OfficeEmployerCheckedListBox);
            //_cashieringManager.InitializeMemberClassificationCheckedListBox(this.ctlManager.MemberClassificationCheckedListBox);
            //_cashieringManager.InitializeMemberTypeCheckedListBox(this.ctlManager.MemberTypeCheckedListBox);

            this.ctlManager.Select();
            this.ctlManager.SetFocusOnSearchTextBoxQuery();

            //receipt date must be change if the control is ready
            BaseServices.BaseServicesLogic.ReceiptDate = _cashieringManager.ServerDateTime;
            //-----------------------------

        }//-----------------------
        //###########################################END CLASS CashieringManager EVENTS#####################################################

        //##########################################CLASS MemberSearchList EVENTS#######################################################       
        //event is raised when the dgvList control is double clicked
        private void _frmMemberSearchOnDoubleClickEnter(String id)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (MemberTab frmMember = new MemberTab(_userInfo, _cashieringManager.GetDetailsMemberInformationByMemberId(_userInfo, id), _cashieringManager))
                {
                    _frmMemberSearch.WindowState = FormWindowState.Minimized;

                    frmMember.ShowDialog(this);

                   _frmMemberSearch.WindowState = FormWindowState.Normal;
                }

                this.ctlManager.ReceiptNo = BaseServices.BaseServicesLogic.ReceiptNumber;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Updating A Member Information");
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }//---------------------------------

        //event is raised when the regular loan multiple payment is clicked
        private void _frmMemberSearchOnRegularLoanMultipleClick()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (RegularLoanMultiplePayment frmPayment = new RegularLoanMultiplePayment(_userInfo, _cashieringManager))
                {
                    _frmMemberSearch.WindowState = FormWindowState.Minimized;

                    frmPayment.ShowDialog(this);

                    _frmMemberSearch.WindowState = FormWindowState.Normal;
                }

                this.ctlManager.ReceiptNo = BaseServices.BaseServicesLogic.ReceiptNumber;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading Regular Loan Multiple Payment");
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }//--------------------------

        //event is raised when the share capital multiple payment is clicked
        private void _frmMemberSearchOnShareCapitalMultipleClick()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (ShareCapitalMultiplePayment frmPayment = new ShareCapitalMultiplePayment(_userInfo, _cashieringManager))
                {
                    _frmMemberSearch.WindowState = FormWindowState.Minimized;

                    frmPayment.ShowDialog(this);

                    _frmMemberSearch.WindowState = FormWindowState.Normal;
                }

                this.ctlManager.ReceiptNo = BaseServices.BaseServicesLogic.ReceiptNumber;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading Share Capital Credit Multiple Payment");
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }//--------------------------

        //event is raised when the in-house hospitalization multiple payment is clicked
        private void _frmMemberSearchOnInHouseMultipleClick()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (InHouseHospitalizationMultiplePayment frmPayment = new InHouseHospitalizationMultiplePayment(_userInfo, _cashieringManager))
                {
                    _frmMemberSearch.WindowState = FormWindowState.Minimized;

                    frmPayment.ShowDialog(this);

                    _frmMemberSearch.WindowState = FormWindowState.Normal;
                }

                this.ctlManager.ReceiptNo = BaseServices.BaseServicesLogic.ReceiptNumber;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading In-House Hospitalization Multiple Payment");
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }//------------------------

        //event is raised when the billing statement button is clicked
        private void _frmMemberSearchOnBillingClick()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (BillingStatement frmBilling = new BillingStatement(_userInfo, _cashieringManager))
                {
                    _frmMemberSearch.WindowState = FormWindowState.Minimized;

                    frmBilling.ShowDialog(this);

                    _frmMemberSearch.WindowState = FormWindowState.Normal;
                }

                this.ctlManager.ReceiptNo = BaseServices.BaseServicesLogic.ReceiptNumber;
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading Billing Statement Module.");
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }//---------------------
        //##########################################END CLASS MemberSearchList EVENTS#######################################################

        //############################################CONTROL ctlManager EVENTS##########################################
        //event is raised when the miscellaneous button or event is clicked
        private void ctlManagerOnMiscellaneousIncome()
        {
            using (MiscellaneousIncome frmShow = new MiscellaneousIncome(_userInfo, _cashieringManager))
            {
                frmShow.ShowDialog();
            }

            this.ctlManager.SetFocusOnSearchTextBox();
            this.ctlManager.ReceiptNo = CashieringLogic.ReceiptNumber;
        }//---------------------------------

        //event is raised when the button is click
        private void ctlManagerOnRefresh(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _cashieringManager = new CashieringLogic(_userInfo);

                this.lblRecordDate.Text = "Record Date: " + DateTime.Parse(_cashieringManager.ServerDateTime).ToString();

                this.ShowSearchResultDialog(true);
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Refreshing Cashiering Data Manager");
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }//---------------------

        //event is raised when the button is clicked
        private void ctlManagerOnClose(object sender, EventArgs e)
        {
            this.Close();
        }//--------------------

        //event is raised when the enter key is pressed
        private void ctlManagerOnPressEnterQuery()
        {
            this.ShowSearchResultDialog(true);
        }//------------------------

        //event is raised when the key is up
        private void ctlManagerOnTextBoxKeyUpQuery(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                _frmMemberSearch.SelectFirstRowInDataGridView();
            }
            else if (string.IsNullOrEmpty(BaseServices.ProcStatic.TrimStartEndString(ctlManager.GetSearchString)))
            {
                _frmMemberSearch.WindowState = FormWindowState.Minimized;

                this.ctlManager.SetFocusOnSearchTextBoxQuery();
            }
        }//-----------------------
       
        //event is raised when the selected index is changed Office Employer CheckedlistBox
        private void ctlManagerOnOfficeEmployerSelectedIndexChanged()
        {
            this.ShowSearchResultDialog(true);
        }//------------------------

        //event is raised when the selected index is changed Member Type CheckedlistBox
        //private void ctlManagerOnMemberClassificationSelectedIndexChanged()
        //{
        //    this.ShowSearchResultDialog(true);
        //}//-------------------------

        //event is raised when the selected index is changed Member Type CheckedlistBox
        //private void ctlManagerOnMemberTypeSelectedIndexChanged()
        //{
        //    this.ShowSearchResultDialog(true);
        //}//---------------------

        //event is raied when the control is validated
        private void ctlManagerOnReceiptNoTextBoxValidated()
        {
            CashieringLogic.ReceiptNumber = this.ctlManager.ReceiptNo;
        }//------------------------

        //event is raised when the decrement link is clicked
        private void ctlManagerOnDecrementLinkClicked()
        {
            CashieringLogic.ReceiptNumber = this.ctlManager.ReceiptNo;
        }//-----------------------

        //event is raised when the increment link is clicked
        private void ctlManagerOnIncrementLinkClicked()
        {
            CashieringLogic.ReceiptNumber = this.ctlManager.ReceiptNo;
        }//---------------------------

        //event is raised when the receiptDateValue is changed
        private void ctlManagerOnReceiptDateValueChanged(DateTime d)
        {
            CashieringLogic.ReceiptDate = this.ctlManager.ReceiptDate.ToLongDateString();
        }//----------------------------

        //event is raised when the reset query is clicked
        private void ctlManagerOnResetLinkClicked()
        {
            _frmMemberSearch.WindowState = FormWindowState.Minimized;
        }//----------------------

        //event is raised when the cash receipt summarized link is clicked
        private void ctlManagerOnCashReceiptsSummarizedLinkClicked()
        {
            using (CashReceiptReportControl frmReport = new CashReceiptReportControl(_userInfo, _cashieringManager))
            {
                frmReport.IsForDetails = false;
                frmReport.IsForSummarized = true;

                frmReport.ShowDialog(this);
            }
        }//-----------------------

        //event is raised when the cash receipt details link is clicked
        private void ctlManagerOnCashReceiptsDetailedLinkClicked()
        {
            using (CashReceiptReportControl frmReport = new CashReceiptReportControl(_userInfo, _cashieringManager))
            {
                frmReport.IsForDetails = true;
                frmReport.IsForSummarized = false;

                frmReport.ShowDialog(this);
            }
        }//---------------------------
        //############################################END CONTROL ctlManager EVENTS##########################################

        #endregion

        #region Programer-Define Void Procedures
        //this procedure shows the search result
        private void ShowSearchResultDialog(Boolean isNewQuery)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                String queryString = BaseServices.ProcStatic.TrimStartEndString(ctlManager.GetSearchString);

                if (!String.IsNullOrEmpty(queryString))
                {
                    if (_cashieringManager.GetSearchedMemberInformationTable(_userInfo, queryString,
                        _cashieringManager.GetOfficeEmployerStringFormat(this.ctlManager.OfficeEmployerCheckedListBox, true, false, false), String.Empty, String.Empty,
                        String.Empty, false, true, isNewQuery) == 1)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;

                          
                            using (MemberTab frmMember = new MemberTab(_userInfo, _cashieringManager.GetDetailsMemberInformationByMemberId(_userInfo, 
                                _cashieringManager.GetMemberForSingleInstance()), _cashieringManager))
                            {
                                _frmMemberSearch.WindowState = FormWindowState.Minimized;

                                frmMember.ShowDialog(this);

                                _frmMemberSearch.WindowState = FormWindowState.Normal;
                            }

                            this.ctlManager.ReceiptNo = BaseServices.BaseServicesLogic.ReceiptNumber;
   
                        }
                        catch (Exception ex)
                        {
                            BaseServices.ProcStatic.ShowErrorDialog("\n\nError Loading Student Tab Mudule. \n\n" + ex.Message, "Error Loading");
                        }
                        finally
                        {
                            this.Cursor = Cursors.Arrow;
                        }
                    }
                    else
                    {
                        _frmMemberSearch.DataSource = _cashieringManager.PopulateMemberInformationTableList();
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Retrieving Data");
            }
            finally
            {
                this.ctlManager.SetFocusOnSearchTextBoxQuery();

                this.Cursor = Cursors.Arrow;
            }

        }//---------------------------------
        #endregion
    }
}
