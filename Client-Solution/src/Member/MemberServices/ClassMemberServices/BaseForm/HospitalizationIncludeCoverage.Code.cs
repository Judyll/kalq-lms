using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class HospitalizationIncludeCoverage
    {
        #region Class Data Member Decleration
        protected MemberLogic _memberManager;
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.HospitalizationIncludeCoverage _hospitalizationIncludeCoverageInfo;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructor
        public HospitalizationIncludeCoverage()
        {
            this.InitializeComponent();
        }

        public HospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, MemberLogic memberManager)
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
        //####################################################CLASS HospitalizationIncludeCoverage EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _hospitalizationIncludeCoverageInfo = new CommonExchange.HospitalizationIncludeCoverage();
        }
        //####################################################END CLASS HospitalizationIncludeCoverage EVENTS###############################################

        //####################################################BUTTON  txtDescription EVENTS###############################################
        //event is raised when the control is validated
        private void txtDescriptionValidated(object sender, EventArgs e)
        {
            _hospitalizationIncludeCoverageInfo.IncludeCoverageDescription = BaseServices.ProcStatic.TrimStartEndString(this.txtDescription.Text);
        }//-------------------------
        //####################################################END BUTTON  txtDescription EVENTS###############################################
        #endregion

        #region Programmer's Defined Functions
        //this fucntion will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtDescription, String.Empty);

            if (String.IsNullOrEmpty(_hospitalizationIncludeCoverageInfo.IncludeCoverageDescription))
            {
                _errProvider.SetError(this.txtDescription, "A hospitalization include coverage description is required.");
                _errProvider.SetIconAlignment(this.txtDescription, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//----------------------
        #endregion

    }
}
