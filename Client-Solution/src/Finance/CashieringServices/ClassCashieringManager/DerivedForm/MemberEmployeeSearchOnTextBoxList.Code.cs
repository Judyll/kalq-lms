using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CashieringServices
{
    partial class MemberEmployeeSearchOnTextBoxList
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private CashieringLogic _cashieringManager;
        #endregion

        #region Class Constructors
        public MemberEmployeeSearchOnTextBoxList(CommonExchange.SysAccess userInfo, CashieringLogic cashieringManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _cashieringManager = cashieringManager;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS PrerequisiteSearchOnTextboxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_cashieringManager.MemberEmployeeTable);

            base.ClassLoad(sender, e);
        }//-------------------------
        //####################################END CLASS PrerequisiteSearchOnTextboxList EVENTS####################################

        //##################################TEXTBOX txtSearch EVENTS##########################################################
        //event is raised when the key is up
        protected override void txtSearchKeyUp(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    this.SetDataGridViewSource(_cashieringManager.GetSearchedMemberEmployeeTable(_userInfo, ((TextBox)sender).Text));
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Retrieving Member/Collector Information List");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }

            base.txtSearchKeyUp(sender, e);

            this.Cursor = Cursors.Arrow;
        }//--------------------
        //##################################END TEXTBOX txtSearch EVENTS##########################################################

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

            this.SetDataGridViewSource(_cashieringManager.MemberEmployeeTable);

            this.Cursor = Cursors.Arrow;
        }//-----------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################
        #endregion
    }
}
