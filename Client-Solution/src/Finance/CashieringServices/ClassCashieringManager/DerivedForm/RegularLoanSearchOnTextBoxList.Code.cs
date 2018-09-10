using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class RegularLoanSearchOnTextBoxList
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private CashieringLogic _cashieringManager;

        private String _sysIDMember = String.Empty;
        #endregion

        #region Class Constructors
        public RegularLoanSearchOnTextBoxList(CommonExchange.SysAccess userInfo, CashieringLogic cashieringManager, String sysIdMember)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _cashieringManager = cashieringManager;
            _sysIDMember = sysIdMember;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS PrerequisiteSearchOnTextboxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_cashieringManager.GetSearchedRegularLoanInformation(_userInfo, _sysIDMember, false, true));

            base.ClassLoad(sender, e);
        }//-------------------------
        //####################################END CLASS PrerequisiteSearchOnTextboxList EVENTS####################################       

        //##################################DATAGRIDVIEW dgvList EVENTS##########################################################
        //event is raised when the key is up
        //event is raised when the mouse is double clicked
        protected override void dgvListDoubleClick(object sender, EventArgs e)
        {
            base.dgvListDoubleClick(sender, e);

            this.Close();
        }
        //--------------------------
        //##################################END DATAGRIDVIEW dgvList EVENTS##########################################################

        //##################################PICTUREBOX pbxRefresh EVENTS######################################################
        //event is raised when the picture box is clicked
        private void pbxRefreshClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.txtSearch.Clear();

            this.SetDataGridViewSource(_cashieringManager.GetSearchedRegularLoanInformation(_userInfo, _sysIDMember, false,true));

            this.Cursor = Cursors.Arrow;
        }//-----------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################
    }
        #endregion
}
