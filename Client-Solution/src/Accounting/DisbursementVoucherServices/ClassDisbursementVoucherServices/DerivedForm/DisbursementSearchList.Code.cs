using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    public delegate void DisbursementSearchListLinkCreateClick();

    partial class DisbursementSearchList
    {
        #region Class Even Declaration
        public event DisbursementSearchListLinkCreateClick OnCreate;
        #endregion

        #region Class Constructors
        public DisbursementSearchList()
        {
            this.InitializeComponent();

            this.btnCreate.Click += new EventHandler(btnCreateClick);
        }
        #endregion

        #region Class Event Void Procedures
        //################################################BUTTON bntCreate EVENTS####################################################
        //event is raised when the link is clicked
        private void btnCreateClick(object sender, EventArgs e)
        {
            DisbursementSearchListLinkCreateClick ev = OnCreate;

            if (ev != null)
            {
                OnCreate();
            }
        }//---------------------------------
        //################################################END LINKBUTTON lnkCreate EVENTS####################################################

        //################################################DATAGRIDVIEW bntCreate EVENTS####################################################
        //event is raised when the link is clicked
        protected override void dgvListDataSourceChanged(object sender, EventArgs e)
        {
            base.dgvListDataSourceChanged(sender, e);

            if (dgvList.Rows.Count == 0 || dgvList.Rows.Count == 1)
            {
                this.lblResult.Text = dgvList.Rows.Count.ToString() + " Record";
            }
            else
            {
                this.lblResult.Text = dgvList.Rows.Count.ToString() + " Records";
            }
        }//---------------------------
        //################################################END DATAGRIDVIEW bntCreate EVENTS####################################################
        #endregion
    }
}
