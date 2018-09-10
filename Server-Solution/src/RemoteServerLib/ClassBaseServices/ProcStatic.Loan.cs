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

        //this function returns the regular loan type table
        public static DataTable GetRegularLoanTypeTable(SqlConnection sqlConn, String userId)
        {
            DataTable dbTable = new DataTable("RegularLoanTypeTable");

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectRegularLoanType";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                {
                    sqlAdapter.SelectCommand = sqlComm;
                    sqlAdapter.Fill(dbTable);
                }
            }

            return dbTable;
        } //--------------------------------

        //this function returns the repayment schedule table
        public static DataTable GetRepaymentScheduleTable(SqlConnection sqlConn, String userId)
        {
            DataTable dbTable = new DataTable("RepaymentScheduleTable");

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectRepaymentSchedule";

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
