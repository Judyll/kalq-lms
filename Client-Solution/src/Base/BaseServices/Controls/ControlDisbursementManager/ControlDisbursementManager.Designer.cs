namespace BaseServices.Control
{
    partial class ControlDisbursementManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIncludeDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCanceledVoucher = new System.Windows.Forms.RadioButton();
            this.rdbIssuedVoucher = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // pbxClose
            // 
            this.ttpMain.SetToolTip(this.pbxClose, "Done");
            // 
            // pbxRefresh
            // 
            this.ttpMain.SetToolTip(this.pbxRefresh, "Refresh");
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Size = new System.Drawing.Size(255, 330);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtSearch, 0);
            this.pnlMain.Controls.SetChildIndex(this.pbxRefresh, 0);
            this.pnlMain.Controls.SetChildIndex(this.pbxClose, 0);
            this.pnlMain.Controls.SetChildIndex(this.pbxFind, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlMain.Controls.SetChildIndex(this.pnlHeader, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.chkIncludeDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpDateEnd);
            this.groupBox2.Controls.Add(this.dtpDateStart);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 124);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // chkIncludeDate
            // 
            this.chkIncludeDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkIncludeDate.AutoSize = true;
            this.chkIncludeDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeDate.ForeColor = System.Drawing.Color.Blue;
            this.chkIncludeDate.Location = new System.Drawing.Point(10, 0);
            this.chkIncludeDate.Name = "chkIncludeDate";
            this.chkIncludeDate.Size = new System.Drawing.Size(88, 18);
            this.chkIncludeDate.TabIndex = 3;
            this.chkIncludeDate.Text = "Include Date";
            this.chkIncludeDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date End";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Start";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpDateEnd.Enabled = false;
            this.dtpDateEnd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEnd.Location = new System.Drawing.Point(6, 87);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(226, 23);
            this.dtpDateEnd.TabIndex = 0;
            this.dtpDateEnd.Value = new System.DateTime(2010, 11, 10, 0, 0, 0, 0);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpDateStart.Enabled = false;
            this.dtpDateStart.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateStart.Location = new System.Drawing.Point(6, 40);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(226, 23);
            this.dtpDateStart.TabIndex = 0;
            this.dtpDateStart.Value = new System.DateTime(2010, 11, 10, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.rdbCanceledVoucher);
            this.groupBox1.Controls.Add(this.rdbIssuedVoucher);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 51);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rdbCanceledVoucher
            // 
            this.rdbCanceledVoucher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdbCanceledVoucher.AutoSize = true;
            this.rdbCanceledVoucher.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCanceledVoucher.Location = new System.Drawing.Point(122, 20);
            this.rdbCanceledVoucher.Name = "rdbCanceledVoucher";
            this.rdbCanceledVoucher.Size = new System.Drawing.Size(113, 17);
            this.rdbCanceledVoucher.TabIndex = 1;
            this.rdbCanceledVoucher.Text = "Cancelled Voucher";
            this.rdbCanceledVoucher.UseVisualStyleBackColor = true;
            // 
            // rdbIssuedVoucher
            // 
            this.rdbIssuedVoucher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdbIssuedVoucher.AutoSize = true;
            this.rdbIssuedVoucher.Checked = true;
            this.rdbIssuedVoucher.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIssuedVoucher.Location = new System.Drawing.Point(14, 20);
            this.rdbIssuedVoucher.Name = "rdbIssuedVoucher";
            this.rdbIssuedVoucher.Size = new System.Drawing.Size(97, 17);
            this.rdbIssuedVoucher.TabIndex = 0;
            this.rdbIssuedVoucher.TabStop = true;
            this.rdbIssuedVoucher.Text = "Issued Voucher";
            this.rdbIssuedVoucher.UseVisualStyleBackColor = true;
            // 
            // ControlDisbursementManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ControlDisbursementManager";
            this.Size = new System.Drawing.Size(255, 330);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker dtpDateEnd;
        public System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.CheckBox chkIncludeDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCanceledVoucher;
        private System.Windows.Forms.RadioButton rdbIssuedVoucher;
    }
}
