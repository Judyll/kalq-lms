using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteClient
{
    public class RemCntLoanManager : IDisposable
    {
        #region Class Constructor and Destructor
        public RemCntLoanManager() { }

        void IDisposable.Dispose() { }

        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure adds a new regular loan information
        public void InsertRegularLoanInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.RegularLoan regularLoanInfo) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertRegularLoanInformation");

            remServer.InsertRegularLoanInformation(userInfo, ref regularLoanInfo);
        } //--------------------------------

        //this procedure update a regular loan information
        public void UpdateRegularLoanInformation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "UpdateRegularLoanInformation");

            remServer.UpdateRegularLoanInformation(userInfo, regularLoanInfo);
        } //------------------------------------

        //this procedure delete a regular loan information
        public void DeleteRegularLoanInformation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "DeleteRegularLoanInformation");

            remServer.DeleteRegularLoanInformation(userInfo, regularLoanInfo);
        } //-------------------------------------------

        /// <summary>
        /// this procedure inserts, update or delete a regular loan document
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanDocumentTable"></param>
        public void InsertUpdateDeleteRegularLoanDocument(CommonExchange.SysAccess userInfo, DataTable regularLoanDocumentTable) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertUpdateDeleteRegularLoanDocument");

            remServer.InsertUpdateDeleteRegularLoanDocument(userInfo, regularLoanDocumentTable);
        } //---------------------------------------------

        /// <summary>
        /// this procedure adds a new collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void InsertCollateralInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Collateral collateralInfo) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertCollateralInformation");

            remServer.InsertCollateralInformation(userInfo, ref collateralInfo);
        } //---------------------------------------------

        /// <summary>
        /// this procedure updates a collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void UpdateCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "UpdateCollateralInformation");

            remServer.UpdateCollateralInformation(userInfo, collateralInfo);
        } //--------------------------------------------

        /// <summary>
        /// this procedure deletes a collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void DeleteCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "DeleteCollateralInformation");

            remServer.DeleteCollateralInformation(userInfo, collateralInfo);
        } //----------------------------------------

        /// <summary>
        /// this procedure inserts and deletes a regular loan collateral
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanCollateralTable"></param>
        public void InsertDeleteRegularLoanCollateral(CommonExchange.SysAccess userInfo, DataTable regularLoanCollateralTable) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertDeleteRegularLoanCollateral");

            remServer.InsertDeleteRegularLoanCollateral(userInfo, regularLoanCollateralTable);
        } //------------------------------------------

        /// <summary>
        /// this procedure inserts, updates and deletes a regular loan co-maker
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanCoMakerTable"></param>
        public void InsertUpdateDeleteRegularLoanCoMaker(CommonExchange.SysAccess userInfo, DataTable regularLoanCoMakerTable) 
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertUpdateDeleteRegularLoanCoMaker");

            remServer.InsertUpdateDeleteRegularLoanCoMaker(userInfo, regularLoanCoMakerTable);
        } //-------------------------------------------

        /// <summary>
        /// this procedure adds, updates, and deletes a regular loan amortization
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanAmortizationList"></param>
        public void InsertUpdateDeleteRegularLoanAmortization(CommonExchange.SysAccess userInfo, String regularLoanSysId,
            List<CommonExchange.RegularLoanAmortization> loanAmortizationList)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertUpdateDeleteRegularLoanAmortization");

            remServer.InsertUpdateDeleteRegularLoanAmortization(userInfo, regularLoanSysId, loanAmortizationList);

        } //--------------------------------

        #endregion

        #region Programmer-Defined Function Procedures

        /// <summary>
        /// This function returns a new regular loan account no
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanTypeId"></param>
        /// <param name="dateApproved"></param>
        /// <returns></returns>
        public String SelectCountForAccountNoRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanTypeId,
            String dateApproved)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectCountForAccountNoRegularLoanInformation");

            return remServer.SelectCountForAccountNoRegularLoanInformation(userInfo, regularLoanTypeId, dateApproved);
        }//------------------------------------------------

        /// <summary>
        /// this function gets the regular loan information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <param name="isMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListRegularLoanInformation(CommonExchange.SysAccess userInfo, String memberSysIdList,
            Boolean isMarkedDeleted)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDMemberListRegularLoanInformation");

            return remServer.SelectBySysIDMemberListRegularLoanInformation(userInfo, memberSysIdList, isMarkedDeleted);

        } //------------------------------     

        /// <summary>
        /// get the regular loan information by regular loan system id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularSysId"></param>
        /// <returns></returns>
        public CommonExchange.RegularLoan SelectBySysIDRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanSysId)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDRegularLoanInformation");

            return remServer.SelectBySysIDRegularLoanInformation(userInfo, regularLoanSysId);

        }  //---------------------------------------------------

        /// <summary>
        /// this function gets the regular loan documents by sysid_regular list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanDocument(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDRegularListRegularLoanDocument");

            return remServer.SelectBySysIDRegularListRegularLoanDocument(userInfo, regularLoanSysIdList);

        } //------------------------------

        /// <summary>
        /// this function gets the collateral information table query
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <param name="includeMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectCollateralInformation(CommonExchange.SysAccess userInfo, String queryString, Boolean includeMarkedDeleted)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectCollateralInformation");

            return remServer.SelectCollateralInformation(userInfo, queryString, includeMarkedDeleted);

        } //------------------------------

        /// <summary>
        /// this function returns the regular loan collateral by regular loan system id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysId"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanCollateral(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDRegularListRegularLoanCollateral");

            return remServer.SelectBySysIDRegularListRegularLoanCollateral(userInfo, regularLoanSysIdList);

        } //------------------------------

        /// <summary>
        /// this function returns the regular loan co-maker by regular loan system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanCoMaker(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDRegularListRegularLoanCoMaker");

            return remServer.SelectBySysIDRegularListRegularLoanCoMaker(userInfo, regularLoanSysIdList);

        } //------------------------------

        /// <summary>
        /// This function determines if the regular loan account no already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public Boolean IsExistsAccountNoRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanSysId,
            String accountNo)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsAccountNoRegularLoanInformation");

            return remServer.IsExistsAccountNoRegularLoanInformation(userInfo, regularLoanSysId, accountNo);

        } //------------------------------------------


        /// <summary>
        /// this function determines if the regular document original name already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="documentId"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="originalName"></param>
        /// <returns></returns>
        public Boolean IsExistsSysIDRegularOriginalNameRegularLoanDocument(CommonExchange.SysAccess userInfo, Int64 documentId, String regularLoanSysId,
            String originalName)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsSysIDRegularOriginalNameRegularLoanDocument");

            return remServer.IsExistsSysIDRegularOriginalNameRegularLoanDocument(userInfo, documentId, regularLoanSysId, originalName);

        } //------------------------------------------

        //this function is used to determine if the payment date from, to and grace period already exists
        public Boolean IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization(CommonExchange.SysAccess userInfo, Int64 amortizationId,
            String regularLoanSysId, String paymentDateFrom, String paymentDateTo)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization");

            return remServer.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization(userInfo, amortizationId, regularLoanSysId, paymentDateFrom, 
                paymentDateTo);
        } //------------------------------

        /// <summary>
        /// this function determines if the regular loan charges already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularChargesId"></param>
        /// <param name="regularSysId"></param>
        /// <param name="loanChargesSysId"></param>
        /// <returns></returns>
        public Boolean IsExistsChargeRegularLoanCharges(CommonExchange.SysAccess userInfo, Int64 regularChargesId,
            String regularLoanSysId, String chargeDescription, String accountSysId)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsChargeRegularLoanCharges");

            return remServer.IsExistsChargeRegularLoanCharges(userInfo, regularChargesId, regularLoanSysId, chargeDescription, accountSysId);
        } //------------------------------

        /// <summary>
        /// this function determines if the regular loan additions already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularChargesId"></param>
        /// <param name="regularSysId"></param>
        /// <param name="loanChargesSysId"></param>
        /// <returns></returns>
        public Boolean IsExistsChargeRegularLoanAdditions(CommonExchange.SysAccess userInfo, Int64 regularAdditionsId,
            String regularLoanSysId, String additionDescription, String accountSysId)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsChargeRegularLoanAdditions");

            return remServer.IsExistsChargeRegularLoanAdditions(userInfo, regularAdditionsId, regularLoanSysId, additionDescription, accountSysId);
        } //------------------------------

        /// <summary>
        /// gets the dataset for the loan manager
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public DataSet GetDataSetForLoanManager(CommonExchange.SysAccess userInfo)
        {
            RemoteServerLib.RemSrvLoanManager remServer = (RemoteServerLib.RemSrvLoanManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvLoanManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "GetDataSetForLoanManager");

            return remServer.GetDataSetForLoanManager(userInfo);
        } //----------------------------------

        #endregion
    }
}
