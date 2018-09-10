using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace MemberServices
{
    internal class LoanLogic : BaseServices.BaseServicesLogic
    {
        #region Class Data Member Decleration
        private DataSet _loanClassDataSet;
        private DataTable _chartOfAccountsTable;
        private DataTable _regularLoanInformationTable;
        private DataTable _loanDocumentTable;
        private DataTable _collateralInformationTable;
        private DataTable _regularLoanCollateralInformationTable;
        private DataTable _regularLoanCollateralTable;
        private DataTable _memberCoMakerTable;
        private DataTable _coMakerInformationTable;
        private DataTable _coMakerTable;
        private DataTable _regularLoanPaymentTable;

        private Int64 _amortizationId = 0;
        private Int64 _loanDocumentId = 0;
        private Int64 _regularLoanCollateralId = 0;
        private Int64 _coMakerId = 0;
        #endregion

        #region Class Properties Decleration
        public DataTable ChartOfAccountTableFormat
        {
            get
            {
                DataTable chartOfAccountTable = new DataTable("ChartOfAccountTable");
                chartOfAccountTable.Columns.Add("account_code_name", System.Type.GetType("System.String"));
                chartOfAccountTable.Columns.Add("category_description", System.Type.GetType("System.String"));
                chartOfAccountTable.Columns.Add("account_code_name_summary", System.Type.GetType("System.String"));
                chartOfAccountTable.Columns.Add("category_description_summary", System.Type.GetType("System.String"));
                chartOfAccountTable.Columns.Add("sysid_account", System.Type.GetType("System.String"));

                return chartOfAccountTable;
            }
        }

        public DataTable LoanAmortizationTable
        {
            get
            {
                DataTable newTable = new DataTable("AmortizationTable");               
                newTable.Columns.Add("payment_no", System.Type.GetType("System.Int16"));
                newTable.Columns.Add("payment_date_from", System.Type.GetType("System.String"));
                newTable.Columns.Add("payment_date_to", System.Type.GetType("System.String"));
                newTable.Columns.Add("balance_beginning", System.Type.GetType("System.String"));
                newTable.Columns.Add("payment_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("interest_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("principal_paid", System.Type.GetType("System.String"));
                newTable.Columns.Add("balance_ending", System.Type.GetType("System.String"));
                newTable.Columns.Add("amortization_id", System.Type.GetType("System.Int64"));

                return newTable;
            }
        }

        //this Table is Used in the generation of summary in the member information services tab.
        public DataTable RegularLoanInformationTableTable
        {
            get { return _regularLoanInformationTable; }
        }

        public DataTable RegularLoanTable
        {
            get
            {
                DataTable newTable = new DataTable("RegularLoanTable");
                newTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("loan_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("purpose_of_loan", System.Type.GetType("System.String"));
                newTable.Columns.Add("loan_terms", System.Type.GetType("System.String"));
                newTable.Columns.Add("interest_rate", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_first_payment", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_maturity", System.Type.GetType("System.String"));
                newTable.Columns.Add("regular_loan_type_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("repayment_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("sysid_voucher", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_date", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable CollateralInformationTable
        {
            get
            {
                DataTable newTable = new DataTable("CollateralInformationTable");
                newTable.Columns.Add("sysid_collateral", System.Type.GetType("System.String"));
                newTable.Columns.Add("property_type", System.Type.GetType("System.String"));
                newTable.Columns.Add("property_brand", System.Type.GetType("System.String"));
                newTable.Columns.Add("serial_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("purchase_price", System.Type.GetType("System.String"));
                newTable.Columns.Add("year_purchased", System.Type.GetType("System.String"));
                newTable.Columns.Add("estimated_appraised_value", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable MemberInformationTable
        {
            get
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

                return newTable;
            }
        }

        public DataTable CoMakerInformationTable
        {
            get
            {
                DataTable newTable = new DataTable("CoMakerInformationTable");
                newTable.Columns.Add("comaker_id", System.Type.GetType("System.String"));                
                newTable.Columns.Add("comaker_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("remarks", System.Type.GetType("System.String"));

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

        private Int64 _loanChargesCountIdCount = 0;
        public Int64 LoanChargesIdCount
        {
            get { return _loanChargesCountIdCount; }
            set { _loanChargesCountIdCount = value; }
        }

        private Int64 _loanAdditionsCountId = 0;
        public Int64 LoanAdditionsCountId
        {
            get { return _loanAdditionsCountId; }
            set { _loanAdditionsCountId = value; }
        }
        #endregion

        #region Class Constructors
        public LoanLogic(CommonExchange.SysAccess userInfo)
            : base(userInfo)
        {
            this.InitializeLoanClass(userInfo);
        }
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will print loan statement of account
        public void PrintLoanStatementOfAccount(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo, DataTable amortizationTable)
        {
            DataTable printStatementTable = new DataTable("PrintStatementTable");
            printStatementTable.Columns.Add("date", System.Type.GetType("System.String"));
            printStatementTable.Columns.Add("description", System.Type.GetType("System.String"));
            printStatementTable.Columns.Add("debit", System.Type.GetType("System.Decimal"));
            printStatementTable.Columns.Add("credit", System.Type.GetType("System.Decimal"));
            printStatementTable.Columns.Add("balance", System.Type.GetType("System.Decimal"));

            DataTable computationVoucherTable = new DataTable("ComputationVoucherTable");
            computationVoucherTable.Columns.Add("description", System.Type.GetType("System.String"));
            computationVoucherTable.Columns.Add("amount", System.Type.GetType("System.String"));
            computationVoucherTable.Columns.Add("balance", System.Type.GetType("System.String"));

            Decimal totalPayment = 0;
            Decimal numberOfPayment = 1;

            if (amortizationTable != null)
            {
                foreach (DataRow amRow in amortizationTable.Rows)
                {
                    String strFilter = "reflected_date >= #" + DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_date_from", String.Empty)).ToShortDateString() +
                        "# AND reflected_date <= #" + DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_date_to", String.Empty)).ToShortDateString() + "#";
                    DataRow[] selectRow = _regularLoanPaymentTable.Select(strFilter, "reflected_date DESC");

                    DataRow payableRow = printStatementTable.NewRow();

                    payableRow["date"] = numberOfPayment.ToString() + ". " +
                        DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_date_to", String.Empty)).ToLongDateString();
                    payableRow["description"] = "Payable";
                    payableRow["debit"] = 0;
                    payableRow["credit"] = RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_amount", Decimal.Parse("0"));
                    payableRow["balance"] = RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_amount", Decimal.Parse("0"));

                    printStatementTable.Rows.Add(payableRow);

                    numberOfPayment++;

                    Decimal totalPaymentForThePeriod = 0;

                    foreach (DataRow tRow in selectRow)
                    {
                        totalPaymentForThePeriod += RemoteServerLib.ProcStatic.DataRowConvert(tRow, "payment_amount", Decimal.Parse("0"));

                        DataRow newRow = printStatementTable.NewRow();

                        newRow["date"] = "          " + DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(tRow, "reflected_date", String.Empty)).ToLongDateString();
                        newRow["description"] = "          Paid";
                        newRow["debit"] = RemoteServerLib.ProcStatic.DataRowConvert(tRow, "payment_amount", Decimal.Parse("0"));
                        newRow["credit"] = 0;

                        Decimal balance = (RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_amount", Decimal.Parse("0")) - totalPaymentForThePeriod) < 0 ?
                            0 : RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_amount", Decimal.Parse("0")) - totalPaymentForThePeriod;

                        newRow["balance"] = balance;

                        printStatementTable.Rows.Add(newRow);

                        totalPayment += RemoteServerLib.ProcStatic.DataRowConvert(tRow, "payment_amount", Decimal.Parse("0"));
                    }
                }
            }

            //create computation voucher table
            DataRow amountGrantedRow = computationVoucherTable.NewRow();

            amountGrantedRow["description"] = "Gross Amount Due";
            amountGrantedRow["amount"] = String.Empty;
            amountGrantedRow["balance"] = regularLoanInfo.LoanAmount.ToString("N");

            computationVoucherTable.Rows.Add(amountGrantedRow);

            DataRow addVRow = computationVoucherTable.NewRow();

            addVRow["description"] = "Add:";
            addVRow["amount"] = String.Empty;
            addVRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(addVRow);

            Decimal totalInterestCharge = ((regularLoanInfo.LoanAmount * (Decimal)(regularLoanInfo.InterestRate / 100)) * regularLoanInfo.LoanTerms);

            DataRow additionVRow = computationVoucherTable.NewRow();

            additionVRow["description"] = "      Interest Charges";
            additionVRow["amount"] = totalInterestCharge.ToString("N");
            additionVRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(additionVRow);

            DataRow subAddRow = computationVoucherTable.NewRow();

            subAddRow["description"] = "            Sub Total";
            subAddRow["amount"] = String.Empty;
            subAddRow["balance"] = (regularLoanInfo.LoanAmount + totalInterestCharge).ToString("N");

            computationVoucherTable.Rows.Add(subAddRow);

            DataRow lessVoucherRow = computationVoucherTable.NewRow();

            lessVoucherRow["description"] = "Less:";
            lessVoucherRow["amount"] = String.Empty;
            lessVoucherRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(lessVoucherRow);

            Decimal prepaidInterest = ((regularLoanInfo.LoanAmount * (Decimal)(regularLoanInfo.InterestRate / 100)) *
                (regularLoanInfo.LoanTerms - regularLoanInfo.NoPrepaidInterest));

            DataRow lessVRow = computationVoucherTable.NewRow();

            lessVRow["description"] = "      Prepaid Interest";
            lessVRow["amount"] = (totalInterestCharge == prepaidInterest) ? "0" : "(" + prepaidInterest.ToString("N") + ")";
            lessVRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(lessVRow);

            DataRow lessTotalPaymentRow = computationVoucherTable.NewRow();

            lessTotalPaymentRow["description"] = "      Total Payment";
            lessTotalPaymentRow["amount"] = "(" + totalPayment.ToString("N") + ")";
            lessTotalPaymentRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(lessTotalPaymentRow);

            DataRow netLineVRow = computationVoucherTable.NewRow();

            DataRow subLessRow = computationVoucherTable.NewRow();

            subLessRow["description"] = "            Sub Total";
            subLessRow["amount"] = String.Empty;
            //subLessRow["balance"] = (totalInterestCharge == prepaidInterest) ? "0" : "(" + prepaidInterest.ToString("N") + ")";
            subLessRow["balance"] = "(" + (totalPayment + prepaidInterest).ToString("N") + ")";

            computationVoucherTable.Rows.Add(subLessRow);

            netLineVRow["description"] = String.Empty;
            netLineVRow["amount"] = String.Empty;
            netLineVRow["balance"] = "------------------------------";

            computationVoucherTable.Rows.Add(netLineVRow);

            if (totalInterestCharge == prepaidInterest)
            {
                prepaidInterest = 0;
            }

            DataRow totalAmountReceivable = computationVoucherTable.NewRow();

            totalAmountReceivable["description"] = "Balance";
            totalAmountReceivable["amount"] = String.Empty;
            totalAmountReceivable["balance"] = ((regularLoanInfo.LoanAmount + totalInterestCharge) - (prepaidInterest + totalPayment)).ToString("N");

            computationVoucherTable.Rows.Add(totalAmountReceivable);
            //-------------------- end computation voucher

            using (ClassMemberServices.CrystalReport.CrystalStatementOfAccount rptStatementOfAccount = new
                     MemberServices.ClassMemberServices.CrystalReport.CrystalStatementOfAccount())
            {
                rptStatementOfAccount.Database.Tables["statement_of_account_table"].SetDataSource(printStatementTable);
                rptStatementOfAccount.Database.Tables["computation_voucher"].SetDataSource(computationVoucherTable);

                rptStatementOfAccount.SetParameterValue("@company_name", CommonExchange.CompanyInformation.CompanyName);
                rptStatementOfAccount.SetParameterValue("@company_address", CommonExchange.CompanyInformation.Address);
                rptStatementOfAccount.SetParameterValue("@company_phone_nos", CommonExchange.CompanyInformation.PhoneNos);
                rptStatementOfAccount.SetParameterValue("@report_name", "Statement of Account");
                rptStatementOfAccount.SetParameterValue("@loan_type", regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeDescription);
                rptStatementOfAccount.SetParameterValue("@as_of_date", DateTime.Parse(this.ServerDateTime).ToLongDateString());
                rptStatementOfAccount.SetParameterValue("@client_name",
                    BaseServices.ProcStatic.GetCompleteNameMiddleInitial(regularLoanInfo.MemberInfo.PersonInfo.LastName,
                    regularLoanInfo.MemberInfo.PersonInfo.FirstName, regularLoanInfo.MemberInfo.PersonInfo.MiddleName));
                rptStatementOfAccount.SetParameterValue("@first_payment_date", DateTime.Parse(regularLoanInfo.DateFirstPayment).ToLongDateString());
                rptStatementOfAccount.SetParameterValue("@maturity_date", DateTime.Parse(regularLoanInfo.DateMaturity).ToLongDateString());
                rptStatementOfAccount.SetParameterValue("@principal_amount", regularLoanInfo.LoanAmount.ToString("N"));
                rptStatementOfAccount.SetParameterValue("@user_info", "Date/Time Printed: " + DateTime.Parse(this.ServerDateTime).ToShortDateString() + " " +
                    DateTime.Parse(this.ServerDateTime).ToShortTimeString() + "         Printed by: " +
                    BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName,
                    userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));

                using (BaseServices.CrystalReportViewer frmViewr = new BaseServices.CrystalReportViewer(rptStatementOfAccount))
                {
                    frmViewr.Text = "   Statement of Account";
                    frmViewr.ShowDialog();
                }
            }
        }//----------------------

        //this procedure will print loan charges and amortization
        public void PrintLoanChargesAmortization(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo, DataTable amourtizationTable,
            Boolean isLoanCalculator, RegularLoanInformation frmRegularLoan, LoanCalculator frmLoanCaluclator)
        {
            DataTable printAmortizationTable = new DataTable("PrintAmortizationTable");
            printAmortizationTable.Columns.Add("payment_no", System.Type.GetType("System.Int16"));
            printAmortizationTable.Columns.Add("payment_date_to", System.Type.GetType("System.String"));
            printAmortizationTable.Columns.Add("balance_beginning", System.Type.GetType("System.Decimal"));
            printAmortizationTable.Columns.Add("payment_amount", System.Type.GetType("System.Decimal"));
            printAmortizationTable.Columns.Add("interest_paid", System.Type.GetType("System.Decimal"));
            printAmortizationTable.Columns.Add("principal_paid", System.Type.GetType("System.Decimal"));
            printAmortizationTable.Columns.Add("balance_ending", System.Type.GetType("System.Decimal"));

            DataTable chargesAdditionsTable = new DataTable("ChargesAdditionsTable");
            chargesAdditionsTable.Columns.Add("description", System.Type.GetType("System.String"));
            chargesAdditionsTable.Columns.Add("amount", System.Type.GetType("System.String"));
            chargesAdditionsTable.Columns.Add("balance", System.Type.GetType("System.String"));

            DataTable computationVoucherTable = new DataTable("ComputationVoucherTable");
            computationVoucherTable.Columns.Add("description", System.Type.GetType("System.String"));
            computationVoucherTable.Columns.Add("amount", System.Type.GetType("System.String"));
            computationVoucherTable.Columns.Add("balance", System.Type.GetType("System.String"));

            //create loan amourtization table
            if (amourtizationTable != null)
            {
                foreach (DataRow amRow in amourtizationTable.Rows)
                {
                    DataRow newRow = printAmortizationTable.NewRow();

                    newRow["payment_no"] = RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_no", Int64.Parse("0"));
                    newRow["payment_date_to"] = RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_date_to", String.Empty);
                    newRow["balance_beginning"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "balance_beginning", String.Empty).ToString());
                    newRow["payment_amount"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "payment_amount", String.Empty).ToString());
                    newRow["interest_paid"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "interest_paid", String.Empty).ToString());
                    newRow["principal_paid"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "principal_paid", String.Empty).ToString());
                    newRow["balance_ending"] = Decimal.Parse(RemoteServerLib.ProcStatic.DataRowConvert(amRow, "balance_ending", String.Empty).ToString());

                    printAmortizationTable.Rows.Add(newRow);
                }
            }//------------------- end amortization table


            //create charges/additionsTable
            DataRow grossAmountDueRow = chargesAdditionsTable.NewRow();

            grossAmountDueRow["description"] = "Gross Amount Due";
            grossAmountDueRow["amount"] = String.Empty;
            grossAmountDueRow["balance"] = regularLoanInfo.LoanAmount.ToString("N");

            chargesAdditionsTable.Rows.Add(grossAmountDueRow);

            Decimal totalCharges = 0;
            Decimal totalAdditions = 0;           

            if (regularLoanInfo.LoanAdditionsList.Count > 0)
            {
                DataRow addRow = chargesAdditionsTable.NewRow();

                addRow["description"] = "Add:";
                addRow["amount"] = String.Empty;
                addRow["balance"] = String.Empty;

                chargesAdditionsTable.Rows.Add(addRow);

                foreach (CommonExchange.RegularLoanAdditions list in regularLoanInfo.LoanAdditionsList)
                {
                    DataRow additionRow = chargesAdditionsTable.NewRow();

                    additionRow["description"] = "    " + list.AdditionDescription;
                    additionRow["amount"] = list.AdditionAmount.ToString("N");
                    additionRow["balance"] = String.Empty;

                    chargesAdditionsTable.Rows.Add(additionRow);

                    totalAdditions += list.AdditionAmount;
                }

                DataRow subTAdditionRow = chargesAdditionsTable.NewRow();

                subTAdditionRow["description"] = "            Sub Total";
                subTAdditionRow["amount"] = String.Empty;
                subTAdditionRow["balance"] = totalAdditions.ToString("N");

                chargesAdditionsTable.Rows.Add(subTAdditionRow);
            }

            if (regularLoanInfo.LoanChargesList.Count > 0)
            {
                DataRow lessRow = chargesAdditionsTable.NewRow();

                lessRow["description"] = "Less:";
                lessRow["amount"] = String.Empty;
                lessRow["balance"] = String.Empty;

                chargesAdditionsTable.Rows.Add(lessRow);


                foreach (CommonExchange.RegularLoanCharges list in regularLoanInfo.LoanChargesList)
                {
                    DataRow chargeRow = chargesAdditionsTable.NewRow();

                    chargeRow["description"] = "    " + list.ChargeDescription;
                    chargeRow["amount"] = "(" + list.ChargeAmount.ToString("N") + ")";
                    chargeRow["balance"] = String.Empty;

                    chargesAdditionsTable.Rows.Add(chargeRow);

                    totalCharges += list.ChargeAmount;
                }

                DataRow subTChargeRow = chargesAdditionsTable.NewRow();

                subTChargeRow["description"] = "            Sub Total";
                subTChargeRow["amount"] = String.Empty;
                subTChargeRow["balance"] = "(" + totalCharges.ToString("N") + ")";

                chargesAdditionsTable.Rows.Add(subTChargeRow);
            }

            DataRow netLineRow = chargesAdditionsTable.NewRow();

            netLineRow["description"] = String.Empty;
            netLineRow["amount"] = String.Empty;
            netLineRow["balance"] = "------------------------------";

            chargesAdditionsTable.Rows.Add(netLineRow);

            DataRow netRow = chargesAdditionsTable.NewRow();

            netRow["description"] = !isLoanCalculator ? "Net Amount Due" : "Net Amount Due to Borrower";
            netRow["amount"] = String.Empty;
            netRow["balance"] = ((regularLoanInfo.LoanAmount - totalCharges) + totalAdditions).ToString("N");

            chargesAdditionsTable.Rows.Add(netRow);
            //------------------------ end loan charges/additions table

            //create computation voucher table
            DataRow amountGrantedRow = computationVoucherTable.NewRow();

            amountGrantedRow["description"] = "Gross Amount Due";
            amountGrantedRow["amount"] = String.Empty;
            amountGrantedRow["balance"] = regularLoanInfo.LoanAmount.ToString("N");

            computationVoucherTable.Rows.Add(amountGrantedRow);

            DataRow addVRow = computationVoucherTable.NewRow();

            addVRow["description"] = "Add:";
            addVRow["amount"] = String.Empty;
            addVRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(addVRow);

            Decimal totalInterestCharge = ((regularLoanInfo.LoanAmount * (Decimal)(regularLoanInfo.InterestRate / 100)) * regularLoanInfo.LoanTerms);

            DataRow additionVRow = computationVoucherTable.NewRow();

            additionVRow["description"] = "      Interest Charges";
            additionVRow["amount"] = totalInterestCharge.ToString("N");
            additionVRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(additionVRow);

            DataRow subAddRow = computationVoucherTable.NewRow();

            subAddRow["description"] = "            Sub Total";
            subAddRow["amount"] = String.Empty;
            subAddRow["balance"] = (regularLoanInfo.LoanAmount + totalInterestCharge).ToString("N");

            computationVoucherTable.Rows.Add(subAddRow);

            DataRow lessVoucherRow = computationVoucherTable.NewRow();

            lessVoucherRow["description"] = "Less:";
            lessVoucherRow["amount"] = String.Empty;
            lessVoucherRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(lessVoucherRow);

            Decimal prepaidInterest = ((regularLoanInfo.LoanAmount * (Decimal)(regularLoanInfo.InterestRate / 100)) * 
                (regularLoanInfo.LoanTerms - regularLoanInfo.NoPrepaidInterest));

            DataRow lessVRow = computationVoucherTable.NewRow();

            lessVRow["description"] = "      Prepaid Interest";
            lessVRow["amount"] = (totalInterestCharge == prepaidInterest) ? "0" : "("  + prepaidInterest.ToString("N") + ")";
            lessVRow["balance"] = String.Empty;

            computationVoucherTable.Rows.Add(lessVRow);

            DataRow netLineVRow = computationVoucherTable.NewRow();

            DataRow subLessRow = computationVoucherTable.NewRow();

            subLessRow["description"] = "            Sub Total";
            subLessRow["amount"] = String.Empty;
            subLessRow["balance"] = (totalInterestCharge == prepaidInterest) ? "0" : "(" + prepaidInterest.ToString("N") + ")";

            computationVoucherTable.Rows.Add(subLessRow);

            netLineVRow["description"] = String.Empty;
            netLineVRow["amount"] = String.Empty;
            netLineVRow["balance"] = "------------------------------";

            computationVoucherTable.Rows.Add(netLineVRow);

            if (totalInterestCharge == prepaidInterest)
            {
                prepaidInterest = 0;
            }

            DataRow totalAmountReceivable = computationVoucherTable.NewRow();

            totalAmountReceivable["description"] = "Total Amount Receivable by the Association";
            totalAmountReceivable["amount"] = String.Empty;
            totalAmountReceivable["balance"] = ((regularLoanInfo.LoanAmount + totalInterestCharge) - prepaidInterest).ToString("N");

            computationVoucherTable.Rows.Add(totalAmountReceivable);
            //-------------------- end computation voucher

            if (!isLoanCalculator)
            {
                using (ClassMemberServices.CrystalReport.CrystalRegularLoanChargesAmortization rptRegularLoanChargeAmortization = new
                    MemberServices.ClassMemberServices.CrystalReport.CrystalRegularLoanChargesAmortization())
                {
                    rptRegularLoanChargeAmortization.Database.Tables["amortization_table"].SetDataSource(printAmortizationTable);
                    rptRegularLoanChargeAmortization.Database.Tables["charges_additions_table"].SetDataSource(chargesAdditionsTable);
                    rptRegularLoanChargeAmortization.Database.Tables["computation_voucher"].SetDataSource(computationVoucherTable);

                    rptRegularLoanChargeAmortization.SetParameterValue("@company_name", CommonExchange.CompanyInformation.CompanyName);
                    rptRegularLoanChargeAmortization.SetParameterValue("@company_address", CommonExchange.CompanyInformation.Address);
                    rptRegularLoanChargeAmortization.SetParameterValue("@company_phone_nos", CommonExchange.CompanyInformation.PhoneNos);
                    rptRegularLoanChargeAmortization.SetParameterValue("@report_name", "Amortization Schedule");
                    rptRegularLoanChargeAmortization.SetParameterValue("@date_applied", DateTime.Parse(regularLoanInfo.DateApplied).ToLongDateString());
                    rptRegularLoanChargeAmortization.SetParameterValue("@date_approved", DateTime.Parse(regularLoanInfo.DateApproved).ToLongDateString());
                    rptRegularLoanChargeAmortization.SetParameterValue("@loan_type", regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeDescription);
                    rptRegularLoanChargeAmortization.SetParameterValue("@client_name",
                        BaseServices.ProcStatic.GetCompleteNameMiddleInitial(regularLoanInfo.MemberInfo.PersonInfo.LastName,
                        regularLoanInfo.MemberInfo.PersonInfo.FirstName, regularLoanInfo.MemberInfo.PersonInfo.MiddleName));
                    rptRegularLoanChargeAmortization.SetParameterValue("@office", regularLoanInfo.MemberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerName +
                        "  [" + regularLoanInfo.MemberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerAcronym + "]");
                    rptRegularLoanChargeAmortization.SetParameterValue("@user_name",
                        BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName, userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));

                    using (BaseServices.CrystalReportViewer frmViewr = new BaseServices.CrystalReportViewer(rptRegularLoanChargeAmortization))
                    {
                        frmViewr.Text = "   Loan Amortization";
                        frmViewr.ShowDialog(frmRegularLoan);
                    }
                }
            }
            else
            {
                using (ClassMemberServices.CrystalReport.CrystalLoanCalculator rptLoanCalculator = new
                   MemberServices.ClassMemberServices.CrystalReport.CrystalLoanCalculator())
                {
                    rptLoanCalculator.Database.Tables["amortization_table"].SetDataSource(printAmortizationTable);
                    rptLoanCalculator.Database.Tables["charges_additions_table"].SetDataSource(chargesAdditionsTable);
                    rptLoanCalculator.Database.Tables["computation_voucher"].SetDataSource(computationVoucherTable);

                    rptLoanCalculator.SetParameterValue("@company_name", CommonExchange.CompanyInformation.CompanyName);
                    rptLoanCalculator.SetParameterValue("@company_address", CommonExchange.CompanyInformation.Address);
                    rptLoanCalculator.SetParameterValue("@company_phone_nos", CommonExchange.CompanyInformation.PhoneNos);
                    rptLoanCalculator.SetParameterValue("@report_name", "Computation Voucher");
                    rptLoanCalculator.SetParameterValue("@loan_type", regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeDescription);
                    rptLoanCalculator.SetParameterValue("@client_name",
                        BaseServices.ProcStatic.GetCompleteNameMiddleInitial(regularLoanInfo.MemberInfo.PersonInfo.LastName,
                        regularLoanInfo.MemberInfo.PersonInfo.FirstName, regularLoanInfo.MemberInfo.PersonInfo.MiddleName));
                    rptLoanCalculator.SetParameterValue("@office", regularLoanInfo.MemberInfo.PersonInfo.OfficeEmployerInfo.OfficeEmployerAcronym);
                    rptLoanCalculator.SetParameterValue("@user_name",
                        BaseServices.ProcStatic.GetCompleteNameMiddleInitial(userInfo.PersonInfo.LastName, userInfo.PersonInfo.FirstName, userInfo.PersonInfo.MiddleName));

                    using (BaseServices.CrystalReportViewer frmViewr = new BaseServices.CrystalReportViewer(rptLoanCalculator))
                    {
                        frmViewr.Text = "   Loan Calculator ";
                        frmViewr.ShowDialog(frmLoanCaluclator);
                    }
                }
            }
        }//------------------------

        //this function will determine if the file is for update or create
        private void InsertLoanDocumentToTempTable(ref DataTable newTable, String originalName, String fileFullName)
        {
            if (_loanDocumentTable != null)
            {
                String strFilter = "original_name = '" + originalName + "'";
                DataRow[] selectRow = _loanDocumentTable.Select(strFilter);

                foreach (DataRow docRow in selectRow)
                {
                    if (RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0")) > 0)
                    {

                        DataRow newRow = newTable.NewRow();

                        newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                        newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_regular", String.Empty);
                        newRow["file_data"] = BaseServices.ProcStatic.GetFileArrayBytes(fileFullName);
                        newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                        newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);

                        newTable.Rows.Add(newRow);


                        newRow.AcceptChanges();
                        newRow.SetModified();
                    }

                    break;
                }
            }
        }//--------------------

        //this procedure will insert regular loan information
        public void InsertUpdateRegularLoanInformation(CommonExchange.SysAccess userInfo,ref CommonExchange.RegularLoan regularLoanInfo)
        {
            Boolean isForCreate = false;

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {   
                if (String.IsNullOrEmpty(regularLoanInfo.RegularLoanSysId))
                {
                    remClient.InsertRegularLoanInformation(userInfo, ref regularLoanInfo);

                    isForCreate = true;
                }
                else
                {
                    remClient.UpdateRegularLoanInformation(userInfo, regularLoanInfo);
                }


                if (_loanDocumentTable != null)
                {
                    if (isForCreate)
                    {
                        Int32 indexDoc = 0;

                        foreach (DataRow docRow in _loanDocumentTable.Rows)
                        {
                            if (docRow.RowState != DataRowState.Deleted)
                            {
                                DataRow editRow = _loanDocumentTable.Rows[indexDoc];

                                editRow.BeginEdit();

                                editRow["sysid_regular"] = regularLoanInfo.RegularLoanSysId;

                                editRow.EndEdit();

                                editRow.AcceptChanges();
                                editRow.SetAdded();
                            }

                            indexDoc++;
                        }
                    }

                     remClient.InsertUpdateDeleteRegularLoanDocument(userInfo, _loanDocumentTable);

                     _loanDocumentTable.AcceptChanges();
                }

                if (_regularLoanCollateralTable != null)
                {
                    if (isForCreate)
                    {
                        Int32 indexCol = 0;

                        foreach (DataRow docRow in _regularLoanCollateralTable.Rows)
                        {
                            if (docRow.RowState != DataRowState.Deleted)
                            {
                                DataRow editRow = _regularLoanCollateralTable.Rows[indexCol];

                                editRow.BeginEdit();

                                editRow["sysid_regular"] = regularLoanInfo.RegularLoanSysId;

                                editRow.EndEdit();

                                editRow.AcceptChanges();
                                editRow.SetAdded();
                            }

                            indexCol++;
                        }
                    }

                    remClient.InsertDeleteRegularLoanCollateral(userInfo, _regularLoanCollateralTable);

                    _regularLoanCollateralTable.AcceptChanges();
                }
             
                if (_coMakerTable != null)
                {
                    if (isForCreate)
                    {
                        Int32 index = 0;

                        foreach (DataRow cRow in _coMakerTable.Rows)
                        {
                            if (cRow.RowState != DataRowState.Deleted)
                            {
                                DataRow editRow = _coMakerTable.Rows[index];

                                editRow.BeginEdit();

                                editRow["sysid_regular"] = regularLoanInfo.RegularLoanSysId;

                                editRow.EndEdit();

                                editRow.AcceptChanges();
                                editRow.SetAdded();
                            }

                            index++;
                        }
                    }

                    remClient.InsertUpdateDeleteRegularLoanCoMaker(userInfo, _coMakerTable);

                    _coMakerTable.AcceptChanges();
                }
            }

            if (_regularLoanInformationTable != null)
            {
                if (isForCreate)
                {
                    DataRow newRow = _regularLoanInformationTable.NewRow();

                    newRow["sysid_regular"] = regularLoanInfo.RegularLoanSysId;
                    newRow["sysid_member"] = regularLoanInfo.MemberInfo.MemberSysId;
                    newRow["account_no"] = regularLoanInfo.AccountNo;
                    newRow["loan_amount"] = regularLoanInfo.LoanAmount;
                    newRow["purpose_of_loan"] = regularLoanInfo.PurposeOfLoan;
                    newRow["is_productive_string"] = regularLoanInfo.IsProductive.ToString();
                    newRow["loan_terms"] = regularLoanInfo.LoanTerms;
                    newRow["interest_rate"] = regularLoanInfo.InterestRate;
                    newRow["is_straight_string"] = regularLoanInfo.IsStraightLoan.ToString();
                    newRow["date_first_payment"] = regularLoanInfo.DateFirstPayment;
                    newRow["date_maturity"] = regularLoanInfo.DateMaturity;
                    newRow["regular_loan_type_id"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId;
                    newRow["regular_loan_type_description"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeDescription;
                    newRow["regular_loan_type_code"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeCode;
                    newRow["regular_loan_type_no"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeNo;
                    newRow["repayment_id"] = regularLoanInfo.RepaymentScheduleInfo.RepaymentId;
                    newRow["repayment_description"] = regularLoanInfo.RepaymentScheduleInfo.RepaymentDescription;
                    newRow["payments_per_year"] = regularLoanInfo.RepaymentScheduleInfo.PaymentsPerYear;
                    newRow["repayment_no"] = regularLoanInfo.RepaymentScheduleInfo.RepaymentNo;
                    newRow["is_active_loan"] = true;

                    _regularLoanInformationTable.Rows.Add(newRow);
                }
                else
                {
                    Int32 index = 0;

                    foreach (DataRow regLoanRow in _regularLoanInformationTable.Rows)
                    {
                        if (regLoanRow.RowState != DataRowState.Deleted)
                        {
                            if (String.Equals(regularLoanInfo.RegularLoanSysId, RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "sysid_regular", String.Empty)))
                            {
                                DataRow editRow = _regularLoanInformationTable.Rows[index];

                                editRow.BeginEdit();

                                editRow["sysid_regular"] = regularLoanInfo.RegularLoanSysId;
                                editRow["sysid_member"] = regularLoanInfo.MemberInfo.MemberSysId;
                                editRow["account_no"] = regularLoanInfo.AccountNo;
                                editRow["loan_amount"] = regularLoanInfo.LoanAmount;
                                editRow["purpose_of_loan"] = regularLoanInfo.PurposeOfLoan;
                                editRow["is_productive_string"] = regularLoanInfo.IsProductive.ToString();
                                editRow["loan_terms"] = regularLoanInfo.LoanTerms;
                                editRow["interest_rate"] = regularLoanInfo.InterestRate;
                                editRow["is_straight_string"] = regularLoanInfo.IsStraightLoan.ToString();
                                editRow["date_first_payment"] = regularLoanInfo.DateFirstPayment;
                                editRow["date_maturity"] = regularLoanInfo.DateMaturity;
                                editRow["regular_loan_type_id"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId;
                                editRow["regular_loan_type_description"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeDescription;
                                editRow["regular_loan_type_code"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeCode;
                                editRow["regular_loan_type_no"] = regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeNo;
                                editRow["repayment_id"] = regularLoanInfo.RepaymentScheduleInfo.RepaymentId;
                                editRow["repayment_description"] = regularLoanInfo.RepaymentScheduleInfo.RepaymentDescription;
                                editRow["payments_per_year"] = regularLoanInfo.RepaymentScheduleInfo.PaymentsPerYear;
                                editRow["repayment_no"] = regularLoanInfo.RepaymentScheduleInfo.RepaymentNo;

                                editRow.EndEdit();

                                break;
                            }
                        }

                        index++;
                    }
                }
            }           
        }//-------------------------------        

        //this procedure will delete regular loan information
        public void DeleteRegularLoanInfomation(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo)
        {
            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                remClient.DeleteRegularLoanInformation(userInfo, regularLoanInfo);

                if (_loanDocumentTable != null)
                {
                    remClient.InsertUpdateDeleteRegularLoanDocument(userInfo, _loanDocumentTable);
                }

                if (_regularLoanCollateralTable != null)
                {
                    remClient.InsertDeleteRegularLoanCollateral(userInfo, _regularLoanCollateralTable);
                }

                if (_coMakerTable != null)
                {
                    remClient.InsertUpdateDeleteRegularLoanCoMaker(userInfo, _coMakerTable);
                }
            }

            if (_regularLoanInformationTable != null)
            {
                Int32 index = 0;

                foreach (DataRow regLoanRow in _regularLoanInformationTable.Rows)
                {
                    if (regLoanRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(regularLoanInfo.RegularLoanSysId, RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "sysid_regular", String.Empty)))
                        {
                            DataRow delRow = _regularLoanInformationTable.Rows[index];

                            delRow.Delete();

                            break;
                        }
                    }

                    index++;
                }
            }
        }//----------------------------

        //this procedure will insert loan document
        public void InsertLoanDocument(CommonExchange.RegularLoan regularLoanInfo, String original_name, Byte[] fileData)
        {
            if (_loanDocumentTable != null)
            {
                if (!Directory.Exists(regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath)))
                {
                    //creates the directory
                    DirectoryInfo dirInfo = new DirectoryInfo(regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath));
                    dirInfo.Create();
                    dirInfo.Attributes = FileAttributes.Hidden;
                }

                DataRow newRow = _loanDocumentTable.NewRow();

                newRow["document_id"] = _loanDocumentId--;
                newRow["sysid_regular"] = regularLoanInfo.RegularLoanSysId;
                newRow["file_data"] = fileData;
                newRow["original_name"] = original_name;

                _loanDocumentTable.Rows.Add(newRow);
            }
        }//--------------------------

        //this procedure will delete loan document
        public void DeleteLoanDocument(CommonExchange.RegularLoan regularLoanInfo, String originalName, String startUpPath)
        {
            if (_loanDocumentTable != null)
            {
                Int32 index = 0;

                foreach (DataRow docRow in _loanDocumentTable.Rows)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty), originalName))
                        {
                            DataRow delRow = _loanDocumentTable.Rows[index];

                            delRow.Delete();

                            //delete from file
                            if (File.Exists(regularLoanInfo.RegularLoanDocumentsFolder(startUpPath) + originalName))
                            {
                                File.Delete(regularLoanInfo.RegularLoanDocumentsFolder(startUpPath) + originalName);
                            }
                        }
                    }

                    index++;
                }
            }
        }//---------------------------

        //this procedure will insert update loan document information
        public void InsertUpdateLoanDocumentInformationInformation(String original_name, String strDocumentInfo)
        {
            if (_loanDocumentTable != null)
            {
                Int32 index = 0;

                foreach (DataRow docRow in _loanDocumentTable.Rows)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(original_name, RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty)))
                        {
                            DataRow editRow = _loanDocumentTable.Rows[index];

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

        //this procedure will insert update delete loan document information
        public void InsertUpdateDeleteLoanDocumentInformation(CommonExchange.SysAccess userInfo, String dirPath)
        {
            DataTable newTable = new DataTable("LoanDocumentTableTemp");
            newTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            newTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
            newTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            newTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            newTable.Columns.Add("document_information", System.Type.GetType("System.String"));

            DirectoryInfo dir = new DirectoryInfo(dirPath);

            if (File.Exists(dirPath))
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    this.InsertLoanDocumentToTempTable(ref newTable, file.Name, file.FullName);
                }
            }

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                //insert, update and delete loan Document Information
                remClient.InsertUpdateDeleteRegularLoanDocument(userInfo, newTable);
                //-----------------------------
            }
        }//-------------------------        

        //this procedure will insert regular loan collateral information
        public void InsertRegularLoanCollateralInformation(CommonExchange.RegularLoanCollateral regularLoanCollateralInfo)
        {
            if (_regularLoanCollateralTable != null)
            {
                DataRow newRow = _regularLoanCollateralTable.NewRow();

                newRow["loan_collateral_id"] = _regularLoanCollateralId--;
                newRow["sysid_regular"] = regularLoanCollateralInfo.RegularLoanInfo.RegularLoanSysId;
                newRow["sysid_collateral"] = regularLoanCollateralInfo.CollateralInfo.CollateralSysId;

                _regularLoanCollateralTable.Rows.Add(newRow);

                if (_regularLoanCollateralInformationTable != null)
                {
                    DataRow newRowC = _regularLoanCollateralInformationTable.NewRow();

                    newRowC["sysid_collateral"] = regularLoanCollateralInfo.CollateralInfo.CollateralSysId;
                    newRowC["property_type"] = regularLoanCollateralInfo.CollateralInfo.PropertyType;
                    newRowC["property_brand"] = regularLoanCollateralInfo.CollateralInfo.PropertyBrand;
                    newRowC["serial_no"] = regularLoanCollateralInfo.CollateralInfo.SerialNo;
                    newRowC["purchase_price"] = regularLoanCollateralInfo.CollateralInfo.PurchasePrice;
                    newRowC["year_purchased"] = regularLoanCollateralInfo.CollateralInfo.YearPurchased;
                    newRowC["estimated_appraised_value"] = regularLoanCollateralInfo.CollateralInfo.EstimatedAppraisedValue;
                    newRowC["remarks"] = regularLoanCollateralInfo.CollateralInfo.Remarks;
                    newRowC["is_marked_deleted"] = regularLoanCollateralInfo.CollateralInfo.IsMarkedDeleted;
                    newRowC["sysid_member"] = regularLoanCollateralInfo.CollateralInfo.MemberInfo.MemberSysId;
                    newRowC["member_id"] = regularLoanCollateralInfo.CollateralInfo.MemberInfo.MemberId;
                    newRowC["last_name"] = regularLoanCollateralInfo.CollateralInfo.MemberInfo.PersonInfo.LastName;
                    newRowC["first_name"] = regularLoanCollateralInfo.CollateralInfo.MemberInfo.PersonInfo.FirstName;
                    newRowC["middle_name"] = regularLoanCollateralInfo.CollateralInfo.MemberInfo.PersonInfo.MiddleName;

                    _regularLoanCollateralInformationTable.Rows.Add(newRowC);
                }
            }
        }//-----------------------------

        //this procedure will delete regular loan collateral information
        public void DeleteRegularLoanCollateralInformation(String collateralSysId)
        {
            if (_regularLoanCollateralTable != null)
            {
                Int32 index = 0;

                foreach (DataRow colRow in _regularLoanCollateralTable.Rows)
                {
                    if (colRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(collateralSysId, RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty)))
                        {
                            DataRow delRow = _regularLoanCollateralTable.Rows[index];

                            delRow.Delete();

                            break;
                        }
                    }

                    index++;
                }

                if (_regularLoanCollateralInformationTable != null)
                {
                    index = 0;

                    foreach (DataRow colRow in _regularLoanCollateralInformationTable.Rows)
                    {
                        if (colRow.RowState != DataRowState.Deleted)
                        {
                            if (String.Equals(collateralSysId, RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty)))
                            {
                                DataRow delRow = _regularLoanCollateralInformationTable.Rows[index];

                                delRow.Delete();

                                break;
                            }
                        }

                        index++;
                    }
                }
            }
        }//-----------------------------

        //this procedure will insert co-maker information
        public void InsertRegularLoanCoMaker(CommonExchange.RegularLoanCoMaker coMakerInfo)
        {
            if (_coMakerTable != null)
            {
                DataRow newRow = _coMakerTable.NewRow();

                newRow["comaker_id"] = _coMakerId--;
                newRow["sysid_regular"] = coMakerInfo.RegularLoanInfo.RegularLoanSysId;
                newRow["sysid_comaker"] = coMakerInfo.CoMakerMemberInfo.MemberSysId;
                newRow["remarks"] = coMakerInfo.Remarks;

                _coMakerTable.Rows.Add(newRow);

                if (_coMakerInformationTable != null)
                {
                    DataRow newRowC = _coMakerInformationTable.NewRow();

                    newRowC["comaker_id"] = _coMakerId;
                    newRowC["sysid_regular"] = coMakerInfo.RegularLoanInfo.RegularLoanSysId;
                    newRowC["comaker_last_name"] = coMakerInfo.CoMakerMemberInfo.PersonInfo.LastName;
                    newRowC["comaker_first_name"] = coMakerInfo.CoMakerMemberInfo.PersonInfo.FirstName;
                    newRowC["comaker_middle_name"] = coMakerInfo.CoMakerMemberInfo.PersonInfo.MiddleName;
                    newRowC["remarks"] = coMakerInfo.Remarks;

                    _coMakerInformationTable.Rows.Add(newRowC);
                }
            }
        }//--------------------

        //this procedure will updte co-maker information
        public void UpdateRegularLoanCoMaker(CommonExchange.RegularLoanCoMaker coMakerInfo)
        {
            if (_coMakerTable != null)
            {
                Int32 index = 0;

                foreach (DataRow coRow in _coMakerTable.Rows)
                {
                    if (coRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(coMakerInfo.CoMakerId.ToString(), 
                            RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_id", String.Empty).ToString()))
                        {
                            DataRow editRow = _coMakerTable.Rows[index];

                            editRow.BeginEdit();

                            editRow["comaker_id"] = coMakerInfo.CoMakerId;
                            editRow["sysid_regular"] = coMakerInfo.RegularLoanInfo.RegularLoanSysId;
                            editRow["sysid_comaker"] = coMakerInfo.CoMakerMemberInfo.MemberSysId;
                            editRow["remarks"] = coMakerInfo.Remarks;

                            editRow.EndEdit();

                            break;
                        }
                    }

                    index++;
                }
              

                if (_coMakerInformationTable != null)
                {
                    index = 0;

                    foreach (DataRow coRow in _coMakerInformationTable.Rows)
                    {
                        if (coRow.RowState != DataRowState.Deleted)
                        {
                            if (String.Equals(coMakerInfo.CoMakerId.ToString(),
                                RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_id", String.Empty).ToString()))
                            {
                                DataRow editRowC = _coMakerInformationTable.Rows[index];

                                editRowC.BeginEdit();

                                editRowC["comaker_id"] = coMakerInfo.CoMakerId;
                                editRowC["sysid_regular"] = coMakerInfo.RegularLoanInfo.RegularLoanSysId;
                                editRowC["comaker_last_name"] = coMakerInfo.CoMakerMemberInfo.PersonInfo.LastName;
                                editRowC["comaker_first_name"] = coMakerInfo.CoMakerMemberInfo.PersonInfo.FirstName;
                                editRowC["comaker_middle_name"] = coMakerInfo.CoMakerMemberInfo.PersonInfo.MiddleName;
                                editRowC["remarks"] = coMakerInfo.Remarks;

                                editRowC.EndEdit();

                                break;
                            }
                        }

                        index++;
                    }
                }
            }
        }//--------------------

        //this procedure will delete co-maker information
        public void DeleteRegularLoanCoMaker(CommonExchange.RegularLoanCoMaker coMakerInfo)
        {
            if (_coMakerTable != null)
            {
                Int32 index = 0;

                foreach (DataRow coRow in _coMakerTable.Rows)
                {
                    if (coRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(coMakerInfo.CoMakerId.ToString(), 
                            RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_id", String.Empty).ToString()))
                        {
                            DataRow delRow = _coMakerTable.Rows[index];

                            delRow.Delete();

                            break;
                        }
                    }

                    index++;
                }


                if (_coMakerInformationTable != null)
                {
                    index = 0;

                    foreach (DataRow coRow in _coMakerInformationTable.Rows)
                    {
                        if (coRow.RowState != DataRowState.Deleted)
                        {
                            if (String.Equals(coMakerInfo.CoMakerId.ToString(), 
                                RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_id", String.Empty).ToString()))
                            {
                                DataRow delRowC = _coMakerInformationTable.Rows[index];

                                delRowC.Delete();

                                break;
                            }
                        }

                        index++;
                    }
                }
            }
        }//-----------------------        

        //this procedure will initialize member logic class
        public void InitializeLoanClass(CommonExchange.SysAccess userInfo)
        {
            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                _loanClassDataSet = remClient.GetDataSetForLoanManager(userInfo);
            }

            _loanDocumentTable = new DataTable("LoanDocumentTable");
            _loanDocumentTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            _loanDocumentTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
            _loanDocumentTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            _loanDocumentTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            _loanDocumentTable.Columns.Add("document_information", System.Type.GetType("System.String"));

            _regularLoanCollateralTable = new DataTable("RegularLoanCollateralTable");
            _regularLoanCollateralTable.Columns.Add("loan_collateral_id", System.Type.GetType("System.Int64"));
            _regularLoanCollateralTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
            _regularLoanCollateralTable.Columns.Add("sysid_collateral", System.Type.GetType("System.String"));

            _coMakerTable = new DataTable("CoMakerTable");
            _coMakerTable.Columns.Add("comaker_id", System.Type.GetType("System.Int64"));
            _coMakerTable.Columns.Add("sysid_regular", System.Type.GetType("System.String"));
            _coMakerTable.Columns.Add("sysid_comaker", System.Type.GetType("System.String"));
            _coMakerTable.Columns.Add("remarks", System.Type.GetType("System.String"));
        }//------------------------------

        //this procedure will initialize loan type combobox
        public void InitializeLoanTypeCombobox(ComboBox cboBase)
        {
            cboBase.Items.Clear();

            if (_loanClassDataSet.Tables["RegularLoanTypeTable"] != null)
            {
                foreach (DataRow typeRow in _loanClassDataSet.Tables["RegularLoanTypeTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(typeRow, "regular_loan_type_description", String.Empty) + " - [" +
                        RemoteServerLib.ProcStatic.DataRowConvert(typeRow, "regular_loan_type_code", String.Empty) + "]");
                }
            }
        }//----------------------

         //this procedure will initialize loan type combobox
        public void InitializeLoanTypeCombobox(ComboBox cboBase, String loanTypeId)
        {
            cboBase.Items.Clear();

            Int32 index = 0;
            Boolean isIndexed = false;

            if (_loanClassDataSet.Tables["RegularLoanTypeTable"] != null)
            {
                 foreach (DataRow typeRow in _loanClassDataSet.Tables["RegularLoanTypeTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(typeRow, "regular_loan_type_description", String.Empty) + " - [" +
                        RemoteServerLib.ProcStatic.DataRowConvert(typeRow, "regular_loan_type_code", String.Empty) + "]");

                     if (!isIndexed)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(typeRow, "regular_loan_type_id", String.Empty), loanTypeId))
                        {
                            cboBase.SelectedIndex = index;
                            isIndexed = true;
                        }

                        index++;
                    }
                }
            }
        }//----------------------------

        //this procedure will initialize payment interval combobox
        public void InitializePaymentIntervalComboBox(ComboBox cboBase)
        {
            cboBase.Items.Clear();

            if (_loanClassDataSet.Tables["RepaymentScheduleTable"] != null)
            {
                foreach (DataRow payRow in _loanClassDataSet.Tables["RepaymentScheduleTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(payRow, "repayment_description", String.Empty));
                }

                cboBase.SelectedIndex = 3;
            }
        }//---------------------

        //this procedure will initialize payment interval combobox
        public void InitializePaymentIntervalComboBox(ComboBox cboBase, String repaymentId)
        {
            cboBase.Items.Clear();

            Int32 index = 0;
            Boolean isIndexed = false;


            if (_loanClassDataSet.Tables["RepaymentScheduleTable"] != null)
            {
                foreach (DataRow payRow in _loanClassDataSet.Tables["RepaymentScheduleTable"].Rows)
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

        //this procedure will initialize loan charges and loan additions listview
        public void InitializeLoanChargesAdditionsListView(ListView lsvBase, CommonExchange.RegularLoan regularLoanInfo, ToolStripLabel lblBase)
        {
            if (regularLoanInfo.LoanAmount > 0)
            {
                lsvBase.Items.Clear();
            
                //for Details
                ListViewItem lviLoanAmount = new ListViewItem(new String[] { "Loan Amount Granted", regularLoanInfo.LoanAmount.ToString("N"),
                    String.Empty, String.Empty }, lsvBase.Groups[1]);
                lsvBase.Items.Add(lviLoanAmount);

                Decimal netAmount = regularLoanInfo.LoanAmount;

                Boolean hasLoanAdditions = false;

                ListViewItem lviAdd = new ListViewItem(new String[] { "Add:", String.Empty, String.Empty, String.Empty }, lsvBase.Groups[1]);
                lviAdd.ForeColor = Color.Orange;
                lsvBase.Items.Add(lviAdd);

                foreach (CommonExchange.RegularLoanAdditions regLoanAdditions in regularLoanInfo.LoanAdditionsList)
                {
                    if (regLoanAdditions.ObjectState != DataRowState.Deleted)
                    {
                        ListViewItem lviLoanAdditions = new ListViewItem(new String[] {"      " + regLoanAdditions.AdditionDescription,
                            regLoanAdditions.AdditionAmount.ToString("N"), regLoanAdditions.RegularAdditionsId.ToString(), "False"}, lsvBase.Groups[1]);
                        lsvBase.Items.Add(lviLoanAdditions);

                        netAmount += regLoanAdditions.AdditionAmount;

                        hasLoanAdditions = true;
                    }
                }

                if (!hasLoanAdditions)
                {
                    lsvBase.Items.Remove(lviAdd);
                }

                ListViewItem lviNetAmountLoan = new ListViewItem(new String[] { "             Sub Total", 
                    netAmount.ToString("N"), String.Empty, String.Empty }, lsvBase.Groups[1]);
                lviNetAmountLoan.ForeColor = Color.LightCoral;
                lsvBase.Items.Add(lviNetAmountLoan);


                Decimal totalLoanCharge = 0;

                Boolean hasLoanCharges = false;

                ListViewItem lviLess = new ListViewItem(new String[] { "Less:", String.Empty, String.Empty, String.Empty }, lsvBase.Groups[1]);
                lviLess.ForeColor = Color.Orange;
                lsvBase.Items.Add(lviLess);

                foreach (CommonExchange.RegularLoanCharges regLoanCharge in regularLoanInfo.LoanChargesList)
                {
                    if (regLoanCharge.ObjectState != DataRowState.Deleted)
                    {
                        ListViewItem lviLoanCharge = new ListViewItem(new String[] {"      " + regLoanCharge.ChargeDescription,
                            "(" + regLoanCharge.ChargeAmount.ToString("N") + ")", regLoanCharge.RegularChargesId.ToString(), "True"}, lsvBase.Groups[1]);
                            lsvBase.Items.Add(lviLoanCharge);

                        totalLoanCharge += regLoanCharge.ChargeAmount;

                        hasLoanCharges = true;
                    }
                }

                ListViewItem lviGrossAmount = null;

                if (!hasLoanCharges)
                {
                    lsvBase.Items.Remove(lviLess);
                }
                else
                {
                    lviGrossAmount = new ListViewItem(new String[] { "             Sub Total", 
                        (netAmount - totalLoanCharge).ToString("N"), String.Empty, String.Empty }, lsvBase.Groups[1]);
                    lviGrossAmount.ForeColor = Color.LightCoral;
                    lsvBase.Items.Add(lviGrossAmount);
                }
                
                //End Details--------------------

                lblBase.Text = "Net Loan Amount: " + (netAmount - totalLoanCharge).ToString("N");
            }
        }//-----------------------

        //this procedure will determine and then add outstanding balance of the same loan type
        public void InitializePreviousLoanOustandingBalance(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo)
        {
            if (_regularLoanInformationTable != null)
            {
                foreach (DataRow loanRow in _regularLoanInformationTable.Rows)
                {
                    if (String.Equals(regularLoanInfo.RegularLoanTypeInfo.RegularLoanTypeId, RemoteServerLib.ProcStatic.DataRowConvert(loanRow, "regular_loan_type_id", String.Empty)))
                    {
                        Decimal totalAmountReceivalbleByTheAssociation = RemoteServerLib.ProcStatic.DataRowConvert(loanRow, "total_amortization_amount", Decimal.Parse("0"));

                        Decimal totalPayment = RemoteServerLib.ProcStatic.DataRowConvert(loanRow, " total_loan_payments", Decimal.Parse("0"));                       

                        if ((totalAmountReceivalbleByTheAssociation - totalPayment) > 0)
                        {
                            CommonExchange.RegularLoanCharges regularLoanCharge = new CommonExchange.RegularLoanCharges();

                            regularLoanCharge.ChargeDescription = "Outstanding Balance: " + RemoteServerLib.ProcStatic.DataRowConvert(loanRow, "regular_loan_type_description", String.Empty);
                            regularLoanCharge.ChargeAmount = (totalAmountReceivalbleByTheAssociation - totalPayment);
                            regularLoanCharge.ObjectState = DataRowState.Added;

                            regularLoanInfo.LoanChargesList.Add(regularLoanCharge);
                        }
                    }
                }
            }
        }//-----------------------

        //this procedure will initialize loan amortization schedule
        public DataTable InitializeLoanAmortizationScheduleDataGridView(CommonExchange.RegularLoan regularLoanInfo, ToolStripLabel lblTotalPayableInterest,
            Boolean isForCreate, Boolean isForUpdateAmortizationSchedule, Boolean hasApprovedDate, ref Decimal totalLoan)
        {
            DataTable newTable = this.LoanAmortizationTable;

            Decimal totalPayableInterest = 0;

             List<CommonExchange.RegularLoanAmortization> amortizationList = new List<CommonExchange.RegularLoanAmortization>();

             if (isForCreate)
             {
                 regularLoanInfo.LoanAmortizationList.Clear();

                amortizationList = this.GetListLoanAmortizationSchedule(regularLoanInfo, hasApprovedDate);

                foreach (CommonExchange.RegularLoanAmortization newAmortization in amortizationList)
                {
                    regularLoanInfo.LoanAmortizationList.Add(newAmortization);
                }

                foreach (CommonExchange.RegularLoanAmortization list in amortizationList)
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

                        totalPayableInterest += list.InterestPaid;
                    }
                }
             }
             else
             {
                 if (isForUpdateAmortizationSchedule)
                 {
                     foreach (CommonExchange.RegularLoanAmortization list in regularLoanInfo.LoanAmortizationList)
                     {
                         if (list.ObjectState != DataRowState.Deleted)
                         {
                             list.ObjectState = DataRowState.Deleted;
                         }
                     }

                     amortizationList = this.GetListLoanAmortizationSchedule(regularLoanInfo, hasApprovedDate);

                     foreach (CommonExchange.RegularLoanAmortization newAmortization in amortizationList)
                     {
                         regularLoanInfo.LoanAmortizationList.Add(newAmortization);
                     }
                 }

                 foreach (CommonExchange.RegularLoanAmortization list in regularLoanInfo.LoanAmortizationList)
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
             }

            Decimal totalInterestCharge = ((regularLoanInfo.LoanAmount * (Decimal)(regularLoanInfo.InterestRate / 100)) * regularLoanInfo.LoanTerms);
             
            lblTotalPayableInterest.Text = "Total Amount Receivable by the Association: " + 
                 ((regularLoanInfo.LoanAmount + totalInterestCharge) - totalPayableInterest).ToString("N");

            totalLoan = ((regularLoanInfo.LoanAmount + totalInterestCharge) - totalPayableInterest);

            return newTable;
        }//--------------------------

        //this procedure will initialize loan amortization schedule
        public DataTable InitializeLoanAmortizationScheduleDataGridView(CommonExchange.RegularLoan regularLoanInfo, Boolean hasApprovedDate)
        {
            DataTable newTable = this.LoanAmortizationTable;

            Decimal totalPayableInterest = 0;

            CommonExchange.RegularLoan regularLoanInfoTemp = (CommonExchange.RegularLoan)regularLoanInfo.Clone();
            List<CommonExchange.RegularLoanAmortization> amortizationList = new List<CommonExchange.RegularLoanAmortization>();

            amortizationList = this.GetListLoanAmortizationSchedule(regularLoanInfo, hasApprovedDate);

            foreach (CommonExchange.RegularLoanAmortization list in amortizationList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["payment_no"] = list.PaymentNo;
                    newRow["payment_date_from"] = !String.IsNullOrEmpty(list.PaymentDateFrom) ?
                        DateTime.Parse(list.PaymentDateFrom).ToShortDateString() : String.Empty;
                    newRow["payment_date_to"] = !String.IsNullOrEmpty(list.PaymentDateTo) ?
                        DateTime.Parse(list.PaymentDateTo).ToShortDateString() : String.Empty;
                    newRow["balance_beginning"] = list.BalanceBeginning.ToString();
                    newRow["payment_amount"] = list.PaymentAmount.ToString();
                    newRow["interest_paid"] = list.InterestPaid.ToString();
                    newRow["principal_paid"] = list.PrincipalPaid.ToString();
                    newRow["balance_ending"] = list.BalanceEnding.ToString();
                    newRow["amortization_id"] = list.AmortizationId;

                    newTable.Rows.Add(newRow);

                    totalPayableInterest += list.InterestPaid;
                }
            }

            return newTable;
        }//--------------------------

        //this procedure will initialize person document 
        public void InitializeLoanDocument(CommonExchange.SysAccess userInfo, CommonExchange.RegularLoan regularLoanInfo)
        {
            try
            {
                if (!Directory.Exists(regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath)))
                {
                    //creates the directory
                    DirectoryInfo dirInfo = new DirectoryInfo(regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath));
                    dirInfo.Create();
                    dirInfo.Attributes = FileAttributes.Hidden;
                }

                DataTable imageTable;

                using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
                {
                    imageTable = remClient.SelectBySysIDRegularListRegularLoanDocument(userInfo, regularLoanInfo.RegularLoanSysId);
                }

                foreach (DataRow docRow in imageTable.Rows)
                {
                    DataRow newRow = _loanDocumentTable.NewRow();

                    newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                    newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_regular", String.Empty);
                    newRow["file_data"] = docRow["file_data"];
                    newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                    newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);
                    
                    _loanDocumentTable.Rows.Add(newRow);
                }

                _loanDocumentTable.AcceptChanges();

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
                            using (FileStream streame = new FileStream(regularLoanInfo.RegularLoanDocumentsFolder(Application.StartupPath) + imagePath,
                                FileMode.Create, FileAccess.Write))
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
        #endregion

        #region Programmer's Defined Functions
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

        //this function will get loan amortization schedule
        public List<CommonExchange.RegularLoanAmortization> GetListLoanAmortizationSchedule(CommonExchange.RegularLoan regularLoanInfo, Boolean hasApprovedDate)
        {
            Int32 noOfMonth = regularLoanInfo.LoanTerms == regularLoanInfo.NoPrepaidInterest ?
                       regularLoanInfo.LoanTerms : (regularLoanInfo.LoanTerms - regularLoanInfo.NoPrepaidInterest);

            Decimal totalInterestPaid = 0;
            Decimal totalAmortizationAmount = 0;

            Decimal totalInterestLessPrePaidInterest = (regularLoanInfo.LoanAmount * (Decimal)(regularLoanInfo.InterestRate / 100) *
                (regularLoanInfo.LoanTerms - regularLoanInfo.NoPrepaidInterest));
            Decimal beginningBalance = regularLoanInfo.LoanAmount + totalInterestLessPrePaidInterest;
            Decimal intrestAmount = totalInterestLessPrePaidInterest / (noOfMonth);

            Int16 noOfPrepaidInterest = regularLoanInfo.NoPrepaidInterest;

            DateTime dateFrom = DateTime.MinValue;
            DateTime approvedDate = DateTime.MinValue;

            if (hasApprovedDate)
            {
                if ((DateTime.TryParse(regularLoanInfo.DateFirstPayment, out dateFrom) && DateTime.Compare(dateFrom, DateTime.MinValue) != 0) &&
                    (DateTime.TryParse(regularLoanInfo.DateApproved, out approvedDate) && DateTime.Compare(approvedDate, DateTime.MinValue) != 0))
                {
                }
            }
            else
            {
                if ((DateTime.TryParse(regularLoanInfo.DateFirstPayment, out dateFrom) && DateTime.Compare(dateFrom, DateTime.MinValue) != 0) &&
                    (DateTime.TryParse(regularLoanInfo.DateFirstPayment, out approvedDate) && DateTime.Compare(approvedDate, DateTime.MinValue) != 0))
                {
                }
            }

            List<CommonExchange.RegularLoanAmortization> amortizationList = new List<CommonExchange.RegularLoanAmortization>();

            for (Int16 amortizationCount = 1; amortizationCount <= regularLoanInfo.LoanTerms; amortizationCount++)
            {
                CommonExchange.RegularLoanAmortization regularLoanAmortizationInfo = new CommonExchange.RegularLoanAmortization();

                regularLoanAmortizationInfo.AmortizationId = _amortizationId--;
                regularLoanAmortizationInfo.PaymentNo = amortizationCount;

                if (DateTime.Compare(dateFrom, DateTime.MinValue) != 0 && DateTime.Compare(approvedDate, DateTime.MinValue) != 0)
                {
                    //if (amortizationCount == 1)
                    //{
                    //    regularLoanAmortizationInfo.PaymentDateFrom = approvedDate.ToShortDateString() + " 12:00:00 AM";
                    //    regularLoanAmortizationInfo.PaymentDateTo = dateFrom.ToShortDateString() + " 11:59:59 PM";

                    //    dateFrom = dateFrom.AddDays(1);
                    //}
                    //else
                    //{
                        if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.DailyId))
                        {
                            dateFrom = dateFrom.AddDays(1);

                            regularLoanAmortizationInfo.PaymentDateFrom = dateFrom.ToShortDateString() + " 12:00:00 AM";
                            regularLoanAmortizationInfo.PaymentDateTo = dateFrom.AddDays(1).ToShortDateString() + " 11:59:59 PM";
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.WeeklyId))
                        {
                            regularLoanAmortizationInfo.PaymentDateTo = dateFrom.AddDays(6).ToShortDateString() + " 11:59:59 PM";
                            regularLoanAmortizationInfo.PaymentDateFrom = dateFrom.ToShortDateString() + " 12:00:00 AM";
                            dateFrom = dateFrom.AddDays(7);
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.BiWeeklyId))
                        {
                            Int32 noOfDaysOfTheMonth =
                                (this.LastDayOfMonthFromDateTime(dateFrom).Day == 31 || this.LastDayOfMonthFromDateTime(dateFrom).Day == 29) ?
                                this.LastDayOfMonthFromDateTime(dateFrom).Day - 1 : this.LastDayOfMonthFromDateTime(dateFrom).Day;

                            dateFrom.AddDays((noOfDaysOfTheMonth / 2) - 1);

                            regularLoanAmortizationInfo.PaymentDateTo = dateFrom.AddDays(((noOfDaysOfTheMonth / 2) - 1)).ToShortDateString() + " 11:59:59 PM";
                            regularLoanAmortizationInfo.PaymentDateFrom = dateFrom.ToShortDateString() + " 12:00:00 AM";

                            if (DateTime.Parse(regularLoanAmortizationInfo.PaymentDateTo).Day == this.LastDayOfMonthFromDateTime(dateFrom).Day - 1)
                            {
                                dateFrom = dateFrom.AddMonths(1);
                                dateFrom = this.FirstDayOfMonthFromDateTime(dateFrom);
                            }
                            else
                            {
                                dateFrom = dateFrom.AddDays((noOfDaysOfTheMonth / 2));
                            }
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.MonthlyId))
                        {
                            regularLoanAmortizationInfo.PaymentDateTo = this.LastDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 11:59:59 PM";
                            regularLoanAmortizationInfo.PaymentDateFrom = this.FirstDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 12:00:00 AM";

                            dateFrom = dateFrom.AddMonths(1);
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.QuarterlyId))
                        {
                            dateFrom = dateFrom.AddMonths(1);
                            regularLoanAmortizationInfo.PaymentDateFrom = this.FirstDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 12:00:00 AM";

                            dateFrom = dateFrom.AddMonths(2);
                            regularLoanAmortizationInfo.PaymentDateTo = this.LastDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 11:59:59 PM";
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.SemiAnnualId))
                        {
                            dateFrom = dateFrom.AddMonths(1);
                            regularLoanAmortizationInfo.PaymentDateFrom = this.FirstDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 12:00:00 AM";

                            dateFrom = dateFrom.AddMonths(5);
                            regularLoanAmortizationInfo.PaymentDateTo = this.LastDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 11:59:59 PM";
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.Annual))
                        {
                            dateFrom = dateFrom.AddMonths(1);
                            regularLoanAmortizationInfo.PaymentDateFrom = this.FirstDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 12:00:00 AM";

                            dateFrom = dateFrom.AddMonths(11);
                            regularLoanAmortizationInfo.PaymentDateTo = this.LastDayOfMonthFromDateTime(dateFrom).ToShortDateString() + " 11:59:59 PM";
                        }
                    //}

                    regularLoanAmortizationInfo.PaymentDateGracePeriod = 
                       DateTime.Parse(regularLoanAmortizationInfo.PaymentDateTo).AddDays(regularLoanInfo.GracePeriod).ToShortDateString() + " 11:59:59 PM";
                }

                regularLoanAmortizationInfo.InterestRate = regularLoanInfo.InterestRate;

                if (regularLoanInfo.LoanAmount > 0 && regularLoanInfo.LoanTerms > 0)
                {
                    regularLoanAmortizationInfo.BalanceBeginning = beginningBalance;
                    regularLoanAmortizationInfo.PaymentAmount = (regularLoanInfo.LoanAmount / regularLoanInfo.LoanTerms) > beginningBalance ?
                       beginningBalance : (regularLoanInfo.LoanAmount / regularLoanInfo.LoanTerms);             

                    if (noOfPrepaidInterest > 0)
                    {
                        regularLoanAmortizationInfo.InterestPaid = 0;

                        noOfPrepaidInterest--;
                    }
                    else
                    {
                        regularLoanAmortizationInfo.InterestPaid = intrestAmount < regularLoanAmortizationInfo.PaymentAmount ? intrestAmount : 0;
                    }
                    
                    regularLoanAmortizationInfo.PaymentAmount = (regularLoanInfo.LoanAmount / regularLoanInfo.LoanTerms) > beginningBalance ?
                        (beginningBalance + regularLoanAmortizationInfo.InterestPaid) :
                        ((regularLoanInfo.LoanAmount / regularLoanInfo.LoanTerms) + regularLoanAmortizationInfo.InterestPaid);

                    totalInterestPaid += regularLoanAmortizationInfo.InterestPaid;

                    totalAmortizationAmount += Math.Round(regularLoanAmortizationInfo.PaymentAmount, 2);

                    regularLoanAmortizationInfo.PrincipalPaid = regularLoanAmortizationInfo.PaymentAmount - regularLoanAmortizationInfo.InterestPaid;
                    regularLoanAmortizationInfo.BalanceEnding = beginningBalance =
                        regularLoanAmortizationInfo.BalanceBeginning - (regularLoanAmortizationInfo.PaymentAmount);
                    regularLoanAmortizationInfo.PenaltyRate = regularLoanInfo.PenaltyRate;
                    regularLoanAmortizationInfo.IsManuallyComputed = false;
                    regularLoanAmortizationInfo.Remarks = String.Empty;
                    regularLoanAmortizationInfo.ObjectState = DataRowState.Added;
                }

                amortizationList.Add(regularLoanAmortizationInfo);
            }

            if (totalAmortizationAmount < (regularLoanInfo.LoanAmount + totalInterestPaid))
            {
                if (amortizationList.Count > 0)
                {
                    Decimal amountToBeAdded = ((regularLoanInfo.LoanAmount + totalInterestPaid) - totalAmortizationAmount);
                                    
                    amortizationList[0].PaymentAmount += amountToBeAdded;
                    amortizationList[0].PrincipalPaid = (amortizationList[0].PaymentAmount - amortizationList[0].InterestPaid);
                }
            }
            else if (totalAmortizationAmount > (regularLoanInfo.LoanAmount + totalInterestPaid))
            {
                if (amortizationList.Count > 0)
                {
                    Decimal amountToBeDeducted = Decimal.Parse((totalAmortizationAmount - (regularLoanInfo.LoanAmount + totalInterestPaid)).ToString("N"));
                    amortizationList[0].PaymentAmount -= amountToBeDeducted;
                    amortizationList[0].PrincipalPaid = (amortizationList[0].PaymentAmount - amortizationList[0].InterestPaid);
                }
            }

            return amortizationList;
        }//------------------------
              
        
        //this function will get searched regular loan information
        public DataTable GetSearchedRegularLoanInformation(CommonExchange.SysAccess userInfo, String memberSysIdList,
            Boolean isMarkedDeleted, Boolean isNewQuery, Boolean isActiveLoan)
        {
            DataTable newTable = this.RegularLoanTable;

            if (isNewQuery)
            {
                using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
                {                                            
                    _regularLoanInformationTable = remClient.SelectBySysIDMemberListRegularLoanInformation(userInfo, memberSysIdList, isMarkedDeleted);
                }
            }

            if (_regularLoanInformationTable != null)
            {
                String strFilter = "is_active_loan = " + isActiveLoan;
                DataRow[] selectRow = _regularLoanInformationTable.Select(strFilter);

                foreach (DataRow regLoanRow in selectRow)
                {
                    if (regLoanRow.RowState != DataRowState.Deleted)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "sysid_regular", String.Empty);
                        newRow["account_no"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "account_no", String.Empty);
                        newRow["loan_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "loan_amount", Decimal.Parse("0")).ToString("N");
                        newRow["purpose_of_loan"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "purpose_of_loan", String.Empty).ToString();
                        newRow["loan_terms"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "loan_terms", Single.Parse("0")).ToString();
                        newRow["interest_rate"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "interest_rate", Int16.Parse("0")).ToString() + "%";
                        newRow["date_first_payment"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "date_first_payment", String.Empty)).ToLongDateString();
                        newRow["date_maturity"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "date_maturity", String.Empty)).ToLongDateString();
                        newRow["regular_loan_type_description"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "regular_loan_type_description", String.Empty);
                        newRow["repayment_description"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "repayment_description", String.Empty);
                        newRow["sysid_voucher"] = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "sysid_voucher", String.Empty);

                        String checkNo = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "is_record_locked", false) ?
                            RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "check_no", String.Empty) : String.Empty;

                        String checkDate = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "is_record_locked", false) ?
                            DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "check_date", String.Empty)).ToLongDateString() : String.Empty;

                        newRow["check_no"] = checkNo;
                        newRow["check_date"] = checkDate;

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//--------------------------

        //this function will get searched chart of accounts
        public DataTable GetSearchedChartOfAccount(CommonExchange.SysAccess userInfo, String queryString,
            String summaryAccount, String accountingCategoryIdList, Boolean isActiveAccount)
        {
            DataTable newTable = new DataTable("ChartOfAccountTable");
            newTable.Columns.Add("account_code_name", System.Type.GetType("System.String"));
            newTable.Columns.Add("category_description", System.Type.GetType("System.String"));
            newTable.Columns.Add("account_code_name_summary", System.Type.GetType("System.String"));
            newTable.Columns.Add("category_description_summary", System.Type.GetType("System.String"));
            newTable.Columns.Add("sysid_account", System.Type.GetType("System.String"));

            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                _chartOfAccountsTable = remClient.SelectChartOfAccounts(userInfo, queryString, summaryAccount, accountingCategoryIdList, isActiveAccount);
            }

            if (_chartOfAccountsTable != null)
            {
                foreach (DataRow accoutRow in _chartOfAccountsTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["account_code_name"] = RemoteServerLib.ProcStatic.DataRowConvert(accoutRow, "account_code", String.Empty) + " - " +
                        RemoteServerLib.ProcStatic.DataRowConvert(accoutRow, "account_name", String.Empty);
                    newRow["category_description"] = RemoteServerLib.ProcStatic.DataRowConvert(accoutRow, "category_description", String.Empty);
                    newRow["account_code_name_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(accoutRow, "account_code_summary", String.Empty) + " - " +
                        RemoteServerLib.ProcStatic.DataRowConvert(accoutRow, "account_name_summary", String.Empty);
                    newRow["category_description_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(accoutRow, "category_description_summary", String.Empty);
                    newRow["sysid_account"] = RemoteServerLib.ProcStatic.DataRowConvert(accoutRow, "sysid_account", String.Empty);

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//------------------------------    

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

        //this fucntion will get regular loan collateral 
        public DataTable GetSearchedRegularLoanCollaterals(CommonExchange.SysAccess userInfo, String regularLoanSysIdList, Boolean isNewQuery)
        {
            DataTable newTable = this.CollateralInformationTable;

            if (isNewQuery)
            {
                using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
                {
                    _regularLoanCollateralInformationTable = remClient.SelectBySysIDRegularListRegularLoanCollateral(userInfo, regularLoanSysIdList);

                    foreach (DataRow colRow in _regularLoanCollateralInformationTable.Rows)
                    {
                        DataRow newRow = _regularLoanCollateralTable.NewRow();

                        newRow["loan_collateral_id"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow,"loan_collateral_id", Int64.Parse("0"));
                        newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow,"sysid_regular", String.Empty);
                        newRow["sysid_collateral"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow,"sysid_collateral", String.Empty);

                        _regularLoanCollateralTable.Rows.Add(newRow);
                    }

                    _regularLoanCollateralTable.AcceptChanges();
                }
            }
            
            if (_regularLoanCollateralInformationTable != null)
            {
                foreach (DataRow colRow in _regularLoanCollateralInformationTable.Rows)
                {
                    if (colRow.RowState != DataRowState.Deleted)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["sysid_collateral"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty);
                        newRow["property_type"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_type", String.Empty);
                        newRow["property_brand"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_brand", String.Empty);
                        newRow["serial_no"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "serial_no", String.Empty);
                        newRow["purchase_price"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "purchase_price", Decimal.Parse("0")).ToString("N");
                        newRow["year_purchased"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "year_purchased", String.Empty);
                        newRow["estimated_appraised_value"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "estimated_appraised_value", Decimal.Parse("0")).ToString("N");
                        newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "remarks", String.Empty);

                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }//---------------------------

        //this fucntion will get searched member information table
        public DataTable GetSearchedMemberInformationTable(CommonExchange.SysAccess userInfo, String queryString, String officeEmployerIdList,
            String classificationIdList, String memberSysIdExcludeList, String memberTypeIdList, Boolean includeMemberStatus, Boolean isActive, Boolean isNewQuery)
        {
            DataTable newTable = this.MemberInformationTable;

            if (isNewQuery)
            {
                using (RemoteClient.RemCntMemberManager remClient = new RemoteClient.RemCntMemberManager())
                {
                    _memberCoMakerTable = remClient.SelectMemberInformation(userInfo, queryString, officeEmployerIdList, memberTypeIdList, classificationIdList,
                        memberSysIdExcludeList, includeMemberStatus, isActive);
                }
            }

            if (_memberCoMakerTable != null)
            {
                foreach (DataRow memRow in _memberCoMakerTable.Rows)
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

        //this function will get searched co-makers
        public DataTable GetSearchedRegularLoanCoMaker(CommonExchange.SysAccess userInfo, String regularLoanSysIdList, Boolean isNewQuery)
        {
            DataTable newTable = this.CoMakerInformationTable;

            if (isNewQuery)
            {
                using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
                {
                    _coMakerInformationTable = remClient.SelectBySysIDRegularListRegularLoanCoMaker(userInfo, regularLoanSysIdList);

                    foreach (DataRow coRow in _coMakerInformationTable.Rows)
                    {
                        DataRow newRow = _coMakerTable.NewRow();

                        newRow["comaker_id"] = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_id", String.Empty);
				        newRow["sysid_regular"] = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "sysid_regular", String.Empty);
                        newRow["sysid_comaker"] = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "sysid_member_comaker", String.Empty);
                        newRow["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "remarks", String.Empty);

                        _coMakerTable.Rows.Add(newRow);
                    }

                    _coMakerTable.AcceptChanges();
                }
            }
            
            if (_coMakerInformationTable != null)
            {
                foreach (DataRow coRow in _coMakerInformationTable.Rows)
                {
                    if (coRow.RowState != DataRowState.Deleted)
                    {
                        DataRow newRowI = newTable.NewRow();

                        newRowI["comaker_id"] = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_id", String.Empty);
                        newRowI["comaker_name"] = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(coRow, "comaker_last_name",
                            "comaker_first_name", "comaker_middle_name");
                        newRowI["remarks"] = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "remarks", String.Empty);

                        newTable.Rows.Add(newRowI);
                    }
                }
            }

            return newTable;
        }//-----------------------

        //this fucntion will get the regular loan payments
        public DataTable GetRegularLoanPayments(CommonExchange.SysAccess userInfo, String regularLoanSysIdList, ToolStripLabel lblTotalPayment, ref Decimal totalPayment)
        {
            DataTable newTable = this.RegularLoanPaymentHistoryTable;

            using (RemoteClient.RemCntCashieringManager remClient = new RemoteClient.RemCntCashieringManager())
            {
                _regularLoanPaymentTable = remClient.SelectBySysIDRegularListRegularLoanPayments(userInfo, regularLoanSysIdList);
            }

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

        //this function will get member information table
        public CommonExchange.Member GetDetailsMemberInfo(String memberId)
        {
            CommonExchange.Member memberInfo = new CommonExchange.Member();

            if (_memberCoMakerTable != null)
            {
                String strFilter = "member_id = '" + memberId + "'";
                DataRow[] selectRow = _memberCoMakerTable.Select(strFilter);

                foreach (DataRow memRow in selectRow)
                {
                    memberInfo.MemberId = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "member_id", String.Empty);
                    memberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "sysid_member", String.Empty);
                    memberInfo.PersonInfo.PersonSysId = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "sysid_person", String.Empty);
                    memberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "last_name", String.Empty);
                    memberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "first_name", String.Empty);
                    memberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(memRow, "middle_name", String.Empty);

                    break;
                }
            }

            return memberInfo;
        }//-----------------------

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

        //this function will get amortization schedule
        public CommonExchange.RegularLoanAmortization GetDetailsAmortizationSchedule(String amortizationId, CommonExchange.RegularLoan regularLoanInfo)
        {
            CommonExchange.RegularLoanAmortization amortizationInfo = new CommonExchange.RegularLoanAmortization();

            foreach (CommonExchange.RegularLoanAmortization list in regularLoanInfo.LoanAmortizationList)
            {
                if (String.Equals(list.AmortizationId.ToString(), amortizationId))
                {
                    amortizationInfo = list;

                    break;
                }
            }

            return amortizationInfo;
        }//---------------------------

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

        //this function will get details regular loan collateral information
        public CommonExchange.RegularLoanCollateral GetDetailsRegularLoanCollateralInformation(String loanCollateralSysId)
        {
            CommonExchange.RegularLoanCollateral regularLoanCollateralInfo = new CommonExchange.RegularLoanCollateral();

            if (_regularLoanCollateralInformationTable != null)
            {
                String strFilter = "loan_collateral_id = '" + loanCollateralSysId + "'";
                DataRow[] selectRow = _regularLoanCollateralInformationTable.Select(strFilter);

                foreach (DataRow colRow in selectRow)
                {
                    regularLoanCollateralInfo.LoanCollateralId = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "loan_collateral_id", Int64.Parse("0"));
                    regularLoanCollateralInfo.CollateralInfo.CollateralSysId = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_collateral", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.PropertyType = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_type", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.PropertyBrand = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "property_brand", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.SerialNo = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "serial_no", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.PurchasePrice = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "purchase_price", Decimal.Parse("0"));
                    regularLoanCollateralInfo.CollateralInfo.YearPurchased = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "year_purchased", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.EstimatedAppraisedValue = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "estimated_appraised_value", Decimal.Parse("0"));
                    regularLoanCollateralInfo.CollateralInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "remarks", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.IsMarkedDeleted = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "is_marked_deleted", false);
                    regularLoanCollateralInfo.CollateralInfo.MemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "sysid_member", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.MemberInfo.MemberId = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "member_id", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.MemberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "last_name", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.MemberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "first_name", String.Empty);
                    regularLoanCollateralInfo.CollateralInfo.MemberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(colRow, "middle_name", String.Empty);

                    break;
                }
            }

            return regularLoanCollateralInfo;
        }//--------------------------    

        //this function will get details Co-Maker Information
        public CommonExchange.RegularLoanCoMaker GetDetailsRegularLoanCoMaker(String sysIdMemberCoMaker)
        {
            CommonExchange.RegularLoanCoMaker coMakerInfo = new CommonExchange.RegularLoanCoMaker();

            if (_coMakerInformationTable != null)
            {
                String strFilter = "comaker_id = '" + sysIdMemberCoMaker + "'";
                DataRow[] selectRow = _coMakerInformationTable.Select(strFilter);

                foreach (DataRow coRow in selectRow)
                {
                    if (coRow.RowState != DataRowState.Deleted)
                    {
                        coMakerInfo.CoMakerId = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_id", Int64.Parse("0"));
                        coMakerInfo.RegularLoanInfo.RegularLoanSysId = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "sysid_regular", String.Empty);
                        coMakerInfo.CoMakerMemberInfo.MemberSysId = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "sysid_member_comaker", String.Empty);
                        coMakerInfo.CoMakerMemberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_last_name", String.Empty);
                        coMakerInfo.CoMakerMemberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_first_name", String.Empty);
                        coMakerInfo.CoMakerMemberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "comaker_middle_name", String.Empty);
                        coMakerInfo.Remarks = RemoteServerLib.ProcStatic.DataRowConvert(coRow, "remarks", String.Empty);

                        break;
                    }
                }
            }

            return coMakerInfo;
        }//-------------------------

        //this function will get chart of account information
        public CommonExchange.ChartOfAccount GetChartOfAccountInformation(String accountSysId)
        {
            CommonExchange.ChartOfAccount chartOfAccountInfo = new CommonExchange.ChartOfAccount();

            if (_chartOfAccountsTable != null)
            {
                String strFilter = "sysid_account = '" + accountSysId + "'";
                DataRow[] selectRow = _chartOfAccountsTable.Select(strFilter);

                foreach (DataRow accountRow in selectRow)
                {
                    chartOfAccountInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_code", String.Empty);
                    chartOfAccountInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_name", String.Empty);
                    chartOfAccountInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "sysid_account", String.Empty);
                    chartOfAccountInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "is_active_account", false);
                    chartOfAccountInfo.AccountingCategoryInfo.AccountingCategoryId =
                        RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "accounting_category_id", String.Empty);
                    chartOfAccountInfo.AccountingCategoryInfo.CategoryDescription =
                        RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "category_description", String.Empty);
                    chartOfAccountInfo.SummaryAccount.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "sysid_account_summary", String.Empty);
                    chartOfAccountInfo.SummaryAccount.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_code_summary", String.Empty);
                    chartOfAccountInfo.SummaryAccount.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_name_summary", String.Empty);
                    chartOfAccountInfo.SummaryAccount.IsActiveAccount =
                        RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "is_active_account_summary", false);
                    chartOfAccountInfo.SummaryAccount.AccountingCategoryInfo.AccountingCategoryId =
                        RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "accounting_category_id_summary", String.Empty);
                    chartOfAccountInfo.SummaryAccount.AccountingCategoryInfo.CategoryDescription =
                       RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "category_description_summary", String.Empty);

                    break;
                }
            }

            return chartOfAccountInfo;
        }//---------------------------
        
        //this function will get regular loan chareges information
        public CommonExchange.RegularLoanCharges GetRegularLoanChargesInformation(CommonExchange.RegularLoan regularLoanInfo, Int64 regularLoanChargeId)
        {
            CommonExchange.RegularLoanCharges regularLoanChargeInfo = new CommonExchange.RegularLoanCharges();

            foreach (CommonExchange.RegularLoanCharges list in regularLoanInfo.LoanChargesList)
            {
                if (regularLoanChargeId == list.RegularChargesId)
                {
                    regularLoanChargeInfo = list;
                }
            }

            return regularLoanChargeInfo;
        }//--------------------

        //this function will get regular loan additions information
        public CommonExchange.RegularLoanAdditions GetRegularLoanAdditionsInformation(CommonExchange.RegularLoan regularLoanInfo, Int64 regularLoanAdditionsId)
        {
            CommonExchange.RegularLoanAdditions regularLoanAdditionsInfo = new CommonExchange.RegularLoanAdditions();

            foreach (CommonExchange.RegularLoanAdditions list in regularLoanInfo.LoanAdditionsList)
            {
                if (regularLoanAdditionsId == list.RegularAdditionsId)
                {
                    regularLoanAdditionsInfo = list;
                }
            }

            return regularLoanAdditionsInfo;
        }//----------------------

        //this function will get regular loan type information
        public CommonExchange.RegularLoanType GetRegularLoanTypeInformation(Int32 index)
        {
            CommonExchange.RegularLoanType regularLoanTypeInfo = new CommonExchange.RegularLoanType();

            if (_loanClassDataSet.Tables["RegularLoanTypeTable"] != null)
            {
                DataRow regLoanRow = _loanClassDataSet.Tables["RegularLoanTypeTable"].Rows[index];

                regularLoanTypeInfo.RegularLoanTypeId = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "regular_loan_type_id", String.Empty);
                regularLoanTypeInfo.RegularLoanTypeDescription = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "regular_loan_type_description", String.Empty);
                regularLoanTypeInfo.RegularLoanTypeCode = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "regular_loan_type_code", String.Empty);
                regularLoanTypeInfo.RegularLoanTypeNo = RemoteServerLib.ProcStatic.DataRowConvert(regLoanRow, "regular_loan_type_no", Byte.Parse("0"));
            }

            return regularLoanTypeInfo;
        }//----------------------

        //this function will get payment interval information (Repayment schedule)
        public CommonExchange.RepaymentSchedule GetRepaymentscheduleInformation(Int32 index)
        {
            CommonExchange.RepaymentSchedule repaymentScheduleInfo = new CommonExchange.RepaymentSchedule();

            if (_loanClassDataSet.Tables["RepaymentScheduleTable"] != null)
            {
                DataRow rePayRow = _loanClassDataSet.Tables["RepaymentScheduleTable"].Rows[index];

                repaymentScheduleInfo.RepaymentId = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "repayment_id", String.Empty);
                repaymentScheduleInfo.RepaymentDescription = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "repayment_description", String.Empty);
                repaymentScheduleInfo.PaymentsPerYear = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "payments_per_year", Int16.Parse("0"));
                repaymentScheduleInfo.RepaymentNo = RemoteServerLib.ProcStatic.DataRowConvert(rePayRow, "repayment_no", Byte.Parse("0"));
            }

            return repaymentScheduleInfo;
        }//-----------------------      

        //this function will get loan document information by document original name
        public String GetLoanDocumentInformation(String originalName)
        {
            String value = String.Empty;

            if (_loanDocumentTable != null)
            {
                String strFilter = "original_name = '" + originalName + "'";
                DataRow[] selectRow = _loanDocumentTable.Select(strFilter);

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

        //this function will automatically compute the maturity date
        public DateTime CalculateMaturityDate(CommonExchange.RegularLoan regularLoanInfo)
        {
            DateTime dateFrom = DateTime.MinValue;
            
            if (DateTime.TryParse(regularLoanInfo.DateFirstPayment, out dateFrom) && DateTime.Compare(dateFrom, DateTime.MinValue) != 0)
            {
            }

            for (Int16 amortizationCount = 1; amortizationCount < regularLoanInfo.LoanTerms; amortizationCount++)
            {
                if (DateTime.Compare(dateFrom, DateTime.MinValue) != 0)
                {
                    //if (amortizationCount == 1)
                    //{
                    //    dateFrom = dateFrom.AddDays(1);
                    //}
                    //else
                    //{
                        if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.DailyId))
                        {
                            dateFrom = dateFrom.AddDays(1);
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.WeeklyId))
                        {
                            dateFrom = dateFrom.AddDays(7);
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.BiWeeklyId))
                        {
                            Int32 noOfDaysOfTheMonth =
                                (this.LastDayOfMonthFromDateTime(dateFrom).Day == 31 || this.LastDayOfMonthFromDateTime(dateFrom).Day == 29) ?
                                this.LastDayOfMonthFromDateTime(dateFrom).Day - 1 : this.LastDayOfMonthFromDateTime(dateFrom).Day;

                            dateFrom.AddDays((noOfDaysOfTheMonth / 2) - 1);

                            if (dateFrom.AddDays(((noOfDaysOfTheMonth / 2) - 1)).Day == this.LastDayOfMonthFromDateTime(dateFrom).Day - 1)
                            {
                                dateFrom = dateFrom.AddMonths(1);
                                dateFrom = this.FirstDayOfMonthFromDateTime(dateFrom);
                            }
                            else
                            {
                                dateFrom = dateFrom.AddDays((noOfDaysOfTheMonth / 2));
                            }                            
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.MonthlyId))
                        {                            
                            dateFrom = this.LastDayOfMonthFromDateTime(dateFrom);
                            dateFrom = dateFrom.AddMonths(1);
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.QuarterlyId))
                        {
                            dateFrom = dateFrom.AddMonths(3);
                            dateFrom = this.LastDayOfMonthFromDateTime(dateFrom);
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.SemiAnnualId))
                        {
                            dateFrom = dateFrom.AddMonths(6);
                            dateFrom = this.LastDayOfMonthFromDateTime(dateFrom);
                        }
                        else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.Annual))
                        {
                            dateFrom = dateFrom.AddMonths(12);
                            dateFrom = this.LastDayOfMonthFromDateTime(dateFrom);
                        }
                    //}
                }
            }

            if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.DailyId))
            {
                dateFrom = dateFrom.AddDays(1);
            }
            else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.WeeklyId))
            {
                dateFrom = dateFrom.AddDays(-1);
            }
            else if (String.Equals(regularLoanInfo.RepaymentScheduleInfo.RepaymentId, CommonExchange.RepaymentSchedule.BiWeeklyId))
            {
                dateFrom = dateFrom.AddDays(-1);

                if (dateFrom.Day == 31 || dateFrom.Day == 29)
                {
                    dateFrom = dateFrom.AddDays(-1);
                }                
            }

            return dateFrom;
        }//----------------------

        //this function will get regular loan acount number
        public String GetRegularLoanAccountNumber(CommonExchange.SysAccess userInfo, String regularLoanTypeId, String dateApproved)
        {
            String accountId = String.Empty;

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                accountId = remClient.SelectCountForAccountNoRegularLoanInformation(userInfo, regularLoanTypeId, dateApproved);
            }

            return accountId;
        }//----------------------

        //this fucntion will determine if the regular loan account number is already exists
        public Boolean IsExistsAccountNumberRegularLoanInformation(CommonExchange.SysAccess userInfo, String regularLoanSysId, String accountNo)
        {
            Boolean isExists = false;

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                isExists = remClient.IsExistsAccountNoRegularLoanInformation(userInfo, regularLoanSysId, accountNo);
            }

            return isExists;
        }//-----------------------------

        //this function will determine if the regular loan charge already exist
        public Boolean IsExistsChargeRegularLoanCharges(CommonExchange.SysAccess userInfo, Int64 regularChargesId,
            String regularLoanSysId, String chargeDescription, String accountSysId)
        {
            Boolean isExist = false;

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                isExist = remClient.IsExistsChargeRegularLoanCharges(userInfo, regularChargesId, regularLoanSysId, chargeDescription, accountSysId);
            }

            return isExist;
        }//-----------------------

        //this function will determine if the payment date from , payment date to and grace period already exist
        public Boolean IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization(CommonExchange.SysAccess userInfo, Int64 amortizationId,
            String regularLoanSysId, String paymentDateFrom, String paymentDateTo)
        {
            Boolean isExist = false;

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                isExist = remClient.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization(userInfo, amortizationId, regularLoanSysId, paymentDateFrom, paymentDateTo);
            }

            return isExist;
        }//--------------------

        //this function will determine if the regular loan document already exist
        public Boolean IsExistsSysIDRegularOriginalNameRegularLoanDocument(CommonExchange.SysAccess userInfo, Int64 documentId, String regularLoanSysId,
            String originalName)
        {
            Boolean isExist = false;

            using (RemoteClient.RemCntLoanManager remClient = new RemoteClient.RemCntLoanManager())
            {
                isExist = remClient.IsExistsSysIDRegularOriginalNameRegularLoanDocument(userInfo, documentId, regularLoanSysId, originalName);
            }

            return isExist;
        }//--------------------------
        #endregion
    }
}
