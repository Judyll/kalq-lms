using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteServerLib
{
    public class RemSrvLoanManager : MarshalByRefObject, IDisposable
    {
        #region Class Constructor and Destructor
        public RemSrvLoanManager() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure adds a new regular loan information
        public void InsertRegularLoanInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.RegularLoan regularLoanInfo) { }

        //this procedure update a regular loan information
        public void UpdateRegularLoanInformation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo) { }

        //this procedure delete a regular loan information
        public void DeleteRegularLoanInformation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo) { }

        /// <summary>
        /// this procedure inserts, update or delete a regular loan document
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanDocumentTable"></param>
        public void InsertUpdateDeleteRegularLoanDocument(CommonExchange.SysAccess userInfo, DataTable regularLoanDocumentTable) { }

        /// <summary>
        /// this procedure adds a new collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void InsertCollateralInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Collateral collateralInfo) { }

        /// <summary>
        /// this procedure updates a collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void UpdateCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo) { }

        /// <summary>
        /// this procedure deletes a collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void DeleteCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo) { }

        /// <summary>
        /// this procedure inserts and deletes a regular loan collateral
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanCollateralTable"></param>
        public void InsertDeleteRegularLoanCollateral(CommonExchange.SysAccess userInfo, DataTable regularLoanCollateralTable) { }

        /// <summary>
        /// this procedure inserts, updates and deletes a regular loan co-maker
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanCoMakerTable"></param>
        public void InsertUpdateDeleteRegularLoanCoMaker(CommonExchange.SysAccess userInfo, DataTable regularLoanCoMakerTable) { }

        /// <summary>
        /// this procedure adds, updates, and deletes a regular loan amortization
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanAmortizationList"></param>
        public void InsertUpdateDeleteRegularLoanAmortization(CommonExchange.SysAccess userInfo, String regularLoanSysId,
            List<CommonExchange.RegularLoanAmortization> loanAmortizationList) { }

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
            return String.Empty;
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
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------     

        /// <summary>
        /// get the regular loan information by regular loan system id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularSysId"></param>
        /// <returns></returns>
        public CommonExchange.RegularLoan SelectBySysIDRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanSysId)
        {
            CommonExchange.RegularLoan regularLoanInfo = new CommonExchange.RegularLoan();

            return regularLoanInfo;

        }  //---------------------------------------------------

        /// <summary>
        /// this function gets the regular loan documents by sysid_regular list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanDocument(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

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
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// this function returns the regular loan collateral by regular loan system id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysId"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanCollateral(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// this function returns the regular loan co-maker by regular loan system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanCoMaker(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

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
            Boolean isExist = false;

            return isExist;

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
            Boolean isExist = false;

            return isExist;

        } //------------------------------------------

        //this function is used to determine if the payment date from, to and grace period already exists
        public Boolean IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization(CommonExchange.SysAccess userInfo, Int64 amortizationId,
            String regularLoanSysId, String paymentDateFrom, String paymentDateTo)
        {
            Boolean isExist = false;

            return isExist;
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
            Boolean isExist = false;

            return isExist;
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
            Boolean isExist = false;

            return isExist;
        } //------------------------------

        /// <summary>
        /// gets the dataset for the loan manager
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public DataSet GetDataSetForLoanManager(CommonExchange.SysAccess userInfo)
        {
            DataSet dbSet = new DataSet();

            return dbSet;
        } //----------------------------------

        #endregion
    }
}
