using System;
using System.Collections.Generic;
using System.Text;

namespace CashieringServices
{
    internal partial class RegularLoanSearchOnTextBoxList : BaseServices.SearchOnTextboxList
    {
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(243, 12);
            this.txtSearch.Visible = false;
            // 
            // pbxDone
            // 
            this.pbxDone.Location = new System.Drawing.Point(605, 9);
            // 
            // pbxRefresh
            // 
            this.pbxRefresh.Location = new System.Drawing.Point(566, 9);
            // 
            // RegularLoanSearchOnTextBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(653, 308);
            this.Name = "RegularLoanSearchOnTextBoxList";
            this.Text = "   Regular Loan List";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
