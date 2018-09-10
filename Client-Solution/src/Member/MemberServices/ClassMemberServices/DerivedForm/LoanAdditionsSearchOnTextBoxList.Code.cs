using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class LoanAdditionsSearchOnTextBoxList
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private LoanLogic _loanManager;
        #endregion

        #region Class Constructors
        public LoanAdditionsSearchOnTextBoxList(CommonExchange.SysAccess userInfo, LoanLogic loanManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _loanManager = loanManager;
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS LoanAdditionsSearchOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_loanManager.ChartOfAccountTableFormat);

            base.ClassLoad(sender, e);
        }//-------------------
        //####################################END CLASS LoanChargesSearchOnTextBoxList EVENTS####################################

        //##################################TEXTBOX txtSearch EVENTS##########################################################
        //event is raised when the key is up
        protected override void txtSearchKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    this.SetDataGridViewSource(_loanManager.GetSearchedChartOfAccount(_userInfo, ((TextBox)sender).Text, String.Empty, String.Empty, true));
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loan Additions Infomation List");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }

            base.txtSearchKeyUp(sender, e);
        }//-----------------------------------
        //##################################END TEXTBOX txtSearch EVENTS##########################################################

        //##################################PICTUREBOX pbxRefresh EVENTS######################################################
        //event is raised when the picture box is clicked
        private void pbxRefreshClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.SetDataGridViewSource(_loanManager.ChartOfAccountTableFormat);

            this.txtSearch.Clear();

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################
        #endregion 
    }
}
