/********************************************************/
/* This SQL Statements is used for the					*/
/* 		Loan Management System (LMS)					*/
/*Programmed by: Judyll Mark T. Agan					*/
/*Date created: September 29, 2010						*/
/*ACCOUNTING SOLUTIONS [ 6 ]							*/
/********************************************************/

USE db_lmsdev_03092010
GO


-- ###########################################DROP TABLE CONSTRAINTS ##############################################################

--verifies if the Bank_Information_SysID_Acccount_FK constraint exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.bank_information
	DROP CONSTRAINT Bank_Information_SysID_Acccount_FK
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

--verifies if the Disbursement_Voucher_Information_SysID_Bank_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information
	DROP CONSTRAINT Disbursement_Voucher_Information_SysID_Bank_FK
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

--verifies if the Disbursement_Voucher_Information_SysID_InHouseDebit_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information
	DROP CONSTRAINT Disbursement_Voucher_Information_SysID_InHouseDebit_FK
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

--verifies if the Disbursement_Voucher_Entry_SysID_Voucher_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry
	DROP CONSTRAINT Disbursement_Voucher_Entry_SysID_Voucher_FK
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Entry_SysID_Account_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry
	DROP CONSTRAINT Disbursement_Voucher_Entry_SysID_Account_FK
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Entry_Cost_Center_ID_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry
	DROP CONSTRAINT Disbursement_Voucher_Entry_Cost_Center_ID_FK
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


-- #########################################END DROP TABLE CONSTRAINTS ##############################################################





-- ########################################DROP DEPENDENT TABLE CONSTRAINTS ##############################################################



-- ######################################END DROP DEPENDENT TABLE CONSTRAINTS ##############################################################






-- ################################################TABLE "bank_information" OBJECTS######################################################
-- verifies if the bank_information table exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
	DROP TABLE lms.bank_information
GO

CREATE TABLE lms.bank_information 			
(
	sysid_bank varchar (50) NOT NULL 
		CONSTRAINT Bank_Information_SysID_Bank_PK PRIMARY KEY (sysid_bank)
		CONSTRAINT Bank_Information_SysID_Bank_CK CHECK (sysid_bank LIKE 'SYSBNK%'),	
	bank_name varchar (50) NOT NULL
		CONSTRAINT Bank_Information_Bank_Name_UQ UNIQUE (bank_name, account_no),
	bank_address varchar (500) NOT NULL,
	account_no varchar (50) NOT NULL
		CONSTRAINT Bank_Information_Account_No_UQ UNIQUE (account_no, bank_name),
	sysid_account varchar (50) NOT NULL
		CONSTRAINT Bank_Information_SysID_Acccount_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,
	is_active_account bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Bank_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Bank_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Bank_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the bank_information table 
CREATE INDEX Bank_Information_SysID_Bank_Index
	ON lms.bank_information (sysid_account ASC)
GO
------------------------------------------------------------------

--verifies that the trigger "Bank_Information_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Bank_Information_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Bank_Information_Trigger_Insert
GO

CREATE TRIGGER lms.Bank_Information_Trigger_Insert
	ON  lms.bank_information
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_bank varchar (50)	
	DECLARE @bank_name varchar (50)
	DECLARE @bank_address varchar (500)
	DECLARE @account_no varchar (50)
	DECLARE @sysid_account varchar (50)
	DECLARE @is_active_account bit

	DECLARE @created_by varchar (50)

	DECLARE @active_string varchar (50)
	
	SELECT 
		@sysid_bank = i.sysid_bank,
		@bank_name = i.bank_name,
		@bank_address = i.bank_address,
		@account_no = i.account_no,
		@sysid_account = i.sysid_account,
		@is_active_account = i.is_active_account,

		@created_by = i.created_by
	FROM INSERTED AS i

	IF @is_active_account = 1
	BEGIN
		SET @active_string = 'YES'
	END
	ELSE
	BEGIN
		SET @active_string = 'NO'
	END

	SET @transaction_done = 'CREATED a new bank information ' + 
							'[Bank ID: ' + ISNULL(@sysid_bank, '') +
							'][Bank Name: ' + ISNULL(@bank_name, '') +
							'][Bank Address: ' + ISNULL(@bank_address, '') +
							'][Account Number: ' + ISNULL(@account_no, '') +
							'][Account Entry: ' + ISNULL((SELECT
																account_code + ' - ' + account_name
															FROM
																lms.chart_of_accounts
															WHERE
																sysid_account = @sysid_account), '') +
							'][Is Active Account: ' + ISNULL(@active_string, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-------------------------------------------------------------------

--verifies that the trigger "Bank_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Bank_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Bank_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Bank_Information_Trigger_Instead_Update
	ON  lms.bank_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_bank varchar (50)	
	DECLARE @bank_name varchar (50)
	DECLARE @bank_address varchar (500)
	DECLARE @account_no varchar (50)
	DECLARE @sysid_account varchar (50)
	DECLARE @is_active_account bit

	DECLARE @edited_by varchar (50)
	
	DECLARE @bank_name_b varchar (50)
	DECLARE @bank_address_b varchar (500)
	DECLARE @account_no_b varchar (50)
	DECLARE @sysid_account_b varchar (50)
	DECLARE @is_active_account_b bit
	
	DECLARE @active_string varchar (50)
	DECLARE @active_string_b varchar (50)

	DECLARE @has_update bit

	DECLARE bank_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_bank, i.bank_name, i.bank_address, i.account_no, i.sysid_account, i.is_active_account, i.edited_by
				FROM INSERTED AS i

	OPEN bank_information_update_cursor

	FETCH NEXT FROM bank_information_update_cursor
		INTO @sysid_bank, @bank_name, @bank_address, @account_no, @sysid_account, @is_active_account, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT 
			@bank_name_b = bnk.bank_name,
			@bank_address_b = bnk.bank_address,
			@account_no_b = bnk.account_no,
			@sysid_account_b = bnk.sysid_account,
			@is_active_account_b = bnk.is_active_account
		FROM 
			lms.bank_information AS bnk
		WHERE 
			bnk.sysid_bank = @sysid_bank

		SET @transaction_done = ''
		SET @has_update = 0

		IF NOT ISNULL(@bank_name COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@bank_name_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Name Before: ' + ISNULL(@bank_name_b, '') + ']' +
														'[Bank Name After: ' + ISNULL(@bank_name, '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Name: ' + ISNULL(@bank_name, '') + ']'
		END

		IF NOT ISNULL(@bank_address COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@bank_address_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Address Before: ' + ISNULL(@bank_address_b, '') + ']' +
														'[Bank Address After: ' + ISNULL(@bank_address, '') + ']'
			SET @has_update = 1
		END

		IF NOT ISNULL(@account_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@account_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Number Before: ' + ISNULL(@account_no_b, '') + ']' +
														'[Account Number After: ' + ISNULL(@account_no, '') + ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@sysid_account COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Entry Before: ' + ISNULL((SELECT
																								account_code + ' - ' + account_name
																							FROM
																								lms.chart_of_accounts
																							WHERE
																								sysid_account = @sysid_account_b), '') + ']' +
														'[Account Entry After: ' + ISNULL((SELECT
																								account_code + ' - ' + account_name
																							FROM
																								lms.chart_of_accounts
																							WHERE
																								sysid_account = @sysid_account), '') + ']'
			SET @has_update = 1
		END

		IF NOT @is_active_account = @is_active_account_b
		BEGIN

			IF @is_active_account = 1
			BEGIN
				SET @active_string = 'YES'
			END
			ELSE
			BEGIN
				SET @active_string = 'NO'
			END

			IF @is_active_account_b = 1
			BEGIN
				SET @active_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @active_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Active Account Before: ' + ISNULL(@active_string_b, '') + ']' +
														'[Is Active Account After: ' + ISNULL(@active_string, '') +  ']'
			SET @has_update = 1
		END	

		IF @has_update = 1
		BEGIN

			UPDATE lms.bank_information SET
				bank_name = @bank_name,
				bank_address = @bank_address,
				account_no = @account_no,
				sysid_account = @sysid_account,
				is_active_account = @is_active_account,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				sysid_bank = @sysid_bank

			SET @transaction_done = 'UPDATED a bank information ' + 
									'[Bank ID: ' + ISNULL(@sysid_bank, '') +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END
					
			EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done	

		END

		FETCH NEXT FROM bank_information_update_cursor
			INTO @sysid_bank, @bank_name, @bank_address, @account_no, @sysid_account, @is_active_account, @edited_by

	END

	CLOSE bank_information_update_cursor
	DEALLOCATE bank_information_update_cursor

GO
-----------------------------------------------------------------

-- verifies that the trigger "Bank_Information_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Bank_Information_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Bank_Information_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Bank_Information_Trigger_Instead_Delete
	ON  lms.bank_information
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a bank information', 'Bank Information'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertBankInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertBankInformation')
   DROP PROCEDURE lms.InsertBankInformation
GO

CREATE PROCEDURE lms.InsertBankInformation

	@sysid_bank varchar (50) = '',	
	@bank_name varchar (50) = '',
	@bank_address varchar (500) = '',
	@account_no varchar (50) = '',
	@sysid_account varchar (50) = '',
	@is_active_account bit = 0,

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsBankNameAccountNumberBankInfo(@sysid_bank, @bank_name, @account_no) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.bank_information
		(
			sysid_bank,	
			bank_name,
			bank_address,
			account_no,
			sysid_account,
			is_active_account,

			created_by
		)
		VALUES
		(
			@sysid_bank,	
			@bank_name,
			@bank_address,
			@account_no,
			@sysid_account,
			@is_active_account,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a bank information', 'Bank Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertBankInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateBankInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateBankInformation')
   DROP PROCEDURE lms.UpdateBankInformation
GO

CREATE PROCEDURE lms.UpdateBankInformation

	@sysid_bank varchar (50) = '',	
	@bank_name varchar (50) = '',
	@bank_address varchar (500) = '',
	@account_no varchar (50) = '',
	@sysid_account varchar (50) = '',
	@is_active_account bit = 0,

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsBankNameAccountNumberBankInfo(@sysid_bank, @bank_name, @account_no) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.bank_information SET
			bank_name = @bank_name,
			bank_address = @bank_address,
			account_no = @account_no,
			sysid_account = @sysid_account,
			is_active_account = @is_active_account,

			edited_by = @edited_by
		WHERE
			sysid_bank = @sysid_bank
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a bank information', 'Bank Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateBankInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBankInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBankInformation')
   DROP PROCEDURE lms.SelectBankInformation
GO

CREATE PROCEDURE lms.SelectBankInformation
	
	@query_string varchar (50) = '',
	@is_active_account bit = 0,

	@system_user_id varchar(50) = ''
	
AS

	
	IF (lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'

		IF (NOT ISNULL(@query_string, '') = '%*%')
		BEGIN

			SELECT
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.bank_address AS bank_address,
				bnk.account_no AS account_no,
				bnk.is_active_account AS is_active_account,

				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--coa.summary_account
				summary_coa.sysid_account AS sysid_account_summary,
				summary_coa.account_code AS account_code_summary,
				summary_coa.account_name AS account_name_summary,
				summary_coa.is_debit_side_increase AS is_debit_side_increase_summary,
				summary_coa.is_active_account AS is_active_account_summary,

				--summary_coa.accounting_category_id
				summary_acg.accounting_category_id AS accounting_category_id_summary,
				summary_acg.category_description AS category_description_summary				
			FROM
				lms.bank_information AS bnk
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				((bnk.bank_name LIKE @query_string) OR 
				((REPLACE(bnk.bank_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.bank_address LIKE @query_string) OR 
				((REPLACE(bnk.bank_address, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.account_no LIKE @query_string) OR 
				((REPLACE(bnk.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_description LIKE @query_string) OR 
				((REPLACE(coa.account_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.company_policy_procedure LIKE @query_string) OR 
				((REPLACE(coa.company_policy_procedure, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(bnk.is_active_account = @is_active_account)

		END		
		ELSE
		BEGIN

			SELECT
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.bank_address AS bank_address,
				bnk.account_no AS account_no,
				bnk.is_active_account AS is_active_account,

				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--coa.summary_account
				summary_coa.sysid_account AS sysid_account_summary,
				summary_coa.account_code AS account_code_summary,
				summary_coa.account_name AS account_name_summary,
				summary_coa.is_debit_side_increase AS is_debit_side_increase_summary,
				summary_coa.is_active_account AS is_active_account_summary,

				--summary_coa.accounting_category_id
				summary_acg.accounting_category_id AS accounting_category_id_summary,
				summary_acg.category_description AS category_description_summary				
			FROM
				lms.bank_information AS bnk
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				(bnk.is_active_account = @is_active_account)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a bank information', 'Bank Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBankInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountBankInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountBankInformation')
   DROP PROCEDURE lms.SelectCountBankInformation
GO

CREATE PROCEDURE lms.SelectCountBankInformation

	@system_user_id varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT COUNT(sysid_bank) FROM lms.bank_information
				
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a bank information', 'Bank Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountBankInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDBankInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDBankInformation')
   DROP PROCEDURE lms.IsExistsSysIDBankInformation
GO

CREATE PROCEDURE lms.IsExistsSysIDBankInformation

	@sysid_bank varchar (50) = '',

	@system_user_id varchar (50) = ''	
		
AS
	
	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT lms.IsExistsSysIDBankInfo(@sysid_bank)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a bank information', 'Bank Information'
	END	
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDBankInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsBankNameAccountNumberBankInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsBankNameAccountNumberBankInformation')
   DROP PROCEDURE lms.IsExistsBankNameAccountNumberBankInformation
GO

CREATE PROCEDURE lms.IsExistsBankNameAccountNumberBankInformation

	@sysid_bank varchar (50) = '',
	@bank_name varchar (50) = '',
	@account_no varchar (50),

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsBankNameAccountNumberBankInfo(@sysid_bank, @bank_name, @account_no)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a bank information', 'Bank Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsBankNameAccountNumberBankInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDBankInfo" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDBankInfo') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDBankInfo
GO

CREATE FUNCTION lms.IsExistsSysIDBankInfo
(	
	@sysid_bank varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_bank FROM lms.bank_information WHERE sysid_bank = @sysid_bank)
	BEGIN
		SET @result = 1
	END	
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsExistsBankNameAccountNumberBankInfo" function already exist
IF OBJECT_ID (N'lms.IsExistsBankNameAccountNumberBankInfo') IS NOT NULL
   DROP FUNCTION lms.IsExistsBankNameAccountNumberBankInfo
GO

CREATE FUNCTION lms.IsExistsBankNameAccountNumberBankInfo
(	
	@sysid_bank varchar (50) = '',
	@bank_name varchar (50) = '',
	@account_no varchar (50)
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_bank FROM lms.bank_information WHERE (NOT sysid_bank = @sysid_bank) AND						
						(REPLACE(bank_name, ' ', '') LIKE REPLACE(@bank_name, ' ', '')) AND						
						(REPLACE(account_no, ' ', '') LIKE REPLACE(@account_no, ' ', '')))
								
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ################################################TABLE "bank_information" OBJECTS######################################################




-- ################################################TABLE "department_information" OBJECTS######################################################
-- verifies if the department_information table existss
IF OBJECT_ID('lms.department_information', 'U') IS NOT NULL
	DROP TABLE lms.department_information
GO

CREATE TABLE lms.department_information 			
(
	department_id varchar (50) NOT NULL 
		CONSTRAINT Department_Information_Department_ID_PK PRIMARY KEY (department_id)
		CONSTRAINT Department_Information_Department_ID_CK CHECK (department_id LIKE 'DEPT%'),
	department_name varchar (100) NOT NULL
		CONSTRAINT Department_Information_Department_Name_UQ UNIQUE (department_name),
	acronym varchar (10) NULL
		CONSTRAINT Department_Information_Acronym_UQ UNIQUE (acronym),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Department_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the department_information table 
CREATE INDEX Department_Information_Department_ID_Index
	ON lms.department_information (department_id ASC)
GO
------------------------------------------------------------------

-- verifies that the trigger "Department_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Department_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Department_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Department_Information_Trigger_Instead_Update
	ON  lms.department_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update a department information', 'Department Information'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Department_Information_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Department_Information_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Department_Information_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Department_Information_Trigger_Instead_Delete
	ON  lms.department_information
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a department information', 'Department Information'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectDepartmentInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectDepartmentInformation')
   DROP PROCEDURE lms.SelectDepartmentInformation
GO

CREATE PROCEDURE lms.SelectDepartmentInformation
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			di.department_id AS department_id,
			di.department_name AS department_name,
			di.acronym AS acronym
		FROM
			lms.department_information AS di
		ORDER BY di.department_name ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a deparment information', 'Department Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectDepartmentInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- ################################################END TABLE "department_information" OBJECTS###################################################




-- ################################################TABLE "disbursement_voucher_information" OBJECTS######################################################
-- verifies if the disbursement_voucher_information table exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
	DROP TABLE lms.disbursement_voucher_information
GO

CREATE TABLE lms.disbursement_voucher_information 			
(
	sysid_voucher varchar (50) NOT NULL 
		CONSTRAINT Disbursement_Voucher_Information_SysID_Voucher_PK PRIMARY KEY (sysid_voucher)
		CONSTRAINT Disbursement_Voucher_Information_SysID_Voucher_CK CHECK (sysid_voucher LIKE 'VN%'),	
	sysid_bank varchar (50) NOT NULL
		CONSTRAINT Disbursement_Voucher_Information_SysID_Bank_FK FOREIGN KEY REFERENCES lms.bank_information(sysid_bank) ON UPDATE NO ACTION
		CONSTRAINT Disbursement_Voucher_Information_SysID_Bank_UQ UNIQUE (sysid_bank, check_no),
	check_no varchar (50) NOT NULL
		CONSTRAINT Disbursement_Voucher_Information_Check_No_UQ UNIQUE (check_no, sysid_bank),
	check_date datetime NOT NULL DEFAULT (GETDATE()),
	payee varchar (150) NOT NULL,
	sysid_regular varchar (50) NULL
		CONSTRAINT Disbursement_Voucher_Information_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION,
	sysid_inhousedebit varchar (50) NULL
		CONSTRAINT Disbursement_Voucher_Information_SysID_InHouseDebit_FK FOREIGN KEY REFERENCES lms.in_house_hospitalization_debit(sysid_inhousedebit) ON UPDATE NO ACTION,
	check_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	particulars varchar (MAX) NULL,
	
	is_marked_deleted bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Disbursement_Voucher_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Disbursement_Voucher_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Disbursement_Voucher_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the disbursement_voucher_information table 
CREATE INDEX Disbursement_Voucher_Information_SysID_Voucher_Index
	ON lms.disbursement_voucher_information (sysid_voucher ASC)
GO
------------------------------------------------------------------

-- create an index of the disbursement_voucher_information table 
CREATE INDEX Disbursement_Voucher_Information_Check_Date_Index
	ON lms.disbursement_voucher_information (check_date DESC)
GO
------------------------------------------------------------------

-- create an index of the disbursement_voucher_information table 
CREATE INDEX Disbursement_Voucher_Information_SysID_Regular_Index
	ON lms.disbursement_voucher_information (sysid_regular DESC)
GO
------------------------------------------------------------------

-- create an index of the disbursement_voucher_information table 
CREATE INDEX Disbursement_Voucher_Information_SysID_InHouseDebit_Index
	ON lms.disbursement_voucher_information (sysid_inhousedebit DESC)
GO
------------------------------------------------------------------

-- create an index of the disbursement_voucher_information table 
CREATE INDEX Disbursement_Voucher_Information_Created_On_Index
	ON lms.disbursement_voucher_information (created_on DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Disbursement_Voucher_Information_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Disbursement_Voucher_Information_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Disbursement_Voucher_Information_Trigger_Insert
GO

CREATE TRIGGER lms.Disbursement_Voucher_Information_Trigger_Insert
	ON  lms.disbursement_voucher_information
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_voucher varchar (50)
	DECLARE @sysid_bank varchar (50)
	DECLARE @check_no varchar (50)
	DECLARE @check_date datetime
	DECLARE @payee varchar (150)
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @check_amount decimal (15, 2)
	DECLARE @particulars varchar (MAX)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@sysid_voucher = i.sysid_voucher,
		@sysid_bank = i.sysid_bank,
		@check_no = i.check_no,
		@check_date = i.check_date,
		@payee = i.payee,
		@sysid_regular = i.sysid_regular,
		@sysid_inhousedebit = i.sysid_inhousedebit,
		@check_amount = i.check_amount,
		@particulars = i.particulars,

		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new disbursement voucher information ' + 
							'[Voucher No.: ' + ISNULL(@sysid_voucher, '') +
							'][Bank Name: ' + ISNULL((SELECT
															'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
														FROM
															lms.bank_information
														WHERE
															sysid_bank = @sysid_bank), '') +
							'][Check No.: ' + ISNULL(@check_no, '') +
							'][Check Date: ' + ISNULL(CONVERT(varchar, @check_date, 101), '') +
							'][Payee: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
													WHERE
														(rli.sysid_regular = @sysid_regular)),
													ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), ISNULL(@payee, ''))) +
							'][Issued for Member Service: ' + ISNULL((SELECT
																			'Regular Loan Account No.: ' + rli.account_no
																		FROM
																			lms.regular_loan_information AS rli
																		WHERE
																			(rli.sysid_regular = @sysid_regular)), 
																		ISNULL((SELECT
																					'H.A.P. Hospital Name: ' + ihd.hospital_name + ' Admission Date: ' + CONVERT(varchar, ihd.date_from, 101) + ' - ' + CONVERT(varchar, ihd.date_to, 101)
																				FROM
																					lms.in_house_hospitalization_debit AS ihd
																				WHERE
																					(ihd.sysid_inhousedebit = @sysid_inhousedebit)), 'NOT APPLICABLE')) +				
							'][Check Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @check_amount), 1), '0.00') +	
							'][Particulars: ' + ISNULL(@particulars, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-------------------------------------------------------------------

--verifies that the trigger "Disbursement_Voucher_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Disbursement_Voucher_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Disbursement_Voucher_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Disbursement_Voucher_Information_Trigger_Instead_Update
	ON  lms.disbursement_voucher_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_voucher varchar (50)
	DECLARE @sysid_bank varchar (50)
	DECLARE @check_no varchar (50)
	DECLARE @check_date datetime
	DECLARE @payee varchar (150)
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @check_amount decimal (15, 2)
	DECLARE @particulars varchar (MAX)

	DECLARE @edited_by varchar (50)
	
	DECLARE @sysid_bank_b varchar (50)
	DECLARE @check_no_b varchar (50)
	DECLARE @check_date_b datetime
	DECLARE @payee_b varchar (150)
	DECLARE @sysid_regular_b varchar (50)
	DECLARE @sysid_inhousedebit_b varchar (50)
	DECLARE @check_amount_b decimal (15, 2)
	DECLARE @particulars_b varchar (MAX)

	DECLARE @has_update bit

	DECLARE disbursement_voucher_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_voucher, i.sysid_bank, i.check_no, i.check_date, i.payee, i.sysid_regular,
					i.sysid_inhousedebit, i.check_amount, i.particulars, i.edited_by
				FROM INSERTED AS i

	OPEN disbursement_voucher_information_update_cursor

	FETCH NEXT FROM disbursement_voucher_information_update_cursor
		INTO @sysid_voucher, @sysid_bank, @check_no, @check_date, @payee, @sysid_regular,
					@sysid_inhousedebit, @check_amount, @particulars, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT 
			@sysid_bank_b = dvi.sysid_bank,
			@check_no_b = dvi.check_no,
			@check_date_b = dvi.check_date,
			@payee_b = dvi.payee,
			@sysid_regular_b = dvi.sysid_regular,
			@sysid_inhousedebit_b = dvi.sysid_inhousedebit,
			@check_amount_b = dvi.check_amount,
			@particulars_b = dvi.particulars
		FROM 
			lms.disbursement_voucher_information AS dvi
		WHERE 
			dvi.sysid_voucher = @sysid_voucher

		SET @transaction_done = ''
		SET @has_update = 0

		IF NOT ISNULL(@sysid_bank COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_bank_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Name Before: ' + ISNULL((SELECT
																							'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
																						FROM
																							lms.bank_information
																						WHERE
																							sysid_bank = @sysid_bank), '') + ']' +
														'[Bank Name After: ' + ISNULL((SELECT
																							'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
																						FROM
																							lms.bank_information
																						WHERE
																							sysid_bank = @sysid_bank), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Name: ' + ISNULL((SELECT
																						'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
																					FROM
																						lms.bank_information
																					WHERE
																						sysid_bank = @sysid_bank), '') + ']'
		END

		IF NOT ISNULL(@check_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@check_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check No. Before: ' + ISNULL(@check_no_b, '') + ']' +
														'[Check No. After: ' + ISNULL(@check_no, '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Check No.: ' + ISNULL(@check_no, '') + ']'
		END

		IF NOT ISNULL(CONVERT(varchar, @check_date, 101), '') = ISNULL(CONVERT(varchar, @check_date_b, 101), '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check Date Before: ' + ISNULL(CONVERT(varchar, @check_date_b, 101), '') + ']' +
														'[Check Date After: ' + ISNULL(CONVERT(varchar, @check_date, 101), '') + ']'
			SET @has_update = 1
		END

		IF NOT ISNULL(CONVERT(varchar, @sysid_regular, 101), '') = ISNULL(CONVERT(varchar, @sysid_regular_b, 101), '') OR
			NOT ISNULL(CONVERT(varchar, @sysid_inhousedebit, 101), '') = ISNULL(CONVERT(varchar, @sysid_inhousedebit_b, 101), '') OR
			NOT ISNULL(@payee COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@payee_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Payee Before: ' + ISNULL((SELECT 
																					pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
																				FROM
																					lms.person_information AS pri
																				INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																				INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																				WHERE
																					(rli.sysid_regular = @sysid_regular_b)),
																				ISNULL((SELECT 
																							pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
																						FROM
																							lms.person_information AS pri
																						INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																						INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																						WHERE
																							(ihd.sysid_inhousedebit = @sysid_inhousedebit_b)), ISNULL(@payee_b, ''))) +
														'][Issued for Member Service Before: ' + ISNULL((SELECT
																										'Regular Loan Account No.: ' + rli.account_no
																									FROM
																										lms.regular_loan_information AS rli
																									WHERE
																										(rli.sysid_regular = @sysid_regular_b)), 
																									ISNULL((SELECT
																												'H.A.P. Hospital Name: ' + ihd.hospital_name + ' Admission Date: ' + CONVERT(varchar, ihd.date_from, 101) + ' - ' + CONVERT(varchar, ihd.date_to, 101)
																											FROM
																												lms.in_house_hospitalization_debit AS ihd
																											WHERE
																												(ihd.sysid_inhousedebit = @sysid_inhousedebit_b)), 'NOT APPLICABLE')) + ']' +
														'[Payee After: ' + ISNULL((SELECT 
																					pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
																				FROM
																					lms.person_information AS pri
																				INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																				INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																				WHERE
																					(rli.sysid_regular = @sysid_regular)),
																				ISNULL((SELECT 
																							pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
																						FROM
																							lms.person_information AS pri
																						INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																						INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																						WHERE
																							(ihd.sysid_inhousedebit = @sysid_inhousedebit)), ISNULL(@payee, ''))) +
														'][Issued for Member Service After: ' + ISNULL((SELECT
																										'Regular Loan Account No.: ' + rli.account_no
																									FROM
																										lms.regular_loan_information AS rli
																									WHERE
																										(rli.sysid_regular = @sysid_regular)), 
																									ISNULL((SELECT
																												'H.A.P. Hospital Name: ' + ihd.hospital_name + ' Admission Date: ' + CONVERT(varchar, ihd.date_from, 101) + ' - ' + CONVERT(varchar, ihd.date_to, 101)
																											FROM
																												lms.in_house_hospitalization_debit AS ihd
																											WHERE
																												(ihd.sysid_inhousedebit = @sysid_inhousedebit)), 'NOT APPLICABLE')) + ']'
			SET @has_update = 1
		END


		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @check_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @check_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @check_amount_b), 1), '0.00') + ']' +
														'[Check Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @check_amount), 1), '0.00') + ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@particulars COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@particulars_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Particulars Before: ' + ISNULL(@particulars_b, '') + ']' +
														'[Particulars After: ' + ISNULL(@particulars, '') + ']'
			SET @has_update = 1
		END

		IF @has_update = 1
		BEGIN

			UPDATE lms.disbursement_voucher_information SET
				sysid_bank = @sysid_bank,
				check_no = @check_no,
				check_date = @check_date,
				payee = @payee,
				sysid_regular = @sysid_regular,
				sysid_inhousedebit = @sysid_inhousedebit,
				check_amount = @check_amount,
				particulars = @particulars,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				sysid_voucher = @sysid_voucher

			SET @transaction_done = 'UPDATED a disbursement voucher information ' + 
									'[Voucher No.: ' + ISNULL(@sysid_voucher, '') +
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
			UPDATE lms.disbursement_voucher_information SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(sysid_voucher = @sysid_voucher)

		END

		FETCH NEXT FROM disbursement_voucher_information_update_cursor
			INTO @sysid_voucher, @sysid_bank, @check_no, @check_date, @payee, @sysid_regular,
						@sysid_inhousedebit, @check_amount, @particulars, @edited_by

	END

	CLOSE disbursement_voucher_information_update_cursor
	DEALLOCATE disbursement_voucher_information_update_cursor

GO
-----------------------------------------------------------------

-- verifies that the trigger "Disbursement_Voucher_Information_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Disbursement_Voucher_Information_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Disbursement_Voucher_Information_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Disbursement_Voucher_Information_Trigger_Instead_Delete
	ON  lms.disbursement_voucher_information
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_voucher varchar (50)
	DECLARE @sysid_bank varchar (50)
	DECLARE @check_no varchar (50)
	DECLARE @check_date datetime
	DECLARE @payee varchar (150)
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @check_amount decimal (15, 2)
	DECLARE @particulars varchar (MAX)
	DECLARE @is_marked_deleted bit

	DECLARE @deleted_by varchar(50)

	DECLARE disbursement_voucher_information_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.sysid_voucher, d.sysid_bank, d.check_no, d.check_date, d.payee, d.sysid_regular,
					d.sysid_inhousedebit, d.check_amount, d.particulars, d.is_marked_deleted, d.edited_by
				FROM DELETED AS d

	OPEN disbursement_voucher_information_delete_cursor

	FETCH NEXT FROM disbursement_voucher_information_delete_cursor
		INTO @sysid_voucher, @sysid_bank, @check_no, @check_date, @payee, @sysid_regular,
					@sysid_inhousedebit, @check_amount, @particulars, @is_marked_deleted, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF (@is_marked_deleted = 0)
		BEGIN

			UPDATE lms.disbursement_voucher_information SET 
				is_marked_deleted = 1, 

				edited_on = GETDATE(), 
				edited_by = @deleted_by 
			WHERE 
				(sysid_voucher = @sysid_voucher)

			SET @transaction_done = 'MARK AS DELETED/CANCELLED a disbursement voucher information ' + 
									'[Voucher No.: ' + ISNULL(@sysid_voucher, '') +
									'][Bank Name: ' + ISNULL((SELECT
																	'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
																FROM
																	lms.bank_information
																WHERE
																	sysid_bank = @sysid_bank), '') +
									'][Check No.: ' + ISNULL(@check_no, '') +
									'][Check Date: ' + ISNULL(CONVERT(varchar, @check_date, 101), '') +
									'][Payee: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE
																(rli.sysid_regular = @sysid_regular)),
															ISNULL((SELECT 
																		pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
																	FROM
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), ISNULL(@payee, ''))) +
									'][Issued for Member Service: ' + ISNULL((SELECT
																					'Regular Loan Account No.: ' + rli.account_no
																				FROM
																					lms.regular_loan_information AS rli
																				WHERE
																					(rli.sysid_regular = @sysid_regular)), 
																				ISNULL((SELECT
																							'H.A.P. Hospital Name: ' + ihd.hospital_name + ' Admission Date: ' + CONVERT(varchar, ihd.date_from, 101) + ' - ' + CONVERT(varchar, ihd.date_to, 101)
																						FROM
																							lms.in_house_hospitalization_debit AS ihd
																						WHERE
																							(ihd.sysid_inhousedebit = @sysid_inhousedebit)), 'NOT APPLICABLE')) +				
									'][Check Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @check_amount), 1), '0.00') +	
									'][Particulars: ' + ISNULL(@particulars, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
			END
					
			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		END
				
		FETCH NEXT FROM disbursement_voucher_information_delete_cursor
			INTO @sysid_voucher, @sysid_bank, @check_no, @check_date, @payee, @sysid_regular,
						@sysid_inhousedebit, @check_amount, @particulars, @is_marked_deleted, @deleted_by

	END

	CLOSE disbursement_voucher_information_delete_cursor
	DEALLOCATE disbursement_voucher_information_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertDisbursementVoucherInformation')
   DROP PROCEDURE lms.InsertDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.InsertDisbursementVoucherInformation

	@sysid_voucher varchar (50) = '',	
	@sysid_bank varchar (50) = '',
	@check_no varchar (50) = '',
	@check_date datetime,
	@payee varchar (150) = '',
	@sysid_regular varchar (50) = '',
	@sysid_inhousedebit varchar (50) = '',
	@check_amount decimal (15, 2) = 0.00,
	@particulars varchar (MAX) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@created_by) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsBankCheckNoDisbursementVoucherInfo(@sysid_voucher, @sysid_bank, @check_no) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		IF (NOT @sysid_regular IS NULL) AND (NOT ISNULL(@sysid_regular, '') = '')
		BEGIN
			SET @sysid_inhousedebit = NULL
		END
		ELSE IF (NOT @sysid_inhousedebit IS NULL) AND (NOT ISNULL(@sysid_inhousedebit, '') = '')
		BEGIN
			SET @sysid_regular = NULL
		END

		INSERT INTO lms.disbursement_voucher_information
		(
			sysid_voucher,	
			sysid_bank,
			check_no,
			check_date,
			payee,
			sysid_regular,
			sysid_inhousedebit,
			check_amount,
			particulars,

			created_by
		)
		VALUES
		(
			@sysid_voucher,	
			@sysid_bank,
			@check_no,
			@check_date,
			@payee,
			@sysid_regular,
			@sysid_inhousedebit,
			@check_amount,
			@particulars,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a disbursement voucher information', 'Disbursement Voucher Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateDisbursementVoucherInformation')
   DROP PROCEDURE lms.UpdateDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.UpdateDisbursementVoucherInformation

	@sysid_voucher varchar (50) = '',	
	@sysid_bank varchar (50) = '',
	@check_no varchar (50) = '',
	@check_date datetime,
	@payee varchar (150) = '',
	@sysid_regular varchar (50) = '',
	@sysid_inhousedebit varchar (50) = '',
	@check_amount decimal (15, 2) = 0.00,
	@particulars varchar (MAX) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@edited_by) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsBankCheckNoDisbursementVoucherInfo(@sysid_voucher, @sysid_bank, @check_no) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		IF (NOT @sysid_regular IS NULL) AND (NOT ISNULL(@sysid_regular, '') = '')
		BEGIN
			SET @sysid_inhousedebit = NULL
		END
		ELSE IF (NOT @sysid_inhousedebit IS NULL) AND (NOT ISNULL(@sysid_inhousedebit, '') = '')
		BEGIN
			SET @sysid_regular = NULL
		END

		UPDATE lms.disbursement_voucher_information SET
			sysid_bank = @sysid_bank,
			check_no = @check_no,
			check_date = @check_date,
			payee = @payee,
			sysid_regular = @sysid_regular,
			sysid_inhousedebit = @sysid_inhousedebit,
			check_amount = @check_amount,
			particulars = @particulars,

			edited_by = @edited_by
		WHERE
			sysid_voucher = @sysid_voucher
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a disbursement voucher information', 'Disbursement Voucher Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteDisbursementVoucherInformation')
   DROP PROCEDURE lms.DeleteDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.DeleteDisbursementVoucherInformation
	
	@sysid_voucher varchar (50) = '',

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT sysid_voucher FROM lms.disbursement_voucher_information WHERE sysid_voucher = @sysid_voucher)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.disbursement_voucher_information SET
				edited_by = @deleted_by
			WHERE
				(sysid_voucher = @sysid_voucher)

			DELETE FROM lms.disbursement_voucher_information WHERE (sysid_voucher = @sysid_voucher)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a disbursement voucher information', 'Disbursement Voucher Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByQueryStringDateStartEndDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByQueryStringDateStartEndDisbursementVoucherInformation')
   DROP PROCEDURE lms.SelectByQueryStringDateStartEndDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.SelectByQueryStringDateStartEndDisbursementVoucherInformation
	
	@query_string varchar (50) = '',
	@date_start datetime,
	@date_end datetime,
	@is_cancelled_voucher bit = 0,

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		-- A - '*'
		-- B - Date Start / End

		--	A	B	
		-- =======
		--	0	0
		--	0	1
		--	1	0
		--	1	1

		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'

		IF (NOT ISNULL(@query_string, '') = '%*%') AND ((@date_start IS NULL) OR (@date_end IS NULL))				-- (00)				
		BEGIN

			SELECT		--NOT RELATED TO A MEMBER SERVICES
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.sysid_voucher LIKE @query_string) OR 
				((REPLACE(dvi.sysid_voucher, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.check_no LIKE @query_string) OR 
				((REPLACE(dvi.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.payee LIKE @query_string) OR 
				((REPLACE(dvi.payee, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(CONVERT(varchar, dvi.check_amount) LIKE @query_string) OR 
				((REPLACE(CONVERT(varchar, dvi.check_amount), ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.particulars LIKE @query_string) OR 
				((REPLACE(dvi.particulars, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.bank_name LIKE @query_string) OR 
				((REPLACE(bnk.bank_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.account_no LIKE @query_string) OR 
				((REPLACE(bnk.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')))
			UNION ALL
			SELECT		--RELATED TO A REGULAR LOAN INFORMATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				rli.sysid_regular AS sysid_regular,
				rli.account_no AS account_no_loan,
				mbi.sysid_member AS sysid_member_loan,
				mbi.member_id AS member_id_loan,
				pri.sysid_person AS sysid_person_loan,
				pri.last_name AS last_name_loan,
				pri.first_name AS first_name_loan,
				pri.middle_name AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'true' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_regular = dvi.sysid_regular
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((NOT dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.sysid_voucher LIKE @query_string) OR 
				((REPLACE(dvi.sysid_voucher, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.check_no LIKE @query_string) OR 
				((REPLACE(dvi.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.payee LIKE @query_string) OR 
				((REPLACE(dvi.payee, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(CONVERT(varchar, dvi.check_amount) LIKE @query_string) OR 
				((REPLACE(CONVERT(varchar, dvi.check_amount), ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.particulars LIKE @query_string) OR 
				((REPLACE(dvi.particulars, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.bank_name LIKE @query_string) OR 
				((REPLACE(bnk.bank_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.account_no LIKE @query_string) OR 
				((REPLACE(bnk.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(rli.account_no LIKE @query_string) OR 
				((REPLACE(rli.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.occupation LIKE @query_string) OR 
				((REPLACE(pri.occupation, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
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
			UNION ALL	
			SELECT		--RELATED TO AN IN-HOUSE HOSPITALIZATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				ihd.sysid_inhousedebit AS sysid_inhousedebit,
				ihd.hospital_name AS hospital_name_inhouse,
				ihd.date_from AS date_from_inhouse,
				ihd.date_to AS date_to_inhouse,
				mbi.sysid_member AS sysid_member_inhouse,
				mbi.member_id AS member_id_inhouse,
				pri.sysid_person AS sysid_person_inhouse,
				pri.last_name AS last_name_inhouse,
				pri.first_name AS first_name_inhouse,
				pri.middle_name AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'true' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_inhousedebit = dvi.sysid_inhousedebit
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = ihd.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(NOT dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.sysid_voucher LIKE @query_string) OR 
				((REPLACE(dvi.sysid_voucher, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.check_no LIKE @query_string) OR 
				((REPLACE(dvi.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.payee LIKE @query_string) OR 
				((REPLACE(dvi.payee, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(CONVERT(varchar, dvi.check_amount) LIKE @query_string) OR 
				((REPLACE(CONVERT(varchar, dvi.check_amount), ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.particulars LIKE @query_string) OR 
				((REPLACE(dvi.particulars, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.bank_name LIKE @query_string) OR 
				((REPLACE(bnk.bank_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.account_no LIKE @query_string) OR 
				((REPLACE(bnk.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(ihd.hospital_name LIKE @query_string) OR 
				((REPLACE(ihd.hospital_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.occupation LIKE @query_string) OR 
				((REPLACE(pri.occupation, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
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
				check_date ASC, payee ASC, bank_name ASC

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND ((NOT @date_start IS NULL) AND (NOT @date_end IS NULL))		-- (01)
		BEGIN

			SELECT		--NOT RELATED TO A MEMBER SERVICES
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.sysid_voucher LIKE @query_string) OR 
				((REPLACE(dvi.sysid_voucher, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.check_no LIKE @query_string) OR 
				((REPLACE(dvi.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.payee LIKE @query_string) OR 
				((REPLACE(dvi.payee, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(CONVERT(varchar, dvi.check_amount) LIKE @query_string) OR 
				((REPLACE(CONVERT(varchar, dvi.check_amount), ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.particulars LIKE @query_string) OR 
				((REPLACE(dvi.particulars, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.bank_name LIKE @query_string) OR 
				((REPLACE(bnk.bank_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.account_no LIKE @query_string) OR 
				((REPLACE(bnk.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				((dvi.check_date BETWEEN @date_start AND @date_end) OR
				(dvi.created_on BETWEEN @date_start AND @date_end))	
			UNION ALL
			SELECT		--RELATED TO A REGULAR LOAN INFORMATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				rli.sysid_regular AS sysid_regular,
				rli.account_no AS account_no_loan,
				mbi.sysid_member AS sysid_member_loan,
				mbi.member_id AS member_id_loan,
				pri.sysid_person AS sysid_person_loan,
				pri.last_name AS last_name_loan,
				pri.first_name AS first_name_loan,
				pri.middle_name AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'true' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_regular = dvi.sysid_regular
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((NOT dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.sysid_voucher LIKE @query_string) OR 
				((REPLACE(dvi.sysid_voucher, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.check_no LIKE @query_string) OR 
				((REPLACE(dvi.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.payee LIKE @query_string) OR 
				((REPLACE(dvi.payee, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(CONVERT(varchar, dvi.check_amount) LIKE @query_string) OR 
				((REPLACE(CONVERT(varchar, dvi.check_amount), ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.particulars LIKE @query_string) OR 
				((REPLACE(dvi.particulars, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.bank_name LIKE @query_string) OR 
				((REPLACE(bnk.bank_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.account_no LIKE @query_string) OR 
				((REPLACE(bnk.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(rli.account_no LIKE @query_string) OR 
				((REPLACE(rli.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.occupation LIKE @query_string) OR 
				((REPLACE(pri.occupation, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
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
				((dvi.check_date BETWEEN @date_start AND @date_end) OR
				(dvi.created_on BETWEEN @date_start AND @date_end))		
			UNION ALL	
			SELECT		--RELATED TO AN IN-HOUSE HOSPITALIZATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				ihd.sysid_inhousedebit AS sysid_inhousedebit,
				ihd.hospital_name AS hospital_name_inhouse,
				ihd.date_from AS date_from_inhouse,
				ihd.date_to AS date_to_inhouse,
				mbi.sysid_member AS sysid_member_inhouse,
				mbi.member_id AS member_id_inhouse,
				pri.sysid_person AS sysid_person_inhouse,
				pri.last_name AS last_name_inhouse,
				pri.first_name AS first_name_inhouse,
				pri.middle_name AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'true' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_inhousedebit = dvi.sysid_inhousedebit
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = ihd.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(NOT dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.sysid_voucher LIKE @query_string) OR 
				((REPLACE(dvi.sysid_voucher, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.check_no LIKE @query_string) OR 
				((REPLACE(dvi.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.payee LIKE @query_string) OR 
				((REPLACE(dvi.payee, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(CONVERT(varchar, dvi.check_amount) LIKE @query_string) OR 
				((REPLACE(CONVERT(varchar, dvi.check_amount), ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(dvi.particulars LIKE @query_string) OR 
				((REPLACE(dvi.particulars, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.bank_name LIKE @query_string) OR 
				((REPLACE(bnk.bank_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(bnk.account_no LIKE @query_string) OR 
				((REPLACE(bnk.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(ihd.hospital_name LIKE @query_string) OR 
				((REPLACE(ihd.hospital_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.occupation LIKE @query_string) OR 
				((REPLACE(pri.occupation, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
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
				((dvi.check_date BETWEEN @date_start AND @date_end) OR
				(dvi.created_on BETWEEN @date_start AND @date_end))	
			ORDER BY
				check_date ASC, payee ASC, bank_name ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND ((@date_start IS NULL) OR (@date_end IS NULL))				-- (10)	
		BEGIN

			SELECT		--NOT RELATED TO A MEMBER SERVICES
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher))
			UNION ALL
			SELECT		--RELATED TO A REGULAR LOAN INFORMATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				rli.sysid_regular AS sysid_regular,
				rli.account_no AS account_no_loan,
				mbi.sysid_member AS sysid_member_loan,
				mbi.member_id AS member_id_loan,
				pri.sysid_person AS sysid_person_loan,
				pri.last_name AS last_name_loan,
				pri.first_name AS first_name_loan,
				pri.middle_name AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'true' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_regular = dvi.sysid_regular
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((NOT dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher))
			UNION ALL	
			SELECT		--RELATED TO AN IN-HOUSE HOSPITALIZATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				ihd.sysid_inhousedebit AS sysid_inhousedebit,
				ihd.hospital_name AS hospital_name_inhouse,
				ihd.date_from AS date_from_inhouse,
				ihd.date_to AS date_to_inhouse,
				mbi.sysid_member AS sysid_member_inhouse,
				mbi.member_id AS member_id_inhouse,
				pri.sysid_person AS sysid_person_inhouse,
				pri.last_name AS last_name_inhouse,
				pri.first_name AS first_name_inhouse,
				pri.middle_name AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'true' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_inhousedebit = dvi.sysid_inhousedebit
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = ihd.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(NOT dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher))
			ORDER BY
				check_date ASC, payee ASC, bank_name ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND ((NOT @date_start IS NULL) AND (NOT @date_end IS NULL))		-- (11)
		BEGIN

			SELECT		--NOT RELATED TO A MEMBER SERVICES
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.check_date BETWEEN @date_start AND @date_end) OR
				(dvi.created_on BETWEEN @date_start AND @date_end))	
			UNION ALL
			SELECT		--RELATED TO A REGULAR LOAN INFORMATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				rli.sysid_regular AS sysid_regular,
				rli.account_no AS account_no_loan,
				mbi.sysid_member AS sysid_member_loan,
				mbi.member_id AS member_id_loan,
				pri.sysid_person AS sysid_person_loan,
				pri.last_name AS last_name_loan,
				pri.first_name AS first_name_loan,
				pri.middle_name AS middle_name_loan,

				--dvi.sysid_inhousedebit
				NULL AS sysid_inhousedebit,
				NULL AS hospital_name_inhouse,
				NULL AS date_from_inhouse,
				NULL AS date_to_inhouse,
				NULL AS sysid_member_inhouse,
				NULL AS member_id_inhouse,
				NULL AS sysid_person_inhouse,
				NULL AS last_name_inhouse,
				NULL AS first_name_inhouse,
				NULL AS middle_name_inhouse,

				'true' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_regular = dvi.sysid_regular
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((NOT dvi.sysid_regular IS NULL) AND
				(dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.check_date BETWEEN @date_start AND @date_end) OR
				(dvi.created_on BETWEEN @date_start AND @date_end))		
			UNION ALL	
			SELECT		--RELATED TO AN IN-HOUSE HOSPITALIZATION
				dvi.sysid_voucher AS sysid_voucher,
				dvi.check_no AS check_no,
				dvi.check_date AS check_date,
				dvi.created_on AS date_issued,
				dvi.payee AS payee,
				dvi.check_amount AS check_amount,
				dvi.particulars AS particulars,
				dvi.is_marked_deleted AS is_marked_deleted,

				--dvi.sysid_bank
				bnk.sysid_bank AS sysid_bank,
				bnk.bank_name AS bank_name,
				bnk.account_no AS account_no_bank,
				bnk.is_active_account AS is_active_account_bank,
				
				--bnk.sysid_account
				coa.sysid_account AS sysid_account,
				coa.account_code AS account_code,
				coa.account_name AS account_name,
				coa.is_debit_side_increase AS is_debit_side_increase,
				coa.is_active_account AS is_active_account_account,

				--coa.accounting_category_id
				acg.accounting_category_id AS accounting_category_id,
				acg.category_description AS category_description,

				--dvi.sysid_regular
				NULL AS sysid_regular,
				NULL AS account_no_loan,
				NULL AS sysid_member_loan,
				NULL AS member_id_loan,
				NULL AS sysid_person_loan,
				NULL AS last_name_loan,
				NULL AS first_name_loan,
				NULL AS middle_name_loan,

				--dvi.sysid_inhousedebit
				ihd.sysid_inhousedebit AS sysid_inhousedebit,
				ihd.hospital_name AS hospital_name_inhouse,
				ihd.date_from AS date_from_inhouse,
				ihd.date_to AS date_to_inhouse,
				mbi.sysid_member AS sysid_member_inhouse,
				mbi.member_id AS member_id_inhouse,
				pri.sysid_person AS sysid_person_inhouse,
				pri.last_name AS last_name_inhouse,
				pri.first_name AS first_name_inhouse,
				pri.middle_name AS middle_name_inhouse,

				'false' AS is_regular_loan,
				'true' AS is_inhouse_hospitalization_debit
			FROM
				lms.disbursement_voucher_information AS dvi
			INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_inhousedebit = dvi.sysid_inhousedebit
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = ihd.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				((dvi.sysid_regular IS NULL) AND
				(NOT dvi.sysid_inhousedebit IS NULL) AND
				(dvi.is_marked_deleted = @is_cancelled_voucher)) AND
				((dvi.check_date BETWEEN @date_start AND @date_end) OR
				(dvi.created_on BETWEEN @date_start AND @date_end))	
			ORDER BY
				check_date ASC, payee ASC, bank_name ASC

		END

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a disbursement voucher information', 'Disbursement Voucher Information'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByQueryStringDateStartEndDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDVoucherDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDVoucherDisbursementVoucherInformation')
   DROP PROCEDURE lms.SelectBySysIDVoucherDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.SelectBySysIDVoucherDisbursementVoucherInformation

	@sysid_voucher varchar (50) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT		
			dvi.sysid_voucher AS sysid_voucher,
			dvi.check_no AS check_no,
			dvi.check_date AS check_date,
			dvi.created_on AS date_issued,
			dvi.payee AS payee,
			dvi.check_amount AS check_amount,
			dvi.particulars AS particulars,
			dvi.is_marked_deleted AS is_marked_deleted,

			--dvi.sysid_bank
			bnk.sysid_bank AS sysid_bank,
			bnk.bank_name AS bank_name,
			bnk.account_no AS account_no_bank,
			bnk.is_active_account AS is_active_account_bank,
			
			--bnk.sysid_account
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,
			coa.is_debit_side_increase AS is_debit_side_increase,
			coa.is_active_account AS is_active_account_account,

			--coa.accounting_category_id
			acg.accounting_category_id AS accounting_category_id,
			acg.category_description AS category_description,

			--coa.summary_account
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			summary_coa.is_debit_side_increase AS is_debit_side_increase_summary,
			summary_coa.is_active_account AS is_active_account_summary,

			--summary_coa.accounting_category_id
			summary_acg.accounting_category_id AS accounting_category_id_summary,
			summary_acg.category_description AS category_description_summary,
			
			--dvi.sysid_regular
			rli.sysid_regular AS sysid_regular,
			rli.account_no AS account_no_loan,
			mbi_loan.sysid_member AS sysid_member_loan,
			mbi_loan.member_id AS member_id_loan,
			pri_loan.sysid_person AS sysid_person_loan,
			pri_loan.last_name AS last_name_loan,
			pri_loan.first_name AS first_name_loan,
			pri_loan.middle_name AS middle_name_loan,

			--dvi.sysid_inhousedebit
			ihd.sysid_inhousedebit AS sysid_inhousedebit,
			ihd.hospital_name AS hospital_name_inhouse,
			ihd.date_from AS date_from_inhouse,
			ihd.date_to AS date_to_inhouse,
			mbi_inhouse.sysid_member AS sysid_member_inhouse,
			mbi_inhouse.member_id AS member_id_inhouse,
			pri_inhouse.sysid_person AS sysid_person_inhouse,
			pri_inhouse.last_name AS last_name_inhouse,
			pri_inhouse.first_name AS first_name_inhouse,
			pri_inhouse.middle_name AS middle_name_inhouse
		FROM
			lms.disbursement_voucher_information AS dvi
		INNER JOIN lms.bank_information AS bnk ON bnk.sysid_bank = dvi.sysid_bank
		INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = bnk.sysid_account
		INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
		LEFT JOIN lms.regular_loan_information AS rli ON rli.sysid_regular = dvi.sysid_regular
		LEFT JOIN lms.member_information AS mbi_loan ON mbi_loan.sysid_member = rli.sysid_member
		LEFT JOIN lms.person_information AS pri_loan ON pri_loan.sysid_person = mbi_loan.sysid_person
		LEFT JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_inhousedebit = dvi.sysid_inhousedebit
		LEFT JOIN lms.member_information AS mbi_inhouse ON mbi_inhouse.sysid_member = ihd.sysid_member
		LEFT JOIN lms.person_information AS pri_inhouse ON pri_inhouse.sysid_person = mbi_inhouse.sysid_person
		WHERE
			(dvi.sysid_voucher = @sysid_voucher)
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a disbursement voucher information', 'Disbursement Voucher Information'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDVoucherDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation')
   DROP PROCEDURE lms.SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation
	
	@query_string varchar (50) = '',

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'

		IF (NOT ISNULL(@query_string, '') = '%*%')
		BEGIN

			SELECT		--FOR REGULAR LOAN
				rli.sysid_regular AS transaction_system_id,	
				rli.account_no AS transaction_account,
				(ISNULL(rli.loan_amount, 0) + ISNULL(loan_additions.addition_amount, 0)) - ISNULL(loan_charges.charge_amount, 0) AS transaction_amount,
				rli.date_approved AS transaction_date,

				rlt.regular_loan_type_description AS transaction_description_name,

				mbi.sysid_member AS sysid_member,
				pri.sysid_person AS sysid_person,
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name,			

				'true' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.regular_loan_information AS rli
			INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN
			(
				SELECT
					inner_rln.sysid_regular AS sysid_regular,
					SUM(inner_rln.addition_amount) AS addition_amount
				FROM
					lms.regular_loan_additions AS inner_rln
				LEFT JOIN
				(
					SELECT
						inner_dvi.sysid_regular AS sysid_regular
					FROM
						lms.disbursement_voucher_information AS inner_dvi
					WHERE
						(NOT inner_dvi.sysid_regular IS NULL)
				) AS inner_exclude_disbursement ON inner_exclude_disbursement.sysid_regular = inner_rln.sysid_regular
				WHERE
					(inner_exclude_disbursement.sysid_regular IS NULL)
				GROUP BY
					inner_rln.sysid_regular

			) AS loan_additions ON loan_additions.sysid_regular = rli.sysid_regular
			LEFT JOIN
			(
				SELECT
					inner_rlg.sysid_regular AS sysid_regular,
					SUM(inner_rlg.charge_amount) AS charge_amount
				FROM
					lms.regular_loan_charges AS inner_rlg
				LEFT JOIN
				(
					SELECT
						inner_dvi.sysid_regular AS sysid_regular
					FROM
						lms.disbursement_voucher_information AS inner_dvi
					WHERE
						(NOT inner_dvi.sysid_regular IS NULL)
				) AS inner_exclude_disbursement ON inner_exclude_disbursement.sysid_regular = inner_rlg.sysid_regular
				WHERE
					(inner_exclude_disbursement.sysid_regular IS NULL)
				GROUP BY
					inner_rlg.sysid_regular
				
			) AS loan_charges ON loan_charges.sysid_regular = rli.sysid_regular
			LEFT JOIN
			(
				SELECT
					dvi.sysid_regular AS sysid_regular,
					dvi.is_marked_deleted AS is_marked_deleted
				FROM
					lms.disbursement_voucher_information AS dvi
				WHERE
					(NOT dvi.sysid_regular IS NULL)

			) AS exclude_disbursement ON exclude_disbursement.sysid_regular = rli.sysid_regular
			WHERE
				(rli.is_marked_deleted = 0) AND
				((exclude_disbursement.sysid_regular IS NULL) OR
				((NOT exclude_disbursement.sysid_regular IS NULL) AND
				(exclude_disbursement.is_marked_deleted = 1))) AND
				((rli.account_no LIKE @query_string) OR 
				((REPLACE(rli.account_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.occupation LIKE @query_string) OR 
				((REPLACE(pri.occupation, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
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
			UNION ALL
			SELECT		--FOR IN HOUSE HOSPITALIZATION DEBIT
				ihd.sysid_inhousedebit AS transaction_system_id,	
				ihd.hospital_name AS transaction_account,	
				ihd.net_assistance_amount AS transaction_amount,
				ihd.reflected_date AS transaction_date,

				'In-House Hospitalization' AS transaction_description_name,

				mbi.sysid_member AS sysid_member,
				pri.sysid_person AS sysid_person,
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name,			

				'false' AS is_regular_loan,
				'true' AS is_inhouse_hospitalization_debit
			FROM
				lms.in_house_hospitalization_debit AS ihd
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = ihd.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN
			(
				SELECT
					dvi.sysid_inhousedebit AS sysid_inhousedebit,
					dvi.is_marked_deleted AS is_marked_deleted
				FROM
					lms.disbursement_voucher_information AS dvi
				WHERE
					(NOT dvi.sysid_inhousedebit IS NULL)

			) AS exclude_disbursement ON exclude_disbursement.sysid_inhousedebit = ihd.sysid_inhousedebit
			WHERE
				(ihd.is_marked_deleted = 0) AND
				((exclude_disbursement.sysid_inhousedebit IS NULL) OR
				((NOT exclude_disbursement.sysid_inhousedebit IS NULL) AND
				(exclude_disbursement.is_marked_deleted = 1))) AND
				((ihd.hospital_name LIKE @query_string) OR 
				((REPLACE(ihd.hospital_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mbi.member_id LIKE @query_string) OR 
				((REPLACE(mbi.member_id, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(pri.occupation LIKE @query_string) OR 
				((REPLACE(pri.occupation, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
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

		END
		ELSE 
		BEGIN

			SELECT		--FOR REGULAR LOAN
				rli.sysid_regular AS transaction_system_id,	
				rli.account_no AS transaction_account,
				(ISNULL(rli.loan_amount, 0) + ISNULL(loan_additions.addition_amount, 0)) - ISNULL(loan_charges.charge_amount, 0) AS transaction_amount,
				rli.date_approved AS transaction_date,

				rlt.regular_loan_type_description AS transaction_description_name,

				mbi.sysid_member AS sysid_member,
				pri.sysid_person AS sysid_person,
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name,			

				'true' AS is_regular_loan,
				'false' AS is_inhouse_hospitalization_debit
			FROM
				lms.regular_loan_information AS rli
			INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN
			(
				SELECT
					inner_rln.sysid_regular AS sysid_regular,
					SUM(inner_rln.addition_amount) AS addition_amount
				FROM
					lms.regular_loan_additions AS inner_rln
				LEFT JOIN
				(
					SELECT
						inner_dvi.sysid_regular AS sysid_regular
					FROM
						lms.disbursement_voucher_information AS inner_dvi
					WHERE
						(NOT inner_dvi.sysid_regular IS NULL)
				) AS inner_exclude_disbursement ON inner_exclude_disbursement.sysid_regular = inner_rln.sysid_regular
				WHERE
					(inner_exclude_disbursement.sysid_regular IS NULL)
				GROUP BY
					inner_rln.sysid_regular

			) AS loan_additions ON loan_additions.sysid_regular = rli.sysid_regular
			LEFT JOIN
			(
				SELECT
					inner_rlg.sysid_regular AS sysid_regular,
					SUM(inner_rlg.charge_amount) AS charge_amount
				FROM
					lms.regular_loan_charges AS inner_rlg
				LEFT JOIN
				(
					SELECT
						inner_dvi.sysid_regular AS sysid_regular
					FROM
						lms.disbursement_voucher_information AS inner_dvi
					WHERE
						(NOT inner_dvi.sysid_regular IS NULL)
				) AS inner_exclude_disbursement ON inner_exclude_disbursement.sysid_regular = inner_rlg.sysid_regular
				WHERE
					(inner_exclude_disbursement.sysid_regular IS NULL)
				GROUP BY
					inner_rlg.sysid_regular
				
			) AS loan_charges ON loan_charges.sysid_regular = rli.sysid_regular
			LEFT JOIN
			(
				SELECT
					dvi.sysid_regular AS sysid_regular,
					dvi.is_marked_deleted AS is_marked_deleted
				FROM
					lms.disbursement_voucher_information AS dvi
				WHERE
					(NOT dvi.sysid_regular IS NULL)

			) AS exclude_disbursement ON exclude_disbursement.sysid_regular = rli.sysid_regular
			WHERE
				(rli.is_marked_deleted = 0) AND
				((exclude_disbursement.sysid_regular IS NULL) OR
				((NOT exclude_disbursement.sysid_regular IS NULL) AND
				(exclude_disbursement.is_marked_deleted = 1)))
			UNION ALL
			SELECT		--FOR IN HOUSE HOSPITALIZATION DEBIT
				ihd.sysid_inhousedebit AS transaction_system_id,	
				ihd.hospital_name AS transaction_account,	
				ihd.net_assistance_amount AS transaction_amount,
				ihd.reflected_date AS transaction_date,

				'In-House Hospitalization' AS transaction_description_name,

				mbi.sysid_member AS sysid_member,
				pri.sysid_person AS sysid_person,
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name,			

				'false' AS is_regular_loan,
				'true' AS is_inhouse_hospitalization_debit
			FROM
				lms.in_house_hospitalization_debit AS ihd
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = ihd.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			LEFT JOIN
			(
				SELECT
					dvi.sysid_inhousedebit AS sysid_inhousedebit,
					dvi.is_marked_deleted AS is_marked_deleted
				FROM
					lms.disbursement_voucher_information AS dvi
				WHERE
					(NOT dvi.sysid_inhousedebit IS NULL)

			) AS exclude_disbursement ON exclude_disbursement.sysid_inhousedebit = ihd.sysid_inhousedebit
			WHERE
				(ihd.is_marked_deleted = 0) AND
				((exclude_disbursement.sysid_inhousedebit IS NULL) OR
				((NOT exclude_disbursement.sysid_inhousedebit IS NULL) AND
				(exclude_disbursement.is_marked_deleted = 1)))

		END

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a disbursement voucher information', 'Disbursement Voucher Information'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountDisbursementVoucherInformation')
   DROP PROCEDURE lms.SelectCountDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.SelectCountDisbursementVoucherInformation

	@system_user_id varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT COUNT(sysid_voucher) FROM lms.disbursement_voucher_information
				
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a disbursement voucher information', 'Disbursement Voucher Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDDisbursementVoucherInformation')
   DROP PROCEDURE lms.IsExistsSysIDDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.IsExistsSysIDDisbursementVoucherInformation

	@sysid_voucher varchar (50) = '',

	@system_user_id varchar (50) = ''	
		
AS
	
	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT lms.IsExistsSysIDDisbursementVoucherInfo(@sysid_voucher)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a disbursement voucher information', 'Disbursement Voucher Information'
	END	
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsBankCheckNoDisbursementVoucherInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsBankCheckNoDisbursementVoucherInformation')
   DROP PROCEDURE lms.IsExistsBankCheckNoDisbursementVoucherInformation
GO

CREATE PROCEDURE lms.IsExistsBankCheckNoDisbursementVoucherInformation

	@sysid_voucher varchar (50) = '',
	@sysid_bank varchar (50) = '',
	@check_no varchar (50),

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsBankCheckNoDisbursementVoucherInfo(@sysid_voucher, @sysid_bank, @check_no)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a disbursement voucher information', 'Disbursement Voucher Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsBankCheckNoDisbursementVoucherInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDDisbursementVoucherInfo" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDDisbursementVoucherInfo') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDDisbursementVoucherInfo
GO

CREATE FUNCTION lms.IsExistsSysIDDisbursementVoucherInfo
(	
	@sysid_voucher varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_voucher FROM lms.disbursement_voucher_information WHERE sysid_voucher = @sysid_voucher)
	BEGIN
		SET @result = 1
	END	
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsExistsBankCheckNoDisbursementVoucherInfo" function already exist
IF OBJECT_ID (N'lms.IsExistsBankCheckNoDisbursementVoucherInfo') IS NOT NULL
   DROP FUNCTION lms.IsExistsBankCheckNoDisbursementVoucherInfo
GO

CREATE FUNCTION lms.IsExistsBankCheckNoDisbursementVoucherInfo
(	
	@sysid_voucher varchar (50) = '',
	@sysid_bank varchar (50) = '',
	@check_no varchar (50)
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_voucher FROM lms.disbursement_voucher_information WHERE (NOT sysid_voucher = @sysid_voucher) AND						
						(sysid_bank = @sysid_bank) AND						
						(REPLACE(check_no, ' ', '') LIKE REPLACE(@check_no, ' ', '')))
								
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------


-- ###############################################END TABLE "disbursement_voucher_information" OBJECTS######################################################






-- ################################################TABLE "disbursement_voucher_entry" OBJECTS######################################################
-- verifies if the disbursement_voucher_entry table exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
	DROP TABLE lms.disbursement_voucher_entry
GO

CREATE TABLE lms.disbursement_voucher_entry 			
(
	voucher_entry_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Disbursement_Voucher_Entry_Voucher_Entry_ID_PK PRIMARY KEY (voucher_entry_id),
	sysid_voucher varchar (50) NOT NULL 
		CONSTRAINT Disbursement_Voucher_Entry_SysID_Voucher_FK FOREIGN KEY REFERENCES lms.disbursement_voucher_information(sysid_voucher) ON UPDATE NO ACTION,
	sysid_account varchar (50) NOT NULL
		CONSTRAINT Disbursement_Voucher_Entry_SysID_Account_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,
	cost_center_id varchar (50) NOT NULL
		CONSTRAINT Disbursement_Voucher_Entry_Cost_Center_ID_FK FOREIGN KEY REFERENCES lms.department_information(department_id) ON UPDATE NO ACTION,
	
	debit_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	credit_amount decimal (15, 2) NOT NULL DEFAULT (0.00),

	sequence_no smallint NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Disbursement_Voucher_Entry_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Disbursement_Voucher_Entry_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Disbursement_Voucher_Entry_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the disbursement_voucher_entry table 
CREATE INDEX Disbursement_Voucher_Entry_Voucher_Entry_ID_Index
	ON lms.disbursement_voucher_entry (voucher_entry_id ASC)
GO
------------------------------------------------------------------

-- create an index of the disbursement_voucher_entry table 
CREATE INDEX Disbursement_Voucher_Entry_SysID_Voucher_Index
	ON lms.disbursement_voucher_entry (sysid_voucher DESC)
GO
------------------------------------------------------------------

-- create an index of the disbursement_voucher_entry table 
CREATE INDEX Disbursement_Voucher_Entry_SysID_Account_Index
	ON lms.disbursement_voucher_entry (sysid_account ASC)
GO
------------------------------------------------------------------

-- create an index of the disbursement_voucher_entry table 
CREATE INDEX Disbursement_Voucher_Entry_Cost_Center_ID_Index
	ON lms.disbursement_voucher_entry (cost_center_id ASC)
GO
------------------------------------------------------------------

--verifies that the trigger "Disbursement_Voucher_Entry_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Disbursement_Voucher_Entry_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Disbursement_Voucher_Entry_Trigger_Insert
GO

CREATE TRIGGER lms.Disbursement_Voucher_Entry_Trigger_Insert
	ON  lms.disbursement_voucher_entry
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @voucher_entry_id bigint
	DECLARE @sysid_voucher varchar (50)
	DECLARE @sysid_account varchar (50)
	DECLARE @cost_center_id varchar (50)	
	DECLARE @debit_amount decimal (15, 2)
	DECLARE @credit_amount decimal (15, 2)
	DECLARE @sequence_no smallint

	DECLARE @created_by varchar (50)
	
	SELECT 
		@voucher_entry_id = i.voucher_entry_id,
		@sysid_voucher = i.sysid_voucher,
		@sysid_account = i.sysid_account,
		@cost_center_id = i.cost_center_id,
		@debit_amount = i.debit_amount, 
		@credit_amount = i.credit_amount,
		@sequence_no = i.sequence_no,

		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new disbursement voucher entry ' + 
							'[Voucher Entry ID: ' + ISNULL(CONVERT(varchar, @voucher_entry_id), '') +
							'[Voucher No.: ' + ISNULL(@sysid_voucher, '') +
							'][Bank Name: ' + ISNULL((SELECT
															'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
														FROM
															lms.bank_information AS bnk
														INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_bank = bnk.sysid_bank
														WHERE
															dvi.sysid_voucher = @sysid_voucher), '') +
							'][Check No.: ' + ISNULL((SELECT
															check_no
														FROM
															lms.disbursement_voucher_information
														WHERE
															sysid_voucher = @sysid_voucher), '') +
							'][Check Date: ' + ISNULL(CONVERT(varchar, (SELECT
																				check_date
																			FROM
																				lms.disbursement_voucher_information
																			WHERE
																				sysid_voucher = @sysid_voucher), 101), '') +
							'][Payee: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
													INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_regular = rli.sysid_regular
													WHERE
														dvi.sysid_voucher = @sysid_voucher),
													ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_inhousedebit = ihd.sysid_inhousedebit
															WHERE
																dvi.sysid_voucher = @sysid_voucher), ISNULL((SELECT
																													payee
																												FROM
																													lms.disbursement_voucher_information
																												WHERE
																													sysid_voucher = @sysid_voucher), ''))) +
							'][Account Entry: ' + ISNULL((SELECT
																account_code + ' - ' + account_name
															FROM
																lms.chart_of_accounts
															WHERE
																sysid_account = @sysid_account), '') +
							'][Cost Center: ' + ISNULL((SELECT
															department_name + ' (' + acronym + ')'
														FROM
															lms.department_information
														WHERE
															department_id = @cost_center_id), '') +			
							'][Debit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @debit_amount), 1), '0.00') +	
							'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
							'][Sequence No.: ' + ISNULL(CONVERT(varchar, @sequence_no), '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-------------------------------------------------------------------

--verifies that the trigger "Disbursement_Voucher_Entry_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Disbursement_Voucher_Entry_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Disbursement_Voucher_Entry_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Disbursement_Voucher_Entry_Trigger_Instead_Update
	ON  lms.disbursement_voucher_entry
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @voucher_entry_id bigint
	DECLARE @sysid_voucher varchar (50)
	DECLARE @sysid_account varchar (50)
	DECLARE @cost_center_id varchar (50)	
	DECLARE @debit_amount decimal (15, 2)
	DECLARE @credit_amount decimal (15, 2)
	DECLARE @sequence_no smallint

	DECLARE @edited_by varchar (50)
	
	DECLARE @sysid_account_b varchar (50)
	DECLARE @cost_center_id_b varchar (50)	
	DECLARE @debit_amount_b decimal (15, 2)
	DECLARE @credit_amount_b decimal (15, 2)
	DECLARE @sequence_no_b smallint

	DECLARE @has_update bit

	DECLARE disbursement_voucher_entry_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.voucher_entry_id, i.sysid_voucher, i.sysid_account, i.cost_center_id, i.debit_amount, 
					i.credit_amount, i.sequence_no, i.edited_by
				FROM INSERTED AS i

	OPEN disbursement_voucher_entry_update_cursor

	FETCH NEXT FROM disbursement_voucher_entry_update_cursor
		INTO @voucher_entry_id, @sysid_voucher, @sysid_account, @cost_center_id, @debit_amount, 
					@credit_amount, @sequence_no, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT 
			@sysid_account_b = dve.sysid_account,
			@cost_center_id_b = dve.cost_center_id,
			@debit_amount_b = dve.debit_amount, 
			@credit_amount_b = dve.credit_amount,
			@sequence_no_b = dve.sequence_no
		FROM 
			lms.disbursement_voucher_entry AS dve
		WHERE 
			dve.voucher_entry_id = @voucher_entry_id

		SET @transaction_done = ''
		SET @has_update = 0

		IF NOT ISNULL(@sysid_account COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Entry Before: ' + ISNULL((SELECT
																								account_code + ' - ' + account_name
																							FROM
																								lms.chart_of_accounts
																							WHERE
																								sysid_account = @sysid_account_b), '') + ']' +
														'[Account Entry After: ' + ISNULL((SELECT
																								account_code + ' - ' + account_name
																							FROM
																								lms.chart_of_accounts
																							WHERE
																								sysid_account = @sysid_account), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Entry: ' + ISNULL((SELECT
																							account_code + ' - ' + account_name
																						FROM
																							lms.chart_of_accounts
																						WHERE
																							sysid_account = @sysid_account), '') + ']'
		END

		IF NOT ISNULL(@cost_center_id COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@cost_center_id_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Cost Center Before: ' + ISNULL((SELECT
																								department_name + ' (' + acronym + ')'
																							FROM
																								lms.department_information
																							WHERE
																								department_id = @cost_center_id_b), '') +	']' +
														'[Cost Center After: ' + ISNULL((SELECT
																								department_name + ' (' + acronym + ')'
																							FROM
																								lms.department_information
																							WHERE
																								department_id = @cost_center_id), '') +	 ']'
			SET @has_update = 1
		END

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @debit_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @debit_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Debit Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @debit_amount_b), 1), '0.00') + ']' +
														'[Debit Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @debit_amount), 1), '0.00') + ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00') + ']' +
														'[Credit Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') + ']'
			SET @has_update = 1
		END				

		IF @has_update = 1
		BEGIN

			UPDATE lms.disbursement_voucher_entry SET
				sysid_account = @sysid_account,
				cost_center_id = @cost_center_id,
				debit_amount = @debit_amount, 
				credit_amount = @credit_amount,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				voucher_entry_id = @voucher_entry_id

			SET @transaction_done = 'UPDATED a disbursement voucher entry ' + 
									'[Voucher Entry ID: ' + ISNULL(CONVERT(varchar, @voucher_entry_id), '') +
									'[Voucher No.: ' + ISNULL(@sysid_voucher, '') +
									'][Bank Name: ' + ISNULL((SELECT
																	'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
																FROM
																	lms.bank_information AS bnk
																INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_bank = bnk.sysid_bank
																WHERE
																	dvi.sysid_voucher = @sysid_voucher), '') +
									'][Check No.: ' + ISNULL((SELECT
																	check_no
																FROM
																	lms.disbursement_voucher_information
																WHERE
																	sysid_voucher = @sysid_voucher), '') +
									'][Check Date: ' + ISNULL(CONVERT(varchar, (SELECT
																						check_date
																					FROM
																						lms.disbursement_voucher_information
																					WHERE
																						sysid_voucher = @sysid_voucher), 101), '') +
									'][Payee: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_regular = rli.sysid_regular
															WHERE
																dvi.sysid_voucher = @sysid_voucher),
															ISNULL((SELECT 
																		pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
																	FROM
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																	INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_inhousedebit = ihd.sysid_inhousedebit
																	WHERE
																		dvi.sysid_voucher = @sysid_voucher), ISNULL((SELECT
																															payee
																														FROM
																															lms.disbursement_voucher_information
																														WHERE
																															sysid_voucher = @sysid_voucher), ''))) +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END
					
			EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done	

		END
		ELSE IF (NOT @sequence_no = @sequence_no_b)
		BEGIN

			UPDATE lms.disbursement_voucher_entry SET
				sequence_no = @sequence_no,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(voucher_entry_id = @voucher_entry_id)
	
		END
		ELSE IF NOT @edited_by IS NULL
		BEGIN

			--used for the delete trigger
			UPDATE lms.disbursement_voucher_entry SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(voucher_entry_id = @voucher_entry_id)

		END

		FETCH NEXT FROM disbursement_voucher_entry_update_cursor
			INTO @voucher_entry_id, @sysid_voucher, @sysid_account, @cost_center_id, @debit_amount, 
						@credit_amount, @sequence_no, @edited_by

	END

	CLOSE disbursement_voucher_entry_update_cursor
	DEALLOCATE disbursement_voucher_entry_update_cursor

GO
-----------------------------------------------------------------

-- verifies that the trigger "Disbursement_Voucher_Entry_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Disbursement_Voucher_Entry_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Disbursement_Voucher_Entry_Trigger_Delete
GO

CREATE TRIGGER lms.Disbursement_Voucher_Entry_Trigger_Delete
	ON  lms.disbursement_voucher_entry
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @voucher_entry_id bigint
	DECLARE @sysid_voucher varchar (50)
	DECLARE @sysid_account varchar (50)
	DECLARE @cost_center_id varchar (50)	
	DECLARE @debit_amount decimal (15, 2)
	DECLARE @credit_amount decimal (15, 2)
	DECLARE @sequence_no smallint

	DECLARE @deleted_by varchar(50)

	DECLARE disbursement_voucher_entry_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.voucher_entry_id, d.sysid_voucher, d.sysid_account, d.cost_center_id, d.debit_amount, 
					d.credit_amount, d.sequence_no, d.edited_by
				FROM DELETED AS d

	OPEN disbursement_voucher_entry_delete_cursor

	FETCH NEXT FROM disbursement_voucher_entry_delete_cursor
		INTO @voucher_entry_id, @sysid_voucher, @sysid_account, @cost_center_id, @debit_amount, 
					@credit_amount, @sequence_no, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		SET @transaction_done = 'DELETED a disbursement voucher entry ' + 
								'[Voucher Entry ID: ' + ISNULL(CONVERT(varchar, @voucher_entry_id), '') +
								'[Voucher No.: ' + ISNULL(@sysid_voucher, '') +
								'][Bank Name: ' + ISNULL((SELECT
																'(' + ISNULL(account_no, '') + ') ' + ISNULL(bank_name, '')
															FROM
																lms.bank_information AS bnk
															INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_bank = bnk.sysid_bank
															WHERE
																dvi.sysid_voucher = @sysid_voucher), '') +
								'][Check No.: ' + ISNULL((SELECT
																check_no
															FROM
																lms.disbursement_voucher_information
															WHERE
																sysid_voucher = @sysid_voucher), '') +
								'][Check Date: ' + ISNULL(CONVERT(varchar, (SELECT
																					check_date
																				FROM
																					lms.disbursement_voucher_information
																				WHERE
																					sysid_voucher = @sysid_voucher), 101), '') +
								'][Payee: ' + ISNULL((SELECT 
															pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
														FROM
															lms.person_information AS pri
														INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
														INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
														INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_regular = rli.sysid_regular
														WHERE
															dvi.sysid_voucher = @sysid_voucher),
														ISNULL((SELECT 
																	pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')'
																FROM
																	lms.person_information AS pri
																INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_inhousedebit = ihd.sysid_inhousedebit
																WHERE
																	dvi.sysid_voucher = @sysid_voucher), ISNULL((SELECT
																														payee
																													FROM
																														lms.disbursement_voucher_information
																													WHERE
																														sysid_voucher = @sysid_voucher), ''))) +
								'][Account Entry: ' + ISNULL((SELECT
																	account_code + ' - ' + account_name
																FROM
																	lms.chart_of_accounts
																WHERE
																	sysid_account = @sysid_account), '') +
								'][Cost Center: ' + ISNULL((SELECT
																department_name + ' (' + acronym + ')'
															FROM
																lms.department_information
															WHERE
																department_id = @cost_center_id), '') +			
								'][Debit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @debit_amount), 1), '0.00') +	
								'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
								'][Sequence No.: ' + ISNULL(CONVERT(varchar, @sequence_no), '') +
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
				
		FETCH NEXT FROM disbursement_voucher_entry_delete_cursor
			INTO @voucher_entry_id, @sysid_voucher, @sysid_account, @cost_center_id, @debit_amount, 
						@credit_amount, @sequence_no, @deleted_by

	END

	CLOSE disbursement_voucher_entry_delete_cursor
	DEALLOCATE disbursement_voucher_entry_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertDisbursementVoucherEntry" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertDisbursementVoucherEntry')
   DROP PROCEDURE lms.InsertDisbursementVoucherEntry
GO

CREATE PROCEDURE lms.InsertDisbursementVoucherEntry

	@sysid_voucher varchar (50) = '',
	@sysid_account varchar (50) = '',
	@cost_center_id varchar (50) = '',
	@debit_amount decimal (15, 2) = 0.00,
	@credit_amount decimal (15, 2) = 0.00,
	@sequence_no smallint = 0,

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@created_by) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@created_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.disbursement_voucher_entry
		(
			sysid_voucher,
			sysid_account,
			cost_center_id,
			debit_amount,
			credit_amount,
			sequence_no,

			created_by
		)
		VALUES
		(
			@sysid_voucher,
			@sysid_account,
			@cost_center_id,
			@debit_amount,
			@credit_amount,
			@sequence_no,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a disbursement voucher entry', 'Disbursement Voucher Entry'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertDisbursementVoucherEntry TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateDisbursementVoucherEntry" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateDisbursementVoucherEntry')
   DROP PROCEDURE lms.UpdateDisbursementVoucherEntry
GO

CREATE PROCEDURE lms.UpdateDisbursementVoucherEntry

	@voucher_entry_id bigint = 0,
	@sysid_account varchar (50) = '',
	@cost_center_id varchar (50) = '',
	@debit_amount decimal (15, 2) = 0.00,
	@credit_amount decimal (15, 2) = 0.00,
	@sequence_no smallint = 0,

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@edited_by) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@edited_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.disbursement_voucher_entry SET
			sysid_account = @sysid_account,
			cost_center_id = @cost_center_id,
			debit_amount = @debit_amount, 
			credit_amount = @credit_amount,
			sequence_no = @sequence_no,

			edited_by = @edited_by
		WHERE
			voucher_entry_id = @voucher_entry_id
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a disbursement voucher entry', 'Disbursement Voucher Entry'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateDisbursementVoucherEntry TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteDisbursementVoucherEntry" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteDisbursementVoucherEntry')
   DROP PROCEDURE lms.DeleteDisbursementVoucherEntry
GO

CREATE PROCEDURE lms.DeleteDisbursementVoucherEntry
	
	@voucher_entry_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT voucher_entry_id FROM lms.disbursement_voucher_entry WHERE voucher_entry_id = @voucher_entry_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.disbursement_voucher_entry SET
				edited_by = @deleted_by
			WHERE
				(voucher_entry_id = @voucher_entry_id)

			DELETE FROM lms.disbursement_voucher_entry WHERE (voucher_entry_id = @voucher_entry_id)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a disbursement voucher entry', 'Disbursement Voucher Entry'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteDisbursementVoucherEntry TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDVoucherListDisbursementVoucherEntry" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDVoucherListDisbursementVoucherEntry')
   DROP PROCEDURE lms.SelectBySysIDVoucherListDisbursementVoucherEntry
GO

CREATE PROCEDURE lms.SelectBySysIDVoucherListDisbursementVoucherEntry

	@sysid_voucher_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT
			dve.voucher_entry_id AS voucher_entry_id,
			dve.sysid_voucher AS sysid_voucher,
			dve.debit_amount AS debit_amount,
			dve.credit_amount AS credit_amount,
			dve.sequence_no AS sequence_no,

			--dve.sysid_account
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,
			coa.is_debit_side_increase AS is_debit_side_increase,
			coa.is_active_account AS is_active_account_account,

			--coa.accounting_category_id
			acg.accounting_category_id AS accounting_category_id,
			acg.category_description AS category_description,

			--coa.summary_account
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			summary_coa.is_debit_side_increase AS is_debit_side_increase_summary,
			summary_coa.is_active_account AS is_active_account_summary,

			--summary_coa.accounting_category_id
			summary_acg.accounting_category_id AS accounting_category_id_summary,
			summary_acg.category_description AS category_description_summary,

			--dve.cost_center_id
			dpi.department_id AS cost_center_id,
			dpi.department_name AS department_name,
			dpi.acronym AS acronym
		FROM
			lms.disbursement_voucher_entry AS dve
		INNER JOIN lms.IterateListToTable (@sysid_voucher_list, ',') AS svl_list ON svl_list.var_str = dve.sysid_voucher
		INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = dve.sysid_account
		INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
		INNER JOIN lms.department_information AS dpi ON dpi.department_id = dve.cost_center_id
		ORDER BY
			dve.sysid_voucher ASC, dve.sequence_no ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a disbursement voucher entry', 'Disbursement Voucher Entry'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDVoucherListDisbursementVoucherEntry TO db_lmsusers
GO
-------------------------------------------------------------


-- ##############################################END TABLE "disbursement_voucher_entry" OBJECTS######################################################







-- ######################################RESTORE DEPENDENT TABLE CONSTRAINTS#############################################################


-- ###################################END RESTORE DEPENDENT TABLE CONSTRAINTS############################################################




-- ############################################INITIAL DATABASE INFORMATION#############################################################
-- lms.department_information
INSERT INTO lms.department_information(department_id, department_name, acronym)
	SELECT 'DEPT001', 'Organizational', 'ORG'
	UNION ALL
	SELECT 'DEPT002', 'H.A.P Division', 'HAP'
	UNION ALL
	SELECT 'DEPT003', 'Accounting Division', 'ACCT'
	UNION ALL
	SELECT 'DEPT004', 'Loans Division', 'LOAN'
	UNION ALL
	SELECT 'DEPT005', 'Cash Division', 'CASH'
GO
-- ##########################################END INITIAL DATABASE INFORMATION#############################################################







-- ########################################FOR CODE DEBUGGING########################################################################



-- ######################################END FOR CODE DEBUGGING########################################################################

