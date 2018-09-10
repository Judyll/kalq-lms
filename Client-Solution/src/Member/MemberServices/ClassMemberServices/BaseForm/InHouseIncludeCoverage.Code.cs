using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class InHouseIncludeCoverage
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.InHouseIncludeCoverage _inHouseIncludeCoverageInfo;
        protected MemberLogic _memberManager;

        private List<CommonExchange.InHouseIncludeCoverage> _inHouseHospitalizationIncludeCoverageList;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Properties Decleration
        public CommonExchange.InHouseIncludeCoverage InHouseIncludeCoverageInfo
        {
            get { return _inHouseIncludeCoverageInfo; }
        }
        #endregion

        #region Class Constructos
        public InHouseIncludeCoverage()
        {
            this.InitializeComponent();
        }

        public InHouseIncludeCoverage(CommonExchange.SysAccess userInfo, MemberLogic memberManager,
            List<CommonExchange.InHouseIncludeCoverage> inHouseHospitalizationIncludeCoverageList)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;
            _inHouseHospitalizationIncludeCoverageList = inHouseHospitalizationIncludeCoverageList;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.btnSearchHospitalizationIncludeInfo.Click += new EventHandler(btnSearchHospitalizationIncludeInfoClick);
            this.txtIncludeAmount.KeyPress += new KeyPressEventHandler(txtIncludeAmountKeyPress);
            this.txtIncludeAmount.Validating += new System.ComponentModel.CancelEventHandler(txtIncludeAmountValidating);
            this.txtIncludeAmount.Validated += new EventHandler(txtIncludeAmountValidated);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS InHouseIncludeCoverage EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _inHouseIncludeCoverageInfo = new CommonExchange.InHouseIncludeCoverage();
        }//-------------------------
        //####################################################END CLASS InHouseIncludeCoverage EVENTS###############################################

        //####################################################BUTTON btnSearchHospitalizationIncludeInfo EVENTS###########################################
        //event is raised when the control is clicked
        private void btnSearchHospitalizationIncludeInfoClick(object sender, EventArgs e)
        {
            using (HospitalizationIncludeSearchedOnTextBoxList frmSearch = new HospitalizationIncludeSearchedOnTextBoxList(_userInfo, _memberManager,
                _inHouseHospitalizationIncludeCoverageList))
            {
                frmSearch.AdoptGridSize = true;
                frmSearch.ShowDialog(this);
                
                if (frmSearch.HasSelected)
                {
                    _inHouseIncludeCoverageInfo.IncludeCoverageInfo = _memberManager.GetHospitalizationIncludeCoverageInformation(frmSearch.PrimaryId);

                    this.txtHospitalizationIncludeCoverageInfo.Text = _inHouseIncludeCoverageInfo.IncludeCoverageInfo.IncludeCoverageDescription;

                    this.txtIncludeAmount.Focus();
                }
            }
        }//--------------------------
        //####################################################END BUTTON btnSearchHospitalizationIncludeInfo EVENTS###########################################

        //####################################################TEXTBOX txtIncludeAmount EVENTS###############################################
        //event is raised when the control is validated
        private void txtIncludeAmountValidated(object sender, EventArgs e)
        {
            Decimal amount = 0;

            if (Decimal.TryParse(this.txtIncludeAmount.Text, out amount))
            {
                _inHouseIncludeCoverageInfo.IncludeAmount = amount;
            }
        }//--------------------------

        //event is raised when the control is validating
        private void txtIncludeAmountValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//--------------------------

        //event is raisd when the key is pressed
        private void txtIncludeAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//------------------------
        //####################################################END TEXTBOX txtIncludeAmount EVENTS###############################################

        //####################################################TEXTBOX txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _inHouseIncludeCoverageInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//------------------------
        //####################################################END TEXTBOX txtRemarks EVENTS###############################################
        #endregion

        #region Programmer's Defined Function
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnSearchHospitalizationIncludeInfo, String.Empty);
            _errProvider.SetError(this.txtIncludeAmount, String.Empty);

            if (String.IsNullOrEmpty(_inHouseIncludeCoverageInfo.IncludeCoverageInfo.IncludeCoverageSysId))
            {
                _errProvider.SetError(this.btnSearchHospitalizationIncludeInfo, "You must select a hospitalization include coverage.");
                _errProvider.SetIconAlignment(this.btnSearchHospitalizationIncludeInfo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_inHouseIncludeCoverageInfo.IncludeAmount <= 0)
            {
                _errProvider.SetError(this.txtIncludeAmount, "Include amount must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtIncludeAmount, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//-------------------
        #endregion
    }
}
