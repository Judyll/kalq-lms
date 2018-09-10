/********************************************************/
/* This SQL Statements is used for the					*/
/* 		Loan Management System (LMS)					*/
/*Programmed by: Judyll Mark T. Agan					*/
/*Date created: March 09, 2010							*/
/*MEMBER SOLUTIONS [ 2 ]								*/
/********************************************************/

USE db_lmsdev_03092010
GO


-- ###########################################DROP TABLE CONSTRAINTS ##############################################################

--verifies if the Member_Informatin_Member_Type_ID_FK constraint exists
IF OBJECT_ID('lms.member_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_information
	DROP CONSTRAINT Member_Informatin_Member_Type_ID_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Information_Classification_ID_FK constraint exists
IF OBJECT_ID('lms.member_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_information
	DROP CONSTRAINT Member_Information_Classification_ID_FK
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

-- ########################################END DROP TABLE CONSTRAINTS ##############################################################




-- ########################################DROP DEPENDENT TABLE CONSTRAINTS ##############################################################

--verifies if the Member_Relationship_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information
	DROP CONSTRAINT Member_Relationship_Information_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Relationship_Information_In_Relationship_With_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information
	DROP CONSTRAINT Member_Relationship_Information_In_Relationship_With_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information
	DROP CONSTRAINT Regular_Loan_Information_SysID_Member_FK
END
GO
-----------------------------------------------------	

--verifies if the Collateral_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collateral_information
	DROP CONSTRAINT Collateral_Information_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_CoMaker_SysID_CoMaker_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_comaker
	DROP CONSTRAINT Regular_Loan_CoMaker_SysID_CoMaker_FK
END
GO
-----------------------------------------------------

--verifies if the Other_Creditor_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information
	DROP CONSTRAINT Other_Creditor_Information_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Information_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_information
	DROP CONSTRAINT Share_Capital_Information_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Information_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_information
	DROP CONSTRAINT In_House_Hospitalization_Information_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Debit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_debit
	DROP CONSTRAINT In_House_Hospitalization_Debit_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit
	DROP CONSTRAINT Share_Capital_Credit_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Equity_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit
	DROP CONSTRAINT Member_Equity_Credit_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit
	DROP CONSTRAINT In_House_Hospitalization_Credit_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income
	DROP CONSTRAINT Miscellaneous_Income_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_SysID_Collector_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income
	DROP CONSTRAINT Miscellaneous_Income_SysID_Collector_FK
END
GO
-----------------------------------------------------

-- ######################################END DROP DEPENDENT TABLE CONSTRAINTS ############################################################





-- ################################################TABLE "member_classification" OBJECTS######################################################
-- verifies if the member_classification table existss
IF OBJECT_ID('lms.member_classification', 'U') IS NOT NULL
	DROP TABLE lms.member_classification
GO

CREATE TABLE lms.member_classification 			
(
	classification_id varchar (50) NOT NULL 
		CONSTRAINT Member_Classification_Classification_ID_PK PRIMARY KEY (classification_id)
		CONSTRAINT Member_Classification_Classification_ID_CK CHECK (classification_id LIKE 'MCS%'),
	classification_description varchar (100) NOT NULL
		CONSTRAINT Member_Classification_Classification_Description_UQ UNIQUE (classification_description),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Member_Classification_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the member_classification table 
CREATE INDEX Member_Classification_Classification_ID_Index
	ON lms.member_classification (classification_id ASC)
GO
------------------------------------------------------------------

-- verifies that the trigger "Member_Classification_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Member_Classification_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Member_Classification_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Member_Classification_Trigger_Instead_Update
	ON  lms.member_classification
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a member classification', 'Member Classification'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Member_Classification_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Member_Classification_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Member_Classification_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Member_Classification_Trigger_Instead_Delete
	ON  lms.member_classification
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a member classification', 'Member Classification'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectMemberClassification" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectMemberClassification')
   DROP PROCEDURE lms.SelectMemberClassification
GO

CREATE PROCEDURE lms.SelectMemberClassification
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			mbc.classification_id AS classification_id,
			mbc.classification_description AS classification_description
		FROM
			lms.member_classification AS mbc
		ORDER BY
			classification_description ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a member classification', 'Member Classification'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectMemberClassification TO db_lmsusers
GO
-------------------------------------------------------------

-- ################################################END TABLE "member_classification" OBJECTS###################################################






-- ################################################TABLE "member_type" OBJECTS######################################################
-- verifies if the member_type table existss
IF OBJECT_ID('lms.member_type', 'U') IS NOT NULL
	DROP TABLE lms.member_type
GO

CREATE TABLE lms.member_type 			
(
	member_type_id varchar (50) NOT NULL 
		CONSTRAINT Member_Type_Member_Type_ID_PK PRIMARY KEY (member_type_id)
		CONSTRAINT Member_Type_Member_Type_ID_CK CHECK (member_type_id LIKE 'MTP%'),
	member_type_description varchar (100) NOT NULL
		CONSTRAINT Member_Type_Member_Type_Description_UQ UNIQUE (member_type_description),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Member_Type_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the member_type table 
CREATE INDEX Member_Type_Member_Type_ID_Index
	ON lms.member_type (member_type_id ASC)
GO
------------------------------------------------------------------

-- verifies that the trigger "Member_Type_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Member_Type_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Member_Type_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Member_Type_Trigger_Instead_Update
	ON  lms.member_type
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a member type', 'Member Type'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Member_Type_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Member_Type_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Member_Type_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Member_Type_Trigger_Instead_Delete
	ON  lms.member_type
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a member type', 'Member Type'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectMemberType" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectMemberType')
   DROP PROCEDURE lms.SelectMemberType
GO

CREATE PROCEDURE lms.SelectMemberType
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			mtp.member_type_id AS member_type_id,
			mtp.member_type_description AS member_type_description
		FROM
			lms.member_type AS mtp
		ORDER BY
			member_type_description ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a member type', 'Member Type'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectMemberType TO db_lmsusers
GO
-------------------------------------------------------------

-- ################################################END TABLE "member_type" OBJECTS###################################################






-- ################################################TABLE "member_information" OBJECTS######################################################
-- verifies if the member_information table exists
IF OBJECT_ID('lms.member_information', 'U') IS NOT NULL
	DROP TABLE lms.member_information
GO

CREATE TABLE lms.member_information 			
(
	sysid_member varchar (50) NOT NULL
		CONSTRAINT Member_Information_SysID_Member_PK PRIMARY KEY (sysid_member)
		CONSTRAINT Member_Information_SysID_Member_CK CHECK (sysid_member LIKE 'SYSMEM%'),
	member_id varchar (50) NOT NULL
		CONSTRAINT Member_Information_Member_ID_UQ UNIQUE (member_id),
	membership_date datetime NOT NULL DEFAULT (GETDATE()),
	member_type_id varchar (50) NOT NULL
		CONSTRAINT Member_Informatin_Member_Type_ID_FK FOREIGN KEY REFERENCES lms.member_type(member_type_id) ON UPDATE NO ACTION,
	classification_id varchar (50) NOT NULL
		CONSTRAINT Member_Information_Classification_ID_FK FOREIGN KEY REFERENCES lms.member_classification(classification_id) ON UPDATE NO ACTION,
	reason_for_membership varchar (MAX) NULL,
	other_coop_membership varchar (MAX) NULL,
	certification_information varchar (MAX) NULL,
	other_member_information varchar (MAX) NULL,
	
	is_active bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Member_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Member_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Member_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the member_information table 
CREATE INDEX Member_Information_SysID_Member_Index
	ON lms.member_information (sysid_member ASC)
GO
------------------------------------------------------------------

-- ##############################################END TABLE "member_information" OBJECTS######################################################





-- ################################################TABLE "collector_information" OBJECTS######################################################
-- verifies if the collector_information table exists
IF OBJECT_ID('lms.collector_information', 'U') IS NOT NULL
	DROP TABLE lms.collector_information
GO

CREATE TABLE lms.collector_information 			
(
	sysid_collector varchar (50) NOT NULL
		CONSTRAINT Collector_Information_SysID_Collector_PK PRIMARY KEY (sysid_collector)
		CONSTRAINT Collector_Information_SysID_Collector_CK CHECK (sysid_collector LIKE 'SYSCOL%'),
	employee_id varchar (50) NOT NULL
		CONSTRAINT Collector_Information_Employee_ID_UQ UNIQUE (employee_id),
	other_collector_information varchar (MAX) NULL,
	is_active bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Collector_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Collector_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Collector_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the collector_information table 
CREATE INDEX Collector_Information_SysID_Collector_Index
	ON lms.collector_information (sysid_collector ASC)
GO
------------------------------------------------------------------

-- ##############################################END TABLE "collector_information" OBJECTS######################################################





-- ######################################RESTORE DEPENDENT TABLE CONSTRAINTS#############################################################

--verifies if the Member_Relationship_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information WITH NOCHECK
	ADD CONSTRAINT Member_Relationship_Information_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Member_Relationship_Information_In_Relationship_With_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.member_relationship_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_relationship_information WITH NOCHECK
	ADD CONSTRAINT Member_Relationship_Information_In_Relationship_With_SysID_Member_FK FOREIGN KEY (in_relationship_with_sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Information_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------	

--verifies if the Collateral_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collateral_information WITH NOCHECK
	ADD CONSTRAINT Collateral_Information_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_CoMaker_SysID_CoMaker_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_comaker WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_CoMaker_SysID_CoMaker_FK FOREIGN KEY (sysid_comaker) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Other_Creditor_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information WITH NOCHECK
	ADD CONSTRAINT Other_Creditor_Information_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Information_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_information WITH NOCHECK
	ADD CONSTRAINT Share_Capital_Information_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Information_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_information WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Information_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Debit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_debit WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Debit_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit WITH NOCHECK
	ADD CONSTRAINT Share_Capital_Credit_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Member_Equity_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit WITH NOCHECK
	ADD CONSTRAINT Member_Equity_Credit_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit WITH NOCHECK
	ADD CONSTRAINT In_House_Hospitalization_Credit_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income WITH NOCHECK
	ADD CONSTRAINT Miscellaneous_Income_SysID_Member_FK FOREIGN KEY (sysid_member) REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Miscellaneous_Income_SysID_Collector_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income WITH NOCHECK
	ADD CONSTRAINT Miscellaneous_Income_SysID_Collector_FK FOREIGN KEY (sysid_collector) REFERENCES lms.collector_information(sysid_collector) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

-- ###################################END RESTORE DEPENDENT TABLE CONSTRAINTS############################################################




-- ############################################INITIAL DATABASE INFORMATION#############################################################
--lms.member_classification
INSERT INTO lms.member_classification(classification_id, classification_description)
	SELECT 'MCS001', 'MIGS'
	UNION ALL
	SELECT 'MCS002', 'NON-MIGS'
	UNION ALL
	SELECT 'MCS003', 'NON-MIGS (New)'

--lms.member_type
INSERT INTO lms.member_type(member_type_id, member_type_description)
	SELECT 'MTP001', 'Regular'
	UNION ALL
	SELECT 'MTP002', 'Casual'

-- ##########################################END INITIAL DATABASE INFORMATION#############################################################




