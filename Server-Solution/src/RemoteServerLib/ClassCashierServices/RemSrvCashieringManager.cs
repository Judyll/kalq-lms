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
        public void InsertBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.InsertBreakdownBankDeposit";

                    sqlComm.Parameters.Add("@date_start", SqlDbType.DateTime).Value = DateTime.Parse(breakdownDeposit.DateStart);
                    sqlComm.Parameters.Add("@date_end", SqlDbType.DateTime).Value = DateTime.Parse(breakdownDeposit.DateEnd);
                    sqlComm.Parameters.Add("@amount", SqlDbType.Decimal).Value = breakdownDeposit.Amount;
                    sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = breakdownDeposit.AccountInfo.AccountSysId;

                    sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    sqlComm.ExecuteNonQuery();
                }
            }
        } //-----------------------------------    

        /// <summary>
        /// This procedure updates a breakdown bank deposit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="breakdownDeposit"></param>
        public void UpdateBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.UpdateBreakdownBankDeposit";

                    sqlComm.Parameters.Add("@breakdown_id", SqlDbType.BigInt).Value = breakdownDeposit.BreakdownId;
                    sqlComm.Parameters.Add("@date_start", SqlDbType.DateTime).Value = DateTime.Parse(breakdownDeposit.DateStart);
                    sqlComm.Parameters.Add("@date_end", SqlDbType.DateTime).Value = DateTime.Parse(breakdownDeposit.DateEnd);
                    sqlComm.Parameters.Add("@amount", SqlDbType.Decimal).Value = breakdownDeposit.Amount;
                    sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = breakdownDeposit.AccountInfo.AccountSysId;

                    sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    sqlComm.ExecuteNonQuery();
                }
            }
        } //-----------------------------------  

        /// <summary>
        /// This procedure deletes a breakdown bank deposit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="breakdownDeposit"></param>
        public void DeleteBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.DeleteBreakdownBankDeposit";

                    sqlComm.Parameters.Add("@breakdown_id", SqlDbType.BigInt).Value = breakdownDeposit.BreakdownId;

                    sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    sqlComm.ExecuteNonQuery();
                }
            }
        } //-----------------------------------  

        /// <summary>
        /// This procedure inserts a new miscellaneous income
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="miscIncomeInfo"></param>
        public void InsertMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscIncomeInfo)
        {
            if (miscIncomeInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertMiscellaneousIncome";

                        sqlComm.Parameters.Add("@received_from", SqlDbType.VarChar).Value = miscIncomeInfo.ReceivedFrom;

                        if (String.IsNullOrEmpty(miscIncomeInfo.MemberInfo.MemberSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = miscIncomeInfo.MemberInfo.MemberSysId;
                        }

                        if (String.IsNullOrEmpty(miscIncomeInfo.CollectorInfo.CollectorSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_collector", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_collector", SqlDbType.VarChar).Value = miscIncomeInfo.CollectorInfo.CollectorSysId;
                        }

                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(miscIncomeInfo.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(miscIncomeInfo.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = miscIncomeInfo.ReceiptNo;

                        sqlComm.Parameters.Add("@miscellaneous_amount", SqlDbType.Decimal).Value = miscIncomeInfo.MiscellaneousAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = miscIncomeInfo.Remarks;

                        sqlComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).Value = miscIncomeInfo.DiscountAmount;
                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = miscIncomeInfo.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = miscIncomeInfo.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = miscIncomeInfo.CheckNo;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = miscIncomeInfo.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure updates a miscellaneous income
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="miscIncomeInfo"></param>
        public void UpdateMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscIncomeInfo)
        {
            if (miscIncomeInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateMiscellaneousIncome";

                        sqlComm.Parameters.Add("@payment_id", SqlDbType.BigInt).Value = miscIncomeInfo.PaymentId;
                        sqlComm.Parameters.Add("@received_from", SqlDbType.VarChar).Value = miscIncomeInfo.ReceivedFrom;

                        if (String.IsNullOrEmpty(miscIncomeInfo.MemberInfo.MemberSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = miscIncomeInfo.MemberInfo.MemberSysId;
                        }

                        if (String.IsNullOrEmpty(miscIncomeInfo.CollectorInfo.CollectorSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_collector", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_collector", SqlDbType.VarChar).Value = miscIncomeInfo.CollectorInfo.CollectorSysId;
                        }

                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(miscIncomeInfo.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(miscIncomeInfo.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = miscIncomeInfo.ReceiptNo;

                        sqlComm.Parameters.Add("@miscellaneous_amount", SqlDbType.Decimal).Value = miscIncomeInfo.MiscellaneousAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = miscIncomeInfo.Remarks;

                        sqlComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).Value = miscIncomeInfo.DiscountAmount;
                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = miscIncomeInfo.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = miscIncomeInfo.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = miscIncomeInfo.CheckNo;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = miscIncomeInfo.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure deletes a miscellaneous income
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="miscIncomeInfo"></param>
        public void DeleteMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscIncomeInfo)
        {
            if (miscIncomeInfo.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteMiscellaneousIncome";

                        sqlComm.Parameters.Add("@payment_id", SqlDbType.BigInt).Value = miscIncomeInfo.PaymentId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure inserts a new in-house hospitalization credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCredit"></param>
        public void InsertInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit hospitalizationCredit)
        {
            if (hospitalizationCredit.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertInHouseHospitalizationCredit";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = hospitalizationCredit.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(hospitalizationCredit.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(hospitalizationCredit.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = hospitalizationCredit.ReceiptNo;

                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = hospitalizationCredit.CreditAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = hospitalizationCredit.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = hospitalizationCredit.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = hospitalizationCredit.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = hospitalizationCredit.CheckNo;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = hospitalizationCredit.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure updates an in-house hospitalization credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCredit"></param>
        public void UpdateInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit hospitalizationCredit)
        {
            if (hospitalizationCredit.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateInHouseHospitalizationCredit";

                        sqlComm.Parameters.Add("@hospitalization_credit_id", SqlDbType.BigInt).Value = hospitalizationCredit.HospitalizationCreditId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(hospitalizationCredit.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(hospitalizationCredit.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = hospitalizationCredit.ReceiptNo;

                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = hospitalizationCredit.CreditAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = hospitalizationCredit.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = hospitalizationCredit.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = hospitalizationCredit.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = hospitalizationCredit.CheckNo;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = hospitalizationCredit.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure deletes an in-house hospitalization credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCredit"></param>
        public void DeleteInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit hospitalizationCredit)
        {
            if (hospitalizationCredit.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteInHouseHospitalizationCredit";

                        sqlComm.Parameters.Add("@hospitalization_credit_id", SqlDbType.BigInt).Value = hospitalizationCredit.HospitalizationCreditId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure insert, update and delete an in-house hospitalization credit by hospitalization credit datatable
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationCreditTable"></param>
        public void InsertUpdateDeleteInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, DataTable hospitalizationCreditTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertInHouseHospitalizationCredit";

                    insertComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).SourceColumn = "sysid_member";
                    insertComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).SourceColumn = "reflected_date";
                    insertComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).SourceColumn = "receipt_date";
                    insertComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).SourceColumn = "receipt_no";

                    insertComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).SourceColumn = "credit_amount";

                    insertComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                    insertComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).SourceColumn = "discount_amount";
                    insertComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).SourceColumn = "amount_tendered";

                    insertComm.Parameters.Add("@bank", SqlDbType.VarChar).SourceColumn = "bank";
                    insertComm.Parameters.Add("@check_no", SqlDbType.VarChar).SourceColumn = "check_no";

                    insertComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).SourceColumn = "sysid_account_credit";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand updateComm = new SqlCommand())
                    {
                        updateComm.Connection = auth.Connection;
                        updateComm.CommandType = CommandType.StoredProcedure;
                        updateComm.CommandText = "lms.UpdateInHouseHospitalizationCredit";

                        updateComm.Parameters.Add("@hospitalization_credit_id", SqlDbType.BigInt).SourceColumn = "hospitalization_credit_id";
                        updateComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).SourceColumn = "reflected_date";
                        updateComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).SourceColumn = "receipt_date";
                        updateComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).SourceColumn = "receipt_no";

                        updateComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).SourceColumn = "credit_amount";

                        updateComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                        updateComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).SourceColumn = "discount_amount";
                        updateComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).SourceColumn = "amount_tendered";

                        updateComm.Parameters.Add("@bank", SqlDbType.VarChar).SourceColumn = "bank";
                        updateComm.Parameters.Add("@check_no", SqlDbType.VarChar).SourceColumn = "check_no";

                        updateComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).SourceColumn = "sysid_account_credit";

                        updateComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        updateComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        using (SqlCommand deleteComm = new SqlCommand())
                        {
                            deleteComm.Connection = auth.Connection;
                            deleteComm.CommandType = CommandType.StoredProcedure;
                            deleteComm.CommandText = "lms.DeleteInHouseHospitalizationCredit";

                            deleteComm.Parameters.Add("@hospitalization_credit_id", SqlDbType.BigInt).SourceColumn = "hospitalization_credit_id";

                            deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                            {
                                sqlAdapter.InsertCommand = insertComm;
                                sqlAdapter.UpdateCommand = updateComm;
                                sqlAdapter.DeleteCommand = deleteComm;

                                sqlAdapter.Update(hospitalizationCreditTable);
                            }
                        }
                    }
                }
            }
        } //----------------------------------

        /// <summary>
        /// This procedure inserts a new share capital credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void InsertShareCapitalCredit(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit capitalCredit)
        {
            if (capitalCredit.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertShareCapitalCredit";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = capitalCredit.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(capitalCredit.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(capitalCredit.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = capitalCredit.ReceiptNo;

                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = capitalCredit.CreditAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = capitalCredit.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = capitalCredit.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = capitalCredit.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = capitalCredit.CheckNo;

                        sqlComm.Parameters.Add("@is_migrated_entry", SqlDbType.Bit).Value = capitalCredit.IsMigratedEntry;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = capitalCredit.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure updates a share capital credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void UpdateShareCapitalCredit(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit capitalCredit)
        {
            if (capitalCredit.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateShareCapitalCredit";

                        sqlComm.Parameters.Add("@capital_credit_id", SqlDbType.BigInt).Value = capitalCredit.CapitalCreditId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(capitalCredit.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(capitalCredit.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = capitalCredit.ReceiptNo;

                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = capitalCredit.CreditAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = capitalCredit.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = capitalCredit.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = capitalCredit.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = capitalCredit.CheckNo;

                        sqlComm.Parameters.Add("@is_migrated_entry", SqlDbType.Bit).Value = capitalCredit.IsMigratedEntry;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = capitalCredit.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure deletes a share capital credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void DeleteShareCapitalCredit(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit capitalCredit)
        {
            if (capitalCredit.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteShareCapitalCredit";

                        sqlComm.Parameters.Add("@capital_credit_id", SqlDbType.BigInt).Value = capitalCredit.CapitalCreditId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure inserts, update, and delete a share capital credit by capital credit datatable
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCreditTable"></param>
        public void InsertUpdateDeleteShareCapitalCredit(CommonExchange.SysAccess userInfo, DataTable capitalCreditTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertShareCapitalCredit";

                    insertComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).SourceColumn = "sysid_member";
                    insertComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).SourceColumn = "reflected_date";
                    insertComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).SourceColumn = "receipt_date";
                    insertComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).SourceColumn = "receipt_no";

                    insertComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).SourceColumn = "credit_amount";

                    insertComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                    insertComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).SourceColumn = "discount_amount";
                    insertComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).SourceColumn = "amount_tendered";

                    insertComm.Parameters.Add("@bank", SqlDbType.VarChar).SourceColumn = "bank";
                    insertComm.Parameters.Add("@check_no", SqlDbType.VarChar).SourceColumn = "check_no";

                    insertComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).SourceColumn = "sysid_account_credit";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand updateComm = new SqlCommand())
                    {
                        updateComm.Connection = auth.Connection;
                        updateComm.CommandType = CommandType.StoredProcedure;
                        updateComm.CommandText = "lms.UpdateShareCapitalCredit";

                        updateComm.Parameters.Add("@capital_credit_id", SqlDbType.BigInt).SourceColumn = "capital_credit_id";
                        updateComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).SourceColumn = "reflected_date";
                        updateComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).SourceColumn = "receipt_date";
                        updateComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).SourceColumn = "receipt_no";

                        updateComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).SourceColumn = "credit_amount";

                        updateComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                        updateComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).SourceColumn = "discount_amount";
                        updateComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).SourceColumn = "amount_tendered";

                        updateComm.Parameters.Add("@bank", SqlDbType.VarChar).SourceColumn = "bank";
                        updateComm.Parameters.Add("@check_no", SqlDbType.VarChar).SourceColumn = "check_no";

                        updateComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).SourceColumn = "sysid_account_credit";

                        updateComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        updateComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        using (SqlCommand deleteComm = new SqlCommand())
                        {
                            deleteComm.Connection = auth.Connection;
                            deleteComm.CommandType = CommandType.StoredProcedure;
                            deleteComm.CommandText = "lms.DeleteShareCapitalCredit";

                            deleteComm.Parameters.Add("@capital_credit_id", SqlDbType.BigInt).SourceColumn = "capital_credit_id";

                            deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                            {
                                sqlAdapter.InsertCommand = insertComm;
                                sqlAdapter.UpdateCommand = updateComm;
                                sqlAdapter.DeleteCommand = deleteComm;

                                sqlAdapter.Update(capitalCreditTable);
                            }
                        }
                    }
                }
            }
        } //----------------------------------

        /// <summary>
        /// This procedure inserts a new member equity credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void InsertMemberEquityCredit(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit equityCredit)
        {
            if (equityCredit.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertMemberEquityCredit";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = equityCredit.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(equityCredit.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(equityCredit.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = equityCredit.ReceiptNo;

                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = equityCredit.CreditAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = equityCredit.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = equityCredit.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = equityCredit.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = equityCredit.CheckNo;

                        sqlComm.Parameters.Add("@is_migrated_entry", SqlDbType.Bit).Value = equityCredit.IsMigratedEntry;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = equityCredit.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure updates a member equity credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void UpdateMemberEquityCredit(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit equityCredit)
        {
            if (equityCredit.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateMemberEquityCredit";

                        sqlComm.Parameters.Add("@equity_id", SqlDbType.BigInt).Value = equityCredit.EquityId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(equityCredit.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(equityCredit.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = equityCredit.ReceiptNo;

                        sqlComm.Parameters.Add("@credit_amount", SqlDbType.Decimal).Value = equityCredit.CreditAmount;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = equityCredit.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = equityCredit.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = equityCredit.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = equityCredit.CheckNo;

                        sqlComm.Parameters.Add("@is_migrated_entry", SqlDbType.Bit).Value = equityCredit.IsMigratedEntry;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = equityCredit.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure deletes a member equity credit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="capitalCredit"></param>
        public void DeleteMemberEquityCredit(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit equityCredit)
        {
            if (equityCredit.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteMemberEquityCredit";

                        sqlComm.Parameters.Add("@equity_id", SqlDbType.BigInt).Value = equityCredit.EquityId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------        

        /// <summary>
        /// This procedure inserts a new regular loan payment
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPayments"></param>
        public void InsertRegularLoanPayments(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments loanPayments)
        {
            if (loanPayments.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertRegularLoanPayments";

                        sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = loanPayments.RegularLoanInfo.RegularLoanSysId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(loanPayments.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(loanPayments.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = loanPayments.ReceiptNo;

                        sqlComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).Value = loanPayments.PaymentAmount;
                        sqlComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).Value = loanPayments.PrincipalPaid;
                        sqlComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).Value = loanPayments.InterestPaid;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = loanPayments.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = loanPayments.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = loanPayments.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = loanPayments.CheckNo;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = loanPayments.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@rebate_amount", SqlDbType.Decimal).Value = loanPayments.RebateAmount;

                        if (String.IsNullOrEmpty(loanPayments.AccountRebateInfo.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_account_rebate", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_account_rebate", SqlDbType.VarChar).Value = loanPayments.AccountRebateInfo.AccountSysId;
                        }

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure updates a regular loan payment
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPayments"></param>
        public void UpdateRegularLoanPayments(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments loanPayments)
        {
            if (loanPayments.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateRegularLoanPayments";

                        sqlComm.Parameters.Add("@payment_id", SqlDbType.BigInt).Value = loanPayments.PaymentId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(loanPayments.ReflectedDate);
                        sqlComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).Value = DateTime.Parse(loanPayments.ReceiptDate);
                        sqlComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).Value = loanPayments.ReceiptNo;

                        sqlComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).Value = loanPayments.PaymentAmount;
                        sqlComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).Value = loanPayments.PrincipalPaid;
                        sqlComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).Value = loanPayments.InterestPaid;

                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = loanPayments.Remarks;

                        sqlComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).Value = loanPayments.AmountTendered;

                        sqlComm.Parameters.Add("@bank", SqlDbType.VarChar).Value = loanPayments.Bank;
                        sqlComm.Parameters.Add("@check_no", SqlDbType.VarChar).Value = loanPayments.CheckNo;

                        sqlComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).Value = loanPayments.AccountCreditInfo.AccountSysId;

                        sqlComm.Parameters.Add("@rebate_amount", SqlDbType.Decimal).Value = loanPayments.RebateAmount;

                        if (String.IsNullOrEmpty(loanPayments.AccountRebateInfo.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_account_rebate", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_account_rebate", SqlDbType.VarChar).Value = loanPayments.AccountRebateInfo.AccountSysId;
                        }

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure deletes a regular loan payment
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPayments"></param>
        public void DeleteRegularLoanPayments(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments loanPayments)
        {
            if (loanPayments.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteRegularLoanPayments";

                        sqlComm.Parameters.Add("@payment_id", SqlDbType.BigInt).Value = loanPayments.PaymentId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure insert, update, and delete a regular loan payments passing a regular loan payments datatable
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="loanPaymentsTable"></param>
        public void InsertUpdateDeleteRegularLoanPayments(CommonExchange.SysAccess userInfo, DataTable loanPaymentsTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertRegularLoanPayments";

                    insertComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).SourceColumn = "sysid_regular";
                    insertComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).SourceColumn = "reflected_date";
                    insertComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).SourceColumn = "receipt_date";
                    insertComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).SourceColumn = "receipt_no";

                    insertComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).SourceColumn = "payment_amount";
                    insertComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).SourceColumn = "principal_paid";
                    insertComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).SourceColumn = "interest_paid";

                    insertComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                    insertComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).SourceColumn = "discount_amount";
                    insertComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).SourceColumn = "amount_tendered";

                    insertComm.Parameters.Add("@bank", SqlDbType.VarChar).SourceColumn = "bank";
                    insertComm.Parameters.Add("@check_no", SqlDbType.VarChar).SourceColumn = "check_no";

                    insertComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).SourceColumn = "sysid_account_credit";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand updateComm = new SqlCommand())
                    {
                        updateComm.Connection = auth.Connection;
                        updateComm.CommandType = CommandType.StoredProcedure;
                        updateComm.CommandText = "lms.UpdateRegularLoanPayments";

                        updateComm.Parameters.Add("@payment_id", SqlDbType.BigInt).SourceColumn = "payment_id";
                        updateComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).SourceColumn = "reflected_date";
                        updateComm.Parameters.Add("@receipt_date", SqlDbType.DateTime).SourceColumn = "receipt_date";
                        updateComm.Parameters.Add("@receipt_no", SqlDbType.VarChar).SourceColumn = "receipt_no";

                        updateComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).SourceColumn = "payment_amount";
                        updateComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).SourceColumn = "principal_paid";
                        updateComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).SourceColumn = "interest_paid";

                        updateComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                        updateComm.Parameters.Add("@discount_amount", SqlDbType.Decimal).SourceColumn = "discount_amount";
                        updateComm.Parameters.Add("@amount_tendered", SqlDbType.Decimal).SourceColumn = "amount_tendered";

                        updateComm.Parameters.Add("@bank", SqlDbType.VarChar).SourceColumn = "bank";
                        updateComm.Parameters.Add("@check_no", SqlDbType.VarChar).SourceColumn = "check_no";

                        updateComm.Parameters.Add("@sysid_account_credit", SqlDbType.VarChar).SourceColumn = "sysid_account_credit";

                        updateComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        updateComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        using (SqlCommand deleteComm = new SqlCommand())
                        {
                            deleteComm.Connection = auth.Connection;
                            deleteComm.CommandType = CommandType.StoredProcedure;
                            deleteComm.CommandText = "lms.DeleteRegularLoanPayments";

                            deleteComm.Parameters.Add("@payment_id", SqlDbType.BigInt).SourceColumn = "payment_id";

                            deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                            {
                                sqlAdapter.InsertCommand = insertComm;
                                sqlAdapter.UpdateCommand = updateComm;
                                sqlAdapter.DeleteCommand = deleteComm;

                                sqlAdapter.Update(loanPaymentsTable);
                            }
                        }
                    }
                }
            }
        } //----------------------------------

        /// <summary>
        /// this procedure insert or update the share capital information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="shareCapitalInfo"></param>
        public void InsertUpdateShareCapitalInformation(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalInformation shareCapitalInfo)
        {
            if (shareCapitalInfo.ObjectState == DataRowState.Added || shareCapitalInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertUpdateShareCapitalInformation";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = shareCapitalInfo.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@premium_amount_due", SqlDbType.Decimal).Value = shareCapitalInfo.PremiumAmountDue;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = shareCapitalInfo.Remarks;
                        sqlComm.Parameters.Add("@is_precluded_withdrawal", SqlDbType.Bit).Value = shareCapitalInfo.IsPrecludedWithdrawal;
                        sqlComm.Parameters.Add("@is_precluded_retirement", SqlDbType.Bit).Value = shareCapitalInfo.IsPrecludedRetirement;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure inserts or updates an in house hospitalization information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseHospitalizationInfo"></param>
        public void InsertUpdateInHouseHospitalizationInformation(CommonExchange.SysAccess userInfo, 
            CommonExchange.InHouseHospitalizationInformation inHouseHospitalizationInfo)
        {
            if (inHouseHospitalizationInfo.ObjectState == DataRowState.Added || inHouseHospitalizationInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertUpdateInHouseHospitalizationInformation";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = inHouseHospitalizationInfo.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@certificate_no", SqlDbType.VarChar).Value = inHouseHospitalizationInfo.CertificateNo;
                        sqlComm.Parameters.Add("@premium_amount_due", SqlDbType.Decimal).Value = inHouseHospitalizationInfo.PremiumAmountDue;
                        sqlComm.Parameters.Add("@maximum_amount", SqlDbType.Decimal).Value = inHouseHospitalizationInfo.MaximumAmount;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = inHouseHospitalizationInfo.Remarks;
                        sqlComm.Parameters.Add("@is_precluded", SqlDbType.Bit).Value = inHouseHospitalizationInfo.IsPrecluded;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------


        /// <summary>
        /// This procedure inserts a new hospitalization include coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="includeCoverage"></param>
        public void InsertHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, 
            ref CommonExchange.HospitalizationIncludeCoverage includeCoverage)
        {
            if (includeCoverage.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertHospitalizationIncludeCoverage";

                        sqlComm.Parameters.Add("@sysid_includecoverage", SqlDbType.VarChar).Value = includeCoverage.IncludeCoverageSysId =
                            PrimaryKeys.GetNewHospitalizationIncludeCoverageSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@include_coverage_description", SqlDbType.VarChar).Value = includeCoverage.IncludeCoverageDescription;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure updates a hospitalization include coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="includeCoverage"></param>
        public void UpdateHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationIncludeCoverage includeCoverage)
        {
            if (includeCoverage.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateHospitalizationIncludeCoverage";

                        sqlComm.Parameters.Add("@sysid_includecoverage", SqlDbType.VarChar).Value = includeCoverage.IncludeCoverageSysId;
                        sqlComm.Parameters.Add("@include_coverage_description", SqlDbType.VarChar).Value = includeCoverage.IncludeCoverageDescription;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// This procedure delete a hospitalization include coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="includeCoverage"></param>
        public void DeleteHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationIncludeCoverage includeCoverage)
        {
            if (includeCoverage.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteHospitalizationIncludeCoverage";

                        sqlComm.Parameters.Add("@sysid_includecoverage", SqlDbType.VarChar).Value = includeCoverage.IncludeCoverageSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// This procedure inserts a new hospitalization exclude coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="excludeCoverage"></param>
        public void InsertHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo,
            ref CommonExchange.HospitalizationExcludeCoverage excludeCoverage)
        {
            if (excludeCoverage.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertHospitalizationExcludeCoverage";

                        sqlComm.Parameters.Add("@sysid_excludecoverage", SqlDbType.VarChar).Value = excludeCoverage.ExcludeCoverageSysId =
                            PrimaryKeys.GetNewHospitalizationExcludeCoverageSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@exclude_coverage_description", SqlDbType.VarChar).Value = excludeCoverage.ExcludeCoverageDescription;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure updates the hospitalization exclude coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="excludeCoverage"></param>
        public void UpdateHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationExcludeCoverage excludeCoverage)
        {
            if (excludeCoverage.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateHospitalizationExcludeCoverage";

                        sqlComm.Parameters.Add("@sysid_excludecoverage", SqlDbType.VarChar).Value = excludeCoverage.ExcludeCoverageSysId;
                        sqlComm.Parameters.Add("@exclude_coverage_description", SqlDbType.VarChar).Value = excludeCoverage.ExcludeCoverageDescription;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// This procedure deletes a hospitalization exclude coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="excludeCoverage"></param>
        public void DeleteHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationExcludeCoverage excludeCoverage)
        {
            if (excludeCoverage.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteHospitalizationExcludeCoverage";

                        sqlComm.Parameters.Add("@sysid_excludecoverage", SqlDbType.VarChar).Value = excludeCoverage.ExcludeCoverageSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// This procedure inserts a new in-house hospitalization debit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitInfo"></param>
        public void InsertInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, 
            ref CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo)
        {
            if (inHouseDebitInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertInHouseHospitalizationDebit";

                        sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitInfo.InHouseDebitSysId =
                            PrimaryKeys.GetNewInHouseHospitalizationDebitSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = inHouseDebitInfo.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(inHouseDebitInfo.ReflectedDate);
                        sqlComm.Parameters.Add("@net_assistance_amount", SqlDbType.Decimal).Value = inHouseDebitInfo.NetAssistanceAmount;
                        sqlComm.Parameters.Add("@hospital_name", SqlDbType.VarChar).Value = inHouseDebitInfo.HospitalName;
                        sqlComm.Parameters.Add("@cause_of_admission", SqlDbType.VarChar).Value = inHouseDebitInfo.CauseOfAdmission;
                        sqlComm.Parameters.Add("@date_from", SqlDbType.DateTime).Value = DateTime.Parse(inHouseDebitInfo.DateFrom);
	                    sqlComm.Parameters.Add("@date_to", SqlDbType.DateTime).Value = DateTime.Parse(inHouseDebitInfo.DateTo);
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = inHouseDebitInfo.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update, or delete a in-house include coverage
                    this.InsertUpdateDeleteInHouseIncludeCoverage(userInfo, auth.Connection, inHouseDebitInfo.InHouseDebitSysId,
                        inHouseDebitInfo.IncludeCoverageList);
                    //------------------------------------------

                    //insert, update, or delete a in-house exclude coverage
                    this.InsertUpdateDeleteInHouseExcludeCoverage(userInfo, auth.Connection, inHouseDebitInfo.InHouseDebitSysId,
                        inHouseDebitInfo.ExcludeCoverageList);
                    //---------------------------------------
                }
            }

        } //-------------------------------------------

        /// <summary>
        /// This procedure update an in-house hospitalization debit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitInfo"></param>
        public void UpdateInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo)
        {
            if (inHouseDebitInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateInHouseHospitalizationDebit";

                        sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitInfo.InHouseDebitSysId;
                        sqlComm.Parameters.Add("@reflected_date", SqlDbType.DateTime).Value = DateTime.Parse(inHouseDebitInfo.ReflectedDate);
                        sqlComm.Parameters.Add("@net_assistance_amount", SqlDbType.Decimal).Value = inHouseDebitInfo.NetAssistanceAmount;
                        sqlComm.Parameters.Add("@hospital_name", SqlDbType.VarChar).Value = inHouseDebitInfo.HospitalName;
                        sqlComm.Parameters.Add("@cause_of_admission", SqlDbType.VarChar).Value = inHouseDebitInfo.CauseOfAdmission;
                        sqlComm.Parameters.Add("@date_from", SqlDbType.DateTime).Value = DateTime.Parse(inHouseDebitInfo.DateFrom);
                        sqlComm.Parameters.Add("@date_to", SqlDbType.DateTime).Value = DateTime.Parse(inHouseDebitInfo.DateTo);
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = inHouseDebitInfo.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update, or delete a in-house include coverage
                    this.InsertUpdateDeleteInHouseIncludeCoverage(userInfo, auth.Connection, inHouseDebitInfo.InHouseDebitSysId,
                        inHouseDebitInfo.IncludeCoverageList);
                    //------------------------------------------

                    //insert, update, or delete a in-house exclude coverage
                    this.InsertUpdateDeleteInHouseExcludeCoverage(userInfo, auth.Connection, inHouseDebitInfo.InHouseDebitSysId,
                        inHouseDebitInfo.ExcludeCoverageList);
                    //---------------------------------------
                }
            }

        } //--------------------------------

        /// <summary>
        /// This procedure deletes an in-house hospitalization debit
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="inHouseDebitInfo"></param>
        public void DeleteInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo)
        {
            if (inHouseDebitInfo.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteInHouseHospitalizationDebit";

                        sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitInfo.InHouseDebitSysId;
                        
                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        
        /// <summary>
        /// This procedure inserts, updates, and delete a in-house include coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="inHouseDebitSysId"></param>
        /// <param name="includeCoverageList"></param>
        private void InsertUpdateDeleteInHouseIncludeCoverage(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String inHouseDebitSysId,
            List<CommonExchange.InHouseIncludeCoverage> includeCoverageList)
        {
            foreach (CommonExchange.InHouseIncludeCoverage includeCoverage in includeCoverageList)
            {
                if (includeCoverage.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteInHouseIncludeCoverage";

                        sqlComm.Parameters.Add("@include_coverage_id", SqlDbType.BigInt).Value = includeCoverage.IncludeCoverageId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }

            }

            foreach (CommonExchange.InHouseIncludeCoverage includeCoverage in includeCoverageList)
            {
                if (includeCoverage.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertInHouseIncludeCoverage";
                            
                        sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitSysId;
                        sqlComm.Parameters.Add("@sysid_includecoverage", SqlDbType.VarChar).Value = includeCoverage.IncludeCoverageInfo.IncludeCoverageSysId;
                        sqlComm.Parameters.Add("@include_amount", SqlDbType.Decimal).Value = includeCoverage.IncludeAmount;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = includeCoverage.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (includeCoverage.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateInHouseIncludeCoverage";

                        sqlComm.Parameters.Add("@include_coverage_id", SqlDbType.BigInt).Value = includeCoverage.IncludeCoverageId;
                        sqlComm.Parameters.Add("@sysid_includecoverage", SqlDbType.VarChar).Value = includeCoverage.IncludeCoverageInfo.IncludeCoverageSysId;
                        sqlComm.Parameters.Add("@include_amount", SqlDbType.Decimal).Value = includeCoverage.IncludeAmount;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = includeCoverage.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// This procedure inserts, update, and delete an in-house exclude coverage
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="inHouseDebitSysId"></param>
        /// <param name="excludeCoverageList"></param>
        private void InsertUpdateDeleteInHouseExcludeCoverage(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String inHouseDebitSysId,
            List<CommonExchange.InHouseExcludeCoverage> excludeCoverageList)
        {
            foreach (CommonExchange.InHouseExcludeCoverage excludeCoverage in excludeCoverageList)
            {
                if (excludeCoverage.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteInHouseExcludeCoverage";

                        sqlComm.Parameters.Add("@exclude_coverage_id", SqlDbType.BigInt).Value = excludeCoverage.ExcludeCoverageId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }

            }

            foreach (CommonExchange.InHouseExcludeCoverage excludeCoverage in excludeCoverageList)
            {
                if (excludeCoverage.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertInHouseExcludeCoverage";

                        sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitSysId;
                        sqlComm.Parameters.Add("@sysid_excludecoverage", SqlDbType.VarChar).Value = excludeCoverage.ExcludeCoverageInfo.ExcludeCoverageSysId;
                        sqlComm.Parameters.Add("@exclude_amount", SqlDbType.Decimal).Value = excludeCoverage.ExcludeAmount;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = excludeCoverage.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (excludeCoverage.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateInHouseExcludeCoverage";

                        sqlComm.Parameters.Add("@exclude_coverage_id", SqlDbType.BigInt).Value = excludeCoverage.ExcludeCoverageId;
                        sqlComm.Parameters.Add("@sysid_excludecoverage", SqlDbType.VarChar).Value = excludeCoverage.ExcludeCoverageInfo.ExcludeCoverageSysId;
                        sqlComm.Parameters.Add("@exclude_amount", SqlDbType.Decimal).Value = excludeCoverage.ExcludeAmount;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = excludeCoverage.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// This procedure insert, update, or delete a hospitalization document
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="hospitalizationDocumentTable"></param>
        public void InsertUpdateDeleteHospitalizationDocument(CommonExchange.SysAccess userInfo, DataTable hospitalizationDocumentTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertHospitalizationDocument";

                    insertComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).SourceColumn = "sysid_inhousedebit";
                    insertComm.Parameters.Add("@file_data", SqlDbType.VarBinary).SourceColumn = "file_data";
                    insertComm.Parameters.Add("@original_name", SqlDbType.VarChar).SourceColumn = "original_name";
                    insertComm.Parameters.Add("@document_information", SqlDbType.VarChar).SourceColumn = "document_information";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand updateComm = new SqlCommand())
                    {

                        updateComm.Connection = auth.Connection;
                        updateComm.CommandType = CommandType.StoredProcedure;
                        updateComm.CommandText = "lms.UpdateHospitalizationDocument";

                        updateComm.Parameters.Add("@document_id", SqlDbType.BigInt).SourceColumn = "document_id";
                        updateComm.Parameters.Add("@file_data", SqlDbType.VarBinary).SourceColumn = "file_data";
                        updateComm.Parameters.Add("@original_name", SqlDbType.VarChar).SourceColumn = "original_name";
                        updateComm.Parameters.Add("@document_information", SqlDbType.VarChar).SourceColumn = "document_information";

                        updateComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        updateComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        using (SqlCommand deleteComm = new SqlCommand())
                        {
                            deleteComm.Connection = auth.Connection;
                            deleteComm.CommandType = CommandType.StoredProcedure;
                            deleteComm.CommandText = "lms.DeleteHospitalizationDocument";

                            deleteComm.Parameters.Add("@document_id", SqlDbType.BigInt).SourceColumn = "document_id";

                            deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                            {
                                sqlAdapter.InsertCommand = insertComm;
                                sqlAdapter.UpdateCommand = updateComm;
                                sqlAdapter.DeleteCommand = deleteComm;

                                sqlAdapter.Update(hospitalizationDocumentTable);
                            }
                        }
                    }
                }
            }
        } //----------------------------------
        
        #endregion

        #region Programmer-Defined Function Procedures

        /// <summary>
        /// This function returns the certificate no for the in-house hospitalization
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public String SelectCountForCertificateNoInHouseHospitalizationInformation(CommonExchange.SysAccess userInfo)
        {
            Int16 count = 0;
            DateTime effDate = DateTime.MinValue;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectCountForCertificateNoInHouseHospitalizationInformation";

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    count = Convert.ToInt16(sqlComm.ExecuteScalar());
                }

                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectMemberServicesEffectivityDate";

                    effDate = Convert.ToDateTime(sqlComm.ExecuteScalar());
                }

            }

            return "HAP-" + effDate.Year.ToString() + "-" + effDate.Month.ToString("00") + "-" + (++count).ToString("000");

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
            DataTable dbTable = new DataTable("BillingStatementByMemberSysIDListDateStartEndTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices";

                    if (String.IsNullOrEmpty(memberSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = memberSysIdList;
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

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }

                    dbTable.AcceptChanges();
                }
            }

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
            DataTable dbTable = new DataTable("CashReceiptsDetailedByDateStartEndTable");
            dbTable.Columns.Add("sysid_account", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("sysid_account_summary", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code_summary", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name_summary", System.Type.GetType("System.String"));
            dbTable.Columns.Add("received_from", System.Type.GetType("System.String"));
            dbTable.Columns.Add("sysid_member_collector", System.Type.GetType("System.String"));
            dbTable.Columns.Add("received_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("is_miscellaneous_income", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("office_employer_id", System.Type.GetType("System.String"));
            dbTable.Columns.Add("office_employer_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("office_employer_acronym", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome";

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

                    sqlComm.Parameters.Add("@is_consolidated", SqlDbType.Bit).Value = isConsolidated;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["sysid_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account", String.Empty);
                                newRow["account_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                newRow["account_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
                                newRow["sysid_account_summary"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_summary",
                                    String.Empty);
                                newRow["account_code_summary"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code_summary",
                                    String.Empty);
                                newRow["account_name_summary"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name_summary",
                                    String.Empty);
                                newRow["received_from"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_from", String.Empty);
                                newRow["sysid_member_collector"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member_collector", String.Empty);
                                newRow["received_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_date",
                                    DateTime.MinValue).ToString();
                                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_no", String.Empty);
                                newRow["amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amount", Decimal.Parse("0"));
                                newRow["is_miscellaneous_income"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_miscellaneous_income", false);
                                newRow["office_employer_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "office_employer_id", String.Empty);
                                newRow["office_employer_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "office_employer_name", String.Empty);
                                newRow["office_employer_acronym"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "office_employer_acronym", String.Empty);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();
                }
            }

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
            DataTable dbTable = new DataTable("CashReceiptsSummarizedByDateStartEndTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome";

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

                    sqlComm.Parameters.Add("@is_consolidated", SqlDbType.Bit).Value = isConsolidated;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }
                }
            }

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
            DataTable dbTable = new DataTable("BreakdownBankDepositCashReceiptsDetailedByDateStartEndTable");
            dbTable.Columns.Add("sysid_account", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("sysid_account_summary", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code_summary", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name_summary", System.Type.GetType("System.String"));
            dbTable.Columns.Add("breakdown_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("date_start", System.Type.GetType("System.String"));
            dbTable.Columns.Add("date_end", System.Type.GetType("System.String"));
            dbTable.Columns.Add("amount", System.Type.GetType("System.Decimal"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit";

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

                    sqlComm.Parameters.Add("@is_consolidated", SqlDbType.Bit).Value = isConsolidated;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["sysid_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account", String.Empty);
                                newRow["account_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                newRow["account_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
                                newRow["sysid_account_summary"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_summary",
                                    String.Empty);
                                newRow["account_code_summary"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code_summary",
                                    String.Empty);
                                newRow["account_name_summary"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name_summary",
                                    String.Empty);
                                newRow["breakdown_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "breakdown_id", Int64.Parse("0"));
                                newRow["date_start"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_start",
                                    DateTime.MinValue).ToString();
                                newRow["date_end"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_end",
                                    DateTime.MinValue).ToString();
                                newRow["amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amount", Decimal.Parse("0"));

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();
                }
            }

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
            DataTable dbTable = new DataTable("BreakdownBankDepositCashReceiptsSummarizedByDateStartEndTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit";

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

                    sqlComm.Parameters.Add("@is_consolidated", SqlDbType.Bit).Value = isConsolidated;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }
                }
            }

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
            DataTable dbTable = new DataTable("MiscellaneousIncomeByQueryStringDateStartEndTable");
            dbTable.Columns.Add("payment_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("received_from", System.Type.GetType("System.String"));
            dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
            dbTable.Columns.Add("sysid_collector", System.Type.GetType("System.String"));
            dbTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("received_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            dbTable.Columns.Add("miscellaneous_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("discount_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("bank", System.Type.GetType("System.String"));
            dbTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByQueryStringDateStartEndMiscellaneousIncome";

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

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["payment_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payment_id", Int64.Parse("0"));
                                newRow["received_from"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_from", String.Empty);
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["sysid_collector"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_collector", String.Empty);
                                newRow["reflected_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reflected_date",
                                    DateTime.MinValue).ToShortDateString();
                                newRow["receipt_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_date",
                                    DateTime.MinValue).ToShortDateString();
                                newRow["received_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_date",
                                    DateTime.MinValue).ToShortDateString();
                                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_no", String.Empty);
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
                                newRow["miscellaneous_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "miscellaneous_amount", 
                                    Decimal.Parse("0"));
                                newRow["discount_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "discount_amount", Decimal.Parse("0"));
                                newRow["amount_tendered"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amount_tendered", Decimal.Parse("0"));
                                newRow["bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "bank", String.Empty);
                                newRow["check_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);
                                newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_credit", String.Empty);
                                newRow["account_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                newRow["account_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);

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
        /// This function returns the in-house hospitalization credit by member system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListInHouseHospitalizationCredit(CommonExchange.SysAccess userInfo, String memberSysIdList)
        {
            DataTable dbTable = new DataTable("InHouseHospitalizationCreditByMemberSysIdListTable");
            dbTable.Columns.Add("hospitalization_credit_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
            dbTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("received_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("credit_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            dbTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("bank", System.Type.GetType("System.String"));
            dbTable.Columns.Add("check_no", System.Type.GetType("System.String"));

            dbTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_debit_side_increase", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_active_account", System.Type.GetType("System.Boolean"));

            dbTable.Columns.Add("accounting_category_id", System.Type.GetType("System.String"));
            dbTable.Columns.Add("category_description", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberListInHouseHospitalizationCredit";

                    if (String.IsNullOrEmpty(memberSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = memberSysIdList;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["hospitalization_credit_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "hospitalization_credit_id", 
                                    Int64.Parse("0"));
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["reflected_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reflected_date",
                                    DateTime.MinValue).ToString();
                                newRow["receipt_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_date",
                                    DateTime.MinValue).ToString();
                                newRow["received_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_date",
                                    DateTime.MinValue).ToString();
                                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_no", String.Empty);
                                newRow["credit_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "credit_amount", Decimal.Parse("0.00"));
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
                                newRow["amount_tendered"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amount_tendered", Decimal.Parse("0.00"));
                                newRow["bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "bank", String.Empty);
                                newRow["check_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);

                                newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_credit", String.Empty);
                                newRow["account_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                newRow["account_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
                                newRow["is_debit_side_increase"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_debit_side_increase", false);
                                newRow["is_active_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account", false);

                                newRow["accounting_category_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "accounting_category_id", String.Empty);
                                newRow["category_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "category_description", String.Empty);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

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
            DataTable dbTable = new DataTable("ShareCapitalCreditByMemberSysIdListTable");
            dbTable.Columns.Add("capital_credit_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
            dbTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("received_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("credit_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            dbTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("bank", System.Type.GetType("System.String"));
            dbTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_migrated_entry", System.Type.GetType("System.String"));

            dbTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_debit_side_increase", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_active_account", System.Type.GetType("System.Boolean"));

            dbTable.Columns.Add("accounting_category_id", System.Type.GetType("System.String"));
            dbTable.Columns.Add("category_description", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberListShareCapitalCredit";

                    if (String.IsNullOrEmpty(memberSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = memberSysIdList;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["capital_credit_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "capital_credit_id", Int64.Parse("0"));
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["reflected_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reflected_date",
                                    DateTime.MinValue).ToString();
                                newRow["receipt_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_date",
                                    DateTime.MinValue).ToString();
                                newRow["received_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_date",
                                    DateTime.MinValue).ToString();
                                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_no", String.Empty);
                                newRow["credit_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "credit_amount", Decimal.Parse("0.00"));
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
                                newRow["amount_tendered"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amount_tendered", Decimal.Parse("0.00"));
                                newRow["bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "bank", String.Empty);
                                newRow["check_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);
                                newRow["is_migrated_entry"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_migrated_entry", false);

                                newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_credit", String.Empty);
                                newRow["account_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                newRow["account_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
                                newRow["is_debit_side_increase"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_debit_side_increase", false);
                                newRow["is_active_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account", false);

                                newRow["accounting_category_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "accounting_category_id", String.Empty);
                                newRow["category_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "category_description", String.Empty);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

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
            DataTable dbTable = new DataTable("MemberEquityCreditByMemberSysIdListTable");
            dbTable.Columns.Add("equity_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
            dbTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("received_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("credit_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            dbTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("bank", System.Type.GetType("System.String"));
            dbTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_migrated_entry", System.Type.GetType("System.String"));

            dbTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_debit_side_increase", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_active_account", System.Type.GetType("System.Boolean"));

            dbTable.Columns.Add("accounting_category_id", System.Type.GetType("System.String"));
            dbTable.Columns.Add("category_description", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberListMemberEquityCredit";

                    if (String.IsNullOrEmpty(memberSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = memberSysIdList;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["equity_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "equity_id", Int64.Parse("0"));
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["reflected_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reflected_date",
                                    DateTime.MinValue).ToString();
                                newRow["receipt_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_date",
                                    DateTime.MinValue).ToString();
                                newRow["received_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_date",
                                    DateTime.MinValue).ToString();
                                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_no", String.Empty);
                                newRow["credit_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "credit_amount", Decimal.Parse("0.00"));
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
                                newRow["amount_tendered"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amount_tendered", Decimal.Parse("0.00"));
                                newRow["bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "bank", String.Empty);
                                newRow["check_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);
                                newRow["is_migrated_entry"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_migrated_entry", false);

                                newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_credit", String.Empty);
                                newRow["account_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code", String.Empty);
                                newRow["account_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name", String.Empty);
                                newRow["is_debit_side_increase"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_debit_side_increase", false);
                                newRow["is_active_account"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account", false);

                                newRow["accounting_category_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "accounting_category_id", String.Empty);
                                newRow["category_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "category_description", String.Empty);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

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
            DataTable dbTable = new DataTable("RegularLoanPaymentsByRegularLoanSysIdListTable");
            dbTable.Columns.Add("payment_id", System.Type.GetType("System.Int64"));
		    dbTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("received_date", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("payment_amount", System.Type.GetType("System.Decimal"));
		    dbTable.Columns.Add("principal_paid", System.Type.GetType("System.Decimal"));
		    dbTable.Columns.Add("interest_paid", System.Type.GetType("System.Decimal"));
		    dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
		    dbTable.Columns.Add("bank", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("rebate_amount", System.Type.GetType("System.Decimal"));

		    dbTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_debit_side_increase_credit", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_active_account_credit", System.Type.GetType("System.Boolean"));

            dbTable.Columns.Add("accounting_category_id_credit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("category_description_credit", System.Type.GetType("System.String"));

            dbTable.Columns.Add("sysid_account_rebate", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_code_rebate", System.Type.GetType("System.String"));
            dbTable.Columns.Add("account_name_rebate", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_debit_side_increase_rebate", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_active_account_rebate", System.Type.GetType("System.Boolean"));

            dbTable.Columns.Add("accounting_category_id_rebate", System.Type.GetType("System.String"));
            dbTable.Columns.Add("category_description_rebate", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularListRegularLoanPayments";

                    if (String.IsNullOrEmpty(regularLoanSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = regularLoanSysIdList;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["payment_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payment_id", Int64.Parse("0"));
                                newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_regular", String.Empty);
                                newRow["reflected_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reflected_date", 
                                    DateTime.MinValue).ToString();
                                newRow["receipt_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_date",
                                    DateTime.MinValue).ToString();
                                newRow["received_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "received_date", 
                                    DateTime.MinValue).ToString();
                                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "receipt_no", String.Empty);
                                newRow["payment_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payment_amount", Decimal.Parse("0.00"));
                                newRow["principal_paid"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "principal_paid", Decimal.Parse("0.00"));
                                newRow["interest_paid"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "interest_paid", Decimal.Parse("0.00"));
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
                                newRow["amount_tendered"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amount_tendered", Decimal.Parse("0.00"));
                                newRow["bank"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "bank", String.Empty);
                                newRow["check_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);
                                newRow["rebate_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "rebate_amount", Decimal.Parse("0.00"));

                                newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_credit", String.Empty);
                                newRow["account_code_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code_credit", String.Empty);
                                newRow["account_name_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name_credit", String.Empty);
                                newRow["is_debit_side_increase_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "is_debit_side_increase_credit", false);
                                newRow["is_active_account_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account_credit", false);

                                newRow["accounting_category_id_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "accounting_category_id_credit", String.Empty);
                                newRow["category_description_credit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "category_description_credit", String.Empty);

                                newRow["sysid_account_rebate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account_rebate", String.Empty);
                                newRow["account_code_rebate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_code_rebate", String.Empty);
                                newRow["account_name_rebate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_name_rebate", String.Empty);
                                newRow["is_debit_side_increase_rebate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "is_debit_side_increase_rebate", false);
                                newRow["is_active_account_rebate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_account_rebate", false);

                                newRow["accounting_category_id_rebate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "accounting_category_id_rebate", String.Empty);
                                newRow["category_description_rebate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "category_description_rebate", String.Empty);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

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
            DataTable dbTable = new DataTable("ShareCapitalInformationByMemberSysIdListTable");
            dbTable.Columns.Add("share_capital_id", System.Type.GetType("System.Int64"));
			dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("effectivity_date", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("premium_amount_due", System.Type.GetType("System.Decimal"));
			dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));            
			dbTable.Columns.Add("is_precluded_withdrawal", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_precluded_retirement", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_current_share_capital", System.Type.GetType("System.Boolean"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberListShareCapitalInformation";

                    if (String.IsNullOrEmpty(memberSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = memberSysIdList;
                    }

                    sqlComm.Parameters.Add("@include_history", SqlDbType.Bit).Value = includeHistory;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["share_capital_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "share_capital_id", Int64.Parse("0"));
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["effectivity_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "effectivity_date",
                                    DateTime.MinValue).ToString();
                                newRow["premium_amount_due"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "premium_amount_due",
                                    Decimal.Parse("0"));
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
                                newRow["is_precluded_withdrawal"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_precluded_withdrawal",
                                    false);
                                newRow["is_precluded_retirement"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_precluded_retirement",
                                    false);
                                newRow["is_current_share_capital"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_current_share_capital",
                                    false);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

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
            DataTable dbTable = new DataTable("InHouseHospitalizationInformationByMemberSysIdListTable");
            dbTable.Columns.Add("in_house_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
            dbTable.Columns.Add("effectivity_date", System.Type.GetType("System.String"));
            dbTable.Columns.Add("certificate_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("premium_amount_due", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("maximum_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_precluded", System.Type.GetType("System.Boolean"));
            dbTable.Columns.Add("is_current_hospitalization", System.Type.GetType("System.Boolean"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberListInHouseHospitalizationInformation";

                    if (String.IsNullOrEmpty(memberSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = memberSysIdList;
                    }

                    sqlComm.Parameters.Add("@include_history", SqlDbType.Bit).Value = includeHistory;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["in_house_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "in_house_id", Int64.Parse("0"));
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["effectivity_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "effectivity_date",
                                    DateTime.MinValue).ToString();
                                newRow["certificate_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "certificate_no", String.Empty);
                                newRow["premium_amount_due"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "premium_amount_due",
                                    Decimal.Parse("0"));
                                newRow["maximum_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "maximum_amount",
                                    Decimal.Parse("0"));
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
                                newRow["is_precluded"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_precluded",
                                    false);
                                newRow["is_current_hospitalization"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_current_hospitalization",
                                    false);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

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
            DataTable dbTable = new DataTable("HospitalizationIncludeTableTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectHospitalizationIncludeCoverage";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    sqlComm.Parameters.Add("@include_marked_deleted", SqlDbType.Bit).Value = includeMarkedDeleted;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }
                }
            }

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
            DataTable dbTable = new DataTable("HospitalizationExcludeTableTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectHospitalizationExcludeCoverage";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    sqlComm.Parameters.Add("@include_marked_deleted", SqlDbType.Bit).Value = includeMarkedDeleted;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }
                }
            }

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
            DataTable dbTable = new DataTable("InHouseHospitalizationDebitByMemberSysIdListTable");
            dbTable.Columns.Add("sysid_inhousedebit", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("net_assistance_amount", System.Type.GetType("System.Decimal"));
		    dbTable.Columns.Add("hospital_name", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("cause_of_admission", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("date_from", System.Type.GetType("System.String"));
		    dbTable.Columns.Add("date_to", System.Type.GetType("System.String"));
            dbTable.Columns.Add("remarks", System.Type.GetType("System.String"));

            dbTable.Columns.Add("is_record_locked", System.Type.GetType("System.Boolean"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberListInHouseHospitalizationDebit";

                    if (String.IsNullOrEmpty(memberSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_list", SqlDbType.NVarChar).Value = memberSysIdList;
                    }

                    sqlComm.Parameters.Add("@is_marked_deleted", SqlDbType.Bit).Value = isMarkedDeleted;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["sysid_inhousedebit"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_inhousedebit", String.Empty);
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["reflected_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reflected_date", 
                                    DateTime.MinValue).ToString();
                                newRow["net_assistance_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "net_assistance_amount",
                                    Decimal.Parse("0"));
                                newRow["hospital_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "hospital_name", String.Empty);
                                newRow["cause_of_admission"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "cause_of_admission", String.Empty);
                                newRow["date_from"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_from", DateTime.MinValue).ToString();
                                newRow["date_to"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_to", DateTime.MinValue).ToString();
                                newRow["remarks"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty).ToString();

                                newRow["is_record_locked"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_record_locked", false);

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDInHouseHospitalizationDebit";

                    sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {

                                inHouseDebitInfo.InHouseDebitSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_inhousedebit", String.Empty);
		                        inHouseDebitInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
		                        inHouseDebitInfo.ReflectedDate = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reflected_date",
                                    DateTime.MinValue).ToString();
		                        inHouseDebitInfo.NetAssistanceAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "net_assistance_amount",
                                    Decimal.Parse("0"));
		                        inHouseDebitInfo.HospitalName = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "hospital_name", String.Empty);
		                        inHouseDebitInfo.CauseOfAdmission = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "cause_of_admission", String.Empty);
		                        inHouseDebitInfo.DateFrom = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_from", DateTime.MinValue).ToString();
		                        inHouseDebitInfo.DateTo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_to", DateTime.MinValue).ToString();
                                inHouseDebitInfo.Remarks = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);

                                inHouseDebitInfo.IsRecordLocked = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_record_locked", false);

                                break;
                            }
                        }

                        sqlReader.Close();
                    }
                }

                //gets the in-house hospitalization debit include coverage
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDInHouseDebitListInHouseIncludeCoverage";

                    if (String.IsNullOrEmpty(inHouseDebitInfo.InHouseDebitSysId))
                    {
                        sqlComm.Parameters.Add("@sysid_inhousedebit_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_inhousedebit_list", SqlDbType.NVarChar).Value = inHouseDebitInfo.InHouseDebitSysId;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                CommonExchange.InHouseIncludeCoverage inHouseIncludeCoverageInfo = new CommonExchange.InHouseIncludeCoverage();

                                inHouseIncludeCoverageInfo.IncludeCoverageId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "include_coverage_id",
                                    Int64.Parse("0"));
		                        inHouseIncludeCoverageInfo.IncludeAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "include_amount",
                                    Decimal.Parse("0"));
		                        inHouseIncludeCoverageInfo.Remarks = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);

			                    inHouseIncludeCoverageInfo.IncludeCoverageInfo.IncludeCoverageSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "sysid_includecoverage", String.Empty);
                                inHouseIncludeCoverageInfo.IncludeCoverageInfo.IncludeCoverageDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "include_coverage_description", String.Empty);

                                inHouseDebitInfo.IncludeCoverageList.Add(inHouseIncludeCoverageInfo);

                            }
                        }

                        sqlReader.Close();
                    }
                }

                //gets the in-house hospitalization debit exclude coverage
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDInHouseDebitListInHouseExcludeCoverage";

                    if (String.IsNullOrEmpty(inHouseDebitInfo.InHouseDebitSysId))
                    {
                        sqlComm.Parameters.Add("@sysid_inhousedebit_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_inhousedebit_list", SqlDbType.NVarChar).Value = inHouseDebitInfo.InHouseDebitSysId;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                CommonExchange.InHouseExcludeCoverage inHouseExcludeCoverageInfo = new CommonExchange.InHouseExcludeCoverage();

                                inHouseExcludeCoverageInfo.ExcludeCoverageId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "exclude_coverage_id",
                                    Int64.Parse("0"));
                                inHouseExcludeCoverageInfo.ExcludeAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "exclude_amount",
                                    Decimal.Parse("0"));
                                inHouseExcludeCoverageInfo.Remarks = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);

                                inHouseExcludeCoverageInfo.ExcludeCoverageInfo.ExcludeCoverageSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "sysid_excludecoverage", String.Empty);
                                inHouseExcludeCoverageInfo.ExcludeCoverageInfo.ExcludeCoverageDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "exclude_coverage_description", String.Empty);

                                inHouseDebitInfo.ExcludeCoverageList.Add(inHouseExcludeCoverageInfo);

                            }
                        }

                        sqlReader.Close();
                    }
                }

            }

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
            DataTable dbTable = new DataTable("HospitalizationDocumentsTable");
            dbTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("sysid_inhousedebit", System.Type.GetType("System.String"));
            dbTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            dbTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("document_information", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDInHouseDebitListHospitalizationDocument";

                    if (String.IsNullOrEmpty(inHouseDebitSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_inhousedebit_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_inhousedebit_list", SqlDbType.NVarChar).Value = inHouseDebitSysIdList;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader(CommandBehavior.SequentialAccess))
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["document_id"] = sqlReader["document_id"];
                                newRow["sysid_inhousedebit"] = sqlReader["sysid_inhousedebit"];
                                newRow["file_data"] = sqlReader["file_data"];
                                newRow["original_name"] = sqlReader["original_name"];
                                newRow["document_information"] = sqlReader["document_information"];

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }
                }

                dbTable.AcceptChanges();
            }

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
            DataTable dbTable = new DataTable("SummaryLoanPaymentsByMemberSysIdListTable");
            dbTable.Columns.Add("table_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("date_created", System.Type.GetType("System.String"));
            dbTable.Columns.Add("date_reflected", System.Type.GetType("System.String"));
            dbTable.Columns.Add("description_summary", System.Type.GetType("System.String"));
            dbTable.Columns.Add("debit_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("credit_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("balance_amount", System.Type.GetType("System.Decimal"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments";

                    sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberSysId;

                    if (String.IsNullOrEmpty(memberSysId))
                    {
                        sqlComm.Parameters.Add("@regular_loan_type_id_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@regular_loan_type_id_list", SqlDbType.NVarChar).Value = regularLoanTypeIdList;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["table_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "table_id", Int64.Parse("0"));
                                newRow["date_created"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_created",
                                    DateTime.MinValue).ToShortDateString();
                                newRow["date_reflected"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_reflected",
                                   DateTime.MinValue).ToShortDateString();
                                newRow["description_summary"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "description_summary", String.Empty);
                                newRow["debit_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "debit_amount",
                                    Decimal.Parse("0"));
                                newRow["credit_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "credit_amount",
                                    Decimal.Parse("0"));
                                newRow["balance_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "balance_amount",
                                    Decimal.Parse("0"));

                                dbTable.Rows.Add(newRow);
                            }
                        }

                        sqlReader.Close();
                    }

                    dbTable.AcceptChanges();

                }
            }

            return dbTable;

        } //------------------------------   

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

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument";

                    sqlComm.Parameters.Add("@document_id", SqlDbType.BigInt).Value = documentId;
                    sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitSysId;
                    sqlComm.Parameters.Add("@original_name", SqlDbType.VarChar).Value = originalName;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;

        } //------------------------------------------

        #endregion
    }
}
