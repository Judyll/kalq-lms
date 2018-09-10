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
    public class CompanyInformation
    {
        private CompanyInformation() { }

        public static String CompanyName
        {
            get { return "Dumaguete City Government Employees General Welfare Association, Inc."; }
        }

        public static String CompanyAcronym
        {
            get { return "DCGEGWA, INC."; }
        }

        public static String Address
        {
            get { return "City Hall Building, Dumaguete City"; }
        }

        public static String Province
        {
            get { return "Negros Oriental, Philippines"; }
        }

        public static String PhoneNos
        {
            get { return "(035) 225-2210"; }
        }

        public static String Manager
        {
            get { return "Mr. Jesus G. Cornelia"; }
        }

        public static String LicenseExpire
        {
            get { return "07/16/2050"; }
        }
    }

    [Serializable()]
    public class CodeEntityId
    {
        private CodeEntityId() { }

        public static String Gender
        {
            get { return "ETID001"; }
        }

        public static String MaritalStatus
        {
            get { return "ETID002"; }
        }

        public static String LifeStatus
        {
            get { return "ETID003"; }
        }

        public static String AppointmentStatus
        {
            get { return "ETID004"; }
        }    
    }

    [Serializable()]
    public class CodeReference : BaseObject
    {
        public CodeReference()
        {
            _codeReferenceId = String.Empty;
            _codeEntityId = String.Empty;
            _referenceCode = String.Empty;
            _codeDescription = String.Empty;
            _referenceFlag = 0;
        }

        public Boolean Equals(CodeReference obj)
        {
            if (base.Equals<CodeReference>(obj))
            {
                return true;
            }

            return false;

        }

        private String _codeReferenceId;
        public String CodeReferenceId
        {
            get { return _codeReferenceId; }
            set { _codeReferenceId = value; }
        }

        private String _codeEntityId;
        public String CodeEntityId
        {
            get { return _codeEntityId; }
            set { _codeEntityId = value; }
        }

        private String _referenceCode;
        public String ReferenceCode
        {
            get { return _referenceCode; }
            set { _referenceCode = value; }
        }

        private String _codeDescription;
        public String CodeDescription
        {
            get { return _codeDescription; }
            set { _codeDescription = value; }
        }

        private Byte _referenceFlag;
        public Byte ReferenceFlag
        {
            get { return _referenceFlag; }
            set { _referenceFlag = value; }
        }
        
    }

    [Serializable()]
    public class RelationshipType : BaseObject
    {
        public RelationshipType()
        {
            _relationshipTypeId = String.Empty;
            _relationshipDescription = String.Empty;
            _isParent = false;
            _isSpouse = false;
            _isSibling = false;
            _isInLaw = false;
            _isBloodLine = false;
            _isFriend = false;

        }

        public Boolean Equals(RelationshipType obj)
        {
            if (base.Equals<RelationshipType>(obj))
            {
                return true;
            }

            return false;
        }

        private String _relationshipTypeId;
        public String RelationshipTypeId
        {
            get { return _relationshipTypeId; }
            set { _relationshipTypeId = value; }
        }

        private String _relationshipDescription;
        public String RelationshipDescription
        {
            get { return _relationshipDescription; }
            set { _relationshipDescription = value; }
        }

        private Boolean _isParent;
        public Boolean IsParent
        {
            get { return _isParent; }
            set { _isParent = value; }
        }

        private Boolean _isSpouse;
        public Boolean IsSpouse
        {
            get { return _isSpouse; }
            set { _isSpouse = value; }
        }

        private Boolean _isSibling;
        public Boolean IsSibling
        {
            get { return _isSibling; }
            set { _isSibling = value; }
        }

        private Boolean _isInLaw;
        public Boolean IsInLaw
        {
            get { return _isInLaw; }
            set { _isInLaw = value; }
        }

        private Boolean _isBloodLine;
        public Boolean IsBloodLine
        {
            get { return _isBloodLine; }
            set { _isBloodLine = value; }
        }

        private Boolean _isFriend;
        public Boolean IsFriend
        {
            get { return _isFriend; }
            set { _isFriend = value; }
        }
    }

    [Serializable()]
    public class OfficeEmployer : BaseObject
    {
        public OfficeEmployer()
        {
            _officeEmployerId = String.Empty;
            _officeEmployerName = String.Empty;
            _officeEmployerAcronym = String.Empty;
            _officeeEmployerAddress = String.Empty;
            _officeEmployerPhoneNos = String.Empty;
            _isMarkedDeleted = false;
        }

        public Boolean Equals(OfficeEmployer obj)
        {
            if (base.Equals<OfficeEmployer>(obj))
            {
                return true;
            }

            return false;
        }

        private String _officeEmployerId;
        public String OfficeEmployerId
        {
            get { return _officeEmployerId; }
            set { _officeEmployerId = value; }
        }

        private String _officeEmployerName;
        public String OfficeEmployerName
        {
            get { return _officeEmployerName; }
            set { _officeEmployerName = value; }
        }

        private String _officeEmployerAcronym;
        public String OfficeEmployerAcronym
        {
            get { return _officeEmployerAcronym; }
            set { _officeEmployerAcronym = value; }
        }

        private String _officeeEmployerAddress;
        public String OfficeEmployerAddress
        {
            get { return _officeeEmployerAddress; }
            set { _officeeEmployerAddress = value; }
        }

        private String _officeEmployerPhoneNos;
        public String OfficeEmployerPhoneNos
        {
            get { return _officeEmployerPhoneNos; }
            set { _officeEmployerPhoneNos = value; }
        }

        private Boolean _isMarkedDeleted;
        public Boolean IsMarkedDeleted
        {
            get { return _isMarkedDeleted; }
            set { _isMarkedDeleted = value; }
        }
    }

    [Serializable()]
    public class Person : BaseObject
    {
        public Person()
        {
            _personSysId = String.Empty;
            _lastName = String.Empty;
            _firstName = String.Empty;
            _middleName = String.Empty;
            _lifeStatusCode = new CodeReference();
            _genderCode = new CodeReference();
            _birthDate = String.Empty;
            _placeOfBirth = String.Empty;
            _eMailAddress = String.Empty;
            _presentAddress = String.Empty;
            _presentPhoneNos = String.Empty;
            _homeAddress = String.Empty;
            _homePhoneNos = String.Empty;
            _houseOwnershipInformation = String.Empty;
            _citizenship = String.Empty;
            _nationality = String.Empty;
            _religion = String.Empty;
            _educationalAttainment = String.Empty;
            _specialSkills = String.Empty;
            _maritalStatusCode = new CodeReference();
            _marriageDate = String.Empty;
            _noOfDependents = 0;
            _occupation = String.Empty;
            _officeEmployerInfo = new OfficeEmployer();
            _appointmentStatusCode = new CodeReference();
            _employmentDate = String.Empty;
            _yearsOfService = 0;
            _salaryIncome = 0.0M;
            _otherIncomeSource = String.Empty;
            _totalMonthlyExpenses = 0.0M;
            _netDisposableIncome = 0.0M;
            _otherPersonInformation = String.Empty;
            _forMember = false;
            _forCollector = false;
            _forLogin = false;
            _personBeneficiaryList = new CloneableDictionaryList<PersonBeneficiary>();
            _personReferenceList = new CloneableDictionaryList<PersonReference>();
            _personSpouseList = new CloneableDictionaryList<PersonSpouse>();
        }

        public Boolean Equals(Person obj)
        {
            if (base.Equals<Person>(obj) &&
                _lifeStatusCode.Equals(obj.LifeStatusCode) &&
                _genderCode.Equals(obj.GenderCode) &&
                _maritalStatusCode.Equals(obj.MaritalStatusCode) &&
                _officeEmployerInfo.Equals(obj.OfficeEmployerInfo) &&
                _appointmentStatusCode.Equals(obj.AppointmentStatusCode) &&
                this.Equals(obj.PersonBeneficiaryList) &&
                this.Equals(obj.PersonReferenceList) &&
                this.Equals(obj.PersonSpouseList))
            {
                return true;
            }

            return false;
        }

        private Boolean Equals(CloneableDictionaryList<PersonBeneficiary> list)
        {
            Int32 i = 0;

            foreach (PersonBeneficiary pBeneficiary in _personBeneficiaryList)
            {
                if ((i < list.Count) && (!pBeneficiary.Equals(list[i])))
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

        private Boolean Equals(CloneableDictionaryList<PersonReference> list)
        {
            Int32 i = 0;

            foreach (PersonReference pReference in _personReferenceList)
            {
                if ((i < list.Count) && (!pReference.Equals(list[i])))
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

        private Boolean Equals(CloneableDictionaryList<PersonSpouse> list)
        {
            Int32 i = 0;

            foreach (PersonSpouse pSpouse in _personSpouseList)
            {
                if ((i < list.Count) && (!pSpouse.Equals(list[i])))
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

        private String _personSysId;
        public String PersonSysId
        {
            get { return _personSysId; }
            set { _personSysId = value; }
        }

        private String _lastName;
        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private String _firstName;
        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private String _middleName;
        public String MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        private CodeReference _lifeStatusCode;
        public CodeReference LifeStatusCode
        {
            get { return _lifeStatusCode; }
            set { _lifeStatusCode = value; }
        }

        private CodeReference _genderCode;
        public CodeReference GenderCode
        {
            get { return _genderCode; }
            set { _genderCode = value; }
        }

        private String _birthDate;
        public String BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private String _placeOfBirth;
        public String PlaceOfBirth
        {
            get { return _placeOfBirth; }
            set { _placeOfBirth = value; }
        }

        private String _eMailAddress;
        public String EMailAddress
        {
            get { return _eMailAddress; }
            set { _eMailAddress = value; }
        }

        private String _presentAddress;
        public String PresentAddress
        {
            get { return _presentAddress; }
            set { _presentAddress = value; }
        }

        private String _presentPhoneNos;
        public String PresentPhoneNos
        {
            get { return _presentPhoneNos; }
            set { _presentPhoneNos = value; }
        }

        private String _homeAddress;
        public String HomeAddress
        {
            get { return _homeAddress; }
            set { _homeAddress = value; }
        }

        private String _homePhoneNos;
        public String HomePhoneNos
        {
            get { return _homePhoneNos; }
            set { _homePhoneNos = value; }
        }

        private String _houseOwnershipInformation;
        public String HouseOwnershipInformation
        {
            get { return _houseOwnershipInformation; }
            set { _houseOwnershipInformation = value; }
        }

        private String _citizenship;
        public String Citizenship
        {
            get { return _citizenship; }
            set { _citizenship = value; }
        }

        private String _nationality;
        public String Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        private String _religion;
        public String Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }

        private String _educationalAttainment;
        public String EducationalAttainment
        {
            get { return _educationalAttainment; }
            set { _educationalAttainment = value; }
        }

        private String _specialSkills;
        public String SpecialSkills
        {
            get { return _specialSkills; }
            set { _specialSkills = value; }
        }

        private CodeReference _maritalStatusCode;
        public CodeReference MaritalStatusCode
        {
            get { return _maritalStatusCode; }
            set { _maritalStatusCode = value; }
        }

        private String _marriageDate;
        public String MarriageDate
        {
            get { return _marriageDate; }
            set { _marriageDate = value; }
        }

        private Byte _noOfDependents;
        public Byte NoOfDependents
        {
            get { return _noOfDependents; }
            set { _noOfDependents = value; }
        }

        private String _occupation;
        public String Occupation
        {
            get { return _occupation; }
            set { _occupation = value; }
        }

        private OfficeEmployer _officeEmployerInfo;
        public OfficeEmployer OfficeEmployerInfo
        {
            get { return _officeEmployerInfo; }
            set { _officeEmployerInfo = value; }
        }

        private CodeReference _appointmentStatusCode;
        public CodeReference AppointmentStatusCode
        {
            get { return _appointmentStatusCode; }
            set { _appointmentStatusCode = value; }
        }

        private String _employmentDate;
        public String EmploymentDate
        {
            get { return _employmentDate; }
            set { _employmentDate = value; }
        }

        private Byte _yearsOfService;
        public Byte YearsOfService
        {
            get { return _yearsOfService; }
            set { _yearsOfService = value; }
        }

        private Decimal _salaryIncome;
        public Decimal SalaryIncome
        {
            get { return _salaryIncome; }
            set { _salaryIncome = value; }
        }

        private String _otherIncomeSource;
        public String OtherIncomeSource
        {
            get { return _otherIncomeSource; }
            set { _otherIncomeSource = value; }
        }

        private Decimal _totalMonthlyExpenses;
        public Decimal TotalMonthlyExpenses
        {
            get { return _totalMonthlyExpenses; }
            set { _totalMonthlyExpenses = value; }
        }

        private Decimal _netDisposableIncome;
        public Decimal NetDisposableIncome
        {
            get { return _netDisposableIncome; }
            set { _netDisposableIncome = value; }
        }

        private String _otherPersonInformation;
        public String OtherPersonInformation
        {
            get { return _otherPersonInformation; }
            set { _otherPersonInformation = value; }
        }

        private Boolean _forMember;
        public Boolean ForMember
        {
            get { return _forMember; }
            set { _forMember = value; }
        }

        private Boolean _forCollector;
        public Boolean ForCollector
        {
            get { return _forCollector; }
            set { _forCollector = value; }
        }

        private Boolean _forLogin;
        public Boolean ForLogin
        {
            get { return _forLogin; }
            set { _forLogin = value; }
        }

        private CloneableDictionaryList<PersonBeneficiary> _personBeneficiaryList;
        public CloneableDictionaryList<PersonBeneficiary> PersonBeneficiaryList
        {
            get { return _personBeneficiaryList; }
            set { _personBeneficiaryList = value; }
        }

        private CloneableDictionaryList<PersonReference> _personReferenceList;
        public CloneableDictionaryList<PersonReference> PersonReferenceList
        {
            get { return _personReferenceList; }
            set { _personReferenceList = value; }
        }

        private CloneableDictionaryList<PersonSpouse> _personSpouseList;
        public CloneableDictionaryList<PersonSpouse> PersonSpouseList
        {
            get { return _personSpouseList; }
            set { _personSpouseList = value; }
        }

        /// <summary>
        /// If the PersonSysId is NULL or Empty, a TEMP folder is created
        /// </summary>
        /// <param name="startUpPath"></param>
        /// <returns></returns>
        public String PersonDocumentsFolder(String startUpPath)
        {
            return SystemConfiguration.ApplicationDocumentsFolder(startUpPath) + @"\" +
                (!String.IsNullOrEmpty(_personSysId) ? _personSysId : "Temp") + @"\PersonDocuments\";
        }
    }

    [Serializable()]
    public class PersonDocument : BaseObject
    {
        public PersonDocument()
        {
            _documentId = 0;
            _personInfo = new Person();
            _filePath = String.Empty;
            _originalName = String.Empty;
            _documentInformation = String.Empty;
            _isPrimaryImage = false;
        }

        public Boolean Equals(PersonDocument obj)
        {
            if (base.Equals<PersonDocument>(obj) &&
                _personInfo.Equals(obj.PersonInfo))
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

        private Person _personInfo;
        public Person PersonInfo
        {
            get { return _personInfo; }
            set { _personInfo = value; }
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

        private Boolean _isPrimaryImage;
        public Boolean IsPrimaryImage
        {
            get { return _isPrimaryImage; }
            set { _isPrimaryImage = value; }
        }

    }

    [Serializable()]
    public class PersonBeneficiary : BaseObject
    {
        public PersonBeneficiary()
        {
            _beneficiaryId = 0;
            _personInRelationshipWith = new Person();
            _relationshipTypeInfo = new RelationshipType();
            _isPrimaryBeneficiary = false;
        }

        public Boolean Equals(PersonBeneficiary obj)
        {
            if (base.Equals<PersonBeneficiary>(obj) &&
                _personInRelationshipWith.Equals(obj.PersonInRelationshipWith) &&
                _relationshipTypeInfo.Equals(obj.RelationshipTypeInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _beneficiaryId;
        public Int64 BeneficiaryId
        {
            get { return _beneficiaryId; }
            set { _beneficiaryId = value; }
        }

        private Person _personInRelationshipWith;
        public Person PersonInRelationshipWith
        {
            get { return _personInRelationshipWith; }
            set { _personInRelationshipWith = value; }
        }

        private RelationshipType _relationshipTypeInfo;
        public RelationshipType RelationshipTypeInfo
        {
            get { return _relationshipTypeInfo; }
            set { _relationshipTypeInfo = value; }
        }

        private Boolean _isPrimaryBeneficiary;
        public Boolean IsPrimaryBeneficiary
        {
            get { return _isPrimaryBeneficiary; }
            set { _isPrimaryBeneficiary = value; }
        }

    }

    [Serializable()]
    public class PersonReference : BaseObject
    {
        public PersonReference()
        {
            _referenceId = 0;
            _personInReferenceWith = new Person();
        }

        public Boolean Equals(PersonReference obj)
        {
            if (base.Equals<PersonReference>(obj))
            {
                return true;
            }

            return false;
        }

        private Int64 _referenceId;
        public Int64 ReferenceId
        {
            get { return _referenceId; }
            set { _referenceId = value; }
        }

        private Person _personInReferenceWith;
        public Person PersonInReferenceWith
        {
            get { return _personInReferenceWith; }
            set { _personInReferenceWith = value; }
        }

    }

    [Serializable()]
    public class PersonSpouse : BaseObject
    {
        public PersonSpouse()
        {
            _spouseId = 0;
            _personInSpouseWith = new Person();
            _relationshipTypeInfo = new RelationshipType();
            _isStillASpouse = false;            
        }

        public Boolean Equals(PersonSpouse obj)
        {
            if (base.Equals<PersonSpouse>(obj) &&
                _personInSpouseWith.Equals(obj.PersonInSpouseWith) &&
                _relationshipTypeInfo.Equals(obj.RelationshipTypeInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _spouseId;
        public Int64 SpouseId
        {
            get { return _spouseId; }
            set { _spouseId = value; }
        }

        private Person _personInSpouseWith;
        public Person PersonInSpouseWith
        {
            get { return _personInSpouseWith; }
            set { _personInSpouseWith = value; }
        }

        private RelationshipType _relationshipTypeInfo;
        public RelationshipType RelationshipTypeInfo
        {
            get { return _relationshipTypeInfo; }
            set { _relationshipTypeInfo = value; }
        }

        private Boolean _isStillASpouse;
        public Boolean IsStillASpouse
        {
            get { return _isStillASpouse; }
            set { _isStillASpouse = value; }
        }

    }

    [Serializable()]
    public class SysAccess : BaseObject
    {
        public SysAccess()
        {
            _userId = String.Empty;
            _userName = String.Empty;
            _password = String.Empty;
            _userStatus = false;
            _personInfo = new Person();
            _networkInfo = String.Empty;
            _installationDate = String.Empty;
            _accessRightsGrantedList = new CloneableDictionaryList<AccessRightsGranted>();
        }

        public Boolean Equals(SysAccess obj)
        {
            if (base.Equals<SysAccess>(obj) &&
                _personInfo.Equals(obj.PersonInfo) &&
                this.Equals(obj.AccessRightsGrantedList))
            {
                return true;
            }

            return false;
        }

        private Boolean Equals(CloneableDictionaryList<AccessRightsGranted> list)
        {
            Int32 i = 0;

            foreach (AccessRightsGranted rightGranted in _accessRightsGrantedList)
            {
                if ((i < list.Count) && (!rightGranted.Equals(list[i])))
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

        private String _userId;
        public String UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        private String _userName;
        public String UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private String _password;
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private Boolean _userStatus;
        public Boolean UserStatus
        {
            get { return _userStatus; }
            set { _userStatus = value; }
        }

        private Person _personInfo;
        public Person PersonInfo
        {
            get { return _personInfo; }
            set { _personInfo = value; }
        }

        private String _networkInfo;
        public String NetworkInformation
        {
            get { return _networkInfo; }
            set { _networkInfo = value; }
        }

        private String _installationDate;
        public String InstallationDate
        {
            get { return _installationDate; }
            set { _installationDate = value; }
        }

        private CloneableDictionaryList<AccessRightsGranted> _accessRightsGrantedList;
        public CloneableDictionaryList<AccessRightsGranted> AccessRightsGrantedList
        {
            get { return _accessRightsGrantedList; }
            set { _accessRightsGrantedList = value; }
        }
               
    }

    [Serializable()]
    public class AccessRightsGranted : BaseObject
    {
        public AccessRightsGranted()
        {
            _rightsGrantedId = 0;
            _accessRightsInfo = new SystemAccessRights();
        }

        public Boolean Equals(AccessRightsGranted obj)
        {
            if (base.Equals<AccessRightsGranted>(obj) &&
                _accessRightsInfo.Equals(obj.AccessRightsInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _rightsGrantedId;
        public Int64 RightsGrantedId
        {
            get { return _rightsGrantedId; }
            set { _rightsGrantedId = value; }
        }

        private SystemAccessRights _accessRightsInfo;
        public SystemAccessRights AccessRightsInfo
        {
            get { return _accessRightsInfo; }
            set { _accessRightsInfo = value; }
        }
    }

    [Serializable()]
    public class SystemAccessRights : BaseObject
    {
        public SystemAccessRights()
        {
            _accessRights = String.Empty;
            _accessIndex = 0;
            _accessDescription = String.Empty;
        }

        public Boolean Equals(SystemAccessRights obj)
        {
            if (base.Equals<SystemAccessRights>(obj))
            {
                return true;
            }

            return false;
        }

        private String _accessRights;
        public String AccessRights
        {
            get { return _accessRights; }
            set { _accessRights = value; }
        }

        private Byte _accessIndex;
        public Byte AccessIndex
        {
            get { return _accessIndex; }
            set { _accessIndex = value; }
        }

        private String _accessDescription;
        public String AccessDescription
        {
            get { return _accessDescription; }
            set { _accessDescription = value; }
        }
    }

    [Serializable()]
    public class TransactionLog
    {
        public TransactionLog()
        {
            _userInfo = new SysAccess();
        }

        private Int64 _transactionId;
        public Int64 TransactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }

        private String _transactionDate;
        public String TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; }
        }

        private SysAccess _userInfo;
        public SysAccess UserInfo
        {
            get { return _userInfo; }
            set { _userInfo = value; }
        }

        private String _networkInformation;
        public String NetworkInformation
        {
            get { return _networkInformation; }
            set { _networkInformation = value; }
        }

        private String _transactionDone;
        public String TransactionDone
        {
            get { return _transactionDone; }
            set { _transactionDone = value; }
        }

        private String _userStatusString;
        public String UserStatusString
        {
            get { return _userStatusString; }
            set { _userStatusString = value; }
        }

        private String _accessDescription;
        public String AccessDescription
        {
            get { return _accessDescription; }
            set { _accessDescription = value; }
        }
    }

    [Serializable()]
    public class SystemConfiguration
    {
        public static String ApplicationDocumentsFolder(String startUpPath)
        {
            return startUpPath + @"\AppDocuments";
        }

        public static String GoogleMapsWebAddress(String query)
        {
            return @"http://maps.google.com/maps?hl=en&q=" + query;
        }

        public static String TreeViewNodeTextSpace
        {
            get { return @"  ::  "; }
        }

        public static String UpdatedBinaryFolder(String startUpPath)
        {
            return startUpPath + @"\LMS Binaries";
        }
    }

    [Serializable()]
    public class LmsBinaries
    {
        public LmsBinaries() { }

        private String _fileName;
        public String FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private Byte[] _fileBytes;
        public Byte[] FileBytes
        {
            get { return _fileBytes; }
            set { _fileBytes = value; }
        }
    }

    /// <summary>
    /// This class is used for list that needs to be cloned. Source: http://programmingcorner.blogspot.com/2007_01_01_programmingcorner_archive.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable()]
    public class CloneableDictionaryList<T> : List<T>, ICloneable where T : class
    {
        public virtual Object Clone()
        {
            CloneableDictionaryList<T> newList = new CloneableDictionaryList<T>();

            if (this.Count > 0)
            {
                Type iCloneType = this[0].GetType().GetInterface("ICloneable", true);

                if (iCloneType != null)
                {
                    foreach (T value in this)
                    {
                        newList.Add((T)((ICloneable)value).Clone());
                    }
                }
                else
                {
                    foreach (T value in this)
                    {
                        newList.Add(value);
                    }
                }

                return newList;
            }
            else
            {
                return newList;
            }

        }
    }

    [Serializable()]
    public abstract class BaseObject : ICloneable
    {
        protected DataRowState _objectState;    //must be declared as protected in order for the data member to be include in the cloning.
        public DataRowState ObjectState
        {
            get { return _objectState; }
            set { _objectState = value; }
        }

        /// <summary>
        /// Clone the object, and returning a reference to a cloned object.
        /// Source: http://www.codeproject.com/KB/cs/cloneimpl_class.aspx
        /// </summary>
        /// <returns>reference to the new cloned object</returns>
        public Object Clone()
        {
            //create an instance of this specific type
            Object newObject = Activator.CreateInstance(this.GetType());

            //get the array of fields for the new type instance
            FieldInfo[] fields = newObject.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | 
                BindingFlags.Public | BindingFlags.Static);

            Int32 i = 0;

            //foreach (FieldInfo fi in this.GetType().GetFields())
            foreach (FieldInfo fi in newObject.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | 
                BindingFlags.Public | BindingFlags.Static))
            {
                //query if the fields support the ICloneable interface.
                Type ICloneType = fi.FieldType.GetInterface("ICloneable", true);

                if (ICloneType != null)
                {
                    //getting the ICloneable interface from the object
                    ICloneable IClone = (ICloneable)fi.GetValue(this);

                    if (fi.GetValue(this) != null)
                    {
                        //use the clone method to set the new value to the field.
                        fields[i].SetValue(newObject, IClone.Clone());
                    }
                }
                else
                {
                    if (fi.GetValue(this) != null)
                    {
                        //if the field doesn't support the ICloneable interface then just set it.
                        fields[i].SetValue(newObject, fi.GetValue(this));
                    }
                }

                //check if the object support the IEnumerable interface, so if it does
                //we need to enumerate all its items and check if they support the ICloneable interface
                Type IEnumerableType = fi.FieldType.GetInterface("IEnumerable", true);

                if (IEnumerableType != null)
                {
                    //get the IEnumerable interface from the field.
                    IEnumerable IEnum = (IEnumerable)fi.GetValue(this);

                    //this version support the IList and the IDictionary interfaces to iterate on collections.
                    Type IListType = fields[i].FieldType.GetInterface("IList", true);

                    Type IDicType = fields[i].FieldType.GetInterface("IDictionary", true);

                    Int32 j = 0;

                    if (IListType != null)
                    {
                        //getting the IList interface
                        IList list = (IList)fields[i].GetValue(newObject);

                        if (IEnum != null && list != null)
                        {
                            foreach (Object obj in IEnum)
                            {
                                //checks to see if the current item support the ICloneable interface
                                ICloneType = obj.GetType().GetInterface("ICloneable", true);

                                if (ICloneType != null)
                                {
                                    //if it does support the ICloneable interface, we use it to set the clone of the object in the list
                                    ICloneable clone = (ICloneable)obj;

                                    list[j] = clone.Clone();
                                }

                                //NOTE: If the item in the list is does not
                                //support the ICloneable interface then in the cloned list this item
                                //will be the same item as in the original list (as long as this type is a reference type).

                                j++;
                            }
                        }
                    }
                    else if (IDicType != null)
                    {
                        //getting the dictionary interface
                        IDictionary dic = (IDictionary)fields[i].GetValue(newObject);

                        if (dic != null)
                        {
                            j = 0;

                            foreach (DictionaryEntry de in IEnum)
                            {
                                //checking to see if the item support the ICloneable interface.
                                ICloneType = de.Value.GetType().GetInterface("ICloneable", true);

                                if (ICloneType != null)
                                {
                                    ICloneable clone = (ICloneable)de.Value;

                                    dic[de.Key] = clone.Clone();
                                }

                                j++;
                            }
                        }
                    }
                }

                i++;
            }

            return newObject;

        }

        protected Boolean Equals<T>(T obj) where T : class
        {
            if (obj != null)
            {
                PropertyInfo[] sourceProperties = this.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance |
                    BindingFlags.Public | BindingFlags.Static);

                foreach (PropertyInfo pi in sourceProperties)
                {
                    if (!(this.GetType().GetProperty(pi.Name).GetValue(this, null) == null ||
                        obj.GetType().GetProperty(pi.Name).GetValue(obj, null) == null) &&
                        !(String.Equals(this.GetType().GetProperty(pi.Name).GetValue(this, null).ToString(),
                        obj.GetType().GetProperty(pi.Name).GetValue(obj, null).ToString())))
                    {
                        return false;
                    }
                }

                return true;
            }

            return this == obj;
        }
    }

    [Serializable()]
    public enum SystemRange
    {
        ReceivedDateAllowance = 4   //IsRecordLockByReflectedCreatedDate
    }

    [Serializable()]
    public enum ServerCode
    {
        PrimaryServer = 1,
        FailOverServer = 2
    }
    #endregion

}
