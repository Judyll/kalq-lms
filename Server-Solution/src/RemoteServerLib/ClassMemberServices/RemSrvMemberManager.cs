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
        public void InsertMemberInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Member memberInfo)
        {
            if (memberInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (RemSrvBaseManager remSrv = new RemSrvBaseManager())
                    {
                        memberInfo.PersonInfo.ForLogin = memberInfo.PersonInfo.ForCollector = false;
                        memberInfo.PersonInfo.ForMember = true;

                        CommonExchange.Person personInfo = memberInfo.PersonInfo;

                        remSrv.InsertUpdatePersonInformationNoAuthenticate(userInfo, auth.Connection, ref personInfo);

                        memberInfo.PersonInfo = personInfo;
                    }

                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertMemberInformation";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberInfo.MemberSysId =
                            PrimaryKeys.GetNewMemberInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@member_id", SqlDbType.VarChar).Value = memberInfo.MemberId;
                        sqlComm.Parameters.Add("@membership_date", SqlDbType.DateTime).Value = DateTime.Parse(memberInfo.MembershipDate);

                        if (String.IsNullOrEmpty(memberInfo.MemberTypeInfo.MemberTypeId))
                        {
                            sqlComm.Parameters.Add("@member_type_id", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@member_type_id", SqlDbType.VarChar).Value = memberInfo.MemberTypeInfo.MemberTypeId;
                        }
                        
                        if (String.IsNullOrEmpty(memberInfo.ClassificationInfo.ClassificationId))
                        {
                            sqlComm.Parameters.Add("@classification_id", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@classification_id", SqlDbType.VarChar).Value = memberInfo.ClassificationInfo.ClassificationId;
                        }

                        sqlComm.Parameters.Add("@reason_for_membership", SqlDbType.VarChar).Value = memberInfo.ReasonForMembership;
                        sqlComm.Parameters.Add("@other_coop_membership", SqlDbType.VarChar).Value = memberInfo.OtherCoopMembership;
                        sqlComm.Parameters.Add("@certification_information", SqlDbType.VarChar).Value = memberInfo.CertificationInformation;                        
                        sqlComm.Parameters.Add("@other_member_information", SqlDbType.VarChar).Value = memberInfo.OtherMemberInformation;
                        sqlComm.Parameters.Add("@is_active", SqlDbType.Bit).Value = memberInfo.IsActive;

                        sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = memberInfo.PersonInfo.PersonSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update or delete a member relationship information
                    this.InsertUpdateDeleteMemberRelationshipInformation(userInfo, auth.Connection, memberInfo.MemberSysId, 
                        memberInfo.MemberRelationshipList);

                    //insert, update or delete an other creditor information
                    this.InsertUpdateDeleteOtherCreditorInformation(userInfo, auth.Connection, memberInfo.MemberSysId,
                        memberInfo.OtherCreditorInfoList);
                    
                }
            }

        } //--------------------------------

        //this procedure updates member information
        public void UpdateMemberInformation(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo)
        {
            if (memberInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (RemSrvBaseManager remSrv = new RemSrvBaseManager())
                    {
                        memberInfo.PersonInfo.ForLogin = memberInfo.PersonInfo.ForCollector = false;
                        memberInfo.PersonInfo.ForMember = true;

                        CommonExchange.Person personInfo = memberInfo.PersonInfo;

                        remSrv.InsertUpdatePersonInformationNoAuthenticate(userInfo, auth.Connection, ref personInfo);

                        memberInfo.PersonInfo = personInfo;
                    }

                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateMemberInformation";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberInfo.MemberSysId;

                        if (String.IsNullOrEmpty(memberInfo.MemberTypeInfo.MemberTypeId))
                        {
                            sqlComm.Parameters.Add("@member_type_id", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@member_type_id", SqlDbType.VarChar).Value = memberInfo.MemberTypeInfo.MemberTypeId;
                        }

                        if (String.IsNullOrEmpty(memberInfo.ClassificationInfo.ClassificationId))
                        {
                            sqlComm.Parameters.Add("@classification_id", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@classification_id", SqlDbType.VarChar).Value = memberInfo.ClassificationInfo.ClassificationId;
                        }

                        sqlComm.Parameters.Add("@reason_for_membership", SqlDbType.VarChar).Value = memberInfo.ReasonForMembership;
                        sqlComm.Parameters.Add("@other_coop_membership", SqlDbType.VarChar).Value = memberInfo.OtherCoopMembership;
                        sqlComm.Parameters.Add("@certification_information", SqlDbType.VarChar).Value = memberInfo.CertificationInformation;
                        sqlComm.Parameters.Add("@other_member_information", SqlDbType.VarChar).Value = memberInfo.OtherMemberInformation;
                        sqlComm.Parameters.Add("@is_active", SqlDbType.Bit).Value = memberInfo.IsActive;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update or delete a member relationship information
                    this.InsertUpdateDeleteMemberRelationshipInformation(userInfo, auth.Connection, memberInfo.MemberSysId, 
                        memberInfo.MemberRelationshipList);

                    //insert, update or delete an other creditor information
                    this.InsertUpdateDeleteOtherCreditorInformation(userInfo, auth.Connection, memberInfo.MemberSysId,
                        memberInfo.OtherCreditorInfoList);
                }
            }

        } //--------------------------------

        //this procedure adds a new collector information
        public void InsertCollectorInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Collector collectorInfo)
        {
            if (collectorInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (RemSrvBaseManager remSrv = new RemSrvBaseManager())
                    {
                        collectorInfo.PersonInfo.ForLogin = collectorInfo.PersonInfo.ForMember = false;
                        collectorInfo.PersonInfo.ForCollector = true;

                        CommonExchange.Person personInfo = collectorInfo.PersonInfo;

                        remSrv.InsertUpdatePersonInformationNoAuthenticate(userInfo, auth.Connection, ref personInfo);

                        collectorInfo.PersonInfo = personInfo;
                    }

                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertCollectorInformation";

                        sqlComm.Parameters.Add("@sysid_collector", SqlDbType.VarChar).Value = collectorInfo.CollectorSysId =
                            PrimaryKeys.GetNewCollectorInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = collectorInfo.EmployeeId;
                        sqlComm.Parameters.Add("@other_collector_information", SqlDbType.VarChar).Value = collectorInfo.OtherCollectorInformation;
                        sqlComm.Parameters.Add("@is_active", SqlDbType.Bit).Value = collectorInfo.IsActive;

                        sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = collectorInfo.PersonInfo.PersonSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        //this procedure updates collector information
        public void UpdateCollectorInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collector collectorInfo)
        {
            if (collectorInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (RemSrvBaseManager remSrv = new RemSrvBaseManager())
                    {
                        collectorInfo.PersonInfo.ForLogin = collectorInfo.PersonInfo.ForMember = false;
                        collectorInfo.PersonInfo.ForCollector = true;

                        CommonExchange.Person personInfo = collectorInfo.PersonInfo;

                        remSrv.InsertUpdatePersonInformationNoAuthenticate(userInfo, auth.Connection, ref personInfo);

                        collectorInfo.PersonInfo = personInfo;
                    }

                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateCollectorInformation";

                        sqlComm.Parameters.Add("@sysid_collector", SqlDbType.VarChar).Value = collectorInfo.CollectorSysId;
                        sqlComm.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = collectorInfo.EmployeeId;
                        sqlComm.Parameters.Add("@other_collector_information", SqlDbType.VarChar).Value = collectorInfo.OtherCollectorInformation;
                        sqlComm.Parameters.Add("@is_active", SqlDbType.Bit).Value = collectorInfo.IsActive;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure adds, updates, and deletes a member relationship information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanAmortizationList"></param>
        private void InsertUpdateDeleteMemberRelationshipInformation(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String memberSysId,
            List<CommonExchange.MemberRelationship> memberRelationshipList)
        {
            //checks if there is a member relationship that will be deleted
            foreach (CommonExchange.MemberRelationship mRelationship in memberRelationshipList)
            {
                if (mRelationship.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteMemberRelationshipInformation";

                        sqlComm.Parameters.Add("@relationship_id", SqlDbType.BigInt).Value = mRelationship.RelationshipId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

            foreach (CommonExchange.MemberRelationship mRelationship in memberRelationshipList)
            {
                if (mRelationship.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertMemberRelationshipInformation";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberSysId;
                        sqlComm.Parameters.Add("@in_relationship_with_sysid_member", SqlDbType.VarChar).Value =
                            mRelationship.MemberInRelationshipWith.PersonSysId;
                        sqlComm.Parameters.Add("@relationship_type_id", SqlDbType.VarChar).Value = mRelationship.RelationshipTypeInfo.RelationshipTypeId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (mRelationship.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateMemberRelationshipInformation";

                        sqlComm.Parameters.Add("@relationship_id", SqlDbType.BigInt).Value = mRelationship.RelationshipId;
                        sqlComm.Parameters.Add("@relationship_type_id", SqlDbType.VarChar).Value = mRelationship.RelationshipTypeInfo.RelationshipTypeId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure adds, updates, and deletes an other creditor information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanAmortizationList"></param>
        private void InsertUpdateDeleteOtherCreditorInformation(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String memberSysId,
            List<CommonExchange.OtherCreditor> otherCreditorInfoList)
        {
            //checks if there is a member relationship that will be deleted
            foreach (CommonExchange.OtherCreditor oCreditor in otherCreditorInfoList)
            {
                if (oCreditor.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteOtherCreditorInformation";

                        sqlComm.Parameters.Add("@other_creditor_id", SqlDbType.BigInt).Value = oCreditor.OtherCreditorId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

            foreach (CommonExchange.OtherCreditor oCreditor in otherCreditorInfoList)
            {
                if (oCreditor.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertOtherCreditorInformation";

                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberSysId;
                        sqlComm.Parameters.Add("@creditor_name", SqlDbType.VarChar).Value = oCreditor.CreditorName;
                        sqlComm.Parameters.Add("@date_due", SqlDbType.DateTime).Value = DateTime.Parse(oCreditor.DateDue);
                        sqlComm.Parameters.Add("@repayment_id", SqlDbType.VarChar).Value = oCreditor.RepaymentScheduleInfo.RepaymentId;
                        sqlComm.Parameters.Add("@amount_owned", SqlDbType.Decimal).Value = oCreditor.AmountOwned;
                        sqlComm.Parameters.Add("@amortization_amount", SqlDbType.Decimal).Value = oCreditor.AmortizationAmount;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = oCreditor.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (oCreditor.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateOtherCreditorInformation";

                        sqlComm.Parameters.Add("@other_creditor_id", SqlDbType.BigInt).Value = oCreditor.OtherCreditorId;
                        sqlComm.Parameters.Add("@creditor_name", SqlDbType.VarChar).Value = oCreditor.CreditorName;
                        sqlComm.Parameters.Add("@date_due", SqlDbType.DateTime).Value = DateTime.Parse(oCreditor.DateDue);
                        sqlComm.Parameters.Add("@repayment_id", SqlDbType.VarChar).Value = oCreditor.RepaymentScheduleInfo.RepaymentId;
                        sqlComm.Parameters.Add("@amount_owned", SqlDbType.Decimal).Value = oCreditor.AmountOwned;
                        sqlComm.Parameters.Add("@amortization_amount", SqlDbType.Decimal).Value = oCreditor.AmortizationAmount;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = oCreditor.Remarks;

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
        /// This function returns a new membership id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="membershipYear"></param>
        /// <returns></returns>
        public String SelectCountForMemberIDMemberInformation(CommonExchange.SysAccess userInfo, Int32 membershipYear)
        {
            Int32 count = 0;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectCountForMemberIDMemberInformation";

                    sqlComm.Parameters.Add("@membership_year", SqlDbType.Int).Value = membershipYear;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    count = Convert.ToInt32(sqlComm.ExecuteScalar());
                }
            }

            return membershipYear + "-" + (++count).ToString("000");
        }//------------------------------------------------

        //this function gets the member information table query
        public DataTable SelectMemberInformation(CommonExchange.SysAccess userInfo, String queryString, String officeEmployerIdList,
            String memberTypeIdList, String classificationIdList, String memberSysIdExcludeList, Boolean includeMemberStatus, Boolean isActive)
        {
            DataTable dbTable = new DataTable("MemberInformationTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandTimeout = 500000;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectMemberInformation";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    if (String.IsNullOrEmpty(officeEmployerIdList))
                    {
                        sqlComm.Parameters.Add("@office_employer_id_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@office_employer_id_list", SqlDbType.NVarChar).Value = officeEmployerIdList;
                    }

                    if (String.IsNullOrEmpty(memberTypeIdList))
                    {
                        sqlComm.Parameters.Add("@member_type_id_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@member_type_id_list", SqlDbType.NVarChar).Value = memberTypeIdList;
                    }

                    if (String.IsNullOrEmpty(classificationIdList))
                    {
                        sqlComm.Parameters.Add("@classification_id_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@classification_id_list", SqlDbType.NVarChar).Value = classificationIdList;
                    }

                    if (String.IsNullOrEmpty(memberSysIdExcludeList))
                    {
                        sqlComm.Parameters.Add("@sysid_member_exclude_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_member_exclude_list", SqlDbType.NVarChar).Value = memberSysIdExcludeList;
                    }

                    sqlComm.Parameters.Add("@include_member_status", SqlDbType.Bit).Value = includeMemberStatus;
                    sqlComm.Parameters.Add("@is_active", SqlDbType.Bit).Value = isActive;

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

        //this function gets the collector information table query
        public DataTable SelectCollectorInformation(CommonExchange.SysAccess userInfo, String queryString,
            Boolean includeCollectorStatus, Boolean isActive)
        {
            DataTable dbTable = new DataTable("CollectorInformationTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectCollectorInformation";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    sqlComm.Parameters.Add("@include_collector_status", SqlDbType.Bit).Value = includeCollectorStatus;
                    sqlComm.Parameters.Add("@is_active", SqlDbType.Bit).Value = isActive;

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
        /// This function returns the member or employee/collector information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public DataTable SelectByQueryStringMemberEmployeeInformation(CommonExchange.SysAccess userInfo, String queryString)
        {
            DataTable dbTable = new DataTable("MemberEmployeeInformationTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectByQueryStringMemberEmployeeInformation";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        sqlAdapter.SelectCommand = sqlComm;
                        sqlAdapter.Fill(dbTable);
                    }
                }
            }

            return dbTable;

        } //-------------------------------------

        //this function returns the member information details
        public CommonExchange.Member SelectByMemberIDMemberInformation(CommonExchange.SysAccess userInfo, String memberId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                memberInfo = this.SelectByMemberIDMemberInformationNoAuthenticate(userInfo, auth.Connection, memberId);
            }

            return memberInfo;
        } //-------------------------------------

        //this function returns the member information details
        public CommonExchange.Member SelectBySysIDPersonMemberInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                String memberId = String.Empty;

                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDPersonMemberInformation";

                    sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                memberId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "member_id", String.Empty);

                                break;

                            }
                        }

                        sqlReader.Close();
                    }
                }

                if (!String.IsNullOrEmpty(memberId))
                {
                    memberInfo = this.SelectByMemberIDMemberInformationNoAuthenticate(userInfo, auth.Connection, memberId);
                }
            }

            return memberInfo;
        } //-------------------------------------

        //this function returns the collector information details
        public CommonExchange.Collector SelectByEmployeeIDCollectorInformation(CommonExchange.SysAccess userInfo, String employeeId)
        {
            CommonExchange.Collector collectorInfo = new CommonExchange.Collector();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                collectorInfo = this.SelectByEmployeeIDCollectorInformationNoAuthenticate(userInfo, auth.Connection, employeeId);
            }

            return collectorInfo;
        } //-------------------------------------

        //this function returns the collector information details
        public CommonExchange.Collector SelectBySysIDPersonCollectorInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Collector collectorInfo = new CommonExchange.Collector();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                String employeeId = String.Empty;

                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDPersonCollectorInformation";

                    sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                employeeId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "employee_id", String.Empty);

                                break;

                            }
                        }

                        sqlReader.Close();
                    }
                }

                if (!String.IsNullOrEmpty(employeeId))
                {
                    collectorInfo = this.SelectByEmployeeIDCollectorInformationNoAuthenticate(userInfo, auth.Connection, employeeId);
                }
            }

            return collectorInfo;
        } //-------------------------------------

        //this function is used to determine if the member id exists
        public Boolean IsExistsMemberIDMemberInformation(CommonExchange.SysAccess userInfo, String memberId, String memberSysId)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsMemberIDMemberInformation";

                    sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberSysId;
                    sqlComm.Parameters.Add("@member_id", SqlDbType.VarChar).Value = memberId;
                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;
        } //-----------------------------   

        //this function is used to get data tables stored in one dataset used for member manager
        public DataSet GetDataSetForMemberManager(CommonExchange.SysAccess userInfo)
        {
            DataSet dbSet = new DataSet();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                //gets the member classification table
                dbSet.Tables.Add(ProcStatic.GetMemberClassificationTable(auth.Connection, userInfo.UserId));
                //-----------------------------

                //get the member type table
                dbSet.Tables.Add(ProcStatic.GetMemberTypeTable(auth.Connection, userInfo.UserId));
                //---------------------------------------

                //get the repayment schedule table
                dbSet.Tables.Add(ProcStatic.GetRepaymentScheduleTable(auth.Connection, userInfo.UserId));
                //------------------------------------------
            }

            return dbSet;
        } //----------------------------------

        //this function returns the member information details
        private CommonExchange.Member SelectByMemberIDMemberInformationNoAuthenticate(CommonExchange.SysAccess userInfo, SqlConnection sqlConn,
            String memberId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectByMemberIDMemberInformation";

                sqlComm.Parameters.Add("@member_id", SqlDbType.VarChar).Value = memberId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {

                            memberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
		                    memberInfo.MemberId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "member_id", String.Empty);
                            memberInfo.MembershipDate = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "membership_date", DateTime.MinValue).ToString();
		                    memberInfo.ReasonForMembership = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "reason_for_membership", String.Empty);
		                    memberInfo.OtherCoopMembership = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "other_coop_membership", String.Empty);
                            memberInfo.CertificationInformation = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                "certification_information", String.Empty);
		                    memberInfo.OtherMemberInformation = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "other_member_information", String.Empty);
		                    memberInfo.IsActive = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active", false);

		                    memberInfo.PersonInfo.PersonSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);

                            memberInfo.MemberTypeInfo.MemberTypeId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "member_type_id", String.Empty);
                            memberInfo.MemberTypeInfo.MemberTypeDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                "member_type_description", String.Empty);

                            memberInfo.ClassificationInfo.ClassificationId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                "classification_id", String.Empty);
                            memberInfo.ClassificationInfo.ClassificationDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                "classification_description", String.Empty);

                            break;

                        }
                    }

                    sqlReader.Close();
                }

                if (!String.IsNullOrEmpty(memberInfo.PersonInfo.PersonSysId))
                {
                    using (RemSrvBaseManager remSrv = new RemSrvBaseManager())
                    {
                        memberInfo.PersonInfo = remSrv.SelectBySysIDPersonInformationNoAuthenticate(userInfo.UserId, sqlConn,
                            memberInfo.PersonInfo.PersonSysId);
                    }
                }

            }

            //get the member in relationship information
            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectBySysIDMemberRelationshipInformation";

                sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberInfo.MemberSysId;

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            CommonExchange.MemberRelationship mRelationship = new CommonExchange.MemberRelationship();

                            mRelationship.MemberInRelationshipWith.PersonSysId = ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);
                            mRelationship.MemberInRelationshipWith.LastName = ProcStatic.DataReaderConvert(sqlReader, "last_name", String.Empty);
                            mRelationship.MemberInRelationshipWith.FirstName = ProcStatic.DataReaderConvert(sqlReader, "first_name", String.Empty);
                            mRelationship.MemberInRelationshipWith.MiddleName = ProcStatic.DataReaderConvert(sqlReader, "middle_name", String.Empty);
                            mRelationship.MemberInRelationshipWith.BirthDate = ProcStatic.DataReaderConvert(sqlReader,
                                "birthdate", DateTime.MinValue).ToString();
                            mRelationship.MemberInRelationshipWith.PresentAddress = ProcStatic.DataReaderConvert(sqlReader, "present_address", String.Empty);
                            mRelationship.MemberInRelationshipWith.PresentPhoneNos = ProcStatic.DataReaderConvert(sqlReader, "present_phone_nos", String.Empty);

                            mRelationship.MemberInRelationshipWith.LifeStatusCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_reference_id", String.Empty);
                            mRelationship.MemberInRelationshipWith.LifeStatusCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_entity_id", String.Empty);
                            mRelationship.MemberInRelationshipWith.LifeStatusCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_reference_code", String.Empty);
                            mRelationship.MemberInRelationshipWith.LifeStatusCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_description", String.Empty);

                            mRelationship.MemberInRelationshipWith.GenderCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_reference_id", String.Empty);
                            mRelationship.MemberInRelationshipWith.GenderCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_entity_id", String.Empty);
                            mRelationship.MemberInRelationshipWith.GenderCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_reference_code", String.Empty);
                            mRelationship.MemberInRelationshipWith.GenderCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_description", String.Empty);

                            mRelationship.RelationshipId = ProcStatic.DataReaderConvert(sqlReader, "relationship_id", Int64.Parse("0"));

                            mRelationship.RelationshipTypeInfo.RelationshipTypeId = ProcStatic.DataReaderConvert(sqlReader,
                                "relationship_type_id", String.Empty);
                            mRelationship.RelationshipTypeInfo.RelationshipDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "relationship_description", String.Empty);
                            mRelationship.RelationshipTypeInfo.IsParent = ProcStatic.DataReaderConvert(sqlReader, "is_parent", false);
                            mRelationship.RelationshipTypeInfo.IsSpouse = ProcStatic.DataReaderConvert(sqlReader, "is_spouse", false);
                            mRelationship.RelationshipTypeInfo.IsSibling = ProcStatic.DataReaderConvert(sqlReader, "is_sibling", false);
                            mRelationship.RelationshipTypeInfo.IsInLaw = ProcStatic.DataReaderConvert(sqlReader, "is_in_law", false);
                            mRelationship.RelationshipTypeInfo.IsBloodLine = ProcStatic.DataReaderConvert(sqlReader, "is_blood_line", false);
                            mRelationship.RelationshipTypeInfo.IsFriend = ProcStatic.DataReaderConvert(sqlReader, "is_friend", false);

                            memberInfo.MemberRelationshipList.Add(mRelationship);

                        }
                    }

                    sqlReader.Close();
                }
            }

            //get the member other creditor information
            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectBySysIDMemberOtherCreditorInformation";

                sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = memberInfo.MemberSysId;

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            CommonExchange.OtherCreditor oCreditor = new CommonExchange.OtherCreditor();

                            oCreditor.OtherCreditorId = ProcStatic.DataReaderConvert(sqlReader, "other_creditor_id", Int64.Parse("0"));
		                    oCreditor.CreditorName = ProcStatic.DataReaderConvert(sqlReader, "creditor_name", String.Empty);
		                    oCreditor.DateDue = ProcStatic.DataReaderConvert(sqlReader, "date_due", DateTime.MinValue).ToString();
		                    oCreditor.AmountOwned = ProcStatic.DataReaderConvert(sqlReader, "amount_owned", Decimal.Parse("0.0"));
		                    oCreditor.AmortizationAmount = ProcStatic.DataReaderConvert(sqlReader, "amortization_amount", Decimal.Parse("0.0"));
		                    oCreditor.Remarks = ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);
			
			                oCreditor.RepaymentScheduleInfo.RepaymentId = ProcStatic.DataReaderConvert(sqlReader, "repayment_id", String.Empty);
		                    oCreditor.RepaymentScheduleInfo.RepaymentDescription = ProcStatic.DataReaderConvert(sqlReader, "repayment_description", 
                                String.Empty);
		                    oCreditor.RepaymentScheduleInfo.PaymentsPerYear = ProcStatic.DataReaderConvert(sqlReader, "payments_per_year", Int16.Parse("0"));
                            oCreditor.RepaymentScheduleInfo.RepaymentNo = ProcStatic.DataReaderConvert(sqlReader, "repayment_no", Byte.Parse("0"));

                            memberInfo.OtherCreditorInfoList.Add(oCreditor);

                        }
                    }

                    sqlReader.Close();
                }
            }

            return memberInfo;
        } //-------------------------------------

        //this function returns the collector information details
        private CommonExchange.Collector SelectByEmployeeIDCollectorInformationNoAuthenticate(CommonExchange.SysAccess userInfo, SqlConnection sqlConn,
            String employeeId)
        {
            CommonExchange.Collector collectorInfo = new CommonExchange.Collector();

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectByEmployeeIDCollectorInformation";

                sqlComm.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = employeeId;
                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {

                            collectorInfo.CollectorSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_collector", String.Empty);
		                    collectorInfo.EmployeeId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "employee_id", String.Empty);
		                    collectorInfo.OtherCollectorInformation = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                "other_collector_information", String.Empty);
		                    collectorInfo.IsActive = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active", false);

                            collectorInfo.PersonInfo.PersonSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);

                            break;

                        }
                    }

                    sqlReader.Close();
                }

                if (!String.IsNullOrEmpty(collectorInfo.PersonInfo.PersonSysId))
                {
                    using (RemSrvBaseManager remSrv = new RemSrvBaseManager())
                    {
                        collectorInfo.PersonInfo = remSrv.SelectBySysIDPersonInformationNoAuthenticate(userInfo.UserId, sqlConn,
                            collectorInfo.PersonInfo.PersonSysId);
                    }
                }

            }

            return collectorInfo;
        } //-------------------------------------

        #endregion
    }
}
