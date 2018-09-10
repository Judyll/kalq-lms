using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BaseServices
{
    partial class Spouce
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected BaseServicesLogic _baseServiceManager;

        private ErrorProvider _errProvider;

        private String _personSysIdExcludeList;
        #endregion

        #region Class Properties Decleration
        protected CommonExchange.PersonSpouse _personSpouceInfo;
        public CommonExchange.PersonSpouse PersonSpouceInfo
        {
            get { return _personSpouceInfo; }
        }
        #endregion

        #region Class Constructos
        public Spouce()
        {
            this.InitializeComponent();
        }

        public Spouce(CommonExchange.SysAccess userInfo, BaseServicesLogic baseServiceManaber, String personSysIdExcludeList)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _baseServiceManager = baseServiceManaber;
            _personSysIdExcludeList = personSysIdExcludeList;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.cboRelationshipType.SelectedIndexChanged += new EventHandler(cboRelationshipTypeSelectedIndexChanged);
            this.chkIsStillASpouce.CheckedChanged += new EventHandler(chkIsStillASpouceCheckedChanged);
            this.btnSearchPerson.Click += new EventHandler(btnSearchPersonClick);
            this.lnkViewFullDetails.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkViewFullDetailsLinkClicked);
        }        
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS Spouce EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _personSpouceInfo = new CommonExchange.PersonSpouse();

            _baseServiceManager.InitializePersonRelationshipTypeCombo(this.cboRelationshipType);            
        }//----------------------
        //####################################################END CLASS Spouce EVENTS###############################################

        //####################################################COMBOX cboRelationship EVENTS###############################################
        //event is raised when the selected index is changed
        private void cboRelationshipTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            _personSpouceInfo.RelationshipTypeInfo = _baseServiceManager.GetPersonRelationshipType(this.cboRelationshipType.SelectedIndex);
        }//--------------------------------
        //####################################################END COMBOX cboRelationship EVENTS###############################################

        //####################################################CHECKEDBOX chkIsStilASpouce EVENTS###############################################
        //event is raised when the checked changed
        private void chkIsStillASpouceCheckedChanged(object sender, EventArgs e)
        {
            _personSpouceInfo.IsStillASpouse = this.chkIsStillASpouce.Checked;
        }//---------------------------
        //####################################################END CHECKEDBOX chkIsStilASpouce EVENTS###############################################

        //####################################################BUTTON bntSearchPerson EVENTS###############################################
        //event is raised when the control is clicked
        private void btnSearchPersonClick(object sender, EventArgs e)
        {
            using (PersonSearchOnTextBoxList frmSearch = new PersonSearchOnTextBoxList(_userInfo, _baseServiceManager, _personSysIdExcludeList))
            {
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    this.SetPersonSpouceControls(_baseServiceManager.GetPersonDetails(_userInfo, frmSearch.PrimaryId));
                }
                else if (frmSearch.HasRecorded)
                {
                    this.SetPersonSpouceControls(frmSearch.PersonInfo);
                }

                this.lnkViewFullDetails.Enabled = true;
            }
        }//----------------------------
        //####################################################END BUTTON bntSearchPerson EVENTS###############################################

        //####################################################LINK LABEL lnkViewFullDetails EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkViewFullDetailsLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (PersonInformationUpdate frmUpdate = new PersonInformationUpdate(_userInfo,
                _baseServiceManager.GetPersonDetails(_userInfo, _personSpouceInfo.PersonInSpouseWith.PersonSysId),
                _baseServiceManager))
            {
                frmUpdate.PersonArchiveVisible = false;
                frmUpdate.SetPersonInformationControls(true);

                frmUpdate.ShowDialog(this);

                if (frmUpdate.HasUpdated)
                {
                    _personSpouceInfo.PersonInSpouseWith = frmUpdate.PersonInfo;

                    _baseServiceManager.InitializePersonRelationshipTypeCombo(this.cboRelationshipType,
                        _personSpouceInfo.RelationshipTypeInfo.RelationshipTypeId);

                    this.SetPersonSpouceControls(_personSpouceInfo.PersonInSpouseWith);

                    this.chkIsStillASpouce.Checked = _personSpouceInfo.IsStillASpouse;
                }
            }
        }//-----------------------------
        //####################################################END LINK LABEL lnkViewFullDetails EVENTS###############################################
        #endregion

        #region Programmer-Defined Void Procedures
        //this procedure will set Person Relationship controls
        private void SetPersonSpouceControls(CommonExchange.Person personInfo)
        {
            _personSpouceInfo.PersonInSpouseWith.PersonSysId = personInfo.PersonSysId;
            _personSpouceInfo.PersonInSpouseWith.LastName = personInfo.LastName;
            _personSpouceInfo.PersonInSpouseWith.FirstName = personInfo.FirstName;
            _personSpouceInfo.PersonInSpouseWith.MiddleName = personInfo.MiddleName;
            _personSpouceInfo.PersonInSpouseWith.BirthDate = personInfo.BirthDate;
            _personSpouceInfo.PersonInSpouseWith.PresentAddress = personInfo.PresentAddress;
            _personSpouceInfo.PersonInSpouseWith.PresentPhoneNos = personInfo.PresentPhoneNos;
            _personSpouceInfo.PersonInSpouseWith.LifeStatusCode = personInfo.LifeStatusCode;
            _personSpouceInfo.PersonInSpouseWith.GenderCode = personInfo.GenderCode;

            this.lblPersonLastName.Text = personInfo.LastName;
            this.lblPersonFirstName.Text = personInfo.FirstName;
            this.lblPersonMiddleName.Text = personInfo.MiddleName;
            this.lblPresentAddress.Text = personInfo.PresentAddress;
            this.lblPresentPhoneNo.Text = personInfo.PresentPhoneNos;

        }//-------------------------------
        #endregion

        #region Programmer-Defined Functions
        //this procedure will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnSearchPerson, "");
            _errProvider.SetError(this.cboRelationshipType, "");

            if (String.IsNullOrEmpty(_personSpouceInfo.PersonInSpouseWith.PersonSysId))
            {
                _errProvider.SetError(this.btnSearchPerson, "You must select a person information.");
                _errProvider.SetIconAlignment(this.btnSearchPerson, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_personSpouceInfo.RelationshipTypeInfo.RelationshipTypeId))
            {
                _errProvider.SetError(this.cboRelationshipType, "You must select a person relationship type.");
                _errProvider.SetIconAlignment(this.cboRelationshipType, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//--------------------------
        #endregion
    }
}
