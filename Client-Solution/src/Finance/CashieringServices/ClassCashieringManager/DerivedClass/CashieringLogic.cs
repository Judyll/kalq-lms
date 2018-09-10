using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CashieringServices
{
    internal class CashieringLogic : BaseServices.BaseServicesLogic
    {
        #region Class Data Member Declaration
        private DataSet _cashieringClassDataSet;
        private DataTable _regularLoanPaymentTable;
        private DataTable _regularLoanInformationTable;
        private DataTable _shareCapitalCreditTable;
        private DataTable _membersEquityTable;
        private DataTable _inHouseHospitalizationTable;
        private DataTable _officeEmployerTable;
        private DataTable _memberTable;
        private DataTable _memberEmployeeTable;
        private DataTable _miscellaneouseIncomeTable;
        private DataTable _cashReceiptDetailsTable;
        private DataTable _printingCashReceiptsDetailsTable;
        private DataTable _summariezedCashReceiptTable;
        private DataTable _printingSummariezedCashReceiptTable;
        private DataTable _breakDownBankDepositDetailsTable;
        private DataTable _printingBreakDownBankDepositDetailsTable;
        private DataTable _breakDownBackDepositeSummarizedTable;
        private DataTable _printingBreakDownBankDepositeSummarizedTable;
        private DataTable _billingStatementTable;
        #endregion

        #region Class Properties Declaration

        public DataTable LoanAmortizationTable
        {
            get
            {
                DataTable newTable = new DataTable("AmortizationTable");
                newTable.Columns.Add("payment_no", System.Type.GetType("System.Int16"));
                newTable.Columns.Add("payment_date_from", System.Type.GetType("System.String"));
                newTable.Columns.Add("payment_date_to", System.Type.GetType("System.String"));
                newTable.Columns.Add("payment_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("interest_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("principal_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("balance_beginning", System.Type.GetType("System.String"));
                newTable.Columns.Add("balance_ending", System.Type.GetType("System.String"));
                newTable.Columns.Add("amortization_id", System.Type.GetType("System.Int64"));

                return newTable;
            }
        }

        public DataTable RegularLoanPaymentHistoryTable
        {
            get
            {
                DataTable newTable = new DataTable("PaymentHistoryTable");
                newTable.Columns.Add("payment_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("received_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("principal_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("interest_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("rebate_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));         
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable RegularLoanTable
        {
            get
            {
                DataTable newTable = new DataTable("RegularLoanTable");
                newTable.Columns.Add("sysid_regular_hidden", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("regular_loan_type_description_freeze", System.Type.GetType("System.String"));
                newTable.Columns.Add("loan_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("purpose_of_loan", System.Type.GetType("System.String"));
                newTable.Columns.Add("loan_terms", System.Type.GetType("System.String"));
                newTable.Columns.Add("interest_rate", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_first_payment", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_maturity", System.Type.GetType("System.String"));                
                newTable.Columns.Add("repayment_description", System.Type.GetType("System.String"));

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

        public DataTable BillingStatementTable
        {
            get
            {
                DataTable newTable = new DataTable("MemberEmployeeTable");
                newTable.Columns.Add("sysid_member_hiddent", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name_forzeen", System.Type.GetType("System.String"));
                newTable.Columns.Add("share_capital_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("hospitalization_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("birthday_principal", System.Type.GetType("System.String"));
                newTable.Columns.Add("birthday_interest", System.Type.GetType("System.String"));
                newTable.Columns.Add("contingency_principal", System.Type.GetType("System.String"));
                newTable.Columns.Add("contingency_interest", System.Type.GetType("System.String"));
                newTable.Columns.Add("salary_principal", System.Type.GetType("System.String"));
                newTable.Columns.Add("salary_interest", System.Type.GetType("System.String"));
                newTable.Columns.Add("medical_principal", System.Type.GetType("System.String"));
                newTable.Columns.Add("medical_interest", System.Type.GetType("System.String"));
                newTable.Columns.Add("special_principal", System.Type.GetType("System.String"));
                newTable.Columns.Add("special_interest", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable MemberEmployeeTable
        {
            get
            {
                DataTable newTable = new DataTable("MemberEmployeeTable");
                newTable.Columns.Add("member_employee_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name_forzeen", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
                newTable.Columns.Add("home_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("home_phone_nos", System.Type.GetType("System.String"));
                newTable.Columns.Add("occupation", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable RegularLoanMultiplePaymentTable
        {
            get
            {
                DataTable newTable = new DataTable("RegularLoanPaymentTable");
                newTable.Columns.Add("sysid_member_hidden", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name_forzeen", System.Type.GetType("System.String"));
                newTable.Columns.Add("sysid_regular_hidden", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("principal_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("interest_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("discount_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_tendered", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_code_name_not_frozen", System.Type.GetType("System.String"));
                newTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));
                newTable.Columns.Add("bank_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_no_not_froze", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable ShareCapitalCreditInHouseHospitalizationMultiplePaymentTable
        {
            get
            {
                DataTable newTable = new DataTable("ShareCapitalCreditInHouseHospitalizationMultiplePaymentTable");
                newTable.Columns.Add("sysid_member_hidden", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name_forzeen", System.Type.GetType("System.String"));               
                newTable.Columns.Add("amount_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("discount_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("amount_tendered", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_code_name_not_frozen", System.Type.GetType("System.String"));
                newTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));
                newTable.Columns.Add("bank_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_no_not_froze", System.Type.GetType("System.String"));                

                return newTable;
            }
        }       
        #endregion

        #region Class Constructors
        public CashieringLogic(CommonExchange.SysAccess userInfo)
            : base(userInfo)
        {
            this.InitializeCashieringClass(userInfo);       
        }
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will initialize member logic class
        private void InitializeCashieringClass(CommonExchange.SysAccess userInfo)
        {
            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                _cashieringClassDataSet = remClient.GetDataSetForMemberManager(userInfo);
            }

            //initialize office employer table
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                _officeEmployerTable = remClient.SelectOfficeEmployerInformation(userInfo, "*", false);
            }//---------------------------

            //add temporary row from employer table for pring of billing statement (for no office/employer member)
            DataRow newRow = _officeEmployerTable.NewRow();

            newRow["office_employer_id"] = "temp001";
			newRow["office_employer_name"] = "Office/Employer NOT SPECIFIED";
			newRow["office_employer_acronym"] = String.Empty;
			newRow["office_employer_address"] = String.Empty;
            newRow["office_employer_phone_nos"] = String.Empty;

            _officeEmployerTable.Rows.Add(newRow);
            //----------------------

            //initialize table for printing cash receipts details
            _printingCashReceiptsDetailsTable = new DataTable("PrintingCashReceiptsTable");
            _printingCashReceiptsDetailsTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            _printingCashReceiptsDetailsTable.Columns.Add("received_date", System.Type.GetType("System.String"));
            _printingCashReceiptsDetailsTable.Columns.Add("received_from", System.Type.GetType("System.String"));
            _printingCashReceiptsDetailsTable.Columns.Add("acronym", System.Type.GetType("System.String"));
            _printingCashReceiptsDetailsTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            _printingCashReceiptsDetailsTable.Columns.Add("account_name", System.Type.GetType("System.String"));
            _printingCashReceiptsDetailsTable.Columns.Add("amount", System.Type.GetType("System.Decimal"));
            _printingCashReceiptsDetailsTable.Columns.Add("total", System.Type.GetType("System.Decimal"));
            //-----------------------

            //initialize table for printing summariezed cash receipts
            _printingSummariezedCashReceiptTable = new DataTable("SummariezedCashReceipts");
            _printingSummariezedCashReceiptTable.Columns.Add("group_title", System.Type.GetType("System.String"));
            _printingSummariezedCashReceiptTable.Columns.Add("account_code_summary", System.Type.GetType("System.String"));
            _printingSummariezedCashReceiptTable.Columns.Add("account_name_summary", System.Type.GetType("System.String"));
            _printingSummariezedCashReceiptTable.Columns.Add("acronym", System.Type.GetType("System.String"));
            _printingSummariezedCashReceiptTable.Columns.Add("account_code_subsidiary", System.Type.GetType("System.String"));
            _printingSummariezedCashReceiptTable.Columns.Add("account_name_subsidiary", System.Type.GetType("System.String"));
            _printingSummariezedCashReceiptTable.Columns.Add("total_amount", System.Type.GetType("System.Decimal"));
            _printingSummariezedCashReceiptTable.Columns.Add("total", System.Type.GetType("System.Decimal"));

            //initialize table for printing break down bank deposit details
            _printingBreakDownBankDepositDetailsTable = new DataTable("PrintingBreakDownDetails");
            _printingBreakDownBankDepositDetailsTable.Columns.Add("account_code_summary", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositDetailsTable.Columns.Add("account_name_summary", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositDetailsTable.Columns.Add("account_code", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositDetailsTable.Columns.Add("account_name", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositDetailsTable.Columns.Add("amount", System.Type.GetType("System.Decimal"));
            //-------------------------

            //initialize table for printing break down bank deposit summarized
            _printingBreakDownBankDepositeSummarizedTable = new DataTable("PrintingBreakDownSummarized");
            _printingBreakDownBankDepositeSummarizedTable.Columns.Add("account_code_summary", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositeSummarizedTable.Columns.Add("account_name_summary", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositeSummarizedTable.Columns.Add("account_code_subsidiary", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositeSummarizedTable.Columns.Add("account_name_subsidiary", System.Type.GetType("System.String"));
            _printingBreakDownBankDepositeSummarizedTable.Columns.Add("total_amount", System.Type.GetType("System.Decimal"));
            //--------------------------
        }//------------------------------

        //this procedure will print billing statement
        public void PrintBillingStatement(CommonExchange.SysAccess userInfo, String billingDate)
        {
            if (_billingStatementTable != null)
            {
                DataTable printBillingTable = new DataTable("PrintBillingTable");
                printBillingTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
				printBillingTable.Columns.Add("name", System.Type.GetType("System.String"));
				printBillingTable.Columns.Add("office_employer_id", System.Type.GetType("System.String"));
				printBillingTable.Columns.Add("share_capital_amount", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("hospitalization_amount", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("birthday_principal", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("birthday_interest", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("contingency_principal", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("contingency_interest", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("salary_principal", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("salary_interest", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("medical_principal", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("medical_interest", System.Type.GetType("System.Decimal"));
				printBillingTable.Columns.Add("special_principal", System.Type.GetType("System.Decimal"));
                printBillingTable.Columns.Add("special_interest", System.Type.GetType("System.Decimal"));

                DataTable printOfficeEmployerTable = new DataTable("PrintOfficeEmployerTable");
                printOfficeEmployerTable.Columns.Add("office_employer_id", System.Type.GetType("System.String"));
                printOfficeEmployerTable.Columns.Add("office_employer_name", System.Type.GetType("System.String"));

                foreach (DataRow bRow in _billingStatementTable.Rows)
                {
                    DataRow newRow = printBillingTable.NewRow();

                    newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "sysid_member", String.Empty);
                    newRow["name"] = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(bRow, "last_name", "first_name", "middle_name");                    
                    newRow["share_capital_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "share_capital_amount", Decimal.Parse("0"));
                    newRow["hospitalization_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "hospitalization_amount", Decimal.Parse("0"));
                    newRow["birthday_principal"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "birthday_principal", Decimal.Parse("0"));
                    newRow["birthday_interest"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "birthday_interest", Decimal.Parse("0"));
                    newRow["contingency_principal"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "contingency_principal", Decimal.Parse("0"));
                    newRow["contingency_interest"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "contingency_interest", Decimal.Parse("0"));
                    newRow["salary_principal"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "salary_principal", Decimal.Parse("0"));
                    newRow["salary_interest"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "salary_interest", Decimal.Parse("0"));
                    newRow["medical_principal"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "medical_principal", Decimal.Parse("0"));
                    newRow["medical_interest"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "medical_interest", Decimal.Parse("0"));
                    newRow["special_principal"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "special_principal", Decimal.Parse("0"));
                    newRow["special_interest"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "special_interest", Decimal.Parse("0"));

                    if (String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(bRow, "office_employer_id", String.Empty)))
                    {
                        newRow["office_employer_id"] = "temp001";
                    }
                    else
                    {
                        newRow["office_employer_id"] = RemoteServerLib.ProcStatic.DataRowConvert(bRow, "office_employer_id", String.Empty);
                    }

                    printBillingTable.Rows.Add(newRow);
                }

                foreach (DataRow ofRow in _officeEmployerTable.Rows)
                {
                    String strFilter = "office_employer_id = '" + RemoteServerLib.ProcStatic.DataRowConvert(ofRow, "office_employer_id", String.Empty) + "'";
                    DataRow[] selectRow = printBillingTable.Select(strFilter);

                    if (selectRow.Length > 0)
                    {
                        DataRow newRow = printOfficeEmployerTable.NewRow();

                        newRow["office_employer_id"] = RemoteServerLib.ProcStatic.DataRowConvert(ofRow, "office_employer_id", String.Empty);

                        String officeName = String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(ofRow, "office_employer_acronym", String.Empty)) ?
                            RemoteServerLib.ProcStatic.DataRowConvert(ofRow, "office_employer_name", String.Empty) :
                            RemoteServerLib.ProcStatic.DataRowConvert(ofRow, "office_employer_name", String.Empty) + " [" +
                            RemoteServerLib.ProcStatic.DataRowConvert(ofRow, "office_employer_acronym", String.Empty) + "]";

                        newRow["office_employer_name"] = officeName;

                        printOfficeEmployerTable.Rows.Add(newRow);
                    }
                }

                using (ClassCashieringManager.CrystalReport.CrystalBillingStatement rptBillingStatement = new
                    CashieringServices.ClassCashieringManager.CrystalReport.CrystalBillingStatement())
                {
                    rptBillingStatement.Database.Tables["billing_table"].SetDataSource(printBillingTable);
                    rptBillingStatement.Database.Tables["office_employer_table"].SetDataSource(printOfficeEmployerTable);

                    rptBillingStatement.SetParameterValue("@school_name", CommonExchange.CompanyInformation.CompanyName);
                    rptBillingStatement.SetParameterValue("@form_name", "Billing Statement");
                    rptBillingStatement.SetParameterValue("@date", "For the Month of " + billingDate);
                    rptBillingStatement.SetParameterValue("@user_info", BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                         userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));

                    using (BaseServices.CrystalReportViewer frmViewer = new BaseServices.CrystalReportViewer(rptBillingStatement))
                    {
                        frmViewer.Text = "   Billing Statement";
                        frmViewer.ShowDialog();
                    }
                }
            }
        }//--------------------------

        //this procedure will print cash receipt details report
        public void PrintCashReceiptDetailReport(CommonExchange.SysAccess userInfo, String dateStart, String dateEnd, Boolean isConsolidated)
        {
            String strCashierConsolidated = isConsolidated ? "Consolidated" : BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                        userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName);

            Decimal totalCollection = 0, totalDeposits = 0;

            if (_printingCashReceiptsDetailsTable != null)
            {
                foreach (DataRow detailsRow in _printingCashReceiptsDetailsTable.Rows)
                {
                    totalCollection += RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "amount", Decimal.Parse("0"));
                }
            }

            if (_printingBreakDownBankDepositDetailsTable != null)
            {
                foreach (DataRow depositRow in _printingBreakDownBankDepositDetailsTable.Rows)
                {
                    totalDeposits += RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "amount", Decimal.Parse("0"));
                }
            }

            Int32 max = 0, min = 0, count = 1, receiptNo = 0;

            if (_printingCashReceiptsDetailsTable != null)
            {
                foreach (DataRow rRow in _printingCashReceiptsDetailsTable.Rows)
                {
                    if (Int32.TryParse(RemoteServerLib.ProcStatic.DataRowConvert(rRow, "receipt_no", String.Empty), out receiptNo))
                    {
                        if (count == 1)
                        {
                            max = min = receiptNo;
                        }
                        else
                        {
                            if (max < receiptNo)
                            {
                                max = receiptNo;
                            }

                            if (min > receiptNo)
                            {
                                min = receiptNo;
                            }
                        }

                        count++;
                    }
                }
            }

            using (ClassCashieringManager.CrystalReport.CrystalCashReceiptDetailsReport rptCashReceiptDetails = new
                CashieringServices.ClassCashieringManager.CrystalReport.CrystalCashReceiptDetailsReport())
            {
                rptCashReceiptDetails.Database.Tables["cash_receipt_details"].SetDataSource(_printingCashReceiptsDetailsTable);
                rptCashReceiptDetails.Database.Tables["break_down_detals"].SetDataSource(_printingBreakDownBankDepositDetailsTable);

                rptCashReceiptDetails.SetParameterValue("@school_name", CommonExchange.CompanyInformation.CompanyName);
                rptCashReceiptDetails.SetParameterValue("@form_name", "Cash Receipt (Detailed)");
                rptCashReceiptDetails.SetParameterValue("@cashier_consolidated", strCashierConsolidated);
                rptCashReceiptDetails.SetParameterValue("@date_range", DateTime.Parse(dateStart).ToLongDateString() + " - " +
                    DateTime.Parse(dateEnd).ToLongDateString());
                rptCashReceiptDetails.SetParameterValue("@cash_receipts_range", min.ToString("000000") + " - " + max.ToString("000000"));
                rptCashReceiptDetails.SetParameterValue("@user_info", "Date/Time Printed: " + DateTime.Parse(this.ServerDateTime).ToShortDateString() + " " +
                    DateTime.Parse(this.ServerDateTime).ToShortTimeString() + "         Printed by: " +
                    BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                    userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));
                rptCashReceiptDetails.SetParameterValue("@total_collection", totalCollection);
                rptCashReceiptDetails.SetParameterValue("@total_diposit", totalDeposits);
                rptCashReceiptDetails.SetParameterValue("@overage_shortage", (totalDeposits - totalCollection));
                rptCashReceiptDetails.SetParameterValue("@prepared_by", BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                    userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));
                rptCashReceiptDetails.SetParameterValue("@verified_by", String.Empty);// CommonExchange.CompanyInformation.boo.BookKeeper);
                rptCashReceiptDetails.SetParameterValue("@approved_by", String.Empty);// CommonExchange.SchoolInformation.VPOfFinanceAffairs);

                using (BaseServices.CrystalReportViewer frmViewer = new BaseServices.CrystalReportViewer(rptCashReceiptDetails))
                {
                    frmViewer.Text = "   Cash Receipt Detailed";
                    frmViewer.ShowDialog();
                }
            }
        }//------------------------------

        //this procedure will print cash receipt summarized report
        public void PrintCashReceiptSummarizedReport(CommonExchange.SysAccess userInfo, String dateStart, String dateEnd, Boolean isConsolidated)
        {
            String strCashierConsolidated = isConsolidated ? "Consolidated" : BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                       userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName);

            Decimal totalCollection = 0, totalDeposits = 0;

            if (_printingSummariezedCashReceiptTable != null)
            {
                foreach (DataRow detailsRow in _printingSummariezedCashReceiptTable.Rows)
                {
                    totalCollection += RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "total_amount", Decimal.Parse("0"));
                }
            }

            if (_printingBreakDownBankDepositeSummarizedTable != null)
            {
                foreach (DataRow depositRow in _printingBreakDownBankDepositeSummarizedTable.Rows)
                {
                    totalDeposits += RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "total_amount", Decimal.Parse("0"));
                }
            }

            using (ClassCashieringManager.CrystalReport.CrystalCashReceiptSummarized rptCashReceiptSummarized  =
                new CashieringServices.ClassCashieringManager.CrystalReport.CrystalCashReceiptSummarized())
            {
                rptCashReceiptSummarized.Database.Tables["cash_receipt_summarized"].SetDataSource(_printingSummariezedCashReceiptTable);
                rptCashReceiptSummarized.Database.Tables["break_down_summarized"].SetDataSource(_printingBreakDownBankDepositeSummarizedTable);

                rptCashReceiptSummarized.SetParameterValue("@school_name", CommonExchange.CompanyInformation.CompanyName);
                rptCashReceiptSummarized.SetParameterValue("@form_name", "Cash Receipt (Summarized)");
                rptCashReceiptSummarized.SetParameterValue("@cashier_consolidated", strCashierConsolidated);
                rptCashReceiptSummarized.SetParameterValue("@date_range", DateTime.Parse(dateStart).ToLongDateString() + " - " +
                    DateTime.Parse(dateEnd).ToLongDateString());
                rptCashReceiptSummarized.SetParameterValue("@print_info", "Date/Time Printed: " + DateTime.Parse(this.ServerDateTime).ToShortDateString() + " " +
                    DateTime.Parse(this.ServerDateTime).ToShortTimeString() + "         Printed by: " +
                    BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                    userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));
                rptCashReceiptSummarized.SetParameterValue("@total_collection", totalCollection);
                rptCashReceiptSummarized.SetParameterValue("@total_diposit", totalDeposits);
                rptCashReceiptSummarized.SetParameterValue("@overage_shortage", (totalDeposits - totalCollection));
                rptCashReceiptSummarized.SetParameterValue("@prepared_by", BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                    userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));
                rptCashReceiptSummarized.SetParameterValue("@verified_by", String.Empty); //CommonExchange.SchoolInformation.BookKeeper);
                rptCashReceiptSummarized.SetParameterValue("@approved_by", String.Empty); //CommonExchange.SchoolInformation.VPOfFinanceAffairs);

                using (BaseServices.CrystalReportViewer frmViewer = new BaseServices.CrystalReportViewer(rptCashReceiptSummarized))
                {
                    frmViewer.Text = "   Cash Receipt Summarized";
                    frmViewer.ShowDialog();
                }
            }
        }//------------------------------

        //this procedure will insert regular loan payments
        public void InsertRegularLoanPayment(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments regularLoanPaymentInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertRegularLoanPayments(userInfo, regularLoanPaymentInfo);
            }
        }//--------------------------

        //this procedure will update regular loan payments
        public void UpdateRegularLoanPayment(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments regularLoanPaymentInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateRegularLoanPayments(userInfo, regularLoanPaymentInfo);
            }
        }//--------------------------

        //this procedure will delete regular loan payments
        public void DeleteRegularLoanPayment(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoanPayments regularLoanPaymentInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteRegularLoanPayments(userInfo, regularLoanPaymentInfo);
            }
        }//--------------------------

        //this procedure will insert, update and delete multiple regular loan payments
        public void InsertUpdateDeleteRegularLoanPayments(CommonExchange.SysAccess userInfo, DataTable regularLoanPaymentsTable)
        {
            DataTable paymentTable = new DataTable("PaymentTable");
            paymentTable.Columns.Add("payment_id", System.Type.GetType("System.Int64"));
            paymentTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
            paymentTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
            paymentTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            paymentTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            paymentTable.Columns.Add("payment_amount", System.Type.GetType("System.Decimal"));
            paymentTable.Columns.Add("principal_paid", System.Type.GetType("System.Decimal"));
            paymentTable.Columns.Add("interest_paid", System.Type.GetType("System.Decimal"));
            paymentTable.Columns.Add("discount_amount", System.Type.GetType("System.Decimal"));
            paymentTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
            paymentTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            paymentTable.Columns.Add("bank", System.Type.GetType("System.String"));
            paymentTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            paymentTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));

            Int64 paymentId = -1;

            if (regularLoanPaymentsTable != null)
            {
                foreach (DataRow paymentRow in regularLoanPaymentsTable.Rows)
                {
                    DataRow newRow = paymentTable.NewRow();

                    newRow["payment_id"] = paymentId;
                    newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_regular_hidden", String.Empty);
                    newRow["reflected_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "reflected_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    newRow["receipt_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_no", String.Empty);
                    newRow["payment_amount"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_paid", String.Empty));
                    newRow["principal_paid"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "principal_paid", String.Empty));
                    newRow["interest_paid"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "interest_paid", String.Empty));
                    newRow["discount_amount"] = !String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "discount_amount", String.Empty)) ?
                        Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "discount_amount", String.Empty)) : 0;
                    newRow["amount_tendered"] = !String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_tendered", String.Empty)) ?
                        Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_tendered", String.Empty)) : 0;
                    newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "remarks", String.Empty);
                    newRow["bank"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "bank_name", String.Empty);
                    newRow["check_no"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "check_no_not_froze", String.Empty);
                    newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_account_credit", String.Empty);

                    paymentTable.Rows.Add(newRow);

                    paymentId--;
                }

                using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
                {
                    remClient.InsertUpdateDeleteRegularLoanPayments(userInfo, paymentTable);
                }
            }
        }//----------------------      

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

        //this procedure will insert, update and delete multiple share capital credit payment
        public void InsertUpdateDeleteShareCapitalCreditPayments(CommonExchange.SysAccess userInfo, DataTable shareCapitalCreditMultiplePaymentTable)
        {
            DataTable shareCapitalTable = new DataTable("PaymentTable");
            shareCapitalTable.Columns.Add("capital_credit_id", System.Type.GetType("System.Int64"));
            shareCapitalTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
            shareCapitalTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
            shareCapitalTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            shareCapitalTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            shareCapitalTable.Columns.Add("credit_amount", System.Type.GetType("System.Decimal"));
            shareCapitalTable.Columns.Add("discount_amount", System.Type.GetType("System.Decimal"));
            shareCapitalTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
            shareCapitalTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            shareCapitalTable.Columns.Add("bank", System.Type.GetType("System.String"));
            shareCapitalTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            shareCapitalTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));

            Int64 capitalCreditId = -1;

            if (shareCapitalCreditMultiplePaymentTable != null)
            {
                foreach (DataRow paymentRow in shareCapitalCreditMultiplePaymentTable.Rows)
                {
                    DataRow newRow = shareCapitalTable.NewRow();

                    newRow["capital_credit_id"] = capitalCreditId;
                    newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_member_hidden", String.Empty);
                    newRow["reflected_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "reflected_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    newRow["receipt_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_no", String.Empty);
                    newRow["credit_amount"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_paid", String.Empty));
                    newRow["discount_amount"] = !String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "discount_amount", String.Empty)) ?
                        Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "discount_amount", String.Empty)) : 0;
                    newRow["amount_tendered"] = !String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_tendered", String.Empty)) ?
                        Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_tendered", String.Empty)) : 0;
                    newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "remarks", String.Empty);
                    newRow["bank"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "bank_name", String.Empty);
                    newRow["check_no"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "check_no_not_froze", String.Empty);
                    newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_account_credit", String.Empty);

                    shareCapitalTable.Rows.Add(newRow);

                    capitalCreditId--;
                }

                using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
                {
                    remClient.InsertUpdateDeleteShareCapitalCredit(userInfo, shareCapitalTable);
                }
            }
        }//----------------------

        //this procedure will insert in-house hospitalization
        public void InsertInHouseHospitalization(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit inHouseHospitalizationCreditInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertInHouseHospitalizationCredit(userInfo, inHouseHospitalizationCreditInfo);
            }
        }//----------------------------

        //this procedure will update in-house hospitalization
        public void UpdateInHouseHospitalization(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit inHouseHospitalizationCreditInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateInHouseHospitalizationCredit(userInfo, inHouseHospitalizationCreditInfo);
            }
        }//----------------------------

        //this procedure will delete in-house hospitalization
        public void DeleteInHouseHospitalization(CommonExchange.SysAccess userInfo, CommonExchange.InHouseHospitalizationCredit inHouseHospitalizationCreditInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteInHouseHospitalizationCredit(userInfo, inHouseHospitalizationCreditInfo);
            }
        }//----------------------------

        //this procedure will insert, update and delete multiple In-House Hospitalization payment
        public void InsertUpdateDeleteInHouseHospitalizationPayments(CommonExchange.SysAccess userInfo, DataTable InHouseHospitalizationMultiplePaymentTable)
        {
            DataTable inHouseTable = new DataTable("PaymentTable");
            inHouseTable.Columns.Add("hospitalization_credit_id", System.Type.GetType("System.Int64"));
            inHouseTable.Columns.Add("sysid_member", System.Type.GetType("System.String"));
            inHouseTable.Columns.Add("reflected_date", System.Type.GetType("System.String"));
            inHouseTable.Columns.Add("receipt_date", System.Type.GetType("System.String"));
            inHouseTable.Columns.Add("receipt_no", System.Type.GetType("System.String"));
            inHouseTable.Columns.Add("credit_amount", System.Type.GetType("System.Decimal"));
            inHouseTable.Columns.Add("discount_amount", System.Type.GetType("System.Decimal"));
            inHouseTable.Columns.Add("amount_tendered", System.Type.GetType("System.Decimal"));
            inHouseTable.Columns.Add("remarks", System.Type.GetType("System.String"));
            inHouseTable.Columns.Add("bank", System.Type.GetType("System.String"));
            inHouseTable.Columns.Add("check_no", System.Type.GetType("System.String"));
            inHouseTable.Columns.Add("sysid_account_credit", System.Type.GetType("System.String"));

            Int64 inHouseId = -1;

            if (InHouseHospitalizationMultiplePaymentTable != null)
            {
                foreach (DataRow paymentRow in InHouseHospitalizationMultiplePaymentTable.Rows)
                {
                    DataRow newRow = inHouseTable.NewRow();

                    newRow["hospitalization_credit_id"] = inHouseId;
                    newRow["sysid_member"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_member_hidden", String.Empty);
                    newRow["reflected_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "reflected_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    newRow["receipt_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_no", String.Empty);
                    newRow["credit_amount"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_paid", String.Empty));
                    newRow["discount_amount"] = !String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "discount_amount", String.Empty)) ?
                        Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "discount_amount", String.Empty)) : 0;
                    newRow["amount_tendered"] = !String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_tendered", String.Empty)) ?
                        Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_tendered", String.Empty)) : 0;
                    newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "remarks", String.Empty);
                    newRow["bank"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "bank_name", String.Empty);
                    newRow["check_no"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "check_no_not_froze", String.Empty);
                    newRow["sysid_account_credit"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_account_credit", String.Empty);

                    inHouseTable.Rows.Add(newRow);

                    inHouseId--;
                }

                using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
                {
                    remClient.InsertUpdateDeleteInHouseHospitalizationCredit(userInfo, inHouseTable);
                }
            }
        }//----------------------

        //this procedure will insert miscellaneous income
        public void InsertMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscellaneousIncomInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertMiscellaneousIncome(userInfo, miscellaneousIncomInfo);
            }
        }//-------------------------

        //this procedure will update miscellaneous income
        public void UpdateMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscellaneousIncomeInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateMiscellaneousIncome(userInfo, miscellaneousIncomeInfo);
            }

            if (_miscellaneouseIncomeTable != null)
            {
                Int32 index = 0;
                foreach (DataRow mRow in _miscellaneouseIncomeTable.Rows)
                {
                    if (mRow.RowState != DataRowState.Deleted)
                    {
                        if (miscellaneousIncomeInfo.PaymentId == RemoteServerLib.ProcStatic.DataRowConvert(mRow, "payment_id", Int64.Parse("0")))
                        {
                            DataRow editRow = _miscellaneouseIncomeTable.Rows[index];

                            editRow.BeginEdit();

                            editRow["payment_id"] = miscellaneousIncomeInfo.PaymentId;
                            editRow["received_from"] = miscellaneousIncomeInfo.ReceivedFrom;
                            editRow["reflected_date"] = miscellaneousIncomeInfo.ReflectedDate;
                            editRow["received_date"] = miscellaneousIncomeInfo.ReceivedDate;
                            editRow["receipt_date"] = miscellaneousIncomeInfo.ReceiptDate;
                            editRow["receipt_no"] = miscellaneousIncomeInfo.ReceiptNo;
                            editRow["remarks"] = miscellaneousIncomeInfo.Remarks;
                            editRow["miscellaneous_amount"] = miscellaneousIncomeInfo.MiscellaneousAmount;
                            editRow["discount_amount"] = miscellaneousIncomeInfo.DiscountAmount;
                            editRow["amount_tendered"] = miscellaneousIncomeInfo.AmountTendered;
                            editRow["bank"] = miscellaneousIncomeInfo.Bank;
                            editRow["check_no"] = miscellaneousIncomeInfo.CheckNo;
                            editRow["sysid_account_credit"] = miscellaneousIncomeInfo.AccountCreditInfo.AccountSysId;
                            editRow["account_code"] = miscellaneousIncomeInfo.AccountCreditInfo.AccountCode;
                            editRow["account_name"] = miscellaneousIncomeInfo.AccountCreditInfo.AccountName;
                            editRow["sysid_member"] = miscellaneousIncomeInfo.MemberInfo.MemberSysId;
                            editRow["sysid_collector"] = miscellaneousIncomeInfo.CollectorInfo.CollectorSysId;

                            editRow.EndEdit();
                        }
                    }

                    index++;
                }
            }
        }//-------------------------

        //this procedure will delete miscellaneous income
        public void DeleteMiscellaneousIncome(CommonExchange.SysAccess userInfo, CommonExchange.MiscellaneousIncome miscellaneousIncomInfo)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteMiscellaneousIncome(userInfo, miscellaneousIncomInfo);
            }
        }//-------------------------

        //this procedure will insert break down banck deposit
        public void InsertBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.InsertBreakdownBankDeposit(userInfo, breakdownDeposit);
            }
        }//--------------------------

        //this procedure will update break down deposit
        public void UpdateBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.UpdateBreakdownBankDeposit(userInfo, breakdownDeposit);
            }
        }//--------------------------

        //this procedure will delete break down deposit
        public void DeleteBreakdownBankDeposit(CommonExchange.SysAccess userInfo, CommonExchange.BreakdownBankDeposit breakdownDeposit)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                remClient.DeleteBreakdownBankDeposit(userInfo, breakdownDeposit);
            }
        }//--------------------------

        //this procedure will select cash receipts details information
        public void SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome(CommonExchange.SysAccess userInfo,
            String dateStart, String dateEnd, Boolean isConsolidated)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _cashReceiptDetailsTable = remClient.SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome(userInfo, dateStart, dateEnd, isConsolidated);
            }
        }//--------------------------

        //this procedure will select break down bank deposit details
        public void SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit(CommonExchange.SysAccess userInfo, String dateStart, String dateEnd, Boolean isConsolidated)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _breakDownBankDepositDetailsTable = remClient.SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit(userInfo, dateStart, dateEnd, isConsolidated);
            }
        }//------------------

        //this procedure will select summariezed cash recepts information
        public void SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome(CommonExchange.SysAccess userInfo,
            String dateStart, String dateEnd, Boolean isConsolidated)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _summariezedCashReceiptTable = remClient.SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome(userInfo, dateStart, dateEnd, isConsolidated);
            }
        }//-------------------------

        //this procedure will select break down bank deposit summarized
        public void SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit(CommonExchange.SysAccess userInfo, String dateStart, String dateEnd, Boolean isConsolidated)
        {
            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _breakDownBackDepositeSummarizedTable = remClient.SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit(userInfo, dateStart, dateEnd, isConsolidated);
            }
        }//-----------------------

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

            if (_cashieringClassDataSet.Tables["MemberClassificationTable"] != null)
            {
                foreach (DataRow memRow in _cashieringClassDataSet.Tables["MemberClassificationTable"].Rows)
                {
                    cbxBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(memRow, "classification_description", String.Empty));
                }
            }
        }//------------------------

        //this procedure will initialize member type checked list box
        public void InitializeMemberTypeCheckedListBox(CheckedListBox cbxBase)
        {
            cbxBase.Items.Clear();

            if (_cashieringClassDataSet.Tables["MemberTypeTable"] != null)
            {
                foreach (DataRow memRow in _cashieringClassDataSet.Tables["MemberTypeTable"].Rows)
                {
                    cbxBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_type_description", String.Empty));
                }
            }
        }//-----------------------

        //this procedure will initialize miscellaneouse payment listview
        public void InitializeMiscellaneousePaymentListView(ListView lsvBase, CommonExchange.SysAccess userInfo, String queryString,
            String dateStart, String dateEnd)
        {
            lsvBase.Items.Clear();

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _miscellaneouseIncomeTable = remClient.SelectByQueryStringDateStartEndMiscellaneousIncome(userInfo, queryString,
                    dateStart, dateEnd);
            }

            if (_miscellaneouseIncomeTable != null)
            {
                foreach (DataRow miscRow in _miscellaneouseIncomeTable.Rows)
                {
                    ListViewItem addItem = new ListViewItem(new String[] {
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "receipt_no", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "received_date", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "reflected_date", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "receipt_date", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "received_from", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "miscellaneous_amount", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "discount_amount", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "remarks", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "account_code", String.Empty) + " - " +
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "account_name", String.Empty), 
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "payment_id", Int64.Parse("0")).ToString()});

                    lsvBase.Items.Add(addItem);
                }
            }
        }//-----------------------------

        //this procedure will initialize the cash receipts details listview and prepare also the table for printing the report
        public void InitializeCashReceiptsDetailsListView(ListView lsvBase, Label lblCollection, Label lblDeposits, Label lblOverage)
        {
            lsvBase.Items.Clear();
            _printingCashReceiptsDetailsTable.Rows.Clear();

            if (_cashReceiptDetailsTable != null)
            {
                Decimal totalAmount = 0;

                foreach (DataRow detailsRow in _cashReceiptDetailsTable.Rows)
                {
                    ListViewItem addItem = new ListViewItem(new String[] { "      " + 
                        RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "receipt_no", String.Empty),
                        DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "received_date", String.Empty)).ToShortDateString(),
                        RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "received_from", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "office_employer_acronym", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "account_code", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "account_name", String.Empty),
                        RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "amount", Decimal.Parse("0")).ToString("N")});

                    DataRow newRow = _printingCashReceiptsDetailsTable.NewRow();

                    newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "receipt_no", String.Empty);
                    newRow["received_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "received_date", String.Empty)).ToShortDateString();
                    newRow["received_from"] = RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "received_from", String.Empty);
                    newRow["acronym"] = RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "office_employer_acronym", String.Empty);
                    newRow["account_code"] = RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "account_code", String.Empty);
                    newRow["account_name"] = RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "account_name", string.Empty);
                    newRow["amount"] = RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "amount", Decimal.Parse("0"));
                    newRow["total"] = 0;

                    _printingCashReceiptsDetailsTable.Rows.Add(newRow);

                    totalAmount += RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "amount", Decimal.Parse("0"));

                    lsvBase.Items.Add(addItem);
                }

                ListViewItem totalIncomeItem = new ListViewItem(new String[] { String.Empty, String.Empty, "    Total cash receipts for the period:", 
                    String.Empty, String.Empty, String.Empty, totalAmount.ToString("N")});

                totalIncomeItem.ForeColor = Color.LightCoral;

                lsvBase.Items.Add(totalIncomeItem);

                DataRow newRowTotalAmount = _printingCashReceiptsDetailsTable.NewRow();

                newRowTotalAmount["receipt_no"] = String.Empty;
                newRowTotalAmount["received_date"] = String.Empty;
                newRowTotalAmount["received_from"] = String.Empty;
                newRowTotalAmount["acronym"] = String.Empty;
                newRowTotalAmount["account_code"] = String.Empty;
                newRowTotalAmount["account_name"] = String.Empty;
                newRowTotalAmount["amount"] = 0;
                newRowTotalAmount["total"] = totalAmount;

                _printingCashReceiptsDetailsTable.Rows.Add(newRowTotalAmount);

                Decimal totalCollection = 0, totalDeposits = 0;

                if (_printingCashReceiptsDetailsTable != null)
                {
                    foreach (DataRow detailsRow in _printingCashReceiptsDetailsTable.Rows)
                    {
                        totalCollection += RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "amount", Decimal.Parse("0"));
                    }
                }

                if (_printingBreakDownBankDepositDetailsTable != null)
                {
                    foreach (DataRow depositRow in _printingBreakDownBankDepositDetailsTable.Rows)
                    {
                        totalDeposits += RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "amount", Decimal.Parse("0"));
                    }
                }

                lblCollection.Text = totalCollection.ToString("N");
                lblDeposits.Text = totalDeposits.ToString("N");
                lblOverage.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (totalDeposits - totalCollection));
            }
        }//------------------------

        //this procedure will initialize the summariezed cash receipts listview and prepare also the table for printing the report
        public void InitializeSummariedCashReceiptListView(ListView lsvBase, Label lblCollection, Label lblDeposits, Label lblOverage)
        {
            lsvBase.Items.Clear();
            _printingSummariezedCashReceiptTable.Rows.Clear();

            if (_summariezedCashReceiptTable != null)
            {
                Boolean isMiscellaneousIncome = false;
                Boolean hasStudentPayment = false;
                Boolean hasMiscellaneousIncome = false;

                Decimal studentPaymentIncome = 0;
                Decimal miscellaneousIncome = 0;

                DataRow groupTitleRowStudentPayment = _printingSummariezedCashReceiptTable.NewRow();

                groupTitleRowStudentPayment["group_title"] = "LOAN PAYMENTS, SHARE CAPITAL, IN-HOUSE HOSPITALIZATION";
                groupTitleRowStudentPayment["account_code_summary"] = String.Empty;
                groupTitleRowStudentPayment["account_name_summary"] = String.Empty;
                groupTitleRowStudentPayment["acronym"] = String.Empty;
                groupTitleRowStudentPayment["account_code_subsidiary"] = String.Empty;
                groupTitleRowStudentPayment["account_name_subsidiary"] = String.Empty;
                groupTitleRowStudentPayment["total_amount"] = 0;
                groupTitleRowStudentPayment["total"] = 0;

                _printingSummariezedCashReceiptTable.Rows.Add(groupTitleRowStudentPayment);

                foreach (DataRow summarizedRow in _summariezedCashReceiptTable.Rows)
                {
                    ListViewItem addItem;

                    if (!RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "is_miscellaneous_income", false))
                    {
                        addItem = new ListViewItem(new String[] { "      " + 
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "office_employer_acronym", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_subsidiary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_subsidiary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "total_amount", Decimal.Parse("0")).ToString("N"), 
                            String.Empty}, lsvBase.Groups[0]);

                        DataRow newRow = _printingSummariezedCashReceiptTable.NewRow();

                        newRow["group_title"] = String.Empty;
                        newRow["account_code_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_summary", String.Empty);
                        newRow["account_name_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_summary", string.Empty);
                        newRow["acronym"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "office_employer_acronym", String.Empty);
                        newRow["account_code_subsidiary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_subsidiary", String.Empty);
                        newRow["account_name_subsidiary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_subsidiary", String.Empty);
                        newRow["total_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "total_amount", Decimal.Parse("0"));
                        newRow["total"] = 0;

                        _printingSummariezedCashReceiptTable.Rows.Add(newRow);

                        studentPaymentIncome += RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "total_amount", Decimal.Parse("0"));

                        hasStudentPayment = true;
                    }
                    else
                    {
                        if ((isMiscellaneousIncome != RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "is_miscellaneous_income", false)) && hasStudentPayment)
                        {
                            ListViewItem subItemStudentPayment = new ListViewItem(new String[] { "      " + String.Empty,
                                "       Sub Total", String.Empty, String.Empty, String.Empty, String.Empty, 
                                studentPaymentIncome.ToString("N")}, lsvBase.Groups[0]);

                            subItemStudentPayment.ForeColor = Color.LightCoral;

                            lsvBase.Items.Add(subItemStudentPayment);

                            DataRow subTotalStudentPaymentNewRow = _printingSummariezedCashReceiptTable.NewRow();

                            subTotalStudentPaymentNewRow["group_title"] = String.Empty;
                            subTotalStudentPaymentNewRow["account_code_summary"] = String.Empty;
                            subTotalStudentPaymentNewRow["account_name_summary"] = "       Sub Total";
                            subTotalStudentPaymentNewRow["acronym"] = String.Empty;
                            subTotalStudentPaymentNewRow["account_code_subsidiary"] = String.Empty;
                            subTotalStudentPaymentNewRow["account_name_subsidiary"] = String.Empty;
                            subTotalStudentPaymentNewRow["total_amount"] = 0;
                            subTotalStudentPaymentNewRow["total"] = studentPaymentIncome;

                            _printingSummariezedCashReceiptTable.Rows.Add(subTotalStudentPaymentNewRow);

                            DataRow groupTitleRowMiscellaneousIncome = _printingSummariezedCashReceiptTable.NewRow();

                            groupTitleRowMiscellaneousIncome["group_title"] = "MISCELLANEOUS INCOME";
                            groupTitleRowMiscellaneousIncome["account_code_summary"] = String.Empty;
                            groupTitleRowMiscellaneousIncome["account_name_summary"] = String.Empty;
                            groupTitleRowMiscellaneousIncome["acronym"] = String.Empty;
                            groupTitleRowMiscellaneousIncome["account_code_subsidiary"] = String.Empty;
                            groupTitleRowMiscellaneousIncome["account_name_subsidiary"] = String.Empty;
                            groupTitleRowMiscellaneousIncome["total_amount"] = 0;
                            groupTitleRowMiscellaneousIncome["total"] = 0;

                            _printingSummariezedCashReceiptTable.Rows.Add(groupTitleRowMiscellaneousIncome);
                        }

                        addItem = new ListViewItem(new String[] { "      " + 
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "office_employer_acronym", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_subsidiary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_subsidiary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "total_amount", Decimal.Parse("0")).ToString("N"), 
                            String.Empty}, lsvBase.Groups[1]);

                        DataRow newRow = _printingSummariezedCashReceiptTable.NewRow();

                        newRow["group_title"] = String.Empty;
                        newRow["account_code_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_summary", String.Empty);
                        newRow["account_name_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_summary", string.Empty);
                        newRow["acronym"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "office_employer_acronym", String.Empty);
                        newRow["account_code_subsidiary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_code_subsidiary", String.Empty);
                        newRow["account_name_subsidiary"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "account_name_subsidiary", String.Empty);
                        newRow["total_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "total_amount", Decimal.Parse("0"));
                        newRow["total"] = 0;

                        _printingSummariezedCashReceiptTable.Rows.Add(newRow);

                        miscellaneousIncome += RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "total_amount", Decimal.Parse("0"));

                        hasMiscellaneousIncome = true;
                    }

                    isMiscellaneousIncome = RemoteServerLib.ProcStatic.DataRowConvert(summarizedRow, "is_miscellaneous_income", false);

                    lsvBase.Items.Add(addItem);
                }

                if (!hasMiscellaneousIncome)
                {
                    ListViewItem subItemStudentPayment = new ListViewItem(new String[] { String.Empty, "       Sub Total", String.Empty, String.Empty, 
                            String.Empty, String.Empty,  studentPaymentIncome.ToString("N")}, lsvBase.Groups[0]);

                    subItemStudentPayment.ForeColor = Color.LightCoral;

                    lsvBase.Items.Add(subItemStudentPayment);

                    DataRow subTotalStudentPaymentNewRow = _printingSummariezedCashReceiptTable.NewRow();

                    subTotalStudentPaymentNewRow["group_title"] = String.Empty;
                    subTotalStudentPaymentNewRow["account_code_summary"] = String.Empty;
                    subTotalStudentPaymentNewRow["account_name_summary"] = "       Sub Total";
                    subTotalStudentPaymentNewRow["acronym"] = String.Empty;
                    subTotalStudentPaymentNewRow["account_code_subsidiary"] = String.Empty;
                    subTotalStudentPaymentNewRow["account_name_subsidiary"] = String.Empty;
                    subTotalStudentPaymentNewRow["total_amount"] = 0;
                    subTotalStudentPaymentNewRow["total"] = studentPaymentIncome;

                    _printingSummariezedCashReceiptTable.Rows.Add(subTotalStudentPaymentNewRow);
                }
                else
                {
                    ListViewItem subItemMiscellaneousIncome = new ListViewItem(new String[] { String.Empty, "       Sub Total", String.Empty, String.Empty, 
                            String.Empty, String.Empty, miscellaneousIncome.ToString("N")}, lsvBase.Groups[1]);

                    subItemMiscellaneousIncome.ForeColor = Color.LightCoral;

                    lsvBase.Items.Add(subItemMiscellaneousIncome);

                    DataRow subTotalMiscellaneousIncomeNewRow = _printingSummariezedCashReceiptTable.NewRow();

                    subTotalMiscellaneousIncomeNewRow["group_title"] = String.Empty;
                    subTotalMiscellaneousIncomeNewRow["account_code_summary"] = String.Empty;
                    subTotalMiscellaneousIncomeNewRow["account_name_summary"] = "       Sub Total";
                    subTotalMiscellaneousIncomeNewRow["acronym"] = String.Empty;
                    subTotalMiscellaneousIncomeNewRow["account_code_subsidiary"] = String.Empty;
                    subTotalMiscellaneousIncomeNewRow["account_name_subsidiary"] = String.Empty;
                    subTotalMiscellaneousIncomeNewRow["total_amount"] = 0;
                    subTotalMiscellaneousIncomeNewRow["total"] = miscellaneousIncome;

                    _printingSummariezedCashReceiptTable.Rows.Add(subTotalMiscellaneousIncomeNewRow);
                }

                Decimal totalCollection = 0, totalDeposits = 0;

                if (_printingSummariezedCashReceiptTable != null)
                {
                    foreach (DataRow detailsRow in _printingSummariezedCashReceiptTable.Rows)
                    {
                        totalCollection += RemoteServerLib.ProcStatic.DataRowConvert(detailsRow, "total_amount", Decimal.Parse("0"));
                    }
                }

                if (_printingBreakDownBankDepositeSummarizedTable != null)
                {
                    foreach (DataRow depositRow in _printingBreakDownBankDepositeSummarizedTable.Rows)
                    {
                        totalDeposits += RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "total_amount", Decimal.Parse("0"));
                    }
                }

                lblCollection.Text = totalCollection.ToString("N");
                lblDeposits.Text = totalDeposits.ToString("N");
                lblOverage.Text = String.Format("{0:#,##0.00;(#,##0.00)}", (totalDeposits - totalCollection));

            }
        }//--------------------------

        //this procedure will initialize break down bank deposit details list view
        public void InitializeBreakDownBankDepositDetailsSummarizedListView(ListView lsvBase, Boolean isDetails)
        {
            lsvBase.Items.Clear();

            DataTable tempTable = null;

            if (isDetails)
            {
                _printingBreakDownBankDepositDetailsTable.Rows.Clear();

                tempTable = _breakDownBankDepositDetailsTable;
            }
            else
            {
                _printingBreakDownBankDepositeSummarizedTable.Rows.Clear();

                tempTable = _breakDownBackDepositeSummarizedTable;
            }

            if (tempTable != null)
            {
                Decimal total = 0;

                foreach (DataRow depositRow in tempTable.Rows)
                {
                    if (isDetails)
                    {
                        ListViewItem addItem = new ListViewItem(new String[] { RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "amount", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "sysid_account", String.Empty)});

                        lsvBase.Items.Add(addItem);

                        total += RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "amount", Decimal.Parse("0"));

                        DataRow newRow = _printingBreakDownBankDepositDetailsTable.NewRow();

                        newRow["account_code_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code_summary", String.Empty);
                        newRow["account_name_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name_summary", String.Empty);
                        newRow["account_code"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code", String.Empty);
                        newRow["account_name"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name", String.Empty);
                        newRow["amount"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "amount", Decimal.Parse("0"));

                        _printingBreakDownBankDepositDetailsTable.Rows.Add(newRow);
                    }
                    else
                    {
                        ListViewItem addItem = new ListViewItem(new String[] { RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name_summary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code_subsidiary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name_subsidiary", String.Empty),
                            RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "total_amount", Decimal.Parse("0")).ToString("N"), String.Empty});

                        DataRow newRow = _printingBreakDownBankDepositeSummarizedTable.NewRow();

                        newRow["account_code_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code_summary", String.Empty);
                        newRow["account_name_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name_summary", String.Empty);
                        newRow["account_code_subsidiary"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code_subsidiary", String.Empty);
                        newRow["account_name_subsidiary"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name_subsidiary", String.Empty);
                        newRow["total_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "total_amount", Decimal.Parse("0"));

                        _printingBreakDownBankDepositeSummarizedTable.Rows.Add(newRow);

                        total += RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "total_amount", Decimal.Parse("0"));

                        lsvBase.Items.Add(addItem);
                    }
                }

                ListViewItem totalIncomeItem = new ListViewItem(new String[] { String.Empty, "    Total bank deposits for the period:", 
                    String.Empty, String.Empty, total.ToString("N"), String.Empty});

                totalIncomeItem.ForeColor = Color.LightCoral;

                lsvBase.Items.Add(totalIncomeItem);
            }
        }//-----------------------

        //this procedure will initialize billing statement List View
        public void InitializeBillingStatementListView(ListView lsvBase, CommonExchange.SysAccess userInfo, String memberSysIdList, String dateStart, String dateEnd)
        {
            lsvBase.Groups.Clear();
            lsvBase.Items.Clear();

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _billingStatementTable = remClient.SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices(userInfo, memberSysIdList, dateStart, dateEnd);
            }

            if (_officeEmployerTable != null && _billingStatementTable != null)
            {
                foreach (DataRow officeRow in _officeEmployerTable.Rows)
                {
                    Boolean isFirstEnter = true;

                    String strFilterOffice = "office_employer_id = '" + RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_id", String.Empty) + "'";
                    DataRow[] selectRow = _billingStatementTable.Select(strFilterOffice);

                    foreach (DataRow billRow in selectRow)
                    {
                        if (isFirstEnter)
                        {
                            lsvBase.Groups.Add(RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_name", String.Empty),
                                RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_name", String.Empty) + " [" +
                                RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_acronym", String.Empty) + "]");

                            isFirstEnter = false;
                        }

                        ListViewItem addItem = new ListViewItem(new String[] 
                            { "          " + BaseServices.ProcStatic.GetCompleteNameMiddleInitial(billRow, "last_name", "first_name", "middle_name"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "share_capital_amount", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "hospitalization_amount", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "birthday_principal", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "birthday_interest", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "contingency_principal", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "contingency_interest", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "salary_principal", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "salary_interest", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "medical_principal", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "medical_interest", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "special_principal", Decimal.Parse("0")).ToString("N"),
                            RemoteServerLib.ProcStatic.DataRowConvert(billRow, "special_interest", Decimal.Parse("0")).ToString("N") },
                            lsvBase.Groups[RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_name", String.Empty)]);

                        lsvBase.Items.Add(addItem);
                    }
                }

                lsvBase.Groups.Add("grpOthers", "Office/Employer NOT SPECIFIED");

                String strFilterOfficeEmpty = "office_employer_id IS NULL";
                DataRow[] selectRowEmpty = _billingStatementTable.Select(strFilterOfficeEmpty);

                foreach (DataRow billRow in selectRowEmpty)
                {
                    ListViewItem addItem = new ListViewItem(new String[] 
                        {"          " + BaseServices.ProcStatic.GetCompleteNameMiddleInitial(billRow, "last_name", "first_name", "middle_name"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "share_capital_amount", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "hospitalization_amount", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "birthday_principal", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "birthday_interest", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "contingency_principal", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "contingency_interest", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "salary_principal", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "salary_interest", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "medical_principal", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "medical_interest", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "special_principal", Decimal.Parse("0")).ToString("N"),
                        RemoteServerLib.ProcStatic.DataRowConvert(billRow, "special_interest", Decimal.Parse("0")).ToString("N")},
                        lsvBase.Groups["grpOthers"]);

                    lsvBase.Items.Add(addItem);
                }
            }
        }//-------------------------------
        #endregion

        #region Programmer's Defined Functions
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

            if (isMemberClassification && _cashieringClassDataSet.Tables["MemberClassificationTable"] != null)
            {
                DataRow memRow = _cashieringClassDataSet.Tables["MemberClassificationTable"].Rows[index];

                value = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "classification_id", String.Empty);
            }
            else if (!isMemberClassification && _cashieringClassDataSet.Tables["MemberTypeTable"] != null)
            {
                DataRow memRow = _cashieringClassDataSet.Tables["MemberTypeTable"].Rows[index];

                value = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_type_id", String.Empty);
            }

            return value;
        }//----------------------

        //this fucntion will get populate member information table
        public DataTable PopulateMemberInformationTableList()
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

            if (_memberTable != null)
            {
                foreach (DataRow memRow in _memberTable.Rows)
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

        //this fucntion will get searched member information table
        public Int32 GetSearchedMemberInformationTable(CommonExchange.SysAccess userInfo, String queryString, String officeEmployerIdList,
            String classificationIdList, String memberSysIdExcludeList, String memberTypeIdList, Boolean includeMemberStatus, Boolean isActive, Boolean isNewQuery)
        {
            if (isNewQuery)
            {
                using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
                {
                    _memberTable = remClient.SelectMemberInformation(userInfo, queryString, officeEmployerIdList, memberTypeIdList, classificationIdList,
                        memberSysIdExcludeList, includeMemberStatus, isActive);
                }
            }

            return _memberTable.Rows.Count;
        }//----------------------

        //this function will get searched member or employee infomration
        public DataTable GetSearchedMemberEmployeeTable(CommonExchange.SysAccess userInfo, String queryString)
        {
            DataTable newTable = this.MemberEmployeeTable;

            using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
            {
                _memberEmployeeTable = remClient.SelectByQueryStringMemberEmployeeInformation(userInfo, queryString);
            }//-------------------

            if (_memberEmployeeTable != null)
            {
                foreach (DataRow empRow in _memberEmployeeTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["member_employee_id"] = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "member_employee_id", String.Empty);
                    newRow["person_name_forzeen"] = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(empRow, "last_name", "first_name", "middle_name");
                    newRow["present_address"] = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "present_address", String.Empty);
                    newRow["present_phone_nos"] = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "present_phone_nos", String.Empty);
                    newRow["home_address"] = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "home_address", String.Empty);
                    newRow["home_phone_nos"] = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "home_address", String.Empty);
                    newRow["occupation"] = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "occupation", String.Empty);

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//-----------------------------

        //this function will get searched regular loan information
        public DataTable GetSearchedRegularLoanInformation(CommonExchange.SysAccess userInfo, String memberSysIdList, 
            Boolean isMarkedDeleted, Boolean isActiveLoad)
        {
            DataTable newTable = this.RegularLoanTable;

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                _regularLoanInformationTable = remClient.SelectBySysIDMemberListRegularLoanInformation(userInfo, memberSysIdList, isMarkedDeleted);
            }
           
            if (_regularLoanInformationTable != null)
            {
                String strFilter = "is_active_loan = " + isActiveLoad;
                DataRow[] selectRow = _regularLoanInformationTable.Select(strFilter);

                foreach (DataRow regLoanRow in selectRow)
                {
                    if (regLoanRow.RowState != DataRowState.Deleted)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["sysid_regular_hidden"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "sysid_regular", String.Empty);
                        newRow["account_no"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "account_no", String.Empty);
                        newRow["loan_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "loan_amount", Decimal.Parse("0")).ToString("N");
                        newRow["purpose_of_loan"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "purpose_of_loan", String.Empty).ToString();
                        newRow["loan_terms"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "loan_terms", Single.Parse("0")).ToString();
                        newRow["interest_rate"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "interest_rate", Int16.Parse("0")).ToString() + "%";
                        newRow["date_first_payment"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "date_first_payment", String.Empty)).ToLongDateString();
                        newRow["date_maturity"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "date_maturity", String.Empty)).ToLongDateString();
                        newRow["regular_loan_type_description_freeze"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "regular_loan_type_description", String.Empty);
                        newRow["repayment_description"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "repayment_description", String.Empty);

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//--------------------------

        //this fucntion will get the regular loan payments
        public DataTable GetRegularLoanPayments(CommonExchange.SysAccess userInfo, String regularLoanSysIdList, ToolStripLabel lblTotalPayment)
        {
            DataTable newTable = this.RegularLoanPaymentHistoryTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _regularLoanPaymentTable = remClient.SelectBySysIDRegularListRegularLoanPayments(userInfo, regularLoanSysIdList);
            }
            
            Decimal totalPayment = 0;

            foreach (DataRow paymentRow in _regularLoanPaymentTable.Rows)
            {
                DataRow newRow = newTable.NewRow();

                newRow["payment_id"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "payment_id", Int64.Parse("0"));
                newRow["receipt_no"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_no", String.Empty);
                newRow["received_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "received_date", String.Empty)).ToShortDateString();
                newRow["reflected_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "reflected_date", String.Empty)).ToShortDateString();
                newRow["receipt_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_date", String.Empty)).ToShortDateString();
                newRow["amount_paid"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "payment_amount", Decimal.Parse("0")).ToString("N");
                newRow["principal_paid"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "principal_paid", Decimal.Parse("0")).ToString("N");
                newRow["interest_paid"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "interest_paid", Decimal.Parse("0")).ToString("N");
                newRow["rebate_paid"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "rebate_amount", Decimal.Parse("0")).ToString("N");
                newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "remarks", String.Empty);

                newTable.Rows.Add(newRow);

                totalPayment += (RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "payment_amount", Decimal.Parse("0")) +
                       RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "rebate_amount", Decimal.Parse("0")));
            }

            lblTotalPayment.Text = "Total Payments Received: " + totalPayment.ToString("N");

            return newTable;
        }//------------------

        //this function will get shared capital credits
        public DataTable GetShareCapitalCredits(CommonExchange.SysAccess userInfo, String memberSysIdList)
        {
            DataTable newTable = this.ShareCapitalCreditTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _shareCapitalCreditTable = remClient.SelectBySysIDMemberListShareCapitalCredit(userInfo, memberSysIdList);
            }

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
            }

            return newTable;
        }//-----------------

        //this function will get member's equity
        public DataTable GetMembersEquity(CommonExchange.SysAccess userInfo, String memberSysIdList)
        {
            DataTable newTable = this.MembersEquityTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _membersEquityTable = remClient.SelectBySysIDMemberListMemberEquityCredit(userInfo, memberSysIdList);
            }

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
            }

            return newTable;
        }//-----------------

        //this function will get in-house hospitalization
        public DataTable GetInHouseHospitalizations(CommonExchange.SysAccess userInfo, String memberSysIdList)
        {
            DataTable newTable = this.InHouseHospitalizationTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _inHouseHospitalizationTable = remClient.SelectBySysIDMemberListInHouseHospitalizationCredit(userInfo, memberSysIdList);
            }

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
            }

            return newTable;
        }//-------------------------

        //this function will initialize loan amortization schedule
        public DataTable InitializeLoanAmortizationScheduleDataGridView(CommonExchange.RegularLoan regularLoanInfo, ToolStripLabel lblTotalPayableInterest)
        {
            DataTable newTable = this.LoanAmortizationTable;

            Decimal totalPayableInterest = 0;

            CommonExchange.RegularLoan regularLoanInfoTemp = (CommonExchange.RegularLoan)regularLoanInfo.Clone();

            foreach (CommonExchange.RegularLoanAmortization list in regularLoanInfoTemp.LoanAmortizationList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["payment_no"] = list.PaymentNo;
                    newRow["payment_date_from"] = !String.IsNullOrEmpty(list.PaymentDateFrom) ?
                        DateTime.Parse(list.PaymentDateFrom).ToShortDateString() : String.Empty;
                    newRow["payment_date_to"] = !String.IsNullOrEmpty(list.PaymentDateTo) ?
                        DateTime.Parse(list.PaymentDateTo).ToShortDateString() : String.Empty;
                    newRow["balance_beginning"] = list.BalanceBeginning.ToString("N");
                    newRow["payment_amount"] = list.PaymentAmount.ToString("N");
                    newRow["interest_paid"] = list.InterestPaid.ToString("N");
                    newRow["principal_paid"] = list.PrincipalPaid.ToString("N");
                    newRow["balance_ending"] = list.BalanceEnding.ToString("N");
                    newRow["amortization_id"] = list.AmortizationId;

                    newTable.Rows.Add(newRow);

                    if (regularLoanInfo.NoPrepaidInterest > 0)
                    {
                        totalPayableInterest += list.InterestPaid;
                    }
                }
            }

            Decimal totalInterestCharge = ((regularLoanInfo.LoanAmount * (Decimal)(regularLoanInfo.InterestRate / 100)) * regularLoanInfo.LoanTerms);

            lblTotalPayableInterest.Text = "Total Amount Receivable by the Association: " +
                 ((regularLoanInfo.LoanAmount + totalInterestCharge) - totalPayableInterest).ToString("N");

            return newTable;
        }//--------------------------

        //this function will initialize regular loan multiple payment data grid view
        public DataTable InitializeRegularLoanMultiplePayment()
        {
            DataTable newTable = this.RegularLoanMultiplePaymentTable;

            if (_memberTable != null)
            {
                foreach (DataRow memRow in _memberTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["sysid_member_hidden"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "sysid_member", String.Empty);
                    newRow["person_name_forzeen"] = "(" + RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_id", String.Empty) + ") " +
                        BaseServices.ProcStatic.GetCompleteNameMiddleInitial(memRow, "last_name", "first_name", "middle_name");
                    newRow["sysid_regular_hidden"] = String.Empty;
                    newRow["account_no"] = String.Empty;
                    newRow["amount_paid"] = String.Empty;
                    newRow["principal_paid"] = String.Empty;
                    newRow["interest_paid"] = String.Empty;
                    newRow["discount_amount"] = String.Empty;
                    newRow["amount_tendered"] = String.Empty;
                    newRow["receipt_no"] = BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");
                    newRow["reflected_date"] = DateTime.Parse(this.ServerDateTime).ToLongDateString();
                    newRow["receipt_date"] = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToLongDateString();
                    newRow["account_code_name_not_frozen"] = String.Empty;
                    newRow["sysid_account_credit"] = String.Empty;
                    newRow["remarks"] = String.Empty;
                    newRow["bank_name"] = String.Empty;
                    newRow["check_no_not_froze"] = String.Empty;

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//-------------------------

        //this function will initialize share capital credit multiple payment data grid view
        public DataTable InitializeShareCapitalCreditInHouseHospitalizationMultiplePayment()
        {
            DataTable newTable = this.ShareCapitalCreditInHouseHospitalizationMultiplePaymentTable;

            if (_memberTable != null)
            {
                foreach (DataRow memRow in _memberTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["person_name_forzeen"] = "(" + RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_id", String.Empty) + ") " +
                        BaseServices.ProcStatic.GetCompleteNameMiddleInitial(memRow, "last_name", "first_name", "middle_name");
                    newRow["sysid_member_hidden"] = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "sysid_member", String.Empty);
                    newRow["amount_paid"] = String.Empty;
                    newRow["discount_amount"] = String.Empty;
                    newRow["amount_tendered"] = String.Empty;
                    newRow["receipt_no"] = BaseServices.BaseServicesLogic.ReceiptNumber.ToString("000000");
                    newRow["reflected_date"] = DateTime.Parse(this.ServerDateTime).ToLongDateString();
                    newRow["receipt_date"] = DateTime.Parse(BaseServices.BaseServicesLogic.ReceiptDate).ToLongDateString();
                    newRow["account_code_name_not_frozen"] = String.Empty;
                    newRow["sysid_account_credit"] = String.Empty;
                    newRow["remarks"] = String.Empty;
                    newRow["bank_name"] = String.Empty;
                    newRow["check_no_not_froze"] = String.Empty;

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//---------------------       

        //this function will get member information details by member id
        public CommonExchange.Member GetDetailsMemberInformationByMemberId(CommonExchange.SysAccess userInfo, String memberId)
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

        //this function will get regular loan information details
        public CommonExchange.RegularLoan GetDetailsRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularSysId)
        {
            CommonExchange.RegularLoan regularLoanInfo = new CommonExchange.RegularLoan();

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                regularLoanInfo = remClient.SelectBySysIDRegularLoanInformation(userInfo, regularSysId);
            }

            return regularLoanInfo;
        }//-----------------------------
      
        //this function will get regular loan payment information details
        public CommonExchange.RegularLoanPayments GetDetailsRegularLoanPaymentsInformation(String paymentId)
        {
            CommonExchange.RegularLoanPayments regularLoanPaymentInfo = new CommonExchange.RegularLoanPayments();

            if (_regularLoanPaymentTable != null)
            {
                String strFilter = "payment_id = " + paymentId;
                DataRow[] selectRow = _regularLoanPaymentTable.Select(strFilter);

                foreach (DataRow paymentRow in selectRow)
                {
                    regularLoanPaymentInfo.PaymentId = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "payment_id", Int64.Parse("0"));
                    regularLoanPaymentInfo.RegularLoanInfo.RegularLoanSysId = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_regular", String.Empty);
                    regularLoanPaymentInfo.ReflectedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "reflected_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    regularLoanPaymentInfo.ReceivedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "received_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    regularLoanPaymentInfo.ReceiptDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    regularLoanPaymentInfo.ReceiptNo = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "receipt_no", String.Empty);
                    regularLoanPaymentInfo.PaymentAmount = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "payment_amount", Decimal.Parse("0"));
                    regularLoanPaymentInfo.PrincipalPaid = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "principal_paid", Decimal.Parse("0"));
                    regularLoanPaymentInfo.InterestPaid = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "interest_paid", Decimal.Parse("0"));
                    regularLoanPaymentInfo.AmountTendered = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "amount_tendered", Decimal.Parse("0"));
                    regularLoanPaymentInfo.RebateAmount = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "rebate_amount", Decimal.Parse("0"));
                    regularLoanPaymentInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "remarks", String.Empty);
                    regularLoanPaymentInfo.Bank = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "bank", String.Empty);
                    regularLoanPaymentInfo.CheckNo = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "check_no", String.Empty);
                    regularLoanPaymentInfo.AccountCreditInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_account_credit", String.Empty);
                    regularLoanPaymentInfo.AccountCreditInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "account_code_credit", String.Empty);
                    regularLoanPaymentInfo.AccountCreditInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "account_name_credit", String.Empty);
                    regularLoanPaymentInfo.AccountRebateInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "sysid_account_rebate", String.Empty);
                    regularLoanPaymentInfo.AccountRebateInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "account_code_rebate", String.Empty);
                    regularLoanPaymentInfo.AccountRebateInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(paymentRow, "account_name_rebate", String.Empty);

                    break;
                }
            }

            return regularLoanPaymentInfo;
        }//----------------------

        //this function will get share capital credit information details
        public CommonExchange.ShareCapitalCredit GetDetailsShareCapitalInformationDetails(String capitalCreditId)
        {
            CommonExchange.ShareCapitalCredit shareCapitalInfo = new CommonExchange.ShareCapitalCredit();

            if (_shareCapitalCreditTable != null)
            {
                String strFilter = "capital_credit_id = " + capitalCreditId;
                DataRow[] selectRow = _shareCapitalCreditTable.Select(strFilter);

                foreach (DataRow shareRow in selectRow)
                {
                    shareCapitalInfo.CapitalCreditId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "capital_credit_id", Int64.Parse("0"));
				    shareCapitalInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_member", String.Empty);
				    shareCapitalInfo.ReflectedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
				    shareCapitalInfo.ReceiptDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    shareCapitalInfo.ReceivedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty)).ToShortDateString() + " 12:00:00 AM"; 
				    shareCapitalInfo.ReceiptNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
				    shareCapitalInfo.CreditAmount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
				    shareCapitalInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);
				    shareCapitalInfo.AmountTendered = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "amount_tendered", Decimal.Parse("0"));
				    shareCapitalInfo.Bank = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
				    shareCapitalInfo.CheckNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
				    shareCapitalInfo.AccountCreditInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_account_credit", String.Empty);
				    shareCapitalInfo.AccountCreditInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_code", String.Empty);
				    shareCapitalInfo.AccountCreditInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_name", String.Empty);
				    shareCapitalInfo.AccountCreditInfo.IsDebitSideIncrease = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_debit_side_increase", false);
				    shareCapitalInfo.AccountCreditInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_active_account", false);
                    
                    break;
                }
            }

            return shareCapitalInfo;
        }//----------------------

        //this function will get member's equity information details
        public CommonExchange.MemberEquityCredit GetDetailsMembersEquityInformationDetails(String equityId)
        {
            CommonExchange.MemberEquityCredit memberEquityInfo = new CommonExchange.MemberEquityCredit();

            if (_membersEquityTable != null)
            {
                String strFilter = "equity_id = " + equityId;
                DataRow[] selectRow = _membersEquityTable.Select(strFilter);

                foreach (DataRow shareRow in selectRow)
                {
                    memberEquityInfo.EquityId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "equity_id", Int64.Parse("0"));
                    memberEquityInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_member", String.Empty);
                    memberEquityInfo.ReflectedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    memberEquityInfo.ReceiptDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    memberEquityInfo.ReceivedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    memberEquityInfo.ReceiptNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
                    memberEquityInfo.CreditAmount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
                    memberEquityInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);
                    memberEquityInfo.AmountTendered = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "amount_tendered", Decimal.Parse("0"));
                    memberEquityInfo.Bank = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
                    memberEquityInfo.CheckNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
                    memberEquityInfo.AccountCreditInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_account_credit", String.Empty);
                    memberEquityInfo.AccountCreditInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_code", String.Empty);
                    memberEquityInfo.AccountCreditInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_name", String.Empty);
                    memberEquityInfo.AccountCreditInfo.IsDebitSideIncrease = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_debit_side_increase", false);
                    memberEquityInfo.AccountCreditInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_active_account", false);

                    break;
                }
            }

            return memberEquityInfo;
        }//----------------------

        //this function will get in-house hospitaliztion information details
        public CommonExchange.InHouseHospitalizationCredit GetDetailsInHouseHospitalizationCredit(String hospitalizationId)
        {
            CommonExchange.InHouseHospitalizationCredit inHouseHospitalizationCreditInfo = new CommonExchange.InHouseHospitalizationCredit();

            if (_inHouseHospitalizationTable != null)
            {
                String strFilter = "hospitalization_credit_id = " + hospitalizationId;
                DataRow[] selectRow = _inHouseHospitalizationTable.Select(strFilter);

                 foreach (DataRow shareRow in selectRow)
                {
                    inHouseHospitalizationCreditInfo.HospitalizationCreditId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "hospitalization_credit_id", Int64.Parse("0"));
                    inHouseHospitalizationCreditInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_member", String.Empty);
                    inHouseHospitalizationCreditInfo.ReflectedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "reflected_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    inHouseHospitalizationCreditInfo.ReceiptDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    inHouseHospitalizationCreditInfo.ReceivedDate = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "received_date", String.Empty)).ToShortDateString() + " 12:00:00 AM";
                    inHouseHospitalizationCreditInfo.ReceiptNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "receipt_no", String.Empty);
                    inHouseHospitalizationCreditInfo.CreditAmount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "credit_amount", Decimal.Parse("0"));
                    inHouseHospitalizationCreditInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "remarks", String.Empty);
                    inHouseHospitalizationCreditInfo.AmountTendered = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "amount_tendered", Decimal.Parse("0"));
                    inHouseHospitalizationCreditInfo.Bank = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "bank", String.Empty);
                    inHouseHospitalizationCreditInfo.CheckNo = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "check_no", String.Empty);
                    inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "sysid_account_credit", String.Empty);
                    inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_code", String.Empty);
                    inHouseHospitalizationCreditInfo.AccountCreditInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "account_name", String.Empty);
                    inHouseHospitalizationCreditInfo.AccountCreditInfo.IsDebitSideIncrease = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_debit_side_increase", false);
                    inHouseHospitalizationCreditInfo.AccountCreditInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataRowConvert(shareRow, "is_active_account", false);
                    
                    break;
                }            
            }

            return inHouseHospitalizationCreditInfo;
        }//------------------------------

        //this function will get member information in miscellaneous income
        public CommonExchange.Member GetDetailsMemberInformationMiscallaneousIncome(String memberId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            if (_memberEmployeeTable != null)
            {
                String strFilter = "member_employee_id = '" + memberId + "'";
                DataRow[] selectRow = _memberEmployeeTable.Select(strFilter);

                foreach (DataRow empRow in selectRow)
                {
                    memberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "sysid_member_employee", String.Empty);
				    memberInfo.MemberId  = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "member_employee_id", String.Empty);
				    memberInfo.PersonInfo.PersonSysId = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "sysid_person", String.Empty);
				    memberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "last_name", String.Empty);
				    memberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "first_name", String.Empty);
				    memberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "middle_name", String.Empty);
				    memberInfo.PersonInfo.PresentAddress =  RemoteServerLib.ProcStatic.DataRowConvert(empRow, "present_address", String.Empty);
				    memberInfo.PersonInfo.PresentPhoneNos = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "present_phone_nos", String.Empty);
				    memberInfo.PersonInfo.HomeAddress = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "home_address", String.Empty);
				    memberInfo.PersonInfo.HomePhoneNos = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "home_phone_nos", String.Empty);
                    memberInfo.PersonInfo.Occupation = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "occupation", String.Empty);

                    break;
                }
            }
          
            return memberInfo;
        }//--------------------------        

        //this function will get the collert/employee information for miscallaneous incom
        public CommonExchange.Collector GetDetailsCollectorInformation(String collectorId)
        {
            CommonExchange.Collector collectorInfo = new CommonExchange.Collector();

            if (_memberEmployeeTable != null)
            {
                String strFilter = "member_employee_id = '" + collectorId + "'";
                DataRow[] selectRow = _memberEmployeeTable.Select(strFilter);

                foreach (DataRow empRow in selectRow)
                {
                    collectorInfo.CollectorSysId = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "sysid_member_employee", String.Empty);
                    collectorInfo.EmployeeId = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "member_employee_id", String.Empty);
                    collectorInfo.PersonInfo.PersonSysId = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "sysid_person", String.Empty);
                    collectorInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "last_name", String.Empty);
                    collectorInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "first_name", String.Empty);
                    collectorInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "middle_name", String.Empty);
                    collectorInfo.PersonInfo.PresentAddress = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "present_address", String.Empty);
                    collectorInfo.PersonInfo.PresentPhoneNos = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "present_phone_nos", String.Empty);
                    collectorInfo.PersonInfo.HomeAddress = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "home_address", String.Empty);
                    collectorInfo.PersonInfo.HomePhoneNos = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "home_phone_nos", String.Empty);
                    collectorInfo.PersonInfo.Occupation = RemoteServerLib.ProcStatic.DataRowConvert(empRow, "occupation", String.Empty);

                    break;
                }
            }

            return collectorInfo;
        }//--------------------------

        //this function will get miscellaneous income information
        public CommonExchange.MiscellaneousIncome GetDetailsMiscellaneousIncomeInformation(String paymentId)
        {
            CommonExchange.MiscellaneousIncome miscellaneouseIncomeInfo = new CommonExchange.MiscellaneousIncome();

            if (_miscellaneouseIncomeTable != null)
            {
                String strFilter = "payment_id = " + paymentId;
                DataRow[] selectRow = _miscellaneouseIncomeTable.Select(strFilter);

                foreach (DataRow miscRow in selectRow)
                {
                    miscellaneouseIncomeInfo.PaymentId = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "payment_id", Int64.Parse("0"));
                    miscellaneouseIncomeInfo.ReceivedFrom = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "received_from", String.Empty);
                    miscellaneouseIncomeInfo.ReflectedDate = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "reflected_date", String.Empty);
                    miscellaneouseIncomeInfo.ReceivedDate = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "received_date", String.Empty);
                    miscellaneouseIncomeInfo.ReceiptDate = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "receipt_date", String.Empty);
                    miscellaneouseIncomeInfo.ReceiptNo = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "receipt_no", String.Empty);
                    miscellaneouseIncomeInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "remarks", String.Empty);
                    miscellaneouseIncomeInfo.MiscellaneousAmount = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "miscellaneous_amount", Decimal.Parse("0"));
                    miscellaneouseIncomeInfo.DiscountAmount = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "discount_amount", Decimal.Parse("0"));
                    miscellaneouseIncomeInfo.AmountTendered = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "amount_tendered", Decimal.Parse("0"));
                    miscellaneouseIncomeInfo.Bank = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "bank", String.Empty);
                    miscellaneouseIncomeInfo.CheckNo = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "check_no", String.Empty);
                    miscellaneouseIncomeInfo.AccountCreditInfo.AccountSysId =
                        RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "sysid_account_credit", String.Empty);
                    miscellaneouseIncomeInfo.AccountCreditInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "account_code", String.Empty);
                    miscellaneouseIncomeInfo.AccountCreditInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "account_name", String.Empty);

                    miscellaneouseIncomeInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "sysid_member", String.Empty);
                    miscellaneouseIncomeInfo.CollectorInfo.CollectorSysId = RemoteServerLib.ProcStatic.DataRowConvert(miscRow, "sysid_collector", String.Empty);
                   
                    break;
                }
            }

            return miscellaneouseIncomeInfo;
        }//----------------------

        //this function will get break down bank deposite information
        public CommonExchange.BreakdownBankDeposit GetDetailsBreakDownBankDepositInformation(String accountSysId)
        {
            CommonExchange.BreakdownBankDeposit breakDownDepositInfo = new CommonExchange.BreakdownBankDeposit();

            if (_breakDownBankDepositDetailsTable != null)
            {
                String strFilter = "sysid_account = '" + accountSysId + "'";
                DataRow[] selectRow = _breakDownBankDepositDetailsTable.Select(strFilter);

                foreach (DataRow depositRow in selectRow)
                {
                    breakDownDepositInfo.AccountInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "sysid_account", String.Empty);
                    breakDownDepositInfo.AccountInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code", String.Empty);
                    breakDownDepositInfo.AccountInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name", String.Empty);
                    breakDownDepositInfo.AccountInfo.SummaryAccount.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "sysid_account_summary", String.Empty);
                    breakDownDepositInfo.AccountInfo.SummaryAccount.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_code_summary", String.Empty);
                    breakDownDepositInfo.AccountInfo.SummaryAccount.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "account_name_summary", String.Empty);
                    breakDownDepositInfo.BreakdownId = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "breakdown_id", Int64.Parse("0"));
                    breakDownDepositInfo.DateStart = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "date_start", String.Empty);
                    breakDownDepositInfo.DateEnd = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "date_end", String.Empty);
                    breakDownDepositInfo.Amount = RemoteServerLib.ProcStatic.DataRowConvert(depositRow, "amount", Decimal.Parse("0"));

                    break;
                }
            }

            return breakDownDepositInfo;
        }//-----------------------

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

        //this function get the student system id list format
        public String GetMemberSystemIdFormat()
        {
            StringBuilder strValue = new StringBuilder();

            if (_memberTable != null)
            {
                foreach (DataRow memRow in _memberTable.Rows)
                {
                    if (!String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(memRow, "sysid_member", "")))
                    {
                        strValue.Append(RemoteServerLib.ProcStatic.DataRowConvert(memRow, "sysid_member", "") + ", ");
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
        }//------------------------------

        //this fucntion get student id for single instance
        public String GetMemberForSingleInstance()
        {
            String value = String.Empty;

            if (_memberTable != null && _memberTable.Rows.Count == 1)
            {
                DataRow studRow = _memberTable.Rows[0];

                value = RemoteServerLib.ProcStatic.DataRowConvert(studRow, "member_id", "");
            }

            return value;
        }//-------------------

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

        //this function will determin if the selected row is a member or a employee
        public Boolean IsMemberInformation(String memberEmployeeId)
        {
            Boolean isMember = true;

            if (_memberEmployeeTable != null)
            {
                String strFilter = "member_employee_id = '" + memberEmployeeId + "'";
                DataRow[] selectRow = _memberEmployeeTable.Select(strFilter);

                foreach (DataRow row in selectRow)
                {
                    isMember = RemoteServerLib.ProcStatic.DataRowConvert(row, "is_member_information", true);

                    break;
                }
            }

            return isMember;
        }//-------------------
        #endregion
    }
}
