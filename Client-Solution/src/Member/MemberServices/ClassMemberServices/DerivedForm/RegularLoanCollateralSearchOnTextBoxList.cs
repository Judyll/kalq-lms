using System;
using System.Collections.Generic;
using System.Text;

namespace MemberServices
{
    internal partial class RegularLoanCollateralSearchOnTextBoxList : BaseServices.SearchOnTextboxList
    {
        protected System.Windows.Forms.LinkLabel lnkCreateCollateral;
    
        private void InitializeComponent()
        {
            this.lnkCreateCollateral = new System.Windows.Forms.LinkLabel();
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
            // lnkCreateCollateral
            // 
            this.lnkCreateCollateral.AutoSize = true;
            this.lnkCreateCollateral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateCollateral.ForeColor = System.Drawing.Color.DarkBlue;
            this.lnkCreateCollateral.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCreateCollateral.Location = new System.Drawing.Point(528, 289);
            this.lnkCreateCollateral.Name = "lnkCreateCollateral";
            this.lnkCreateCollateral.Size = new System.Drawing.Size(113, 15);
            this.lnkCreateCollateral.TabIndex = 91;
            this.lnkCreateCollateral.TabStop = true;
            this.lnkCreateCollateral.Text = "[Create Collateral ]";
            this.lnkCreateCollateral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegularLoanCollateralSearchOnTextBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(649, 308);
            this.Controls.Add(this.lnkCreateCollateral);
            this.Name = "RegularLoanCollateralSearchOnTextBoxList";
            this.Text = "   Regular Loan Collateral List";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pbxRefresh, 0);
            this.Controls.SetChildIndex(this.pbxDone, 0);
            this.Controls.SetChildIndex(this.lnkCreateCollateral, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
