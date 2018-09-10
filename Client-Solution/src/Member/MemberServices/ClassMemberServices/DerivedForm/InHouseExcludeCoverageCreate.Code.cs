using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class InHouseExcludeCoverageCreate
    {
        #region Class Properties Declarations
        private Boolean _hasCreated = false;
        public Boolean HasCreated
        {
            get { return _hasCreated; }
        }

        private Boolean _multipleInsert = false;
        public Boolean MultipleInsert
        {
            get { return _multipleInsert; }
            set { _multipleInsert = value; }
        }
        #endregion

        #region Class Constructors
        public InHouseExcludeCoverageCreate(CommonExchange.SysAccess userInfo, MemberLogic memberManager)
            : base(userInfo, memberManager)
        {
            this.InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.chkMultipleInsert.CheckedChanged += new EventHandler(chkMultipleInsertCheckedChanged);
            this.btnCancel.Click += new EventHandler(btnCancelClick);
            this.btnCreate.Click += new EventHandler(btnCreateClick);
        }
        #endregion

        #region Class Event Void Procedures
        //#####################################CLASS InHouseExcludeCoverageCreate EVENTS########################################
        //event is raised when the class is closing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasCreated)
            {
                String strMsg = "Are you sure you want to cancel the creation of a new In house hospitalization exclude coverage information?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }  
        }//--------------------------
        //#####################################END CLASS InHouseExcludeCoverageCreate EVENTS########################################

        //################################################CHECKBOX chkMultipleInsert EVENTS####################################################
        //event is raised when the checked is change
        private void chkMultipleInsertCheckedChanged(object sender, EventArgs e)
        {
            _multipleInsert = this.chkMultipleInsert.Checked;
        }//-----------------------
        //################################################END CHECKBOX chkMultipleInsert EVENTS####################################################


        //################################################BUTTON btnCancel EVENTS####################################################
        //event is raised when btnCancel is Clicked
        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------
        //################################################END BUTTON btnCancel EVENTS####################################################

        //################################################BUTTON btnCreate EVENTS####################################################
        //event is raised when btnAdd is Clicked
        private void btnCreateClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    //String strMsg = "Are you sure you want to create a In house hospitalization exclude coverage information?";

                    //DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //if (msgResult == DialogResult.Yes)
                    //{
                    //    strMsg = "The In house hospitalization exclude coverage information has been successfully created.";

                        this.Cursor = Cursors.WaitCursor;

                        _inHouseExcludeCoverageInfo.ObjectState = DataRowState.Added;

                        _inHouseExcludeCoverageInfo.ExcludeCoverageId = _memberManager.InHouseHospitalizationExcludeCoverageId - 1;

                        _memberManager.InHouseHospitalizationExcludeCoverageId = _inHouseExcludeCoverageInfo.ExcludeCoverageId;

                        this.Cursor = Cursors.Arrow;

                        //MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasCreated = true;

                        this.Close();
                    //}
                }
                catch (Exception ex)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Createting");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//--------------------------
        //################################################END BUTTON btnCreate EVENTS####################################################
        #endregion
    }
}
