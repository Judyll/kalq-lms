using System;
using System.Collections.Generic;
using System.Text;

namespace MemberServices
{
    internal partial class MemberInformation : BaseServices.PersonInformationWithBeneficiaryReference
    {
        protected System.Windows.Forms.Label label22;
        protected System.Windows.Forms.Label lblSalaryIncome;
        protected System.Windows.Forms.Label label20;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tblMemberInformation;
        private System.Windows.Forms.Label lblMemberInfo;
        protected System.Windows.Forms.PictureBox pbxMemberInformation;
        protected System.Windows.Forms.TabControl tabMemberInfo;
        private System.Windows.Forms.TabPage tblMember;
        protected System.Windows.Forms.Label label41;
        protected System.Windows.Forms.TextBox txtMemberId;
        protected System.Windows.Forms.ComboBox cboMemberType;
        protected System.Windows.Forms.Label label40;
        protected System.Windows.Forms.Label label28;
        protected System.Windows.Forms.TextBox txtOtherMemberInformation;
        protected System.Windows.Forms.TextBox txtOtherCooperativeMembership;
        protected System.Windows.Forms.TextBox txtCertificationInformation;
        protected System.Windows.Forms.Label lblMemberStatus;
        protected System.Windows.Forms.Label label34;
        protected System.Windows.Forms.Label label32;
        protected System.Windows.Forms.ComboBox cboMemberClassification;
        protected System.Windows.Forms.Label label29;
        protected System.Windows.Forms.LinkLabel lnkMembershipDate;
        protected System.Windows.Forms.TextBox txtMembershipDate;
        protected System.Windows.Forms.Label label26;
        protected System.Windows.Forms.Label label27;
        protected System.Windows.Forms.TextBox txtReasonOfMembership;
        private System.Windows.Forms.TabPage tblCollateral;
        protected System.Windows.Forms.DataGridView dgvCollateral;
        protected System.Windows.Forms.LinkLabel lnkCreateCollateral;
        private System.Windows.Forms.TabPage tblOtherCreditor;
        protected System.Windows.Forms.DataGridView dgvOtherCreditor;
        protected System.Windows.Forms.LinkLabel lnkCreateOtherCreditor;
        protected System.Windows.Forms.Label lblStatus;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSalaryIncome = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tblMemberInformation = new System.Windows.Forms.TabPage();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.tabMemberInfo = new System.Windows.Forms.TabControl();
            this.tblMember = new System.Windows.Forms.TabPage();
            this.label41 = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.cboMemberType = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtOtherMemberInformation = new System.Windows.Forms.TextBox();
            this.txtOtherCooperativeMembership = new System.Windows.Forms.TextBox();
            this.txtCertificationInformation = new System.Windows.Forms.TextBox();
            this.lblMemberStatus = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.cboMemberClassification = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.lnkMembershipDate = new System.Windows.Forms.LinkLabel();
            this.txtMembershipDate = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtReasonOfMembership = new System.Windows.Forms.TextBox();
            this.tblCollateral = new System.Windows.Forms.TabPage();
            this.dgvCollateral = new System.Windows.Forms.DataGridView();
            this.lnkCreateCollateral = new System.Windows.Forms.LinkLabel();
            this.tblOtherCreditor = new System.Windows.Forms.TabPage();
            this.dgvOtherCreditor = new System.Windows.Forms.DataGridView();
            this.lnkCreateOtherCreditor = new System.Windows.Forms.LinkLabel();
            this.pbxMemberInformation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeneficiaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).BeginInit();
            this.tblPerson.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneralInformation)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).BeginInit();
            this.tabCntPerson.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tblMemberInformation.SuspendLayout();
            this.tabMemberInfo.SuspendLayout();
            this.tblMember.SuspendLayout();
            this.tblCollateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollateral)).BeginInit();
            this.tblOtherCreditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherCreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxReferences
            // 
            this.pbxReferences.Location = new System.Drawing.Point(0, 57);
            // 
            // pbxBeneficiaries
            // 
            this.pbxBeneficiaries.Location = new System.Drawing.Point(0, 29);
            // 
            // pbxPersonalDocument
            // 
            this.pbxPersonalDocument.Location = new System.Drawing.Point(0, 85);
            // 
            // tblPerson
            // 
            this.tblPerson.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxMemberInformation);
            this.panel2.Controls.SetChildIndex(this.pbxGeneralInformation, 0);
            this.panel2.Controls.SetChildIndex(this.pbxBeneficiaries, 0);
            this.panel2.Controls.SetChildIndex(this.pbxReferences, 0);
            this.panel2.Controls.SetChildIndex(this.pbxPersonalDocument, 0);
            this.panel2.Controls.SetChildIndex(this.pbxMemberInformation, 0);
            // 
            // tabCntPerson
            // 
            this.tabCntPerson.Controls.Add(this.tblMemberInformation);
            this.tabCntPerson.Controls.SetChildIndex(this.tblMemberInformation, 0);
            this.tabCntPerson.Controls.SetChildIndex(this.tblPerson, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblSalaryIncome);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 364);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " EMPLOYMENT INFORMATION ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(130, 50);
            this.textBox1.MaxLength = 500;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 44;
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(382, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(344, 23);
            this.lblStatus.TabIndex = 43;
            this.lblStatus.Text = "ACTIVE";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalaryIncome
            // 
            this.lblSalaryIncome.AutoSize = true;
            this.lblSalaryIncome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryIncome.ForeColor = System.Drawing.Color.Black;
            this.lblSalaryIncome.Location = new System.Drawing.Point(30, 108);
            this.lblSalaryIncome.Name = "lblSalaryIncome";
            this.lblSalaryIncome.Size = new System.Drawing.Size(95, 15);
            this.lblSalaryIncome.TabIndex = 35;
            this.lblSalaryIncome.Text = "Salary / Income:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(3, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 15);
            this.label22.TabIndex = 39;
            this.label22.Text = "Appointment Status:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(53, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 15);
            this.label20.TabIndex = 32;
            this.label20.Text = "Occupation:";
            // 
            // tblMemberInformation
            // 
            this.tblMemberInformation.BackColor = System.Drawing.Color.GhostWhite;
            this.tblMemberInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblMemberInformation.Controls.Add(this.lblMemberInfo);
            this.tblMemberInformation.Controls.Add(this.tabMemberInfo);
            this.tblMemberInformation.Location = new System.Drawing.Point(4, 24);
            this.tblMemberInformation.Name = "tblMemberInformation";
            this.tblMemberInformation.Size = new System.Drawing.Size(812, 579);
            this.tblMemberInformation.TabIndex = 4;
            this.tblMemberInformation.Text = "Member Information";
            this.tblMemberInformation.UseVisualStyleBackColor = true;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.ForeColor = System.Drawing.Color.Orange;
            this.lblMemberInfo.Location = new System.Drawing.Point(637, 6);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(170, 20);
            this.lblMemberInfo.TabIndex = 87;
            this.lblMemberInfo.Text = "Member Information";
            // 
            // tabMemberInfo
            // 
            this.tabMemberInfo.Controls.Add(this.tblMember);
            this.tabMemberInfo.Controls.Add(this.tblCollateral);
            this.tabMemberInfo.Controls.Add(this.tblOtherCreditor);
            this.tabMemberInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMemberInfo.Location = new System.Drawing.Point(3, 11);
            this.tabMemberInfo.Multiline = true;
            this.tabMemberInfo.Name = "tabMemberInfo";
            this.tabMemberInfo.SelectedIndex = 0;
            this.tabMemberInfo.Size = new System.Drawing.Size(802, 561);
            this.tabMemberInfo.TabIndex = 93;
            // 
            // tblMember
            // 
            this.tblMember.Controls.Add(this.txtMembershipDate);
            this.tblMember.Controls.Add(this.lnkMembershipDate);
            this.tblMember.Controls.Add(this.label41);
            this.tblMember.Controls.Add(this.label28);
            this.tblMember.Controls.Add(this.txtMemberId);
            this.tblMember.Controls.Add(this.cboMemberType);
            this.tblMember.Controls.Add(this.label40);
            this.tblMember.Controls.Add(this.txtOtherMemberInformation);
            this.tblMember.Controls.Add(this.txtOtherCooperativeMembership);
            this.tblMember.Controls.Add(this.txtCertificationInformation);
            this.tblMember.Controls.Add(this.lblMemberStatus);
            this.tblMember.Controls.Add(this.label34);
            this.tblMember.Controls.Add(this.label32);
            this.tblMember.Controls.Add(this.cboMemberClassification);
            this.tblMember.Controls.Add(this.label29);
            this.tblMember.Controls.Add(this.label26);
            this.tblMember.Controls.Add(this.label27);
            this.tblMember.Controls.Add(this.txtReasonOfMembership);
            this.tblMember.Location = new System.Drawing.Point(4, 24);
            this.tblMember.Name = "tblMember";
            this.tblMember.Padding = new System.Windows.Forms.Padding(3);
            this.tblMember.Size = new System.Drawing.Size(794, 533);
            this.tblMember.TabIndex = 2;
            this.tblMember.Text = "Member Details";
            this.tblMember.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(98, 40);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(95, 15);
            this.label41.TabIndex = 110;
            this.label41.Text = "Membership ID:";
            // 
            // txtMemberId
            // 
            this.txtMemberId.BackColor = System.Drawing.Color.White;
            this.txtMemberId.Enabled = false;
            this.txtMemberId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(213, 38);
            this.txtMemberId.MaxLength = 50;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(328, 23);
            this.txtMemberId.TabIndex = 2;
            // 
            // cboMemberType
            // 
            this.cboMemberType.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cboMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMemberType.FormattingEnabled = true;
            this.cboMemberType.Location = new System.Drawing.Point(213, 95);
            this.cboMemberType.Name = "cboMemberType";
            this.cboMemberType.Size = new System.Drawing.Size(328, 22);
            this.cboMemberType.TabIndex = 4;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(156, 96);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(37, 15);
            this.label40.TabIndex = 109;
            this.label40.Text = "Type:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(83, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(110, 15);
            this.label28.TabIndex = 108;
            this.label28.Text = "Membership Date:";
            // 
            // txtOtherMemberInformation
            // 
            this.txtOtherMemberInformation.BackColor = System.Drawing.Color.White;
            this.txtOtherMemberInformation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherMemberInformation.Location = new System.Drawing.Point(213, 426);
            this.txtOtherMemberInformation.MaxLength = 500;
            this.txtOtherMemberInformation.Multiline = true;
            this.txtOtherMemberInformation.Name = "txtOtherMemberInformation";
            this.txtOtherMemberInformation.Size = new System.Drawing.Size(328, 95);
            this.txtOtherMemberInformation.TabIndex = 8;
            // 
            // txtOtherCooperativeMembership
            // 
            this.txtOtherCooperativeMembership.BackColor = System.Drawing.Color.White;
            this.txtOtherCooperativeMembership.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherCooperativeMembership.Location = new System.Drawing.Point(213, 325);
            this.txtOtherCooperativeMembership.MaxLength = 500;
            this.txtOtherCooperativeMembership.Multiline = true;
            this.txtOtherCooperativeMembership.Name = "txtOtherCooperativeMembership";
            this.txtOtherCooperativeMembership.Size = new System.Drawing.Size(328, 95);
            this.txtOtherCooperativeMembership.TabIndex = 7;
            // 
            // txtCertificationInformation
            // 
            this.txtCertificationInformation.BackColor = System.Drawing.Color.White;
            this.txtCertificationInformation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertificationInformation.Location = new System.Drawing.Point(213, 224);
            this.txtCertificationInformation.MaxLength = 500;
            this.txtCertificationInformation.Multiline = true;
            this.txtCertificationInformation.Name = "txtCertificationInformation";
            this.txtCertificationInformation.Size = new System.Drawing.Size(328, 95);
            this.txtCertificationInformation.TabIndex = 6;
            // 
            // lblMemberStatus
            // 
            this.lblMemberStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMemberStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberStatus.ForeColor = System.Drawing.Color.Green;
            this.lblMemberStatus.Location = new System.Drawing.Point(547, 483);
            this.lblMemberStatus.Name = "lblMemberStatus";
            this.lblMemberStatus.Size = new System.Drawing.Size(247, 38);
            this.lblMemberStatus.TabIndex = 9;
            this.lblMemberStatus.Text = "ACTIVE";
            this.lblMemberStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(30, 427);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(163, 15);
            this.label34.TabIndex = 107;
            this.label34.Text = "Other Member Information:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(47, 225);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(146, 15);
            this.label32.TabIndex = 106;
            this.label32.Text = "Certification Information:";
            // 
            // cboMemberClassification
            // 
            this.cboMemberClassification.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cboMemberClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberClassification.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMemberClassification.FormattingEnabled = true;
            this.cboMemberClassification.Location = new System.Drawing.Point(213, 67);
            this.cboMemberClassification.Name = "cboMemberClassification";
            this.cboMemberClassification.Size = new System.Drawing.Size(328, 22);
            this.cboMemberClassification.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(113, 68);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(80, 15);
            this.label29.TabIndex = 105;
            this.label29.Text = "Classification:";
            // 
            // lnkMembershipDate
            // 
            this.lnkMembershipDate.AutoSize = true;
            this.lnkMembershipDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMembershipDate.ForeColor = System.Drawing.Color.Navy;
            this.lnkMembershipDate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMembershipDate.LinkColor = System.Drawing.Color.Blue;
            this.lnkMembershipDate.Location = new System.Drawing.Point(495, 12);
            this.lnkMembershipDate.Name = "lnkMembershipDate";
            this.lnkMembershipDate.Size = new System.Drawing.Size(46, 15);
            this.lnkMembershipDate.TabIndex = 1;
            this.lnkMembershipDate.TabStop = true;
            this.lnkMembershipDate.Text = "change";
            // 
            // txtMembershipDate
            // 
            this.txtMembershipDate.BackColor = System.Drawing.Color.White;
            this.txtMembershipDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipDate.Location = new System.Drawing.Point(213, 10);
            this.txtMembershipDate.MaxLength = 500;
            this.txtMembershipDate.Name = "txtMembershipDate";
            this.txtMembershipDate.ReadOnly = true;
            this.txtMembershipDate.Size = new System.Drawing.Size(276, 22);
            this.txtMembershipDate.TabIndex = 0;
            this.txtMembershipDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(6, 326);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(187, 15);
            this.label26.TabIndex = 104;
            this.label26.Text = "Other Cooperative Membership:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(56, 124);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(137, 15);
            this.label27.TabIndex = 103;
            this.label27.Text = "Reason of Membership:";
            // 
            // txtReasonOfMembership
            // 
            this.txtReasonOfMembership.BackColor = System.Drawing.Color.White;
            this.txtReasonOfMembership.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonOfMembership.Location = new System.Drawing.Point(213, 123);
            this.txtReasonOfMembership.MaxLength = 500;
            this.txtReasonOfMembership.Multiline = true;
            this.txtReasonOfMembership.Name = "txtReasonOfMembership";
            this.txtReasonOfMembership.Size = new System.Drawing.Size(328, 95);
            this.txtReasonOfMembership.TabIndex = 5;
            // 
            // tblCollateral
            // 
            this.tblCollateral.Controls.Add(this.dgvCollateral);
            this.tblCollateral.Controls.Add(this.lnkCreateCollateral);
            this.tblCollateral.Location = new System.Drawing.Point(4, 24);
            this.tblCollateral.Name = "tblCollateral";
            this.tblCollateral.Size = new System.Drawing.Size(794, 533);
            this.tblCollateral.TabIndex = 6;
            this.tblCollateral.Text = "Collateral Information";
            this.tblCollateral.UseVisualStyleBackColor = true;
            // 
            // dgvCollateral
            // 
            this.dgvCollateral.AllowUserToAddRows = false;
            this.dgvCollateral.AllowUserToDeleteRows = false;
            this.dgvCollateral.AllowUserToResizeColumns = false;
            this.dgvCollateral.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCollateral.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCollateral.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvCollateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCollateral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCollateral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCollateral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollateral.Location = new System.Drawing.Point(3, 9);
            this.dgvCollateral.Name = "dgvCollateral";
            this.dgvCollateral.RowHeadersVisible = false;
            this.dgvCollateral.RowHeadersWidth = 15;
            this.dgvCollateral.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender;
            this.dgvCollateral.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCollateral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollateral.Size = new System.Drawing.Size(784, 493);
            this.dgvCollateral.TabIndex = 91;
            // 
            // lnkCreateCollateral
            // 
            this.lnkCreateCollateral.AutoSize = true;
            this.lnkCreateCollateral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateCollateral.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateCollateral.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateCollateral.Location = new System.Drawing.Point(674, 511);
            this.lnkCreateCollateral.Name = "lnkCreateCollateral";
            this.lnkCreateCollateral.Size = new System.Drawing.Size(113, 15);
            this.lnkCreateCollateral.TabIndex = 90;
            this.lnkCreateCollateral.TabStop = true;
            this.lnkCreateCollateral.Text = "[Create Collateral ]";
            this.lnkCreateCollateral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblOtherCreditor
            // 
            this.tblOtherCreditor.Controls.Add(this.dgvOtherCreditor);
            this.tblOtherCreditor.Controls.Add(this.lnkCreateOtherCreditor);
            this.tblOtherCreditor.Location = new System.Drawing.Point(4, 24);
            this.tblOtherCreditor.Name = "tblOtherCreditor";
            this.tblOtherCreditor.Size = new System.Drawing.Size(794, 533);
            this.tblOtherCreditor.TabIndex = 7;
            this.tblOtherCreditor.Text = "Other Creditor Information";
            this.tblOtherCreditor.UseVisualStyleBackColor = true;
            // 
            // dgvOtherCreditor
            // 
            this.dgvOtherCreditor.AllowUserToAddRows = false;
            this.dgvOtherCreditor.AllowUserToDeleteRows = false;
            this.dgvOtherCreditor.AllowUserToResizeColumns = false;
            this.dgvOtherCreditor.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOtherCreditor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOtherCreditor.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvOtherCreditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOtherCreditor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOtherCreditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOtherCreditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtherCreditor.Location = new System.Drawing.Point(3, 9);
            this.dgvOtherCreditor.Name = "dgvOtherCreditor";
            this.dgvOtherCreditor.RowHeadersVisible = false;
            this.dgvOtherCreditor.RowHeadersWidth = 15;
            this.dgvOtherCreditor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender;
            this.dgvOtherCreditor.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOtherCreditor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOtherCreditor.Size = new System.Drawing.Size(784, 493);
            this.dgvOtherCreditor.TabIndex = 93;
            // 
            // lnkCreateOtherCreditor
            // 
            this.lnkCreateOtherCreditor.AutoSize = true;
            this.lnkCreateOtherCreditor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateOtherCreditor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateOtherCreditor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateOtherCreditor.Location = new System.Drawing.Point(649, 508);
            this.lnkCreateOtherCreditor.Name = "lnkCreateOtherCreditor";
            this.lnkCreateOtherCreditor.Size = new System.Drawing.Size(140, 15);
            this.lnkCreateOtherCreditor.TabIndex = 92;
            this.lnkCreateOtherCreditor.TabStop = true;
            this.lnkCreateOtherCreditor.Text = "[Create Other Creditor ]";
            this.lnkCreateOtherCreditor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbxMemberInformation
            // 
            this.pbxMemberInformation.BackColor = System.Drawing.Color.Transparent;
            this.pbxMemberInformation.BackgroundImage = global::MemberServices.Properties.Resources.Member_Information;
            this.pbxMemberInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMemberInformation.Location = new System.Drawing.Point(0, 113);
            this.pbxMemberInformation.Name = "pbxMemberInformation";
            this.pbxMemberInformation.Size = new System.Drawing.Size(161, 25);
            this.pbxMemberInformation.TabIndex = 8;
            this.pbxMemberInformation.TabStop = false;
            // 
            // MemberInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(994, 712);
            this.Name = "MemberInformation";
            ((System.ComponentModel.ISupportInitialize)(this.pbxReferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeneficiaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).EndInit();
            this.tblPerson.ResumeLayout(false);
            this.tblPerson.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneralInformation)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).EndInit();
            this.tabCntPerson.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tblMemberInformation.ResumeLayout(false);
            this.tblMemberInformation.PerformLayout();
            this.tabMemberInfo.ResumeLayout(false);
            this.tblMember.ResumeLayout(false);
            this.tblMember.PerformLayout();
            this.tblCollateral.ResumeLayout(false);
            this.tblCollateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollateral)).EndInit();
            this.tblOtherCreditor.ResumeLayout(false);
            this.tblOtherCreditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherCreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberInformation)).EndInit();
            this.ResumeLayout(false);

        }
        
    }
}
