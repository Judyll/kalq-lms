using System;
using System.Collections.Generic;
using System.Text;

namespace DisbursementVoucherServices
{
    internal partial class SearchBankInformationOnTextBoxList : BaseServices.SearchOnTextboxList
    {
        protected System.Windows.Forms.LinkLabel lnkUpdateBankInformation;
        protected System.Windows.Forms.LinkLabel lnkCreateBankInformation;
    
        private void InitializeComponent()
        {
            this.lnkUpdateBankInformation = new System.Windows.Forms.LinkLabel();
            this.lnkCreateBankInformation = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(243, 12);
            // 
            // pbxDone
            // 
            this.pbxDone.Location = new System.Drawing.Point(605, 9);
            // 
            // pbxRefresh
            // 
            this.pbxRefresh.Location = new System.Drawing.Point(566, 9);
            // 
            // lnkUpdateBankInformation
            // 
            this.lnkUpdateBankInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUpdateBankInformation.AutoSize = true;
            this.lnkUpdateBankInformation.Enabled = false;
            this.lnkUpdateBankInformation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUpdateBankInformation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkUpdateBankInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkUpdateBankInformation.Location = new System.Drawing.Point(315, 288);
            this.lnkUpdateBankInformation.Name = "lnkUpdateBankInformation";
            this.lnkUpdateBankInformation.Size = new System.Drawing.Size(161, 15);
            this.lnkUpdateBankInformation.TabIndex = 77;
            this.lnkUpdateBankInformation.TabStop = true;
            this.lnkUpdateBankInformation.Text = "[ Update Bank Information ]";
            this.lnkUpdateBankInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkCreateBankInformation
            // 
            this.lnkCreateBankInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCreateBankInformation.AutoSize = true;
            this.lnkCreateBankInformation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateBankInformation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateBankInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateBankInformation.Location = new System.Drawing.Point(482, 288);
            this.lnkCreateBankInformation.Name = "lnkCreateBankInformation";
            this.lnkCreateBankInformation.Size = new System.Drawing.Size(159, 15);
            this.lnkCreateBankInformation.TabIndex = 76;
            this.lnkCreateBankInformation.TabStop = true;
            this.lnkCreateBankInformation.Text = "[ Create Bank Information ]";
            this.lnkCreateBankInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchBankInformationOnTextBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(649, 312);
            this.Controls.Add(this.lnkUpdateBankInformation);
            this.Controls.Add(this.lnkCreateBankInformation);
            this.Name = "SearchBankInformationOnTextBoxList";
            this.Text = "   Bank Information List";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pbxRefresh, 0);
            this.Controls.SetChildIndex(this.pbxDone, 0);
            this.Controls.SetChildIndex(this.lnkCreateBankInformation, 0);
            this.Controls.SetChildIndex(this.lnkUpdateBankInformation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
