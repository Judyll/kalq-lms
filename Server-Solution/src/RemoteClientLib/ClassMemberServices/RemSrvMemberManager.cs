using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteServerLib
{
    public class RemSrvMemberManager : MarshalByRefObject, IDisposable
    {
        #region Class Constructor and Destructor
        public RemSrvMemberManager() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Void Procedures 

        //this procedure adds a new member information
        public void InsertMemberInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Member memberInfo) { }

        //this procedure updates member information
        public void UpdateMemberInformation(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo) { }

        //this procedure adds a new collector information
        public void InsertCollectorInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Collector collectorInfo) { }

        //this procedure updates collector information
        public void UpdateCollectorInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collector collectorInfo) { }

        #endregion

        #region Programmer-Defined Function Procedures

        /// <summary>
        /// This function returns a new membership id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="membershipYear"></param>
        /// <returns></returns>
        public String SelectCountForMemberIDMemberInformation(CommonExchange.SysAccess userInfo, Int32 membershipYear)
        {
            return String.Empty;
        }//------------------------------------------------

        //this function gets the member information table query
        public DataTable SelectMemberInformation(CommonExchange.SysAccess userInfo, String queryString, String officeEmployerIdList,
            String memberTypeIdList, String classificationIdList, String memberSysIdExcludeList, Boolean includeMemberStatus, Boolean isActive)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        //this function gets the collector information table query
        public DataTable SelectCollectorInformation(CommonExchange.SysAccess userInfo, String queryString,
            Boolean includeCollectorStatus, Boolean isActive)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        /// <summary>
        /// This function returns the member or employee/collector information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public DataTable SelectByQueryStringMemberEmployeeInformation(CommonExchange.SysAccess userInfo, String queryString)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //-------------------------------------

        //this function returns the member information details
        public CommonExchange.Member SelectByMemberIDMemberInformation(CommonExchange.SysAccess userInfo, String memberId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            return memberInfo;
        } //-------------------------------------

        //this function returns the member information details
        public CommonExchange.Member SelectBySysIDPersonMemberInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            return memberInfo;
        } //-------------------------------------

        //this function returns the collector information details
        public CommonExchange.Collector SelectByEmployeeIDCollectorInformation(CommonExchange.SysAccess userInfo, String employeeId)
        {
            CommonExchange.Collector collectorInfo = new CommonExchange.Collector();

            return collectorInfo;
        } //-------------------------------------

        //this function returns the collector information details
        public CommonExchange.Collector SelectBySysIDPersonCollectorInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Collector collectorInfo = new CommonExchange.Collector();

            return collectorInfo;
        } //-------------------------------------

        //this function is used to determine if the member id exists
        public Boolean IsExistsMemberIDMemberInformation(CommonExchange.SysAccess userInfo, String memberId, String memberSysId)
        {
            Boolean isExist = false;

            return isExist;
        } //-----------------------------   

        //this function is used to get data tables stored in one dataset used for member services
        public DataSet GetDataSetForMemberManager(CommonExchange.SysAccess userInfo)
        {
            DataSet dbSet = new DataSet();

            return dbSet;
        } //----------------------------------

        #endregion
    }
}
