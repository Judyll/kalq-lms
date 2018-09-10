using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    partial class HospitalizationIncludeSearchedOnTextBoxList
    {
        #region Class Data Member Decleration
        private CommonExchange.SysAccess _userInfo;
        private List<CommonExchange.InHouseIncludeCoverage> _inHouseHospitalizationIncludeCoverageList;
        private MemberLogic _memberManager;
        #endregion

        #region Class Constructors
        public HospitalizationIncludeSearchedOnTextBoxList(CommonExchange.SysAccess userInfo, MemberLogic memberManager, 
            List<CommonExchange.InHouseIncludeCoverage> inHouseHospitalizationIncludeCoverageList)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;
            _inHouseHospitalizationIncludeCoverageList = inHouseHospitalizationIncludeCoverageList;

            this.pbxRefresh.Click += new EventHandler(pbxRefreshClick);
            this.lnkCreateIncludeCoverage.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateIncludeCoverageLinkClicked);
            this.lnkUpdateIncludeCoverage.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkUpdateIncludeCoverageLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################CLASS LoanChargesSearchOnTextBoxList EVENTS####################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.SetDataGridViewSource(_memberManager.HospitalizationIncludeTable);

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

                    this.SetDataGridViewSource(_memberManager.GetSearchedHospitalizationIncludeCoverage(_userInfo, _inHouseHospitalizationIncludeCoverageList, 
                        ((TextBox)sender).Text, false));
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

            this.lnkUpdateIncludeCoverage.Enabled = !String.IsNullOrEmpty(this.PrimaryId) ? true : false;
        }//---------------------------
        //##################################END DATAGRIDVIEW dgvList EVENTS##########################################################

        //##################################PICTUREBOX pbxRefresh EVENTS######################################################
        //event is raised when the picture box is clicked
        private void pbxRefreshClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.SetDataGridViewSource(_memberManager.HospitalizationIncludeTable);

            this.txtSearch.Clear();

            this.Cursor = Cursors.Arrow;
        }//---------------------------------
        //##################################END PICTUREBOX pbxRefresh EVENTS######################################################

        //##################################LINKLABEL lnkCreateIncludeCoverage EVENTS######################################################
        //event is raised when the control is clicked
        private void lnkCreateIncludeCoverageLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (HospitalizationIncludeCoverageCreate frmCreate = new HospitalizationIncludeCoverageCreate(_userInfo, _memberManager))
                {
                    frmCreate.ShowDialog(this);

                    if (frmCreate.HasCreated)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        this.SetDataGridViewSource(_memberManager.GetSearchedHospitalizationIncludeCoverage(_userInfo, _inHouseHospitalizationIncludeCoverageList,
                            this.txtSearch.Text, false));

                        this.Cursor = Cursors.Arrow;
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error");
            }
        }//-----------------------------
        //##################################END LINKLABEL lnkCreateIncludeCoverage EVENTS######################################################

        //##################################LINKLABEL lnkUpdateIncludeCoverage EVENTS######################################################
        //event is raised when the control is clicked
        private void lnkUpdateIncludeCoverageLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.PrimaryId))
            {
                try
                {
                    using (HospitalizationIncludeCoverageUpdate frmUpdate = new HospitalizationIncludeCoverageUpdate(_userInfo, _memberManager,
                        _memberManager.GetHospitalizationIncludeCoverageInformation(this.PrimaryId)))
                    {
                        frmUpdate.ShowDialog(this);

                        if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                        {
                            this.Cursor = Cursors.WaitCursor;

                            this.SetDataGridViewSource(_memberManager.GetSearchedHospitalizationIncludeCoverage(_userInfo, _inHouseHospitalizationIncludeCoverageList,
                                this.txtSearch.Text, false));

                            this.Cursor = Cursors.Arrow;
                        }
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error");
                }
            }
        }//----------------------------
        //##################################END LINKLABEL lnkUpdateIncludeCoverage EVENTS######################################################
        #endregion

    }
}
