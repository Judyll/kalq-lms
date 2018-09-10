using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteClient
{
    public class RemCntBaseManager: IDisposable
    {
        #region Class Constructor and Destructor
        public RemCntBaseManager() { }

        void IDisposable.Dispose() { }

        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure adds a office/employer information
        public void InsertOfficeEmployerInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertOfficeEmployerInformation");

            remServer.InsertOfficeEmployerInformation(userInfo, ref officeEmployerInfo);

        } //--------------------------------

        //this procedure updates a office information
        public void UpdateOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "UpdateOfficeEmployerInformation");

            remServer.UpdateOfficeEmployerInformation(userInfo, officeEmployerInfo);

        } //--------------------------------

        //this procedure deletes a office information
        public void DeleteOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "DeleteOfficeEmployerInformation");

            remServer.DeleteOfficeEmployerInformation(userInfo, officeEmployerInfo);

        } //--------------------------------

        //this procedure inserts or updates a person infomation
        public void InsertUpdatePersonInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Person personInfo) 
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertUpdatePersonInformation");

            remServer.InsertUpdatePersonInformation(userInfo, ref personInfo);
        } //------------------------------------------------

        //this procedure inserts or updates a person information
        public void InsertUpdatePersonInformationNoAuthenticate(CommonExchange.SysAccess userInfo, SqlConnection sqlConn,
            ref CommonExchange.Person personInfo) 
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertUpdatePersonInformationNoAuthenticate");

            remServer.InsertUpdatePersonInformationNoAuthenticate(userInfo, sqlConn, ref personInfo);
        } //-------------------------------------

        //this procedure inserts, update or delete a person document
        public void InsertUpdateDeletePersonDocument(CommonExchange.SysAccess userInfo, DataTable personDocumentTable) 
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "InsertUpdateDeletePersonDocument");

            remServer.InsertUpdateDeletePersonDocument(userInfo, personDocumentTable);
        } //-------------------------------------

        #endregion

        #region Programmer-Defined Function Procedures

        //this function gets the office information table query
        public DataTable SelectOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String queryString, Boolean includeMarkedDeleted)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectOfficeEmployerInformation");

            return remServer.SelectOfficeEmployerInformation(userInfo, queryString, includeMarkedDeleted);

        } //------------------------------

        //this function gets the person information table query
        public DataTable SelectPersonInformation(CommonExchange.SysAccess userInfo, String queryString,
            String lastName, String firstName, String personSysIdExcludeList)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectPersonInformation");

            return remServer.SelectPersonInformation(userInfo, queryString, lastName, firstName, personSysIdExcludeList);

        } //------------------------------

        //this function returns the person information details
        public CommonExchange.Person SelectBySysIDPersonInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDPersonInformation");

            return remServer.SelectBySysIDPersonInformation(userInfo, personSysId);
        } //------------------------------------

        //this function returns the person information details
        public CommonExchange.Person SelectBySysIDPersonInformationNoAuthenticate(String userId, SqlConnection sqlConn, String personSysId)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDPersonInformationNoAuthenticate");

            return remServer.SelectBySysIDPersonInformationNoAuthenticate(userId, sqlConn, personSysId);
        } //------------------------------------

        //this function gets the person information documents by sysid_person list
        public DataTable SelectBySysIDPersonListPersonDocument(CommonExchange.SysAccess userInfo, String personSysIdList,
            Boolean isPrimaryImage)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "SelectBySysIDPersonListPersonDocument");

            return remServer.SelectBySysIDPersonListPersonDocument(userInfo, personSysIdList, isPrimaryImage);

        } //------------------------------

        //this function return the server date
        public String GetServerDateTime(CommonExchange.SysAccess userInfo)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "GetServerDateTime");

            return remServer.GetServerDateTime(userInfo);

        } //--------------------------

        //this function return the server date
        public String GetServerDateTimeNoAuthenticate(SqlConnection sqlConn)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "GetServerDateTimeNoAuthenticate");

            return remServer.GetServerDateTimeNoAuthenticate(sqlConn);

        } //--------------------------

        //this function is used to determine if the office name exists
        public Boolean IsExistsNameOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerName)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsNameOfficeEmployerInformation");

            return remServer.IsExistsNameOfficeEmployerInformation(userInfo, officeEmployerId, officeEmployerName);
        } //-----------------------------   

        //this function is used to determine if the office acronym exists
        public Boolean IsExistsAcronymOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerAcronym)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsAcronymOfficeEmployerInformation");

            return remServer.IsExistsAcronymOfficeEmployerInformation(userInfo, officeEmployerId, officeEmployerAcronym);
        } //-----------------------------   

        //this function determines if the person is a member or a collector
        public Boolean IsExistsSysIDPersonMemberCollectorInformation(CommonExchange.SysAccess userInfo, String personSysId, ref Boolean isCollector)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsSysIDPersonMemberCollectorInformation");

            return remServer.IsExistsSysIDPersonMemberCollectorInformation(userInfo, personSysId, ref isCollector);

        } //------------------------------

        //this function determines if the person document original name already exists
        public Boolean IsExistsSysIDPersonOriginalNamePersonDocument(CommonExchange.SysAccess userInfo, Int64 documentId, String personSysId,
            String originalName)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "IsExistsSysIDPersonOriginalNamePersonDocument");

            return remServer.IsExistsSysIDPersonOriginalNamePersonDocument(userInfo, documentId, personSysId, originalName);

        } //------------------------------

        //this function is used to get data tables stored in one dataset used for base services
        public DataSet GetDataSetForBaseManager(CommonExchange.SysAccess userInfo)
        {
            RemoteServerLib.RemSrvBaseManager remServer = (RemoteServerLib.RemSrvBaseManager)Activator.GetObject(typeof(RemoteServerLib.RemSrvBaseManager),
                                                        TcpRemoteServer.GetRemoteServerTcp() + "GetDataSetForBaseManager");

            return remServer.GetDataSetForBaseManager(userInfo);
        } //----------------------------------

        #endregion

    }
}
