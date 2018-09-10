using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace DisbursementVoucherServices
{
    internal class DisbursementVoucherLogic : BaseServices.BaseServicesLogic
    {

        #region Class Data Member Declaration
        private DataSet _classDataSet;

        private DataTable _bankTable;
        private DataTable _disbursementPayeeTable;
        private DataTable _disbursementVoucherTable;
        #endregion

        #region Class Properties Declaration
        public DataTable BankTable
        {
            get
            {
                DataTable newTable = new DataTable("TempBankTable");
                newTable.Columns.Add("sysid_bank", System.Type.GetType("System.String"));
                newTable.Columns.Add("bank_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("bank_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_code_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("category_description", System.Type.GetType("System.String"));

                return newTable;

            }
        }

        public DataTable CostCenterTable
        {
            get
            {
                DataTable newTable = new DataTable("CostCenterTable");
                newTable.Columns.Add("department_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("department_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("acronym", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable DisbursementPayeeTable
        {
            get
            {
                DataTable newTable = new DataTable("DisbursementPayeeTable");
                newTable.Columns.Add("transaction_system_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name_forzeen", System.Type.GetType("System.String"));
                newTable.Columns.Add("transaction_account", System.Type.GetType("System.String"));
                newTable.Columns.Add("transaction_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("transaction_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("transaction_description_name", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable VoucherEntryTable
        {
            get
            {
                DataTable newTable = new DataTable("VoucherEntryTable");
                newTable.Columns.Add("sysid_vouchers", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_code_name_not_frozen", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_code_name_summary", System.Type.GetType("System.String"));
                newTable.Columns.Add("department_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("debit_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("credit_amount", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable DisbursementVoucherTable
        {
            get
            {
                DataTable newTable = new DataTable("DisbursementTable");
                newTable.Columns.Add("sysid_voucher", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_no", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_date", System.Type.GetType("System.String"));
                newTable.Columns.Add("date_issued", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("check_amount", System.Type.GetType("System.String"));
                newTable.Columns.Add("particulars", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        private Int16 _sequenceNo = 0;
        public Int16 SequenceNo
        {
            get { return _sequenceNo; }
            set { _sequenceNo = value; }
        }

        private Int16 _tempVoucherEntryId = -1;
        public Int16 TempVoucherentryId
        {
            get { return _tempVoucherEntryId; }
            set { _tempVoucherEntryId = value; }
        }
        #endregion

        #region Class Constructors
        public DisbursementVoucherLogic(CommonExchange.SysAccess userInfo)
            : base(userInfo)
        {
            //gets the server date and time
            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                _classDataSet = remClient.GetDataSetForAccounting(userInfo);
            } //--------------------------------
        }
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will print disbursement voucher
        public void PrintDisbursementVoucher(CommonExchange.DisbursementVoucher disbursementVoucherInfo, DisbursementVoucher frmD)
        {
            DataTable printVoucherEntry = new DataTable("PrintVoucherEntry");
            printVoucherEntry.Columns.Add("account_code", System.Type.GetType("System.String"));
            printVoucherEntry.Columns.Add("account_name", System.Type.GetType("System.String"));
            printVoucherEntry.Columns.Add("department_name", System.Type.GetType("System.String"));
            printVoucherEntry.Columns.Add("debit_amount", System.Type.GetType("System.Decimal"));
            printVoucherEntry.Columns.Add("credit_amount", System.Type.GetType("System.Decimal"));

            foreach (CommonExchange.VoucherEntry list in disbursementVoucherInfo.VoucherEntryList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow newRow = printVoucherEntry.NewRow();

                    newRow["account_code"] = list.AccountInfo.AccountCode;
                    newRow["account_name"] = list.AccountInfo.AccountName;
                    newRow["department_name"] = list.CostCenterInfo.DepartmentName;
                    newRow["debit_amount"] = list.DebitAmount;
                    newRow["credit_amount"] = list.CreditAmount;

                    printVoucherEntry.Rows.Add(newRow);
                }
            }

            using (ClassDisbursementVoucherServices.CrystalReport.CrystalDisbursementVoucher rptDisbursementVoucher = new 
                DisbursementVoucherServices.ClassDisbursementVoucherServices.CrystalReport.CrystalDisbursementVoucher())
            {
                rptDisbursementVoucher.Database.Tables["voucher_entry_table"].SetDataSource(printVoucherEntry);

                rptDisbursementVoucher.SetParameterValue("@company_name", CommonExchange.CompanyInformation.CompanyName);
                rptDisbursementVoucher.SetParameterValue("@company_address", CommonExchange.CompanyInformation.Address);
                rptDisbursementVoucher.SetParameterValue("@company_phone_nos", CommonExchange.CompanyInformation.PhoneNos);
                rptDisbursementVoucher.SetParameterValue("@report_name", "Disbursement Voucher");
                rptDisbursementVoucher.SetParameterValue("@disbursement_voucher_id", disbursementVoucherInfo.VoucherSysId);
                rptDisbursementVoucher.SetParameterValue("@check_date", disbursementVoucherInfo.CheckDate);
                rptDisbursementVoucher.SetParameterValue("@payee", disbursementVoucherInfo.Payee);

                long wholeNum = this.GetWholeNumberTenthDecimal(disbursementVoucherInfo.CheckAmount, true);
                int decNum = (int)this.GetWholeNumberTenthDecimal(disbursementVoucherInfo.CheckAmount, false);

                BaseServices.ConvertNumberWords numberToWordsManager = new BaseServices.ConvertNumberWords();

                numberToWordsManager.ProcessNumber(wholeNum, decNum);

                rptDisbursementVoucher.SetParameterValue("@check_amount", numberToWordsManager.NumberString + "  (PHP " + disbursementVoucherInfo.CheckAmount.ToString("N") + ")");
                rptDisbursementVoucher.SetParameterValue("@check_no", disbursementVoucherInfo.CheckNo);
                rptDisbursementVoucher.SetParameterValue("@bank", disbursementVoucherInfo.BankInfo.BankName);
                rptDisbursementVoucher.SetParameterValue("@particulars", disbursementVoucherInfo.Particulars);


                using (BaseServices.CrystalReportViewer frmViewr = new BaseServices.CrystalReportViewer(rptDisbursementVoucher))
                {
                    frmViewr.Text = "   Disbursement Voucher";
                    frmViewr.ShowDialog(frmD);
                }
            }
        }//-------------------------------

        //this procedure will insert disbursement voucher information
        public void InsertUpdateDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.DisbursementVoucher disbursementVoucherInfo)
        {
            if (String.IsNullOrEmpty(disbursementVoucherInfo.VoucherSysId))
            {
                using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
                {
                    remClient.InsertDisbursementVoucherInformation(userInfo, ref disbursementVoucherInfo);
                }
            }
            else
            {
                using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
                {
                    remClient.UpdateDisbursementVoucherInformation(userInfo, disbursementVoucherInfo);
                }
            }

            Int32 index = 0;
            foreach (CommonExchange.VoucherEntry list in disbursementVoucherInfo.VoucherEntryList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    disbursementVoucherInfo.VoucherEntryList[index].ObjectState = DataRowState.Unchanged;
                }

                index++;
            }
        }//---------------------
             
        //this procedure will delete disbursement voucher information
        public void DeleteDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, CommonExchange.DisbursementVoucher disbursementVoucherInfo)
        {
            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                remClient.DeleteDisbursementVoucherInformation(userInfo, disbursementVoucherInfo);
            }
        }//---------------------

        //this procedure will insert new bank information
        public void InsertBankInformation(CommonExchange.SysAccess userInfo, CommonExchange.Bank bankInfo)
        {
            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                remClient.InsertBankInformation(userInfo, ref bankInfo);
            }

            if (_bankTable != null)
            {
                DataRow newRow = _bankTable.NewRow();

                newRow["sysid_bank"] = bankInfo.BankSysId;
                newRow["bank_name"] = bankInfo.BankName;
                newRow["bank_address"] = bankInfo.BankAddress;
                newRow["account_no"] = bankInfo.AccountNo;
                newRow["account_code"] = bankInfo.AccountInfo.AccountCode;
                newRow["account_name"] = bankInfo.AccountInfo.AccountName;
                newRow["category_description"] = bankInfo.AccountInfo.AccountingCategoryInfo.CategoryDescription;

                _bankTable.Rows.Add(newRow);
            }
        }//--------------------------

        //this procedure will update bank information
        public void UpdateBankInformation(CommonExchange.SysAccess userInfo, CommonExchange.Bank bankInfo)
        {
            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                remClient.UpdateBankInformation(userInfo, bankInfo);
            }

            if (_bankTable != null)
            {
                Int32 index = 0;

                foreach (DataRow bankRow in _bankTable.Rows)
                {
                    if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "sysid_bank", String.Empty), bankInfo.BankSysId))
                    {
                        DataRow editRow = _bankTable.Rows[index];

                        editRow.BeginEdit();

                        editRow["sysid_bank"] = bankInfo.BankSysId;
                        editRow["bank_name"] = bankInfo.BankName;
                        editRow["bank_address"] = bankInfo.BankAddress;
                        editRow["account_no"] = bankInfo.AccountNo;
                        editRow["account_code"] = bankInfo.AccountInfo.AccountCode;
                        editRow["account_name"] = bankInfo.AccountInfo.AccountName;
                        editRow["category_description"] = bankInfo.AccountInfo.AccountingCategoryInfo.CategoryDescription;

                        editRow.EndEdit();

                        break;
                    }

                    index++;
                }
            }
        }//-----------------------

        //this procedure will set voucher entry sequence no
        public void SetVoucherEntrySequenceNo(List<CommonExchange.VoucherEntry> voucherEntryList)
        {
            Int16 sequenceNo = 1;

            foreach (CommonExchange.VoucherEntry list in voucherEntryList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    list.SequenceNo = sequenceNo;

                    if (list.ObjectState == DataRowState.Unchanged || list.ObjectState == 0)
                    {
                        list.ObjectState = DataRowState.Modified;
                    }

                    sequenceNo++;
                }
            }
        }//--------------------------
        #endregion

        #region Programmer's Defined Function
        //this funtion will initialize the Voucher Entry Table
        public DataTable SetVoucherEntryTable(List<CommonExchange.VoucherEntry> voucherEntryList, Label lblDebit, Label lblCredit)
        {
            DataTable newTable = this.VoucherEntryTable;

            Decimal debit = 0;
            Decimal credit = 0;

            foreach (CommonExchange.VoucherEntry list in voucherEntryList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["sysid_vouchers"] = list.VoucherEntryId;
                    newRow["account_code_name_not_frozen"] = list.AccountInfo.AccountCode + " (" + list.AccountInfo.AccountName + ")";
                    newRow["account_code_name_summary"] = !(String.IsNullOrEmpty(list.AccountInfo.SummaryAccount.AccountCode) &&
                        String.IsNullOrEmpty(list.AccountInfo.SummaryAccount.AccountName)) ?
                        list.AccountInfo.SummaryAccount.AccountCode + " (" + list.AccountInfo.SummaryAccount.AccountName + ")" : String.Empty;
                    newRow["department_name"] = list.CostCenterInfo.DepartmentName;
                    newRow["debit_amount"] = list.DebitAmount.ToString("N");
                    newRow["credit_amount"] = list.CreditAmount.ToString("N");
                   
                    newTable.Rows.Add(newRow);

                    debit += list.DebitAmount;
                    credit += list.CreditAmount;
                }
            }

            lblDebit.Text = debit.ToString("N");
            lblCredit.Text = credit.ToString("N");

            return newTable;
        }//----------------------------

        //this function will get Voucher Entry information details
        public CommonExchange.VoucherEntry GetVoucherEntryInformationDetails(List<CommonExchange.VoucherEntry> voucherEntryList, String voucherEntryId)
        {
            CommonExchange.VoucherEntry voucherEntryInfo = new CommonExchange.VoucherEntry();

            foreach (CommonExchange.VoucherEntry list in voucherEntryList)
            {
                if (list.VoucherEntryId == Int64.Parse(voucherEntryId))
                {
                    voucherEntryInfo = list;
                }
            }

            return voucherEntryInfo;
        }//----------------------

        //this function will get searched bank information
        public DataTable GetSearchedBankInformation(CommonExchange.SysAccess userInfo, String queryString, Boolean isActiveAccount, Boolean isNewQuery)
        {
            DataTable newTable = this.BankTable;

            if (isNewQuery)
            {
                using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
                {
                    _bankTable = remClient.SelectBankInformation(userInfo, queryString, isActiveAccount);
                }
            }

            if (_bankTable != null)
            {
                foreach (DataRow bankRow in _bankTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["sysid_bank"] = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "sysid_bank", String.Empty);
                    newRow["bank_name"] = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "bank_name", String.Empty);
                    newRow["bank_address"] = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "bank_address", String.Empty);
                    newRow["account_no"] = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "account_no", String.Empty);
                    newRow["account_code_name"] = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "account_code", String.Empty) + " (" +
                        RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "account_name", String.Empty) + ")";
                    newRow["category_description"] = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "category_description", String.Empty);

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//--------------------

        //this function will get search cost center 
        public DataTable GetSearchedCostCostCeter(String queryString)
        {
            DataTable newTable = this.CostCenterTable;

            if (_classDataSet.Tables["DepartmentInformationTable"] != null)
            {
                queryString = queryString.Replace("*", "").Replace("%", "").Replace("'", "''");

                String strFilter = "department_name LIKE '%" + queryString + "%' OR acronym LIKE '%" + queryString + "%'";
                DataRow[] selectRow = _classDataSet.Tables["DepartmentInformationTable"].Select(strFilter);

                foreach (DataRow costRow in selectRow)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["department_id"] = RemoteServerLib.ProcStatic.DataRowConvert(costRow, "department_id", String.Empty);
                    newRow["department_name"] = RemoteServerLib.ProcStatic.DataRowConvert(costRow, "department_name", String.Empty);
                    newRow["acronym"] = RemoteServerLib.ProcStatic.DataRowConvert(costRow, "acronym", String.Empty);

                    newTable.Rows.Add(newRow);
                }                
            }

            return newTable;
        }//-------------------------
        
        //this function will search disbursement payee table
        public DataTable GetSearchDisbursmentPayeeTable(CommonExchange.SysAccess userInfo, String queryString)
        {
            DataTable newTable = this.DisbursementPayeeTable;

            queryString = queryString.Replace("%", "").Replace("'", "''");

            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                _disbursementPayeeTable = remClient.SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation(userInfo, queryString);
            }

            if (_disbursementPayeeTable != null)
            {
                foreach (DataRow disbursementRow in _disbursementPayeeTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["transaction_system_id"] = RemoteServerLib.ProcStatic.DataRowConvert(disbursementRow, "transaction_system_id", String.Empty);
                    newRow["person_name_forzeen"] = BaseServices.ProcStatic.GetCompleteNameMiddleInitial(disbursementRow, "last_name", "first_name", "middle_name");
                    newRow["transaction_account"] = RemoteServerLib.ProcStatic.DataRowConvert(disbursementRow, "transaction_account", String.Empty);
                    newRow["transaction_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(disbursementRow, "transaction_amount", Decimal.Parse("0")).ToString("N");
                    newRow["transaction_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(disbursementRow, "transaction_date", String.Empty)).ToShortDateString();
                    newRow["transaction_description_name"] = RemoteServerLib.ProcStatic.DataRowConvert(disbursementRow, "transaction_description_name", String.Empty);

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//------------------

        //this function will get disbursement voucher information
        public DataTable GetSearchedDisbursmentVoucherInformation(CommonExchange.SysAccess userInfo, String queryString,
            String dateStart, String dateEnd, Boolean isCanceled)
        {
            DataTable newTable = this.DisbursementVoucherTable;

            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            { 
                _disbursementVoucherTable = remClient.SelectByQueryStringDateStartEndDisbursementVoucherInformation(userInfo, queryString, dateStart, dateEnd, isCanceled);
            }

            foreach (DataRow disRow in _disbursementVoucherTable.Rows)
            {
                DataRow newRow = newTable.NewRow();

                newRow["sysid_voucher"] = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "sysid_voucher", String.Empty);
                newRow["check_no"] = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "check_no", String.Empty);
                newRow["check_date"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(disRow, "check_date", String.Empty)).ToShortDateString();
                newRow["date_issued"] = DateTime.Parse(RemoteServerLib.ProcStatic.DataRowConvert(disRow, "date_issued", String.Empty)).ToShortDateString();
                newRow["person_name"] = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "payee", String.Empty);
                newRow["check_amount"] = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "check_amount", Decimal.Parse("0")).ToString("N");
                newRow["particulars"] = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "particulars", String.Empty);

                newTable.Rows.Add(newRow);
            }

            return newTable;
        }//-----------------------

        //this function will get bank information details
        public CommonExchange.Bank GetBankInformationDetails(String bankSysId)
        {
            CommonExchange.Bank bankInfo = new CommonExchange.Bank();

            if (_bankTable != null)
            {
                String strFilter = "sysid_bank = '" + bankSysId + "'";
                DataRow[] selectRow = _bankTable.Select(strFilter);

                foreach (DataRow bankRow in selectRow)
                {
                    bankInfo.BankSysId = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "sysid_bank", String.Empty);
                    bankInfo.BankName = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "bank_name", String.Empty);
                    bankInfo.BankAddress = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "bank_address", String.Empty);
                    bankInfo.IsActiveAccount = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "is_active_account", false);
                    bankInfo.AccountNo = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "account_no", String.Empty);
                    bankInfo.AccountInfo.AccountSysId = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "sysid_account", String.Empty);
                    bankInfo.AccountInfo.AccountCode = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "account_code", String.Empty);
                    bankInfo.AccountInfo.AccountName = RemoteServerLib.ProcStatic.DataRowConvert(bankRow, "account_name", String.Empty);

                    break;
                }
            }

            return bankInfo;
        }//---------------------       

        //this function will get cost center details
        public CommonExchange.Department GetCostCenterDetails(String departmentId)
        {
            CommonExchange.Department departmentInfo = new CommonExchange.Department();

            if (_classDataSet.Tables["DepartmentInformationTable"] != null)
            {
                String strFilter = "department_id = '" + departmentId + "'";
                DataRow[] selectRow = _classDataSet.Tables["DepartmentInformationTable"].Select(strFilter);

                foreach (DataRow costRow in selectRow)
                {
                    departmentInfo.DepartmentId = RemoteServerLib.ProcStatic.DataRowConvert(costRow, "department_id", String.Empty);
                    departmentInfo.DepartmentName = RemoteServerLib.ProcStatic.DataRowConvert(costRow, "department_name", String.Empty);
                    departmentInfo.Acronym = RemoteServerLib.ProcStatic.DataRowConvert(costRow, "acronym", String.Empty);

                    break;
                }
            }

            return departmentInfo;
        }//---------------------------

        //this function will get the in house hospitalization debit information
        public CommonExchange.InHouseHospitalizationDebit GetInHouseHospitalizationDebitInfoDetails(String transactionId, 
            TextBox txtTransactionName, TextBox txtCheckAmount)
        {
            CommonExchange.InHouseHospitalizationDebit hospitalizationDebitInfo = new CommonExchange.InHouseHospitalizationDebit();

            if (_disbursementPayeeTable != null)
            {
                String strFilter = "transaction_system_id = '" + transactionId + "'";
                DataRow[] selectRow = _disbursementPayeeTable.Select(strFilter);

                foreach (DataRow disRow in selectRow)
                {
                    hospitalizationDebitInfo.InHouseDebitSysId = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_system_id", String.Empty);
                    hospitalizationDebitInfo.HospitalName = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_account", String.Empty);
                    hospitalizationDebitInfo.NetAssistanceAmount = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_amount", Decimal.Parse("0"));
                    hospitalizationDebitInfo.ReflectedDate = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_date", String.Empty);
                    hospitalizationDebitInfo.MemberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "last_name", String.Empty);
                    hospitalizationDebitInfo.MemberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "first_name", String.Empty);
                    hospitalizationDebitInfo.MemberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "middle_name", String.Empty);

                    txtTransactionName.Text = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_description_name", String.Empty);
                    txtCheckAmount.Text = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_amount", Decimal.Parse("0")).ToString("N");

                    break;
                }
            }

            return hospitalizationDebitInfo;
        }//-------------------------

        //this function wil get the regular loan information
        public CommonExchange.RegularLoan GetRegularLoanInfoForDisbursmentDetails(String transactionId,
            TextBox txtTransactionName, TextBox txtCheckAmount)
        {
            CommonExchange.RegularLoan regularLoanInfo = new CommonExchange.RegularLoan();

            if (_disbursementPayeeTable != null)
            {
                String strFilter = "transaction_system_id = '" + transactionId + "'";
                DataRow[] selectRow = _disbursementPayeeTable.Select(strFilter);

                foreach (DataRow disRow in selectRow)
                {
                    regularLoanInfo.RegularLoanSysId = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_system_id", String.Empty);
                    regularLoanInfo.AccountNo = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_account", String.Empty);
                    regularLoanInfo.LoanAmount = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_amount", Decimal.Parse("0"));
                    regularLoanInfo.DateApproved = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_date", String.Empty);
                    regularLoanInfo.MemberInfo.PersonInfo.LastName = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "last_name", String.Empty);
                    regularLoanInfo.MemberInfo.PersonInfo.FirstName = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "first_name", String.Empty);
                    regularLoanInfo.MemberInfo.PersonInfo.MiddleName = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "middle_name", String.Empty);

                    txtTransactionName.Text = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_description_name", String.Empty);
                    txtCheckAmount.Text = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "transaction_amount", Decimal.Parse("0")).ToString("N");

                    break;
                }
            }

            return regularLoanInfo;
        }//----------------------

        //this function will get disbursement voucher information details
        public CommonExchange.DisbursementVoucher GetDisbursementVoucherInformationDetails(CommonExchange.SysAccess userInfo, String voucherSysId)
        {
            CommonExchange.DisbursementVoucher disbursementVoucherInfo = new CommonExchange.DisbursementVoucher();

            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                disbursementVoucherInfo = remClient.SelectBySysIDVoucherDisbursementVoucherInformation(userInfo, voucherSysId);
            }

            return disbursementVoucherInfo;
        }//----------------------

        //this function will determine if the bank information already exist
        public Boolean IsExistsBankNameAccountNumberBankInformation(CommonExchange.SysAccess userInfo, String bankSysId, String bankName, String accountNumber)
        {
            Boolean isExist = true;

            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                isExist = remClient.IsExistsBankNameAccountNumberBankInformation(userInfo, bankSysId, bankName, accountNumber);
            }

            return isExist;
        }//------------------------
        
        //this function will determine if the Check Number alrady exists
        public Boolean IsExistsBankCheckNoDisbursementVoucherInformation(CommonExchange.SysAccess userInfo, String voucherSysId, String bankSysId, String checkNo)
        {
            Boolean isExists = true;

            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                isExists = remClient.IsExistsBankCheckNoDisbursementVoucherInformation(userInfo, voucherSysId, bankSysId, checkNo);
            }

            return isExists;
        }//-------------------

        //this function will determine if the disbursment payee is for regular loan or in house hospitalization
        public Boolean IsPayeeForRegularLoan(String transactionId)
        {
            Boolean isForRegularLoan = false;

            String strFilter = "transaction_system_id = '" + transactionId + "'";
            DataRow[] selectRow = _disbursementPayeeTable.Select(strFilter);

            foreach (DataRow disRow in selectRow)
            {
                isForRegularLoan = RemoteServerLib.ProcStatic.DataRowConvert(disRow, "is_regular_loan", false);

                break;
            }

            return isForRegularLoan;
        }//----------------------        

        //this function will determine if the list of voucher entry is valid (at least one of the object state is added or modified)
        public Boolean IsValidVoucherEntryList(List<CommonExchange.VoucherEntry> voucherEntryList)
        {
            Boolean isValid = false;

            foreach (CommonExchange.VoucherEntry list in voucherEntryList)
            {
                if (list.ObjectState == DataRowState.Added || list.ObjectState == DataRowState.Modified || list.ObjectState == DataRowState.Unchanged || list.ObjectState == 0)
                {
                    isValid = true;

                    break;
                }
            }

            return isValid;
        }//------------------------
        #endregion
    }
}
