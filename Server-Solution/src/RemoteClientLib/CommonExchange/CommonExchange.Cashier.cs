using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CommonExchange
{
    #region Common Structure Exchange

    [Serializable()]
    public class ShareCapitalInformation : BaseObject
    {
        public ShareCapitalInformation()
        {
            _shareCapitalId = 0;
            _memberInfo = new Member();
            _effectivityDate = String.Empty;
            _premiumAmountDue = 0.0M;
            _remarks = String.Empty;
            _isPrecludedWithdrawal = false;
            _isPrecludedRetirement = false;
        }

        public Boolean Equals(ShareCapitalInformation obj)
        {
            if (base.Equals<ShareCapitalInformation>(obj) &&
                _memberInfo.Equals(obj.MemberInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _shareCapitalId;
        public Int64 ShareCapitalId
        {
            get { return _shareCapitalId; }
            set { _shareCapitalId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _effectivityDate;
        public String EffectivityDate
        {
            get { return _effectivityDate; }
            set { _effectivityDate = value; }
        }

        private Decimal _premiumAmountDue;
        public Decimal PremiumAmountDue
        {
            get { return _premiumAmountDue; }
            set { _premiumAmountDue = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Boolean _isPrecludedWithdrawal;
        public Boolean IsPrecludedWithdrawal
        {
            get { return _isPrecludedWithdrawal; }
            set { _isPrecludedWithdrawal = value; }
        }

        private Boolean _isPrecludedRetirement;
        public Boolean IsPrecludedRetirement
        {
            get { return _isPrecludedRetirement; }
            set { _isPrecludedRetirement = value; }
        }
    }

    [Serializable()]
    public class InHouseHospitalizationInformation : BaseObject
    {
        public InHouseHospitalizationInformation()
        {
            _inHouseId = 0;
            _memberInfo = new Member();
            _effectivityDate = String.Empty;
            _certificateNo = String.Empty;
            _premiumAmountDue = 0.0M;
            _maximumAmount = 0.0M;
            _remarks = String.Empty;
            _isPrecluded = false;
        }

        public Boolean Equals(InHouseHospitalizationInformation obj)
        {
            if (base.Equals<InHouseHospitalizationInformation>(obj) &&
                _memberInfo.Equals(obj.MemberInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _inHouseId;
        public Int64 InHouseId
        {
            get { return _inHouseId; }
            set { _inHouseId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _effectivityDate;
        public String EffectivityDate
        {
            get { return _effectivityDate; }
            set { _effectivityDate = value; }
        }

        private String _certificateNo;
        public String CertificateNo
        {
            get { return _certificateNo; }
            set { _certificateNo = value; }
        }

        private Decimal _premiumAmountDue;
        public Decimal PremiumAmountDue
        {
            get { return _premiumAmountDue; }
            set { _premiumAmountDue = value; }
        }

        private Decimal _maximumAmount;
        public Decimal MaximumAmount
        {
            get { return _maximumAmount; }
            set { _maximumAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Boolean _isPrecluded;
        public Boolean IsPrecluded
        {
            get { return _isPrecluded; }
            set { _isPrecluded = value; }
        }
    }

    [Serializable()]
    public class HospitalizationIncludeCoverage : BaseObject
    {
        public HospitalizationIncludeCoverage()
        {
            _includeCoverageSysId = String.Empty;
            _includeCoverageDescription = String.Empty;
            _isMarkedDeleted = false;
        }

        public Boolean Equals(HospitalizationIncludeCoverage obj)
        {
            if (base.Equals<HospitalizationIncludeCoverage>(obj))
            {
                return true;
            }

            return false;
        }

        private String _includeCoverageSysId;
        public String IncludeCoverageSysId
        {
            get { return _includeCoverageSysId; }
            set { _includeCoverageSysId = value; }
        }

        private String _includeCoverageDescription;
        public String IncludeCoverageDescription
        {
            get { return _includeCoverageDescription; }
            set { _includeCoverageDescription = value; }
        }

        private Boolean _isMarkedDeleted;
        public Boolean IsMarkedDeleted
        {
            get { return _isMarkedDeleted; }
            set { _isMarkedDeleted = value; }
        }
    }

    [Serializable()]
    public class HospitalizationExcludeCoverage : BaseObject
    {
        public HospitalizationExcludeCoverage()
        {
            _excludeCoverageSysId = String.Empty;
            _excludeCoverageDescription = String.Empty;
            _isMarkedDeleted = false;
        }

        public Boolean Equals(HospitalizationExcludeCoverage obj)
        {
            if (base.Equals<HospitalizationExcludeCoverage>(obj))
            {
                return true;
            }

            return false;
        }

        private String _excludeCoverageSysId;
        public String ExcludeCoverageSysId
        {
            get { return _excludeCoverageSysId; }
            set { _excludeCoverageSysId = value; }
        }

        private String _excludeCoverageDescription;
        public String ExcludeCoverageDescription
        {
            get { return _excludeCoverageDescription; }
            set { _excludeCoverageDescription = value; }
        }

        private Boolean _isMarkedDeleted;
        public Boolean IsMarkedDeleted
        {
            get { return _isMarkedDeleted; }
            set { _isMarkedDeleted = value; }
        }
    }

    [Serializable()]
    public class InHouseHospitalizationDebit : BaseObject
    {
        public InHouseHospitalizationDebit()
        {
            _inHouseDebitSysId = String.Empty;
            _memberInfo = new Member();
            _reflectedDate = String.Empty;
            _netAssistanceAmount = 0.0M;
            _hospitalName = String.Empty;
            _causeOfAdmission = String.Empty;
            _dateFrom = String.Empty;
            _dateTo = String.Empty;
            _remarks = String.Empty;
            _isRecordLocked = false;
            _includeCoverageList = new CloneableDictionaryList<InHouseIncludeCoverage>();
            _excludeCoverageList = new CloneableDictionaryList<InHouseExcludeCoverage>();
            _isMarkedDeleted = false;
        }

        public Boolean Equals(InHouseHospitalizationDebit obj)
        {
            if (base.Equals<InHouseHospitalizationDebit>(obj) &&
                _memberInfo.Equals(obj.MemberInfo) &&
                this.Equals(obj.IncludeCoverageList) &&
                this.Equals(obj.ExcludeCoverageList))
            {
                return true;
            }

            return false;
        }

        private Boolean Equals(CloneableDictionaryList<InHouseIncludeCoverage> list)
        {
            Int32 i = 0;

            foreach (InHouseIncludeCoverage includeCoverage in _includeCoverageList)
            {
                if ((i < list.Count) && (!includeCoverage.Equals(list[i])))
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

        private Boolean Equals(CloneableDictionaryList<InHouseExcludeCoverage> list)
        {
            Int32 i = 0;

            foreach (InHouseExcludeCoverage excludeCoverage in _excludeCoverageList)
            {
                if ((i < list.Count) && (!excludeCoverage.Equals(list[i])))
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

        private String _inHouseDebitSysId;
        public String InHouseDebitSysId
        {
            get { return _inHouseDebitSysId; }
            set { _inHouseDebitSysId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _reflectedDate;
        public String ReflectedDate
        {
            get { return _reflectedDate; }
            set { _reflectedDate = value; }
        }

        private Decimal _netAssistanceAmount;
        public Decimal NetAssistanceAmount
        {
            get { return _netAssistanceAmount; }
            set { _netAssistanceAmount = value; }
        }

        private String _hospitalName;
        public String HospitalName
        {
            get { return _hospitalName; }
            set { _hospitalName = value; }
        }

        private String _causeOfAdmission;
        public String CauseOfAdmission
        {
            get { return _causeOfAdmission; }
            set { _causeOfAdmission = value; }
        }

        private String _dateFrom;
        public String DateFrom
        {
            get { return _dateFrom; }
            set { _dateFrom = value; }
        }

        private String _dateTo;
        public String DateTo
        {
            get { return _dateTo; }
            set { _dateTo = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Boolean _isRecordLocked;
        public Boolean IsRecordLocked
        {
            get { return _isRecordLocked; }
            set { _isRecordLocked = value; }
        }

        private CloneableDictionaryList<InHouseIncludeCoverage> _includeCoverageList;
        public CloneableDictionaryList<InHouseIncludeCoverage> IncludeCoverageList
        {
            get { return _includeCoverageList; }
            set { _includeCoverageList = value; }
        }

        private CloneableDictionaryList<InHouseExcludeCoverage> _excludeCoverageList;
        public CloneableDictionaryList<InHouseExcludeCoverage> ExcludeCoverageList
        {
            get { return _excludeCoverageList; }
            set { _excludeCoverageList = value; }
        }

        private Boolean _isMarkedDeleted;
        public Boolean IsMarkedDeleted
        {
            get { return _isMarkedDeleted; }
            set { _isMarkedDeleted = value; }
        }

        /// <summary>
        /// If the InHouseDebitSysId is NULL or Empty, a TEMP folder is created
        /// </summary>
        /// <param name="startUpPath"></param>
        /// <returns></returns>
        public String HospitalizationDocumentsFolder(String startUpPath)
        {
            return SystemConfiguration.ApplicationDocumentsFolder(startUpPath) + @"\" +
                (!String.IsNullOrEmpty(_inHouseDebitSysId) ? _inHouseDebitSysId : "Temp") + @"\HospitalizationDocuments\";
        }
    }

    [Serializable()]
    public class InHouseIncludeCoverage : BaseObject
    {
        public InHouseIncludeCoverage()
        {
            _includeCoverageId = 0;
            _includeCoverageInfo = new HospitalizationIncludeCoverage();
            _includeAmount = 0.0M;
            _remarks = String.Empty;
        }

        public Boolean Equals(InHouseIncludeCoverage obj)
        {
            if (base.Equals<InHouseIncludeCoverage>(obj) &&
                _includeCoverageInfo.Equals(obj.IncludeCoverageInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _includeCoverageId;
        public Int64 IncludeCoverageId
        {
            get { return _includeCoverageId; }
            set { _includeCoverageId = value; }
        }

        private HospitalizationIncludeCoverage _includeCoverageInfo;
        public HospitalizationIncludeCoverage IncludeCoverageInfo
        {
            get { return _includeCoverageInfo; }
            set { _includeCoverageInfo = value; }
        }

        private Decimal _includeAmount;
        public Decimal IncludeAmount
        {
            get { return _includeAmount; }
            set { _includeAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

    }

    [Serializable()]
    public class InHouseExcludeCoverage : BaseObject
    {
        public InHouseExcludeCoverage()
        {
            _excludeCoverageId = 0;
            _excludeCoverageInfo = new HospitalizationExcludeCoverage();
            _excludeAmount = 0.0M;
            _remarks = String.Empty;
        }

        public Boolean Equals(InHouseExcludeCoverage obj)
        {
            if (base.Equals<InHouseExcludeCoverage>(obj) &&
                _excludeCoverageInfo.Equals(obj.ExcludeCoverageInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _excludeCoverageId;
        public Int64 ExcludeCoverageId
        {
            get { return _excludeCoverageId; }
            set { _excludeCoverageId = value; }
        }

        private HospitalizationExcludeCoverage _excludeCoverageInfo;
        public HospitalizationExcludeCoverage ExcludeCoverageInfo
        {
            get { return _excludeCoverageInfo; }
            set { _excludeCoverageInfo = value; }
        }

        private Decimal _excludeAmount;
        public Decimal ExcludeAmount
        {
            get { return _excludeAmount; }
            set { _excludeAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

    }

    [Serializable()]
    public class HospitalizationDocument : BaseObject
    {
        public HospitalizationDocument()
        {
            _documentId = 0;
            _inHouseDebitInfo = new InHouseHospitalizationDebit();
            _filePath = String.Empty;
            _originalName = String.Empty;
            _documentInformation = String.Empty;
        }

        public Boolean Equals(HospitalizationDocument obj)
        {
            if (base.Equals<HospitalizationDocument>(obj) &&
                _inHouseDebitInfo.Equals(obj.InHouseDebitInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _documentId;
        public Int64 DocumentId
        {
            get { return _documentId; }
            set { _documentId = value; }
        }

        private InHouseHospitalizationDebit _inHouseDebitInfo;
        public InHouseHospitalizationDebit InHouseDebitInfo
        {
            get { return _inHouseDebitInfo; }
            set { _inHouseDebitInfo = value; }
        }

        private Byte[] _fileData;
        public Byte[] FileData
        {
            get { return _fileData; }
            set { _fileData = value; }
        }

        private String _filePath;
        public String FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private String _originalName;
        public String FileName
        {
            get { return _originalName; }
            set { _originalName = value; }
        }

        private String _documentInformation;
        public String DocumentInformation
        {
            get { return _documentInformation; }
            set { _documentInformation = value; }
        }
    }

    [Serializable()]
    public class RegularLoanPayments : BaseObject
    {
        public RegularLoanPayments()
        {
            _paymentId = 0;
            _regularLoanInfo = new RegularLoan();
            _reflectedDate = String.Empty;
            _receiptDate = String.Empty;
            _receivedDate = String.Empty;
            _receiptNo = String.Empty;
            _paymentAmount = 0.0M;
            _principalPaid = 0.0M;
            _interestPaid = 0.0M;
            _remarks = String.Empty;
            _amountTendered = 0.0M;
            _bank = String.Empty;
            _checkNo = String.Empty;
            _accountCreditInfo = new ChartOfAccount();
            _rebateAmount = 0.0M;
            _accountRebateInfo = new ChartOfAccount();
        }

        public Boolean Equals(RegularLoanPayments obj)
        {
            if (base.Equals<RegularLoanPayments>(obj) &&
                _regularLoanInfo.Equals(obj.RegularLoanInfo) &&
                _accountCreditInfo.Equals(obj.AccountCreditInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _paymentId;
        public Int64 PaymentId
        {
            get { return _paymentId; }
            set { _paymentId = value; }
        }

        private RegularLoan _regularLoanInfo;
        public RegularLoan RegularLoanInfo
        {
            get { return _regularLoanInfo; }
            set { _regularLoanInfo = value; }
        }

        private String _reflectedDate;
        public String ReflectedDate
        {
            get { return _reflectedDate; }
            set { _reflectedDate = value; }
        }

        private String _receiptDate;
        public String ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receivedDate;
        public String ReceivedDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receiptNo;
        public String ReceiptNo
        {
            get { return _receiptNo; }
            set { _receiptNo = value; }
        }

        private Decimal _paymentAmount;
        public Decimal PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }

        private Decimal _principalPaid;
        public Decimal PrincipalPaid
        {
            get { return _principalPaid; }
            set { _principalPaid = value; }
        }

        private Decimal _interestPaid;
        public Decimal InterestPaid
        {
            get { return _interestPaid; }
            set { _interestPaid = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Decimal _amountTendered;
        public Decimal AmountTendered
        {
            get { return _amountTendered; }
            set { _amountTendered = value; }
        }

        private String _bank;
        public String Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }

        private String _checkNo;
        public String CheckNo
        {
            get { return _checkNo; }
            set { _checkNo = value; }
        }

        private ChartOfAccount _accountCreditInfo;
        public ChartOfAccount AccountCreditInfo
        {
            get { return _accountCreditInfo; }
            set { _accountCreditInfo = value; }
        }

        private Decimal _rebateAmount;
        public Decimal RebateAmount
        {
            get { return _rebateAmount; }
            set { _rebateAmount = value; }
        }

        private ChartOfAccount _accountRebateInfo;
        public ChartOfAccount AccountRebateInfo
        {
            get { return _accountRebateInfo; }
            set { _accountRebateInfo = value; }
        }
    }

    [Serializable()]
    public class ShareCapitalCredit : BaseObject
    {
        public ShareCapitalCredit()
        {
            _capitalCreditId = 0;
            _memberInfo = new Member();
            _reflectedDate = String.Empty;
            _receiptDate = String.Empty;
            _receivedDate = String.Empty;
            _receiptNo = String.Empty;
            _creditAmount = 0.0M;
            _remarks = String.Empty;
            _amountTendered = 0.0M;
            _bank = String.Empty;
            _checkNo = String.Empty;
            _isMigratedEntry = false;
            _accountCreditInfo = new ChartOfAccount();
        }

        public Boolean Equals(ShareCapitalCredit obj)
        {
            if (base.Equals<ShareCapitalCredit>(obj) &&
                _memberInfo.Equals(obj.MemberInfo) &&
                _accountCreditInfo.Equals(obj.AccountCreditInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _capitalCreditId;
        public Int64 CapitalCreditId
        {
            get { return _capitalCreditId; }
            set { _capitalCreditId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _reflectedDate;
        public String ReflectedDate
        {
            get { return _reflectedDate; }
            set { _reflectedDate = value; }
        }

        private String _receiptDate;
        public String ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receivedDate;
        public String ReceivedDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receiptNo;
        public String ReceiptNo
        {
            get { return _receiptNo; }
            set { _receiptNo = value; }
        }

        private Decimal _creditAmount;
        public Decimal CreditAmount
        {
            get { return _creditAmount; }
            set { _creditAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Decimal _amountTendered;
        public Decimal AmountTendered
        {
            get { return _amountTendered; }
            set { _amountTendered = value; }
        }

        private String _bank;
        public String Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }

        private String _checkNo;
        public String CheckNo
        {
            get { return _checkNo; }
            set { _checkNo = value; }
        }

        private Boolean _isMigratedEntry;
        public Boolean IsMigratedEntry
        {
            get { return _isMigratedEntry; }
            set { _isMigratedEntry = value; }
        }

        private ChartOfAccount _accountCreditInfo;
        public ChartOfAccount AccountCreditInfo
        {
            get { return _accountCreditInfo; }
            set { _accountCreditInfo = value; }
        }
    }

    [Serializable()]
    public class MemberEquityCredit : BaseObject
    {
        public MemberEquityCredit()
        {
            _equityId = 0;
            _memberInfo = new Member();
            _reflectedDate = String.Empty;
            _receiptDate = String.Empty;
            _receivedDate = String.Empty;
            _receiptNo = String.Empty;
            _creditAmount = 0.0M;
            _remarks = String.Empty;
            _amountTendered = 0.0M;
            _bank = String.Empty;
            _checkNo = String.Empty;
            _isMigratedEntry = false;
            _accountCreditInfo = new ChartOfAccount();
        }

        public Boolean Equals(MemberEquityCredit obj)
        {
            if (base.Equals<MemberEquityCredit>(obj) &&
                _memberInfo.Equals(obj.MemberInfo) &&
                _accountCreditInfo.Equals(obj.AccountCreditInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _equityId;
        public Int64 EquityId
        {
            get { return _equityId; }
            set { _equityId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _reflectedDate;
        public String ReflectedDate
        {
            get { return _reflectedDate; }
            set { _reflectedDate = value; }
        }

        private String _receiptDate;
        public String ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receivedDate;
        public String ReceivedDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receiptNo;
        public String ReceiptNo
        {
            get { return _receiptNo; }
            set { _receiptNo = value; }
        }

        private Decimal _creditAmount;
        public Decimal CreditAmount
        {
            get { return _creditAmount; }
            set { _creditAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Decimal _amountTendered;
        public Decimal AmountTendered
        {
            get { return _amountTendered; }
            set { _amountTendered = value; }
        }

        private String _bank;
        public String Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }

        private String _checkNo;
        public String CheckNo
        {
            get { return _checkNo; }
            set { _checkNo = value; }
        }

        private Boolean _isMigratedEntry;
        public Boolean IsMigratedEntry
        {
            get { return _isMigratedEntry; }
            set { _isMigratedEntry = value; }
        }

        private ChartOfAccount _accountCreditInfo;
        public ChartOfAccount AccountCreditInfo
        {
            get { return _accountCreditInfo; }
            set { _accountCreditInfo = value; }
        }
    }

    [Serializable()]
    public class InHouseHospitalizationCredit : BaseObject
    {
        public InHouseHospitalizationCredit()
        {
            _hospitalizationCreditId = 0;
            _memberInfo = new Member();
            _reflectedDate = String.Empty;
            _receiptDate = String.Empty;
            _receivedDate = String.Empty;
            _receiptNo = String.Empty;
            _creditAmount = 0.0M;
            _remarks = String.Empty;
            _amountTendered = 0.0M;
            _bank = String.Empty;
            _checkNo = String.Empty;
            _accountCreditInfo = new ChartOfAccount();
        }

        public Boolean Equals(InHouseHospitalizationCredit obj)
        {
            if (base.Equals<InHouseHospitalizationCredit>(obj) &&
                _memberInfo.Equals(obj.MemberInfo) &&
                _accountCreditInfo.Equals(obj.AccountCreditInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _hospitalizationCreditId;
        public Int64 HospitalizationCreditId
        {
            get { return _hospitalizationCreditId; }
            set { _hospitalizationCreditId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _reflectedDate;
        public String ReflectedDate
        {
            get { return _reflectedDate; }
            set { _reflectedDate = value; }
        }

        private String _receiptDate;
        public String ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receivedDate;
        public String ReceivedDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receiptNo;
        public String ReceiptNo
        {
            get { return _receiptNo; }
            set { _receiptNo = value; }
        }

        private Decimal _creditAmount;
        public Decimal CreditAmount
        {
            get { return _creditAmount; }
            set { _creditAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Decimal _amountTendered;
        public Decimal AmountTendered
        {
            get { return _amountTendered; }
            set { _amountTendered = value; }
        }

        private String _bank;
        public String Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }

        private String _checkNo;
        public String CheckNo
        {
            get { return _checkNo; }
            set { _checkNo = value; }
        }

        private ChartOfAccount _accountCreditInfo;
        public ChartOfAccount AccountCreditInfo
        {
            get { return _accountCreditInfo; }
            set { _accountCreditInfo = value; }
        }
    }

    [Serializable()]
    public class MiscellaneousIncome : BaseObject
    {
        public MiscellaneousIncome()
        {
            _paymentId = 0;
            _receivedFrom = String.Empty;
            _memberInfo = new Member();
            _collectorInfo = new Collector();
            _reflectedDate = String.Empty;
            _receiptDate = String.Empty;
            _receivedDate = String.Empty;
            _receiptNo = String.Empty;
            _miscellaneousAmount = 0.0M;
            _remarks = String.Empty;
            _discountAmount = 0.0M;
            _amountTendered = 0.0M;
            _bank = String.Empty;
            _checkNo = String.Empty;
            _accountCreditInfo = new ChartOfAccount();
        }

        public Boolean Equals(MiscellaneousIncome obj)
        {
            if (base.Equals<MiscellaneousIncome>(obj) &&
                _memberInfo.Equals(obj.MemberInfo) &&
                _collectorInfo.Equals(obj.CollectorInfo) &&
                _accountCreditInfo.Equals(obj.AccountCreditInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _paymentId;
        public Int64 PaymentId
        {
            get { return _paymentId; }
            set { _paymentId = value; }
        }

        private String _receivedFrom;
        public String ReceivedFrom
        {
            get { return _receivedFrom; }
            set { _receivedFrom = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private Collector _collectorInfo;
        public Collector CollectorInfo
        {
            get { return _collectorInfo; }
            set { _collectorInfo = value; }
        }

        private String _reflectedDate;
        public String ReflectedDate
        {
            get { return _reflectedDate; }
            set { _reflectedDate = value; }
        }

        private String _receiptDate;
        public String ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receivedDate;
        public String ReceivedDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private String _receiptNo;
        public String ReceiptNo
        {
            get { return _receiptNo; }
            set { _receiptNo = value; }
        }

        private Decimal _miscellaneousAmount;
        public Decimal MiscellaneousAmount
        {
            get { return _miscellaneousAmount; }
            set { _miscellaneousAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Decimal _discountAmount;
        public Decimal DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }

        private Decimal _amountTendered;
        public Decimal AmountTendered
        {
            get { return _amountTendered; }
            set { _amountTendered = value; }
        }

        private String _bank;
        public String Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }

        private String _checkNo;
        public String CheckNo
        {
            get { return _checkNo; }
            set { _checkNo = value; }
        }

        private ChartOfAccount _accountCreditInfo;
        public ChartOfAccount AccountCreditInfo
        {
            get { return _accountCreditInfo; }
            set { _accountCreditInfo = value; }
        }
    }

    [Serializable()]
    public class BreakdownBankDeposit : BaseObject
    {
        public BreakdownBankDeposit()
        {
            _breakdownId = 0;
            _dateStart = String.Empty;
            _dateEnd = String.Empty;
            _amount = 0.0M;
            _accountInfo = new ChartOfAccount();
        }

        public Boolean Equals(BreakdownBankDeposit obj)
        {
            if (base.Equals<BreakdownBankDeposit>(obj) &&
                _accountInfo.Equals(obj.AccountInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _breakdownId;
        public Int64 BreakdownId
        {
            get { return _breakdownId; }
            set { _breakdownId = value; }
        }

        private String _dateStart;
        public String DateStart
        {
            get { return _dateStart; }
            set { _dateStart = value; }
        }

        private String _dateEnd;
        public String DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }

        private Decimal _amount;
        public Decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private ChartOfAccount _accountInfo;
        public ChartOfAccount AccountInfo
        {
            get { return _accountInfo; }
            set { _accountInfo = value; }
        }

    }    

    #endregion
}
