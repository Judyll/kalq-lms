using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class InHouseExcludeCoverageUpdate
    {
        #region Class Data Member Decleration
        private CommonExchange.InHouseExcludeCoverage _tempInHouseExcludeCoverageInfo;
        #endregion

        #region Class Properties Declarations
        private Boolean _hasUpdated = false;
        public Boolean HasUpdated
        {
            get { return _hasUpdated; }
        }

        private Boolean _hasDeleted = false;
        public Boolean HasDeleted
        {
            get { return _hasDeleted; }
        }
        #endregion

        #region Class Constructors
        public InHouseExcludeCoverageUpdate(CommonExchange.SysAccess userInfo, CommonExchange.InHouseExcludeCoverage inHouseExcludeCoverageInfo,
            MemberLogic memberManager)
            : base(userInfo, memberManager)
        {
            this.InitializeComponent();

            _inHouseExcludeCoverageInfo = inHouseExcludeCoverageInfo;
            _tempInHouseExcludeCoverageInfo = (CommonExchange.InHouseExcludeCoverage)inHouseExcludeCoverageInfo.Clone();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }
        #endregion

        #region Class Event Void Procedures
        //#####################################CLASS InHouseExcludeCoverageUpdate EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.txtHospitalizationExcludeCoverageInfo.Text = _inHouseExcludeCoverageInfo.ExcludeCoverageInfo.ExcludeCoverageDescription;
            this.txtExcludeAmount.Text = _inHouseExcludeCoverageInfo.ExcludeAmount.ToString("N");
            this.txtRemarks.Text = _inHouseExcludeCoverageInfo.Remarks;
        }//------------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if ((!_hasUpdated || !_hasDeleted) && !_inHouseExcludeCoverageInfo.Equals(_tempInHouseExcludeCoverageInfo))
            {
                String strMsg = "There has been changes made in the current In house hospitalization exclude coverage information. \nExiting will not save this changes." +
                                "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//----------------------------
        //#####################################END CLASS InHouseExcludeCoverageUpdate EVENTS########################################

        //#####################################BUTTON btnClose EVENTS########################################
        //event is raised when the control is clicked
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------------
        //#####################################END BUTTON btnClose EVENTS########################################

        //#####################################BUTTON btnUpdate EVENTS########################################
        //event is raised when the control is clicked
        private void btnUpdateClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to update the In house hospitalization include coverage information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The In house hospitalization include coverage information has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseExcludeCoverageInfo.ObjectState = DataRowState.Modified;

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasUpdated = _hasDeleted = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Updating");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//------------------------
        //#####################################END BUTTON btnUpdate EVENTS########################################

        //#####################################BUTTON btnDelete EVENTS########################################
        //event is raised when the control is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to delete the In house hospitalization include coverage information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The In house hospitalization include coverage information has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseExcludeCoverageInfo.ObjectState = DataRowState.Deleted;

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasUpdated = _hasDeleted = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Deleting");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//----------------------
        //#####################################END BUTTON btnDelete EVENTS########################################
        #endregion
    }
}
