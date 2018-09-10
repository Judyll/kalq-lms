using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    partial class RegularLoanCollateralSearchOnTextBoxList
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private CommonExchange.Member _memberInfo;
        private LoanLogic _loanManager;
        private MemberLogic _memberManager;
        #endregion

        #region Class Constructors
        public RegularLoanCollateralSearchOnTextBoxList(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, LoanLogic loanManager, MemberLogic memberLogic)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberInfo = memberInfo;
            _loanManager = loanManager;
            _memberManager = memberLogic;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
            this.lnkCreateCollateral.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateCollateralLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS RegularLoanCollateralSearchOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_loanManager.CollateralInformationTable);

            base.ClassLoad(sender, e);
        }//-------------------
        //####################################END CLASS RegularLoanCollateralSearchOnTextBoxList EVENTS####################################

        //##################################TEXTBOX txtSearch EVENTS##########################################################
        //event is raised when the key is up
        protected override void txtSearchKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    this.SetDataGridViewSource(_loanManager.GetSearchedCollateralInformation(_userInfo, ((TextBox)sender).Text, false, true));
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loan Charges Infomation List");
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

            this.SetDataGridViewSource(_loanManager.CollateralInformationTable);

            this.txtSearch.Clear();

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################

        //############################################LINKLABEL lnkCreateCollateral EVENTS######################################
        //event is raised when the control link is clicked
        private void lnkCreateCollateralLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (CollateralInformationCreate frmCreate = new CollateralInformationCreate(_userInfo, _memberInfo, _memberManager))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    this.SetDataGridViewSource(_loanManager.GetSearchedCollateralInformation(_userInfo, this.txtSearch.Text, false, true));
                }
            }
        }//------------------------
        //############################################END LINKLABEL lnkCreateCollateral EVENTS######################################        

        #endregion
    }
}
