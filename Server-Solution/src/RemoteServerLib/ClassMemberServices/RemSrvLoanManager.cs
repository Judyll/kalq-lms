using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteServerLib
{
    public class RemSrvLoanManager : MarshalByRefObject, IDisposable
    {
        #region Class Constructor and Destructor
        public RemSrvLoanManager() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure adds a new regular loan information
        public void InsertRegularLoanInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.RegularLoan regularLoanInfo)
        {
            if (regularLoanInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertRegularLoanInformation";

                        sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanInfo.RegularLoanSysId = 
                            PrimaryKeys.GetNewRegularLoanInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = regularLoanInfo.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@account_no", SqlDbType.VarChar).Value = regularLoanInfo.AccountNo;
                        sqlComm.Parameters.Add("@loan_amount", SqlDbType.Decimal).Value = regularLoanInfo.LoanAmount;
                        sqlComm.Parameters.Add("@purpose_of_loan", SqlDbType.VarChar).Value = regularLoanInfo.PurposeOfLoan;
                        sqlComm.Parameters.Add("@is_productive", SqlDbType.Bit).Value = regularLoanInfo.IsProductive;
                        sqlComm.Parameters.Add("@regular_loan_type_id", SqlDbType.VarChar).Value = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId;
                        sqlComm.Parameters.Add("@repayment_id", SqlDbType.VarChar).Value = regularLoanInfo.RepaymentScheduleInfo.RepaymentId;
                        sqlComm.Parameters.Add("@loan_terms", SqlDbType.SmallInt).Value = regularLoanInfo.LoanTerms;
                        sqlComm.Parameters.Add("@no_prepaid_interest", SqlDbType.SmallInt).Value = regularLoanInfo.NoPrepaidInterest;
                        sqlComm.Parameters.Add("@interest_rate", SqlDbType.Float).Value = regularLoanInfo.InterestRate;
                        sqlComm.Parameters.Add("@grace_period", SqlDbType.TinyInt).Value = regularLoanInfo.GracePeriod;
                        sqlComm.Parameters.Add("@is_straight_loan", SqlDbType.Bit).Value = regularLoanInfo.IsStraightLoan;
                        sqlComm.Parameters.Add("@loan_requirements", SqlDbType.VarChar).Value = regularLoanInfo.LoanRequirements;
                        sqlComm.Parameters.Add("@date_applied", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateApplied);
                        sqlComm.Parameters.Add("@date_approved", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateApproved);
                        sqlComm.Parameters.Add("@approval_evaluation", SqlDbType.VarChar).Value = regularLoanInfo.ApprovalEvaluation;
                        sqlComm.Parameters.Add("@date_first_payment", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateFirstPayment);
                        sqlComm.Parameters.Add("@date_maturity", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateMaturity);
                        sqlComm.Parameters.Add("@penalty_rate", SqlDbType.Float).Value = regularLoanInfo.PenaltyRate;
                        sqlComm.Parameters.Add("@no_default_payment", SqlDbType.TinyInt).Value = regularLoanInfo.NoDefaultPayment;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = regularLoanInfo.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update and delete a regular loan amortization
                    this.InsertUpdateDeleteRegularLoanAmortization(userInfo, auth.Connection, regularLoanInfo.RegularLoanSysId, 
                        regularLoanInfo.LoanAmortizationList);
                    //---------------------------------------------------

                    //insert, update and delete a regular loan charges
                    this.InsertUpdateDeleteRegularLoanCharges(userInfo, auth.Connection, regularLoanInfo.RegularLoanSysId,
                        regularLoanInfo.LoanChargesList);
                    //-------------------------------------------

                    //insert, update and delete a regular loan additions
                    this.InsertUpdateDeleteRegularLoanAdditions(userInfo, auth.Connection, regularLoanInfo.RegularLoanSysId,
                        regularLoanInfo.LoanAdditionsList);
                    //--------------------------------------------
                }
            }

        } //--------------------------------

        //this procedure update a regular loan information
        public void UpdateRegularLoanInformation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo)
        {
            if (regularLoanInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateRegularLoanInformation";

                        sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanInfo.RegularLoanSysId;
                        sqlComm.Parameters.Add("@account_no", SqlDbType.VarChar).Value = regularLoanInfo.AccountNo;
                        sqlComm.Parameters.Add("@loan_amount", SqlDbType.Decimal).Value = regularLoanInfo.LoanAmount;
                        sqlComm.Parameters.Add("@purpose_of_loan", SqlDbType.VarChar).Value = regularLoanInfo.PurposeOfLoan;
                        sqlComm.Parameters.Add("@is_productive", SqlDbType.Bit).Value = regularLoanInfo.IsProductive;
                        sqlComm.Parameters.Add("@regular_loan_type_id", SqlDbType.VarChar).Value = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId;
                        sqlComm.Parameters.Add("@repayment_id", SqlDbType.VarChar).Value = regularLoanInfo.RepaymentScheduleInfo.RepaymentId;
                        sqlComm.Parameters.Add("@loan_terms", SqlDbType.SmallInt).Value = regularLoanInfo.LoanTerms;
                        sqlComm.Parameters.Add("@no_prepaid_interest", SqlDbType.SmallInt).Value = regularLoanInfo.NoPrepaidInterest;
                        sqlComm.Parameters.Add("@interest_rate", SqlDbType.Float).Value = regularLoanInfo.InterestRate;
                        sqlComm.Parameters.Add("@grace_period", SqlDbType.TinyInt).Value = regularLoanInfo.GracePeriod;
                        sqlComm.Parameters.Add("@is_straight_loan", SqlDbType.Bit).Value = regularLoanInfo.IsStraightLoan;
                        sqlComm.Parameters.Add("@loan_requirements", SqlDbType.VarChar).Value = regularLoanInfo.LoanRequirements;
                        sqlComm.Parameters.Add("@date_applied", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateApplied);
                        sqlComm.Parameters.Add("@date_approved", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateApproved);
                        sqlComm.Parameters.Add("@approval_evaluation", SqlDbType.VarChar).Value = regularLoanInfo.ApprovalEvaluation;
                        sqlComm.Parameters.Add("@date_first_payment", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateFirstPayment);
                        sqlComm.Parameters.Add("@date_maturity", SqlDbType.DateTime).Value = DateTime.Parse(regularLoanInfo.DateMaturity);
                        sqlComm.Parameters.Add("@penalty_rate", SqlDbType.Float).Value = regularLoanInfo.PenaltyRate;
                        sqlComm.Parameters.Add("@no_default_payment", SqlDbType.TinyInt).Value = regularLoanInfo.NoDefaultPayment;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = regularLoanInfo.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }

                    //insert, update and delete a regular loan amortization
                    this.InsertUpdateDeleteRegularLoanAmortization(userInfo, auth.Connection, regularLoanInfo.RegularLoanSysId,
                        regularLoanInfo.LoanAmortizationList);
                    //---------------------------------------------------

                    //insert, update and delete a regular loan charges
                    this.InsertUpdateDeleteRegularLoanCharges(userInfo, auth.Connection, regularLoanInfo.RegularLoanSysId,
                        regularLoanInfo.LoanChargesList);
                    //-------------------------------------------

                    //insert, update and delete a regular loan additions
                    this.InsertUpdateDeleteRegularLoanAdditions(userInfo, auth.Connection, regularLoanInfo.RegularLoanSysId,
                        regularLoanInfo.LoanAdditionsList);
                    //--------------------------------------------
                }
            }

        } //--------------------------------

        //this procedure delete a regular loan information
        public void DeleteRegularLoanInformation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo)
        {
            if (regularLoanInfo.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteRegularLoanInformation";

                        sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanInfo.RegularLoanSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure inserts, update or delete a regular loan document
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanDocumentTable"></param>
        public void InsertUpdateDeleteRegularLoanDocument(CommonExchange.SysAccess userInfo, DataTable regularLoanDocumentTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertRegularLoanDocument";

                    insertComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).SourceColumn = "sysid_regular";
                    insertComm.Parameters.Add("@file_data", SqlDbType.VarBinary).SourceColumn = "file_data";
                    insertComm.Parameters.Add("@original_name", SqlDbType.VarChar).SourceColumn = "original_name";
                    insertComm.Parameters.Add("@document_information", SqlDbType.VarChar).SourceColumn = "document_information";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand updateComm = new SqlCommand())
                    {

                        updateComm.Connection = auth.Connection;
                        updateComm.CommandType = CommandType.StoredProcedure;
                        updateComm.CommandText = "lms.UpdateRegularLoanDocument";

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
                            deleteComm.CommandText = "lms.DeleteRegularLoanDocument";

                            deleteComm.Parameters.Add("@document_id", SqlDbType.BigInt).SourceColumn = "document_id";

                            deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                            {
                                sqlAdapter.InsertCommand = insertComm;
                                sqlAdapter.UpdateCommand = updateComm;
                                sqlAdapter.DeleteCommand = deleteComm;

                                sqlAdapter.Update(regularLoanDocumentTable);
                            }
                        }
                    }
                }
            }
        } //----------------------------------

        /// <summary>
        /// this procedure adds a new collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void InsertCollateralInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Collateral collateralInfo)
        {
            if (collateralInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertCollateralInformation";

                        sqlComm.Parameters.Add("@sysid_collateral", SqlDbType.VarChar).Value = collateralInfo.CollateralSysId =
                            PrimaryKeys.GetNewCollateralInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = collateralInfo.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@property_type", SqlDbType.VarChar).Value = collateralInfo.PropertyType;
                        sqlComm.Parameters.Add("@property_brand", SqlDbType.VarChar).Value = collateralInfo.PropertyBrand;
                        sqlComm.Parameters.Add("@serial_no", SqlDbType.VarChar).Value = collateralInfo.SerialNo;
                        sqlComm.Parameters.Add("@purchase_price", SqlDbType.Decimal).Value = collateralInfo.PurchasePrice;
                        sqlComm.Parameters.Add("@year_purchased", SqlDbType.VarChar).Value = collateralInfo.YearPurchased;
                        sqlComm.Parameters.Add("@estimated_appraised_value", SqlDbType.Decimal).Value = collateralInfo.EstimatedAppraisedValue;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = collateralInfo.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure updates a collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void UpdateCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo)
        {
            if (collateralInfo.ObjectState == DataRowState.Modified)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateCollateralInformation";

                        sqlComm.Parameters.Add("@sysid_collateral", SqlDbType.VarChar).Value = collateralInfo.CollateralSysId;
                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = collateralInfo.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@property_type", SqlDbType.VarChar).Value = collateralInfo.PropertyType;
                        sqlComm.Parameters.Add("@property_brand", SqlDbType.VarChar).Value = collateralInfo.PropertyBrand;
                        sqlComm.Parameters.Add("@serial_no", SqlDbType.VarChar).Value = collateralInfo.SerialNo;
                        sqlComm.Parameters.Add("@purchase_price", SqlDbType.Decimal).Value = collateralInfo.PurchasePrice;
                        sqlComm.Parameters.Add("@year_purchased", SqlDbType.VarChar).Value = collateralInfo.YearPurchased;
                        sqlComm.Parameters.Add("@estimated_appraised_value", SqlDbType.Decimal).Value = collateralInfo.EstimatedAppraisedValue;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = collateralInfo.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure deletes a collateral information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void DeleteCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo)
        {
            if (collateralInfo.ObjectState == DataRowState.Deleted)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteCollateralInformation";

                        sqlComm.Parameters.Add("@sysid_collateral", SqlDbType.VarChar).Value = collateralInfo.CollateralSysId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure inserts and deletes a regular loan collateral
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanCollateralTable"></param>
        public void InsertDeleteRegularLoanCollateral(CommonExchange.SysAccess userInfo, DataTable regularLoanCollateralTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertRegularLoanCollateral";

                    insertComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).SourceColumn = "sysid_regular";
                    insertComm.Parameters.Add("@sysid_collateral", SqlDbType.VarChar).SourceColumn = "sysid_collateral";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand deleteComm = new SqlCommand())
                    {
                        deleteComm.Connection = auth.Connection;
                        deleteComm.CommandType = CommandType.StoredProcedure;
                        deleteComm.CommandText = "lms.DeleteRegularLoanCollateral";

                        deleteComm.Parameters.Add("@loan_collateral_id", SqlDbType.BigInt).SourceColumn = "loan_collateral_id";

                        deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                        {
                            sqlAdapter.InsertCommand = insertComm;
                            sqlAdapter.DeleteCommand = deleteComm;

                            sqlAdapter.Update(regularLoanCollateralTable);
                        }
                    }
                }
            }
        } //----------------------------------

        /// <summary>
        /// this procedure inserts, updates and deletes a regular loan co-maker
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanCoMakerTable"></param>
        public void InsertUpdateDeleteRegularLoanCoMaker(CommonExchange.SysAccess userInfo, DataTable regularLoanCoMakerTable)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand insertComm = new SqlCommand())
                {
                    insertComm.Connection = auth.Connection;
                    insertComm.CommandType = CommandType.StoredProcedure;
                    insertComm.CommandText = "lms.InsertRegularLoanCoMaker";

                    insertComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).SourceColumn = "sysid_regular";
                    insertComm.Parameters.Add("@sysid_comaker", SqlDbType.VarChar).SourceColumn = "sysid_comaker";
                    insertComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                    insertComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                    insertComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlCommand updateComm = new SqlCommand())
                    {

                        updateComm.Connection = auth.Connection;
                        updateComm.CommandType = CommandType.StoredProcedure;
                        updateComm.CommandText = "lms.UpdateRegularLoanCoMaker";

                        updateComm.Parameters.Add("@comaker_id", SqlDbType.BigInt).SourceColumn = "comaker_id";
                        updateComm.Parameters.Add("@remarks", SqlDbType.VarChar).SourceColumn = "remarks";

                        updateComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        updateComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        using (SqlCommand deleteComm = new SqlCommand())
                        {
                            deleteComm.Connection = auth.Connection;
                            deleteComm.CommandType = CommandType.StoredProcedure;
                            deleteComm.CommandText = "lms.DeleteRegularLoanCoMaker";

                            deleteComm.Parameters.Add("@comaker_id", SqlDbType.BigInt).SourceColumn = "comaker_id";

                            deleteComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            deleteComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                            {
                                sqlAdapter.InsertCommand = insertComm;
                                sqlAdapter.UpdateCommand = updateComm;
                                sqlAdapter.DeleteCommand = deleteComm;

                                sqlAdapter.Update(regularLoanCoMakerTable);
                            }
                        }
                    }
                }
            }
        } //----------------------------------


        /// <summary>
        /// this procedure adds a new other creditor information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="collateralInfo"></param>
        public void InsertOtherCreditorInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Collateral collateralInfo)
        {
            if (collateralInfo.ObjectState == DataRowState.Added)
            {
                using (Authenticate auth = new Authenticate(userInfo, false))
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = auth.Connection;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertCollateralInformation";

                        sqlComm.Parameters.Add("@sysid_collateral", SqlDbType.VarChar).Value = collateralInfo.CollateralSysId =
                            PrimaryKeys.GetNewCollateralInformationSystemID(userInfo, auth.Connection);
                        sqlComm.Parameters.Add("@sysid_member", SqlDbType.VarChar).Value = collateralInfo.MemberInfo.MemberSysId;
                        sqlComm.Parameters.Add("@property_type", SqlDbType.VarChar).Value = collateralInfo.PropertyType;
                        sqlComm.Parameters.Add("@property_brand", SqlDbType.VarChar).Value = collateralInfo.PropertyBrand;
                        sqlComm.Parameters.Add("@serial_no", SqlDbType.VarChar).Value = collateralInfo.SerialNo;
                        sqlComm.Parameters.Add("@purchase_price", SqlDbType.Decimal).Value = collateralInfo.PurchasePrice;
                        sqlComm.Parameters.Add("@year_purchased", SqlDbType.VarChar).Value = collateralInfo.YearPurchased;
                        sqlComm.Parameters.Add("@estimated_appraised_value", SqlDbType.Decimal).Value = collateralInfo.EstimatedAppraisedValue;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = collateralInfo.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }

        } //--------------------------------

        /// <summary>
        /// this procedure adds, updates, and deletes a regular loan amortization
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanAmortizationList"></param>
        public void InsertUpdateDeleteRegularLoanAmortization(CommonExchange.SysAccess userInfo, String regularLoanSysId,
            List<CommonExchange.RegularLoanAmortization> loanAmortizationList)
        {
            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                foreach (CommonExchange.RegularLoanAmortization loanAmortization in loanAmortizationList)
                {
                    if (loanAmortization.ObjectState == DataRowState.Deleted)
                    {
                        using (SqlCommand sqlComm = new SqlCommand())
                        {
                            sqlComm.Connection = auth.Connection;
                            sqlComm.CommandType = CommandType.StoredProcedure;
                            sqlComm.CommandText = "lms.DeleteRegularLoanAmortization";

                            sqlComm.Parameters.Add("@amortization_id", SqlDbType.BigInt).Value = loanAmortization.AmortizationId;

                            sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            sqlComm.ExecuteNonQuery();
                        }
                    }

                }

                foreach (CommonExchange.RegularLoanAmortization loanAmortization in loanAmortizationList)
                {
                    if (loanAmortization.ObjectState == DataRowState.Added)
                    {
                        using (SqlCommand sqlComm = new SqlCommand())
                        {
                            sqlComm.Connection = auth.Connection;
                            sqlComm.CommandType = CommandType.StoredProcedure;
                            sqlComm.CommandText = "lms.InsertRegularLoanAmortization";

                            sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
                            sqlComm.Parameters.Add("@payment_no", SqlDbType.SmallInt).Value = loanAmortization.PaymentNo;
                            sqlComm.Parameters.Add("@payment_date_from", SqlDbType.DateTime).Value =
                                DateTime.Parse(loanAmortization.PaymentDateFrom);
                            sqlComm.Parameters.Add("@payment_date_to", SqlDbType.DateTime).Value =
                                DateTime.Parse(loanAmortization.PaymentDateTo);
                            sqlComm.Parameters.Add("@payment_date_grace_period", SqlDbType.DateTime).Value =
                                DateTime.Parse(loanAmortization.PaymentDateGracePeriod);
                            sqlComm.Parameters.Add("@interest_rate", SqlDbType.Float).Value = loanAmortization.InterestRate;
                            sqlComm.Parameters.Add("@balance_beginning", SqlDbType.Decimal).Value = loanAmortization.BalanceBeginning;
                            sqlComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).Value = loanAmortization.PaymentAmount;
                            sqlComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).Value = loanAmortization.PrincipalPaid;
                            sqlComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).Value = loanAmortization.InterestPaid;
                            sqlComm.Parameters.Add("@balance_ending", SqlDbType.Decimal).Value = loanAmortization.BalanceEnding;
                            sqlComm.Parameters.Add("@penalty_rate", SqlDbType.Float).Value = loanAmortization.PenaltyRate;

                            sqlComm.Parameters.Add("@is_manually_computed", SqlDbType.Bit).Value = loanAmortization.IsManuallyComputed;
                            sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = loanAmortization.Remarks;

                            sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            sqlComm.ExecuteNonQuery();
                        }
                    }
                    else if (loanAmortization.ObjectState == DataRowState.Modified)
                    {
                        using (SqlCommand sqlComm = new SqlCommand())
                        {
                            sqlComm.Connection = auth.Connection;
                            sqlComm.CommandType = CommandType.StoredProcedure;
                            sqlComm.CommandText = "lms.UpdateRegularLoanAmortization";

                            sqlComm.Parameters.Add("@amortization_id", SqlDbType.BigInt).Value = loanAmortization.AmortizationId;
                            sqlComm.Parameters.Add("@payment_no", SqlDbType.SmallInt).Value = loanAmortization.PaymentNo;
                            sqlComm.Parameters.Add("@payment_date_from", SqlDbType.DateTime).Value =
                                DateTime.Parse(loanAmortization.PaymentDateFrom);
                            sqlComm.Parameters.Add("@payment_date_to", SqlDbType.DateTime).Value =
                                DateTime.Parse(loanAmortization.PaymentDateTo);
                            sqlComm.Parameters.Add("@payment_date_grace_period", SqlDbType.DateTime).Value =
                                DateTime.Parse(loanAmortization.PaymentDateGracePeriod);
                            sqlComm.Parameters.Add("@interest_rate", SqlDbType.Float).Value = loanAmortization.InterestRate;
                            sqlComm.Parameters.Add("@balance_beginning", SqlDbType.Decimal).Value = loanAmortization.BalanceBeginning;
                            sqlComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).Value = loanAmortization.PaymentAmount;
                            sqlComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).Value = loanAmortization.PrincipalPaid;
                            sqlComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).Value = loanAmortization.InterestPaid;
                            sqlComm.Parameters.Add("@balance_ending", SqlDbType.Decimal).Value = loanAmortization.BalanceEnding;
                            sqlComm.Parameters.Add("@penalty_rate", SqlDbType.Float).Value = loanAmortization.PenaltyRate;

                            sqlComm.Parameters.Add("@is_manually_computed", SqlDbType.Bit).Value = loanAmortization.IsManuallyComputed;
                            sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = loanAmortization.Remarks;

                            sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                            sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                            sqlComm.ExecuteNonQuery();
                        }
                    }
                }
            }

        } //--------------------------------
        

        /// <summary>
        /// this procedure adds, updates, and deletes a regular loan amortization
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanAmortizationList"></param>
        private void InsertUpdateDeleteRegularLoanAmortization(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String regularLoanSysId,
            List<CommonExchange.RegularLoanAmortization> loanAmortizationList)
        {
            foreach (CommonExchange.RegularLoanAmortization loanAmortization in loanAmortizationList)
            {
                if (loanAmortization.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteRegularLoanAmortization";

                        sqlComm.Parameters.Add("@amortization_id", SqlDbType.BigInt).Value = loanAmortization.AmortizationId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }

            }

            foreach (CommonExchange.RegularLoanAmortization loanAmortization in loanAmortizationList)
            {
                if (loanAmortization.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertRegularLoanAmortization";

                        sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
                        sqlComm.Parameters.Add("@payment_no", SqlDbType.SmallInt).Value = loanAmortization.PaymentNo;
                        sqlComm.Parameters.Add("@payment_date_from", SqlDbType.DateTime).Value = 
                            DateTime.Parse(loanAmortization.PaymentDateFrom);
                        sqlComm.Parameters.Add("@payment_date_to", SqlDbType.DateTime).Value =
                            DateTime.Parse(loanAmortization.PaymentDateTo);
                        sqlComm.Parameters.Add("@payment_date_grace_period", SqlDbType.DateTime).Value =
                            DateTime.Parse(loanAmortization.PaymentDateGracePeriod);
                        sqlComm.Parameters.Add("@interest_rate", SqlDbType.Float).Value = loanAmortization.InterestRate;
                        sqlComm.Parameters.Add("@balance_beginning", SqlDbType.Decimal).Value = loanAmortization.BalanceBeginning;
                        sqlComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).Value = loanAmortization.PaymentAmount;
                        sqlComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).Value = loanAmortization.PrincipalPaid;
                        sqlComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).Value = loanAmortization.InterestPaid;
                        sqlComm.Parameters.Add("@balance_ending", SqlDbType.Decimal).Value = loanAmortization.BalanceEnding;
                        sqlComm.Parameters.Add("@penalty_rate", SqlDbType.Float).Value = loanAmortization.PenaltyRate;

                        sqlComm.Parameters.Add("@is_manually_computed", SqlDbType.Bit).Value = loanAmortization.IsManuallyComputed;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = loanAmortization.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (loanAmortization.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateRegularLoanAmortization";

                        sqlComm.Parameters.Add("@amortization_id", SqlDbType.BigInt).Value = loanAmortization.AmortizationId;
                        sqlComm.Parameters.Add("@payment_no", SqlDbType.SmallInt).Value = loanAmortization.PaymentNo;
                        sqlComm.Parameters.Add("@payment_date_from", SqlDbType.DateTime).Value =
                            DateTime.Parse(loanAmortization.PaymentDateFrom);
                        sqlComm.Parameters.Add("@payment_date_to", SqlDbType.DateTime).Value =
                            DateTime.Parse(loanAmortization.PaymentDateTo);
                        sqlComm.Parameters.Add("@payment_date_grace_period", SqlDbType.DateTime).Value =
                            DateTime.Parse(loanAmortization.PaymentDateGracePeriod);
                        sqlComm.Parameters.Add("@interest_rate", SqlDbType.Float).Value = loanAmortization.InterestRate;
                        sqlComm.Parameters.Add("@balance_beginning", SqlDbType.Decimal).Value = loanAmortization.BalanceBeginning;
                        sqlComm.Parameters.Add("@payment_amount", SqlDbType.Decimal).Value = loanAmortization.PaymentAmount;
                        sqlComm.Parameters.Add("@principal_paid", SqlDbType.Decimal).Value = loanAmortization.PrincipalPaid;
                        sqlComm.Parameters.Add("@interest_paid", SqlDbType.Decimal).Value = loanAmortization.InterestPaid;
                        sqlComm.Parameters.Add("@balance_ending", SqlDbType.Decimal).Value = loanAmortization.BalanceEnding;
                        sqlComm.Parameters.Add("@penalty_rate", SqlDbType.Float).Value = loanAmortization.PenaltyRate;

                        sqlComm.Parameters.Add("@is_manually_computed", SqlDbType.Bit).Value = loanAmortization.IsManuallyComputed;
                        sqlComm.Parameters.Add("@remarks", SqlDbType.VarChar).Value = loanAmortization.Remarks;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }                
            }

        } //--------------------------------

        /// <summary>
        /// this procedure insert, update or delete a regular loan charges
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanChargesList"></param>
        private void InsertUpdateDeleteRegularLoanCharges(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String regularLoanSysId,
            List<CommonExchange.RegularLoanCharges> loanChargesList)
        {
            foreach (CommonExchange.RegularLoanCharges loanCharges in loanChargesList)
            {
                if (loanCharges.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteRegularLoanCharges";

                        sqlComm.Parameters.Add("@regular_charges_id", SqlDbType.BigInt).Value = loanCharges.RegularChargesId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }

            }

            foreach (CommonExchange.RegularLoanCharges loanCharges in loanChargesList)
            {
                if (loanCharges.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertRegularLoanCharges";
                        
                        sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
	                    sqlComm.Parameters.Add("@charge_amount", SqlDbType.Decimal).Value = loanCharges.ChargeAmount;
	                    sqlComm.Parameters.Add("@charge_description", SqlDbType.VarChar).Value = loanCharges.ChargeDescription;

                        if (String.IsNullOrEmpty(loanCharges.AccountInfo.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = loanCharges.AccountInfo.AccountSysId;
                        }

                        if (String.IsNullOrEmpty(loanCharges.RegularLoanSysIdForwarded))
                        {
                            sqlComm.Parameters.Add("@sysid_regular_forwarded", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_regular_forwarded", SqlDbType.VarChar).Value = loanCharges.RegularLoanSysIdForwarded;
                        }

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (loanCharges.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateRegularLoanCharges";

                        sqlComm.Parameters.Add("@regular_charges_id", SqlDbType.BigInt).Value = loanCharges.RegularChargesId;
                        sqlComm.Parameters.Add("@charge_amount", SqlDbType.Decimal).Value = loanCharges.ChargeAmount;
                        sqlComm.Parameters.Add("@charge_description", SqlDbType.VarChar).Value = loanCharges.ChargeDescription;

                        if (String.IsNullOrEmpty(loanCharges.AccountInfo.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = loanCharges.AccountInfo.AccountSysId;
                        }

                        if (String.IsNullOrEmpty(loanCharges.RegularLoanSysIdForwarded))
                        {
                            sqlComm.Parameters.Add("@sysid_regular_forwarded", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_regular_forwarded", SqlDbType.VarChar).Value = loanCharges.RegularLoanSysIdForwarded;
                        }

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// this procedure insert, update or delete a regular loan additions
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="sqlConn"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="loanAdditionsList"></param>
        private void InsertUpdateDeleteRegularLoanAdditions(CommonExchange.SysAccess userInfo, SqlConnection sqlConn, String regularLoanSysId,
            List<CommonExchange.RegularLoanAdditions> loanAdditionsList)
        {
            foreach (CommonExchange.RegularLoanAdditions loanAdditions in loanAdditionsList)
            {
                if (loanAdditions.ObjectState == DataRowState.Deleted)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.DeleteRegularLoanAdditions";

                        sqlComm.Parameters.Add("@regular_additions_id", SqlDbType.BigInt).Value = loanAdditions.RegularAdditionsId;

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@deleted_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }

            }

            foreach (CommonExchange.RegularLoanAdditions loanAdditions in loanAdditionsList)
            {
                if (loanAdditions.ObjectState == DataRowState.Added)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.InsertRegularLoanAdditions";

                        sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
	                    sqlComm.Parameters.Add("@addition_amount", SqlDbType.Decimal).Value = loanAdditions.AdditionAmount;
                        sqlComm.Parameters.Add("@addition_description", SqlDbType.VarChar).Value = loanAdditions.AdditionDescription;

                        if (String.IsNullOrEmpty(loanAdditions.AccountInfo.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = loanAdditions.AccountInfo.AccountSysId;
                        }

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@created_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
                else if (loanAdditions.ObjectState == DataRowState.Modified)
                {
                    using (SqlCommand sqlComm = new SqlCommand())
                    {
                        sqlComm.Connection = sqlConn;
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.CommandText = "lms.UpdateRegularLoanAdditions";

                        sqlComm.Parameters.Add("@regular_additions_id", SqlDbType.BigInt).Value = loanAdditions.RegularAdditionsId;
                        sqlComm.Parameters.Add("@addition_amount", SqlDbType.Decimal).Value = loanAdditions.AdditionAmount;
                        sqlComm.Parameters.Add("@addition_description", SqlDbType.VarChar).Value = loanAdditions.AdditionDescription;

                        if (String.IsNullOrEmpty(loanAdditions.AccountInfo.AccountSysId))
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = loanAdditions.AccountInfo.AccountSysId;
                        }

                        sqlComm.Parameters.Add("@network_information", SqlDbType.VarChar).Value = userInfo.NetworkInformation;
                        sqlComm.Parameters.Add("@edited_by", SqlDbType.VarChar).Value = userInfo.UserId;

                        sqlComm.ExecuteNonQuery();
                    }
                }
            }
        }

        #endregion

        #region Programmer-Defined Function Procedures

        /// <summary>
        /// This function returns a new regular loan account no
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanTypeId"></param>
        /// <param name="dateApproved"></param>
        /// <returns></returns>
        public String SelectCountForAccountNoRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanTypeId,
            String dateApproved)
        {
            Int16 count = 0;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectCountForAccountNoRegularLoanInformation";

                    sqlComm.Parameters.Add("@regular_loan_type_id", SqlDbType.VarChar).Value = regularLoanTypeId;
                    sqlComm.Parameters.Add("@date_approved", SqlDbType.DateTime).Value = DateTime.Parse(dateApproved);

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    count = Convert.ToInt16(sqlComm.ExecuteScalar());
                }
            }

            if (String.Equals(regularLoanTypeId, CommonExchange.RegularLoanType.BirthdayLoanId))
            {
                return CommonExchange.RegularLoanType.BirthdayLoanCode + "-" + DateTime.Parse(dateApproved).Year.ToString() + "-" +
                    DateTime.Parse(dateApproved).Month.ToString("00") + "-" + (++count).ToString("000");
            }
            else if (String.Equals(regularLoanTypeId, CommonExchange.RegularLoanType.ContingencyLoanId))
            {
                return CommonExchange.RegularLoanType.ContingencyLoanCode + "-" + DateTime.Parse(dateApproved).Year.ToString() + "-" +
                    DateTime.Parse(dateApproved).Month.ToString("00") + "-" + (++count).ToString("000");
            }
            else if (String.Equals(regularLoanTypeId, CommonExchange.RegularLoanType.SalaryLoanId))
            {
                return CommonExchange.RegularLoanType.SalaryLoanCode + "-" + DateTime.Parse(dateApproved).Year.ToString() + "-" +
                    DateTime.Parse(dateApproved).Month.ToString("00") + "-" + (++count).ToString("000");
            }
            else if (String.Equals(regularLoanTypeId, CommonExchange.RegularLoanType.MedicalLoanId))
            {
                return CommonExchange.RegularLoanType.MedicalLoanCode + "-" + DateTime.Parse(dateApproved).Year.ToString() + "-" +
                    DateTime.Parse(dateApproved).Month.ToString("00") + "-" + (++count).ToString("000");
            }
            else if (String.Equals(regularLoanTypeId, CommonExchange.RegularLoanType.SpecialLoanId))
            {
                return CommonExchange.RegularLoanType.SpecialLoanCode + "-" + DateTime.Parse(dateApproved).Year.ToString() + "-" +
                    DateTime.Parse(dateApproved).Month.ToString("00") + "-" + (++count).ToString("000");
            }

            return String.Empty;
        }//------------------------------------------------

        /// <summary>
        /// this function gets the regular loan information
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="memberSysIdList"></param>
        /// <param name="isMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDMemberListRegularLoanInformation(CommonExchange.SysAccess userInfo, String memberSysIdList,
            Boolean isMarkedDeleted)
        {
            DataTable dbTable = new DataTable("RegularLoanInformationByMemberSysIdListTable");
            dbTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
			dbTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
			dbTable.Columns.Add("account_no", System.Type.GetType("System.String"));
			dbTable.Columns.Add("loan_amount", System.Type.GetType("System.Decimal"));
			dbTable.Columns.Add("purpose_of_loan", System.Type.GetType("System.String"));
            dbTable.Columns.Add("is_productive_string", System.Type.GetType("System.String"));
			dbTable.Columns.Add("loan_terms", System.Type.GetType("System.Int16"));
			dbTable.Columns.Add("interest_rate", System.Type.GetType("System.Single"));
            dbTable.Columns.Add("is_straight_string", System.Type.GetType("System.String"));
            dbTable.Columns.Add("date_first_payment", System.Type.GetType("System.String"));
			dbTable.Columns.Add("date_maturity", System.Type.GetType("System.String"));
			
			dbTable.Columns.Add("regular_loan_type_id", System.Type.GetType("System.String"));
            dbTable.Columns.Add("regular_loan_type_description", System.Type.GetType("System.String"));
            dbTable.Columns.Add("regular_loan_type_code", System.Type.GetType("System.String"));
			dbTable.Columns.Add("regular_loan_type_no", System.Type.GetType("System.Byte"));

			dbTable.Columns.Add("repayment_id", System.Type.GetType("System.String"));
			dbTable.Columns.Add("repayment_description", System.Type.GetType("System.String"));
			dbTable.Columns.Add("payments_per_year", System.Type.GetType("System.Int16"));
            dbTable.Columns.Add("repayment_no", System.Type.GetType("System.Byte"));

            dbTable.Columns.Add("is_record_locked", System.Type.GetType("System.Boolean"));

            dbTable.Columns.Add("is_active_loan", System.Type.GetType("System.Boolean"));

            dbTable.Columns.Add("total_amortization_amount", System.Type.GetType("System.Decimal"));
            dbTable.Columns.Add("total_loan_payments", System.Type.GetType("System.Decimal"));

            dbTable.Columns.Add("sysid_voucher", System.Type.GetType("System.String"));
            dbTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            dbTable.Columns.Add("check_date", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDMemberListRegularLoanInformation";

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

                                newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_regular", String.Empty);
                                newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                newRow["account_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_no", String.Empty);
                                newRow["loan_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "loan_amount", Decimal.Parse("0"));
                                newRow["purpose_of_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "purpose_of_loan", String.Empty);
                                newRow["is_productive_string"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_productive_string", String.Empty);
                                newRow["loan_terms"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "loan_terms", Int16.Parse("0"));
                                newRow["interest_rate"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "interest_rate", Single.Parse("0"));
                                newRow["is_straight_string"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_straight_string", String.Empty);
                                newRow["date_first_payment"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_first_payment", 
                                    DateTime.MinValue).ToString();
                                newRow["date_maturity"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_maturity",
                                    DateTime.MinValue).ToString();

                                newRow["regular_loan_type_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "regular_loan_type_id",
                                    String.Empty);
                                newRow["regular_loan_type_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "regular_loan_type_description",
                                    String.Empty);
                                newRow["regular_loan_type_code"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "regular_loan_type_code",
                                    String.Empty);
                                newRow["regular_loan_type_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "regular_loan_type_no",
                                    Byte.Parse("0"));

                                newRow["repayment_id"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "repayment_id", String.Empty);
                                newRow["repayment_description"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "repayment_description", String.Empty);
                                newRow["payments_per_year"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payments_per_year", Int16.Parse("0"));
                                newRow["repayment_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "repayment_no", Byte.Parse("0"));

                                newRow["is_record_locked"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_record_locked", false);

                                newRow["is_active_loan"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_active_loan", false);

                                newRow["total_amortization_amount"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "total_amortization_amount", Decimal.Parse("0"));
                                newRow["total_loan_payments"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "total_loan_payments", Decimal.Parse("0"));

                                newRow["sysid_voucher"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_voucher", String.Empty);
                                newRow["check_no"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_no", String.Empty);
                                newRow["check_date"] = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "check_date",
                                    DateTime.MinValue).ToString();

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
        /// get the regular loan information by regular loan system id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularSysId"></param>
        /// <returns></returns>
        public CommonExchange.RegularLoan SelectBySysIDRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanSysId)
        {
            CommonExchange.RegularLoan regularLoanInfo = new CommonExchange.RegularLoan();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularLoanInformation";

                    sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                regularLoanInfo.RegularLoanSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_regular", String.Empty);
                                regularLoanInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_member", String.Empty);
                                regularLoanInfo.AccountNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "account_no", String.Empty);
                                regularLoanInfo.LoanAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "loan_amount", Decimal.Parse("0"));
                                regularLoanInfo.PurposeOfLoan = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "purpose_of_loan", String.Empty);
                                regularLoanInfo.IsProductive = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_productive", false);
                                regularLoanInfo.LoanTerms = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "loan_terms", Int16.Parse("0"));
                                regularLoanInfo.NoPrepaidInterest = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "no_prepaid_interest", 
                                    Int16.Parse("0"));
                                regularLoanInfo.InterestRate = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "interest_rate", Single.Parse("0.0"));
                                regularLoanInfo.GracePeriod = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "grace_period", Byte.Parse("0"));
                                regularLoanInfo.IsStraightLoan = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_straight_loan", false);
                                regularLoanInfo.LoanRequirements = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "loan_requirements", String.Empty);
                                regularLoanInfo.DateApplied = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_applied", 
                                    DateTime.MinValue).ToString();
                                regularLoanInfo.DateApproved = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_approved",
                                    DateTime.MinValue).ToString();
                                regularLoanInfo.ApprovalEvaluation = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "approval_evaluation", String.Empty);
                                regularLoanInfo.DateFirstPayment = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_first_payment",
                                    DateTime.MinValue).ToString();
                                regularLoanInfo.DateMaturity = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "date_maturity",
                                    DateTime.MinValue).ToString();
                                regularLoanInfo.PenaltyRate = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "penalty_rate", Single.Parse("0.0"));
                                regularLoanInfo.NoDefaultPayment = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "no_default_payment", Byte.Parse("0"));
                                regularLoanInfo.Remarks = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);

                                regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "regular_loan_type_id", String.Empty);
                                regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "regular_loan_type_description", String.Empty);
                                regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeCode = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "regular_loan_type_code", String.Empty);
                                regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "regular_loan_type_no", Byte.Parse("0"));

                                regularLoanInfo.RepaymentScheduleInfo.RepaymentId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "repayment_id", String.Empty);
                                regularLoanInfo.RepaymentScheduleInfo.RepaymentDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "repayment_description", String.Empty);
                                regularLoanInfo.RepaymentScheduleInfo.PaymentsPerYear = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "payments_per_year", Int16.Parse("0"));
                                regularLoanInfo.RepaymentScheduleInfo.RepaymentNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "repayment_no", Byte.Parse("0"));

                                regularLoanInfo.IsRecordLocked = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_record_locked", false);

                                break;
                            }
                        }

                        sqlReader.Close();
                    }
                }

                //gets the regular loan amortization
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularListRegularLoanAmortization";

                    if (String.IsNullOrEmpty(regularLoanInfo.RegularLoanSysId))
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = regularLoanInfo.RegularLoanSysId;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                CommonExchange.RegularLoanAmortization loanAmortizationInfo = new CommonExchange.RegularLoanAmortization();

                                loanAmortizationInfo.AmortizationId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "amortization_id", Int64.Parse("0"));
		                        loanAmortizationInfo.PaymentNo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payment_no", Int16.Parse("0"));
		                        loanAmortizationInfo.PaymentDateFrom = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "payment_date_from", DateTime.MinValue).ToString();
		                        loanAmortizationInfo.PaymentDateTo = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "payment_date_to", DateTime.MinValue).ToString();
                                loanAmortizationInfo.PaymentDateGracePeriod = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader,
                                    "payment_date_grace_period", DateTime.MinValue).ToString();
		                        loanAmortizationInfo.InterestRate = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "interest_rate", Single.Parse("0.0"));
		                        loanAmortizationInfo.BalanceBeginning = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "balance_beginning", 
                                    Decimal.Parse("0.00"));
		                        loanAmortizationInfo.PaymentAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "payment_amount",
                                    Decimal.Parse("0.00"));
		                        loanAmortizationInfo.PrincipalPaid = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "principal_paid",
                                    Decimal.Parse("0.00"));
		                        loanAmortizationInfo.InterestPaid = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "interest_paid",
                                    Decimal.Parse("0.00"));
		                        loanAmortizationInfo.BalanceEnding = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "balance_ending", 
                                    Decimal.Parse("0.00"));
		                        loanAmortizationInfo.PenaltyRate = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "penalty_rate", Single.Parse("0.0"));

		                        loanAmortizationInfo.IsManuallyComputed = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "is_manually_computed", false);
                                loanAmortizationInfo.Remarks = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "remarks", String.Empty);

                                regularLoanInfo.LoanAmortizationList.Add(loanAmortizationInfo);

                            }
                        }

                        sqlReader.Close();
                    }
                }

                //gets the regular loan charges
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularListRegularLoanCharges";

                    if (String.IsNullOrEmpty(regularLoanInfo.RegularLoanSysId))
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = regularLoanInfo.RegularLoanSysId;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                CommonExchange.RegularLoanCharges loanChargesInfo = new CommonExchange.RegularLoanCharges();

                                loanChargesInfo.RegularChargesId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "regular_charges_id", Int64.Parse("0"));
		                        loanChargesInfo.ChargeAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "charge_amount", Decimal.Parse("0.00"));
                                loanChargesInfo.ChargeDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "charge_description", String.Empty);
                                loanChargesInfo.AccountInfo.AccountSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account", String.Empty);
                                loanChargesInfo.RegularLoanSysIdForwarded = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_regular_forwarded", String.Empty);

                                regularLoanInfo.LoanChargesList.Add(loanChargesInfo);

                            }
                        }

                        sqlReader.Close();
                    }
                }

                //gets the regular loan additions
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularListRegularLoanAdditions";

                    if (String.IsNullOrEmpty(regularLoanInfo.RegularLoanSysId))
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = regularLoanInfo.RegularLoanSysId;
                    }

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                CommonExchange.RegularLoanAdditions loanAdditionsInfo = new CommonExchange.RegularLoanAdditions();

                                loanAdditionsInfo.RegularAdditionsId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, 
                                    "regular_additions_id", Int64.Parse("0"));
		                        loanAdditionsInfo.AdditionAmount = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "addition_amount", 
                                    Decimal.Parse("0.00"));
                                loanAdditionsInfo.AdditionDescription = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "addition_description", 
                                    String.Empty);
                                loanAdditionsInfo.AccountInfo.AccountSysId = RemoteServerLib.ProcStatic.DataReaderConvert(sqlReader, "sysid_account", String.Empty);

                                regularLoanInfo.LoanAdditionsList.Add(loanAdditionsInfo);

                            }
                        }

                        sqlReader.Close();
                    }
                }


            }

            return regularLoanInfo;

        }  //---------------------------------------------------

        /// <summary>
        /// this function gets the regular loan documents by sysid_regular list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanDocument(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            DataTable dbTable = new DataTable("RegularLoanDocumentsTable");
            dbTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            dbTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
            dbTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            dbTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            dbTable.Columns.Add("document_information", System.Type.GetType("System.String"));

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularListRegularLoanDocument";

                    if (String.IsNullOrEmpty(regularLoanSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = regularLoanSysIdList;
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
                                newRow["sysid_regular"] = sqlReader["sysid_regular"];
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
        /// this function gets the collateral information table query
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="queryString"></param>
        /// <param name="includeMarkedDeleted"></param>
        /// <returns></returns>
        public DataTable SelectCollateralInformation(CommonExchange.SysAccess userInfo, String queryString, Boolean includeMarkedDeleted)
        {
            DataTable dbTable = new DataTable("CollateralInformationTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectCollateralInformation";

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
        /// this function returns the regular loan collateral by regular loan system id
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysId"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanCollateral(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            DataTable dbTable = new DataTable("RegularLoanCollateralTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularListRegularLoanCollateral";

                    if (String.IsNullOrEmpty(regularLoanSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = regularLoanSysIdList;
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

        } //------------------------------

        /// <summary>
        /// this function returns the regular loan co-maker by regular loan system id list
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysIdList"></param>
        /// <returns></returns>
        public DataTable SelectBySysIDRegularListRegularLoanCoMaker(CommonExchange.SysAccess userInfo, String regularLoanSysIdList)
        {
            DataTable dbTable = new DataTable("RegularLoanCoMakerTable");

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.SelectBySysIDRegularListRegularLoanCoMaker";

                    if (String.IsNullOrEmpty(regularLoanSysIdList))
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        sqlComm.Parameters.Add("@sysid_regular_list", SqlDbType.NVarChar).Value = regularLoanSysIdList;
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

        } //------------------------------

        /// <summary>
        /// This function determines if the regular loan account no already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public Boolean IsExistsAccountNoRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanSysId,
            String accountNo)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsAccountNoRegularLoanInformation";

                    sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
                    sqlComm.Parameters.Add("@account_no", SqlDbType.VarChar).Value = accountNo;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;

        } //------------------------------------------

        /// <summary>
        /// this function determines if the regular document original name already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="documentId"></param>
        /// <param name="regularLoanSysId"></param>
        /// <param name="originalName"></param>
        /// <returns></returns>
        public Boolean IsExistsSysIDRegularOriginalNameRegularLoanDocument(CommonExchange.SysAccess userInfo, Int64 documentId, String regularLoanSysId,
            String originalName)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsSysIDRegularOriginalNameRegularLoanDocument";

                    sqlComm.Parameters.Add("@document_id", SqlDbType.BigInt).Value = documentId;
                    sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
                    sqlComm.Parameters.Add("@original_name", SqlDbType.VarChar).Value = originalName;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;

        } //------------------------------------------

        //this function is used to determine if the payment date from, to and grace period already exists
        public Boolean IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization(CommonExchange.SysAccess userInfo, Int64 amortizationId,
            String regularLoanSysId, String paymentDateFrom, String paymentDateTo)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization";

                    sqlComm.Parameters.Add("@amortization_id", SqlDbType.BigInt).Value = amortizationId;
                    sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
                    sqlComm.Parameters.Add("@payment_date_from", SqlDbType.DateTime).Value = DateTime.Parse(paymentDateFrom);
                    sqlComm.Parameters.Add("@payment_date_to", SqlDbType.DateTime).Value = DateTime.Parse(paymentDateTo);

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;
        } //------------------------------

        /// <summary>
        /// this function determines if the regular loan charges already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularChargesId"></param>
        /// <param name="regularSysId"></param>
        /// <param name="loanChargesSysId"></param>
        /// <returns></returns>
        public Boolean IsExistsChargeRegularLoanCharges(CommonExchange.SysAccess userInfo, Int64 regularChargesId,
            String regularLoanSysId, String chargeDescription, String accountSysId)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsChargeRegularLoanCharges";

                    sqlComm.Parameters.Add("@regular_charges_id", SqlDbType.BigInt).Value = regularChargesId;
                    sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
                    sqlComm.Parameters.Add("@charge_description", SqlDbType.VarChar).Value = chargeDescription;
                    sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = accountSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;
        } //------------------------------

        /// <summary>
        /// this function determines if the regular loan additions already exists
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="regularChargesId"></param>
        /// <param name="regularSysId"></param>
        /// <param name="loanChargesSysId"></param>
        /// <returns></returns>
        public Boolean IsExistsChargeRegularLoanAdditions(CommonExchange.SysAccess userInfo, Int64 regularAdditionsId,
            String regularLoanSysId, String additionDescription, String accountSysId)
        {
            Boolean isExist = false;

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = auth.Connection;
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "lms.IsExistsChargeRegularLoanAdditions";

                    sqlComm.Parameters.Add("@regular_additions_id", SqlDbType.BigInt).Value = regularAdditionsId;
                    sqlComm.Parameters.Add("@sysid_regular", SqlDbType.VarChar).Value = regularLoanSysId;
                    sqlComm.Parameters.Add("@addition_description", SqlDbType.VarChar).Value = additionDescription;
                    sqlComm.Parameters.Add("@sysid_account", SqlDbType.VarChar).Value = accountSysId;

                    sqlComm.Parameters.Add("@system_user_id", SqlDbType.VarChar).Value = userInfo.UserId;

                    isExist = (Boolean)sqlComm.ExecuteScalar();
                }
            }

            return isExist;
        } //------------------------------

        /// <summary>
        /// gets the dataset for the loan manager
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public DataSet GetDataSetForLoanManager(CommonExchange.SysAccess userInfo)
        {
            DataSet dbSet = new DataSet();

            using (Authenticate auth = new Authenticate(userInfo, false))
            {
                //gets the regular loan type table
                dbSet.Tables.Add(ProcStatic.GetRegularLoanTypeTable(auth.Connection, userInfo.UserId));
                //---------------------------------

                //gets the repayment schedule table
                dbSet.Tables.Add(ProcStatic.GetRepaymentScheduleTable(auth.Connection, userInfo.UserId));
                //-------------------------------------
            }

            return dbSet;
        } //----------------------------------

        #endregion
    }
}
