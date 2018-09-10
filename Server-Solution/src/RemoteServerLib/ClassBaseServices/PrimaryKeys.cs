using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace RemoteServerLib
{
    internal class PrimaryKeys
    {
        #region Programmer-Defined Function Procedures

        //this function gets a new person information id
        public static String GetNewPersonInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int64 rowCount = 0;
            String personId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountPersonInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt64(sqlComm.ExecuteScalar());
            }

            do
            {
                personId = "SYSPER" + (++rowCount).ToString("000000000000");

            } while (IsExistsSysIDPersonInformation(userInfo.UserId, sqlConn, personId));

            return personId;
        }

        public static Boolean IsExistsSysIDPersonInformation(String userId, SqlConnection sqlConn, String personId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDPersonInformation";

                sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new member information id
        public static String GetNewMemberInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int32 rowCount = 0;
            String memberId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountMemberInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt32(sqlComm.ExecuteScalar());
            }

            do
            {
                memberId = "SYSMEM" + (++rowCount).ToString("000000000");

            } while (IsExistsSysIDMemberInformation(userInfo.UserId, sqlConn, memberId));

            return memberId;
        }

        private static Boolean IsExistsSysIDMemberInformation(String userId, SqlConnection sqlConn, String memberId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDMemberInformation";

                sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new office id
        public static String GetNewOfficeEmployerInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int16 rowCount = 0;
            String officeEmployerId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountOfficeEmployerInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt16(sqlComm.ExecuteScalar());
            }

            do
            {
                officeEmployerId = "OEI" + (++rowCount).ToString("000000");

            } while (IsExistsSysIDOfficeEmployerInformation(userInfo.UserId, sqlConn, officeEmployerId));

            return officeEmployerId;
        }

        private static Boolean IsExistsSysIDOfficeEmployerInformation(String userId, SqlConnection sqlConn, String officeEmployerId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDOfficeEmployerInformation";

                sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = officeEmployerId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new collector id
        public static String GetNewCollectorInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int32 rowCount = 0;
            String collectorId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountCollectorInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt32(sqlComm.ExecuteScalar());
            }

            do
            {
                collectorId = "SYSCOL" + (++rowCount).ToString("000000000");

            } while (IsExistsSysIDCollectorInformation(userInfo.UserId, sqlConn, collectorId));

            return collectorId;
        }

        private static Boolean IsExistsSysIDCollectorInformation(String userId, SqlConnection sqlConn, String collectorId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDCollectorInformation";

                sqlComm.Parameters.Add("@sysid_collector", SqlDbType.VarChar).Value = collectorId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new regular loan information
        public static String GetNewRegularLoanInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int64 rowCount = 0;
            String loanId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountRegularLoanInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt64(sqlComm.ExecuteScalar());
            }

            do
            {
                loanId = "SYSRLI" + (++rowCount).ToString("000000000000");

            } while (IsExistsSysIDRegularLoanInformation(userInfo.UserId, sqlConn, loanId));

            return loanId;
        }

        private static Boolean IsExistsSysIDRegularLoanInformation(String userId, SqlConnection sqlConn, String loanId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDRegularLoanInformation";

                sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = loanId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new collateral information id
        public static String GetNewCollateralInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int64 rowCount = 0;
            String collateralId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountCollateralInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt64(sqlComm.ExecuteScalar());
            }

            do
            {
                collateralId = "SYSCLI" + (++rowCount).ToString("000000000000");

            } while (IsExistsSysIDCollateralInformation(userInfo.UserId, sqlConn, collateralId));

            return collateralId;
        }

        private static Boolean IsExistsSysIDCollateralInformation(String userId, SqlConnection sqlConn, String collateralId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDCollateralInformation";

                sqlComm.Parameters.Add("@sysid_collateral", SqlDbType.VarChar).Value = collateralId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new hospitalization include coverage information id
        public static String GetNewHospitalizationIncludeCoverageSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int16 rowCount = 0;
            String includeCoverageId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountHospitalizationIncludeCoverage";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt16(sqlComm.ExecuteScalar());
            }

            do
            {
                includeCoverageId = "SYSHIC" + (++rowCount).ToString("000");

            } while (IsExistsSysIDHospitalizationIncludeCoverage(userInfo.UserId, sqlConn, includeCoverageId));

            return includeCoverageId;
        }

        private static Boolean IsExistsSysIDHospitalizationIncludeCoverage(String userId, SqlConnection sqlConn, String includeCoverageId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDHospitalizationIncludeCoverage";

                sqlComm.Parameters.Add("@sysid_includecoverage", SqlDbType.VarChar).Value = includeCoverageId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new hospitalization exclude coverage information id
        public static String GetNewHospitalizationExcludeCoverageSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int16 rowCount = 0;
            String excludeCoverageId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountHospitalizationExcludeCoverage";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt16(sqlComm.ExecuteScalar());
            }

            do
            {
                excludeCoverageId = "SYSHEC" + (++rowCount).ToString("000");

            } while (IsExistsSysIDHospitalizationExcludeCoverage(userInfo.UserId, sqlConn, excludeCoverageId));

            return excludeCoverageId;
        }

        private static Boolean IsExistsSysIDHospitalizationExcludeCoverage(String userId, SqlConnection sqlConn, String excludeCoverageId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDHospitalizationExcludeCoverage";

                sqlComm.Parameters.Add("@sysid_excludecoverage", SqlDbType.VarChar).Value = excludeCoverageId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new in house hospitalization debit system id
        public static String GetNewInHouseHospitalizationDebitSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int64 rowCount = 0;
            String inHouseDebitId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountInHouseHospitalizationDebit";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt64(sqlComm.ExecuteScalar());
            }

            do
            {
                inHouseDebitId = "SYSIHD" + (++rowCount).ToString("000000000000");

            } while (IsExistsSysIDInHouseHospitalizationDebit(userInfo.UserId, sqlConn, inHouseDebitId));

            return inHouseDebitId;
        }

        private static Boolean IsExistsSysIDInHouseHospitalizationDebit(String userId, SqlConnection sqlConn, String inHouseDebitId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDInHouseHospitalizationDebit";

                sqlComm.Parameters.Add("@sysid_inhousedebit", SqlDbType.VarChar).Value = inHouseDebitId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //--------------------------------

        //this function gets a new chart of accounts system id
        public static String GetNewChartOfAccountsSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int32 rowCount = 0;
            String accountId = "";

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.GetCountChartOfAccounts";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt32(sqlComm.ExecuteScalar());
            }

            do
            {
                accountId = "SYSCOA" + (++rowCount).ToString("00000");

            } while (IsExistsSysIDChartOfAccount(userInfo.UserId, sqlConn, accountId));

            return accountId;
        }

        private static Boolean IsExistsSysIDChartOfAccount(String userId, SqlConnection sqlConn, String accountId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDChartOfAccount";

                sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = accountId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new bank information system id
        public static String GetNewBankInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int16 rowCount = 0;
            String bankId = "";

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountBankInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt16(sqlComm.ExecuteScalar());
            }

            do
            {
                bankId = "SYSBNK" + (++rowCount).ToString("000");

            } while (IsExistsSysIDBankInformation(userInfo.UserId, sqlConn, bankId));

            return bankId;
        }

        private static Boolean IsExistsSysIDBankInformation(String userId, SqlConnection sqlConn, String bankId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDBankInformation";

                sqlComm.Parameters.Add("@sysid_bank", SqlDbType.VarChar).Value = bankId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        //this function gets a new in disbursement voucher system id
        public static String GetNewDisbursementVoucherInformationSystemID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            Int64 rowCount = 0;
            String voucherId = String.Empty;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectCountDisbursementVoucherInformation";

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                rowCount = Convert.ToInt64(sqlComm.ExecuteScalar());
            }

            do
            {
                voucherId = "VN" + (++rowCount).ToString("000000000000");

            } while (IsExistsSysIDDisbursementVoucherInformation(userInfo.UserId, sqlConn, voucherId));

            return voucherId;
        }

        private static Boolean IsExistsSysIDDisbursementVoucherInformation(String userId, SqlConnection sqlConn, String voucherId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsSysIDDisbursementVoucherInformation";

                sqlComm.Parameters.Add("@sysid_voucher", SqlDbType.VarChar).Value = voucherId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //--------------------------------

        //this function gets a new system user id
        public static String GetNewSystemUserID(CommonExchange.SysAccess userInfo, SqlConnection sqlConn)
        {
            StringBuilder newUserId;

            do
            {
                newUserId = new StringBuilder();

                Int32 sSpecial, eSpecial, sUChar, eUChar, sLChar, eLChar, delimeter, oSqBracket, cSqBracket;

                sSpecial = Convert.ToInt32('!');
                eSpecial = Convert.ToInt32('?');
                sUChar = Convert.ToInt32('@');
                eUChar = Convert.ToInt32('_');
                sLChar = Convert.ToInt32('`');
                eLChar = Convert.ToInt32('~');
                delimeter = Convert.ToInt32('#');
                oSqBracket = Convert.ToInt32('[');
                cSqBracket = Convert.ToInt32(']');

                newUserId.Append(Convert.ToChar(delimeter).ToString());

                for (Int32 i = 1; i <= 26; i++)
                {
                    Boolean isValid = false;
                    Int32 iRandom = 0;

                    Thread.Sleep(15);

                    Random randObj = new Random(DateTime.Now.Millisecond);

                    do
                    {
                        iRandom = randObj.Next(sSpecial, eLChar);

                        if ((((iRandom >= sSpecial) && (iRandom <= eSpecial)) ||
                            ((iRandom >= sUChar) && (iRandom <= eUChar)) ||
                            ((iRandom >= sLChar) && (iRandom <= eLChar))) &&
                            (iRandom != delimeter) && (iRandom != oSqBracket) && (iRandom != cSqBracket))
                        {
                            newUserId.Append(Convert.ToChar(iRandom).ToString());
                            isValid = true;
                        }

                    } while (!isValid);
                }

                newUserId.Append(Convert.ToChar(delimeter).ToString());

            } while (IsExistsIDSystemUserInfo(userInfo.UserId, sqlConn, newUserId.ToString()));

            return newUserId.ToString();
        }

        private static Boolean IsExistsIDSystemUserInfo(String userId, SqlConnection sqlConn, String newUserId)
        {
            Boolean isExist = false;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.IsExistsIDSystemUserInformation";

                sqlComm.Parameters.Add("@new_user_id", SqlDbType.VarChar).Value = newUserId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                isExist = (Boolean)sqlComm.ExecuteScalar();
            }

            return isExist;

        } //-----------------------------

        #endregion
    }
}
