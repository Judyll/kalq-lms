using System;
using System.Collections.Generic;
using System.Text;

namespace AdministratorServices
{
    internal partial class UserInfoAdminCreate : UserInfoAdmin
    {
        protected System.Windows.Forms.Button btnCreate;
        protected System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoAdminCreate));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeneficiaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).BeginInit();
            this.panel3.SuspendLayout();
            this.tblPerson.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneralInformation)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).BeginInit();
            this.tabCntPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Controls.Add(this.btnCancel);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(809, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 23);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "  Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(901, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "  Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UserInfoAdminCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(994, 712);
            this.Name = "UserInfoAdminCreate";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeneficiaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tblPerson.ResumeLayout(false);
            this.tblPerson.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneralInformation)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).EndInit();
            this.tabCntPerson.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
