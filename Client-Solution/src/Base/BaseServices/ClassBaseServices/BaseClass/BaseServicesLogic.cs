using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.Drawing;

namespace BaseServices
{
    public class BaseServicesLogic
    {
        #region Class Data Member Decleration
        private DataSet _baseClassDataSet;
        private DataTable _personTable;
        private DataTable _officeEmployerTable;
        private DataTable _chartOfAccountsTable;
        public DataTable _personDocumentTable;

        private Int64 _documentId = 0;
        #endregion

        #region Class Properties Decleration

        private String _serverDateTime = String.Empty;
        public String ServerDateTime
        {
            get { return _serverDateTime; }
        }

        private static Int32 _receiptNumber = 0;
        public static Int32 ReceiptNumber
        {
            get { return _receiptNumber; }
            set { _receiptNumber = value; }
        }

        private static String _receiptDate;
        public static String ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        public DataTable PersonTable
        {
            get
            {
                DataTable newTable = new DataTable("PersonTable");
                newTable.Columns.Add("person_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("birthdate", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
                newTable.Columns.Add("life_status_code_code_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("gender_code_code_description", System.Type.GetType("System.String"));

                return newTable;

            }
        }

        public DataTable PersonSpouceTable
        {
            get
            {
                DataTable newTable = new DataTable("PersonSpouceTable");
                newTable.Columns.Add("beneficiary_reference_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("relationship_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("birthdate", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
                newTable.Columns.Add("life_status_code_code_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("gender_code_code_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("is_still_a_spouce", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable PersonBeneficiaryTable
        {
            get
            {
                DataTable newTable = new DataTable("PersonBeneficiaryReferenceTable");
                newTable.Columns.Add("beneficiary_reference_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("relationship_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("birthdate", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
                newTable.Columns.Add("life_status_code_code_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("gender_code_code_description", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable PersonReferenceTable
        {
            get
            {
                DataTable newTable = new DataTable("PersonBeneficiaryReferenceTable");
                newTable.Columns.Add("beneficiary_reference_id", System.Type.GetType("System.String"));
                newTable.Columns.Add("person_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("birthdate", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
                newTable.Columns.Add("life_status_code_code_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("gender_code_code_description", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable OfficeEmployerTable
        {

            get
            {
                DataTable newTable = new DataTable("OfficeEmployerTable");
                newTable.Columns.Add("office_employer_id", System.Type.GetType("System.String"));
				newTable.Columns.Add("office_employer_name", System.Type.GetType("System.String"));
				newTable.Columns.Add("office_employer_acronym", System.Type.GetType("System.String"));
				newTable.Columns.Add("office_employer_address", System.Type.GetType("System.String"));
                newTable.Columns.Add("office_employer_phone_nos", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        public DataTable ChartOfAccountTable
        {
            get
            {
                DataTable newTable = new DataTable("AccountChartTable");
                newTable.Columns.Add("sysid_account", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_code_name", System.Type.GetType("System.String"));
                newTable.Columns.Add("category_description", System.Type.GetType("System.String"));
                newTable.Columns.Add("account_code_name_summary", System.Type.GetType("System.String"));
                newTable.Columns.Add("category_description_summary", System.Type.GetType("System.String"));

                return newTable;
            }
        }

        private Int64 _beneficiaryIdCount = 0;
        public Int64 BeneficiaryIdCount
        {
            get { return _beneficiaryIdCount; }
            set { _beneficiaryIdCount = value; }
        }

        private Int64 _referenceIdCount = 0;
        public Int64 ReferenceIdCount
        {
            get { return _referenceIdCount; }
            set { _referenceIdCount = value; }
        }

        private Int64 _spouceIdCount = 0;
        public Int64 SpouceIdCount
        {
            get { return _spouceIdCount; }
            set { _spouceIdCount = value; }
        }
        #endregion

        #region Class Constructors
        public BaseServicesLogic(CommonExchange.SysAccess userInfo)
        {
            this.InitializeBaseClass(userInfo);
        }
        #endregion

        #region Programmers-Defined Void Procedures
        //this procedure will initialize class
        private void InitializeBaseClass(CommonExchange.SysAccess userInfo)
        {
            //gets the server date and time
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                _serverDateTime = remClient.GetServerDateTime(userInfo);

                _baseClassDataSet = remClient.GetDataSetForBaseManager(userInfo);               
            } //--------------------------------

            _personDocumentTable = new DataTable("PersonDocumentTable");
            _personDocumentTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            _personDocumentTable.Columns.Add("sysid_person", System.Type.GetType("System.String"));
            _personDocumentTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            _personDocumentTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            _personDocumentTable.Columns.Add("document_information", System.Type.GetType("System.String"));
            _personDocumentTable.Columns.Add("is_primary_image", System.Type.GetType("System.Boolean"));
        }//---------------------------
        
        //this function will determine if the file is for update or create
        private void InserPersonDocumentToTempTable(ref DataTable newTable, String originalName, String fileFullName)
        {
            if (_personDocumentTable != null)
            {            
                String strFilter = "original_name = '" + originalName + "'";
                DataRow[] selectRow = _personDocumentTable.Select(strFilter);

                foreach (DataRow docRow in selectRow)
                {
                    if (RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0")) > 0)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                        newRow["sysid_person"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_person", String.Empty);
                        newRow["file_data"] = ProcStatic.GetFileArrayBytes(fileFullName);
                        newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                        newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);
                        newRow["is_primary_image"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "is_primary_image", false);

                        newTable.Rows.Add(newRow);

                        newRow.AcceptChanges();
                        newRow.SetModified();
                    }

                    break;
                }               
            }
        }//--------------------
             
        //this procedure will insert update delete person document information
        public void InsertUpdateDeletePersonDocumentInformation(CommonExchange.SysAccess userInfo, CommonExchange.Person personInfo, String dirPath)
        {
            DataTable newTable = new DataTable("PersonDocumentTableTemp");
            newTable.Columns.Add("document_id", System.Type.GetType("System.Int64"));
            newTable.Columns.Add("sysid_person", System.Type.GetType("System.String"));
            newTable.Columns.Add("file_data", System.Type.GetType("System.Byte[]"));
            newTable.Columns.Add("original_name", System.Type.GetType("System.String"));
            newTable.Columns.Add("document_information", System.Type.GetType("System.String"));
            newTable.Columns.Add("is_primary_image", System.Type.GetType("System.Boolean"));

            try
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);

                foreach (FileInfo file in dir.GetFiles())
                {
                    this.InserPersonDocumentToTempTable(ref newTable, file.Name, file.FullName);
                }

                using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
                {
                    //insert, update and delete Person Document Information
                    remClient.InsertUpdateDeletePersonDocument(userInfo, newTable);
                    //-----------------------------
                }    
            }
            catch
            {
                Int32 index = 0;

                foreach (DataRow docRow in _personDocumentTable.Rows)
                {
                    if (RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0")) <= 0)
                    {
                        DataRow editRow = _personDocumentTable.Rows[index];

                        editRow.BeginEdit();
                        
                        editRow["sysid_person"] = personInfo.PersonSysId;
                     
                        editRow.EndEdit();

                        editRow.AcceptChanges();
                        editRow.SetAdded();
                    }

                    index++;
                }

                using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
                {
                    //insert, update and delete Person Document Information
                    remClient.InsertUpdateDeletePersonDocument(userInfo, _personDocumentTable);
                    //-----------------------------
                }    
            }
        }//-------------------------

        //this procedure will delete person document
        public void DeletePersonDocument(CommonExchange.Person personInfo, String originalName, String startUpPath)
        {
            if (_personDocumentTable != null)
            {
                Int32 index = 0;

                foreach (DataRow docRow in _personDocumentTable.Rows)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty), originalName))
                        {
                            DataRow delRow = _personDocumentTable.Rows[index];

                            delRow.Delete();

                            //delete from file
                            if (File.Exists(personInfo.PersonDocumentsFolder(startUpPath) + originalName))
                            {
                                File.Delete(personInfo.PersonDocumentsFolder(startUpPath) + originalName);
                            }
                        }
                    }

                    index++;
                }
            }
        }//---------------------------

        //this procedure will create a person
        public void InsertUpdatePersonInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Person personInfo)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                remClient.InsertUpdatePersonInformation(userInfo, ref personInfo);

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

                            editRow["sysid_person"] = personInfo.PersonSysId;

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
        }//------------------------------

         //this procedure will create a person with document open
        public void InsertUpdatePersonInformation(CommonExchange.SysAccess userInfo, ref CommonExchange.Person personInfo, List<String> documentOpenList)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                remClient.InsertUpdatePersonInformation(userInfo, ref personInfo);

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

                            editRow["sysid_person"] = personInfo.PersonSysId;

                            editRow.EndEdit();

                            if (docRow.RowState == DataRowState.Added)
                            {
                                editRow.AcceptChanges();
                                editRow.SetAdded();
                            }
                        }

                        index++;
                    }

                    DirectoryInfo dir = new DirectoryInfo(personInfo.PersonDocumentsFolder(Application.StartupPath));

                    foreach (FileInfo file in dir.GetFiles())
                    {
                        foreach (String strFile in documentOpenList)
                        {
                            if (String.Equals(strFile, file.Name))
                            {
                                Int32 count = 0;

                                foreach (DataRow docRow in _personDocumentTable.Rows)
                                {
                                    if (docRow.RowState != DataRowState.Deleted &&
                                        (String.Equals(strFile, RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty)) &&
                                         ProcStatic.GetFileArrayBytes(file.FullName) != (Byte[])docRow["original_name"]))
                                    {
                                        DataRow editRow = _personDocumentTable.Rows[index];

                                        editRow.SetModified();
                                    }

                                    count++;
                                }
                            }
                        }
                    }

                    //insert, update and delete Person Document Information
                    remClient.InsertUpdateDeletePersonDocument(userInfo, _personDocumentTable);
                    //-----------------------------
                }
            }
        }//-------------------------------

        //this procedure will insert update person document information
        public void InsertUpdatePersonDocumentInformationInformation(String original_name, String strDocumentInfo)
        {
            if (_personDocumentTable != null)
            {
                Int32 index = 0;

                foreach (DataRow docRow in _personDocumentTable.Rows)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        if (String.Equals(original_name, RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty)))
                        {
                            DataRow editRow = _personDocumentTable.Rows[index];

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

        //this procedure will insert person document
        public void InsertPersonDocument(CommonExchange.Person personInfo, String original_name, Byte[] fileData, Boolean isPrimaryImage)
        {
            if (_personDocumentTable != null)
            {
                if (!Directory.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath)))
                {
                    //creates the directory
                    DirectoryInfo dirInfo = new DirectoryInfo(personInfo.PersonDocumentsFolder(Application.StartupPath));
                    dirInfo.Create();
                    dirInfo.Attributes = FileAttributes.Hidden;
                }

                Int32 index = 0;

                foreach (DataRow docRow in _personDocumentTable.Rows)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        DataRow editRow = _personDocumentTable.Rows[index];

                        editRow.BeginEdit();

                        editRow["is_primary_image"] = false;

                        editRow.EndEdit();
                    }

                    index++;
                }

                DataRow newRow = _personDocumentTable.NewRow();

                newRow["document_id"] = _documentId--;
                newRow["sysid_person"] = personInfo.PersonSysId;
                newRow["file_data"] = fileData;
                newRow["original_name"] = original_name;
                newRow["is_primary_image"] = isPrimaryImage;

                _personDocumentTable.Rows.Add(newRow);
            }
        }//--------------------------

        //this procedure will update person beneficiary information
        public void UpdatePersonBeneficiaryInformation(List<CommonExchange.PersonBeneficiary> personBeneficiaryList, 
            CommonExchange.PersonBeneficiary personBeneficiaryInfo)
        {
            Int32 index = 0;

            if (personBeneficiaryInfo.IsPrimaryBeneficiary)
            {
                foreach (CommonExchange.PersonBeneficiary list in personBeneficiaryList)
                {
                    if (list.BeneficiaryId != personBeneficiaryInfo.BeneficiaryId)
                    {
                        list.IsPrimaryBeneficiary = false;
                    }
                }
            }

            foreach (CommonExchange.PersonBeneficiary list in personBeneficiaryList)
            {
                if (list.BeneficiaryId == personBeneficiaryInfo.BeneficiaryId)
                {
                    personBeneficiaryList.RemoveAt(index);

                    break;
                }

                index++;
            }

            personBeneficiaryList.Add(personBeneficiaryInfo);
        }//---------------------------

        //this procedure will insert office employer information
        public void InsertOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                remClient.InsertOfficeEmployerInformation(userInfo, ref officeEmployerInfo);

                if (_officeEmployerTable != null)
                {
                    DataRow newRow = _officeEmployerTable.NewRow();

                    newRow["office_employer_id"] = officeEmployerInfo.OfficeEmployerId;
				    newRow["office_employer_name"] = officeEmployerInfo.OfficeEmployerName;
				    newRow["office_employer_acronym"] = officeEmployerInfo.OfficeEmployerAcronym;
				    newRow["office_employer_address"] = officeEmployerInfo.OfficeEmployerAddress;
                    newRow["office_employer_phone_nos"] = officeEmployerInfo.OfficeEmployerPhoneNos;

                    _officeEmployerTable.Rows.Add(newRow);
                }
            }
        }//-----------------------

        //this procedure will update office employer information
        public void UpdateOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                remClient.UpdateOfficeEmployerInformation(userInfo, officeEmployerInfo);

                if (_officeEmployerTable != null)
                {
                    Int32 index = 0;

                    foreach (DataRow officeRow in _officeEmployerTable.Rows)
                    {
                        if (officeRow.RowState != DataRowState.Deleted && String.Equals(officeEmployerInfo.OfficeEmployerId,
                             RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_id", String.Empty)))
                        {
                            DataRow editRow = _officeEmployerTable.Rows[index];

                            editRow.BeginEdit();

                            editRow["office_employer_id"] = officeEmployerInfo.OfficeEmployerId;
                            editRow["office_employer_name"] = officeEmployerInfo.OfficeEmployerName;
                            editRow["office_employer_acronym"] = officeEmployerInfo.OfficeEmployerAcronym;
                            editRow["office_employer_address"] = officeEmployerInfo.OfficeEmployerAddress;
                            editRow["office_employer_phone_nos"] = officeEmployerInfo.OfficeEmployerPhoneNos;

                            editRow.EndEdit();

                            break;
                        }

                        index++;
                    }                   
                }
            }
        }//-----------------------

        //this procedure will delete office employer information
        public void DeleteOfficeEmployerInformation(CommonExchange.SysAccess userInfo, CommonExchange.OfficeEmployer officeEmployerInfo)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                remClient.DeleteOfficeEmployerInformation(userInfo, officeEmployerInfo);

                if (_officeEmployerTable != null)
                {
                    Int32 index = 0;

                    foreach (DataRow officeRow in _officeEmployerTable.Rows)
                    {
                        if (officeRow.RowState != DataRowState.Deleted && String.Equals(officeEmployerInfo.OfficeEmployerId,
                             RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_id", String.Empty)))
                        {
                            DataRow delRow = _officeEmployerTable.Rows[index];

                            delRow.Delete();

                            break;
                        }

                        index++;
                    }
                }
            }
        }//---------------------

        //this procedure will select chart of accounts
        public void SelectChartOfAccountsArrangedList(CommonExchange.SysAccess userInfo, String queryString,
            String summaryAccount, String accountingCategoryIdList, Boolean isActiveAccount)
        {
            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                _chartOfAccountsTable = remClient.SelectChartOfAccounts(userInfo, queryString, summaryAccount, accountingCategoryIdList, isActiveAccount);
            }
        }//------------------------


        //this procedure will initialize code reference combo
        public void InitializeCodeReferenceCombo(ComboBox cboBase, String codeEntityId)
        {
            cboBase.Items.Clear();

            String strFilter = "code_entity_id = '" + codeEntityId + "'";
            DataRow[] selectRow = _baseClassDataSet.Tables["CodeReferenceTable"].Select(strFilter);

            foreach (DataRow codeRow in selectRow)
            {
                cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(codeRow, "code_description", ""));
            }

            cboBase.SelectedIndex = -1;
        }//----------------------------

        //this procedure will initialize code reference combo
        public void InitializeCodeReferenceCombo(ComboBox cboBase, String codeEntityId, String codeReferenceId)
        {
            cboBase.Items.Clear();

            String strFilter = "code_entity_id = '" + codeEntityId + "'";
            DataRow[] selectRow = _baseClassDataSet.Tables["CodeReferenceTable"].Select(strFilter);
            Int32 index = 0;

            foreach (DataRow codeRow in selectRow)
            {
                cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(codeRow, "code_description", ""));

                if (String.Equals(codeReferenceId, RemoteServerLib.ProcStatic.DataRowConvert(codeRow, "code_reference_id", "")))
                {
                    cboBase.SelectedIndex = index;
                }

                index++;
            }
        }//-----------------------------

        //this procedure will initialize person relationship type combo
        public void InitializePersonRelationshipTypeCombo(ComboBox cboBase)
        {
            cboBase.Items.Clear();

            if (_baseClassDataSet.Tables["RelationshipTypeTable"] != null)
            {
                foreach (DataRow relationshipRow in _baseClassDataSet.Tables["RelationshipTypeTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "relationship_description", ""));
                }
            }

            cboBase.SelectedIndex = -1;
        }//------------------------

        //this procedure will initialize person relationship type combo
        public void InitializePersonRelationshipTypeCombo(ComboBox cboBase, String relationshipTypeId)
        {
            cboBase.Items.Clear();

            Int32 index = 0;
            Boolean isIndexed = false;

            if (_baseClassDataSet.Tables["RelationshipTypeTable"] != null)
            {
                foreach (DataRow relationshipRow in _baseClassDataSet.Tables["RelationshipTypeTable"].Rows)
                {
                    cboBase.Items.Add(RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "relationship_description", ""));

                    if (!isIndexed)
                    {
                        if (String.Equals(RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "relationship_type_id", ""), relationshipTypeId))
                        {
                            cboBase.SelectedIndex = index;
                            isIndexed = true;
                        }

                        index++;
                    }
                }
            }
        }//-------------------------

        //this procedure will initialize person spoouce data grid view
        public void InitializePersonSpouceDataGridView(DataGridView dgvBase, List<CommonExchange.PersonSpouse> personSpouceList)
        {
            DataTable newTable = this.PersonSpouceTable;

            foreach (CommonExchange.PersonSpouse list in personSpouceList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow spouceRow = newTable.NewRow();

                    spouceRow["beneficiary_reference_id"] = list.SpouseId;
                    spouceRow["person_name"] = ProcStatic.GetCompleteNameMiddleInitial(list.PersonInSpouseWith.LastName,
                        list.PersonInSpouseWith.FirstName, list.PersonInSpouseWith.MiddleName);
                    spouceRow["relationship_description"] = list.RelationshipTypeInfo.RelationshipDescription;

                    DateTime bDate = DateTime.MinValue;

                    if (DateTime.TryParse(list.PersonInSpouseWith.BirthDate, out bDate) && DateTime.Compare(bDate, DateTime.MinValue) != 0)
                    {
                        spouceRow["birthdate"] = bDate.ToLongDateString();
                    }

                    spouceRow["present_address"] = list.PersonInSpouseWith.PresentAddress;
                    spouceRow["present_phone_nos"] = list.PersonInSpouseWith.PresentPhoneNos;
                    spouceRow["life_status_code_code_description"] = list.PersonInSpouseWith.LifeStatusCode.CodeDescription;
                    spouceRow["gender_code_code_description"] = list.PersonInSpouseWith.GenderCode.CodeDescription;
                    spouceRow["is_still_a_spouce"] = list.IsStillASpouse;

                    newTable.Rows.Add(spouceRow);
                }
            }

            dgvBase.DataSource = newTable;
        }//------------------------

        //this procedure will initialize person beneficiary data grid view
        public void InitializePersonBeneficiaryDataGridView(DataGridView dgvBase, List<CommonExchange.PersonBeneficiary> personBeneficiaryList, Label lblBase)
        {
            Boolean hasEnter = false;

            DataTable newTable = this.PersonBeneficiaryTable;

            foreach (CommonExchange.PersonBeneficiary list in personBeneficiaryList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow relationshipRow = newTable.NewRow();

                    relationshipRow["beneficiary_reference_id"] = list.BeneficiaryId;
                    relationshipRow["person_name"] = ProcStatic.GetCompleteNameMiddleInitial(list.PersonInRelationshipWith.LastName,
                        list.PersonInRelationshipWith.FirstName, list.PersonInRelationshipWith.MiddleName);
                    relationshipRow["relationship_description"] = list.RelationshipTypeInfo.RelationshipDescription;

                    DateTime bDate = DateTime.MinValue;

                    if (DateTime.TryParse(list.PersonInRelationshipWith.BirthDate, out bDate) && DateTime.Compare(bDate, DateTime.MinValue) != 0)
                    {
                        relationshipRow["birthdate"] = bDate.ToLongDateString();
                    }

                    relationshipRow["present_address"] = list.PersonInRelationshipWith.PresentAddress;
                    relationshipRow["present_phone_nos"] = list.PersonInRelationshipWith.PresentPhoneNos;
                    relationshipRow["life_status_code_code_description"] = list.PersonInRelationshipWith.LifeStatusCode.CodeDescription;
                    relationshipRow["gender_code_code_description"] = list.PersonInRelationshipWith.GenderCode.CodeDescription;

                    newTable.Rows.Add(relationshipRow);

                    if (!hasEnter && list.IsPrimaryBeneficiary)
                    {
                        hasEnter = true;
                    }
                }
            }

            lblBase.Visible = !hasEnter;

            dgvBase.DataSource = newTable;
        }//-------------------------        

        //this procedure will initialize person reference data grid view
        public void InitializePersonReferenceDataGridView(DataGridView dgvBase, List<CommonExchange.PersonReference> personReferenceList)
        {
            DataTable newTable = this.PersonReferenceTable;

            foreach (CommonExchange.PersonReference list in personReferenceList)
            {
                if (list.ObjectState != DataRowState.Deleted)
                {
                    DataRow referenceRow = newTable.NewRow();

                    referenceRow["beneficiary_reference_id"] = list.ReferenceId;
                    referenceRow["person_name"] = ProcStatic.GetCompleteNameMiddleInitial(list.PersonInReferenceWith.LastName,
                        list.PersonInReferenceWith.FirstName, list.PersonInReferenceWith.MiddleName);

                    DateTime bDate = DateTime.MinValue;

                    if (DateTime.TryParse(list.PersonInReferenceWith.BirthDate, out bDate) && DateTime.Compare(bDate, DateTime.MinValue) != 0)
                    {
                        referenceRow["birthdate"] = bDate.ToLongDateString();
                    }

                    referenceRow["present_address"] = list.PersonInReferenceWith.PresentAddress;
                    referenceRow["present_phone_nos"] = list.PersonInReferenceWith.PresentPhoneNos;
                    referenceRow["life_status_code_code_description"] = list.PersonInReferenceWith.LifeStatusCode.CodeDescription;
                    referenceRow["gender_code_code_description"] = list.PersonInReferenceWith.GenderCode.CodeDescription;

                    newTable.Rows.Add(referenceRow);

                }
            }

            dgvBase.DataSource = newTable;
        }//-------------------------

        //this procedure will delete directory
        public void DeletePersonDocumentDirecotry(CommonExchange.Person personInfo)
        {
            if (Directory.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath)))
            {
                this.DeleteDirectory(personInfo.PersonDocumentsFolder(Application.StartupPath));
            }

        }//-------------------------

        //this procedure will initialize person document 
        public void InitializePersonDocument(CommonExchange.SysAccess userInfo, CommonExchange.Person personInfo, Boolean isPrimaryImage)
        {
            try
            {
                //if (Directory.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath)))
                //{
                //    //this.DeleteDirectory(personInfo.PersonDocumentsFolder(Application.StartupPath));
                //}

                if (!Directory.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath)))
                {
                    //creates the directory
                    DirectoryInfo dirInfo = new DirectoryInfo(personInfo.PersonDocumentsFolder(Application.StartupPath));
                    dirInfo.Create();
                    dirInfo.Attributes = FileAttributes.Hidden;
                }

                DataTable imageTable;

                using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
                {
                    imageTable = remClient.SelectBySysIDPersonListPersonDocument(userInfo, personInfo.PersonSysId, isPrimaryImage);
                }

                foreach (DataRow docRow in imageTable.Rows)
                {
                    DataRow newRow = _personDocumentTable.NewRow();

                    newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                    newRow["sysid_person"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_person", String.Empty);
                    newRow["file_data"] = docRow["file_data"];
                    newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                    newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);
                    newRow["is_primary_image"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "is_primary_image", false);

                    _personDocumentTable.Rows.Add(newRow);
                }

                _personDocumentTable.AcceptChanges();

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

                            //// Create a new Bitmap object, passing the array 
                            //// of bytes to the constructor of a MemoryStream.
                            //using (Bitmap personDocument = new Bitmap(new MemoryStream(buffer)))
                            //{
                            //    if (!File.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath) + imagePath))
                            //    {
                            //        personDocument.Save(personInfo.PersonDocumentsFolder(Application.StartupPath) + imagePath);
                            //    }
                            //}

                            //create a file stream object, passing the array
                            using (FileStream streame = new FileStream(personInfo.PersonDocumentsFolder(Application.StartupPath) + imagePath,
                                FileMode.Create, FileAccess.Write))
                            {
                                streame.Write(buffer, 0, buffer.Length);
                            }
                            
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ProcStatic.ShowErrorDialog("Error loading person document module.\n\n" + ex.Message, "Error Loading");
            }
        }//---------------------------

        //this procedure will kill all the process
        public void KillProcess(List<Process> processList)
        {
            if (processList != null)
            {
                foreach (Process p in processList)
                {
                    try
                    {
                        if (!p.HasExited)
                        {
                            p.Kill();
                            p.Dispose();
                        }
                    }
                    catch
                    { }
                }
            }
        }//-------------------------

        //this procedure will delete file
        public void DeleteDirectory(String dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                ProcStatic.DeleteDirectory(dirPath);               
            }
        }//-------------------------

        public void ClearPersonDocumentTable()
        {
            if (_personDocumentTable != null)
            {
                _personDocumentTable.Rows.Clear();
            }
        }//------------------------
        #endregion

        #region Programmers-Defined Functions
        //this function will get searched person information
        public DataTable GetSearchPersonInformation(CommonExchange.SysAccess userInfo, String queryString, String lastName,
            String firstName, String personSysIdExcludedList, Boolean isNewQuery)
        {
            if (isNewQuery)
            {
                using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
                {
                    _personTable = remClient.SelectPersonInformation(userInfo, queryString, lastName, firstName, personSysIdExcludedList);
                }
            }

            DataTable newTable = new DataTable("PersonTable");
            newTable.Columns.Add("sysid_person", System.Type.GetType("System.String"));
            newTable.Columns.Add("person_name", System.Type.GetType("System.String"));
            newTable.Columns.Add("birthdate", System.Type.GetType("System.String"));
            newTable.Columns.Add("present_address", System.Type.GetType("System.String"));
            newTable.Columns.Add("present_phone_nos", System.Type.GetType("System.String"));
            newTable.Columns.Add("life_status_code_code_description", System.Type.GetType("System.String"));
            newTable.Columns.Add("gender_code_code_description", System.Type.GetType("System.String"));

            if (_personTable != null)
            {
                foreach (DataRow pRow in _personTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["sysid_person"] = RemoteServerLib.ProcStatic.DataRowConvert(pRow, "sysid_person", String.Empty);
                    newRow["person_name"] = ProcStatic.GetCompleteNameMiddleInitial(pRow, "last_name", "first_name", "middle_name");

                    DateTime dValue = DateTime.Parse(_serverDateTime);

                    if (DateTime.TryParse(RemoteServerLib.ProcStatic.DataRowConvert(pRow, "birthdate", ""), out dValue))
                    {

                        newRow["birthdate"] = DateTime.Compare(dValue, DateTime.MinValue) == 0 ? String.Empty :
                           dValue.ToLongDateString();
                    }

                    newRow["present_address"] = RemoteServerLib.ProcStatic.DataRowConvert(pRow, "present_address", "");
                    newRow["present_phone_nos"] = RemoteServerLib.ProcStatic.DataRowConvert(pRow, "present_phone_nos", "");
                    newRow["life_status_code_code_description"] = RemoteServerLib.ProcStatic.DataRowConvert(pRow, "life_status_code_code_description", "");
                    newRow["gender_code_code_description"] = RemoteServerLib.ProcStatic.DataRowConvert(pRow, "gender_code_code_description", "");

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//----------------------------

        //this function will get searched chart of account informations
        public DataTable GetSearchedChartOfAccountInformations(String queryString)
        {
            DataTable newTable = this.ChartOfAccountTable;

            if (_chartOfAccountsTable != null)
            {
                String strFilter = "account_code LIKE '%" + queryString + "%' OR account_name LIKE '%" + queryString + "%'";
                DataRow[] selectRow = _chartOfAccountsTable.Select(strFilter);

                foreach (DataRow accountRow in selectRow)
                {
                    DataRow newRow = newTable.NewRow();

                    newRow["sysid_account"] = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "sysid_account", String.Empty);
                    newRow["account_code_name"] = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_code", String.Empty) + "  (" +
                        RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_name", String.Empty) + ")";
                    newRow["category_description"] = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "category_description", String.Empty);
                    newRow["account_code_name_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_code_summary", String.Empty) + "  (" +
                        RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "account_name_summary", String.Empty) + ")";
                    newRow["category_description_summary"] = RemoteServerLib.ProcStatic.DataRowConvert(accountRow, "category_description_summary", String.Empty);

                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }//------------------------    

        //this function will get details of each chart of account information
        public CommonExchange.ChartOfAccount GetDetailsChartOfAccount(CommonExchange.SysAccess userInfo, String accountSysId)
        {
            CommonExchange.ChartOfAccount chartOfAccountInfo = new CommonExchange.ChartOfAccount();

            using (RemoteClient.RemCntAccountingManager remClient = new RemoteClient.RemCntAccountingManager())
            {
                chartOfAccountInfo = remClient.SelectBySysIDAccountChartOfAccounts(userInfo, accountSysId);
            }

            return chartOfAccountInfo;
        }//---------------------

        //this procedure will get searched office employer information
        public DataTable GetSearchedOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String queryString, 
            Boolean includeMarkedDeleted, Boolean isNewQuery)
        {
            if (isNewQuery)
            {
                using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
                {
                    _officeEmployerTable = remClient.SelectOfficeEmployerInformation(userInfo, queryString, includeMarkedDeleted);
                }
            }

            return _officeEmployerTable;
        }//----------------------------

        //this function will get code reference details
        public CommonExchange.CodeReference GetCodeReference(String codeEntityId, Int32 index)
        {
            CommonExchange.CodeReference codeReferenceInfo = new CommonExchange.CodeReference();

            String strFilter = "code_entity_id = '" + codeEntityId + "'";
            DataRow[] selectRow = _baseClassDataSet.Tables["CodeReferenceTable"].Select(strFilter);

            Int32 count = 0;

            foreach (DataRow codeRow in selectRow)
            {
                if (count == index)
                {
                    codeReferenceInfo.CodeReferenceId = RemoteServerLib.ProcStatic.DataRowConvert(codeRow, "code_reference_id", "");
                    codeReferenceInfo.CodeEntityId = RemoteServerLib.ProcStatic.DataRowConvert(codeRow, "code_entity_id", "");
                    codeReferenceInfo.ReferenceCode = RemoteServerLib.ProcStatic.DataRowConvert(codeRow, "reference_code", "");
                    codeReferenceInfo.CodeDescription = RemoteServerLib.ProcStatic.DataRowConvert(codeRow, "code_description", "");

                    break;
                }

                count++;
            }

            return codeReferenceInfo;
        }//-----------------------

        //this function will get person spouce details
        public CommonExchange.PersonSpouse GetDetailsPersonSpouce(List<CommonExchange.PersonSpouse> personSpouceList, String spouceId)
        {
            CommonExchange.PersonSpouse personSpouceInfo = new CommonExchange.PersonSpouse();

            foreach (CommonExchange.PersonSpouse list in personSpouceList)
            {
                if (String.Equals(list.SpouseId.ToString(), spouceId))
                {
                    personSpouceInfo = list;

                    break;
                }
            }

            return personSpouceInfo;
        }//---------------------------

        //this fucntion will get person beneficiary
        public CommonExchange.PersonBeneficiary GetDetailsPersonBeneficiary(List<CommonExchange.PersonBeneficiary> personBeneficiaryList, String beneficiaryId)
        {
            CommonExchange.PersonBeneficiary personBeneficiary = new CommonExchange.PersonBeneficiary();

            foreach (CommonExchange.PersonBeneficiary list in personBeneficiaryList)
            {
                if (String.Equals(list.BeneficiaryId.ToString(), beneficiaryId))
                {
                    personBeneficiary = list;

                    break;
                }
            }

            return personBeneficiary;
        }//-----------------------------

        //this fucntion will get person reference
        public CommonExchange.PersonReference GetDetailsPersonReference(List<CommonExchange.PersonReference> personReferenceList, String referenceId)
        {
            CommonExchange.PersonReference personReference = new CommonExchange.PersonReference();

            foreach (CommonExchange.PersonReference list in personReferenceList)
            {
                if (String.Equals(list.ReferenceId.ToString(), referenceId))
                {
                    personReference = list;

                    break;
                }
            }

            return personReference;
        }//-----------------------------

        //this fucntion will get person relationship type
        public CommonExchange.RelationshipType GetPersonRelationshipType(Int32 index)
        {
            CommonExchange.RelationshipType relationshipTypeInfo = new CommonExchange.RelationshipType();

            if (_baseClassDataSet.Tables["RelationshipTypeTable"] != null)
            {
                DataRow relationshipRow = _baseClassDataSet.Tables["RelationshipTypeTable"].Rows[index];

                relationshipTypeInfo.RelationshipTypeId = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "relationship_type_id", "");
                relationshipTypeInfo.RelationshipDescription = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "relationship_description", "");
                relationshipTypeInfo.IsSpouse = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "is_spouse", false);
                relationshipTypeInfo.IsSibling = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "is_sibling", false);
                relationshipTypeInfo.IsParent = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "is_parent", false);
                relationshipTypeInfo.IsInLaw = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "is_in_law", false);
                relationshipTypeInfo.IsFriend = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "is_friend", false);
                relationshipTypeInfo.IsBloodLine = RemoteServerLib.ProcStatic.DataRowConvert(relationshipRow, "is_blood_line", false);
            }

            return relationshipTypeInfo;
        }//-------------------------

        //this function will get person details
        public CommonExchange.Person GetPersonDetails(CommonExchange.SysAccess userInfo, String personSysId)
        {
            CommonExchange.Person personInfo = new CommonExchange.Person();

            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                personInfo = remClient.SelectBySysIDPersonInformation(userInfo, personSysId);

                if (!String.IsNullOrEmpty(personInfo.BirthDate))
                {
                    DateTime bDate = DateTime.Parse(personInfo.BirthDate);

                    if (DateTime.Compare(bDate, DateTime.MinValue) == 0)
                    {
                        personInfo.BirthDate = String.Empty;
                    }
                }

                if (!String.IsNullOrEmpty(personInfo.MarriageDate))
                {
                    DateTime mDate = DateTime.Parse(personInfo.MarriageDate);

                    if (DateTime.Compare(mDate, DateTime.MinValue) == 0)
                    {
                        personInfo.MarriageDate = String.Empty;
                    }
                }

                if (!String.IsNullOrEmpty(personInfo.EmploymentDate))
                {
                    DateTime mDate = DateTime.Parse(personInfo.EmploymentDate);

                    if (DateTime.Compare(mDate, DateTime.MinValue) == 0)
                    {
                        personInfo.EmploymentDate = String.Empty;
                    }
                }
            }

            return personInfo;
        }//---------------------

        //this function will get office employer information details
        public CommonExchange.OfficeEmployer GetOfficeEmployerInformationDetails(String officeEmployerSysId)
        {
            CommonExchange.OfficeEmployer officeEmployerInfo = new CommonExchange.OfficeEmployer();

            if (_officeEmployerTable != null)
            {
                String strFilter = "office_employer_id = '" + officeEmployerSysId + "'";
                DataRow[] selectRow = _officeEmployerTable.Select(strFilter);

                foreach (DataRow officeRow in selectRow)
                {
                    officeEmployerInfo.OfficeEmployerId = RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_id", String.Empty);
                    officeEmployerInfo.OfficeEmployerName = RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_name", String.Empty);
                    officeEmployerInfo.OfficeEmployerAcronym = RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_acronym", String.Empty);
                    officeEmployerInfo.OfficeEmployerAddress = RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_address", String.Empty);
                    officeEmployerInfo.OfficeEmployerPhoneNos = RemoteServerLib.ProcStatic.DataRowConvert(officeRow, "office_employer_phone_nos", String.Empty);

                    break;
                }
            }

            return officeEmployerInfo;
        }//------------------------------

        //this function will determine if the selected image already exist
        public Boolean IsExistsSysIDPersonOriginalNamePersonDocument(CommonExchange.SysAccess userInfo, String personSysId, String originalName, Int64 documentId)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                return remClient.IsExistsSysIDPersonOriginalNamePersonDocument(userInfo, documentId, personSysId, originalName);
            }
        }//-----------------------

        //this function will determine if the office employer name already exist
        public Boolean IsExistsNameOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerName)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                return remClient.IsExistsNameOfficeEmployerInformation(userInfo, officeEmployerId, officeEmployerName);
            }
        }//------------------------

        //this fucntion will determine if the office employer acronym alrady exist
        public Boolean IsExistsAcronymOfficeEmployerInformation(CommonExchange.SysAccess userInfo, String officeEmployerId, String officeEmployerAcronym)
        {
            using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
            {
                return remClient.IsExistsAcronymOfficeEmployerInformation(userInfo, officeEmployerId, officeEmployerAcronym);
            }
        }//-------------------------

        //this function will generate person spouce exclude list
        public String GetPersonSpouceExcludeListStringFormat(List<CommonExchange.PersonSpouse> personSpouceList, String personSysId)
        {
            StringBuilder strValue = new StringBuilder();

            foreach (CommonExchange.PersonSpouse list in personSpouceList)
            {
                strValue.Append(list.PersonInSpouseWith.PersonSysId + ", ");
            }

            strValue.Append(personSysId + ", ");

            if (strValue.Length >= 2)
            {
                return strValue.ToString().Substring(0, strValue.Length - 2);
            }
            else
            {
                return String.Empty;
            }
        }//-------------------------

        //this function will generate person relationship exclude list
        public String GetPersonRelationshipExcludeListStringFormat(List<CommonExchange.PersonBeneficiary> personBeneficiaryList, 
            List<CommonExchange.PersonReference> personReferenceList, String personSysId)
        {
            StringBuilder strValue = new StringBuilder();

            foreach (CommonExchange.PersonBeneficiary list in personBeneficiaryList)
            {
                strValue.Append(list.PersonInRelationshipWith.PersonSysId + ", ");
            }

            foreach (CommonExchange.PersonReference list in personReferenceList)
            {
                strValue.Append(list.PersonInReferenceWith.PersonSysId + ", ");
            }

            strValue.Append(personSysId + ", ");

            if (strValue.Length >= 2)
            {
                return strValue.ToString().Substring(0, strValue.Length - 2);
            }
            else
            {
                return String.Empty;
            }
        }//-------------------------

        //this function will determine if the person document is used us primary image
        public Boolean IsPersonDocumentPrimaryImage(String originalName)
        {
            Boolean isPrimaryImage = true;

            if (_personDocumentTable != null)
            {
                String strFilter = "original_name = '" + originalName + "'";
                DataRow[] selectRow = _personDocumentTable.Select(strFilter);

                foreach (DataRow docRow in selectRow)
                {
                    if (docRow.RowState != DataRowState.Deleted)
                    {
                        isPrimaryImage = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "is_primary_image", false);
                    }

                    break;
                }
            }

            return isPrimaryImage;
        }//------------------------

        //this function will get person document information by document original name
        public String GetPersonDocumentInformation(String originalName)
        {
            String value = String.Empty;

            if (_personDocumentTable != null)
            {
                String strFilter = "original_name = '" + originalName + "'";
                DataRow[] selectRow = _personDocumentTable.Select(strFilter);

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

        //this function will get document id by person system id
        public Int64 GetDocumentIdByPersonSysId(String personSysId)
        {
            Int64 docId = -1;

            if (_personDocumentTable != null)
            {
                String strFilter = "sysid_person = '" + personSysId + "' AND is_primary_image = 1";
                DataRow[] selectRow = _personDocumentTable.Select(strFilter);

                foreach (DataRow docRow in selectRow)
                {
                    docId = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                }
            }

            return docId;
        }//---------------------

        //this function gets the whole number and return the decimal number
        public long GetWholeNumberTenthDecimal(Decimal numInput, Boolean isWholeNumber)
        {
            String[] strInput = numInput.ToString().Split('.');

            return isWholeNumber ? long.Parse(strInput[0]) : long.Parse(strInput[1]);
        }//-------------------------    

        //this function will retrun image path of the person primary image
        public String GetPersonPrimaryImagePath(CommonExchange.SysAccess userInfo, CommonExchange.Person personInfo, Boolean isPrimaryImage)
        {
            String path = String.Empty;
            try
            {
                //if (Directory.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath)))
                //{
                //    //this.DeleteDirectory(personInfo.PersonDocumentsFolder(Application.StartupPath));
                //}

                if (!Directory.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath)))
                {
                    //creates the directory
                    DirectoryInfo dirInfo = new DirectoryInfo(personInfo.PersonDocumentsFolder(Application.StartupPath));
                    dirInfo.Create();
                    dirInfo.Attributes = FileAttributes.Hidden;
                }

                DataTable imageTable;

                using (RemoteClient.RemCntBaseManager remClient = new RemoteClient.RemCntBaseManager())
                {
                    imageTable = remClient.SelectBySysIDPersonListPersonDocument(userInfo, personInfo.PersonSysId, isPrimaryImage);
                }

                foreach (DataRow docRow in imageTable.Rows)
                {
                    DataRow newRow = _personDocumentTable.NewRow();

                    newRow["document_id"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_id", Int64.Parse("0"));
                    newRow["sysid_person"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "sysid_person", String.Empty);
                    newRow["file_data"] = docRow["file_data"];
                    newRow["original_name"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "original_name", String.Empty);
                    newRow["document_information"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "document_information", String.Empty);
                    newRow["is_primary_image"] = RemoteServerLib.ProcStatic.DataRowConvert(docRow, "is_primary_image", false);

                    _personDocumentTable.Rows.Add(newRow);
                }

                _personDocumentTable.AcceptChanges();

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

                            // Create a new Bitmap object, passing the array 
                            // of bytes to the constructor of a MemoryStream.
                            using (Bitmap personDocument = new Bitmap(new MemoryStream(buffer)))
                            {
                                if (!File.Exists(personInfo.PersonDocumentsFolder(Application.StartupPath) + imagePath))
                                {
                                    personDocument.Save(personInfo.PersonDocumentsFolder(Application.StartupPath) + imagePath);
                                }

                                path = personInfo.PersonDocumentsFolder(Application.StartupPath) + imagePath;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ProcStatic.ShowErrorDialog("Error loading person document module.\n\n" + ex.Message, "Error Loading");
            }

            return path;
        }//---------------------------
        #endregion
    }
}
