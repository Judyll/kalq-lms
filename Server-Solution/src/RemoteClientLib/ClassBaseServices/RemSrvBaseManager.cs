using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteServerLib
{
    public class RemSrvBaseManager: MarshalByRefObject, IDisposable
    {
        #region Class Constructor and Destructor
        public RemSrvBaseManager() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure adds a office/employer information
        public void InsertOfficeEmployerInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.OfficeEmployer officeEmployerInfo) { }

        //this procedure updates a office information
        public void UpdateOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo) { }

        //this procedure deletes a office information
        public void DeleteOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo) { }

        //this procedure inserts or updates a person infomation
        public void InsertUpdatePersonInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Person personInfo) { }

        //this procedure inserts or updates a person information
        public void InsertUpdatePersonInformationNoAuthenticate(CommonExchange.SysAccess userInfo, SqlConnection sqlConn,
            ref CommonExchange.Person personInfo) { }

        //this procedure inserts, update or delete a person document
        public void InsertUpdateDeletePersonDocument(CommonExchange.SysAccess userInfo, DataTable personDocumentTable) { }
       
        #endregion

        #region Programmer-Defined Function Procedures

        //this function gets the office information table query
        public DataTable SelectOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String queryString, Boolean includeMarkedDeleted)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        //this function gets the person information table query
        public DataTable SelectPersonInformation(CommonExchange.SysAccess userInfo, String queryString,
            String lastName, String firstName, String personSysIdExcludeList)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        //this function returns the person information details
        public CommonExchange.Person SelectBySysIDPersonInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Person personInfo = new CommonExchange.Person();

            return personInfo;
        } //------------------------------------

        //this function returns the person information details
        public CommonExchange.Person SelectBySysIDPersonInformationNoAuthenticate(String userId, SqlConnection sqlConn, String personSysId)
        {
            CommonExchange.Person personInfo = new CommonExchange.Person();

            return personInfo;
        } //------------------------------------

        //this function gets the person information documents by sysid_person list
        public DataTable SelectBySysIDPersonListPersonDocument(CommonExchange.SysAccess userInfo, String personSysIdList,
            Boolean isPrimaryImage)
        {
            DataTable dbTable = new DataTable();

            return dbTable;

        } //------------------------------

        //this function return the server date
        public String GetServerDateTime(CommonExchange.SysAccess userInfo)
        {
            String serverTime = String.Empty;

            return serverTime;
                        
        } //--------------------------

        //this function return the server date
        public String GetServerDateTimeNoAuthenticate(SqlConnection sqlConn)
        {
            DateTime serverTime = DateTime.MinValue;

            return serverTime.ToString("o");

        } //--------------------------

        //this function is used to determine if the office name exists
        public Boolean IsExistsNameOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerName)
        {
            Boolean isExist = false;

            return isExist;
        } //-----------------------------   

        //this function is used to determine if the office acronym exists
        public Boolean IsExistsAcronymOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerAcronym)
        {
            Boolean isExist = false;

            return isExist;
        } //-----------------------------   

        //this function determines if the person is a member or a collector
        public Boolean IsExistsSysIDPersonMemberCollectorInformation(CommonExchange.SysAccess userInfo, String personSysId, ref Boolean isCollector)
        {
            Boolean isExist = false;

            return isExist;

        } //------------------------------

        //this function determines if the person document original name already exists
        public Boolean IsExistsSysIDPersonOriginalNamePersonDocument(CommonExchange.SysAccess userInfo, Int64 documentId, String personSysId,
            String originalName)
        {
            Boolean isExist = false;

            return isExist;

        } //------------------------------

        //this function is used to get data tables stored in one dataset used for administrator services
        public DataSet GetDataSetForBaseManager(CommonExchange.SysAccess userInfo)
        {
            DataSet dbSet = new DataSet();

            return dbSet;
        } //----------------------------------

        #endregion
    }
}
