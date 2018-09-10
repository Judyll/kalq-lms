using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Collections;

namespace CommonExchange
{
    #region Common Structure Exchange

    [Serializable()]
    public class RegularLoanType : BaseObject
    {
        public RegularLoanType()
        {
            _regularLoanTypeId = String.Empty;
            _regularLoanTypeDescription = String.Empty;
            _regularLoanTypeNo = 0;
            _regularLoanTypeCode = String.Empty;
        }

        public Boolean Equals(RegularLoanType obj)
        {
            if (base.Equals<RegularLoanType>(obj))
            {
                return true;
            }

            return false;

        }

        private String _regularLoanTypeId;
        public String RegularLoanTypeId
        {
            get { return _regularLoanTypeId; }
            set { _regularLoanTypeId = value; }
        }

        private String _regularLoanTypeDescription;
        public String RegularLoanTypeDescription
        {
            get { return _regularLoanTypeDescription; }
            set { _regularLoanTypeDescription = value; }
        }

        private Byte _regularLoanTypeNo;
        public Byte RegularLoanTypeNo
        {
            get { return _regularLoanTypeNo; }
            set { _regularLoanTypeNo = value; }
        }

        private String _regularLoanTypeCode;
        public String RegularLoanTypeCode
        {
            get { return _regularLoanTypeCode; }
            set { _regularLoanTypeCode = value; }
        }

        public static String BirthdayLoanId
        {
            get { return "RLTID001"; }
        }

        public static Byte BirthdayLoanNo
        {
            get { return 1; }
        }

        public static String BirthdayLoanCode
        {
            get { return "BL"; }
        }

        public static String ContingencyLoanId
        {
            get { return "RLTID002"; }
        }

        public static Byte ContingencyLoanNo
        {
            get { return 2; }
        }

        public static String ContingencyLoanCode
        {
            get { return "CL"; }
        }

        public static String SalaryLoanId
        {
            get { return "RLTID003"; }
        }

        public static Byte SalaryLoanNo
        {
            get { return 3; }
        }

        public static String SalaryLoanCode
        {
            get { return "SL"; }
        }

        public static String MedicalLoanId
        {
            get { return "RLTID004"; }
        }

        public static Byte MedicalLoanNo
        {
            get { return 4; }
        }

        public static String MedicalLoanCode
        {
            get { return "ML"; }
        }

        public static String SpecialLoanId
        {
            get { return "RLTID005"; }
        }

        public static Byte SpecialLoanNo
        {
            get { return 5; }
        }

        public static String SpecialLoanCode
        {
            get { return "PL"; }
        }
    }

    [Serializable()]
    public class RepaymentSchedule : BaseObject
    {
        public RepaymentSchedule()
        {
            _repaymentId = String.Empty;
            _repaymentDescription = String.Empty;
            _paymentsPerYear = 0;
            _repaymentNo = 0;
        }

        public Boolean Equals(RepaymentSchedule obj)
        {
            if (base.Equals<RepaymentSchedule>(obj))
            {
                return true;
            }

            return false;

        }

        private String _repaymentId;
        public String RepaymentId
        {
            get { return _repaymentId; }
            set { _repaymentId = value; }
        }

        private String _repaymentDescription;
        public String RepaymentDescription
        {
            get { return _repaymentDescription; }
            set { _repaymentDescription = value; }
        }

        private Int16 _paymentsPerYear;
        public Int16 PaymentsPerYear
        {
            get { return _paymentsPerYear; }
            set { _paymentsPerYear = value; }
        }

        private Byte _repaymentNo;
        public Byte RepaymentNo
        {
            get { return _repaymentNo; }
            set { _repaymentNo = value; }
        }

        public static String DailyId
        {
            get { return "RPSID001"; }
        }

        public static Int16 DailyPaymentsPerYear
        {
            get { return 365; }
        }

        public static Byte DailyNo
        {
            get { return 1; }
        }

        public static String WeeklyId
        {
            get { return "RPSID002"; }
        }

        public static Int16 WeeklyPaymentsPerYear
        {
            get { return 52; }
        }

        public static Byte WeeklyNo
        {
            get { return 2; }
        }

        public static String BiWeeklyId
        {
            get { return "RPSID003"; }
        }

        public static Int16 BiWeeklyPaymentsPerYear
        {
            get { return 26; }
        }

        public static Byte BiWeeklyNo
        {
            get { return 3; }
        }

        public static String MonthlyId
        {
            get { return "RPSID004"; }
        }

        public static Int16 MonthlyPaymentsPerYear
        {
            get { return 12; }
        }

        public static Byte MonthlyNo
        {
            get { return 4; }
        }

        public static String QuarterlyId
        {
            get { return "RPSID005"; }
        }

        public static Int16 QuarterlyPaymentsPerYear
        {
            get { return 4; }
        }

        public static Byte QuarterlyNo
        {
            get { return 5; }
        }

        public static String SemiAnnualId
        {
            get { return "RPSID006"; }
        }

        public static Int16 SemiAnnualPaymentsPerYear
        {
            get { return 2; }
        }

        public static Byte SemiAnnualNo
        {
            get { return 6; }
        }

        public static String Annual
        {
            get { return "RPSID007"; }
        }

        public static Int16 AnnualPaymentsPerYear
        {
            get { return 1; }
        }

        public static Byte AnnualNo
        {
            get { return 7; }
        }
    }

    [Serializable()]
    public class RegularLoan : BaseObject
    {
        public RegularLoan()
        {
            _regularLoanSysId = String.Empty;
            _memberInfo = new Member();
            _accountNo = String.Empty;
            _loanAmount = 0.0M;
            _purposeOfLoan = String.Empty;
            _isProductive = false;
            _regularLoanTypeInfo = new RegularLoanType();
            _repaymentScheduleInfo = new RepaymentSchedule();
            _loanTerms = 0;
            _noPrepaidInterest = 0;
            _interestRate = 0.0F;
            _gracePeriod = 0;
            _isStraightLoan = false;
            _loanRequirements = String.Empty;
            _dateApplied = String.Empty;
            _dateApproved = String.Empty;
            _approvalEvaluation = String.Empty;
            _dateFirstPayment = String.Empty;
            _dateMaturity = String.Empty;
            _penaltyRate = 0.0F;
            _noDefaultPayment = 0;
            _remarks = String.Empty;
            _isMarkedDeleted = false;
            _isRecordLocked = false;
            _loanAmortizationList = new CloneableDictionaryList<RegularLoanAmortization>();
            _loanChargesList = new CloneableDictionaryList<RegularLoanCharges>();
            _loanAdditionsList = new CloneableDictionaryList<RegularLoanAdditions>();
        }

        public Boolean Equals(RegularLoan obj)
        {
            if (base.Equals<RegularLoan>(obj) &&
                _memberInfo.Equals(obj.MemberInfo) &&
                _regularLoanTypeInfo.Equals(obj.RegularLoanTypeInfo) &&
                _repaymentScheduleInfo.Equals(obj.RepaymentScheduleInfo) &&
                this.Equals(obj.LoanAmortizationList) &&
                this.Equals(obj.LoanChargesList) &&
                this.Equals(obj.LoanAdditionsList))
            {
                return true;
            }

            return false;
        }

        private Boolean Equals(CloneableDictionaryList<RegularLoanAmortization> list)
        {
            Int32 i = 0;

            foreach (RegularLoanAmortization loanAmortization in _loanAmortizationList)
            {
                if ((i < list.Count) && (!loanAmortization.Equals(list[i])))
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

        private Boolean Equals(CloneableDictionaryList<RegularLoanCharges> list)
        {
            Int32 i = 0;

            foreach (RegularLoanCharges loanCharges in _loanChargesList)
            {
                if ((i < list.Count) && (!loanCharges.Equals(list[i])))
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

        private Boolean Equals(CloneableDictionaryList<RegularLoanAdditions> list)
        {
            Int32 i = 0;

            foreach (RegularLoanAdditions loanAdditions in _loanAdditionsList)
            {
                if ((i < list.Count) && (!loanAdditions.Equals(list[i])))
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

        private String _regularLoanSysId;
        public String RegularLoanSysId
        {
            get { return _regularLoanSysId; }
            set { _regularLoanSysId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _accountNo;
        public String AccountNo
        {
            get { return _accountNo; }
            set { _accountNo = value; }
        }

        private Decimal _loanAmount;
        public Decimal LoanAmount
        {
            get { return _loanAmount; }
            set { _loanAmount = value; }
        }

        private String _purposeOfLoan;
        public String PurposeOfLoan
        {
            get { return _purposeOfLoan; }
            set { _purposeOfLoan = value; }
        }

        private Boolean _isProductive;
        public Boolean IsProductive
        {
            get { return _isProductive; }
            set { _isProductive = value; }
        }

        private RegularLoanType _regularLoanTypeInfo;
        public RegularLoanType RegularLoanTypeInfo
        {
            get { return _regularLoanTypeInfo; }
            set { _regularLoanTypeInfo = value; }
        }

        private RepaymentSchedule _repaymentScheduleInfo;
        public RepaymentSchedule RepaymentScheduleInfo
        {
            get { return _repaymentScheduleInfo; }
            set { _repaymentScheduleInfo = value; }
        }

        private Int16 _loanTerms;
        public Int16 LoanTerms
        {
            get { return _loanTerms; }
            set { _loanTerms = value; }
        }

        private Int16 _noPrepaidInterest;
        public Int16 NoPrepaidInterest
        {
            get { return _noPrepaidInterest; }
            set { _noPrepaidInterest = value; }
        }

        private Single _interestRate;
        public Single InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        private Byte _gracePeriod;
        public Byte GracePeriod
        {
            get { return _gracePeriod; }
            set { _gracePeriod = value; }
        }

        public Boolean _isStraightLoan;
        public Boolean IsStraightLoan
        {
            get { return _isStraightLoan; }
            set { _isStraightLoan = value; }
        }

        private String _loanRequirements;
        public String LoanRequirements
        {
            get { return _loanRequirements; }
            set { _loanRequirements = value; }
        }

        private String _dateApplied;
        public String DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; }
        }

        private String _dateApproved;
        public String DateApproved
        {
            get { return _dateApproved; }
            set { _dateApproved = value; }
        }

        private String _approvalEvaluation;
        public String ApprovalEvaluation
        {
            get { return _approvalEvaluation; }
            set { _approvalEvaluation = value; }
        }

        private String _dateFirstPayment;
        public String DateFirstPayment
        {
            get { return _dateFirstPayment; }
            set { _dateFirstPayment = value; }
        }

        private String _dateMaturity;
        public String DateMaturity
        {
            get { return _dateMaturity; }
            set { _dateMaturity = value; }
        }

        private Single _penaltyRate;
        public Single PenaltyRate
        {
            get { return _penaltyRate; }
            set { _penaltyRate = value; }
        }

        private Byte _noDefaultPayment;
        public Byte NoDefaultPayment
        {
            get { return _noDefaultPayment; }
            set { _noDefaultPayment = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Boolean _isMarkedDeleted;
        public Boolean IsMarkedDeleted
        {
            get { return _isMarkedDeleted; }
            set { _isMarkedDeleted = value; }
        }

        private Boolean _isRecordLocked;
        public Boolean IsRecordLocked
        {
            get { return _isRecordLocked; }
            set { _isRecordLocked = value; }
        }

        private CloneableDictionaryList<RegularLoanAmortization> _loanAmortizationList;
        public CloneableDictionaryList<RegularLoanAmortization> LoanAmortizationList
        {
            get { return _loanAmortizationList; }
            set { _loanAmortizationList = value; }
        }

        private CloneableDictionaryList<RegularLoanCharges> _loanChargesList;
        public CloneableDictionaryList<RegularLoanCharges> LoanChargesList
        {
            get { return _loanChargesList; }
            set { _loanChargesList = value; }
        }

        private CloneableDictionaryList<RegularLoanAdditions> _loanAdditionsList;
        public CloneableDictionaryList<RegularLoanAdditions> LoanAdditionsList
        {
            get { return _loanAdditionsList; }
            set { _loanAdditionsList = value; }
        }

        /// <summary>
        /// If the RegularLoanSysId is NULL or Empty, a TEMP folder is created
        /// </summary>
        /// <param name="startUpPath"></param>
        /// <returns></returns>
        public String RegularLoanDocumentsFolder(String startUpPath)
        {
            return SystemConfiguration.ApplicationDocumentsFolder(startUpPath) + @"\" +
                (!String.IsNullOrEmpty(_regularLoanSysId) ? _regularLoanSysId : "Temp") + @"\RegularLoanDocuments\";
        }

    }

    [Serializable()]
    public class RegularLoanAmortization : BaseObject
    {
        public RegularLoanAmortization()
        {
            _amortizationId = 0;
            _paymentNo = 0;
            _paymentDateFrom = String.Empty;
            _paymentDateTo = String.Empty;
            _paymentDateGracePeriod = String.Empty;
            _interestRate = 0.0F;
            _balanceBeginning = 0.0M;
            _paymentAmount = 0.0M;
            _principalPaid = 0.0M;
            _interestPaid = 0.0M;
            _balanceEnding = 0.0M;
            _penaltyRate = 0.0F;
            _isManuallyComputed = false;
            _remarks = String.Empty;            
        }

        public Boolean Equals(RegularLoanAmortization obj)
        {
            if (base.Equals<RegularLoanAmortization>(obj))
            {
                return true;
            }

            return false;
        }

        private Int64 _amortizationId;
        public Int64 AmortizationId
        {
            get { return _amortizationId; }
            set { _amortizationId = value; }
        }

        private Int16 _paymentNo;
        public Int16 PaymentNo
        {
            get { return _paymentNo; }
            set { _paymentNo = value; }
        }

        private String _paymentDateFrom;
        public String PaymentDateFrom
        {
            get { return _paymentDateFrom; }
            set { _paymentDateFrom = value; }
        }

        private String _paymentDateTo;
        public String PaymentDateTo
        {
            get { return _paymentDateTo; }
            set { _paymentDateTo = value; }
        }

        private String _paymentDateGracePeriod;
        public String PaymentDateGracePeriod
        {
            get { return _paymentDateGracePeriod; }
            set { _paymentDateGracePeriod = value; }
        }

        private Single _interestRate;
        public Single InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        private Decimal _balanceBeginning;
        public Decimal BalanceBeginning
        {
            get { return _balanceBeginning; }
            set { _balanceBeginning = value; }
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

        private Decimal _balanceEnding;
        public Decimal BalanceEnding
        {
            get { return _balanceEnding; }
            set { _balanceEnding = value; }
        }

        private Single _penaltyRate;
        public Single PenaltyRate
        {
            get { return _penaltyRate; }
            set { _penaltyRate = value; }
        }

        private Boolean _isManuallyComputed;
        public Boolean IsManuallyComputed
        {
            get { return _isManuallyComputed; }
            set { _isManuallyComputed = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

    }

    [Serializable()]
    public class RegularLoanCharges : BaseObject
    {
        public RegularLoanCharges()
        {
            _regularChargesId = 0;
            _accountInfo = new ChartOfAccount();
            _chargeAmount = 0.0M;
            _chargeDescription = String.Empty;            
        }

        public Boolean Equals(RegularLoanCharges obj)
        {
            if (base.Equals<RegularLoanCharges>(obj) &&
                _accountInfo.Equals(obj.AccountInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _regularChargesId;
        public Int64 RegularChargesId
        {
            get { return _regularChargesId; }
            set { _regularChargesId = value; }
        }

        private ChartOfAccount _accountInfo;
        public ChartOfAccount AccountInfo
        {
            get { return _accountInfo; }
            set { _accountInfo = value; }
        }

        private Decimal _chargeAmount;
        public Decimal ChargeAmount
        {
            get { return _chargeAmount; }
            set { _chargeAmount = value; }
        }

        private String _chargeDescription;
        public String ChargeDescription
        {
            get { return _chargeDescription; }
            set { _chargeDescription = value; }
        }

    }

    [Serializable()]
    public class RegularLoanAdditions : BaseObject
    {
        public RegularLoanAdditions()
        {
            _regularAdditionsId = 0;
            _accountInfo = new ChartOfAccount();
            _additionAmount = 0.0M;
            _additionDescription = String.Empty;
        }

        public Boolean Equals(RegularLoanAdditions obj)
        {
            if (base.Equals<RegularLoanAdditions>(obj) &&
                _accountInfo.Equals(obj.AccountInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _regularAdditionsId;
        public Int64 RegularAdditionsId
        {
            get { return _regularAdditionsId; }
            set { _regularAdditionsId = value; }
        }

        private ChartOfAccount _accountInfo;
        public ChartOfAccount AccountInfo
        {
            get { return _accountInfo; }
            set { _accountInfo = value; }
        }

        private Decimal _additionAmount;
        public Decimal AdditionAmount
        {
            get { return _additionAmount; }
            set { _additionAmount = value; }
        }

        private String _additionDescription;
        public String AdditionDescription
        {
            get { return _additionDescription; }
            set { _additionDescription = value; }
        }

    }

    [Serializable()]
    public class RegularLoanDocument : BaseObject
    {
        public RegularLoanDocument()
        {
            _documentId = 0;
            _regularLoanInfo = new RegularLoan();
            _filePath = String.Empty;
            _originalName = String.Empty;
            _documentInformation = String.Empty;
        }

        public Boolean Equals(RegularLoanDocument obj)
        {
            if (base.Equals<RegularLoanDocument>(obj) &&
                _regularLoanInfo.Equals(obj.RegularLoanInfo))
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

        private RegularLoan _regularLoanInfo;
        public RegularLoan RegularLoanInfo
        {
            get { return _regularLoanInfo; }
            set { _regularLoanInfo = value; }
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
    public class Collateral : BaseObject
    {
        public Collateral()
        {
            _collateralSysId = String.Empty;
            _memberInfo = new Member();
            _propertyType = String.Empty;
            _propertyBrand = String.Empty;
            _serialNo = String.Empty;
            _purchasePrice = 0.0M;
            _yearPurchased = String.Empty;
            _estimatedAppraisedValue = 0.0M;
            _remarks = String.Empty;
            _isMarkedDeleted = false;
        }

        public Boolean Equals(Collateral obj)
        {
            if (base.Equals<Collateral>(obj) &&
                _memberInfo.Equals(obj.MemberInfo))
            {
                return true;
            }

            return false;
        }

        private String _collateralSysId;
        public String CollateralSysId
        {
            get { return _collateralSysId; }
            set { _collateralSysId = value; }
        }

        private Member _memberInfo;
        public Member MemberInfo
        {
            get { return _memberInfo; }
            set { _memberInfo = value; }
        }

        private String _propertyType;
        public String PropertyType
        {
            get { return _propertyType; }
            set { _propertyType = value; }
        }

        private String _propertyBrand;
        public String PropertyBrand
        {
            get { return _propertyBrand; }
            set { _propertyBrand = value; }
        }

        private String _serialNo;
        public String SerialNo
        {
            get { return _serialNo; }
            set { _serialNo = value; }
        }

        private Decimal _purchasePrice;
        public Decimal PurchasePrice
        {
            get { return _purchasePrice; }
            set { _purchasePrice = value; }
        }

        private String _yearPurchased;
        public String YearPurchased
        {
            get { return _yearPurchased; }
            set { _yearPurchased = value; }
        }

        private Decimal _estimatedAppraisedValue;
        public Decimal EstimatedAppraisedValue
        {
            get { return _estimatedAppraisedValue; }
            set { _estimatedAppraisedValue = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private Boolean _isMarkedDeleted;
        public Boolean IsMarkedDeleted
        {
            get { return _isMarkedDeleted; }
            set { _isMarkedDeleted = value; }
        }
    }

    [Serializable()]
    public class RegularLoanCollateral : BaseObject
    {
        public RegularLoanCollateral()
        {
            _loanCollateralId = 0;
            _regularLoanInfo = new RegularLoan();
            _collateralInfo = new Collateral();
        }

        public Boolean Equals(RegularLoanCollateral obj)
        {
            if (base.Equals<RegularLoanCollateral>(obj) &&
                _regularLoanInfo.Equals(obj.RegularLoanInfo) &&
                _collateralInfo.Equals(obj.CollateralInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _loanCollateralId;
        public Int64 LoanCollateralId
        {
            get { return _loanCollateralId; }
            set { _loanCollateralId = value; }
        }

        private RegularLoan _regularLoanInfo;
        public RegularLoan RegularLoanInfo
        {
            get { return _regularLoanInfo; }
            set { _regularLoanInfo = value; }
        }

        private Collateral _collateralInfo;
        public Collateral CollateralInfo
        {
            get { return _collateralInfo; }
            set { _collateralInfo = value; }
        }
    }

    [Serializable()]
    public class RegularLoanCoMaker : BaseObject
    {
        public RegularLoanCoMaker()
        {
            _coMakerId = 0;
            _regularLoanInfo = new RegularLoan();
            _coMakerMemberInfo = new Member();
            _remarks = String.Empty;
        }

        public Boolean Equals(RegularLoanCoMaker obj)
        {
            if (base.Equals<RegularLoanCoMaker>(obj) &&
                _regularLoanInfo.Equals(obj.RegularLoanInfo) &&
                _coMakerMemberInfo.Equals(obj.CoMakerMemberInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _coMakerId;
        public Int64 CoMakerId
        {
            get { return _coMakerId; }
            set { _coMakerId = value; }
        }

        private RegularLoan _regularLoanInfo;
        public RegularLoan RegularLoanInfo
        {
            get { return _regularLoanInfo; }
            set { _regularLoanInfo = value; }
        }

        private Member _coMakerMemberInfo;
        public Member CoMakerMemberInfo
        {
            get { return _coMakerMemberInfo; }
            set { _coMakerMemberInfo = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
    }

    [Serializable()]
    public class OtherCreditor : BaseObject
    {
        public OtherCreditor()
        {
            _otherCreditorId = 0;
            _creditorName = String.Empty;
            _dateDue = String.Empty;
            _repaymentScheduleInfo = new RepaymentSchedule();
            _amountOwned = 0.0M;
            _amortizationAmount = 0.0M;
            _remarks = String.Empty;
        }

        public Boolean Equals(OtherCreditor obj)
        {
            if (base.Equals<OtherCreditor>(obj) &&
                _repaymentScheduleInfo.Equals(obj.RepaymentScheduleInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _otherCreditorId;
        public Int64 OtherCreditorId
        {
            get { return _otherCreditorId; }
            set { _otherCreditorId = value; }
        }

        private String _creditorName;
        public String CreditorName
        {
            get { return _creditorName; }
            set { _creditorName = value; }
        }

        private String _dateDue;
        public String DateDue
        {
            get { return _dateDue; }
            set { _dateDue = value; }
        }

        private RepaymentSchedule _repaymentScheduleInfo;
        public RepaymentSchedule RepaymentScheduleInfo
        {
            get { return _repaymentScheduleInfo; }
            set { _repaymentScheduleInfo = value; }
        }

        private Decimal _amountOwned;
        public Decimal AmountOwned
        {
            get { return _amountOwned; }
            set { _amountOwned = value; }
        }

        private Decimal _amortizationAmount;
        public Decimal AmortizationAmount
        {
            get { return _amortizationAmount; }
            set { _amortizationAmount = value; }
        }

        private String _remarks;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
    }

    #endregion
}
