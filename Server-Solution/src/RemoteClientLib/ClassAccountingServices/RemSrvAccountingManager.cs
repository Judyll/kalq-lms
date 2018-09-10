using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteServerLib
{
    public class RemSrvAccountingManager : MarshalByRefObject, IDisposable
    {
        #region Class Constructor and Destructor
        public RemSrvAccountingManager() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Void Procedures

        /// <summary>
        /// This procedure inserts a new chart of account
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="chartOfAccount"></param>
        public void InsertChartOfAccounts(CommonExchange.SysAccess userInfo, ref CommonExchange.ChartOfAccount chartOfAccount) { }

        /// <summary>
        /// This procedure updates a chart of account
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="chartOfAccount"></param>
        public void UpdateChartOfAccounts(CommonExchange.SysAccess userInfo, CommonExchange.ChartOfAccount chartOfAccount) { }

        /// <summary>
        /// This procedure insert a new bank information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankInfo"></param>
        public void InsertBankInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Bank bankInfo) { }

        /// <summary>
        /// This procedure updates a bank information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankInfo"></param>
        public void UpdateBankInformation(CommonExchange.SysAccess userInfo, CommonExchange.Bank bankInfo) { }

        /// <summary>
        /// This procedure insert a new disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void InsertDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.DisbursementVoucher voucherInfo) { }

        /// <summary>
        /// This procedure updates a disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void UpdateDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher voucherInfo) { }

        /// <summary>
        /// This procedure delete a disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void DeleteDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher voucherInfo) { }

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
            DataTable dbTable = new DataTable();

            return dbTable;

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
            CommonExchange.ChartOfAccount accountInfo = new CommonExchange.ChartOfAccount();

            return accountInfo;
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
            DataTable dbTable = new DataTable();

            return dbTable;

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
            DataTable dbTable = new DataTable();
            
            return dbTable;

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
            CommonExchange.DisbursementVoucher voucherInfo = new CommonExchange.DisbursementVoucher();

            return voucherInfo;

        }  //---------------------------------------------------

        /// <summary>
        /// This function returns the query for disbursement payee
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public DataTable SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, String queryString)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

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
            Boolean isExist = false;

            return isExist;
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
            Boolean isExist = false;

            return isExist;
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
            Boolean isExist = false;

            return isExist;
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
            Boolean isExist = false;

            return isExist;
        } //------------------------------

        /// <summary>
        /// This procedure get the cached data for accounting
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public DataSet GetDataSetForAccounting(CommonExchange.SysAccess userInfo)
        {
            DataSet dbSet = new DataSet();

            return dbSet;
        } //----------------------------------

        #endregion

    }
}
