using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RemoteServerLib
{
    partial class ProcStatic
    {

        #region Programmer-Defined Function Procedures

        //this function returns the member classification table
        public static DataTable GetMemberClassificationTable(SqlConnection sqlConn, String userId)
        {
            DataTable dbTable = new DataTable("MemberClassificationTable");

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectMemberClassification";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                {
                    sqlAdapter.SelectCommand = sqlComm;
                    sqlAdapter.Fill(dbTable);
                }
            }

            return dbTable;
        } //--------------------------------

        //this function returns the member type table
        public static DataTable GetMemberTypeTable(SqlConnection sqlConn, String userId)
        {
            DataTable dbTable = new DataTable("MemberTypeTable");

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectMemberType";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                {
                    sqlAdapter.SelectCommand = sqlComm;
                    sqlAdapter.Fill(dbTable);
                }
            }

            return dbTable;
        } //--------------------------------

        #endregion
    }
}
