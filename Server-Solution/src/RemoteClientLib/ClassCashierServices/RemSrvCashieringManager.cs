using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteServerLib
{
    public class RemSrvCashieringManager : MarshalByRefObject, IDisposable
    {
        #region Class Constructor and Destructor
        public RemSrvCashieringManager() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Void Procedures

        /// <summary>
        /// This procedure inserts a new breakdown bank deposit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="breakdownDeposit"></param>
        public void InsertBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit) { }

        /// <summary>
        /// This procedure updates a breakdown bank deposit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="breakdownDeposit"></param>
        public void UpdateBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit) { }

        /// <summary>
        /// This procedure deletes a breakdown bank deposit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="breakdownDeposit"></param>
        public void DeleteBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit) { }

        /// <summary>
        /// This procedure inserts a new miscellaneous income
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="miscIncomeInfo"></param>
        public void InsertMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscIncomeInfo) { }

        /// <summary>
        /// This procedure updates a miscellaneous income
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="miscIncomeInfo"></param>
        public void UpdateMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscIncomeInfo) { }

        /// <summary>
        /// This procedure deletes a miscellaneous income
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="miscIncomeInfo"></param>
        public void DeleteMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscIncomeInfo) { }

        /// <summary>
        /// This procedure inserts a new in-house hospitalization credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCredit"></param>
        public void InsertInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit hospitalizationCredit) { }

        /// <summary>
        /// This procedure updates an in-house hospitalization credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCredit"></param>
        public void UpdateInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit hospitalizationCredit) { }

        /// <summary>
        /// This procedure deletes an in-house hospitalization credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCredit"></param>
        public void DeleteInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit hospitalizationCredit) { }

        /// <summary>
        /// This procedure insert, update and delete an in-house hospitalization credit by hospitalization credit datatable
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCreditTable"></param>
        public void InsertUpdateDeleteInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, DataTable hospitalizationCreditTable) { }

        /// <summary>
        /// This procedure inserts a new share capital credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void InsertShareCapitalCredit(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit capitalCredit) { }

        /// <summary>
        /// This procedure updates a share capital credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void UpdateShareCapitalCredit(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit capitalCredit) { }

        /// <summary>
        /// This procedure deletes a share capital credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void DeleteShareCapitalCredit(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit capitalCredit) { }

        /// <summary>
        /// This procedure inserts, update, and delete a share capital credit by capital credit datatable
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCreditTable"></param>
        public void InsertUpdateDeleteShareCapitalCredit(CommonExchange.SysAccess userInfo, DataTable capitalCreditTable) { }

        /// <summary>
        /// This procedure inserts a new member equity credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void InsertMemberEquityCredit(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit equityCredit) { }

        /// <summary>
        /// This procedure updates a member equity credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void UpdateMemberEquityCredit(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit equityCredit) { }

        /// <summary>
        /// This procedure deletes a member equity credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void DeleteMemberEquityCredit(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit equityCredit) { }

        /// <summary>
        /// This procedure inserts a new regular loan payments
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPayments"></param>
        public void InsertRegularLoanPayments(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments loanPayments) { }

        /// <summary>
        /// This procedure updates a regular loan payment
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPayments"></param>
        public void UpdateRegularLoanPayments(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments loanPayments) { }

        /// <summary>
        /// This procedure deletes a regular loan payment
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPayments"></param>
        public void DeleteRegularLoanPayments(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments loanPayments) { }

        /// <summary>
        /// This procedure insert, update, and delete a regular loan payments passing a regular loan payments datatable
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPaymentsTable"></param>
        public void InsertUpdateDeleteRegularLoanPayments(CommonExchange.SysAccess userInfo, DataTable loanPaymentsTable) { }

        /// <summary>
        /// this procedure insert or update the share capital information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="shareCapitalInfo"></param>
        public void InsertUpdateShareCapitalInformation(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalInformation shareCapitalInfo) { }

        /// <summary>
        /// this procedure inserts or updates an in house hospitalization information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseHospitalizationInfo"></param>
        public void InsertUpdateInHouseHospitalizationInformation(CommonExchange.SysAccess userInfo,
            CommonExchange.InHouseHospitalizationInformation inHouseHospitalizationInfo) { }

        /// <summary>
        /// This procedure inserts a new hospitalization include coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="includeCoverage"></param>
        public void InsertHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo,
            ref CommonExchange.HospitalizationIncludeCoverage includeCoverage) { }

        /// <summary>
        /// This procedure updates a hospitalization include coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="includeCoverage"></param>
        public void UpdateHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationIncludeCoverage includeCoverage) { }

        /// <summary>
        /// This procedure delete a hospitalization include coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="includeCoverage"></param>
        public void DeleteHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationIncludeCoverage includeCoverage) { }

        /// <summary>
        /// This procedure inserts a new hospitalization exclude coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="excludeCoverage"></param>
        public void InsertHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo,
            ref CommonExchange.HospitalizationExcludeCoverage excludeCoverage) { }

        /// <summary>
        /// This procedure updates the hospitalization exclude coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="excludeCoverage"></param>
        public void UpdateHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationExcludeCoverage excludeCoverage) { }

        /// <summary>
        /// This procedure deletes a hospitalization exclude coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="excludeCoverage"></param>
        public void DeleteHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationExcludeCoverage excludeCoverage) { }

        /// <summary>
        /// This procedure inserts a new in-house hospitalization debit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitInfo"></param>
        public void InsertInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo,
            ref CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo) { }

        /// <summary>
        /// This procedure update an in-house hospitalization debit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitInfo"></param>
        public void UpdateInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo) { }

        /// <summary>
        /// This procedure deletes an in-house hospitalization debit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitInfo"></param>
        public void DeleteInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo) { }

        /// <summary>
        /// This procedure insert, update, or delete a hospitalization document
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationDocumentTable"></param>
        public void InsertUpdateDeleteHospitalizationDocument(CommonExchange.SysAccess userInfo, DataTable hospitalizationDocumentTable) { }

        #endregion

        #region Programmer-Defined Function Procedures

        /// <summary>
        /// This function returns the certificate no for the in-house hospitalization
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public String SelectCountForCertificateNoInHouseHospitalizationInformation(CommonExchange.SysAccess userInfo)
        {
            return String.Empty;

        }//------------------------------------------------

        /// <summary>
        /// This function returns the billing statement for member services
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns></returns>
        public DataTable SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices(CommonExchange.SysAccess userInfo, String memberSysIdList,
            String dateStart, String dateEnd)
        {
            DataTable dbTable = new DataTable();

            return dbTable;
        } //-------------------------------------------

        /// <summary>
        /// This function returns the cash receipt detailed
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <param name="isConsolidated"></param>
        /// <returns></returns>
        public DataTable SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome(CommonExchange.SysAccess userInfo,
            String dateStart, String dateEnd, Boolean isConsolidated)
        {
            DataTable dbTable = new DataTable();

            return dbTable;
        } //-------------------------------------------

        /// <summary>
        /// This function returns the cash receipts summarized table
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns></returns>
        public DataTable SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome(CommonExchange.SysAccess userInfo,
            String dateStart, String dateEnd, Boolean isConsolidated)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// This function returns the breakdown bank deposit for cash receipts detailed
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <param name="isConsolidated"></param>
        /// <param name="serverDateTime"></param>
        /// <returns></returns>
        public DataTable SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit(CommonExchange.SysAccess userInfo,
            String dateStart, String dateEnd, Boolean isConsolidated)
        {
            DataTable dbTable = new DataTable();

            return dbTable;
        } //-------------------------------------------

        /// <summary>
        /// This function returns the breakdown bank deposit for cash receipts summarized table
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns></returns>
        public DataTable SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit(CommonExchange.SysAccess userInfo,
            String dateStart, String dateEnd, Boolean isConsolidated)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// This function returns the miscellaneous income by query string and date start and date end
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns></returns>
        public DataTable SelectByQueryStringDateStartEndMiscellaneousIncome(CommonExchange.SysAccess userInfo, String queryString,
            String dateStart, String dateEnd)
        {
            DataTable dbTable = new DataTable();
           
            return dbTable;

        } //--------------------------------------------

        /// <summary>
        /// This function returns the in-house hospitalization credit by member system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, String memberSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------  

        /// <summary>
        /// This function returns the share capital credit by member system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListShareCapitalCredit(CommonExchange.SysAccess userInfo, String memberSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------   

        /// <summary>
        /// This function returns the member equity credit by member system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListMemberEquityCredit(CommonExchange.SysAccess userInfo, String memberSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------ 

        /// <summary>
        /// This function returns the regular loan payments
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanPayments(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------   

        /// <summary>
        /// this function returns the member share capital information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <param name="includeHistory"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListShareCapitalInformation(CommonExchange.SysAccess userInfo, String memberSysIdList,
            Boolean includeHistory)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------    

        /// <summary>
        /// this function returns the member in house hospitalization information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <param name="includeHistory"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListInHouseHospitalizationInformation(CommonExchange.SysAccess userInfo, String memberSysIdList,
            Boolean includeHistory)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------   

        /// <summary>
        /// This function returns the hospitalization include table
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <param name="includeMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, String queryString,
            Boolean includeMarkedDeleted)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// This function return the hospitalization exclude table
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <param name="includeMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, String queryString,
            Boolean includeMarkedDeleted)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// This function returns the in-house hospitalization debit by member system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <param name="isMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, String memberSysIdList,
            Boolean isMarkedDeleted)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------    

        /// <summary>
        /// This function returns the in-house hospitalization debit information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitSysId"></param>
        /// <returns></returns>
        public CommonExchange.InHouseHospitalizationDebit SelectBySysIDInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, String inHouseDebitSysId)
        {
            CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo = new CommonExchange.InHouseHospitalizationDebit();

            return inHouseDebitInfo;

        }  //---------------------------------------------------

        /// <summary>
        /// This function returns the hospitalization document table
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDInHouseDebitListHospitalizationDocument(CommonExchange.SysAccess userInfo, String inHouseDebitSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// This function returns the list of summary of loan payments
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <param name="isMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments(CommonExchange.SysAccess userInfo, String memberSysId,
            String regularLoanTypeIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;
        }

        /// <summary>
        /// This function determines if the hospitalization document original name already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="documentId"></param>
        /// <param name="inHouseDebitSysId"></param>
        /// <param name="originalName"></param>
        /// <returns></returns>
        public Boolean IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument(CommonExchange.SysAccess userInfo, Int64 documentId,
            String inHouseDebitSysId, String originalName)
        {
            Boolean isExist = false;

            return isExist;

        } //------------------------------------------

        #endregion
    }
}
