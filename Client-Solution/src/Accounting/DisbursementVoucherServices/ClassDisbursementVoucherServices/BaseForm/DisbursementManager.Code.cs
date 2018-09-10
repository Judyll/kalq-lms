using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class DisbursementManager
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private DisbursementVoucherLogic _disbursementManager;

        private DisbursementSearchList _frmSearch;
        #endregion

        #region Class Constructors
        public DisbursementManager(CommonExchange.SysAccess userInfo)
        {
            this.InitializeComponent();

            _userInfo = userInfo;

            this.Load += new EventHandler(ClassLoad);
            this.ctlManager.OnClose += new BaseServices.Control.ClickEvent(ctlManagerOnClose);
            this.ctlManager.OnRefresh += new BaseServices.Control.ClickEvent(ctlManagerOnRefresh);
            this.ctlManager.OnTextBoxKeyUp += new BaseServices.Control.KeyEventHandler(ctlManagerOnTextBoxKeyUp);
            this.ctlManager.OnPressEnter += new BaseServices.Control.KeyPressEnter(ctlManagerOnPressEnter);
            this.ctlManager.OnDateStartValueChanged += new BaseServices.Control.ControlDisbursementManagerDateTimePickerValueChanged(OnDateStartEndValueChanged);
            this.ctlManager.OnDateEndValueChanged += new BaseServices.Control.ControlDisbursementManagerDateTimePickerValueChanged(OnDateStartEndValueChanged);
            this.ctlManager.OnCanceledVoucherCheckChanged += new BaseServices.Control.ControlDisbursementManagerRadioButtonCheckedChanged(OnControlModeChanged);
            this.ctlManager.OnIssuedVoucherCheckChanged += new BaseServices.Control.ControlDisbursementManagerRadioButtonCheckedChanged(OnControlModeChanged);
        }
        #endregion

        #region  Class Event Void Procedures
        //###########################################CLASS DisbursementManager EVENTS#####################################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            if (!RemoteServerLib.ProcStatic.IsSystemAccessAdmin(_userInfo) && !RemoteServerLib.ProcStatic.IsSystemAccessDisbursementOfficer(_userInfo))
            {
                throw new Exception("You are not authorized to access this module.");
            }


            _disbursementManager = new DisbursementVoucherLogic(_userInfo);

            _frmSearch = new DisbursementSearchList();
            _frmSearch.OnCreate += new DisbursementSearchListLinkCreateClick(_frmSearchOnCreate);
            _frmSearch.OnDoubleClickEnter += new BaseServices.SearchListDataGridDoubleClickEnter(_frmSearchOnDoubleClickEnter);
            _frmSearch.LocationPoint = new Point(14, 300);
            _frmSearch.AdoptGridSize = false;
            _frmSearch.MdiParent = this;

            this.ctlManager.SetDateStart(DateTime.Parse(_disbursementManager.ServerDateTime));
            this.ctlManager.SetDateEnd(DateTime.Parse(_disbursementManager.ServerDateTime));

            this.lblRecordDate.Text = "Record Date: " + DateTime.Parse(_disbursementManager.ServerDateTime).ToString();

            this.ctlManager.Select();
            this.ctlManager.SetFocusOnSearchTextBox();
        }
        //---------------------
        //###########################################END CLASS DisbursementManager EVENTS#####################################################

        //############################################CLASS disbursementVoucerSearchList EVENTS###############################################################
        //event is raised when the button on create is clicked
        private void _frmSearchOnCreate()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (DisbursementVoucherRecord frmCreate = new DisbursementVoucherRecord(_userInfo, _disbursementManager))
                {
                    _frmSearch.WindowState = FormWindowState.Minimized;

                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasRecorded)
                    {
                        this.ShowSearchResultDialog(true);
                    }

                    _frmSearch.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Creating A Disbursement Voucher Information");
            }
            finally
            {
                this.ctlManager.SetFocusOnSearchTextBox();

                this.Cursor = Cursors.Arrow;
            }
        }//---------------------

        //event is raised when the control is double clicked
        private void _frmSearchOnDoubleClickEnter(string id)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (DisbursementVoucherRecord frmUpdate = new DisbursementVoucherRecord(_userInfo, _disbursementManager.GetDisbursementVoucherInformationDetails(_userInfo, id),
                    _disbursementManager))
                {
                    _frmSearch.WindowState = FormWindowState.Minimized;

                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasRecorded)
                    {
                        this.ShowSearchResultDialog(true);
                    }

                    _frmSearch.WindowState = FormWindowState.Normal;
                }

            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading Update Disbursement Voucher Information Module");
            }
            finally
            {
                this.ctlManager.SetFocusOnSearchTextBox();

                this.Cursor = Cursors.Arrow;
            }
        }//---------------------------
        //############################################END CLASS disbursementVoucerSearchList EVENTS###############################################################

        //############################################CONTROL ctlManager EVENTS###############################################################
        //event is raised when the button is click
        private void ctlManagerOnRefresh(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _disbursementManager = new DisbursementVoucherLogic(_userInfo);

                this.lblRecordDate.Text = "Record Date: " + DateTime.Parse(_disbursementManager.ServerDateTime).ToString();

                this.ShowSearchResultDialog(true);
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Refreshing Student's Data Manager");
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }//---------------------------

        //event is raised when the refresh button is clicked
        private void ctlManagerOnClose(object sender, EventArgs e)
        {
            this.Close();
        }//--------------------------

        //event is raised when the key is up
        private void ctlManagerOnTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                _frmSearch.SelectFirstRowInDataGridView();
            }
            else if (string.IsNullOrEmpty(BaseServices.ProcStatic.TrimStartEndString(ctlManager.GetSearchString)))
            {
                _frmSearch.WindowState = FormWindowState.Minimized;

                this.ctlManager.SetFocusOnSearchTextBox();
            }
        }//---------------------------

        //event is raised when the enter key is pressed
        private void ctlManagerOnPressEnter()
        {
            this.ShowSearchResultDialog(true);
        }//-----------------------------

        //event is raised when the date value is changed
        private void OnDateStartEndValueChanged()
        {
            this.ShowSearchResultDialog(true);
        }//----------------------

        //event is raised when the control mode is changed
        private void OnControlModeChanged()
        {
            this.ShowSearchResultDialog(true);
        }//------------------------
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
                    String dateStart = this.ctlManager.IncludeDateCheckedBox.Checked ? 
                        this.ctlManager.DateStartDateTimePicker.Value.ToShortDateString() + " 12:00:00 AM" : String.Empty;
                    String dateEnd = this.ctlManager.IncludeDateCheckedBox.Checked ?
                        this.ctlManager.DateEndDateTimePicker.Value.ToShortDateString() + " 11:59:59 PM" : String.Empty;

                    _frmSearch.DataSource = _disbursementManager.GetSearchedDisbursmentVoucherInformation(_userInfo, queryString, dateStart, dateEnd, this.ctlManager.IsCanceled);
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Retrieving Data");
            }
            finally
            {
                this.ctlManager.SetFocusOnSearchTextBox();

                this.Cursor = Cursors.Arrow;
            }
        }//---------------------------------
        #endregion
    }
}
