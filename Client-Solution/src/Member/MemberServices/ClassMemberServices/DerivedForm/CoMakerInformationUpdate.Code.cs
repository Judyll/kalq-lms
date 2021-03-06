using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class CoMakerInformationUpdate
    {
        #region Class Data Member Decleration
        private CommonExchange.RegularLoanCoMaker _temRegularLoanCoMaker;
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
        public CoMakerInformationUpdate(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo, 
            CommonExchange.RegularLoanCoMaker coMakerInfo, LoanLogic loanManager, String memberSysId)
            : base(userInfo, regularLoanInfo, loanManager, memberSysId)
        {
            this.InitializeComponent();

            coMakerInfo.RegularLoanInfo = regularLoanInfo;
            _coMakerInfo = coMakerInfo;
            _temRegularLoanCoMaker = (CommonExchange.RegularLoanCoMaker)coMakerInfo;

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }
        #endregion
        
        #region Class Event Void Procedures
        //#####################################CLASS CollateralInformationUpdate EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            this.lblPersonLastName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.LastName;
            this.lblPersonFirstName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.FirstName;
            this.lblPersonMiddleName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.MiddleName;
            this.lblPresentAddress.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.PresentAddress;
            this.lblPresentPhoneNo.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.PresentPhoneNos;

            this.lnkViewFullDetails.Enabled = true;

            this.txtRemarks.Text = _coMakerInfo.Remarks;
        }//------------------------------------

        //event is raised when the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if ((!_hasUpdated || !_hasDeleted) && !_coMakerInfo.Equals(_temRegularLoanCoMaker))
            {
                String strMsg = "There has been changes made in the current co-maker information. \nExiting will not save this changes." +
                                "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }//----------------------------
        //#####################################END CLASS CollateralInformationUpdate EVENTS########################################

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
                    String strMsg = "Are you sure you want to update the co-maker information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The co-maker information has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        _coMakerInfo.ObjectState = DataRowState.Modified;

                        _loanManager.UpdateRegularLoanCoMaker(_coMakerInfo);

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
                    String strMsg = "Are you sure you want to delete the co-maker information?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The co-maker information has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _coMakerInfo.ObjectState = DataRowState.Deleted;

                        _loanManager.DeleteRegularLoanCoMaker(_coMakerInfo);

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
