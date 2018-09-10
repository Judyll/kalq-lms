using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    internal class MemberLogic :  BaseServices.BaseServicesLogic
    {
        #region Class Data Member Decleration
        private DataSet _memberClassDataSet;
        private DataTable _memberInfoTable;
        private DataTable _officeEmployerTable;
        private DataTable _collateralInformationTable;
        private DataTable _sharedCapitalInformationTable;
        private DataTable _hospitalizationInformationTable;
        private DataTable _includeHospitalizationTable;
        private DataTable _excludeHospitalizationTable;
        private DataTable _debitHospitalizationTable;
        private DataTable _documentHospitalizationDebitTable;
        private DataTable _shareCapitalCreditTable;
        private DataTable _membersEquityTable;
        private DataTable _inHouseHospitalizationTable;
        private DataTable _billingStatementTable;

        private Int64 _inHouseHospitalizationDebitId = 0;
        #endregion

        #region Class Properties Decleration
        public DataTable CollateralInformationTable
        {
            get
            {
                DataTable newTable = new DataTable("CollateralInformationTable");
                newTable.Columns.Add("sysid_collateral", System.Type.GetType("System.String"));
                newTable.Columns.Add("property_type", System.Type.GetType("System.String"));
                newTable.Columns.Add("property_brand", System.Type.GetType("System.String"));
                newTable.Columns.Add("serial_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("purchase_price", System.Type.GetType("System.Decimal"));
                newTable.Columns.Add("year_purchased", System.Type.GetType("System.String"));
                newTable.Columns.Add("estimated_appraised_value", System.Type.GetType("System.Decimal"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable OtherCreditorInformationTable
        {
            get
            {
                DataTable newTable = new DataTable("OtherCreditorInformationTable");
                newTable.Columns.Add("other_creditor_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("creditor_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_owned", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_due", System.Type.GetType("System.String"));
                newTable.Columns.Add("repayment_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("amortization_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable ShareCapitalInformationTable
        {
            get
            {
                DataTable newTable = new DataTable("ShareCapitalInformationTable");
                newTable.Columns.Add("sysid_share", System.Type.GetType("System.String"));
                newTable.Columns.Add("effectivity_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("premium_amount_due", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable HospitalizationInformation
        {
            get
            {
                DataTable newTable = new DataTable("HospitalizationInformationTable");
                newTable.Columns.Add("effectivity_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("certificate_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("premium_amount_due", System.Type.GetType("System.String"));
                newTable.Columns.Add("maximum_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable HospitalizationIncludeTable
        {
            get
            {
                DataTable newTable = new DataTable("HospitalizationIncludeTable");
                newTable.Columns.Add("sysid_includecoverage", System.Type.GetType("System.String"));
                newTable.Columns.Add("include_coverage_description", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable HospitalizationExcludeTable
        {
            get
            {
                DataTable newTable = new DataTable("HospitalizationExcludeTable");
                newTable.Columns.Add("sysid_excludecoverage", System.Type.GetType("System.String"));
                newTable.Columns.Add("exclude_coverage_description", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable HospitalizationDebitTable
        {
            get
            {
                DataTable newTable = new DataTable("HospitalizationDebitTable");
                newTable.Columns.Add("sysid_inhousedebit", System.Type.GetType("System.String"));
                newTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("net_assistance_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("hospital_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("cause_of_admission", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_from", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_to", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable ShareCapitalCreditTable
        {
            get
            {
                DataTable newTable = new DataTable("ShareCapitalCreditTable");
                newTable.Columns.Add("capital_credit_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("received_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("bank_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_no_not_froze", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable MembersEquityTable
        {
            get
            {
                DataTable newTable = new DataTable("MembersEquityTable");
                newTable.Columns.Add("equity_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("received_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("bank_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_no_not_froze", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable InHouseHospitalizationTable
        {
            get
            {
                DataTable newTable = new DataTable("InHouseHospitalizationTable");
                newTable.Columns.Add("hospitalization_credit_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("received_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("bank_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_no_not_froze", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        private Int64 _otherCreditorId= 0;
        public Int64 OtherCreditorId
        {
            get { return _otherCreditorId; }
            set { _otherCreditorId = value; }
        }

        private Int64 _inHouseHospitalizationIncludeCoverageId = 0;
        public Int64 InHouseHospitalizationIncludeCoverageId
        {
            get { return _inHouseHospitalizationIncludeCoverageId; }
            set { _inHouseHospitalizationIncludeCoverageId = value; }
        }

        private Int64 _inHouseHospitalizationExcludeCoverageId = 0;
        public Int64 InHouseHospitalizationExcludeCoverageId
        {
            get { return _inHouseHospitalizationExcludeCoverageId; }
            set { _inHouseHospitalizationExcludeCoverageId = value; } 
        }
        #endregion

        #region Class Constructors
        public MemberLogic(CommonExchange.SysAccess userInfo)
            : base(userInfo)
        {
            this.InitializeMemberClass(userInfo);
        }
        #endregion

        #region Programmers-Defined Void Procedures
        //this procedure will initialize member logic class
        private void InitializeMemberClass(CommonExchange.SysAccess userInfo)
        {
            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                _memberClassDataSet = remClient.GetDataSetForMemberManager(userInfo);
            }

            //initialize office employer table
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                _officeEmployerTable = remClient.SelectOfficeEmployerInformation(userInfo, "*", false);
            }//---------------------------

            //initialize hospitalization debit table
            _documentHospitalizationDebitTable = new DataTable("DocumentHospitalizationDebitTable");
            _documentHospitalizationDebitTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            _documentHospitalizationDebitTable.Columns.Add("sysid_inhousedebit", System.Type.GetType("System.String"));
            _documentHospitalizationDebitTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            _documentHospitalizationDebitTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            _documentHospitalizationDebitTable.Columns.Add("document_information", System.Type.GetType("System.String"));
        }//-------------------------        

        //this procedure will determine if the file is for update or create in house hospitalization debit document
        private void InsertInHouseHospitalizationDebitToTempTable(ref DataTable newTable, String originalName, String fileFullName)
        {
            if (_documentHospitalizationDebitTable != null)
            {
                String strFilter = "original_name = '" + originalName + "'";
                DataRow[] selectRow = _documentHospitalizationDebitTable.Select(strFilter);

                foreach (DataRow docRow in selectRow)
                {
                    if (RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0")) > 0)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                        newRow["sysid_inhousedebit"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_inhousedebit", String.Empty);
                        newRow["file_data"] = BaseServices.ProcStatic.GetFileArrayBytes(fileFullName);
                        newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                        newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);

                        newTable.Rows.Add(newRow);

                        newRow.AcceptChanges();
                        newRow.SetModified();
                    }
                    else
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                        newRow["sysid_inhousedebit"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_inhousedebit", String.Empty);
                        newRow["file_data"] = BaseServices.ProcStatic.GetFileArrayBytes(fileFullName);
                        newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                        newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);

                        newTable.Rows.Add(newRow);
                    }

                    break;
                }
            }
        }//--------------------

        //this procedure will print In-House Hospitalization Debit Information
        public void PrintInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationDebit inHouseHopitalizationDebiInfo,
            Decimal assistanceBeginningBalancePerYear, Decimal hospitalizationMaximumAmount, HospitalizationDebit frmHospitalization)
        {
            DataTable hospitalizationDebitTable = new DataTable("HospitalizationDebitTable");
            hospitalizationDebitTable.Columns.Add("description", System.Type.GetType("System.String"));
            hospitalizationDebitTable.Columns.Add("amount", System.Type.GetType("System.String"));
            hospitalizationDebitTable.Columns.Add("balance", System.Type.GetType("System.String"));
            hospitalizationDebitTable.Columns.Add("bold", System.Type.GetType("System.String"));

            DataRow newRowLineOne = hospitalizationDebitTable.NewRow();

            newRowLineOne["description"] = String.Empty;
            newRowLineOne["amount"] = String.Empty;
            newRowLineOne["balance"] = String.Empty;
            newRowLineOne["bold"] = String.Empty;

            hospitalizationDebitTable.Rows.Add(newRowLineOne);

            DataRow newRowCurrentBalance = hospitalizationDebitTable.NewRow();

            newRowCurrentBalance["description"] = "CURRENT BALANCE FOR THE YEAR " + DateTime.Parse(inHouseHopitalizationDebiInfo.ReflectedDate).Year;
            newRowCurrentBalance["amount"] = String.Empty;
            newRowCurrentBalance["balance"] = assistanceBeginningBalancePerYear.ToString("N");
            newRowCurrentBalance["bold"] = "<b>";

            hospitalizationDebitTable.Rows.Add(newRowCurrentBalance);

            Decimal totalIncludeCoverage = 0;

            if (inHouseHopitalizationDebiInfo.IncludeCoverageList.Count > 0)
            {
                DataRow newRowAdd = hospitalizationDebitTable.NewRow();

                newRowAdd["description"] = "Add:";
                newRowAdd["amount"] = String.Empty;
                newRowAdd["balance"] = String.Empty;
                newRowAdd["bold"] = String.Empty;

                hospitalizationDebitTable.Rows.Add(newRowAdd);

                foreach (CommonExchange.InHouseIncludeCoverage list in inHouseHopitalizationDebiInfo.IncludeCoverageList)
                {
                    if (list.ObjectState != DataRowState.Deleted)
                    {
                        DataRow newAddRow = hospitalizationDebitTable.NewRow();

                        newAddRow["description"] = "      " + list.IncludeCoverageInfo.IncludeCoverageDescription;
                        newAddRow["amount"] = list.IncludeAmount.ToString("N");
                        newAddRow["balance"] = String.Empty;
                        newAddRow["bold"] = String.Empty;

                        hospitalizationDebitTable.Rows.Add(newAddRow);

                        totalIncludeCoverage += list.IncludeAmount;
                    }
                }

                //DataRow newRowSubTotalAdd = hospitalizationDebitTable.NewRow();

                //newRowSubTotalAdd["description"] = "             Sub Total";
                //newRowSubTotalAdd["amount"] = totalIncludeCoverage.ToString("N");
                //newRowSubTotalAdd["balance"] = String.Empty;
                //newRowSubTotalAdd["bold"] = String.Empty;

                //hospitalizationDebitTable.Rows.Add(newRowSubTotalAdd);
            }

            //Decimal totalExcludeCoverage = 0;

            //if (inHouseHopitalizationDebiInfo.ExcludeCoverageList.Count > 0)
            //{
            //    DataRow newRowLess = hospitalizationDebitTable.NewRow();

            //    newRowLess["description"] = "Less:";
            //    newRowLess["amount"] = String.Empty;
            //    newRowLess["balance"] = String.Empty;
            //    newRowLess["bold"] = String.Empty;

            //    hospitalizationDebitTable.Rows.Add(newRowLess);

            //    foreach (CommonExchange.InHouseExcludeCoverage list in inHouseHopitalizationDebiInfo.ExcludeCoverageList)
            //    {
            //        if (list.ObjectState != DataRowState.Deleted)
            //        {
            //            DataRow newLessRow = hospitalizationDebitTable.NewRow();

            //            newLessRow["description"] = "      " + list.ExcludeCoverageInfo.ExcludeCoverageDescription;
            //            newLessRow["amount"] = "(" + list.ExcludeAmount.ToString("N") + ")";
            //            newLessRow["balance"] = String.Empty;
            //            newLessRow["bold"] = String.Empty;

            //            hospitalizationDebitTable.Rows.Add(newLessRow);

            //            totalExcludeCoverage += list.ExcludeAmount;
            //        }
            //    }

            //    DataRow newRowSubTotalLess = hospitalizationDebitTable.NewRow();

            //    newRowSubTotalLess["description"] = "             Sub Total";
            //    newRowSubTotalLess["amount"] = "(" + totalExcludeCoverage.ToString("N") + ")";
            //    newRowSubTotalLess["balance"] = String.Empty;
            //    newRowSubTotalLess["bold"] = String.Empty;

            //    hospitalizationDebitTable.Rows.Add(newRowSubTotalLess);
            //}

            DataRow newRowNetAsssistance = hospitalizationDebitTable.NewRow();

            newRowNetAsssistance["description"] = "Total Allowable Hospitalization Assistance";
            newRowNetAsssistance["amount"] = String.Empty;
            newRowNetAsssistance["balance"] = totalIncludeCoverage.ToString("N");
            newRowNetAsssistance["bold"] = "<b>";

            hospitalizationDebitTable.Rows.Add(newRowNetAsssistance);

            DataRow newRowAvailed = hospitalizationDebitTable.NewRow();

            newRowAvailed["description"] = "Hospitalization Assistance Availed";
            newRowAvailed["amount"] = String.Empty;
            newRowAvailed["balance"] = "(" + inHouseHopitalizationDebiInfo.NetAssistanceAmount.ToString("N") + ")";
            newRowAvailed["bold"] = "<b>";

            hospitalizationDebitTable.Rows.Add(newRowAvailed);

            DataRow newRowLinethree = hospitalizationDebitTable.NewRow();

            newRowLinethree["description"] = String.Empty;
            newRowLinethree["amount"] = String.Empty;
            newRowLinethree["balance"] = String.Empty;
            newRowLinethree["bold"] = "<b>";

            hospitalizationDebitTable.Rows.Add(newRowLinethree);

            DataRow newRowYearBalance = hospitalizationDebitTable.NewRow();

            newRowYearBalance["description"] = "BALANCE FOR THE YEAR AFTER AVAILED ASSISTANCE";
            newRowYearBalance["amount"] = String.Empty;
            newRowYearBalance["balance"] = assistanceBeginningBalancePerYear.ToString("N");
            
            newRowYearBalance["bold"] = "<b>";

            hospitalizationDebitTable.Rows.Add(newRowYearBalance);

            long wholeNum = this.GetWholeNumberTenthDecimal(inHouseHopitalizationDebiInfo.NetAssistanceAmount, true);
            int decNum = (int)this.GetWholeNumberTenthDecimal(inHouseHopitalizationDebiInfo.NetAssistanceAmount, false);

            BaseServices.ConvertNumberWords numberToWordsManager = new BaseServices.ConvertNumberWords();

            numberToWordsManager.ProcessNumber(wholeNum, decNum);

            using (ClassMemberServices.CrystalReport.CrystalInHouseHospitalization rptInHouseHospitalization = new
                   MemberServices.ClassMemberServices.CrystalReport.CrystalInHouseHospitalization())
            {
                rptInHouseHospitalization.Database.Tables["hospitalization_debit"].SetDataSource(hospitalizationDebitTable);

                rptInHouseHospitalization.SetParameterValue("@company_name", CommonExchange.CompanyInformation.CompanyName);
                rptInHouseHospitalization.SetParameterValue("@company_address", CommonExchange.CompanyInformation.Address);
                rptInHouseHospitalization.SetParameterValue("@company_phone_nos", CommonExchange.CompanyInformation.PhoneNos);
                rptInHouseHospitalization.SetParameterValue("@report_name", "In-House Hospitalization Assistance Program");
                rptInHouseHospitalization.SetParameterValue("@hospital_name", inHouseHopitalizationDebiInfo.HospitalName);
                rptInHouseHospitalization.SetParameterValue("@max_assistance", hospitalizationMaximumAmount.ToString("N"));
                rptInHouseHospitalization.SetParameterValue("@inclusive_dates", DateTime.Parse(inHouseHopitalizationDebiInfo.DateFrom).ToShortDateString() + " - " +
                    DateTime.Parse(inHouseHopitalizationDebiInfo.DateTo).ToShortDateString());
                rptInHouseHospitalization.SetParameterValue("@cause_of_admission", inHouseHopitalizationDebiInfo.CauseOfAdmission);
                rptInHouseHospitalization.SetParameterValue("@date_approved", DateTime.Parse(inHouseHopitalizationDebiInfo.ReflectedDate).ToLongDateString());
                rptInHouseHospitalization.SetParameterValue("@name_of_member",
                    BaseServices.ProcStatic.GetCompleteNameMiddleInitial(inHouseHopitalizationDebiInfo.MemberInfo.PersonInfo.LastName,
                    inHouseHopitalizationDebiInfo.MemberInfo.PersonInfo.FirstName, inHouseHopitalizationDebiInfo.MemberInfo.PersonInfo.MiddleName));
                rptInHouseHospitalization.SetParameterValue("@office", inHouseHopitalizationDebiInfo.MemberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerName +
                    "  [" + inHouseHopitalizationDebiInfo.MemberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerAcronym + "]");
                rptInHouseHospitalization.SetParameterValue("@user_name",
                    BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName, userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));
                rptInHouseHospitalization.SetParameterValue("@Approved_by", CommonExchange.CompanyInformation.Manager);
                rptInHouseHospitalization.SetParameterValue("@receipt_info", "       Received the amount of " + numberToWordsManager.NumberString + " Only (PHP " +
                    inHouseHopitalizationDebiInfo.NetAssistanceAmount.ToString("N") + ") as medical assistance of his/her confinement for the period state above.");

                using (BaseServices.CrystalReportViewer frmViewr = new BaseServices.CrystalReportViewer(rptInHouseHospitalization))
                {
                    frmViewr.Text = "   In-House Hospitalization Assistance Program";
                    frmViewr.ShowDialog(frmHospitalization);
                }
            }
        }//---------------------------

        //this procedure will insert member information
        public void InsertMemberInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Member memberInfo)
        {
            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                remClient.InsertMemberInformation(userInfo, ref memberInfo);
            }

            //using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            //{
            //    if (base._personDocumentTable != null)
            //    {
            //        Int32 index = 0;

            //        foreach (DataRow docRow in _personDocumentTable.Rows)
            //        {
            //            if (docRow.RowState != DataRowState.Deleted &&
            //                String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_person", String.Empty)))
            //            {
            //                DataRow editRow = _personDocumentTable.Rows[index];

            //                editRow.BeginEdit();

            //                editRow["sysid_person"] = memberInfo.PersonInfo.PersonSysId;

            //                editRow.EndEdit();

            //                if (docRow.RowState == DataRowState.Added)
            //                {
            //                    editRow.AcceptChanges();
            //                    editRow.SetAdded();
            //                }
            //            }

            //            index++;
            //        }

            //        //insert, update and delete Person Document Information
            //        remClient.InsertUpdateDeletePersonDocument(userInfo, _personDocumentTable);
            //        //-----------------------------
            //    }
            //}

            if (_memberInfoTable != null)
            {
                DataRow newRow = _memberInfoTable.NewRow();

                newRow["member_id"] = memberInfo.MemberId;
                newRow["occupation"] = memberInfo.PersonInfo.Occupation;
                newRow["last_name"] = memberInfo.PersonInfo.LastName;
                newRow["first_name"] = memberInfo.PersonInfo.FirstName;
                newRow["middle_name"] = memberInfo.PersonInfo.MiddleName;
                newRow["present_address"] = memberInfo.PersonInfo.PresentAddress;
                newRow["present_phone_nos"] = memberInfo.PersonInfo.PresentPhoneNos;
                newRow["home_address"] = memberInfo.PersonInfo.HomeAddress;
                newRow["home_phone_nos"] = memberInfo.PersonInfo.HomePhoneNos;
                newRow["office_employer_name"] = memberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerName;
                newRow["office_office_employer_acronym"] = memberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerAcronym;

                _memberInfoTable.Rows.Add(newRow);
            }
        }//--------------------------

        //this procedure will update member information
        public void UpdateMemberInformation(CommonExchange.SysAccess userInfo, CommonExchange.Member memberInfo)
        {
            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                remClient.UpdateMemberInformation(userInfo, memberInfo);
            }

            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                if (_personDocumentTable != null)
                {
                    Int32 index = 0;

                    foreach (DataRow docRow in _personDocumentTable.Rows)
                    {
                        if (docRow.RowState != DataRowState.Deleted &&
                            String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_person", String.Empty)))
                        {
                            DataRow editRow = _personDocumentTable.Rows[index];

                            editRow.BeginEdit();

                            editRow["sysid_person"] = memberInfo.PersonInfo.PersonSysId;

                            editRow.EndEdit();

                            if (docRow.RowState == DataRowState.Added)
                            {
                                editRow.AcceptChanges();
                                editRow.SetAdded();
                            }
                        }

                        index++;
                    }

                    //insert, update and delete Person Document Information
                    remClient.InsertUpdateDeletePersonDocument(userInfo, _personDocumentTable);
                    //-----------------------------
                }
            }

            if (_memberInfoTable != null)
            {
                Int32 index = 0;

                foreach (DataRow memRow in _memberInfoTable.Rows)
                {
                    if (memRow.RowState != DataRowState.Deleted &&
                        String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(memRow, "sysid_member", String.Empty), memberInfo.MemberSysId))
                    {
                        DataRow editRow = _memberInfoTable.Rows[index];

                        editRow.BeginEdit();

                        editRow["member_id"] = memberInfo.MemberId;
                        editRow["occupation"] = memberInfo.PersonInfo.Occupation;
                        editRow["last_name"] = memberInfo.PersonInfo.LastName;
                        editRow["first_name"] = memberInfo.PersonInfo.FirstName;
                        editRow["middle_name"] = memberInfo.PersonInfo.MiddleName;
                        editRow["present_address"] = memberInfo.PersonInfo.PresentAddress;
                        editRow["present_phone_nos"] = memberInfo.PersonInfo.PresentPhoneNos;
                        editRow["home_address"] = memberInfo.PersonInfo.HomeAddress;
                        editRow["home_phone_nos"] = memberInfo.PersonInfo.HomePhoneNos;
                        editRow["office_employer_name"] = memberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerName;
                        editRow["office_office_employer_acronym"] = memberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerAcronym;

                        editRow.EndEdit();
                    }

                    index++;
                }
            }
        }//---------------------

        //this procedure will insert collateral information
        public void InsertCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo)
        {
            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                remClient.InsertCollateralInformation(userInfo, ref collateralInfo);
            }

            if (_collateralInformationTable != null)
            {
                DataRow newRow = _collateralInformationTable.NewRow();

                newRow["sysid_collateral"] = collateralInfo.CollateralSysId;
                newRow["property_type"] = collateralInfo.PropertyType;
                newRow["property_brand"] = collateralInfo.PropertyBrand;
                newRow["serial_no"] = collateralInfo.SerialNo;
                newRow["purchase_price"] = collateralInfo.PurchasePrice;
                newRow["year_purchased"] = collateralInfo.YearPurchased;
                newRow["estimated_appraised_value"] = collateralInfo.EstimatedAppraisedValue;
                newRow["remarks"] = collateralInfo.Remarks;
                newRow["is_marked_deleted"] = collateralInfo.IsMarkedDeleted;
                newRow["sysid_member"] = collateralInfo.MemberInfo.MemberSysId;
                newRow["member_id"] = collateralInfo.MemberInfo.MemberId;
                newRow["last_name"] = collateralInfo.MemberInfo.PersonInfo.LastName;
                newRow["first_name"] = collateralInfo.MemberInfo.PersonInfo.FirstName;
                newRow["middle_name"] = collateralInfo.MemberInfo.PersonInfo.MiddleName;

                _collateralInformationTable.Rows.Add(newRow);
            }
        }//--------------------------

        //this procedure will update collateral information
        public void UpdateCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo)
        {
            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                remClient.UpdateCollateralInformation(userInfo, collateralInfo);
            }

            if (_collateralInformationTable != null)
            {
                Int32 index = 0;

                foreach (DataRow colRow in _collateralInformationTable.Rows)
                {
                    if (colRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(collateralInfo.CollateralSysId, RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty)))
                        {
                            DataRow editRow = _collateralInformationTable.Rows[index];

                            editRow.BeginEdit();

                            editRow["sysid_collateral"] = collateralInfo.CollateralSysId;
                            editRow["property_type"] = collateralInfo.PropertyType;
                            editRow["property_brand"] = collateralInfo.PropertyBrand;
                            editRow["serial_no"] = collateralInfo.SerialNo;
                            editRow["purchase_price"] = collateralInfo.PurchasePrice;
                            editRow["year_purchased"] = collateralInfo.YearPurchased;
                            editRow["estimated_appraised_value"] = collateralInfo.EstimatedAppraisedValue;
                            editRow["remarks"] = collateralInfo.Remarks;
                            editRow["is_marked_deleted"] = collateralInfo.IsMarkedDeleted;
                            editRow["sysid_member"] = collateralInfo.MemberInfo.MemberSysId;
                            editRow["member_id"] = collateralInfo.MemberInfo.MemberId;
                            editRow["last_name"] = collateralInfo.MemberInfo.PersonInfo.LastName;
                            editRow["first_name"] = collateralInfo.MemberInfo.PersonInfo.FirstName;
                            editRow["middle_name"] = collateralInfo.MemberInfo.PersonInfo.MiddleName;

                            editRow.EndEdit();

                            break;
                        }
                    }

                    index++;
                }
            }
        }//--------------------------

        //this procedure will delete collateral information
        public void DeleteCollateralInformation(CommonExchange.SysAccess userInfo, CommonExchange.Collateral collateralInfo)
        {
            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                remClient.DeleteCollateralInformation(userInfo, collateralInfo);
            }

            if (_collateralInformationTable != null)
            {
                Int32 index = 0;

                foreach (DataRow colRow in _collateralInformationTable.Rows)
                {
                    if (colRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(collateralInfo.CollateralSysId, RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty)))
                        {
                            DataRow delRow = _collateralInformationTable.Rows[index];

                            delRow.Delete();

                            break;
                        }
                    }

                    index++;
                }
            }
        }//--------------------------
        
        //this procedure will update member other creditor information
        public void UpdateDeleteMemberOtherCreditorInformation(List<CommonExchange.OtherCreditor> otherCreditorList, 
            CommonExchange.OtherCreditor otherCreditorInfo)
        {
            Int32 index = 0;

            foreach (CommonExchange.OtherCreditor list in otherCreditorList)
            {
                if (list.OtherCreditorId == otherCreditorInfo.OtherCreditorId)
                {
                    otherCreditorList.RemoveAt(index);

                    break;
                }

                index++;
            }

            otherCreditorList.Add(otherCreditorInfo);
        }//-------------------------

        //this procedure will insert update shared capital information
        public void InsertUpdateShareCapitalInformation(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalInformation shareCapitalInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertUpdateShareCapitalInformation(userInfo, shareCapitalInfo);
            }
        }//------------------------

        //this procedure will insert share capital information
        public void InsertShareCapital(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit shareCapitalInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertShareCapitalCredit(userInfo, shareCapitalInfo);
            }
        }//----------------------------

        //this procedure will update share capital information
        public void UpdateShareCapital(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit shareCapitalInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateShareCapitalCredit(userInfo, shareCapitalInfo);
            }
        }//----------------------------

        //this procedure will delete share capital information
        public void DeleteShareCapital(CommonExchange.SysAccess userInfo, CommonExchange.ShareCapitalCredit shareCapitalInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteShareCapitalCredit(userInfo, shareCapitalInfo);
            }
        }//----------------------------

        //this procedure will insert member's equity information
        public void InsertMembersEquity(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit membersEquityInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertMemberEquityCredit(userInfo, membersEquityInfo);
            }
        }//--------------------------------

        //this procedure will update member's equity information
        public void UpdateMembersEquity(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit membersEquityInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateMemberEquityCredit(userInfo, membersEquityInfo);
            }
        }//--------------------------------

        //this procedure will delete member's equity information
        public void DeleteMembersEquity(CommonExchange.SysAccess userInfo, CommonExchange.MemberEquityCredit membersEquityInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteMemberEquityCredit(userInfo, membersEquityInfo);
            }
        }//--------------------------------

        //this procedure will insert update hospitalization information
        public void InsertUpdateHospitalizationInformation(CommonExchange.SysAccess userInfo,
            CommonExchange.InHouseHospitalizationInformation hospitalizationInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertUpdateInHouseHospitalizationInformation(userInfo, hospitalizationInfo);
            }
        }//-------------------------

        //this procedure will insert hospitalization include coverage
        public void InsertHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationIncludeCoverage includeCoverageInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertHospitalizationIncludeCoverage(userInfo, ref includeCoverageInfo);
            }
        }//-------------------------

        //this procedure will update hospitalization include coverage
        public void UpdateHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationIncludeCoverage includeCoverageInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateHospitalizationIncludeCoverage(userInfo, includeCoverageInfo);
            }
        }//----------------------------

        //this procedure will delete hospitalization include coverage
        public void DeleteHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationIncludeCoverage includeCoverageInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteHospitalizationIncludeCoverage(userInfo, includeCoverageInfo);
            }
        }//-----------------------------

        //this procedure will insert hospitalization exclude coverage
        public void InsertHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationExcludeCoverage excludeCoverageInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertHospitalizationExcludeCoverage(userInfo, ref excludeCoverageInfo);
            }
        }//------------------------

        //this procedure will update hospitalization exclude coverage
        public void UpdateHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationExcludeCoverage excludeCoverageInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateHospitalizationExcludeCoverage(userInfo, excludeCoverageInfo);
            }
        }//-------------------------

        //this procedure will delete hospitalization exclude coverage
        public void DeleteHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, CommonExchange.HospitalizationExcludeCoverage excludeCoverageInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteHospitalizationExcludeCoverage(userInfo, excludeCoverageInfo);
            }
        }//------------------------

        //this procedure will insert in house hospitalization debit
        public void InsertUpdateInHouseHospitalizationDebitInfo(CommonExchange.SysAccess userInfo,ref CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo)
        {
            if (String.IsNullOrEmpty(inHouseDebitInfo.InHouseDebitSysId))
            {
                using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
                {
                    remClient.InsertInHouseHospitalizationDebit(userInfo, ref inHouseDebitInfo);
                }

                if (_debitHospitalizationTable != null)
                {
                    DataRow newRow = _debitHospitalizationTable.NewRow();

                    newRow["cause_of_admission"] = inHouseDebitInfo.CauseOfAdmission;
                    newRow["date_from"] = inHouseDebitInfo.DateFrom;
                    newRow["date_to"] = inHouseDebitInfo.DateTo;
                    newRow["hospital_name"] = inHouseDebitInfo.HospitalName;
                    newRow["sysid_inhousedebit"] = inHouseDebitInfo.InHouseDebitSysId;
                    newRow["net_assistance_amount"] = inHouseDebitInfo.NetAssistanceAmount;
                    newRow["reflected_date"] = inHouseDebitInfo.ReflectedDate;
                    newRow["remarks"] = inHouseDebitInfo.Remarks;

                    _debitHospitalizationTable.Rows.Add(newRow);
                }
            }
            else
            {
                using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
                {
                    remClient.UpdateInHouseHospitalizationDebit(userInfo, inHouseDebitInfo);
                }

                if (_debitHospitalizationTable != null)
                {
                    Int32 index = 0;

                    foreach (DataRow debitRow in _debitHospitalizationTable.Rows)
                    {
                        if (debitRow.RowState != DataRowState.Deleted)
                        {
                            if (String.Equals(inHouseDebitInfo.InHouseDebitSysId,
                                RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "sysid_inhousedebit", String.Empty)))
                            {
                                DataRow editRow = _debitHospitalizationTable.Rows[index];

                                editRow.BeginEdit();

                                editRow["cause_of_admission"] = inHouseDebitInfo.CauseOfAdmission;
                                editRow["date_from"] = inHouseDebitInfo.DateFrom;
                                editRow["date_to"] = inHouseDebitInfo.DateTo;
                                editRow["hospital_name"] = inHouseDebitInfo.HospitalName;
                                editRow["sysid_inhousedebit"] = inHouseDebitInfo.InHouseDebitSysId;
                                editRow["net_assistance_amount"] = inHouseDebitInfo.NetAssistanceAmount;
                                editRow["reflected_date"] = inHouseDebitInfo.ReflectedDate;
                                editRow["remarks"] = inHouseDebitInfo.Remarks;

                                editRow.EndEdit();

                                break;
                            }
                        }

                        index++;
                    }
                }
            }
        }//-----------------------

        //this procedure will delete in house hospitalization debit
        public void DeleteInHouseHospitalizationDebit(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteInHouseHospitalizationDebit(userInfo, inHouseDebitInfo);
            }

            if (_debitHospitalizationTable != null)
            {
                Int32 index = 0;

                foreach (DataRow debitRow in _debitHospitalizationTable.Rows)
                {
                    if (debitRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(inHouseDebitInfo.InHouseDebitSysId,
                            RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "sysid_inhousedebit", String.Empty)))
                        {
                            DataRow delRow = _debitHospitalizationTable.Rows[index];

                            delRow.Delete();

                            break;
                        }
                    }

                    index++;
                }
            }
        }//-------------------------

        //this procedure will insert in house hospitalization debit document
        public void InsertInHouseHospitalizationDebitDocument(CommonExchange.InHouseHospitalizationDebit inHouseHospitalizationDebitInfo, 
            String original_name, Byte[] fileData)
        {
            if (_documentHospitalizationDebitTable != null)
            {
                if (!Directory.Exists(inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath)))
                {
                    //creates the directory
                    DirectoryInfo dirInfo = new DirectoryInfo(inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath));
                    dirInfo.Create();
                    dirInfo.Attributes = FileAttributes.Hidden;
                }

                DataRow newRow = _documentHospitalizationDebitTable.NewRow();

                newRow["document_id"] = _inHouseHospitalizationDebitId--;
                newRow["sysid_inhousedebit"] = inHouseHospitalizationDebitInfo.InHouseDebitSysId;
                newRow["file_data"] = fileData;
                newRow["original_name"] = original_name;

                _documentHospitalizationDebitTable.Rows.Add(newRow);
            }
        }//--------------------------

        //this procedure will insert update in house hospitalization debit document information
        public void InsertUpdateInHouseHospitalizationDebitDocumentInformationInformation(String original_name, String strDocumentInfo)
        {
            if (_documentHospitalizationDebitTable != null)
            {
                Int32 index = 0;

                foreach (DataRow docRow in _documentHospitalizationDebitTable.Rows)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(original_name, RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty)))
                        {
                            DataRow editRow = _documentHospitalizationDebitTable.Rows[index];

                            editRow.BeginEdit();

                            editRow["document_information"] = strDocumentInfo;

                            editRow.EndEdit();

                            if (docRow.RowState == DataRowState.Added)
                            {
                                editRow.AcceptChanges();
                                editRow.SetAdded();
                            }
                        }
                    }

                    index++;
                }
            }
        }//--------------------------------

        //this procedure will delete in house hospitalization debit  document
        public void DeleteInHouseHospitalizationDebitDocument(CommonExchange.InHouseHospitalizationDebit inHouseHospitalizationDebitInfo, String originalName, String startUpPath)
        {
            if (_documentHospitalizationDebitTable != null)
            {
                Int32 index = 0;

                foreach (DataRow docRow in _documentHospitalizationDebitTable.Rows)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty), originalName))
                        {
                            DataRow delRow = _documentHospitalizationDebitTable.Rows[index];

                            delRow.Delete();

                            //delete from file
                            if (File.Exists(inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(startUpPath) + originalName))
                            {
                                File.Delete(inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(startUpPath) + originalName);
                            }
                        }
                    }

                    index++;
                }
            }
        }//---------------------------

        //this procedure will insert update delete loan document information
        public void InsertUpdateDeleteInHouseHospitaliationDebitDocumentInformation(CommonExchange.SysAccess userInfo, String dirPath)
        {
            DataTable newTable = new DataTable("InHouseHospitalizationDebitDocumentTableTemp");
            newTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            newTable.Columns.Add("sysid_inhousedebit", System.Type.GetType("System.String"));
            newTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            newTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            newTable.Columns.Add("document_information", System.Type.GetType("System.String"));

            DirectoryInfo dir = new DirectoryInfo(dirPath);

            foreach (FileInfo file in dir.GetFiles())
            {
                this.InsertInHouseHospitalizationDebitToTempTable(ref newTable, file.Name, file.FullName);
            }

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                //insert, update and delete In House Hospitalization Debit Document Information
                remClient.InsertUpdateDeleteHospitalizationDocument(userInfo, newTable);
                //-----------------------------
            }
        }//-------------------------        

        //this procedure will initialize clasification combobox
        public void InitializeClassificationCombo(ComboBox cboBase)
        {
            cboBase.Items.Clear();

            if (_memberClassDataSet.Tables["MemberClassificationTable"] != null)
            {
                foreach (DataRow cRow in _memberClassDataSet.Tables["MemberClassificationTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(cRow, "classification_description", String.Empty));
                }
            }

            cboBase.SelectedIndex = -1;
        }//----------------------

        //this procedure will initialize clasification combobox
        public void InitializeClassificationCombo(ComboBox cboBase, String classificationId)
        {
            cboBase.Items.Clear();

            Int32 index = 0;
            Boolean isIndexed = false;

            if (_memberClassDataSet.Tables["MemberClassificationTable"] != null)
            {
                foreach (DataRow cRow in _memberClassDataSet.Tables["MemberClassificationTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(cRow, "classification_description", String.Empty));

                    if (!isIndexed)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(cRow, "classification_id", String.Empty), classificationId))
                        {
                            cboBase.SelectedIndex = index;
                            isIndexed = true;
                        }

                        index++;
                    }
                }
            }
        }//----------------------

        //this procedure will initialize member type combobox
        public void InitializeMemberTypeComboBox(ComboBox cboBase)
        {
            cboBase.Items.Clear();

            if (_memberClassDataSet.Tables["MemberTypeTable"] != null)
            {
                foreach (DataRow cRow in _memberClassDataSet.Tables["MemberTypeTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(cRow, "member_type_description", String.Empty));
                }
            }

            cboBase.SelectedIndex = -1;
        }//---------------------------

        //this procedure will initialize member type combobox
        public void InitializeMemberTypeComboBox(ComboBox cboBase, String typeId)
        {
            cboBase.Items.Clear();

            Int32 index = 0;
            Boolean isIndexed = false;

            if (_memberClassDataSet.Tables["MemberTypeTable"] != null)
            {
                foreach (DataRow cRow in _memberClassDataSet.Tables["MemberTypeTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(cRow, "member_type_description", String.Empty));

                    if (!isIndexed)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(cRow, "member_type_id", String.Empty), typeId))
                        {
                            cboBase.SelectedIndex = index;
                            isIndexed = true;
                        }

                        index++;
                    }
                }
            }
        }//------------------------------

        //this procedure will initialize office employer checked list box
        public void InitializeOfficeEmployerCheckedListBox(CheckedListBox cbxBase)
        {
            cbxBase.Items.Clear();

            if (_officeEmployerTable != null)
            {
                foreach (DataRow officeRow in _officeEmployerTable.Rows)
                {
                    cbxBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_name", String.Empty) + " [" +
                        RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_acronym", String.Empty) + "]");
                }
            }
        }//--------------------------

        //this procedure will initialize member classification checked list box
        public void InitializeMemberClassificationCheckedListBox(CheckedListBox cbxBase)
        {
            cbxBase.Items.Clear();

            if (_memberClassDataSet.Tables["MemberClassificationTable"] != null)
            {
                foreach (DataRow memRow in _memberClassDataSet.Tables["MemberClassificationTable"].Rows)
                {
                    cbxBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(memRow, "classification_description", String.Empty));
                }
            }
        }//------------------------

        //this procedure will initialize member type checked list box
        public void InitializeMemberTypeCheckedListBox(CheckedListBox cbxBase)
        {
            cbxBase.Items.Clear();

            if (_memberClassDataSet.Tables["MemberTypeTable"] != null)
            {
                foreach (DataRow memRow in _memberClassDataSet.Tables["MemberTypeTable"].Rows)
                {
                    cbxBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_type_description", String.Empty));
                }
            }
        }//-----------------------

        //this procedure will initialize payment interval combobox
        public void InitializePaymentIntervalComboBox(ComboBox cboBase)
        {
            cboBase.Items.Clear();

            if (_memberClassDataSet.Tables["RepaymentScheduleTable"] != null)
            {
                foreach (DataRow payRow in _memberClassDataSet.Tables["RepaymentScheduleTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(payRow, "repayment_description", String.Empty));
                }
            }
        }//---------------------

        //this procedure will initialize payment interval combobox
        public void InitializePaymentIntervalComboBox(ComboBox cboBase, String repaymentId)
        {
            cboBase.Items.Clear();

            Int32 index = 0;
            Boolean isIndexed = false;


            if (_memberClassDataSet.Tables["RepaymentScheduleTable"] != null)
            {
                foreach (DataRow payRow in _memberClassDataSet.Tables["RepaymentScheduleTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(payRow, "repayment_description", String.Empty));

                    if (!isIndexed)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(payRow, "repayment_id", String.Empty), repaymentId))
                        {
                            cboBase.SelectedIndex = index;
                            isIndexed = true;
                        }

                        index++;
                    }
                }
            }
        }//---------------------       

        //this procedure will initialize In house hospitalization debit charges summary
        public void InitializeInHouseHospitalizationDebitChargesSummary(ListView lsvBase, 
            CommonExchange.InHouseHospitalizationDebit inHouseHopitalizationDebiInfo, Decimal assistanceBeginningBalancePerYear, Decimal hospitalizationMaximumAmount)
        {
            if (inHouseHopitalizationDebiInfo.IncludeCoverageList.Count > 0 || inHouseHopitalizationDebiInfo.ExcludeCoverageList.Count > 0)
            {
                lsvBase.Items.Clear();

                ListViewItem lviMaximumAssistance = new ListViewItem(new String[] {"MAXIMUM ASSISTANCE ALLOWABLE/YEAR", String.Empty,
                    hospitalizationMaximumAmount.ToString("N"), String.Empty, String.Empty }, lsvBase.Groups[0]);
                lviMaximumAssistance.ForeColor = Color.Black;
                lsvBase.Items.Add(lviMaximumAssistance);

                ListViewItem lviNewLine = new ListViewItem(new String[] {String.Empty, String.Empty, String.Empty, String.Empty, String.Empty }, lsvBase.Groups[0]);
                lviNewLine.ForeColor = Color.Orange;
                lsvBase.Items.Add(lviNewLine);            


                ListViewItem lviBeginningBalance = new ListViewItem(new String[] {"CURRENT BALANCE FOR THE YEAR  ", String.Empty,
                    assistanceBeginningBalancePerYear.ToString("N"), String.Empty, String.Empty }, lsvBase.Groups[0]);
                lviBeginningBalance.ForeColor = Color.Black;
                lsvBase.Items.Add(lviBeginningBalance);

                ListViewItem lviAdd = new ListViewItem(new String[] { "Add:", String.Empty, String.Empty, String.Empty, String.Empty }, lsvBase.Groups[0]);
                lviAdd.ForeColor = Color.Orange;
                lsvBase.Items.Add(lviAdd);

                Decimal totalIncludeCoverage = 0;

                foreach (CommonExchange.InHouseIncludeCoverage list in inHouseHopitalizationDebiInfo.IncludeCoverageList)
                {
                    if (list.ObjectState != DataRowState.Deleted)
                    {
                        ListViewItem includeCoverageItem = new ListViewItem(new String[] {"      " + list.IncludeCoverageInfo.IncludeCoverageDescription,
                            list.IncludeAmount.ToString("N"), String.Empty, list.IncludeCoverageId.ToString(), "True"}, lsvBase.Groups[0]);
                        includeCoverageItem.ForeColor = Color.Black;
                        lsvBase.Items.Add(includeCoverageItem);

                        totalIncludeCoverage += list.IncludeAmount;
                    }
                }

                if (inHouseHopitalizationDebiInfo.IncludeCoverageList.Count <= 0)
                {
                    lsvBase.Items.Remove(lviAdd);
                }
                //else
                //{
                //    ListViewItem lviSubTotalIncludeCoverage = new ListViewItem(new String[] {"             Sub Total", 
                //        totalIncludeCoverage.ToString("N"), String.Empty, String.Empty, String.Empty}, lsvBase.Groups[0]);
                //    lviSubTotalIncludeCoverage.ForeColor = Color.LightCoral;
                //    lsvBase.Items.Add(lviSubTotalIncludeCoverage);
                //}

                //ListViewItem lviLess = new ListViewItem(new String[] { "Less:", String.Empty, String.Empty, String.Empty, String.Empty }, lsvBase.Groups[0]);
                //lsvBase.ForeColor = Color.Orange;
                //lsvBase.Items.Add(lviLess);

                //Decimal totalExcludeCoverage = 0;

                //foreach (CommonExchange.InHouseExcludeCoverage list in inHouseHopitalizationDebiInfo.ExcludeCoverageList)
                //{
                //    if (list.ObjectState != DataRowState.Deleted)
                //    {
                //        ListViewItem excludeCoverageItem = new ListViewItem(new String[] {"      " + list.ExcludeCoverageInfo.ExcludeCoverageDescription,
                //            "(" + list.ExcludeAmount.ToString("N") + ")", String.Empty, list.ExcludeCoverageId.ToString(), "False"}, lsvBase.Groups[0]);
                //        excludeCoverageItem.ForeColor = Color.Black;
                //        lsvBase.Items.Add(excludeCoverageItem);

                //        totalExcludeCoverage += list.ExcludeAmount;
                //    }
                //}

                //if (inHouseHopitalizationDebiInfo.ExcludeCoverageList.Count <= 0)
                //{
                //    lsvBase.Items.Remove(lviLess);
                //}
                //else
                //{
                //    ListViewItem lviSubTotalExcludeCoverage = new ListViewItem(new String[] { "             Sub Total", 
                //        "(" + totalExcludeCoverage.ToString("N") + ")", String.Empty, String.Empty, String.Empty }, lsvBase.Groups[0]);
                //    lviSubTotalExcludeCoverage.ForeColor = Color.LightCoral;
                //    lsvBase.Items.Add(lviSubTotalExcludeCoverage);
                //}

                ListViewItem lviNetAssistance = new ListViewItem(new String[] {"Total Allowable Hospitalization Assistance", String.Empty, 
                    totalIncludeCoverage.ToString("N"), String.Empty, String.Empty}, lsvBase.Groups[0]);
                lviNetAssistance.ForeColor = Color.LightCoral;
                lsvBase.Items.Add(lviNetAssistance);

                ListViewItem lviNewLine1 = new ListViewItem(new String[] { String.Empty, String.Empty, String.Empty, String.Empty, String.Empty }, lsvBase.Groups[0]);
                lviNewLine1.ForeColor = Color.Orange;
                lsvBase.Items.Add(lviNewLine1);   

                ListViewItem lviNetAssistanceAmount = new ListViewItem(new String[] {"Hospitalization Assistance Availed", String.Empty, 
                    "(" + inHouseHopitalizationDebiInfo.NetAssistanceAmount.ToString("N") + ")", String.Empty, String.Empty}, lsvBase.Groups[0]);
                lviNetAssistanceAmount.ForeColor = Color.LightCoral;
                lsvBase.Items.Add(lviNetAssistanceAmount);

                ListViewItem lviNewLine2 = new ListViewItem(new String[] { String.Empty, String.Empty, String.Empty, String.Empty, String.Empty }, lsvBase.Groups[0]);
                lviNewLine2.ForeColor = Color.Orange;
                lsvBase.Items.Add(lviNewLine2);

                if (String.IsNullOrEmpty(inHouseHopitalizationDebiInfo.InHouseDebitSysId))
                {
                    ListViewItem lviBalance = new ListViewItem(new String[] {"BALANCE FOR THE YEAR AFTER AVAILED ASSISTANCE", String.Empty,
                    (assistanceBeginningBalancePerYear - inHouseHopitalizationDebiInfo.NetAssistanceAmount).ToString("N"), String.Empty}, lsvBase.Groups[0]);
                    lviBalance.ForeColor = Color.Red;
                    lsvBase.Items.Add(lviBalance);
                }
                else
                {
                    ListViewItem lviBalance = new ListViewItem(new String[] {"BALANCE FOR THE YEAR AFTER AVAILED ASSISTANCE", String.Empty,
                    assistanceBeginningBalancePerYear.ToString("N"), String.Empty}, lsvBase.Groups[0]);
                    lviBalance.ForeColor = Color.Red;
                    lsvBase.Items.Add(lviBalance);
                }
            }
        }//----------------------

        //this procedure will initialize person document 
        public void InitializeInHospitalizationDebitDocument(CommonExchange.SysAccess userInfo,
            CommonExchange.InHouseHospitalizationDebit inHouseHospitalizationDebitInfo)
        {
            try
            {
                if (!Directory.Exists(inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath)))
                {
                    //creates the directory
                    DirectoryInfo dirInfo = new DirectoryInfo(inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath));
                    dirInfo.Create();
                    dirInfo.Attributes = FileAttributes.Hidden;
                }

                DataTable imageTable;

                using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
                {
                    imageTable = remClient.SelectBySysIDInHouseDebitListHospitalizationDocument(userInfo, inHouseHospitalizationDebitInfo.InHouseDebitSysId);
                }

                foreach (DataRow docRow in imageTable.Rows)
                {
                    DataRow newRow = _documentHospitalizationDebitTable.NewRow();

                    newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                    newRow["sysid_inhousedebit"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_inhousedebit", String.Empty);
                    newRow["file_data"] = docRow["file_data"];
                    newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                    newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);

                    _documentHospitalizationDebitTable.Rows.Add(newRow);
                }

                _documentHospitalizationDebitTable.AcceptChanges();

                using (DataTableReader tableReader = new DataTableReader(imageTable))
                {
                    if (tableReader.HasRows)
                    {
                        Int32 picColumn = 2;

                        while (tableReader.Read())
                        {
                            String imagePath = tableReader["original_name"].ToString();

                            long len = tableReader.GetBytes(picColumn, 0, null, 0, 0);
                            // Create a buffer to hold the bytes, and then
                            // read the bytes from the DataTableReader.
                            Byte[] buffer = new Byte[len];
                            tableReader.GetBytes(picColumn, 0, buffer, 0, (int)len);

                            //create a file stream object, passing the array
                            using (FileStream streame = new FileStream(inHouseHospitalizationDebitInfo.HospitalizationDocumentsFolder(Application.StartupPath)
                                + imagePath, FileMode.Create, FileAccess.Write))
                            {
                                streame.Write(buffer, 0, buffer.Length);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BaseServices.ProcStatic.ShowErrorDialog("Error loading regular loan document module.\n\n" + ex.Message, "Error Loading");
            }
        }//-----------------------------

        //this procedure will initialize member summary tab control
        public void InitializeMemberSummaryListView(CommonExchange.SysAccess userInfo, ListView lsvBase, CommonExchange.Member memberInfo, String dateStart, String dateEnd,
            Decimal totalShareCapitalContribution, Decimal totalMembersEquity, Decimal totalHospitalizationContribution, DataTable regularLoanInformationTable)
        {
            lsvBase.Items.Clear();

            if (regularLoanInformationTable != null)
            {
                String strFilter = "is_active_loan = 1";
                DataRow[] selectRow = regularLoanInformationTable.Select(strFilter);

                lsvBase.Groups.Add("grpRegularLoans", "Regular Loans");

                Decimal totalReularLoanBalance = 0;

                foreach (DataRow regLoanRow in selectRow)
                {
                    if (regLoanRow.RowState != DataRowState.Deleted)
                    {
                        Decimal loanBalance = (RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "total_amortization_amount", Decimal.Parse("0")) -
                            RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "total_loan_payments", Decimal.Parse("0")));

                        ListViewItem loanItem = new ListViewItem(new String[] { "              " + 
                            RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "account_no", String.Empty) + " - " +
                            RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "regular_loan_type_description", String.Empty), loanBalance.ToString("N") },
                            lsvBase.Groups["grpRegularLoans"]);
                        loanItem.SubItems[0].ForeColor = Color.Blue;
                        loanItem.SubItems[1].ForeColor = Color.Red;
                        loanItem.UseItemStyleForSubItems = false;

                        lsvBase.Items.Add(loanItem);

                        totalReularLoanBalance += loanBalance;
                    }
                }

                if (totalReularLoanBalance > 0)
                {
                    ListViewItem loanBalanceItem = new ListViewItem(new String[] { "                        Total Regular Loan Balances", totalReularLoanBalance.ToString("N") },
                           lsvBase.Groups["grpRegularLoans"]);
                    loanBalanceItem.SubItems[0].ForeColor = Color.LightCoral;
                    loanBalanceItem.SubItems[1].ForeColor = Color.Red;
                    loanBalanceItem.UseItemStyleForSubItems = false;

                    lsvBase.Items.Add(loanBalanceItem);
                }
            }

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _billingStatementTable = remClient.SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices(userInfo, memberInfo.MemberSysId, dateStart, dateEnd);
            }

            Decimal shareCapitalBill = 0;
            Decimal hospitalizationBill = 0;
            Decimal birthDayBill = 0;
            Decimal contingencyBill = 0;
            Decimal salaryBill = 0;
            Decimal medicalBill = 0;
            Decimal specialBill = 0;

            foreach (DataRow billRow in _billingStatementTable.Rows)
            {
                shareCapitalBill += RemoteServerLib.ProcStatic.DataRowConvert(billRow, "share_capital_amount", Decimal.Parse("0"));
                hospitalizationBill += RemoteServerLib.ProcStatic.DataRowConvert(billRow, "hospitalization_amount", Decimal.Parse("0"));
                birthDayBill += (RemoteServerLib.ProcStatic.DataRowConvert(billRow, "birthday_principal", Decimal.Parse("0")) +
                    RemoteServerLib.ProcStatic.DataRowConvert(billRow, "birthday_interest", Decimal.Parse("0")));
                contingencyBill += (RemoteServerLib.ProcStatic.DataRowConvert(billRow, "contingency_principal", Decimal.Parse("0")) +
                   RemoteServerLib.ProcStatic.DataRowConvert(billRow, "contingency_interest", Decimal.Parse("0")));
                salaryBill += (RemoteServerLib.ProcStatic.DataRowConvert(billRow, "salary_principal", Decimal.Parse("0")) +
                    RemoteServerLib.ProcStatic.DataRowConvert(billRow, "salary_interest", Decimal.Parse("0")));
                medicalBill += (RemoteServerLib.ProcStatic.DataRowConvert(billRow, "medical_principal", Decimal.Parse("0")) +
                    RemoteServerLib.ProcStatic.DataRowConvert(billRow, "medical_interest", Decimal.Parse("0")));
                specialBill += (RemoteServerLib.ProcStatic.DataRowConvert(billRow, "special_principal", Decimal.Parse("0")) +
                    RemoteServerLib.ProcStatic.DataRowConvert(billRow, "special_interest", Decimal.Parse("0")));
            }

            String monthOf = DateTime.Parse(dateStart).ToString("MMMM, yyyy");

            if (totalShareCapitalContribution > 0 || shareCapitalBill > 0)
            {
                lsvBase.Groups.Add("grpShareCapital", "Share Capital");

                if (shareCapitalBill > 0)
                {
                    ListViewItem shareBillItem = new ListViewItem(new String[] { "              Share Capital Bill for " + monthOf, shareCapitalBill.ToString("N") },
                        lsvBase.Groups["grpShareCapital"]);
                    shareBillItem.SubItems[0].ForeColor = Color.Blue;
                    shareBillItem.SubItems[1].ForeColor = Color.Red;
                    shareBillItem.UseItemStyleForSubItems = false;

                    lsvBase.Items.Add(shareBillItem);
                }

                if (totalShareCapitalContribution > 0)
                {
                    ListViewItem shareContItem = new ListViewItem(new String[] { "              Total Share Capital Contribution",
                        totalShareCapitalContribution.ToString("N") }, lsvBase.Groups["grpShareCapital"]);
                    shareContItem.SubItems[0].ForeColor = Color.Blue;
                    shareContItem.SubItems[1].ForeColor = Color.Red;
                    shareContItem.UseItemStyleForSubItems = false;

                    lsvBase.Items.Add(shareContItem);                    
                }
            }

            if (totalMembersEquity > 0)
            {
                lsvBase.Groups.Add("grpMembersEquity", "Member's Equity");

                ListViewItem equityItem = new ListViewItem(new String[] { "              Total Member's Equity", totalMembersEquity.ToString("N") }, lsvBase.Groups["grpMembersEquity"]);
                equityItem.SubItems[0].ForeColor = Color.Blue;
                equityItem.SubItems[1].ForeColor = Color.Red;
                equityItem.UseItemStyleForSubItems = false;

                lsvBase.Items.Add(equityItem);
            }

            if (totalHospitalizationContribution > 0 || hospitalizationBill > 0)
            {
                lsvBase.Groups.Add("grpHospitalization", "Hospitalization");

                if (hospitalizationBill > 0)
                {
                    ListViewItem hospBillItem = new ListViewItem(new String[] { "              Hospitalization Bill for " + monthOf, hospitalizationBill.ToString("N") },
                        lsvBase.Groups["grpHospitaliztion"]);
                    hospBillItem.SubItems[0].ForeColor = Color.Blue;
                    hospBillItem.SubItems[1].ForeColor = Color.Red;
                    hospBillItem.UseItemStyleForSubItems = false;

                    lsvBase.Items.Add(hospBillItem);
                }

                if (totalHospitalizationContribution > 0)
                {
                    ListViewItem hospContrItem = new ListViewItem(new String[] { "              Total Hospitalization Contribution", totalHospitalizationContribution.ToString("N") },
                        lsvBase.Groups["grpHospitalization"]);
                    hospContrItem.SubItems[0].ForeColor = Color.Blue;
                    hospContrItem.SubItems[1].ForeColor = Color.Red;
                    hospContrItem.UseItemStyleForSubItems = false;

                    lsvBase.Items.Add(hospContrItem);
                }
            }

            if (birthDayBill > 0)
            {
                lsvBase.Groups.Add("grpBirthDay", "Birthday Loan");

                ListViewItem birthDayLoanItem = new ListViewItem(new String[] { "              Birthday Loan Bill for " + monthOf, birthDayBill.ToString("N") },
                        lsvBase.Groups["grpBirthDay"]);
                birthDayLoanItem.SubItems[0].ForeColor = Color.Blue;
                birthDayLoanItem.SubItems[1].ForeColor = Color.Red;
                birthDayLoanItem.UseItemStyleForSubItems = false;

                lsvBase.Items.Add(birthDayLoanItem);
            }

            if (contingencyBill > 0)
            {
                lsvBase.Groups.Add("grpContingency", "Contingency Loan");

                ListViewItem contingencyLoanItem = new ListViewItem(new String[] { "              Contingency Loan Bill for " + monthOf, contingencyBill.ToString("N") },
                        lsvBase.Groups["grpContingency"]);
                contingencyLoanItem.SubItems[0].ForeColor = Color.Blue;
                contingencyLoanItem.SubItems[1].ForeColor = Color.Red;
                contingencyLoanItem.UseItemStyleForSubItems = false;

                lsvBase.Items.Add(contingencyLoanItem);
            }

            if (salaryBill > 0)
            {
                lsvBase.Groups.Add("grpSalary", "Salary Loan");

                ListViewItem salarLoanItem = new ListViewItem(new String[] { "              Salary Loan Bill for " + monthOf, salaryBill.ToString("N") },
                        lsvBase.Groups["grpSalary"]);
                salarLoanItem.SubItems[0].ForeColor = Color.Blue;
                salarLoanItem.SubItems[1].ForeColor = Color.Red;
                salarLoanItem.UseItemStyleForSubItems = false;

                lsvBase.Items.Add(salarLoanItem);
            }

            if (medicalBill > 0)
            {
                lsvBase.Groups.Add("grpMedical", "Medical Loan");

                ListViewItem medicalLoanItem = new ListViewItem(new String[] { "              Medical Loan Bill for " + monthOf, medicalBill.ToString("N") },
                       lsvBase.Groups["grpMedical"]);
                medicalLoanItem.SubItems[0].ForeColor = Color.Blue;
                medicalLoanItem.SubItems[1].ForeColor = Color.Red;
                medicalLoanItem.UseItemStyleForSubItems = false;

                lsvBase.Items.Add(medicalLoanItem);
            }

            if (specialBill > 0)
            {
                lsvBase.Groups.Add("grpSpecial", "Special Loan");

                ListViewItem specialLoanItem = new ListViewItem(new String[] { "              Special Loan Bill for " + monthOf, specialBill.ToString("N") },
                      lsvBase.Groups["grpSpecial"]);
                specialLoanItem.SubItems[0].ForeColor = Color.Blue;
                specialLoanItem.SubItems[1].ForeColor = Color.Red;
                specialLoanItem.UseItemStyleForSubItems = false;

                lsvBase.Items.Add(specialLoanItem);
            }
        }
        //this procedure will refresh member logic class
        public void ReferesData(CommonExchange.SysAccess userInfo)
        {
            this.InitializeMemberClass(userInfo);
        }//-------------------------
        #endregion

        #region Programmers-Defined Function
        //this fucntion will get office employer id by current index
        private String GetOfficeEmployerId(Int32 index)
        {
            String value = String.Empty;

            if (_officeEmployerTable != null)
            {
                DataRow officeRow = _officeEmployerTable.Rows[index];

                value = RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_id", String.Empty);
            }

            return value;
        }//----------------------

        //this function will get member classification and member type id by current index
        private String GetMemberClassificationTypeId(Int32 index, Boolean isMemberClassification)
        {
            String value = String.Empty;

            if (isMemberClassification && _memberClassDataSet.Tables["MemberClassificationTable"] != null)
            {
                DataRow memRow = _memberClassDataSet.Tables["MemberClassificationTable"].Rows[index];

                value = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "classification_id", String.Empty);
            }
            else if (!isMemberClassification && _memberClassDataSet.Tables["MemberTypeTable"] != null)
            {
                DataRow memRow = _memberClassDataSet.Tables["MemberTypeTable"].Rows[index];

                value = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_type_id", String.Empty);
            }

            return value;
        }//----------------------

        //this fucntion will determine if the hospitalization include coverage already exist in the InHouseHospitalizationIncludeCoverageList
        private Boolean IsAlreadyExistInHouseIncludeCoverage(List<CommonExchange.InHouseIncludeCoverage> inHouseIncludeCoverageList, String sysIdIncludeCoverage)
        {
            Boolean isExist = false;

            foreach (CommonExchange.InHouseIncludeCoverage list in inHouseIncludeCoverageList)
            {
                if (String.Equals(list.IncludeCoverageInfo.IncludeCoverageSysId, sysIdIncludeCoverage) && list.ObjectState != DataRowState.Deleted)
                {
                    isExist = true;

                    break;
                }
            }

            return isExist;
        }//-----------------------------

        //get the first day of the month
        public DateTime FirstDayOfMonthFromDateTime(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }//-------------------------

        //this the last day of the month
        public DateTime LastDayOfMonthFromDateTime(DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }//---------------------------  

        //this fucntion will get searched member information table
        public DataTable GetSearchedMemberInformationTable(CommonExchange.SysAccess userInfo, String queryString, String officeEmployerIdList,
            String classificationIdList, String memberSysIdExcludeList, String memberTypeIdList, Boolean includeMemberStatus, Boolean isActive, Boolean isNewQuery)

        {
            DataTable newTable = new DataTable("MemberTable");
            newTable.Columns.Add("member_id", System.Type.GetType("System.String"));
            newTable.Columns.Add("occupation", System.Type.GetType("System.String"));
            newTable.Columns.Add("member_name", System.Type.GetType("System.String"));
            newTable.Columns.Add("present_address", System.Type.GetType("System.String"));
            newTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
            newTable.Columns.Add("home_address", System.Type.GetType("System.String"));
            newTable.Columns.Add("home_phone_nos", System.Type.GetType("System.String"));
            newTable.Columns.Add("office_name_acronym", System.Type.GetType("System.String"));

            if (isNewQuery)
            {
                using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
                {
                    _memberInfoTable = remClient.SelectMemberInformation(userInfo, queryString, officeEmployerIdList, memberTypeIdList, classificationIdList, 
                        memberSysIdExcludeList, includeMemberStatus, isActive);
                }
            }

            if (_memberInfoTable != null)
            {
                foreach (DataRow memRow in _memberInfoTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["member_id"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_id", String.Empty);
                    newRow["occupation"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "occupation", String.Empty);
                    newRow["member_name"] = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(memRow, "last_name", "first_name", "middle_name");
                    newRow["present_address"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "present_address", String.Empty);
                    newRow["present_phone_nos"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "present_phone_nos", String.Empty);
                    newRow["home_address"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "home_address", String.Empty);
                    newRow["home_phone_nos"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "home_phone_nos", String.Empty);
                    newRow["office_name_acronym"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "office_employer_name", String.Empty) + " [" +
                        RemoteServerLib.ProcStatic.DataRowConvert(memRow, "office_office_employer_acronym", String.Empty) + "]";

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//----------------------

        //this function will get searched collateral information
        public DataTable GetSearchedCollateralInformation(CommonExchange.SysAccess userInfo, String queryString,
            Boolean includeMarkedDeleted, Boolean isNewQuery)
        {
            DataTable newTable = this.CollateralInformationTable;

            if (isNewQuery)
            {
                using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
                {
                    _collateralInformationTable = remClient.SelectCollateralInformation(userInfo, queryString, includeMarkedDeleted);
                }
            }

            if (_collateralInformationTable != null)
            {
                foreach (DataRow colRow in _collateralInformationTable.Rows)
                {
                    if (colRow.RowState != DataRowState.Deleted)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["sysid_collateral"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty);
                        newRow["property_type"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_type", String.Empty);
                        newRow["property_brand"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_brand", String.Empty);
                        newRow["serial_no"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "serial_no", String.Empty);
                        newRow["purchase_price"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "purchase_price", Decimal.Parse("0"));
                        newRow["year_purchased"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "year_purchased", String.Empty);
                        newRow["estimated_appraised_value"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "estimated_appraised_value", Decimal.Parse("0"));
                        newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "remarks", String.Empty);

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//--------------------------

        //this function will initialize other creditor data grid view
        public DataTable InitializeOtherCreditorDataGridView(List<CommonExchange.OtherCreditor> otherCreditorList)
        {
            DataTable newTable = this.OtherCreditorInformationTable;

            foreach (CommonExchange.OtherCreditor list in otherCreditorList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["other_creditor_id"] = list.OtherCreditorId;
                    newRow["creditor_name"] = list.CreditorName;
                    newRow["amount_owned"] = list.AmountOwned;
                    newRow["date_due"] = !String.IsNullOrEmpty(list.DateDue) ? DateTime.Parse(list.DateDue).ToShortDateString() : String.Empty;
                    newRow["repayment_description"] = list.RepaymentScheduleInfo.RepaymentDescription;
                    newRow["amortization_amount"] = list.AmortizationAmount;
                    newRow["remarks"] = list.Remarks;

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//-----------------------

        //this function will get searched shared capital information 
        public DataTable GetSearchedSharedCapitalInformation(CommonExchange.SysAccess userInfo, String memberSysIdList, Boolean includeHistory)
        {
            DataTable newTable = this.ShareCapitalInformationTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _sharedCapitalInformationTable = remClient.SelectBySysIDMemberListShareCapitalInformation(userInfo, memberSysIdList, includeHistory);
            }

            if (_sharedCapitalInformationTable != null)
            {
                foreach (DataRow sharedRow in _sharedCapitalInformationTable.Rows)
                {
                    if (!RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "is_current_share_capital", false))
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["sysid_share"] = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "sysid_share", String.Empty);

                        DateTime effectivityDate = DateTime.MinValue;

                        if (DateTime.TryParse(RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "effectivity_date", String.Empty), out effectivityDate))
                        {
                            newRow["effectivity_date"] = DateTime.Compare(effectivityDate, DateTime.MinValue) == 0 ? 
                                String.Empty : effectivityDate.ToLongDateString();
                        }

                        newRow["premium_amount_due"] = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "premium_amount_due", Decimal.Parse("0")).ToString("N");
                        newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "remarks", String.Empty);

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//----------------------

        //this function will get searched hospital information
        public DataTable GetSearchedHospitalizationInformation(CommonExchange.SysAccess userInfo, String memberSysIdList, Boolean includeHistory)
        {
            DataTable newTable = this.HospitalizationInformation;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _hospitalizationInformationTable = remClient.SelectBySysIDMemberListInHouseHospitalizationInformation(userInfo, memberSysIdList, true);
            }

            if (_hospitalizationInformationTable != null)
            {
                foreach (DataRow hospRow in _hospitalizationInformationTable.Rows)
                {
                    if (!RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "is_current_hospitalization", false))
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["effectivity_date"] = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "effectivity_date", String.Empty);
                        newRow["certificate_no"] = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "certificate_no", String.Empty);
                        newRow["premium_amount_due"] = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "premium_amount_due",Decimal.Parse("0")).ToString();
                        newRow["maximum_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "maximum_amount", Decimal.Parse("0")).ToString();
                        newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "remarks", String.Empty);

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//---------------------------

        //this function will get search hospitalization include coverage
        public DataTable GetSearchedHospitalizationIncludeCoverage(CommonExchange.SysAccess userInfo, List<CommonExchange.InHouseIncludeCoverage> inHouseIncludeCoverageList,
            String queryString, Boolean includeMarkedDeleted)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _includeHospitalizationTable = remClient.SelectHospitalizationIncludeCoverage(userInfo, queryString, includeMarkedDeleted);
            }

            DataTable newTable = this.HospitalizationIncludeTable;

            if (_includeHospitalizationTable != null)
            {
                foreach (DataRow includeRow in _includeHospitalizationTable.Rows)
                {
                    if (!this.IsAlreadyExistInHouseIncludeCoverage(inHouseIncludeCoverageList,
                        RemoteServerLib.ProcStatic.DataRowConvert(includeRow, "sysid_includecoverage", String.Empty)))
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["sysid_includecoverage"] = RemoteServerLib.ProcStatic.DataRowConvert(includeRow, "sysid_includecoverage", String.Empty);
                        newRow["include_coverage_description"] = RemoteServerLib.ProcStatic.DataRowConvert(includeRow, "include_coverage_description", String.Empty);

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//-------------------------

        //this function will get searched hospitalization exclude coverage
        public DataTable GetSearchedHospitalizationExcludeCoverage(CommonExchange.SysAccess userInfo, String queryString, Boolean includeMarkedDeleted)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _excludeHospitalizationTable = remClient.SelectHospitalizationExcludeCoverage(userInfo, queryString, includeMarkedDeleted);
            }

            DataTable newTable = this.HospitalizationExcludeTable;

            if (_excludeHospitalizationTable != null)
            {
                foreach (DataRow excludeRow in _excludeHospitalizationTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["sysid_excludecoverage"] = RemoteServerLib.ProcStatic.DataRowConvert(excludeRow, "sysid_excludecoverage", String.Empty);
                    newRow["exclude_coverage_description"] = RemoteServerLib.ProcStatic.DataRowConvert(excludeRow, "exclude_coverage_description", String.Empty);

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//-----------------------

        //this function will get searched hospitalization debit
        public DataTable GetSearchedHospitalizationDebit(CommonExchange.SysAccess userInfo, String memberSysIdList, Boolean isMarkedDeleted, Boolean isNewQuery)
        {
            if (isNewQuery)
            {
                using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
                {
                    _debitHospitalizationTable = remClient.SelectBySysIDMemberListInHouseHospitalizationDebit(userInfo, memberSysIdList, isMarkedDeleted);
                }
            }

            DataTable newTable = this.HospitalizationDebitTable;

            if (_debitHospitalizationTable != null)
            {
                foreach (DataRow debitRow in _debitHospitalizationTable.Rows)
                {
                    if (debitRow.RowState != DataRowState.Deleted)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["sysid_inhousedebit"] = RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "sysid_inhousedebit", String.Empty);

                        DateTime reflectedDate = DateTime.MinValue;

                        if (DateTime.TryParse(RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "reflected_date", String.Empty), out reflectedDate))
                        {
                            newRow["reflected_date"] = DateTime.Compare(reflectedDate, DateTime.MinValue) == 0 ?
                                String.Empty : reflectedDate.ToLongDateString();
                        }

                        newRow["net_assistance_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "net_assistance_amount", Decimal.Parse("0")).ToString("N");
                        newRow["hospital_name"] = RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "hospital_name", String.Empty);
                        newRow["cause_of_admission"] = RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "cause_of_admission", String.Empty);

                        DateTime dateFrom = DateTime.MinValue;

                        if (DateTime.TryParse(RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "date_from", String.Empty), out dateFrom))
                        {
                            newRow["date_from"] = DateTime.Compare(dateFrom, DateTime.MinValue) == 0 ?
                                String.Empty : dateFrom.ToLongDateString();
                        }


                        DateTime dateTo = DateTime.MinValue;

                        if (DateTime.TryParse(RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "date_to", String.Empty), out dateTo))
                        {
                            newRow["date_to"] = DateTime.Compare(dateTo, DateTime.MinValue) == 0 ?
                                String.Empty : dateTo.ToLongDateString();
                        }

                        newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "remarks", String.Empty);

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//----------------------------

        //this function will get shared capital credits
        public DataTable GetShareCapitalCredits(CommonExchange.SysAccess userInfo, String memberSysIdList, ref Decimal totalShareContribution, ToolStripLabel lblTotalContribution)
        {
            DataTable newTable = this.ShareCapitalCreditTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _shareCapitalCreditTable = remClient.SelectBySysIDMemberListShareCapitalCredit(userInfo, memberSysIdList);
            }

            totalShareContribution = 0;

            foreach (DataRow shareRow in _shareCapitalCreditTable.Rows)
            {
                DataRow newRow = newTable.NewRow();

                newRow["capital_credit_id"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "capital_credit_id", Int64.Parse("0"));
                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
                newRow["received_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty)).ToShortDateString();
                newRow["amount_paid"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0")).ToString("N");
                newRow["reflected_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty)).ToShortDateString();
                newRow["receipt_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty)).ToShortDateString();
                newRow["bank_name"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
                newRow["check_no_not_froze"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
                newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);

                newTable.Rows.Add(newRow);

                totalShareContribution += RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
            }

            lblTotalContribution.Text = "Total Share Capital Contribution: " + totalShareContribution.ToString("N");

            return newTable;
        }//-----------------

        //this function will get shared capital credits
        public DataTable GetMembersEquity(CommonExchange.SysAccess userInfo, String memberSysIdList, ref Decimal totalMemberEquitContribution, ToolStripLabel lblTotalContribution)
        {
            DataTable newTable = this.MembersEquityTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _membersEquityTable = remClient.SelectBySysIDMemberListMemberEquityCredit(userInfo, memberSysIdList);
            }

            totalMemberEquitContribution = 0;

            foreach (DataRow shareRow in _membersEquityTable.Rows)
            {
                DataRow newRow = newTable.NewRow();

                newRow["equity_id"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "equity_id", Int64.Parse("0"));
                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
                newRow["received_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty)).ToShortDateString();
                newRow["amount_paid"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0")).ToString("N");
                newRow["reflected_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty)).ToShortDateString();
                newRow["receipt_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty)).ToShortDateString();
                newRow["bank_name"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
                newRow["check_no_not_froze"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
                newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);

                newTable.Rows.Add(newRow);

                totalMemberEquitContribution += RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
            }

            lblTotalContribution.Text = "Total Member's Equity: " + totalMemberEquitContribution.ToString("N");

            return newTable;
        }//-----------------

        //this function will get in-house hospitalization
        public DataTable GetInHouseHospitalizations(CommonExchange.SysAccess userInfo, String memberSysIdList, ref Decimal totalHospitaliztionContribution)
        {
            DataTable newTable = this.InHouseHospitalizationTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _inHouseHospitalizationTable = remClient.SelectBySysIDMemberListInHouseHospitalizationCredit(userInfo, memberSysIdList);
            }

            totalHospitaliztionContribution = 0;

            foreach (DataRow shareRow in _inHouseHospitalizationTable.Rows)
            {
                DataRow newRow = newTable.NewRow();

                newRow["hospitalization_credit_id"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "hospitalization_credit_id", Int64.Parse("0"));
                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
                newRow["received_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty)).ToShortDateString();
                newRow["amount_paid"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0")).ToString("N");
                newRow["reflected_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty)).ToShortDateString();
                newRow["receipt_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty)).ToShortDateString();
                newRow["bank_name"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
                newRow["check_no_not_froze"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
                newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);

                newTable.Rows.Add(newRow);

                totalHospitaliztionContribution += RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
            }

            return newTable;
        }//-------------------------

        //this function will get hospitalization debit information
        public CommonExchange.InHouseHospitalizationDebit GetDetailsInHouseHospitalizationDebitInformation(CommonExchange.SysAccess userInfo,
            String inHouseDebitSysId)
        {
            CommonExchange.InHouseHospitalizationDebit inHouseDebitInfo = new CommonExchange.InHouseHospitalizationDebit();

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                inHouseDebitInfo = remClient.SelectBySysIDInHouseHospitalizationDebit(userInfo, inHouseDebitSysId);
            }

            return inHouseDebitInfo;
        }//----------------------------

        //this function will get hospitalization include coverage information
        public CommonExchange.HospitalizationIncludeCoverage GetHospitalizationIncludeCoverageInformation(String includeCoverageSysId)
        {
            CommonExchange.HospitalizationIncludeCoverage includeCoverageInfo = new CommonExchange.HospitalizationIncludeCoverage();

            if (_includeHospitalizationTable != null)
            {
                String strFilter = "sysid_includecoverage = '" + includeCoverageSysId + "'";
                DataRow[] selectRow = _includeHospitalizationTable.Select(strFilter);

                foreach (DataRow includeRow in selectRow)
                {
                    includeCoverageInfo.IncludeCoverageDescription = RemoteServerLib.ProcStatic.DataRowConvert(includeRow, "include_coverage_description", String.Empty);
                    includeCoverageInfo.IncludeCoverageSysId = RemoteServerLib.ProcStatic.DataRowConvert(includeRow, "sysid_includecoverage", String.Empty);
                    includeCoverageInfo.IsMarkedDeleted = RemoteServerLib.ProcStatic.DataRowConvert(includeRow, "is_marked_deleted", false);

                    break;
                }
            }

            return includeCoverageInfo;
        }//-----------------------

        //this function will get hospitalization exclude coverage information
        public CommonExchange.HospitalizationExcludeCoverage GetHospitalizationExcludeCoverageInformation(String excludeCoverageSysId)
        {
            CommonExchange.HospitalizationExcludeCoverage excludeCoverageInfo = new CommonExchange.HospitalizationExcludeCoverage();

            if (_excludeHospitalizationTable != null)
            {
                String strFilter = "sysid_excludecoverage = '" + excludeCoverageSysId + "'";
                DataRow[] selectRow = _excludeHospitalizationTable.Select(strFilter);

                foreach (DataRow excludeRow in selectRow)
                {
                    excludeCoverageInfo.ExcludeCoverageDescription = RemoteServerLib.ProcStatic.DataRowConvert(excludeRow, "exclude_coverage_description", String.Empty);
                    excludeCoverageInfo.ExcludeCoverageSysId = RemoteServerLib.ProcStatic.DataRowConvert(excludeRow, "sysid_excludecoverage", String.Empty);
                    excludeCoverageInfo.IsMarkedDeleted = RemoteServerLib.ProcStatic.DataRowConvert(excludeRow, "is_marked_deleted", false);

                    break;
                }
            }

            return excludeCoverageInfo;
        }//--------------------------------

        //this function will get details shared capital information
        public CommonExchange.ShareCapitalInformation GetDetailsSharedCapitalInformation()
        {
            CommonExchange.ShareCapitalInformation sharedInfo = new CommonExchange.ShareCapitalInformation();

            if (_sharedCapitalInformationTable != null)
            {
                foreach (DataRow sharedRow in _sharedCapitalInformationTable.Rows)
                {
                    if (RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "is_current_share_capital", false))
                    {
                        sharedInfo.ShareCapitalId = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "share_capital_id", Int64.Parse("0"));
                        sharedInfo.EffectivityDate = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "effectivity_date", String.Empty);
                        sharedInfo.PremiumAmountDue = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "premium_amount_due", Decimal.Parse("0"));
                        sharedInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "remarks", String.Empty);
                        sharedInfo.IsPrecludedWithdrawal = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "is_precluded_withdrawal", false);
                        sharedInfo.IsPrecludedRetirement = RemoteServerLib.ProcStatic.DataRowConvert(sharedRow, "is_precluded_retirement", false);

                        break;
                    }
                }
            }

            return sharedInfo;
        }//-------------------------

        //this function will get details share capital credit information
        public CommonExchange.ShareCapitalCredit GetDetailsShareCapitalCreditInformation(String capitalCreditId)
        {
            CommonExchange.ShareCapitalCredit shareCapitalCreditInfo = new CommonExchange.ShareCapitalCredit();

            if (_shareCapitalCreditTable != null)
            {
                String strFilter = "capital_credit_id = " + capitalCreditId;
                DataRow[] selectRow = _shareCapitalCreditTable.Select(strFilter);

                foreach (DataRow shareRow in selectRow)
                {
                    shareCapitalCreditInfo.CapitalCreditId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "capital_credit_id", Int64.Parse("0"));
                    shareCapitalCreditInfo.ReflectedDate = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty);
                    shareCapitalCreditInfo.ReceiptDate = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty);
                    shareCapitalCreditInfo.ReceivedDate = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty);
                    shareCapitalCreditInfo.ReceiptNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
                    shareCapitalCreditInfo.CreditAmount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
                    shareCapitalCreditInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);
                    shareCapitalCreditInfo.AmountTendered = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "amount_tendered", Decimal.Parse("0"));
                    shareCapitalCreditInfo.Bank = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
                    shareCapitalCreditInfo.CheckNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
                    shareCapitalCreditInfo.IsMigratedEntry = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_migrated_entry", false);
                    shareCapitalCreditInfo.AccountCreditInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_account_credit", String.Empty);
                    shareCapitalCreditInfo.AccountCreditInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_code", String.Empty);
                    shareCapitalCreditInfo.AccountCreditInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_name", String.Empty);

                    break;
                }
            }

            return shareCapitalCreditInfo;
        }//-----------------------------

        //this function will get details share capital credit information
        public CommonExchange.MemberEquityCredit GetDetailsMembersEquityInformation(String equityId)
        {
            CommonExchange.MemberEquityCredit membersEquityInfo = new CommonExchange.MemberEquityCredit();

            if (_shareCapitalCreditTable != null)
            {
                String strFilter = "equity_id = " + equityId;
                DataRow[] selectRow = _membersEquityTable.Select(strFilter);

                foreach (DataRow shareRow in selectRow)
                {
                    membersEquityInfo.EquityId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "equity_id", Int64.Parse("0"));
                    membersEquityInfo.ReflectedDate = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty);
                    membersEquityInfo.ReceiptDate = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty);
                    membersEquityInfo.ReceivedDate = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty);
                    membersEquityInfo.ReceiptNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
                    membersEquityInfo.CreditAmount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
                    membersEquityInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);
                    membersEquityInfo.AmountTendered = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "amount_tendered", Decimal.Parse("0"));
                    membersEquityInfo.Bank = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
                    membersEquityInfo.CheckNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
                    membersEquityInfo.IsMigratedEntry = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_migrated_entry", false);
                    membersEquityInfo.AccountCreditInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_account_credit", String.Empty);
                    membersEquityInfo.AccountCreditInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_code", String.Empty);
                    membersEquityInfo.AccountCreditInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_name", String.Empty);

                    break;
                }
            }

            return membersEquityInfo;
        }//-----------------------------

        //this function will get details hospitalization information
        public CommonExchange.InHouseHospitalizationInformation GetDetailsCurrentHospitalizationInformaion()
        {
            CommonExchange.InHouseHospitalizationInformation hospitalizationInfo = new CommonExchange.InHouseHospitalizationInformation();

            if (_hospitalizationInformationTable != null)
            {
                foreach (DataRow hospRow in _hospitalizationInformationTable.Rows)
                {
                    if (RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "is_current_hospitalization", false) &&
                        !RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "is_precluded", false))
                    {
                        hospitalizationInfo.CertificateNo = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "certificate_no", String.Empty);
                        hospitalizationInfo.EffectivityDate = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "effectivity_date", String.Empty);
                        hospitalizationInfo.InHouseId = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "in_house_id", Int64.Parse("0"));
                        hospitalizationInfo.IsPrecluded = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "is_precluded", false);
                        hospitalizationInfo.MaximumAmount = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "maximum_amount", Decimal.Parse("0"));
                        hospitalizationInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "remarks", String.Empty);
                        hospitalizationInfo.PremiumAmountDue = RemoteServerLib.ProcStatic.DataRowConvert(hospRow, "premium_amount_due", Decimal.Parse("0"));

                        break;
                    }
                }
            }

            return hospitalizationInfo;
        }//---------------------------
              
        //this function will get in house hospitalization include coverage information
        public CommonExchange.InHouseIncludeCoverage GetDetailsInHouseIncludeCoverage(Int64 includeCoverageId, 
            List<CommonExchange.InHouseIncludeCoverage> includeCoverageList)
        {
            CommonExchange.InHouseIncludeCoverage includeCoverageInfo = new CommonExchange.InHouseIncludeCoverage();

            foreach (CommonExchange.InHouseIncludeCoverage list in includeCoverageList)
            {
                if (list.IncludeCoverageId == includeCoverageId)
                {
                    includeCoverageInfo = list;

                    break;
                }
            }

            return includeCoverageInfo;
        }//----------------------------

        //this fucntion will get in house hospitalization exclude coverage information
        public CommonExchange.InHouseExcludeCoverage GetDetailsInHouseExcludeCoverage(Int64 excludeCoverageId,
            List<CommonExchange.InHouseExcludeCoverage> excludeCoverageList)
        {
            CommonExchange.InHouseExcludeCoverage excludeCoverageInfo = new CommonExchange.InHouseExcludeCoverage();

            foreach (CommonExchange.InHouseExcludeCoverage list in excludeCoverageList)
            {
                if (list.ExcludeCoverageId == excludeCoverageId)
                {
                    excludeCoverageInfo = list;

                    break;
                }
            }
            
            return excludeCoverageInfo;
        }//---------------------

        //this function will get details collateral information
        public CommonExchange.Collateral GetDetailsCollateralInformation(String collateralSysId)
        {
            CommonExchange.Collateral collateralInfo = new CommonExchange.Collateral();

            if (_collateralInformationTable != null)
            {
                String strFilter = "sysid_collateral = '" + collateralSysId + "'";
                DataRow[] selectRow = _collateralInformationTable.Select(strFilter);

                foreach (DataRow colRow in selectRow)
                {
                    collateralInfo.CollateralSysId = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty);
                    collateralInfo.PropertyType = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_type", String.Empty);
                    collateralInfo.PropertyBrand = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_brand", String.Empty);
                    collateralInfo.SerialNo = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "serial_no", String.Empty);
                    collateralInfo.PurchasePrice = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "purchase_price", Decimal.Parse("0"));
                    collateralInfo.YearPurchased = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "year_purchased", String.Empty);
                    collateralInfo.EstimatedAppraisedValue = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "estimated_appraised_value", Decimal.Parse("0"));
                    collateralInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "remarks", String.Empty);
                    collateralInfo.IsMarkedDeleted = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "is_marked_deleted", false);
                    collateralInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_member", String.Empty);
                    collateralInfo.MemberInfo.MemberId = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "member_id", String.Empty);
                    collateralInfo.MemberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "last_name", String.Empty);
                    collateralInfo.MemberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "first_name", String.Empty);
                    collateralInfo.MemberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "middle_name", String.Empty);

                    break;
                }
            }

            return collateralInfo;
        }//--------------------------            

        //this fucntion will get member classification information
        public CommonExchange.MemberClassification GetMemberClassificationInformation(Int32 index)
        {
            CommonExchange.MemberClassification memberClassificationInfo = new CommonExchange.MemberClassification();

            DataRow cRow = _memberClassDataSet.Tables["MemberClassificationTable"].Rows[index];

            memberClassificationInfo.ClassificationId = RemoteServerLib.ProcStatic.DataRowConvert(cRow, "classification_id", String.Empty);
            memberClassificationInfo.ClassificationDescription = RemoteServerLib.ProcStatic.DataRowConvert(cRow, "classification_description", String.Empty);

            return memberClassificationInfo;
        }//----------------------

        //this function will get member type information
        public CommonExchange.MemberType GetMemberTypeInformation(Int32 index)
        {
            CommonExchange.MemberType memberTypeInfo = new CommonExchange.MemberType();

            DataRow memRow = _memberClassDataSet.Tables["MemberTypeTable"].Rows[index];

            memberTypeInfo.MemberTypeId = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_type_id", String.Empty);
            memberTypeInfo.MemberTypeDescription = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_type_description", String.Empty);

            return memberTypeInfo;
        }//-------------------------

        //this function will get member information details by member id
        public CommonExchange.Member GetMemberInformationDetailsByMemberId(CommonExchange.SysAccess userInfo, String memberId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                memberInfo = remClient.SelectByMemberIDMemberInformation(userInfo, memberId);
            }

            if (!String.IsNullOrEmpty(memberInfo.PersonInfo.BirthDate))
            {
                DateTime bDate = DateTime.Parse(memberInfo.PersonInfo.BirthDate);

                if (DateTime.Compare(bDate, DateTime.MinValue) == 0)
                {
                    memberInfo.PersonInfo.BirthDate = String.Empty;
                }
            }

            if (!String.IsNullOrEmpty(memberInfo.PersonInfo.MarriageDate))
            {
                DateTime mDate = DateTime.Parse(memberInfo.PersonInfo.MarriageDate);

                if (DateTime.Compare(mDate, DateTime.MinValue) == 0)
                {
                    memberInfo.PersonInfo.MarriageDate = String.Empty;
                }
            }

            if (!String.IsNullOrEmpty(memberInfo.PersonInfo.EmploymentDate))
            {
                DateTime mDate = DateTime.Parse(memberInfo.PersonInfo.EmploymentDate);

                if (DateTime.Compare(mDate, DateTime.MinValue) == 0)
                {
                    memberInfo.PersonInfo.EmploymentDate = String.Empty;
                }
            }

            return memberInfo;
        }//-----------------------------

        //this function will get member information details by person id
        public CommonExchange.Member GetMemberInformationDetailsByPersonId(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                memberInfo = remClient.SelectBySysIDPersonMemberInformation(userInfo, personSysId);
            }

            return memberInfo;
        }//---------------------------------   

        //this function will get payment interval information (Repayment schedule)
        public CommonExchange.RepaymentSchedule GetRepaymentscheduleInformation(Int32 index)
        {
            CommonExchange.RepaymentSchedule repaymentScheduleInfo = new CommonExchange.RepaymentSchedule();

            if (_memberClassDataSet.Tables["RepaymentScheduleTable"] != null)
            {
                DataRow rePayRow = _memberClassDataSet.Tables["RepaymentScheduleTable"].Rows[index];

                repaymentScheduleInfo.RepaymentId = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "repayment_id", String.Empty);
                repaymentScheduleInfo.RepaymentDescription = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "repayment_description", String.Empty);
                repaymentScheduleInfo.PaymentsPerYear = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "payments_per_year", Int16.Parse("0"));
                repaymentScheduleInfo.RepaymentNo = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "repayment_no", Byte.Parse("0"));
            }

            return repaymentScheduleInfo;
        }//-----------------------      

        //this fucntion will get other creditor information
        public CommonExchange.OtherCreditor GetDetailsOtherCreditorInformation(List<CommonExchange.OtherCreditor> otherCreditorList, String otherCreditorId)
        {
            CommonExchange.OtherCreditor otherCreditorInfo = new CommonExchange.OtherCreditor();

            foreach (CommonExchange.OtherCreditor list in otherCreditorList)
            {
                if (String.Equals(list.OtherCreditorId.ToString(), otherCreditorId))
                {
                    otherCreditorInfo = list;

                    break;
                }
            }

            return otherCreditorInfo;
        }//------------------------

        //this function will get the hospitalization running balance
        public Decimal GetHospitalizationRunningBalance(CommonExchange.InHouseHospitalizationInformation inHouseHospitalizationInfo)
        {
            Decimal runningBalance = inHouseHospitalizationInfo.MaximumAmount;

            DateTime basedEffectivityDate = DateTime.MinValue;

            if (_debitHospitalizationTable != null && DateTime.TryParse(inHouseHospitalizationInfo.EffectivityDate, out basedEffectivityDate))
            {
                foreach (DataRow debitRow in _debitHospitalizationTable.Rows)
                {
                    if (debitRow.RowState != DataRowState.Deleted)
                    {
                        DateTime reflectedDateDebit = DateTime.MinValue;

                        if (DateTime.TryParse(RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "reflected_date", String.Empty), out reflectedDateDebit) &&
                            basedEffectivityDate.Year == reflectedDateDebit.Year)
                        {
                            runningBalance -= RemoteServerLib.ProcStatic.DataRowConvert(debitRow, "net_assistance_amount", Decimal.Parse("0"));
                        }
                    }
                }
            }

            return runningBalance;
        }//------------------------

        //this function will get in house hospitalization debit document information by document original name
        public String GetInHouseHospitalizationDebitDocumentInformation(String originalName)
        {
            String value = String.Empty;

            if (_documentHospitalizationDebitTable != null)
            {
                String strFilter = "original_name = '" + originalName + "'";
                DataRow[] selectRow = _documentHospitalizationDebitTable.Select(strFilter);

                foreach (DataRow docRow in selectRow)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        value = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);
                    }

                    break;
                }
            }

            return value;
        }//-----------------------

        //this function will get member id
        public String GetMemberId(CommonExchange.SysAccess userInfo, Int32 membershipYear)
        {
            String memberId = String.Empty;

            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                memberId = remClient.SelectCountForMemberIDMemberInformation(userInfo, membershipYear);
            }

            return memberId;
        }//----------------------

        //this fucntion will determine if the member information already exist
        public Boolean IsExistsMemberIDMemberInformation(CommonExchange.SysAccess userInfo, String memberId, String memberSysId)
        {
            Boolean isExist = false;

            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                isExist = remClient.IsExistsMemberIDMemberInformation(userInfo, memberId, memberSysId);
            }

            return isExist;
        }//------------------------------

        //this function will determine if the in house hospitalization debit information already exist
        public Boolean IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument(CommonExchange.SysAccess userInfo, Int64 documentId,
            String inHouseDebitSysId, String originalName)
        {
            Boolean isExist = false;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                isExist = remClient.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument(userInfo, documentId, inHouseDebitSysId, originalName);
            }

            return isExist;
        }//-------------------------------- 

        //this fucntion gets the course yearlevel string format
        public String GetOfficeEmployerStringFormat(CheckedListBox cbXBase, Boolean isOfficeEmployer, Boolean isMemberClassification, Boolean isMemberType)
        {
            StringBuilder strValue = new StringBuilder();

            if (cbXBase.CheckedIndices.Count >= 1)
            {
                IEnumerator myEnum = cbXBase.CheckedIndices.GetEnumerator();
                Int32 x;

                if (isOfficeEmployer)
                {
                    while (myEnum.MoveNext() != false)
                    {
                        x = (Int32)myEnum.Current;

                        strValue.Append(this.GetOfficeEmployerId(x) + ", ");
                    }
                }
                else if (isMemberClassification)
                {
                    while (myEnum.MoveNext() != false)
                    {
                        x = (Int32)myEnum.Current;

                        strValue.Append(this.GetMemberClassificationTypeId(x, true) + ", ");
                    }
                }
                else if (isMemberType)
                {
                    while (myEnum.MoveNext() != false)
                    {
                        x = (Int32)myEnum.Current;

                        strValue.Append(this.GetMemberClassificationTypeId(x, false) + ", ");
                    }
                }
            }

            if (strValue.Length >= 2)
            {
                return strValue.ToString().Substring(0, strValue.Length - 2);
            }
            else
            {
                return String.Empty;
            }
        }//-------------------------
        #endregion
    }
}