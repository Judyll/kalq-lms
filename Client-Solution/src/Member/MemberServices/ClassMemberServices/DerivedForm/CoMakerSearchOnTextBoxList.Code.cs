using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    partial class CoMakerSearchOnTextBoxList
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private LoanLogic _loanManager;
        private String _memberSysId;
        #endregion

        #region Class Constructors
        public CoMakerSearchOnTextBoxList(CommonExchange.SysAccess userInfo, LoanLogic loanManager, String memberSysId)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _loanManager = loanManager;
            _memberSysId = memberSysId;
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS LoanAdditionsSearchOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_loanManager.MemberInformationTable);

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

                    this.SetDataGridViewSource(_loanManager.GetSearchedMemberInformationTable(_userInfo, ((TextBox)sender).Text, String.Empty, String.Empty, 
                        _memberSysId, String.Empty, true, true, true));
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading Member List Module.");
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

            this.SetDataGridViewSource(_loanManager.MemberInformationTable);

            this.txtSearch.Clear();

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################
        #endregion 
    }
}
