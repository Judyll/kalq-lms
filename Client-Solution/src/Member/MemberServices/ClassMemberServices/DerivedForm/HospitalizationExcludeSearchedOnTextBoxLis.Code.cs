using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    partial class HospitalizationExcludeSearchedOnTextBoxLis
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private MemberLogic _memberManager;
        #endregion

        #region Class Constructors
        public HospitalizationExcludeSearchedOnTextBoxLis(CommonExchange.SysAccess userInfo, MemberLogic memberManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
            this.lnkCreateExcludeCoverage.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateExcludeCoverageLinkClicked);
            this.lnkUpdateExcludeCoverage.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkUpdateExcludeCoverageLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS LoanChargesSearchOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_memberManager.HospitalizationExcludeTable);

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

                    this.SetDataGridViewSource(_memberManager.GetSearchedHospitalizationExcludeCoverage(_userInfo, ((TextBox)sender).Text, false));
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Hospitalization Exclude Coverage List");
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

            this.lnkUpdateExcludeCoverage.Enabled = !String.IsNullOrEmpty(this.PrimaryId) ? true : false;
        }//---------------------------
        //##################################END DATAGRIDVIEW dgvList EVENTS##########################################################

        //##################################PICTUREBOX pbxRefresh EVENTS######################################################
        //event is raised when the picture box is clicked
        private void pbxRefreshClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.SetDataGridViewSource(_memberManager.HospitalizationExcludeTable);

            this.txtSearch.Clear();

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################

        //##################################LINKLABEL lnkCreateExcludeCoverage EVENTS######################################################
        //event is raised when the control is clicked
        private void lnkCreateExcludeCoverageLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (HospitalizationExcludeCoverageCreate frmCreate = new HospitalizationExcludeCoverageCreate(_userInfo, _memberManager))
                {
                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasCreated)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        this.SetDataGridViewSource(_memberManager.GetSearchedHospitalizationExcludeCoverage(_userInfo, this.txtSearch.Text, false));

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error");
            }
        }//--------------------------------
        //##################################END LINKLABEL lnkCreateExcludeCoverage EVENTS######################################################

        //##################################LINKLABEL lnkUpdateExcludeCoverage EVENTS######################################################
        //event is raised when the control is clicked
        private void lnkUpdateExcludeCoverageLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.PrimaryId))
            {
                try
                {
                    using (HospitalizationExcludeCoverageUpdate frmUpdate = new HospitalizationExcludeCoverageUpdate(_userInfo,
                        _memberManager.GetHospitalizationExcludeCoverageInformation(this.PrimaryId), _memberManager))
                    {
                        frmUpdate.ShowDialog(this);

                        if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                        {
                            this.Cursor = Cursors.WaitCursor;

                            this.SetDataGridViewSource(_memberManager.GetSearchedHospitalizationExcludeCoverage(_userInfo, this.txtSearch.Text, false));

                            this.Cursor = Cursors.Arrow;
                        }
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error");
                }
            }
        }//-------------------------------
        //##################################END LINKLABEL lnkUpdateExcludeCoverage EVENTS######################################################
        #endregion
    }
}
