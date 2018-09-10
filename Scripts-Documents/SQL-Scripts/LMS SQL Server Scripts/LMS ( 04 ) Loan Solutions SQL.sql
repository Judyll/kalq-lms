  /********************************************************/
/* This SQL Statements is used for the					*/
/* 		Loan Management System (LMS)					*/
/*Programmed by: Judyll Mark T. Agan					*/
/*Date created: May 03, 2010							*/
/*LOAN SOLUTIONS [ 4 ]									*/
/********************************************************/

USE db_lmsdev_03092010
GO


-- ###########################################DROP TABLE CONSTRAINTS ##############################################################

--verifies if the Regular_Loan_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information
	DROP CONSTRAINT Regular_Loan_Information_SysID_Member_FK
END
GO
-----------------------------------------------------	
 
--verifies if the Regular_Loan_Information_Regular_Loan_Type_ID_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information
	DROP CONSTRAINT Regular_Loan_Information_Regular_Loan_Type_ID_FK
END
GO
-----------------------------------------------------	

--verifies if the Regular_Loan_Information_Repayment_ID_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_information
	DROP CONSTRAINT Regular_Loan_Information_Repayment_ID_FK
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

--verifies if the Regular_Loan_Amortization_SysID_Regular_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_amortization', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_amortization
	DROP CONSTRAINT Regular_Loan_Amortization_SysID_Regular_FK
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

--verifies if the Regular_Loan_Document_SysID_Regular_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_document
	DROP CONSTRAINT Regular_Loan_Document_SysID_Regular_FK
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

--verifies if the Collateral_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.collateral_information
	DROP CONSTRAINT Collateral_Information_SysID_Member_FK
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

--verifies if the Regular_Loan_Collateral_SysID_Regular_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_collateral', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_collateral
	DROP CONSTRAINT Regular_Loan_Collateral_SysID_Regular_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Collateral_SysID_Collateral_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_collateral', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_collateral
	DROP CONSTRAINT Regular_Loan_Collateral_SysID_Collateral_FK
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

--verifies if the Regular_Loan_CoMaker_SysID_Regular_FK constraint exists--
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_comaker
	DROP CONSTRAINT Regular_Loan_CoMaker_SysID_Regular_FK
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

--verifies if the Other_Creditor_Information_SysID_Member_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information
	DROP CONSTRAINT Other_Creditor_Information_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Other_Creditor_Information_Repayment_ID_FK constraint exists--
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.other_creditor_information
	DROP CONSTRAINT Other_Creditor_Information_Repayment_ID_FK
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

-- #########################################END DROP TABLE CONSTRAINTS ##############################################################





-- ########################################DROP DEPENDENT TABLE CONSTRAINTS ##############################################################

--verifies if the Regular_Loan_Charges_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges
	DROP CONSTRAINT Regular_Loan_Charges_SysID_Regular_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Charges_SysID_Regular_Forwarded_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges
	DROP CONSTRAINT Regular_Loan_Charges_SysID_Regular_Forwarded_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Additions_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions
	DROP CONSTRAINT Regular_Loan_Additions_SysID_Regular_FK
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Information_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information
	DROP CONSTRAINT Disbursement_Voucher_Information_SysID_Regular_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments
	DROP CONSTRAINT Regular_Loan_Payments_SysID_Regular_FK
END
GO
-----------------------------------------------------


-- ######################################END DROP DEPENDENT TABLE CONSTRAINTS ##############################################################






-- ################################################TABLE "regular_loan_type" OBJECTS######################################################
-- verifies if the regular_loan_type table existss
IF OBJECT_ID('lms.regular_loan_type', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_type
GO

CREATE TABLE lms.regular_loan_type 			
(
	regular_loan_type_id varchar (50) NOT NULL 
		CONSTRAINT Regular_Loan_Type_ID_PK PRIMARY KEY (regular_loan_type_id)
		CONSTRAINT Regular_Loan_Type_ID_CK CHECK (regular_loan_type_id LIKE 'RLTID%'),
	regular_loan_type_description varchar (100) NOT NULL
		CONSTRAINT Regular_Loan_Type_Description_UQ UNIQUE (regular_loan_type_description),
	regular_loan_type_code varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Type_Code_UQ UNIQUE (regular_loan_type_code),
	regular_loan_type_no tinyint NOT NULL
		CONSTRAINT Regular_Loan_Type_No_UQ UNIQUE (regular_loan_type_no),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Type_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the regular_loan_type table 
CREATE INDEX Regular_Loan_Type_Regular_Loan_Type_ID_Index
	ON lms.regular_loan_type (regular_loan_type_id ASC)
GO
------------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Type_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_Type_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Type_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_Type_Trigger_Instead_Update
	ON  lms.regular_loan_type
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a regular loan type', 'Regular Loan Type'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Type_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Type_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Type_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Type_Trigger_Instead_Delete
	ON  lms.regular_loan_type
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a regular loan type', 'Regular Loan Type'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectRegularLoanType" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectRegularLoanType')
   DROP PROCEDURE lms.SelectRegularLoanType
GO

CREATE PROCEDURE lms.SelectRegularLoanType
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			rlt.regular_loan_type_id AS regular_loan_type_id,
			rlt.regular_loan_type_description AS regular_loan_type_description,
			rlt.regular_loan_type_code AS regular_loan_type_code,
			rlt.regular_loan_type_no AS regular_loan_type_no
		FROM
			lms.regular_loan_type AS rlt
		ORDER BY
			regular_loan_type_description ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan type', 'Regular Loan Type'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectRegularLoanType TO db_lmsusers
GO
-------------------------------------------------------------

-- ################################################END TABLE "regular_loan_type" OBJECTS###################################################





-- ################################################TABLE "repayment_schedule" OBJECTS######################################################
-- verifies if the repayment_schedule table existss
IF OBJECT_ID('lms.repayment_schedule', 'U') IS NOT NULL
	DROP TABLE lms.repayment_schedule
GO

CREATE TABLE lms.repayment_schedule 			
(
	repayment_id varchar (50) NOT NULL 
		CONSTRAINT Repayment_Schedule_Repayment_ID_PK PRIMARY KEY (repayment_id)
		CONSTRAINT Repayment_Schedule_Repayment_ID_CK CHECK (repayment_id LIKE 'RPSID%'),
	repayment_description varchar (100) NOT NULL
		CONSTRAINT Repayment_Schedule_Repayment_Description_UQ UNIQUE (repayment_description),
	payments_per_year smallint NOT NULL
		CONSTRAINT Repayment_Schedule_Payments_Per_Year_UQ UNIQUE (payments_per_year),
	repayment_no tinyint NOT NULL
		CONSTRAINT Repayment_Schedule_Repayment_No_UQ UNIQUE (repayment_no),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Repayment_Schedule_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the repayment_schedule table 
CREATE INDEX Repayment_Schedule_Repayment_ID_Index
	ON lms.repayment_schedule (repayment_id ASC)
GO
------------------------------------------------------------------

-- verifies that the trigger "Repayment_Schedule_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Repayment_Schedule_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Repayment_Schedule_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Repayment_Schedule_Trigger_Instead_Update
	ON  lms.repayment_schedule
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a repayment schedule', 'Repayment Schedule'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Repayment_Schedule_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Repayment_Schedule_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Repayment_Schedule_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Repayment_Schedule_Trigger_Instead_Delete
	ON  lms.repayment_schedule
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a repayment schedule', 'Repayment Schedule'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectRepaymentSchedule" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectRepaymentSchedule')
   DROP PROCEDURE lms.SelectRepaymentSchedule
GO

CREATE PROCEDURE lms.SelectRepaymentSchedule
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			rps.repayment_id AS repayment_id,
			rps.repayment_description AS repayment_description,
			rps.payments_per_year AS payments_per_year,
			rps.repayment_no AS repayment_no
		FROM
			lms.repayment_schedule AS rps
		ORDER BY
			repayment_no ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a repayment schedule', 'Repayment Schedule'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectRepaymentSchedule TO db_lmsusers
GO
-------------------------------------------------------------

-- ################################################END TABLE "repayment_schedule" OBJECTS###################################################




-- ################################################TABLE "regular_loan_information" OBJECTS######################################################
-- verifies if the regular_loan_information table exists
IF OBJECT_ID('lms.regular_loan_information', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_information
GO

CREATE TABLE lms.regular_loan_information 			
(
	sysid_regular varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Information_SysID_Regular_PK PRIMARY KEY (sysid_regular)
		CONSTRAINT Regular_Loan_Information_SysID_Regular_CK CHECK (sysid_regular LIKE 'SYSRLI%'),
	sysid_member varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Information_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	account_no varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Information_Account_No_UQ UNIQUE (account_no),
	loan_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	purpose_of_loan varchar (MAX) NOT NULL,
	is_productive bit NOT NULL DEFAULT (0),
	regular_loan_type_id varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Information_Regular_Loan_Type_ID_FK FOREIGN KEY REFERENCES lms.regular_loan_type(regular_loan_type_id) ON UPDATE NO ACTION,
	repayment_id varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Information_Repayment_ID_FK FOREIGN KEY REFERENCES lms.repayment_schedule(repayment_id) ON UPDATE NO ACTION,
	loan_terms smallint NOT NULL DEFAULT (1),
	no_prepaid_interest smallint NOT NULL DEFAULT (0),
	interest_rate float NOT NULL DEFAULT (1.0),
	grace_period tinyint NOT NULL DEFAULT (1),
	is_straight_loan bit NOT NULL DEFAULT (0),
	loan_requirements varchar (MAX) NULL,
	date_applied datetime NOT NULL 
		CONSTRAINT Regular_Loan_Information_Date_Applied_CK CHECK (CONVERT(varchar, date_applied, 109) LIKE '%12:00:00:000AM'),
	date_approved datetime NOT NULL 
		CONSTRAINT Regular_Loan_Information_Date_Approved_CK CHECK (CONVERT(varchar, date_approved, 109) LIKE '%12:00:00:000AM'),
	approval_evaluation varchar (MAX) NULL,
	date_first_payment datetime NOT NULL 
		CONSTRAINT Regular_Loan_Information_Date_First_Payment_CK CHECK (CONVERT(varchar, date_first_payment, 109) LIKE '%12:00:00:000AM'),
	date_maturity datetime NOT NULL 
		CONSTRAINT Regular_Loan_Information_Date_Maturity_CK CHECK (CONVERT(varchar, date_maturity, 109) LIKE '%12:00:00:000AM'),
	penalty_rate float NOT NULL DEFAULT (1.0),
	no_default_payment tinyint NOT NULL DEFAULT (1),

	remarks varchar (MAX) NULL,

		CONSTRAINT Regular_Loan_Information_Loan_Terms_No_Prepaid_Interest_CK CHECK (loan_terms >= no_prepaid_interest),

	is_marked_deleted bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the regular_loan_information table 
CREATE INDEX Regular_Loan_Information_SysID_Regular_Index
	ON lms.regular_loan_information (sysid_regular DESC)
GO
------------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanInformation')
   DROP PROCEDURE lms.InsertRegularLoanInformation
GO

CREATE PROCEDURE lms.InsertRegularLoanInformation
	
	@sysid_regular varchar (50) = '',
	@sysid_member varchar (50) = '',
	@account_no varchar (50) = '',
	@loan_amount decimal (15, 2) = 0.00,
	@purpose_of_loan varchar (MAX) = '',
	@is_productive bit = 0,
	@regular_loan_type_id varchar (50) = '',
	@repayment_id varchar (50) = '',
	@loan_terms smallint = 0,
	@no_prepaid_interest smallint = 0,
	@interest_rate float = 0.0,
	@grace_period tinyint = 0,
	@is_straight_loan bit = 0,
	@loan_requirements varchar (MAX) = '',
	@date_applied datetime,
	@date_approved datetime,
	@approval_evaluation varchar (MAX) = '',
	@date_first_payment datetime,
	@date_maturity datetime,
	@penalty_rate float = 0.0,
	@no_default_payment tinyint = 0,
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_information
		(
			sysid_regular,
			sysid_member,
			account_no,
			loan_amount,
			purpose_of_loan,
			is_productive,
			regular_loan_type_id,
			repayment_id,
			loan_terms,
			no_prepaid_interest,
			interest_rate,
			grace_period,
			is_straight_loan,
			loan_requirements,
			date_applied,
			date_approved,
			approval_evaluation,
			date_first_payment,
			date_maturity,			
			penalty_rate,
			no_default_payment,
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_regular,
			@sysid_member,
			@account_no,
			@loan_amount,
			@purpose_of_loan,
			@is_productive,
			@regular_loan_type_id,
			@repayment_id,
			@loan_terms,
			@no_prepaid_interest,
			@interest_rate,
			@grace_period,
			@is_straight_loan,
			@loan_requirements,
			@date_applied,
			@date_approved,
			@approval_evaluation,
			@date_first_payment,
			@date_maturity,			
			@penalty_rate,
			@no_default_payment,
			@remarks,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a regular loan information', 'Regular Loan Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateRegularLoanInformation')
   DROP PROCEDURE lms.UpdateRegularLoanInformation
GO

CREATE PROCEDURE lms.UpdateRegularLoanInformation
	
	@sysid_regular varchar (50) = '',
	@account_no varchar (50) = '',
	@loan_amount decimal (15, 2) = 0.00,
	@purpose_of_loan varchar (MAX) = '',
	@is_productive bit = 0,
	@regular_loan_type_id varchar (50) = '',
	@repayment_id varchar (50) = '',
	@loan_terms smallint = 0,
	@no_prepaid_interest smallint = 0,
	@interest_rate float = 0.0,
	@grace_period tinyint = 0,
	@is_straight_loan bit = 0,
	@loan_requirements varchar (MAX) = '',
	@date_applied datetime,
	@date_approved datetime,
	@approval_evaluation varchar (MAX) = '',
	@date_first_payment datetime,
	@date_maturity datetime,
	@penalty_rate float = 0.0,
	@no_default_payment tinyint = 0,
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByDisbursementVoucher(@sysid_regular) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.regular_loan_information SET
			account_no = @account_no,
			loan_amount = @loan_amount,
			purpose_of_loan = @purpose_of_loan,
			is_productive = @is_productive,
			regular_loan_type_id = @regular_loan_type_id,
			repayment_id = @repayment_id,
			loan_terms = @loan_terms,
			no_prepaid_interest = @no_prepaid_interest,
			interest_rate = @interest_rate,
			grace_period = @grace_period,
			is_straight_loan = @is_straight_loan,
			loan_requirements = @loan_requirements,
			date_applied = @date_applied,
			date_approved = @date_approved,
			approval_evaluation = @approval_evaluation,
			date_first_payment = @date_first_payment,
			date_maturity = @date_maturity,
			penalty_rate = @penalty_rate,
			no_default_payment = @no_default_payment,
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(sysid_regular = @sysid_regular)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a regular loan information', 'Regular Loan Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanInformation')
   DROP PROCEDURE lms.DeleteRegularLoanInformation
GO

CREATE PROCEDURE lms.DeleteRegularLoanInformation
	
	@sysid_regular varchar (50) = '',

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByDisbursementVoucher(@sysid_regular) = 0)
	BEGIN

		IF EXISTS (SELECT sysid_regular FROM lms.regular_loan_information WHERE sysid_regular = @sysid_regular)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_information SET
				edited_by = @deleted_by
			WHERE
				(sysid_regular = @sysid_regular)

			DELETE FROM lms.regular_loan_information WHERE (sysid_regular = @sysid_regular)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan information', 'Regular Loan Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberListRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberListRegularLoanInformation')
   DROP PROCEDURE lms.SelectBySysIDMemberListRegularLoanInformation
GO

CREATE PROCEDURE lms.SelectBySysIDMemberListRegularLoanInformation

	@sysid_member_list nvarchar (MAX) = '',
	@is_marked_deleted bit = 0,

	@system_user_id varchar (50) = ''
		
AS  

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rli.sysid_regular AS sysid_regular,
			rli.sysid_member AS sysid_member,
			rli.account_no AS account_no,
			rli.loan_amount AS loan_amount,
			rli.purpose_of_loan AS purpose_of_loan,
			CASE WHEN 
					(rli.is_productive = 1)
				THEN
					('PRODUCTIVE LOAN')
				ELSE
					('PROVIDENT LOAN')
				END AS is_productive_string,
			rli.loan_terms AS loan_terms,
			rli.interest_rate AS interest_rate,
			CASE WHEN 
					(rli.is_straight_loan = 1)
				THEN
					('STRAIGHT AMORTIZATION')
				ELSE
					('DIMINISHING BALANCE AMORTIZATION')
				END AS is_straight_string,
			rli.date_first_payment AS date_first_payment,
			rli.date_maturity AS date_maturity,
			
			--rli.regular_loan_type_id
			rlt.regular_loan_type_id AS regular_loan_type_id,
			rlt.regular_loan_type_description AS regular_loan_type_description,
			rlt.regular_loan_type_code AS regular_loan_type_code,
			rlt.regular_loan_type_no AS regular_loan_type_no,

			--rli.repayment_id
			rps.repayment_id AS repayment_id,
			rps.repayment_description AS repayment_description,
			rps.payments_per_year AS payments_per_year,
			rps.repayment_no AS repayment_no,

			'false' AS is_record_locked,

			CASE WHEN (((ISNULL(amortization_amount.payment_amount, 0)) - 1) > (ISNULL(loan_payments.payment_amount, 0) + ISNULL(loan_charges_forwarded.payment_amount, 0)))
							THEN 
								'true'
							ELSE
								'false'
							END AS is_active_loan, 
							
			amortization_amount.payment_amount AS total_amortization_amount,
			(ISNULL(loan_payments.payment_amount, 0) + ISNULL(loan_charges_forwarded.payment_amount, 0)) AS total_loan_payments,
			
			dvi.sysid_voucher AS sysid_voucher,
			dvi.check_no AS check_no,
			dvi.check_date AS check_date

		FROM
			lms.regular_loan_information AS rli
		INNER JOIN
		(
			SELECT --get the summary of all scheduled payment 
				inner_rla.sysid_regular AS sysid_regular,
				ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount
			FROM
				lms.regular_loan_amortization AS inner_rla
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			GROUP BY
				inner_rla.sysid_regular

		) AS amortization_amount ON amortization_amount.sysid_regular = rli.sysid_regular		
		LEFT JOIN 
		(
			SELECT --get the summary of all payments made
				inner_tlp.sysid_regular AS sysid_regular,
				ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) AS payment_amount
			FROM
				lms.regular_loan_payments AS inner_tlp
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			GROUP BY
				inner_tlp.sysid_regular

		) AS loan_payments ON loan_payments.sysid_regular = rli.sysid_regular
		LEFT JOIN 
		(
			SELECT --get the summary of all balance forwarded made
				inner_rlc.sysid_regular_forwarded AS sysid_regular_forwarded,
				ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
			FROM
				lms.regular_loan_charges AS inner_rlc
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rlc.sysid_regular_forwarded
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			GROUP BY
				inner_rlc.sysid_regular_forwarded

		) AS loan_charges_forwarded ON loan_charges_forwarded.sysid_regular_forwarded = rli.sysid_regular
		INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
		INNER JOIN lms.repayment_schedule AS rps ON rps.repayment_id = rli.repayment_id	
		INNER JOIN
		(
			SELECT 
				DISTINCT inner_dvi.sysid_regular AS sysid_regular,
				inner_dvi.sysid_voucher AS sysid_voucher,
				inner_dvi.check_no AS check_no,
				inner_dvi.check_date AS check_date,
				inner_dvi.is_marked_deleted AS is_marked_deleted
			FROM
				lms.disbursement_voucher_information AS inner_dvi			
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_dvi.sysid_regular
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			WHERE
				(NOT inner_dvi.sysid_regular IS NULL) AND
				(inner_dvi.is_marked_deleted = 0)
			
		) AS dvi ON dvi.sysid_regular = rli.sysid_regular
		WHERE
			(rli.is_marked_deleted = @is_marked_deleted)
		UNION ALL
		SELECT
			rli.sysid_regular AS sysid_regular,
			rli.sysid_member AS sysid_member,
			rli.account_no AS account_no,
			rli.loan_amount AS loan_amount,
			rli.purpose_of_loan AS purpose_of_loan,
			CASE WHEN 
					(rli.is_productive = 1)
				THEN
					('PRODUCTIVE LOAN')
				ELSE
					('PROVIDENT LOAN')
				END AS is_productive_string,
			rli.loan_terms AS loan_terms,
			rli.interest_rate AS interest_rate,
			CASE WHEN 
					(rli.is_straight_loan = 1)
				THEN
					('STRAIGHT AMORTIZATION')
				ELSE
					('DIMINISHING BALANCE AMORTIZATION')
				END AS is_straight_string,
			rli.date_first_payment AS date_first_payment,
			rli.date_maturity AS date_maturity,
			
			--rli.regular_loan_type_id
			rlt.regular_loan_type_id AS regular_loan_type_id,
			rlt.regular_loan_type_description AS regular_loan_type_description,
			rlt.regular_loan_type_code AS regular_loan_type_code,
			rlt.regular_loan_type_no AS regular_loan_type_no,

			--rli.repayment_id
			rps.repayment_id AS repayment_id,
			rps.repayment_description AS repayment_description,
			rps.payments_per_year AS payments_per_year,
			rps.repayment_no AS repayment_no,

			'false' AS is_record_locked,

			CASE WHEN (((ISNULL(amortization_amount.payment_amount, 0)) - 1) > (ISNULL(loan_payments.payment_amount, 0) + ISNULL(loan_charges_forwarded.payment_amount, 0)))
							THEN 
								'true'
							ELSE
								'false'
							END AS is_active_loan, 
							
			amortization_amount.payment_amount AS total_amortization_amount,
			(ISNULL(loan_payments.payment_amount, 0) + ISNULL(loan_charges_forwarded.payment_amount, 0)) AS total_loan_payments,
			
			NULL AS sysid_voucher,
			NULL AS check_no,
			NULL AS check_date

		FROM
			lms.regular_loan_information AS rli
		INNER JOIN
		(
			SELECT --get the summary of all scheduled payment amount
				inner_rla.sysid_regular AS sysid_regular,
				ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount
			FROM
				lms.regular_loan_amortization AS inner_rla
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			GROUP BY
				inner_rla.sysid_regular

		) AS amortization_amount ON amortization_amount.sysid_regular = rli.sysid_regular		
		LEFT JOIN 
		(
			SELECT --get the summary of all payments made
				inner_tlp.sysid_regular AS sysid_regular,
				ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) AS payment_amount
			FROM
				lms.regular_loan_payments AS inner_tlp
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			GROUP BY
				inner_tlp.sysid_regular

		) AS loan_payments ON loan_payments.sysid_regular = rli.sysid_regular
		LEFT JOIN 
		(
			SELECT --get the summary of all balance forwarded made
				inner_rlc.sysid_regular_forwarded AS sysid_regular_forwarded,
				ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
			FROM
				lms.regular_loan_charges AS inner_rlc
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rlc.sysid_regular_forwarded
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			GROUP BY
				inner_rlc.sysid_regular_forwarded

		) AS loan_charges_forwarded ON loan_charges_forwarded.sysid_regular_forwarded = rli.sysid_regular
		INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
		INNER JOIN lms.repayment_schedule AS rps ON rps.repayment_id = rli.repayment_id	
		INNER JOIN --this filter only the loans without any created voucher or all vouchers has been deleted and no other voucher is being active 
		(
			SELECT --loan does not have any voucher created
				inner_rli.sysid_regular AS sysid_regular 
			FROM	
				lms.regular_loan_information AS inner_rli
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			LEFT JOIN lms.disbursement_voucher_information AS inner_dvi ON inner_dvi.sysid_regular = inner_rli.sysid_regular
			WHERE
				(inner_dvi.sysid_regular IS NULL)
			UNION ALL
			SELECT --all vouchers has been deleted and no other voucher is being active
				DISTINCT inner_rli.sysid_regular AS sysid_regular --must be distinct on sysid_regular and not sysid_voucher because sometimes a single regular loan has 2 different voucher both are deleted/cancelled.
			FROM	
				lms.regular_loan_information AS inner_rli
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = inner_rli.sysid_member
			INNER JOIN lms.disbursement_voucher_information AS inner_dvi ON inner_dvi.sysid_regular = inner_rli.sysid_regular
			WHERE
				(NOT EXISTS (SELECT * FROM lms.disbursement_voucher_information AS exist_dvi WHERE exist_dvi.is_marked_deleted = 0 AND 
				exist_dvi.sysid_regular = inner_rli.sysid_regular)) AND
				(inner_dvi.is_marked_deleted = 1)			
			
		) AS dvi ON dvi.sysid_regular = rli.sysid_regular
		WHERE			
			(rli.is_marked_deleted = @is_marked_deleted)
		ORDER BY
			rli.sysid_member ASC, rli.date_first_payment ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan information', 'Regular Loan Information'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberListRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularLoanInformation')
   DROP PROCEDURE lms.SelectBySysIDRegularLoanInformation
GO

CREATE PROCEDURE lms.SelectBySysIDRegularLoanInformation

	@sysid_regular varchar (50) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rli.sysid_regular AS sysid_regular,
			rli.sysid_member AS sysid_member,
			rli.account_no AS account_no,
			rli.loan_amount AS loan_amount,
			rli.purpose_of_loan AS purpose_of_loan,
			rli.is_productive AS is_productive,
			rli.loan_terms AS loan_terms,
			rli.no_prepaid_interest AS no_prepaid_interest,
			rli.interest_rate AS interest_rate,
			rli.grace_period AS grace_period,
			rli.is_straight_loan AS is_straight_loan,
			rli.loan_requirements AS loan_requirements,
			rli.date_applied AS date_applied,
			rli.date_approved AS date_approved,
			rli.approval_evaluation AS approval_evaluation,
			rli.date_first_payment AS date_first_payment,
			rli.date_maturity AS date_maturity,
			rli.penalty_rate AS penalty_rate,
			rli.no_default_payment AS no_default_payment,
			rli.remarks AS remarks,			
			
			--rli.regular_loan_type_id
			rlt.regular_loan_type_id AS regular_loan_type_id,
			rlt.regular_loan_type_description AS regular_loan_type_description,
			rlt.regular_loan_type_code AS regular_loan_type_code,
			rlt.regular_loan_type_no AS regular_loan_type_no,

			--rli.repayment_id
			rps.repayment_id AS repayment_id,
			rps.repayment_description AS repayment_description,
			rps.payments_per_year AS payments_per_year,
			rps.repayment_no AS repayment_no,

			'true' AS is_record_locked

		FROM
			lms.regular_loan_information AS rli
		INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
		INNER JOIN lms.repayment_schedule AS rps ON rps.repayment_id = rli.repayment_id	
		INNER JOIN
		(
			SELECT 
				DISTINCT inner_dvi.sysid_regular AS sysid_regular
			FROM
				lms.disbursement_voucher_information AS inner_dvi			
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_dvi.sysid_regular
			WHERE
				(inner_rli.sysid_regular = @sysid_regular) AND
				(inner_dvi.is_marked_deleted = 0)
			
		) AS dvi ON dvi.sysid_regular = rli.sysid_regular
		UNION ALL
		SELECT
			rli.sysid_regular AS sysid_regular,
			rli.sysid_member AS sysid_member,
			rli.account_no AS account_no,
			rli.loan_amount AS loan_amount,
			rli.purpose_of_loan AS purpose_of_loan,
			rli.is_productive AS is_productive,
			rli.loan_terms AS loan_terms,
			rli.no_prepaid_interest AS no_prepaid_interest,
			rli.interest_rate AS interest_rate,
			rli.grace_period AS grace_period,
			rli.is_straight_loan AS is_straight_loan,
			rli.loan_requirements AS loan_requirements,
			rli.date_applied AS date_applied,
			rli.date_approved AS date_approved,
			rli.approval_evaluation AS approval_evaluation,
			rli.date_first_payment AS date_first_payment,
			rli.date_maturity AS date_maturity,
			rli.penalty_rate AS penalty_rate,
			rli.no_default_payment AS no_default_payment,
			rli.remarks AS remarks,			
			
			--rli.regular_loan_type_id
			rlt.regular_loan_type_id AS regular_loan_type_id,
			rlt.regular_loan_type_description AS regular_loan_type_description,
			rlt.regular_loan_type_code AS regular_loan_type_code,
			rlt.regular_loan_type_no AS regular_loan_type_no,

			--rli.repayment_id
			rps.repayment_id AS repayment_id,
			rps.repayment_description AS repayment_description,
			rps.payments_per_year AS payments_per_year,
			rps.repayment_no AS repayment_no,

			'false' AS is_record_locked

		FROM
			lms.regular_loan_information AS rli
		INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
		INNER JOIN lms.repayment_schedule AS rps ON rps.repayment_id = rli.repayment_id	
		LEFT JOIN
		(
			SELECT 
				DISTINCT inner_dvi.sysid_regular AS sysid_regular, --must be distinct on sysid_regular and not sysid_voucher because somethings a single regular loan has 2 different voucher both are deleted/cancelled.
				inner_dvi.is_marked_deleted AS is_marked_deleted
			FROM
				lms.disbursement_voucher_information AS inner_dvi			
			INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_dvi.sysid_regular
			WHERE
				(inner_rli.sysid_regular = @sysid_regular)
			
		) AS dvi ON dvi.sysid_regular = rli.sysid_regular
		WHERE
			((dvi.sysid_regular IS NULL) OR
			((NOT dvi.sysid_regular IS NULL) AND
			(dvi.is_marked_deleted = 1))) AND
			(rli.sysid_regular = @sysid_regular)
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan information', 'Regular Loan Information'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountRegularLoanInformation')
   DROP PROCEDURE lms.SelectCountRegularLoanInformation
GO

CREATE PROCEDURE lms.SelectCountRegularLoanInformation

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT COUNT(rli.sysid_regular) FROM lms.regular_loan_information AS rli

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan information', 'Regular Loan Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountForAccountNoRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountForAccountNoRegularLoanInformation')
   DROP PROCEDURE lms.SelectCountForAccountNoRegularLoanInformation
GO

CREATE PROCEDURE lms.SelectCountForAccountNoRegularLoanInformation

	@regular_loan_type_id varchar (50) = '',
	@date_approved datetime,

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT 
			COUNT(rli.sysid_regular) 
		FROM 
			lms.regular_loan_information AS rli
		WHERE
			(rli.regular_loan_type_id = @regular_loan_type_id) AND
			(YEAR(rli.date_approved) = YEAR(@date_approved)) AND
			(MONTH(rli.date_approved) = MONTH(@date_approved))

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan information', 'Regular Loan Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountForAccountNoRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDRegularLoanInformation')
   DROP PROCEDURE lms.IsExistsSysIDRegularLoanInformation
GO

CREATE PROCEDURE lms.IsExistsSysIDRegularLoanInformation

	@sysid_regular varchar (50) = '',
	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsSysIDRegularLoanInfo(@sysid_regular)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan information', 'Regular Loan Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsAccountNoRegularLoanInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsAccountNoRegularLoanInformation')
   DROP PROCEDURE lms.IsExistsAccountNoRegularLoanInformation
GO

CREATE PROCEDURE lms.IsExistsAccountNoRegularLoanInformation

	@sysid_regular varchar (50) = '',
	@account_no varchar (50) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsAccountNoRegularLoanInfo(@sysid_regular, @account_no)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan information', 'Regular Loan Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsAccountNoRegularLoanInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDRegularLoanInfo" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDRegularLoanInfo') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDRegularLoanInfo
GO

CREATE FUNCTION lms.IsExistsSysIDRegularLoanInfo
(	
	@sysid_regular varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_regular FROM lms.regular_loan_information WHERE sysid_regular = @sysid_regular)
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsExistsAccountNoRegularLoanInfo" function already exist
IF OBJECT_ID (N'lms.IsExistsAccountNoRegularLoanInfo') IS NOT NULL
   DROP FUNCTION lms.IsExistsAccountNoRegularLoanInfo
GO

CREATE FUNCTION lms.IsExistsAccountNoRegularLoanInfo
(	
	@sysid_regular varchar (50) = '',
	@account_no varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_regular FROM lms.regular_loan_information WHERE ((REPLACE(account_no, ' ', '')) LIKE REPLACE(@account_no, ' ', '')) AND 
																				NOT sysid_regular = @sysid_regular)
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ##############################################END TABLE "regular_loan_information" OBJECTS######################################################




-- ################################################TABLE "regular_loan_amortization" OBJECTS######################################################
-- verifies if the regular_loan_amortization table exists
IF OBJECT_ID('lms.regular_loan_amortization', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_amortization
GO

CREATE TABLE lms.regular_loan_amortization 			
(
	amortization_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Regular_Loan_Amortization_Amortization_ID_PK PRIMARY KEY (amortization_id),
	sysid_regular varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Amortization_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION,
	payment_no smallint NOT NULL DEFAULT (1)
		CONSTRAINT Regular_Loan_Amortization_Payment_No_UQ UNIQUE (payment_no, sysid_regular),
	payment_date_from datetime NOT NULL
		CONSTRAINT Regular_Loan_Amortization_Payment_Date_From_CK CHECK (CONVERT(varchar, payment_date_from, 109) LIKE '%12:00:00:000AM')
		CONSTRAINT Regular_Loan_Amortization_Payment_Date_From_UQ UNIQUE (payment_date_from, sysid_regular),
	payment_date_to datetime NOT NULL
		CONSTRAINT Regular_Loan_Amortization_Payment_Date_To_CK CHECK (CONVERT(varchar, payment_date_to, 109) LIKE '%11:59:59:000PM')
		CONSTRAINT Regular_Loan_Amortization_Payment_Date_To_UQ UNIQUE (payment_date_to, sysid_regular),
	payment_date_grace_period datetime NOT NULL
		CONSTRAINT Regular_Loan_Amortization_Payment_Date_Grace_Period_CK CHECK (CONVERT(varchar, payment_date_grace_period, 109) LIKE '%11:59:59:000PM')
		CONSTRAINT Regular_Loan_Amortization_Payment_Date_Grace_Period_UQ UNIQUE (payment_date_grace_period, sysid_regular),

	CONSTRAINT Regular_Loan_Amortization_Payment_Date_Grace_Period_Greater_Or_Equal_Date_To_CK 
		CHECK (payment_date_grace_period >= payment_date_to),

	interest_rate float NOT NULL DEFAULT (1.0),
	balance_beginning decimal (15, 2) NOT NULL DEFAULT (0.00),
	payment_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	principal_paid decimal (15, 2) NOT NULL DEFAULT (0.00),
	interest_paid decimal (15, 2) NOT NULL DEFAULT (0.00),
	balance_ending decimal (15, 2) NOT NULL DEFAULT (0.00),
	penalty_rate float NOT NULL DEFAULT (1.0),

	is_manually_computed bit NOT NULL DEFAULT (0),
	remarks varchar (MAX) NULL,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Amortization_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_Amortization_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Amortization_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the regular_loan_amortization table 
CREATE INDEX Regular_Loan_Amortization_Amortization_ID_Index
	ON lms.regular_loan_amortization (amortization_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Amortization_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_Amortization_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Amortization_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_Amortization_Trigger_Insert
	ON  lms.regular_loan_amortization
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @amortization_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @payment_no smallint
	DECLARE @payment_date_from datetime
	DECLARE @payment_date_to datetime
	DECLARE @payment_date_grace_period datetime
	DECLARE @interest_rate float
	DECLARE @balance_beginning decimal (15, 2)
	DECLARE @payment_amount decimal (15, 2)
	DECLARE @principal_paid decimal (15, 2)
	DECLARE @interest_paid decimal (15, 2)
	DECLARE @balance_ending decimal (15, 2)
	DECLARE @penalty_rate float

	DECLARE @is_manually_computed bit
	DECLARE @remarks varchar (MAX)

	DECLARE @created_by varchar (50)

	DECLARE @manually_computed_string varchar (20)
	
	SELECT 
		@amortization_id = i.amortization_id,
		@sysid_regular = i.sysid_regular, 
		@payment_no = i.payment_no,
		@payment_date_from = i.payment_date_from,
		@payment_date_to = i.payment_date_to,
		@payment_date_grace_period = i.payment_date_grace_period,
		@interest_rate = i.interest_rate,
		@balance_beginning = i.balance_beginning,
		@payment_amount = i.payment_amount,
		@principal_paid = i.principal_paid,
		@interest_paid = i.interest_paid,
		@balance_ending = i.balance_ending,
		@penalty_rate = i.penalty_rate,

		@is_manually_computed = i.is_manually_computed,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	IF (@is_manually_computed = 1)
	BEGIN
		SET @manually_computed_string = 'YES'
	END
	ELSE
	BEGIN
		SET @manually_computed_string = 'NO'
	END

	SET @transaction_done = 'CREATED a new regular loan amortization ' + 
							'[Amortization ID: ' + ISNULL(CONVERT(varchar, @amortization_id), '') +
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
													WHERE
														(rli.sysid_regular = @sysid_regular)), '') +
							'][Account No.: ' + ISNULL((SELECT
															rli.account_no
														FROM
															lms.regular_loan_information AS rli
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Payment No.: ' + ISNULL(CONVERT(varchar, @payment_no), '') +	
							'][Payment Date From: ' + ISNULL(CONVERT(varchar, @payment_date_from, 101), '') +	
							'][Payment Date To: ' + ISNULL(CONVERT(varchar, @payment_date_to, 101), '') +	
							'][Payment Date Grace Period: ' + ISNULL(CONVERT(varchar, @payment_date_grace_period, 101), '') +	
							'][Interest Rate: ' + ISNULL(CONVERT(varchar, @interest_rate), '') + '%' +				
							'][Balance Beginning: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_beginning), 1), '0.00') +				
							'][Payment Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') +
							'][Principal Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') +							
							'][Interest Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') +														
							'][Balance Ending: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_ending), 1), '0.00') +
							'][Penalty Rate: ' + ISNULL(CONVERT(varchar, @penalty_rate), '') + '%' +

							'][Is Manually Computed: ' + ISNULL(@manually_computed_string, '') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Amortization_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_Amortization_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Amortization_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_Amortization_Trigger_Instead_Update
	ON  lms.regular_loan_amortization
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @amortization_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @payment_no smallint
	DECLARE @payment_date_from datetime
	DECLARE @payment_date_to datetime
	DECLARE @payment_date_grace_period datetime
	DECLARE @interest_rate float
	DECLARE @balance_beginning decimal (15, 2)
	DECLARE @payment_amount decimal (15, 2)
	DECLARE @principal_paid decimal (15, 2)
	DECLARE @interest_paid decimal (15, 2)
	DECLARE @balance_ending decimal (15, 2)
	DECLARE @penalty_rate float

	DECLARE @is_manually_computed bit
	DECLARE @remarks varchar (MAX)

	DECLARE @edited_by varchar(50)

	DECLARE @payment_no_b smallint
	DECLARE @payment_date_from_b datetime
	DECLARE @payment_date_to_b datetime
	DECLARE @payment_date_grace_period_b datetime
	DECLARE @interest_rate_b float
	DECLARE @balance_beginning_b decimal (15, 2)
	DECLARE @payment_amount_b decimal (15, 2)
	DECLARE @principal_paid_b decimal (15, 2)
	DECLARE @interest_paid_b decimal (15, 2)
	DECLARE @balance_ending_b decimal (15, 2)
	DECLARE @penalty_rate_b float

	DECLARE @is_manually_computed_b bit
	DECLARE @remarks_b varchar (MAX)
	
	DECLARE @manually_computed_string varchar (20)
	DECLARE @manually_computed_string_b varchar (20)

	DECLARE @has_update bit

	DECLARE regular_loan_amortization_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.amortization_id, i.sysid_regular, i.payment_no, i.payment_date_from, i.payment_date_to,
					i.payment_date_grace_period, i.interest_rate, i.balance_beginning, i.payment_amount, i.principal_paid, i.interest_paid,
					i.balance_ending, i.penalty_rate, i.is_manually_computed, i.remarks, i.edited_by
				FROM INSERTED AS i

	OPEN regular_loan_amortization_update_cursor

	FETCH NEXT FROM regular_loan_amortization_update_cursor
		INTO @amortization_id, @sysid_regular, @payment_no, @payment_date_from, @payment_date_to,
					@payment_date_grace_period, @interest_rate, @balance_beginning, @payment_amount, @principal_paid, @interest_paid,
					@balance_ending, @penalty_rate, @is_manually_computed, @remarks, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		SELECT 
			@payment_no_b = rla.payment_no,
			@payment_date_from_b = rla.payment_date_from,
			@payment_date_to_b = rla.payment_date_to,
			@payment_date_grace_period_b = rla.payment_date_grace_period,
			@interest_rate_b = rla.interest_rate,
			@balance_beginning_b = rla.balance_beginning,
			@payment_amount_b = rla.payment_amount,
			@principal_paid_b = rla.principal_paid,
			@interest_paid_b = rla.interest_paid,
			@balance_ending_b = rla.balance_ending,
			@penalty_rate_b = rla.penalty_rate,

			@is_manually_computed_b = rla.is_manually_computed,
			@remarks_b = rla.remarks
		FROM 
			lms.regular_loan_amortization AS rla
		WHERE
			(rla.amortization_id = @amortization_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT @payment_no = @payment_no_b)
		BEGIN
			SET @transaction_done = @transaction_done + '[Payment No. Before: ' + ISNULL(CONVERT(varchar, @payment_no_b), '') + ']' +
														'[Payment No. After: ' + ISNULL(CONVERT(varchar, @payment_no), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Payment No.: ' + ISNULL(CONVERT(varchar, @payment_no), '') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, @payment_date_from, 101), '') = ISNULL(CONVERT(varchar, @payment_date_from_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Payment Date From Before: ' + ISNULL(CONVERT(varchar, @payment_date_from_b, 101), '') + ']' +
														'[Payment Date From After: ' + ISNULL(CONVERT(varchar, @payment_date_from, 101), '') + ']'
			SET @has_update = 1	
		END

		IF (NOT ISNULL(CONVERT(varchar, @payment_date_to, 101), '') = ISNULL(CONVERT(varchar, @payment_date_to_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Payment Date To Before: ' + ISNULL(CONVERT(varchar, @payment_date_to_b, 101), '') + ']' +
														'[Payment Date To After: ' + ISNULL(CONVERT(varchar, @payment_date_to, 101), '') + ']'
			SET @has_update = 1	
		END

		IF (NOT ISNULL(CONVERT(varchar, @payment_date_grace_period, 101), '') = ISNULL(CONVERT(varchar, @payment_date_grace_period_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Payment Date Grace Period Before: ' + ISNULL(CONVERT(varchar, @payment_date_grace_period_b, 101), '') + ']' +
														'[Payment Date Grace Period After: ' + ISNULL(CONVERT(varchar, @payment_date_grace_period, 101), '') + ']'
			SET @has_update = 1	
		END

		IF (NOT ISNULL(CONVERT(varchar, @interest_rate), '') = ISNULL(CONVERT(varchar, @interest_rate_b), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Interest Rate Before: ' + ISNULL(CONVERT(varchar, @interest_rate_b), '') +  ']' +
														'[Interest Rate After: ' + ISNULL(CONVERT(varchar, @interest_rate), '') +  ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @balance_beginning), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @balance_beginning_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Balance Beginning Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_beginning_b), 1), '0.00') + ']' +
														'[Balance Beginning After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_beginning), 1), '0.00') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Payment Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount_b), 1), '0.00') + ']' +
														'[Payment Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Principal Paid Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid_b), 1), '0.00') + ']' +
														'[Principal Paid After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Interest Paid Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid_b), 1), '0.00') + ']' +
														'[Interest Paid After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @balance_ending), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @balance_ending_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Balance Ending Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_ending_b), 1), '0.00') + ']' +
														'[Balance Ending After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_ending), 1), '0.00') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, @penalty_rate), '') = ISNULL(CONVERT(varchar, @penalty_rate_b), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Penalty Rate Before: ' + ISNULL(CONVERT(varchar, @penalty_rate_b), '') + '%' + ']' +
														'[Penalty Rate After: ' + ISNULL(CONVERT(varchar, @penalty_rate), '') + '%' + ']'
			SET @has_update = 1
		END

		IF (NOT @is_manually_computed = @is_manually_computed_b)
		BEGIN

			IF (@is_manually_computed = 1)
			BEGIN
				SET @manually_computed_string = 'YES'
			END
			ELSE
			BEGIN
				SET @manually_computed_string = 'NO'
			END

			IF (@is_manually_computed_b = 1)
			BEGIN
				SET @manually_computed_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @manually_computed_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Manually Computed Before: ' + ISNULL(@manually_computed_string_b, '') + ']' +
														'[Is Manually Computed After: ' + ISNULL(@manually_computed_string, '') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') + ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') + ']'
			SET @has_update = 1
		END

		IF (@has_update = 1)
		BEGIN

			UPDATE lms.regular_loan_amortization SET
				payment_no = @payment_no,
				payment_date_from = @payment_date_from,
				payment_date_to = @payment_date_to,
				payment_date_grace_period = @payment_date_grace_period,
				interest_rate = @interest_rate,
				balance_beginning = @balance_beginning,
				payment_amount = @payment_amount,
				principal_paid = @principal_paid,
				interest_paid = @interest_paid,
				balance_ending = @balance_ending,
				penalty_rate = @penalty_rate,

				is_manually_computed = @is_manually_computed,
				remarks = @remarks,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(amortization_id = @amortization_id)

			SET @transaction_done = 'UPDATED a regular loan amortization ' + 
									'[Amortization ID: ' + ISNULL(CONVERT(varchar, @amortization_id), '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
									'][Account No.: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END

			EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done

		END
		ELSE IF NOT @edited_by IS NULL
		BEGIN

			--used for the delete trigger
			UPDATE lms.regular_loan_amortization SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(amortization_id = @amortization_id)

		END
				
		FETCH NEXT FROM regular_loan_amortization_update_cursor
			INTO @amortization_id, @sysid_regular, @payment_no, @payment_date_from, @payment_date_to,
						@payment_date_grace_period, @interest_rate, @balance_beginning, @payment_amount, @principal_paid, @interest_paid,
						@balance_ending, @penalty_rate, @is_manually_computed, @remarks, @edited_by

	END

	CLOSE regular_loan_amortization_update_cursor
	DEALLOCATE regular_loan_amortization_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Amortization_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Amortization_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Amortization_Trigger_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Amortization_Trigger_Delete
	ON  lms.regular_loan_amortization
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @amortization_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @payment_no smallint
	DECLARE @payment_date_from datetime
	DECLARE @payment_date_to datetime
	DECLARE @payment_date_grace_period datetime
	DECLARE @interest_rate float
	DECLARE @balance_beginning decimal (15, 2)
	DECLARE @payment_amount decimal (15, 2)
	DECLARE @principal_paid decimal (15, 2)
	DECLARE @interest_paid decimal (15, 2)
	DECLARE @balance_ending decimal (15, 2)
	DECLARE @penalty_rate float

	DECLARE @is_manually_computed bit
	DECLARE @remarks varchar (MAX)

	DECLARE @deleted_by varchar(50)
	
	DECLARE @manually_computed_string varchar (20)

	DECLARE regular_loan_amortization_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.amortization_id, d.sysid_regular, d.payment_no, d.payment_date_from, d.payment_date_to, 
					d.payment_date_grace_period, d.interest_rate, d.balance_beginning, d.payment_amount, d.principal_paid, d.interest_paid,
					d.balance_ending, d.penalty_rate, d.is_manually_computed, d.remarks, d.edited_by
				FROM DELETED AS d

	OPEN regular_loan_amortization_delete_cursor

	FETCH NEXT FROM regular_loan_amortization_delete_cursor
		INTO @amortization_id, @sysid_regular, @payment_no, @payment_date_from, @payment_date_to, 
					@payment_date_grace_period, @interest_rate, @balance_beginning, @payment_amount, @principal_paid, @interest_paid,
					@balance_ending, @penalty_rate, @is_manually_computed, @remarks, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF (@is_manually_computed = 1)
		BEGIN
			SET @manually_computed_string = 'YES'
		END
		ELSE
		BEGIN
			SET @manually_computed_string = 'NO'
		END

		SET @transaction_done = 'DELETED a regular loan amortization ' + 
								'[Amortization ID: ' + ISNULL(CONVERT(varchar, @amortization_id), '') +
								'][Member ID: ' + ISNULL((SELECT
																mbi.member_id
															FROM
																lms.member_information AS mbi
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
								'][Name: ' + ISNULL((SELECT 
															pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
														FROM
															lms.person_information AS pri
														INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
														INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
								'][Account No.: ' + ISNULL((SELECT
																rli.account_no
															FROM
																lms.regular_loan_information AS rli
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
								'][Payment No.: ' + ISNULL(CONVERT(varchar, @payment_no), '') +	
								'][Payment Date From: ' + ISNULL(CONVERT(varchar, @payment_date_from, 101), '') +	
								'][Payment Date To: ' + ISNULL(CONVERT(varchar, @payment_date_to, 101), '') +		
								'][Payment Date Grace Period: ' + ISNULL(CONVERT(varchar, @payment_date_grace_period, 101), '') +	
								'][Interest Rate: ' + ISNULL(CONVERT(varchar, @interest_rate), '') + '%' +				
								'][Balance Beginning: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_beginning), 1), '0.00') +				
								'][Payment Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') +
								'][Principal Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') +							
								'][Interest Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') +														
								'][Balance Ending: ' + ISNULL(CONVERT(varchar, CONVERT(money, @balance_ending), 1), '0.00') +
								'][Penalty Rate: ' + ISNULL(CONVERT(varchar, @penalty_rate), '') + '%' +

								'][Is Manually Computed: ' + ISNULL(@manually_computed_string, '') +
								'][Remarks: ' + ISNULL(@remarks, '') +
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
				
		FETCH NEXT FROM regular_loan_amortization_delete_cursor
			INTO @amortization_id, @sysid_regular, @payment_no, @payment_date_from, @payment_date_to, 
						@payment_date_grace_period, @interest_rate, @balance_beginning, @payment_amount, @principal_paid, @interest_paid,
						@balance_ending, @penalty_rate, @is_manually_computed, @remarks, @deleted_by

	END

	CLOSE regular_loan_amortization_delete_cursor
	DEALLOCATE regular_loan_amortization_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanAmortization" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanAmortization')
   DROP PROCEDURE lms.InsertRegularLoanAmortization
GO

CREATE PROCEDURE lms.InsertRegularLoanAmortization
	
	@sysid_regular varchar (50) = '',
	@payment_no smallint = 0,
	@payment_date_from datetime,
	@payment_date_to datetime,
	@payment_date_grace_period datetime,
	@interest_rate float = 0.0,
	@balance_beginning decimal (15, 2) = 0.00,
	@payment_amount decimal (15, 2) = 0.00,
	@principal_paid decimal (15, 2) = 0.00,
	@interest_paid decimal (15, 2) = 0.00,
	@balance_ending decimal (15, 2) = 0.00,
	@penalty_rate float = 0,

	@is_manually_computed bit = 0,
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1) OR
		(lms.IsCashierSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortize(DEFAULT, @sysid_regular, @payment_date_from, @payment_date_to) = 0) AND
		(lms.IsRecordLockByDisbursementVoucher(@sysid_regular) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_amortization
		(
			sysid_regular,
			payment_no,
			payment_date_from,
			payment_date_to,
			payment_date_grace_period,
			interest_rate,
			balance_beginning,
			payment_amount,
			principal_paid,
			interest_paid,
			balance_ending,
			penalty_rate,

			is_manually_computed,
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_regular,
			@payment_no,
			@payment_date_from,
			@payment_date_to,
			@payment_date_grace_period,
			@interest_rate,
			@balance_beginning,
			@payment_amount,
			@principal_paid,
			@interest_paid,
			@balance_ending,
			@penalty_rate,

			@is_manually_computed,
			@remarks,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a regular loan amortization', 'Regular Loan Amortization'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanAmortization TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateRegularLoanAmortization" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateRegularLoanAmortization')
   DROP PROCEDURE lms.UpdateRegularLoanAmortization
GO

CREATE PROCEDURE lms.UpdateRegularLoanAmortization
	
	@amortization_id bigint = 0,
	@payment_no smallint = 0,
	@payment_date_from datetime,
	@payment_date_to datetime,
	@payment_date_grace_period datetime,
	@interest_rate float = 0.0,
	@balance_beginning decimal (15, 2) = 0.00,
	@payment_amount decimal (15, 2) = 0.00,
	@principal_paid decimal (15, 2) = 0.00,
	@interest_paid decimal (15, 2) = 0.00,
	@balance_ending decimal (15, 2) = 0.00,
	@penalty_rate float = 0,

	@is_manually_computed bit = 0,
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1) OR
		(lms.IsCashierSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortize(@amortization_id, 
																	(SELECT
																			sysid_regular
																		FROM
																			lms.regular_loan_amortization
																		WHERE
																			(amortization_id = @amortization_id)), 
																	@payment_date_from, @payment_date_to) = 0)
		--this is commented because loan amortization schedule for a loan which is being forwarded should be updated anytime (ex. interest amount) 															
		-- AND
		--(lms.IsRecordLockByDisbursementVoucher((SELECT
		--											sysid_regular
		--										FROM
		--											lms.regular_loan_amortization
		--										WHERE
		--											(amortization_id = @amortization_id))) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.regular_loan_amortization SET
			payment_no = @payment_no,
			payment_date_from = @payment_date_from,
			payment_date_to = @payment_date_to,
			payment_date_grace_period = @payment_date_grace_period,
			interest_rate = @interest_rate,
			balance_beginning = @balance_beginning,
			payment_amount = @principal_paid + @interest_paid,
			principal_paid = @principal_paid,
			interest_paid = @interest_paid,
			balance_ending = @balance_ending,
			penalty_rate = @penalty_rate,

			is_manually_computed = @is_manually_computed,
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(amortization_id = @amortization_id)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a regular loan amortization', 'Regular Loan Amortization'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateRegularLoanAmortization TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanAmortization" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanAmortization')
   DROP PROCEDURE lms.DeleteRegularLoanAmortization
GO

CREATE PROCEDURE lms.DeleteRegularLoanAmortization
	
	@amortization_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsCashierSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByDisbursementVoucher((SELECT
													sysid_regular
												FROM
													lms.regular_loan_amortization
												WHERE
													(amortization_id = @amortization_id))) = 0)
	BEGIN

		IF EXISTS (SELECT amortization_id FROM lms.regular_loan_amortization WHERE amortization_id = @amortization_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_amortization SET
				edited_by = @deleted_by
			WHERE
				(amortization_id = @amortization_id)

			DELETE FROM lms.regular_loan_amortization WHERE (amortization_id = @amortization_id)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan amortization', 'Regular Loan Amortization'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanAmortization TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularListRegularLoanAmortization" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularListRegularLoanAmortization')
   DROP PROCEDURE lms.SelectBySysIDRegularListRegularLoanAmortization
GO

CREATE PROCEDURE lms.SelectBySysIDRegularListRegularLoanAmortization

	@sysid_regular_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rla.amortization_id AS amortization_id,
			rla.sysid_regular AS sysid_regular,
			rla.payment_no AS payment_no,
			rla.payment_date_from AS payment_date_from,
			rla.payment_date_to AS payment_date_to,
			rla.payment_date_grace_period AS payment_date_grace_period,
			rla.interest_rate AS interest_rate,
			rla.balance_beginning AS balance_beginning,
			rla.payment_amount AS payment_amount,
			rla.principal_paid AS principal_paid,
			rla.interest_paid AS interest_paid,
			rla.balance_ending AS balance_ending,
			rla.penalty_rate AS penalty_rate,

			rla.is_manually_computed AS is_manually_computed,
			rla.remarks AS remarks
		FROM
			lms.regular_loan_amortization AS rla
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srgl_list ON srgl_list.var_str = rla.sysid_regular
		ORDER BY
			rla.sysid_regular ASC, rla.payment_no ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan amortization', 'Regular Loan Amortization'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularListRegularLoanAmortization TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization')
   DROP PROCEDURE lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization
GO

CREATE PROCEDURE lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization

	@amortization_id bigint = 0,
	@sysid_regular varchar (50) = '',
	@payment_date_from datetime,
	@payment_date_to datetime,

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortize(@amortization_id, @sysid_regular, @payment_date_from, @payment_date_to)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan amortization', 'Regular Loan Amortization'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsPaymentDateFromToGracePeriodRegularLoanAmortize" function already exist
IF OBJECT_ID (N'lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortize') IS NOT NULL
   DROP FUNCTION lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortize
GO

CREATE FUNCTION lms.IsExistsPaymentDateFromToGracePeriodRegularLoanAmortize
(	
	@amortization_id bigint = 0,
	@sysid_regular varchar (50) = '',
	@payment_date_from datetime,
	@payment_date_to datetime
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT 
					amortization_id 
				FROM 
					lms.regular_loan_amortization
				WHERE 
					(NOT amortization_id = @amortization_id) AND
					(sysid_regular = @sysid_regular) AND
					((@payment_date_from BETWEEN payment_date_from AND payment_date_to) OR
					(@payment_date_to BETWEEN payment_date_from AND payment_date_to)))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------


-- ###############################################END TABLE "regular_loan_amortization" OBJECTS######################################################





-- ##########################################TABLE "regular_loan_document" OBJECTS########################################################

-- verifies if the regular_loan_document table exists
IF OBJECT_ID('lms.regular_loan_document', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_document
GO

CREATE TABLE lms.regular_loan_document 			
(
	document_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Regular_Loan_Document_Document_ID_PK PRIMARY KEY (document_id),
	sysid_regular varchar (50) NOT NULL 
		CONSTRAINT Regular_Loan_Document_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
		CONSTRAINT Regular_Loan_Document_SysID_Regular_UQ UNIQUE (sysid_regular, original_name),
	
	file_data varbinary (MAX) NOT NULL,
	original_name varchar (255) NOT NULL
		CONSTRAINT Regular_Loan_Document_Original_Name_UQ UNIQUE (original_name, sysid_regular),
	document_information varchar (MAX) NULL,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Document_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_Document_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Document_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the regular_loan_document table 
CREATE INDEX Regular_Loan_Document_Document_ID_Index
	ON lms.regular_loan_document (document_id ASC)
GO
------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Document_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_Document_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Document_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_Document_Trigger_Insert
	ON  lms.regular_loan_document
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @document_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @original_name varchar (255)
	DECLARE @document_information varchar (MAX)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@document_id = i.document_id,
		@sysid_regular = i.sysid_regular,
		@original_name = i.original_name,
		@document_information = i.document_information,

		@created_by = i.created_by
	FROM INSERTED AS i
	
	SET @transaction_done = 'CREATED a regular loan document ' + 
							'[Document ID: ' + ISNULL(CONVERT(varchar, @document_id), '') + 
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
													WHERE
														(rli.sysid_regular = @sysid_regular)), '') +
							'][Account No.: ' + ISNULL((SELECT
															rli.account_no
														FROM
															lms.regular_loan_information AS rli
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Original FileName: ' + ISNULL(@original_name, '') + 
							'][Document Information: ' + ISNULL(@document_information, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done
GO
----------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Document_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Document_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Document_Trigger_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Document_Trigger_Delete
	ON  lms.regular_loan_document
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @document_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @original_name varchar (255)
	DECLARE @document_information varchar (MAX)

	DECLARE @deleted_by varchar (50)

	DECLARE regular_loan_document_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.document_id, d.sysid_regular, d.original_name, d.document_information, d.edited_by
			FROM 
				DELETED AS d

	OPEN regular_loan_document_delete_cursor

	FETCH NEXT FROM regular_loan_document_delete_cursor
		INTO @document_id, @sysid_regular, @original_name, @document_information, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		SET @transaction_done = 'DELETED a regular loan document ' + 
								'[Document ID: ' + ISNULL(CONVERT(varchar, @document_id), '') + 
								'][Member ID: ' + ISNULL((SELECT
																mbi.member_id
															FROM
																lms.member_information AS mbi
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
								'][Name: ' + ISNULL((SELECT 
															pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
														FROM
															lms.person_information AS pri
														INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
														INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
								'][Account No.: ' + ISNULL((SELECT
																rli.account_no
															FROM
																lms.regular_loan_information AS rli
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
								'][Original FileName: ' + ISNULL(@original_name, '') + 
								'][Document Information: ' + ISNULL(@document_information, '') +
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		FETCH NEXT FROM regular_loan_document_delete_cursor
			INTO @document_id, @sysid_regular, @original_name, @document_information, @deleted_by

	END

	CLOSE regular_loan_document_delete_cursor
	DEALLOCATE regular_loan_document_delete_cursor

GO
----------------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanDocument')
   DROP PROCEDURE lms.InsertRegularLoanDocument
GO

CREATE PROCEDURE lms.InsertRegularLoanDocument
	
	@sysid_regular varchar (50) = '',
	
	@file_data varbinary (MAX),
	@original_name varchar (255) = '',
	@document_information varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_document
		(
			sysid_regular,
	
			file_data,
			original_name,
			document_information,

			created_by
		)
		VALUES
		(
			@sysid_regular,
	
			@file_data,
			@original_name,
			@document_information,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a regular loan document', 'Regular Loan Document'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateRegularLoanDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateRegularLoanDocument')
   DROP PROCEDURE lms.UpdateRegularLoanDocument
GO

CREATE PROCEDURE lms.UpdateRegularLoanDocument
	
	@document_id bigint = 0,
	
	@file_data varbinary (MAX),
	@original_name varchar (255) = '',
	@document_information varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		DECLARE @transaction_done varchar(MAX)		

		DECLARE @sysid_regular varchar (50)

		DECLARE @original_name_b varchar (255)
		DECLARE @document_information_b varchar (MAX)

		DECLARE @has_update bit
		
		SELECT 
			@sysid_regular = rld.sysid_regular,
	
			@original_name_b = rld.original_name,
			@document_information_b = rld.document_information
		FROM
			lms.regular_loan_document AS rld
		WHERE 
			rld.document_id = @document_id

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT @file_data = (SELECT file_data FROM lms.person_document WHERE document_id = @document_id))
		BEGIN
			SET @has_update = 1
		END

		IF (NOT ISNULL(@original_name COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@original_name_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Original FileName Before: ' + ISNULL(@original_name_b, '') + ']' +
														'[Original FileName After: ' + ISNULL(@original_name, '') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(@document_information COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@document_information_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Document Information Before: ' + ISNULL(@document_information_b, '') + ']' +
														'[Document Information After: ' + ISNULL(@document_information, '') + ']'
			SET @has_update = 1
		END		

		IF (@has_update = 1)
		BEGIN

			UPDATE lms.regular_loan_document SET
				file_data = @file_data,
				original_name = @original_name,
				document_information = @document_information,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				document_id = @document_id

			SET @transaction_done = 'UPDATED a regular loan document ' + 
									'[Document ID: ' + ISNULL(CONVERT(varchar, @document_id), '') + 
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
									'][Account No.: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END
					
			EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a regular loan document', 'Regular Loan Document'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateRegularLoanDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanDocument')
   DROP PROCEDURE lms.DeleteRegularLoanDocument
GO

CREATE PROCEDURE lms.DeleteRegularLoanDocument
	
	@document_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT document_id FROM lms.regular_loan_document WHERE document_id = @document_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_document SET
				edited_by = @deleted_by
			WHERE
				document_id = @document_id

			DELETE FROM lms.regular_loan_document WHERE document_id = @document_id	

		END	

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan document', 'Regular Loan Document'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularListRegularLoanDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularListRegularLoanDocument')
   DROP PROCEDURE lms.SelectBySysIDRegularListRegularLoanDocument
GO

CREATE PROCEDURE lms.SelectBySysIDRegularListRegularLoanDocument

	@sysid_regular_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT 
			rld.document_id AS document_id,
			rld.sysid_regular AS sysid_regular,
			rld.file_data AS file_data,
			rld.original_name AS original_name,
			rld.document_information AS document_information
		FROM 
			lms.regular_loan_document AS rld
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srl_list ON srl_list.var_str = rld.sysid_regular
		WHERE
			(NOT rld.file_data IS NULL) AND
			(NOT rld.original_name IS NULL)
		ORDER BY
			rld.sysid_regular ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan document', 'Regular Loan Document'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularListRegularLoanDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDRegularOriginalNameRegularLoanDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDRegularOriginalNameRegularLoanDocument')
   DROP PROCEDURE lms.IsExistsSysIDRegularOriginalNameRegularLoanDocument
GO

CREATE PROCEDURE lms.IsExistsSysIDRegularOriginalNameRegularLoanDocument

	@document_id bigint = 0,
	@sysid_regular varchar (50) = '',
	@original_name varchar (255) = '',
	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsSysIDRegularOriginalNameRegularLoanDoc(@document_id, @sysid_regular, @original_name)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan document', 'Regular Loan Document'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDRegularOriginalNameRegularLoanDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDRegularOriginalNameRegularLoanDoc" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDRegularOriginalNameRegularLoanDoc') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDRegularOriginalNameRegularLoanDoc
GO

CREATE FUNCTION lms.IsExistsSysIDRegularOriginalNameRegularLoanDoc
(	
	@document_id bigint = 0,
	@sysid_regular varchar (50) = '',	
	@original_name varchar (255) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_regular FROM lms.regular_loan_document WHERE (NOT document_id = @document_id) AND (sysid_regular = @sysid_regular) AND
									((REPLACE(original_name, ' ', '')) LIKE REPLACE(@original_name, ' ', '')))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ##########################################END TABLE "regular_loan_document" OBJECTS########################################################





-- ################################################TABLE "collateral_information" OBJECTS######################################################
-- verifies if the collateral_information table exists
IF OBJECT_ID('lms.collateral_information', 'U') IS NOT NULL
	DROP TABLE lms.collateral_information
GO

CREATE TABLE lms.collateral_information 			
(
	sysid_collateral varchar (50) NOT NULL
		CONSTRAINT Collateral_Information_SysID_Collateral_PK PRIMARY KEY (sysid_collateral)
		CONSTRAINT Collateral_Information_SysID_Collateral_CK CHECK (sysid_collateral LIKE 'SYSCLI%'),
	sysid_member varchar (50) NOT NULL
		CONSTRAINT Collateral_Information_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	property_type varchar (100) NOT NULL,
	property_brand varchar (100) NOT NULL,
	serial_no varchar (50) NOT NULL,
	purchase_price decimal (15, 2) NOT NULL DEFAULT (0.00),
	year_purchased varchar (50) NOT NULL,
	estimated_appraised_value decimal (15, 2) NOT NULL DEFAULT (0.00),	
	remarks varchar (MAX) NULL,

	is_marked_deleted bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Collateral_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Collateral_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Collateral_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the collateral_information table 
CREATE INDEX Collateral_Information_SysID_Collateral_Index
	ON lms.collateral_information (sysid_collateral DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Collateral_Information_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Collateral_Information_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Collateral_Information_Trigger_Insert
GO

CREATE TRIGGER lms.Collateral_Information_Trigger_Insert
	ON  lms.collateral_information
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_collateral varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @property_type varchar (100)
	DECLARE @property_brand varchar (100)
	DECLARE @serial_no varchar (50)
	DECLARE @purchase_price decimal (15, 2)
	DECLARE @year_purchased varchar (50)
	DECLARE @estimated_appraised_value decimal (15, 2)
	DECLARE @remarks varchar (MAX)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@sysid_collateral = i.sysid_collateral,
		@sysid_member = i.sysid_member,
		@property_type = i.property_type,
		@property_brand = i.property_brand,
		@serial_no = i.serial_no,
		@purchase_price = i.purchase_price,
		@year_purchased = i.year_purchased,
		@estimated_appraised_value = i.estimated_appraised_value,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new collateral information ' + 
							'[Collateral ID: ' + ISNULL(@sysid_collateral, '') +
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														WHERE
															(mbi.sysid_member = @sysid_member)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													WHERE 
														(mbi.sysid_member = @sysid_member)), '') +
							'][Property Type: ' + ISNULL(@property_type, '') +
							'][Property Brand: ' + ISNULL(@property_brand, '') +
							'][Serial No.: ' + ISNULL(@serial_no, '') +
							'][Purchase Price: ' + ISNULL(CONVERT(varchar, CONVERT(money, @purchase_price), 1), '0.00') +
							'][Year Purchased: ' + ISNULL(@year_purchased, '') +
							'][Estimated Appraised Value: ' + ISNULL(CONVERT(varchar, CONVERT(money, @estimated_appraised_value), 1), '0.00') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Collateral_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Collateral_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Collateral_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Collateral_Information_Trigger_Instead_Update
	ON  lms.collateral_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_collateral varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @property_type varchar (100)
	DECLARE @property_brand varchar (100)
	DECLARE @serial_no varchar (50)
	DECLARE @purchase_price decimal (15, 2)
	DECLARE @year_purchased varchar (50)
	DECLARE @estimated_appraised_value decimal (15, 2)
	DECLARE @remarks varchar (MAX)
	DECLARE @is_marked_deleted bit

	DECLARE @edited_by varchar(50)

	DECLARE @sysid_member_b varchar (50)
	DECLARE @property_type_b varchar (100)
	DECLARE @property_brand_b varchar (100)
	DECLARE @serial_no_b varchar (50)
	DECLARE @purchase_price_b decimal (15, 2)
	DECLARE @year_purchased_b varchar (50)
	DECLARE @estimated_appraised_value_b decimal (15, 2)
	DECLARE @remarks_b varchar (MAX)

	DECLARE @has_update bit

	DECLARE collateral_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_collateral, i.sysid_member, i.property_type, i.property_brand, i.serial_no, i.purchase_price, i.year_purchased,
					i.estimated_appraised_value, i.remarks, i.is_marked_deleted, i.edited_by
				FROM INSERTED AS i

	OPEN collateral_information_update_cursor

	FETCH NEXT FROM collateral_information_update_cursor
		INTO @sysid_collateral, @sysid_member, @property_type, @property_brand, @serial_no, @purchase_price, @year_purchased,
					@estimated_appraised_value, @remarks, @is_marked_deleted, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		IF (@is_marked_deleted = 0)
		BEGIN	

			SELECT 
				@sysid_member_b = cli.sysid_member,
				@property_type_b = cli.property_type,
				@property_brand_b = cli.property_brand,
				@serial_no_b = cli.serial_no,
				@purchase_price_b = cli.purchase_price,
				@year_purchased_b = cli.year_purchased,
				@estimated_appraised_value_b = cli.estimated_appraised_value,
				@remarks_b = cli.remarks
			FROM 
				lms.collateral_information AS cli
			WHERE
				(cli.sysid_collateral = @sysid_collateral)

			SET @transaction_done = ''
			SET @has_update = 0

			IF (NOT ISNULL(@sysid_member COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_member_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Member ID Before: ' + ISNULL((SELECT
																								mbi.member_id
																							FROM
																								lms.member_information AS mbi
																							WHERE
																								(mbi.sysid_member = @sysid_member_b)), '') +
															'][Name Before: ' + ISNULL((SELECT 
																							pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
																						FROM
																							lms.person_information AS pri
																						INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																						WHERE 
																							(mbi.sysid_member = @sysid_member_b)), '') + ']' +
															'[Member ID After: ' + ISNULL((SELECT
																								mbi.member_id
																							FROM
																								lms.member_information AS mbi
																							WHERE
																								(mbi.sysid_member = @sysid_member)), '') +
															'][Name After: ' + ISNULL((SELECT 
																							pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
																						FROM
																							lms.person_information AS pri
																						INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																						WHERE 
																							(mbi.sysid_member = @sysid_member)), '') + ']'
				SET @has_update = 1
			END
			ELSE
			BEGIN
				SET @transaction_done = @transaction_done + '[Member ID: ' + ISNULL((SELECT
																							mbi.member_id
																						FROM
																							lms.member_information AS mbi
																						WHERE
																							(mbi.sysid_member = @sysid_member)), '') +
															'][Name: ' + ISNULL((SELECT 
																						pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
																					FROM
																						lms.person_information AS pri
																					INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																					WHERE 
																						(mbi.sysid_member = @sysid_member)), '') + ']'
			END

			IF (NOT ISNULL(@property_type COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@property_type_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Property Type Before: ' + ISNULL(@property_type_b, '') + ']' +
															'[Property Type After: ' + ISNULL(@property_type, '') + ']'
				SET @has_update = 1
			END
			ELSE
			BEGIN
				SET @transaction_done = @transaction_done + '[Property Type: ' + ISNULL(@property_type, '') + ']'
			END

			IF (NOT ISNULL(@property_brand COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@property_brand_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Property Brand Before: ' + ISNULL(@property_brand_b, '') + ']' +
															'[Property Brand After: ' + ISNULL(@property_brand, '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(@serial_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@serial_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Serial No. Before: ' + ISNULL(@serial_no_b, '') + ']' +
															'[Serial No. After: ' + ISNULL(@serial_no, '') + ']'
				SET @has_update = 1
			END
			ELSE
			BEGIN
				SET @transaction_done = @transaction_done + '[Serial No.: ' + ISNULL(@serial_no, '') + ']'
			END

			IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @purchase_price), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @purchase_price_b), 1), '0.00'))
			BEGIN
				SET @transaction_done = @transaction_done + '[Purchase Price Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @purchase_price_b), 1), '0.00') + ']' +
															'[Purchase Price After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @purchase_price), 1), '0.00') + ']'
				SET @has_update = 1	
			END

			IF (NOT ISNULL(@year_purchased COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@year_purchased_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Year Purchased Before: ' + ISNULL(@year_purchased_b, '') + ']' +
															'[Year Purchased After: ' + ISNULL(@year_purchased, '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @estimated_appraised_value), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @estimated_appraised_value_b), 1), '0.00'))
			BEGIN
				SET @transaction_done = @transaction_done + '[Estimated Appraised Value Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @estimated_appraised_value_b), 1), '0.00') + ']' +
															'[Estimated Appraised Value After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @estimated_appraised_value), 1), '0.00') + ']'
				SET @has_update = 1	
			END

			IF (NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') + ']' +
															'[Remarks After: ' + ISNULL(@remarks, '') + ']'
				SET @has_update = 1
			END

			IF (@has_update = 1)
			BEGIN

				UPDATE lms.collateral_information SET
					sysid_member = @sysid_member,
					property_type = @property_type,
					property_brand = @property_brand,
					serial_no = @serial_no,
					purchase_price = @purchase_price,
					year_purchased = @year_purchased,
					estimated_appraised_value = @estimated_appraised_value,
					remarks = @remarks,

					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					sysid_collateral = @sysid_collateral

				SET @transaction_done = 'UPDATED a collateral information ' + 
										'[Collateral ID: ' + ISNULL(@sysid_collateral, '') +
										']' + @transaction_done

				IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
				BEGIN
					SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
				END

				EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done

			END
			ELSE IF NOT @edited_by IS NULL
			BEGIN

				--used for the delete trigger
				UPDATE lms.collateral_information SET
					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					(sysid_collateral = @sysid_collateral)

			END

		END
				
		FETCH NEXT FROM collateral_information_update_cursor
			INTO @sysid_collateral, @sysid_member, @property_type, @property_brand, @serial_no, @purchase_price, @year_purchased,
					@estimated_appraised_value, @remarks, @is_marked_deleted, @edited_by

	END

	CLOSE collateral_information_update_cursor
	DEALLOCATE collateral_information_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Collateral_Information_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Collateral_Information_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Collateral_Information_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Collateral_Information_Trigger_Instead_Delete
	ON  lms.collateral_information
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_collateral varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @property_type varchar (100)
	DECLARE @property_brand varchar (100)
	DECLARE @serial_no varchar (50)
	DECLARE @purchase_price decimal (15, 2)
	DECLARE @year_purchased varchar (50)
	DECLARE @estimated_appraised_value decimal (15, 2)
	DECLARE @remarks varchar (MAX)
	DECLARE @is_marked_deleted bit

	DECLARE @deleted_by varchar(50)

	DECLARE collateral_information_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.sysid_collateral, d.sysid_member, d.property_type, d.property_brand, d.serial_no, d.purchase_price, d.year_purchased,
					d.estimated_appraised_value, d.remarks, d.is_marked_deleted, d.edited_by
				FROM DELETED AS d

	OPEN collateral_information_delete_cursor

	FETCH NEXT FROM collateral_information_delete_cursor
		INTO @sysid_collateral, @sysid_member, @property_type, @property_brand, @serial_no, @purchase_price, @year_purchased,
					@estimated_appraised_value, @remarks, @is_marked_deleted, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF (@is_marked_deleted = 0)
		BEGIN

			UPDATE lms.collateral_information SET 
				is_marked_deleted = 1, 

				edited_on = GETDATE(), 
				edited_by = @deleted_by 
			WHERE 
				(sysid_collateral = @sysid_collateral)

			SET @transaction_done = 'MARK AS DELETED a collateral information ' + 
									'[Collateral ID: ' + ISNULL(@sysid_collateral, '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																WHERE
																	(mbi.sysid_member = @sysid_member)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															WHERE 
																(mbi.sysid_member = @sysid_member)), '') +
									'][Property Type: ' + ISNULL(@property_type, '') +
									'][Property Brand: ' + ISNULL(@property_brand, '') +
									'][Serial No.: ' + ISNULL(@serial_no, '') +
									'][Purchase Price: ' + ISNULL(CONVERT(varchar, CONVERT(money, @purchase_price), 1), '0.00') +
									'][Year Purchased: ' + ISNULL(@year_purchased, '') +
									'][Estimated Appraised Value: ' + ISNULL(CONVERT(varchar, CONVERT(money, @estimated_appraised_value), 1), '0.00') +
									'][Remarks: ' + ISNULL(@remarks, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
			END
					
			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		END
				
		FETCH NEXT FROM collateral_information_delete_cursor
			INTO @sysid_collateral, @sysid_member, @property_type, @property_brand, @serial_no, @purchase_price, @year_purchased,
					@estimated_appraised_value, @remarks, @is_marked_deleted, @deleted_by

	END

	CLOSE collateral_information_delete_cursor
	DEALLOCATE collateral_information_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertCollateralInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertCollateralInformation')
   DROP PROCEDURE lms.InsertCollateralInformation
GO

CREATE PROCEDURE lms.InsertCollateralInformation
	
	@sysid_collateral varchar (50) = '',
	@sysid_member varchar (50) = '',
	@property_type varchar (100) = '',
	@property_brand varchar (100) = '',
	@serial_no varchar (50) = '',
	@purchase_price decimal (15, 2) = 0.00,
	@year_purchased varchar (50) = '',
	@estimated_appraised_value decimal (15, 2) = 0.00,	
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.collateral_information
		(
			sysid_collateral,
			sysid_member,
			property_type,
			property_brand,
			serial_no,
			purchase_price,
			year_purchased,
			estimated_appraised_value,	
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_collateral,
			@sysid_member,
			@property_type,
			@property_brand,
			@serial_no,
			@purchase_price,
			@year_purchased,
			@estimated_appraised_value,	
			@remarks,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a collateral information', 'Collateral Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertCollateralInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateCollateralInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateCollateralInformation')
   DROP PROCEDURE lms.UpdateCollateralInformation
GO

CREATE PROCEDURE lms.UpdateCollateralInformation
	
	@sysid_collateral varchar (50) = '',
	@sysid_member varchar (50) = '',
	@property_type varchar (100) = '',
	@property_brand varchar (100) = '',
	@serial_no varchar (50) = '',
	@purchase_price decimal (15, 2) = 0.00,
	@year_purchased varchar (50) = '',
	@estimated_appraised_value decimal (15, 2) = 0.00,	
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.collateral_information SET
			sysid_member = @sysid_member,
			property_type = @property_type,
			property_brand = @property_brand,
			serial_no = @serial_no,
			purchase_price = @purchase_price,
			year_purchased = @year_purchased,
			estimated_appraised_value = @estimated_appraised_value,	
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(sysid_collateral = @sysid_collateral)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a collateral information', 'Collateral Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateCollateralInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteCollateralInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteCollateralInformation')
   DROP PROCEDURE lms.DeleteCollateralInformation
GO

CREATE PROCEDURE lms.DeleteCollateralInformation
	
	@sysid_collateral varchar (50) = '',

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT sysid_collateral FROM lms.collateral_information WHERE sysid_collateral = @sysid_collateral)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.collateral_information SET
				edited_by = @deleted_by
			WHERE
				(sysid_collateral = @sysid_collateral)

			DELETE FROM lms.collateral_information WHERE (sysid_collateral = @sysid_collateral)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a collateral information', 'Collateral Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteCollateralInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCollateralInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCollateralInformation')
   DROP PROCEDURE lms.SelectCollateralInformation
GO

CREATE PROCEDURE lms.SelectCollateralInformation

	@query_string varchar (50) = '',
	@sysid_collateral_exclude_list nvarchar (MAX) = '',
	@include_marked_deleted bit = 0,

	@system_user_id varchar (50) = ''
		
AS


	--	A - query_string is equal to '*'
	--	B - include sysid_collateral_exclude_list
	--	C - include_marked_deleted

	--	A	B	C
	--	==========
	--	0	0	0
	--	0	0	1
	--	0	1	0
	--	0	1	1
	--	1	0	0
	--	1	0	1
	--	1	1	0
	--	1	1	1

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'

		IF (NOT ISNULL(@query_string, '') = '%*%') AND (ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 0)		--(000)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((cli.property_type LIKE @query_string) OR 
				((REPLACE(cli.property_type, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.property_brand LIKE @query_string) OR 
				((REPLACE(cli.property_brand, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.serial_no LIKE @query_string) OR 
				((REPLACE(cli.serial_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_member LIKE @query_string) OR 
				((REPLACE(mbi.sysid_member, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_person LIKE @query_string) OR 
				((REPLACE(mbi.sysid_person, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.last_name LIKE @query_string) OR 
				((REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.first_name LIKE @query_string) OR
				((REPLACE(pri.first_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.middle_name LIKE @query_string) OR
				((REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				((pri.last_name + ', ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.last_name + ' ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.middle_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.last_name + ',' + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.last_name + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.middle_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + ',' + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(cli.is_marked_deleted = 0)
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 1)		--(001)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((cli.property_type LIKE @query_string) OR 
				((REPLACE(cli.property_type, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.property_brand LIKE @query_string) OR 
				((REPLACE(cli.property_brand, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.serial_no LIKE @query_string) OR 
				((REPLACE(cli.serial_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_member LIKE @query_string) OR 
				((REPLACE(mbi.sysid_member, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_person LIKE @query_string) OR 
				((REPLACE(mbi.sysid_person, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.last_name LIKE @query_string) OR 
				((REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.first_name LIKE @query_string) OR
				((REPLACE(pri.first_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.middle_name LIKE @query_string) OR
				((REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				((pri.last_name + ', ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.last_name + ' ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.middle_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.last_name + ',' + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.last_name + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.middle_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + ',' + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')))
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 0)		--(010)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN lms.IterateListToTable (@sysid_collateral_exclude_list, ',') AS scel_list ON scel_list.var_str = cli.sysid_collateral
			WHERE
				((cli.property_type LIKE @query_string) OR 
				((REPLACE(cli.property_type, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.property_brand LIKE @query_string) OR 
				((REPLACE(cli.property_brand, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.serial_no LIKE @query_string) OR 
				((REPLACE(cli.serial_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_member LIKE @query_string) OR 
				((REPLACE(mbi.sysid_member, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_person LIKE @query_string) OR 
				((REPLACE(mbi.sysid_person, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.last_name LIKE @query_string) OR 
				((REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.first_name LIKE @query_string) OR
				((REPLACE(pri.first_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.middle_name LIKE @query_string) OR
				((REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				((pri.last_name + ', ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.last_name + ' ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.middle_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.last_name + ',' + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.last_name + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.middle_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + ',' + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(cli.is_marked_deleted = 0) AND
				(scel_list.var_str IS NULL)
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 1)		--(011)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN lms.IterateListToTable (@sysid_collateral_exclude_list, ',') AS scel_list ON scel_list.var_str = cli.sysid_collateral
			WHERE
				((cli.property_type LIKE @query_string) OR 
				((REPLACE(cli.property_type, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.property_brand LIKE @query_string) OR 
				((REPLACE(cli.property_brand, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(cli.serial_no LIKE @query_string) OR 
				((REPLACE(cli.serial_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_member LIKE @query_string) OR 
				((REPLACE(mbi.sysid_member, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.sysid_person LIKE @query_string) OR 
				((REPLACE(mbi.sysid_person, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.last_name LIKE @query_string) OR 
				((REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.first_name LIKE @query_string) OR
				((REPLACE(pri.first_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				(pri.middle_name LIKE @query_string) OR
				((REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR 
				((pri.last_name + ', ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.last_name + ' ' + pri.first_name + ' ' + pri.middle_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.middle_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.first_name + ' ' + pri.last_name) LIKE @query_string) OR
				((pri.last_name + ',' + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.last_name + pri.first_name + pri.middle_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.middle_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((pri.first_name + pri.last_name) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + ',' + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.last_name, ' ', '') + REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.middle_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				((REPLACE(pri.first_name, ' ', '') + REPLACE(pri.last_name, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(scel_list.var_str IS NULL)
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 0)		--(100)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				(cli.is_marked_deleted = 0)
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 1)		--(101)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 0)		--(110)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN lms.IterateListToTable (@sysid_collateral_exclude_list, ',') AS scel_list ON scel_list.var_str = cli.sysid_collateral
			WHERE
				(cli.is_marked_deleted = 0) AND
				(scel_list.var_str IS NULL)
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@sysid_collateral_exclude_list, '') = '') AND (@include_marked_deleted = 1)		--(111)
		BEGIN

			SELECT
				cli.sysid_collateral AS sysid_collateral,
				cli.property_type AS property_type,
				cli.property_brand AS property_brand,
				cli.serial_no AS serial_no,
				cli.purchase_price AS purchase_price,
				cli.year_purchased AS year_purchased,
				cli.estimated_appraised_value AS estimated_appraised_value,
				cli.remarks AS remarks,
				cli.is_marked_deleted AS is_marked_deleted,

				--cli.sysid_member
				mbi.sysid_member AS sysid_member,
				mbi.member_id AS member_id,
		
				--mbi.sysid_person
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name
			FROM
				lms.collateral_information AS cli
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN lms.IterateListToTable (@sysid_collateral_exclude_list, ',') AS scel_list ON scel_list.var_str = cli.sysid_collateral
			WHERE
				(scel_list.var_str IS NULL)
			ORDER BY
				cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC

		END
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a collateral information', 'Collateral Information'
		
	END
	
GO
-------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCollateralInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountCollateralInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountCollateralInformation')
   DROP PROCEDURE lms.SelectCountCollateralInformation
GO

CREATE PROCEDURE lms.SelectCountCollateralInformation

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT COUNT(cli.sysid_collateral) FROM lms.collateral_information AS cli

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a collateral information', 'Collateral Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountCollateralInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDCollateralInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDCollateralInformation')
   DROP PROCEDURE lms.IsExistsSysIDCollateralInformation
GO

CREATE PROCEDURE lms.IsExistsSysIDCollateralInformation

	@sysid_collateral varchar (50) = '',
	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsSysIDCollateralInfo(@sysid_collateral)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a collateral information', 'Collateral Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDCollateralInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDCollateralInfo" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDCollateralInfo') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDCollateralInfo
GO

CREATE FUNCTION lms.IsExistsSysIDCollateralInfo
(	
	@sysid_collateral varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_collateral FROM lms.collateral_information WHERE sysid_collateral = @sysid_collateral)
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ###############################################END TABLE "collateral_information" OBJECTS######################################################




-- ################################################TABLE "regular_loan_collateral" OBJECTS######################################################
-- verifies if the regular_loan_collateral table exists
IF OBJECT_ID('lms.regular_loan_collateral', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_collateral
GO

CREATE TABLE lms.regular_loan_collateral 			
(
	loan_collateral_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Regular_Loan_Collateral_Loan_Collateral_ID_PK PRIMARY KEY (loan_collateral_id),
	sysid_regular varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Collateral_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
		CONSTRAINT Regular_Loan_Collateral_SysID_Regular_UQ UNIQUE (sysid_regular, sysid_collateral),
	sysid_collateral varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Collateral_SysID_Collateral_FK FOREIGN KEY REFERENCES lms.collateral_information(sysid_collateral) ON UPDATE NO ACTION
		CONSTRAINT Regular_Loan_Collateral_SysID_Collateral_UQ UNIQUE (sysid_collateral, sysid_regular),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Collateral_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_Collateral_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Collateral_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the regular_loan_collateral table 
CREATE INDEX Regular_Loan_Collateral_Loan_Collateral_ID_Index
	ON lms.regular_loan_collateral (loan_collateral_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Collateral_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_Collateral_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Collateral_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_Collateral_Trigger_Insert
	ON  lms.regular_loan_collateral
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @loan_collateral_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_collateral varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@loan_collateral_id = i.loan_collateral_id,
		@sysid_regular = i.sysid_regular,
		@sysid_collateral = i.sysid_collateral,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new regular loan collateral ' + 
							'[Loan Collateral ID: ' + ISNULL(CONVERT(varchar, @loan_collateral_id), '') +
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
													WHERE
														(rli.sysid_regular = @sysid_regular)), '') +
							'][Account No.: ' + ISNULL((SELECT
															rli.account_no
														FROM
															lms.regular_loan_information AS rli
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Property Type: ' + ISNULL((SELECT
																cli.property_type
															FROM
																lms.collateral_information AS cli
															WHERE
																(cli.sysid_collateral = @sysid_collateral)), '') +
							'][Property Brand: ' + ISNULL((SELECT
																cli.property_brand
															FROM
																lms.collateral_information AS cli
															WHERE
																(cli.sysid_collateral = @sysid_collateral)), '') +
							'][Serial No.: ' + ISNULL((SELECT
															cli.serial_no
														FROM
															lms.collateral_information AS cli
														WHERE
															(cli.sysid_collateral = @sysid_collateral)), '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Collateral_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_Collateral_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Collateral_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_Collateral_Trigger_Instead_Update
	ON  lms.regular_loan_collateral
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @loan_collateral_id bigint

	DECLARE @edited_by varchar(50)

	DECLARE regular_loan_collateral_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.loan_collateral_id, i.edited_by
				FROM INSERTED AS i

	OPEN regular_loan_collateral_update_cursor

	FETCH NEXT FROM regular_loan_collateral_update_cursor
		INTO @loan_collateral_id, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF NOT @edited_by IS NULL
		BEGIN

			--used for the delete trigger
			UPDATE lms.regular_loan_collateral SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(loan_collateral_id = @loan_collateral_id)

		END
		
		FETCH NEXT FROM regular_loan_collateral_update_cursor
			INTO @loan_collateral_id, @edited_by

	END

	CLOSE regular_loan_collateral_update_cursor
	DEALLOCATE regular_loan_collateral_update_cursor

GO
---------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Collateral_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Collateral_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Collateral_Trigger_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Collateral_Trigger_Delete
	ON  lms.regular_loan_collateral
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @loan_collateral_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_collateral varchar (50)

	DECLARE @deleted_by varchar (50)

	DECLARE regular_loan_collateral_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.loan_collateral_id, d.sysid_regular, d.sysid_collateral, d.created_by		
			FROM 
				DELETED AS d

	OPEN regular_loan_collateral_delete_cursor

	FETCH NEXT FROM regular_loan_collateral_delete_cursor
		INTO @loan_collateral_id, @sysid_regular, @sysid_collateral, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

			SET @transaction_done = 'DELETED a regular loan collateral ' + 
									'[Loan Collateral ID: ' + ISNULL(CONVERT(varchar, @loan_collateral_id), '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
									'][Account No.: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Property Type: ' + ISNULL((SELECT
																		cli.property_type
																	FROM
																		lms.collateral_information AS cli
																	WHERE
																		(cli.sysid_collateral = @sysid_collateral)), '') +
									'][Property Brand: ' + ISNULL((SELECT
																		cli.property_brand
																	FROM
																		lms.collateral_information AS cli
																	WHERE
																		(cli.sysid_collateral = @sysid_collateral)), '') +
									'][Serial No.: ' + ISNULL((SELECT
																	cli.serial_no
																FROM
																	lms.collateral_information AS cli
																WHERE
																	(cli.sysid_collateral = @sysid_collateral)), '') +
									']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END

		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
		
		FETCH NEXT FROM regular_loan_collateral_delete_cursor
			INTO @loan_collateral_id, @sysid_regular, @sysid_collateral, @deleted_by

	END

	CLOSE regular_loan_collateral_delete_cursor
	DEALLOCATE regular_loan_collateral_delete_cursor

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanCollateral" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanCollateral')
   DROP PROCEDURE lms.InsertRegularLoanCollateral
GO

CREATE PROCEDURE lms.InsertRegularLoanCollateral
	
	@sysid_regular varchar (50) = '',
	@sysid_collateral varchar (50) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1))		 
	BEGIN																

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_collateral
		(
			sysid_regular,
			sysid_collateral,

			created_by
		)
		VALUES
		(
			@sysid_regular,
			@sysid_collateral,

			@created_by
		)

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a regular loan collateral', 'Regular Loan Collateral'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanCollateral TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanCollateral" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanCollateral')
   DROP PROCEDURE lms.DeleteRegularLoanCollateral
GO

CREATE PROCEDURE lms.DeleteRegularLoanCollateral
	
	@loan_collateral_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))	
	BEGIN

		IF EXISTS (SELECT loan_collateral_id FROM lms.regular_loan_collateral WHERE loan_collateral_id = @loan_collateral_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_collateral SET
				edited_by = @deleted_by
			WHERE
				loan_collateral_id = @loan_collateral_id

			DELETE FROM lms.regular_loan_collateral WHERE loan_collateral_id = @loan_collateral_id

		END

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan collateral', 'Regular Loan Collateral'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanCollateral TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularListRegularLoanCollateral" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularListRegularLoanCollateral')
   DROP PROCEDURE lms.SelectBySysIDRegularListRegularLoanCollateral
GO

CREATE PROCEDURE lms.SelectBySysIDRegularListRegularLoanCollateral

	@sysid_regular_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rlc.loan_collateral_id AS loan_collateral_id,
			rlc.sysid_regular AS sysid_regular,

			cli.sysid_collateral AS sysid_collateral,
			cli.property_type AS property_type,
			cli.property_brand AS property_brand,
			cli.serial_no AS serial_no,
			cli.purchase_price AS purchase_price,
			cli.year_purchased AS year_purchased,
			cli.estimated_appraised_value AS estimated_appraised_value,
			cli.remarks AS remarks,
			cli.is_marked_deleted AS is_marked_deleted,

			mbi.sysid_member AS sysid_member,
			mbi.member_id AS member_id,
			
			pri.last_name AS last_name,
			pri.first_name AS first_name,
			pri.middle_name AS middle_name
		FROM
			lms.regular_loan_collateral AS rlc
		INNER JOIN lms.collateral_information AS cli ON cli.sysid_collateral = rlc.sysid_collateral
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srl_list ON srl_list.var_str = rlc.sysid_regular
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = cli.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		ORDER BY
			cli.property_type ASC, cli.property_brand ASC, cli.serial_no ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan collateral', 'Regular Loan Collateral'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularListRegularLoanCollateral TO db_lmsusers
GO
-------------------------------------------------------------


-- ##############################################END TABLE "regular_loan_collateral" OBJECTS######################################################






-- ################################################TABLE "regular_loan_comaker" OBJECTS######################################################
-- verifies if the regular_loan_comaker table exists
IF OBJECT_ID('lms.regular_loan_comaker', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_comaker
GO

CREATE TABLE lms.regular_loan_comaker 			
(
	comaker_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Regular_Loan_CoMaker_CoMaker_ID_PK PRIMARY KEY (comaker_id),
	sysid_regular varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_CoMaker_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
		CONSTRAINT Regular_Loan_CoMaker_SysID_Regular_UQ UNIQUE (sysid_regular, sysid_comaker),
	sysid_comaker varchar (50) NOT NULL		
		CONSTRAINT Regular_Loan_CoMaker_SysID_CoMaker_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
		CONSTRAINT Regular_Loan_CoMaker_SysID_CoMaker_UQ UNIQUE (sysid_comaker, sysid_regular),
	remarks varchar (MAX) NULL,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_CoMaker_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_CoMaker_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_CoMaker_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the regular_loan_comaker table 
CREATE INDEX Regular_Loan_CoMaker_CoMaker_ID_Index
	ON lms.regular_loan_comaker (comaker_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_CoMaker_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_CoMaker_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_CoMaker_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_CoMaker_Trigger_Insert
	ON  lms.regular_loan_comaker
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @comaker_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_comaker varchar (50)
	DECLARE @remarks varchar (MAX)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@comaker_id = i.comaker_id,
		@sysid_regular = i.sysid_regular,
		@sysid_comaker = i.sysid_comaker,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new regular loan co-maker ' + 
							'[Co-Maker ID: ' + ISNULL(CONVERT(varchar, @comaker_id), '') +
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
													WHERE
														(rli.sysid_regular = @sysid_regular)), '') +
							'][Account No.: ' + ISNULL((SELECT
															rli.account_no
														FROM
															lms.regular_loan_information AS rli
														WHERE
															(rli.sysid_regular = @sysid_regular)), '') +
							'][Co-Maker Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																WHERE
																	(mbi.sysid_member = @sysid_comaker)), '') +
							'][Co-Maker Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															WHERE
																(mbi.sysid_member = @sysid_comaker)), '') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_CoMaker_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_CoMaker_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_CoMaker_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_CoMaker_Trigger_Instead_Update
	ON  lms.regular_loan_comaker
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @comaker_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_comaker varchar (50)
	DECLARE @remarks varchar (MAX)

	DECLARE @edited_by varchar(50)

	DECLARE @remarks_b varchar (MAX)

	DECLARE @has_update bit

	DECLARE regular_loan_comaker_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.comaker_id, i.sysid_regular, i.sysid_comaker, i.remarks, i.edited_by
				FROM INSERTED AS i

	OPEN regular_loan_comaker_update_cursor

	FETCH NEXT FROM regular_loan_comaker_update_cursor
		INTO @comaker_id, @sysid_regular, @sysid_comaker, @remarks, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		SELECT 
			@remarks_b = rlk.remarks
		FROM 
			lms.regular_loan_comaker AS rlk
		WHERE
			rlk.comaker_id = @comaker_id

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') + ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') + ']'
			SET @has_update = 1
		END

		IF (@has_update = 1)
		BEGIN

			UPDATE lms.regular_loan_comaker SET
				remarks = @remarks,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				comaker_id = @comaker_id

			SET @transaction_done = 'UPDATED a regular loan co-maker ' + 
									'[Co-Maker ID: ' + ISNULL(CONVERT(varchar, @comaker_id), '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
									'][Account No.: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Co-Maker Member ID: ' + ISNULL((SELECT
																			mbi.member_id
																		FROM
																			lms.member_information AS mbi
																		WHERE
																			(mbi.sysid_member = @sysid_comaker)), '') +
									'][Co-Maker Name: ' + ISNULL((SELECT 
																		pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
																	FROM
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	WHERE
																		(mbi.sysid_member = @sysid_comaker)), '') + 
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END

			EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done

		END
		ELSE IF NOT @edited_by IS NULL
		BEGIN

			--used for the delete trigger
			UPDATE lms.regular_loan_comaker SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(comaker_id = @comaker_id)

		END
		
		FETCH NEXT FROM regular_loan_comaker_update_cursor
			INTO @comaker_id, @sysid_regular, @sysid_comaker, @remarks, @edited_by

	END

	CLOSE regular_loan_comaker_update_cursor
	DEALLOCATE regular_loan_comaker_update_cursor

GO
---------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_CoMaker_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_CoMaker_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_CoMaker_Trigger_Delete
GO

CREATE TRIGGER lms.Regular_Loan_CoMaker_Trigger_Delete
	ON  lms.regular_loan_comaker
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @comaker_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_comaker varchar (50)
	DECLARE @remarks varchar (MAX)

	DECLARE @deleted_by varchar (50)

	DECLARE regular_loan_comaker_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.comaker_id, d.sysid_regular, d.sysid_comaker, d.remarks, d.created_by		
			FROM 
				DELETED AS d

	OPEN regular_loan_comaker_delete_cursor

	FETCH NEXT FROM regular_loan_comaker_delete_cursor
		INTO @comaker_id, @sysid_regular, @sysid_comaker, @remarks, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

			SET @transaction_done = 'DELETED a regular loan co-maker ' + 
									'[Co-Maker ID: ' + ISNULL(CONVERT(varchar, @comaker_id), '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)), '') +
									'][Account No.: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular)), '') +
									'][Co-Maker Member ID: ' + ISNULL((SELECT
																			mbi.member_id
																		FROM
																			lms.member_information AS mbi
																		WHERE
																			(mbi.sysid_member = @sysid_comaker)), '') +
									'][Co-Maker Name: ' + ISNULL((SELECT 
																		pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
																	FROM
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	WHERE
																		(mbi.sysid_member = @sysid_comaker)), '') +
									'][Remarks: ' + ISNULL(@remarks, '') +
									']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END

		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
		
		FETCH NEXT FROM regular_loan_comaker_delete_cursor
			INTO @comaker_id, @sysid_regular, @sysid_comaker, @remarks, @deleted_by

	END

	CLOSE regular_loan_comaker_delete_cursor
	DEALLOCATE regular_loan_comaker_delete_cursor

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanCoMaker" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanCoMaker')
   DROP PROCEDURE lms.InsertRegularLoanCoMaker
GO

CREATE PROCEDURE lms.InsertRegularLoanCoMaker
	
	@sysid_regular varchar (50) = '',
	@sysid_comaker varchar (50) = '',
	@remarks varchar (MAX) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1))		 
	BEGIN																

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_comaker
		(
			sysid_regular,
			sysid_comaker,
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_regular,
			@sysid_comaker,
			@remarks,

			@created_by
		)

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a regular loan comaker', 'Regular Loan Co-Maker'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanCoMaker TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateRegularLoanCoMaker" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateRegularLoanCoMaker')
   DROP PROCEDURE lms.UpdateRegularLoanCoMaker
GO

CREATE PROCEDURE lms.UpdateRegularLoanCoMaker
	
	@comaker_id bigint = 0,
	@remarks varchar (MAX) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1))	
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.regular_loan_comaker SET
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(comaker_id = @comaker_id)

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a regular loan comaker', 'Regular Loan Co-Maker'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateRegularLoanCoMaker TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanCoMaker" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanCoMaker')
   DROP PROCEDURE lms.DeleteRegularLoanCoMaker
GO

CREATE PROCEDURE lms.DeleteRegularLoanCoMaker
	
	@comaker_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))	
	BEGIN

		IF EXISTS (SELECT comaker_id FROM lms.regular_loan_comaker WHERE comaker_id = @comaker_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_comaker SET
				edited_by = @deleted_by
			WHERE
				(comaker_id = @comaker_id)

			DELETE FROM lms.regular_loan_comaker WHERE (comaker_id = @comaker_id)

		END

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan comaker', 'Regular Loan Co-Maker'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanCoMaker TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularListRegularLoanCoMaker" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularListRegularLoanCoMaker')
   DROP PROCEDURE lms.SelectBySysIDRegularListRegularLoanCoMaker
GO

CREATE PROCEDURE lms.SelectBySysIDRegularListRegularLoanCoMaker

	@sysid_regular_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rlk.comaker_id AS comaker_id,
			rlk.sysid_regular AS sysid_regular,
			rlk.remarks AS remarks,

			mbi.sysid_member AS sysid_member_comaker,
			mbi.member_id AS comaker_member_id,
			
			pri.last_name AS comaker_last_name,
			pri.first_name AS comaker_first_name,
			pri.middle_name AS comaker_middle_name
		FROM
			lms.regular_loan_comaker AS rlk
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rlk.sysid_comaker
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person		
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srl_list ON srl_list.var_str = rlk.sysid_regular
		ORDER BY
			pri.last_name ASC, pri.first_name ASC, pri.middle_name ASC, mbi.member_id ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan comaker', 'Regular Loan Co-Maker'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularListRegularLoanCoMaker TO db_lmsusers
GO
-------------------------------------------------------------



-- ##############################################END TABLE "regular_loan_comaker" OBJECTS######################################################






-- ################################################TABLE "other_creditor_information" OBJECTS######################################################
-- verifies if the other_creditor_information table exists
IF OBJECT_ID('lms.other_creditor_information', 'U') IS NOT NULL
	DROP TABLE lms.other_creditor_information
GO

CREATE TABLE lms.other_creditor_information 			
(
	other_creditor_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Other_Creditor_Information_Other_Creditor_ID_PK PRIMARY KEY (other_creditor_id),
	sysid_member varchar (50) NOT NULL		
		CONSTRAINT Other_Creditor_Information_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	creditor_name varchar (100) NOT NULL,
	date_due datetime NOT NULL 
		CONSTRAINT Other_Creditor_Information_Date_Due_CK CHECK (CONVERT(varchar, date_due, 109) LIKE '%12:00:00:000AM'),
	repayment_id varchar (50) NOT NULL
		CONSTRAINT Other_Creditor_Information_Repayment_ID_FK FOREIGN KEY REFERENCES lms.repayment_schedule(repayment_id) ON UPDATE NO ACTION,	
	amount_owned decimal (15, 2) NOT NULL DEFAULT (0.00),
	amortization_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	remarks varchar (MAX) NULL,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Other_Creditor_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Other_Creditor_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Other_Creditor_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the other_creditor_information table 
CREATE INDEX Other_Creditor_Information_Other_Creditor_ID_Index
	ON lms.other_creditor_information (other_creditor_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Other_Creditor_Information_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Other_Creditor_Information_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Other_Creditor_Information_Trigger_Insert
GO

CREATE TRIGGER lms.Other_Creditor_Information_Trigger_Insert
	ON  lms.other_creditor_information
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @other_creditor_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @creditor_name varchar (100)
	DECLARE @date_due datetime
	DECLARE @repayment_id varchar (50)
	DECLARE @amount_owned decimal (15, 2)
	DECLARE @amortization_amount decimal (15, 2)
	DECLARE @remarks varchar (MAX)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@other_creditor_id = i.other_creditor_id,
		@sysid_member = i.sysid_member,
		@creditor_name = i.creditor_name,
		@date_due = i.date_due,
		@repayment_id = i.repayment_id,
		@amount_owned = i.amount_owned,
		@amortization_amount = i.amortization_amount,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new other creditor information ' + 
							'[Other Creditor ID: ' + ISNULL(CONVERT(varchar, @other_creditor_id), '') +
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														WHERE
															(mbi.sysid_member = @sysid_member)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													WHERE 
														(mbi.sysid_member = @sysid_member)), '') +
							'][Creditor Name: ' + ISNULL(@creditor_name, '') +
							'][Date Due: ' + ISNULL(CONVERT(varchar, @date_due, 101), '') +
							'][Repayment Schedule: ' + (SELECT
															rps.repayment_description + ' (' + ISNULL(CONVERT(varchar, rps.payments_per_year), '') 
																	+ ' payments per year)'
														FROM
															lms.repayment_schedule AS rps
														WHERE
															(rps.repayment_id = @repayment_id)) +
							'][Amount Owned: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_owned), 1), '0.00') +
							'][Amortization Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amortization_amount), 1), '0.00') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Other_Creditor_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Other_Creditor_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Other_Creditor_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Other_Creditor_Information_Trigger_Instead_Update
	ON  lms.other_creditor_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @other_creditor_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @creditor_name varchar (100)
	DECLARE @date_due datetime
	DECLARE @repayment_id varchar (50)
	DECLARE @amount_owned decimal (15, 2)
	DECLARE @amortization_amount decimal (15, 2)
	DECLARE @remarks varchar (MAX)

	DECLARE @edited_by varchar(50)

	DECLARE @creditor_name_b varchar (100)
	DECLARE @date_due_b datetime
	DECLARE @repayment_id_b varchar (50)
	DECLARE @amount_owned_b decimal (15, 2)
	DECLARE @amortization_amount_b decimal (15, 2)
	DECLARE @remarks_b varchar (MAX)

	DECLARE @has_update bit

	DECLARE other_creditor_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.other_creditor_id, i.sysid_member, i.creditor_name, i.date_due, i.repayment_id, i.amount_owned,
					i.amortization_amount, i.remarks, i.edited_by
				FROM INSERTED AS i

	OPEN other_creditor_information_update_cursor

	FETCH NEXT FROM other_creditor_information_update_cursor
		INTO @other_creditor_id, @sysid_member, @creditor_name, @date_due, @repayment_id, @amount_owned,
					@amortization_amount, @remarks, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		SELECT 
			@creditor_name_b = oci.creditor_name,
			@date_due_b = oci.date_due,
			@repayment_id_b = oci.repayment_id,
			@amount_owned_b = oci.amount_owned,
			@amortization_amount_b = oci.amortization_amount,
			@remarks_b = oci.remarks
		FROM 
			lms.other_creditor_information AS oci
		WHERE
			(oci.other_creditor_id = @other_creditor_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(@creditor_name COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@creditor_name_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Creditor Name Before: ' + ISNULL(@creditor_name_b, '') + ']' +
														'[Creditor Name After: ' + ISNULL(@creditor_name, '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Creditor Name: ' + ISNULL(@creditor_name, '') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, @date_due, 101), '') = ISNULL(CONVERT(varchar, @date_due_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Date Due Before: ' + ISNULL(CONVERT(varchar, @date_due_b, 101), '') + ']' +
														'[Date Due After: ' + ISNULL(CONVERT(varchar, @date_due, 101), '') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(@repayment_id COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@repayment_id_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Repayment Schedule Before: ' + (SELECT
																								rps.repayment_description + ' (' + ISNULL(CONVERT(varchar, rps.payments_per_year), '') 
																										+ ' payments per year)'
																							FROM
																								lms.repayment_schedule AS rps
																							WHERE
																								(rps.repayment_id = @repayment_id_b)) + ']' +
														'[Repayment Schedule After: ' + (SELECT
																								rps.repayment_description + ' (' + ISNULL(CONVERT(varchar, rps.payments_per_year), '') 
																										+ ' payments per year)'
																							FROM
																								lms.repayment_schedule AS rps
																							WHERE
																								(rps.repayment_id = @repayment_id)) + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @amount_owned), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amount_owned_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount Owned Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_owned_b), 1), '0.00') + ']' +
														'[Amount Owned After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_owned), 1), '0.00') + ']'
			SET @has_update = 1	
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @amortization_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amortization_amount_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Amortization Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amortization_amount_b), 1), '0.00') + ']' +
														'[Amortization Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amortization_amount), 1), '0.00') + ']'
			SET @has_update = 1	
		END

		IF (NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') + ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') + ']'
			SET @has_update = 1
		END

		IF (@has_update = 1)
		BEGIN

			UPDATE lms.other_creditor_information SET
				creditor_name = @creditor_name,
				date_due = @date_due,
				repayment_id = @repayment_id,
				amount_owned = @amount_owned,
				amortization_amount = @amortization_amount,
				remarks = @remarks,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				other_creditor_id = @other_creditor_id

			SET @transaction_done = 'UPDATED an other creditor information ' + 
									'[Other Creditor ID: ' + ISNULL(CONVERT(varchar, @other_creditor_id), '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																WHERE
																	(mbi.sysid_member = @sysid_member)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															WHERE 
																(mbi.sysid_member = @sysid_member)), '') +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END

			EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done

		END
		ELSE IF NOT @edited_by IS NULL
		BEGIN

			--used for the delete trigger
			UPDATE lms.other_creditor_information SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(other_creditor_id = @other_creditor_id)

		END
				
		FETCH NEXT FROM other_creditor_information_update_cursor
			INTO @other_creditor_id, @sysid_member, @creditor_name, @date_due, @repayment_id, @amount_owned,
						@amortization_amount, @remarks, @edited_by

	END

	CLOSE other_creditor_information_update_cursor
	DEALLOCATE other_creditor_information_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Other_Creditor_Information_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Other_Creditor_Information_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Other_Creditor_Information_Trigger_Delete
GO

CREATE TRIGGER lms.Other_Creditor_Information_Trigger_Delete
	ON  lms.other_creditor_information
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @other_creditor_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @creditor_name varchar (100)
	DECLARE @date_due datetime
	DECLARE @repayment_id varchar (50)
	DECLARE @amount_owned decimal (15, 2)
	DECLARE @amortization_amount decimal (15, 2)
	DECLARE @remarks varchar (MAX)

	DECLARE @deleted_by varchar(50)

	DECLARE other_creditor_information_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.other_creditor_id, d.sysid_member, d.creditor_name, d.date_due, d.repayment_id, d.amount_owned,
					d.amortization_amount, d.remarks, d.edited_by
				FROM DELETED AS d

	OPEN other_creditor_information_delete_cursor

	FETCH NEXT FROM other_creditor_information_delete_cursor
		INTO @other_creditor_id, @sysid_member, @creditor_name, @date_due, @repayment_id, @amount_owned,
					@amortization_amount, @remarks, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		SET @transaction_done = 'DELETED an other creditor information ' + 
								'[Other Creditor ID: ' + ISNULL(CONVERT(varchar, @other_creditor_id), '') +
								'][Member ID: ' + ISNULL((SELECT
																mbi.member_id
															FROM
																lms.member_information AS mbi
															WHERE
																(mbi.sysid_member = @sysid_member)), '') +
								'][Name: ' + ISNULL((SELECT 
															pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
														FROM
															lms.person_information AS pri
														INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
														WHERE 
															(mbi.sysid_member = @sysid_member)), '') +
								'][Creditor Name: ' + ISNULL(@creditor_name, '') +
								'][Date Due: ' + ISNULL(CONVERT(varchar, @date_due, 101), '') +
								'][Repayment Schedule: ' + (SELECT
																rps.repayment_description + ' (' + ISNULL(CONVERT(varchar, rps.payments_per_year), '') 
																		+ ' payments per year)'
															FROM
																lms.repayment_schedule AS rps
															WHERE
																(rps.repayment_id = @repayment_id)) +
								'][Amount Owned: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_owned), 1), '0.00') +
								'][Amortization Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amortization_amount), 1), '0.00') +
								'][Remarks: ' + ISNULL(@remarks, '') +
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
				
		FETCH NEXT FROM other_creditor_information_delete_cursor
			INTO @other_creditor_id, @sysid_member, @creditor_name, @date_due, @repayment_id, @amount_owned,
						@amortization_amount, @remarks, @deleted_by

	END

	CLOSE other_creditor_information_delete_cursor
	DEALLOCATE other_creditor_information_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertOtherCreditorInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertOtherCreditorInformation')
   DROP PROCEDURE lms.InsertOtherCreditorInformation
GO

CREATE PROCEDURE lms.InsertOtherCreditorInformation
	
	@sysid_member varchar (50) = '',
	@creditor_name varchar (100) = '',
	@date_due datetime,
	@repayment_id varchar (50) = '',
	@amount_owned decimal (15, 2) = 0.00,
	@amortization_amount decimal (15, 2) = 0.00,
	@remarks varchar (MAX) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1))		 
	BEGIN																

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.other_creditor_information
		(
			sysid_member,
			creditor_name,
			date_due,
			repayment_id,
			amount_owned,
			amortization_amount,
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_member,
			@creditor_name,
			@date_due,
			@repayment_id,
			@amount_owned,
			@amortization_amount,
			@remarks,

			@created_by
		)

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a other creditor information', 'Other Creditor Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertOtherCreditorInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateOtherCreditorInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateOtherCreditorInformation')
   DROP PROCEDURE lms.UpdateOtherCreditorInformation
GO

CREATE PROCEDURE lms.UpdateOtherCreditorInformation
	
	@other_creditor_id bigint = 0,
	@creditor_name varchar (100) = '',
	@date_due datetime,
	@repayment_id varchar (50) = '',
	@amount_owned decimal (15, 2) = 0.00,
	@amortization_amount decimal (15, 2) = 0.00,
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.other_creditor_information SET
			creditor_name = @creditor_name,
			date_due = @date_due,
			repayment_id = @repayment_id,
			amount_owned = @amount_owned,
			amortization_amount = @amortization_amount,
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(other_creditor_id = @other_creditor_id)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a other creditor information', 'Other Creditor Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateOtherCreditorInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteOtherCreditorInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteOtherCreditorInformation')
   DROP PROCEDURE lms.DeleteOtherCreditorInformation
GO

CREATE PROCEDURE lms.DeleteOtherCreditorInformation
	
	@other_creditor_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT other_creditor_id FROM lms.other_creditor_information WHERE other_creditor_id = @other_creditor_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.other_creditor_information SET
				edited_by = @deleted_by
			WHERE
				(other_creditor_id = @other_creditor_id)

			DELETE FROM lms.other_creditor_information WHERE (other_creditor_id = @other_creditor_id)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a other creditor information', 'Other Creditor Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteOtherCreditorInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberOtherCreditorInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberOtherCreditorInformation')
   DROP PROCEDURE lms.SelectBySysIDMemberOtherCreditorInformation
GO

CREATE PROCEDURE lms.SelectBySysIDMemberOtherCreditorInformation

	@sysid_member varchar (50) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			oci.other_creditor_id AS other_creditor_id,
			oci.creditor_name AS creditor_name,
			oci.date_due AS date_due,
			oci.amount_owned AS amount_owned,
			oci.amortization_amount AS amortization_amount,
			oci.remarks AS remarks,
			
			--oci.repayment_id
			rps.repayment_id AS repayment_id,
			rps.repayment_description AS repayment_description,
			rps.payments_per_year AS payments_per_year,
			rps.repayment_no AS repayment_no
		FROM
			lms.other_creditor_information AS oci
		INNER JOIN lms.repayment_schedule AS rps ON rps.repayment_id = oci.repayment_id
		WHERE
			(oci.sysid_member = @sysid_member)
		ORDER BY
			oci.creditor_name ASC, oci.date_due ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a other creditor information', 'Other Creditor Information'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberOtherCreditorInformation TO db_lmsusers
GO
-------------------------------------------------------------


-- ##############################################END TABLE "other_creditor_information" OBJECTS######################################################







-- ######################################RESTORE DEPENDENT TABLE CONSTRAINTS#############################################################

--verifies if the Regular_Loan_Charges_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Charges_SysID_Regular_FK FOREIGN KEY (sysid_regular) REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Charges_SysID_Regular_Forwarded_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Charges_SysID_Regular_Forwarded_FK FOREIGN KEY (sysid_regular_forwarded) REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Additions_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Additions_SysID_Regular_FK FOREIGN KEY (sysid_regular) REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Information_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information WITH NOCHECK
	ADD CONSTRAINT Disbursement_Voucher_Information_SysID_Regular_FK FOREIGN KEY (sysid_regular) REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments WITH NOCHECK
	ADD CONSTRAINT Regular_Loan_Payments_SysID_Regular_FK  FOREIGN KEY (sysid_regular) REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------


-- ###################################END RESTORE DEPENDENT TABLE CONSTRAINTS############################################################






-- ############################################INITIAL DATABASE INFORMATION#############################################################
--lms.regular_loan_type (CommonExchange.RegularLoanType)
INSERT INTO lms.regular_loan_type (regular_loan_type_id, regular_loan_type_description, regular_loan_type_code, regular_loan_type_no)
	SELECT 'RLTID001', 'Birthday Loan', 'BL', 1
	UNION ALL
	SELECT 'RLTID002', 'Contingency Loan', 'CL', 2
	UNION ALL
	SELECT 'RLTID003', 'Salary Loan', 'SL', 3
	UNION ALL
	SELECT 'RLTID004', 'Medical Loan', 'ML', 4
	UNION ALL
	SELECT 'RLTID005', 'Special Loan', 'PL', 5

--lms.repayment_schedule (CommonExchnage.RepaymentSchedule)
INSERT INTO lms.repayment_schedule (repayment_id, repayment_description, payments_per_year, repayment_no)
	SELECT 'RPSID001', 'Daily', 365, 1
	UNION ALL
	SELECT 'RPSID002', 'Weekly', 52, 2
	UNION ALL
	SELECT 'RPSID003', 'Bi-Weekly', 26, 3
	UNION ALL
	SELECT 'RPSID004', 'Monthly', 12, 4
	UNION ALL
	SELECT 'RPSID005', 'Quarterly', 4, 5
	UNION ALL
	SELECT 'RPSID006', 'Semi-Annual', 2, 6
	UNION ALL
	SELECT 'RPSID007', 'Annual', 1, 7

-- ##########################################END INITIAL DATABASE INFORMATION#############################################################





-- ########################################FOR CODE DEBUGGING########################################################################



-- ######################################END FOR CODE DEBUGGING########################################################################
