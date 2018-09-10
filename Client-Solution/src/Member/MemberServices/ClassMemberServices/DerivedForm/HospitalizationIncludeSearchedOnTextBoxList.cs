using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MemberServices
{
    internal partial class HospitalizationIncludeSearchedOnTextBoxList : BaseServices.SearchOnTextboxList
    {
        protected LinkLabel lnkUpdateIncludeCoverage;
        protected LinkLabel lnkCreateIncludeCoverage;
    
        private void InitializeComponent()
        {
            this.lnkUpdateIncludeCoverage = new System.Windows.Forms.LinkLabel();
            this.lnkCreateIncludeCoverage = new System.Windows.Forms.LinkLabel();
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
            // lnkUpdateIncludeCoverage
            // 
            this.lnkUpdateIncludeCoverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUpdateIncludeCoverage.AutoSize = true;
            this.lnkUpdateIncludeCoverage.Enabled = false;
            this.lnkUpdateIncludeCoverage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUpdateIncludeCoverage.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkUpdateIncludeCoverage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkUpdateIncludeCoverage.Location = new System.Drawing.Point(313, 288);
            this.lnkUpdateIncludeCoverage.Name = "lnkUpdateIncludeCoverage";
            this.lnkUpdateIncludeCoverage.Size = new System.Drawing.Size(162, 15);
            this.lnkUpdateIncludeCoverage.TabIndex = 75;
            this.lnkUpdateIncludeCoverage.TabStop = true;
            this.lnkUpdateIncludeCoverage.Text = "[ Update Include Coverage ]";
            this.lnkUpdateIncludeCoverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkCreateIncludeCoverage
            // 
            this.lnkCreateIncludeCoverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCreateIncludeCoverage.AutoSize = true;
            this.lnkCreateIncludeCoverage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateIncludeCoverage.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateIncludeCoverage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateIncludeCoverage.Location = new System.Drawing.Point(481, 288);
            this.lnkCreateIncludeCoverage.Name = "lnkCreateIncludeCoverage";
            this.lnkCreateIncludeCoverage.Size = new System.Drawing.Size(160, 15);
            this.lnkCreateIncludeCoverage.TabIndex = 74;
            this.lnkCreateIncludeCoverage.TabStop = true;
            this.lnkCreateIncludeCoverage.Text = "[ Create Include Coverage ]";
            this.lnkCreateIncludeCoverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HospitalizationIncludeSearchedOnTextBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(649, 309);
            this.Controls.Add(this.lnkUpdateIncludeCoverage);
            this.Controls.Add(this.lnkCreateIncludeCoverage);
            this.Name = "HospitalizationIncludeSearchedOnTextBoxList";
            this.Text = "   Hospitalization Include Coverage List";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pbxRefresh, 0);
            this.Controls.SetChildIndex(this.pbxDone, 0);
            this.Controls.SetChildIndex(this.lnkCreateIncludeCoverage, 0);
            this.Controls.SetChildIndex(this.lnkUpdateIncludeCoverage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
