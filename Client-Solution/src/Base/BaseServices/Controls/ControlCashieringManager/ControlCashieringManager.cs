using System;
using System.Collections.Generic;
using System.Text;

namespace BaseServices.Controls
{
    public partial class ControlCashieringManager : BaseServices.Control.ControlManager
    {
        protected System.Windows.Forms.GroupBox gbxOfficeEmployer;
        protected System.Windows.Forms.LinkLabel lnkOfficeEmployer;
        protected System.Windows.Forms.Label lblOfficeCount;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.CheckedListBox cbxOfficeEmployer;
        private System.Windows.Forms.TabControl tabManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.TextBox txtReceiptNo;
        protected System.Windows.Forms.LinkLabel lnkIncrement;
        protected System.Windows.Forms.LinkLabel lnkDecrement;
        protected System.Windows.Forms.TextBox txtQueryCashiering;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.LinkLabel linkLabel1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.CheckedListBox checkedListBox1;
        protected System.Windows.Forms.LinkLabel lnkCashReceiptsSummarized;
        protected System.Windows.Forms.LinkLabel lnkCashReceiptsDetailed;
        protected System.Windows.Forms.PictureBox pbxMiscellaneousIncome;
        protected System.Windows.Forms.LinkLabel lnkResetQuery;
    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCashieringManager));
            this.gbxOfficeEmployer = new System.Windows.Forms.GroupBox();
            this.lnkOfficeEmployer = new System.Windows.Forms.LinkLabel();
            this.lblOfficeCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOfficeEmployer = new System.Windows.Forms.CheckedListBox();
            this.lnkResetQuery = new System.Windows.Forms.LinkLabel();
            this.tabManager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtQueryCashiering = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lnkCashReceiptsSummarized = new System.Windows.Forms.LinkLabel();
            this.lnkCashReceiptsDetailed = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.lnkIncrement = new System.Windows.Forms.LinkLabel();
            this.lnkDecrement = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pbxMiscellaneousIncome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.gbxOfficeEmployer.SuspendLayout();
            this.tabManager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiscellaneousIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // ttpMain
            // 
            this.ttpMain.AutoPopDelay = 3000;
            this.ttpMain.InitialDelay = 500;
            this.ttpMain.IsBalloon = true;
            this.ttpMain.ReshowDelay = 100;
            this.ttpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpMain.ToolTipTitle = "Console";
            // 
            // pbxFind
            // 
            this.pbxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxFind.Location = new System.Drawing.Point(8, 116);
            this.pbxFind.Visible = false;
            // 
            // pbxClose
            // 
            this.ttpMain.SetToolTip(this.pbxClose, "Done");
            // 
            // pbxRefresh
            // 
            this.ttpMain.SetToolTip(this.pbxRefresh, "Refresh");
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(52, 128);
            this.txtSearch.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbxMiscellaneousIncome);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.lnkResetQuery);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.tabManager);
            this.pnlMain.Size = new System.Drawing.Size(255, 556);
            this.pnlMain.Controls.SetChildIndex(this.txtSearch, 0);
            this.pnlMain.Controls.SetChildIndex(this.pbxFind, 0);
            this.pnlMain.Controls.SetChildIndex(this.tabManager, 0);
            this.pnlMain.Controls.SetChildIndex(this.pbxRefresh, 0);
            this.pnlMain.Controls.SetChildIndex(this.pbxClose, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlMain.Controls.SetChildIndex(this.lnkResetQuery, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox3, 0);
            this.pnlMain.Controls.SetChildIndex(this.pbxMiscellaneousIncome, 0);
            this.pnlMain.Controls.SetChildIndex(this.pnlHeader, 0);
            // 
            // gbxOfficeEmployer
            // 
            this.gbxOfficeEmployer.Controls.Add(this.lnkOfficeEmployer);
            this.gbxOfficeEmployer.Controls.Add(this.lblOfficeCount);
            this.gbxOfficeEmployer.Controls.Add(this.label1);
            this.gbxOfficeEmployer.Controls.Add(this.cbxOfficeEmployer);
            this.gbxOfficeEmployer.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOfficeEmployer.Location = new System.Drawing.Point(6, 38);
            this.gbxOfficeEmployer.Name = "gbxOfficeEmployer";
            this.gbxOfficeEmployer.Size = new System.Drawing.Size(224, 266);
            this.gbxOfficeEmployer.TabIndex = 1;
            this.gbxOfficeEmployer.TabStop = false;
            this.gbxOfficeEmployer.Text = "Query by Office/Employer";
            // 
            // lnkOfficeEmployer
            // 
            this.lnkOfficeEmployer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkOfficeEmployer.AutoSize = true;
            this.lnkOfficeEmployer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOfficeEmployer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkOfficeEmployer.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkOfficeEmployer.Location = new System.Drawing.Point(134, 245);
            this.lnkOfficeEmployer.Name = "lnkOfficeEmployer";
            this.lnkOfficeEmployer.Size = new System.Drawing.Size(84, 14);
            this.lnkOfficeEmployer.TabIndex = 2;
            this.lnkOfficeEmployer.TabStop = true;
            this.lnkOfficeEmployer.Text = "| Select None |";
            // 
            // lblOfficeCount
            // 
            this.lblOfficeCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOfficeCount.AutoSize = true;
            this.lblOfficeCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeCount.ForeColor = System.Drawing.Color.Red;
            this.lblOfficeCount.Location = new System.Drawing.Point(60, 242);
            this.lblOfficeCount.Name = "lblOfficeCount";
            this.lblOfficeCount.Size = new System.Drawing.Size(18, 19);
            this.lblOfficeCount.TabIndex = 1;
            this.lblOfficeCount.Text = "0";
            this.lblOfficeCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(4, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selected:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOfficeEmployer
            // 
            this.cbxOfficeEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbxOfficeEmployer.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbxOfficeEmployer.CheckOnClick = true;
            this.cbxOfficeEmployer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOfficeEmployer.FormattingEnabled = true;
            this.cbxOfficeEmployer.HorizontalScrollbar = true;
            this.cbxOfficeEmployer.Location = new System.Drawing.Point(7, 17);
            this.cbxOfficeEmployer.Name = "cbxOfficeEmployer";
            this.cbxOfficeEmployer.Size = new System.Drawing.Size(211, 220);
            this.cbxOfficeEmployer.TabIndex = 0;
            this.cbxOfficeEmployer.ThreeDCheckBoxes = true;
            // 
            // lnkResetQuery
            // 
            this.lnkResetQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkResetQuery.AutoSize = true;
            this.lnkResetQuery.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkResetQuery.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkResetQuery.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkResetQuery.Location = new System.Drawing.Point(77, 536);
            this.lnkResetQuery.Name = "lnkResetQuery";
            this.lnkResetQuery.Size = new System.Drawing.Size(90, 14);
            this.lnkResetQuery.TabIndex = 3;
            this.lnkResetQuery.TabStop = true;
            this.lnkResetQuery.Text = "| RESET QUERY |";
            // 
            // tabManager
            // 
            this.tabManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tabManager.Controls.Add(this.tabPage1);
            this.tabManager.Controls.Add(this.tabPage2);
            this.tabManager.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManager.Location = new System.Drawing.Point(6, 67);
            this.tabManager.Name = "tabManager";
            this.tabManager.SelectedIndex = 0;
            this.tabManager.Size = new System.Drawing.Size(244, 337);
            this.tabManager.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.txtQueryCashiering);
            this.tabPage1.Controls.Add(this.gbxOfficeEmployer);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtQueryCashiering
            // 
            this.txtQueryCashiering.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtQueryCashiering.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtQueryCashiering.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueryCashiering.Location = new System.Drawing.Point(6, 7);
            this.txtQueryCashiering.MaxLength = 50;
            this.txtQueryCashiering.Name = "txtQueryCashiering";
            this.txtQueryCashiering.Size = new System.Drawing.Size(224, 26);
            this.txtQueryCashiering.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lnkCashReceiptsSummarized);
            this.tabPage2.Controls.Add(this.lnkCashReceiptsDetailed);
            this.tabPage2.ForeColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lnkCashReceiptsSummarized
            // 
            this.lnkCashReceiptsSummarized.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkCashReceiptsSummarized.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCashReceiptsSummarized.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCashReceiptsSummarized.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkCashReceiptsSummarized.Location = new System.Drawing.Point(2, 31);
            this.lnkCashReceiptsSummarized.Name = "lnkCashReceiptsSummarized";
            this.lnkCashReceiptsSummarized.Size = new System.Drawing.Size(233, 26);
            this.lnkCashReceiptsSummarized.TabIndex = 24;
            this.lnkCashReceiptsSummarized.TabStop = true;
            this.lnkCashReceiptsSummarized.Text = "Cash Receipts (Summarized)";
            this.lnkCashReceiptsSummarized.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkCashReceiptsDetailed
            // 
            this.lnkCashReceiptsDetailed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkCashReceiptsDetailed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCashReceiptsDetailed.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCashReceiptsDetailed.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkCashReceiptsDetailed.Location = new System.Drawing.Point(2, 5);
            this.lnkCashReceiptsDetailed.Name = "lnkCashReceiptsDetailed";
            this.lnkCashReceiptsDetailed.Size = new System.Drawing.Size(233, 26);
            this.lnkCashReceiptsDetailed.TabIndex = 23;
            this.lnkCashReceiptsDetailed.TabStop = true;
            this.lnkCashReceiptsDetailed.Text = "Cash Receipts (Detailed)";
            this.lnkCashReceiptsDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.dtpReceiptDate);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receipt Date";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpReceiptDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpReceiptDate.CalendarMonthBackground = System.Drawing.Color.GhostWhite;
            this.dtpReceiptDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(133)))));
            this.dtpReceiptDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpReceiptDate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiptDate.Location = new System.Drawing.Point(6, 22);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(228, 22);
            this.dtpReceiptDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.txtReceiptNo);
            this.groupBox2.Controls.Add(this.lnkIncrement);
            this.groupBox2.Controls.Add(this.lnkDecrement);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Receipt No.";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtReceiptNo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtReceiptNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptNo.ForeColor = System.Drawing.Color.Red;
            this.txtReceiptNo.Location = new System.Drawing.Point(50, 20);
            this.txtReceiptNo.MaxLength = 10;
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(139, 27);
            this.txtReceiptNo.TabIndex = 1;
            this.txtReceiptNo.Text = "000000";
            this.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnkIncrement
            // 
            this.lnkIncrement.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkIncrement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIncrement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkIncrement.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkIncrement.Location = new System.Drawing.Point(191, 20);
            this.lnkIncrement.Name = "lnkIncrement";
            this.lnkIncrement.Size = new System.Drawing.Size(42, 26);
            this.lnkIncrement.TabIndex = 2;
            this.lnkIncrement.TabStop = true;
            this.lnkIncrement.Text = "| >> |";
            this.lnkIncrement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkDecrement
            // 
            this.lnkDecrement.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnkDecrement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDecrement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDecrement.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkDecrement.Location = new System.Drawing.Point(7, 20);
            this.lnkDecrement.Name = "lnkDecrement";
            this.lnkDecrement.Size = new System.Drawing.Size(42, 26);
            this.lnkDecrement.TabIndex = 0;
            this.lnkDecrement.TabStop = true;
            this.lnkDecrement.Text = "| << |";
            this.lnkDecrement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 233);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query by Office/Employer";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.Location = new System.Drawing.Point(133, 212);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 14);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "| Select None |";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(59, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(3, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selected:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkedListBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(211, 184);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // pbxMiscellaneousIncome
            // 
            this.pbxMiscellaneousIncome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbxMiscellaneousIncome.BackColor = System.Drawing.Color.Transparent;
            this.pbxMiscellaneousIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxMiscellaneousIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMiscellaneousIncome.Image = ((System.Drawing.Image)(resources.GetObject("pbxMiscellaneousIncome.Image")));
            this.pbxMiscellaneousIncome.Location = new System.Drawing.Point(136, 37);
            this.pbxMiscellaneousIncome.Name = "pbxMiscellaneousIncome";
            this.pbxMiscellaneousIncome.Size = new System.Drawing.Size(33, 41);
            this.pbxMiscellaneousIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMiscellaneousIncome.TabIndex = 19;
            this.pbxMiscellaneousIncome.TabStop = false;
            // 
            // ControlCashieringManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ControlCashieringManager";
            this.Size = new System.Drawing.Size(255, 556);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbxOfficeEmployer.ResumeLayout(false);
            this.gbxOfficeEmployer.PerformLayout();
            this.tabManager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiscellaneousIncome)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
