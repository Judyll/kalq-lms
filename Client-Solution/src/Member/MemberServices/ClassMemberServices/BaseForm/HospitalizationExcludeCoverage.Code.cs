using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class HospitalizationExcludeCoverage
    {
        #region Class Data Member Decleration
        protected MemberLogic _memberManager;
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.HospitalizationExcludeCoverage _hospitalizationExcludeCoverageInfo;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructors
        public HospitalizationExcludeCoverage()
        {
            this.InitializeComponent();
        }

        public HospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, MemberLogic memberManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.txtDescription.Validated += new EventHandler(txtDescriptionValidated);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS HospitalizationExcludeCoverage EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _hospitalizationExcludeCoverageInfo = new CommonExchange.HospitalizationExcludeCoverage();
        }//------------------------
        //####################################################END CLASS HospitalizationExcludeCoverage EVENTS###############################################

        //####################################################BUTTON  txtDescription EVENTS###############################################
        //event is raised when the control is validated
        private void txtDescriptionValidated(object sender, EventArgs e)
        {
            _hospitalizationExcludeCoverageInfo.ExcludeCoverageDescription = BaseServices.ProcStatic.TrimStartEndString(this.txtDescription.Text);
        }//----------------------
        //####################################################END BUTTON  txtDescription EVENTS###############################################
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtDescription, String.Empty);

            if (String.IsNullOrEmpty(_hospitalizationExcludeCoverageInfo.ExcludeCoverageDescription))
            {
                _errProvider.SetError(this.txtDescription, "A hospitalization exclude coverage description is required.");
                _errProvider.SetIconAlignment(this.txtDescription, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//---------------------------

        #endregion

    }
}
