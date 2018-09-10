namespace CashieringServices
{
    partial class CashieringManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashieringManager));
            this.ctlManager = new BaseServices.Controls.ControlCashieringManager();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlManager
            // 
            this.ctlManager.BackColor = System.Drawing.Color.Transparent;
            this.ctlManager.Location = new System.Drawing.Point(752, 111);
            this.ctlManager.Name = "ctlManager";
            this.ctlManager.ReceiptDate = new System.DateTime(2011, 2, 8, 11, 36, 56, 140);
            this.ctlManager.ReceiptNo = 0;
            this.ctlManager.Size = new System.Drawing.Size(255, 557);
            this.ctlManager.TabIndex = 1;
            // 
            // lblRecordDate
            // 
            this.lblRecordDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRecordDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecordDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordDate.Location = new System.Drawing.Point(0, 681);
            this.lblRecordDate.Name = "lblRecordDate";
            this.lblRecordDate.Size = new System.Drawing.Size(1014, 13);
            this.lblRecordDate.TabIndex = 15;
            this.lblRecordDate.Text = "label1";
            this.lblRecordDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CashieringManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 694);
            this.Controls.Add(this.lblRecordDate);
            this.Controls.Add(this.ctlManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashieringManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private BaseServices.Controls.ControlCashieringManager ctlManager;
        private System.Windows.Forms.Label lblRecordDate;
    }
}