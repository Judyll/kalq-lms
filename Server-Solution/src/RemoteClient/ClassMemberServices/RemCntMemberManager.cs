using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteClient
{
    public class RemCntMemberManager : IDisposable
    {
        #region Class Constructor and Destructor
        public RemCntMemberManager() { }

        void IDisposable.Dispose() { }

        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure adds a new member information
        public void InsertMemberInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Member memberInfo) 
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertMemberInformation");

            remServer.InsertMemberInformation(userInfo, ref memberInfo);
        } //-------------------------------

        //this procedure updates member information
        public void UpdateMemberInformation(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo) 
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "UpdateMemberInformation");

            remServer.UpdateMemberInformation(userInfo, memberInfo);
        } //----------------------------------

        //this procedure adds a new collector information
        public void InsertCollectorInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Collector collectorInfo) 
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertCollectorInformation");

            remServer.InsertCollectorInformation(userInfo, ref collectorInfo);
        } //--------------------------------------

        //this procedure updates collector information
        public void UpdateCollectorInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collector collectorInfo) 
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "UpdateCollectorInformation");

            remServer.UpdateCollectorInformation(userInfo, collectorInfo);
        } //------------------------------------------

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
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectCountForMemberIDMemberInformation");

            return remServer.SelectCountForMemberIDMemberInformation(userInfo, membershipYear);
        }//------------------------------------------------

        //this function gets the member information table query
        public DataTable SelectMemberInformation(CommonExchange.SysAccess userInfo, String queryString, String officeEmployerIdList,
            String memberTypeIdList, String classificationIdList, String memberSysIdExcludeList, Boolean includeMemberStatus, Boolean isActive)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectMemberInformation");

            return remServer.SelectMemberInformation(userInfo, queryString, officeEmployerIdList, 
                memberTypeIdList, classificationIdList, memberSysIdExcludeList, includeMemberStatus, isActive);

        } //------------------------------

        //this function gets the collector information table query
        public DataTable SelectCollectorInformation(CommonExchange.SysAccess userInfo, String queryString,
            Boolean includeCollectorStatus, Boolean isActive)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectCollectorInformation");

            return remServer.SelectCollectorInformation(userInfo, queryString, includeCollectorStatus, isActive);

        } //------------------------------

        /// <summary>
        /// This function returns the member or employee/collector information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public DataTable SelectByQueryStringMemberEmployeeInformation(CommonExchange.SysAccess userInfo, String queryString)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectByQueryStringMemberEmployeeInformation");

            return remServer.SelectByQueryStringMemberEmployeeInformation(userInfo, queryString);

        } //-------------------------------------

        //this function returns the member information details
        public CommonExchange.Member SelectByMemberIDMemberInformation(CommonExchange.SysAccess userInfo, String memberId)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectByMemberIDMemberInformation");

            return remServer.SelectByMemberIDMemberInformation(userInfo, memberId);
        } //-------------------------------------

        //this function returns the member information details
        public CommonExchange.Member SelectBySysIDPersonMemberInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDPersonMemberInformation");

            return remServer.SelectBySysIDPersonMemberInformation(userInfo, personSysId);
        } //-------------------------------------

        //this function returns the collector information details
        public CommonExchange.Collector SelectByEmployeeIDCollectorInformation(CommonExchange.SysAccess userInfo, String employeeId)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectByEmployeeIDCollectorInformation");

            return remServer.SelectByEmployeeIDCollectorInformation(userInfo, employeeId);
        } //-------------------------------------

        //this function returns the collector information details
        public CommonExchange.Collector SelectBySysIDPersonCollectorInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDPersonCollectorInformation");

            return remServer.SelectBySysIDPersonCollectorInformation(userInfo, personSysId);
        } //-------------------------------------

        //this function is used to determine if the member id exists
        public Boolean IsExistsMemberIDMemberInformation(CommonExchange.SysAccess userInfo, String memberId, String memberSysId)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsMemberIDMemberInformation");

            return remServer.IsExistsMemberIDMemberInformation(userInfo, memberId, memberSysId);
        } //-----------------------------   

        //this function is used to get data tables stored in one dataset used for member services
        public DataSet GetDataSetForMemberManager(CommonExchange.SysAccess userInfo)
        {
            RemoteServerLib.RemSrvMemberManager remServer = (RemoteServerLib.RemSrvMemberManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvMemberManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "GetDataSetForMemberManager");

            return remServer.GetDataSetForMemberManager(userInfo);
        } //----------------------------------

        #endregion
    }
}
