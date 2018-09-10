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
        public void InsertChartOfAccounts(CommonExchange.SysAccess userInfo, ref CommonExchange.ChartOfAccount chartOfAccount)
        {
            if (chartOfAccount.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertChartOfAccounts";

                        sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = chartOfAccount.AccountSysId =
                            PrimaryKeys.GetNewChartOfAccountsSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@accounting_category_id", SqlDbType.VarChar).Value = chartOfAccount.AccountingCategoryInfo.AccountingCategoryId;
                        sqlComm.Parameters.Add("@account_code", SqlDbType.VarChar).Value = chartOfAccount.AccountCode;
                        sqlComm.Parameters.Add("@account_name", SqlDbType.VarChar).Value = chartOfAccount.AccountName;
                        sqlComm.Parameters.Add("@account_description", SqlDbType.VarChar).Value = chartOfAccount.AccountDescription;
                        sqlComm.Parameters.Add("@company_policy_procedure", SqlDbType.VarChar).Value = chartOfAccount.CompanyPolicyProcedure;

                        if (String.IsNullOrEmpty(chartOfAccount.SummaryAccount.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@summary_account", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@summary_account", SqlDbType.VarChar).Value = chartOfAccount.SummaryAccount.AccountSysId;
                        }

                        sqlComm.Parameters.Add("@is_debit_side_increase", SqlDbType.VarChar).Value = chartOfAccount.IsDebitSideIncrease;
                        sqlComm.Parameters.Add("@is_active_account", SqlDbType.VarChar).Value = chartOfAccount.IsActiveAccount;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        } //-----------------------------------

        /// <summary>
        /// This procedure updates a chart of account
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="chartOfAccount"></param>
        public void UpdateChartOfAccounts(CommonExchange.SysAccess userInfo, CommonExchange.ChartOfAccount chartOfAccount)
        {
            if (chartOfAccount.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateChartOfAccounts";

                        sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = chartOfAccount.AccountSysId;
                        sqlComm.Parameters.Add("@accounting_category_id", SqlDbType.VarChar).Value = chartOfAccount.AccountingCategoryInfo.AccountingCategoryId;
                        sqlComm.Parameters.Add("@account_code", SqlDbType.VarChar).Value = chartOfAccount.AccountCode;
                        sqlComm.Parameters.Add("@account_name", SqlDbType.VarChar).Value = chartOfAccount.AccountName;
                        sqlComm.Parameters.Add("@account_description", SqlDbType.VarChar).Value = chartOfAccount.AccountDescription;
                        sqlComm.Parameters.Add("@company_policy_procedure", SqlDbType.VarChar).Value = chartOfAccount.CompanyPolicyProcedure;

                        if (String.IsNullOrEmpty(chartOfAccount.SummaryAccount.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@summary_account", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@summary_account", SqlDbType.VarChar).Value = chartOfAccount.SummaryAccount.AccountSysId;
                        }

                        sqlComm.Parameters.Add("@is_debit_side_increase", SqlDbType.VarChar).Value = chartOfAccount.IsDebitSideIncrease;
                        sqlComm.Parameters.Add("@is_active_account", SqlDbType.VarChar).Value = chartOfAccount.IsActiveAccount;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        } //-----------------------------------

        /// <summary>
        /// This procedure insert a new bank information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankInfo"></param>
        public void InsertBankInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Bank bankInfo)
        {
            if (bankInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertBankInformation";

                        sqlComm.Parameters.Add("@sysid_bank", SqlDbType.VarChar).Value = bankInfo.BankSysId =
                            PrimaryKeys.GetNewBankInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@bank_name", SqlDbType.VarChar).Value = bankInfo.BankName;
                        sqlComm.Parameters.Add("@bank_address", SqlDbType.VarChar).Value = bankInfo.BankAddress;
                        sqlComm.Parameters.Add("@account_no", SqlDbType.VarChar).Value = bankInfo.AccountNo;
                        sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = bankInfo.AccountInfo.AccountSysId;
                        sqlComm.Parameters.Add("@is_active_account", SqlDbType.Bit).Value = bankInfo.IsActiveAccount;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        } //-----------------------------------

        /// <summary>
        /// This procedure updates a bank information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="bankInfo"></param>
        public void UpdateBankInformation(CommonExchange.SysAccess userInfo, CommonExchange.Bank bankInfo)
        {
            if (bankInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateBankInformation";

                        sqlComm.Parameters.Add("@sysid_bank", SqlDbType.VarChar).Value = bankInfo.BankSysId;
                        sqlComm.Parameters.Add("@bank_name", SqlDbType.VarChar).Value = bankInfo.BankName;
                        sqlComm.Parameters.Add("@bank_address", SqlDbType.VarChar).Value = bankInfo.BankAddress;
                        sqlComm.Parameters.Add("@account_no", SqlDbType.VarChar).Value = bankInfo.AccountNo;
                        sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = bankInfo.AccountInfo.AccountSysId;
                        sqlComm.Parameters.Add("@is_active_account", SqlDbType.Bit).Value = bankInfo.IsActiveAccount;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        } //-----------------------------------

        /// <summary>
        /// This procedure insert a new disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void InsertDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.DisbursementVoucher voucherInfo)
        {
            if (voucherInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertDisbursementVoucherInformation";

                        sqlComm.Parameters.Add("@sysid_voucher", SqlDbType.VarChar).Value = voucherInfo.VoucherSysId =
                            PrimaryKeys.GetNewDisbursementVoucherInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@sysid_bank", SqlDbType.VarChar).Value = voucherInfo.BankInfo.BankSysId;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = voucherInfo.CheckNo;
                        sqlComm.Parameters.Add("@check_date", SqlDbType.DateTime).Value = DateTime.Parse(voucherInfo.CheckDate);
                        sqlComm.Parameters.Add("@payee", SqlDbType.VarChar).Value = voucherInfo.Payee;

                        if (String.IsNullOrEmpty(voucherInfo.RegularLoanInfo.RegularLoanSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = voucherInfo.RegularLoanInfo.RegularLoanSysId;
                        }

                        if (String.IsNullOrEmpty(voucherInfo.InHouseDebitInfo.InHouseDebitSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = voucherInfo.InHouseDebitInfo.InHouseDebitSysId;
                        }

                        sqlComm.Parameters.Add("@check_amount", SqlDbType.Decimal).Value = voucherInfo.CheckAmount;
                        sqlComm.Parameters.Add("@particulars", SqlDbType.VarChar).Value = voucherInfo.Particulars;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update, and delete a disbursement voucher entry
                    this.InsertUpdateDeleteDisbursementVoucherEntry(userInfo, auth.Connection, voucherInfo.VoucherSysId,
                        voucherInfo.VoucherEntryList);
                    //---------------------------------------------
                }
            }
        } //-----------------------------------

        /// <summary>
        /// This procedure updates a disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void UpdateDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher voucherInfo)
        {
            if (voucherInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateDisbursementVoucherInformation";

                        sqlComm.Parameters.Add("@sysid_voucher", SqlDbType.VarChar).Value = voucherInfo.VoucherSysId;
                        sqlComm.Parameters.Add("@sysid_bank", SqlDbType.VarChar).Value = voucherInfo.BankInfo.BankSysId;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = voucherInfo.CheckNo;
                        sqlComm.Parameters.Add("@check_date", SqlDbType.DateTime).Value = DateTime.Parse(voucherInfo.CheckDate);
                        sqlComm.Parameters.Add("@payee", SqlDbType.VarChar).Value = voucherInfo.Payee;

                        if (String.IsNullOrEmpty(voucherInfo.RegularLoanInfo.RegularLoanSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = voucherInfo.RegularLoanInfo.RegularLoanSysId;
                        }

                        if (String.IsNullOrEmpty(voucherInfo.InHouseDebitInfo.InHouseDebitSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = voucherInfo.InHouseDebitInfo.InHouseDebitSysId;
                        }

                        sqlComm.Parameters.Add("@check_amount", SqlDbType.Decimal).Value = voucherInfo.CheckAmount;
                        sqlComm.Parameters.Add("@particulars", SqlDbType.VarChar).Value = voucherInfo.Particulars;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update, and delete a disbursement voucher entry
                    this.InsertUpdateDeleteDisbursementVoucherEntry(userInfo, auth.Connection, voucherInfo.VoucherSysId,
                        voucherInfo.VoucherEntryList);
                    //---------------------------------------------
                }
            }
        } //-----------------------------------

        /// <summary>
        /// This procedure delete a disbursement voucher information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="voucherInfo"></param>
        public void DeleteDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher voucherInfo)
        {
            if (voucherInfo.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteDisbursementVoucherInformation";

                        sqlComm.Parameters.Add("@sysid_voucher", SqlDbType.VarChar).Value = voucherInfo.VoucherSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// This function insert, update, and delete a disbursement voucher entry
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="voucherSysId"></param>
        /// <param name="voucherEntryList"></param>
        private void InsertUpdateDeleteDisbursementVoucherEntry(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String voucherSysId,
            List<CommonExchange.VoucherEntry> voucherEntryList)
        {
            foreach (CommonExchange.VoucherEntry vEntry in voucherEntryList)
            {
                if (vEntry.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteDisbursementVoucherEntry";

                        sqlComm.Parameters.Add("@voucher_entry_id", SqlDbType.BigInt).Value = vEntry.VoucherEntryId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }

            }

            foreach (CommonExchange.VoucherEntry vEntry in voucherEntryList)
            {
                if (vEntry.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertDisbursementVoucherEntry";

                        sqlComm.Parameters.Add("@sysid_voucher", SqlDbType.VarChar).Value = voucherSysId;
                        sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = vEntry.AccountInfo.AccountSysId;
                        sqlComm.Parameters.Add("@cost_center_id", SqlDbType.VarChar).Value = vEntry.CostCenterInfo.DepartmentId;
                        sqlComm.Parameters.Add("@debit_amount", SqlDbType.Decimal).Value = vEntry.DebitAmount;
                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = vEntry.CreditAmount;
                        sqlComm.Parameters.Add("@sequence_no", SqlDbType.SmallInt).Value = vEntry.SequenceNo;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (vEntry.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateDisbursementVoucherEntry";

                        sqlComm.Parameters.Add("@voucher_entry_id", SqlDbType.VarChar).Value = vEntry.VoucherEntryId;
                        sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = vEntry.AccountInfo.AccountSysId;
                        sqlComm.Parameters.Add("@cost_center_id", SqlDbType.VarChar).Value = vEntry.CostCenterInfo.DepartmentId;
                        sqlComm.Parameters.Add("@debit_amount", SqlDbType.Decimal).Value = vEntry.DebitAmount;
                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = vEntry.CreditAmount;
                        sqlComm.Parameters.Add("@sequence_no", SqlDbType.SmallInt).Value = vEntry.SequenceNo;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

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
            DataTable dbTable = new DataTable("ChartOfAccountsTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectChartOfAccounts";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    if (String.IsNullOrEmpty(summaryAccount))
                    {
                        sqlComm.Parameters.Add("@summary_account", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@summary_account", SqlDbType.NVarChar).Value = summaryAccount;
                    }

                    if (String.IsNullOrEmpty(accountingCategoryIdList))
                    {
                        sqlComm.Parameters.Add("@accounting_category_id_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@accounting_category_id_list", SqlDbType.NVarChar).Value = accountingCategoryIdList;
                    }

                    sqlComm.Parameters.Add("@is_active_account", SqlDbType.Bit).Value = isActiveAccount;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }
                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDAccountChartOfAccounts";

                    sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = accountSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                accountInfo.AccountSysId = ProcStatic.DataReaderConvert(sqlReader, "sysid_account", String.Empty);
                                accountInfo.AccountCode = ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                accountInfo.AccountName = ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
                                accountInfo.AccountDescription = ProcStatic.DataReaderConvert(sqlReader, "account_description", String.Empty);
                                accountInfo.CompanyPolicyProcedure = ProcStatic.DataReaderConvert(sqlReader, "company_policy_procedure", String.Empty);
                                accountInfo.IsDebitSideIncrease = ProcStatic.DataReaderConvert(sqlReader, "is_debit_side_increase", false);
                                accountInfo.IsActiveAccount = ProcStatic.DataReaderConvert(sqlReader, "is_active_account", false);

                                accountInfo.AccountingCategoryInfo.AccountingCategoryId = ProcStatic.DataReaderConvert(sqlReader,
                                    "accounting_category_id", String.Empty);
                                accountInfo.AccountingCategoryInfo.CategoryDescription = ProcStatic.DataReaderConvert(sqlReader,
                                    "category_description", String.Empty);

                                accountInfo.SummaryAccount.AccountSysId = ProcStatic.DataReaderConvert(sqlReader, "sysid_account_summary", String.Empty);
                                accountInfo.SummaryAccount.AccountCode = ProcStatic.DataReaderConvert(sqlReader, "account_code_summary", String.Empty);
                                accountInfo.SummaryAccount.AccountName = ProcStatic.DataReaderConvert(sqlReader, "account_name_summary", String.Empty);
                                accountInfo.SummaryAccount.AccountDescription = ProcStatic.DataReaderConvert(sqlReader, "account_description_summary", 
                                    String.Empty);
                                accountInfo.SummaryAccount.CompanyPolicyProcedure = ProcStatic.DataReaderConvert(sqlReader,
                                    "company_policy_procedure_summary", String.Empty);
                                accountInfo.SummaryAccount.IsDebitSideIncrease = ProcStatic.DataReaderConvert(sqlReader, "is_debit_side_increase_summary", false);
                                accountInfo.SummaryAccount.IsActiveAccount = ProcStatic.DataReaderConvert(sqlReader, "is_active_account_summary", false);

                                accountInfo.SummaryAccount.AccountingCategoryInfo.AccountingCategoryId = ProcStatic.DataReaderConvert(sqlReader,
                                    "accounting_category_id_summary", String.Empty);
                                accountInfo.SummaryAccount.AccountingCategoryInfo.CategoryDescription = ProcStatic.DataReaderConvert(sqlReader,
                                    "category_description_summary", String.Empty);

                                break;

                            }
                        }

                        sqlReader.Close();
                    }
                }
            }

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
            DataTable dbTable = new DataTable("BankInformationTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBankInformation";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    sqlComm.Parameters.Add("@is_active_account", SqlDbType.Bit).Value = isActiveAccount;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }
                }
            }

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
            DataTable dbTable = new DataTable("DisbursementVoucherInformationByQueryStringDateStartEndTable");
            dbTable.Columns.Add("sysid_voucher", System.Type.GetType("System.String"));
			dbTable.Columns.Add("check_no", System.Type.GetType("System.String"));
			dbTable.Columns.Add("check_date", System.Type.GetType("System.String"));
			dbTable.Columns.Add("date_issued", System.Type.GetType("System.String"));
			dbTable.Columns.Add("payee", System.Type.GetType("System.String"));
			dbTable.Columns.Add("check_amount", System.Type.GetType("System.Decimal"));
			dbTable.Columns.Add("particulars", System.Type.GetType("System.String"));
			dbTable.Columns.Add("is_marked_deleted", System.Type.GetType("System.Boolean"));

			dbTable.Columns.Add("sysid_bank", System.Type.GetType("System.String"));
			dbTable.Columns.Add("bank_name", System.Type.GetType("System.String"));
			dbTable.Columns.Add("account_no_bank", System.Type.GetType("System.String"));
			dbTable.Columns.Add("is_active_account_bank", System.Type.GetType("System.Boolean"));
				
			dbTable.Columns.Add("sysid_account", System.Type.GetType("System.String"));
			dbTable.Columns.Add("account_code", System.Type.GetType("System.String"));
			dbTable.Columns.Add("account_name", System.Type.GetType("System.String"));
			dbTable.Columns.Add("is_debit_side_increase", System.Type.GetType("System.Boolean"));
			dbTable.Columns.Add("is_active_account_account", System.Type.GetType("System.Boolean"));

		    dbTable.Columns.Add("accounting_category_id", System.Type.GetType("System.String"));
			dbTable.Columns.Add("category_description", System.Type.GetType("System.String"));

		    dbTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
			dbTable.Columns.Add("account_no_loan", System.Type.GetType("System.String"));
			dbTable.Columns.Add("sysid_member_loan", System.Type.GetType("System.String"));
			dbTable.Columns.Add("member_id_loan", System.Type.GetType("System.String"));
			dbTable.Columns.Add("sysid_person_loan", System.Type.GetType("System.String"));
			dbTable.Columns.Add("last_name_loan", System.Type.GetType("System.String"));
			dbTable.Columns.Add("first_name_loan", System.Type.GetType("System.String"));
			dbTable.Columns.Add("middle_name_loan", System.Type.GetType("System.String"));

			dbTable.Columns.Add("sysid_inhousedebit", System.Type.GetType("System.String"));
			dbTable.Columns.Add("hospital_name_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("date_from_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("date_to_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("sysid_member_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("member_id_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("sysid_person_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("last_name_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("first_name_inhouse", System.Type.GetType("System.String"));
			dbTable.Columns.Add("middle_name_inhouse", System.Type.GetType("System.String"));

			dbTable.Columns.Add("is_regular_loan", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_inhouse_hospitalization_debit", System.Type.GetType("System.Boolean"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByQueryStringDateStartEndDisbursementVoucherInformation";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    DateTime dStart = DateTime.MinValue;
                    DateTime dEnd = DateTime.MinValue;

                    if ((String.IsNullOrEmpty(dateStart) || !DateTime.TryParse(dateStart, out dStart)) ||
                        (String.IsNullOrEmpty(dateEnd) || !DateTime.TryParse(dateEnd, out dEnd)))
                    {
                        sqlComm.Parameters.Add("@date_start", SqlDbType.DateTime).Value = DBNull.Value;
                        sqlComm.Parameters.Add("@date_end", SqlDbType.DateTime).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@date_start", SqlDbType.DateTime).Value = dStart;
                        sqlComm.Parameters.Add("@date_end", SqlDbType.DateTime).Value = dEnd;
                    }

                    sqlComm.Parameters.Add("@is_cancelled_voucher", SqlDbType.Bit).Value = isCancelledVoucher;
                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["sysid_voucher"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_voucher", String.Empty);
                                newRow["check_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);
                                newRow["check_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_date", DateTime.MinValue).ToString();
                                newRow["date_issued"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_issued", DateTime.MinValue).ToString();
                                newRow["payee"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payee", String.Empty);
                                newRow["check_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_amount", Decimal.Parse("0"));
                                newRow["particulars"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "particulars", String.Empty);
                                newRow["is_marked_deleted"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_marked_deleted", false);

                                newRow["sysid_bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_bank", String.Empty);
                                newRow["bank_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "bank_name", String.Empty);
                                newRow["account_no_bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_no_bank", String.Empty);
                                newRow["is_active_account_bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account_bank", false);

                                newRow["sysid_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account", String.Empty);
                                newRow["account_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                newRow["account_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
                                newRow["is_debit_side_increase"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_debit_side_increase", false);
                                newRow["is_active_account_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account_account", false);

                                newRow["accounting_category_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "accounting_category_id", String.Empty);
                                newRow["category_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "category_description", String.Empty);

                                newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_regular", String.Empty);
                                newRow["account_no_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_no_loan", String.Empty);
                                newRow["sysid_member_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member_loan", String.Empty);
                                newRow["member_id_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "member_id_loan", String.Empty);
                                newRow["sysid_person_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_person_loan", String.Empty);
                                newRow["last_name_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "last_name_loan", String.Empty);
                                newRow["first_name_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "first_name_loan", String.Empty);
                                newRow["middle_name_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "middle_name_loan", String.Empty);

                                newRow["sysid_inhousedebit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_inhousedebit", String.Empty);
                                newRow["hospital_name_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "hospital_name_inhouse", String.Empty);
                                newRow["date_from_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_from_inhouse",
                                    DateTime.MinValue).ToString();
                                newRow["date_to_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_to_inhouse",
                                    DateTime.MinValue).ToString();
                                newRow["sysid_member_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member_inhouse", String.Empty);
                                newRow["member_id_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "member_id_inhouse", String.Empty);
                                newRow["sysid_person_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_person_inhouse", String.Empty);
                                newRow["last_name_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "last_name_inhouse", String.Empty);
                                newRow["first_name_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "first_name_inhouse", String.Empty);
                                newRow["middle_name_inhouse"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "middle_name_inhouse", String.Empty);

                                newRow["is_regular_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_regular_loan", false);
                                newRow["is_inhouse_hospitalization_debit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "is_inhouse_hospitalization_debit", false);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();
                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDVoucherDisbursementVoucherInformation";

                    sqlComm.Parameters.Add("@sysid_voucher", SqlDbType.VarChar).Value = voucherSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                voucherInfo.VoucherSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_voucher", String.Empty);
		                        voucherInfo.CheckNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);
		                        voucherInfo.CheckDate = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_date", DateTime.MinValue).ToString();
		                        voucherInfo.DateIssued = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_issued", DateTime.MinValue).ToString();
	                            voucherInfo.Payee = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payee", String.Empty);
		                        voucherInfo.CheckAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_amount", Decimal.Parse("0.00"));
		                        voucherInfo.Particulars = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "particulars", String.Empty);
		                        voucherInfo.IsMarkedDeleted = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_marked_deleted", false);

			                    voucherInfo.BankInfo.BankSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_bank", String.Empty);
		                        voucherInfo.BankInfo.BankName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "bank_name", String.Empty);
		                        voucherInfo.BankInfo.AccountNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_no_bank", String.Empty);
		                        voucherInfo.BankInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account_bank", false);
			
		                        voucherInfo.BankInfo.AccountInfo.AccountSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account", 
                                    String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.AccountCode = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code",
                                    String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.AccountName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name",
                                    String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.IsDebitSideIncrease = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "is_debit_side_increase", false);
		                        voucherInfo.BankInfo.AccountInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "is_active_account_account", false);

			                    voucherInfo.BankInfo.AccountInfo.AccountingCategoryInfo.AccountingCategoryId = RemoteServerLib.ProcStatic.DataReaderConvert(
                                    sqlReader, "accounting_category_id", String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.AccountingCategoryInfo.CategoryDescription = RemoteServerLib.ProcStatic.DataReaderConvert(
                                    sqlReader, "category_description", String.Empty);

		                        voucherInfo.BankInfo.AccountInfo.SummaryAccount.AccountSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "sysid_account_summary", String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.SummaryAccount.AccountCode = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "account_code_summary", String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.SummaryAccount.AccountName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "account_name_summary", String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.SummaryAccount.IsDebitSideIncrease = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "is_debit_side_increase_summary", false);
		                        voucherInfo.BankInfo.AccountInfo.SummaryAccount.IsActiveAccount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "is_active_account_summary", false);

		                        voucherInfo.BankInfo.AccountInfo.SummaryAccount.AccountingCategoryInfo.AccountingCategoryId = 
                                    RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "accounting_category_id_summary", String.Empty);
		                        voucherInfo.BankInfo.AccountInfo.SummaryAccount.AccountingCategoryInfo.CategoryDescription =
                                    RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "category_description_summary", String.Empty);
			
	                            voucherInfo.RegularLoanInfo.RegularLoanSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_regular", 
                                    String.Empty);
		                        voucherInfo.RegularLoanInfo.AccountNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_no_loan", String.Empty);
		                        voucherInfo.RegularLoanInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "sysid_member_loan", String.Empty);
		                        voucherInfo.RegularLoanInfo.MemberInfo.MemberId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "member_id_loan", String.Empty);
		                        voucherInfo.RegularLoanInfo.MemberInfo.PersonInfo.PersonSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "sysid_person_loan", String.Empty);
		                        voucherInfo.RegularLoanInfo.MemberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "last_name_loan", String.Empty);
		                        voucherInfo.RegularLoanInfo.MemberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "first_name_loan", String.Empty);
		                        voucherInfo.RegularLoanInfo.MemberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "middle_name_loan", String.Empty);

		                        voucherInfo.InHouseDebitInfo.InHouseDebitSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "sysid_inhousedebit", String.Empty);
		                        voucherInfo.InHouseDebitInfo.HospitalName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "hospital_name_inhouse", String.Empty);
		                        voucherInfo.InHouseDebitInfo.DateFrom = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "date_from_inhouse", DateTime.MinValue).ToString();
		                        voucherInfo.InHouseDebitInfo.DateTo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "date_to_inhouse", DateTime.MinValue).ToString();
		                        voucherInfo.InHouseDebitInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "sysid_member_inhouse", String.Empty);
		                        voucherInfo.InHouseDebitInfo.MemberInfo.MemberId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "member_id_inhouse", String.Empty);
		                        voucherInfo.InHouseDebitInfo.MemberInfo.PersonInfo.PersonSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "sysid_person_inhouse", String.Empty);
		                        voucherInfo.InHouseDebitInfo.MemberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "last_name_inhouse", String.Empty);
		                        voucherInfo.InHouseDebitInfo.MemberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "first_name_inhouse", String.Empty);
                                voucherInfo.InHouseDebitInfo.MemberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "middle_name_inhouse", String.Empty);

                                break;
                            }
                        }

                        sqlReader.Close();
                    }
                }

                //gets the disbursement voucher entry
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDVoucherListDisbursementVoucherEntry";

                    if (String.IsNullOrEmpty(voucherInfo.VoucherSysId))
                    {
                        sqlComm.Parameters.Add("@sysid_voucher_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_voucher_list", SqlDbType.NVarChar).Value = voucherInfo.VoucherSysId;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                CommonExchange.VoucherEntry vEntry = new CommonExchange.VoucherEntry();

                                vEntry.VoucherEntryId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "voucher_entry_id", Int64.Parse("0"));
		                        vEntry.DebitAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "debit_amount", Decimal.Parse("0.00"));
		                        vEntry.CreditAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "credit_amount", Decimal.Parse("0.00"));
		                        vEntry.SequenceNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sequence_no", Int16.Parse("0"));

		                        vEntry.AccountInfo.AccountSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account", String.Empty);
		                        vEntry.AccountInfo.AccountCode = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
		                        vEntry.AccountInfo.AccountName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
		                        vEntry.AccountInfo.IsDebitSideIncrease = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "is_debit_side_increase", false);
		                        vEntry.AccountInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "is_active_account_account", false);

		                        vEntry.AccountInfo.AccountingCategoryInfo.AccountingCategoryId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "accounting_category_id", String.Empty);
		                        vEntry.AccountInfo.AccountingCategoryInfo.CategoryDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "category_description", String.Empty);

		                        vEntry.AccountInfo.SummaryAccount.AccountSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "sysid_account_summary", String.Empty);
		                        vEntry.AccountInfo.SummaryAccount.AccountCode = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "account_code_summary", String.Empty);
		                        vEntry.AccountInfo.SummaryAccount.AccountName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "account_name_summary", String.Empty);
		                        vEntry.AccountInfo.SummaryAccount.IsDebitSideIncrease = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "is_debit_side_increase_summary", false);
		                        vEntry.AccountInfo.SummaryAccount.IsActiveAccount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "is_active_account_summary", false);

		                        vEntry.AccountInfo.SummaryAccount.AccountingCategoryInfo.AccountingCategoryId = 
                                    RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "accounting_category_id_summary", String.Empty);
		                        vEntry.AccountInfo.SummaryAccount.AccountingCategoryInfo.CategoryDescription = 
                                    RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "category_description_summary", String.Empty);

			                    vEntry.CostCenterInfo.DepartmentId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "cost_center_id", String.Empty);
		                        vEntry.CostCenterInfo.DepartmentName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "department_name", String.Empty);
                                vEntry.CostCenterInfo.Acronym = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "acronym", String.Empty);

                                voucherInfo.VoucherEntryList.Add(vEntry);

                            }
                        }

                        sqlReader.Close();
                    }
                }

            }

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
            DataTable dbTable = new DataTable("DisbursementPayeeByQueryStringTable");
            dbTable.Columns.Add("transaction_system_id", System.Type.GetType("System.String"));
			dbTable.Columns.Add("transaction_account", System.Type.GetType("System.String"));
			dbTable.Columns.Add("transaction_amount", System.Type.GetType("System.Decimal"));
			dbTable.Columns.Add("transaction_date", System.Type.GetType("System.String"));

			dbTable.Columns.Add("transaction_description_name", System.Type.GetType("System.String"));

			dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
			dbTable.Columns.Add("sysid_person", System.Type.GetType("System.String"));
			dbTable.Columns.Add("last_name", System.Type.GetType("System.String"));
			dbTable.Columns.Add("first_name", System.Type.GetType("System.String"));
			dbTable.Columns.Add("middle_name", System.Type.GetType("System.String"));

			dbTable.Columns.Add("is_regular_loan", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_inhouse_hospitalization_debit", System.Type.GetType("System.Boolean"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["transaction_system_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "transaction_system_id", String.Empty);
                                newRow["transaction_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "transaction_account", String.Empty);
                                newRow["transaction_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "transaction_amount", Decimal.Parse("0"));
                                newRow["transaction_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "transaction_date", 
                                    DateTime.MinValue).ToString();

                                newRow["transaction_description_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "transaction_description_name",
                                    String.Empty);

                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["sysid_person"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);
                                newRow["last_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "last_name", String.Empty);
                                newRow["first_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "first_name", String.Empty);
                                newRow["middle_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "middle_name", String.Empty);

                                newRow["is_regular_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_regular_loan", false);
                                newRow["is_inhouse_hospitalization_debit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "is_inhouse_hospitalization_debit", false);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();
                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsValidCategoryBySummaryAccountChartOfAccount";

                    sqlComm.Parameters.Add("@accounting_category_id", SqlDbType.VarChar).Value = accountingCategoryId;
                    sqlComm.Parameters.Add("@summary_account", SqlDbType.VarChar).Value = summaryAccount;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsAccountCodeChartOfAccount";

                    sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = accountSysId;
                    sqlComm.Parameters.Add("@account_code", SqlDbType.VarChar).Value = accountCode;
                    sqlComm.Parameters.Add("@summary_account", SqlDbType.VarChar).Value = summaryAccount;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsBankNameAccountNumberBankInformation";

                    sqlComm.Parameters.Add("@sysid_bank", SqlDbType.VarChar).Value = bankSysId;
                    sqlComm.Parameters.Add("@bank_name", SqlDbType.VarChar).Value = bankName;
                    sqlComm.Parameters.Add("@account_no", SqlDbType.VarChar).Value = accountNumber;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsBankCheckNoDisbursementVoucherInformation";

                    sqlComm.Parameters.Add("@sysid_voucher", SqlDbType.VarChar).Value = voucherSysId;
                    sqlComm.Parameters.Add("@sysid_bank", SqlDbType.VarChar).Value = bankSysId;
                    sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = checkNo;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                //get the accounting category table
                dbSet.Tables.Add(ProcStatic.GetAccountingCategoryTable(auth.Connection, userInfo.UserId));
                //--------------------------------

                //get the department information table
                dbSet.Tables.Add(ProcStatic.GetDepartmentInformationTable(auth.Connection, userInfo.UserId));
                //----------------------------------
            }

            return dbSet;
        } //----------------------------------

        #endregion

    }
}
