using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class BillingStatement
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private CashieringLogic _cashieringManager;
        #endregion

        #region Class Constructors
        public BillingStatement(CommonExchange.SysAccess userInfo, CashieringLogic cashieringManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _cashieringManager = cashieringManager;

            this.Load += new EventHandler(ClassLoad);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnShowResult.Click += new EventHandler(btnShowResultClick);
            this.btnPrint.Click += new EventHandler(btnPrintClick);
        }

          
        #endregion

        #region Class Event Void Procedures
        //###########################################CLASS BillingStatement EVENTS#####################################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            this.btnPrint.Enabled = false;           

            this.dtpStart.Format = DateTimePickerFormat.Custom;
            this.dtpStart.CustomFormat = "MMMM, yyyy";

            this.dtpStart.Value = DateTime.Parse(_cashieringManager.ServerDateTime);
        }//-----------------
        //###########################################END CLASS BillingStatement EVENTS#####################################################

        //###########################################BUTTON btnClose EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-------------------
        //###########################################END BUTTON btnClose EVENTS#####################################################

        //###########################################BUTTON btnShowResult EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnShowResultClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
                      
            _cashieringManager.InitializeBillingStatementListView(this.lsvBillingList, _userInfo, _cashieringManager.GetMemberSystemIdFormat(), 
                _cashieringManager.FirstDayOfMonthFromDateTime(this.dtpStart.Value).ToShortDateString() + " 12:00:00 AM",
                _cashieringManager.LastDayOfMonthFromDateTime(this.dtpStart.Value).ToShortDateString() + " 11:59:59 PM");

            this.btnPrint.Enabled = true;

            this.Cursor = Cursors.Arrow;
        }//-----------------------
        //###########################################END BUTTON btnShowResult EVENTS#####################################################

        //###########################################BUTTON btnPrint EVENTS#####################################################
        //event is raised when the control is clicked
        private void btnPrintClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            _cashieringManager.PrintBillingStatement(_userInfo, dtpStart.Text);

            this.Cursor = Cursors.Arrow;
        }//----------------------------
        //###########################################BUTTON btnPrint EVENTS#####################################################
        #endregion
    }
}
