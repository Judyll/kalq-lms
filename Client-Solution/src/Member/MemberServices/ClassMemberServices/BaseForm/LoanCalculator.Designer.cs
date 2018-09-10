namespace MemberServices
{
    partial class LoanCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Loan Charges/Additions Summary", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Loan Charges/Additions Details", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanCalculator));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrincipalAmount = new System.Windows.Forms.TextBox();
            this.gbxChargesAdditionals = new System.Windows.Forms.GroupBox();
            this.lsvChargesAdditions = new System.Windows.Forms.ListView();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.systemId = new System.Windows.Forms.ColumnHeader();
            this.isCharges = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCharges = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddAdditionals = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblNetLoanAmount = new System.Windows.Forms.ToolStripLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDeferredInterest = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRealizedInterest = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrePaidInterest = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtMaturityDate = new System.Windows.Forms.TextBox();
            this.lnkChageReleaseDate = new System.Windows.Forms.LinkLabel();
            this.txtFirstPaymentDate = new System.Windows.Forms.TextBox();
            this.lnkChangeMaturityDate = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPaymentInterval = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoOfPrepaidInterest = new System.Windows.Forms.TextBox();
            this.rdbStraight = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.gbxChargesAdditionals.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPrincipalAmount);
            this.groupBox4.Location = new System.Drawing.Point(332, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 81);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Principal Amount ";
            // 
            // txtPrincipalAmount
            // 
            this.txtPrincipalAmount.BackColor = System.Drawing.Color.White;
            this.txtPrincipalAmount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipalAmount.ForeColor = System.Drawing.Color.Red;
            this.txtPrincipalAmount.Location = new System.Drawing.Point(15, 27);
            this.txtPrincipalAmount.MaxLength = 50;
            this.txtPrincipalAmount.Name = "txtPrincipalAmount";
            this.txtPrincipalAmount.Size = new System.Drawing.Size(275, 33);
            this.txtPrincipalAmount.TabIndex = 0;
            this.txtPrincipalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbxChargesAdditionals
            // 
            this.gbxChargesAdditionals.Controls.Add(this.lsvChargesAdditions);
            this.gbxChargesAdditionals.Controls.Add(this.toolStrip1);
            this.gbxChargesAdditionals.Enabled = false;
            this.gbxChargesAdditionals.Location = new System.Drawing.Point(16, 187);
            this.gbxChargesAdditionals.Name = "gbxChargesAdditionals";
            this.gbxChargesAdditionals.Size = new System.Drawing.Size(302, 484);
            this.gbxChargesAdditionals.TabIndex = 7;
            this.gbxChargesAdditionals.TabStop = false;
            this.gbxChargesAdditionals.Text = " Loan Summary ";
            // 
            // lsvChargesAdditions
            // 
            this.lsvChargesAdditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.description,
            this.amount,
            this.systemId,
            this.isCharges});
            this.lsvChargesAdditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvChargesAdditions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvChargesAdditions.FullRowSelect = true;
            listViewGroup1.Header = "Loan Charges/Additions Summary";
            listViewGroup1.Name = "grpSummary";
            listViewGroup2.Header = "Loan Charges/Additions Details";
            listViewGroup2.Name = "grpDetals";
            this.lsvChargesAdditions.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lsvChargesAdditions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvChargesAdditions.HideSelection = false;
            this.lsvChargesAdditions.Location = new System.Drawing.Point(3, 43);
            this.lsvChargesAdditions.MultiSelect = false;
            this.lsvChargesAdditions.Name = "lsvChargesAdditions";
            this.lsvChargesAdditions.ShowItemToolTips = true;
            this.lsvChargesAdditions.Size = new System.Drawing.Size(296, 438);
            this.lsvChargesAdditions.TabIndex = 1;
            this.lsvChargesAdditions.UseCompatibleStateImageBehavior = false;
            this.lsvChargesAdditions.View = System.Windows.Forms.View.Details;
            // 
            // description
            // 
            this.description.Text = "                     Description";
            this.description.Width = 190;
            // 
            // amount
            // 
            this.amount.Text = "Amount     ";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 85;
            // 
            // systemId
            // 
            this.systemId.Text = "";
            this.systemId.Width = 0;
            // 
            // isCharges
            // 
            this.isCharges.Text = "";
            this.isCharges.Width = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCharges,
            this.toolStripSeparator1,
            this.btnAddAdditionals,
            this.toolStripSeparator2,
            this.lblNetLoanAmount});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(296, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCharges
            // 
            this.btnAddCharges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCharges.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCharges.Image")));
            this.btnAddCharges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCharges.Name = "btnAddCharges";
            this.btnAddCharges.Size = new System.Drawing.Size(23, 22);
            this.btnAddCharges.Text = "Create loan charges";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddAdditionals
            // 
            this.btnAddAdditionals.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddAdditionals.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAdditionals.Image")));
            this.btnAddAdditionals.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAdditionals.Name = "btnAddAdditionals";
            this.btnAddAdditionals.Size = new System.Drawing.Size(23, 22);
            this.btnAddAdditionals.Text = "Create loan additions";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblNetLoanAmount
            // 
            this.lblNetLoanAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetLoanAmount.ForeColor = System.Drawing.Color.Sienna;
            this.lblNetLoanAmount.Name = "lblNetLoanAmount";
            this.lblNetLoanAmount.Size = new System.Drawing.Size(10, 22);
            this.lblNetLoanAmount.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDeferredInterest);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblRealizedInterest);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblPrePaidInterest);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cboPaymentInterval);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNoOfPrepaidInterest);
            this.groupBox3.Controls.Add(this.rdbStraight);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtInterestRate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTerm);
            this.groupBox3.Location = new System.Drawing.Point(332, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 396);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Loan Parameters ";
            // 
            // lblDeferredInterest
            // 
            this.lblDeferredInterest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeferredInterest.ForeColor = System.Drawing.Color.Red;
            this.lblDeferredInterest.Location = new System.Drawing.Point(144, 188);
            this.lblDeferredInterest.Name = "lblDeferredInterest";
            this.lblDeferredInterest.Size = new System.Drawing.Size(148, 19);
            this.lblDeferredInterest.TabIndex = 83;
            this.lblDeferredInterest.Text = "-";
            this.lblDeferredInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(37, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 15);
            this.label15.TabIndex = 82;
            this.label15.Text = "Deferred Interest:";
            // 
            // lblRealizedInterest
            // 
            this.lblRealizedInterest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizedInterest.ForeColor = System.Drawing.Color.Red;
            this.lblRealizedInterest.Location = new System.Drawing.Point(144, 167);
            this.lblRealizedInterest.Name = "lblRealizedInterest";
            this.lblRealizedInterest.Size = new System.Drawing.Size(148, 19);
            this.lblRealizedInterest.TabIndex = 81;
            this.lblRealizedInterest.Text = "-";
            this.lblRealizedInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(42, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 15);
            this.label10.TabIndex = 80;
            this.label10.Text = "Realized Interest:";
            // 
            // lblPrePaidInterest
            // 
            this.lblPrePaidInterest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrePaidInterest.ForeColor = System.Drawing.Color.Red;
            this.lblPrePaidInterest.Location = new System.Drawing.Point(144, 145);
            this.lblPrePaidInterest.Name = "lblPrePaidInterest";
            this.lblPrePaidInterest.Size = new System.Drawing.Size(148, 19);
            this.lblPrePaidInterest.TabIndex = 79;
            this.lblPrePaidInterest.Text = "-";
            this.lblPrePaidInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(45, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 78;
            this.label12.Text = "Prepaid Interest:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtMaturityDate);
            this.groupBox10.Controls.Add(this.lnkChageReleaseDate);
            this.groupBox10.Controls.Add(this.txtFirstPaymentDate);
            this.groupBox10.Controls.Add(this.lnkChangeMaturityDate);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Location = new System.Drawing.Point(6, 241);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(290, 126);
            this.groupBox10.TabIndex = 76;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = " Dates ";
            // 
            // txtMaturityDate
            // 
            this.txtMaturityDate.BackColor = System.Drawing.Color.White;
            this.txtMaturityDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaturityDate.ForeColor = System.Drawing.Color.Black;
            this.txtMaturityDate.Location = new System.Drawing.Point(23, 90);
            this.txtMaturityDate.Name = "txtMaturityDate";
            this.txtMaturityDate.ReadOnly = true;
            this.txtMaturityDate.Size = new System.Drawing.Size(209, 22);
            this.txtMaturityDate.TabIndex = 2;
            this.txtMaturityDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkChageReleaseDate
            // 
            this.lnkChageReleaseDate.AutoSize = true;
            this.lnkChageReleaseDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkChageReleaseDate.ForeColor = System.Drawing.Color.Navy;
            this.lnkChageReleaseDate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkChageReleaseDate.LinkColor = System.Drawing.Color.Blue;
            this.lnkChageReleaseDate.Location = new System.Drawing.Point(238, 43);
            this.lnkChageReleaseDate.Name = "lnkChageReleaseDate";
            this.lnkChageReleaseDate.Size = new System.Drawing.Size(46, 15);
            this.lnkChageReleaseDate.TabIndex = 1;
            this.lnkChageReleaseDate.TabStop = true;
            this.lnkChageReleaseDate.Text = "change";
            // 
            // txtFirstPaymentDate
            // 
            this.txtFirstPaymentDate.BackColor = System.Drawing.Color.White;
            this.txtFirstPaymentDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPaymentDate.ForeColor = System.Drawing.Color.Black;
            this.txtFirstPaymentDate.Location = new System.Drawing.Point(23, 41);
            this.txtFirstPaymentDate.Name = "txtFirstPaymentDate";
            this.txtFirstPaymentDate.ReadOnly = true;
            this.txtFirstPaymentDate.Size = new System.Drawing.Size(209, 22);
            this.txtFirstPaymentDate.TabIndex = 0;
            this.txtFirstPaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkChangeMaturityDate
            // 
            this.lnkChangeMaturityDate.AutoSize = true;
            this.lnkChangeMaturityDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkChangeMaturityDate.ForeColor = System.Drawing.Color.Navy;
            this.lnkChangeMaturityDate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkChangeMaturityDate.LinkColor = System.Drawing.Color.Blue;
            this.lnkChangeMaturityDate.Location = new System.Drawing.Point(238, 92);
            this.lnkChangeMaturityDate.Name = "lnkChangeMaturityDate";
            this.lnkChangeMaturityDate.Size = new System.Drawing.Size(46, 15);
            this.lnkChangeMaturityDate.TabIndex = 3;
            this.lnkChangeMaturityDate.TabStop = true;
            this.lnkChangeMaturityDate.Text = "change";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 15);
            this.label14.TabIndex = 86;
            this.label14.Text = "First Payment Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 15);
            this.label13.TabIndex = 89;
            this.label13.Text = "Date Maturity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(276, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "%";
            // 
            // cboPaymentInterval
            // 
            this.cboPaymentInterval.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cboPaymentInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentInterval.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentInterval.FormattingEnabled = true;
            this.cboPaymentInterval.Location = new System.Drawing.Point(148, 54);
            this.cboPaymentInterval.Name = "cboPaymentInterval";
            this.cboPaymentInterval.Size = new System.Drawing.Size(144, 22);
            this.cboPaymentInterval.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "Payment Interval:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "No. of Prepaid Interest:";
            // 
            // txtNoOfPrepaidInterest
            // 
            this.txtNoOfPrepaidInterest.BackColor = System.Drawing.Color.White;
            this.txtNoOfPrepaidInterest.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfPrepaidInterest.Location = new System.Drawing.Point(148, 115);
            this.txtNoOfPrepaidInterest.MaxLength = 50;
            this.txtNoOfPrepaidInterest.Name = "txtNoOfPrepaidInterest";
            this.txtNoOfPrepaidInterest.Size = new System.Drawing.Size(144, 23);
            this.txtNoOfPrepaidInterest.TabIndex = 4;
            this.txtNoOfPrepaidInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdbStraight
            // 
            this.rdbStraight.AutoSize = true;
            this.rdbStraight.Checked = true;
            this.rdbStraight.Location = new System.Drawing.Point(148, 220);
            this.rdbStraight.Name = "rdbStraight";
            this.rdbStraight.Size = new System.Drawing.Size(64, 18);
            this.rdbStraight.TabIndex = 6;
            this.rdbStraight.TabStop = true;
            this.rdbStraight.Text = "Straight";
            this.rdbStraight.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 15);
            this.label7.TabIndex = 71;
            this.label7.Text = "Interest Rate in Percent:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.White;
            this.txtInterestRate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(148, 23);
            this.txtInterestRate.MaxLength = 50;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(122, 23);
            this.txtInterestRate.TabIndex = 0;
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(105, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "Term:";
            // 
            // txtTerm
            // 
            this.txtTerm.BackColor = System.Drawing.Color.White;
            this.txtTerm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.Location = new System.Drawing.Point(148, 84);
            this.txtTerm.MaxLength = 50;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(144, 23);
            this.txtTerm.TabIndex = 3;
            this.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 62);
            this.panel1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(0, 680);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 41);
            this.panel3.TabIndex = 29;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(16, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 23);
            this.btnPrint.TabIndex = 108;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(548, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOffice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMonthlySalary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblApplicantName);
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 113);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Member Information ";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffice.ForeColor = System.Drawing.Color.Magenta;
            this.lblOffice.Location = new System.Drawing.Point(150, 79);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(13, 18);
            this.lblOffice.TabIndex = 77;
            this.lblOffice.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "Office:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Monthly Salary:";
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySalary.ForeColor = System.Drawing.Color.Magenta;
            this.lblMonthlySalary.Location = new System.Drawing.Point(150, 53);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(13, 18);
            this.lblMonthlySalary.TabIndex = 76;
            this.lblMonthlySalary.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Name of Applicant:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantName.ForeColor = System.Drawing.Color.Magenta;
            this.lblApplicantName.Location = new System.Drawing.Point(150, 27);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(13, 18);
            this.lblApplicantName.TabIndex = 75;
            this.lblApplicantName.Text = "-";
            // 
            // LoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(650, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbxChargesAdditionals);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoanCalculator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbxChargesAdditionals.ResumeLayout(false);
            this.gbxChargesAdditionals.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.TextBox txtPrincipalAmount;
        protected System.Windows.Forms.GroupBox gbxChargesAdditionals;
        protected System.Windows.Forms.ListView lsvChargesAdditions;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader systemId;
        private System.Windows.Forms.ColumnHeader isCharges;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCharges;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddAdditionals;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripLabel lblNetLoanAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label9;
        protected System.Windows.Forms.ComboBox cboPaymentInterval;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtNoOfPrepaidInterest;
        private System.Windows.Forms.RadioButton rdbStraight;
        public System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox txtInterestRate;
        public System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtTerm;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblOffice;
        public System.Windows.Forms.Label lblMonthlySalary;
        public System.Windows.Forms.Label lblApplicantName;
        protected System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox10;
        protected System.Windows.Forms.TextBox txtMaturityDate;
        protected System.Windows.Forms.LinkLabel lnkChageReleaseDate;
        protected System.Windows.Forms.TextBox txtFirstPaymentDate;
        protected System.Windows.Forms.LinkLabel lnkChangeMaturityDate;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Label lblPrePaidInterest;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblDeferredInterest;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblRealizedInterest;
        public System.Windows.Forms.Label label10;
    }
}