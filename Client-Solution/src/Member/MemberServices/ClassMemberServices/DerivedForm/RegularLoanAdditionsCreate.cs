using System;
using System.Collections.Generic;
using System.Text;

namespace MemberServices
{
    internal partial class RegularLoanAdditionsCreate : RegularLoanAdditions
    {
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkMultipleInsert;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularLoanAdditionsCreate));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkMultipleInsert = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkMultipleInsert);
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
            this.btnCreate.Location = new System.Drawing.Point(169, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "  Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(261, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "  Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkMultipleInsert
            // 
            this.chkMultipleInsert.AutoSize = true;
            this.chkMultipleInsert.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMultipleInsert.ForeColor = System.Drawing.Color.Maroon;
            this.chkMultipleInsert.Location = new System.Drawing.Point(14, 9);
            this.chkMultipleInsert.Name = "chkMultipleInsert";
            this.chkMultipleInsert.Size = new System.Drawing.Size(107, 19);
            this.chkMultipleInsert.TabIndex = 80;
            this.chkMultipleInsert.Text = "Multiple Insert";
            this.chkMultipleInsert.UseVisualStyleBackColor = true;
            // 
            // RegularLoanAdditionsCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(363, 283);
            this.Name = "RegularLoanAdditionsCreate";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
