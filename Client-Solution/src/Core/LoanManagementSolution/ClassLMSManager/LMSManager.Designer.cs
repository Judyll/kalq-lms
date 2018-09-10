namespace LoanManagementSolution
{
    partial class LMSManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMSManager));
            this.stsStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpaceSeparate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbxMemberSolution = new System.Windows.Forms.PictureBox();
            this.pbxDisbursementSolution = new System.Windows.Forms.PictureBox();
            this.pbxChartOfAccountSolution = new System.Windows.Forms.PictureBox();
            this.pbxFinanceSolutions = new System.Windows.Forms.PictureBox();
            this.lnkExit = new System.Windows.Forms.LinkLabel();
            this.lnkUser = new System.Windows.Forms.LinkLabel();
            this.lnkTransactionLog = new System.Windows.Forms.LinkLabel();
            this.stsStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisbursementSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChartOfAccountSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinanceSolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // stsStrip
            // 
            this.stsStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolSpace,
            this.lblSpaceSeparate,
            this.toolStripStatusLabel1,
            this.lblDate,
            this.lblUserName,
            this.toolStripStatusLabel2,
            this.lbltime});
            this.stsStrip.Location = new System.Drawing.Point(0, 684);
            this.stsStrip.Name = "stsStrip";
            this.stsStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stsStrip.Size = new System.Drawing.Size(1018, 22);
            this.stsStrip.SizingGrip = false;
            this.stsStrip.TabIndex = 3;
            this.stsStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.Image")));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready";
            // 
            // toolSpace
            // 
            this.toolSpace.Name = "toolSpace";
            this.toolSpace.Size = new System.Drawing.Size(0, 17);
            // 
            // lblSpaceSeparate
            // 
            this.lblSpaceSeparate.Name = "lblSpaceSeparate";
            this.lblSpaceSeparate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSpaceSeparate.Size = new System.Drawing.Size(888, 17);
            this.lblSpaceSeparate.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(7, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblDate
            // 
            this.lblDate.Image = ((System.Drawing.Image)(resources.GetObject("lblDate.Image")));
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 17);
            // 
            // lblUserName
            // 
            this.lblUserName.Image = ((System.Drawing.Image)(resources.GetObject("lblUserName.Image")));
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(16, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(7, 17);
            this.toolStripStatusLabel2.Text = "|";
            this.toolStripStatusLabel2.ToolTipText = "|";
            // 
            // lbltime
            // 
            this.lbltime.Image = ((System.Drawing.Image)(resources.GetObject("lbltime.Image")));
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(16, 17);
            // 
            // pbxMemberSolution
            // 
            this.pbxMemberSolution.BackColor = System.Drawing.Color.Transparent;
            this.pbxMemberSolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxMemberSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMemberSolution.Image = global::LoanManagementSolution.Properties.Resources.memberManagerDisabled;
            this.pbxMemberSolution.Location = new System.Drawing.Point(142, 274);
            this.pbxMemberSolution.Name = "pbxMemberSolution";
            this.pbxMemberSolution.Size = new System.Drawing.Size(146, 166);
            this.pbxMemberSolution.TabIndex = 4;
            this.pbxMemberSolution.TabStop = false;
            // 
            // pbxDisbursementSolution
            // 
            this.pbxDisbursementSolution.BackColor = System.Drawing.Color.Transparent;
            this.pbxDisbursementSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDisbursementSolution.Image = global::LoanManagementSolution.Properties.Resources.disbursementVoucherDisabled;
            this.pbxDisbursementSolution.Location = new System.Drawing.Point(325, 274);
            this.pbxDisbursementSolution.Name = "pbxDisbursementSolution";
            this.pbxDisbursementSolution.Size = new System.Drawing.Size(146, 166);
            this.pbxDisbursementSolution.TabIndex = 5;
            this.pbxDisbursementSolution.TabStop = false;
            // 
            // pbxChartOfAccountSolution
            // 
            this.pbxChartOfAccountSolution.BackColor = System.Drawing.Color.Transparent;
            this.pbxChartOfAccountSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChartOfAccountSolution.Image = global::LoanManagementSolution.Properties.Resources.chartOfAccountDisabled;
            this.pbxChartOfAccountSolution.Location = new System.Drawing.Point(508, 275);
            this.pbxChartOfAccountSolution.Name = "pbxChartOfAccountSolution";
            this.pbxChartOfAccountSolution.Size = new System.Drawing.Size(146, 166);
            this.pbxChartOfAccountSolution.TabIndex = 6;
            this.pbxChartOfAccountSolution.TabStop = false;
            // 
            // pbxFinanceSolutions
            // 
            this.pbxFinanceSolutions.BackColor = System.Drawing.Color.Transparent;
            this.pbxFinanceSolutions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFinanceSolutions.Image = global::LoanManagementSolution.Properties.Resources.lmsIconCashieringManagerDisabled;
            this.pbxFinanceSolutions.Location = new System.Drawing.Point(695, 274);
            this.pbxFinanceSolutions.Name = "pbxFinanceSolutions";
            this.pbxFinanceSolutions.Size = new System.Drawing.Size(146, 166);
            this.pbxFinanceSolutions.TabIndex = 7;
            this.pbxFinanceSolutions.TabStop = false;
            // 
            // lnkExit
            // 
            this.lnkExit.BackColor = System.Drawing.Color.Transparent;
            this.lnkExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkExit.Image = ((System.Drawing.Image)(resources.GetObject("lnkExit.Image")));
            this.lnkExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkExit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkExit.LinkColor = System.Drawing.Color.Black;
            this.lnkExit.Location = new System.Drawing.Point(934, 651);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lnkExit.Size = new System.Drawing.Size(74, 22);
            this.lnkExit.TabIndex = 9;
            this.lnkExit.TabStop = true;
            this.lnkExit.Text = "Exit";
            this.lnkExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkUser
            // 
            this.lnkUser.BackColor = System.Drawing.Color.Transparent;
            this.lnkUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUser.Image = ((System.Drawing.Image)(resources.GetObject("lnkUser.Image")));
            this.lnkUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkUser.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkUser.LinkColor = System.Drawing.Color.Black;
            this.lnkUser.Location = new System.Drawing.Point(930, 624);
            this.lnkUser.Name = "lnkUser";
            this.lnkUser.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lnkUser.Size = new System.Drawing.Size(78, 22);
            this.lnkUser.TabIndex = 10;
            this.lnkUser.TabStop = true;
            this.lnkUser.Text = "Users";
            this.lnkUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkUser.Visible = false;
            // 
            // lnkTransactionLog
            // 
            this.lnkTransactionLog.BackColor = System.Drawing.Color.Transparent;
            this.lnkTransactionLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkTransactionLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTransactionLog.Image = ((System.Drawing.Image)(resources.GetObject("lnkTransactionLog.Image")));
            this.lnkTransactionLog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkTransactionLog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTransactionLog.LinkColor = System.Drawing.Color.Black;
            this.lnkTransactionLog.Location = new System.Drawing.Point(856, 597);
            this.lnkTransactionLog.Name = "lnkTransactionLog";
            this.lnkTransactionLog.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lnkTransactionLog.Size = new System.Drawing.Size(152, 22);
            this.lnkTransactionLog.TabIndex = 11;
            this.lnkTransactionLog.TabStop = true;
            this.lnkTransactionLog.Text = "Transaction Log";
            this.lnkTransactionLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkTransactionLog.Visible = false;
            // 
            // LMSManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1018, 706);
            this.Controls.Add(this.lnkTransactionLog);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.lnkExit);
            this.Controls.Add(this.pbxFinanceSolutions);
            this.Controls.Add(this.pbxChartOfAccountSolution);
            this.Controls.Add(this.pbxMemberSolution);
            this.Controls.Add(this.stsStrip);
            this.Controls.Add(this.pbxDisbursementSolution);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 738);
            this.MinimumSize = new System.Drawing.Size(1020, 736);
            this.Name = "LMSManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Management System";
            this.stsStrip.ResumeLayout(false);
            this.stsStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisbursementSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChartOfAccountSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinanceSolutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolSpace;
        private System.Windows.Forms.ToolStripStatusLabel lblSpaceSeparate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbltime;
        private System.Windows.Forms.PictureBox pbxMemberSolution;
        private System.Windows.Forms.PictureBox pbxDisbursementSolution;
        private System.Windows.Forms.PictureBox pbxChartOfAccountSolution;
        private System.Windows.Forms.PictureBox pbxFinanceSolutions;
        private System.Windows.Forms.LinkLabel lnkExit;
        private System.Windows.Forms.LinkLabel lnkUser;
        private System.Windows.Forms.LinkLabel lnkTransactionLog;
    }
}