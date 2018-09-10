using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CommonExchange
{
    #region Common Structure Exchange

    [Serializable()]
    public class Department : BaseObject
    {
        public Department()
        {
            _departmentId = String.Empty;
            _departmentName = String.Empty;
            _acronym = String.Empty;
        }

        public Boolean Equals(Department obj)
        {
            if (base.Equals<Department>(obj))
            {
                return true;
            }

            return false;
        }

        private String _departmentId;
        public String DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }

        private String _departmentName;
        public String DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        private String _acronym;
        public String Acronym
        {
            get { return _acronym; }
            set { _acronym = value; }
        }
    }

    [Serializable()]
    public class AccountingCategory : BaseObject
    {
        public AccountingCategory() 
        {
            _accountingCategoryId = String.Empty;
            _categoryDescription = String.Empty;
            _categoryNo = 0;
        }

        public Boolean Equals(AccountingCategory obj)
        {
            if (base.Equals<AccountingCategory>(obj))
            {
                return true;
            }

            return false;

        }

        private String _accountingCategoryId;
        public String AccountingCategoryId
        {
            get { return _accountingCategoryId; }
            set { _accountingCategoryId = value; }
        }

        private String _categoryDescription;
        public String CategoryDescription
        {
            get { return _categoryDescription; }
            set { _categoryDescription = value; }
        }

        private Byte _categoryNo;
        public Byte CategoryNo
        {
            get { return _categoryNo; }
            set { _categoryNo = value; }
        }

        public static String AccountingElementId
        {
            get { return "ACID01"; }
        }

        public static Byte AccountingElementNo
        {
            get { return 1; }
        }

        public static String ClassificationId
        {
            get { return "ACID02"; }
        }

        public static Byte ClassificationNo
        {
            get { return 2; }
        }

        public static String ControllingAccountId
        {
            get { return "ACID03"; }
        }

        public static Byte ControllingAccountNo
        {
            get { return 1; }
        }

        public static String SubsidiaryAccountId
        {
            get { return "ACID04"; }
        }

        public static Byte SubsidiaryAccountNo
        {
            get { return 1; }
        }        
    }

    [Serializable()]
    public class SummaryAccount : BaseObject
    {
        public SummaryAccount()
        {
            _accountSysId = String.Empty;
            _accountingCategoryInfo = new AccountingCategory();
            _accountCode = String.Empty;
            _accountName = String.Empty;
            _accountDescription = String.Empty;
            _companyPolicyProcedure = String.Empty;
            _isDebitSideIncrease = false;
            _isActiveAccount = false;
        }

        public Boolean Equals(SummaryAccount obj)
        {
            if (base.Equals<SummaryAccount>(obj) &&
                _accountingCategoryInfo.Equals(obj.AccountingCategoryInfo))
            {
                return true;
            }

            return false;

        }

        private String _accountSysId;
        public String AccountSysId
        {
            get { return _accountSysId; }
            set { _accountSysId = value; }
        }

        private AccountingCategory _accountingCategoryInfo;
        public AccountingCategory AccountingCategoryInfo
        {
            get { return _accountingCategoryInfo; }
            set { _accountingCategoryInfo = value; }
        }

        private String _accountCode;
        public String AccountCode
        {
            get { return _accountCode; }
            set { _accountCode = value; }
        }

        private String _accountName;
        public String AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        private String _accountDescription;
        public String AccountDescription
        {
            get { return _accountDescription; }
            set { _accountDescription = value; }
        }

        private String _companyPolicyProcedure;
        public String CompanyPolicyProcedure
        {
            get { return _companyPolicyProcedure; }
            set { _companyPolicyProcedure = value; }
        }

        private Boolean _isDebitSideIncrease;
        public Boolean IsDebitSideIncrease
        {
            get { return _isDebitSideIncrease; }
            set { _isDebitSideIncrease = value; }
        }

        private Boolean _isActiveAccount;
        public Boolean IsActiveAccount
        {
            get { return _isActiveAccount; }
            set { _isActiveAccount = value; }
        }
    }

    [Serializable()]
    public class ChartOfAccount : BaseObject
    {
        public ChartOfAccount()
        {
            _accountSysId = String.Empty;
            _accountingCategoryInfo = new AccountingCategory();
            _accountCode = String.Empty;
            _accountName = String.Empty;
            _accountDescription = String.Empty;
            _companyPolicyProcedure = String.Empty;
            _summaryAccount = new SummaryAccount();
            _isDebitSideIncrease = false;
            _isActiveAccount = false;
        }

        public Boolean Equals(ChartOfAccount obj)
        {
            if (base.Equals<ChartOfAccount>(obj) &&
                _accountingCategoryInfo.Equals(obj.AccountingCategoryInfo) &&
                _summaryAccount.Equals(obj.SummaryAccount))
            {
                return true;
            }

            return false;

        }

        private String _accountSysId;
        public String AccountSysId
        {
            get { return _accountSysId; }
            set { _accountSysId = value; }
        }

        private AccountingCategory _accountingCategoryInfo;
        public AccountingCategory AccountingCategoryInfo
        {
            get { return _accountingCategoryInfo; }
            set { _accountingCategoryInfo = value; }
        }

        private String _accountCode;
        public String AccountCode
        {
            get { return _accountCode; }
            set { _accountCode = value; }
        }

        private String _accountName;
        public String AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        private String _accountDescription;
        public String AccountDescription
        {
            get { return _accountDescription; }
            set { _accountDescription = value; }
        }

        private String _companyPolicyProcedure;
        public String CompanyPolicyProcedure
        {
            get { return _companyPolicyProcedure; }
            set { _companyPolicyProcedure = value; }
        }

        private SummaryAccount _summaryAccount;
        public SummaryAccount SummaryAccount
        {
            get { return _summaryAccount; }
            set { _summaryAccount = value; }
        }

        private Boolean _isDebitSideIncrease;
        public Boolean IsDebitSideIncrease
        {
            get { return _isDebitSideIncrease; }
            set { _isDebitSideIncrease = value; }
        }

        private Boolean _isActiveAccount;
        public Boolean IsActiveAccount
        {
            get { return _isActiveAccount; }
            set { _isActiveAccount = value; }
        }
        
    }

    [Serializable()]
    public class Bank : BaseObject
    {
        public Bank()
        {
            _bankSysId = String.Empty;
            _bankName = String.Empty;
            _bankAddress = String.Empty;
            _accountNo = String.Empty;
            _accountInfo = new ChartOfAccount();
            _isActiveAccount = false;
        }

        public Boolean Equals(Bank obj)
        {
            if (base.Equals<Bank>(obj) &&
                _accountInfo.Equals(obj.AccountInfo))
            {
                return true;
            }

            return false;

        }

        private String _bankSysId;
        public String BankSysId
        {
            get { return _bankSysId; }
            set { _bankSysId = value; }
        }

        private String _bankName;
        public String BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        private String _bankAddress;
        public String BankAddress
        {
            get { return _bankAddress; }
            set { _bankAddress = value; }
        }

        private String _accountNo;
        public String AccountNo
        {
            get { return _accountNo; }
            set { _accountNo = value; }
        }

        private ChartOfAccount _accountInfo;
        public ChartOfAccount AccountInfo
        {
            get { return _accountInfo; }
            set { _accountInfo = value; }
        }

        private Boolean _isActiveAccount;
        public Boolean IsActiveAccount
        {
            get { return _isActiveAccount; }
            set { _isActiveAccount = value; }
        }

    }

    [Serializable()]
    public class VoucherEntry : BaseObject
    {
        public VoucherEntry()
        {
            _voucherEntryId = 0;
            _accountInfo = new ChartOfAccount();
            _costCenterInfo = new Department();
            _debitAmount = 0.0M;
            _creditAmount = 0.0M;
            _sequenceNo = 0;
        }

        public Boolean Equals(VoucherEntry obj)
        {
            if (base.Equals<VoucherEntry>(obj) &&
                _accountInfo.Equals(obj.AccountInfo) &&
                _costCenterInfo.Equals(obj.CostCenterInfo))
            {
                return true;
            }

            return false;

        }

        private Int64 _voucherEntryId;
        public Int64 VoucherEntryId
        {
            get { return _voucherEntryId; }
            set { _voucherEntryId = value; }
        }

        private ChartOfAccount _accountInfo;
        public ChartOfAccount AccountInfo
        {
            get { return _accountInfo; }
            set { _accountInfo = value; }
        }

        private Department _costCenterInfo;
        public Department CostCenterInfo
        {
            get { return _costCenterInfo; }
            set { _costCenterInfo = value; }
        }

        private Decimal _debitAmount;
        public Decimal DebitAmount
        {
            get { return _debitAmount; }
            set { _debitAmount = value; }
        }

        private Decimal _creditAmount;
        public Decimal CreditAmount
        {
            get { return _creditAmount; }
            set { _creditAmount = value; }
        }

        private Int16 _sequenceNo;
        public Int16 SequenceNo
        {
            get { return _sequenceNo; }
            set { _sequenceNo = value; }
        }       

    }

    [Serializable()]
    public class DisbursementVoucher : BaseObject
    {
        public DisbursementVoucher()
        {
            _voucherSysId = String.Empty;
            _bankInfo = new Bank();
            _checkNo = String.Empty;
            _checkDate = String.Empty;
            _dateIssued = String.Empty;
            _payee = String.Empty;
            _regularLoanInfo = new RegularLoan();
            _inHouseDebitInfo = new InHouseHospitalizationDebit();
            _checkAmount = 0.0M;
            _particulars = String.Empty;
            _isMarkedDeleted = false;
            _voucherEntryList = new CloneableDictionaryList<VoucherEntry>();
        }

        public Boolean Equals(DisbursementVoucher obj)
        {
            if (base.Equals<DisbursementVoucher>(obj) &&
                _bankInfo.Equals(obj.BankInfo) &&
                _regularLoanInfo.Equals(obj.RegularLoanInfo) &&
                _inHouseDebitInfo.Equals(obj.InHouseDebitInfo) &&
                this.Equals(obj.VoucherEntryList))
            {
                return true;
            }

            return false;

        }

        private Boolean Equals(CloneableDictionaryList<VoucherEntry> list)
        {
            Int32 i = 0;

            foreach (VoucherEntry vEntry in _voucherEntryList)
            {
                if ((i < list.Count) && (!vEntry.Equals(list[i])))
                {
                    return false;
                }

                i++;
            }

            if (i != list.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private String _voucherSysId;
        public String VoucherSysId
        {
            get { return _voucherSysId; }
            set { _voucherSysId = value; }
        }

        private Bank _bankInfo;
        public Bank BankInfo
        {
            get { return _bankInfo; }
            set { _bankInfo = value; }
        }

        private String _checkNo;
        public String CheckNo
        {
            get { return _checkNo; }
            set { _checkNo = value; }
        }

        private String _checkDate;
        public String CheckDate
        {
            get { return _checkDate; }
            set { _checkDate = value; }
        }

        private String _dateIssued;
        public String DateIssued
        {
            get { return _dateIssued; }
            set { _dateIssued = value; }
        }

        private String _payee;
        public String Payee
        {
            get { return _payee; }
            set { _payee = value; }
        }

        private RegularLoan _regularLoanInfo;
        public RegularLoan RegularLoanInfo
        {
            get { return _regularLoanInfo; }
            set { _regularLoanInfo = value; }
        }

        private InHouseHospitalizationDebit _inHouseDebitInfo;
        public InHouseHospitalizationDebit InHouseDebitInfo
        {
            get { return _inHouseDebitInfo; }
            set { _inHouseDebitInfo = value; }
        }

        private Decimal _checkAmount;
        public Decimal CheckAmount
        {
            get { return _checkAmount; }
            set { _checkAmount = value; }
        }

        private String _particulars;
        public String Particulars
        {
            get { return _particulars; }
            set { _particulars = value; }
        }

        private Boolean _isMarkedDeleted;
        public Boolean IsMarkedDeleted
        {
            get { return _isMarkedDeleted; }
            set { _isMarkedDeleted = value; }
        }

        private CloneableDictionaryList<VoucherEntry> _voucherEntryList;
        public CloneableDictionaryList<VoucherEntry> VoucherEntryList
        {
            get { return _voucherEntryList; }
            set { _voucherEntryList = value; }
        }

    }

    #endregion
}