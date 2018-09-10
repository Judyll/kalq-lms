using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    partial class CollateralInformation
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.Collateral _collateralInfo;
        protected CommonExchange.Member _memberInfo;
        protected MemberLogic _memberManager;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructors
        public CollateralInformation()
        {
            this.InitializeComponent();
        }

        public CollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo, MemberLogic memberLogic)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberLogic;
            _memberInfo = memberInfo;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.txtPropertyType.Validated += new EventHandler(txtPropertyTypeValidated);
            this.txtPropertyBrand.Validated += new EventHandler(txtPropertyBrandValidated);
            this.txtSerialNo.Validated += new EventHandler(txtSerialNoValidated);
            this.txtPurchasePrice.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtPurchasePrice.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtPurchasePrice.Validated += new EventHandler(txtPurchasePriceValidated);
            this.txtYearPurchase.Validated += new EventHandler(txtYearPurchaseValidated);
            this.txtEstimatedAppraisedValue.KeyPress += new KeyPressEventHandler(txtDecimalKeyPress);
            this.txtEstimatedAppraisedValue.Validating += new System.ComponentModel.CancelEventHandler(txtDecimalValidating);
            this.txtEstimatedAppraisedValue.Validated += new EventHandler(txtEstimatedAppraisedValueValidated);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
        }     
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS CollateralInformation EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _collateralInfo = new CommonExchange.Collateral();

            _collateralInfo.MemberInfo = _memberInfo;
        }//--------------------------
        //####################################################END CLASS CollateralInformation EVENTS###############################################

        //####################################################TEXTBOX textBoxDecimal EVENTS###############################################
        //event is raised when the control is validating
        private void txtDecimalValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxValidateAmount((TextBox)sender);
        }//--------------------------

        //event is raised when the key is pressed
        private void txtDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            BaseServices.ProcStatic.TextBoxAmountOnly(e);
        }//-------------------------
        //####################################################END TEXTBOX textBoxDecimal EVENTS###############################################  

        //####################################################TEXTBOX txtPropertyType EVENTS###############################################
        //event is raised when the control is validated
        private void txtPropertyTypeValidated(object sender, EventArgs e)
        {
            _collateralInfo.PropertyType = BaseServices.ProcStatic.TrimStartEndString(this.txtPropertyType.Text);
        }//--------------------------
        //####################################################END TEXTBOX txtPropertyType EVENTS###############################################

        //####################################################TEXTBOX txtPropertyBrand EVENTS###############################################
        //event is raised when the control is validated
        private void txtPropertyBrandValidated(object sender, EventArgs e)
        {
            _collateralInfo.PropertyBrand = BaseServices.ProcStatic.TrimStartEndString(this.txtPropertyBrand.Text);
        }//-------------------------
        //####################################################END TEXTBOX txtPropertyBrand EVENTS###############################################

        //####################################################TEXTBOX txtSerialNo EVENTS###############################################
        //event is raised when the control is validated
        private void txtSerialNoValidated(object sender, EventArgs e)
        {
            _collateralInfo.SerialNo = BaseServices.ProcStatic.TrimStartEndString(this.txtSerialNo.Text);
        }//---------------------------
        //####################################################END TEXTBOX txtSerialNo EVENTS###############################################

        //####################################################TEXTBOX txtPurchasePrice EVENTS###############################################
        //event is raised when the control is validated
        private void txtPurchasePriceValidated(object sender, EventArgs e)
        {
            Decimal purchasePrice = 0;

            if (Decimal.TryParse(this.txtPurchasePrice.Text, out purchasePrice))
            {
                _collateralInfo.PurchasePrice = purchasePrice;
            }
        }//-------------------------
        //####################################################END TEXTBOX txtPurchasePrice EVENTS###############################################

        //####################################################TEXTBOX txtYearPurchased EVENTS###############################################
        //event is raised when the control is validated
        private void txtYearPurchaseValidated(object sender, EventArgs e)
        {
            _collateralInfo.YearPurchased = BaseServices.ProcStatic.TrimStartEndString(this.txtYearPurchase.Text);
        }//-------------------------
        //####################################################END TEXTBOX txtYearPurchased EVENTS###############################################

        //####################################################TEXTBOX txtEstimatedAppraisedValue EVENTS###############################################
        //event is raised when the control is validated
        private void txtEstimatedAppraisedValueValidated(object sender, EventArgs e)
        {
            Decimal estPriceValue = 0;

            if (Decimal.TryParse(this.txtEstimatedAppraisedValue.Text, out estPriceValue))
            {
                _collateralInfo.EstimatedAppraisedValue = estPriceValue;
            }
        }//-------------------------
        //####################################################END TEXTBOX txtEstimatedAppraisedValue EVENTS###############################################

        //####################################################TEXTBOX txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _collateralInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//--------------------------
        //####################################################END TEXTBOX txtRemarks EVENTS###############################################
        #endregion

        #region Programme's Defined Functions
        //this function will validate controls
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtPropertyType, String.Empty);
            _errProvider.SetError(this.txtPropertyBrand, String.Empty);
            _errProvider.SetError(this.txtSerialNo, String.Empty);
            _errProvider.SetError(this.txtPurchasePrice, String.Empty);
            _errProvider.SetError(this.txtYearPurchase, String.Empty);
            _errProvider.SetError(this.txtEstimatedAppraisedValue, String.Empty);
            _errProvider.SetError(this.gbxCollateral, String.Empty);

            if (String.IsNullOrEmpty(_collateralInfo.PropertyType))
            {
                _errProvider.SetError(this.txtPropertyType, "You must input a property type information.");
                _errProvider.SetIconAlignment(this.txtPropertyType, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_collateralInfo.PropertyBrand))
            {
                _errProvider.SetError(this.txtPropertyBrand, "You must input a property brand information.");
                _errProvider.SetIconAlignment(this.txtPropertyBrand, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_collateralInfo.SerialNo))
            {
                _errProvider.SetError(this.txtSerialNo, "You must input a serial number information.");
                _errProvider.SetIconAlignment(this.txtSerialNo, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_collateralInfo.PurchasePrice <= 0)
            {
                _errProvider.SetError(this.txtPurchasePrice, "Purchase price must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtPurchasePrice, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_collateralInfo.YearPurchased))
            {
                _errProvider.SetError(this.txtYearPurchase, "You must input a year purchase information.");
                _errProvider.SetIconAlignment(this.txtYearPurchase, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (_collateralInfo.EstimatedAppraisedValue <= 0)
            {
                _errProvider.SetError(this.txtEstimatedAppraisedValue, "Estimated appraised value must be greater than zero.");
                _errProvider.SetIconAlignment(this.txtEstimatedAppraisedValue, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            if (String.IsNullOrEmpty(_collateralInfo.MemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.gbxCollateral, "Member information is required.");
                _errProvider.SetIconAlignment(this.gbxCollateral, ErrorIconAlignment.MiddleRight);

                isValid = false;
            }

            return isValid;
        }//---------------------------
        #endregion
    }
}
