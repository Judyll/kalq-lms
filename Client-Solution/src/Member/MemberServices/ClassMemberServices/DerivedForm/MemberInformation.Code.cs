using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MemberServices
{
    partial class MemberInformation
    {
        #region Class Data Member Decleration
        protected CommonExchange.Member _memberInfo;
        protected MemberLogic _memberManager;

        private Int32 _primaryIndexCollateral = 0;
        private Int32 _rowIndexCollateral = -1;
        private String _primaryIdCollateral = String.Empty;

        private Int32 _primaryIndexOtherCreditor = 0;
        private Int32 _rowIndexOtherCreditor = -1;
        private String _primaryIdOtherCreditor = String.Empty;
        #endregion

        #region Class Constructors
        public MemberInformation()
        {
            this.InitializeComponent();
        }

        public MemberInformation(CommonExchange.SysAccess userInfo, MemberLogic memberManager)
            : base(userInfo, (BaseServices.BaseServicesLogic)memberManager)
        {
            this.InitializeComponent();

            _userInfo = userInfo;
            _memberManager = memberManager;

            this.txtMemberId.Validated += new EventHandler(txtMemberIdValidated);
            this.lnkMembershipDate.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkMembershipDateLinkClicked);
            this.cboMemberClassification.SelectedIndexChanged += new EventHandler(cboClassificationSelectedIndexChanged);
            this.cboMemberType.SelectedIndexChanged += new EventHandler(cboMemberTypeSelectedIndexChanged);
            this.txtReasonOfMembership.Validated += new EventHandler(txtReasonOfMembershipValidated);
            this.txtCertificationInformation.Validated += new EventHandler(txtCertificationInformationValidated);
            this.txtOtherCooperativeMembership.Validated += new EventHandler(txtOtherCooperativeMembershipValidated);
            this.txtOtherMemberInformation.Validated += new EventHandler(txtOtherMemberInformationValidated);
            this.lblMemberStatus.Click += new EventHandler(lblStatusClick);
            this.pbxMemberInformation.Click += new EventHandler(pbxMemberInformationClick);
            this.pbxMemberInformation.MouseEnter += new EventHandler(pbxMemberInformationMouseEnter);
            this.pbxMemberInformation.MouseLeave += new EventHandler(pbxMemberInformationMouseLeave);
            this.dgvCollateral.MouseDown += new MouseEventHandler(dgvCollateralMouseDown);
            this.dgvCollateral.KeyPress += new KeyPressEventHandler(dgvCollateralKeyPress);
            this.dgvCollateral.KeyDown += new KeyEventHandler(dgvCollateralKeyDown);
            this.dgvCollateral.DataSourceChanged += new EventHandler(dgvCollateralDataSourceChanged);
            this.dgvCollateral.DoubleClick += new EventHandler(dgvCollateralDoubleClick);
            this.dgvOtherCreditor.MouseDown += new MouseEventHandler(dgvOtherCreditorMouseDown);
            this.dgvOtherCreditor.KeyPress += new KeyPressEventHandler(dgvOtherCreditorKeyPress);
            this.dgvOtherCreditor.KeyDown += new KeyEventHandler(dgvOtherCreditorKeyDown);
            this.dgvOtherCreditor.DataSourceChanged += new EventHandler(dgvOtherCreditorDataSourceChanged);
            this.dgvOtherCreditor.DoubleClick += new EventHandler(dgvOtherCreditorDoubleClick);
            this.lnkCreateCollateral.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateCollateralLinkClicked);
            this.lnkCreateOtherCreditor.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCreateOtherCreditorLinkClicked);
        }           
        #endregion

        #region Class Event Void Procedures
        //####################################################CLASS PersonInformationCreateUpdate EVENTS###############################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            base.ClassLoad(sender, e);

            _memberInfo = new CommonExchange.Member();

            _memberInfo.IsActive = false;

            this.SetUserStatusControl();

            _memberManager.InitializeClassificationCombo(this.cboMemberClassification);
            _memberManager.InitializeMemberTypeComboBox(this.cboMemberType);

            this.dgvCollateral.DataSource = _memberManager.GetSearchedCollateralInformation(_userInfo, _memberInfo.MemberSysId, false, true);
            this.dgvOtherCreditor.DataSource = _memberManager.OtherCreditorInformationTable;
            //this.dgvOtherCreditor.DataSource = _memberManager.OtherCreditorInformationTable;

            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvCollateral, false);
            BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvOtherCreditor, false);
            //BaseServices.ProcStatic.SetDataGridViewColumns(this.dgvOtherCreditor, false);            
        }//----------------------
        //####################################################END CLASS PersonInformationCreateUpdate EVENTS###############################################

        //####################################################TEXTBOX txtMemberId EVENTS###############################################
        //event is raised when the control is validated
        private void txtMemberIdValidated(object sender, EventArgs e)
        {
            _memberInfo.MemberId = BaseServices.ProcStatic.TrimStartEndString(this.txtMemberId.Text);
        }//------------------------
        //####################################################END TEXTBOX txtMemberId EVENTS###############################################

        //####################################################LINKLABEL lnkMembershipDate EVENTS###############################################
        //event is raised when the control is clicked
        private void lnkMembershipDateLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime mDate = DateTime.MinValue;

            if (String.IsNullOrEmpty(_memberInfo.MembershipDate))
            {
                mDate = DateTime.Parse(_baseServiceManager.ServerDateTime);
            }
            else
            {
                mDate = DateTime.Parse(_memberInfo.MembershipDate);
            }

            using (BaseServices.Control.DatePicker frmPicker = new BaseServices.Control.DatePicker(mDate))
            {
                frmPicker.ShowDialog(this);

                if (frmPicker.HasSelectedDate)
                {
                    if (DateTime.TryParse(frmPicker.GetSelectedDate.ToLongDateString() + " " +
                            DateTime.Parse(_baseServiceManager.ServerDateTime).ToLongTimeString(), out mDate))
                    {
                        _memberInfo.MembershipDate = mDate.ToString();
                    }

                    this.txtMembershipDate.Text = mDate.ToLongDateString();

                    this.txtMemberId.Enabled = true;

                    _memberInfo.MemberId = this.txtMemberId.Text = _memberManager.GetMemberId(_userInfo, DateTime.Parse(_memberInfo.MembershipDate).Year);
                }
            }

            this.Cursor = Cursors.Arrow;
        }//---------------------
        //####################################################END LINKLABEL lnkMembershipDate EVENTS###############################################

        //####################################################COMBOBOX cboClassification EVENTS###############################################
        //event is raised when the control is selected index changed
        private void cboClassificationSelectedIndexChanged(object sender, EventArgs e)
        {
            _memberInfo.ClassificationInfo = _memberManager.GetMemberClassificationInformation(this.cboMemberClassification.SelectedIndex);
        }//-----------------------
        //####################################################END COMBOBOX cboClassification EVENTS###############################################

        //####################################################COMBOBOX cboMemberType EVENTS###############################################
        //event is raised when the control is selected index changed
        private void cboMemberTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            _memberInfo.MemberTypeInfo = _memberManager.GetMemberTypeInformation(this.cboMemberType.SelectedIndex);
        }//--------------------------
        //####################################################END COMBOBOX cboMemberType EVENTS###############################################

        //####################################################TEXTBOX txtOtherMemberInformation EVENTS###############################################
        //event is raised when the control is validated
        private void txtOtherMemberInformationValidated(object sender, EventArgs e)
        {
            _memberInfo.OtherMemberInformation = BaseServices.ProcStatic.TrimStartEndString(this.txtOtherMemberInformation.Text);
        }//------------------------
        //####################################################END TEXTBOX txtOtherMemberInformation EVENTS###############################################

        //####################################################TEXTBOX txtOtherCooperativeMembership EVENTS###############################################
        //event is raised when the control is validated
        private void txtOtherCooperativeMembershipValidated(object sender, EventArgs e)
        {
            _memberInfo.OtherCoopMembership = BaseServices.ProcStatic.TrimStartEndString(this.txtOtherCooperativeMembership.Text);
        }//-----------------------
        //####################################################END TEXTBOX txtOtherCooperativeMembership EVENTS###############################################

        //####################################################TEXTBOX txtCertificationInformation EVENTS###############################################
        //event is raised when the control is validated
        private void txtCertificationInformationValidated(object sender, EventArgs e)
        {
            _memberInfo.CertificationInformation = BaseServices.ProcStatic.TrimStartEndString(this.txtCertificationInformation.Text);
        }//------------------------
        //####################################################END TEXTBOX txtCertificationInformation EVENTS###############################################

        //####################################################TEXTBOX txtReasonOfMembership EVENTS###############################################
        //event is raised when the control is validated
        private void txtReasonOfMembershipValidated(object sender, EventArgs e)
        {
            _memberInfo.ReasonForMembership = BaseServices.ProcStatic.TrimStartEndString(this.txtReasonOfMembership.Text);
        }//-------------------------
        //####################################################END TEXTBOX txtReasonOfMembership EVENTS###############################################

        //####################################################LABEL lblStatus EVENTS###############################################
        //event is raised when the control is clicked
        private void lblStatusClick(object sender, EventArgs e)
        {
            this.SetUserStatusControl();
        }//------------------------
        //####################################################END LABEL lblStatus EVENTS###############################################

        //####################################################PICTUREBOX pbxMemberInformation EVENTS###############################################
        //event is raised when the control is clicked
        private void pbxMemberInformationClick(object sender, EventArgs e)
        {
            this.tabCntPerson.SelectedIndex = 4;
        }//------------------------

        //event is raised when the mouse leaves
        private void pbxMemberInformationMouseLeave(object sender, EventArgs e)
        {
            this.pbxMemberInformation.Image = global::MemberServices.Properties.Resources.Member_Information;
        }//----------------------

        //event is raised when the mouse enters
        private void pbxMemberInformationMouseEnter(object sender, EventArgs e)
        {
            this.pbxMemberInformation.Image = global::MemberServices.Properties.Resources.Member_Information_hover;
        }//-----------------------------
        //####################################################END PICTUREBOX pbxMemberInformation EVENTS###############################################    

        //############################################DATAGRIDVIEW dgvCollateral EVENTS######################################
        //event is raised when the mouse is down
        private void dgvCollateralMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexCollateral = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexCollateral = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexCollateral = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexCollateral = -1;
                        _primaryIdCollateral = String.Empty;
                        break;
                }

                if (_rowIndexCollateral != -1)
                {
                    _primaryIdCollateral = dgvBase[_primaryIndexCollateral, _rowIndexCollateral].Value.ToString();
                }
            }
        }//-------------------------

        //event is raised when the data source is changed
        private void dgvCollateralDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdCollateral = row.Cells[_primaryIndexCollateral].Value.ToString();
            }
        }//----------------------

        //event is raised when the mouse is down
        private void dgvCollateralKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//-----------------------

        //event is raissed when the key is pressed
        private void dgvCollateralKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdCollateral = row.Cells[_primaryIndexCollateral].Value.ToString();
                    _primaryIndexCollateral = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//------------------------

        //event is raised when the control is double clicked
        private void dgvCollateralDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdCollateral))
            {
                using (CollateralInformationUpdate frmUpdate = new CollateralInformationUpdate(_userInfo, _memberInfo,
                    _memberManager.GetDetailsCollateralInformation(_primaryIdCollateral), _memberManager))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        this.dgvCollateral.DataSource = _memberManager.GetSearchedCollateralInformation(_userInfo, _memberInfo.MemberSysId, false, false);
                    }
                }
            }
        }//------------------------
        //############################################END DATAGRIDVIEW dgvCollateral EVENTS######################################

        //############################################DATAGRIDVIEW dgvOtherCreditor EVENTS######################################
        //event is raised when the mouse is down
        private void dgvOtherCreditorMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView dgvBase = (DataGridView)sender;

                DataGridView.HitTestInfo hitTest = dgvBase.HitTest(e.X, e.Y);

                _rowIndexOtherCreditor = -1;

                switch (hitTest.Type)
                {
                    case DataGridViewHitTestType.Cell:
                        _rowIndexOtherCreditor = hitTest.RowIndex;
                        break;
                    case DataGridViewHitTestType.RowHeader:
                        _rowIndexOtherCreditor = hitTest.RowIndex;
                        break;
                    default:
                        _rowIndexOtherCreditor = -1;
                        _primaryIdOtherCreditor = String.Empty;
                        break;
                }

                if (_rowIndexOtherCreditor != -1)
                {
                    _primaryIdOtherCreditor = dgvBase[_primaryIndexOtherCreditor, _rowIndexOtherCreditor].Value.ToString();
                }
            }
        }//-----------------------

        //event is raised when the key is pressed
        private void dgvOtherCreditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DataGridView dgvBase = (DataGridView)sender;

                if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    DataGridViewRow row = dgvBase.SelectedRows[0];

                    _primaryIdOtherCreditor  = row.Cells[_primaryIndexOtherCreditor].Value.ToString();
                    _primaryIndexOtherCreditor = row.Index;
                }
            }
            else
            {
                e.Handled = true;
            }
        }//-------------------------

        //event is raissed when the key is down
        private void dgvOtherCreditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }//--------------------------

        //event is raised when the data source is changed
        private void dgvOtherCreditorDataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgvBase = (DataGridView)sender;

            if (dgvBase.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataGridViewRow row = dgvBase.SelectedRows[0];

                _primaryIdOtherCreditor = row.Cells[_primaryIndexOtherCreditor].Value.ToString();
            }
        }//----------------------------

        //event is raised when the control is double clicked
        private void dgvOtherCreditorDoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_primaryIdOtherCreditor))
            {
                using (OtherCreditorInformationUpdate frmUpdate = new OtherCreditorInformationUpdate(_userInfo,
                    _memberManager.GetDetailsOtherCreditorInformation(_memberInfo.OtherCreditorInfoList, _primaryIdOtherCreditor), _memberInfo, _memberManager))
                {
                    frmUpdate.ShowDialog(this);

                    if (frmUpdate.HasUpdated || frmUpdate.HasDeleted)
                    {
                        this.dgvOtherCreditor.DataSource = _memberManager.InitializeOtherCreditorDataGridView(_memberInfo.OtherCreditorInfoList);
                    }
                }
            }
        }//-------------------------------
        //############################################END DATAGRIDVIEW dgvOtherCreditor EVENTS######################################

        //############################################LINKLABEL lnkCreateCollateral EVENTS######################################
        //event is raised when the control link is clicked
        private void lnkCreateCollateralLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (CollateralInformationCreate frmCreate = new CollateralInformationCreate(_userInfo, _memberInfo, _memberManager))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    this.dgvCollateral.DataSource = _memberManager.GetSearchedCollateralInformation(_userInfo, _memberInfo.MemberSysId, false, false);
                }
            }
        }//------------------------
        //############################################END LINKLABEL lnkCreateCollateral EVENTS######################################        

        //############################################LINKLABEL lnkCreateOtherCreditor EVENTS######################################
        //event is raised when the link is clicked
        private void lnkCreateOtherCreditorLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OtherCreditorInformationCreate frmCreate = new OtherCreditorInformationCreate(_userInfo, _memberManager))
            {
                frmCreate.ShowDialog(this);

                if (frmCreate.HasCreated)
                {
                    _memberInfo.OtherCreditorInfoList.Add(frmCreate.OtherCreditorInfo);

                   this.dgvOtherCreditor.DataSource = _memberManager.InitializeOtherCreditorDataGridView(_memberInfo.OtherCreditorInfoList);
                }
            }
        }//-----------------------
        //############################################END LINKLABEL lnkCreateOtherCreditor EVENTS######################################
        #endregion

        #region Programmers-Defined Void Procedures
        //this procedure will set user status control
        public void SetUserStatusControl()
        {
            _memberInfo.IsActive = !_memberInfo.IsActive;

            if (_memberInfo.IsActive)
            {
                this.lblMemberStatus.Text = "ACTIVE";
                this.lblMemberStatus.ForeColor = Color.Green;
            }
            else
            {
                this.lblMemberStatus.Text = "DEACTIVATED";
                this.lblMemberStatus.ForeColor = Color.Red;
            }
        }//-----------------------
        #endregion

        #region Programmers-Defined Function
        //this fucntion will validate controls                       
        public Boolean MemberValidateControls()
        {
            Boolean isValid = true;

            _errProvider.SetError(this.txtMemberId, String.Empty);
            _errProvider.SetError(this.txtMembershipDate, String.Empty);
            _errProvider.SetError(this.cboMemberClassification, String.Empty);
            _errProvider.SetError(this.cboMemberType, String.Empty);

            if (String.IsNullOrEmpty(_memberInfo.MemberId))
            {
                _errProvider.SetError(this.txtMemberId, "Membership id is required.");
                _errProvider.SetIconAlignment(this.txtMemberId, ErrorIconAlignment.MiddleRight);

                this.tabCntPerson.SelectedIndex = 4;

                isValid = false;
            }

            if (String.IsNullOrEmpty(_memberInfo.MembershipDate))
            {
                _errProvider.SetError(this.txtMembershipDate, "Membership date is required.");
                _errProvider.SetIconAlignment(this.txtMembershipDate, ErrorIconAlignment.MiddleRight);

                this.tabCntPerson.SelectedIndex = 4;

                isValid = false;
            }

            if (String.IsNullOrEmpty(_memberInfo.ClassificationInfo.ClassificationId))
            {
                _errProvider.SetError(this.cboMemberClassification, "Membership clasification is required.");
                _errProvider.SetIconAlignment(this.cboMemberClassification, ErrorIconAlignment.MiddleRight);

                this.tabCntPerson.SelectedIndex = 4;

                isValid = false;
            }

            if (String.IsNullOrEmpty(_memberInfo.MemberTypeInfo.MemberTypeId))
            {
                _errProvider.SetError(this.cboMemberType, "Membership type is required.");
                _errProvider.SetIconAlignment(this.cboMemberType, ErrorIconAlignment.MiddleRight);

                this.tabCntPerson.SelectedIndex = 4;

                isValid = false;
            }

            if (_memberManager.IsExistsMemberIDMemberInformation(_userInfo, _memberInfo.MemberId, _memberInfo.MemberSysId))
            {
                _errProvider.SetError(this.txtMemberId, "Membership information already exist.");
                _errProvider.SetIconAlignment(this.txtMemberId, ErrorIconAlignment.MiddleLeft);

                this.tabCntPerson.SelectedIndex = 4;

                isValid = false;
            }

            return isValid;
        }//------------------------
        #endregion
    }
}

