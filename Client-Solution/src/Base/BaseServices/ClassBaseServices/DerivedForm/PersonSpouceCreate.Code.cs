using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
 
namespace BaseServices
{
    partial class PersonSpouceCreate
    {
        #region Class Properties Declarations
        private Boolean _hasAdded = false;
        public Boolean HasAdded
        {
            get { return _hasAdded; }
        }
        #endregion

        #region Class Constructos
        public PersonSpouceCreate(CommonExchange.SysAccess userInfo, BaseServicesLogic baseServiceManager, String personSysIdExcludeList)
            : base(userInfo, baseServiceManager, personSysIdExcludeList)
        {
            this.InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(ClassClossing);
            this.btnCancel.Click += new EventHandler(btnCancelClick);
            this.btnAdd.Click += new EventHandler(btnAddClick);
        }       
        #endregion

        #region Class Event Void Procedures
        //#####################################CLASS PersonSpouceCreate EVENTS########################################
        //event is raised when the class is closing
        private void ClassClossing(object sender, FormClosingEventArgs e)
        {
            if (!_hasAdded)
            {
                String strMsg = "Are you sure you want to cancel the creation of a new person spouce information?";
                DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }  
        }//-------------------------------
        //#####################################END CLASS PersonSpouceCreate EVENTS########################################

        //################################################BUTTON btnCancel EVENTS####################################################
        //event is raised when btnCancel is Clicked
        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }//-----------------------
        //################################################END BUTTON btnCancel EVENTS####################################################

        //################################################BUTTON btnAdd EVENTS####################################################
        //event is raised when btnAdd is Clicked
        private void btnAddClick(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                try
                {
                    String strMsg = "Are you sure you want to create a new person spouce?";

                    DialogResult msgResult = MessageBox.Show(strMsg, "Confirm Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msgResult == DialogResult.Yes)
                    {
                        strMsg = "The person relationship has been successfully created.";

                        this.Cursor = Cursors.WaitCursor;

                        _personSpouceInfo.ObjectState = DataRowState.Added;

                        _personSpouceInfo.SpouseId = _baseServiceManager.SpouceIdCount - 1;

                        _baseServiceManager.SpouceIdCount = _personSpouceInfo.SpouseId;

                        this.Cursor = Cursors.Arrow;

                        MessageBox.Show(strMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        _hasAdded = true;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    ProcStatic.ShowErrorDialog(ex.Message, "Error Createting");
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }//--------------------
        //################################################END BUTTON btnAdd EVENTS####################################################
        #endregion
    }
}
