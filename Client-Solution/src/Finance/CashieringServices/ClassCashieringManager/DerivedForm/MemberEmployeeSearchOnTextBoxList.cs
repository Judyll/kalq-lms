using System;
using System.Collections.Generic;
using System.Text;

namespace CashieringServices
{
    internal partial class MemberEmployeeSearchOnTextBoxList : BaseServices.SearchOnTextboxList
    {
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(248, 12);
            // 
            // pbxDone
            // 
            this.pbxDone.Location = new System.Drawing.Point(610, 9);
            // 
            // pbxRefresh
            // 
            this.pbxRefresh.Location = new System.Drawing.Point(571, 9);
            // 
            // MemberEmployeeSearchOnTextBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(654, 307);
            this.Name = "MemberEmployeeSearchOnTextBoxList";
            this.Text = "   Member/Collector List";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
