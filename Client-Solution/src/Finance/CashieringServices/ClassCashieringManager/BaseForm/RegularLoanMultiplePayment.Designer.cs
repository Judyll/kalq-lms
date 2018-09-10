namespace CashieringServices
{
    partial class RegularLoanMultiplePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularLoanMultiplePayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPaymentList = new System.Windows.Forms.DataGridView();
            this.chkIncludeInterest = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpReflectedDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCreditEntry = new System.Windows.Forms.TextBox();
            this.btnSearchCreditEntry = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnRecord);
            this.panel3.Location = new System.Drawing.Point(0, 591);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 35);
            this.panel3.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(896, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "  Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecord.BackgroundImage")));
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(815, 7);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 15;
            this.btnRecord.Text = "    Record";
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 58);
            this.panel1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPaymentList);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 455);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " PAYMENT LIST ";
            // 
            // dgvPaymentList
            // 
            this.dgvPaymentList.AllowUserToAddRows = false;
            this.dgvPaymentList.AllowUserToDeleteRows = false;
            this.dgvPaymentList.AllowUserToResizeColumns = false;
            this.dgvPaymentList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPaymentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentList.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvPaymentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaymentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentList.Location = new System.Drawing.Point(3, 18);
            this.dgvPaymentList.Name = "dgvPaymentList";
            this.dgvPaymentList.RowHeadersVisible = false;
            this.dgvPaymentList.RowHeadersWidth = 15;
            this.dgvPaymentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            this.dgvPaymentList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPaymentList.Size = new System.Drawing.Size(964, 434);
            this.dgvPaymentList.TabIndex = 1;
            // 
            // chkIncludeInterest
            // 
            this.chkIncludeInterest.AutoSize = true;
            this.chkIncludeInterest.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeInterest.ForeColor = System.Drawing.Color.Black;
            this.chkIncludeInterest.Location = new System.Drawing.Point(11, 18);
            this.chkIncludeInterest.Name = "chkIncludeInterest";
            this.chkIncludeInterest.Size = new System.Drawing.Size(102, 18);
            this.chkIncludeInterest.TabIndex = 105;
            this.chkIncludeInterest.Text = "Include Interest";
            this.chkIncludeInterest.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIncludeInterest);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 49);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpReflectedDate);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(143, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 49);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Reflected Date ";
            // 
            // dtpReflectedDate
            // 
            this.dtpReflectedDate.Location = new System.Drawing.Point(14, 18);
            this.dtpReflectedDate.Name = "dtpReflectedDate";
            this.dtpReflectedDate.Size = new System.Drawing.Size(219, 22);
            this.dtpReflectedDate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpReceiptDate);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(396, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 49);
            this.groupBox4.TabIndex = 108;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Receipt Date ";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Location = new System.Drawing.Point(14, 18);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(219, 22);
            this.dtpReceiptDate.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCreditEntry);
            this.groupBox5.Controls.Add(this.btnSearchCreditEntry);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(649, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 49);
            this.groupBox5.TabIndex = 109;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Credit Entry ";
            // 
            // txtCreditEntry
            // 
            this.txtCreditEntry.BackColor = System.Drawing.Color.White;
            this.txtCreditEntry.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditEntry.Location = new System.Drawing.Point(6, 17);
            this.txtCreditEntry.MaxLength = 100;
            this.txtCreditEntry.Name = "txtCreditEntry";
            this.txtCreditEntry.ReadOnly = true;
            this.txtCreditEntry.Size = new System.Drawing.Size(293, 26);
            this.txtCreditEntry.TabIndex = 11;
            // 
            // btnSearchCreditEntry
            // 
            this.btnSearchCreditEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCreditEntry.BackgroundImage")));
            this.btnSearchCreditEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCreditEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCreditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCreditEntry.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCreditEntry.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchCreditEntry.Location = new System.Drawing.Point(305, 18);
            this.btnSearchCreditEntry.Name = "btnSearchCreditEntry";
            this.btnSearchCreditEntry.Size = new System.Drawing.Size(22, 22);
            this.btnSearchCreditEntry.TabIndex = 12;
            this.btnSearchCreditEntry.UseVisualStyleBackColor = true;
            // 
            // RegularLoanMultiplePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(994, 626);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegularLoanMultiplePayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.DataGridView dgvPaymentList;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.CheckBox chkIncludeInterest;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpReflectedDate;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        public System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCreditEntry;
        protected System.Windows.Forms.Button btnSearchCreditEntry;
    }
}