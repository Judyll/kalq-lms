/********************************************************/
/* This SQL Statements is used for the					*/
/* 		Loan Management System (LMS)					*/
/*Programmed by: Judyll Mark T. Agan					*/
/*Date created: March 09, 2010							*/
/*SERVER SOLUTIONS [ 1 ]								*/
/********************************************************/

USE db_lmsdev_03092010
GO


-- ###########################################DROP TABLE CONSTRAINTS ##############################################################

--verifies if the Code_Reference_Code_Entity_ID_FK constraint exists
IF OBJECT_ID('lms.code_reference', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.code_reference
	DROP CONSTRAINT Code_Reference_Code_Entity_ID_FK
END
GO
-----------------------------------------------------

--verifies if the System_User_Info_Created_By_FK constraint exists--
IF OBJECT_ID('lms.system_user_info', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.system_user_info
	DROP CONSTRAINT System_User_Info_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the System_User_Info_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.system_user_info', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.system_user_info
	DROP CONSTRAINT System_User_Info_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Access_Rights_Granted_System_User_ID_FK constraint exists--
IF OBJECT_ID('lms.access_rights_granted', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.access_rights_granted
	DROP CONSTRAINT Access_Rights_Granted_System_User_ID_FK
END
GO
-----------------------------------------------------

--verifies if the Access_Rights_Granted_Access_Rights_FK constraint exists--
IF OBJECT_ID('lms.access_rights_granted', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.access_rights_granted
	DROP CONSTRAINT Access_Rights_Granted_Access_Rights_FK
END
GO
-----------------------------------------------------

--verifies if the Access_Rights_Granted_Created_By_FK constraint exists--
IF OBJECT_ID('lms.access_rights_granted', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.access_rights_granted
	DROP CONSTRAINT Access_Rights_Granted_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Access_Rights_Granted_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.access_rights_granted', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.access_rights_granted
	DROP CONSTRAINT Access_Rights_Granted_Edited_By_FK
END
GO
-----------------------------------------------------

-- verifies if the Transaction_Log_System_User_ID_FK constraint exists
IF OBJECT_ID('lms.transaction_log', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.transaction_log
	DROP CONSTRAINT Transaction_Log_System_User_ID_FK 
END
GO
-----------------------------------------------------

-- ########################################END DROP TABLE CONSTRAINTS ##############################################################




-- ########################################DROP DEPENDENT TABLE CONSTRAINTS ##############################################################

--verifies if the Office_Employer_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.office_employer_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.office_employer_information
	DROP CONSTRAINT Office_Employer_Information_Created_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Office_Employer_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.office_employer_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.office_employer_information
	DROP CONSTRAINT Office_Employer_Information_Edited_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Life_Status_Code_FK constraint exists--
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information
	DROP CONSTRAINT Person_Information_Life_Status_Code_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Gender_Code_FK constraint exists--
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information
	DROP CONSTRAINT Person_Information_Gender_Code_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Marital_Status_Code_FK constraint exists--
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information
	DROP CONSTRAINT Person_Information_Marital_Status_Code_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Appointment_Status_Code_FK constraint exists--
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information
	DROP CONSTRAINT Person_Information_Appointment_Status_Code_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information
	DROP CONSTRAINT Person_Information_Created_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information
	DROP CONSTRAINT Person_Information_Edited_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Member_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.member_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_information
	DROP CONSTRAINT Member_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.member_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_information
	DROP CONSTRAINT Member_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Collector_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.collector_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collector_information
	DROP CONSTRAINT Collector_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Collector_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.collector_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collector_information
	DROP CONSTRAINT Collector_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Person_Document_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_document
	DROP CONSTRAINT Person_Document_Created_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Document_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_document
	DROP CONSTRAINT Person_Document_Edited_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Beneficiary_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_beneficiary_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_beneficiary_information
	DROP CONSTRAINT Person_Beneficiary_Information_Created_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Beneficiary_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_beneficiary_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_beneficiary_information
	DROP CONSTRAINT Person_Beneficiary_Information_Edited_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Reference_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_reference_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_reference_information
	DROP CONSTRAINT Person_Reference_Information_Created_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Person_Reference_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_reference_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_reference_information
	DROP CONSTRAINT Person_Reference_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Person_Spouse_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_spouse_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_spouse_information
	DROP CONSTRAINT Person_Spouse_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Person_Spouse_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_spouse_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_spouse_information
	DROP CONSTRAINT Person_Spouse_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Relationship_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information
	DROP CONSTRAINT Member_Relationship_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Relationship_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information
	DROP CONSTRAINT Member_Relationship_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information
	DROP CONSTRAINT Regular_Loan_Information_Created_By_FK
END
GO
-----------------------------------------------------	

--verifies if the Regular_Loan_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information
	DROP CONSTRAINT Regular_Loan_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Amortization_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_amortization', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_amortization
	DROP CONSTRAINT Regular_Loan_Amortization_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Amortization_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_amortization', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_amortization
	DROP CONSTRAINT Regular_Loan_Amortization_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Chart_Of_Accounts_Created_By_FK constraint exists
IF OBJECT_ID('lms.chart_of_accounts', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.chart_of_accounts
	DROP CONSTRAINT Chart_Of_Accounts_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Chart_Of_Accounts_Edited_By_FK constraint exists
IF OBJECT_ID('lms.chart_of_accounts', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.chart_of_accounts
	DROP CONSTRAINT Chart_Of_Accounts_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Charges_Created_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges
	DROP CONSTRAINT Regular_Loan_Charges_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Charges_Edited_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges
	DROP CONSTRAINT Regular_Loan_Charges_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Additions_Created_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions
	DROP CONSTRAINT Regular_Loan_Additions_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Additions_Edited_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions
	DROP CONSTRAINT Regular_Loan_Additions_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Document_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_document
	DROP CONSTRAINT Regular_Loan_Document_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Document_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_document
	DROP CONSTRAINT Regular_Loan_Document_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Collateral_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collateral_information
	DROP CONSTRAINT Collateral_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Collateral_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collateral_information
	DROP CONSTRAINT Collateral_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Collateral_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_collateral', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_collateral
	DROP CONSTRAINT Regular_Loan_Collateral_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Collateral_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_collateral', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_collateral
	DROP CONSTRAINT Regular_Loan_Collateral_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_CoMaker_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_comaker
	DROP CONSTRAINT Regular_Loan_CoMaker_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_CoMaker_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_comaker
	DROP CONSTRAINT Regular_Loan_CoMaker_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Other_Creditor_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information
	DROP CONSTRAINT Other_Creditor_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Other_Creditor_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information
	DROP CONSTRAINT Other_Creditor_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_information
	DROP CONSTRAINT Share_Capital_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_information
	DROP CONSTRAINT Share_Capital_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_information
	DROP CONSTRAINT In_House_Hospitalization_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_information
	DROP CONSTRAINT In_House_Hospitalization_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Include_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_include_coverage
	DROP CONSTRAINT Hospitalization_Include_Coverage_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Include_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_include_coverage
	DROP CONSTRAINT Hospitalization_Include_Coverage_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Exclude_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_exclude_coverage
	DROP CONSTRAINT Hospitalization_Exclude_Coverage_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Exclude_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_exclude_coverage
	DROP CONSTRAINT Hospitalization_Exclude_Coverage_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Debit_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_debit
	DROP CONSTRAINT In_House_Hospitalization_Debit_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Debit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_debit
	DROP CONSTRAINT In_House_Hospitalization_Debit_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Include_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_include_coverage
	DROP CONSTRAINT In_House_Include_Coverage_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Include_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_include_coverage
	DROP CONSTRAINT In_House_Include_Coverage_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Exclude_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_exclude_coverage
	DROP CONSTRAINT In_House_Exclude_Coverage_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Exclude_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_exclude_coverage
	DROP CONSTRAINT In_House_Exclude_Coverage_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Document_Created_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_document
	DROP CONSTRAINT Hospitalization_Document_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Document_Edited_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_document
	DROP CONSTRAINT Hospitalization_Document_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Bank_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.bank_information
	DROP CONSTRAINT Bank_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Bank_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.bank_information
	DROP CONSTRAINT Bank_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information
	DROP CONSTRAINT Disbursement_Voucher_Information_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information
	DROP CONSTRAINT Disbursement_Voucher_Information_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Entry_Created_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry
	DROP CONSTRAINT Disbursement_Voucher_Entry_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Entry_Edited_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry
	DROP CONSTRAINT Disbursement_Voucher_Entry_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_Created_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments
	DROP CONSTRAINT Regular_Loan_Payments_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_Edited_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments
	DROP CONSTRAINT Regular_Loan_Payments_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Credit_Created_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit
	DROP CONSTRAINT Share_Capital_Credit_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Credit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit
	DROP CONSTRAINT Share_Capital_Credit_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Equity_Credit_Created_By_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit
	DROP CONSTRAINT Member_Equity_Credit_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Equity_Credit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit
	DROP CONSTRAINT Member_Equity_Credit_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Credit_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit
	DROP CONSTRAINT In_House_Hospitalization_Credit_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Credit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit
	DROP CONSTRAINT In_House_Hospitalization_Credit_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_Created_By_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income
	DROP CONSTRAINT Miscellaneous_Income_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_Edited_By_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income
	DROP CONSTRAINT Miscellaneous_Income_Edited_By_FK
END
GO
-----------------------------------------------------

--verifies if the Breakdown_Bank_Deposit_Created_By_FK constraint exists
IF OBJECT_ID('lms.breakdown_bank_deposit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.breakdown_bank_deposit
	DROP CONSTRAINT Breakdown_Bank_Deposit_Created_By_FK
END
GO
-----------------------------------------------------

--verifies if the Breakdown_Bank_Deposit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.breakdown_bank_deposit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.breakdown_bank_deposit
	DROP CONSTRAINT Breakdown_Bank_Deposit_Edited_By_FK
END
GO
-----------------------------------------------------



-- ######################################END DROP DEPENDENT TABLE CONSTRAINTS ############################################################




-- #########################################################GENERAL PROCEDURES AND FUNCTIONS##################################################

-- verifies if the "ShowErrorMsg" procedure already exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'ShowErrorMsg')
   DROP PROCEDURE lms.ShowErrorMsg
GO

CREATE PROCEDURE lms.ShowErrorMsg

	@request varchar(200) = '',
	@table varchar(200) = ''

AS
	
	RAISERROR (N'%s \n%s %s \n%s %s \n\n%s', 10, 128, N'The server DENIED the current request.', 'Query: ',
				@request, 'Table: ', @table, N'Please contact the system administrator.') WITH NOWAIT

GO
----------------------------------------------------

-- verifies if the "GetServerDateTime" procedure already exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'GetServerDateTime')
   DROP PROCEDURE lms.GetServerDateTime
GO

CREATE PROCEDURE lms.GetServerDateTime
AS
	SELECT GETDATE()	
GO
----------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.GetServerDateTime TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "CreateTemporaryTable" procedure already exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'CreateTemporaryTable')
   DROP PROCEDURE lms.CreateTemporaryTable
GO

CREATE PROCEDURE lms.CreateTemporaryTable

	@system_user_id varchar(50) = '',
	@network_information varchar(MAX) = ''

AS
	
	IF NOT EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		CREATE TABLE ##lms_network_information_table
		(
			system_user_id varchar(50) NOT NULL PRIMARY KEY,
			network_information varchar(MAX)
		)
	END

	IF NOT EXISTS (SELECT * FROM ##lms_network_information_table WHERE system_user_id = @system_user_id)
	BEGIN
		INSERT INTO ##lms_network_information_table
		(
			system_user_id,
			network_information
		)
		VALUES
		(
			@system_user_id,
			@network_information
		)
	END
	ELSE
	BEGIN
		UPDATE ##lms_network_information_table SET
			network_information = @network_information
		WHERE
			system_user_id = @system_user_id
	END

GO
----------------------------------------------------

-- verifies if the "SelectMemberServicesEffectivityDate" procedure already exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectMemberServicesEffectivityDate')
   DROP PROCEDURE lms.SelectMemberServicesEffectivityDate
GO

CREATE PROCEDURE lms.SelectMemberServicesEffectivityDate
AS
	SELECT lms.GetMemberServicesEffectivityDate(GETDATE())
GO
----------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectMemberServicesEffectivityDate TO db_lmsusers
GO
-------------------------------------------------------------


-- verifies if the "IterateListToTable" function already exist
IF OBJECT_ID (N'lms.IterateListToTable') IS NOT NULL
   DROP FUNCTION lms.IterateListToTable
GO

CREATE FUNCTION lms.IterateListToTable
(	
	@list nvarchar(MAX),
	@delimiter nchar(1) = N','
)
RETURNS @return_table TABLE (list_id int IDENTITY(1,1) NOT NULL,
								var_str varchar(4000) NOT NULL,
								nvar_str nvarchar(2000) NOT NULL)
AS
BEGIN
	
	DECLARE @endpos int
	DECLARE @startpos int
	DECLARE @textpos int
	DECLARE @chunklen smallint
	DECLARE @tmpstr nvarchar (4000)
	DECLARE @leftover nvarchar (4000)
	DECLARE @tmpval nvarchar (4000)

	SET @textpos = 1
	SET @leftover = ''
	
	WHILE @textpos <= DATALENGTH(@list) / 2
	BEGIN

		SET @chunklen = 4000 - DATALENGTH(@leftover) / 2
		SET @tmpstr = @leftover + SUBSTRING(@list, @textpos, @chunklen)
		SET @textpos = @textpos + @chunklen

		SET @startpos = 0
		SET @endpos = CHARINDEX(@delimiter COLLATE Slovenian_BIN2, @tmpstr)

		WHILE @endpos > 0
		BEGIN

			SET @tmpval = LTRIM(RTRIM(SUBSTRING(@tmpstr, @startpos + 1, @endpos - @startpos - 1)))

			INSERT @return_table (var_str, nvar_str) VALUES (@tmpval, @tmpval)

			SET @startpos = @endpos
			SET @endpos = CHARINDEX(@delimiter COLLATE Slovenian_BIN2, @tmpstr, @startpos + 1)
		
		END

		SET @leftover = RIGHT(@tmpstr, DATALENGTH(@tmpstr) / 2 - @startpos)

	END

	INSERT @return_table (var_str, nvar_str) VALUES (LTRIM(RTRIM(@leftover)), LTRIM(RTRIM(@leftover)))

	RETURN

END
GO
------------------------------------------------------

-- verifies if the "GetMemberServicesEffectivityDate" function already exist
IF OBJECT_ID (N'lms.GetMemberServicesEffectivityDate') IS NOT NULL
   DROP FUNCTION lms.GetMemberServicesEffectivityDate
GO

CREATE FUNCTION lms.GetMemberServicesEffectivityDate
(	
	@initial_date datetime
)
RETURNS datetime
AS
BEGIN
	
	DECLARE @effectivity_date datetime
	DECLARE @month tinyint
	DECLARE @year smallint
	
	IF DAY(@initial_date) >= 1   --cut-off day
	BEGIN

		SET @month = MONTH(DATEADD(mm, 1, @initial_date))
		SET @year = YEAR(DATEADD(mm, 1, @initial_date))
		
	END
	ELSE
	BEGIN

		SET @month = MONTH(@initial_date)
		SET @year = YEAR(@initial_date)

	END

	RETURN CONVERT(datetime, (CONVERT(varchar, @month) + '/' + '1' + '/' + CONVERT(varchar, @year)) + ' 12:00:00 AM', 101)

END
GO
------------------------------------------------------

-- verifies if the "IsRecordLockByReflectedCreatedDate" function already exist
IF OBJECT_ID (N'lms.IsRecordLockByReflectedCreatedDate') IS NOT NULL
   DROP FUNCTION lms.IsRecordLockByReflectedCreatedDate
GO

CREATE FUNCTION lms.IsRecordLockByReflectedCreatedDate
(	
	@reflected_date datetime,
	@created_date datetime
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit
	DECLARE @add_months tinyint

	SET @result = 0	
	SET @add_months = 4
	
	IF (@reflected_date > (DATEADD(mm, @add_months, @created_date))) OR
		(@reflected_date < (DATEADD(mm, (@add_months - (@add_months * 2)), @created_date))) OR
		(GETDATE() > (DATEADD(mm, @add_months, @created_date)))
	BEGIN
		SET @result = 1
	END	
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsRecordLockByDisbursementVoucher" function already exist
IF OBJECT_ID (N'lms.IsRecordLockByDisbursementVoucher') IS NOT NULL
   DROP FUNCTION lms.IsRecordLockByDisbursementVoucher
GO

CREATE FUNCTION lms.IsRecordLockByDisbursementVoucher
(	
	@sysid_transaction varchar (50)
)
RETURNS bit
AS
BEGIN

	--Procedures that needs to be updated if this function is updated:
	--SelectBySysIDMemberListRegularLoanInformation
	--SelectBySysIDRegularLoanInformation
	--SelectBySysIDMemberListInHouseHospitalizationDebit
	--SelectBySysIDInHouseHospitalizationDebit
		
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_voucher FROM lms.disbursement_voucher_information WHERE
					((sysid_regular = @sysid_transaction) OR
					(sysid_inhousedebit = @sysid_transaction)) AND is_marked_deleted = 0)
	BEGIN
		SET @result = 1
	END	
	
	RETURN @result
END
GO
------------------------------------------------------


-- ######################################################END GENERAL PROCEDURES AND FUNCTIONS###################################################





-- ################################################TABLE "code_entity" OBJECTS######################################################
-- verifies if the code_entity table existss
IF OBJECT_ID('lms.code_entity', 'U') IS NOT NULL
	DROP TABLE lms.code_entity
GO

CREATE TABLE lms.code_entity 			
(
	code_entity_id varchar (50) NOT NULL 
		CONSTRAINT Code_Entity_Code_Entity_ID_PK PRIMARY KEY (code_entity_id)
		CONSTRAINT Code_Entity_Code_Entity_ID_CK CHECK (code_entity_id LIKE 'ETID%'),
	entity_description varchar (100) NOT NULL
		CONSTRAINT Code_Entity_Entity_Description_UQ UNIQUE (entity_description),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Code_Entity_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the code_entity table 
CREATE INDEX Code_Entity_Code_Entity_ID_Index
	ON lms.code_entity (code_entity_id ASC)
GO
------------------------------------------------------------------

-- verifies that the trigger "Code_Entity_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Code_Entity_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Code_Entity_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Code_Entity_Trigger_Instead_Update
	ON  lms.code_entity
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a code entity', 'Code Entity'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Code_Entity_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Code_Entity_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Code_Entity_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Code_Entity_Trigger_Instead_Delete
	ON  lms.code_entity
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a code entity', 'Code Entity'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectCodeEntity" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCodeEntity')
   DROP PROCEDURE lms.SelectCodeEntity
GO

CREATE PROCEDURE lms.SelectCodeEntity
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			cdt.code_entity_id AS code_entity_id,
			cdt.entity_description AS entity_description
		FROM
			lms.code_entity AS cdt
		ORDER BY
			entity_description ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a code entity', 'Code Entity'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCodeEntity TO db_lmsusers
GO
-------------------------------------------------------------

-- ################################################END TABLE "code_entity" OBJECTS###################################################





-- ################################################TABLE "code_reference" OBJECTS######################################################
-- verifies if the code_reference table existss
IF OBJECT_ID('lms.code_reference', 'U') IS NOT NULL
	DROP TABLE lms.code_reference
GO

CREATE TABLE lms.code_reference 			
(
	code_reference_id varchar (50) NOT NULL
		CONSTRAINT Code_Reference_Code_Reference_ID_PK PRIMARY KEY (code_reference_id)
		CONSTRAINT Code_Reference_Code_Reference_ID_CK CHECK (code_reference_id LIKE 'CODE%'),
	code_entity_id varchar (50) NOT NULL 
		CONSTRAINT Code_Reference_Code_Entity_ID_FK FOREIGN KEY REFERENCES lms.code_entity(code_entity_id) ON UPDATE NO ACTION
		CONSTRAINT Code_Reference_Code_Entity_ID_UQ UNIQUE (code_entity_id, reference_code, code_description),
	reference_code varchar (50) NOT NULL
		CONSTRAINT Code_Reference_Reference_Code_UQ	UNIQUE (reference_code, code_entity_id, code_description),
	code_description varchar (100) NOT NULL
		CONSTRAINT Code_Reference_Code_Description_UQ UNIQUE (code_description, code_entity_id, reference_code),
	reference_flag tinyint NOT NULL DEFAULT (0),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Code_Reference_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the code_reference table 
CREATE INDEX Code_Reference_Code_Reference_ID_Index
	ON lms.code_reference (code_reference_id ASC)
GO
------------------------------------------------------------------

-- verifies that the trigger "Code_Reference_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Code_Reference_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Code_Reference_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Code_Reference_Trigger_Instead_Update
	ON  lms.code_reference
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a code reference', 'Code Reference'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Code_Reference_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Code_Reference_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Code_Reference_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Code_Reference_Trigger_Instead_Delete
	ON  lms.code_reference
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a code reference', 'Code Reference'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectCodeReference" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCodeReference')
   DROP PROCEDURE lms.SelectCodeReference
GO

CREATE PROCEDURE lms.SelectCodeReference
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			crf.code_reference_id AS code_reference_id,
			crf.code_entity_id AS code_entity_id,
			crf.reference_code AS reference_code,
			crf.code_description AS code_description,
			crf.reference_flag AS reference_flag,
			cdt.entity_description AS entity_description
		FROM
			lms.code_reference AS crf
		INNER JOIN lms.code_entity AS cdt ON cdt.code_entity_id = crf.code_entity_id
		ORDER BY
			entity_description, code_description ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a code reference', 'Code Reference'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCodeReference TO db_lmsusers
GO
-------------------------------------------------------------

-- ################################################END TABLE "code_entity" OBJECTS###################################################




-- ################################################TABLE "system_access_rights" OBJECTS######################################################
-- verifies if the system_access_rights table exists
IF OBJECT_ID('lms.system_access_rights', 'U') IS NOT NULL
	DROP TABLE lms.system_access_rights
GO

CREATE TABLE lms.system_access_rights 			
(
	access_rights varchar (50) NOT NULL DEFAULT('')		
		CONSTRAINT System_Access_Rights_Access_Code_PK PRIMARY KEY (access_rights),
	access_index tinyint NOT NULL
		CONSTRAINT System_Access_Rights_Access_Index_UQ UNIQUE (access_index),
	access_description varchar (100) NOT NULL
		CONSTRAINT System_Access_Rights_Access_Description_UQ UNIQUE (access_description),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT System_Access_Rights_Unique_ID_UQ UNIQUE (unique_id)	
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- verifies that the trigger "System_Access_Rights_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.System_Access_Rights_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.System_Access_Rights_Trigger_Instead_Update
GO

CREATE TRIGGER lms.System_Access_Rights_Trigger_Instead_Update
	ON  lms.system_access_rights
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a system access rights', 'System Access Rights'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "System_Access_Rights_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.System_Access_Rights_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.System_Access_Rights_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.System_Access_Rights_Trigger_Instead_Delete
	ON  lms.system_access_rights
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a system access code', 'System Access Rights'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectSystemAccessRights" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectSystemAccessRights')
   DROP PROCEDURE lms.SelectSystemAccessRights
GO

CREATE PROCEDURE lms.SelectSystemAccessRights
	
	@system_user_id varchar(50) = ''
	
AS

	IF (lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			sar.access_rights AS access_rights,
			sar.access_index AS access_index,
			sar.access_description AS access_description
		FROM
			lms.system_access_rights AS sar
		ORDER BY
			sar.access_index ASC
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query system access rights', 'System Access Rights'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectSystemAccessRights TO db_lmsusers
GO
-------------------------------------------------------------

-- ##############################################END TABLE "system_access_rights" OBJECTS######################################################




-- ################################################TABLE "system_user_info" OBJECTS######################################################
-- verifies if the system_user_info table exists
IF OBJECT_ID('lms.system_user_info', 'U') IS NOT NULL
	DROP TABLE lms.system_user_info
GO

--USE THIS TO DETERMINE THE CHARACTERS THAT WILL BE ACCEPTED FOR THE USERNAME AND PASSWORD FIELD
--USE master
--GO
--
--SELECT number, char(number)
--FROM
--	spt_values
--WHERE type='p' AND number BETWEEN 1 AND 127
--AND CHAR(number) NOT LIKE '[^ -~0-z]'

CREATE TABLE lms.system_user_info 			
(
	system_user_id varchar (50) NOT NULL 
		CONSTRAINT System_User_Info_System_User_ID_PK PRIMARY KEY (system_user_id),
	system_user_name varchar (50) NOT NULL
		CONSTRAINT System_User_Info_System_User_Name_UQ UNIQUE (system_user_name)
		CONSTRAINT System_User_Info_System_User_Name_CK CHECK ((LEN(system_user_name) >= 6) AND (system_user_name NOT LIKE '%[^ -~0-z]%')),
	system_user_password varchar (50) NOT NULL
		CONSTRAINT System_User_Info_System_User_Password_CK CHECK ((LEN(system_user_password) >= 6) AND (system_user_password NOT LIKE '%[^ -~0-z]%')),
	system_user_status bit NOT NULL DEFAULT (0),		-- 1 - Access Grant  0 - Access Denied

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT System_User_Info_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT System_User_Info_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT System_User_Info_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the system_user_info table using system_user_id as index key
CREATE INDEX System_User_Info_System_User_ID_Index
	ON lms.system_user_info (system_user_id ASC)
GO
------------------------------------------------------------------

-- ###############################################END TABLE "system_user_info" OBJECTS###################################################





-- ################################################TABLE "access_rights_granted" OBJECTS######################################################
-- verifies if the access_rights_granted table exists
IF OBJECT_ID('lms.access_rights_granted', 'U') IS NOT NULL
	DROP TABLE lms.access_rights_granted
GO

CREATE TABLE lms.access_rights_granted 			
(
	rights_granted_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Access_Rights_Granted_ID_PK PRIMARY KEY (rights_granted_id),
	system_user_id varchar (50) NOT NULL
		CONSTRAINT Access_Rights_Granted_System_User_ID_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
		CONSTRAINT Access_Rights_Granted_System_User_ID_UQ UNIQUE (system_user_id, access_rights),
	access_rights varchar (50) NOT NULL 
		CONSTRAINT Access_Rights_Granted_Access_Rights_FK FOREIGN KEY REFERENCES lms.system_access_rights(access_rights) ON UPDATE NO ACTION
		CONSTRAINT Access_Rights_Granted_Access_Rights_UQ UNIQUE (access_rights, system_user_id),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Access_Rights_Granted_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Access_Rights_Granted_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Access_Rights_Granted_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the access_rights_granted table 
CREATE INDEX Access_Rights_Granted_Rights_Granted_ID_Index
	ON lms.access_rights_granted (rights_granted_id ASC)
GO
------------------------------------------------------------------

-- verifies if the procedure "InsertAccessRightsGranted" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertAccessRightsGranted')
   DROP PROCEDURE lms.InsertAccessRightsGranted
GO

CREATE PROCEDURE lms.InsertAccessRightsGranted
	
	@system_user_id varchar (50) = '',
	@access_rights varchar (50) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF lms.IsSystemAdminSystemUserInfo(@created_by) = 1
	BEGIN

		IF EXISTS (SELECT system_user_id FROM lms.system_user_info WHERE (system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
															(system_user_id = @system_user_id) AND
															(system_user_status = 1)) AND
			EXISTS (SELECT access_rights FROM lms.system_access_rights WHERE (access_rights = @access_rights COLLATE SQL_Latin1_General_CP1_CS_AS) AND
																(access_rights = @access_rights))
		BEGIN

			EXECUTE lms.CreateTemporaryTable @created_by, @network_information

			INSERT INTO lms.access_rights_granted
			(
				system_user_id,
				access_rights,

				created_by
			)
			VALUES
			(
				@system_user_id,
				@access_rights,

				@created_by
			)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert an access rights granted', 'Access Rights Granted'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertAccessRightsGranted TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteAccessRightsGranted" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteAccessRightsGranted')
   DROP PROCEDURE lms.DeleteAccessRightsGranted
GO

CREATE PROCEDURE lms.DeleteAccessRightsGranted
	
	@rights_granted_id bigint = 0,
	@system_user_id varchar (50) = '',
	@access_rights varchar (50) = '',

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1
	BEGIN

		IF EXISTS (SELECT system_user_id FROM lms.system_user_info WHERE (system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
															(system_user_id = @system_user_id) AND
															(system_user_status = 1)) AND
			EXISTS (SELECT access_rights FROM lms.system_access_rights WHERE (access_rights = @access_rights COLLATE SQL_Latin1_General_CP1_CS_AS) AND
																(access_rights = @access_rights))
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.access_rights_granted SET
				edited_by = @deleted_by
			WHERE
				(system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
				(system_user_id = @system_user_id) AND
				(access_rights = @access_rights COLLATE SQL_Latin1_General_CP1_CS_AS) AND
				(access_rights = @access_rights) AND
				(rights_granted_id = @rights_granted_id)

			DELETE FROM lms.access_rights_granted
			WHERE
				(system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
				(system_user_id = @system_user_id) AND
				(access_rights = @access_rights COLLATE SQL_Latin1_General_CP1_CS_AS) AND
				(access_rights = @access_rights) AND
				(rights_granted_id = @rights_granted_id)
		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete an access rights granted', 'Access Rights Granted'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteAccessRightsGranted TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySystemUserIdAccessRightsGranted" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySystemUserIdAccessRightsGranted')
   DROP PROCEDURE lms.SelectBySystemUserIdAccessRightsGranted
GO

CREATE PROCEDURE lms.SelectBySystemUserIdAccessRightsGranted
	
	@system_user_id varchar (50) = '',
	@system_user_name varchar(50) = '',
	@system_user_password varchar(50) = ''

AS
	SELECT
		arg.rights_granted_id AS rights_granted_id,		

		sar.access_index AS access_index,
		sar.access_description AS access_description
	FROM
		lms.access_rights_granted AS arg
	INNER JOIN lms.system_user_info AS sui ON sui.system_user_id = arg.system_user_id
	INNER JOIN lms.system_access_rights AS sar ON sar.access_rights = arg.access_rights
	WHERE 
		(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
		(sui.system_user_name = @system_user_name COLLATE SQL_Latin1_General_CP1_CS_AS) AND 
		(sui.system_user_password = @system_user_password COLLATE SQL_Latin1_General_CP1_CS_AS) AND
		(sui.system_user_id = @system_user_id) AND
		(sui.system_user_name = @system_user_name) AND
		(sui.system_user_password = @system_user_password) AND
		(sui.system_user_status = 1)	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySystemUserIdAccessRightsGranted TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectForUpdateAccessRightsGranted" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectForUpdateAccessRightsGranted')
   DROP PROCEDURE lms.SelectForUpdateAccessRightsGranted
GO

CREATE PROCEDURE lms.SelectForUpdateAccessRightsGranted
	
	@retrieve_system_user_id varchar (50) = '',

	@system_user_id varchar(50) = ''

AS

	IF lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1
	BEGIN

		SELECT
			arg.rights_granted_id AS rights_granted_id,		
			
			sar.access_rights AS access_rights,
			sar.access_index AS access_index,
			sar.access_description AS access_description
		FROM
			lms.access_rights_granted AS arg
		INNER JOIN lms.system_user_info AS sui ON sui.system_user_id = arg.system_user_id
		INNER JOIN lms.system_access_rights AS sar ON sar.access_rights = arg.access_rights
		WHERE 
			(sui.system_user_id = @retrieve_system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
			(sui.system_user_id = @retrieve_system_user_id) AND
			(sui.system_user_status = 1)	

	END
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectForUpdateAccessRightsGranted TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsSystemAdminSystemUserInfo" function already exist
IF OBJECT_ID (N'lms.IsSystemAdminSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.IsSystemAdminSystemUserInfo
GO

CREATE FUNCTION lms.IsSystemAdminSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0

	IF EXISTS (SELECT 
					sui.system_user_id
				FROM 
					lms.system_user_info AS sui
				INNER JOIN lms.access_rights_granted AS arg ON arg.system_user_id = sui.system_user_id
				WHERE 
					(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
					(sui.system_user_id = @system_user_id) AND
					(sui.system_user_status = 1) AND
					(arg.access_rights = '@NTz3&W1Z_aQ)-2T5zPwR1:zHG2!4^zmBRqf7%I@'))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsLoanOfficerSystemUserInfo" function already exist
IF OBJECT_ID (N'lms.IsLoanOfficerSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.IsLoanOfficerSystemUserInfo
GO

CREATE FUNCTION lms.IsLoanOfficerSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0

	IF EXISTS (SELECT 
					sui.system_user_id 
				FROM 
					lms.system_user_info AS sui
				INNER JOIN lms.access_rights_granted AS arg ON arg.system_user_id = sui.system_user_id
				WHERE 
					(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
					(sui.system_user_id = @system_user_id) AND
					(sui.system_user_status = 1) AND
					(arg.access_rights = '@V1UlR_9*t^qP|;oI3WqI8_sU6wOwY82zUtWU&w@'))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsCashierSystemUserInfo" function already exist
IF OBJECT_ID (N'lms.IsCashierSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.IsCashierSystemUserInfo
GO

CREATE FUNCTION lms.IsCashierSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0

	IF EXISTS (SELECT 
					sui.system_user_id 
				FROM 
					lms.system_user_info AS sui
				INNER JOIN lms.access_rights_granted AS arg ON arg.system_user_id = sui.system_user_id
				WHERE 
					(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
					(sui.system_user_id = @system_user_id) AND
					(sui.system_user_status = 1) AND
					(arg.access_rights = '@Yi*w$zTI4EIq914_$sUTw84#2(wz\UTqzI9s7+@'))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsDisbursementOfficerSystemUserInfo" function already exist
IF OBJECT_ID (N'lms.IsDisbursementOfficerSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.IsDisbursementOfficerSystemUserInfo
GO

CREATE FUNCTION lms.IsDisbursementOfficerSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0

	IF EXISTS (SELECT 
					sui.system_user_id 
				FROM 
					lms.system_user_info AS sui
				INNER JOIN lms.access_rights_granted AS arg ON arg.system_user_id = sui.system_user_id
				WHERE 
					(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
					(sui.system_user_id = @system_user_id) AND
					(sui.system_user_status = 1) AND
					(arg.access_rights = '@Y3Rz*s9$rX-^2|zvB1#i&%saT6wQzmU7$cI+w=@'))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsBookkeeperSystemUserInfo" function already exist
IF OBJECT_ID (N'lms.IsBookkeeperSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.IsBookkeeperSystemUserInfo
GO

CREATE FUNCTION lms.IsBookkeeperSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0

	IF EXISTS (SELECT 
					sui.system_user_id 
				FROM 
					lms.system_user_info AS sui
				INNER JOIN lms.access_rights_granted AS arg ON arg.system_user_id = sui.system_user_id
				WHERE 
					(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
					(sui.system_user_id = @system_user_id) AND
					(sui.system_user_status = 1) AND
					(arg.access_rights = '@Ow82Utz*e_92(wsO$s4#zx(ytWP[}we*rfY28m@'))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsDataControllerSystemUserInfo" function already exist
IF OBJECT_ID (N'lms.IsDataControllerSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.IsDataControllerSystemUserInfo
GO

CREATE FUNCTION lms.IsDataControllerSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0

	IF EXISTS (SELECT 
					sui.system_user_id 
				FROM 
					lms.system_user_info AS sui
				INNER JOIN lms.access_rights_granted AS arg ON arg.system_user_id = sui.system_user_id
				WHERE 
					(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
					(sui.system_user_id = @system_user_id) AND
					(sui.system_user_status = 1) AND
					(arg.access_rights = '@J^e!R4z_0Utw}[s|q$fTwQ2*zFxIwPiWT5eReZ@'))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------


-- verifies if the "IsActiveSystemUserInfo" function already exist
IF OBJECT_ID (N'lms.IsActiveSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.IsActiveSystemUserInfo
GO

CREATE FUNCTION lms.IsActiveSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0

	IF EXISTS (SELECT 
					sui.system_user_id 
				FROM 
					lms.system_user_info AS sui
				INNER JOIN lms.access_rights_granted AS arg ON arg.system_user_id = sui.system_user_id
				WHERE 
					(sui.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
					(sui.system_user_id = @system_user_id) AND
					(sui.system_user_status = 1))			
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

/*verifies if the "GetAccessRightsSystemUserInfo" function already exist*/
IF OBJECT_ID (N'lms.GetAccessRightsSystemUserInfo') IS NOT NULL
   DROP FUNCTION lms.GetAccessRightsSystemUserInfo
GO

CREATE FUNCTION lms.GetAccessRightsSystemUserInfo
(	
	@system_user_id varchar(50) = ''
)
RETURNS varchar(MAX)
AS
BEGIN
	
	DECLARE @access_description varchar(MAX)

	SELECT 
		@access_description = COALESCE(@access_description + ', ', '') + sar.access_description
	FROM 
		lms.access_rights_granted AS arg
	INNER JOIN lms.system_access_rights AS sar ON sar.access_rights = arg.access_rights
	WHERE
		(arg.system_user_id = @system_user_id COLLATE SQL_Latin1_General_CP1_CS_AS) AND
		(arg.system_user_id = @system_user_id)
		
	RETURN ISNULL(@access_description, '')

END
GO
--------------------------------------------------------

-- ###########################################END TABLE "access_rights_granted" OBJECTS######################################################




-- ###########################################TABLE "transaction_log" OBJECTS############################################################
-- verifies if the transaction_log table exists
IF OBJECT_ID('lms.transaction_log', 'U') IS NOT NULL
	DROP TABLE lms.transaction_log
GO
-----------------------------------------------------

-- creates the table "transaction_log"
CREATE TABLE lms.transaction_log
(
	transaction_id bigint NOT NULL IDENTITY (1,1) NOT FOR REPLICATION
		CONSTRAINT Transaction_Log_Transaction_ID_PK PRIMARY KEY (transaction_id),
	transaction_date datetime NOT NULL DEFAULT (GETDATE()),
	system_user_id varchar (50) NOT NULL 
		CONSTRAINT Transaction_Log_System_User_ID_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,	
	network_information varchar (MAX) NULL DEFAULT (''),
	transaction_done varchar (MAX) NOT NULL DEFAULT(''),
	access_description varchar (MAX) NOT NULL DEFAULT (''),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Transaction_Log_Unique_ID_UQ UNIQUE (unique_id)	
	
) ON [PRIMARY]
GO
-----------------------------------------------

-- create an index of the transaction_log table using cart_id as index key
CREATE INDEX Transaction_Log_Transaction_ID_Index
	ON lms.transaction_log (transaction_id DESC)
GO
-----------------------------------------------------------------

-- verifies that the trigger "Transaction_Log_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Transaction_Log_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Transaction_Log_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Transaction_Log_Trigger_Instead_Update
	ON  lms.transaction_log
	INSTEAD OF UPDATE 
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a record', 'Transaction Log'
	
GO
---------------------------------------------------------------------

-- verifies that the trigger "Transaction_Log_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Transaction_Log_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Transaction_Log_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Transaction_Log_Trigger_Instead_Delete
	ON  lms.transaction_log
	INSTEAD OF DELETE 
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a record', 'Transaction Log'
	
GO
---------------------------------------------------------------------

-- verifies if the procedure "InsertTransactionLog" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertTransactionLog')
   DROP PROCEDURE lms.InsertTransactionLog
GO

CREATE PROCEDURE lms.InsertTransactionLog
	
	@system_user_id varchar(50) = '',
	@network_information varchar (MAX) = '',
	@transaction_done varchar(MAX) = ''

AS

	INSERT INTO lms.transaction_log
	(
		system_user_id,
		network_information,
		transaction_done,
		access_description		
	)
	VALUES
	(
		@system_user_id,
		@network_information,
		@transaction_done,
		lms.GetAccessRightsSystemUserInfo(@system_user_id)
	)
	
GO
-------------------------------------------------------

-- ##########################################END TABLE "transaction_log" OBJECTS########################################################




-- ######################################RESTORE DEPENDENT TABLE CONSTRAINTS#############################################################

--verifies if the Office_Employer_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.office_employer_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.office_employer_information WITH NOCHECK
	ADD CONSTRAINT Office_Employer_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Office_Employer_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.office_employer_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.office_employer_information WITH NOCHECK
	ADD CONSTRAINT Office_Employer_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Life_Status_Code_FK constraint exists
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information WITH NOCHECK
	ADD CONSTRAINT Person_Information_Life_Status_Code_FK FOREIGN KEY (life_status_code) REFERENCES lms.code_reference(code_reference_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Gender_Code_FK constraint exists
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information WITH NOCHECK
	ADD CONSTRAINT Person_Information_Gender_Code_FK FOREIGN KEY (gender_code) REFERENCES lms.code_reference(code_reference_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Marital_Status_Code_FK constraint exists
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information WITH NOCHECK
	ADD CONSTRAINT Person_Information_Marital_Status_Code_FK FOREIGN KEY (marital_status_code) REFERENCES lms.code_reference(code_reference_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Appointment_Status_Code_FK constraint exists--
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information WITH NOCHECK
	ADD CONSTRAINT Person_Information_Appointment_Status_Code_FK FOREIGN KEY (appointment_status_code) REFERENCES lms.code_reference(code_reference_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information WITH NOCHECK
	ADD CONSTRAINT Person_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.person_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_information WITH NOCHECK
	ADD CONSTRAINT Person_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Member_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.member_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_information WITH NOCHECK
	ADD CONSTRAINT Member_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Member_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.member_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_information WITH NOCHECK
	ADD CONSTRAINT Member_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Collector_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.collector_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collector_information WITH NOCHECK
	ADD CONSTRAINT Collector_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Collector_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.collector_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collector_information WITH NOCHECK
	ADD CONSTRAINT Collector_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Person_Document_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_document WITH NOCHECK
	ADD CONSTRAINT Person_Document_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Document_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_document WITH NOCHECK
	ADD CONSTRAINT Person_Document_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Beneficiary_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_beneficiary_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_beneficiary_information WITH NOCHECK
	ADD CONSTRAINT Person_Beneficiary_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Beneficiary_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_beneficiary_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_beneficiary_information WITH NOCHECK
	ADD CONSTRAINT Person_Beneficiary_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Reference_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_reference_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_reference_information WITH NOCHECK
	ADD CONSTRAINT Person_Reference_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Person_Reference_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_reference_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_reference_information WITH NOCHECK
	ADD CONSTRAINT Person_Reference_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Person_Spouse_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.person_spouse_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_spouse_information WITH NOCHECK
	ADD CONSTRAINT Person_Spouse_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Person_Spouse_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.person_spouse_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.person_spouse_information WITH NOCHECK
	ADD CONSTRAINT Person_Spouse_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Member_Relationship_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information WITH NOCHECK
	ADD CONSTRAINT Member_Relationship_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Member_Relationship_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information WITH NOCHECK
	ADD CONSTRAINT Member_Relationship_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Regular_Loan_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Amortization_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_amortization', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_amortization WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Amortization_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Amortization_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_amortization', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_amortization WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Amortization_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Chart_Of_Accounts_Created_By_FK constraint exists
IF OBJECT_ID('lms.chart_of_accounts', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.chart_of_accounts WITH NOCHECK
	ADD CONSTRAINT Chart_Of_Accounts_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Chart_Of_Accounts_Edited_By_FK constraint exists
IF OBJECT_ID('lms.chart_of_accounts', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.chart_of_accounts WITH NOCHECK
	ADD CONSTRAINT Chart_Of_Accounts_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Charges_Created_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Charges_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Charges_Edited_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Charges_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Additions_Created_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Additions_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Additions_Edited_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Additions_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Document_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_document WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Document_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Document_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_document WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Document_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Collateral_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collateral_information WITH NOCHECK
	ADD CONSTRAINT Collateral_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Collateral_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collateral_information WITH NOCHECK
	ADD CONSTRAINT Collateral_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Collateral_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_collateral', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_collateral WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Collateral_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Collateral_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_collateral', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_collateral WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Collateral_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_CoMaker_Created_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_comaker WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_CoMaker_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_CoMaker_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_comaker WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_CoMaker_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Other_Creditor_Information_Created_By_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information WITH NOCHECK
	ADD CONSTRAINT Other_Creditor_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END 
GO
-----------------------------------------------------

--verifies if the Other_Creditor_Information_Edited_By_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information WITH NOCHECK
	ADD CONSTRAINT Other_Creditor_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_information WITH NOCHECK
	ADD CONSTRAINT Share_Capital_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_information WITH NOCHECK
	ADD CONSTRAINT Share_Capital_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_information WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_information WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Include_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_include_coverage WITH NOCHECK
	ADD CONSTRAINT Hospitalization_Include_Coverage_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Include_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_include_coverage WITH NOCHECK
	ADD CONSTRAINT Hospitalization_Include_Coverage_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Exclude_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_exclude_coverage WITH NOCHECK
	ADD CONSTRAINT Hospitalization_Exclude_Coverage_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Exclude_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_exclude_coverage WITH NOCHECK
	ADD CONSTRAINT Hospitalization_Exclude_Coverage_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Debit_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_debit WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Debit_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Debit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_debit WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Debit_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Include_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_include_coverage WITH NOCHECK
	ADD CONSTRAINT In_House_Include_Coverage_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Include_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_include_coverage WITH NOCHECK
	ADD CONSTRAINT In_House_Include_Coverage_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Exclude_Coverage_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_exclude_coverage WITH NOCHECK
	ADD CONSTRAINT In_House_Exclude_Coverage_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Exclude_Coverage_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_exclude_coverage WITH NOCHECK
	ADD CONSTRAINT In_House_Exclude_Coverage_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Document_Created_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_document WITH NOCHECK
	ADD CONSTRAINT Hospitalization_Document_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Hospitalization_Document_Edited_By_FK constraint exists
IF OBJECT_ID('lms.hospitalization_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_document WITH NOCHECK 
	ADD CONSTRAINT Hospitalization_Document_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Bank_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.bank_information WITH NOCHECK
	ADD CONSTRAINT Bank_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Bank_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.bank_information WITH NOCHECK
	ADD CONSTRAINT Bank_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Information_Created_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information WITH NOCHECK
	ADD CONSTRAINT Disbursement_Voucher_Information_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Information_Edited_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information WITH NOCHECK
	ADD CONSTRAINT Disbursement_Voucher_Information_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Entry_Created_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry WITH NOCHECK
	ADD CONSTRAINT Disbursement_Voucher_Entry_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Entry_Edited_By_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry WITH NOCHECK
	ADD CONSTRAINT Disbursement_Voucher_Entry_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_Created_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Payments_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_Edited_By_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Payments_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Credit_Created_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit WITH NOCHECK
	ADD CONSTRAINT Share_Capital_Credit_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Credit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit WITH NOCHECK
	ADD CONSTRAINT Share_Capital_Credit_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Member_Equity_Credit_Created_By_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit WITH NOCHECK
	ADD CONSTRAINT Member_Equity_Credit_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Member_Equity_Credit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit WITH NOCHECK
	ADD CONSTRAINT Member_Equity_Credit_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Credit_Created_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Credit_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Credit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Credit_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_Created_By_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income WITH NOCHECK
	ADD CONSTRAINT Miscellaneous_Income_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_Edited_By_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income WITH NOCHECK
	ADD CONSTRAINT Miscellaneous_Income_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Breakdown_Bank_Deposit_Created_By_FK constraint exists
IF OBJECT_ID('lms.breakdown_bank_deposit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.breakdown_bank_deposit WITH NOCHECK
	ADD CONSTRAINT Breakdown_Bank_Deposit_Created_By_FK FOREIGN KEY (created_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Breakdown_Bank_Deposit_Edited_By_FK constraint exists
IF OBJECT_ID('lms.breakdown_bank_deposit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.breakdown_bank_deposit WITH NOCHECK
	ADD CONSTRAINT Breakdown_Bank_Deposit_Edited_By_FK FOREIGN KEY (edited_by) REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------



-- ###################################END RESTORE DEPENDENT TABLE CONSTRAINTS############################################################





-- ############################################INITIAL DATABASE INFORMATION#############################################################

-- for system_access_code
INSERT INTO lms.system_access_rights(access_rights, access_index, access_description) 
	SELECT '@NTz3&W1Z_aQ)-2T5zPwR1:zHG2!4^zmBRqf7%I@', 0, 'System Administrator'
	UNION ALL
	SELECT '@V1UlR_9*t^qP|;oI3WqI8_sU6wOwY82zUtWU&w@', 1, 'Loan Officer'
	UNION ALL
	SELECT '@Yi*w$zTI4EIq914_$sUTw84#2(wz\UTqzI9s7+@', 2, 'Cashier'
	UNION ALL
	SELECT '@Y3Rz*s9$rX-^2|zvB1#i&%saT6wQzmU7$cI+w=@', 3, 'Disbursement Officer'
	UNION ALL
	SELECT '@Ow82Utz*e_92(wsO$s4#zx(ytWP[}we*rfY28m@', 4, 'Bookkeeper'
	UNION ALL
	SELECT '@J^e!R4z_0Utw}[s|q$fTwQ2*zFxIwPiWT5eReZ@', 5, 'Data Controller'
GO

-- verifies that the trigger "System_User_Info_Trigger_Instead_Insert" already exist
IF OBJECT_ID ('lms.System_User_Info_Trigger_Instead_Insert','TR') IS NOT NULL
   DISABLE TRIGGER lms.System_User_Info_Trigger_Instead_Insert ON lms.system_user_info
GO
-- verifies that the trigger "Access_Rights_Granted_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Access_Rights_Granted_Trigger_Insert','TR') IS NOT NULL
   DISABLE TRIGGER lms.Access_Rights_Granted_Trigger_Insert ON lms.access_rights_granted
GO

INSERT INTO lms.system_user_info(system_user_id, system_user_name, system_user_password, system_user_status, created_by)
	VALUES ('#N!kK!$h@K2yLl3K2!sT!@nNeE@#', 'Judyll', 'lo0408an', 1, '#N!kK!$h@K2yLl3K2!sT!@nNeE@#')
INSERT INTO lms.access_rights_granted(system_user_id, access_rights, created_by)
	VALUES ('#N!kK!$h@K2yLl3K2!sT!@nNeE@#', '@NTz3&W1Z_aQ)-2T5zPwR1:zHG2!4^zmBRqf7%I@', '#N!kK!$h@K2yLl3K2!sT!@nNeE@#')

INSERT INTO lms.system_user_info(system_user_id, system_user_name, system_user_password, system_user_status, created_by)
	VALUES ('#Tuy@i*2sz@kUw-2!us%WBxYzwP#', 'Initi@lD@t@', '?r0gr@mm3r', 1, '#N!kK!$h@K2yLl3K2!sT!@nNeE@#')
INSERT INTO lms.access_rights_granted(system_user_id, access_rights, created_by)
	VALUES ('#Tuy@i*2sz@kUw-2!us%WBxYzwP#', '@NTz3&W1Z_aQ)-2T5zPwR1:zHG2!4^zmBRqf7%I@', '#N!kK!$h@K2yLl3K2!sT!@nNeE@#')
GO

IF OBJECT_ID ('lms.System_User_Info_Trigger_Instead_Insert','TR') IS NOT NULL
	ENABLE TRIGGER lms.System_User_Info_Trigger_Instead_Insert ON lms.system_user_info
GO
IF OBJECT_ID ('lms.Access_Rights_Granted_Trigger_Insert','TR') IS NOT NULL
	ENABLE TRIGGER lms.Access_Rights_Granted_Trigger_Insert ON lms.access_rights_granted
GO

--lms.code_entity  REF: CommonExchange.CodeEntityId
INSERT INTO lms.code_entity(code_entity_id, entity_description) 
	SELECT 'ETID001', 'Gender'
	UNION ALL
	SELECT 'ETID002', 'Marital Status'
	UNION ALL
	SELECT 'ETID003', 'Life Status'
	UNION ALL
	SELECT 'ETID004', 'Appointment Status'
GO

--(ETID001) Gender
INSERT INTO lms.code_reference(code_reference_id, code_entity_id, reference_code, code_description, reference_flag)
	SELECT 'CODE000001', 'ETID001', 'M', 'Male', 1
	UNION ALL
	SELECT 'CODE000002', 'ETID001', 'F', 'Female', 2
GO

--(ETID002) Marital Status
INSERT INTO lms.code_reference(code_reference_id, code_entity_id, reference_code, code_description, reference_flag)
	SELECT 'CODE000003', 'ETID002', 'D', 'Divorced', 1
	UNION ALL
	SELECT 'CODE000004', 'ETID002', 'M', 'Married', 1
	UNION ALL
	SELECT 'CODE000005', 'ETID002', 'P', 'Life Partner', 1
	UNION ALL
	SELECT 'CODE000006', 'ETID002', 'S', 'Single', 0
	UNION ALL
	SELECT 'CODE000007', 'ETID002', 'U', 'Unknown', 0
	UNION ALL 
	SELECT 'CODE000008', 'ETID002', 'W', 'Windowed', 2
	UNION ALL
	SELECT 'CODE000009', 'ETID002', 'X', 'Legally Separated', 1

--(ETID003) Life Status
INSERT INTO lms.code_reference(code_reference_id, code_entity_id, reference_code, code_description, reference_flag)
	SELECT 'CODE000010', 'ETID003', 'L', 'Living', 1
	UNION ALL
	SELECT 'CODE000011', 'ETID003', 'D', 'Deceased', 2

--(ETID004) Appointment Status
INSERT INTO lms.code_reference(code_reference_id, code_entity_id, reference_code, code_description, reference_flag)
	SELECT 'CODE000012', 'ETID004', 'R', 'Regular', 1
	UNION ALL
	SELECT 'CODE000013', 'ETID004', 'C', 'Casual', 2


-- ##########################################END INITIAL DATABASE INFORMATION#############################################################



