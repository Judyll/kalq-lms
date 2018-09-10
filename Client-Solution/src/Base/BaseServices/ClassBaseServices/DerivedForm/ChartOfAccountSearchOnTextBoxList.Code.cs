using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BaseServices
{
    partial class ChartOfAccountSearchOnTextBoxList
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private BaseServicesLogic _baseServiceManager;
        #endregion

         #region Class Constructors
        public ChartOfAccountSearchOnTextBoxList(CommonExchange.SysAccess userInfo, BaseServicesLogic baseServiceManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _baseServiceManager = baseServiceManager;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
        }
        #endregion

        #region Class Event Void Procedures

        //####################################CLASS ChartOfAccountsSearchedOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_baseServiceManager.ChartOfAccountTable);

            _baseServiceManager.SelectChartOfAccountsArrangedList(_userInfo, "*", String.Empty, String.Empty, true);

            base.ClassLoad(sender, e);
        }//-------------------------
        //####################################END CLASS ChartOfAccountsSearchedOnTextBoxList EVENTS####################################

        //##################################TEXTBOX txtSearch EVENTS##########################################################
        //event is raised when the key is up
        protected override void txtSearchKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    this.SetDataGridViewSource(_baseServiceManager.GetSearchedChartOfAccountInformations(((TextBox)sender).Text));
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Retrieving Chart of Account List");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }

            base.txtSearchKeyUp(sender, e);
        }//--------------------
        //##################################END TEXTBOX txtSearch EVENTS##########################################################
     
        //##################################PICTUREBOX pbxRefresh EVENTS######################################################
        //event is raised when the picture box is clicked
        private void pbxRefreshClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.txtSearch.Clear();

            _baseServiceManager.SelectChartOfAccountsArrangedList(_userInfo, "*", String.Empty, String.Empty, true);

            this.Cursor = Cursors.Arrow;
        }//-----------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################

        #endregion
    }
}
