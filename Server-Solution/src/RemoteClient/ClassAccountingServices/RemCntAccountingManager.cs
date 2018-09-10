using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RemoteClient
{
    public class RemCntAccountingManager : IDisposable
    {
        #region Constructor and Destructor
        public RemCntAccountingManager() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Void Procedures

        /// <summary>
        /// This procedure inserts a new chart of account
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="chartOfAccount"></param>
        public void InsertChartOfAccounts(CommonExchange.SysAccess userInfo, ref CommonExchange.ChartOfAccount chartOfAccount) 
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "InsertChartOfAccounts");

            remServer.InsertChartOfAccounts(userInfo, ref chartOfAccount);
        } //--------------------------------------------

        /// <summary>
        /// This procedure updates a chart of account
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="chartOfAccount"></param>
        public void UpdateChartOfAccounts(CommonExchange.SysAccess userInfo, CommonExchange.ChartOfAccount chartOfAccount) 
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "UpdateChartOfAccounts");

            remServer.UpdateChartOfAccounts(userInfo, chartOfAccount);
        } //------------------------------------------------

        /// <summary>
        /// This procedure insert a new bank information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankInfo"></param>
        public void InsertBankInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Bank bankInfo) 
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "InsertBankInformation");

            remServer.InsertBankInformation(userInfo, ref bankInfo);
        } //--------------------------------------------

        /// <summary>
        /// This procedure updates a bank information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankInfo"></param>
        public void UpdateBankInformation(CommonExchange.SysAccess userInfo, CommonExchange.Bank bankInfo) 
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "UpdateBankInformation");

            remServer.UpdateBankInformation(userInfo, bankInfo);
        } //----------------------------------------------

        /// <summary>t
        /// This procedure insert a new disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void InsertDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.DisbursementVoucher voucherInfo) 
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "InsertDisbursementVoucherInformation");

            remServer.InsertDisbursementVoucherInformation(userInfo, ref voucherInfo);
        } //--------------------------------------------------

        /// <summary>
        /// This procedure updates a disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void UpdateDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher voucherInfo) 
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "UpdateDisbursementVoucherInformation");

            remServer.UpdateDisbursementVoucherInformation(userInfo, voucherInfo);
        } //--------------------------------------------------

        /// <summary>
        /// This procedure delete a disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void DeleteDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher voucherInfo) 
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "DeleteDisbursementVoucherInformation");

            remServer.DeleteDisbursementVoucherInformation(userInfo, voucherInfo);
        } //------------------------------------------------------

        #endregion

        #region Programmer-Defined Function Procedures

        /// <summary>
        /// This function return the chart of accounts table
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="summaryAccount"></param>
        /// <param name="accountinCategoryIdList"></param>
        /// <returns></returns>
        public DataTable SelectChartOfAccounts(CommonExchange.SysAccess userInfo, String queryString,
            String summaryAccount, String accountingCategoryIdList, Boolean isActiveAccount)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "SelectChartOfAccounts");

            return remServer.SelectChartOfAccounts(userInfo, queryString, summaryAccount, accountingCategoryIdList, isActiveAccount);

        } //--------------------------------------------------

        /// <summary>
        /// This function returns a chart of account details
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="sqlConn"></param>
        /// <param name="accountSysId"></param>
        /// <returns></returns>
        public CommonExchange.ChartOfAccount SelectBySysIDAccountChartOfAccounts(CommonExchange.SysAccess userInfo, String accountSysId)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDAccountChartOfAccounts");

            return remServer.SelectBySysIDAccountChartOfAccounts(userInfo, accountSysId);
        } //------------------------------------

        /// <summary>
        /// This function returns the bank information table
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <param name="isActiveAccount"></param>
        /// <returns></returns>
        public DataTable SelectBankInformation(CommonExchange.SysAccess userInfo, String queryString, Boolean isActiveAccount)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "SelectBankInformation");

            return remServer.SelectBankInformation(userInfo, queryString, isActiveAccount);

        } //--------------------------------------------------

        /// <summary>
        /// This function returns the disbursement voucher information by date start and date end
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns></returns>
        public DataTable SelectByQueryStringDateStartEndDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, String queryString,
            String dateStart, String dateEnd, Boolean isCancelledVoucher)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "SelectByQueryStringDateStartEndDisbursementVoucherInformation");

            return remServer.SelectByQueryStringDateStartEndDisbursementVoucherInformation(userInfo, queryString, dateStart, dateEnd, isCancelledVoucher);

        } //--------------------------------------------

        /// <summary>
        /// This function returns the disbursement voucher information by voucher system id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherSysId"></param>
        /// <returns></returns>
        public CommonExchange.DisbursementVoucher SelectBySysIDVoucherDisbursementVoucherInformation(CommonExchange.SysAccess userInfo,
            String voucherSysId)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDVoucherDisbursementVoucherInformation");

            return remServer.SelectBySysIDVoucherDisbursementVoucherInformation(userInfo, voucherSysId);

        }  //---------------------------------------------------

        /// <summary>
        /// This function returns the query for disbursement payee
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public DataTable SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, String queryString)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation");

            return remServer.SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation(userInfo, queryString);

        } //--------------------------------------------

        /// <summary>
        /// This function determines if the category is valid by summary account
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="accountingCategoryId"></param>
        /// <param name="summaryAccount"></param>
        /// <returns></returns>
        public Boolean IsValidCategoryBySummaryAccountChartOfAccount(CommonExchange.SysAccess userInfo, String accountingCategoryId,
            String summaryAccount)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "IsValidCategoryBySummaryAccountChartOfAccount");

            return remServer.IsValidCategoryBySummaryAccountChartOfAccount(userInfo, accountingCategoryId, summaryAccount);
        } //------------------------------

        /// <summary>
        /// This function determines if the account code already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="accountSysId"></param>
        /// <param name="accountCode"></param>
        /// <returns></returns>
        public Boolean IsExistsAccountCodeChartOfAccount(CommonExchange.SysAccess userInfo, String accountSysId,
            String accountCode, String summaryAccount)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "IsExistsAccountCodeChartOfAccount");

            return remServer.IsExistsAccountCodeChartOfAccount(userInfo, accountSysId, accountCode, summaryAccount);
        } //------------------------------

        /// <summary>
        /// This function determines if the bank name and the account number already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankName"></param>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public Boolean IsExistsBankNameAccountNumberBankInformation(CommonExchange.SysAccess userInfo, String bankSysId, String bankName,
            String accountNumber)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "IsExistsBankNameAccountNumberBankInformation");

            return remServer.IsExistsBankNameAccountNumberBankInformation(userInfo, bankSysId, bankName, accountNumber);
        } //------------------------------

        /// <summary>
        /// This function determines if the bank and check no already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankSysId"></param>
        /// <param name="checkNo"></param>
        /// <returns></returns>
        public Boolean IsExistsBankCheckNoDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, String voucherSysId,
            String bankSysId, String checkNo)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "IsExistsBankCheckNoDisbursementVoucherInformation");

            return remServer.IsExistsBankCheckNoDisbursementVoucherInformation(userInfo, voucherSysId, bankSysId, checkNo);
        } //------------------------------

        /// <summary>
        /// This procedure get the cached data for accounting
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public DataSet GetDataSetForAccounting(CommonExchange.SysAccess userInfo)
        {
            RemoteServerLib.RemSrvAccountingManager remServer =
                (RemoteServerLib.RemSrvAccountingManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvAccountingManager),
                TcpRemoteServer.GetRemoteServerTcp() + "GetDataSetForAccounting");

            return remServer.GetDataSetForAccounting(userInfo);
        } //----------------------------------

        #endregion
    }
}
