using System;
using System.Collections.Generic;
using System.Text;

namespace MemberServices
{
    internal partial class RegularLoanInformationRecord : RegularLoanInformation
    {
        private System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecord;
    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularLoanInformationRecord));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabAmortization.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbxChargesAdditionals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocked)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnRecord);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(896, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "  Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecord.BackgroundImage")));
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(804, 7);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(86, 23);
            this.btnRecord.TabIndex = 12;
            this.btnRecord.Text = "     Record";
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(10, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 23);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // RegularLoanInformationRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(994, 712);
            this.Name = "RegularLoanInformationRecord";
            this.tabAmortization.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbxChargesAdditionals.ResumeLayout(false);
            this.gbxChargesAdditionals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
