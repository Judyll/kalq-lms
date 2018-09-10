using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace LoanManagementSolution
{
    partial class LMSManager
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private BaseServices.BaseServicesLogic _baseManager;

        private Timer _trmSystemTime;
        private DateTime _systemTime;
        #endregion

        #region Class Constructors
        public LMSManager(CommonExchange.SysAccess userInfo)
        {
            this.InitializeComponent();

            _userInfo = userInfo;

            _baseManager = new BaseServices.BaseServicesLogic(_userInfo);

            _trmSystemTime = new Timer();

            this.Load += new EventHandler(ClassLoad);
            this.FormClosed += new FormClosedEventHandler(ClassClossing);
            this._trmSystemTime.Tick += new EventHandler(trmSystemTimeTick);

            this.pbxMemberSolution.Click += new EventHandler(pbxMemberSolutionClick);
            this.pbxMemberSolution.MouseEnter += new EventHandler(controlMouseEnter);
            this.pbxMemberSolution.MouseLeave += new EventHandler(controlMouseLeave);

            this.pbxDisbursementSolution.Click += new EventHandler(pbxDisbursementSolutionClick);
            this.pbxDisbursementSolution.MouseEnter += new EventHandler(controlMouseEnter);
            this.pbxDisbursementSolution.MouseLeave += new EventHandler(controlMouseLeave);

            this.pbxChartOfAccountSolution.Click += new EventHandler(pbxChartOfAccountSolutionClick);
            this.pbxChartOfAccountSolution.MouseEnter += new EventHandler(controlMouseEnter);
            this.pbxChartOfAccountSolution.MouseLeave += new EventHandler(controlMouseLeave);

            this.pbxFinanceSolutions.Click += new EventHandler(pbxFinanceSolutionsClick);
            this.pbxFinanceSolutions.MouseEnter += new EventHandler(controlMouseEnter);
            this.pbxFinanceSolutions.MouseLeave += new EventHandler(controlMouseLeave);

            this.lnkExit.Click += new EventHandler(lnkExitClick);

            if (RemoteServerLib.ProcStatic.IsSystemAccessAdmin(_userInfo))
            {
                this.lnkUser.Click += new EventHandler(lnkUserClick);
                this.lnkTransactionLog.Click += new EventHandler(lnkTransactionLogClick);

                this.lnkTransactionLog.Visible = this.lnkUser.Visible = true;
            }
        }
        #endregion

        #region Class Event Void Procedures
        //###############################################CLASS LMSManager EVENTS##################################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            _trmSystemTime.Interval = 1000;

            if (DateTime.TryParse(_baseManager.ServerDateTime, out _systemTime))
            {
                _trmSystemTime.Start();
            }

            this.lblUserName.Text = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(_userInfo.PersonInfo.LastName, _userInfo.PersonInfo.FirstName,
                _userInfo.PersonInfo.MiddleName);

            DateTime date = DateTime.MinValue;

            if (DateTime.TryParse(_baseManager.ServerDateTime, out date))
            {
                this.lblDate.Text = date.ToLongDateString();
            }

            this.SetAccessRights();
        }//------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosedEventArgs e)
        {
            _baseManager.DeleteDirectory(Application.StartupPath + @"\AppDocuments");
        }//------------------------------
        //###############################################END CLASS LMSManager EVENTS##################################################

        //###############################################TIMER trmSystemTime EVENTS##################################################
        //event is raised when timer tick
        private void trmSystemTimeTick(object sender, EventArgs e)
        {
            _systemTime = _systemTime.AddSeconds(((Timer)sender).Interval / 1000);

            lbltime.Text = _systemTime.ToLongTimeString();
        }//-----------------------------
        //###############################################END TIMER trmSystemTime EVENTS##################################################

        //###############################################PICTUREBOX pbxMemberSolution EVENTS##################################################
        //event is raised when the control is clicked
        private void pbxMemberSolutionClick(object sender, EventArgs e)
        {
            this.ShowMemberManager();
        }//----------------------------
        //###############################################END PICTUREBOX pbxMemberSolution EVENTS##################################################

        //###############################################PICTUREBOX pbxDisbursementSolution EVENTS##################################################
        //event is raised when the control is clicked
        private void pbxDisbursementSolutionClick(object sender, EventArgs e)
        {
            this.ShowDisbursementVoucherManager();
        }//--------------------------
        //###############################################END PICTUREBOX pbxDisbursementSolution EVENTS##################################################

        //###############################################PICTUREBOX pbxChartOfAccountSolution EVENTS##################################################
        //event is raised when the control is clicked
        private void pbxChartOfAccountSolutionClick(object sender, EventArgs e)
        {
            this.ShowChartOfAccountManager();
        }//--------------------------
        //###############################################END PICTUREBOX pbxChartOfAccountSolution EVENTS##################################################

        //###############################################PICTUREBOX pbxFinanceSolution EVENTS##################################################
        //event is raised when the control is clicked
        private void pbxFinanceSolutionsClick(object sender, EventArgs e)
        {
            this.ShowCashieringManager();
        }//-----------------------
        //###############################################END PICTUREBOX pbxFinanceSolution EVENTS##################################################

        //###############################################CLASS Mouse Leave EVENTS##################################################
        //event is raised when the mouse button leave
        private void controlMouseLeave(object sender, EventArgs e)
        {
            this.lblStatus.Text = " Ready";

            String cntName = String.Empty;

            if (sender.GetType().Equals(typeof(PictureBox)))
            {
                cntName = ((PictureBox)sender).Name;
            }

            if (String.Equals(cntName, this.pbxMemberSolution.Name))
            {
                this.pbxMemberSolution.Image = global::LoanManagementSolution.Properties.Resources.membermanager;
            }
            else if (String.Equals(cntName, this.pbxDisbursementSolution.Name))
            {
                this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementvoucher;
            }
            else if (String.Equals(cntName, this.pbxChartOfAccountSolution.Name))
            {
                this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartofaccounts;
            }
            else if (String.Equals(cntName, this.pbxFinanceSolutions.Name))
            {
                this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManager;
            }
        }//------------------------
        //###############################################END CLASS Mouse Leave EVENTS##################################################

        //###############################################CLASS Mouse Hover EVENTS##################################################
        //event is raised when the mouse toolstripbutton hover
        private void controlMouseEnter(object sender, EventArgs e)
        {
            String cntName = String.Empty;

            if (sender.GetType().Equals(typeof(PictureBox)))
            {
                cntName = ((PictureBox)sender).Name;
            }

            if (String.Equals(cntName, this.pbxMemberSolution.Name))
            {
                this.lblStatus.Text = " Allows you to create and update member information and services";

                this.pbxMemberSolution.Image = global::LoanManagementSolution.Properties.Resources.membermanagerhover;
            }
            else if (String.Equals(cntName, this.pbxDisbursementSolution.Name))
            {
                this.lblStatus.Text = " Allows you to create and update disbursement vouchers";

                this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementvoucherhover;
            }
            else if (String.Equals(cntName, this.pbxChartOfAccountSolution.Name))
            {
                this.lblStatus.Text = " Allows you to create and update chart of accounts information";

                this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartofaccountshover;
            }
            else if (String.Equals(cntName, this.pbxFinanceSolutions.Name))
            {
                this.lblStatus.Text = " Allows you to create and update member payments and miscellaneous incomes";

                this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManagerHover;
            }
            else
            {
                this.lblStatus.Text = " Ready";
            }
        }//------------------------       
        //###############################################END CLASS Mouse Hover EVENTS##################################################

        //###############################################LINKLABEL lnkExit EVENTS##################################################
        //event is raised when the control is clicked
        private void lnkExitClick(object sender, EventArgs e)
        {
            this.Close();
        }//--------------------------
        //###############################################END LINKLABEL lnkExit EVENTS##################################################

        //###############################################LINKLABEL lnkTransactionLog EVENTS##################################################
        //event is raised when the control link is clicked
        private void lnkTransactionLogClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.ShowAdministrationManagerLog();

            this.Cursor = Cursors.Arrow;
        }//-----------------------
        //###############################################END LINKLABEL lnkTransactionLog EVENTS##################################################

        //###############################################LINKLABEL lnkUser EVENTS##################################################
        //event is raised when the control link is clicked
        private void lnkUserClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.ShowAdministrationManagerUser();

            this.Cursor = Cursors.Arrow;
        }//---------------------
        //###############################################END LINKLABEL lnkUser EVENTS##################################################

        #endregion

        #region Programmer's Defined Void Procedure
        //this procedure will set access rights functionality
        private void SetAccessRights()
        {
            if (!RemoteServerLib.ProcStatic.IsSystemAccessAdmin(_userInfo))
            {
                this.pbxDisbursementSolution.Enabled = this.pbxChartOfAccountSolution.Enabled = this.pbxFinanceSolutions.Enabled = false;

                this.pbxMemberSolution.Image = global::LoanManagementSolution.Properties.Resources.membermanager;

                if (RemoteServerLib.ProcStatic.IsSystemAccessBookkeeper(_userInfo))
                {
                    this.pbxChartOfAccountSolution.Enabled = true;

                    this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartofaccounts;

                    //this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementVoucherDisabled;
                    //this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManagerDisabled;
                }

                if (RemoteServerLib.ProcStatic.IsSystemAccessCashier(_userInfo))
                {
                    this.pbxFinanceSolutions.Enabled = true;

                    this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManager;

                    //this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementVoucherDisabled;
                    //this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartOfAccountDisabled;
                }

                if (RemoteServerLib.ProcStatic.IsSystemAccessDataController(_userInfo) || RemoteServerLib.ProcStatic.IsSystemAccessLoanOfficer(_userInfo))
                {
                    this.pbxMemberSolution.Image = global::LoanManagementSolution.Properties.Resources.membermanager;

                    //this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartOfAccountDisabled;
                    //this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementVoucherDisabled;
                    //this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManagerDisabled;
                }

                if (RemoteServerLib.ProcStatic.IsSystemAccessDisbursementOfficer(_userInfo))
                {
                    this.pbxDisbursementSolution.Enabled = true;

                    this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementvoucher;

                    //this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartOfAccountDisabled;
                    //this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManagerDisabled;
                }
            }
            else
            {
                this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartofaccounts;
                this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManager;
                this.pbxMemberSolution.Image = global::LoanManagementSolution.Properties.Resources.membermanager;
                this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementvoucher;
            }
        }//--------------------

        /// <summary>
        /// this procedure will call Chart of Account Manager ---------------->> Accounting Solution
        /// </summary>
        private void ShowChartOfAccountManager()
        {
            try
            {
                using (AccountingServices.ChartOfAccountManager frmShow = new AccountingServices.ChartOfAccountManager(_userInfo))
                {
                    this.Cursor = Cursors.WaitCursor;

                    frmShow.ShowDialog(this);

                    this.Cursor = Cursors.Arrow;
                }
            }
            catch
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error Loading Chart of Account Manager Module.", "Error Loading");
            }
        }//---------------------

        /// <summary>
        /// this procedure will call the Disbursement Voucher Manager --------------------->> Accounting Solution
        /// </summary>
        private void ShowDisbursementVoucherManager()
        {
            try
            {
                using (DisbursementVoucherServices.DisbursementManager frmShow = new DisbursementVoucherServices.DisbursementManager(_userInfo))
                {
                    this.Cursor = Cursors.WaitCursor;

                    frmShow.ShowDialog(this);

                    this.Cursor = Cursors.Arrow;
                }
            }
            catch
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error Loading Disbursement Voucher Manager Module.", "Error Loading");
            }
        }//---------------------

        /// <summary>
        /// this procedure will call the Member Manager ---------------------->> Member Solution
        /// </summary>
        private void ShowMemberManager()
        {
            try
            {
                using (MemberServices.MemberManager frmShow = new MemberServices.MemberManager(_userInfo))
                {
                    this.Cursor = Cursors.WaitCursor;

                    frmShow.ShowDialog(this);

                    this.Cursor = Cursors.Arrow;
                }
            }
            catch
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error Loading Member Manager Module.", "Error Loading");
            }
        }//--------------------

        /// <summary>
        /// this procedure will call the Cashiering Manager ---------------------->> Cashiering Solution
        /// </summary>
        private void ShowCashieringManager()
        {
            try
            {
                using (CashieringServices.CashieringManager frmShow = new CashieringServices.CashieringManager(_userInfo))
                {
                    this.Cursor = Cursors.WaitCursor;

                    frmShow.ShowDialog(this);

                    this.Cursor = Cursors.Arrow;
                }
            }
            catch
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error Loading Cashering Module.", "Error Loading");
            }
        }//--------------------

        /// <summary>
        /// this procedure calls Class Administration User Manager
        /// </summary>
        private void ShowAdministrationManagerUser()
        {
            try
            {
                using (AdministratorServices.AdministrationManagerUser frmShow = new AdministratorServices.AdministrationManagerUser(_userInfo))
                {
                    this.Cursor = Cursors.WaitCursor;

                    frmShow.ShowDialog(this);

                    this.Cursor = Cursors.Arrow;

                    if (frmShow.ExitUMS)
                    {
                        Application.Exit();
                    }
                }
            }
            catch
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error Loading Class Administration User  Module.", "Error Loading");
            }
        }//---------------------

        /// <summary>
        ///this procedure call the Class Administration Manager Log
        /// </summary>
        private void ShowAdministrationManagerLog()
        {
            try
            {
                using (AdministratorServices.AdministrationManagerLog frmShow = new AdministratorServices.AdministrationManagerLog(_userInfo))
                {
                    this.Cursor = Cursors.WaitCursor;

                    frmShow.ShowDialog(this);

                    this.Cursor = Cursors.Arrow;
                }
            }
            catch
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error Loading Class Administration Log Module.", "Error Loading");
            }
        }//-------------------
        #endregion
    }
}
