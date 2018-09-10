using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    partial class SearchBankInformationOnTextBoxList
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private DisbursementVoucherLogic _disbursementManager;
        #endregion

        #region Class Constructors
        public SearchBankInformationOnTextBoxList(CommonExchange.SysAccess userInfo, DisbursementVoucherLogic disbursementManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _disbursementManager = disbursementManager;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
            this.lnkCreateBankInformation.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateBankInformationLinkClicked);
            this.lnkUpdateBankInformation.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkUpdateBankInformationLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS SearchBankInformationOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_disbursementManager.BankTable);

            base.ClassLoad(sender, e);
        }//-------------------
        //####################################END CLASS SearchBankInformationOnTextBoxList EVENTS####################################

        //##################################TEXTBOX txtSearch EVENTS##########################################################
        //event is raised when the key is up
        protected override void txtSearchKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    this.SetDataGridViewSource(_disbursementManager.GetSearchedBankInformation(_userInfo, ((TextBox)sender).Text, true, true));

                    this.SelectFirstRowInDataGridView();
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

        //##################################DATAGRIDVIEW dgvList EVENTS##########################################################
        //event is raised when the selection is changed
        protected override void dgvListSelectionChanged(object sender, EventArgs e)
        {
            base.dgvListSelectionChanged(sender, e);

            this.lnkUpdateBankInformation.Enabled = !String.IsNullOrEmpty(this.PrimaryId) ? true : false;
        }//---------------------------
        //##################################END DATAGRIDVIEW dgvList EVENTS##########################################################

        //##################################PICTUREBOX pbxRefresh EVENTS######################################################
        //event is raised when the picture box is clicked
        private void pbxRefreshClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.SetDataGridViewSource(_disbursementManager.GetSearchedBankInformation(_userInfo, "*", true, true));

            this.txtSearch.Clear();

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################

        //##################################LINKLABEL lnkCreateBankInformation EVENTS######################################################
        //event is raised when the control is clicked
        private void lnkCreateBankInformationLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (BankInformationCreate frmCreate = new BankInformationCreate(_userInfo, _disbursementManager))
                {
                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasCreated)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        this.SetDataGridViewSource(_disbursementManager.GetSearchedBankInformation(_userInfo, this.txtSearch.Text, true, false));

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error");
            }
        }//----------------------
        //##################################END LINKLABEL lnkCreateBankInformation EVENTS######################################################

        //##################################LINKLABEL lnkUpdateBankInformation EVENTS######################################################
        //event is raised when the control is clicked
        private void lnkUpdateBankInformationLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.PrimaryId))
            {
                try
                {
                    using (BankInformationUpdate frmUpdate = new BankInformationUpdate(_userInfo, _disbursementManager.GetBankInformationDetails(this.PrimaryId),
                        _disbursementManager))
                    {
                        frmUpdate.ShowDialog(this);

                        if (frmUpdate.HasUpdated)
                        {
                            this.Cursor = Cursors.WaitCursor;

                            this.SetDataGridViewSource(_disbursementManager.GetSearchedBankInformation(_userInfo, this.txtSearch.Text, true, false));

                            this.Cursor = Cursors.Arrow;
                        }
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error");
                }
            }
        }//---------------------
        //##################################END LINKLABEL lnkUpdateBankInformation EVENTS######################################################
        #endregion
    }
}
