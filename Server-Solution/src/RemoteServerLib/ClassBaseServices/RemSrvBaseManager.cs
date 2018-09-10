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
        public void InsertOfficeEmployerInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            if (officeEmployerInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertOfficeEmployerInformation";

                        sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerId =
                            PrimaryKeys.GetNewOfficeEmployerInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@office_employer_name", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerName;
                        sqlComm.Parameters.Add("@office_employer_acronym", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerAcronym;
                        sqlComm.Parameters.Add("@office_employer_address", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerAddress;
                        sqlComm.Parameters.Add("@office_employer_phone_nos", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerPhoneNos;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        //this procedure updates a office information
        public void UpdateOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            if (officeEmployerInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateOfficeEmployerInformation";

                        sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerId;
                        sqlComm.Parameters.Add("@office_employer_name", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerName;
                        sqlComm.Parameters.Add("@office_employer_acronym", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerAcronym;
                        sqlComm.Parameters.Add("@office_employer_address", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerAddress;
                        sqlComm.Parameters.Add("@office_employer_phone_nos", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerPhoneNos;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        //this procedure deletes a office information
        public void DeleteOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            if (officeEmployerInfo.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteOfficeEmployerInformation";

                        sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = officeEmployerInfo.OfficeEmployerId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        //this procedure inserts or updates a person infomation
        public void InsertUpdatePersonInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Person personInfo)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                this.InsertUpdatePersonInformationNoAuthenticate(userInfo, auth.Connection, ref personInfo);
            }

        } //-------------------------------------

        //this procedure inserts or updates a person information
        public void InsertUpdatePersonInformationNoAuthenticate(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, ref CommonExchange.Person personInfo)
        {
            if (personInfo.ObjectState == DataRowState.Added || personInfo.ObjectState == DataRowState.Modified)
            {

                if (String.IsNullOrEmpty(personInfo.PersonSysId) ||
                    (!PrimaryKeys.IsExistsSysIDPersonInformation(userInfo.UserId, sqlConn, personInfo.PersonSysId)))
                {
                    personInfo.PersonSysId = PrimaryKeys.GetNewPersonInformationSystemID(userInfo, sqlConn);
                }

                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = sqlConn;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.InsertUpdatePersonInformation";

                    sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personInfo.PersonSysId;
                    sqlComm.Parameters.Add("@last_name", SqlDbType.VarChar).Value = personInfo.LastName;
                    sqlComm.Parameters.Add("@first_name", SqlDbType.VarChar).Value = personInfo.FirstName;
                    sqlComm.Parameters.Add("@middle_name", SqlDbType.VarChar).Value = personInfo.MiddleName;

                    if (String.IsNullOrEmpty(personInfo.LifeStatusCode.CodeReferenceId))
                    {
                        sqlComm.Parameters.Add("@life_status_code", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@life_status_code", SqlDbType.VarChar).Value = personInfo.LifeStatusCode.CodeReferenceId;
                    }

                    if (String.IsNullOrEmpty(personInfo.GenderCode.CodeReferenceId))
                    {
                        sqlComm.Parameters.Add("@gender_code", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@gender_code", SqlDbType.VarChar).Value = personInfo.GenderCode.CodeReferenceId;
                    }

                    DateTime bDate = DateTime.MinValue;

                    if (DateTime.TryParse(personInfo.BirthDate, out bDate) && DateTime.Compare(bDate, DateTime.MinValue) != 0)
                    {
                        sqlComm.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = bDate;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    sqlComm.Parameters.Add("@place_birth", SqlDbType.VarChar).Value = personInfo.PlaceOfBirth;
                    sqlComm.Parameters.Add("@email_address", SqlDbType.VarChar).Value = personInfo.EMailAddress;
                    sqlComm.Parameters.Add("@present_address", SqlDbType.VarChar).Value = personInfo.PresentAddress;
                    sqlComm.Parameters.Add("@present_phone_nos", SqlDbType.VarChar).Value = personInfo.PresentPhoneNos;
                    sqlComm.Parameters.Add("@home_address", SqlDbType.VarChar).Value = personInfo.HomeAddress;
                    sqlComm.Parameters.Add("@home_phone_nos", SqlDbType.VarChar).Value = personInfo.HomePhoneNos;
                    sqlComm.Parameters.Add("@house_ownership_information", SqlDbType.VarChar).Value = personInfo.HouseOwnershipInformation;
                    sqlComm.Parameters.Add("@citizenship", SqlDbType.VarChar).Value = personInfo.Citizenship;
                    sqlComm.Parameters.Add("@nationality", SqlDbType.VarChar).Value = personInfo.Nationality;
                    sqlComm.Parameters.Add("@religion", SqlDbType.VarChar).Value = personInfo.Religion;
                    sqlComm.Parameters.Add("@educational_attainment", SqlDbType.VarChar).Value = personInfo.EducationalAttainment;
                    sqlComm.Parameters.Add("@special_skills", SqlDbType.VarChar).Value = personInfo.SpecialSkills;

                    if (String.IsNullOrEmpty(personInfo.MaritalStatusCode.CodeReferenceId))
                    {
                        sqlComm.Parameters.Add("@marital_status_code", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@marital_status_code", SqlDbType.VarChar).Value = personInfo.MaritalStatusCode.CodeReferenceId;
                    }

                    DateTime mDate = DateTime.MinValue;

                    if (DateTime.TryParse(personInfo.MarriageDate, out mDate) && DateTime.Compare(mDate, DateTime.MinValue) != 0)
                    {
                        sqlComm.Parameters.Add("@marriage_date", SqlDbType.DateTime).Value = mDate;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@marriage_date", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    sqlComm.Parameters.Add("@no_of_dependents", SqlDbType.TinyInt).Value = personInfo.NoOfDependents;

                    sqlComm.Parameters.Add("@occupation", SqlDbType.VarChar).Value = personInfo.Occupation;

                    if (String.IsNullOrEmpty(personInfo.OfficeEmployerInfo.OfficeEmployerId))
                    {
                        sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = personInfo.OfficeEmployerInfo.OfficeEmployerId;
                    }

                    if (String.IsNullOrEmpty(personInfo.AppointmentStatusCode.CodeReferenceId))
                    {
                        sqlComm.Parameters.Add("@appointment_status_code", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@appointment_status_code", SqlDbType.VarChar).Value = personInfo.AppointmentStatusCode.CodeReferenceId;
                    }

                    DateTime eDate = DateTime.MinValue;

                    if (DateTime.TryParse(personInfo.EmploymentDate, out eDate) && DateTime.Compare(eDate, DateTime.MinValue) != 0)
                    {
                        sqlComm.Parameters.Add("@employment_date", SqlDbType.DateTime).Value = eDate;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@employment_date", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    sqlComm.Parameters.Add("@years_of_service", SqlDbType.TinyInt).Value = personInfo.YearsOfService;
                    sqlComm.Parameters.Add("@salary_income", SqlDbType.Decimal).Value = personInfo.SalaryIncome;
                    sqlComm.Parameters.Add("@other_income_source", SqlDbType.VarChar).Value = personInfo.OtherIncomeSource;
                    sqlComm.Parameters.Add("@total_monthly_expenses", SqlDbType.Decimal).Value = personInfo.TotalMonthlyExpenses;
                    sqlComm.Parameters.Add("@net_disposable_income", SqlDbType.Decimal).Value = personInfo.NetDisposableIncome;

                    sqlComm.Parameters.Add("@other_person_information", SqlDbType.VarChar).Value = personInfo.OtherPersonInformation;

                    sqlComm.Parameters.Add("@for_member", SqlDbType.Bit).Value = personInfo.ForMember;
                    sqlComm.Parameters.Add("@for_collector", SqlDbType.Bit).Value = personInfo.ForCollector;
                    sqlComm.Parameters.Add("@for_login", SqlDbType.Bit).Value = personInfo.ForLogin;

                    sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    sqlComm.ExecuteNonQuery();
                }
            }

            //this procedure insert, updates and deletes a person beneficiary
            this.InsertUpdateDeletePersonBeneficiaryInformation(userInfo, sqlConn, personInfo.PersonSysId, personInfo.PersonBeneficiaryList);
            //-------------------------------------------
            
            //this procedure insert, and deletes a person reference
            this.InsertDeletePersonReferenceInformation(userInfo, sqlConn, personInfo.PersonSysId, personInfo.PersonReferenceList);
            //-------------------------------------------
            
            //this procedure insert, updates and deletes a person spouse
            this.InsertUpdateDeletePersonSpouseInformation(userInfo, sqlConn, personInfo.PersonSysId, personInfo.PersonSpouseList);
            //----------------------------------------            

        } //-------------------------------------------

        //this procedure inserts, update or delete a person document
        public void InsertUpdateDeletePersonDocument(CommonExchange.SysAccess userInfo, DataTable personDocumentTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertPersonDocument";

                    insertComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).SourceColumn = "sysid_person";
                    insertComm.Parameters.Add("@file_data", SqlDbType.VarBinary).SourceColumn = "file_data";
                    insertComm.Parameters.Add("@original_name", SqlDbType.VarChar).SourceColumn = "original_name";
                    insertComm.Parameters.Add("@document_information", SqlDbType.VarChar).SourceColumn = "document_information";
                    insertComm.Parameters.Add("@is_primary_image", SqlDbType.Bit).SourceColumn = "is_primary_image";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand updateComm = new SqlCommand())
                    {

                        updateComm.Connection = auth.Connection;
                        updateComm.CommandType = CommandType.StoredProcedure;
                        updateComm.CommandText = "lms.UpdatePersonDocument";

                        updateComm.Parameters.Add("@document_id", SqlDbType.BigInt).SourceColumn = "document_id";
                        updateComm.Parameters.Add("@file_data", SqlDbType.VarBinary).SourceColumn = "file_data";
                        updateComm.Parameters.Add("@original_name", SqlDbType.VarChar).SourceColumn = "original_name";
                        updateComm.Parameters.Add("@document_information", SqlDbType.VarChar).SourceColumn = "document_information";
                        updateComm.Parameters.Add("@is_primary_image", SqlDbType.Bit).SourceColumn = "is_primary_image";

                        updateComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        updateComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        using (SqlCommand deleteComm = new SqlCommand())
                        {
                            deleteComm.Connection = auth.Connection;
                            deleteComm.CommandType = CommandType.StoredProcedure;
                            deleteComm.CommandText = "lms.DeletePersonDocument";

                            deleteComm.Parameters.Add("@document_id", SqlDbType.BigInt).SourceColumn = "document_id";

                            deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                            {
                                sqlAdapter.InsertCommand = insertComm;
                                sqlAdapter.UpdateCommand = updateComm;
                                sqlAdapter.DeleteCommand = deleteComm;

                                sqlAdapter.Update(personDocumentTable);
                            }
                        }
                    }
                }
            }
        } //----------------------------------


        /// <summary>
        /// this procedure insert, update, and delete a person beneficiary
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="personSysId"></param>
        /// <param name="personBeneficiaryList"></param>
        private void InsertUpdateDeletePersonBeneficiaryInformation(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String personSysId,
            List<CommonExchange.PersonBeneficiary> personBeneficiaryList)
        {
            //checks if there is a person beneficiaries that will be deleted
            foreach (CommonExchange.PersonBeneficiary pBeneficiary in personBeneficiaryList)
            {
                if (pBeneficiary.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeletePersonBeneficiaryInformation";

                        sqlComm.Parameters.Add("@beneficiary_id", SqlDbType.BigInt).Value = pBeneficiary.BeneficiaryId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

            foreach (CommonExchange.PersonBeneficiary pBeneficiary in personBeneficiaryList)
            {
                if (pBeneficiary.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertPersonBeneficiaryInformation";

                        sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;
                        sqlComm.Parameters.Add("@in_relationship_with_sysid_person", SqlDbType.VarChar).Value = pBeneficiary.PersonInRelationshipWith.PersonSysId;
                        sqlComm.Parameters.Add("@relationship_type_id", SqlDbType.VarChar).Value = pBeneficiary.RelationshipTypeInfo.RelationshipTypeId;
                        sqlComm.Parameters.Add("@is_primary_beneficiary", SqlDbType.Bit).Value = pBeneficiary.IsPrimaryBeneficiary;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (pBeneficiary.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdatePersonBeneficiaryInformation";

                        sqlComm.Parameters.Add("@beneficiary_id", SqlDbType.BigInt).Value = pBeneficiary.BeneficiaryId;
                        sqlComm.Parameters.Add("@relationship_type_id", SqlDbType.VarChar).Value = pBeneficiary.RelationshipTypeInfo.RelationshipTypeId;
                        sqlComm.Parameters.Add("@is_primary_beneficiary", SqlDbType.Bit).Value = pBeneficiary.IsPrimaryBeneficiary;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        } //-----------------------------------------------

        /// <summary>
        /// this procedure insert, and deletes a person reference
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="personSysId"></param>
        /// <param name="personReferenceList"></param>
        private void InsertDeletePersonReferenceInformation(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String personSysId,
            List<CommonExchange.PersonReference> personReferenceList)
        {
            //checks if there is a person reference that will be deleted
            foreach (CommonExchange.PersonReference pReference in personReferenceList)
            {
                if (pReference.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeletePersonReferenceInformation";

                        sqlComm.Parameters.Add("@reference_id", SqlDbType.BigInt).Value = pReference.ReferenceId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

            foreach (CommonExchange.PersonReference pReference in personReferenceList)
            {
                if (pReference.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertPersonReferenceInformation";

                        sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;
                        sqlComm.Parameters.Add("@in_reference_with_sysid_person", SqlDbType.VarChar).Value = pReference.PersonInReferenceWith.PersonSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        } //-------------------------------------

        /// <summary>
        /// this procedure insert, update and delete a person spouse
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="personSysId"></param>
        /// <param name="personSpouseList"></param>
        private void InsertUpdateDeletePersonSpouseInformation(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String personSysId,
            List<CommonExchange.PersonSpouse> personSpouseList)
        {
            //checks if there is a person spouse that will be deleted
            foreach (CommonExchange.PersonSpouse pSpouse in personSpouseList)
            {
                if (pSpouse.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeletePersonSpouseInformation";

                        sqlComm.Parameters.Add("@spouse_id", SqlDbType.BigInt).Value = pSpouse.SpouseId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

            foreach (CommonExchange.PersonSpouse pSpouse in personSpouseList)
            {
                if (pSpouse.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertPersonSpouseInformation";

                        sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;
                        sqlComm.Parameters.Add("@in_spouse_with_sysid_person", SqlDbType.VarChar).Value = pSpouse.PersonInSpouseWith.PersonSysId;
                        sqlComm.Parameters.Add("@relationship_type_id", SqlDbType.VarChar).Value = pSpouse.RelationshipTypeInfo.RelationshipTypeId;
                        sqlComm.Parameters.Add("@is_still_a_spouse", SqlDbType.Bit).Value = pSpouse.IsStillASpouse;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (pSpouse.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdatePersonSpouseInformation";

                        sqlComm.Parameters.Add("@spouse_id", SqlDbType.BigInt).Value = pSpouse.SpouseId;
                        sqlComm.Parameters.Add("@relationship_type_id", SqlDbType.VarChar).Value = pSpouse.RelationshipTypeInfo.RelationshipTypeId;
                        sqlComm.Parameters.Add("@is_still_a_spouse", SqlDbType.Bit).Value = pSpouse.IsStillASpouse;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        } //---------------------------------------
       
        #endregion

        #region Programmer-Defined Function Procedures

        //this function gets the office information table query
        public DataTable SelectOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String queryString, Boolean includeMarkedDeleted)
        {
            DataTable dbTable = new DataTable("OfficeEmployerInformationTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectOfficeEmployerInformation";

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

        //this function gets the person information table query
        public DataTable SelectPersonInformation(CommonExchange.SysAccess userInfo, String queryString,
            String lastName, String firstName, String personSysIdExcludeList)
        {
            DataTable dbTable = new DataTable("PersonInformationTable");
            dbTable.Columns.Add("sysid_person", System.Type.GetType("System.String"));
			dbTable.Columns.Add("last_name", System.Type.GetType("System.String"));
			dbTable.Columns.Add("first_name", System.Type.GetType("System.String"));
			dbTable.Columns.Add("middle_name", System.Type.GetType("System.String"));
			dbTable.Columns.Add("birthdate", System.Type.GetType("System.String"));
			dbTable.Columns.Add("present_address", System.Type.GetType("System.String"));
			dbTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
			dbTable.Columns.Add("life_status_code_code_reference_id", System.Type.GetType("System.String"));
			dbTable.Columns.Add("life_status_code_code_entity_id", System.Type.GetType("System.String"));
			dbTable.Columns.Add("life_status_code_reference_code", System.Type.GetType("System.String"));
			dbTable.Columns.Add("life_status_code_code_description", System.Type.GetType("System.String"));
			dbTable.Columns.Add("gender_code_code_reference_id", System.Type.GetType("System.String"));
			dbTable.Columns.Add("gender_code_code_entity_id", System.Type.GetType("System.String"));
			dbTable.Columns.Add("gender_code_reference_code", System.Type.GetType("System.String"));
            dbTable.Columns.Add("gender_code_code_description", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectPersonInformation";

                    if (String.IsNullOrEmpty(queryString))
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@query_string", SqlDbType.VarChar).Value = queryString;
                    }

                    if (String.IsNullOrEmpty(lastName))
                    {
                        sqlComm.Parameters.Add("@last_name", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@last_name", SqlDbType.VarChar).Value = lastName;
                    }

                    if (String.IsNullOrEmpty(firstName))
                    {
                        sqlComm.Parameters.Add("@first_name", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@first_name", SqlDbType.VarChar).Value = firstName;
                    }                    

                    if (String.IsNullOrEmpty(personSysIdExcludeList))
                    {
                        sqlComm.Parameters.Add("@sysid_person_exclude_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_person_exclude_list", SqlDbType.NVarChar).Value = personSysIdExcludeList;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["sysid_person"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);
                                newRow["last_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "last_name", String.Empty);
                                newRow["first_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "first_name", String.Empty);
                                newRow["middle_name"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "middle_name", String.Empty);
                                newRow["birthdate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "birthdate",
                                    DateTime.MinValue).ToString();
                                newRow["present_address"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "present_address", String.Empty);
                                newRow["present_phone_nos"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "present_phone_nos", String.Empty);
                                newRow["life_status_code_code_reference_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "life_status_code_code_reference_id", String.Empty);
                                newRow["life_status_code_code_entity_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "life_status_code_code_entity_id", String.Empty);
                                newRow["life_status_code_reference_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "life_status_code_reference_code", String.Empty);
                                newRow["life_status_code_code_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "life_status_code_code_description", String.Empty);
                                newRow["gender_code_code_reference_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "gender_code_code_reference_id", String.Empty);
                                newRow["gender_code_code_entity_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "gender_code_code_entity_id", String.Empty);
                                newRow["gender_code_reference_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "gender_code_reference_code", String.Empty);
                                newRow["gender_code_code_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "gender_code_code_description", String.Empty);

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

        //this function returns the person information details
        public CommonExchange.Person SelectBySysIDPersonInformation(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Person personInfo = new CommonExchange.Person();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                personInfo = this.SelectBySysIDPersonInformationNoAuthenticate(userInfo.UserId, auth.Connection, personSysId);
            }

            return personInfo;
        } //------------------------------------

        //this function returns the person information details
        public CommonExchange.Person SelectBySysIDPersonInformationNoAuthenticate(String userId, SqlConnection sqlConn, String personSysId)
        {
            CommonExchange.Person personInfo = new CommonExchange.Person();

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectBySysIDPersonInformation";

                sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            personInfo.PersonSysId = ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);
                            personInfo.LastName = ProcStatic.DataReaderConvert(sqlReader, "last_name", String.Empty);
                            personInfo.FirstName = ProcStatic.DataReaderConvert(sqlReader, "first_name", String.Empty);
                            personInfo.MiddleName = ProcStatic.DataReaderConvert(sqlReader, "middle_name", String.Empty);
	                        personInfo.BirthDate = ProcStatic.DataReaderConvert(sqlReader, "birthdate", DateTime.MinValue).ToString();
                            personInfo.PlaceOfBirth = ProcStatic.DataReaderConvert(sqlReader, "place_birth", String.Empty);
                            personInfo.EMailAddress = ProcStatic.DataReaderConvert(sqlReader, "email_address", String.Empty);
                            personInfo.PresentAddress = ProcStatic.DataReaderConvert(sqlReader, "present_address", String.Empty);
                            personInfo.PresentPhoneNos = ProcStatic.DataReaderConvert(sqlReader, "present_phone_nos", String.Empty);
                            personInfo.HomeAddress = ProcStatic.DataReaderConvert(sqlReader, "home_address", String.Empty);
                            personInfo.HomePhoneNos = ProcStatic.DataReaderConvert(sqlReader, "home_phone_nos", String.Empty);
                            personInfo.HouseOwnershipInformation = ProcStatic.DataReaderConvert(sqlReader, "house_ownership_information", String.Empty);
                            personInfo.Citizenship = ProcStatic.DataReaderConvert(sqlReader, "citizenship", String.Empty);
                            personInfo.Nationality = ProcStatic.DataReaderConvert(sqlReader, "nationality", String.Empty);
                            personInfo.Religion = ProcStatic.DataReaderConvert(sqlReader, "religion", String.Empty);
                            personInfo.EducationalAttainment = ProcStatic.DataReaderConvert(sqlReader, "educational_attainment", String.Empty);
                            personInfo.SpecialSkills = ProcStatic.DataReaderConvert(sqlReader, "special_skills", String.Empty);

		                    personInfo.MarriageDate = ProcStatic.DataReaderConvert(sqlReader, "marriage_date", DateTime.MinValue).ToString();
                            personInfo.NoOfDependents = ProcStatic.DataReaderConvert(sqlReader, "no_of_dependents", Byte.Parse("0"));

                            personInfo.Occupation = ProcStatic.DataReaderConvert(sqlReader, "occupation", String.Empty);
                            personInfo.EmploymentDate = ProcStatic.DataReaderConvert(sqlReader, "employment_date", DateTime.MinValue).ToString();
                            personInfo.YearsOfService = ProcStatic.DataReaderConvert(sqlReader, "years_of_service", Byte.Parse("0"));
                            personInfo.SalaryIncome = ProcStatic.DataReaderConvert(sqlReader, "salary_income", Decimal.Parse("0"));
                            personInfo.OtherIncomeSource = ProcStatic.DataReaderConvert(sqlReader, "other_income_source", String.Empty);
                            personInfo.TotalMonthlyExpenses = ProcStatic.DataReaderConvert(sqlReader, "total_monthly_expenses", Decimal.Parse("0"));
                            personInfo.NetDisposableIncome = ProcStatic.DataReaderConvert(sqlReader, "net_disposable_income", Decimal.Parse("0"));

                            personInfo.OtherPersonInformation = ProcStatic.DataReaderConvert(sqlReader, "other_person_information", String.Empty);

                            personInfo.LifeStatusCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader, "life_status_code_code_reference_id", String.Empty);
                            personInfo.LifeStatusCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader, "life_status_code_code_entity_id", String.Empty);
                            personInfo.LifeStatusCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader, "life_status_code_reference_code", String.Empty);
                            personInfo.LifeStatusCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader, "life_status_code_code_description", String.Empty);

                            personInfo.GenderCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader, "gender_code_code_reference_id", String.Empty);
                            personInfo.GenderCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader, "gender_code_code_entity_id", String.Empty);
                            personInfo.GenderCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader, "gender_code_reference_code", String.Empty);
                            personInfo.GenderCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader, "gender_code_code_description", String.Empty);

                            personInfo.MaritalStatusCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader, "marital_status_code_code_reference_id", 
                                String.Empty);
                            personInfo.MaritalStatusCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader, "marital_status_code_code_entity_id", String.Empty);
                            personInfo.MaritalStatusCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader, "marital_status_code_reference_code", 
                                String.Empty);
                            personInfo.MaritalStatusCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader, "marital_status_code_code_description", 
                                String.Empty);

                            personInfo.OfficeEmployerInfo.OfficeEmployerId = ProcStatic.DataReaderConvert(sqlReader, "office_employer_id", String.Empty);
		                    personInfo.OfficeEmployerInfo.OfficeEmployerName = ProcStatic.DataReaderConvert(sqlReader, "office_employer_name", String.Empty);
		                    personInfo.OfficeEmployerInfo.OfficeEmployerAcronym = ProcStatic.DataReaderConvert(sqlReader, "office_employer_acronym", String.Empty);
	                        personInfo.OfficeEmployerInfo.OfficeEmployerAddress = ProcStatic.DataReaderConvert(sqlReader, "office_employer_address", String.Empty);
                            personInfo.OfficeEmployerInfo.OfficeEmployerPhoneNos = ProcStatic.DataReaderConvert(sqlReader, 
                                "office_employer_phone_nos", String.Empty);

                            personInfo.AppointmentStatusCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader, 
                                "appointment_status_code_code_reference_id", String.Empty);
		                    personInfo.AppointmentStatusCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader, 
                                "appointment_status_code_code_entity_id", String.Empty);
		                    personInfo.AppointmentStatusCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader, 
                                "appointment_status_code_reference_code", String.Empty);
                            personInfo.AppointmentStatusCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "appointment_status_code_code_description", String.Empty);

                            personInfo.ForLogin = personInfo.ForMember = personInfo.ForCollector = false;

                            break;

                        }
                    }

                    sqlReader.Close();
                }
            }

            //get the person in beneficiary
            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectBySysIDPersonBeneficiaryInformation";

                sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            CommonExchange.PersonBeneficiary pBeneficiary = new CommonExchange.PersonBeneficiary();

                            pBeneficiary.PersonInRelationshipWith.PersonSysId = ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.LastName = ProcStatic.DataReaderConvert(sqlReader, "last_name", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.FirstName = ProcStatic.DataReaderConvert(sqlReader, "first_name", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.MiddleName = ProcStatic.DataReaderConvert(sqlReader, "middle_name", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.BirthDate = ProcStatic.DataReaderConvert(sqlReader, "birthdate", DateTime.MinValue).ToString();
                            pBeneficiary.PersonInRelationshipWith.PresentAddress = ProcStatic.DataReaderConvert(sqlReader, "present_address", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.PresentPhoneNos = ProcStatic.DataReaderConvert(sqlReader, "present_phone_nos", String.Empty);

                            pBeneficiary.PersonInRelationshipWith.LifeStatusCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader, 
                                "life_status_code_code_reference_id", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.LifeStatusCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader, 
                                "life_status_code_code_entity_id", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.LifeStatusCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_reference_code", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.LifeStatusCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_description", String.Empty);

                            pBeneficiary.PersonInRelationshipWith.GenderCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_reference_id", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.GenderCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader, 
                                "gender_code_code_entity_id", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.GenderCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader, 
                                "gender_code_reference_code", String.Empty);
                            pBeneficiary.PersonInRelationshipWith.GenderCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader, 
                                "gender_code_code_description", String.Empty);

                            pBeneficiary.BeneficiaryId = ProcStatic.DataReaderConvert(sqlReader, "beneficiary_id", Int64.Parse("0"));
                            pBeneficiary.IsPrimaryBeneficiary = ProcStatic.DataReaderConvert(sqlReader, "is_primary_beneficiary", false);

                            pBeneficiary.RelationshipTypeInfo.RelationshipTypeId = ProcStatic.DataReaderConvert(sqlReader, "relationship_type_id", String.Empty);
		                    pBeneficiary.RelationshipTypeInfo.RelationshipDescription = ProcStatic.DataReaderConvert(sqlReader, 
                                "relationship_description", String.Empty);
		                    pBeneficiary.RelationshipTypeInfo.IsParent = ProcStatic.DataReaderConvert(sqlReader, "is_parent", false);
		                    pBeneficiary.RelationshipTypeInfo.IsSpouse = ProcStatic.DataReaderConvert(sqlReader, "is_spouse", false);
		                    pBeneficiary.RelationshipTypeInfo.IsSibling = ProcStatic.DataReaderConvert(sqlReader, "is_sibling", false);
		                    pBeneficiary.RelationshipTypeInfo.IsInLaw = ProcStatic.DataReaderConvert(sqlReader, "is_in_law", false);
	                        pBeneficiary.RelationshipTypeInfo.IsBloodLine = ProcStatic.DataReaderConvert(sqlReader, "is_blood_line", false);
                            pBeneficiary.RelationshipTypeInfo.IsFriend = ProcStatic.DataReaderConvert(sqlReader, "is_friend", false);

                            personInfo.PersonBeneficiaryList.Add(pBeneficiary);

                        }
                    }

                    sqlReader.Close();
                }
            }

            //get the person in reference
            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectBySysIDPersonReferenceInformation";

                sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            CommonExchange.PersonReference pReference = new CommonExchange.PersonReference();

                            pReference.ReferenceId = ProcStatic.DataReaderConvert(sqlReader, "reference_id", Int64.Parse("0"));

                            pReference.PersonInReferenceWith.PersonSysId = ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);
                            pReference.PersonInReferenceWith.LastName = ProcStatic.DataReaderConvert(sqlReader, "last_name", String.Empty);
                            pReference.PersonInReferenceWith.FirstName = ProcStatic.DataReaderConvert(sqlReader, "first_name", String.Empty);
                            pReference.PersonInReferenceWith.MiddleName = ProcStatic.DataReaderConvert(sqlReader, "middle_name", String.Empty);
                            pReference.PersonInReferenceWith.BirthDate = ProcStatic.DataReaderConvert(sqlReader, "birthdate", DateTime.MinValue).ToString();
                            pReference.PersonInReferenceWith.PresentAddress = ProcStatic.DataReaderConvert(sqlReader, "present_address", String.Empty);
                            pReference.PersonInReferenceWith.PresentPhoneNos = ProcStatic.DataReaderConvert(sqlReader, "present_phone_nos", String.Empty);

                            pReference.PersonInReferenceWith.LifeStatusCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_reference_id", String.Empty);
                            pReference.PersonInReferenceWith.LifeStatusCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_entity_id", String.Empty);
                            pReference.PersonInReferenceWith.LifeStatusCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_reference_code", String.Empty);
                            pReference.PersonInReferenceWith.LifeStatusCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_description", String.Empty);

                            pReference.PersonInReferenceWith.GenderCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_reference_id", String.Empty);
                            pReference.PersonInReferenceWith.GenderCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_entity_id", String.Empty);
                            pReference.PersonInReferenceWith.GenderCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_reference_code", String.Empty);
                            pReference.PersonInReferenceWith.GenderCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_description", String.Empty);

                            personInfo.PersonReferenceList.Add(pReference);

                        }
                    }

                    sqlReader.Close();
                }
            }

            //get the person in spouse
            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.SelectBySysIDPersonSpouseInformation";

                sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userId;

                using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                {
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            CommonExchange.PersonSpouse pSpouse = new CommonExchange.PersonSpouse();

                            pSpouse.PersonInSpouseWith.PersonSysId = ProcStatic.DataReaderConvert(sqlReader, "sysid_person", String.Empty);
                            pSpouse.PersonInSpouseWith.LastName = ProcStatic.DataReaderConvert(sqlReader, "last_name", String.Empty);
                            pSpouse.PersonInSpouseWith.FirstName = ProcStatic.DataReaderConvert(sqlReader, "first_name", String.Empty);
                            pSpouse.PersonInSpouseWith.MiddleName = ProcStatic.DataReaderConvert(sqlReader, "middle_name", String.Empty);
                            pSpouse.PersonInSpouseWith.BirthDate = ProcStatic.DataReaderConvert(sqlReader, "birthdate", DateTime.MinValue).ToString();
                            pSpouse.PersonInSpouseWith.PresentAddress = ProcStatic.DataReaderConvert(sqlReader, "present_address", String.Empty);
                            pSpouse.PersonInSpouseWith.PresentPhoneNos = ProcStatic.DataReaderConvert(sqlReader, "present_phone_nos", String.Empty);

                            pSpouse.PersonInSpouseWith.LifeStatusCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_reference_id", String.Empty);
                            pSpouse.PersonInSpouseWith.LifeStatusCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_entity_id", String.Empty);
                            pSpouse.PersonInSpouseWith.LifeStatusCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_reference_code", String.Empty);
                            pSpouse.PersonInSpouseWith.LifeStatusCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "life_status_code_code_description", String.Empty);

                            pSpouse.PersonInSpouseWith.GenderCode.CodeReferenceId = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_reference_id", String.Empty);
                            pSpouse.PersonInSpouseWith.GenderCode.CodeEntityId = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_entity_id", String.Empty);
                            pSpouse.PersonInSpouseWith.GenderCode.ReferenceCode = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_reference_code", String.Empty);
                            pSpouse.PersonInSpouseWith.GenderCode.CodeDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "gender_code_code_description", String.Empty);

                            pSpouse.SpouseId = ProcStatic.DataReaderConvert(sqlReader, "spouse_id", Int64.Parse("0"));
                            pSpouse.IsStillASpouse = ProcStatic.DataReaderConvert(sqlReader, "is_still_a_spouse", false);

                            pSpouse.RelationshipTypeInfo.RelationshipTypeId = ProcStatic.DataReaderConvert(sqlReader, "relationship_type_id", String.Empty);
                            pSpouse.RelationshipTypeInfo.RelationshipDescription = ProcStatic.DataReaderConvert(sqlReader,
                                "relationship_description", String.Empty);
                            pSpouse.RelationshipTypeInfo.IsParent = ProcStatic.DataReaderConvert(sqlReader, "is_parent", false);
                            pSpouse.RelationshipTypeInfo.IsSpouse = ProcStatic.DataReaderConvert(sqlReader, "is_spouse", false);
                            pSpouse.RelationshipTypeInfo.IsSibling = ProcStatic.DataReaderConvert(sqlReader, "is_sibling", false);
                            pSpouse.RelationshipTypeInfo.IsInLaw = ProcStatic.DataReaderConvert(sqlReader, "is_in_law", false);
                            pSpouse.RelationshipTypeInfo.IsBloodLine = ProcStatic.DataReaderConvert(sqlReader, "is_blood_line", false);
                            pSpouse.RelationshipTypeInfo.IsFriend = ProcStatic.DataReaderConvert(sqlReader, "is_friend", false);

                            personInfo.PersonSpouseList.Add(pSpouse);

                        }
                    }

                    sqlReader.Close();
                }
            }

            return personInfo;
        } //------------------------------------

        //this function gets the person information documents by sysid_person list
        public DataTable SelectBySysIDPersonListPersonDocument(CommonExchange.SysAccess userInfo, String personSysIdList, 
            Boolean isPrimaryImage)
        {
            DataTable dbTable = new DataTable("PersonDocumentsTable");
            dbTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("sysid_person", System.Type.GetType("System.String"));
            dbTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            dbTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("document_information", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_primary_image", System.Type.GetType("System.Boolean"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDPersonListPersonDocument";

                    sqlComm.Parameters.Add("@sysid_person_list", SqlDbType.NVarChar).Value = personSysIdList;
                    sqlComm.Parameters.Add("@is_primary_image", SqlDbType.Bit).Value = isPrimaryImage;
                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader(CommandBehavior.SequentialAccess))
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                DataRow newRow = dbTable.NewRow();

                                newRow["document_id"] = sqlReader["document_id"];
                                newRow["sysid_person"] = sqlReader["sysid_person"];
                                newRow["file_data"] = sqlReader["file_data"];
                                newRow["original_name"] = sqlReader["original_name"];
                                newRow["document_information"] = sqlReader["document_information"];
                                newRow["is_primary_image"] = sqlReader["is_primary_image"];

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

        //this function return the server date
        public String GetServerDateTime(CommonExchange.SysAccess userInfo)
        {
            String serverTime;
            
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                serverTime = this.GetServerDateTimeNoAuthenticate(auth.Connection);
            }

            return serverTime;
                        
        } //--------------------------

        //this function return the server date
        public String GetServerDateTimeNoAuthenticate(SqlConnection sqlConn)
        {
            DateTime serverTime;

            using (SqlCommand sqlComm = new SqlCommand())
            {
                sqlComm.Connection = sqlConn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "lms.GetServerDateTime";

                serverTime = ((DateTime)sqlComm.ExecuteScalar());
            }

            return serverTime.ToString("o");

        } //--------------------------

        //this function is used to determine if the office name exists
        public Boolean IsExistsNameOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerName)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsNameOfficeEmployerInformation";

                    sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = officeEmployerId;
                    sqlComm.Parameters.Add("@office_employer_name", SqlDbType.VarChar).Value = officeEmployerName;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;
        } //-----------------------------   

        //this function is used to determine if the office acronym exists
        public Boolean IsExistsAcronymOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerAcronym)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsAcronymOfficeEmployerInformation";

                    sqlComm.Parameters.Add("@office_employer_id", SqlDbType.VarChar).Value = officeEmployerId;
                    sqlComm.Parameters.Add("@office_employer_acronym", SqlDbType.VarChar).Value = officeEmployerAcronym;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;
        } //-----------------------------   

        //this function determines if the person is a member or a collector
        public Boolean IsExistsSysIDPersonMemberCollectorInformation(CommonExchange.SysAccess userInfo, String personSysId, ref Boolean isCollector)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsSysIDPersonMemberCollectorInformation";

                    sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }

                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsSysIDPersonCollectorInformation";

                    sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isCollector = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;

        } //------------------------------

        //this function determines if the person document original name already exists
        public Boolean IsExistsSysIDPersonOriginalNamePersonDocument(CommonExchange.SysAccess userInfo, Int64 documentId, String personSysId, 
            String originalName)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsSysIDPersonOriginalNamePersonDocument";

                    sqlComm.Parameters.Add("@document_id", SqlDbType.BigInt).Value = documentId;
                    sqlComm.Parameters.Add("@sysid_person", SqlDbType.VarChar).Value = personSysId;
                    sqlComm.Parameters.Add("@original_name", SqlDbType.VarChar).Value = originalName;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;

        } //------------------------------

        //this function is used to get data tables stored in one dataset used for base services
        public DataSet GetDataSetForBaseManager(CommonExchange.SysAccess userInfo)
        {
            DataSet dbSet = new DataSet();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                //gets the code reference table
                dbSet.Tables.Add(ProcStatic.GetCodeReferenceTable(auth.Connection, userInfo.UserId));
                //-----------------------------

                //gets the relationship type table
                dbSet.Tables.Add(ProcStatic.GetRelationshipTypeTable(auth.Connection, userInfo.UserId));
                //-------------------------------------
            }

            return dbSet;
        } //----------------------------------

        #endregion
    }
}
