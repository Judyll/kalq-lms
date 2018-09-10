namespace DisbursementVoucherServices
{
    partial class DisbursementVoucher
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisbursementVoucher));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxCollateral = new System.Windows.Forms.GroupBox();
            this.txtCheckAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchPayee = new System.Windows.Forms.Button();
            this.btnSearchBank = new System.Windows.Forms.Button();
            this.txtParticulars = new System.Windows.Forms.TextBox();
            this.txtPayee = new System.Windows.Forms.TextBox();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.dtpCheckDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxVoucherEntry = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDebit = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lnkPrintVoucher = new System.Windows.Forms.LinkLabel();
            this.lnkCreateVouchEntry = new System.Windows.Forms.LinkLabel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lblAddVoucherBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lblAddVoucherAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkAddVoucherEntry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDeleteVoucherEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxSysID = new System.Windows.Forms.GroupBox();
            this.lblSysID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbxUnlock = new System.Windows.Forms.PictureBox();
            this.pbxLocked = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemovePayee = new System.Windows.Forms.Button();
            this.gbxCollateral.SuspendLayout();
            this.gbxVoucherEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.lnkAddVoucherEntry.SuspendLayout();
            this.gbxSysID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocked)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(133)))));
            this.panel3.Location = new System.Drawing.Point(0, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 35);
            this.panel3.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 58);
            this.panel1.TabIndex = 33;
            // 
            // gbxCollateral
            // 
            this.gbxCollateral.Controls.Add(this.btnRemovePayee);
            this.gbxCollateral.Controls.Add(this.txtCheckAmount);
            this.gbxCollateral.Controls.Add(this.label3);
            this.gbxCollateral.Controls.Add(this.btnSearchPayee);
            this.gbxCollateral.Controls.Add(this.btnSearchBank);
            this.gbxCollateral.Controls.Add(this.txtParticulars);
            this.gbxCollateral.Controls.Add(this.txtPayee);
            this.gbxCollateral.Controls.Add(this.txtCheckNo);
            this.gbxCollateral.Controls.Add(this.txtBank);
            this.gbxCollateral.Controls.Add(this.dtpCheckDate);
            this.gbxCollateral.Controls.Add(this.label5);
            this.gbxCollateral.Controls.Add(this.label4);
            this.gbxCollateral.Controls.Add(this.label2);
            this.gbxCollateral.Controls.Add(this.label6);
            this.gbxCollateral.Controls.Add(this.label1);
            this.gbxCollateral.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCollateral.ForeColor = System.Drawing.Color.Navy;
            this.gbxCollateral.Location = new System.Drawing.Point(12, 126);
            this.gbxCollateral.Name = "gbxCollateral";
            this.gbxCollateral.Size = new System.Drawing.Size(787, 136);
            this.gbxCollateral.TabIndex = 35;
            this.gbxCollateral.TabStop = false;
            this.gbxCollateral.Text = " CHECK INFORMATION ";
            // 
            // txtCheckAmount
            // 
            this.txtCheckAmount.BackColor = System.Drawing.Color.White;
            this.txtCheckAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckAmount.ForeColor = System.Drawing.Color.Red;
            this.txtCheckAmount.Location = new System.Drawing.Point(480, 93);
            this.txtCheckAmount.MaxLength = 50;
            this.txtCheckAmount.Name = "txtCheckAmount";
            this.txtCheckAmount.Size = new System.Drawing.Size(272, 27);
            this.txtCheckAmount.TabIndex = 36;
            this.txtCheckAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(418, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Amount:";
            // 
            // btnSearchPayee
            // 
            this.btnSearchPayee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPayee.BackgroundImage")));
            this.btnSearchPayee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPayee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPayee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPayee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPayee.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchPayee.Location = new System.Drawing.Point(359, 61);
            this.btnSearchPayee.Name = "btnSearchPayee";
            this.btnSearchPayee.Size = new System.Drawing.Size(22, 22);
            this.btnSearchPayee.TabIndex = 81;
            this.btnSearchPayee.UseVisualStyleBackColor = true;
            // 
            // btnSearchBank
            // 
            this.btnSearchBank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBank.BackgroundImage")));
            this.btnSearchBank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBank.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBank.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchBank.Location = new System.Drawing.Point(758, 61);
            this.btnSearchBank.Name = "btnSearchBank";
            this.btnSearchBank.Size = new System.Drawing.Size(22, 22);
            this.btnSearchBank.TabIndex = 80;
            this.btnSearchBank.UseVisualStyleBackColor = true;
            // 
            // txtParticulars
            // 
            this.txtParticulars.BackColor = System.Drawing.Color.White;
            this.txtParticulars.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticulars.Location = new System.Drawing.Point(81, 93);
            this.txtParticulars.MaxLength = 50;
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.Size = new System.Drawing.Size(272, 23);
            this.txtParticulars.TabIndex = 79;
            // 
            // txtPayee
            // 
            this.txtPayee.BackColor = System.Drawing.Color.White;
            this.txtPayee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayee.Location = new System.Drawing.Point(81, 62);
            this.txtPayee.MaxLength = 50;
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.Size = new System.Drawing.Size(272, 23);
            this.txtPayee.TabIndex = 78;
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.BackColor = System.Drawing.Color.White;
            this.txtCheckNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckNo.Location = new System.Drawing.Point(81, 30);
            this.txtCheckNo.MaxLength = 50;
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(272, 23);
            this.txtCheckNo.TabIndex = 77;
            // 
            // txtBank
            // 
            this.txtBank.BackColor = System.Drawing.Color.White;
            this.txtBank.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(480, 62);
            this.txtBank.MaxLength = 50;
            this.txtBank.Name = "txtBank";
            this.txtBank.ReadOnly = true;
            this.txtBank.Size = new System.Drawing.Size(272, 23);
            this.txtBank.TabIndex = 76;
            // 
            // dtpCheckDate
            // 
            this.dtpCheckDate.Checked = false;
            this.dtpCheckDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckDate.Location = new System.Drawing.Point(480, 30);
            this.dtpCheckDate.Name = "dtpCheckDate";
            this.dtpCheckDate.Size = new System.Drawing.Size(272, 23);
            this.dtpCheckDate.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(437, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 75;
            this.label5.Text = "Bank:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Particulars:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "Payee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(437, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Check No.:";
            // 
            // gbxVoucherEntry
            // 
            this.gbxVoucherEntry.Controls.Add(this.label9);
            this.gbxVoucherEntry.Controls.Add(this.lblDebit);
            this.gbxVoucherEntry.Controls.Add(this.lblCredit);
            this.gbxVoucherEntry.Controls.Add(this.lnkPrintVoucher);
            this.gbxVoucherEntry.Controls.Add(this.lnkCreateVouchEntry);
            this.gbxVoucherEntry.Controls.Add(this.dgvList);
            this.gbxVoucherEntry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVoucherEntry.ForeColor = System.Drawing.Color.Navy;
            this.gbxVoucherEntry.Location = new System.Drawing.Point(13, 268);
            this.gbxVoucherEntry.Name = "gbxVoucherEntry";
            this.gbxVoucherEntry.Size = new System.Drawing.Size(787, 344);
            this.gbxVoucherEntry.TabIndex = 36;
            this.gbxVoucherEntry.TabStop = false;
            this.gbxVoucherEntry.Text = " VOUCHER ENTRY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(473, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "Totals:";
            // 
            // lblDebit
            // 
            this.lblDebit.BackColor = System.Drawing.Color.Transparent;
            this.lblDebit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.ForeColor = System.Drawing.Color.Red;
            this.lblDebit.Location = new System.Drawing.Point(534, 309);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(119, 29);
            this.lblDebit.TabIndex = 80;
            this.lblDebit.Text = "0.00";
            this.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCredit
            // 
            this.lblCredit.BackColor = System.Drawing.Color.Transparent;
            this.lblCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.ForeColor = System.Drawing.Color.Red;
            this.lblCredit.Location = new System.Drawing.Point(659, 309);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(119, 29);
            this.lblCredit.TabIndex = 79;
            this.lblCredit.Text = "0.00";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkPrintVoucher
            // 
            this.lnkPrintVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPrintVoucher.AutoSize = true;
            this.lnkPrintVoucher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPrintVoucher.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkPrintVoucher.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPrintVoucher.Location = new System.Drawing.Point(6, 321);
            this.lnkPrintVoucher.Name = "lnkPrintVoucher";
            this.lnkPrintVoucher.Size = new System.Drawing.Size(99, 15);
            this.lnkPrintVoucher.TabIndex = 78;
            this.lnkPrintVoucher.TabStop = true;
            this.lnkPrintVoucher.Text = "[ Print Voucher ]";
            this.lnkPrintVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkCreateVouchEntry
            // 
            this.lnkCreateVouchEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCreateVouchEntry.AutoSize = true;
            this.lnkCreateVouchEntry.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateVouchEntry.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateVouchEntry.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateVouchEntry.Location = new System.Drawing.Point(111, 321);
            this.lnkCreateVouchEntry.Name = "lnkCreateVouchEntry";
            this.lnkCreateVouchEntry.Size = new System.Drawing.Size(142, 15);
            this.lnkCreateVouchEntry.TabIndex = 77;
            this.lnkCreateVouchEntry.TabStop = true;
            this.lnkCreateVouchEntry.Text = "[ Create Voucher Entry ]";
            this.lnkCreateVouchEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(6, 21);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvList.Size = new System.Drawing.Size(775, 285);
            this.dgvList.TabIndex = 61;
            // 
            // lblAddVoucherBefore
            // 
            this.lblAddVoucherBefore.Name = "lblAddVoucherBefore";
            this.lblAddVoucherBefore.Size = new System.Drawing.Size(210, 22);
            this.lblAddVoucherBefore.Text = "Add Voucher Entry Before";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(207, 6);
            // 
            // lblAddVoucherAfter
            // 
            this.lblAddVoucherAfter.Name = "lblAddVoucherAfter";
            this.lblAddVoucherAfter.Size = new System.Drawing.Size(210, 22);
            this.lblAddVoucherAfter.Text = "Add Voucher Entry After";
            // 
            // lnkAddVoucherEntry
            // 
            this.lnkAddVoucherEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAddVoucherBefore,
            this.toolStripSeparator6,
            this.lblAddVoucherAfter,
            this.toolStripSeparator1,
            this.lblDeleteVoucherEntry});
            this.lnkAddVoucherEntry.Name = "cmsControl";
            this.lnkAddVoucherEntry.Size = new System.Drawing.Size(211, 82);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // lblDeleteVoucherEntry
            // 
            this.lblDeleteVoucherEntry.Name = "lblDeleteVoucherEntry";
            this.lblDeleteVoucherEntry.Size = new System.Drawing.Size(210, 22);
            this.lblDeleteVoucherEntry.Text = "Delete Voucher Entry";
            // 
            // gbxSysID
            // 
            this.gbxSysID.Controls.Add(this.lblSysID);
            this.gbxSysID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSysID.ForeColor = System.Drawing.Color.Navy;
            this.gbxSysID.Location = new System.Drawing.Point(504, 67);
            this.gbxSysID.Name = "gbxSysID";
            this.gbxSysID.Size = new System.Drawing.Size(295, 53);
            this.gbxSysID.TabIndex = 37;
            this.gbxSysID.TabStop = false;
            this.gbxSysID.Text = " VOUCHER NO ";
            // 
            // lblSysID
            // 
            this.lblSysID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysID.ForeColor = System.Drawing.Color.Black;
            this.lblSysID.Location = new System.Drawing.Point(14, 22);
            this.lblSysID.Name = "lblSysID";
            this.lblSysID.Size = new System.Drawing.Size(265, 18);
            this.lblSysID.TabIndex = 1;
            this.lblSysID.Text = "Acquiring...";
            this.lblSysID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(12, 69);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 45);
            this.lblStatus.TabIndex = 72;
            // 
            // pbxUnlock
            // 
            this.pbxUnlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUnlock.BackgroundImage")));
            this.pbxUnlock.Location = new System.Drawing.Point(14, 618);
            this.pbxUnlock.Name = "pbxUnlock";
            this.pbxUnlock.Size = new System.Drawing.Size(24, 24);
            this.pbxUnlock.TabIndex = 97;
            this.pbxUnlock.TabStop = false;
            // 
            // pbxLocked
            // 
            this.pbxLocked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLocked.BackgroundImage")));
            this.pbxLocked.Location = new System.Drawing.Point(14, 618);
            this.pbxLocked.Name = "pbxLocked";
            this.pbxLocked.Size = new System.Drawing.Size(24, 24);
            this.pbxLocked.TabIndex = 96;
            this.pbxLocked.TabStop = false;
            this.pbxLocked.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(39, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "This record is OPEN.";
            // 
            // btnRemovePayee
            // 
            this.btnRemovePayee.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePayee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemovePayee.BackgroundImage")));
            this.btnRemovePayee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemovePayee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePayee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePayee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePayee.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemovePayee.Location = new System.Drawing.Point(385, 61);
            this.btnRemovePayee.Name = "btnRemovePayee";
            this.btnRemovePayee.Size = new System.Drawing.Size(22, 22);
            this.btnRemovePayee.TabIndex = 82;
            this.btnRemovePayee.UseVisualStyleBackColor = false;
            // 
            // DisbursementVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(812, 682);
            this.Controls.Add(this.pbxUnlock);
            this.Controls.Add(this.pbxLocked);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbxSysID);
            this.Controls.Add(this.gbxVoucherEntry);
            this.Controls.Add(this.gbxCollateral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisbursementVoucher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbxCollateral.ResumeLayout(false);
            this.gbxCollateral.PerformLayout();
            this.gbxVoucherEntry.ResumeLayout(false);
            this.gbxVoucherEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.lnkAddVoucherEntry.ResumeLayout(false);
            this.gbxSysID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxCollateral;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtParticulars;
        protected System.Windows.Forms.TextBox txtPayee;
        protected System.Windows.Forms.TextBox txtCheckNo;
        protected System.Windows.Forms.TextBox txtBank;
        protected System.Windows.Forms.TextBox txtCheckAmount;
        public System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnSearchBank;
        protected System.Windows.Forms.Button btnSearchPayee;
        private System.Windows.Forms.GroupBox gbxVoucherEntry;
        protected System.Windows.Forms.DataGridView dgvList;
        protected System.Windows.Forms.LinkLabel lnkCreateVouchEntry;
        private System.Windows.Forms.ToolStripMenuItem lblAddVoucherBefore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem lblAddVoucherAfter;
        private System.Windows.Forms.ContextMenuStrip lnkAddVoucherEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem lblDeleteVoucherEntry;
        protected System.Windows.Forms.DateTimePicker dtpCheckDate;
        protected System.Windows.Forms.GroupBox gbxSysID;
        protected System.Windows.Forms.Label lblSysID;
        public System.Windows.Forms.Label lblStatus;
        protected System.Windows.Forms.LinkLabel lnkPrintVoucher;
        public System.Windows.Forms.Label lblDebit;
        public System.Windows.Forms.Label lblCredit;
        public System.Windows.Forms.Label label9;
        protected System.Windows.Forms.PictureBox pbxUnlock;
        protected System.Windows.Forms.PictureBox pbxLocked;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button btnRemovePayee;
    }
}