using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AdministratorServices
{
    partial class UserInfoAdmin
    {
        #region Class Data Member Declaration
        protected AdministrationLogic _administarationManager;

        protected Boolean _hasErrors = false;

        protected Int32 _rowIndexForPersonSearch = -1;
        #endregion

        #region Class Constructors
        public UserInfoAdmin()
        {
            this.InitializeComponent();
        }

        public UserInfoAdmin(CommonExchange.SysAccess userInfo, AdministrationLogic administrationManager)
            : base(userInfo, administrationManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _administarationManager = administrationManager;

            this.txtUserName.Validated += new EventHandler(txtUserNameValidated);
            this.txtPassword.Validated += new EventHandler(txtPasswordValidated);
            this.txtUserName.KeyPress += new KeyPressEventHandler(textBoxKeyPress);
            this.lblStatus.Click += new EventHandler(lblStatusClick);
            this.dgvList.RowValidated += new DataGridViewCellEventHandler(dgvListRowValidated);
            this.pbxUserInfo.Click += new EventHandler(pbxUserInfoClick);
            this.pbxUserInfo.MouseEnter += new EventHandler(pbxUserInfoMouseEnter);
            this.pbxUserInfo.MouseLeave += new EventHandler(pbxUserInfoMouseLeave);
        }      
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS UserInfoAdmin EVENTS###############################################
        ////event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            try
            {
                if (!RemoteServerLib.ProcStatic.IsSystemAccessAdmin(_userInfo))
                {
                    throw new Exception("You are not authorized to access this module.");
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
                this.Close();
            }

            base.ClassLoad(sender, e);

            _newUserInfo = new CommonExchange.SysAccess();
            _newUserInfo.UserStatus = true;

            this.SetDataGridViewColumns();

            _administarationManager.InitializeAccessRightsDataGridView(this.dgvList);
        }//-----------------------
        //####################################################END CLASS UserInfoAdmin EVENTS###############################################

        //####################################################TEXTBOX EVENTS###############################################
        //event is raised when the key is pressed
        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxForUserNamePassword(e);
        }//-----------------------
        //####################################################END TEXTBOX EVENTS###############################################

        //####################################################TEXTBOX txtUserName EVENTS###############################################
        //event is raised when the control is validated
        private void txtUserNameValidated(object sender, EventArgs e)
        {
            _newUserInfo.UserName = BaseServices.ProcStatic.TrimStartEndString(this.txtUserName.Text);
        }//-------------------
        //####################################################END TEXTBOX txtUserName EVENTS###############################################

        //####################################################TEXTBOX txtPassword EVENTS###############################################
        //event is raised when the control is validated
        private void txtPasswordValidated(object sender, EventArgs e)
        {
            _newUserInfo.Password = BaseServices.ProcStatic.TrimStartEndString(this.txtPassword.Text);
        }//-------------------
        //####################################################END TEXTBOX txtPassword EVENTS###############################################

        //####################################################LABEL lblStatus EVENTS###############################################
        //event is raised when the selected index is changed
        private void lblStatusClick(object sender, EventArgs e)
        {
            this.SetUserStatusControl();
        }//-------------------
        //####################################################END LABEL lblStatus EVENTS###############################################

        //####################################################DATAGRIDVIEW dgvList EVENTS###############################################
        //event is raised when the row is validated
        private void dgvListRowValidated(object sender, DataGridViewCellEventArgs e)
        {
            //if (((Boolean)dgvList["checkbox_column", e.RowIndex].Value) && dgvList["department_name", e.RowIndex].Value == null)
            //{
            //    dgvList["department_name", e.RowIndex].ErrorText = "You must select a department.";

            //    _hasErrors = true;
            //}
            //else
            //{
            //    dgvList["department_name", e.RowIndex].ErrorText = String.Empty;

            //    _hasErrors = false;
            //}
        }//------------------------
        //####################################################END DATAGRIDVIEW dgvList EVENTS###############################################  

        //####################################################PICTUREBOX pbxUserInfo EVENTS###############################################
        //event is raised when the control is clicked
        private void pbxUserInfoClick(object sender, EventArgs e)
        {
            this.tabCntPerson.SelectedIndex = 4; //select user information tab
        }//------------------------

        //event is raised when the mouse leaves
        private void pbxUserInfoMouseLeave(object sender, EventArgs e)
        {
            this.pbxUserInfo.Image = global::AdministratorServices.Properties.Resources.lmsUusers;
        }//--------------------

        //event is raised when the mouse enters
        private void pbxUserInfoMouseEnter(object sender, EventArgs e)
        {
            this.pbxUserInfo.Image = global::AdministratorServices.Properties.Resources.lmsUsers_hover;
        }//-------------------------
        //####################################################END PICTUREBOX pbxUserInfo EVENTS###############################################
        #endregion


        #region Programmer-Defined Void Procedures
        //this procedure will Set Data Grid View Columuns
        protected void SetDataGridViewColumns()
        {
            DataGridViewColumn chkCol = new DataGridViewColumn();
            chkCol.Name = "checkbox_column";
            chkCol.HeaderText = String.Empty;
            chkCol.Width = 19;
            this.dgvList.Columns.Add(chkCol);

            DataGridViewColumn accsDescription = new DataGridViewColumn();
            accsDescription.Name = "access_description";
            accsDescription.HeaderText = "Access Description";
            accsDescription.Width = 360;
            accsDescription.ReadOnly = true;
            this.dgvList.Columns.Add(accsDescription);

            this.dgvList.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }//-------------------------------

        //this procedure will set user status control
        public void SetUserStatusControl()
        {
            _newUserInfo.UserStatus = !_newUserInfo.UserStatus;

            if (_newUserInfo.UserStatus)
            {
                this.lblStatus.Text = "ACTIVE";
                this.lblStatus.ForeColor = Color.Green;
            }
            else
            {
                this.lblStatus.Text = "DEACTIVATED";
                this.lblStatus.ForeColor = Color.Red;
            }
        }//-------------------

        //this procedure will set datagrid view do events
        public void SetDataGridViewDoEvents(Int32 rowCount)
        {
            this.dgvList.Rows[rowCount].Selected = true;
            this.dgvList.FirstDisplayedScrollingRowIndex = rowCount;

            this.dgvList.Refresh();
        }//-------------------
        #endregion

        #region Programmer-Defined Functions
        //this function will validate controls
        public Boolean ValidateControlsUser()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtUserName, "");
            _errProvider.SetError(this.txtPassword, "");
            _errProvider.SetError(this.txtConfirmPassword, "");
            _errProvider.SetError(this.txtLastName, "");
            _errProvider.SetError(this.txtFirstName, "");
            _errProvider.SetError(this.txtMiddleName, "");
            _errProvider.SetError(this.gbxAccessRights, "");

            if (String.IsNullOrEmpty(_newUserInfo.UserName))
            {
                _errProvider.SetError(this.txtUserName, "User name is required.");
                _errProvider.SetIconAlignment(this.txtUserName, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 4;
            }

            if (isValid && _newUserInfo.UserName.Length < 6)
            {
                _errProvider.SetError(this.txtUserName, "User name requires at least six (6) characters.");
                _errProvider.SetIconAlignment(this.txtUserName, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_newUserInfo.Password))
            {
                _errProvider.SetError(this.txtPassword, "Password is required.");
                _errProvider.SetIconAlignment(this.txtPassword, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 4;
            }

            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                _errProvider.SetError(this.txtConfirmPassword, "Confirm Password is required.");
                _errProvider.SetIconAlignment(this.txtConfirmPassword, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 4;
            }

            if (isValid && !String.Equals(_newUserInfo.Password, BaseServices.ProcStatic.TrimStartEndString(this.txtConfirmPassword.Text)))
            {
                _errProvider.SetError(this.txtConfirmPassword, "Password mismatch.");
                _errProvider.SetIconAlignment(this.txtConfirmPassword, ErrorIconAlignment.MiddleRight);

                _errProvider.SetError(this.txtPassword, "Password mismatch.");
                _errProvider.SetIconAlignment(this.txtPassword, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 4;
            }

            if (isValid && _newUserInfo.Password.Length < 6)
            {
                _errProvider.SetError(this.txtPassword, "Password requires at least six (6) characters.");
                _errProvider.SetIconAlignment(this.txtPassword, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 4;
            }

            if (String.IsNullOrEmpty(_personInfo.LastName))
            {
                _errProvider.SetError(this.txtLastName, "Last name is required.");
                _errProvider.SetIconAlignment(this.txtLastName, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 0;
            }

            if (String.IsNullOrEmpty(_personInfo.FirstName))
            {
                _errProvider.SetError(this.txtFirstName, "First name is required.");
                _errProvider.SetIconAlignment(this.txtFirstName, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 0;
            }

            if (_administarationManager.IsExistsNameSystemUserInformation(_userInfo, _newUserInfo))
            {
                _errProvider.SetError(this.txtUserName, "User authentication already exist.");
                _errProvider.SetIconAlignment(this.txtUserName, ErrorIconAlignment.MiddleRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 4;
            }

            if (_newUserInfo.AccessRightsGrantedList.Count < 1)
            {
                _errProvider.SetError(this.gbxAccessRights, "You must select at least one access rights.");
                _errProvider.SetIconAlignment(this.gbxAccessRights, ErrorIconAlignment.TopRight);

                isValid = false;

                this.tabCntPerson.SelectedIndex = 4;
            }          

            return isValid;
        }//-----------------------
        #endregion
    }
}
