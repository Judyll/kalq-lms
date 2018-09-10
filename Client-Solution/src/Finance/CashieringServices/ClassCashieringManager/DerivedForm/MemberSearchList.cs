using System;
using System.Collections.Generic;
using System.Text;

namespace CashieringServices
{
    internal partial class MemberSearchList : BaseServices.SearchList
    {
        internal System.Windows.Forms.ToolStrip tspCreate;
        private System.Windows.Forms.ToolStripLabel lblQuery;
        private System.Windows.Forms.ToolStripLabel lblResult;
        private System.Windows.Forms.ToolStripLabel lblSpacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRegularLoanMultiple;
        private System.Windows.Forms.ToolStripButton btnShareCapitalMultiple;
        private System.Windows.Forms.ToolStripButton btnInHouseMultiple;
        private System.Windows.Forms.ToolStripButton btnBilling;
    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberSearchList));
            this.tspCreate = new System.Windows.Forms.ToolStrip();
            this.lblQuery = new System.Windows.Forms.ToolStripLabel();
            this.lblResult = new System.Windows.Forms.ToolStripLabel();
            this.lblSpacer = new System.Windows.Forms.ToolStripLabel();
            this.btnRegularLoanMultiple = new System.Windows.Forms.ToolStripButton();
            this.btnShareCapitalMultiple = new System.Windows.Forms.ToolStripButton();
            this.btnInHouseMultiple = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBilling = new System.Windows.Forms.ToolStripButton();
            this.tspCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspCreate
            // 
            this.tspCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspCreate.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspCreate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblQuery,
            this.lblResult,
            this.lblSpacer,
            this.btnRegularLoanMultiple,
            this.btnShareCapitalMultiple,
            this.btnInHouseMultiple,
            this.toolStripSeparator1,
            this.btnBilling});
            this.tspCreate.Location = new System.Drawing.Point(0, 258);
            this.tspCreate.Name = "tspCreate";
            this.tspCreate.Size = new System.Drawing.Size(713, 25);
            this.tspCreate.TabIndex = 64;
            this.tspCreate.Text = "toolStrip1";
            // 
            // lblQuery
            // 
            this.lblQuery.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery.ForeColor = System.Drawing.Color.Maroon;
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(51, 22);
            this.lblQuery.Text = "  Query:";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 22);
            this.lblResult.Text = "Result";
            // 
            // lblSpacer
            // 
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(0, 22);
            // 
            // btnRegularLoanMultiple
            // 
            this.btnRegularLoanMultiple.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRegularLoanMultiple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegularLoanMultiple.Image = ((System.Drawing.Image)(resources.GetObject("btnRegularLoanMultiple.Image")));
            this.btnRegularLoanMultiple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegularLoanMultiple.Name = "btnRegularLoanMultiple";
            this.btnRegularLoanMultiple.Size = new System.Drawing.Size(23, 22);
            this.btnRegularLoanMultiple.Text = "Regular loan multiple payment";
            // 
            // btnShareCapitalMultiple
            // 
            this.btnShareCapitalMultiple.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnShareCapitalMultiple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShareCapitalMultiple.Image = ((System.Drawing.Image)(resources.GetObject("btnShareCapitalMultiple.Image")));
            this.btnShareCapitalMultiple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShareCapitalMultiple.Name = "btnShareCapitalMultiple";
            this.btnShareCapitalMultiple.Size = new System.Drawing.Size(23, 22);
            this.btnShareCapitalMultiple.Text = "Share capital multiple payment";
            // 
            // btnInHouseMultiple
            // 
            this.btnInHouseMultiple.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnInHouseMultiple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInHouseMultiple.Image = ((System.Drawing.Image)(resources.GetObject("btnInHouseMultiple.Image")));
            this.btnInHouseMultiple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInHouseMultiple.Name = "btnInHouseMultiple";
            this.btnInHouseMultiple.Size = new System.Drawing.Size(23, 22);
            this.btnInHouseMultiple.Text = "In-house hospitalization multiple payment";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBilling
            // 
            this.btnBilling.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBilling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBilling.Image = ((System.Drawing.Image)(resources.GetObject("btnBilling.Image")));
            this.btnBilling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(23, 22);
            this.btnBilling.Text = "Generate billing statement";
            // 
            // MemberSearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(713, 283);
            this.Controls.Add(this.tspCreate);
            this.Name = "MemberSearchList";
            this.Text = "    Member List";
            this.Controls.SetChildIndex(this.tspCreate, 0);
            this.tspCreate.ResumeLayout(false);
            this.tspCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
