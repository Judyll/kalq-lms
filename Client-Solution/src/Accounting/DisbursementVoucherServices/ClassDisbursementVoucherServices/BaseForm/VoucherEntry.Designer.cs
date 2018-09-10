namespace DisbursementVoucherServices
{
    partial class VoucherEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoucherEntry));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxCollateral = new System.Windows.Forms.GroupBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchDepartment = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.gbxCollateral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(133)))));
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 35);
            this.panel3.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 58);
            this.panel1.TabIndex = 35;
            // 
            // gbxCollateral
            // 
            this.gbxCollateral.Controls.Add(this.txtDebit);
            this.gbxCollateral.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCollateral.ForeColor = System.Drawing.Color.Navy;
            this.gbxCollateral.Location = new System.Drawing.Point(14, 148);
            this.gbxCollateral.Name = "gbxCollateral";
            this.gbxCollateral.Size = new System.Drawing.Size(340, 69);
            this.gbxCollateral.TabIndex = 2;
            this.gbxCollateral.TabStop = false;
            this.gbxCollateral.Text = " DEBIT AMOUNT ";
            // 
            // txtDebit
            // 
            this.txtDebit.BackColor = System.Drawing.Color.White;
            this.txtDebit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebit.ForeColor = System.Drawing.Color.Red;
            this.txtDebit.Location = new System.Drawing.Point(11, 22);
            this.txtDebit.MaxLength = 50;
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(318, 31);
            this.txtDebit.TabIndex = 0;
            this.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchAccount);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(14, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ACCOUNT INFORMATION ";
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchAccount.BackgroundImage")));
            this.btnSearchAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAccount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchAccount.Location = new System.Drawing.Point(307, 29);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(22, 22);
            this.btnSearchAccount.TabIndex = 1;
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.White;
            this.txtAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(11, 27);
            this.txtAccount.MaxLength = 50;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(290, 27);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchDepartment);
            this.groupBox2.Controls.Add(this.txtDepartment);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(360, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " COST CENTER ";
            // 
            // btnSearchDepartment
            // 
            this.btnSearchDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchDepartment.BackgroundImage")));
            this.btnSearchDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDepartment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDepartment.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchDepartment.Location = new System.Drawing.Point(307, 29);
            this.btnSearchDepartment.Name = "btnSearchDepartment";
            this.btnSearchDepartment.Size = new System.Drawing.Size(22, 22);
            this.btnSearchDepartment.TabIndex = 1;
            this.btnSearchDepartment.UseVisualStyleBackColor = true;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.White;
            this.txtDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(11, 27);
            this.txtDepartment.MaxLength = 50;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(290, 27);
            this.txtDepartment.TabIndex = 0;
            this.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCredit);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(360, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 69);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " CREDIT AMOUNT ";
            // 
            // txtCredit
            // 
            this.txtCredit.BackColor = System.Drawing.Color.White;
            this.txtCredit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.ForeColor = System.Drawing.Color.Red;
            this.txtCredit.Location = new System.Drawing.Point(11, 22);
            this.txtCredit.MaxLength = 50;
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(318, 31);
            this.txtCredit.TabIndex = 0;
            this.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VoucherEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(717, 270);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxCollateral);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoucherEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbxCollateral.ResumeLayout(false);
            this.gbxCollateral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxCollateral;
        protected System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button btnSearchAccount;
        protected System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button btnSearchDepartment;
        protected System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.TextBox txtCredit;
    }
}