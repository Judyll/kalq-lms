using System;
using System.Collections.Generic;
using System.Text;

namespace MemberServices
{
    internal partial class MemberInformationUpdate : MemberInformation
    {
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.PictureBox pbxServices;
        private System.Windows.Forms.TabPage tbmServices;
        private System.Windows.Forms.Label label44;
        protected System.Windows.Forms.PictureBox pbxHospitalization;
        protected System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tblSummary;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        protected System.Windows.Forms.ListView lsvMemberSummary;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.TabPage tblRegularLoan;
        private System.Windows.Forms.GroupBox groupBox17;
        protected System.Windows.Forms.DataGridView dgvCompletedLoan;
        private System.Windows.Forms.GroupBox groupBox8;
        protected System.Windows.Forms.DataGridView dgvRegularLoan;
        protected System.Windows.Forms.LinkLabel lnkLoanCalculator;
        protected System.Windows.Forms.LinkLabel lnkCreateRegularLoan;
        private System.Windows.Forms.TabPage tblShareCapital;
        protected System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.DataGridView dgvSharedCapital;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton rdbRetirement;
        private System.Windows.Forms.RadioButton rdbWithdrawal;
        private System.Windows.Forms.Button btnRecordSharedCapital;
        private System.Windows.Forms.GroupBox groupBox9;
        protected System.Windows.Forms.TextBox txtRemarksSharedCapital;
        private System.Windows.Forms.GroupBox groupBox7;
        protected System.Windows.Forms.TextBox txtAmountSharedCapital;
        private System.Windows.Forms.GroupBox groupBox6;
        protected System.Windows.Forms.Label lblEffictivityDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        protected System.Windows.Forms.ToolStripLabel lblShareCapitalCreditTotatContribution;
        protected System.Windows.Forms.LinkLabel lnkShareCapitalCreditCreate;
        protected System.Windows.Forms.DataGridView dgvShareRemittance;
        private System.Windows.Forms.TabPage tblMembersEquity;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripLabel lblMembersEquityTotal;
        protected System.Windows.Forms.LinkLabel lnkMembersEquityCreate;
        protected System.Windows.Forms.DataGridView dgvMembersEquity;
        private System.Windows.Forms.TabPage tblHospitalization;
        private System.Windows.Forms.Label lblRunningBalance;
        private System.Windows.Forms.Label label19;
        protected System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tblHospitalizationDebit;
        protected System.Windows.Forms.LinkLabel lnkCreateHospitalizationDebit;
        protected System.Windows.Forms.DataGridView dgvHospitalizationDebit;
        private System.Windows.Forms.TabPage tblHospitalizationInformation;
        protected System.Windows.Forms.DataGridView dgvHospitalization;
        private System.Windows.Forms.TabPage tblHospitalizationCredit;
        protected System.Windows.Forms.DataGridView dgvHospitalizationCredit;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox chkHospitalizationPrecluded;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.PictureBox pbxGenerateId;
        protected System.Windows.Forms.TextBox txtHospitalizationCertificateNo;
        private System.Windows.Forms.GroupBox groupBox12;
        protected System.Windows.Forms.TextBox txtHospitalizationMaximumAmount;
        private System.Windows.Forms.Button btnRecordHospitalization;
        private System.Windows.Forms.GroupBox groupBox13;
        protected System.Windows.Forms.TextBox txtHospitalizationRemarks;
        private System.Windows.Forms.GroupBox groupBox14;
        protected System.Windows.Forms.TextBox txtHospitalizationPremiumAmountDue;
        private System.Windows.Forms.GroupBox groupBox15;
        protected System.Windows.Forms.Label lblHospitalizationEffectivityDate;
        protected System.Windows.Forms.Button btnUpdate;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInformationUpdate));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Loan Charges/Additions Summary", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Loan Charges/Additions Details", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbxServices = new System.Windows.Forms.PictureBox();
            this.tbmServices = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tblSummary = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lsvMemberSummary = new System.Windows.Forms.ListView();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.tblRegularLoan = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvCompletedLoan = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvRegularLoan = new System.Windows.Forms.DataGridView();
            this.lnkLoanCalculator = new System.Windows.Forms.LinkLabel();
            this.lnkCreateRegularLoan = new System.Windows.Forms.LinkLabel();
            this.tblShareCapital = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSharedCapital = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rdbRetirement = new System.Windows.Forms.RadioButton();
            this.rdbWithdrawal = new System.Windows.Forms.RadioButton();
            this.btnRecordSharedCapital = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtRemarksSharedCapital = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtAmountSharedCapital = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblEffictivityDate = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblShareCapitalCreditTotatContribution = new System.Windows.Forms.ToolStripLabel();
            this.lnkShareCapitalCreditCreate = new System.Windows.Forms.LinkLabel();
            this.dgvShareRemittance = new System.Windows.Forms.DataGridView();
            this.tblMembersEquity = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblMembersEquityTotal = new System.Windows.Forms.ToolStripLabel();
            this.lnkMembersEquityCreate = new System.Windows.Forms.LinkLabel();
            this.dgvMembersEquity = new System.Windows.Forms.DataGridView();
            this.pbxHospitalization = new System.Windows.Forms.PictureBox();
            this.tblHospitalization = new System.Windows.Forms.TabPage();
            this.lblRunningBalance = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tblHospitalizationDebit = new System.Windows.Forms.TabPage();
            this.lnkCreateHospitalizationDebit = new System.Windows.Forms.LinkLabel();
            this.dgvHospitalizationDebit = new System.Windows.Forms.DataGridView();
            this.tblHospitalizationInformation = new System.Windows.Forms.TabPage();
            this.dgvHospitalization = new System.Windows.Forms.DataGridView();
            this.tblHospitalizationCredit = new System.Windows.Forms.TabPage();
            this.dgvHospitalizationCredit = new System.Windows.Forms.DataGridView();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chkHospitalizationPrecluded = new System.Windows.Forms.CheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pbxGenerateId = new System.Windows.Forms.PictureBox();
            this.txtHospitalizationCertificateNo = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtHospitalizationMaximumAmount = new System.Windows.Forms.TextBox();
            this.btnRecordHospitalization = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtHospitalizationRemarks = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtHospitalizationPremiumAmountDue = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.lblHospitalizationEffectivityDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeneficiaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalDocument)).BeginInit();
            this.panel3.SuspendLayout();
            this.tblPerson.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneralInformation)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).BeginInit();
            this.tabCntPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServices)).BeginInit();
            this.tbmServices.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tblSummary.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tblRegularLoan.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedLoan)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegularLoan)).BeginInit();
            this.tblShareCapital.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSharedCapital)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShareRemittance)).BeginInit();
            this.tblMembersEquity.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersEquity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHospitalization)).BeginInit();
            this.tblHospitalization.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tblHospitalizationDebit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizationDebit)).BeginInit();
            this.tblHospitalizationInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalization)).BeginInit();
            this.tblHospitalizationCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizationCredit)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGenerateId)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkCreateBeneficiary
            // 
            this.lnkCreateBeneficiary.Location = new System.Drawing.Point(678, 557);
            // 
            // lnkCreateReference
            // 
            this.lnkCreateReference.Location = new System.Drawing.Point(684, 557);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnUpdate);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxHospitalization);
            this.panel2.Controls.Add(this.pbxServices);
            this.panel2.Controls.SetChildIndex(this.pbxMemberInformation, 0);
            this.panel2.Controls.SetChildIndex(this.pbxGeneralInformation, 0);
            this.panel2.Controls.SetChildIndex(this.pbxBeneficiaries, 0);
            this.panel2.Controls.SetChildIndex(this.pbxReferences, 0);
            this.panel2.Controls.SetChildIndex(this.pbxPersonalDocument, 0);
            this.panel2.Controls.SetChildIndex(this.pbxServices, 0);
            this.panel2.Controls.SetChildIndex(this.pbxHospitalization, 0);
            // 
            // tabCntPerson
            // 
            this.tabCntPerson.Controls.Add(this.tbmServices);
            this.tabCntPerson.Controls.Add(this.tblHospitalization);
            this.tabCntPerson.Controls.SetChildIndex(this.tblHospitalization, 0);
            this.tabCntPerson.Controls.SetChildIndex(this.tbmServices, 0);
            this.tabCntPerson.Controls.SetChildIndex(this.tblPerson, 0);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(892, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(800, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnUpdate.TabIndex = 92;
            this.btnUpdate.Text = "  Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // pbxServices
            // 
            this.pbxServices.BackColor = System.Drawing.Color.Transparent;
            this.pbxServices.BackgroundImage = global::MemberServices.Properties.Resources.Services;
            this.pbxServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxServices.Location = new System.Drawing.Point(0, 141);
            this.pbxServices.Name = "pbxServices";
            this.pbxServices.Size = new System.Drawing.Size(161, 25);
            this.pbxServices.TabIndex = 10;
            this.pbxServices.TabStop = false;
            // 
            // tbmServices
            // 
            this.tbmServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbmServices.Controls.Add(this.label44);
            this.tbmServices.Controls.Add(this.tabControl1);
            this.tbmServices.Location = new System.Drawing.Point(4, 24);
            this.tbmServices.Name = "tbmServices";
            this.tbmServices.Padding = new System.Windows.Forms.Padding(3);
            this.tbmServices.Size = new System.Drawing.Size(812, 579);
            this.tbmServices.TabIndex = 5;
            this.tbmServices.Text = "Services";
            this.tbmServices.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Orange;
            this.label44.Location = new System.Drawing.Point(730, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(77, 20);
            this.label44.TabIndex = 51;
            this.label44.Text = "Services";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tblSummary);
            this.tabControl1.Controls.Add(this.tblRegularLoan);
            this.tabControl1.Controls.Add(this.tblShareCapital);
            this.tabControl1.Controls.Add(this.tblMembersEquity);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 14);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 555);
            this.tabControl1.TabIndex = 50;
            // 
            // tblSummary
            // 
            this.tblSummary.Controls.Add(this.toolStrip3);
            this.tblSummary.Controls.Add(this.lsvMemberSummary);
            this.tblSummary.Location = new System.Drawing.Point(4, 24);
            this.tblSummary.Name = "tblSummary";
            this.tblSummary.Size = new System.Drawing.Size(793, 527);
            this.tblSummary.TabIndex = 4;
            this.tblSummary.Text = "Summary";
            this.tblSummary.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(793, 25);
            this.toolStrip3.TabIndex = 44;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "toolStripButton1";
            // 
            // lsvMemberSummary
            // 
            this.lsvMemberSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.description,
            this.amount});
            this.lsvMemberSummary.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMemberSummary.FullRowSelect = true;
            listViewGroup1.Header = "Loan Charges/Additions Summary";
            listViewGroup1.Name = "grpSummary";
            listViewGroup2.Header = "Loan Charges/Additions Details";
            listViewGroup2.Name = "grpDetals";
            this.lsvMemberSummary.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lsvMemberSummary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvMemberSummary.HideSelection = false;
            this.lsvMemberSummary.Location = new System.Drawing.Point(0, 28);
            this.lsvMemberSummary.MultiSelect = false;
            this.lsvMemberSummary.Name = "lsvMemberSummary";
            this.lsvMemberSummary.ShowItemToolTips = true;
            this.lsvMemberSummary.Size = new System.Drawing.Size(793, 499);
            this.lsvMemberSummary.TabIndex = 2;
            this.lsvMemberSummary.UseCompatibleStateImageBehavior = false;
            this.lsvMemberSummary.View = System.Windows.Forms.View.Details;
            // 
            // description
            // 
            this.description.Text = "                                                                                 " +
                "               Description";
            this.description.Width = 638;
            // 
            // amount
            // 
            this.amount.Text = "Amount           ";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 125;
            // 
            // tblRegularLoan
            // 
            this.tblRegularLoan.Controls.Add(this.groupBox17);
            this.tblRegularLoan.Controls.Add(this.groupBox8);
            this.tblRegularLoan.Location = new System.Drawing.Point(4, 24);
            this.tblRegularLoan.Name = "tblRegularLoan";
            this.tblRegularLoan.Size = new System.Drawing.Size(793, 527);
            this.tblRegularLoan.TabIndex = 1;
            this.tblRegularLoan.Text = "Regular Loan Information";
            this.tblRegularLoan.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.dgvCompletedLoan);
            this.groupBox17.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox17.Location = new System.Drawing.Point(3, 270);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(787, 258);
            this.groupBox17.TabIndex = 43;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = " Completed Loan ";
            // 
            // dgvCompletedLoan
            // 
            this.dgvCompletedLoan.AllowUserToAddRows = false;
            this.dgvCompletedLoan.AllowUserToDeleteRows = false;
            this.dgvCompletedLoan.AllowUserToResizeColumns = false;
            this.dgvCompletedLoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCompletedLoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompletedLoan.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvCompletedLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompletedLoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompletedLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompletedLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompletedLoan.Location = new System.Drawing.Point(3, 19);
            this.dgvCompletedLoan.Name = "dgvCompletedLoan";
            this.dgvCompletedLoan.RowHeadersVisible = false;
            this.dgvCompletedLoan.RowHeadersWidth = 15;
            this.dgvCompletedLoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            this.dgvCompletedLoan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompletedLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompletedLoan.Size = new System.Drawing.Size(781, 236);
            this.dgvCompletedLoan.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvRegularLoan);
            this.groupBox8.Controls.Add(this.lnkLoanCalculator);
            this.groupBox8.Controls.Add(this.lnkCreateRegularLoan);
            this.groupBox8.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(787, 261);
            this.groupBox8.TabIndex = 42;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = " Active Loan ";
            // 
            // dgvRegularLoan
            // 
            this.dgvRegularLoan.AllowUserToAddRows = false;
            this.dgvRegularLoan.AllowUserToDeleteRows = false;
            this.dgvRegularLoan.AllowUserToResizeColumns = false;
            this.dgvRegularLoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRegularLoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegularLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvRegularLoan.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvRegularLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRegularLoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegularLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRegularLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegularLoan.Location = new System.Drawing.Point(6, 18);
            this.dgvRegularLoan.Name = "dgvRegularLoan";
            this.dgvRegularLoan.RowHeadersVisible = false;
            this.dgvRegularLoan.RowHeadersWidth = 15;
            this.dgvRegularLoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            this.dgvRegularLoan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRegularLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegularLoan.Size = new System.Drawing.Size(775, 221);
            this.dgvRegularLoan.TabIndex = 2;
            // 
            // lnkLoanCalculator
            // 
            this.lnkLoanCalculator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkLoanCalculator.AutoSize = true;
            this.lnkLoanCalculator.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLoanCalculator.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkLoanCalculator.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkLoanCalculator.Location = new System.Drawing.Point(6, 242);
            this.lnkLoanCalculator.Name = "lnkLoanCalculator";
            this.lnkLoanCalculator.Size = new System.Drawing.Size(110, 15);
            this.lnkLoanCalculator.TabIndex = 41;
            this.lnkLoanCalculator.TabStop = true;
            this.lnkLoanCalculator.Text = "[ Loan Calculator ]";
            this.lnkLoanCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkCreateRegularLoan
            // 
            this.lnkCreateRegularLoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkCreateRegularLoan.AutoSize = true;
            this.lnkCreateRegularLoan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateRegularLoan.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateRegularLoan.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateRegularLoan.Location = new System.Drawing.Point(644, 242);
            this.lnkCreateRegularLoan.Name = "lnkCreateRegularLoan";
            this.lnkCreateRegularLoan.Size = new System.Drawing.Size(137, 15);
            this.lnkCreateRegularLoan.TabIndex = 40;
            this.lnkCreateRegularLoan.TabStop = true;
            this.lnkCreateRegularLoan.Text = "[ Create Regular Loan ]";
            this.lnkCreateRegularLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblShareCapital
            // 
            this.tblShareCapital.Controls.Add(this.tabControl3);
            this.tblShareCapital.Location = new System.Drawing.Point(4, 24);
            this.tblShareCapital.Name = "tblShareCapital";
            this.tblShareCapital.Padding = new System.Windows.Forms.Padding(3);
            this.tblShareCapital.Size = new System.Drawing.Size(793, 527);
            this.tblShareCapital.TabIndex = 2;
            this.tblShareCapital.Text = "Share Capital Information";
            this.tblShareCapital.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(6, 14);
            this.tabControl3.Multiline = true;
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(781, 511);
            this.tabControl3.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSharedCapital);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(773, 483);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Share Capital Premiums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSharedCapital
            // 
            this.dgvSharedCapital.AllowUserToAddRows = false;
            this.dgvSharedCapital.AllowUserToDeleteRows = false;
            this.dgvSharedCapital.AllowUserToResizeColumns = false;
            this.dgvSharedCapital.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSharedCapital.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSharedCapital.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvSharedCapital.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSharedCapital.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSharedCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSharedCapital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSharedCapital.Location = new System.Drawing.Point(5, 218);
            this.dgvSharedCapital.Name = "dgvSharedCapital";
            this.dgvSharedCapital.RowHeadersVisible = false;
            this.dgvSharedCapital.RowHeadersWidth = 15;
            this.dgvSharedCapital.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender;
            this.dgvSharedCapital.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSharedCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSharedCapital.Size = new System.Drawing.Size(765, 262);
            this.dgvSharedCapital.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.btnRecordSharedCapital);
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(5, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(765, 205);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rdbRetirement);
            this.groupBox10.Controls.Add(this.rdbWithdrawal);
            this.groupBox10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.Navy;
            this.groupBox10.Location = new System.Drawing.Point(12, 136);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(319, 56);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = " Precluded ";
            // 
            // rdbRetirement
            // 
            this.rdbRetirement.AutoSize = true;
            this.rdbRetirement.Location = new System.Drawing.Point(210, 24);
            this.rdbRetirement.Name = "rdbRetirement";
            this.rdbRetirement.Size = new System.Drawing.Size(81, 18);
            this.rdbRetirement.TabIndex = 1;
            this.rdbRetirement.TabStop = true;
            this.rdbRetirement.Text = "Retirement";
            this.rdbRetirement.UseVisualStyleBackColor = true;
            // 
            // rdbWithdrawal
            // 
            this.rdbWithdrawal.AutoSize = true;
            this.rdbWithdrawal.Location = new System.Drawing.Point(27, 24);
            this.rdbWithdrawal.Name = "rdbWithdrawal";
            this.rdbWithdrawal.Size = new System.Drawing.Size(83, 18);
            this.rdbWithdrawal.TabIndex = 0;
            this.rdbWithdrawal.TabStop = true;
            this.rdbWithdrawal.Text = "Withdrawal";
            this.rdbWithdrawal.UseVisualStyleBackColor = true;
            // 
            // btnRecordSharedCapital
            // 
            this.btnRecordSharedCapital.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecordSharedCapital.BackgroundImage")));
            this.btnRecordSharedCapital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecordSharedCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordSharedCapital.Location = new System.Drawing.Point(670, 170);
            this.btnRecordSharedCapital.Name = "btnRecordSharedCapital";
            this.btnRecordSharedCapital.Size = new System.Drawing.Size(86, 23);
            this.btnRecordSharedCapital.TabIndex = 4;
            this.btnRecordSharedCapital.Text = "  Record";
            this.btnRecordSharedCapital.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecordSharedCapital.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtRemarksSharedCapital);
            this.groupBox9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Navy;
            this.groupBox9.Location = new System.Drawing.Point(344, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(319, 175);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = " Remarks ";
            // 
            // txtRemarksSharedCapital
            // 
            this.txtRemarksSharedCapital.BackColor = System.Drawing.Color.White;
            this.txtRemarksSharedCapital.Location = new System.Drawing.Point(23, 21);
            this.txtRemarksSharedCapital.MaxLength = 10000;
            this.txtRemarksSharedCapital.Multiline = true;
            this.txtRemarksSharedCapital.Name = "txtRemarksSharedCapital";
            this.txtRemarksSharedCapital.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarksSharedCapital.Size = new System.Drawing.Size(273, 140);
            this.txtRemarksSharedCapital.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtAmountSharedCapital);
            this.groupBox7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Navy;
            this.groupBox7.Location = new System.Drawing.Point(12, 74);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(319, 56);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = " Premium Amount ";
            // 
            // txtAmountSharedCapital
            // 
            this.txtAmountSharedCapital.BackColor = System.Drawing.Color.White;
            this.txtAmountSharedCapital.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountSharedCapital.ForeColor = System.Drawing.Color.Red;
            this.txtAmountSharedCapital.Location = new System.Drawing.Point(27, 20);
            this.txtAmountSharedCapital.MaxLength = 100;
            this.txtAmountSharedCapital.Name = "txtAmountSharedCapital";
            this.txtAmountSharedCapital.Size = new System.Drawing.Size(264, 27);
            this.txtAmountSharedCapital.TabIndex = 0;
            this.txtAmountSharedCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblEffictivityDate);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Navy;
            this.groupBox6.Location = new System.Drawing.Point(12, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 51);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " Effectivity Date ";
            // 
            // lblEffictivityDate
            // 
            this.lblEffictivityDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffictivityDate.ForeColor = System.Drawing.Color.Black;
            this.lblEffictivityDate.Location = new System.Drawing.Point(24, 24);
            this.lblEffictivityDate.Name = "lblEffictivityDate";
            this.lblEffictivityDate.Size = new System.Drawing.Size(267, 15);
            this.lblEffictivityDate.TabIndex = 0;
            this.lblEffictivityDate.Text = "-";
            this.lblEffictivityDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.lnkShareCapitalCreditCreate);
            this.tabPage2.Controls.Add(this.dgvShareRemittance);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 483);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Share Capital Credits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblShareCapitalCreditTotatContribution});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(767, 25);
            this.toolStrip2.TabIndex = 43;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblShareCapitalCreditTotatContribution
            // 
            this.lblShareCapitalCreditTotatContribution.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShareCapitalCreditTotatContribution.ForeColor = System.Drawing.Color.Sienna;
            this.lblShareCapitalCreditTotatContribution.Name = "lblShareCapitalCreditTotatContribution";
            this.lblShareCapitalCreditTotatContribution.Size = new System.Drawing.Size(10, 22);
            this.lblShareCapitalCreditTotatContribution.Text = " ";
            // 
            // lnkShareCapitalCreditCreate
            // 
            this.lnkShareCapitalCreditCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkShareCapitalCreditCreate.AutoSize = true;
            this.lnkShareCapitalCreditCreate.Enabled = false;
            this.lnkShareCapitalCreditCreate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShareCapitalCreditCreate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkShareCapitalCreditCreate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkShareCapitalCreditCreate.Location = new System.Drawing.Point(595, 462);
            this.lnkShareCapitalCreditCreate.Name = "lnkShareCapitalCreditCreate";
            this.lnkShareCapitalCreditCreate.Size = new System.Drawing.Size(175, 15);
            this.lnkShareCapitalCreditCreate.TabIndex = 42;
            this.lnkShareCapitalCreditCreate.TabStop = true;
            this.lnkShareCapitalCreditCreate.Text = "[ Create Share Capital Credit ]";
            this.lnkShareCapitalCreditCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvShareRemittance
            // 
            this.dgvShareRemittance.AllowUserToAddRows = false;
            this.dgvShareRemittance.AllowUserToDeleteRows = false;
            this.dgvShareRemittance.AllowUserToResizeColumns = false;
            this.dgvShareRemittance.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvShareRemittance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvShareRemittance.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvShareRemittance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShareRemittance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShareRemittance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvShareRemittance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShareRemittance.Location = new System.Drawing.Point(3, 31);
            this.dgvShareRemittance.Name = "dgvShareRemittance";
            this.dgvShareRemittance.RowHeadersVisible = false;
            this.dgvShareRemittance.RowHeadersWidth = 15;
            this.dgvShareRemittance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender;
            this.dgvShareRemittance.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvShareRemittance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShareRemittance.Size = new System.Drawing.Size(767, 428);
            this.dgvShareRemittance.TabIndex = 4;
            // 
            // tblMembersEquity
            // 
            this.tblMembersEquity.Controls.Add(this.toolStrip1);
            this.tblMembersEquity.Controls.Add(this.lnkMembersEquityCreate);
            this.tblMembersEquity.Controls.Add(this.dgvMembersEquity);
            this.tblMembersEquity.Location = new System.Drawing.Point(4, 24);
            this.tblMembersEquity.Name = "tblMembersEquity";
            this.tblMembersEquity.Size = new System.Drawing.Size(793, 527);
            this.tblMembersEquity.TabIndex = 5;
            this.tblMembersEquity.Text = "Member\'s Equity Information";
            this.tblMembersEquity.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMembersEquityTotal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblMembersEquityTotal
            // 
            this.lblMembersEquityTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersEquityTotal.ForeColor = System.Drawing.Color.Sienna;
            this.lblMembersEquityTotal.Name = "lblMembersEquityTotal";
            this.lblMembersEquityTotal.Size = new System.Drawing.Size(10, 22);
            this.lblMembersEquityTotal.Text = " ";
            // 
            // lnkMembersEquityCreate
            // 
            this.lnkMembersEquityCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkMembersEquityCreate.AutoSize = true;
            this.lnkMembersEquityCreate.Enabled = false;
            this.lnkMembersEquityCreate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMembersEquityCreate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkMembersEquityCreate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMembersEquityCreate.Location = new System.Drawing.Point(634, 502);
            this.lnkMembersEquityCreate.Name = "lnkMembersEquityCreate";
            this.lnkMembersEquityCreate.Size = new System.Drawing.Size(156, 15);
            this.lnkMembersEquityCreate.TabIndex = 45;
            this.lnkMembersEquityCreate.TabStop = true;
            this.lnkMembersEquityCreate.Text = "[ Create Member\'s Equity ]";
            this.lnkMembersEquityCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvMembersEquity
            // 
            this.dgvMembersEquity.AllowUserToAddRows = false;
            this.dgvMembersEquity.AllowUserToDeleteRows = false;
            this.dgvMembersEquity.AllowUserToResizeColumns = false;
            this.dgvMembersEquity.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMembersEquity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMembersEquity.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvMembersEquity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMembersEquity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembersEquity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMembersEquity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersEquity.Location = new System.Drawing.Point(3, 28);
            this.dgvMembersEquity.Name = "dgvMembersEquity";
            this.dgvMembersEquity.RowHeadersVisible = false;
            this.dgvMembersEquity.RowHeadersWidth = 15;
            this.dgvMembersEquity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Lavender;
            this.dgvMembersEquity.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMembersEquity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembersEquity.Size = new System.Drawing.Size(787, 470);
            this.dgvMembersEquity.TabIndex = 44;
            // 
            // pbxHospitalization
            // 
            this.pbxHospitalization.BackColor = System.Drawing.Color.Transparent;
            this.pbxHospitalization.BackgroundImage = global::MemberServices.Properties.Resources.lmsHospitalization;
            this.pbxHospitalization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHospitalization.Location = new System.Drawing.Point(0, 169);
            this.pbxHospitalization.Name = "pbxHospitalization";
            this.pbxHospitalization.Size = new System.Drawing.Size(161, 25);
            this.pbxHospitalization.TabIndex = 11;
            this.pbxHospitalization.TabStop = false;
            // 
            // tblHospitalization
            // 
            this.tblHospitalization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblHospitalization.Controls.Add(this.lblRunningBalance);
            this.tblHospitalization.Controls.Add(this.label19);
            this.tblHospitalization.Controls.Add(this.tabControl2);
            this.tblHospitalization.Controls.Add(this.groupBox11);
            this.tblHospitalization.Location = new System.Drawing.Point(4, 24);
            this.tblHospitalization.Name = "tblHospitalization";
            this.tblHospitalization.Size = new System.Drawing.Size(812, 579);
            this.tblHospitalization.TabIndex = 6;
            this.tblHospitalization.Text = "Hospitalization Information";
            this.tblHospitalization.UseVisualStyleBackColor = true;
            // 
            // lblRunningBalance
            // 
            this.lblRunningBalance.AutoSize = true;
            this.lblRunningBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningBalance.ForeColor = System.Drawing.Color.Red;
            this.lblRunningBalance.Location = new System.Drawing.Point(486, 7);
            this.lblRunningBalance.Name = "lblRunningBalance";
            this.lblRunningBalance.Size = new System.Drawing.Size(20, 25);
            this.lblRunningBalance.TabIndex = 54;
            this.lblRunningBalance.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(5, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(486, 25);
            this.label19.TabIndex = 53;
            this.label19.Text = "Hospitalization running balance for the year: ";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tblHospitalizationDebit);
            this.tabControl2.Controls.Add(this.tblHospitalizationInformation);
            this.tabControl2.Controls.Add(this.tblHospitalizationCredit);
            this.tabControl2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(6, 252);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(781, 276);
            this.tabControl2.TabIndex = 52;
            // 
            // tblHospitalizationDebit
            // 
            this.tblHospitalizationDebit.Controls.Add(this.lnkCreateHospitalizationDebit);
            this.tblHospitalizationDebit.Controls.Add(this.dgvHospitalizationDebit);
            this.tblHospitalizationDebit.Location = new System.Drawing.Point(4, 24);
            this.tblHospitalizationDebit.Name = "tblHospitalizationDebit";
            this.tblHospitalizationDebit.Size = new System.Drawing.Size(773, 248);
            this.tblHospitalizationDebit.TabIndex = 2;
            this.tblHospitalizationDebit.Text = "Hospitalization Debits";
            this.tblHospitalizationDebit.UseVisualStyleBackColor = true;
            // 
            // lnkCreateHospitalizationDebit
            // 
            this.lnkCreateHospitalizationDebit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkCreateHospitalizationDebit.AutoSize = true;
            this.lnkCreateHospitalizationDebit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateHospitalizationDebit.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateHospitalizationDebit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateHospitalizationDebit.Location = new System.Drawing.Point(590, 228);
            this.lnkCreateHospitalizationDebit.Name = "lnkCreateHospitalizationDebit";
            this.lnkCreateHospitalizationDebit.Size = new System.Drawing.Size(177, 15);
            this.lnkCreateHospitalizationDebit.TabIndex = 41;
            this.lnkCreateHospitalizationDebit.TabStop = true;
            this.lnkCreateHospitalizationDebit.Text = "[ Create Hospitalization Debit ]";
            this.lnkCreateHospitalizationDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvHospitalizationDebit
            // 
            this.dgvHospitalizationDebit.AllowUserToAddRows = false;
            this.dgvHospitalizationDebit.AllowUserToDeleteRows = false;
            this.dgvHospitalizationDebit.AllowUserToResizeColumns = false;
            this.dgvHospitalizationDebit.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHospitalizationDebit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvHospitalizationDebit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvHospitalizationDebit.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvHospitalizationDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHospitalizationDebit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospitalizationDebit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvHospitalizationDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalizationDebit.Location = new System.Drawing.Point(8, 3);
            this.dgvHospitalizationDebit.Name = "dgvHospitalizationDebit";
            this.dgvHospitalizationDebit.RowHeadersVisible = false;
            this.dgvHospitalizationDebit.RowHeadersWidth = 15;
            this.dgvHospitalizationDebit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Lavender;
            this.dgvHospitalizationDebit.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvHospitalizationDebit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitalizationDebit.Size = new System.Drawing.Size(759, 223);
            this.dgvHospitalizationDebit.TabIndex = 5;
            // 
            // tblHospitalizationInformation
            // 
            this.tblHospitalizationInformation.Controls.Add(this.dgvHospitalization);
            this.tblHospitalizationInformation.Location = new System.Drawing.Point(4, 24);
            this.tblHospitalizationInformation.Name = "tblHospitalizationInformation";
            this.tblHospitalizationInformation.Size = new System.Drawing.Size(773, 248);
            this.tblHospitalizationInformation.TabIndex = 1;
            this.tblHospitalizationInformation.Text = "Hospitalization Premiums";
            this.tblHospitalizationInformation.UseVisualStyleBackColor = true;
            // 
            // dgvHospitalization
            // 
            this.dgvHospitalization.AllowUserToAddRows = false;
            this.dgvHospitalization.AllowUserToDeleteRows = false;
            this.dgvHospitalization.AllowUserToResizeColumns = false;
            this.dgvHospitalization.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHospitalization.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvHospitalization.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvHospitalization.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvHospitalization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHospitalization.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospitalization.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvHospitalization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalization.Location = new System.Drawing.Point(8, 3);
            this.dgvHospitalization.Name = "dgvHospitalization";
            this.dgvHospitalization.RowHeadersVisible = false;
            this.dgvHospitalization.RowHeadersWidth = 15;
            this.dgvHospitalization.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Lavender;
            this.dgvHospitalization.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvHospitalization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitalization.Size = new System.Drawing.Size(759, 243);
            this.dgvHospitalization.TabIndex = 4;
            // 
            // tblHospitalizationCredit
            // 
            this.tblHospitalizationCredit.Controls.Add(this.dgvHospitalizationCredit);
            this.tblHospitalizationCredit.Location = new System.Drawing.Point(4, 24);
            this.tblHospitalizationCredit.Name = "tblHospitalizationCredit";
            this.tblHospitalizationCredit.Size = new System.Drawing.Size(773, 248);
            this.tblHospitalizationCredit.TabIndex = 3;
            this.tblHospitalizationCredit.Text = "Hospitalization Credits";
            this.tblHospitalizationCredit.UseVisualStyleBackColor = true;
            // 
            // dgvHospitalizationCredit
            // 
            this.dgvHospitalizationCredit.AllowUserToAddRows = false;
            this.dgvHospitalizationCredit.AllowUserToDeleteRows = false;
            this.dgvHospitalizationCredit.AllowUserToResizeColumns = false;
            this.dgvHospitalizationCredit.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHospitalizationCredit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvHospitalizationCredit.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvHospitalizationCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHospitalizationCredit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospitalizationCredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvHospitalizationCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalizationCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHospitalizationCredit.Location = new System.Drawing.Point(0, 0);
            this.dgvHospitalizationCredit.Name = "dgvHospitalizationCredit";
            this.dgvHospitalizationCredit.RowHeadersVisible = false;
            this.dgvHospitalizationCredit.RowHeadersWidth = 15;
            this.dgvHospitalizationCredit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Lavender;
            this.dgvHospitalizationCredit.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvHospitalizationCredit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitalizationCredit.Size = new System.Drawing.Size(773, 248);
            this.dgvHospitalizationCredit.TabIndex = 5;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.chkHospitalizationPrecluded);
            this.groupBox11.Controls.Add(this.groupBox16);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.btnRecordHospitalization);
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Controls.Add(this.groupBox14);
            this.groupBox11.Controls.Add(this.groupBox15);
            this.groupBox11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.Navy;
            this.groupBox11.Location = new System.Drawing.Point(6, 35);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(781, 211);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            // 
            // chkHospitalizationPrecluded
            // 
            this.chkHospitalizationPrecluded.AutoSize = true;
            this.chkHospitalizationPrecluded.Location = new System.Drawing.Point(685, 91);
            this.chkHospitalizationPrecluded.Name = "chkHospitalizationPrecluded";
            this.chkHospitalizationPrecluded.Size = new System.Drawing.Size(86, 18);
            this.chkHospitalizationPrecluded.TabIndex = 5;
            this.chkHospitalizationPrecluded.Text = "? Precluded ";
            this.chkHospitalizationPrecluded.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.pbxGenerateId);
            this.groupBox16.Controls.Add(this.txtHospitalizationCertificateNo);
            this.groupBox16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.ForeColor = System.Drawing.Color.Navy;
            this.groupBox16.Location = new System.Drawing.Point(353, 19);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(319, 51);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = " Certificate No. ";
            // 
            // pbxGenerateId
            // 
            this.pbxGenerateId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGenerateId.Image = ((System.Drawing.Image)(resources.GetObject("pbxGenerateId.Image")));
            this.pbxGenerateId.Location = new System.Drawing.Point(285, 18);
            this.pbxGenerateId.Name = "pbxGenerateId";
            this.pbxGenerateId.Size = new System.Drawing.Size(24, 24);
            this.pbxGenerateId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxGenerateId.TabIndex = 1;
            this.pbxGenerateId.TabStop = false;
            // 
            // txtHospitalizationCertificateNo
            // 
            this.txtHospitalizationCertificateNo.BackColor = System.Drawing.Color.White;
            this.txtHospitalizationCertificateNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalizationCertificateNo.Location = new System.Drawing.Point(23, 19);
            this.txtHospitalizationCertificateNo.MaxLength = 50;
            this.txtHospitalizationCertificateNo.Name = "txtHospitalizationCertificateNo";
            this.txtHospitalizationCertificateNo.Size = new System.Drawing.Size(251, 23);
            this.txtHospitalizationCertificateNo.TabIndex = 0;
            this.txtHospitalizationCertificateNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtHospitalizationMaximumAmount);
            this.groupBox12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.Navy;
            this.groupBox12.Location = new System.Drawing.Point(12, 138);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(319, 56);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = " Maximum Amount ";
            // 
            // txtHospitalizationMaximumAmount
            // 
            this.txtHospitalizationMaximumAmount.BackColor = System.Drawing.Color.White;
            this.txtHospitalizationMaximumAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalizationMaximumAmount.ForeColor = System.Drawing.Color.Red;
            this.txtHospitalizationMaximumAmount.Location = new System.Drawing.Point(27, 19);
            this.txtHospitalizationMaximumAmount.MaxLength = 100;
            this.txtHospitalizationMaximumAmount.Name = "txtHospitalizationMaximumAmount";
            this.txtHospitalizationMaximumAmount.Size = new System.Drawing.Size(264, 27);
            this.txtHospitalizationMaximumAmount.TabIndex = 0;
            this.txtHospitalizationMaximumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRecordHospitalization
            // 
            this.btnRecordHospitalization.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecordHospitalization.BackgroundImage")));
            this.btnRecordHospitalization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecordHospitalization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordHospitalization.Location = new System.Drawing.Point(685, 171);
            this.btnRecordHospitalization.Name = "btnRecordHospitalization";
            this.btnRecordHospitalization.Size = new System.Drawing.Size(86, 23);
            this.btnRecordHospitalization.TabIndex = 6;
            this.btnRecordHospitalization.Text = "  Record";
            this.btnRecordHospitalization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecordHospitalization.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtHospitalizationRemarks);
            this.groupBox13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.ForeColor = System.Drawing.Color.Navy;
            this.groupBox13.Location = new System.Drawing.Point(353, 78);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(319, 116);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = " Remarks ";
            // 
            // txtHospitalizationRemarks
            // 
            this.txtHospitalizationRemarks.BackColor = System.Drawing.Color.White;
            this.txtHospitalizationRemarks.Location = new System.Drawing.Point(23, 21);
            this.txtHospitalizationRemarks.MaxLength = 10000;
            this.txtHospitalizationRemarks.Multiline = true;
            this.txtHospitalizationRemarks.Name = "txtHospitalizationRemarks";
            this.txtHospitalizationRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHospitalizationRemarks.Size = new System.Drawing.Size(273, 82);
            this.txtHospitalizationRemarks.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtHospitalizationPremiumAmountDue);
            this.groupBox14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.ForeColor = System.Drawing.Color.Navy;
            this.groupBox14.Location = new System.Drawing.Point(12, 76);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(319, 56);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = " Premium Amount Due ";
            // 
            // txtHospitalizationPremiumAmountDue
            // 
            this.txtHospitalizationPremiumAmountDue.BackColor = System.Drawing.Color.White;
            this.txtHospitalizationPremiumAmountDue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalizationPremiumAmountDue.ForeColor = System.Drawing.Color.Red;
            this.txtHospitalizationPremiumAmountDue.Location = new System.Drawing.Point(27, 18);
            this.txtHospitalizationPremiumAmountDue.MaxLength = 100;
            this.txtHospitalizationPremiumAmountDue.Name = "txtHospitalizationPremiumAmountDue";
            this.txtHospitalizationPremiumAmountDue.Size = new System.Drawing.Size(264, 27);
            this.txtHospitalizationPremiumAmountDue.TabIndex = 0;
            this.txtHospitalizationPremiumAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.lblHospitalizationEffectivityDate);
            this.groupBox15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.ForeColor = System.Drawing.Color.Navy;
            this.groupBox15.Location = new System.Drawing.Point(12, 19);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(319, 51);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = " Effectivity Date ";
            // 
            // lblHospitalizationEffectivityDate
            // 
            this.lblHospitalizationEffectivityDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalizationEffectivityDate.ForeColor = System.Drawing.Color.Black;
            this.lblHospitalizationEffectivityDate.Location = new System.Drawing.Point(24, 24);
            this.lblHospitalizationEffectivityDate.Name = "lblHospitalizationEffectivityDate";
            this.lblHospitalizationEffectivityDate.Size = new System.Drawing.Size(267, 15);
            this.lblHospitalizationEffectivityDate.TabIndex = 0;
            this.lblHospitalizationEffectivityDate.Text = "-";
            this.lblHospitalizationEffectivityDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberInformationUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(994, 712);
            this.Name = "MemberInformationUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeneficiaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalDocument)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tblPerson.ResumeLayout(false);
            this.tblPerson.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneralInformation)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).EndInit();
            this.tabCntPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServices)).EndInit();
            this.tbmServices.ResumeLayout(false);
            this.tbmServices.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tblSummary.ResumeLayout(false);
            this.tblSummary.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tblRegularLoan.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedLoan)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegularLoan)).EndInit();
            this.tblShareCapital.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSharedCapital)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShareRemittance)).EndInit();
            this.tblMembersEquity.ResumeLayout(false);
            this.tblMembersEquity.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersEquity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHospitalization)).EndInit();
            this.tblHospitalization.ResumeLayout(false);
            this.tblHospitalization.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tblHospitalizationDebit.ResumeLayout(false);
            this.tblHospitalizationDebit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizationDebit)).EndInit();
            this.tblHospitalizationInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalization)).EndInit();
            this.tblHospitalizationCredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizationCredit)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGenerateId)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

             
      

        
    }
}
