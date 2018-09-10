using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class InHouseExcludeCoverage
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.InHouseExcludeCoverage _inHouseExcludeCoverageInfo;
        protected MemberLogic _memberManager;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Properties Declerateion
        public CommonExchange.InHouseExcludeCoverage InHouseExcludeCoverageInfo
        {
            get { return _inHouseExcludeCoverageInfo; }
        }
        #endregion

        #region Class Constructors
        public InHouseExcludeCoverage()
        {
            this.InitializeComponent();
        }

        public InHouseExcludeCoverage(CommonExchange.SysAccess userInfo, MemberLogic memberManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.btnSearchHospitalizationExcludeInfo.Click += new EventHandler(btnSearchHospitalizationExcludeInfoClick);
            this.txtExcludeAmount.KeyPress += new KeyPressEventHandler(txtExcludeAmountKeyPress);
            this.txtExcludeAmount.Validating += new System.ComponentModel.CancelEventHandler(txtExcludeAmountValidating);
            this.txtExcludeAmount.Validated += new EventHandler(txtExcludeAmountValidated);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS InHouseExcludeCoverage EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _inHouseExcludeCoverageInfo = new CommonExchange.InHouseExcludeCoverage();
        }//---------------------
        //####################################################END CLASS InHouseExcludeCoverage EVENTS###############################################

        //####################################################BUTTON btnSearchHospitalizationExcludeInfo EVENTS###########################################
        //event is raised when the control is clicked
        private void btnSearchHospitalizationExcludeInfoClick(object sender, EventArgs e)
        {
            using (HospitalizationExcludeSearchedOnTextBoxLis frmSearch = new HospitalizationExcludeSearchedOnTextBoxLis(_userInfo, _memberManager))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _inHouseExcludeCoverageInfo.ExcludeCoverageInfo = _memberManager.GetHospitalizationExcludeCoverageInformation(frmSearch.PrimaryId);

                    this.txtHospitalizationExcludeCoverageInfo.Text = _inHouseExcludeCoverageInfo.ExcludeCoverageInfo.ExcludeCoverageDescription;

                    this.txtExcludeAmount.Focus();
                }
            }
        }//----------------------
        //####################################################END BUTTON btnSearchHospitalizationExcludeInfo EVENTS#######################################

        //####################################################TEXTBOX txtIncludeAmount EVENTS###############################################
        //event is raised when the control is validated
        private void txtExcludeAmountValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtExcludeAmount.Text, out amount))
            {
                _inHouseExcludeCoverageInfo.ExcludeAmount = amount;
            }
        }//------------------------

        //event is raised when the control is validating
        private void txtExcludeAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//-------------------------

        //event is raised when the key is pressed
        private void txtExcludeAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//----------------------------
        //####################################################END TEXTBOX txtIncludeAmount EVENTS###############################################

        //####################################################TEXTBOX txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _inHouseExcludeCoverageInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//----------------------------
        //####################################################END TEXTBOX txtRemarks EVENTS###############################################
        #endregion

        #region Programmer's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnSearchHospitalizationExcludeInfo, String.Empty);
            _errProvider.SetError(this.txtExcludeAmount, String.Empty);

            if (String.IsNullOrEmpty(_inHouseExcludeCoverageInfo.ExcludeCoverageInfo.ExcludeCoverageSysId))
            {
                _errProvider.SetError(this.btnSearchHospitalizationExcludeInfo, "You must select a In house hospitalization exclude coverage information.");
                _errProvider.SetIconAlignment(this.btnSearchHospitalizationExcludeInfo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_inHouseExcludeCoverageInfo.ExcludeAmount <= 0)
            {
                _errProvider.SetError(this.txtExcludeAmount, "Exclude amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtExcludeAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//------------------------
        #endregion
    }
}
