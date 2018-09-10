using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    partial class CoMakerInformation
    {
        #region Class Data Member Decleration
        protected CommonExchange.SysAccess _userInfo;
        protected CommonExchange.RegularLoanCoMaker _coMakerInfo;
        protected CommonExchange.RegularLoan _regularLoanInfo;
        protected LoanLogic _loanManager;

        private String _memberSysId;

        private ErrorProvider _errProvider;
        #endregion

        #region Class Constructors
        public CoMakerInformation()
        {
            this.InitializeComponent();
        }

        public CoMakerInformation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo, LoanLogic loanManager, String memberSysId)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _loanManager = loanManager;
            _regularLoanInfo = regularLoanInfo;
            _memberSysId = memberSysId;

            _errProvider = new ErrorProvider();

            this.Load += new EventHandler(ClassLoad);
            this.txtRemarks.Validated += new EventHandler(txtRemarksValidated);
            this.btnSearch.Click += new EventHandler(btnSearchMemberClick);
            this.lnkViewFullDetails.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkViewFullDetailsLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS CoMakerInformation EVENTS###############################################
        //event is raised when the class is loaded
        protected virtual void ClassLoad(object sender, EventArgs e)
        {
            _coMakerInfo = new CommonExchange.RegularLoanCoMaker();

            _coMakerInfo.RegularLoanInfo = _regularLoanInfo;           
        }//---------------------
        //####################################################END CLASS CoMakerInformation EVENTS###############################################

        //####################################################TEXTBOX  txtRemarks EVENTS###############################################
        //event is raised when the control is validated
        private void txtRemarksValidated(object sender, EventArgs e)
        {
            _coMakerInfo.Remarks = BaseServices.ProcStatic.TrimStartEndString(this.txtRemarks.Text);
        }//----------------------
        //####################################################END TEXTBOX  txtRemarks EVENTS###############################################

        //####################################################BUTTON btnSearchMember EVENTS###############################################
        //event is raised when the control is validated
        private void btnSearchMemberClick(object sender, EventArgs e)
        {
            using (CoMakerSearchOnTextBoxList frmSearch = new CoMakerSearchOnTextBoxList(_userInfo, _loanManager, _memberSysId))
            {
                frmSearch.ShowDialog(this);

                if (frmSearch.HasSelected)
                {
                    _coMakerInfo.CoMakerMemberInfo = _loanManager.GetDetailsMemberInfo(frmSearch.PrimaryId);

                    this.lblPersonLastName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.LastName;
                    this.lblPersonFirstName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.FirstName;
                    this.lblPersonMiddleName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.MiddleName;
                    this.lblPresentAddress.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.PresentAddress;
                    this.lblPresentPhoneNo.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.PresentPhoneNos;

                    this.lnkViewFullDetails.Enabled = true;
                }
            }
        }//----------------------
        //####################################################END BUTTON btnSearchMember EVENTS###############################################

        //####################################################LINK LABEL lnkViewFullDetails EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkViewFullDetailsLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (BaseServices.PersonInformationUpdate frmUpdate = new BaseServices.PersonInformationUpdate(_userInfo,
                _loanManager.GetPersonDetails(_userInfo,_coMakerInfo.CoMakerMemberInfo.PersonInfo.PersonSysId), _loanManager))
            {
                frmUpdate.PersonArchiveVisible = false;
                frmUpdate.SetPersonInformationControls(true);

                frmUpdate.ShowDialog(this);

                if (frmUpdate.HasUpdated)
                {
                    _coMakerInfo.CoMakerMemberInfo.PersonInfo = frmUpdate.PersonInfo;

                    this.lblPersonLastName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.LastName;
                    this.lblPersonFirstName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.FirstName;
                    this.lblPersonMiddleName.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.MiddleName;
                    this.lblPresentAddress.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.PresentAddress;
                    this.lblPresentPhoneNo.Text = _coMakerInfo.CoMakerMemberInfo.PersonInfo.PresentPhoneNos;

                }
            }
        }//-----------------------------
        //####################################################END LINK LABEL lnkViewFullDetails EVENTS###############################################
        #endregion

        #region Programme's Defined Functions
        //this fucntion will validate controls\
        public Boolean ValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.btnSearch, String.Empty);

            if (String.IsNullOrEmpty(_coMakerInfo.CoMakerMemberInfo.MemberSysId))
            {
                _errProvider.SetError(this.btnSearch, "You must select a co-maker information.");
                _errProvider.SetIconAlignment(this.btnSearch, ErrorIconAlignment.MiddleLeft);

                isValid = false;
            }

            return isValid;
        }//---------------------------
        #endregion
    }
}
