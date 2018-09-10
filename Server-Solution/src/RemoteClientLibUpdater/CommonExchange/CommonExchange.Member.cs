using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CommonExchange
{
    #region Common Structure Exchange

    [Serializable()]
    public class MemberClassification : BaseObject
    {
        public MemberClassification()
        {
            _classificationId = String.Empty;
            _classificationDescription = String.Empty;
        }

        public Boolean Equals(MemberClassification obj)
        {
            if (base.Equals<MemberClassification>(obj))
            {
                return true;
            }

            return false;
        }

        private String _classificationId;
        public String ClassificationId
        {
            get { return _classificationId; }
            set { _classificationId = value; }
        }

        private String _classificationDescription;
        public String ClassificationDescription
        {
            get { return _classificationDescription; }
            set { _classificationDescription = value; }
        }
    }

    [Serializable()]
    public class MemberType : BaseObject
    {
        public MemberType()
        {
            _memberTypeId = String.Empty;
            _memberTypeDescription = String.Empty;
        }

        public Boolean Equals(MemberType obj)
        {
            if (base.Equals<MemberType>(obj))
            {
                return true;
            }

            return false;
        }

        private String _memberTypeId;
        public String MemberTypeId
        {
            get { return _memberTypeId; }
            set { _memberTypeId = value; }
        }

        private String _memberTypeDescription;
        public String MemberTypeDescription
        {
            get { return _memberTypeDescription; }
            set { _memberTypeDescription = value; }
        }
    }    

    [Serializable()]
    public class Member : BaseObject
    {
        public Member()
        {
            _memberSysId = String.Empty;
            _personInfo = new Person();
            _memberId = String.Empty;
            _membershipDate = String.Empty;
            _memberTypeInfo = new MemberType();
            _classificationInfo = new MemberClassification();
            _reasonForMembership = String.Empty;
            _otherCoopMembership = String.Empty;
            _certificationInformation = String.Empty;
            _otherMemberInformation = String.Empty;
            _isActive = false;
            _memberRelationshipList = new CloneableDictionaryList<MemberRelationship>();
            _otherCreditorInfoList = new CloneableDictionaryList<OtherCreditor>();
        }

        public Boolean Equals(Member obj)
        {
            if (base.Equals<Member>(obj) &&
                _personInfo.Equals(obj.PersonInfo) &&
                _classificationInfo.Equals(obj.ClassificationInfo) &&
                this.Equals(obj.MemberRelationshipList) &&
                this.Equals(obj.OtherCreditorInfoList))
            {
                return true;
            }

            return false;
        }

        private Boolean Equals(CloneableDictionaryList<MemberRelationship> list)
        {
            Int32 i = 0;

            foreach (MemberRelationship mRelationship in _memberRelationshipList)
            {
                if ((i < list.Count) && (!mRelationship.Equals(list[i])))
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

        private Boolean Equals(CloneableDictionaryList<OtherCreditor> list)
        {
            Int32 i = 0;

            foreach (OtherCreditor oCreditor in _otherCreditorInfoList)
            {
                if ((i < list.Count) && (!oCreditor.Equals(list[i])))
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

        private String _memberSysId;
        public String MemberSysId
        {
            get { return _memberSysId; }
            set { _memberSysId = value; }
        }

        private Person _personInfo;
        public Person PersonInfo
        {
            get { return _personInfo; }
            set { _personInfo = value; }
        }

        private String _memberId;
        public String MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }

        private String _membershipDate;
        public String MembershipDate
        {
            get { return _membershipDate; }
            set { _membershipDate = value; }
        }

        private MemberType _memberTypeInfo;
        public MemberType MemberTypeInfo
        {
            get { return _memberTypeInfo; }
            set { _memberTypeInfo = value; }
        }

        private MemberClassification _classificationInfo;
        public MemberClassification ClassificationInfo
        {
            get { return _classificationInfo; }
            set { _classificationInfo = value; }
        }

        private String _reasonForMembership;
        public String ReasonForMembership
        {
            get { return _reasonForMembership; }
            set { _reasonForMembership = value; }
        }

        private String _otherCoopMembership;
        public String OtherCoopMembership
        {
            get { return _otherCoopMembership; }
            set { _otherCoopMembership = value; }
        }

        private String _certificationInformation;
        public String CertificationInformation
        {
            get { return _certificationInformation; }
            set { _certificationInformation = value; }
        }

        private String _otherMemberInformation;
        public String OtherMemberInformation
        {
            get { return _otherMemberInformation; }
            set { _otherMemberInformation = value; }
        }

        private Boolean _isActive;
        public Boolean IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private CloneableDictionaryList<MemberRelationship> _memberRelationshipList;
        public CloneableDictionaryList<MemberRelationship> MemberRelationshipList
        {
            get { return _memberRelationshipList; }
            set { _memberRelationshipList = value; }
        }

        private CloneableDictionaryList<OtherCreditor> _otherCreditorInfoList;
        public CloneableDictionaryList<OtherCreditor> OtherCreditorInfoList
        {
            get { return _otherCreditorInfoList; }
            set { _otherCreditorInfoList = value; }
        }
    }

    [Serializable()]
    public class MemberRelationship : BaseObject
    {
        public MemberRelationship()
        {
            _relationshipId = 0;
            _memberInRelationshipWith = new Person();
            _relationshipTypeInfo = new RelationshipType();
        }

        public Boolean Equals(MemberRelationship obj)
        {
            if (base.Equals<MemberRelationship>(obj) &&
                _memberInRelationshipWith.Equals(obj.MemberInRelationshipWith) &&
                _relationshipTypeInfo.Equals(obj.RelationshipTypeInfo))
            {
                return true;
            }

            return false;
        }

        private Int64 _relationshipId;
        public Int64 RelationshipId
        {
            get { return _relationshipId; }
            set { _relationshipId = value; }
        }

        private Person _memberInRelationshipWith;
        public Person MemberInRelationshipWith
        {
            get { return _memberInRelationshipWith; }
            set { _memberInRelationshipWith = value; }
        }

        private RelationshipType _relationshipTypeInfo;
        public RelationshipType RelationshipTypeInfo
        {
            get { return _relationshipTypeInfo; }
            set { _relationshipTypeInfo = value; }
        }

    }

    [Serializable()]
    public class Collector : BaseObject
    {
        public Collector()
        {
            _collectorSysId = String.Empty;
            _personInfo = new Person();
            _employeeId = String.Empty;
            _otherCollectorInformation = String.Empty;
            _isActive = false;
        }

        public Boolean Equals(Collector obj)
        {
            if (base.Equals<Collector>(obj) &&
                _personInfo.Equals(obj.PersonInfo))
            {
                return true;
            }

            return false;
        }

        private String _collectorSysId;
        public String CollectorSysId
        {
            get { return _collectorSysId; }
            set { _collectorSysId = value; }
        }

        private Person _personInfo;
        public Person PersonInfo
        {
            get { return _personInfo; }
            set { _personInfo = value; }
        }

        private String _employeeId;
        public String EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        private String _otherCollectorInformation;
        public String OtherCollectorInformation
        {
            get { return _otherCollectorInformation; }
            set { _otherCollectorInformation = value; }
        }

        private Boolean _isActive;
        public Boolean IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }

    #endregion
}
