using System;
using System.Collections.Generic;
using System.Text;

namespace AdministratorServices
{
    internal partial class UserInfoAdmin : BaseServices.PersonInformationWithBeneficiaryReference
    {
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.GroupBox gbxAccessRights;
        protected System.Windows.Forms.DataGridView dgvList;
        public System.Windows.Forms.GroupBox groupBox5;
        protected System.Windows.Forms.Label lblStatus;
        protected System.Windows.Forms.TextBox txtConfirmPassword;
        protected System.Windows.Forms.TextBox txtPassword;
        protected System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        protected System.Windows.Forms.PictureBox pbxUserInfo;
        private System.Windows.Forms.TabPage tblUserInformation;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblUserInformation = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.gbxAccessRights = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pbxUserInfo = new System.Windows.Forms.PictureBox();
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
            this.tblUserInformation.SuspendLayout();
            this.gbxAccessRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPerson
            // 
            this.tblPerson.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxUserInfo);
            this.panel2.Controls.SetChildIndex(this.pbxGeneralInformation, 0);
            this.panel2.Controls.SetChildIndex(this.pbxBeneficiaries, 0);
            this.panel2.Controls.SetChildIndex(this.pbxReferences, 0);
            this.panel2.Controls.SetChildIndex(this.pbxPersonalDocument, 0);
            this.panel2.Controls.SetChildIndex(this.pbxUserInfo, 0);
            // 
            // tabCntPerson
            // 
            this.tabCntPerson.Controls.Add(this.tblUserInformation);
            this.tabCntPerson.Controls.SetChildIndex(this.tblUserInformation, 0);
            this.tabCntPerson.Controls.SetChildIndex(this.tblPerson, 0);
            // 
            // tblUserInformation
            // 
            this.tblUserInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblUserInformation.Controls.Add(this.label19);
            this.tblUserInformation.Controls.Add(this.gbxAccessRights);
            this.tblUserInformation.Controls.Add(this.groupBox5);
            this.tblUserInformation.Location = new System.Drawing.Point(4, 24);
            this.tblUserInformation.Name = "tblUserInformation";
            this.tblUserInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tblUserInformation.Size = new System.Drawing.Size(812, 579);
            this.tblUserInformation.TabIndex = 4;
            this.tblUserInformation.Text = "User Information";
            this.tblUserInformation.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Orange;
            this.label19.Location = new System.Drawing.Point(662, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 20);
            this.label19.TabIndex = 101;
            this.label19.Text = "User Information";
            // 
            // gbxAccessRights
            // 
            this.gbxAccessRights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxAccessRights.Controls.Add(this.dgvList);
            this.gbxAccessRights.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAccessRights.ForeColor = System.Drawing.Color.Navy;
            this.gbxAccessRights.Location = new System.Drawing.Point(407, 33);
            this.gbxAccessRights.Name = "gbxAccessRights";
            this.gbxAccessRights.Size = new System.Drawing.Size(390, 538);
            this.gbxAccessRights.TabIndex = 100;
            this.gbxAccessRights.TabStop = false;
            this.gbxAccessRights.Text = " ACCESS RIGHTS ";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 18);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 15;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(384, 517);
            this.dgvList.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.lblStatus);
            this.groupBox5.Controls.Add(this.txtConfirmPassword);
            this.groupBox5.Controls.Add(this.txtPassword);
            this.groupBox5.Controls.Add(this.txtUserName);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(11, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 142);
            this.groupBox5.TabIndex = 99;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " USER AUTHENTICATION ";
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(6, 114);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(382, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "ACTIVE";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(122, 88);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(247, 22);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(122, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(247, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(122, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(6, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 15);
            this.label20.TabIndex = 22;
            this.label20.Text = "Confirm Password:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(44, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 15);
            this.label22.TabIndex = 17;
            this.label22.Text = "User Name:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(53, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 15);
            this.label23.TabIndex = 18;
            this.label23.Text = "Password:";
            // 
            // pbxUserInfo
            // 
            this.pbxUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbxUserInfo.BackgroundImage = global::AdministratorServices.Properties.Resources.lmsUusers;
            this.pbxUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserInfo.Location = new System.Drawing.Point(0, 117);
            this.pbxUserInfo.Name = "pbxUserInfo";
            this.pbxUserInfo.Size = new System.Drawing.Size(161, 25);
            this.pbxUserInfo.TabIndex = 7;
            this.pbxUserInfo.TabStop = false;
            // 
            // UserInfoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(994, 712);
            this.Name = "UserInfoAdmin";
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
            this.tblUserInformation.ResumeLayout(false);
            this.tblUserInformation.PerformLayout();
            this.gbxAccessRights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserInfo)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
