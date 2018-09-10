using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CashieringServices
{
    public delegate void MemberSearchListButtonClick();

    partial class MemberSearchList
    {
        #region Class Even Declaration
        //public event MemberSearchListLinkCreateClick OnCreate;
        public event MemberSearchListButtonClick OnBillingClick;
        public event MemberSearchListButtonClick OnRegularLoanMultipleClick;
        public event MemberSearchListButtonClick OnShareCapitalMultipleClick;
        public event MemberSearchListButtonClick OnInHouseMultipleClick;
        #endregion

        #region Class Constructors
        public MemberSearchList()
        {
            this.InitializeComponent();

            //this.btnCreate.Click += new EventHandler(btnCreateClick);
            this.btnBilling.Click += new EventHandler(btnBillingClick);
            this.btnRegularLoanMultiple.Click += new EventHandler(btnRegularLoanMultipleClick);
            this.btnShareCapitalMultiple.Click += new EventHandler(btnShareCapitalMultipleClick);
            this.btnInHouseMultiple.Click += new EventHandler(btnInHouseMultipleClick);
            
        }     
        #endregion

        #region Class Event Void Procedures
        ////################################################BUTTON btnBilling EVENTS####################################################
        ////event is raised when the link is clicked
        private void btnBillingClick(object sender, EventArgs e)
        {
            MemberSearchListButtonClick ev = OnBillingClick;

            if (ev != null)
            {
                OnBillingClick();
            }
        }//--------------------
        ////################################################END BUTTON btnBilling EVENTS####################################################

        ////################################################BUTTON btnRegularLoan EVENTS####################################################
        ////event is raised when the link is clicked
        private void btnRegularLoanMultipleClick(object sender, EventArgs e)
        {
            MemberSearchListButtonClick ev = OnRegularLoanMultipleClick;

            if (ev != null)
            {
                OnRegularLoanMultipleClick();
            }
        }//---------------------
        ////################################################END BUTTON btnRegularLoan EVENTS####################################################

        ////################################################BUTTON btnShareCapital EVENTS####################################################
        ////event is raised when the link is clicked
        private void btnShareCapitalMultipleClick(object sender, EventArgs e)
        {
            MemberSearchListButtonClick ev = OnShareCapitalMultipleClick;

            if (ev != null)
            {
                OnShareCapitalMultipleClick();
            }
        }//------------------------
        ////################################################END BUTTON btnShareCapital EVENTS####################################################

        ////################################################BUTTON btnInHouse EVENTS####################################################
        ////event is raised when the link is clicked
        private void btnInHouseMultipleClick(object sender, EventArgs e)
        {
            MemberSearchListButtonClick ev = OnInHouseMultipleClick;

            if (ev != null)
            {
                OnInHouseMultipleClick();
            }
        }//---------------------------
        ////################################################END BUTTON btnInHouse EVENTS####################################################

        ////################################################BUTTON bntCreate EVENTS####################################################
        ////event is raised when the link is clicked
        //private void btnCreateClick(object sender, EventArgs e)
        //{
        //    MemberSearchListLinkCreateClick ev = OnCreate;

        //    if (ev != null)
        //    {
        //        OnCreate();
        //    }
        //}//---------------------------------
        ////################################################END LINKBUTTON lnkCreate EVENTS####################################################

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

        #region Programer-Define Procedures
        ////this procedure will disable create button
        //public void DisableCreateLink()
        //{
        //    this.btnCreate.Visible = false;
        //}//-------------------------------
        #endregion
    }
}
