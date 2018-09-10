using System;
using System.Collections.Generic;
using System.Text;

namespace MemberServices
{
    internal partial class HospitalizationExcludeSearchedOnTextBoxLis : BaseServices.SearchOnTextboxList
    {
        protected System.Windows.Forms.LinkLabel lnkUpdateExcludeCoverage;
        protected System.Windows.Forms.LinkLabel lnkCreateExcludeCoverage;
    
        private void InitializeComponent()
        {
            this.lnkUpdateExcludeCoverage = new System.Windows.Forms.LinkLabel();
            this.lnkCreateExcludeCoverage = new System.Windows.Forms.LinkLabel();
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
            // lnkUpdateExcludeCoverage
            // 
            this.lnkUpdateExcludeCoverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUpdateExcludeCoverage.AutoSize = true;
            this.lnkUpdateExcludeCoverage.Enabled = false;
            this.lnkUpdateExcludeCoverage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUpdateExcludeCoverage.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkUpdateExcludeCoverage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkUpdateExcludeCoverage.Location = new System.Drawing.Point(305, 289);
            this.lnkUpdateExcludeCoverage.Name = "lnkUpdateExcludeCoverage";
            this.lnkUpdateExcludeCoverage.Size = new System.Drawing.Size(166, 15);
            this.lnkUpdateExcludeCoverage.TabIndex = 77;
            this.lnkUpdateExcludeCoverage.TabStop = true;
            this.lnkUpdateExcludeCoverage.Text = "[ Update Exclude Coverage ]";
            this.lnkUpdateExcludeCoverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkCreateExcludeCoverage
            // 
            this.lnkCreateExcludeCoverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCreateExcludeCoverage.AutoSize = true;
            this.lnkCreateExcludeCoverage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateExcludeCoverage.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateExcludeCoverage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateExcludeCoverage.Location = new System.Drawing.Point(477, 289);
            this.lnkCreateExcludeCoverage.Name = "lnkCreateExcludeCoverage";
            this.lnkCreateExcludeCoverage.Size = new System.Drawing.Size(164, 15);
            this.lnkCreateExcludeCoverage.TabIndex = 76;
            this.lnkCreateExcludeCoverage.TabStop = true;
            this.lnkCreateExcludeCoverage.Text = "[ Create Exclude Coverage ]";
            this.lnkCreateExcludeCoverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HospitalizationExcludeSearchedOnTextBoxLis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(649, 310);
            this.Controls.Add(this.lnkUpdateExcludeCoverage);
            this.Controls.Add(this.lnkCreateExcludeCoverage);
            this.Name = "HospitalizationExcludeSearchedOnTextBoxLis";
            this.Text = "   Hospitalization Exclude Coverage List";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pbxRefresh, 0);
            this.Controls.SetChildIndex(this.pbxDone, 0);
            this.Controls.SetChildIndex(this.lnkCreateExcludeCoverage, 0);
            this.Controls.SetChildIndex(this.lnkUpdateExcludeCoverage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
