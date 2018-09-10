using System;
using System.Collections.Generic;
using System.Text;

namespace BaseServices
{
    public partial class ChartOfAccountSearchOnTextBoxList : ChartOfAccountSearchList
    {
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(516, 12);
            // 
            // pbxDone
            // 
            this.pbxDone.Location = new System.Drawing.Point(878, 9);
            // 
            // pbxRefresh
            // 
            this.pbxRefresh.Location = new System.Drawing.Point(839, 9);
            // 
            // ChartOfAccountSearchOnTextBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(922, 312);
            this.Name = "ChartOfAccountSearchOnTextBoxList";
            this.Text = "  Chart Of Accounts List";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
