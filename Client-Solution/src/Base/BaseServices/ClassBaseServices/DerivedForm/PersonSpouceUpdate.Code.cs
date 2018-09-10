using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BaseServices
{
    partial class PersonSpouceUpdate
    {
        #region Class Data Member Decleration
        private CommonExchange.PersonSpouse _personSpouceInfoTemp;
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
        public PersonSpouceUpdate(CommonExchange.SysAccess userInfo, CommonExchange.PersonSpouse personSpouceInfo,
            BaseServicesLogic baseServiceManager, String personSysIdExcludeList)
            : base(userInfo, baseServiceManager, personSysIdExcludeList)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _baseServiceManager = baseServiceManager;
            _personSpouceInfo = personSpouceInfo;
            _personSpouceInfoTemp = (CommonExchange.PersonSpouse)personSpouceInfo.Clone();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnClose.Click += new EventHandler(btnCloseClick);
            this.btnUpdate.Click += new EventHandler(btnUpdateClick);
            this.btnDelete.Click += new EventHandler(btnDeleteClick);
        }  
        #endregion

        #region Class Event Void Procedures
        //#####################################CLASS PersonSpouceUpdate EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            _baseServiceManager.InitializePersonRelationshipTypeCombo(this.cboRelationshipType, _personSpouceInfo.RelationshipTypeInfo.RelationshipTypeId);

            this.lblPersonLastName.Text = _personSpouceInfo.PersonInSpouseWith.LastName;
            this.lblPersonFirstName.Text = _personSpouceInfo.PersonInSpouseWith.FirstName;
            this.lblPersonMiddleName.Text = _personSpouceInfo.PersonInSpouseWith.MiddleName;
            this.lblPresentAddress.Text = _personSpouceInfo.PersonInSpouseWith.PresentAddress;
            this.lblPresentPhoneNo.Text = _personSpouceInfo.PersonInSpouseWith.PresentPhoneNos;

            this.chkIsStillASpouce.Checked = _personSpouceInfo.IsStillASpouse;

            this.lnkViewFullDetails.Enabled = true;
            this.btnSearchPerson.Visible = false;
        }//----------------------------

        //event is raised whent the class is clossing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if ((!_hasUpdated || !_hasDeleted) && !_personSpouceInfo.Equals(_personSpouceInfoTemp))
            {
                String strMsg = "There has been changes made in the current person spouce information. \nExiting will not save this changes." +
                                "\n\nAre you sure you want to exit?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        //#####################################END CLASS PersonSpouceUpdate EVENTS########################################

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
                    String strMsg = "Are you sure you want to update the person spouce?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The person spouce has been successfully updated.";

                        this.Cursor = Cursors.WaitCursor;

                        if (_personSpouceInfo.ObjectState != DataRowState.Added)
                        {
                            _personSpouceInfo.ObjectState = DataRowState.Modified;
                        }
                        else
                        {
                            _personSpouceInfo.ObjectState = DataRowState.Added;
                        }

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasUpdated = _hasDeleted = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    ProcStatic.ShowErrorDialog(ex.Message, "Error Updating");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//-------------------------
        //#####################################END BUTTON btnUpdate EVENTS########################################

        //#####################################BUTTON btnDelete EVENTS########################################
        //event is raised when the control is clicked
        private void btnDeleteClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to delete the person spouce?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The person spouce has been successfully deleted.";

                        this.Cursor = Cursors.WaitCursor;

                        _personSpouceInfo.ObjectState = DataRowState.Deleted;

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasUpdated = _hasDeleted = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    ProcStatic.ShowErrorDialog(ex.Message, "Error Deleting");
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
