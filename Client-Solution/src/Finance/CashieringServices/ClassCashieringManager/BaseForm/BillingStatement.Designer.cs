namespace CashieringServices
{
    partial class BillingStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingStatement));
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("TUITION FEE, MISCELLANEOUS, OTHER FEES, LABORATORY FEES", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("MISCELLANEOUS INCOME", System.Windows.Forms.HorizontalAlignment.Left);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.smTotal = new System.Windows.Forms.ColumnHeader();
            this.smSubCode = new System.Windows.Forms.ColumnHeader();
            this.smSubName = new System.Windows.Forms.ColumnHeader();
            this.smAmount = new System.Windows.Forms.ColumnHeader();
            this.pnlSummarized = new System.Windows.Forms.Panel();
            this.cmCourse = new System.Windows.Forms.ColumnHeader();
            this.smAccountName = new System.Windows.Forms.ColumnHeader();
            this.lsvBillingList = new System.Windows.Forms.ListView();
            this.clName = new System.Windows.Forms.ColumnHeader();
            this.clShareCapitalAmount = new System.Windows.Forms.ColumnHeader();
            this.clHospitalizationAmount = new System.Windows.Forms.ColumnHeader();
            this.clBirthdayPrincipal = new System.Windows.Forms.ColumnHeader();
            this.clBirthdayInterest = new System.Windows.Forms.ColumnHeader();
            this.clContengencyPrincipal = new System.Windows.Forms.ColumnHeader();
            this.clContengencyInterest = new System.Windows.Forms.ColumnHeader();
            this.clSalaryPrincipal = new System.Windows.Forms.ColumnHeader();
            this.clSalaryInterest = new System.Windows.Forms.ColumnHeader();
            this.clMedicalPrincipal = new System.Windows.Forms.ColumnHeader();
            this.clMedicalInterest = new System.Windows.Forms.ColumnHeader();
            this.clSpecialPrincipal = new System.Windows.Forms.ColumnHeader();
            this.clSpecialInterest = new System.Windows.Forms.ColumnHeader();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.smAccountCode = new System.Windows.Forms.ColumnHeader();
            this.lsvCashReceipsSummariezed = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(-1, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 35);
            this.panel2.TabIndex = 111;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(13, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 23);
            this.btnPrint.TabIndex = 71;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(896, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "  Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // smTotal
            // 
            this.smTotal.Text = "Total         ";
            this.smTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.smTotal.Width = 90;
            // 
            // smSubCode
            // 
            this.smSubCode.Text = "Sub. Code";
            this.smSubCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.smSubCode.Width = 90;
            // 
            // smSubName
            // 
            this.smSubName.Text = "                          Sub. Name";
            this.smSubName.Width = 240;
            // 
            // smAmount
            // 
            this.smAmount.Text = "Amount      ";
            this.smAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.smAmount.Width = 90;
            // 
            // pnlSummarized
            // 
            this.pnlSummarized.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSummarized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSummarized.BackgroundImage")));
            this.pnlSummarized.Location = new System.Drawing.Point(-1, 0);
            this.pnlSummarized.Name = "pnlSummarized";
            this.pnlSummarized.Size = new System.Drawing.Size(997, 58);
            this.pnlSummarized.TabIndex = 110;
            // 
            // cmCourse
            // 
            this.cmCourse.Text = " CRSE/DPT";
            this.cmCourse.Width = 100;
            // 
            // smAccountName
            // 
            this.smAccountName.Text = "                    Account Name";
            this.smAccountName.Width = 240;
            // 
            // lsvBillingList
            // 
            this.lsvBillingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvBillingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clShareCapitalAmount,
            this.clHospitalizationAmount,
            this.clBirthdayPrincipal,
            this.clBirthdayInterest,
            this.clContengencyPrincipal,
            this.clContengencyInterest,
            this.clSalaryPrincipal,
            this.clSalaryInterest,
            this.clMedicalPrincipal,
            this.clMedicalInterest,
            this.clSpecialPrincipal,
            this.clSpecialInterest});
            this.lsvBillingList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillingList.FullRowSelect = true;
            this.lsvBillingList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvBillingList.HideSelection = false;
            this.lsvBillingList.Location = new System.Drawing.Point(12, 133);
            this.lsvBillingList.MultiSelect = false;
            this.lsvBillingList.Name = "lsvBillingList";
            this.lsvBillingList.ShowItemToolTips = true;
            this.lsvBillingList.Size = new System.Drawing.Size(970, 538);
            this.lsvBillingList.TabIndex = 112;
            this.lsvBillingList.UseCompatibleStateImageBehavior = false;
            this.lsvBillingList.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "                              Name";
            this.clName.Width = 250;
            // 
            // clShareCapitalAmount
            // 
            this.clShareCapitalAmount.Text = "SC Amount     ";
            this.clShareCapitalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clShareCapitalAmount.Width = 110;
            // 
            // clHospitalizationAmount
            // 
            this.clHospitalizationAmount.Text = "HC Amount     ";
            this.clHospitalizationAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clHospitalizationAmount.Width = 110;
            // 
            // clBirthdayPrincipal
            // 
            this.clBirthdayPrincipal.Text = "Bday Principal   ";
            this.clBirthdayPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clBirthdayPrincipal.Width = 110;
            // 
            // clBirthdayInterest
            // 
            this.clBirthdayInterest.Text = "Bday Interest    ";
            this.clBirthdayInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clBirthdayInterest.Width = 110;
            // 
            // clContengencyPrincipal
            // 
            this.clContengencyPrincipal.Text = "CG Principal     ";
            this.clContengencyPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clContengencyPrincipal.Width = 110;
            // 
            // clContengencyInterest
            // 
            this.clContengencyInterest.Text = "CG Interest     ";
            this.clContengencyInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clContengencyInterest.Width = 110;
            // 
            // clSalaryPrincipal
            // 
            this.clSalaryPrincipal.Text = "Salary Principal  ";
            this.clSalaryPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clSalaryPrincipal.Width = 110;
            // 
            // clSalaryInterest
            // 
            this.clSalaryInterest.Text = "Salary Interest  ";
            this.clSalaryInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clSalaryInterest.Width = 110;
            // 
            // clMedicalPrincipal
            // 
            this.clMedicalPrincipal.Text = "Medical Principal ";
            this.clMedicalPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clMedicalPrincipal.Width = 110;
            // 
            // clMedicalInterest
            // 
            this.clMedicalInterest.Text = "Medical Interest ";
            this.clMedicalInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clMedicalInterest.Width = 110;
            // 
            // clSpecialPrincipal
            // 
            this.clSpecialPrincipal.Text = "Special Principal ";
            this.clSpecialPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clSpecialPrincipal.Width = 110;
            // 
            // clSpecialInterest
            // 
            this.clSpecialInterest.Text = "Special Interest ";
            this.clSpecialInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clSpecialInterest.Width = 110;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.Silver;
            this.pnlDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDetails.BackgroundImage")));
            this.pnlDetails.Location = new System.Drawing.Point(-1, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(997, 58);
            this.pnlDetails.TabIndex = 109;
            this.pnlDetails.Visible = false;
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.Location = new System.Drawing.Point(283, 18);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(188, 33);
            this.btnShowResult.TabIndex = 105;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowResult.UseVisualStyleBackColor = true;
            // 
            // smAccountCode
            // 
            this.smAccountCode.Text = "  Account Code";
            this.smAccountCode.Width = 100;
            // 
            // lsvCashReceipsSummariezed
            // 
            this.lsvCashReceipsSummariezed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCashReceipsSummariezed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.smAccountCode,
            this.smAccountName,
            this.cmCourse,
            this.smSubCode,
            this.smSubName,
            this.smAmount,
            this.smTotal});
            this.lsvCashReceipsSummariezed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCashReceipsSummariezed.FullRowSelect = true;
            this.lsvCashReceipsSummariezed.GridLines = true;
            listViewGroup5.Header = "TUITION FEE, MISCELLANEOUS, OTHER FEES, LABORATORY FEES";
            listViewGroup5.Name = "grpStudentPayments";
            listViewGroup6.Header = "MISCELLANEOUS INCOME";
            listViewGroup6.Name = "grpMiscellaneousIncome";
            this.lsvCashReceipsSummariezed.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.lsvCashReceipsSummariezed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvCashReceipsSummariezed.HideSelection = false;
            this.lsvCashReceipsSummariezed.Location = new System.Drawing.Point(12, 133);
            this.lsvCashReceipsSummariezed.MultiSelect = false;
            this.lsvCashReceipsSummariezed.Name = "lsvCashReceipsSummariezed";
            this.lsvCashReceipsSummariezed.ShowItemToolTips = true;
            this.lsvCashReceipsSummariezed.Size = new System.Drawing.Size(970, 538);
            this.lsvCashReceipsSummariezed.TabIndex = 114;
            this.lsvCashReceipsSummariezed.UseCompatibleStateImageBehavior = false;
            this.lsvCashReceipsSummariezed.View = System.Windows.Forms.View.Details;
            this.lsvCashReceipsSummariezed.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowResult);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 60);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Billing Month ";
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = false;
            this.dtpStart.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(20, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(248, 33);
            this.dtpStart.TabIndex = 0;
            // 
            // BillingStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(994, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSummarized);
            this.Controls.Add(this.lsvBillingList);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.lsvCashReceipsSummariezed);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillingStatement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader smTotal;
        private System.Windows.Forms.ColumnHeader smSubCode;
        private System.Windows.Forms.ColumnHeader smSubName;
        private System.Windows.Forms.ColumnHeader smAmount;
        private System.Windows.Forms.Panel pnlSummarized;
        private System.Windows.Forms.ColumnHeader cmCourse;
        private System.Windows.Forms.ColumnHeader smAccountName;
        private System.Windows.Forms.ListView lsvBillingList;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.ColumnHeader smAccountCode;
        private System.Windows.Forms.ListView lsvCashReceipsSummariezed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clShareCapitalAmount;
        private System.Windows.Forms.ColumnHeader clHospitalizationAmount;
        private System.Windows.Forms.ColumnHeader clBirthdayPrincipal;
        private System.Windows.Forms.ColumnHeader clBirthdayInterest;
        private System.Windows.Forms.ColumnHeader clContengencyPrincipal;
        private System.Windows.Forms.ColumnHeader clContengencyInterest;
        private System.Windows.Forms.ColumnHeader clSalaryPrincipal;
        private System.Windows.Forms.ColumnHeader clSalaryInterest;
        private System.Windows.Forms.ColumnHeader clMedicalPrincipal;
        private System.Windows.Forms.ColumnHeader clMedicalInterest;
        private System.Windows.Forms.ColumnHeader clSpecialPrincipal;
        private System.Windows.Forms.ColumnHeader clSpecialInterest;
    }
}