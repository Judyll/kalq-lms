using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace BaseServices.Controls
{
    public delegate void ControlCashieringManagerMiscellaneousIncomeClick();
    public delegate void ControlCashieringManagerCheckedListBoxSelectedIndexChanged();
    public delegate void ControlCashieringManagerResetQueryLinkClicked();
    public delegate void ControlCashieringManagerDecrementLinkClicked();
    public delegate void ControlCashieringManagerIncrementLinkClicked();
    public delegate void ControlCashieringManagerReceiptDateValueChanged(DateTime d);
    public delegate void ControlCashieringManagerReceiptNoTextBoxValidated();

    public delegate void ControlCashieringManagerCashReceiptsDetailedLinkClicked();
    public delegate void ControlCashieringManagerCashReceiptsSummarizedLinkClicked();

    partial class ControlCashieringManager
    {
        #region Class Event Declarations
        public event ControlCashieringManagerMiscellaneousIncomeClick OnMiscellaneousIncome;
        public event ControlCashieringManagerCheckedListBoxSelectedIndexChanged OnOfficeEmployerSelectedIndexChanged;
        //public event ControlCashieringManagerCheckedListBoxSelectedIndexChanged OnMemberClassificationSelectedIndexChanged;
        //public event ControlCashieringManagerCheckedListBoxSelectedIndexChanged OnMemberTypeSelectedIndexChanged;
        public event ControlCashieringManagerResetQueryLinkClicked OnResetLinkClicked;
        public event KeyEventHandler OnTextBoxKeyUpQuery;
        public event BaseServices.Control.KeyPressEnter OnPressEnterQuery;
        public event ControlCashieringManagerDecrementLinkClicked OnDecrementLinkClicked;
        public event ControlCashieringManagerIncrementLinkClicked OnIncrementLinkClicked;
        public event ControlCashieringManagerReceiptDateValueChanged OnReceiptDateValueChanged;
        public event ControlCashieringManagerReceiptNoTextBoxValidated OnReceiptNoTextBoxValidated;

        public event ControlCashieringManagerCashReceiptsDetailedLinkClicked OnCashReceiptsDetailedLinkClicked;
        public event ControlCashieringManagerCashReceiptsSummarizedLinkClicked OnCashReceiptsSummarizedLinkClicked;
        #endregion

        #region Class Member Declarations
        protected ToolTip _ttpMain = new ToolTip();
        #endregion

        #region Class Properties Declarations
        public CheckedListBox OfficeEmployerCheckedListBox
        {
            get { return this.cbxOfficeEmployer; }
            set { this.lblOfficeCount.Text = 0.ToString(); this.cbxOfficeEmployer = value; }
        }

        //public CheckedListBox MemberClassificationCheckedListBox
        //{
        //    get { return this.cbxMemberClassification; }
        //    set { this.lblMemberClassificationCount.Text = 0.ToString(); this.cbxMemberClassification = value; }
        //}

        //public CheckedListBox MemberTypeCheckedListBox
        //{
        //    get { return this.cbxMemberType; }
        //    set { this.lblMemberTypeCount.Text = 0.ToString(); this.cbxMemberType = value; }
        //}

        public Int32 ReceiptNo
        {
            get
            {
                Int32 result;

                if (Int32.TryParse(this.txtReceiptNo.Text, out result))
                {
                    return result;
                }

                return 0;
            }
            set
            {
                this.txtReceiptNo.Text = value.ToString("000000");
            }
        }

        public DateTime ReceiptDate
        {
            get { return this.dtpReceiptDate.Value; }
            set { this.dtpReceiptDate.Value = value; }
        }
        #endregion

        #region Class Constructors
        public ControlCashieringManager()
        {
            this.InitializeComponent();

            this.pbxMiscellaneousIncome.Click += new EventHandler(pbxMiscellaneousIncomeClick);
            this.cbxOfficeEmployer.SelectedIndexChanged += new EventHandler(cbxOfficeEmployerSelectedIndexChanged);
            this.lnkOfficeEmployer.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkOfficeEmployerLinkClicked);
            this.txtQueryCashiering.KeyUp += new KeyEventHandler(txtQueryCashieringKeyUp);
            this.txtQueryCashiering.KeyPress += new KeyPressEventHandler(txtQueryCashieringKeyPress);
            //this.cbxMemberClassification.SelectedIndexChanged += new EventHandler(cbxMemberClassificationSelectedIndexChanged);
            //this.lnkMemberClassificationSelectNone.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkMemberClassificationSelectNoneLinkClicked);
            //this.cbxMemberType.SelectedIndexChanged += new EventHandler(cbxMemberTypeSelectedIndexChanged);
            //this.lnkMemberTypeSelectNone.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkMemberTypeSelectNoneLinkClicked);
            this.txtReceiptNo.Validated += new EventHandler(txtReceiptNoValidated);
            this.txtReceiptNo.KeyPress += new KeyPressEventHandler(txtReceiptNoKeyPress);
            this.lnkDecrement.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkDecrementLinkClicked);
            this.lnkIncrement.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkIncrementLinkClicked);
            this.dtpReceiptDate.ValueChanged += new EventHandler(dtpReceiptDateValueChanged);
            this.lnkResetQuery.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkResetQueryLinkClicked);
            this.tabManager.SelectedIndexChanged += new EventHandler(tabManagerSelectedIndexChanged);

            this.lnkCashReceiptsDetailed.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCashReceiptsDetailedLinkClicked);
            this.lnkCashReceiptsSummarized.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCashReceiptsSummarizedLinkClicked);
        }
        #endregion

        #region Class Event Void Procedures
        //################################CLASS ControlManager EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            base.ClassLoad(sender, e);

            _maxHeight = this.Size.Height;

            _ttpMain.ToolTipIcon = ToolTipIcon.Info;
            _ttpMain.ToolTipTitle = "Console";
            _ttpMain.UseAnimation = true;
            _ttpMain.UseFading = true;
            _ttpMain.IsBalloon = true;
            _ttpMain.AutoPopDelay = 3000;
            _ttpMain.SetToolTip(this.pbxClose, "Close");
            _ttpMain.SetToolTip(this.pbxRefresh, "Refresh");
            _ttpMain.SetToolTip(this.pbxMiscellaneousIncome, "Miscellaneous Income");

            this.dtpReceiptDate.Format = DateTimePickerFormat.Custom;
            this.dtpReceiptDate.CustomFormat = "<dddd>   MMM dd, yyyy";

            this.txtQueryCashiering.Select();
            this.txtQueryCashiering.Focus();
        }//------------------------
        //################################END CLASS ControlManager EVENTS#####################################

        //##################################PICTUREBOX pbxMiscellaneousIncome EVENTS#####################################
        //event is raised when the control is clicked
        private void pbxMiscellaneousIncomeClick(object sender, EventArgs e)
        {
            ControlCashieringManagerMiscellaneousIncomeClick ev = OnMiscellaneousIncome;

            if (ev != null)
            {
                OnMiscellaneousIncome();
            }

            this.SetFocusOnSearchTextBoxQuery();
        }//-------------------------------------------

        //################################END PICTUREBOX pbxMiscellaneousIncome EVENTS#####################################

        //###################################CHECKEDLISTBOX cbxOfficeEmployer EVENTS############################################
        //event is raised when the selected index is changed
        private void cbxOfficeEmployerSelectedIndexChanged(object sender, EventArgs e)
        {
            ControlCashieringManagerCheckedListBoxSelectedIndexChanged ev = OnOfficeEmployerSelectedIndexChanged;

            if (ev != null)
            {
                OnOfficeEmployerSelectedIndexChanged();
            }

            this.SetFocusOnSearchTextBoxQuery();

            this.lblOfficeCount.Text = this.cbxOfficeEmployer.CheckedItems.Count.ToString();
        }//---------------------------
        //###################################END CHECKEDLISTBOX cbxOfficeEmployer EVENTS############################################

        //#########################################LINKBUTTON lnkOfficeEmployer EVENTS###########################################################
        //event is raised when the link is clicked
        private void lnkOfficeEmployerLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SetAllListAsChecked(this.cbxOfficeEmployer, this.lblOfficeCount, false);

            ControlCashieringManagerCheckedListBoxSelectedIndexChanged ev = OnOfficeEmployerSelectedIndexChanged;

            if (ev != null)
            {
                OnOfficeEmployerSelectedIndexChanged();
            }

            this.SetFocusOnSearchTextBoxQuery();
        }//-------------------------------
        //#########################################END LINKBUTTON lnkOfficeEmployer EVENTS###########################################################

        //###################################TEXTBOX txtQueryCashiering EVENTS##########################################
        //event is raised when the key is pressed
        private void txtQueryCashieringKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '*' && e.KeyChar != '\r' && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }//--------------------------

        //event is raised when the key is up
        private void txtQueryCashieringKeyUp(object sender, KeyEventArgs e)
        {
            _strSearch = ((TextBox)sender).Text;

            if (e.KeyCode == Keys.Enter)
            {
                _strSearch = this.txtQueryCashiering.Text;

                BaseServices.Control.KeyPressEnter ev = OnPressEnterQuery;

                if (ev != null)
                {
                    OnPressEnterQuery();
                }
            }
            else
            {
                KeyEventHandler ev = OnTextBoxKeyUpQuery;

                if (ev != null)
                {
                    OnTextBoxKeyUpQuery(sender, e);
                }
            }            
        }//-------------------------------
        //###################################END TEXTBOX txtQueryCashiering EVENTS##########################################

        //###################################CHECKEDLISTBOX cbxMemberClassification EVENTS############################################
        //event is raised when the selected index is changed
        //private void cbxMemberClassificationSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ControlCashieringManagerCheckedListBoxSelectedIndexChanged ev = OnMemberClassificationSelectedIndexChanged;

        //    if (ev != null)
        //    {
        //        OnMemberClassificationSelectedIndexChanged();
        //    }

        //    this.txtSearch.Focus();

        //    this.lblMemberClassificationCount.Text = this.cbxMemberClassification.CheckedItems.Count.ToString();
        //}//-----------------------------
        //###################################END CHECKEDLISTBOX cbxMemberClassification EVENTS############################################

        //#########################################LINKBUTTON lnkMemberClassificationSelectNone EVENTS#################################################
        //event is raised when the link is clicked
        //private void lnkMemberClassificationSelectNoneLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.SetAllListAsChecked(this.cbxMemberClassification, this.lblMemberClassificationCount, false);

        //    ControlCashieringManagerCheckedListBoxSelectedIndexChanged ev = OnMemberClassificationSelectedIndexChanged;

        //    if (ev != null)
        //    {
        //        OnMemberClassificationSelectedIndexChanged();
        //    }

        //    this.txtSearch.Focus();
        //}//-----------------------
        //#########################################END LINKBUTTON lnkMemberClassificationSelectNone EVENTS#################################################

        //###################################CHECKEDLISTBOX cbxMemberType EVENTS############################################
        //event is raised when the selected index is changed
        //private void cbxMemberTypeSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ControlCashieringManagerCheckedListBoxSelectedIndexChanged ev = OnMemberTypeSelectedIndexChanged;

        //    if (ev != null)
        //    {
        //        OnMemberTypeSelectedIndexChanged();
        //    }

        //    this.txtSearch.Focus();

        //    this.lblMemberTypeCount.Text = this.cbxMemberType.CheckedItems.Count.ToString();
        //}//-------------------------
        //###################################END CHECKEDLISTBOX cbxMemberType EVENTS############################################

        //#########################################LINKBUTTON lnkMemberTypeSelectNone EVENTS#################################################
        //event is raised when the link is clicked
        //private void lnkMemberTypeSelectNoneLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.SetAllListAsChecked(this.cbxMemberType, this.lblMemberTypeCount, false);

        //    ControlCashieringManagerCheckedListBoxSelectedIndexChanged ev = OnMemberTypeSelectedIndexChanged;

        //    if (ev != null)
        //    {
        //        OnMemberTypeSelectedIndexChanged();
        //    }

        //    this.txtSearch.Focus();

        //}//-------------------------
        //#########################################END LINKBUTTON lnkMemberTypeSelectNone EVENTS#################################################

        //#########################################TEXTBOX txtReceiptNo EVENTS###################################################
        //event is raised when the key is pressed
        private void txtReceiptNoKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }//--------------------------

        //event is raised when the control is validated
        private void txtReceiptNoValidated(object sender, EventArgs e)
        {
            Int32 result;

            if (Int32.TryParse(this.txtReceiptNo.Text, out result) && result < Int32.MaxValue)
            {
                this.txtReceiptNo.Text = result.ToString("000000");
            }
            else
            {
                this.txtReceiptNo.Text = (0).ToString("000000");
            }

            ControlCashieringManagerReceiptNoTextBoxValidated ev = OnReceiptNoTextBoxValidated;

            if (ev != null)
            {
                OnReceiptNoTextBoxValidated();
            }

            this.SetFocusOnSearchTextBoxQuery();
        } //----------------------------------
        //######################################END TEXTBOX txtReceiptNo EVENTS#################################################

        //########################################LINKLABEL lnkDecrement EVENTS#################################################
        //event is raised when the link is clicked
        private void lnkDecrementLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SetCurrentReceiptNo(false);

            ControlCashieringManagerDecrementLinkClicked ev = OnDecrementLinkClicked;

            if (ev != null)
            {
                OnDecrementLinkClicked();
            }

            this.SetFocusOnSearchTextBoxQuery();
        } //-----------------------------------------------
        //######################################END LINKLABEL lnkDecrement EVENTS###############################################

        //########################################LINKLABEL lnkIncrement EVENTS#################################################
        //event is raised when the linked is clicked
        private void lnkIncrementLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SetCurrentReceiptNo(true);

            ControlCashieringManagerIncrementLinkClicked ev = OnIncrementLinkClicked;

            if (ev != null)
            {
                OnIncrementLinkClicked();
            }

            this.SetFocusOnSearchTextBoxQuery();
        } //--------------------------------------------
        //######################################END LINKLABEL lnkIncrement EVENTS################################################

        //#########################################DATETIMEPICKER dtpReceiptDate EVENTS##############################################
        //event is raised when the value is changed
        private void dtpReceiptDateValueChanged(object sender, EventArgs e)
        {
            ControlCashieringManagerReceiptDateValueChanged ev = OnReceiptDateValueChanged;

            if (ev != null)
            {
                OnReceiptDateValueChanged(this.dtpReceiptDate.Value);
            }

            this.SetFocusOnSearchTextBoxQuery();
        } //-----------------------------------------
        //#########################################END DATETIMEPICKER dtpReceiptDate EVENTS##############################################

        //##########################################LINKBUTTON lnkResetQuery EVENTS############################################################
        //event is raised when the link is clicked
        private void lnkResetQueryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SetAllListAsChecked(this.cbxOfficeEmployer, this.lblOfficeCount, false);
            //this.SetAllListAsChecked(this.cbxMemberClassification, this.lblMemberClassificationCount, false);
            //this.SetAllListAsChecked(this.cbxMemberType, this.lblMemberTypeCount, false);

            //this.lblOfficeCount.Text = this.lblMemberClassificationCount.Text = this.lblMemberTypeCount.Text = 0.ToString();

            this.txtSearch.Clear();
            this.txtSearch.Focus();

            ControlCashieringManagerResetQueryLinkClicked ev = OnResetLinkClicked;

            if (ev != null)
            {
                OnResetLinkClicked();
            }

            this.SetFocusOnSearchTextBoxQuery();
        }//------------------------
        //##########################################END LINKBUTTON lnkResetQuery EVENTS############################################################

        //########################################TABCONTROL tabManager EVENTS#######################################
        //event is raised when the link is clicked
        private void tabManagerSelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtQueryCashiering.Focus();
        }//------------------------
        //########################################END TABCONTROL tabManager EVENTS#######################################

        //########################################LINKLABEL lnkCashReceiptsDetailed EVENTS#######################################
        //event is raised when the link is clicked
        private void lnkCashReceiptsDetailedLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ControlCashieringManagerCashReceiptsDetailedLinkClicked ev = OnCashReceiptsDetailedLinkClicked;

            if (ev != null)
            {
                OnCashReceiptsDetailedLinkClicked();
            }

            this.SetFocusOnSearchTextBox();
        } //---------------------------------------------------
        //#######################################END LINKLABEL lnkCashReceiptsDetailed EVENTS####################################

        //########################################LINKLABEL lnkCashReceiptsSummarized EVENTS######################################
        //event is raised when the link is clicked
        private void lnkCashReceiptsSummarizedLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ControlCashieringManagerCashReceiptsSummarizedLinkClicked ev = OnCashReceiptsSummarizedLinkClicked;

            if (ev != null)
            {
                OnCashReceiptsSummarizedLinkClicked();
            }

            this.SetFocusOnSearchTextBox();
        } //---------------------------------------    
        //######################################END LINKLABEL lnkCashReceiptsSummarized EVENTS####################################
        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure sets the current receipt as already issued
        public void SetCurrentReceiptNo(Boolean forIncrement)
        {
            Int32 result;

            if (Int32.TryParse(this.txtReceiptNo.Text, out result))
            {
                this.txtReceiptNo.Text = forIncrement ? (((result + 1) >= Int32.MaxValue) ? result : (result + 1)).ToString("000000") :
                    (((result - 1) < 0) ? result : (result - 1)).ToString("000000");
            }
            else
            {
                this.txtReceiptNo.Text = (0).ToString("000000");
            }
        } //-------------------------------------

        //this procedure checks all the list in the checkbox
        private void SetAllListAsChecked(CheckedListBox cbxBase, Label lblBase, Boolean isChecked)
        {
            for (Int32 i = 0; i < cbxBase.Items.Count; i++)
            {
                cbxBase.SetItemChecked(i, isChecked);
            }

            lblBase.Text = cbxBase.CheckedItems.Count.ToString();

        } //-----------------------------

        //this procedure sets the focus on search textbox
        public void SetFocusOnSearchTextBoxQuery()
        {
            this.txtQueryCashiering.Focus();
        } //----------------------------
        #endregion
    }
}
