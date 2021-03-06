using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class CostCenterSearchOnTextBoxList
    {
        #region Class Data Member Declaration
        private CommonExchange.SysAccess _userInfo;
        private DisbursementVoucherLogic _disbursementManager;
        #endregion

        #region Class Constructors
        public CostCenterSearchOnTextBoxList(CommonExchange.SysAccess userInfo, DisbursementVoucherLogic disbursementManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _disbursementManager = disbursementManager;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS LoanChargesSearchOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_disbursementManager.CostCenterTable);

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

                    this.SetDataGridViewSource(_disbursementManager.GetSearchedCostCostCeter(((TextBox)sender).Text));
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Hospitalization Include Coverage List");
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

            this.SetDataGridViewSource(_disbursementManager.GetSearchedCostCostCeter("*"));

            this.txtSearch.Clear();

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################
        #endregion
    }
}
