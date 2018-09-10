using System;
using System.Collections.Generic;
using System.Text;

namespace MemberServices
{
    internal partial class ShareCapitalCreditCreate : ShareCapitalCredit
    {
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAllowMultipleInsert;
        private System.Windows.Forms.Button btnCreate;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShareCapitalCreditCreate));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chkAllowMultipleInsert = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShareUnLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShareLock)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Controls.Add(this.chkAllowMultipleInsert);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(825, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "  Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(733, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 24);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "   Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // chkAllowMultipleInsert
            // 
            this.chkAllowMultipleInsert.AutoSize = true;
            this.chkAllowMultipleInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllowMultipleInsert.ForeColor = System.Drawing.Color.Maroon;
            this.chkAllowMultipleInsert.Location = new System.Drawing.Point(19, 7);
            this.chkAllowMultipleInsert.Name = "chkAllowMultipleInsert";
            this.chkAllowMultipleInsert.Size = new System.Drawing.Size(172, 23);
            this.chkAllowMultipleInsert.TabIndex = 211;
            this.chkAllowMultipleInsert.Text = "Allow Multiple Insert";
            this.chkAllowMultipleInsert.UseVisualStyleBackColor = true;
            // 
            // ShareCapitalCreditCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(931, 341);
            this.Name = "ShareCapitalCreditCreate";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShareUnLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShareLock)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
