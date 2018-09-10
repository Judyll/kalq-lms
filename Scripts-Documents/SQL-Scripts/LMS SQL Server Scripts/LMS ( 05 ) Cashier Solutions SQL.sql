/********************************************************/
/* This SQL Statements is used for the					*/
/* 		Loan Management System (LMS)					*/
/*Programmed by: Judyll Mark T. Agan					*/
/*Date created: May 07, 2010							*/
/*CASHIER SOLUTIONS [ 5 ]								*/
/********************************************************/

USE db_lmsdev_03092010
GO


-- ###########################################DROP TABLE CONSTRAINTS ##############################################################

--verifies if the Chart_Of_Accounts_Accounting_Category_ID_FK constraint exists
IF OBJECT_ID('lms.chart_of_accounts', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.chart_of_accounts
	DROP CONSTRAINT Chart_Of_Accounts_Accounting_Category_ID_FK
END
GO
-----------------------------------------------------

--verifies if the Chart_Of_Accounts_Summary_Account_FK constraint exists
IF OBJECT_ID('lms.chart_of_accounts', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.chart_of_accounts
	DROP CONSTRAINT Chart_Of_Accounts_Summary_Account_FK
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

--verifies if the Regular_Loan_Charges_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges
	DROP CONSTRAINT Regular_Loan_Charges_SysID_Regular_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Charges_SysID_Account_FK constraint exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_charges
	DROP CONSTRAINT Regular_Loan_Charges_SysID_Account_FK
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

--verifies if the Regular_Loan_Additions_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions
	DROP CONSTRAINT Regular_Loan_Additions_SysID_Regular_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Additions_SysID_Account_FK constraint exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_additions
	DROP CONSTRAINT Regular_Loan_Additions_SysID_Account_FK
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

--verifies if the Share_Capital_Information_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_information
	DROP CONSTRAINT Share_Capital_Information_SysID_Member_FK
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

--verifies if the In_House_Hospitalization_Information_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_information
	DROP CONSTRAINT In_House_Hospitalization_Information_SysID_Member_FK
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

--verifies if the In_House_Hospitalization_Debit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_debit
	DROP CONSTRAINT In_House_Hospitalization_Debit_SysID_Member_FK
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

--verifies if the In_House_Include_Coverage_SysID_InHouseDebit_FK constraint exists
IF OBJECT_ID('lms.in_house_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_include_coverage
	DROP CONSTRAINT In_House_Include_Coverage_SysID_InHouseDebit_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Include_Coverage_SysID_IncludeCoverage_FK constraint exists
IF OBJECT_ID('lms.in_house_include_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_include_coverage
	DROP CONSTRAINT In_House_Include_Coverage_SysID_IncludeCoverage_FK
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

--verifies if the In_House_Exclude_Coverage_SysID_InHouseDebit_FK constraint exists
IF OBJECT_ID('lms.in_house_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_exclude_coverage
	DROP CONSTRAINT In_House_Exclude_Coverage_SysID_InHouseDebit_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Exclude_Coverage_SysID_ExcludeCoverage_FK constraint exists
IF OBJECT_ID('lms.in_house_exclude_coverage', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_exclude_coverage
	DROP CONSTRAINT In_House_Exclude_Coverage_SysID_ExcludeCoverage_FK
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

--verifies if the Hospitalization_Document_SysID_InHouseDebit_FK constraint exists
IF OBJECT_ID('lms.hospitalization_document', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.hospitalization_document
	DROP CONSTRAINT Hospitalization_Document_SysID_InHouseDebit_FK
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

--verifies if the Regular_Loan_Payments_SysID_Regular_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments
	DROP CONSTRAINT Regular_Loan_Payments_SysID_Regular_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_SysID_Account_Credit_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments
	DROP CONSTRAINT Regular_Loan_Payments_SysID_Account_Credit_FK
END
GO
-----------------------------------------------------

--verifies if the Regular_Loan_Payments_SysID_Account_Rebate_FK constraint exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.regular_loan_payments
	DROP CONSTRAINT Regular_Loan_Payments_SysID_Account_Rebate_FK
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

--verifies if the Share_Capital_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit
	DROP CONSTRAINT Share_Capital_Credit_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Share_Capital_Credit_SysID_Account_Credit_FK constraint exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.share_capital_credit
	DROP CONSTRAINT Share_Capital_Credit_SysID_Account_Credit_FK
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

--verifies if the Member_Equity_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit
	DROP CONSTRAINT Member_Equity_Credit_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the Member_Equity_Credit_SysID_Account_Credit_FK constraint exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.member_equity_credit
	DROP CONSTRAINT Member_Equity_Credit_SysID_Account_Credit_FK
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

--verifies if the In_House_Hospitalization_Credit_SysID_Member_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit
	DROP CONSTRAINT In_House_Hospitalization_Credit_SysID_Member_FK
END
GO
-----------------------------------------------------

--verifies if the In_House_Hospitalization_Credit_SysID_Account_Credit_FK constraint exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.in_house_hospitalization_credit
	DROP CONSTRAINT In_House_Hospitalization_Credit_SysID_Account_Credit_FK
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

--verifies if the Miscellaneous_Income_SysID_Account_Credit_FK constraint exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.miscellaneous_income
	DROP CONSTRAINT Miscellaneous_Income_SysID_Account_Credit_FK
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

--verifies if the Breakdown_Bank_Deposit_SysID_Account_FK constraint exists
IF OBJECT_ID('lms.breakdown_bank_deposit', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.breakdown_bank_deposit
	DROP CONSTRAINT Breakdown_Bank_Deposit_SysID_Account_FK
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

-- #########################################END DROP TABLE CONSTRAINTS ##############################################################





-- ########################################DROP DEPENDENT TABLE CONSTRAINTS ##############################################################
--verifies if the Bank_Information_SysID_Acccount_FK constraint exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.bank_information
	DROP CONSTRAINT Bank_Information_SysID_Acccount_FK
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

--verifies if the Disbursement_Voucher_Entry_SysID_Account_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry
	DROP CONSTRAINT Disbursement_Voucher_Entry_SysID_Account_FK
END
GO
-----------------------------------------------------

-- ######################################END DROP DEPENDENT TABLE CONSTRAINTS ##############################################################





-- ################################################TABLE "accounting_category" OBJECTS######################################################
-- verifies if the accounting_category table exists
IF OBJECT_ID('lms.accounting_category', 'U') IS NOT NULL
	DROP TABLE lms.accounting_category
GO

CREATE TABLE lms.accounting_category 			
(
	accounting_category_id varchar (50) NOT NULL 
		CONSTRAINT Accounting_Category_Accounting_Category_ID_PK PRIMARY KEY (accounting_category_id)
		CONSTRAINT Accounting_Category_Accounting_Category_ID_CK CHECK (accounting_category_id LIKE 'ACID%'),
	category_description varchar (100) NOT NULL
		CONSTRAINT Accounting_Category_Category_Description_UQ UNIQUE (category_description),
	category_no tinyint NOT NULL
		CONSTRAINT Accounting_Category_Category_No_UQ UNIQUE (category_no),

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Accounting_Category_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- verifies that the trigger "Accounting_Category_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Accounting_Category_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Accounting_Category_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Accounting_Category_Trigger_Instead_Update
	ON  lms.accounting_category
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Update an accounting category', 'Accounting Category'
	
GO
-------------------------------------------------------------------------

-- verifies that the trigger "Accounting_Category_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Accounting_Category_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Accounting_Category_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Accounting_Category_Trigger_Instead_Delete
	ON  lms.accounting_category
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete an accounting category', 'Accounting Category'
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "SelectAccountingCategory" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectAccountingCategory')
   DROP PROCEDURE lms.SelectAccountingCategory
GO

CREATE PROCEDURE lms.SelectAccountingCategory
	
	@system_user_id varchar(50) = ''
	
AS

	IF lms.IsActiveSystemUserInfo(@system_user_id) = 1
	BEGIN
		
		SELECT
			acg.accounting_category_id AS accounting_category_id,
			acg.category_description AS category_description,
			acg.category_no AS category_no			
		FROM
			lms.accounting_category AS acg
		ORDER BY acg.category_no ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query an accounting category', 'Accounting Category'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectAccountingCategory TO db_lmsusers
GO
-------------------------------------------------------------


-- ################################################END TABLE "accounting_category" OBJECTS###################################################





-- ################################################TABLE "chart_of_accounts" OBJECTS######################################################
-- verifies if the chart_of_accounts table exists
IF OBJECT_ID('lms.chart_of_accounts', 'U') IS NOT NULL
	DROP TABLE lms.chart_of_accounts
GO

CREATE TABLE lms.chart_of_accounts 			
(
	sysid_account varchar (50) NOT NULL 
		CONSTRAINT Chart_Of_Accounts_SysID_Account_PK PRIMARY KEY (sysid_account)
		CONSTRAINT Chart_Of_Accounts_SysID_Account_CK CHECK (sysid_account LIKE 'SYSCOA%'),	
	accounting_category_id varchar (50) NOT NULL
		CONSTRAINT Chart_Of_Accounts_Accounting_Category_ID_FK FOREIGN KEY REFERENCES lms.accounting_category(accounting_category_id) ON UPDATE NO ACTION,
	account_code varchar (50) NOT NULL
		CONSTRAINT Chart_Of_Accounts_Account_Code_UQ UNIQUE (account_code, summary_account),
	account_name varchar (150) NOT NULL,
	account_description varchar (MAX) NULL,
	company_policy_procedure varchar (MAX) NULL,
	summary_account varchar (50) NULL
		CONSTRAINT Chart_Of_Accounts_Summary_Account_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION
		CONSTRAINT Chart_Of_Accounts_Summary_Account_UQ UNIQUE (summary_account, account_code),

	is_debit_side_increase bit NOT NULL DEFAULT (0),
	is_active_account bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Chart_Of_Accounts_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Chart_Of_Accounts_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Chart_Of_Accounts_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the chart_of_accounts table 
CREATE INDEX Chart_Of_Accounts_SysID_Account_Index
	ON lms.chart_of_accounts (sysid_account ASC)
GO
------------------------------------------------------------------

--verifies that the trigger "Chart_Of_Accounts_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Chart_Of_Accounts_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Chart_Of_Accounts_Trigger_Insert
GO

CREATE TRIGGER lms.Chart_Of_Accounts_Trigger_Insert
	ON  lms.chart_of_accounts
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_account varchar (50)
	DECLARE @accounting_category_id varchar (50)
	DECLARE @account_code varchar (50)
	DECLARE @account_name varchar (150)
	DECLARE @account_description varchar (MAX)
	DECLARE @company_policy_procedure varchar (MAX)
	DECLARE @summary_account varchar (50)
	DECLARE @is_debit_side_increase bit
	DECLARE @is_active_account bit	

	DECLARE @created_by varchar (50)

	DECLARE @debit_side_string varchar (50)
	DECLARE @active_string varchar (50)
	
	SELECT 
		@sysid_account = i.sysid_account,
		@accounting_category_id = i.accounting_category_id,
		@account_code = i.account_code,
		@account_name = i.account_name,
		@account_description = i.account_description,
		@company_policy_procedure = i.company_policy_procedure,
		@summary_account = i.summary_account,
		@is_debit_side_increase = i.is_debit_side_increase,
		@is_active_account = i.is_active_account,

		@created_by = i.created_by
	FROM INSERTED AS i

	IF @is_debit_side_increase = 1
	BEGIN
		SET @debit_side_string = 'YES'
	END
	ELSE
	BEGIN
		SET @debit_side_string = 'NO'
	END

	IF @is_active_account = 1
	BEGIN
		SET @active_string = 'YES'
	END
	ELSE
	BEGIN
		SET @active_string = 'NO'
	END

	SET @transaction_done = 'CREATED a new account in the chart of accounts ' + 
							'[Account ID: ' + ISNULL(@sysid_account, '') +
							'][Accounting Category: ' + ISNULL((SELECT category_description FROM lms.accounting_category WHERE accounting_category_id = @accounting_category_id), '') +
							'][Account Code: ' + ISNULL(@account_code, '') +
							'][Account Name: ' + ISNULL(@account_name, '') +
							'][Account Description: ' + ISNULL(@account_description, '') +
							'][Company Policy/Procedure: ' + ISNULL(@company_policy_procedure, '') +
							'][Summary Account: ' + ISNULL((SELECT
																account_code + ' - ' + account_name
															FROM
																lms.chart_of_accounts
															WHERE
																sysid_account = @summary_account), '') +
							'][Is Debit Side Increase: ' + ISNULL(@debit_side_string, '') +
							'][Is Active Account: ' + ISNULL(@active_string, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-------------------------------------------------------------------

--verifies that the trigger "Chart_Of_Accounts_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Chart_Of_Accounts_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Chart_Of_Accounts_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Chart_Of_Accounts_Trigger_Instead_Update
	ON  lms.chart_of_accounts
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_account varchar (50)
	DECLARE @accounting_category_id varchar (50)
	DECLARE @account_code varchar (50)
	DECLARE @account_name varchar (150)
	DECLARE @account_description varchar (MAX)
	DECLARE @company_policy_procedure varchar (MAX)
	DECLARE @summary_account varchar (50)
	DECLARE @is_debit_side_increase bit
	DECLARE @is_active_account bit	

	DECLARE @edited_by varchar (50)
	
	DECLARE @accounting_category_id_b varchar (50)
	DECLARE @account_code_b varchar (50)
	DECLARE @account_name_b varchar (150)
	DECLARE @account_description_b varchar (MAX)
	DECLARE @company_policy_procedure_b varchar (MAX)
	DECLARE @summary_account_b varchar (50)
	DECLARE @is_debit_side_increase_b bit
	DECLARE @is_active_account_b bit
	
	DECLARE @active_string varchar (50)
	DECLARE @active_string_b varchar (50)
	DECLARE @debit_side_string varchar (50)
	DECLARE @debit_side_string_b varchar (50)

	DECLARE @has_update bit

	DECLARE chart_of_accounts_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_account, i.accounting_category_id, i.account_code, i.account_name, i.account_description,
					i.company_policy_procedure, i.summary_account, i.is_debit_side_increase, i.is_active_account, i.edited_by
				FROM INSERTED AS i

	OPEN chart_of_accounts_update_cursor

	FETCH NEXT FROM chart_of_accounts_update_cursor
		INTO @sysid_account, @accounting_category_id, @account_code, @account_name, @account_description,
					@company_policy_procedure, @summary_account, @is_debit_side_increase, @is_active_account, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT 
			@accounting_category_id_b = coa.accounting_category_id,
			@account_code_b = coa.account_code,
			@account_name_b = coa.account_name,
			@account_description_b = coa.account_description,
			@company_policy_procedure_b = coa.company_policy_procedure,
			@summary_account_b = coa.summary_account,
			@is_debit_side_increase_b = coa.is_debit_side_increase,
			@is_active_account_b = coa.is_active_account
		FROM 
			lms.chart_of_accounts AS coa
		WHERE 
			coa.sysid_account = @sysid_account

		SET @transaction_done = ''
		SET @has_update = 0

		IF NOT ISNULL(@accounting_category_id COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@accounting_category_id_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Accounting Category Before: ' + ISNULL((SELECT category_description FROM lms.accounting_category WHERE accounting_category_id = @accounting_category_id_b), '') + ']' +
														'[Accounting Category After: ' + ISNULL((SELECT category_description FROM lms.accounting_category WHERE accounting_category_id = @accounting_category_id), '') + ']'
			SET @has_update = 1
		END

		IF NOT ISNULL(@account_code COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@account_code_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Code Before: ' + ISNULL(@account_code_b, '') + ']' +
														'[Account Code After: ' + ISNULL(@account_code, '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Code: ' + ISNULL(@account_code, '') + ']'
		END

		IF NOT ISNULL(@account_name COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@account_name_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Name Before: ' + ISNULL(@account_name_b, '') + ']' +
														'[Account Name After: ' + ISNULL(@account_name, '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Name: ' + ISNULL(@account_name, '') + ']'
		END

		IF NOT ISNULL(@account_description COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@account_description_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Description Before: ' + ISNULL(@account_description_b, '') + ']' +
														'[Account Description After: ' + ISNULL(@account_description, '') + ']'
			SET @has_update = 1
		END

		IF NOT ISNULL(@company_policy_procedure COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@company_policy_procedure_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Company Policy/Procedure Before: ' + ISNULL(@company_policy_procedure_b, '') + ']' +
														'[Company Policy/Procedure After: ' + ISNULL(@company_policy_procedure, '') + ']'
			SET @has_update = 1
		END

		IF NOT ISNULL(@summary_account COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@summary_account_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Summary Account Before: ' + ISNULL((SELECT
																									account_code + ' - ' + account_name
																								FROM
																									lms.chart_of_accounts
																								WHERE
																									sysid_account = @summary_account_b), '') + ']' +
														'[Summary Account After: ' + ISNULL((SELECT
																									account_code + ' - ' + account_name
																								FROM
																									lms.chart_of_accounts
																								WHERE
																									sysid_account = @summary_account), '') + ']'
			SET @has_update = 1
		END

		IF NOT @is_debit_side_increase = @is_debit_side_increase_b
		BEGIN

			IF @is_debit_side_increase = 1
			BEGIN
				SET @debit_side_string = 'YES'
			END
			ELSE
			BEGIN
				SET @debit_side_string = 'NO'
			END

			IF @is_debit_side_increase_b = 1
			BEGIN
				SET @debit_side_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @debit_side_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Debit Side Increase Before: ' + ISNULL(@debit_side_string_b, '') + ']' +
														'[Is Debit Side Increase After: ' + ISNULL(@debit_side_string, '') +  ']'
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

			UPDATE lms.chart_of_accounts SET
				accounting_category_id = @accounting_category_id,
				account_code = @account_code,
				account_name = @account_name,
				account_description = @account_description,
				company_policy_procedure = @company_policy_procedure,
				summary_account = @summary_account,
				is_debit_side_increase = @is_debit_side_increase,
				is_active_account = @is_active_account,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				sysid_account = @sysid_account

			SET @transaction_done = 'UPDATED a new account in the chart of accounts ' + 
									'[Account ID: ' + ISNULL(@sysid_account, '') +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END
					
			EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done	

		END

		FETCH NEXT FROM chart_of_accounts_update_cursor
			INTO @sysid_account, @accounting_category_id, @account_code, @account_name, @account_description,
						@company_policy_procedure, @summary_account, @is_debit_side_increase, @is_active_account, @edited_by

	END

	CLOSE chart_of_accounts_update_cursor
	DEALLOCATE chart_of_accounts_update_cursor

GO
-----------------------------------------------------------------

-- verifies that the trigger "Chart_Of_Accounts_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Chart_Of_Accounts_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Chart_Of_Accounts_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Chart_Of_Accounts_Trigger_Instead_Delete
	ON  lms.chart_of_accounts
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a chart of accounts', 'Chart Of Accounts'
	
GO
-------------------------------------------------------------------------


-- verifies if the procedure "InsertChartOfAccounts" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertChartOfAccounts')
   DROP PROCEDURE lms.InsertChartOfAccounts
GO

CREATE PROCEDURE lms.InsertChartOfAccounts

	@sysid_account varchar (50) = '',
	@accounting_category_id varchar (50) = '',
	@account_code varchar (50) = '',
	@account_name varchar (150) = '',
	@account_description varchar (MAX) = '',
	@company_policy_procedure varchar (MAX) = '',
	@summary_account varchar (50) = '',
	@is_debit_side_increase bit = 0,
	@is_active_account bit = 0,

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@created_by) = 1)) AND
		(lms.IsValidCategoryBySummaryAccountChartOfAcc(@accounting_category_id, @summary_account) = 1)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		IF (NOT @summary_account IS NULL)
		BEGIN
			SELECT @is_debit_side_increase = is_debit_side_increase FROM lms.chart_of_accounts WHERE sysid_account = @summary_account
		END

		INSERT INTO lms.chart_of_accounts
		(
			sysid_account,
			accounting_category_id,
			account_code,
			account_name,
			account_description,
			company_policy_procedure,
			summary_account,
			is_debit_side_increase,
			is_active_account,

			created_by
		)
		VALUES
		(
			@sysid_account,
			@accounting_category_id,
			@account_code,
			@account_name,
			@account_description,
			@company_policy_procedure,
			@summary_account,
			@is_debit_side_increase,
			@is_active_account,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a chart of accounts', 'Chart Of Accounts'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertChartOfAccounts TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateChartOfAccounts" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateChartOfAccounts')
   DROP PROCEDURE lms.UpdateChartOfAccounts
GO

CREATE PROCEDURE lms.UpdateChartOfAccounts

	@sysid_account varchar (50) = '',
	@accounting_category_id varchar (50) = '',
	@account_code varchar (50) = '',
	@account_name varchar (150) = '',
	@account_description varchar (MAX) = '',
	@company_policy_procedure varchar (MAX) = '',
	@summary_account varchar (50) = '',
	@is_debit_side_increase bit = 0,
	@is_active_account bit = 0,

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsValidCategoryBySummaryAccountChartOfAcc(@accounting_category_id, @summary_account) = 1)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		IF (NOT @summary_account IS NULL)
		BEGIN
			SELECT @is_debit_side_increase = is_debit_side_increase FROM lms.chart_of_accounts WHERE sysid_account = @summary_account
		END

		UPDATE lms.chart_of_accounts SET
			accounting_category_id = @accounting_category_id,
			account_code = @account_code,
			account_name = @account_name,
			account_description = @account_description,
			company_policy_procedure = @company_policy_procedure,
			summary_account = @summary_account,
			is_debit_side_increase = @is_debit_side_increase,
			is_active_account = @is_active_account,

			edited_by = @edited_by
		WHERE
			sysid_account = @sysid_account
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a chart of accounts', 'Chart Of Accounts'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateChartOfAccounts TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectChartOfAccounts" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectChartOfAccounts')
   DROP PROCEDURE lms.SelectChartOfAccounts
GO

CREATE PROCEDURE lms.SelectChartOfAccounts
	
	@query_string varchar (50) = '',
	@summary_account varchar (50) = '',
	@accounting_category_id_list nvarchar (MAX) = '',
	@is_active_account bit = 0,

	@system_user_id varchar(50) = ''
	
AS

	-- A - '*'
	-- B - Summary Account
	-- C - Accounting Category ID List

	--	A	B	C	
	-- ============
	--	0	0	0
	--	0	0	1
	--	0	1	0
	--	0	1	1
	--	1	0	0
	--	1	0	1
	--	1	1	0	
	--	1	1	1

	
	IF (lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'

		IF (NOT ISNULL(@query_string, '') = '%*%') AND (ISNULL(@summary_account, '') = '') AND		-- (000)
				(ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				((coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_description LIKE @query_string) OR 
				((REPLACE(coa.account_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.company_policy_procedure LIKE @query_string) OR 
				((REPLACE(coa.company_policy_procedure, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (ISNULL(@summary_account, '') = '') AND		-- (001)
				(NOT ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.IterateListToTable (@accounting_category_id_list, ',') AS acidl_list ON acidl_list.var_str = acg.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				((coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_description LIKE @query_string) OR 
				((REPLACE(coa.account_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.company_policy_procedure LIKE @query_string) OR 
				((REPLACE(coa.company_policy_procedure, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@summary_account, '') = '') AND		-- (010)
				(ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				((coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_description LIKE @query_string) OR 
				((REPLACE(coa.account_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.company_policy_procedure LIKE @query_string) OR 
				((REPLACE(coa.company_policy_procedure, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(coa.summary_account = @summary_account) AND
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@summary_account, '') = '') AND		-- (011)
				(NOT ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.IterateListToTable (@accounting_category_id_list, ',') AS acidl_list ON acidl_list.var_str = acg.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				((coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_description LIKE @query_string) OR 
				((REPLACE(coa.account_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.company_policy_procedure LIKE @query_string) OR 
				((REPLACE(coa.company_policy_procedure, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(coa.summary_account = @summary_account) AND
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (ISNULL(@summary_account, '') = '') AND		-- (100)
				(ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code
	
		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (ISNULL(@summary_account, '') = '') AND		-- (101)
				(NOT ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.IterateListToTable (@accounting_category_id_list, ',') AS acidl_list ON acidl_list.var_str = acg.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@summary_account, '') = '') AND		-- (110)
				(ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				(coa.summary_account = @summary_account) AND
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (NOT ISNULL(@summary_account, '') = '') AND		-- (111)
				(NOT ISNULL(@accounting_category_id_list, '') = '')
		BEGIN

			SELECT
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
				lms.chart_of_accounts AS coa
			INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
			INNER JOIN lms.IterateListToTable (@accounting_category_id_list, ',') AS acidl_list ON acidl_list.var_str = acg.accounting_category_id
			LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
			LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
			WHERE
				(coa.summary_account = @summary_account) AND
				(coa.is_active_account = @is_active_account)
			ORDER BY
				coa.account_code

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a chart of accounts', 'Chart Of Accounts'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectChartOfAccounts TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDAccountChartOfAccounts" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDAccountChartOfAccounts')
   DROP PROCEDURE lms.SelectBySysIDAccountChartOfAccounts
GO

CREATE PROCEDURE lms.SelectBySysIDAccountChartOfAccounts

	@sysid_account varchar (50) = '',

	@system_user_id varchar (50) = ''	
		
AS

	IF (lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsDisbursementOfficerSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,
			coa.account_description AS account_description,
			coa.company_policy_procedure AS company_policy_procedure,
			coa.is_debit_side_increase AS is_debit_side_increase,
			coa.is_active_account AS is_active_account,

			--coa.accounting_category_id
			acg.accounting_category_id AS accounting_category_id,
			acg.category_description AS category_description,

			--coa.summary_account
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			summary_coa.account_description AS account_description_summary,
			summary_coa.company_policy_procedure AS company_policy_procedure_summary,
			summary_coa.is_debit_side_increase AS is_debit_side_increase_summary,
			summary_coa.is_active_account AS is_active_account_summary,

			--summary_coa.accounting_category_id
			summary_acg.accounting_category_id AS accounting_category_id_summary,
			summary_acg.category_description AS category_description_summary
		FROM
			lms.chart_of_accounts AS coa
		INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		LEFT JOIN lms.accounting_category AS summary_acg ON summary_acg.accounting_category_id = summary_coa.accounting_category_id
		WHERE
			(coa.sysid_account = @sysid_account)
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a chart of accounts', 'Chart Of Accounts'		
	END
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDAccountChartOfAccounts TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "GetCountChartOfAccounts" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'GetCountChartOfAccounts')
   DROP PROCEDURE lms.GetCountChartOfAccounts
GO

CREATE PROCEDURE lms.GetCountChartOfAccounts

	@system_user_id varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT COUNT(sysid_account) FROM lms.chart_of_accounts
				
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a chart of accounts', 'Chart Of Accounts'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.GetCountChartOfAccounts TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDChartOfAccount" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDChartOfAccount')
   DROP PROCEDURE lms.IsExistsSysIDChartOfAccount
GO

CREATE PROCEDURE lms.IsExistsSysIDChartOfAccount

	@sysid_account varchar (50) = '',

	@system_user_id varchar (50) = ''	
		
AS
	
	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT lms.IsExistsSysIDChartOfAcc(@sysid_account)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a chart of account', 'Chart Of Account'
	END	
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDChartOfAccount TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsValidCategoryBySummaryAccountChartOfAccount" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsValidCategoryBySummaryAccountChartOfAccount')
   DROP PROCEDURE lms.IsValidCategoryBySummaryAccountChartOfAccount
GO

CREATE PROCEDURE lms.IsValidCategoryBySummaryAccountChartOfAccount

	@accounting_category_id varchar (50) = '',
	@summary_account varchar (50) = '',

	@system_user_id varchar (50) = ''	
		
AS
	
	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT lms.IsValidCategoryBySummaryAccountChartOfAcc(@accounting_category_id, @summary_account)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a chart of account', 'Chart Of Account'
	END	
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsValidCategoryBySummaryAccountChartOfAccount TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsAccountCodeChartOfAccount" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsAccountCodeChartOfAccount')
   DROP PROCEDURE lms.IsExistsAccountCodeChartOfAccount
GO

CREATE PROCEDURE lms.IsExistsAccountCodeChartOfAccount

	@sysid_account varchar (50) = '',
	@account_code varchar (50) = '',
	@summary_account varchar (50) = '',

	@system_user_id varchar (50) = ''	
		
AS
	
	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT lms.IsExistsAccountCodeChartOfAcc(@sysid_account, @account_code, @summary_account)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a chart of account', 'Chart Of Account'
	END	
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsAccountCodeChartOfAccount TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDChartOfAcc" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDChartOfAcc') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDChartOfAcc
GO

CREATE FUNCTION lms.IsExistsSysIDChartOfAcc
(	
	@sysid_account varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_account FROM lms.chart_of_accounts WHERE sysid_account = @sysid_account)
	BEGIN
		SET @result = 1
	END	
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsValidCategoryBySummaryAccountChartOfAcc" function already exist
IF OBJECT_ID (N'lms.IsValidCategoryBySummaryAccountChartOfAcc') IS NOT NULL
   DROP FUNCTION lms.IsValidCategoryBySummaryAccountChartOfAcc
GO

CREATE FUNCTION lms.IsValidCategoryBySummaryAccountChartOfAcc
(	
	@accounting_category_id varchar (50) = '',
	@summary_account varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF (@summary_account IS NULL) OR
		(EXISTS (SELECT 
					sysid_account 
				FROM 
					lms.chart_of_accounts AS coa
				INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
				WHERE 
					(sysid_account = @summary_account) AND
					(acg.category_no <= (SELECT category_no FROM lms.accounting_category WHERE accounting_category_id = @accounting_category_id))))
	BEGIN
		SET @result = 1
	END	
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsExistsAccountCodeChartOfAcc" function already exist
IF OBJECT_ID (N'lms.IsExistsAccountCodeChartOfAcc') IS NOT NULL
   DROP FUNCTION lms.IsExistsAccountCodeChartOfAcc
GO

CREATE FUNCTION lms.IsExistsAccountCodeChartOfAcc
(	
	@sysid_account varchar (50) = '',
	@account_code varchar (50) = '',
	@summary_account varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_account FROM lms.chart_of_accounts WHERE NOT sysid_account = @sysid_account AND 
															((REPLACE(account_code, ' ', '')) LIKE REPLACE(@account_code, ' ', '')) AND
															((REPLACE(ISNULL(summary_account, ''), ' ', '')) LIKE REPLACE(ISNULL(@summary_account, ''), ' ', '')))
	BEGIN
		SET @result = 1
	END	
	
	RETURN @result
END
GO
------------------------------------------------------

-- ################################################END TABLE "chart_of_accounts" OBJECTS######################################################






---- ################################################TABLE "loan_charges_information" OBJECTS######################################################
---- verifies if the loan_charges_information table exists
--IF OBJECT_ID('lms.loan_charges_information', 'U') IS NOT NULL
--	DROP TABLE lms.loan_charges_information
--GO
--
--CREATE TABLE lms.loan_charges_information 			
--(
--	sysid_loancharges varchar (50) NOT NULL		
--		CONSTRAINT Loan_Charges_Information_SysID_LoanCharges_PK PRIMARY KEY (sysid_loancharges)
--		CONSTRAINT Loan_Charges_Information_SysID_LoanCharges_CK CHECK (sysid_loancharges LIKE 'SYSLCI%'),
--	loan_charges_description varchar (100) NOT NULL
--		CONSTRAINT Loan_Charges_Information_Loan_Charges_Description_UQ UNIQUE (loan_charges_description),
--
--	is_marked_deleted bit NOT NULL DEFAULT (0),
--
--	created_on datetime NOT NULL DEFAULT (GETDATE()),
--	created_by varchar (50) NOT NULL
--		CONSTRAINT Loan_Charges_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
--	
--	edited_on datetime NULL,
--	edited_by varchar (50) NULL	
--		CONSTRAINT Loan_Charges_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
--
--	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
--		CONSTRAINT Loan_Charges_Information_Unique_ID_UQ UNIQUE (unique_id)
--	
--) ON [PRIMARY]
--GO
--------------------------------------------------------------------
--
---- create an index of the loan_charges_information table 
--CREATE INDEX Loan_Charges_Information_SysID_LoanCharges_Index
--	ON lms.loan_charges_information (sysid_loancharges ASC)
--GO
--------------------------------------------------------------------
--
----verifies that the trigger "Loan_Charges_Information_Trigger_Insert" already exist
--IF OBJECT_ID ('lms.Loan_Charges_Information_Trigger_Insert','TR') IS NOT NULL
--   DROP TRIGGER lms.Loan_Charges_Information_Trigger_Insert
--GO
--
--CREATE TRIGGER lms.Loan_Charges_Information_Trigger_Insert
--	ON  lms.loan_charges_information
--	FOR INSERT
--	NOT FOR REPLICATION
--AS 
--
--	DECLARE @network_information varchar (MAX)
--	DECLARE @transaction_done varchar(MAX)
--
--	DECLARE @sysid_loancharges varchar (50)
--	DECLARE @loan_charges_description varchar (100)
--
--	DECLARE @created_by varchar (50)
--	
--	SELECT 
--		@sysid_loancharges = i.sysid_loancharges,
--		@loan_charges_description = i.loan_charges_description,
--		
--		@created_by = i.created_by
--	FROM INSERTED AS i
--
--	SET @transaction_done = 'CREATED a new loan charges information ' + 
--							'[Loan Charges System ID: ' + ISNULL(@sysid_loancharges, '') +
--							'][Charges Description: ' + ISNULL(@loan_charges_description, '') +
--							']'
--
--	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
--	BEGIN
--		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
--	END
--			
--	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done
--
--GO
-------------------------------------------------------------------
--
---- verifies that the trigger "Loan_Charges_Information_Trigger_Instead_Update" already exist
--IF OBJECT_ID ('lms.Loan_Charges_Information_Trigger_Instead_Update','TR') IS NOT NULL
--   DROP TRIGGER lms.Loan_Charges_Information_Trigger_Instead_Update
--GO
--
--CREATE TRIGGER lms.Loan_Charges_Information_Trigger_Instead_Update
--	ON  lms.loan_charges_information
--	INSTEAD OF UPDATE
--	NOT FOR REPLICATION
--AS 
--
--	DECLARE @network_information varchar(MAX)
--	DECLARE @transaction_done varchar(MAX)
--	
--	DECLARE @sysid_loancharges varchar (50)
--	DECLARE @loan_charges_description varchar (100)
--	DECLARE @is_marked_deleted bit
--
--	DECLARE @edited_by varchar(50)
--
--	DECLARE @loan_charges_description_b varchar (100)
--
--	DECLARE @has_update bit
--
--	DECLARE loan_charges_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
--		FOR SELECT i.sysid_loancharges, i.loan_charges_description, i.is_marked_deleted, i.edited_by
--				FROM INSERTED AS i
--
--	OPEN loan_charges_information_update_cursor
--
--	FETCH NEXT FROM loan_charges_information_update_cursor
--		INTO @sysid_loancharges, @loan_charges_description, @is_marked_deleted, @edited_by
--
--	WHILE @@FETCH_STATUS = 0
--	BEGIN	
--
--		IF (@is_marked_deleted = 0)
--		BEGIN	
--
--			SELECT 
--				@loan_charges_description_b = lci.loan_charges_description
--			FROM 
--				lms.loan_charges_information AS lci
--			WHERE
--				(lci.sysid_loancharges = @sysid_loancharges)
--
--			SET @transaction_done = ''
--			SET @has_update = 0
--
--			IF (NOT ISNULL(@loan_charges_description COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@loan_charges_description_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
--			BEGIN
--				SET @transaction_done = @transaction_done + '[Charges Description Before: ' + ISNULL(@loan_charges_description_b, '') + ']' +
--															'[Charges Description After: ' + ISNULL(@loan_charges_description, '') + ']'
--				SET @has_update = 1
--			END
--
--			IF (@has_update = 1)
--			BEGIN
--
--				UPDATE lms.loan_charges_information SET
--					loan_charges_description = @loan_charges_description,
--
--					edited_on = GETDATE(),
--					edited_by = @edited_by
--				WHERE
--					sysid_loancharges = @sysid_loancharges
--
--				SET @transaction_done = 'UPDATED a loan charges information ' + 
--										'[Loan Charges System ID: ' + ISNULL(@sysid_loancharges, '') +
--										']' + @transaction_done
--
--				IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
--				BEGIN
--					SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
--				END
--
--				EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done
--
--			END
--			ELSE IF NOT @edited_by IS NULL
--			BEGIN
--
--				--used for the delete trigger
--				UPDATE lms.loan_charges_information SET
--					edited_on = GETDATE(),
--					edited_by = @edited_by
--				WHERE
--					(sysid_loancharges = @sysid_loancharges)
--
--			END
--
--		END
--				
--		FETCH NEXT FROM loan_charges_information_update_cursor
--			INTO @sysid_loancharges, @loan_charges_description, @is_marked_deleted, @edited_by
--
--	END
--
--	CLOSE loan_charges_information_update_cursor
--	DEALLOCATE loan_charges_information_update_cursor
--
--GO
-----------------------------------------------------------------------
--
---- verifies that the trigger "Loan_Charges_Information_Trigger_Instead_Delete" already exist
--IF OBJECT_ID ('lms.Loan_Charges_Information_Trigger_Instead_Delete','TR') IS NOT NULL
--   DROP TRIGGER lms.Loan_Charges_Information_Trigger_Instead_Delete
--GO
--
--CREATE TRIGGER lms.Loan_Charges_Information_Trigger_Instead_Delete
--	ON  lms.loan_charges_information
--	INSTEAD OF DELETE
--	NOT FOR REPLICATION
--AS 
--
--	DECLARE @network_information varchar(MAX)
--	DECLARE @transaction_done varchar(MAX)
--	
--	DECLARE @sysid_loancharges varchar (50)
--	DECLARE @loan_charges_description varchar (100)
--	DECLARE @is_marked_deleted bit
--
--	DECLARE @deleted_by varchar(50)
--
--	DECLARE loan_charges_information_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
--		FOR SELECT d.sysid_loancharges, d.loan_charges_description, d.is_marked_deleted, d.edited_by
--				FROM DELETED AS d
--
--	OPEN loan_charges_information_delete_cursor
--
--	FETCH NEXT FROM loan_charges_information_delete_cursor
--		INTO @sysid_loancharges, @loan_charges_description, @is_marked_deleted, @deleted_by
--
--	WHILE @@FETCH_STATUS = 0
--	BEGIN		
--
--		IF (@is_marked_deleted = 0)
--		BEGIN
--
--			UPDATE lms.loan_charges_information SET 
--				is_marked_deleted = 1, 
--
--				edited_on = GETDATE(), 
--				edited_by = @deleted_by 
--			WHERE 
--				(sysid_loancharges = @sysid_loancharges)
--
--			SET @transaction_done = 'MARK AS DELETED a loan charges information ' + 
--									'[Loan Charges System ID: ' + ISNULL(@sysid_loancharges, '') +
--									'][Charges Description: ' + ISNULL(@loan_charges_description, '') +
--									']'
--
--			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
--			BEGIN
--				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
--			END
--					
--			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
--
--		END
--				
--		FETCH NEXT FROM loan_charges_information_delete_cursor
--			INTO @sysid_loancharges, @loan_charges_description, @is_marked_deleted, @deleted_by
--
--	END
--
--	CLOSE loan_charges_information_delete_cursor
--	DEALLOCATE loan_charges_information_delete_cursor
--	
--GO
---------------------------------------------------------------------------
--
---- verifies if the procedure "InsertLoanChargesInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertLoanChargesInformation')
--   DROP PROCEDURE lms.InsertLoanChargesInformation
--GO
--
--CREATE PROCEDURE lms.InsertLoanChargesInformation
--	
--	@sysid_loancharges varchar (50) = '',
--	@loan_charges_description varchar (100) = '',
--
--	@network_information varchar(MAX) = '',
--	@created_by varchar(50)
--	
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@created_by) = 1)) AND
--		(lms.IsExistsDescriptionLoanChargesInfo(@sysid_loancharges, @loan_charges_description) = 0)
--	BEGIN
--
--		EXECUTE lms.CreateTemporaryTable @created_by, @network_information
--
--		INSERT INTO lms.loan_charges_information
--		(
--			sysid_loancharges,
--			loan_charges_description,
--
--			created_by
--		)
--		VALUES
--		(
--			@sysid_loancharges,
--			@loan_charges_description,
--
--			@created_by
--		)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Insert a loan charges information', 'Loan Charges Information'
--	END
--	
--GO
---------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.InsertLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "UpdateLoanChargesInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateLoanChargesInformation')
--   DROP PROCEDURE lms.UpdateLoanChargesInformation
--GO
--
--CREATE PROCEDURE lms.UpdateLoanChargesInformation
--	
--	@sysid_loancharges varchar (50) = '',
--	@loan_charges_description varchar (100) = '',
--
--	@network_information varchar(MAX) = '',
--	@edited_by varchar(50)
--	
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@edited_by) = 1)) AND
--		(lms.IsExistsDescriptionLoanChargesInfo(@sysid_loancharges, @loan_charges_description) = 0)
--	BEGIN
--
--		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information
--
--		UPDATE lms.loan_charges_information SET
--			loan_charges_description = @loan_charges_description,
--
--			edited_by = @edited_by
--		WHERE
--			(sysid_loancharges = @sysid_loancharges)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Update a loan charges information', 'Loan Charges Information'
--	END
--	
--GO
---------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.UpdateLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "DeleteLoanChargesInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteLoanChargesInformation')
--   DROP PROCEDURE lms.DeleteLoanChargesInformation
--GO
--
--CREATE PROCEDURE lms.DeleteLoanChargesInformation
--	
--	@sysid_loancharges varchar (50) = '',
--
--	@network_information varchar(MAX) = '',
--	@deleted_by varchar(50)
--	
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@deleted_by) = 1))
--	BEGIN
--
--		IF EXISTS (SELECT sysid_loancharges FROM lms.loan_charges_information WHERE sysid_loancharges = @sysid_loancharges)
--		BEGIN
--
--			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information
--
--			UPDATE lms.loan_charges_information SET
--				edited_by = @deleted_by
--			WHERE
--				(sysid_loancharges = @sysid_loancharges)
--
--			DELETE FROM lms.loan_charges_information WHERE (sysid_loancharges = @sysid_loancharges)
--
--		END
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Delete a loan charges information', 'Loan Charges Information'
--	END
--	
--GO
---------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.DeleteLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "SelectLoanChargesInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectLoanChargesInformation')
--   DROP PROCEDURE lms.SelectLoanChargesInformation
--GO
--
--CREATE PROCEDURE lms.SelectLoanChargesInformation
--
--	@query_string varchar (50) = '',
--	@include_marked_deleted bit = 0,
--
--	@system_user_id varchar (50) = ''
--		
--AS
--
--	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
--	BEGIN
--
--		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'
--
--		IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(00)
--		BEGIN
--
--			SELECT
--				lci.sysid_loancharges AS sysid_loancharges,
--				lci.loan_charges_description AS loan_charges_description,
--				lci.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_charges_information AS lci
--			WHERE
--				((lci.loan_charges_description LIKE @query_string) OR 
--				((REPLACE(lci.loan_charges_description, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
--				(lci.is_marked_deleted = 0)
--
--		END
--		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(01)
--		BEGIN
--
--			SELECT
--				lci.sysid_loancharges AS sysid_loancharges,
--				lci.loan_charges_description AS loan_charges_description,
--				lci.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_charges_information AS lci
--			WHERE
--				((lci.loan_charges_description LIKE @query_string) OR 
--				((REPLACE(lci.loan_charges_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')))
--
--		END
--		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(10)
--		BEGIN
--
--			SELECT
--				lci.sysid_loancharges AS sysid_loancharges,
--				lci.loan_charges_description AS loan_charges_description,
--				lci.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_charges_information AS lci
--			WHERE
--				(lci.is_marked_deleted = 0)
--	
--		END
--		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(11)
--		BEGIN
--	
--			SELECT
--				lci.sysid_loancharges AS sysid_loancharges,
--				lci.loan_charges_description AS loan_charges_description,
--				lci.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_charges_information AS lci
--
--		END	
--		
--	END
--	ELSE
--	BEGIN				
--		
--		EXECUTE lms.ShowErrorMsg 'Query a loan charges information', 'Loan Charges Information'
--		
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.SelectLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "SelectCountLoanChargesInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountLoanChargesInformation')
--   DROP PROCEDURE lms.SelectCountLoanChargesInformation
--GO
--
--CREATE PROCEDURE lms.SelectCountLoanChargesInformation
--
--	@system_user_id varchar (50) = ''
--
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
--	BEGIN
--		
--		SELECT COUNT(lci.sysid_loancharges) FROM lms.loan_charges_information AS lci
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Query a loan charges information', 'Loan Charges Information'
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.SelectCountLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "IsExistsSysIDLoanChargesInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDLoanChargesInformation')
--   DROP PROCEDURE lms.IsExistsSysIDLoanChargesInformation
--GO
--
--CREATE PROCEDURE lms.IsExistsSysIDLoanChargesInformation
--
--	@sysid_loancharges varchar (50) = '',
--	@system_user_id varchar (50) = ''
--
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
--	BEGIN
--		
--		SELECT lms.IsExistsSysIDLoanChargesInfo(@sysid_loancharges)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Query a loan charges information', 'Loan Charges Information'
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.IsExistsSysIDLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "IsExistsDescriptionLoanChargesInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsDescriptionLoanChargesInformation')
--   DROP PROCEDURE lms.IsExistsDescriptionLoanChargesInformation
--GO
--
--CREATE PROCEDURE lms.IsExistsDescriptionLoanChargesInformation
--
--	@sysid_loancharges varchar (50) = '',
--	@loan_charges_description varchar (100) = '',
--
--	@system_user_id varchar (50) = ''
--
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
--	BEGIN
--		
--		SELECT lms.IsExistsDescriptionLoanChargesInfo(@sysid_loancharges, @loan_charges_description)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Query a loan charges information', 'Loan Charges Information'
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.IsExistsDescriptionLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the "IsExistsSysIDLoanChargesInfo" function already exist
--IF OBJECT_ID (N'lms.IsExistsSysIDLoanChargesInfo') IS NOT NULL
--   DROP FUNCTION lms.IsExistsSysIDLoanChargesInfo
--GO
--
--CREATE FUNCTION lms.IsExistsSysIDLoanChargesInfo
--(	
--	@sysid_loancharges varchar (50) = ''
--)
--RETURNS bit
--AS
--BEGIN
--	
--	DECLARE @result bit
--
--	SET @result = 0
--	
--	IF EXISTS (SELECT sysid_loancharges FROM lms.loan_charges_information WHERE sysid_loancharges = @sysid_loancharges)
--	BEGIN
--		SET @result = 1
--	END
--	
--	RETURN @result
--END
--GO
--------------------------------------------------------
--
---- verifies if the "IsExistsDescriptionLoanChargesInfo" function already exist
--IF OBJECT_ID (N'lms.IsExistsDescriptionLoanChargesInfo') IS NOT NULL
--   DROP FUNCTION lms.IsExistsDescriptionLoanChargesInfo
--GO
--
--CREATE FUNCTION lms.IsExistsDescriptionLoanChargesInfo
--(	
--	@sysid_loancharges varchar (50) = '',
--	@loan_charges_description varchar (100) = ''
--)
--RETURNS bit
--AS
--BEGIN
--	
--	DECLARE @result bit
--
--	SET @result = 0
--	
--	IF EXISTS (SELECT sysid_loancharges FROM lms.loan_charges_information WHERE (NOT sysid_loancharges = @sysid_loancharges) AND						
--						(REPLACE(loan_charges_description, ' ', '') LIKE REPLACE(@loan_charges_description, ' ', '')))
--								
--	BEGIN
--		SET @result = 1
--	END
--	
--	RETURN @result
--END
--GO
--------------------------------------------------------
--
---- #############################################END TABLE "loan_charges_information" OBJECTS######################################################






-- ################################################TABLE "regular_loan_charges" OBJECTS######################################################
-- verifies if the regular_loan_charges table exists
IF OBJECT_ID('lms.regular_loan_charges', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_charges
GO

CREATE TABLE lms.regular_loan_charges 			
(
	regular_charges_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Regular_Loan_Charges_Regular_Charges_ID_PK PRIMARY KEY (regular_charges_id),
	sysid_regular varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Charges_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION,
	charge_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	charge_description varchar (150) NULL,
	sysid_account varchar (50) NULL
		CONSTRAINT Regular_Loan_Charges_SysID_Account_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,
	sysid_regular_forwarded varchar (50) NULL
		CONSTRAINT Regular_Loan_Charges_SysID_Regular_Forwarded_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Charges_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_Charges_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Charges_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the regular_loan_charges table 
CREATE INDEX Regular_Loan_Charges_Regular_Charges_ID_Index
	ON lms.regular_loan_charges (regular_charges_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Charges_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_Charges_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Charges_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_Charges_Trigger_Insert
	ON  lms.regular_loan_charges
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @regular_charges_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @charge_amount decimal (15, 2)
	DECLARE @charge_description varchar (150)
	DECLARE @sysid_account varchar (50)
	DECLARE @sysid_regular_forwarded varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@regular_charges_id = i.regular_charges_id,
		@sysid_regular = i.sysid_regular,
		@charge_amount = i.charge_amount,
		@charge_description = i.charge_description,
		@sysid_account = i.sysid_account,
		@sysid_regular_forwarded = i.sysid_regular_forwarded,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new regular loan charges ' + 
							'[Charge ID: ' + ISNULL(CONVERT(varchar, @regular_charges_id), '') +
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
							'][Charge Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @charge_amount), 1), '0.00') +
							'][Charges Description: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account)), ISNULL(@charge_description, '')) +
							'][Balance Forwarded From Account No.: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular_forwarded)), '') +	
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Charges_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_Charges_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Charges_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_Charges_Trigger_Instead_Update
	ON  lms.regular_loan_charges
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @regular_charges_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @charge_amount decimal (15, 2)
	DECLARE @charge_description varchar (150)
	DECLARE @sysid_account varchar (50)
	DECLARE @sysid_regular_forwarded varchar (50)

	DECLARE @edited_by varchar(50)

	DECLARE @charge_amount_b decimal (15, 2)
	DECLARE @charge_description_b varchar (150)
	DECLARE @sysid_account_b varchar (50)
	DECLARE @sysid_regular_forwarded_b varchar (50)

	DECLARE @has_update bit

	DECLARE regular_loan_charges_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.regular_charges_id, i.sysid_regular, i.charge_amount, i.charge_description, i.sysid_account, i.sysid_regular_forwarded, i.edited_by
				FROM INSERTED AS i

	OPEN regular_loan_charges_update_cursor

	FETCH NEXT FROM regular_loan_charges_update_cursor
		INTO @regular_charges_id, @sysid_regular, @charge_amount, @charge_description, @sysid_account, @sysid_regular_forwarded, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		SELECT 
			@charge_amount_b = rlg.charge_amount,
			@charge_description_b = rlg.charge_description,
			@sysid_account_b = rlg.sysid_account,
			@sysid_regular_forwarded_b = rlg.sysid_regular_forwarded
		FROM 
			lms.regular_loan_charges AS rlg
		WHERE
			(rlg.regular_charges_id = @regular_charges_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @charge_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @charge_amount_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Charge Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @charge_amount_b), 1), '0.00') + ']' +
														'[Charge Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @charge_amount), 1), '0.00') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(@charge_description COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@charge_description_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')) OR
			(NOT ISNULL(@sysid_account COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Charges Description Before: ' + ISNULL((SELECT
																										coa.account_code + ' - ' + coa.account_name
																									FROM
																										lms.chart_of_accounts AS coa
																									INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																									WHERE
																										(coa.sysid_account = @sysid_account_b)), ISNULL(@charge_description_b, '')) + ']' +
														'[Charges Description After: ' + ISNULL((SELECT
																										coa.account_code + ' - ' + coa.account_name
																									FROM
																										lms.chart_of_accounts AS coa
																									INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																									WHERE
																										(coa.sysid_account = @sysid_account)), ISNULL(@charge_description, '')) + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Charges Description: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account)), ISNULL(@charge_description, '')) + ']'
		END
		
		IF (NOT ISNULL(@sysid_regular_forwarded COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_regular_forwarded_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Balance Forwarded From Account No. Before: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular_forwarded_b)), '') + ']' +
														'[Balance Forwarded From Account No. After: ' + ISNULL((SELECT
																	rli.account_no
																FROM
																	lms.regular_loan_information AS rli
																WHERE
																	(rli.sysid_regular = @sysid_regular_forwarded)), '') + ']'
			SET @has_update = 1
		END

		
		IF (@has_update = 1)
		BEGIN

			UPDATE lms.regular_loan_charges SET
				charge_amount = @charge_amount,
				charge_description = @charge_description,
				sysid_account = @sysid_account,
				sysid_regular_forwarded = @sysid_regular_forwarded,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				regular_charges_id = @regular_charges_id

			SET @transaction_done = 'UPDATED a regular loan charges ' + 
									'[Charge ID: ' + ISNULL(CONVERT(varchar, @regular_charges_id), '') +
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
			UPDATE lms.regular_loan_charges SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(regular_charges_id = @regular_charges_id)

		END
				
		FETCH NEXT FROM regular_loan_charges_update_cursor
			INTO @regular_charges_id, @sysid_regular, @charge_amount, @charge_description, @sysid_account, @sysid_regular_forwarded, @edited_by

	END

	CLOSE regular_loan_charges_update_cursor
	DEALLOCATE regular_loan_charges_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Charges_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Charges_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Charges_Trigger_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Charges_Trigger_Delete
	ON  lms.regular_loan_charges
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @regular_charges_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @charge_amount decimal (15, 2)
	DECLARE @charge_description varchar (150)
	DECLARE @sysid_account varchar (50)
	DECLARE @sysid_regular_forwarded varchar (50)

	DECLARE @deleted_by varchar(50)

	DECLARE regular_loan_charges_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.regular_charges_id, d.sysid_regular, d.charge_amount, d.charge_description, d.sysid_account, d.sysid_regular_forwarded, d.edited_by
				FROM DELETED AS d

	OPEN regular_loan_charges_delete_cursor

	FETCH NEXT FROM regular_loan_charges_delete_cursor
		INTO @regular_charges_id, @sysid_regular, @charge_amount, @charge_description, @sysid_account, @sysid_regular_forwarded, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		SET @transaction_done = 'DELETED a regular loan charges ' + 
								'[Charge ID: ' + ISNULL(CONVERT(varchar, @regular_charges_id), '') +
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
								'][Charge Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @charge_amount), 1), '0.00') +
								'][Charges Description: ' + ISNULL((SELECT
																		coa.account_code + ' - ' + coa.account_name
																	FROM
																		lms.chart_of_accounts AS coa
																	INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																	WHERE
																		(coa.sysid_account = @sysid_account)), ISNULL(@charge_description, '')) +
								'][Balance Forwarded From Account No.: ' + ISNULL((SELECT
																		rli.account_no
																	FROM
																		lms.regular_loan_information AS rli
																	WHERE
																		(rli.sysid_regular = @sysid_regular_forwarded)), '') +		
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
				
		FETCH NEXT FROM regular_loan_charges_delete_cursor
			INTO @regular_charges_id, @sysid_regular, @charge_amount, @charge_description, @sysid_account, @sysid_regular_forwarded, @deleted_by

	END

	CLOSE regular_loan_charges_delete_cursor
	DEALLOCATE regular_loan_charges_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanCharges" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanCharges')
   DROP PROCEDURE lms.InsertRegularLoanCharges
GO

CREATE PROCEDURE lms.InsertRegularLoanCharges
	
	@sysid_regular varchar (50) = '',
	@charge_amount decimal (15, 2) = 0.00,
	@charge_description varchar (150) = '',
	@sysid_account varchar (50) = '',
	@sysid_regular_forwarded varchar (50) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsChargeRegularLoanChar(DEFAULT, @sysid_regular, @charge_description, @sysid_account) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_charges
		(
			sysid_regular,
			charge_amount,
			charge_description,
			sysid_account,
			sysid_regular_forwarded,

			created_by
		)
		VALUES
		(
			@sysid_regular,
			@charge_amount,
			@charge_description,
			@sysid_account,
			@sysid_regular_forwarded,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a regular loan charges', 'Regular Loan Charges'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanCharges TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateRegularLoanCharges" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateRegularLoanCharges')
   DROP PROCEDURE lms.UpdateRegularLoanCharges
GO

CREATE PROCEDURE lms.UpdateRegularLoanCharges
	
	@regular_charges_id bigint = 0,
	@charge_amount decimal (15, 2) = 0.00,
	@charge_description varchar (150) = '',
	@sysid_account varchar (50) = '',
	@sysid_regular_forwarded varchar (50) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsChargeRegularLoanChar(@regular_charges_id, 
											(SELECT sysid_regular FROM lms.regular_loan_charges WHERE regular_charges_id = @regular_charges_id), 
											@charge_description,
											@sysid_account) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.regular_loan_charges SET
			charge_amount = @charge_amount,
			charge_description = @charge_description,
			sysid_account = @sysid_account,
			sysid_regular_forwarded = @sysid_regular_forwarded,

			edited_by = @edited_by
		WHERE
			(regular_charges_id = @regular_charges_id)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a regular loan charges', 'Regular Loan Charges'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateRegularLoanCharges TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanCharges" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanCharges')
   DROP PROCEDURE lms.DeleteRegularLoanCharges
GO

CREATE PROCEDURE lms.DeleteRegularLoanCharges
	
	@regular_charges_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT regular_charges_id FROM lms.regular_loan_charges WHERE regular_charges_id = @regular_charges_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_charges SET
				edited_by = @deleted_by
			WHERE
				(regular_charges_id = @regular_charges_id)

			DELETE FROM lms.regular_loan_charges WHERE (regular_charges_id = @regular_charges_id)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan charges', 'Regular Loan Charges'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanCharges TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularListRegularLoanCharges" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularListRegularLoanCharges')
   DROP PROCEDURE lms.SelectBySysIDRegularListRegularLoanCharges
GO

CREATE PROCEDURE lms.SelectBySysIDRegularListRegularLoanCharges

	@sysid_regular_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rlg.regular_charges_id AS regular_charges_id,
			rlg.sysid_regular AS sysid_regular,
			rlg.charge_amount AS charge_amount,
			rlg.charge_description AS charge_description,
			rlg.sysid_account AS sysid_account,
			rlg.sysid_regular_forwarded AS sysid_regular_forwarded
		FROM
			lms.regular_loan_charges AS rlg
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srgl_list ON srgl_list.var_str = rlg.sysid_regular
		ORDER BY
			rlg.sysid_regular ASC, rlg.charge_description ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan charges', 'Regular Loan Charges'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularListRegularLoanCharges TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsChargeRegularLoanCharges" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsChargeRegularLoanCharges')
   DROP PROCEDURE lms.IsExistsChargeRegularLoanCharges
GO

CREATE PROCEDURE lms.IsExistsChargeRegularLoanCharges

	@regular_charges_id bigint = 0,
	@sysid_regular varchar (50) = '',
	@charge_description varchar (150) = '',
	@sysid_account varchar (50) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsChargeRegularLoanChar(@regular_charges_id, @sysid_regular, @charge_description, @sysid_account)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan charges', 'Regular Loan Charges'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsChargeRegularLoanCharges TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsChargeRegularLoanChar" function already exist
IF OBJECT_ID (N'lms.IsExistsChargeRegularLoanChar') IS NOT NULL
   DROP FUNCTION lms.IsExistsChargeRegularLoanChar
GO

CREATE FUNCTION lms.IsExistsChargeRegularLoanChar
(	
	@regular_charges_id bigint = 0,
	@sysid_regular varchar (50) = '',
	@charge_description varchar (150) = '',
	@sysid_account varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT 
					regular_charges_id 
				FROM 
					lms.regular_loan_charges
				WHERE 
					(NOT regular_charges_id = @regular_charges_id) AND
					(sysid_regular = @sysid_regular) AND
					((sysid_account = @sysid_account) OR
					(REPLACE(charge_description, ' ', '') LIKE REPLACE(@charge_description, ' ', ''))))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------
-- ################################################TABLE "regular_loan_charges" OBJECTS######################################################





---- ################################################TABLE "loan_additions_information" OBJECTS######################################################
---- verifies if the loan_additions_information table exists
--IF OBJECT_ID('lms.loan_additions_information', 'U') IS NOT NULL
--	DROP TABLE lms.loan_additions_information
--GO
--
--CREATE TABLE lms.loan_additions_information 			
--(
--	sysid_loanadditions varchar (50) NOT NULL		
--		CONSTRAINT Loan_Additions_Information_SysID_LoanAdditions_PK PRIMARY KEY (sysid_loanadditions)
--		CONSTRAINT Loan_Additions_Information_SysID_LoanAdditions_CK CHECK (sysid_loanadditions LIKE 'SYSLAI%'),
--	loan_additions_description varchar (100) NOT NULL
--		CONSTRAINT Loan_Additions_Information_Loan_Additions_Description_UQ UNIQUE (loan_additions_description),
--
--	is_marked_deleted bit NOT NULL DEFAULT (0),
--
--	created_on datetime NOT NULL DEFAULT (GETDATE()),
--	created_by varchar (50) NOT NULL
--		CONSTRAINT Loan_Additions_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
--	
--	edited_on datetime NULL,
--	edited_by varchar (50) NULL	
--		CONSTRAINT Loan_Additions_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
--
--	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
--		CONSTRAINT Loan_Additions_Information_Unique_ID_UQ UNIQUE (unique_id)
--	
--) ON [PRIMARY]
--GO
--------------------------------------------------------------------
--
---- create an index of the loan_additions_information table 
--CREATE INDEX Loan_Additions_Information_SysID_LoanAdditions_Index
--	ON lms.loan_additions_information (sysid_loanadditions ASC)
--GO
--------------------------------------------------------------------
--
----verifies that the trigger "Loan_Additions_Information_Trigger_Insert" already exist
--IF OBJECT_ID ('lms.Loan_Additions_Information_Trigger_Insert','TR') IS NOT NULL
--   DROP TRIGGER lms.Loan_Additions_Information_Trigger_Insert
--GO
--
--CREATE TRIGGER lms.Loan_Additions_Information_Trigger_Insert
--	ON  lms.loan_additions_information
--	FOR INSERT
--	NOT FOR REPLICATION
--AS 
--
--	DECLARE @network_information varchar (MAX)
--	DECLARE @transaction_done varchar(MAX)
--
--	DECLARE @sysid_loanadditions varchar (50)
--	DECLARE @loan_additions_description varchar (100)
--
--	DECLARE @created_by varchar (50)
--	
--	SELECT 
--		@sysid_loanadditions = i.sysid_loanadditions,
--		@loan_additions_description = i.loan_additions_description,
--		
--		@created_by = i.created_by
--	FROM INSERTED AS i
--
--	SET @transaction_done = 'CREATED a new loan additions information ' + 
--							'[Loan Additions System ID: ' + ISNULL(@sysid_loanadditions, '') +
--							'][Additions Description: ' + ISNULL(@loan_additions_description, '') +
--							']'
--
--	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
--	BEGIN
--		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
--	END
--			
--	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done
--
--GO
-------------------------------------------------------------------
--
---- verifies that the trigger "Loan_Additions_Information_Trigger_Instead_Update" already exist
--IF OBJECT_ID ('lms.Loan_Additions_Information_Trigger_Instead_Update','TR') IS NOT NULL
--   DROP TRIGGER lms.Loan_Additions_Information_Trigger_Instead_Update
--GO
--
--CREATE TRIGGER lms.Loan_Additions_Information_Trigger_Instead_Update
--	ON  lms.loan_additions_information
--	INSTEAD OF UPDATE
--	NOT FOR REPLICATION
--AS 
--
--	DECLARE @network_information varchar(MAX)
--	DECLARE @transaction_done varchar(MAX)
--	
--	DECLARE @sysid_loanadditions varchar (50)
--	DECLARE @loan_additions_description varchar (100)
--	DECLARE @is_marked_deleted bit
--
--	DECLARE @edited_by varchar(50)
--
--	DECLARE @loan_additions_description_b varchar (100)
--
--	DECLARE @has_update bit
--
--	DECLARE loan_additions_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
--		FOR SELECT i.sysid_loanadditions, i.loan_additions_description, i.is_marked_deleted, i.edited_by
--				FROM INSERTED AS i
--
--	OPEN loan_additions_information_update_cursor
--
--	FETCH NEXT FROM loan_additions_information_update_cursor
--		INTO @sysid_loanadditions, @loan_additions_description, @is_marked_deleted, @edited_by
--
--	WHILE @@FETCH_STATUS = 0
--	BEGIN	
--
--		IF (@is_marked_deleted = 0)
--		BEGIN	
--
--			SELECT 
--				@loan_additions_description_b = lai.loan_additions_description
--			FROM 
--				lms.loan_additions_information AS lai
--			WHERE
--				(lai.sysid_loanadditions = @sysid_loanadditions)
--
--			SET @transaction_done = ''
--			SET @has_update = 0
--
--			IF (NOT ISNULL(@loan_additions_description COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@loan_additions_description_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
--			BEGIN
--				SET @transaction_done = @transaction_done + '[Additions Description Before: ' + ISNULL(@loan_additions_description_b, '') + ']' +
--															'[Additions Description After: ' + ISNULL(@loan_additions_description, '') + ']'
--				SET @has_update = 1
--			END
--
--			IF (@has_update = 1)
--			BEGIN
--
--				UPDATE lms.loan_additions_information SET
--					loan_additions_description = @loan_additions_description,
--
--					edited_on = GETDATE(),
--					edited_by = @edited_by
--				WHERE
--					sysid_loanadditions = @sysid_loanadditions
--
--				SET @transaction_done = 'UPDATED a loan additions information ' + 
--										'[Loan Additions System ID: ' + ISNULL(@sysid_loanadditions, '') +
--										']' + @transaction_done
--
--				IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
--				BEGIN
--					SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
--				END
--
--				EXECUTE lms.InsertTransactionLog @edited_by, @network_information, @transaction_done
--
--			END
--			ELSE IF NOT @edited_by IS NULL
--			BEGIN
--
--				--used for the delete trigger
--				UPDATE lms.loan_additions_information SET
--					edited_on = GETDATE(),
--					edited_by = @edited_by
--				WHERE
--					(sysid_loanadditions = @sysid_loanadditions)
--
--			END
--
--		END
--				
--		FETCH NEXT FROM loan_additions_information_update_cursor
--			INTO @sysid_loanadditions, @loan_additions_description, @is_marked_deleted, @edited_by
--
--	END
--
--	CLOSE loan_additions_information_update_cursor
--	DEALLOCATE loan_additions_information_update_cursor
--
--GO
-----------------------------------------------------------------------
--
---- verifies that the trigger "Loan_Additions_Information_Trigger_Instead_Delete" already exist
--IF OBJECT_ID ('lms.Loan_Additions_Information_Trigger_Instead_Delete','TR') IS NOT NULL
--   DROP TRIGGER lms.Loan_Additions_Information_Trigger_Instead_Delete
--GO
--
--CREATE TRIGGER lms.Loan_Additions_Information_Trigger_Instead_Delete
--	ON  lms.loan_additions_information
--	INSTEAD OF DELETE
--	NOT FOR REPLICATION
--AS 
--
--	DECLARE @network_information varchar(MAX)
--	DECLARE @transaction_done varchar(MAX)
--	
--	DECLARE @sysid_loanadditions varchar (50)
--	DECLARE @loan_additions_description varchar (100)
--	DECLARE @is_marked_deleted bit
--
--	DECLARE @deleted_by varchar(50)
--
--	DECLARE loan_additions_information_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
--		FOR SELECT d.sysid_loanadditions, d.loan_additions_description, d.is_marked_deleted, d.edited_by
--				FROM DELETED AS d
--
--	OPEN loan_additions_information_delete_cursor
--
--	FETCH NEXT FROM loan_additions_information_delete_cursor
--		INTO @sysid_loanadditions, @loan_additions_description, @is_marked_deleted, @deleted_by
--
--	WHILE @@FETCH_STATUS = 0
--	BEGIN		
--
--		IF (@is_marked_deleted = 0)
--		BEGIN
--
--			UPDATE lms.loan_additions_information SET 
--				is_marked_deleted = 1, 
--
--				edited_on = GETDATE(), 
--				edited_by = @deleted_by 
--			WHERE 
--				(sysid_loanadditions = @sysid_loanadditions)
--
--			SET @transaction_done = 'MARK AS DELETED a loan additions information ' + 
--									'[Loan Additions System ID: ' + ISNULL(@sysid_loanadditions, '') +
--									'][Additions Description: ' + ISNULL(@loan_additions_description, '') +
--									']'
--
--			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
--			BEGIN
--				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
--			END
--					
--			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
--
--		END
--				
--		FETCH NEXT FROM loan_additions_information_delete_cursor
--			INTO @sysid_loanadditions, @loan_additions_description, @is_marked_deleted, @deleted_by
--
--	END
--
--	CLOSE loan_additions_information_delete_cursor
--	DEALLOCATE loan_additions_information_delete_cursor
--	
--GO
---------------------------------------------------------------------------
--
---- verifies if the procedure "InsertLoanAdditionsInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertLoanAdditionsInformation')
--   DROP PROCEDURE lms.InsertLoanAdditionsInformation
--GO
--
--CREATE PROCEDURE lms.InsertLoanAdditionsInformation
--	
--	@sysid_loanadditions varchar (50) = '',
--	@loan_additions_description varchar (100) = '',
--
--	@network_information varchar(MAX) = '',
--	@created_by varchar(50)
--	
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@created_by) = 1)) AND
--		(lms.IsExistsDescriptionLoanAdditionsInfo(@sysid_loanadditions, @loan_additions_description) = 0)
--	BEGIN
--
--		EXECUTE lms.CreateTemporaryTable @created_by, @network_information
--
--		INSERT INTO lms.loan_additions_information
--		(
--			sysid_loanadditions,
--			loan_additions_description,
--
--			created_by
--		)
--		VALUES
--		(
--			@sysid_loanadditions,
--			@loan_additions_description,
--
--			@created_by
--		)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Insert a loan additions information', 'Loan Additions Information'
--	END
--	
--GO
---------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.InsertLoanAdditionsInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "UpdateLoanAdditionsInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateLoanAdditionsInformation')
--   DROP PROCEDURE lms.UpdateLoanAdditionsInformation
--GO
--
--CREATE PROCEDURE lms.UpdateLoanAdditionsInformation
--	
--	@sysid_loanadditions varchar (50) = '',
--	@loan_additions_description varchar (100) = '',
--
--	@network_information varchar(MAX) = '',
--	@edited_by varchar(50)
--	
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@edited_by) = 1)) AND
--		(lms.IsExistsDescriptionLoanAdditionsInfo(@sysid_loanadditions, @loan_additions_description) = 0)
--	BEGIN
--
--		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information
--
--		UPDATE lms.loan_additions_information SET
--			loan_additions_description = @loan_additions_description,
--
--			edited_by = @edited_by
--		WHERE
--			(sysid_loanadditions = @sysid_loanadditions)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Update a loan additions information', 'Loan Additions Information'
--	END
--	
--GO
---------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.UpdateLoanAdditionsInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "DeleteLoanAdditionsInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteLoanAdditionsInformation')
--   DROP PROCEDURE lms.DeleteLoanAdditionsInformation
--GO
--
--CREATE PROCEDURE lms.DeleteLoanAdditionsInformation
--	
--	@sysid_loanadditions varchar (50) = '',
--
--	@network_information varchar(MAX) = '',
--	@deleted_by varchar(50)
--	
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@deleted_by) = 1))
--	BEGIN
--
--		IF EXISTS (SELECT sysid_loanadditions FROM lms.loan_additions_information WHERE sysid_loanadditions = @sysid_loanadditions)
--		BEGIN
--
--			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information
--
--			UPDATE lms.loan_additions_information SET
--				edited_by = @deleted_by
--			WHERE
--				(sysid_loanadditions = @sysid_loanadditions)
--
--			DELETE FROM lms.loan_additions_information WHERE (sysid_loanadditions = @sysid_loanadditions)
--
--		END
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Delete a loan additions information', 'Loan Additions Information'
--	END
--	
--GO
---------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.DeleteLoanAdditionsInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "SelectLoanAdditionsInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectLoanAdditionsInformation')
--   DROP PROCEDURE lms.SelectLoanAdditionsInformation
--GO
--
--CREATE PROCEDURE lms.SelectLoanAdditionsInformation
--
--	@query_string varchar (50) = '',
--	@include_marked_deleted bit = 0,
--
--	@system_user_id varchar (50) = ''
--		
--AS
--
--	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
--	BEGIN
--
--		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'
--
--		IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(00)
--		BEGIN
--
--			SELECT
--				lai.sysid_loanadditions AS sysid_loanadditions,
--				lai.loan_additions_description AS loan_additions_description,
--				lai.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_additions_information AS lai
--			WHERE
--				((lai.loan_additions_description LIKE @query_string) OR 
--				((REPLACE(lai.loan_additions_description, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
--				(lai.is_marked_deleted = 0)
--
--		END
--		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(01)
--		BEGIN
--
--			SELECT
--				lai.sysid_loanadditions AS sysid_loanadditions,
--				lai.loan_additions_description AS loan_additions_description,
--				lai.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_additions_information AS lai
--			WHERE
--				((lai.loan_additions_description LIKE @query_string) OR 
--				((REPLACE(lai.loan_additions_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')))
--
--		END
--		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(10)
--		BEGIN
--
--			SELECT
--				lai.sysid_loanadditions AS sysid_loanadditions,
--				lai.loan_additions_description AS loan_additions_description,
--				lai.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_additions_information AS lai
--			WHERE
--				(lai.is_marked_deleted = 0)
--	
--		END
--		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(11)
--		BEGIN
--	
--			SELECT
--				lai.sysid_loanadditions AS sysid_loanadditions,
--				lai.loan_additions_description AS loan_additions_description,
--				lai.is_marked_deleted AS is_marked_deleted
--			FROM
--				lms.loan_additions_information AS lai
--
--		END	
--		
--	END
--	ELSE
--	BEGIN				
--		
--		EXECUTE lms.ShowErrorMsg 'Query a loan charges information', 'Loan Charges Information'
--		
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.SelectLoanChargesInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "SelectCountLoanAdditionsInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountLoanAdditionsInformation')
--   DROP PROCEDURE lms.SelectCountLoanAdditionsInformation
--GO
--
--CREATE PROCEDURE lms.SelectCountLoanAdditionsInformation
--
--	@system_user_id varchar (50) = ''
--
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
--	BEGIN
--		
--		SELECT COUNT(lai.sysid_loanadditions) FROM lms.loan_additions_information AS lai
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Query a loan additions information', 'Loan Additions Information'
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.SelectCountLoanAdditionsInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "IsExistsSysIDLoanAdditionsInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDLoanAdditionsInformation')
--   DROP PROCEDURE lms.IsExistsSysIDLoanAdditionsInformation
--GO
--
--CREATE PROCEDURE lms.IsExistsSysIDLoanAdditionsInformation
--
--	@sysid_loanadditions varchar (50) = '',
--	@system_user_id varchar (50) = ''
--
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
--	BEGIN
--		
--		SELECT lms.IsExistsSysIDLoanAdditionsInfo(@sysid_loanadditions)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Query a loan additions information', 'Loan Additions Information'
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.IsExistsSysIDLoanAdditionsInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the procedure "IsExistsDescriptionLoanAdditionsInformation" exist
--IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsDescriptionLoanAdditionsInformation')
--   DROP PROCEDURE lms.IsExistsDescriptionLoanAdditionsInformation
--GO
--
--CREATE PROCEDURE lms.IsExistsDescriptionLoanAdditionsInformation
--
--	@sysid_loanadditions varchar (50) = '',
--	@loan_additions_description varchar (100) = '',
--
--	@system_user_id varchar (50) = ''
--
--AS
--
--	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
--		(lms.IsBookkeeperSystemUserInfo(@system_user_id) = 1))
--	BEGIN
--		
--		SELECT lms.IsExistsDescriptionLoanAdditionsInfo(@sysid_loanadditions, @loan_additions_description)
--
--	END
--	ELSE
--	BEGIN
--		EXECUTE lms.ShowErrorMsg 'Query a loan additions information', 'Loan Additions Information'
--	END
--	
--GO
-----------------------------------------------------------
--
---- grant permission on the stored procedure
--GRANT EXECUTE ON lms.IsExistsDescriptionLoanAdditionsInformation TO db_lmsusers
--GO
---------------------------------------------------------------
--
---- verifies if the "IsExistsSysIDLoanAdditionsInfo" function already exist
--IF OBJECT_ID (N'lms.IsExistsSysIDLoanAdditionsInfo') IS NOT NULL
--   DROP FUNCTION lms.IsExistsSysIDLoanAdditionsInfo
--GO
--
--CREATE FUNCTION lms.IsExistsSysIDLoanAdditionsInfo
--(	
--	@sysid_loanadditions varchar (50) = ''
--)
--RETURNS bit
--AS
--BEGIN
--	
--	DECLARE @result bit
--
--	SET @result = 0
--	
--	IF EXISTS (SELECT sysid_loanadditions FROM lms.loan_additions_information WHERE sysid_loanadditions = @sysid_loanadditions)
--	BEGIN
--		SET @result = 1
--	END
--	
--	RETURN @result
--END
--GO
--------------------------------------------------------
--
---- verifies if the "IsExistsDescriptionLoanAdditionsInfo" function already exist
--IF OBJECT_ID (N'lms.IsExistsDescriptionLoanAdditionsInfo') IS NOT NULL
--   DROP FUNCTION lms.IsExistsDescriptionLoanAdditionsInfo
--GO
--
--CREATE FUNCTION lms.IsExistsDescriptionLoanAdditionsInfo
--(	
--	@sysid_loanadditions varchar (50) = '',
--	@loan_additions_description varchar (100) = ''
--)
--RETURNS bit
--AS
--BEGIN
--	
--	DECLARE @result bit
--
--	SET @result = 0
--	
--	IF EXISTS (SELECT sysid_loanadditions FROM lms.loan_additions_information WHERE (NOT sysid_loanadditions = @sysid_loanadditions) AND						
--						(REPLACE(loan_additions_description, ' ', '') LIKE REPLACE(@loan_additions_description, ' ', '')))
--								
--	BEGIN
--		SET @result = 1
--	END
--	
--	RETURN @result
--END
--GO
--------------------------------------------------------
--
---- ################################################END TABLE "loan_additions_information" OBJECTS######################################################






-- ################################################TABLE "regular_loan_additions" OBJECTS######################################################
-- verifies if the regular_loan_additions table exists
IF OBJECT_ID('lms.regular_loan_additions', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_additions
GO

CREATE TABLE lms.regular_loan_additions 			
(
	regular_additions_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Regular_Loan_Additions_Regular_Additions_ID_PK PRIMARY KEY (regular_additions_id),
	sysid_regular varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Additions_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION,
	addition_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	addition_description varchar (150) NULL,
	sysid_account varchar (50) NULL
		CONSTRAINT Regular_Loan_Additions_SysID_Account_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Additions_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_Additions_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Additions_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the regular_loan_additions table 
CREATE INDEX Regular_Loan_Additions_Regular_Additions_ID_Index
	ON lms.regular_loan_additions (regular_additions_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Addition_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_Addition_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Addition_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_Addition_Trigger_Insert
	ON  lms.regular_loan_additions
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @regular_additions_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @addition_amount decimal (15, 2)
	DECLARE @addition_description varchar (150)
	DECLARE @sysid_account varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@regular_additions_id = i.regular_additions_id,
		@sysid_regular = i.sysid_regular,
		@addition_amount = i.addition_amount,
		@addition_description = i.addition_description,
		@sysid_account = i.sysid_account,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new regular loan additions ' + 
							'[Addition ID: ' + ISNULL(CONVERT(varchar, @regular_additions_id), '') +
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
							'][Addition Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @addition_amount), 1), '0.00') +
							'][Addition Description: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account)), ISNULL(@addition_description, '')) +	
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Additions_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_Additions_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Additions_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_Additions_Trigger_Instead_Update
	ON  lms.regular_loan_additions
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @regular_additions_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @addition_amount decimal (15, 2)
	DECLARE @addition_description varchar (150)
	DECLARE @sysid_account varchar (50)

	DECLARE @edited_by varchar(50)

	DECLARE @addition_amount_b decimal (15, 2)
	DECLARE @addition_description_b varchar (150)
	DECLARE @sysid_account_b varchar (50)

	DECLARE @has_update bit

	DECLARE regular_loan_additions_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.regular_additions_id, i.sysid_regular, i.addition_amount, i.addition_description, i.sysid_account, i.edited_by
				FROM INSERTED AS i

	OPEN regular_loan_additions_update_cursor

	FETCH NEXT FROM regular_loan_additions_update_cursor
		INTO @regular_additions_id, @sysid_regular, @addition_amount, @addition_description, @sysid_account, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		SELECT 
			@addition_amount_b = rln.addition_amount,
			@addition_description_b = rln.addition_description,
			@sysid_account_b = rln.sysid_account
		FROM 
			lms.regular_loan_additions AS rln
		WHERE
			(rln.regular_additions_id = @regular_additions_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @addition_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @addition_amount_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Addition Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @addition_amount_b), 1), '0.00') + ']' +
														'[Addition Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @addition_amount), 1), '0.00') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(@addition_description COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@addition_description_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')) OR
			(NOT ISNULL(@sysid_account COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Addition Description Before: ' + ISNULL((SELECT
																										coa.account_code + ' - ' + coa.account_name
																									FROM
																										lms.chart_of_accounts AS coa
																									INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																									WHERE
																										(coa.sysid_account = @sysid_account_b)), ISNULL(@addition_description_b, '')) +	 ']' +
														'[Addition Description After: ' + ISNULL((SELECT
																										coa.account_code + ' - ' + coa.account_name
																									FROM
																										lms.chart_of_accounts AS coa
																									INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																									WHERE
																										(coa.sysid_account = @sysid_account)), ISNULL(@addition_description, '')) +	 ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Addition Description: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account)), ISNULL(@addition_description, '')) +	 ']'
		END


		IF (@has_update = 1)
		BEGIN

			UPDATE lms.regular_loan_additions SET
				addition_amount = @addition_amount,
				addition_description = @addition_description,
				sysid_account = @sysid_account,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				regular_additions_id = @regular_additions_id

			SET @transaction_done = 'UPDATED a regular loan additions ' + 
									'[Addition ID: ' + ISNULL(CONVERT(varchar, @regular_additions_id), '') +
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
			UPDATE lms.regular_loan_additions SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(regular_additions_id = @regular_additions_id)

		END
				
		FETCH NEXT FROM regular_loan_additions_update_cursor
			INTO @regular_additions_id, @sysid_regular, @addition_amount, @addition_description, @sysid_account, @edited_by

	END

	CLOSE regular_loan_additions_update_cursor
	DEALLOCATE regular_loan_additions_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Additions_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Additions_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Additions_Trigger_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Additions_Trigger_Delete
	ON  lms.regular_loan_additions
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @regular_additions_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @addition_amount decimal (15, 2)
	DECLARE @addition_description varchar (150)
	DECLARE @sysid_account varchar (50)

	DECLARE @deleted_by varchar(50)

	DECLARE regular_loan_additions_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.regular_additions_id, d.sysid_regular, d.addition_amount, d.addition_description, d.sysid_account, d.edited_by
				FROM DELETED AS d

	OPEN regular_loan_additions_delete_cursor

	FETCH NEXT FROM regular_loan_additions_delete_cursor
		INTO @regular_additions_id, @sysid_regular, @addition_amount, @addition_description, @sysid_account, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		SET @transaction_done = 'DELETED a regular loan additions ' + 
								'[Additions ID: ' + ISNULL(CONVERT(varchar, @regular_additions_id), '') +
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
								'][Addition Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @addition_amount), 1), '0.00') +
								'][Addition Description: ' + ISNULL((SELECT
																		coa.account_code + ' - ' + coa.account_name
																	FROM
																		lms.chart_of_accounts AS coa
																	INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																	WHERE
																		(coa.sysid_account = @sysid_account)), ISNULL(@addition_description, '')) +	
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
				
		FETCH NEXT FROM regular_loan_additions_delete_cursor
			INTO @regular_additions_id, @sysid_regular, @addition_amount, @addition_description, @sysid_account, @deleted_by

	END

	CLOSE regular_loan_additions_delete_cursor
	DEALLOCATE regular_loan_additions_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanAdditions" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanAdditions')
   DROP PROCEDURE lms.InsertRegularLoanAdditions
GO

CREATE PROCEDURE lms.InsertRegularLoanAdditions
	
	@sysid_regular varchar (50) = '',
	@addition_amount decimal (15, 2) = 0.00,
	@addition_description varchar (150) = '',
	@sysid_account varchar (50) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsChargeRegularLoanAdd(DEFAULT, @sysid_regular, @addition_description, @sysid_account) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_additions
		(
			sysid_regular,
			addition_amount,
			addition_description,
			sysid_account,

			created_by
		)
		VALUES
		(
			@sysid_regular,
			@addition_amount,
			@addition_description,
			@sysid_account,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a regular loan additions', 'Regular Loan Additions'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanAdditions TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateRegularLoanAdditions" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateRegularLoanAdditions')
   DROP PROCEDURE lms.UpdateRegularLoanAdditions
GO

CREATE PROCEDURE lms.UpdateRegularLoanAdditions
	
	@regular_additions_id bigint = 0,
	@addition_amount decimal (15, 2) = 0.00,
	@addition_description varchar (150) = '',
	@sysid_account varchar (50) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsChargeRegularLoanAdd(@regular_additions_id, 
											(SELECT sysid_regular FROM lms.regular_loan_additions WHERE regular_additions_id = @regular_additions_id), 
											@addition_description,
											@sysid_account) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.regular_loan_additions SET
			addition_amount = @addition_amount,
			addition_description = @addition_description,
			sysid_account = @sysid_account,

			edited_by = @edited_by
		WHERE
			(regular_additions_id = @regular_additions_id)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a regular loan additions', 'Regular Loan Additions'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateRegularLoanAdditions TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanAdditions" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanAdditions')
   DROP PROCEDURE lms.DeleteRegularLoanAdditions
GO

CREATE PROCEDURE lms.DeleteRegularLoanAdditions
	
	@regular_additions_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT regular_additions_id FROM lms.regular_loan_additions WHERE regular_additions_id = @regular_additions_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_additions SET
				edited_by = @deleted_by
			WHERE
				(regular_additions_id = @regular_additions_id)

			DELETE FROM lms.regular_loan_additions WHERE (regular_additions_id = @regular_additions_id)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan additions', 'Regular Loan Additions'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanAdditions TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularListRegularLoanAdditions" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularListRegularLoanAdditions')
   DROP PROCEDURE lms.SelectBySysIDRegularListRegularLoanAdditions
GO

CREATE PROCEDURE lms.SelectBySysIDRegularListRegularLoanAdditions

	@sysid_regular_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rln.regular_additions_id AS regular_additions_id,
			rln.sysid_regular AS sysid_regular,
			rln.addition_amount AS addition_amount,
			rln.addition_description AS addition_description,
			rln.sysid_account AS sysid_account
		FROM
			lms.regular_loan_additions AS rln
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srgl_list ON srgl_list.var_str = rln.sysid_regular
		ORDER BY
			rln.sysid_regular ASC, rln.addition_description ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan additions', 'Regular Loan Additions'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularListRegularLoanAdditions TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsChargeRegularLoanAdditions" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsChargeRegularLoanAdditions')
   DROP PROCEDURE lms.IsExistsChargeRegularLoanAdditions
GO

CREATE PROCEDURE lms.IsExistsChargeRegularLoanAdditions

	@regular_additions_id bigint = 0,
	@sysid_regular varchar (50) = '',
	@addition_description varchar (150) = '',
	@sysid_account varchar (50) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsChargeRegularLoanAdd(@regular_additions_id, @sysid_regular, @addition_description, @sysid_account)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a regular loan additions', 'Regular Loan Additions'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsChargeRegularLoanAdditions TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsChargeRegularLoanAdd" function already exist
IF OBJECT_ID (N'lms.IsExistsChargeRegularLoanAdd') IS NOT NULL
   DROP FUNCTION lms.IsExistsChargeRegularLoanAdd
GO

CREATE FUNCTION lms.IsExistsChargeRegularLoanAdd
(	
	@regular_additions_id bigint = 0,
	@sysid_regular varchar (50) = '',
	@addition_description varchar (150) = '',
	@sysid_account varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT 
					regular_additions_id 
				FROM 
					lms.regular_loan_additions
				WHERE 
					(NOT regular_additions_id = @regular_additions_id) AND
					(sysid_regular = @sysid_regular) AND
					((sysid_account = @sysid_account) OR
					(REPLACE(addition_description, ' ', '') LIKE REPLACE(@addition_description, ' ', ''))))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ##############################################END TABLE "regular_loan_additions" OBJECTS######################################################





-- ################################################TABLE "regular_loan_information" OBJECTS######################################################

--verifies that the trigger "Regular_Loan_Information_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_Information_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Information_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_Information_Trigger_Insert
	ON  lms.regular_loan_information
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @account_no varchar (50)
	DECLARE @loan_amount decimal (15, 2)
	DECLARE @purpose_of_loan varchar (MAX)
	DECLARE @is_productive bit
	DECLARE @regular_loan_type_id varchar (50)
	DECLARE @repayment_id varchar (50)
	DECLARE @loan_terms smallint
	DECLARE @no_prepaid_interest smallint
	DECLARE @interest_rate float
	DECLARE @grace_period tinyint
	DECLARE @is_straight_loan bit
	DECLARE @loan_requirements varchar (MAX)
	DECLARE @date_applied datetime
	DECLARE @date_approved datetime
	DECLARE @approval_evaluation varchar (MAX)
	DECLARE @date_first_payment datetime
	DECLARE @date_maturity datetime
	DECLARE @penalty_rate float
	DECLARE @no_default_payment tinyint
	DECLARE @remarks varchar (MAX)

	DECLARE @created_by varchar (50)

	DECLARE @productive_string varchar (20)
	DECLARE @straight_loan_string varchar (20)
	
	SELECT 
		@sysid_regular = i.sysid_regular,
		@sysid_member = i.sysid_member,
		@account_no = i.account_no,
		@loan_amount = i.loan_amount,
		@purpose_of_loan = i.purpose_of_loan,
		@is_productive = i.is_productive,
		@regular_loan_type_id = i.regular_loan_type_id,
		@repayment_id = i.repayment_id,
		@loan_terms = i.loan_terms,
		@no_prepaid_interest = i.no_prepaid_interest,
		@interest_rate = i.interest_rate,
		@grace_period = i.grace_period,
		@is_straight_loan = i.is_straight_loan,
		@loan_requirements = i.loan_requirements,
		@date_applied = i.date_applied,
		@date_approved = i.date_approved,
		@approval_evaluation = i.approval_evaluation,
		@date_first_payment = i.date_first_payment,
		@date_maturity = i.date_maturity,		
		@penalty_rate = i.penalty_rate,
		@no_default_payment = i.no_default_payment,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	IF (@is_productive = 1)
	BEGIN
		SET @productive_string = 'YES'
	END
	ELSE
	BEGIN
		SET @productive_string = 'NO'
	END

	IF (@is_straight_loan = 1)
	BEGIN
		SET @straight_loan_string = 'YES'
	END
	ELSE
	BEGIN
		SET @straight_loan_string = 'NO'
	END

	SET @transaction_done = 'CREATED a new regular loan information ' + 
							'[Regular Loan System ID: ' + ISNULL(@sysid_regular, '') +
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
							'][Account No.: ' + ISNULL(@account_no, '') +
							'][Loan Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @loan_amount), 1), '0.00') +
							'][Purpose of Loan: ' + ISNULL(@purpose_of_loan, '') +
							'][Is Productive: ' + ISNULL(@productive_string, '') +
							'][Regular Loan Type: ' + ISNULL((SELECT
																	rlt.regular_loan_type_description + ' (' + rlt.regular_loan_type_code + ')'
																FROM
																	lms.regular_loan_type AS rlt
																WHERE
																	(rlt.regular_loan_type_id = @regular_loan_type_id)), '') +
							'][Repayment Schedule: ' + (SELECT
															rps.repayment_description + ' (' + ISNULL(CONVERT(varchar, rps.payments_per_year), '') 
																	+ ' payments per year)'
														FROM
															lms.repayment_schedule AS rps
														WHERE
															(rps.repayment_id = @repayment_id)) +
							'][Loan Terms: ' + ISNULL(CONVERT(varchar, @loan_terms), '') +
							'][No. of Prepaid Interest: ' + ISNULL(CONVERT(varchar, @no_prepaid_interest), '') +
							'][Interest Rate: ' + ISNULL(CONVERT(varchar, @interest_rate), '') + '%' +
							'][Grace Period: ' + ISNULL(CONVERT(varchar, @grace_period), '') + 
							'][Is Straight Loan: ' + ISNULL(@straight_loan_string, '') +
							'][Loan Requirements: ' + ISNULL(@loan_requirements, '') +
							'][Date Applied: ' + ISNULL(CONVERT(varchar, @date_applied, 101), '') +
							'][Date Approved: ' + ISNULL(CONVERT(varchar, @date_approved, 101), '') +
							'][Approval/Evaluation: ' + ISNULL(@approval_evaluation, '') +
							'][Date First Payment: ' + ISNULL(CONVERT(varchar, @date_first_payment, 101), '') +
							'][Date Maturity: ' + ISNULL(CONVERT(varchar, @date_maturity, 101), '') +
							'][Penalty Rate: ' + ISNULL(CONVERT(varchar, @penalty_rate), '') + '%' +
							'][No. of Default Payments: ' + ISNULL(CONVERT(varchar, @no_default_payment), '') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_Information_Trigger_Instead_Update
	ON  lms.regular_loan_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @account_no varchar (50)
	DECLARE @loan_amount decimal (15, 2)
	DECLARE @purpose_of_loan varchar (MAX)
	DECLARE @is_productive bit
	DECLARE @regular_loan_type_id varchar (50)
	DECLARE @repayment_id varchar (50)
	DECLARE @loan_terms smallint
	DECLARE @no_prepaid_interest smallint
	DECLARE @interest_rate float
	DECLARE @grace_period tinyint
	DECLARE @is_straight_loan bit
	DECLARE @loan_requirements varchar (MAX)
	DECLARE @date_applied datetime
	DECLARE @date_approved datetime
	DECLARE @approval_evaluation varchar (MAX)
	DECLARE @date_first_payment datetime
	DECLARE @date_maturity datetime
	DECLARE @penalty_rate float
	DECLARE @no_default_payment tinyint
	DECLARE @remarks varchar (MAX)
	DECLARE @is_marked_deleted bit

	DECLARE @edited_by varchar(50)

	DECLARE @account_no_b varchar (50)
	DECLARE @loan_amount_b decimal (15, 2)
	DECLARE @purpose_of_loan_b varchar (MAX)
	DECLARE @is_productive_b bit
	DECLARE @regular_loan_type_id_b varchar (50)
	DECLARE @repayment_id_b varchar (50)
	DECLARE @loan_terms_b smallint
	DECLARE @no_prepaid_interest_b smallint
	DECLARE @interest_rate_b float
	DECLARE @grace_period_b tinyint
	DECLARE @is_straight_loan_b bit
	DECLARE @loan_requirements_b varchar (MAX)
	DECLARE @date_applied_b datetime
	DECLARE @date_approved_b datetime
	DECLARE @approval_evaluation_b varchar (MAX)
	DECLARE @date_first_payment_b datetime
	DECLARE @date_maturity_b datetime
	DECLARE @penalty_rate_b float
	DECLARE @no_default_payment_b tinyint
	DECLARE @remarks_b varchar (MAX)
	
	DECLARE @productive_string varchar (20)
	DECLARE @straight_loan_string varchar (20)
	DECLARE @productive_string_b varchar (20)
	DECLARE @straight_loan_string_b varchar (20)

	DECLARE @has_update bit

	DECLARE regular_loan_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_regular, i.sysid_member, i.account_no, i.loan_amount, i.purpose_of_loan, i.is_productive, i.regular_loan_type_id,
					i.repayment_id, i.loan_terms, i.no_prepaid_interest, i.interest_rate, i.grace_period, i.is_straight_loan, i.loan_requirements, 
					i.date_applied, i.date_approved, i.approval_evaluation, i.date_first_payment, i.date_maturity, i.penalty_rate, i.no_default_payment, 
					i.remarks, i.is_marked_deleted, i.edited_by
				FROM INSERTED AS i

	OPEN regular_loan_information_update_cursor

	FETCH NEXT FROM regular_loan_information_update_cursor
		INTO @sysid_regular, @sysid_member, @account_no, @loan_amount, @purpose_of_loan, @is_productive, @regular_loan_type_id,
					@repayment_id, @loan_terms, @no_prepaid_interest, @interest_rate, @grace_period, @is_straight_loan, @loan_requirements, 
					@date_applied, @date_approved, @approval_evaluation, @date_first_payment, @date_maturity, @penalty_rate, @no_default_payment, 
					@remarks, @is_marked_deleted, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		IF (@is_marked_deleted = 0)
		BEGIN	

			SELECT 
				@account_no_b = rli.account_no,
				@loan_amount_b = rli.loan_amount,
				@purpose_of_loan_b = rli.purpose_of_loan,
				@is_productive_b = rli.is_productive,
				@regular_loan_type_id_b = rli.regular_loan_type_id,
				@repayment_id_b = rli.repayment_id,
				@loan_terms_b = rli.loan_terms,
				@no_prepaid_interest_b = rli.no_prepaid_interest,
				@interest_rate_b = rli.interest_rate,
				@grace_period_b = rli.grace_period,
				@is_straight_loan_b = rli.is_straight_loan,
				@loan_requirements_b = rli.loan_requirements,
				@date_applied_b = rli.date_applied,
				@date_approved_b = rli.date_approved,
				@approval_evaluation_b = rli.approval_evaluation,
				@date_first_payment_b = rli.date_first_payment,
				@date_maturity_b = rli.date_maturity,
				@penalty_rate_b = rli.penalty_rate,
				@no_default_payment_b = rli.no_default_payment,
				@remarks_b = rli.remarks
			FROM 
				lms.regular_loan_information AS rli
			WHERE
				(rli.sysid_regular = @sysid_regular)

			SET @transaction_done = ''
			SET @has_update = 0

			IF (NOT ISNULL(@account_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@account_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Account No. Before: ' + ISNULL(@account_no_b, '') + ']' +
															'[Account No. After: ' + ISNULL(@account_no, '') + ']'
				SET @has_update = 1
			END
			ELSE
			BEGIN
				SET @transaction_done = @transaction_done + '[Account No.: ' + ISNULL(@account_no, '') + ']'
			END

			IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @loan_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @loan_amount_b), 1), '0.00'))
			BEGIN
				SET @transaction_done = @transaction_done + '[Loan Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @loan_amount_b), 1), '0.00') + ']' +
															'[Loan Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @loan_amount), 1), '0.00') + ']'
				SET @has_update = 1	
			END

			IF (NOT ISNULL(@purpose_of_loan COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@purpose_of_loan_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Purpose of Loan Before: ' + ISNULL(@purpose_of_loan_b, '') + ']' +
															'[Purpose of Loan After: ' + ISNULL(@purpose_of_loan, '') + ']'
				SET @has_update = 1
			END

			IF (NOT @is_productive = @is_productive_b)
			BEGIN

				IF (@is_productive = 1)
				BEGIN
					SET @productive_string = 'YES'
				END
				ELSE
				BEGIN
					SET @productive_string = 'NO'
				END

				IF (@is_productive_b = 1)
				BEGIN
					SET @productive_string_b = 'YES'
				END
				ELSE
				BEGIN
					SET @productive_string_b = 'NO'
				END

				SET @transaction_done = @transaction_done + '[Is Productive Before: ' + ISNULL(@productive_string_b, '') + ']' +
															'[Is Productive After: ' + ISNULL(@productive_string, '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(@regular_loan_type_id COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@regular_loan_type_id_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Regular Loan Type Before: ' + ISNULL((SELECT
																										rlt.regular_loan_type_description + ' (' + rlt.regular_loan_type_code + ')'
																									FROM
																										lms.regular_loan_type AS rlt
																									WHERE
																										(rlt.regular_loan_type_id = @regular_loan_type_id_b)), '') + ']' +
															'[Regular Loan Type After: ' + ISNULL((SELECT
																										rlt.regular_loan_type_description + ' (' + rlt.regular_loan_type_code + ')'
																									FROM
																										lms.regular_loan_type AS rlt
																									WHERE
																										(rlt.regular_loan_type_id = @regular_loan_type_id)), '') + ']'
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

			IF (NOT ISNULL(CONVERT(varchar, @loan_terms), '') = ISNULL(CONVERT(varchar, @loan_terms_b), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Loan Terms Before: ' + ISNULL(CONVERT(varchar, @loan_terms_b), '') + ']' +
															'[Loan Terms After: ' + ISNULL(CONVERT(varchar, @loan_terms), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @no_prepaid_interest), '') = ISNULL(CONVERT(varchar, @no_prepaid_interest_b), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[No. of Prepaid Interest Before: ' + ISNULL(CONVERT(varchar, @no_prepaid_interest_b), '') + ']' +
															'[No. of Prepaid Interest After: ' + ISNULL(CONVERT(varchar, @no_prepaid_interest), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @interest_rate), '') = ISNULL(CONVERT(varchar, @interest_rate_b), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Interest Rate Before: ' + ISNULL(CONVERT(varchar, @interest_rate_b), '') + '%' + ']' +
															'[Interest Rate After: ' + ISNULL(CONVERT(varchar, @interest_rate), '') + '%' + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @grace_period), '') = ISNULL(CONVERT(varchar, @grace_period_b), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Grace Period Before: ' + ISNULL(CONVERT(varchar, @grace_period_b), '') +  ']' +
															'[Grace Period After: ' + ISNULL(CONVERT(varchar, @grace_period), '') +  ']'
				SET @has_update = 1
			END

			IF (NOT @is_straight_loan = @is_straight_loan_b)
			BEGIN

				IF (@is_straight_loan = 1)
				BEGIN
					SET @straight_loan_string = 'YES'
				END
				ELSE
				BEGIN
					SET @straight_loan_string = 'NO'
				END

				IF (@is_straight_loan_b = 1)
				BEGIN
					SET @straight_loan_string_b = 'YES'
				END
				ELSE
				BEGIN
					SET @straight_loan_string_b = 'NO'
				END

				SET @transaction_done = @transaction_done + '[Is Straight Loan Before: ' + ISNULL(@straight_loan_string_b, '') + ']' +
															'[Is Straight Loan After: ' + ISNULL(@straight_loan_string, '') + ']'
				SET @has_update = 1

			END

			IF (NOT ISNULL(@loan_requirements COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@loan_requirements_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Loan Requirements Before: ' + ISNULL(@loan_requirements_b, '') + ']' +
															'[Loan Requirements After: ' + ISNULL(@loan_requirements, '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @date_applied, 101), '') = ISNULL(CONVERT(varchar, @date_applied_b, 101), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Date Applied Before: ' + ISNULL(CONVERT(varchar, @date_applied_b, 101), '') + ']' +
															'[Date Applied After: ' + ISNULL(CONVERT(varchar, @date_applied, 101), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @date_approved, 101), '') = ISNULL(CONVERT(varchar, @date_approved_b, 101), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Date Approved Before: ' + ISNULL(CONVERT(varchar, @date_approved_b, 101), '') + ']' +
															'[Date Approved After: ' + ISNULL(CONVERT(varchar, @date_approved, 101), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(@approval_evaluation COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@approval_evaluation_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Approval/Evaluation Before: ' + ISNULL(@approval_evaluation_b, '') + ']' +
															'[Approval/Evaluation After: ' + ISNULL(@approval_evaluation, '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @date_first_payment, 101), '') = ISNULL(CONVERT(varchar, @date_first_payment_b, 101), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Date First Payment Before: ' + ISNULL(CONVERT(varchar, @date_first_payment_b, 101), '') + ']' +
															'[Date First Payment After: ' + ISNULL(CONVERT(varchar, @date_first_payment, 101), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @date_maturity, 101), '') = ISNULL(CONVERT(varchar, @date_maturity_b, 101), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Date Maturity Before: ' + ISNULL(CONVERT(varchar, @date_maturity_b, 101), '') + ']' +
															'[Date Maturity After: ' + ISNULL(CONVERT(varchar, @date_maturity, 101), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @penalty_rate), '') = ISNULL(CONVERT(varchar, @penalty_rate_b), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Penalty Rate Before: ' + ISNULL(CONVERT(varchar, @penalty_rate_b), '') + '%' + ']' +
															'[Penalty Rate After: ' + ISNULL(CONVERT(varchar, @penalty_rate), '') + '%' + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @no_default_payment), '') = ISNULL(CONVERT(varchar, @no_default_payment_b), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[No. of Default Payments Before: ' + ISNULL(CONVERT(varchar, @no_default_payment_b), '') + ']' +
															'[No. of Default Payments After: ' + ISNULL(CONVERT(varchar, @no_default_payment), '') + ']'
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

					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					sysid_regular = @sysid_regular

				SET @transaction_done = 'UPDATED a regular loan information ' + 
										'[Regular Loan System ID: ' + ISNULL(@sysid_regular, '') +
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
				UPDATE lms.regular_loan_information SET
					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					(sysid_regular = @sysid_regular)

			END

		END
				
		FETCH NEXT FROM regular_loan_information_update_cursor
			INTO @sysid_regular, @sysid_member, @account_no, @loan_amount, @purpose_of_loan, @is_productive, @regular_loan_type_id,
						@repayment_id, @loan_terms, @no_prepaid_interest, @interest_rate, @grace_period, @is_straight_loan, @loan_requirements, 
						@date_applied, @date_approved, @approval_evaluation, @date_first_payment, @date_maturity, @penalty_rate, @no_default_payment, 
						@remarks, @is_marked_deleted, @edited_by

	END

	CLOSE regular_loan_information_update_cursor
	DEALLOCATE regular_loan_information_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Regular_Loan_Information_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Information_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Information_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Information_Trigger_Instead_Delete
	ON  lms.regular_loan_information
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_regular varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @account_no varchar (50)
	DECLARE @loan_amount decimal (15, 2)
	DECLARE @purpose_of_loan varchar (MAX)
	DECLARE @is_productive bit
	DECLARE @regular_loan_type_id varchar (50)
	DECLARE @repayment_id varchar (50)
	DECLARE @loan_terms smallint
	DECLARE @no_prepaid_interest smallint
	DECLARE @interest_rate float
	DECLARE @grace_period tinyint
	DECLARE @is_straight_loan bit
	DECLARE @loan_requirements varchar (MAX)
	DECLARE @date_applied datetime
	DECLARE @date_approved datetime
	DECLARE @approval_evaluation varchar (MAX)
	DECLARE @date_first_payment datetime
	DECLARE @date_maturity datetime
	DECLARE @penalty_rate float
	DECLARE @no_default_payment tinyint
	DECLARE @remarks varchar (MAX)
	DECLARE @is_marked_deleted bit

	DECLARE @deleted_by varchar(50)
	
	DECLARE @productive_string varchar (20)
	DECLARE @straight_loan_string varchar (20)

	DECLARE regular_loan_information_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.sysid_regular, d.sysid_member, d.account_no, d.loan_amount, d.purpose_of_loan, d.is_productive, d.regular_loan_type_id,
					d.repayment_id, d.loan_terms, d.no_prepaid_interest, d.interest_rate, d.grace_period, d.is_straight_loan, d.loan_requirements, 
					d.date_applied, d.date_approved, d.approval_evaluation, d.date_first_payment, d.date_maturity, d.penalty_rate, d.no_default_payment, 
					d.remarks, d.is_marked_deleted, d.edited_by
				FROM DELETED AS d

	OPEN regular_loan_information_delete_cursor

	FETCH NEXT FROM regular_loan_information_delete_cursor
		INTO @sysid_regular, @sysid_member, @account_no, @loan_amount, @purpose_of_loan, @is_productive, @regular_loan_type_id,
					@repayment_id, @loan_terms, @no_prepaid_interest, @interest_rate, @grace_period, @is_straight_loan, @loan_requirements, 
					@date_applied, @date_approved, @approval_evaluation, @date_first_payment, @date_maturity, @penalty_rate, @no_default_payment, 
					@remarks, @is_marked_deleted, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF (@is_marked_deleted = 0)
		BEGIN

			--delete the loan charges
			UPDATE lms.regular_loan_charges SET edited_on = GETDATE(), edited_by = @deleted_by WHERE sysid_regular = @sysid_regular
			DELETE lms.regular_loan_charges WHERE sysid_regular = @sysid_regular

			--delete the loan additions
			UPDATE lms.regular_loan_additions SET edited_on = GETDATE(), edited_by = @deleted_by WHERE sysid_regular = @sysid_regular
			DELETE lms.regular_loan_additions WHERE sysid_regular = @sysid_regular

			UPDATE lms.regular_loan_information SET 
				is_marked_deleted = 1, 

				edited_on = GETDATE(), 
				edited_by = @deleted_by 
			WHERE 
				(sysid_regular = @sysid_regular)

			IF (@is_productive = 1)
			BEGIN
				SET @productive_string = 'YES'
			END
			ELSE
			BEGIN
				SET @productive_string = 'NO'
			END

			IF (@is_straight_loan = 1)
			BEGIN
				SET @straight_loan_string = 'YES'
			END
			ELSE
			BEGIN
				SET @straight_loan_string = 'NO'
			END

			SET @transaction_done = 'MARK AS DELETED a regular loan information ' + 
									'[Regular Loan System ID: ' + ISNULL(@sysid_regular, '') +
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
									'][Account No.: ' + ISNULL(@account_no, '') +
									'][Loan Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @loan_amount), 1), '0.00') +
									'][Purpose of Loan: ' + ISNULL(@purpose_of_loan, '') +
									'][Is Productive: ' + ISNULL(@productive_string, '') +
									'][Regular Loan Type: ' + ISNULL((SELECT
																			rlt.regular_loan_type_description + ' (' + rlt.regular_loan_type_code + ')'
																		FROM
																			lms.regular_loan_type AS rlt
																		WHERE
																			(rlt.regular_loan_type_id = @regular_loan_type_id)), '') +
									'][Repayment Schedule: ' + (SELECT
																	rps.repayment_description + ' (' + ISNULL(CONVERT(varchar, rps.payments_per_year), '') 
																			+ ' payments per year)'
																FROM
																	lms.repayment_schedule AS rps
																WHERE
																	(rps.repayment_id = @repayment_id)) +
									'][Loan Terms: ' + ISNULL(CONVERT(varchar, @loan_terms), '') +
									'][No. of Prepaid Interest: ' + ISNULL(CONVERT(varchar, @no_prepaid_interest), '') +
									'][Interest Rate: ' + ISNULL(CONVERT(varchar, @interest_rate), '') + '%' +
									'][Grace Period: ' + ISNULL(CONVERT(varchar, @grace_period), '') + 
									'][Is Straight Loan: ' + ISNULL(@straight_loan_string, '') +
									'][Loan Requirements: ' + ISNULL(@loan_requirements, '') +
									'][Date Applied: ' + ISNULL(CONVERT(varchar, @date_applied, 101), '') +
									'][Date Approved: ' + ISNULL(CONVERT(varchar, @date_approved, 101), '') +
									'][Approval/Evaluation: ' + ISNULL(@approval_evaluation, '') +
									'][Date First Payment: ' + ISNULL(CONVERT(varchar, @date_first_payment, 101), '') +
									'][Date Maturity: ' + ISNULL(CONVERT(varchar, @date_maturity, 101), '') +
									'][Penalty Rate: ' + ISNULL(CONVERT(varchar, @penalty_rate), '') + '%' +
									'][No. of Default Payments: ' + ISNULL(CONVERT(varchar, @no_default_payment), '') +
									'][Remarks: ' + ISNULL(@remarks, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
			END
					
			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		END
				
		FETCH NEXT FROM regular_loan_information_delete_cursor
			INTO @sysid_regular, @sysid_member, @account_no, @loan_amount, @purpose_of_loan, @is_productive, @regular_loan_type_id,
						@repayment_id, @loan_terms, @no_prepaid_interest, @interest_rate, @grace_period, @is_straight_loan, @loan_requirements, 
						@date_applied, @date_approved, @approval_evaluation, @date_first_payment, @date_maturity, @penalty_rate, @no_default_payment, 
						@remarks, @is_marked_deleted, @deleted_by

	END

	CLOSE regular_loan_information_delete_cursor
	DEALLOCATE regular_loan_information_delete_cursor
	
GO
-------------------------------------------------------------------------


-- ##############################################END TABLE "regular_loan_information" OBJECTS######################################################







-- ################################################TABLE "share_capital_information" OBJECTS######################################################
-- verifies if the share_capital_information table exists
IF OBJECT_ID('lms.share_capital_information', 'U') IS NOT NULL
	DROP TABLE lms.share_capital_information
GO

CREATE TABLE lms.share_capital_information 			
(
	share_capital_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Share_Capital_Information_Share_Capital_ID_PK PRIMARY KEY (share_capital_id),
	sysid_member varchar (50) NOT NULL		
		CONSTRAINT Share_Capital_Information_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
		CONSTRAINT Share_Capital_Information_SysID_Member_UQ UNIQUE (sysid_member, effectivity_date),
	effectivity_date datetime NOT NULL DEFAULT (GETDATE())
		CONSTRAINT Share_Capital_Information_Effectivity_Date_UQ UNIQUE (effectivity_date, sysid_member),
	premium_amount_due decimal (15, 2) NOT NULL DEFAULT (0.00),
	remarks varchar (MAX) NULL,
	
	is_precluded_withdrawal bit NOT NULL DEFAULT (0),
	is_precluded_retirement bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Share_Capital_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Share_Capital_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Share_Capital_Information_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the share_capital_id table 
CREATE INDEX Share_Capital_Information_Share_Capital_ID_Index
	ON lms.share_capital_information (share_capital_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Share_Capital_Information_Trigger_Instead_Insert" already exist
IF OBJECT_ID ('lms.Share_Capital_Information_Trigger_Instead_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Share_Capital_Information_Trigger_Instead_Insert
GO

CREATE TRIGGER lms.Share_Capital_Information_Trigger_Instead_Insert
	ON  lms.share_capital_information
	INSTEAD OF INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @share_capital_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @effectivity_date datetime
	DECLARE @premium_amount_due decimal (15, 2)
	DECLARE @remarks varchar (MAX)
	DECLARE @is_precluded_withdrawal bit
	DECLARE @is_precluded_retirement bit

	DECLARE @created_by varchar (50)

	DECLARE @premium_amount_due_b decimal (15, 2)

	DECLARE @has_update bit

	DECLARE @withdrawal_string varchar (20)
	DECLARE @retirement_string varchar (20)

	DECLARE share_capital_information_insert_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.share_capital_id, i.sysid_member, i.effectivity_date, i.premium_amount_due,
					i.remarks, i.is_precluded_withdrawal, i.is_precluded_retirement, i.created_by
			FROM INSERTED AS i

	OPEN share_capital_information_insert_cursor

	FETCH NEXT FROM share_capital_information_insert_cursor
		INTO @share_capital_id, @sysid_member, @effectivity_date, @premium_amount_due,
					@remarks, @is_precluded_withdrawal, @is_precluded_retirement, @created_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		--check if there is a change in the premium amount due before creating a new share capital information
		IF (EXISTS (SELECT share_capital_id FROM lms.share_capital_information WHERE sysid_member = @sysid_member))
		BEGIN

			SELECT
				@premium_amount_due_b = sci.premium_amount_due
			FROM
				lms.share_capital_information AS sci
			WHERE
				(sci.sysid_member = @sysid_member) AND
				(sci.effectivity_date = (SELECT MAX(effectivity_date) FROM lms.share_capital_information WHERE sysid_member = @sysid_member))

			IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due_b), 1), '0.00'))
			BEGIN
				SET @has_update = 1	
			END

		END
		ELSE
		BEGIN
			SET @has_update = 1
		END

		IF @has_update = 1
		BEGIN

			INSERT INTO lms.share_capital_information
			(
				sysid_member,
				effectivity_date,
				premium_amount_due,
				remarks,
				is_precluded_withdrawal, 
				is_precluded_retirement,

				created_by
			)
			VALUES
			(
				@sysid_member,
				@effectivity_date,
				@premium_amount_due,
				@remarks,
				@is_precluded_withdrawal, 
				@is_precluded_retirement,

				@created_by
			)

			IF (@is_precluded_withdrawal = 1)
			BEGIN
				SET @withdrawal_string = 'YES'
			END
			ELSE
			BEGIN
				SET @withdrawal_string = 'NO'
			END

			IF (@is_precluded_retirement = 1)
			BEGIN
				SET @retirement_string = 'YES'
			END
			ELSE
			BEGIN
				SET @retirement_string = 'NO'
			END


			SET @transaction_done = 'CREATED a new share capital information ' + 
									'[Share Capital ID: ' + ISNULL(CONVERT(varchar, @share_capital_id), '') +
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
									'][Effectivity Date: ' + ISNULL(CONVERT(varchar, @effectivity_date, 101), '') +
									'][Premium Amount Due: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') +
									'][Remarks: ' + ISNULL(@remarks, '') +
									'][Is Precluded for Withdrawal: ' + ISNULL(@withdrawal_string, '') +
									'][Is Precluded for Retirement: ' + ISNULL(@retirement_string, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
			END
					
			EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

		END

		FETCH NEXT FROM share_capital_information_insert_cursor
			INTO @share_capital_id, @sysid_member, @effectivity_date, @premium_amount_due,
						@remarks, @is_precluded_withdrawal, @is_precluded_retirement, @created_by

	END

	CLOSE share_capital_information_insert_cursor
	DEALLOCATE share_capital_information_insert_cursor

GO
-----------------------------------------------------------------

--verifies that the trigger "Share_Capital_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Share_Capital_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Share_Capital_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Share_Capital_Information_Trigger_Instead_Update
	ON  lms.share_capital_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @share_capital_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @effectivity_date datetime
	DECLARE @premium_amount_due decimal (15, 2)
	DECLARE @remarks varchar (MAX)
	DECLARE @is_precluded_withdrawal bit
	DECLARE @is_precluded_retirement bit

	DECLARE @edited_by varchar (50)

	DECLARE @premium_amount_due_b decimal (15, 2)
	DECLARE @remarks_b varchar (MAX)
	DECLARE @is_precluded_withdrawal_b bit
	DECLARE @is_precluded_retirement_b bit

	DECLARE @has_update bit

	DECLARE @withdrawal_string varchar (20)
	DECLARE @retirement_string varchar (20)
	DECLARE @withdrawal_string_b varchar (20)
	DECLARE @retirement_string_b varchar (20)

	DECLARE share_capital_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.share_capital_id, i.sysid_member, i.effectivity_date, i.premium_amount_due,
					i.remarks, i.is_precluded_withdrawal, i.is_precluded_retirement, i.edited_by
			FROM INSERTED AS i

	OPEN share_capital_information_update_cursor

	FETCH NEXT FROM share_capital_information_update_cursor
		INTO @share_capital_id, @sysid_member, @effectivity_date, @premium_amount_due,
					@remarks, @is_precluded_withdrawal, @is_precluded_retirement, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@premium_amount_due_b = sci.premium_amount_due,
			@remarks_b = sci.remarks,
			@is_precluded_withdrawal_b = sci.is_precluded_withdrawal,
			@is_precluded_retirement_b = sci.is_precluded_retirement
		FROM
			lms.share_capital_information AS sci
		WHERE
			(sci.share_capital_id = @share_capital_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Premium Amount Due Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due_b), 1), '0.00') + ']' +
														'[Premium Amount Due After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Premium Amount Due: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') + ']'
		END

		IF (NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') + ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') + ']'
			SET @has_update = 1
		END

		IF (NOT @is_precluded_withdrawal = @is_precluded_withdrawal_b)
		BEGIN

			IF (@is_precluded_withdrawal = 1)
			BEGIN
				SET @withdrawal_string = 'YES'
			END
			ELSE
			BEGIN
				SET @withdrawal_string = 'NO'
			END

			IF (@is_precluded_withdrawal_b = 1)
			BEGIN
				SET @withdrawal_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @withdrawal_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Precluded for Withdrawal Before: ' + ISNULL(@withdrawal_string_b, '') + ']' +
														'[Is Precluded for Withdrawal After: ' + ISNULL(@withdrawal_string, '') + ']'
			SET @has_update = 1
		END

		IF (NOT @is_precluded_retirement = @is_precluded_retirement_b)
		BEGIN

			IF (@is_precluded_retirement = 1)
			BEGIN
				SET @retirement_string = 'YES'
			END
			ELSE
			BEGIN
				SET @retirement_string = 'NO'
			END

			IF (@is_precluded_retirement_b = 1)
			BEGIN
				SET @retirement_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @retirement_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Precluded for Retirement Before: ' + ISNULL(@retirement_string_b, '') + ']' +
														'[Is Precluded for Retirement After: ' + ISNULL(@retirement_string, '') + ']'
			SET @has_update = 1
		END

		IF (@has_update = 1)
		BEGIN

			UPDATE lms.share_capital_information SET
				premium_amount_due = @premium_amount_due,
				remarks = @remarks,
				is_precluded_withdrawal = @is_precluded_withdrawal,
				is_precluded_retirement = @is_precluded_retirement,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				share_capital_id = @share_capital_id

			SET @transaction_done = 'UPDATED a share capital information ' + 
									'[Share Capital ID: ' + ISNULL(CONVERT(varchar, @share_capital_id), '') +
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
									'][Effectivity Date: ' + ISNULL(CONVERT(varchar, @effectivity_date, 101), '') +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END

		END

		FETCH NEXT FROM share_capital_information_update_cursor
			INTO @share_capital_id, @sysid_member, @effectivity_date, @premium_amount_due,
						@remarks, @is_precluded_withdrawal, @is_precluded_retirement, @edited_by

	END

	CLOSE share_capital_information_update_cursor
	DEALLOCATE share_capital_information_update_cursor

GO
-----------------------------------------------------------------

--verifies that the trigger "Share_Capital_Information_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Share_Capital_Information_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Share_Capital_Information_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Share_Capital_Information_Trigger_Instead_Delete
	ON  lms.share_capital_information
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a share capital information', 'Share Capital Information'

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertUpdateShareCapitalInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertUpdateShareCapitalInformation')
   DROP PROCEDURE lms.InsertUpdateShareCapitalInformation
GO

CREATE PROCEDURE lms.InsertUpdateShareCapitalInformation

	@sysid_member varchar (50) = '',
	@premium_amount_due decimal (15, 2) = 0.00,
	@remarks varchar (MAX) = '',
	@is_precluded_withdrawal bit = 0, 
	@is_precluded_retirement bit = 0,

	@network_information varchar (MAX) = '',
	@system_user_id varchar (50) = ''
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @system_user_id, @network_information

		DECLARE @share_capital_id varchar (50)

		SELECT @share_capital_id = share_capital_id FROM lms.share_capital_information WHERE sysid_member = @sysid_member AND
								effectivity_date = lms.GetMemberServicesEffectivityDate(GETDATE())

		IF (NOT @share_capital_id IS NULL)
		BEGIN

			UPDATE lms.share_capital_information SET
				premium_amount_due = @premium_amount_due,
				remarks = @remarks,
				is_precluded_withdrawal = @is_precluded_withdrawal,
				is_precluded_retirement = @is_precluded_retirement,

				edited_by = @system_user_id
			WHERE
				(share_capital_id = @share_capital_id)

		END
		ELSE
		BEGIN

			INSERT INTO lms.share_capital_information
			(
				sysid_member,
				effectivity_date,
				premium_amount_due,
				remarks,
				is_precluded_withdrawal,
				is_precluded_retirement,

				created_by
			)
			VALUES
			(
				@sysid_member,
				lms.GetMemberServicesEffectivityDate(GETDATE()),
				@premium_amount_due,
				@remarks,
				@is_precluded_withdrawal,
				@is_precluded_retirement,

				@system_user_id
			)

		END	

	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertUpdateShareCapitalInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberListShareCapitalInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberListShareCapitalInformation')
   DROP PROCEDURE lms.SelectBySysIDMemberListShareCapitalInformation
GO

CREATE PROCEDURE lms.SelectBySysIDMemberListShareCapitalInformation
	
	@sysid_member_list nvarchar (MAX) = '',
	@include_history bit = 0,

	@system_user_id varchar (50) = ''
	
AS
	
	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		IF (@include_history = 0)
		BEGIN

			SELECT
				sci.share_capital_id AS share_capital_id,
				sci.sysid_member AS sysid_member,
				sci.effectivity_date AS effectivity_date,
				sci.premium_amount_due AS premium_amount_due,
				sci.remarks AS remarks,
				sci.is_precluded_withdrawal AS is_precluded_withdrawal,
				sci.is_precluded_retirement AS is_precluded_retirement,
				'true' AS is_current_share_capital
			FROM
				lms.share_capital_information AS sci
			INNER JOIN
			(
				SELECT
					inner_sci.sysid_member AS sysid_member,
					MAX(inner_sci.effectivity_date) AS effectivity_date
				FROM
					lms.share_capital_information AS inner_sci
				INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = inner_sci.sysid_member
				GROUP BY
					inner_sci.sysid_member
				
			) AS sci_max_eff ON sci_max_eff.sysid_member = sci.sysid_member AND sci_max_eff.effectivity_date >= sci.effectivity_date
			ORDER BY
				effectivity_date DESC

		END
		ELSE
		BEGIN

			SELECT
				sci.share_capital_id AS share_capital_id,
				sci.sysid_member AS sysid_member,
				sci.effectivity_date AS effectivity_date,
				sci.premium_amount_due AS premium_amount_due,
				sci.remarks AS remarks,
				sci.is_precluded_withdrawal AS is_precluded_withdrawal,
				sci.is_precluded_retirement AS is_precluded_retirement,
				'true' AS is_current_share_capital
			FROM
				lms.share_capital_information AS sci
			INNER JOIN
			(
				SELECT
					inner_sci.sysid_member AS sysid_member,
					MAX(inner_sci.effectivity_date) AS effectivity_date
				FROM
					lms.share_capital_information AS inner_sci
				INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = inner_sci.sysid_member
				GROUP BY
					inner_sci.sysid_member
				
			) AS sci_max_eff ON sci_max_eff.sysid_member = sci.sysid_member AND sci_max_eff.effectivity_date >= sci.effectivity_date
			UNION ALL
			SELECT
				sci.share_capital_id AS share_capital_id,
				sci.sysid_member AS sysid_member,
				sci.effectivity_date AS effectivity_date,
				sci.premium_amount_due AS premium_amount_due,
				sci.remarks AS remarks,
				sci.is_precluded_withdrawal AS is_precluded_withdrawal,
				sci.is_precluded_retirement AS is_precluded_retirement,
				'false' AS is_current_share_capital
			FROM
				lms.share_capital_information AS sci
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = sci.sysid_member
			WHERE 
				(NOT sci.share_capital_id IN (SELECT
													sci.share_capital_id AS share_capital_id
												FROM
													lms.share_capital_information AS sci
												INNER JOIN
												(
													SELECT
														inner_sci.sysid_member AS sysid_member,
														MAX(inner_sci.effectivity_date) AS effectivity_date
													FROM
														lms.share_capital_information AS inner_sci
													INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = inner_sci.sysid_member
													GROUP BY
														inner_sci.sysid_member
													
												) AS sci_max_eff ON sci_max_eff.sysid_member = sci.sysid_member AND sci_max_eff.effectivity_date >= sci.effectivity_date))
			ORDER BY
				effectivity_date DESC
		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a share capital information', 'Share Capital Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberListShareCapitalInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- ##############################################END TABLE "share_capital_information" OBJECTS######################################################







-- ################################################TABLE "in_house_hospitalization_information" OBJECTS######################################################
-- verifies if the in_house_hospitalization_information table exists
IF OBJECT_ID('lms.in_house_hospitalization_information', 'U') IS NOT NULL
	DROP TABLE lms.in_house_hospitalization_information
GO

CREATE TABLE lms.in_house_hospitalization_information 			
(
	in_house_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT In_House_Hospitalization_In_House_ID_PK PRIMARY KEY (in_house_id),
	sysid_member varchar (50) NOT NULL		
		CONSTRAINT In_House_Hospitalization_Information_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION
		CONSTRAINT In_House_Hospitalization_Information_SysID_Member_UQ UNIQUE (sysid_member, effectivity_date),
	effectivity_date datetime NOT NULL DEFAULT (GETDATE())
		CONSTRAINT In_House_Hospitalization_Information_Effectivity_Date_UQ UNIQUE (effectivity_date, sysid_member),
	certificate_no varchar (50) NOT NULL,
	premium_amount_due decimal (15, 2) NOT NULL DEFAULT (0.00),
	maximum_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	remarks varchar (MAX) NULL,
	
	is_precluded bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT In_House_Hospitalization_Information_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT In_House_Hospitalization_Information_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT In_House_Hospitalization_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the in_house_id table 
CREATE INDEX In_House_Hospitalization_In_House_ID_Index
	ON lms.in_house_hospitalization_information (in_house_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "In_House_Hospitalization_Information_Trigger_Instead_Insert" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Information_Trigger_Instead_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Information_Trigger_Instead_Insert
GO

CREATE TRIGGER lms.In_House_Hospitalization_Information_Trigger_Instead_Insert
	ON  lms.in_house_hospitalization_information
	INSTEAD OF INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @in_house_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @effectivity_date datetime
	DECLARE @certificate_no varchar (50)
	DECLARE @premium_amount_due decimal (15, 2)
	DECLARE @maximum_amount decimal (15, 2)
	DECLARE @remarks varchar (MAX)
	DECLARE @is_precluded bit

	DECLARE @created_by varchar (50)

	DECLARE @premium_amount_due_b decimal (15, 2)
	DECLARE @maximum_amount_b decimal (15, 2)

	DECLARE @has_update bit

	DECLARE @precluded_string varchar (20)

	DECLARE in_house_hospitalization_information_insert_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.in_house_id, i.sysid_member, i.effectivity_date, i.certificate_no, i.premium_amount_due,
					i.maximum_amount, i.remarks, i.is_precluded, i.created_by
			FROM INSERTED AS i

	OPEN in_house_hospitalization_information_insert_cursor

	FETCH NEXT FROM in_house_hospitalization_information_insert_cursor
		INTO @in_house_id, @sysid_member, @effectivity_date, @certificate_no, @premium_amount_due,
					@maximum_amount, @remarks, @is_precluded, @created_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		--check if there is a change in the premium amount due before creating a new in-house hospitalization information
		IF (EXISTS (SELECT in_house_id FROM lms.in_house_hospitalization_information WHERE sysid_member = @sysid_member))
		BEGIN

			SELECT
				@premium_amount_due_b = ihi.premium_amount_due,
				@maximum_amount_b = ihi.maximum_amount
			FROM
				lms.in_house_hospitalization_information AS ihi
			WHERE
				(ihi.sysid_member = @sysid_member) AND
				(ihi.effectivity_date = (SELECT MAX(effectivity_date) FROM lms.in_house_hospitalization_information WHERE sysid_member = @sysid_member))

			IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due_b), 1), '0.00')) OR
				(NOT ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount_b), 1), '0.00'))
			BEGIN
				SET @has_update = 1	
			END

		END
		ELSE
		BEGIN
			SET @has_update = 1
		END

		IF @has_update = 1
		BEGIN

			INSERT INTO lms.in_house_hospitalization_information
			(
				sysid_member, 
				effectivity_date, 
				certificate_no, 
				premium_amount_due,
				maximum_amount, 
				remarks, 
				is_precluded,

				created_by
			)
			VALUES
			(
				@sysid_member, 
				@effectivity_date, 
				@certificate_no, 
				@premium_amount_due,
				@maximum_amount, 
				@remarks, 
				@is_precluded,

				@created_by
			)

			IF (@is_precluded = 1)
			BEGIN
				SET @precluded_string = 'YES'
			END
			ELSE
			BEGIN
				SET @precluded_string = 'NO'
			END


			SET @transaction_done = 'CREATED a new in-house hospitalization information ' + 
									'[In-House ID: ' + ISNULL(CONVERT(varchar, @in_house_id), '') +
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
									'][Effectivity Date: ' + ISNULL(CONVERT(varchar, @effectivity_date, 101), '') +
									'][Certificate No.: ' + ISNULL(@certificate_no, '') +
									'][Premium Amount Due: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') +
									'][Maximum Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount), 1), '0.00') +
									'][Remarks: ' + ISNULL(@remarks, '') +
									'][Is Precluded: ' + ISNULL(@precluded_string, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
			END
					
			EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

		END

		FETCH NEXT FROM in_house_hospitalization_information_insert_cursor
			INTO @in_house_id, @sysid_member, @effectivity_date, @certificate_no, @premium_amount_due,
						@maximum_amount, @remarks, @is_precluded, @created_by

	END

	CLOSE in_house_hospitalization_information_insert_cursor
	DEALLOCATE in_house_hospitalization_information_insert_cursor

GO
-----------------------------------------------------------------

--verifies that the trigger "In_House_Hospitalization_Information_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Information_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Information_Trigger_Instead_Update
GO

CREATE TRIGGER lms.In_House_Hospitalization_Information_Trigger_Instead_Update
	ON  lms.in_house_hospitalization_information
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @in_house_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @effectivity_date datetime
	DECLARE @certificate_no varchar (50)
	DECLARE @premium_amount_due decimal (15, 2)
	DECLARE @maximum_amount decimal (15, 2)
	DECLARE @remarks varchar (MAX)
	DECLARE @is_precluded bit

	DECLARE @edited_by varchar (50)

	DECLARE @certificate_no_b varchar (50)
	DECLARE @premium_amount_due_b decimal (15, 2)
	DECLARE @maximum_amount_b decimal (15, 2)
	DECLARE @remarks_b varchar (MAX)
	DECLARE @is_precluded_b bit

	DECLARE @has_update bit

	DECLARE @precluded_string varchar (20)
	DECLARE @precluded_string_b varchar (20)

	DECLARE in_house_hospitalization_information_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.in_house_id, i.sysid_member, i.effectivity_date, i.certificate_no, i.premium_amount_due,
					i.maximum_amount, i.remarks, i.is_precluded, i.edited_by
			FROM INSERTED AS i

	OPEN in_house_hospitalization_information_update_cursor

	FETCH NEXT FROM in_house_hospitalization_information_update_cursor
		INTO @in_house_id, @sysid_member, @effectivity_date, @certificate_no, @premium_amount_due,
					@maximum_amount, @remarks, @is_precluded, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@certificate_no_b = ihi.certificate_no, 
			@premium_amount_due_b = ihi.premium_amount_due,
			@maximum_amount_b = ihi.maximum_amount, 
			@remarks_b = ihi.remarks, 
			@is_precluded_b = ihi.is_precluded
		FROM
			lms.in_house_hospitalization_information AS ihi
		WHERE
			(ihi.in_house_id = @in_house_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(@certificate_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@certificate_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Certificate No. Before: ' + ISNULL(@certificate_no_b, '') + ']' +
														'[Certificate No. After: ' + ISNULL(@certificate_no, '') + ']'
			SET @has_update = 1
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Premium Amount Due Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due_b), 1), '0.00') + ']' +
														'[Premium Amount Due After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Premium Amount Due: ' + ISNULL(CONVERT(varchar, CONVERT(money, @premium_amount_due), 1), '0.00') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Maximum Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount_b), 1), '0.00') + ']' +
														'[Maximum Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount), 1), '0.00') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Maximum Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @maximum_amount), 1), '0.00') + ']'
		END

		IF (NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') + ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') + ']'
			SET @has_update = 1
		END

		IF (NOT @is_precluded = @is_precluded_b)
		BEGIN

			IF (@is_precluded = 1)
			BEGIN
				SET @precluded_string = 'YES'
			END
			ELSE
			BEGIN
				SET @precluded_string = 'NO'
			END

			IF (@is_precluded_b = 1)
			BEGIN
				SET @precluded_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @precluded_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Precluded Before: ' + ISNULL(@precluded_string_b, '') + ']' +
														'[Is Precluded After: ' + ISNULL(@precluded_string, '') + ']'
			SET @has_update = 1
		END

		IF (@has_update = 1)
		BEGIN

			UPDATE lms.in_house_hospitalization_information SET
				certificate_no = @certificate_no, 
				premium_amount_due = @premium_amount_due,
				maximum_amount = @maximum_amount, 
				remarks = @remarks, 
				is_precluded = @is_precluded,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				in_house_id = @in_house_id

			SET @transaction_done = 'UPDATED a in-house hospitalization information ' + 
									'[In-House ID: ' + ISNULL(CONVERT(varchar, @in_house_id), '') +
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
									'][Effectivity Date: ' + ISNULL(CONVERT(varchar, @effectivity_date, 101), '') +
									']' + @transaction_done

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @edited_by
			END

		END

		FETCH NEXT FROM in_house_hospitalization_information_update_cursor
			INTO @in_house_id, @sysid_member, @effectivity_date, @certificate_no, @premium_amount_due,
						@maximum_amount, @remarks, @is_precluded, @edited_by

	END

	CLOSE in_house_hospitalization_information_update_cursor
	DEALLOCATE in_house_hospitalization_information_update_cursor

GO
-----------------------------------------------------------------

--verifies that the trigger "In_House_Hospitalization_Information_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Information_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Information_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.In_House_Hospitalization_Information_Trigger_Instead_Delete
	ON  lms.in_house_hospitalization_information
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	EXECUTE lms.ShowErrorMsg 'Delete a in-house hospitalization information', 'In-House Hospitalization Information'

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertUpdateInHouseHospitalizationInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertUpdateInHouseHospitalizationInformation')
   DROP PROCEDURE lms.InsertUpdateInHouseHospitalizationInformation
GO

CREATE PROCEDURE lms.InsertUpdateInHouseHospitalizationInformation

	@sysid_member varchar (50) = '',
	@certificate_no varchar (50) = '',
	@premium_amount_due decimal (15, 2) = 0.00,
	@maximum_amount decimal (15, 2) = 0.00,
	@remarks varchar (MAX) = '',
	@is_precluded bit = 0,

	@network_information varchar (MAX) = '',
	@system_user_id varchar (50) = ''
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @system_user_id, @network_information

		DECLARE @in_house_id varchar (50)

		SELECT @in_house_id = in_house_id FROM lms.in_house_hospitalization_information WHERE sysid_member = @sysid_member AND
								effectivity_date = lms.GetMemberServicesEffectivityDate(GETDATE())

		IF (NOT @in_house_id IS NULL) AND (@in_house_id > 0)
		BEGIN

			UPDATE lms.in_house_hospitalization_information SET
				certificate_no = @certificate_no, 
				premium_amount_due = @premium_amount_due,
				maximum_amount = @maximum_amount, 
				remarks = @remarks, 
				is_precluded = @is_precluded,

				edited_by = @system_user_id
			WHERE
				(in_house_id = @in_house_id)

		END
		ELSE
		BEGIN

			INSERT INTO lms.in_house_hospitalization_information
			(
				sysid_member, 
				effectivity_date, 
				certificate_no, 
				premium_amount_due,
				maximum_amount, 
				remarks, 
				is_precluded,

				created_by
			)
			VALUES
			(
				@sysid_member, 
				lms.GetMemberServicesEffectivityDate(GETDATE()), 
				@certificate_no, 
				@premium_amount_due,
				@maximum_amount, 
				@remarks, 
				@is_precluded,

				@system_user_id
			)

		END	

	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertUpdateInHouseHospitalizationInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberListInHouseHospitalizationInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberListInHouseHospitalizationInformation')
   DROP PROCEDURE lms.SelectBySysIDMemberListInHouseHospitalizationInformation
GO

CREATE PROCEDURE lms.SelectBySysIDMemberListInHouseHospitalizationInformation
	
	@sysid_member_list nvarchar (MAX) = '',
	@include_history bit = 0,

	@system_user_id varchar (50) = ''
	
AS
	
	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		IF (@include_history = 0)
		BEGIN

			SELECT
				ihi.in_house_id AS in_house_id,
				ihi.sysid_member AS sysid_member,
				ihi.effectivity_date AS effectivity_date,
				ihi.certificate_no AS certificate_no,
				ihi.premium_amount_due AS premium_amount_due,
				ihi.maximum_amount AS maximum_amount,
				ihi.remarks AS remarks,
				ihi.is_precluded AS is_precluded,
				'true' AS is_current_hospitalization
			FROM
				lms.in_house_hospitalization_information AS ihi
			INNER JOIN
			(
				SELECT
					inner_ihi.sysid_member AS sysid_member,
					MAX(inner_ihi.effectivity_date) AS effectivity_date
				FROM
					lms.in_house_hospitalization_information AS inner_ihi
				INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = inner_ihi.sysid_member
				GROUP BY
					inner_ihi.sysid_member
				
			) AS ihi_max_eff ON ihi_max_eff.sysid_member = ihi.sysid_member AND ihi_max_eff.effectivity_date >= ihi.effectivity_date
			ORDER BY
				effectivity_date DESC

		END
		ELSE
		BEGIN

			SELECT
				ihi.in_house_id AS in_house_id,
				ihi.sysid_member AS sysid_member,
				ihi.effectivity_date AS effectivity_date,
				ihi.certificate_no AS certificate_no,
				ihi.premium_amount_due AS premium_amount_due,
				ihi.maximum_amount AS maximum_amount,
				ihi.remarks AS remarks,
				ihi.is_precluded AS is_precluded,
				'true' AS is_current_hospitalization
			FROM
				lms.in_house_hospitalization_information AS ihi
			INNER JOIN
			(
				SELECT
					inner_ihi.sysid_member AS sysid_member,
					MAX(inner_ihi.effectivity_date) AS effectivity_date
				FROM
					lms.in_house_hospitalization_information AS inner_ihi
				INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = inner_ihi.sysid_member
				GROUP BY
					inner_ihi.sysid_member
				
			) AS ihi_max_eff ON ihi_max_eff.sysid_member = ihi.sysid_member AND ihi_max_eff.effectivity_date >= ihi.effectivity_date
			UNION ALL
			SELECT
				ihi.in_house_id AS in_house_id,
				ihi.sysid_member AS sysid_member,
				ihi.effectivity_date AS effectivity_date,
				ihi.certificate_no AS certificate_no,
				ihi.premium_amount_due AS premium_amount_due,
				ihi.maximum_amount AS maximum_amount,
				ihi.remarks AS remarks,
				ihi.is_precluded AS is_precluded,
				'false' AS is_current_hospitalization
			FROM
				lms.in_house_hospitalization_information AS ihi
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = ihi.sysid_member
			WHERE 
				(NOT ihi.in_house_id IN (SELECT
												ihi.in_house_id AS in_house_id
											FROM
												lms.in_house_hospitalization_information AS ihi
											INNER JOIN
											(
												SELECT
													inner_ihi.sysid_member AS sysid_member,
													MAX(inner_ihi.effectivity_date) AS effectivity_date
												FROM
													lms.in_house_hospitalization_information AS inner_ihi
												INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS sml_list ON sml_list.var_str = inner_ihi.sysid_member
												GROUP BY
													inner_ihi.sysid_member
												
											) AS ihi_max_eff ON ihi_max_eff.sysid_member = ihi.sysid_member AND ihi_max_eff.effectivity_date >= ihi.effectivity_date))
			ORDER BY
				effectivity_date DESC
		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query an in-house hospitalization information', 'In-House Hospitalization Information'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberListInHouseHospitalizationInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountForCertificateNoInHouseHospitalizationInformation" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountForCertificateNoInHouseHospitalizationInformation')
   DROP PROCEDURE lms.SelectCountForCertificateNoInHouseHospitalizationInformation
GO

CREATE PROCEDURE lms.SelectCountForCertificateNoInHouseHospitalizationInformation

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT 
			COUNT(ihi.in_house_id) 
		FROM 
			lms.in_house_hospitalization_information AS ihi
		WHERE
			(YEAR(ihi.effectivity_date) = YEAR(lms.GetMemberServicesEffectivityDate(GETDATE()))) AND
			(MONTH(ihi.effectivity_date) = MONTH(lms.GetMemberServicesEffectivityDate(GETDATE())))

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query an in-house hospitalization information', 'In-House Hospitalization Information'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountForCertificateNoInHouseHospitalizationInformation TO db_lmsusers
GO
-------------------------------------------------------------

-- ##############################################END TABLE "in_house_hospitalization_information" OBJECTS######################################################





-- ################################################TABLE "hospitalization_include_coverage" OBJECTS######################################################
-- verifies if the hospitalization_include_coverage table exists
IF OBJECT_ID('lms.hospitalization_include_coverage', 'U') IS NOT NULL
	DROP TABLE lms.hospitalization_include_coverage
GO

CREATE TABLE lms.hospitalization_include_coverage 			
(
	sysid_includecoverage varchar (50) NOT NULL		
		CONSTRAINT Hospitalization_Include_Coverage_SysID_IncludeCoverage_PK PRIMARY KEY (sysid_includecoverage)
		CONSTRAINT Hospitalization_Include_Coverage_SysID_IncludeCoverage_CK CHECK (sysid_includecoverage LIKE 'SYSHIC%'),
	include_coverage_description varchar (100) NOT NULL
		CONSTRAINT Hospitalization_Include_Coverage_Include_Coverage_Description_UQ UNIQUE (include_coverage_description),

	is_marked_deleted bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Hospitalization_Include_Coverage_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Hospitalization_Include_Coverage_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Hospitalization_Include_Coverage_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the hospitalization_include_coverage table 
CREATE INDEX Hospitalization_Include_Coverage_SysID_IncludeCoverage_Index
	ON lms.hospitalization_include_coverage (sysid_includecoverage ASC)
GO
------------------------------------------------------------------

--verifies that the trigger "Hospitalization_Include_Coverage_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Hospitalization_Include_Coverage_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Include_Coverage_Trigger_Insert
GO

CREATE TRIGGER lms.Hospitalization_Include_Coverage_Trigger_Insert
	ON  lms.hospitalization_include_coverage
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_includecoverage varchar (50)
	DECLARE @include_coverage_description varchar (100)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@sysid_includecoverage = i.sysid_includecoverage,
		@include_coverage_description = i.include_coverage_description,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new hospitalization include coverage ' + 
							'[Include Coverage System ID: ' + ISNULL(@sysid_includecoverage, '') +
							'][Include Coverage Description: ' + ISNULL(@include_coverage_description, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Hospitalization_Include_Coverage_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Hospitalization_Include_Coverage_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Include_Coverage_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Hospitalization_Include_Coverage_Trigger_Instead_Update
	ON  lms.hospitalization_include_coverage
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_includecoverage varchar (50)
	DECLARE @include_coverage_description varchar (100)
	DECLARE @is_marked_deleted bit

	DECLARE @edited_by varchar(50)

	DECLARE @include_coverage_description_b varchar (100)

	DECLARE @has_update bit

	DECLARE hospitalization_include_coverage_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_includecoverage, i.include_coverage_description, i.is_marked_deleted, i.edited_by
				FROM INSERTED AS i

	OPEN hospitalization_include_coverage_update_cursor

	FETCH NEXT FROM hospitalization_include_coverage_update_cursor
		INTO @sysid_includecoverage, @include_coverage_description, @is_marked_deleted, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		IF (@is_marked_deleted = 0)
		BEGIN	

			SELECT 
				@include_coverage_description_b = hic.include_coverage_description
			FROM 
				lms.hospitalization_include_coverage AS hic
			WHERE
				(hic.sysid_includecoverage = @sysid_includecoverage)

			SET @transaction_done = ''
			SET @has_update = 0

			IF (NOT ISNULL(@include_coverage_description COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@include_coverage_description_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Include Coverage Description Before: ' + ISNULL(@include_coverage_description_b, '') + ']' +
															'[Include Coverage Description After: ' + ISNULL(@include_coverage_description, '') + ']'
				SET @has_update = 1
			END

			IF (@has_update = 1)
			BEGIN

				UPDATE lms.hospitalization_include_coverage SET
					include_coverage_description = @include_coverage_description,

					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					sysid_includecoverage = @sysid_includecoverage

				SET @transaction_done = 'UPDATED a hospitalization include coverage ' + 
										'[Include Coverage System ID: ' + ISNULL(@sysid_includecoverage, '') +
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
				UPDATE lms.hospitalization_include_coverage SET
					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					(sysid_includecoverage = @sysid_includecoverage)

			END

		END
				
		FETCH NEXT FROM hospitalization_include_coverage_update_cursor
			INTO @sysid_includecoverage, @include_coverage_description, @is_marked_deleted, @edited_by

	END

	CLOSE hospitalization_include_coverage_update_cursor
	DEALLOCATE hospitalization_include_coverage_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Hospitalization_Include_Coverage_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Hospitalization_Include_Coverage_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Include_Coverage_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Hospitalization_Include_Coverage_Trigger_Instead_Delete
	ON  lms.hospitalization_include_coverage
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_includecoverage varchar (50)
	DECLARE @include_coverage_description varchar (100)
	DECLARE @is_marked_deleted bit

	DECLARE @deleted_by varchar(50)

	DECLARE hospitalization_include_coverage_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.sysid_includecoverage, d.include_coverage_description, d.is_marked_deleted, d.edited_by
				FROM DELETED AS d

	OPEN hospitalization_include_coverage_delete_cursor

	FETCH NEXT FROM hospitalization_include_coverage_delete_cursor
		INTO @sysid_includecoverage, @include_coverage_description, @is_marked_deleted, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF (@is_marked_deleted = 0)
		BEGIN

			UPDATE lms.hospitalization_include_coverage SET 
				is_marked_deleted = 1, 

				edited_on = GETDATE(), 
				edited_by = @deleted_by 
			WHERE 
				(sysid_includecoverage = @sysid_includecoverage)

			SET @transaction_done = 'MARK AS DELETED a hospitalization include coverage ' + 
									'[Include Coverage System ID: ' + ISNULL(@sysid_includecoverage, '') +
									'][Include Coverage Description: ' + ISNULL(@include_coverage_description, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
			END
					
			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		END
				
		FETCH NEXT FROM hospitalization_include_coverage_delete_cursor
			INTO @sysid_includecoverage, @include_coverage_description, @is_marked_deleted, @deleted_by

	END

	CLOSE hospitalization_include_coverage_delete_cursor
	DEALLOCATE hospitalization_include_coverage_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertHospitalizationIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertHospitalizationIncludeCoverage')
   DROP PROCEDURE lms.InsertHospitalizationIncludeCoverage
GO

CREATE PROCEDURE lms.InsertHospitalizationIncludeCoverage
	
	@sysid_includecoverage varchar (50) = '',
	@include_coverage_description varchar (100) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsDescriptionHospitalizationIncludeCover(@sysid_includecoverage, @include_coverage_description) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.hospitalization_include_coverage
		(
			sysid_includecoverage,
			include_coverage_description,

			created_by
		)
		VALUES
		(
			@sysid_includecoverage,
			@include_coverage_description,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a hospitalization include coverage', 'Hospitalization Include Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertHospitalizationIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateHospitalizationIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateHospitalizationIncludeCoverage')
   DROP PROCEDURE lms.UpdateHospitalizationIncludeCoverage
GO

CREATE PROCEDURE lms.UpdateHospitalizationIncludeCoverage
	
	@sysid_includecoverage varchar (50) = '',
	@include_coverage_description varchar (100) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsDescriptionHospitalizationIncludeCover(@sysid_includecoverage, @include_coverage_description) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.hospitalization_include_coverage SET
			include_coverage_description = @include_coverage_description,

			edited_by = @edited_by
		WHERE
			(sysid_includecoverage = @sysid_includecoverage)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a hospitalization include coverage', 'Hospitalization Include Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateHospitalizationIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteHospitalizationIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteHospitalizationIncludeCoverage')
   DROP PROCEDURE lms.DeleteHospitalizationIncludeCoverage
GO

CREATE PROCEDURE lms.DeleteHospitalizationIncludeCoverage
	
	@sysid_includecoverage varchar (50) = '',

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT sysid_includecoverage FROM lms.hospitalization_include_coverage WHERE sysid_includecoverage = @sysid_includecoverage)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.hospitalization_include_coverage SET
				edited_by = @deleted_by
			WHERE
				(sysid_includecoverage = @sysid_includecoverage)

			DELETE FROM lms.hospitalization_include_coverage WHERE (sysid_includecoverage = @sysid_includecoverage)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a hospitalization include coverage', 'Hospitalization Include Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteHospitalizationIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectHospitalizationIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectHospitalizationIncludeCoverage')
   DROP PROCEDURE lms.SelectHospitalizationIncludeCoverage
GO

CREATE PROCEDURE lms.SelectHospitalizationIncludeCoverage

	@query_string varchar (50) = '',
	@include_marked_deleted bit = 0,

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'

		IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(00)
		BEGIN

			SELECT
				hic.sysid_includecoverage AS sysid_includecoverage,
				hic.include_coverage_description AS include_coverage_description,
				hic.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_include_coverage AS hic
			WHERE
				((hic.include_coverage_description LIKE @query_string) OR 
				((REPLACE(hic.include_coverage_description, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(hic.is_marked_deleted = 0)

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(01)
		BEGIN

			SELECT
				hic.sysid_includecoverage AS sysid_includecoverage,
				hic.include_coverage_description AS include_coverage_description,
				hic.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_include_coverage AS hic
			WHERE
				((hic.include_coverage_description LIKE @query_string) OR 
				((REPLACE(hic.include_coverage_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')))

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(10)
		BEGIN

			SELECT
				hic.sysid_includecoverage AS sysid_includecoverage,
				hic.include_coverage_description AS include_coverage_description,
				hic.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_include_coverage AS hic
			WHERE
				(hic.is_marked_deleted = 0)
	
		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(11)
		BEGIN
	
			SELECT
				hic.sysid_includecoverage AS sysid_includecoverage,
				hic.include_coverage_description AS include_coverage_description,
				hic.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_include_coverage AS hic

		END	
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization include coverage', 'Hospitalization Include Coverage'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectHospitalizationIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountHospitalizationIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountHospitalizationIncludeCoverage')
   DROP PROCEDURE lms.SelectCountHospitalizationIncludeCoverage
GO

CREATE PROCEDURE lms.SelectCountHospitalizationIncludeCoverage

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT COUNT(hic.sysid_includecoverage) FROM lms.hospitalization_include_coverage AS hic

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization include coverage', 'Hospitalization Include Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountHospitalizationIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDHospitalizationIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDHospitalizationIncludeCoverage')
   DROP PROCEDURE lms.IsExistsSysIDHospitalizationIncludeCoverage
GO

CREATE PROCEDURE lms.IsExistsSysIDHospitalizationIncludeCoverage

	@sysid_includecoverage varchar (50) = '',
	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsSysIDHospitalizationIncludeCover(@sysid_includecoverage)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization include coverage', 'Hospitalization Include Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDHospitalizationIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsDescriptionHospitalizationIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsDescriptionHospitalizationIncludeCoverage')
   DROP PROCEDURE lms.IsExistsDescriptionHospitalizationIncludeCoverage
GO

CREATE PROCEDURE lms.IsExistsDescriptionHospitalizationIncludeCoverage

	@sysid_includecoverage varchar (50) = '',
	@include_coverage_description varchar (100) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsDescriptionHospitalizationIncludeCover(@sysid_includecoverage, @include_coverage_description)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization include coverage', 'Hospitalization Include Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsDescriptionHospitalizationIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDHospitalizationIncludeCover" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDHospitalizationIncludeCover') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDHospitalizationIncludeCover
GO

CREATE FUNCTION lms.IsExistsSysIDHospitalizationIncludeCover
(	
	@sysid_includecoverage varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_includecoverage FROM lms.hospitalization_include_coverage WHERE sysid_includecoverage = @sysid_includecoverage)
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsExistsDescriptionHospitalizationIncludeCover" function already exist
IF OBJECT_ID (N'lms.IsExistsDescriptionHospitalizationIncludeCover') IS NOT NULL
   DROP FUNCTION lms.IsExistsDescriptionHospitalizationIncludeCover
GO

CREATE FUNCTION lms.IsExistsDescriptionHospitalizationIncludeCover
(	
	@sysid_includecoverage varchar (50) = '',
	@include_coverage_description varchar (100) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_includecoverage FROM lms.hospitalization_include_coverage WHERE (NOT sysid_includecoverage = @sysid_includecoverage) AND						
						(REPLACE(include_coverage_description, ' ', '') LIKE REPLACE(@include_coverage_description, ' ', '')))
								
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------


-- ################################################END TABLE "hospitalization_include_coverage" OBJECTS######################################################





-- ################################################TABLE "hospitalization_exclude_coverage" OBJECTS######################################################
-- verifies if the hospitalization_exclude_coverage table exists
IF OBJECT_ID('lms.hospitalization_exclude_coverage', 'U') IS NOT NULL
	DROP TABLE lms.hospitalization_exclude_coverage
GO

CREATE TABLE lms.hospitalization_exclude_coverage 			
(
	sysid_excludecoverage varchar (50) NOT NULL		
		CONSTRAINT Hospitalization_Exclude_Coverage_SysID_ExcludeCoverage_PK PRIMARY KEY (sysid_excludecoverage)
		CONSTRAINT Hospitalization_Exclude_Coverage_SysID_ExcludeCoverage_CK CHECK (sysid_excludecoverage LIKE 'SYSHEC%'),
	exclude_coverage_description varchar (100) NOT NULL
		CONSTRAINT Hospitalization_Exclude_Coverage_Exclude_Coverage_Description_UQ UNIQUE (exclude_coverage_description),

	is_marked_deleted bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Hospitalization_Exclude_Coverage_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Hospitalization_Exclude_Coverage_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Hospitalization_Exclude_Coverage_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the hospitalization_exclude_coverage table 
CREATE INDEX Hospitalization_Exclude_Coverage_SysID_ExcludeCoverage_Index
	ON lms.hospitalization_exclude_coverage (sysid_excludecoverage ASC)
GO
------------------------------------------------------------------

--verifies that the trigger "Hospitalization_Exclude_Coverage_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Hospitalization_Exclude_Coverage_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Exclude_Coverage_Trigger_Insert
GO

CREATE TRIGGER lms.Hospitalization_Exclude_Coverage_Trigger_Insert
	ON  lms.hospitalization_exclude_coverage
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_excludecoverage varchar (50)
	DECLARE @exclude_coverage_description varchar (100)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@sysid_excludecoverage = i.sysid_excludecoverage,
		@exclude_coverage_description = i.exclude_coverage_description,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new hospitalization exclude coverage ' + 
							'[Exclude Coverage System ID: ' + ISNULL(@sysid_excludecoverage, '') +
							'][Exclude Coverage Description: ' + ISNULL(@exclude_coverage_description, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "Hospitalization_Exclude_Coverage_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Hospitalization_Exclude_Coverage_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Exclude_Coverage_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Hospitalization_Exclude_Coverage_Trigger_Instead_Update
	ON  lms.hospitalization_exclude_coverage
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_excludecoverage varchar (50)
	DECLARE @exclude_coverage_description varchar (100)
	DECLARE @is_marked_deleted bit

	DECLARE @edited_by varchar(50)

	DECLARE @exclude_coverage_description_b varchar (100)

	DECLARE @has_update bit

	DECLARE hospitalization_exclude_coverage_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_excludecoverage, i.exclude_coverage_description, i.is_marked_deleted, i.edited_by
				FROM INSERTED AS i

	OPEN hospitalization_exclude_coverage_update_cursor

	FETCH NEXT FROM hospitalization_exclude_coverage_update_cursor
		INTO @sysid_excludecoverage, @exclude_coverage_description, @is_marked_deleted, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		IF (@is_marked_deleted = 0)
		BEGIN	

			SELECT 
				@exclude_coverage_description_b = hec.exclude_coverage_description
			FROM 
				lms.hospitalization_exclude_coverage AS hec
			WHERE
				(hec.sysid_excludecoverage = @sysid_excludecoverage)

			SET @transaction_done = ''
			SET @has_update = 0

			IF (NOT ISNULL(@exclude_coverage_description COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@exclude_coverage_description_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Exclude Coverage Description Before: ' + ISNULL(@exclude_coverage_description_b, '') + ']' +
															'[Exclude Coverage Description After: ' + ISNULL(@exclude_coverage_description, '') + ']'
				SET @has_update = 1
			END

			IF (@has_update = 1)
			BEGIN

				UPDATE lms.hospitalization_exclude_coverage SET
					exclude_coverage_description = @exclude_coverage_description,

					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					sysid_excludecoverage = @sysid_excludecoverage

				SET @transaction_done = 'UPDATED a hospitalization exclude coverage ' + 
										'[Exclude Coverage System ID: ' + ISNULL(@sysid_excludecoverage, '') +
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
				UPDATE lms.hospitalization_exclude_coverage SET
					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					(sysid_excludecoverage = @sysid_excludecoverage)

			END

		END
				
		FETCH NEXT FROM hospitalization_exclude_coverage_update_cursor
			INTO @sysid_excludecoverage, @exclude_coverage_description, @is_marked_deleted, @edited_by

	END

	CLOSE hospitalization_exclude_coverage_update_cursor
	DEALLOCATE hospitalization_exclude_coverage_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "Hospitalization_Exclude_Coverage_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Hospitalization_Exclude_Coverage_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Exclude_Coverage_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Hospitalization_Exclude_Coverage_Trigger_Instead_Delete
	ON  lms.hospitalization_exclude_coverage
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_excludecoverage varchar (50)
	DECLARE @exclude_coverage_description varchar (100)
	DECLARE @is_marked_deleted bit

	DECLARE @deleted_by varchar(50)

	DECLARE hospitalization_exclude_coverage_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.sysid_excludecoverage, d.exclude_coverage_description, d.is_marked_deleted, d.edited_by
				FROM DELETED AS d

	OPEN hospitalization_exclude_coverage_delete_cursor

	FETCH NEXT FROM hospitalization_exclude_coverage_delete_cursor
		INTO @sysid_excludecoverage, @exclude_coverage_description, @is_marked_deleted, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF (@is_marked_deleted = 0)
		BEGIN

			UPDATE lms.hospitalization_exclude_coverage SET 
				is_marked_deleted = 1, 

				edited_on = GETDATE(), 
				edited_by = @deleted_by 
			WHERE 
				(sysid_excludecoverage = @sysid_excludecoverage)

			SET @transaction_done = 'MARK AS DELETED a hospitalization exclude coverage ' + 
									'[Exclude Coverage System ID: ' + ISNULL(@sysid_excludecoverage, '') +
									'][Exclude Coverage Description: ' + ISNULL(@exclude_coverage_description, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
			END
					
			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		END
				
		FETCH NEXT FROM hospitalization_exclude_coverage_delete_cursor
			INTO @sysid_excludecoverage, @exclude_coverage_description, @is_marked_deleted, @deleted_by

	END

	CLOSE hospitalization_exclude_coverage_delete_cursor
	DEALLOCATE hospitalization_exclude_coverage_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertHospitalizationExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertHospitalizationExcludeCoverage')
   DROP PROCEDURE lms.InsertHospitalizationExcludeCoverage
GO

CREATE PROCEDURE lms.InsertHospitalizationExcludeCoverage
	
	@sysid_excludecoverage varchar (50) = '',
	@exclude_coverage_description varchar (100) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsDescriptionHospitalizationExcludeCover(@sysid_excludecoverage, @exclude_coverage_description) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.hospitalization_exclude_coverage
		(
			sysid_excludecoverage,
			exclude_coverage_description,

			created_by
		)
		VALUES
		(
			@sysid_excludecoverage,
			@exclude_coverage_description,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a hospitalization exclude coverage', 'Hospitalization Exclude Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertHospitalizationExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateHospitalizationExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateHospitalizationExcludeCoverage')
   DROP PROCEDURE lms.UpdateHospitalizationExcludeCoverage
GO

CREATE PROCEDURE lms.UpdateHospitalizationExcludeCoverage
	
	@sysid_excludecoverage varchar (50) = '',
	@exclude_coverage_description varchar (100) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsDescriptionHospitalizationExcludeCover(@sysid_excludecoverage, @exclude_coverage_description) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.hospitalization_exclude_coverage SET
			exclude_coverage_description = @exclude_coverage_description,

			edited_by = @edited_by
		WHERE
			(sysid_excludecoverage = @sysid_excludecoverage)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a hospitalization exclude coverage', 'Hospitalization Exclude Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateHospitalizationExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteHospitalizationExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteHospitalizationExcludeCoverage')
   DROP PROCEDURE lms.DeleteHospitalizationExcludeCoverage
GO

CREATE PROCEDURE lms.DeleteHospitalizationExcludeCoverage
	
	@sysid_excludecoverage varchar (50) = '',

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT sysid_excludecoverage FROM lms.hospitalization_exclude_coverage WHERE sysid_excludecoverage = @sysid_excludecoverage)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.hospitalization_exclude_coverage SET
				edited_by = @deleted_by
			WHERE
				(sysid_excludecoverage = @sysid_excludecoverage)

			DELETE FROM lms.hospitalization_exclude_coverage WHERE (sysid_excludecoverage = @sysid_excludecoverage)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a hospitalization exclude coverage', 'Hospitalization Exclude Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteHospitalizationExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectHospitalizationExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectHospitalizationExcludeCoverage')
   DROP PROCEDURE lms.SelectHospitalizationExcludeCoverage
GO

CREATE PROCEDURE lms.SelectHospitalizationExcludeCoverage

	@query_string varchar (50) = '',
	@include_marked_deleted bit = 0,

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT @query_string = '%' + RTRIM(LTRIM(@query_string)) + '%'

		IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(00)
		BEGIN

			SELECT
				hec.sysid_excludecoverage AS sysid_excludecoverage,
				hec.exclude_coverage_description AS exclude_coverage_description,
				hec.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_exclude_coverage AS hec
			WHERE
				((hec.exclude_coverage_description LIKE @query_string) OR 
				((REPLACE(hec.exclude_coverage_description, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				(hec.is_marked_deleted = 0)

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(01)
		BEGIN

			SELECT
				hec.sysid_excludecoverage AS sysid_excludecoverage,
				hec.exclude_coverage_description AS exclude_coverage_description,
				hec.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_exclude_coverage AS hec
			WHERE
				((hec.exclude_coverage_description LIKE @query_string) OR 
				((REPLACE(hec.exclude_coverage_description, ' ', '')) LIKE REPLACE(@query_string, ' ', '')))

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 0)	--(10)
		BEGIN

			SELECT
				hec.sysid_excludecoverage AS sysid_excludecoverage,
				hec.exclude_coverage_description AS exclude_coverage_description,
				hec.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_exclude_coverage AS hec
			WHERE
				(hec.is_marked_deleted = 0)
	
		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND (@include_marked_deleted = 1)	--(11)
		BEGIN
	
			SELECT
				hec.sysid_excludecoverage AS sysid_excludecoverage,
				hec.exclude_coverage_description AS exclude_coverage_description,
				hec.is_marked_deleted AS is_marked_deleted
			FROM
				lms.hospitalization_exclude_coverage AS hec

		END	
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization exclude coverage', 'Hospitalization Exclude Coverage'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectHospitalizationExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountHospitalizationExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountHospitalizationExcludeCoverage')
   DROP PROCEDURE lms.SelectCountHospitalizationExcludeCoverage
GO

CREATE PROCEDURE lms.SelectCountHospitalizationExcludeCoverage

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT COUNT(hec.sysid_excludecoverage) FROM lms.hospitalization_exclude_coverage AS hec

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization exclude coverage', 'Hospitalization Exclude Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountHospitalizationExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDHospitalizationExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDHospitalizationExcludeCoverage')
   DROP PROCEDURE lms.IsExistsSysIDHospitalizationExcludeCoverage
GO

CREATE PROCEDURE lms.IsExistsSysIDHospitalizationExcludeCoverage

	@sysid_excludecoverage varchar (50) = '',
	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsSysIDHospitalizationExcludeCover(@sysid_excludecoverage)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization exclude coverage', 'Hospitalization Exclude Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDHospitalizationExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsDescriptionHospitalizationExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsDescriptionHospitalizationExcludeCoverage')
   DROP PROCEDURE lms.IsExistsDescriptionHospitalizationExcludeCoverage
GO

CREATE PROCEDURE lms.IsExistsDescriptionHospitalizationExcludeCoverage

	@sysid_excludecoverage varchar (50) = '',
	@exclude_coverage_description varchar (100) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsDescriptionHospitalizationExcludeCover(@sysid_excludecoverage, @exclude_coverage_description)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization exclude coverage', 'Hospitalization Exclude Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsDescriptionHospitalizationExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDHospitalizationExcludeCover" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDHospitalizationExcludeCover') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDHospitalizationExcludeCover
GO

CREATE FUNCTION lms.IsExistsSysIDHospitalizationExcludeCover
(	
	@sysid_excludecoverage varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_excludecoverage FROM lms.hospitalization_exclude_coverage WHERE sysid_excludecoverage = @sysid_excludecoverage)
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- verifies if the "IsExistsDescriptionHospitalizationExcludeCover" function already exist
IF OBJECT_ID (N'lms.IsExistsDescriptionHospitalizationExcludeCover') IS NOT NULL
   DROP FUNCTION lms.IsExistsDescriptionHospitalizationExcludeCover
GO

CREATE FUNCTION lms.IsExistsDescriptionHospitalizationExcludeCover
(	
	@sysid_excludecoverage varchar (50) = '',
	@exclude_coverage_description varchar (100) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_excludecoverage FROM lms.hospitalization_exclude_coverage WHERE (NOT sysid_excludecoverage = @sysid_excludecoverage) AND						
						(REPLACE(exclude_coverage_description, ' ', '') LIKE REPLACE(@exclude_coverage_description, ' ', '')))
								
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ##############################################END TABLE "hospitalization_exclude_coverage" OBJECTS######################################################





-- ################################################TABLE "in_house_hospitalization_debit" OBJECTS######################################################
-- verifies if the in_house_hospitalization_debit table exists
IF OBJECT_ID('lms.in_house_hospitalization_debit', 'U') IS NOT NULL
	DROP TABLE lms.in_house_hospitalization_debit
GO

CREATE TABLE lms.in_house_hospitalization_debit 			
(
	sysid_inhousedebit varchar (50) NOT NULL
		CONSTRAINT In_House_Hospitalization_Debit_SysID_InHouseDebit_PK PRIMARY KEY (sysid_inhousedebit)
		CONSTRAINT In_House_Hospitalization_Debit_SysID_InHouseDebit_CK CHECK (sysid_inhousedebit LIKE 'SYSIHD%'),
	sysid_member varchar (50) NOT NULL
		CONSTRAINT In_House_Hospitalization_Debit_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	reflected_date datetime NOT NULL 
		CONSTRAINT In_House_Hospitalization_Debit_Reflected_Date_CK CHECK (CONVERT(varchar, reflected_date, 109) LIKE '%12:00:00:000AM'),
	net_assistance_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	hospital_name varchar (100) NOT NULL,
	cause_of_admission varchar (MAX) NOT NULL,
	date_from datetime NOT NULL 
		CONSTRAINT In_House_Hospitalization_Debit_Date_From_CK CHECK (CONVERT(varchar, date_from, 109) LIKE '%12:00:00:000AM'),
	date_to datetime NOT NULL 
		CONSTRAINT In_House_Hospitalization_Debit_Date_To_CK CHECK (CONVERT(varchar, date_to, 109) LIKE '%11:59:59:000PM'),
	remarks varchar (MAX) NULL,
	is_marked_deleted bit NOT NULL DEFAULT (0),

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT In_House_Hospitalization_Debit_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT In_House_Hospitalization_Debit_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT In_House_Hospitalization_Debit_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the in_house_hospitalization_debit table 
CREATE INDEX In_House_Hospitalization_Debit_SysID_Regular_Index
	ON lms.in_house_hospitalization_debit (sysid_inhousedebit DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "In_House_Hospitalization_Debit_Trigger_Insert" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Debit_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Debit_Trigger_Insert
GO

CREATE TRIGGER lms.In_House_Hospitalization_Debit_Trigger_Insert
	ON  lms.in_house_hospitalization_debit
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @net_assistance_amount decimal (15, 2)
	DECLARE @hospital_name varchar (100)
	DECLARE @cause_of_admission varchar (MAX)
	DECLARE @date_from datetime
	DECLARE @date_to datetime
	DECLARE @remarks varchar (MAX)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@sysid_inhousedebit = i.sysid_inhousedebit,
		@sysid_member = i.sysid_member,
		@reflected_date = i.reflected_date,
		@net_assistance_amount = i.net_assistance_amount,
		@hospital_name = i.hospital_name,
		@cause_of_admission = i.cause_of_admission,
		@date_from = i.date_from,
		@date_to = i.date_to,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new in-house hospitalization debit ' + 
							'[In-House Debit System ID: ' + ISNULL(@sysid_inhousedebit, '') +
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
							'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
							'][Net Assistance Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @net_assistance_amount), 1), '0.00') +
							'][Hospital Name: ' + ISNULL(@hospital_name, '') +
							'][Cause of Admission: ' + ISNULL(@cause_of_admission, '') +
							'][Admission Date From: ' + ISNULL(CONVERT(varchar, @date_from, 101), '') +
							'][Admission Date To: ' + ISNULL(CONVERT(varchar, @date_to, 101), '') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "In_House_Hospitalization_Debit_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Debit_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Debit_Trigger_Instead_Update
GO

CREATE TRIGGER lms.In_House_Hospitalization_Debit_Trigger_Instead_Update
	ON  lms.in_house_hospitalization_debit
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @net_assistance_amount decimal (15, 2)
	DECLARE @hospital_name varchar (100)
	DECLARE @cause_of_admission varchar (MAX)
	DECLARE @date_from datetime
	DECLARE @date_to datetime
	DECLARE @remarks varchar (MAX)
	DECLARE @is_marked_deleted bit

	DECLARE @edited_by varchar(50)

	DECLARE @reflected_date_b datetime
	DECLARE @net_assistance_amount_b decimal (15, 2)
	DECLARE @hospital_name_b varchar (100)
	DECLARE @cause_of_admission_b varchar (MAX)
	DECLARE @date_from_b datetime
	DECLARE @date_to_b datetime
	DECLARE @remarks_b varchar (MAX)

	DECLARE @has_update bit

	DECLARE in_house_hospitalization_debit_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.sysid_inhousedebit, i.sysid_member, i.reflected_date, i.net_assistance_amount, i.hospital_name, i.cause_of_admission,
					i.date_from, i.date_to, i.remarks, i.is_marked_deleted, i.edited_by
				FROM INSERTED AS i

	OPEN in_house_hospitalization_debit_update_cursor

	FETCH NEXT FROM in_house_hospitalization_debit_update_cursor
		INTO @sysid_inhousedebit, @sysid_member, @reflected_date, @net_assistance_amount, @hospital_name, @cause_of_admission,
					@date_from, @date_to, @remarks, @is_marked_deleted, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		IF (@is_marked_deleted = 0)
		BEGIN	

			SELECT 
				@reflected_date_b = ihd.reflected_date,
				@net_assistance_amount_b = ihd.net_assistance_amount,
				@hospital_name_b = ihd.hospital_name,
				@cause_of_admission_b = ihd.cause_of_admission,
				@date_from_b = ihd.date_from,
				@date_to_b = ihd.date_to,
				@remarks_b = ihd.remarks
			FROM 
				lms.in_house_hospitalization_debit AS ihd
			WHERE
				(ihd.sysid_inhousedebit = @sysid_inhousedebit)

			SET @transaction_done = ''
			SET @has_update = 0

			IF (NOT ISNULL(CONVERT(varchar, @reflected_date, 101), '') = ISNULL(CONVERT(varchar, @reflected_date_b, 101), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Reflected Date Before: ' + ISNULL(CONVERT(varchar, @reflected_date_b, 101), '') + ']' +
															'[Reflected Date After: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @net_assistance_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @net_assistance_amount_b), 1), '0.00'))
			BEGIN
				SET @transaction_done = @transaction_done + '[Net Assistance Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @net_assistance_amount_b), 1), '0.00') + ']' +
															'[Net Assistance Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @net_assistance_amount), 1), '0.00') + ']'
				SET @has_update = 1	
			END

			IF (NOT ISNULL(@hospital_name COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@hospital_name_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Hospital Name Before: ' + ISNULL(@hospital_name_b, '') + ']' +
															'[Hospital Name After: ' + ISNULL(@hospital_name, '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(@cause_of_admission COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@cause_of_admission_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Cause of Admission Before: ' + ISNULL(@cause_of_admission_b, '') + ']' +
															'[Cause of Admission After: ' + ISNULL(@cause_of_admission, '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @date_from, 101), '') = ISNULL(CONVERT(varchar, @date_from_b, 101), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Admission Date From Before: ' + ISNULL(CONVERT(varchar, @date_from_b, 101), '') + ']' +
															'[Admission Date From After: ' + ISNULL(CONVERT(varchar, @date_from, 101), '') + ']'
				SET @has_update = 1
			END

			IF (NOT ISNULL(CONVERT(varchar, @date_to, 101), '') = ISNULL(CONVERT(varchar, @date_to_b, 101), ''))
			BEGIN
				SET @transaction_done = @transaction_done + '[Admission Date To Before: ' + ISNULL(CONVERT(varchar, @date_to_b, 101), '') + ']' +
															'[Admission Date To After: ' + ISNULL(CONVERT(varchar, @date_to, 101), '') + ']'
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

				UPDATE lms.in_house_hospitalization_debit SET
					reflected_date = @reflected_date,
					net_assistance_amount = @net_assistance_amount,
					hospital_name = @hospital_name,
					cause_of_admission = @cause_of_admission,
					date_from = @date_from,
					date_to = @date_to,
					remarks = @remarks,

					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					sysid_inhousedebit = @sysid_inhousedebit

				SET @transaction_done = 'UPDATED an in-house hospitalization debit ' + 
										'[In-House Debit System ID: ' + ISNULL(@sysid_inhousedebit, '') +
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
				UPDATE lms.in_house_hospitalization_debit SET
					edited_on = GETDATE(),
					edited_by = @edited_by
				WHERE
					(sysid_inhousedebit = @sysid_inhousedebit)

			END

		END
				
		FETCH NEXT FROM in_house_hospitalization_debit_update_cursor
			INTO @sysid_inhousedebit, @sysid_member, @reflected_date, @net_assistance_amount, @hospital_name, @cause_of_admission,
						@date_from, @date_to, @remarks, @is_marked_deleted, @edited_by

	END

	CLOSE in_house_hospitalization_debit_update_cursor
	DEALLOCATE in_house_hospitalization_debit_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "In_House_Hospitalization_Debit_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Debit_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Debit_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.In_House_Hospitalization_Debit_Trigger_Instead_Delete
	ON  lms.in_house_hospitalization_debit
	INSTEAD OF DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @net_assistance_amount decimal (15, 2)
	DECLARE @hospital_name varchar (100)
	DECLARE @cause_of_admission varchar (MAX)
	DECLARE @date_from datetime
	DECLARE @date_to datetime
	DECLARE @remarks varchar (MAX)
	DECLARE @is_marked_deleted bit

	DECLARE @deleted_by varchar(50)

	DECLARE in_house_hospitalization_debit_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.sysid_inhousedebit, d.sysid_member, d.reflected_date, d.net_assistance_amount, d.hospital_name, d.cause_of_admission,
					d.date_from, d.date_to, d.remarks, d.is_marked_deleted, d.edited_by
				FROM DELETED AS d

	OPEN in_house_hospitalization_debit_delete_cursor

	FETCH NEXT FROM in_house_hospitalization_debit_delete_cursor
		INTO @sysid_inhousedebit, @sysid_member, @reflected_date, @net_assistance_amount, @hospital_name, @cause_of_admission,
					@date_from, @date_to, @remarks, @is_marked_deleted, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		IF (@is_marked_deleted = 0)
		BEGIN

			--delete the in_house_include_coverage
			UPDATE lms.in_house_include_coverage SET edited_on = GETDATE(), edited_by = @deleted_by WHERE sysid_inhousedebit = @sysid_inhousedebit
			DELETE lms.in_house_include_coverage WHERE sysid_inhousedebit = @sysid_inhousedebit

			--delete the in_house_exclude_coverage
			UPDATE lms.in_house_exclude_coverage SET edited_on = GETDATE(), edited_by = @deleted_by WHERE sysid_inhousedebit = @sysid_inhousedebit
			DELETE lms.in_house_exclude_coverage WHERE sysid_inhousedebit = @sysid_inhousedebit

			UPDATE lms.in_house_hospitalization_debit SET 
				is_marked_deleted = 1, 

				edited_on = GETDATE(), 
				edited_by = @deleted_by 
			WHERE 
				(sysid_inhousedebit = @sysid_inhousedebit)

			SET @transaction_done = 'MARK AS DELETED an in-house hospitalization debit ' + 
									'[In-House Debit System ID: ' + ISNULL(@sysid_inhousedebit, '') +
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
									'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
									'][Net Assistance Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @net_assistance_amount), 1), '0.00') +
									'][Hospital Name: ' + ISNULL(@hospital_name, '') +
									'][Cause of Admission: ' + ISNULL(@cause_of_admission, '') +
									'][Admission Date From: ' + ISNULL(CONVERT(varchar, @date_from, 101), '') +
									'][Admission Date To: ' + ISNULL(CONVERT(varchar, @date_to, 101), '') +
									'][Remarks: ' + ISNULL(@remarks, '') +
									']'

			IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
			BEGIN
				SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
			END
					
			EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		END
				
		FETCH NEXT FROM in_house_hospitalization_debit_delete_cursor
			INTO @sysid_inhousedebit, @sysid_member, @reflected_date, @net_assistance_amount, @hospital_name, @cause_of_admission,
						@date_from, @date_to, @remarks, @is_marked_deleted, @deleted_by

	END

	CLOSE in_house_hospitalization_debit_delete_cursor
	DEALLOCATE in_house_hospitalization_debit_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertInHouseHospitalizationDebit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertInHouseHospitalizationDebit')
   DROP PROCEDURE lms.InsertInHouseHospitalizationDebit
GO

CREATE PROCEDURE lms.InsertInHouseHospitalizationDebit
	
	@sysid_inhousedebit varchar (50) = '',
	@sysid_member varchar (50) = '',
	@reflected_date datetime,
	@net_assistance_amount decimal (15, 2) = 0.00,
	@hospital_name varchar (100) = '',
	@cause_of_admission varchar (MAX) = '',
	@date_from datetime,
	@date_to datetime,
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1))
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.in_house_hospitalization_debit
		(
			sysid_inhousedebit,
			sysid_member,
			reflected_date,
			net_assistance_amount,
			hospital_name,
			cause_of_admission,
			date_from,
			date_to,
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_inhousedebit,
			@sysid_member,
			@reflected_date,
			@net_assistance_amount,
			@hospital_name,
			@cause_of_admission,
			@date_from,
			@date_to,
			@remarks,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert an in-house hospitalization debit', 'In-House Hospitalization Debit'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertInHouseHospitalizationDebit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateInHouseHospitalizationDebit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateInHouseHospitalizationDebit')
   DROP PROCEDURE lms.UpdateInHouseHospitalizationDebit
GO

CREATE PROCEDURE lms.UpdateInHouseHospitalizationDebit
	
	@sysid_inhousedebit varchar (50) = '',
	@reflected_date datetime,
	@net_assistance_amount decimal (15, 2) = 0.00,
	@hospital_name varchar (100) = '',
	@cause_of_admission varchar (MAX) = '',
	@date_from datetime,
	@date_to datetime,
	@remarks varchar (MAX) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByDisbursementVoucher(@sysid_inhousedebit) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.in_house_hospitalization_debit SET
			reflected_date = @reflected_date,
			net_assistance_amount = @net_assistance_amount,
			hospital_name = @hospital_name,
			cause_of_admission = @cause_of_admission,
			date_from = @date_from,
			date_to = @date_to,
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(sysid_inhousedebit = @sysid_inhousedebit)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update an in-house hospitalization debit', 'In-House Hospitalization Debit'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateInHouseHospitalizationDebit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteInHouseHospitalizationDebit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteInHouseHospitalizationDebit')
   DROP PROCEDURE lms.DeleteInHouseHospitalizationDebit
GO

CREATE PROCEDURE lms.DeleteInHouseHospitalizationDebit
	
	@sysid_inhousedebit varchar (50) = '',

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByDisbursementVoucher(@sysid_inhousedebit) = 0)
	BEGIN

		IF EXISTS (SELECT sysid_inhousedebit FROM lms.in_house_hospitalization_debit WHERE sysid_inhousedebit = @sysid_inhousedebit)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.in_house_hospitalization_debit SET
				edited_by = @deleted_by
			WHERE
				(sysid_inhousedebit = @sysid_inhousedebit)

			DELETE FROM lms.in_house_hospitalization_debit WHERE (sysid_inhousedebit = @sysid_inhousedebit)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete an in-house hospitalization debit', 'In-House Hospitalization Debit'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteInHouseHospitalizationDebit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberListInHouseHospitalizationDebit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberListInHouseHospitalizationDebit')
   DROP PROCEDURE lms.SelectBySysIDMemberListInHouseHospitalizationDebit
GO

CREATE PROCEDURE lms.SelectBySysIDMemberListInHouseHospitalizationDebit

	@sysid_member_list nvarchar (MAX) = '',
	@is_marked_deleted bit = 0,

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			ihd.sysid_inhousedebit AS sysid_inhousedebit,
			ihd.sysid_member AS sysid_member,
			ihd.reflected_date AS reflected_date,
			ihd.net_assistance_amount AS net_assistance_amount,
			ihd.hospital_name AS hospital_name,
			ihd.cause_of_admission AS cause_of_admission,
			ihd.date_from AS date_from,
			ihd.date_to AS date_to,
			ihd.remarks AS remarks,

			'true' AS is_record_locked
		FROM
			lms.in_house_hospitalization_debit AS ihd
		INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = ihd.sysid_member	
		INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_inhousedebit = ihd.sysid_inhousedebit
		WHERE
			(NOT dvi.sysid_inhousedebit IS NULL) AND
			(ihd.is_marked_deleted = @is_marked_deleted)
		UNION ALL
		SELECT
			ihd.sysid_inhousedebit AS sysid_inhousedebit,
			ihd.sysid_member AS sysid_member,
			ihd.reflected_date AS reflected_date,
			ihd.net_assistance_amount AS net_assistance_amount,
			ihd.hospital_name AS hospital_name,
			ihd.cause_of_admission AS cause_of_admission,
			ihd.date_from AS date_from,
			ihd.date_to AS date_to,
			ihd.remarks AS remarks,

			'false' AS is_record_locked
		FROM
			lms.in_house_hospitalization_debit AS ihd
		INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = ihd.sysid_member	
		LEFT JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_inhousedebit = ihd.sysid_inhousedebit
		WHERE
			(dvi.sysid_inhousedebit IS NULL) AND
			(ihd.is_marked_deleted = @is_marked_deleted)
		ORDER BY
			ihd.sysid_member ASC, ihd.reflected_date DESC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query an in-house hospitalization debit', 'In-House Hospitalization Debit'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberListInHouseHospitalizationDebit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDInHouseHospitalizationDebit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDInHouseHospitalizationDebit')
   DROP PROCEDURE lms.SelectBySysIDInHouseHospitalizationDebit
GO

CREATE PROCEDURE lms.SelectBySysIDInHouseHospitalizationDebit

	@sysid_inhousedebit varchar (50) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT
			ihd.sysid_inhousedebit AS sysid_inhousedebit,
			ihd.sysid_member AS sysid_member,
			ihd.reflected_date AS reflected_date,
			ihd.net_assistance_amount AS net_assistance_amount,
			ihd.hospital_name AS hospital_name,
			ihd.cause_of_admission AS cause_of_admission,
			ihd.date_from AS date_from,
			ihd.date_to AS date_to,
			ihd.remarks AS remarks,

			'true' AS is_record_locked
		FROM
			lms.in_house_hospitalization_debit AS ihd	
		INNER JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_inhousedebit = ihd.sysid_inhousedebit
		WHERE
			(NOT dvi.sysid_inhousedebit IS NULL) AND
			(ihd.sysid_inhousedebit = @sysid_inhousedebit)
		UNION ALL
		SELECT
			ihd.sysid_inhousedebit AS sysid_inhousedebit,
			ihd.sysid_member AS sysid_member,
			ihd.reflected_date AS reflected_date,
			ihd.net_assistance_amount AS net_assistance_amount,
			ihd.hospital_name AS hospital_name,
			ihd.cause_of_admission AS cause_of_admission,
			ihd.date_from AS date_from,
			ihd.date_to AS date_to,
			ihd.remarks AS remarks,

			'false' AS is_record_locked
		FROM
			lms.in_house_hospitalization_debit AS ihd	
		LEFT JOIN lms.disbursement_voucher_information AS dvi ON dvi.sysid_inhousedebit = ihd.sysid_inhousedebit
		WHERE
			(dvi.sysid_inhousedebit IS NULL) AND
			(ihd.sysid_inhousedebit = @sysid_inhousedebit)
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query an in-house hospitalization debit', 'In-House Hospitalization Debit'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDInHouseHospitalizationDebit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectCountInHouseHospitalizationDebit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectCountInHouseHospitalizationDebit')
   DROP PROCEDURE lms.SelectCountInHouseHospitalizationDebit
GO

CREATE PROCEDURE lms.SelectCountInHouseHospitalizationDebit

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT COUNT(ihd.sysid_inhousedebit) FROM lms.in_house_hospitalization_debit AS ihd

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query an in-house hospitalization debit', 'In-House Hospitalization Debit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectCountInHouseHospitalizationDebit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDInHouseHospitalizationDebit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDInHouseHospitalizationDebit')
   DROP PROCEDURE lms.IsExistsSysIDInHouseHospitalizationDebit
GO

CREATE PROCEDURE lms.IsExistsSysIDInHouseHospitalizationDebit

	@sysid_inhousedebit varchar (50) = '',
	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsSysIDInHouseHospitalizationDeb(@sysid_inhousedebit)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query an in-house hospitalization debit', 'In-House Hospitalization Debit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDInHouseHospitalizationDebit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDInHouseHospitalizationDeb" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDInHouseHospitalizationDeb') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDInHouseHospitalizationDeb
GO

CREATE FUNCTION lms.IsExistsSysIDInHouseHospitalizationDeb
(	
	@sysid_inhousedebit varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_inhousedebit FROM lms.in_house_hospitalization_debit WHERE sysid_inhousedebit = @sysid_inhousedebit)
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ##############################################END TABLE "in_house_hospitalization_debit" OBJECTS######################################################







-- ################################################TABLE "in_house_include_coverage" OBJECTS######################################################
-- verifies if the in_house_include_coverage table exists
IF OBJECT_ID('lms.in_house_include_coverage', 'U') IS NOT NULL
	DROP TABLE lms.in_house_include_coverage
GO

CREATE TABLE lms.in_house_include_coverage 			
(
	include_coverage_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT In_House_Include_Coverage_Include_Coverage_ID_PK PRIMARY KEY (include_coverage_id),
	sysid_inhousedebit varchar (50) NOT NULL
		CONSTRAINT In_House_Include_Coverage_SysID_InHouseDebit_FK FOREIGN KEY REFERENCES lms.in_house_hospitalization_debit(sysid_inhousedebit) ON UPDATE NO ACTION
		CONSTRAINT In_House_Include_Coverage_SysID_InHouseDebit_UQ UNIQUE (sysid_inhousedebit, sysid_includecoverage),
	sysid_includecoverage varchar (50) NOT NULL		
		CONSTRAINT In_House_Include_Coverage_SysID_IncludeCoverage_FK FOREIGN KEY REFERENCES lms.hospitalization_include_coverage(sysid_includecoverage) ON UPDATE NO ACTION
		CONSTRAINT In_House_Include_Coverage_SysID_IncludeCoverage_UQ UNIQUE (sysid_includecoverage, sysid_inhousedebit),
	include_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	remarks varchar (50) NULL,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT In_House_Include_Coverage_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT In_House_Include_Coverage_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT In_House_Include_Coverage_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the in_house_include_coverage table 
CREATE INDEX In_House_Include_Coverage_Include_Coverage_ID_Index
	ON lms.in_house_include_coverage (include_coverage_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "In_House_Include_Coverage_Trigger_Insert" already exist
IF OBJECT_ID ('lms.In_House_Include_Coverage_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Include_Coverage_Trigger_Insert
GO

CREATE TRIGGER lms.In_House_Include_Coverage_Trigger_Insert
	ON  lms.in_house_include_coverage
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @include_coverage_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_includecoverage varchar (50)
	DECLARE @include_amount decimal (15, 2)
	DECLARE @remarks varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@include_coverage_id = i.include_coverage_id,
		@sysid_inhousedebit = i.sysid_inhousedebit,
		@sysid_includecoverage = i.sysid_includecoverage,
		@include_amount = i.include_amount,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new in-house include coverage ' + 
							'[Include Coverage ID: ' + ISNULL(CONVERT(varchar, @include_coverage_id), '') +
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
														WHERE
															(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
													WHERE
														(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Hospital Name: ' + ISNULL((SELECT
																ihd.hospital_name
															FROM
																lms.in_house_hospitalization_debit AS ihd
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Admission Date From: ' + ISNULL((SELECT
																	CONVERT(varchar, ihd.date_from, 101)
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Admission Date To: ' + ISNULL((SELECT
																	CONVERT(varchar, ihd.date_to, 101)
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Include Coverage Description: ' + ISNULL((SELECT
																				hic.include_coverage_description
																			FROM
																				lms.hospitalization_include_coverage AS hic
																			WHERE
																				(hic.sysid_includecoverage = @sysid_includecoverage)), '') +	
							'][Include Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @include_amount), 1), '0.00') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "In_House_Include_Coverage_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.In_House_Include_Coverage_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Include_Coverage_Trigger_Instead_Update
GO

CREATE TRIGGER lms.In_House_Include_Coverage_Trigger_Instead_Update
	ON  lms.in_house_include_coverage
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @include_coverage_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_includecoverage varchar (50)
	DECLARE @include_amount decimal (15, 2)
	DECLARE @remarks varchar (50)

	DECLARE @edited_by varchar(50)

	DECLARE @sysid_includecoverage_b varchar (50)
	DECLARE @include_amount_b decimal (15, 2)
	DECLARE @remarks_b varchar (50)

	DECLARE @has_update bit

	DECLARE in_house_include_coverage_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.include_coverage_id, i.sysid_inhousedebit, i.sysid_includecoverage, i.include_amount, i.remarks, i.edited_by
				FROM INSERTED AS i

	OPEN in_house_include_coverage_update_cursor

	FETCH NEXT FROM in_house_include_coverage_update_cursor
		INTO @include_coverage_id, @sysid_inhousedebit, @sysid_includecoverage, @include_amount, @remarks, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		SELECT 
			@sysid_includecoverage_b = iin.sysid_includecoverage,
			@include_amount_b = iin.include_amount,
			@remarks_b = iin.remarks
		FROM 
			lms.in_house_include_coverage AS iin
		WHERE
			(iin.include_coverage_id = @include_coverage_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(@sysid_includecoverage COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_includecoverage_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Include Coverage Description Before: ' + ISNULL((SELECT
																												hic.include_coverage_description
																											FROM
																												lms.hospitalization_include_coverage AS hic
																											WHERE
																												(hic.sysid_includecoverage = @sysid_includecoverage_b)), '') + ']' +
														'[Include Coverage Description After: ' + ISNULL((SELECT
																												hic.include_coverage_description
																											FROM
																												lms.hospitalization_include_coverage AS hic
																											WHERE
																												(hic.sysid_includecoverage = @sysid_includecoverage)), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Include Coverage Description After: ' + ISNULL((SELECT
																												hic.include_coverage_description
																											FROM
																												lms.hospitalization_include_coverage AS hic
																											WHERE
																												(hic.sysid_includecoverage = @sysid_includecoverage)), '') + ']'
		END
		

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @include_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @include_amount_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Include Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @include_amount_b), 1), '0.00') + ']' +
														'[Include Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @include_amount), 1), '0.00') + ']'
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

			UPDATE lms.in_house_include_coverage SET
				sysid_includecoverage = @sysid_includecoverage,
				include_amount = @include_amount,
				remarks = @remarks,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				include_coverage_id = @include_coverage_id

			SET @transaction_done = 'UPDATED an in-house include coverage ' + 
									'[Include Coverage ID: ' + ISNULL(CONVERT(varchar, @include_coverage_id), '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Hospital Name: ' + ISNULL((SELECT
																		ihd.hospital_name
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Admission Date From: ' + ISNULL((SELECT
																			CONVERT(varchar, ihd.date_from, 101)
																		FROM
																			lms.in_house_hospitalization_debit AS ihd
																		WHERE
																			(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Admission Date To: ' + ISNULL((SELECT
																			CONVERT(varchar, ihd.date_to, 101)
																		FROM
																			lms.in_house_hospitalization_debit AS ihd
																		WHERE
																			(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
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
			UPDATE lms.in_house_include_coverage SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(include_coverage_id = @include_coverage_id)

		END
				
		FETCH NEXT FROM in_house_include_coverage_update_cursor
			INTO @include_coverage_id, @sysid_inhousedebit, @sysid_includecoverage, @include_amount, @remarks, @edited_by

	END

	CLOSE in_house_include_coverage_update_cursor
	DEALLOCATE in_house_include_coverage_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "In_House_Include_Coverage_Trigger_Delete" already exist
IF OBJECT_ID ('lms.In_House_Include_Coverage_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Include_Coverage_Trigger_Delete
GO

CREATE TRIGGER lms.In_House_Include_Coverage_Trigger_Delete
	ON  lms.in_house_include_coverage
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @include_coverage_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_includecoverage varchar (50)
	DECLARE @include_amount decimal (15, 2)
	DECLARE @remarks varchar (50)

	DECLARE @deleted_by varchar(50)

	DECLARE in_house_include_coverage_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.include_coverage_id, d.sysid_inhousedebit, d.sysid_includecoverage, d.include_amount, d.remarks, d.edited_by
				FROM DELETED AS d

	OPEN in_house_include_coverage_delete_cursor

	FETCH NEXT FROM in_house_include_coverage_delete_cursor
		INTO @include_coverage_id, @sysid_inhousedebit, @sysid_includecoverage, @include_amount, @remarks, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		SET @transaction_done = 'DELETED an in-house include coverage ' + 
								'[Include Coverage ID: ' + ISNULL(CONVERT(varchar, @include_coverage_id), '') +
								'][Member ID: ' + ISNULL((SELECT
																mbi.member_id
															FROM
																lms.member_information AS mbi
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Name: ' + ISNULL((SELECT 
															pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
														FROM
															lms.person_information AS pri
														INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
														INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
														WHERE
															(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Hospital Name: ' + ISNULL((SELECT
																	ihd.hospital_name
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Admission Date From: ' + ISNULL((SELECT
																		CONVERT(varchar, ihd.date_from, 101)
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Admission Date To: ' + ISNULL((SELECT
																		CONVERT(varchar, ihd.date_to, 101)
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Include Coverage Description: ' + ISNULL((SELECT
																					hic.include_coverage_description
																				FROM
																					lms.hospitalization_include_coverage AS hic
																				WHERE
																					(hic.sysid_includecoverage = @sysid_includecoverage)), '') +	
								'][Include Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @include_amount), 1), '0.00') +
								'][Remarks: ' + ISNULL(@remarks, '') +
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
				
		FETCH NEXT FROM in_house_include_coverage_delete_cursor
			INTO @include_coverage_id, @sysid_inhousedebit, @sysid_includecoverage, @include_amount, @remarks, @deleted_by

	END

	CLOSE in_house_include_coverage_delete_cursor
	DEALLOCATE in_house_include_coverage_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertInHouseIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertInHouseIncludeCoverage')
   DROP PROCEDURE lms.InsertInHouseIncludeCoverage
GO

CREATE PROCEDURE lms.InsertInHouseIncludeCoverage
	
	@sysid_inhousedebit varchar (50) = '',
	@sysid_includecoverage varchar (50) = '',
	@include_amount decimal (15, 2) = 0.00,
	@remarks varchar (50) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsCoverageInHouseIncludeCover(DEFAULT, @sysid_inhousedebit, @sysid_includecoverage) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.in_house_include_coverage
		(
			sysid_inhousedebit,
			sysid_includecoverage,
			include_amount,
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_inhousedebit,
			@sysid_includecoverage,
			@include_amount,
			@remarks,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert an in-house include coverage', 'In-House Include Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertInHouseIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateInHouseIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateInHouseIncludeCoverage')
   DROP PROCEDURE lms.UpdateInHouseIncludeCoverage
GO

CREATE PROCEDURE lms.UpdateInHouseIncludeCoverage
	
	@include_coverage_id bigint = 0,
	@sysid_includecoverage varchar (50) = '',
	@include_amount decimal (15, 2) = 0.00,
	@remarks varchar (50) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsCoverageInHouseIncludeCover(@include_coverage_id, 
											(SELECT sysid_inhousedebit FROM lms.in_house_include_coverage WHERE include_coverage_id = @include_coverage_id), 
											@sysid_includecoverage) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.in_house_include_coverage SET
			sysid_includecoverage = @sysid_includecoverage,
			include_amount = @include_amount,
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(include_coverage_id = @include_coverage_id)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update an in-house include coverage', 'In-House Include Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateInHouseIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteInHouseIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteInHouseIncludeCoverage')
   DROP PROCEDURE lms.DeleteInHouseIncludeCoverage
GO

CREATE PROCEDURE lms.DeleteInHouseIncludeCoverage
	
	@include_coverage_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT include_coverage_id FROM lms.in_house_include_coverage WHERE include_coverage_id = @include_coverage_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.in_house_include_coverage SET
				edited_by = @deleted_by
			WHERE
				(include_coverage_id = @include_coverage_id)

			DELETE FROM lms.in_house_include_coverage WHERE (include_coverage_id = @include_coverage_id)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete an in-house include coverage', 'In-House Include Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteInHouseIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDInHouseDebitListInHouseIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDInHouseDebitListInHouseIncludeCoverage')
   DROP PROCEDURE lms.SelectBySysIDInHouseDebitListInHouseIncludeCoverage
GO

CREATE PROCEDURE lms.SelectBySysIDInHouseDebitListInHouseIncludeCoverage

	@sysid_inhousedebit_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT
			iin.include_coverage_id AS include_coverage_id,
			iin.sysid_inhousedebit AS sysid_inhousedebit,
			iin.include_amount AS include_amount,
			iin.remarks AS remarks,

			--iin.sysid_includecoverage
			hic.sysid_includecoverage AS sysid_includecoverage,
			hic.include_coverage_description AS include_coverage_description
		FROM
			lms.in_house_include_coverage AS iin
		INNER JOIN lms.IterateListToTable (@sysid_inhousedebit_list, ',') AS sihd_list ON sihd_list.var_str = iin.sysid_inhousedebit
		INNER JOIN lms.hospitalization_include_coverage AS hic ON hic.sysid_includecoverage = iin.sysid_includecoverage
		ORDER BY
			iin.sysid_inhousedebit ASC, hic.include_coverage_description ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query an in-house include coverage', 'In-House Include Coverage'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDInHouseDebitListInHouseIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsCoverageInHouseIncludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsCoverageInHouseIncludeCoverage')
   DROP PROCEDURE lms.IsExistsCoverageInHouseIncludeCoverage
GO

CREATE PROCEDURE lms.IsExistsCoverageInHouseIncludeCoverage

	@include_coverage_id bigint = 0,
	@sysid_inhousedebit varchar (50) = '',
	@sysid_includecoverage varchar (50) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsCoverageInHouseIncludeCover(@include_coverage_id, @sysid_inhousedebit, @sysid_includecoverage)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query an in-house include coverage', 'In-House Include Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsCoverageInHouseIncludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsCoverageInHouseIncludeCover" function already exist
IF OBJECT_ID (N'lms.IsExistsCoverageInHouseIncludeCover') IS NOT NULL
   DROP FUNCTION lms.IsExistsCoverageInHouseIncludeCover
GO

CREATE FUNCTION lms.IsExistsCoverageInHouseIncludeCover
(	
	@include_coverage_id bigint = 0,
	@sysid_inhousedebit varchar (50) = '',
	@sysid_includecoverage varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT 
					include_coverage_id 
				FROM 
					lms.in_house_include_coverage
				WHERE 
					(NOT include_coverage_id = @include_coverage_id) AND
					(sysid_inhousedebit = @sysid_inhousedebit) AND
					(sysid_includecoverage = @sysid_includecoverage))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ##############################################END TABLE "in_house_include_coverage" OBJECTS######################################################







-- ################################################TABLE "in_house_exclude_coverage" OBJECTS######################################################
-- verifies if the in_house_exclude_coverage table exists
IF OBJECT_ID('lms.in_house_exclude_coverage', 'U') IS NOT NULL
	DROP TABLE lms.in_house_exclude_coverage
GO

CREATE TABLE lms.in_house_exclude_coverage 			
(
	exclude_coverage_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT In_House_Exclude_Coverage_Exclude_Coverage_ID_PK PRIMARY KEY (exclude_coverage_id),
	sysid_inhousedebit varchar (50) NOT NULL
		CONSTRAINT In_House_Exclude_Coverage_SysID_InHouseDebit_FK FOREIGN KEY REFERENCES lms.in_house_hospitalization_debit(sysid_inhousedebit) ON UPDATE NO ACTION
		CONSTRAINT In_House_Exclude_Coverage_SysID_InHouseDebit_UQ UNIQUE (sysid_inhousedebit, sysid_excludecoverage),
	sysid_excludecoverage varchar (50) NOT NULL		
		CONSTRAINT In_House_Exclude_Coverage_SysID_ExcludeCoverage_FK FOREIGN KEY REFERENCES lms.hospitalization_exclude_coverage(sysid_excludecoverage) ON UPDATE NO ACTION
		CONSTRAINT In_House_Exclude_Coverage_SysID_ExcludeCoverage_UQ UNIQUE (sysid_excludecoverage, sysid_inhousedebit),
	exclude_amount decimal (15, 2) NOT NULL DEFAULT (0.00),
	remarks varchar (50) NULL,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT In_House_Exclude_Coverage_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT In_House_Exclude_Coverage_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT In_House_Exclude_Coverage_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the in_house_exclude_coverage table 
CREATE INDEX In_House_Exclude_Coverage_Exclude_Coverage_ID_Index
	ON lms.in_house_exclude_coverage (exclude_coverage_id DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "In_House_Exclude_Coverage_Trigger_Insert" already exist
IF OBJECT_ID ('lms.In_House_Exclude_Coverage_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Exclude_Coverage_Trigger_Insert
GO

CREATE TRIGGER lms.In_House_Exclude_Coverage_Trigger_Insert
	ON  lms.in_house_exclude_coverage
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @exclude_coverage_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_excludecoverage varchar (50)
	DECLARE @exclude_amount decimal (15, 2)
	DECLARE @remarks varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@exclude_coverage_id = i.exclude_coverage_id,
		@sysid_inhousedebit = i.sysid_inhousedebit,
		@sysid_excludecoverage = i.sysid_excludecoverage,
		@exclude_amount = i.exclude_amount,
		@remarks = i.remarks,
		
		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new in-house exclude coverage ' + 
							'[Exclude Coverage ID: ' + ISNULL(CONVERT(varchar, @exclude_coverage_id), '') +
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
														WHERE
															(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
													WHERE
														(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Hospital Name: ' + ISNULL((SELECT
																ihd.hospital_name
															FROM
																lms.in_house_hospitalization_debit AS ihd
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Admission Date From: ' + ISNULL((SELECT
																	CONVERT(varchar, ihd.date_from, 101)
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Admission Date To: ' + ISNULL((SELECT
																	CONVERT(varchar, ihd.date_to, 101)
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Exclude Coverage Description: ' + ISNULL((SELECT
																				hec.exclude_coverage_description
																			FROM
																				lms.hospitalization_exclude_coverage AS hec
																			WHERE
																				(hec.sysid_excludecoverage = @sysid_excludecoverage)), '') +	
							'][Exclude Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @exclude_amount), 1), '0.00') +
							'][Remarks: ' + ISNULL(@remarks, '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done

GO
-----------------------------------------------------------------

-- verifies that the trigger "In_House_Exclude_Coverage_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.In_House_Exclude_Coverage_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Exclude_Coverage_Trigger_Instead_Update
GO

CREATE TRIGGER lms.In_House_Exclude_Coverage_Trigger_Instead_Update
	ON  lms.in_house_exclude_coverage
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @exclude_coverage_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_excludecoverage varchar (50)
	DECLARE @exclude_amount decimal (15, 2)
	DECLARE @remarks varchar (50)

	DECLARE @edited_by varchar(50)

	DECLARE @sysid_excludecoverage_b varchar (50)
	DECLARE @exclude_amount_b decimal (15, 2)
	DECLARE @remarks_b varchar (50)

	DECLARE @has_update bit

	DECLARE in_house_exclude_coverage_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.exclude_coverage_id, i.sysid_inhousedebit, i.sysid_excludecoverage, i.exclude_amount, i.remarks, i.edited_by
				FROM INSERTED AS i

	OPEN in_house_exclude_coverage_update_cursor

	FETCH NEXT FROM in_house_exclude_coverage_update_cursor
		INTO @exclude_coverage_id, @sysid_inhousedebit, @sysid_excludecoverage, @exclude_amount, @remarks, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN	

		SELECT 
			@sysid_excludecoverage_b = iex.sysid_excludecoverage,
			@exclude_amount_b = iex.exclude_amount,
			@remarks_b = iex.remarks
		FROM 
			lms.in_house_exclude_coverage AS iex
		WHERE
			(iex.exclude_coverage_id = @exclude_coverage_id)

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(@sysid_excludecoverage COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_excludecoverage_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Exclude Coverage Description Before: ' + ISNULL((SELECT
																												hec.exclude_coverage_description
																											FROM
																												lms.hospitalization_exclude_coverage AS hec
																											WHERE
																												(hec.sysid_excludecoverage = @sysid_excludecoverage_b)), '') + ']' +
														'[Exclude Coverage Description After: ' + ISNULL((SELECT
																												hec.exclude_coverage_description
																											FROM
																												lms.hospitalization_exclude_coverage AS hec
																											WHERE
																												(hec.sysid_excludecoverage = @sysid_excludecoverage)), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Exclude Coverage Description: ' + ISNULL((SELECT
																										hec.exclude_coverage_description
																									FROM
																										lms.hospitalization_exclude_coverage AS hec
																									WHERE
																										(hec.sysid_excludecoverage = @sysid_excludecoverage)), '') + ']'
		END
		

		IF (NOT ISNULL(CONVERT(varchar, CONVERT(money, @exclude_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @exclude_amount_b), 1), '0.00'))
		BEGIN
			SET @transaction_done = @transaction_done + '[Exclude Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @exclude_amount), 1), '0.00') + ']' +
														'[Exclude Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @exclude_amount), 1), '0.00') + ']'
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

			UPDATE lms.in_house_exclude_coverage SET
				sysid_excludecoverage = @sysid_excludecoverage,
				exclude_amount = @exclude_amount,
				remarks = @remarks,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				exclude_coverage_id = @exclude_coverage_id

			SET @transaction_done = 'UPDATED an in-house exclude coverage ' + 
									'[Exclude Coverage ID: ' + ISNULL(CONVERT(varchar, @exclude_coverage_id), '') +
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Hospital Name: ' + ISNULL((SELECT
																		ihd.hospital_name
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Admission Date From: ' + ISNULL((SELECT
																			CONVERT(varchar, ihd.date_from, 101)
																		FROM
																			lms.in_house_hospitalization_debit AS ihd
																		WHERE
																			(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Admission Date To: ' + ISNULL((SELECT
																			CONVERT(varchar, ihd.date_to, 101)
																		FROM
																			lms.in_house_hospitalization_debit AS ihd
																		WHERE
																			(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
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
			UPDATE lms.in_house_exclude_coverage SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				(exclude_coverage_id = @exclude_coverage_id)

		END
				
		FETCH NEXT FROM in_house_exclude_coverage_update_cursor
			INTO @exclude_coverage_id, @sysid_inhousedebit, @sysid_excludecoverage, @exclude_amount, @remarks, @edited_by

	END

	CLOSE in_house_exclude_coverage_update_cursor
	DEALLOCATE in_house_exclude_coverage_update_cursor

GO
---------------------------------------------------------------------

-- verifies that the trigger "In_House_Exclude_Coverage_Trigger_Delete" already exist
IF OBJECT_ID ('lms.In_House_Exclude_Coverage_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Exclude_Coverage_Trigger_Delete
GO

CREATE TRIGGER lms.In_House_Exclude_Coverage_Trigger_Delete
	ON  lms.in_house_exclude_coverage
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar(MAX)
	DECLARE @transaction_done varchar(MAX)
	
	DECLARE @exclude_coverage_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @sysid_excludecoverage varchar (50)
	DECLARE @exclude_amount decimal (15, 2)
	DECLARE @remarks varchar (50)

	DECLARE @deleted_by varchar(50)

	DECLARE in_house_exclude_coverage_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.exclude_coverage_id, d.sysid_inhousedebit, d.sysid_excludecoverage, d.exclude_amount, d.remarks, d.edited_by
				FROM DELETED AS d

	OPEN in_house_exclude_coverage_delete_cursor

	FETCH NEXT FROM in_house_exclude_coverage_delete_cursor
		INTO @exclude_coverage_id, @sysid_inhousedebit, @sysid_excludecoverage, @exclude_amount, @remarks, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN		

		SET @transaction_done = 'DELETED an in-house exclude coverage ' + 
								'[Exclude Coverage ID: ' + ISNULL(CONVERT(varchar, @exclude_coverage_id), '') +
								'][Member ID: ' + ISNULL((SELECT
																mbi.member_id
															FROM
																lms.member_information AS mbi
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Name: ' + ISNULL((SELECT 
															pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
														FROM
															lms.person_information AS pri
														INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
														INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
														WHERE
															(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Hospital Name: ' + ISNULL((SELECT
																	ihd.hospital_name
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Admission Date From: ' + ISNULL((SELECT
																		CONVERT(varchar, ihd.date_from, 101)
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Admission Date To: ' + ISNULL((SELECT
																		CONVERT(varchar, ihd.date_to, 101)
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Exclude Coverage Description: ' + ISNULL((SELECT
																					hec.exclude_coverage_description
																				FROM
																					lms.hospitalization_exclude_coverage AS hec
																				WHERE
																					(hec.sysid_excludecoverage = @sysid_excludecoverage)), '') +	
								'][Exclude Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @exclude_amount), 1), '0.00') +
								'][Remarks: ' + ISNULL(@remarks, '') +
								']'
		
		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done
				
		FETCH NEXT FROM in_house_exclude_coverage_delete_cursor
			INTO @exclude_coverage_id, @sysid_inhousedebit, @sysid_excludecoverage, @exclude_amount, @remarks, @deleted_by

	END

	CLOSE in_house_exclude_coverage_delete_cursor
	DEALLOCATE in_house_exclude_coverage_delete_cursor
	
GO
-------------------------------------------------------------------------

-- verifies if the procedure "InsertInHouseExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertInHouseExcludeCoverage')
   DROP PROCEDURE lms.InsertInHouseExcludeCoverage
GO

CREATE PROCEDURE lms.InsertInHouseExcludeCoverage
	
	@sysid_inhousedebit varchar (50) = '',
	@sysid_excludecoverage varchar (50) = '',
	@exclude_amount decimal (15, 2) = 0.00,
	@remarks varchar (50) = '',

	@network_information varchar(MAX) = '',
	@created_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@created_by) = 1)) AND
		(lms.IsExistsCoverageInHouseExcludeCover(DEFAULT, @sysid_inhousedebit, @sysid_excludecoverage) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.in_house_exclude_coverage
		(
			sysid_inhousedebit,
			sysid_excludecoverage,
			exclude_amount,
			remarks,

			created_by
		)
		VALUES
		(
			@sysid_inhousedebit,
			@sysid_excludecoverage,
			@exclude_amount,
			@remarks,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert an in-house exclude coverage', 'In-House Include Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertInHouseExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateInHouseExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateInHouseExcludeCoverage')
   DROP PROCEDURE lms.UpdateInHouseExcludeCoverage
GO

CREATE PROCEDURE lms.UpdateInHouseExcludeCoverage
	
	@exclude_coverage_id bigint = 0,
	@sysid_excludecoverage varchar (50) = '',
	@exclude_amount decimal (15, 2) = 0.00,
	@remarks varchar (50) = '',

	@network_information varchar(MAX) = '',
	@edited_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsExistsCoverageInHouseExcludeCover(@exclude_coverage_id, 
											(SELECT sysid_inhousedebit FROM lms.in_house_exclude_coverage WHERE exclude_coverage_id = @exclude_coverage_id), 
											@sysid_excludecoverage) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.in_house_exclude_coverage SET
			sysid_excludecoverage = @sysid_excludecoverage,
			exclude_amount = @exclude_amount,
			remarks = @remarks,

			edited_by = @edited_by
		WHERE
			(exclude_coverage_id = @exclude_coverage_id)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update an in-house exclude coverage', 'In-House Exclude Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateInHouseExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteInHouseExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteInHouseExcludeCoverage')
   DROP PROCEDURE lms.DeleteInHouseExcludeCoverage
GO

CREATE PROCEDURE lms.DeleteInHouseExcludeCoverage
	
	@exclude_coverage_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT exclude_coverage_id FROM lms.in_house_exclude_coverage WHERE exclude_coverage_id = @exclude_coverage_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.in_house_exclude_coverage SET
				edited_by = @deleted_by
			WHERE
				(exclude_coverage_id = @exclude_coverage_id)

			DELETE FROM lms.in_house_exclude_coverage WHERE (exclude_coverage_id = @exclude_coverage_id)

		END

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete an in-house exclude coverage', 'In-House Exclude Coverage'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteInHouseExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDInHouseDebitListInHouseExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDInHouseDebitListInHouseExcludeCoverage')
   DROP PROCEDURE lms.SelectBySysIDInHouseDebitListInHouseExcludeCoverage
GO

CREATE PROCEDURE lms.SelectBySysIDInHouseDebitListInHouseExcludeCoverage

	@sysid_inhousedebit_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN

		SELECT
			iex.exclude_coverage_id AS exclude_coverage_id,
			iex.sysid_inhousedebit AS sysid_inhousedebit,
			iex.exclude_amount AS exclude_amount,
			iex.remarks AS remarks,

			--iex.sysid_excludecoverage
			hec.sysid_excludecoverage AS sysid_excludecoverage,
			hec.exclude_coverage_description AS exclude_coverage_description
		FROM
			lms.in_house_exclude_coverage AS iex
		INNER JOIN lms.IterateListToTable (@sysid_inhousedebit_list, ',') AS sihd_list ON sihd_list.var_str = iex.sysid_inhousedebit
		INNER JOIN lms.hospitalization_exclude_coverage AS hec ON hec.sysid_excludecoverage = iex.sysid_excludecoverage
		ORDER BY
			iex.sysid_inhousedebit ASC, hec.exclude_coverage_description ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query an in-house exclude coverage', 'In-House Exclude Coverage'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDInHouseDebitListInHouseExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsCoverageInHouseExcludeCoverage" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsCoverageInHouseExcludeCoverage')
   DROP PROCEDURE lms.IsExistsCoverageInHouseExcludeCoverage
GO

CREATE PROCEDURE lms.IsExistsCoverageInHouseExcludeCoverage

	@exclude_coverage_id bigint = 0,
	@sysid_inhousedebit varchar (50) = '',
	@sysid_excludecoverage varchar (50) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsCoverageInHouseExcludeCover(@exclude_coverage_id, @sysid_inhousedebit, @sysid_excludecoverage)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query an in-house exclude coverage', 'In-House Exclude Coverage'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsCoverageInHouseExcludeCoverage TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsCoverageInHouseExcludeCover" function already exist
IF OBJECT_ID (N'lms.IsExistsCoverageInHouseExcludeCover') IS NOT NULL
   DROP FUNCTION lms.IsExistsCoverageInHouseExcludeCover
GO

CREATE FUNCTION lms.IsExistsCoverageInHouseExcludeCover
(	
	@exclude_coverage_id bigint = 0,
	@sysid_inhousedebit varchar (50) = '',
	@sysid_excludecoverage varchar (50) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT 
					exclude_coverage_id 
				FROM 
					lms.in_house_exclude_coverage
				WHERE 
					(NOT exclude_coverage_id = @exclude_coverage_id) AND
					(sysid_inhousedebit = @sysid_inhousedebit) AND
					(sysid_excludecoverage = @sysid_excludecoverage))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ##############################################END TABLE "in_house_exclude_coverage" OBJECTS######################################################






-- ##########################################TABLE "hospitalization_document" OBJECTS########################################################

-- verifies if the hospitalization_document table exists
IF OBJECT_ID('lms.hospitalization_document', 'U') IS NOT NULL
	DROP TABLE lms.hospitalization_document
GO

CREATE TABLE lms.hospitalization_document 			
(
	document_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Hospitalization_Document_Document_ID_PK PRIMARY KEY (document_id),
	sysid_inhousedebit varchar (50) NOT NULL 
		CONSTRAINT Hospitalization_Document_SysID_InHouseDebit_FK FOREIGN KEY REFERENCES lms.in_house_hospitalization_debit(sysid_inhousedebit) ON UPDATE NO ACTION
		CONSTRAINT Hospitalization_Document_SysID_InHouseDebit_UQ UNIQUE (sysid_inhousedebit, original_name),
	
	file_data varbinary (MAX) NOT NULL,
	original_name varchar (255) NOT NULL
		CONSTRAINT Hospitalization_Document_Original_Name_UQ UNIQUE (original_name, sysid_inhousedebit),
	document_information varchar (MAX) NULL,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Hospitalization_Document_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL
		CONSTRAINT Hospitalization_Document_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Hospitalization_Document_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
------------------------------------------------------------------

-- create an index of the hospitalization_document table 
CREATE INDEX Hospitalization_Document_Document_ID_Index
	ON lms.hospitalization_document (document_id ASC)
GO
------------------------------------------------------------------

--verifies that the trigger "Hospitalization_Document_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Hospitalization_Document_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Document_Trigger_Insert
GO

CREATE TRIGGER lms.Hospitalization_Document_Trigger_Insert
	ON  lms.hospitalization_document
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @document_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @original_name varchar (255)
	DECLARE @document_information varchar (MAX)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@document_id = i.document_id,
		@sysid_inhousedebit = i.sysid_inhousedebit,
		@original_name = i.original_name,
		@document_information = i.document_information,

		@created_by = i.created_by
	FROM INSERTED AS i
	
	SET @transaction_done = 'CREATED a hospitalization document ' + 
							'[Document ID: ' + ISNULL(CONVERT(varchar, @document_id), '') + 
							'][Member ID: ' + ISNULL((SELECT
															mbi.member_id
														FROM
															lms.member_information AS mbi
														INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
														WHERE
															(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Name: ' + ISNULL((SELECT 
														pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
													FROM
														lms.person_information AS pri
													INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
													INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
													WHERE
														(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Hospital Name: ' + ISNULL((SELECT
																ihd.hospital_name
															FROM
																lms.in_house_hospitalization_debit AS ihd
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Admission Date From: ' + ISNULL((SELECT
																	CONVERT(varchar, ihd.date_from, 101)
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
							'][Admission Date To: ' + ISNULL((SELECT
																	CONVERT(varchar, ihd.date_to, 101)
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
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

--verifies that the trigger "Hospitalization_Document_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Hospitalization_Document_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Hospitalization_Document_Trigger_Delete
GO

CREATE TRIGGER lms.Hospitalization_Document_Trigger_Delete
	ON  lms.hospitalization_document
	FOR DELETE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @document_id bigint
	DECLARE @sysid_inhousedebit varchar (50)
	DECLARE @original_name varchar (255)
	DECLARE @document_information varchar (MAX)

	DECLARE @deleted_by varchar (50)

	DECLARE hospitalization_document_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.document_id, d.sysid_inhousedebit, d.original_name, d.document_information, d.edited_by
			FROM 
				DELETED AS d

	OPEN hospitalization_document_delete_cursor

	FETCH NEXT FROM hospitalization_document_delete_cursor
		INTO @document_id, @sysid_inhousedebit, @original_name, @document_information, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		SET @transaction_done = 'DELETED a hospitalization document ' + 
								'[Document ID: ' + ISNULL(CONVERT(varchar, @document_id), '') + 
								'][Member ID: ' + ISNULL((SELECT
																mbi.member_id
															FROM
																lms.member_information AS mbi
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Name: ' + ISNULL((SELECT 
															pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
														FROM
															lms.person_information AS pri
														INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
														INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
														WHERE
															(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Hospital Name: ' + ISNULL((SELECT
																	ihd.hospital_name
																FROM
																	lms.in_house_hospitalization_debit AS ihd
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Admission Date From: ' + ISNULL((SELECT
																		CONVERT(varchar, ihd.date_from, 101)
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Admission Date To: ' + ISNULL((SELECT
																		CONVERT(varchar, ihd.date_to, 101)
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
								'][Original FileName: ' + ISNULL(@original_name, '') + 
								'][Document Information: ' + ISNULL(@document_information, '') +
								']'


		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done

		FETCH NEXT FROM hospitalization_document_delete_cursor
			INTO @document_id, @sysid_inhousedebit, @original_name, @document_information, @deleted_by

	END

	CLOSE hospitalization_document_delete_cursor
	DEALLOCATE hospitalization_document_delete_cursor

GO
----------------------------------------------------------------------

-- verifies if the procedure "InsertHospitalizationDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertHospitalizationDocument')
   DROP PROCEDURE lms.InsertHospitalizationDocument
GO

CREATE PROCEDURE lms.InsertHospitalizationDocument
	
	@sysid_inhousedebit varchar (50) = '',
	
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

		INSERT INTO lms.hospitalization_document
		(
			sysid_inhousedebit,
	
			file_data,
			original_name,
			document_information,

			created_by
		)
		VALUES
		(
			@sysid_inhousedebit,
	
			@file_data,
			@original_name,
			@document_information,

			@created_by
		)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Insert a hospitalization document', 'Hospitalization Document'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertHospitalizationDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateHospitalizationDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateHospitalizationDocument')
   DROP PROCEDURE lms.UpdateHospitalizationDocument
GO

CREATE PROCEDURE lms.UpdateHospitalizationDocument
	
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

		DECLARE @sysid_inhousedebit varchar (50)

		DECLARE @original_name_b varchar (255)
		DECLARE @document_information_b varchar (MAX)

		DECLARE @has_update bit
		
		SELECT 
			@sysid_inhousedebit = hpd.sysid_inhousedebit,
	
			@original_name_b = hpd.original_name,
			@document_information_b = hpd.document_information
		FROM
			lms.hospitalization_document AS hpd
		WHERE 
			hpd.document_id = @document_id

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

			UPDATE lms.hospitalization_document SET
				file_data = @file_data,
				original_name = @original_name,
				document_information = @document_information,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				document_id = @document_id

			SET @transaction_done = 'UPDATED a hospitalization document ' + 
									'[Document ID: ' + ISNULL(CONVERT(varchar, @document_id), '') + 
									'][Member ID: ' + ISNULL((SELECT
																	mbi.member_id
																FROM
																	lms.member_information AS mbi
																INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
																WHERE
																	(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Name: ' + ISNULL((SELECT 
																pri.last_name + ', ' + pri.first_name + + ' ' + ISNULL(pri.middle_name, '') 
															FROM
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.in_house_hospitalization_debit AS ihd ON ihd.sysid_member = mbi.sysid_member
															WHERE
																(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Hospital Name: ' + ISNULL((SELECT
																		ihd.hospital_name
																	FROM
																		lms.in_house_hospitalization_debit AS ihd
																	WHERE
																		(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Admission Date From: ' + ISNULL((SELECT
																			CONVERT(varchar, ihd.date_from, 101)
																		FROM
																			lms.in_house_hospitalization_debit AS ihd
																		WHERE
																			(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
									'][Admission Date To: ' + ISNULL((SELECT
																			CONVERT(varchar, ihd.date_to, 101)
																		FROM
																			lms.in_house_hospitalization_debit AS ihd
																		WHERE
																			(ihd.sysid_inhousedebit = @sysid_inhousedebit)), '') +
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
		EXECUTE lms.ShowErrorMsg 'Update a hospitalization document', 'Hospitalization Document'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateHospitalizationDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteHospitalizationDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteHospitalizationDocument')
   DROP PROCEDURE lms.DeleteHospitalizationDocument
GO

CREATE PROCEDURE lms.DeleteHospitalizationDocument
	
	@document_id bigint = 0,

	@network_information varchar(MAX) = '',
	@deleted_by varchar(50)
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@deleted_by) = 1))
	BEGIN

		IF EXISTS (SELECT document_id FROM lms.hospitalization_document WHERE document_id = @document_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.hospitalization_document SET
				edited_by = @deleted_by
			WHERE
				document_id = @document_id

			DELETE FROM lms.hospitalization_document WHERE document_id = @document_id	

		END	

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a hospitalization document', 'Hospitalization Document'
	END
	
GO
-------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteHospitalizationDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDInHouseDebitListHospitalizationDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDInHouseDebitListHospitalizationDocument')
   DROP PROCEDURE lms.SelectBySysIDInHouseDebitListHospitalizationDocument
GO

CREATE PROCEDURE lms.SelectBySysIDInHouseDebitListHospitalizationDocument

	@sysid_inhousedebit_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT 
			hpd.document_id AS document_id,
			hpd.sysid_inhousedebit AS sysid_inhousedebit,
			hpd.file_data AS file_data,
			hpd.original_name AS original_name,
			hpd.document_information AS document_information
		FROM 
			lms.hospitalization_document AS hpd
		INNER JOIN lms.IterateListToTable (@sysid_inhousedebit_list, ',') AS sihb_list ON sihb_list.var_str = hpd.sysid_inhousedebit
		WHERE
			(NOT hpd.file_data IS NULL) AND
			(NOT hpd.original_name IS NULL)
		ORDER BY
			hpd.sysid_inhousedebit ASC

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization document', 'Hospitalization Document'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDInHouseDebitListHospitalizationDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument')
   DROP PROCEDURE lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument
GO

CREATE PROCEDURE lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument

	@document_id bigint = 0,
	@sysid_inhousedebit varchar (50) = '',
	@original_name varchar (255) = '',
	@system_user_id varchar (50) = ''

AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR
		(lms.IsLoanOfficerSystemUserInfo(@system_user_id) = 1))
	BEGIN
		
		SELECT lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDoc(@document_id, @sysid_inhousedebit, @original_name)

	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a hospitalization document', 'Hospitalization Document'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the "IsExistsSysIDInHouseDebitOriginalNameHospitalizationDoc" function already exist
IF OBJECT_ID (N'lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDoc') IS NOT NULL
   DROP FUNCTION lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDoc
GO

CREATE FUNCTION lms.IsExistsSysIDInHouseDebitOriginalNameHospitalizationDoc
(	
	@document_id bigint = 0,
	@sysid_inhousedebit varchar (50) = '',	
	@original_name varchar (255) = ''
)
RETURNS bit
AS
BEGIN
	
	DECLARE @result bit

	SET @result = 0
	
	IF EXISTS (SELECT sysid_inhousedebit FROM lms.hospitalization_document WHERE (NOT document_id = @document_id) AND (sysid_inhousedebit = @sysid_inhousedebit) AND
									((REPLACE(original_name, ' ', '')) LIKE REPLACE(@original_name, ' ', '')))
	BEGIN
		SET @result = 1
	END
	
	RETURN @result
END
GO
------------------------------------------------------

-- ########################################END TABLE "hospitalization_document" OBJECTS########################################################





-- ################################################TABLE "regular_loan_payments" OBJECTS######################################################
-- verifies if the regular_loan_payments table exists
IF OBJECT_ID('lms.regular_loan_payments', 'U') IS NOT NULL
	DROP TABLE lms.regular_loan_payments
GO

CREATE TABLE lms.regular_loan_payments 			
(
	payment_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Regular_Loan_Payments_Payment_ID_PK PRIMARY KEY (payment_id),
	sysid_regular varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Payments_SysID_Regular_FK FOREIGN KEY REFERENCES lms.regular_loan_information(sysid_regular) ON UPDATE NO ACTION,
	reflected_date datetime NOT NULL
		CONSTRAINT Regular_Loan_Payments_Reflected_Date_CK CHECK (CONVERT(varchar, reflected_date, 109) LIKE '%12:00:00:000AM'),
	receipt_date datetime NOT NULL
		CONSTRAINT Regular_Loan_Payments_Receipt_Date_CK CHECK (CONVERT(varchar, receipt_date, 109) LIKE '%12:00:00:000AM'),
	receipt_no varchar (50) NOT NULL,

	payment_amount decimal (12, 2) NOT NULL,
	principal_paid decimal (12, 2) NOT NULL,
	interest_paid decimal (12, 2) NOT NULL,

	remarks varchar (100) NULL,

	amount_tendered decimal (12, 2) NULL,

	bank varchar (50) NULL,
	check_no varchar (50) NULL,

	sysid_account_credit varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Payments_SysID_Account_Credit_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,

	rebate_amount decimal (12, 2) NULL,
	sysid_account_rebate varchar (50) NULL
		CONSTRAINT Regular_Loan_Payments_SysID_Account_Rebate_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,	

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Regular_Loan_Payments_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Regular_Loan_Payments_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Regular_Loan_Payments_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the regular_loan_payments table 
CREATE INDEX Regular_Loan_Payments_Payment_ID_Index
	ON lms.regular_loan_payments (payment_id DESC)
GO
------------------------------------------------------------------

-- create an index of the regular_loan_payments table 
CREATE INDEX Regular_Loan_Payments_Reflected_Date_Index
	ON lms.regular_loan_payments (reflected_date DESC)
GO
------------------------------------------------------------------

-- create an index of the regular_loan_payments table 
CREATE INDEX Regular_Loan_Payments_Receipt_Date_Index
	ON lms.regular_loan_payments (receipt_date DESC)
GO
------------------------------------------------------------------

-- create an index of the regular_loan_payments table 
CREATE INDEX Regular_Loan_Payments_Created_On_Index
	ON lms.regular_loan_payments (created_on DESC)
GO
------------------------------------------------------------------

-- create an index of the regular_loan_payments table 
CREATE INDEX Regular_Loan_Payments_Created_By_Index
	ON lms.regular_loan_payments (created_by DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Payments_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Regular_Loan_Payments_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Payments_Trigger_Insert
GO

CREATE TRIGGER lms.Regular_Loan_Payments_Trigger_Insert
	ON  lms.regular_loan_payments
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @payment_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @payment_amount decimal (12, 2)
	DECLARE @principal_paid decimal (12, 2)
	DECLARE @interest_paid decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @rebate_amount decimal (12, 2)
	DECLARE @sysid_account_rebate varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@payment_id = i.payment_id,
		@sysid_regular = i.sysid_regular,
		@reflected_date = i.reflected_date,
		@receipt_date = i.receipt_date,
		@receipt_no = i.receipt_no,

		@payment_amount = i.payment_amount,
		@principal_paid = i.principal_paid,
		@interest_paid = i.interest_paid,

		@remarks = i.remarks,

		@amount_tendered = i.amount_tendered,

		@bank = i.bank,
		@check_no = i.check_no,

		@sysid_account_credit = i.sysid_account_credit,

		@rebate_amount = i.rebate_amount,
		@sysid_account_rebate = i.sysid_account_rebate,

		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new regular loan payments ' + 
							'[Payment ID: ' + ISNULL(CONVERT(varchar, @payment_id), '') +
							'][Member ID: ' + ISNULL((SELECT mbi.member_id
															FROM 
																lms.member_information AS mbi
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE 
																rli.sysid_regular = @sysid_regular), '') +
							'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
															FROM 
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
															WHERE 
																rli.sysid_regular = @sysid_regular), '') +
							'][Loan Information: ' + ISNULL((SELECT '(' + rli.account_no + ') ' + rlt.regular_loan_type_description
																FROM 
																	lms.regular_loan_information AS rli
																INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
																WHERE 
																	rli.sysid_regular = @sysid_regular), '') +
							'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
							'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
							'][Receipt No.: ' + ISNULL(@receipt_no, '') +

							'][Payment Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') +
							'][Principal Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') +
							'][Interest Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') +
				
							'][Remarks: ' + ISNULL(@remarks, '') + 
							
							'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

							'][Bank: ' + ISNULL(@bank, '') +
							'][Check No.: ' + ISNULL(@check_no, '') +

							'][Credit Entry: ' + ISNULL((SELECT
																coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
															FROM
																lms.chart_of_accounts AS coa
															INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
															WHERE
																(coa.sysid_account = @sysid_account_credit)), '') +

							'][Rebate Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @rebate_amount), 1), '0.00') +
							'][Rebate Entry: ' + ISNULL((SELECT
																coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
															FROM
																lms.chart_of_accounts AS coa
															INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
															WHERE
																(coa.sysid_account = @sysid_account_rebate)), '') +
							
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-----------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Payments_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Regular_Loan_Payments_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Payments_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Regular_Loan_Payments_Trigger_Instead_Update
	ON  lms.regular_loan_payments
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @payment_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @payment_amount decimal (12, 2)
	DECLARE @principal_paid decimal (12, 2)
	DECLARE @interest_paid decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @rebate_amount decimal (12, 2)
	DECLARE @sysid_account_rebate varchar (50)

	DECLARE @edited_by varchar (50)
	
	DECLARE @reflected_date_b datetime
	DECLARE @receipt_date_b datetime
	DECLARE @receipt_no_b varchar (50)

	DECLARE @payment_amount_b decimal (12, 2)
	DECLARE @principal_paid_b decimal (12, 2)
	DECLARE @interest_paid_b decimal (12, 2)

	DECLARE @remarks_b varchar (100)

	DECLARE @amount_tendered_b decimal (12, 2)

	DECLARE @bank_b varchar (50)
	DECLARE @check_no_b varchar (50)

	DECLARE @sysid_account_credit_b varchar (50)

	DECLARE @rebate_amount_b decimal (12, 2)
	DECLARE @sysid_account_rebate_b varchar (50)

	DECLARE @has_update bit

	DECLARE regular_loan_payments_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.payment_id, i.sysid_regular, i.reflected_date, i.receipt_date, i.receipt_no, i.payment_amount,
				i.principal_paid, i.interest_paid, i.remarks, i.amount_tendered, i.bank,
				i.check_no, i.sysid_account_credit, i.rebate_amount, i.sysid_account_rebate, i.edited_by
			FROM INSERTED AS i

	OPEN regular_loan_payments_update_cursor

	FETCH NEXT FROM regular_loan_payments_update_cursor
		INTO @payment_id, @sysid_regular, @reflected_date, @receipt_date, @receipt_no, @payment_amount,
				@principal_paid, @interest_paid, @remarks, @amount_tendered, @bank,
				@check_no, @sysid_account_credit, @rebate_amount, @sysid_account_rebate, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@reflected_date_b = rlp.reflected_date,
			@receipt_date_b = rlp.receipt_date,
			@receipt_no_b = rlp.receipt_no,

			@payment_amount_b = rlp.payment_amount,
			@principal_paid_b = rlp.principal_paid,
			@interest_paid_b = rlp.interest_paid,

			@remarks_b = rlp.remarks,

			@amount_tendered_b = rlp.amount_tendered,

			@bank_b = rlp.bank,
			@check_no_b = rlp.check_no,

			@sysid_account_credit_b = rlp.sysid_account_credit,

			@rebate_amount_b = rlp.rebate_amount,
			@sysid_account_rebate = rlp.sysid_account_rebate
		FROM
			lms.regular_loan_payments AS rlp
		WHERE
			rlp.payment_id = @payment_id

		SET @transaction_done = ''
		SET @has_update = 0
		
		IF (NOT ISNULL(CONVERT(varchar, @reflected_date, 101), '') = ISNULL(CONVERT(varchar, @reflected_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date Before: ' + ISNULL(CONVERT(varchar, @reflected_date_b, 101), '') + ']' +
														'[Reflected Date After: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, @receipt_date, 101), '') = ISNULL(CONVERT(varchar, @receipt_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date Before: ' + ISNULL(CONVERT(varchar, @receipt_date_b, 101), '') + ']' +
														'[Receipt Date After: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
		END

		IF NOT ISNULL(@receipt_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@receipt_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No. Before: ' + ISNULL(@receipt_no_b, '') + ']' +
														'[Receipt No. After: ' + ISNULL(@receipt_no, '') + ']'
			SET @has_update = 1
		END		
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No.: ' + ISNULL(@receipt_no, '') + ']'
		END

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Payment Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount_b), 1), '0.00') +  ']' +
														'[Payment Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Principal Paid Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid_b), 1), '0.00') +  ']' +
														'[Principal Paid After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Interest Paid Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid_b), 1), '0.00') +  ']' +
														'[Interest Paid After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') +  ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount Tendered Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00') +  ']' +
														'[Amount Tendered After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@bank COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@bank_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Before: ' + ISNULL(@bank_b, '') +  ']' +
														'[Bank After: ' + ISNULL(@bank, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@check_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@check_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check No. Before: ' + ISNULL(@check_no_b, '') +  ']' +
														'[Check No. After: ' + ISNULL(@check_no, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@sysid_account_credit COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_credit_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Entry Before: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit_b)), '') +  ']' +
														'[Credit Entry After: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit)), '') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @rebate_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @rebate_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Rebate Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @rebate_amount_b), 1), '0.00') +  ']' +
														'[Rebate Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @rebate_amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@sysid_account_rebate COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_rebate_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Rebate Entry Before: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_rebate_b)), '') +  ']' +
														'[Rebate Entry After: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_rebate)), '') +  ']'
			SET @has_update = 1
		END	

		IF @has_update = 1
		BEGIN

			UPDATE lms.regular_loan_payments SET
				reflected_date = @reflected_date,
				receipt_date = @receipt_date,
				receipt_no = @receipt_no,

				payment_amount = @payment_amount,
				principal_paid = @principal_paid,
				interest_paid = @interest_paid,

				remarks = @remarks,

				amount_tendered = @amount_tendered,

				bank = @bank,
				check_no = @check_no,

				sysid_account_credit = @sysid_account_credit,

				rebate_amount = @rebate_amount,
				sysid_account_rebate = @sysid_account_rebate,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				payment_id = @payment_id

			SET @transaction_done = 'UPDATED a regular loan payments ' + 
									'[Payment ID: ' + ISNULL(CONVERT(varchar, @payment_id), '') +
									'][Member ID: ' + ISNULL((SELECT mbi.member_id
																	FROM 
																		lms.member_information AS mbi
																	INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																	WHERE 
																		rli.sysid_regular = @sysid_regular), '') +
									'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																	FROM 
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																	WHERE 
																		rli.sysid_regular = @sysid_regular), '') +
									'][Loan Information: ' + ISNULL((SELECT '(' + rli.account_no + ') ' + rlt.regular_loan_type_description
																		FROM 
																			lms.regular_loan_information AS rli
																		INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
																		WHERE 
																			rli.sysid_regular = @sysid_regular), '') +
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
			UPDATE lms.regular_loan_payments SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				payment_id = @payment_id

		END	

		FETCH NEXT FROM regular_loan_payments_update_cursor
			INTO @payment_id, @sysid_regular, @reflected_date, @receipt_date, @receipt_no, @payment_amount,
					@principal_paid, @interest_paid, @remarks, @amount_tendered, @bank,
					@check_no, @sysid_account_credit, @rebate_amount, @sysid_account_rebate, @edited_by


	END

	CLOSE regular_loan_payments_update_cursor
	DEALLOCATE regular_loan_payments_update_cursor

GO
-------------------------------------------------------------------

--verifies that the trigger "Regular_Loan_Payments_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Regular_Loan_Payments_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Regular_Loan_Payments_Trigger_Delete
GO

CREATE TRIGGER lms.Regular_Loan_Payments_Trigger_Delete
	ON  lms.regular_loan_payments
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @payment_id bigint
	DECLARE @sysid_regular varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @payment_amount decimal (12, 2)
	DECLARE @principal_paid decimal (12, 2)
	DECLARE @interest_paid decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @rebate_amount decimal (12, 2)
	DECLARE @sysid_account_rebate varchar (50)

	DECLARE @deleted_by varchar (50)

	DECLARE regular_loan_payments_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.payment_id, d.sysid_regular, d.reflected_date, d.receipt_date, d.receipt_no, d.payment_amount,
				d.principal_paid, d.interest_paid, d.remarks, d.amount_tendered, d.bank,
				d.check_no, d.sysid_account_credit, d.rebate_amount, d.sysid_account_rebate, d.edited_by
			FROM 
				DELETED AS d

	OPEN regular_loan_payments_delete_cursor

	FETCH NEXT FROM regular_loan_payments_delete_cursor
		INTO @payment_id, @sysid_regular, @reflected_date, @receipt_date, @receipt_no, @payment_amount,
				@principal_paid, @interest_paid, @remarks, @amount_tendered, @bank,
				@check_no, @sysid_account_credit, @rebate_amount, @sysid_account_rebate, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SET @transaction_done = 'DELETED a regular loan payments ' + 
								'[Payment ID: ' + ISNULL(CONVERT(varchar, @payment_id), '') +
								'][Member ID: ' + ISNULL((SELECT mbi.member_id
																FROM 
																	lms.member_information AS mbi
																INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																WHERE 
																	rli.sysid_regular = @sysid_regular), '') +
								'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																FROM 
																	lms.person_information AS pri
																INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_member = mbi.sysid_member
																WHERE 
																	rli.sysid_regular = @sysid_regular), '') +
								'][Loan Information: ' + ISNULL((SELECT '(' + rli.account_no + ') ' + rlt.regular_loan_type_description
																	FROM 
																		lms.regular_loan_information AS rli
																	INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
																	WHERE 
																		rli.sysid_regular = @sysid_regular), '') +
								'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
								'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
								'][Receipt No.: ' + ISNULL(@receipt_no, '') +

								'][Payment Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @payment_amount), 1), '0.00') +
								'][Principal Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @principal_paid), 1), '0.00') +
								'][Interest Paid: ' + ISNULL(CONVERT(varchar, CONVERT(money, @interest_paid), 1), '0.00') +
					
								'][Remarks: ' + ISNULL(@remarks, '') + 
								
								'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

								'][Bank: ' + ISNULL(@bank, '') +
								'][Check No.: ' + ISNULL(@check_no, '') +

								'][Credit Entry: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account_credit)), '') +

								'][Rebate Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @rebate_amount), 1), '0.00') +
								'][Rebate Entry: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account_rebate)), '') +

								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done	

		FETCH NEXT FROM regular_loan_payments_delete_cursor
			INTO @payment_id, @sysid_regular, @reflected_date, @receipt_date, @receipt_no, @payment_amount,
					@principal_paid, @interest_paid, @remarks, @amount_tendered, @bank,
					@check_no, @sysid_account_credit, @rebate_amount, @sysid_account_rebate, @deleted_by


	END

	CLOSE regular_loan_payments_delete_cursor
	DEALLOCATE regular_loan_payments_delete_cursor	

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertRegularLoanPayments" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertRegularLoanPayments')
   DROP PROCEDURE lms.InsertRegularLoanPayments
GO

CREATE PROCEDURE lms.InsertRegularLoanPayments

	@sysid_regular varchar (50) = '',
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@payment_amount decimal (12, 2) = 0.0,
	@principal_paid decimal (12, 2) = 0.0,
	@interest_paid decimal (12, 2) = 0.0,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.0,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@sysid_account_credit varchar (50) = '',

	@rebate_amount decimal (12, 2) = 0.0,
	@sysid_account_rebate varchar (50) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR (lms.IsCashierSystemUserInfo(@created_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, GETDATE()) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.regular_loan_payments
		(
			sysid_regular,
			reflected_date,
			receipt_date,
			receipt_no,

			payment_amount,
			principal_paid,
			interest_paid,

			remarks,

			amount_tendered,

			bank,
			check_no,

			sysid_account_credit,

			rebate_amount,
			sysid_account_rebate,

			created_by
		)
		VALUES
		(
			@sysid_regular,
			@reflected_date,
			@receipt_date,
			@receipt_no,

			@payment_amount,
			@principal_paid,
			@interest_paid,

			@remarks,

			@amount_tendered,

			@bank,
			@check_no,

			@sysid_account_credit,

			@rebate_amount,
			@sysid_account_rebate,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a new regular loan payments', 'Regular Loan Payments'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertRegularLoanPayments TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateRegularLoanPayments" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateRegularLoanPayments')
   DROP PROCEDURE lms.UpdateRegularLoanPayments
GO

CREATE PROCEDURE lms.UpdateRegularLoanPayments

	@payment_id bigint = 0,
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@payment_amount decimal (12, 2) = 0.0,
	@principal_paid decimal (12, 2) = 0.0,
	@interest_paid decimal (12, 2) = 0.0,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.0,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@sysid_account_credit varchar (50) = '',

	@rebate_amount decimal (12, 2) = 0.0,
	@sysid_account_rebate varchar (50) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR (lms.IsCashierSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, (SELECT
																	created_on
																FROM
																	lms.regular_loan_payments
																WHERE
																	(payment_id = @payment_id))) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.regular_loan_payments SET
			reflected_date = @reflected_date,
			receipt_date = @receipt_date,
			receipt_no = @receipt_no,

			payment_amount = @payment_amount,
			principal_paid = @principal_paid,
			interest_paid = @interest_paid,

			remarks = @remarks,

			amount_tendered = @amount_tendered,

			bank = @bank,
			check_no = @check_no,

			sysid_account_credit = @sysid_account_credit,

			rebate_amount = @rebate_amount,
			sysid_account_rebate = @sysid_account_rebate,

			edited_by = @edited_by
		WHERE
			payment_id = @payment_id
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a regular loan payments', 'Regular Loan Payments'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateRegularLoanPayments TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteRegularLoanPayments" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteRegularLoanPayments')
   DROP PROCEDURE lms.DeleteRegularLoanPayments
GO

CREATE PROCEDURE lms.DeleteRegularLoanPayments

	@payment_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR (lms.IsCashierSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, 
												(SELECT
														created_on
													FROM
														lms.regular_loan_payments
													WHERE
														(payment_id = @payment_id))) = 0)
	BEGIN

		IF EXISTS (SELECT payment_id FROM lms.regular_loan_payments WHERE payment_id = @payment_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.regular_loan_payments SET
				edited_by = @deleted_by
			WHERE
				payment_id = @payment_id

			DELETE FROM lms.regular_loan_payments WHERE payment_id = @payment_id

		END
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a regular loan payments', 'Regular Loan Payments'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteRegularLoanPayments TO db_lmsusers
GO    
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDRegularListRegularLoanPayments" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDRegularListRegularLoanPayments')
   DROP PROCEDURE lms.SelectBySysIDRegularListRegularLoanPayments
GO

CREATE PROCEDURE lms.SelectBySysIDRegularListRegularLoanPayments

	@sysid_regular_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			rlp.payment_id AS payment_id,
			rlp.sysid_regular AS sysid_regular,
			rlp.reflected_date AS reflected_date,
			rlp.receipt_date AS receipt_date,
			rlp.created_on AS received_date,
			rlp.receipt_no AS receipt_no,
			rlp.payment_amount AS payment_amount,
			rlp.principal_paid AS principal_paid,
			rlp.interest_paid AS interest_paid,
			rlp.remarks AS remarks,
			rlp.amount_tendered AS amount_tendered,
			rlp.bank AS bank,
			rlp.check_no AS check_no,
			rlp.rebate_amount AS rebate_amount,

			--rlp.sysid_account_credit
			coa.sysid_account AS sysid_account_credit,
			coa.account_code AS account_code_credit,
			coa.account_name AS account_name_credit,
			coa.is_debit_side_increase AS is_debit_side_increase_credit,
			coa.is_active_account AS is_active_account_credit,

			--coa.accounting_category_id
			acg.accounting_category_id AS accounting_category_id_credit,
			acg.category_description AS category_description_credit,

			--rlp.sysid_account_rebate
			rebate_coa.sysid_account AS sysid_account_rebate,
			rebate_coa.account_code AS account_code_rebate,
			rebate_coa.account_name AS account_name_rebate,
			rebate_coa.is_debit_side_increase AS is_debit_side_increase_rebate,
			rebate_coa.is_active_account AS is_active_account_rebate,

			--rebate_coa.accounting_category_id
			rebate_acg.accounting_category_id AS accounting_category_id_rebate,
			rebate_acg.category_description AS category_description_rebate,
			
			'true' AS is_editable 
		FROM
			lms.regular_loan_payments AS rlp
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srgl_list ON srgl_list.var_str = rlp.sysid_regular
		INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = rlp.sysid_account_credit
		INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
		LEFT JOIN lms.chart_of_accounts AS rebate_coa ON rebate_coa.sysid_account = rlp.sysid_account_rebate
		LEFT JOIN lms.accounting_category AS rebate_acg ON rebate_acg.accounting_category_id = rebate_coa.accounting_category_id
		UNION ALL
		SELECT
			00000000 AS payment_id,
			srgl_list.var_str AS sysid_regular,
			rlg.created_on AS reflected_date,
			rlg.created_on AS receipt_date,
			rlg.created_on AS received_date,
			rli.account_no AS receipt_no,
			rlg.charge_amount AS payment_amount,
			rlg.charge_amount AS principal_paid,
			0.00 AS interest_paid,
			'Outstanding Balance: ' + rlt.regular_loan_type_description + ' (' + rli.account_no + ')' AS remarks,
			rlg.charge_amount AS amount_tendered,
			NULL AS bank,
			NULL AS check_no,
			0.00 AS rebate_amount,

			--rlp.sysid_account_credit
			NULL AS sysid_account_credit,
			NULL AS account_code_credit,
			NULL AS account_name_credit,
			NULL AS is_debit_side_increase_credit,
			NULL AS is_active_account_credit,

			--coa.accounting_category_id
			NULL AS accounting_category_id_credit,
			NULL AS category_description_credit,

			--rlp.sysid_account_rebate
			NULL AS sysid_account_rebate,
			NULL AS account_code_rebate,
			NULL AS account_name_rebate,
			NULL AS is_debit_side_increase_rebate,
			NULL AS is_active_account_rebate,

			--rebate_coa.accounting_category_id
			NULL AS accounting_category_id_rebate,
			NULL AS category_description_rebate,
			
			'false' AS is_editable 
		FROM
			lms.regular_loan_charges AS rlg
		INNER JOIN lms.IterateListToTable (@sysid_regular_list, ',') AS srgl_list ON srgl_list.var_str = rlg.sysid_regular_forwarded
		INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_regular = rlg.sysid_regular
		INNER JOIN lms.regular_loan_type AS rlt ON rlt.regular_loan_type_id = rli.regular_loan_type_id
		ORDER BY
			rlp.receipt_date DESC, rlp.reflected_date DESC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan payments', 'Regular Loan Payments'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDRegularListRegularLoanPayments TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments')
   DROP PROCEDURE lms.SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments
GO

CREATE PROCEDURE lms.SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments

	@sysid_member varchar (50) = '',
	@regular_loan_type_id_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN
	
		DECLARE @loan_type_summary TABLE (table_id bigint IDENTITY(1, 1) NOT NULL PRIMARY KEY,
											date_created datetime NOT NULL,
											date_reflected datetime NOT NULL,
											description_summary varchar (200) NOT NULL,
											debit_amount decimal (12, 2) NOT NULL DEFAULT (0.00),
											credit_amount decimal (12, 2) NOT NULL DEFAULT (0.00),
											balance_amount decimal (12, 2) NOT NULL DEFAULT (0.00))
		
		-- we can use the field balance_amount to get the last balance by getting the maximum table_id which means this is the last record
		-- SELECT TOP 1 balance_amount FROM @loan_type_summary ORDER BY table_id DESC
		-- To get the total amount loan receivable by the association, that would be principal amount + total interest.
											
		DECLARE @balance_amount decimal (12, 2)
		DECLARE @sysid_regular varchar (50)
		DECLARE @account_no varchar (50)
		DECLARE @loan_amount decimal (15, 2)
		DECLARE @purpose_of_loan varchar (MAX)
		DECLARE @date_applied datetime
		DECLARE @date_approved datetime
		
		DECLARE regular_loan_information_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
			FOR SELECT rli.sysid_regular, rli.account_no, rli.loan_amount, rli.purpose_of_loan, rli.date_applied, rli.date_approved 
					FROM lms.regular_loan_information AS rli
					INNER JOIN lms.IterateListToTable (@regular_loan_type_id_list, ',') AS rltil_list ON rltil_list.var_str = rli.regular_loan_type_id
					WHERE
						rli.sysid_member = @sysid_member AND
						rli.is_marked_deleted = 0
					ORDER BY
						rli.created_on ASC

		OPEN regular_loan_information_cursor

		FETCH NEXT FROM regular_loan_information_cursor
			INTO @sysid_regular, @account_no, @loan_amount, @purpose_of_loan, @date_applied, @date_approved
			
		WHILE @@FETCH_STATUS = 0
		BEGIN		
		
			--insert a member loan availed
			INSERT INTO @loan_type_summary 
			(
				date_created, 
				date_reflected, 
				description_summary, 
				debit_amount, 
				credit_amount, 
				balance_amount
			)
			VALUES 
			(
				@date_applied, 
				@date_approved, 
				'LOAN RELEASED: ' + @account_no + ' - ' + @purpose_of_loan, 
				CONVERT(money, '0.00'), 
				@loan_amount, 
				CONVERT(money, '0.00')
			)
			
			--insert a the interest earned by the loan being availed
			INSERT INTO @loan_type_summary 
			(
				date_created, 
				date_reflected, 
				description_summary, 
				debit_amount, 
				credit_amount, 
				balance_amount
			)
			VALUES 
			(
				@date_applied, 
				@date_approved, 
				'LOAN INTEREST: ' + @account_no,
				CONVERT(money, '0.00'), 
				(SELECT SUM(rla.interest_paid) FROM lms.regular_loan_amortization AS rla WHERE rla.sysid_regular = @sysid_regular), 
				CONVERT(money, '0.00')
			)
			
			--insert member payments
			INSERT INTO @loan_type_summary(date_created, date_reflected, description_summary, debit_amount, credit_amount, balance_amount)
				SELECT
					receipt_date,
					reflected_date,
					'Payment: RN# ' + receipt_no + ' (Prin: ' + ISNULL(CONVERT(varchar, CONVERT(money, principal_paid), 1), '0.00') + '; Int: ' +
						ISNULL(CONVERT(varchar, CONVERT(money, interest_paid), 1), '0.00') + ')',
					payment_amount,
					CONVERT(money, '0.00'),
					CONVERT(money, '0.00')
				FROM
					lms.regular_loan_payments AS rlp
				WHERE
					rlp.sysid_regular = @sysid_regular
				ORDER BY
					rlp.reflected_date ASC
				
			FETCH NEXT FROM regular_loan_information_cursor
				INTO @sysid_regular, @account_no, @loan_amount, @purpose_of_loan, @date_applied, @date_approved

		END

		CLOSE regular_loan_information_cursor
		DEALLOCATE regular_loan_information_cursor
		
		UPDATE @loan_type_summary
		SET
			@balance_amount = (ISNULL(@balance_amount, CONVERT(money, '0.00')) + credit_amount) - debit_amount,
			balance_amount = @balance_amount
		
		SELECT
			date_created,
			date_reflected,
			description_summary,
			debit_amount, 
			credit_amount, 
			balance_amount
		FROM
			@loan_type_summary AS lts
		ORDER BY
			lts.table_id ASC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a regular loan payments', 'Regular Loan Payments'
		
	END
	
GO
-------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments TO db_lmsusers
GO
-------------------------------------------------------------

-- #############################################END TABLE "regular_loan_payments" OBJECTS######################################################





-- ################################################TABLE "share_capital_credit" OBJECTS######################################################
-- verifies if the share_capital_credit table exists
IF OBJECT_ID('lms.share_capital_credit', 'U') IS NOT NULL
	DROP TABLE lms.share_capital_credit
GO

CREATE TABLE lms.share_capital_credit 			
(
	capital_credit_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Share_Capital_Credit_Capital_Credit_ID_PK PRIMARY KEY (capital_credit_id),
	sysid_member varchar (50) NOT NULL
		CONSTRAINT Share_Capital_Credit_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	reflected_date datetime NOT NULL
		CONSTRAINT Share_Capital_Credit_Reflected_Date_CK CHECK (CONVERT(varchar, reflected_date, 109) LIKE '%12:00:00:000AM'),
	receipt_date datetime NOT NULL
		CONSTRAINT Share_Capital_Credit_Receipt_Date_CK CHECK (CONVERT(varchar, receipt_date, 109) LIKE '%12:00:00:000AM'),
	receipt_no varchar (50) NOT NULL,

	credit_amount decimal (12, 2) NOT NULL,

	remarks varchar (100) NULL,

	amount_tendered decimal (12, 2) NULL,

	bank varchar (50) NULL,
	check_no varchar (50) NULL,

	is_migrated_entry bit NOT NULL DEFAULT (0),

	sysid_account_credit varchar (50) NOT NULL
		CONSTRAINT Share_Capital_Credit_SysID_Account_Credit_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Share_Capital_Credit_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Share_Capital_Credit_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Share_Capital_Credit_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the share_capital_credit table 
CREATE INDEX Share_Capital_Credit_Capital_Credit_ID_Index
	ON lms.share_capital_credit (capital_credit_id DESC)
GO
------------------------------------------------------------------

-- create an index of the share_capital_credit table 
CREATE INDEX Share_Capital_Credit_Reflected_Date_Index
	ON lms.share_capital_credit (reflected_date DESC)
GO
------------------------------------------------------------------

-- create an index of the share_capital_credit table 
CREATE INDEX Share_Capital_Credit_Receipt_Date_Index
	ON lms.share_capital_credit (receipt_date DESC)
GO
------------------------------------------------------------------

-- create an index of the share_capital_credit table 
CREATE INDEX Share_Capital_Credit_Created_On_Index
	ON lms.share_capital_credit (created_on DESC)
GO
------------------------------------------------------------------

-- create an index of the share_capital_credit table 
CREATE INDEX Share_Capital_Credit_Created_By_Index
	ON lms.share_capital_credit (created_by DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Share_Capital_Credit_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Share_Capital_Credit_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Share_Capital_Credit_Trigger_Insert
GO

CREATE TRIGGER lms.Share_Capital_Credit_Trigger_Insert
	ON  lms.share_capital_credit
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @capital_credit_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @is_migrated_entry bit

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @created_by varchar (50)

	DECLARE @migrated_entry_string varchar (20)
	
	SELECT 
		@capital_credit_id = i.capital_credit_id,
		@sysid_member = i.sysid_member,
		@reflected_date = i.reflected_date,
		@receipt_date = i.receipt_date,
		@receipt_no = i.receipt_no,

		@credit_amount = i.credit_amount,

		@remarks = i.remarks,

		@amount_tendered = i.amount_tendered,

		@bank = i.bank,
		@check_no = i.check_no,

		@is_migrated_entry = i.is_migrated_entry,

		@sysid_account_credit = i.sysid_account_credit,

		@created_by = i.created_by
	FROM INSERTED AS i

	IF (@is_migrated_entry = 1)
	BEGIN
		SET @migrated_entry_string = 'YES'
	END
	ELSE
	BEGIN
		SET @migrated_entry_string = 'NO'
	END

	SET @transaction_done = 'CREATED a new share capital credit ' + 
							'[Credit ID: ' + ISNULL(CONVERT(varchar, @capital_credit_id), '') +
							'][Member ID: ' + ISNULL((SELECT mbi.member_id
															FROM 
																lms.member_information AS mbi
															WHERE 
																mbi.sysid_member = @sysid_member), '') +
							'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
															FROM 
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															WHERE 
																mbi.sysid_member = @sysid_member), '') +
							'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
							'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
							'][Receipt No.: ' + ISNULL(@receipt_no, '') +

							'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
				
							'][Remarks: ' + ISNULL(@remarks, '') + 
							
							'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

							'][Bank: ' + ISNULL(@bank, '') +
							'][Check No.: ' + ISNULL(@check_no, '') +
							
							'][Is Migrated Entry: ' + ISNULL(@migrated_entry_string, '') +

							'][Credit Entry: ' + ISNULL((SELECT
																coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
															FROM
																lms.chart_of_accounts AS coa
															INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
															WHERE
																(coa.sysid_account = @sysid_account_credit)), '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-----------------------------------------------------------------

--verifies that the trigger "Share_Capital_Credit_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Share_Capital_Credit_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Share_Capital_Credit_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Share_Capital_Credit_Trigger_Instead_Update
	ON  lms.share_capital_credit
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @capital_credit_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @is_migrated_entry bit

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @edited_by varchar (50)
	
	DECLARE @reflected_date_b datetime
	DECLARE @receipt_date_b datetime
	DECLARE @receipt_no_b varchar (50)

	DECLARE @credit_amount_b decimal (12, 2)

	DECLARE @remarks_b varchar (100)

	DECLARE @amount_tendered_b decimal (12, 2)

	DECLARE @bank_b varchar (50)
	DECLARE @check_no_b varchar (50)

	DECLARE @is_migrated_entry_b bit

	DECLARE @sysid_account_credit_b varchar (50)

	DECLARE @has_update bit

	DECLARE @migrated_entry_string varchar (20)
	DECLARE @migrated_entry_string_b varchar (20)

	DECLARE share_capital_credit_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.capital_credit_id, i.sysid_member, i.reflected_date, i.receipt_date, i.receipt_no, i.credit_amount,
				i.remarks, i.amount_tendered, i.bank, i.check_no, i.is_migrated_entry, i.sysid_account_credit, i.edited_by
			FROM INSERTED AS i

	OPEN share_capital_credit_update_cursor

	FETCH NEXT FROM share_capital_credit_update_cursor
		INTO @capital_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
				@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@reflected_date_b = scc.reflected_date,
			@receipt_date_b = scc.receipt_date,
			@receipt_no_b = scc.receipt_no,

			@credit_amount_b = scc.credit_amount,

			@remarks_b = scc.remarks,

			@amount_tendered_b = scc.amount_tendered,

			@bank_b = scc.bank,
			@check_no_b = scc.check_no,

			@is_migrated_entry_b = scc.is_migrated_entry,

			@sysid_account_credit_b = scc.sysid_account_credit
		FROM
			lms.share_capital_credit AS scc
		WHERE
			scc.capital_credit_id = @capital_credit_id

		SET @transaction_done = ''
		SET @has_update = 0
		
		IF (NOT ISNULL(CONVERT(varchar, @reflected_date, 101), '') = ISNULL(CONVERT(varchar, @reflected_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date Before: ' + ISNULL(CONVERT(varchar, @reflected_date_b, 101), '') + ']' +
														'[Reflected Date After: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, @receipt_date, 101), '') = ISNULL(CONVERT(varchar, @receipt_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date Before: ' + ISNULL(CONVERT(varchar, @receipt_date_b, 101), '') + ']' +
														'[Receipt Date After: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
		END

		IF NOT ISNULL(@receipt_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@receipt_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No. Before: ' + ISNULL(@receipt_no_b, '') + ']' +
														'[Receipt No. After: ' + ISNULL(@receipt_no, '') + ']'
			SET @has_update = 1
		END		
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No.: ' + ISNULL(@receipt_no, '') + ']'
		END

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00') +  ']' +
														'[Credit Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') +  ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount Tendered Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00') +  ']' +
														'[Amount Tendered After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@bank COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@bank_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Before: ' + ISNULL(@bank_b, '') +  ']' +
														'[Bank After: ' + ISNULL(@bank, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@check_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@check_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check No. Before: ' + ISNULL(@check_no_b, '') +  ']' +
														'[Check No. After: ' + ISNULL(@check_no, '') +  ']'
			SET @has_update = 1
		END	

		IF (NOT @is_migrated_entry = @is_migrated_entry_b)
		BEGIN

			IF (@is_migrated_entry = 1)
			BEGIN
				SET @migrated_entry_string = 'YES'
			END
			ELSE
			BEGIN
				SET @migrated_entry_string = 'NO'
			END

			IF (@is_migrated_entry_b = 1)
			BEGIN
				SET @migrated_entry_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @migrated_entry_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Migrated Entry Before: ' + ISNULL(@migrated_entry_string_b, '') + ']' +
														'[Is Migrated Entry After: ' + ISNULL(@migrated_entry_string, '') + ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(@sysid_account_credit COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_credit_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Entry Before: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit_b)), '') +  ']' +
														'[Credit Entry After: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit)), '') +  ']'
			SET @has_update = 1
		END	

		IF @has_update = 1
		BEGIN

			UPDATE lms.share_capital_credit SET
				reflected_date = @reflected_date,
				receipt_date = @receipt_date,
				receipt_no = @receipt_no,

				credit_amount = @credit_amount,

				remarks = @remarks,

				amount_tendered = @amount_tendered,

				bank = @bank,
				check_no = @check_no,

				is_migrated_entry = @is_migrated_entry,

				sysid_account_credit = @sysid_account_credit,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				capital_credit_id = @capital_credit_id

			SET @transaction_done = 'UPDATED a share capital credit ' + 
									'[Credit ID: ' + ISNULL(CONVERT(varchar, @capital_credit_id), '') +
									'][Member ID: ' + ISNULL((SELECT mbi.member_id
																	FROM 
																		lms.member_information AS mbi
																	WHERE 
																		mbi.sysid_member = @sysid_member), '') +
									'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																	FROM 
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	WHERE 
																		mbi.sysid_member = @sysid_member), '') +
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
			UPDATE lms.share_capital_credit SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				capital_credit_id = @capital_credit_id

		END	

		FETCH NEXT FROM share_capital_credit_update_cursor
			INTO @capital_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
					@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @edited_by


	END

	CLOSE share_capital_credit_update_cursor
	DEALLOCATE share_capital_credit_update_cursor

GO
-------------------------------------------------------------------

--verifies that the trigger "Share_Capital_Credit_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Share_Capital_Credit_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Share_Capital_Credit_Trigger_Delete
GO

CREATE TRIGGER lms.Share_Capital_Credit_Trigger_Delete
	ON  lms.share_capital_credit
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @capital_credit_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @is_migrated_entry bit

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @deleted_by varchar (50)

	DECLARE @migrated_entry_string varchar (20)

	DECLARE share_capital_credit_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.capital_credit_id, d.sysid_member, d.reflected_date, d.receipt_date, d.receipt_no, d.credit_amount,
				d.remarks, d.amount_tendered, d.bank, d.check_no, d.is_migrated_entry, d.sysid_account_credit, d.edited_by
			FROM 
				DELETED AS d

	OPEN share_capital_credit_delete_cursor

	FETCH NEXT FROM share_capital_credit_delete_cursor
		INTO @capital_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
				@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SET @transaction_done = 'DELETED a share capital credit ' + 
								'[Credit ID: ' + ISNULL(CONVERT(varchar, @capital_credit_id), '') +
								'][Member ID: ' + ISNULL((SELECT mbi.member_id
																FROM 
																	lms.member_information AS mbi
																WHERE 
																	mbi.sysid_member = @sysid_member), '') +
								'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																FROM 
																	lms.person_information AS pri
																INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																WHERE 
																	mbi.sysid_member = @sysid_member), '') +
								'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
								'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
								'][Receipt No.: ' + ISNULL(@receipt_no, '') +

								'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
					
								'][Remarks: ' + ISNULL(@remarks, '') + 
								
								'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

								'][Bank: ' + ISNULL(@bank, '') +
								'][Check No.: ' + ISNULL(@check_no, '') +
							
								'][Is Migrated Entry: ' + ISNULL(@migrated_entry_string, '') +

								'][Credit Entry: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account_credit)), '') +
								']'


		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done	

		FETCH NEXT FROM share_capital_credit_delete_cursor
			INTO @capital_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
					@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @deleted_by


	END

	CLOSE share_capital_credit_delete_cursor
	DEALLOCATE share_capital_credit_delete_cursor	

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertShareCapitalCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertShareCapitalCredit')
   DROP PROCEDURE lms.InsertShareCapitalCredit
GO

CREATE PROCEDURE lms.InsertShareCapitalCredit

	@sysid_member varchar (50) = '',
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@credit_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@is_migrated_entry bit = 0,

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR (lms.IsCashierSystemUserInfo(@created_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, GETDATE()) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.share_capital_credit
		(
			sysid_member,
			reflected_date,
			receipt_date,
			receipt_no,

			credit_amount,

			remarks,

			amount_tendered,

			bank,
			check_no,

			is_migrated_entry,

			sysid_account_credit,

			created_by
		)
		VALUES
		(
			@sysid_member,
			@reflected_date,
			@receipt_date,
			@receipt_no,

			@credit_amount,

			@remarks,

			@amount_tendered,

			@bank,
			@check_no,

			@is_migrated_entry,

			@sysid_account_credit,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a new share capital credit', 'Share Capital Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertShareCapitalCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateShareCapitalCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateShareCapitalCredit')
   DROP PROCEDURE lms.UpdateShareCapitalCredit
GO

CREATE PROCEDURE lms.UpdateShareCapitalCredit

	@capital_credit_id bigint = 0,
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@credit_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@is_migrated_entry bit = 0,

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR (lms.IsCashierSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, (SELECT
																	created_on
																FROM
																	lms.share_capital_credit
																WHERE
																	(capital_credit_id = @capital_credit_id))) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.share_capital_credit SET
			reflected_date = @reflected_date,
			receipt_date = @receipt_date,
			receipt_no = @receipt_no,

			credit_amount = @credit_amount,

			remarks = @remarks,

			amount_tendered = @amount_tendered,

			bank = @bank,
			check_no = @check_no,

			is_migrated_entry = @is_migrated_entry,

			sysid_account_credit = @sysid_account_credit,

			edited_by = @edited_by
		WHERE
			capital_credit_id = @capital_credit_id
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a share capital credit', 'Share Capital Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateShareCapitalCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteShareCapitalCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteShareCapitalCredit')
   DROP PROCEDURE lms.DeleteShareCapitalCredit
GO

CREATE PROCEDURE lms.DeleteShareCapitalCredit

	@capital_credit_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR (lms.IsCashierSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, 
												(SELECT
														created_on
													FROM
														lms.share_capital_credit
													WHERE
														(capital_credit_id = @capital_credit_id))) = 0)
	BEGIN

		IF EXISTS (SELECT capital_credit_id FROM lms.share_capital_credit WHERE capital_credit_id = @capital_credit_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.share_capital_credit SET
				edited_by = @deleted_by
			WHERE
				capital_credit_id = @capital_credit_id

			DELETE FROM lms.share_capital_credit WHERE capital_credit_id = @capital_credit_id

		END
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a share capital credit', 'Share Capital Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteShareCapitalCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberListShareCapitalCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberListShareCapitalCredit')
   DROP PROCEDURE lms.SelectBySysIDMemberListShareCapitalCredit
GO

CREATE PROCEDURE lms.SelectBySysIDMemberListShareCapitalCredit

	@sysid_member_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			scc.capital_credit_id AS capital_credit_id,
			scc.sysid_member AS sysid_member,
			scc.reflected_date AS reflected_date,
			scc.receipt_date AS receipt_date,
			scc.created_on AS received_date,
			scc.receipt_no AS receipt_no,
			scc.credit_amount AS credit_amount,
			scc.remarks AS remarks,
			scc.amount_tendered AS amount_tendered,
			scc.bank AS bank,
			scc.check_no AS check_no,
			scc.is_migrated_entry AS is_migrated_entry,
			
			--scc.sysid_account_credit
			coa.sysid_account AS sysid_account_credit,
			coa.account_code AS account_code,
			coa.account_name AS account_name,
			coa.is_debit_side_increase AS is_debit_side_increase,
			coa.is_active_account AS is_active_account,

			--coa.accounting_category_id
			acg.accounting_category_id AS accounting_category_id,
			acg.category_description AS category_description
		FROM
			lms.share_capital_credit AS scc
		INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = scc.sysid_member
		INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = scc.sysid_account_credit
		INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
		ORDER BY
			scc.receipt_date DESC, scc.reflected_date DESC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a share capital credit', 'Share Capital Credit'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberListShareCapitalCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- ##############################################END TABLE "share_capital_credit" OBJECTS######################################################






-- ################################################TABLE "member_equity_credit" OBJECTS######################################################
-- verifies if the member_equity_credit table exists
IF OBJECT_ID('lms.member_equity_credit', 'U') IS NOT NULL
	DROP TABLE lms.member_equity_credit
GO

CREATE TABLE lms.member_equity_credit 			
(
	equity_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Member_Equity_Credit_Equity_ID_PK PRIMARY KEY (equity_id),
	sysid_member varchar (50) NOT NULL
		CONSTRAINT Member_Equity_Credit_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	reflected_date datetime NOT NULL
		CONSTRAINT Member_Equity_Credit_Reflected_Date_CK CHECK (CONVERT(varchar, reflected_date, 109) LIKE '%12:00:00:000AM'),
	receipt_date datetime NOT NULL
		CONSTRAINT Member_Equity_Credit_Receipt_Date_CK CHECK (CONVERT(varchar, receipt_date, 109) LIKE '%12:00:00:000AM'),
	receipt_no varchar (50) NOT NULL,

	credit_amount decimal (12, 2) NOT NULL,

	remarks varchar (100) NULL,

	amount_tendered decimal (12, 2) NULL,

	bank varchar (50) NULL,
	check_no varchar (50) NULL,

	is_migrated_entry bit NOT NULL DEFAULT (0),

	sysid_account_credit varchar (50) NOT NULL
		CONSTRAINT Member_Equity_Credit_SysID_Account_Credit_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Member_Equity_Credit_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Member_Equity_Credit_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Member_Equity_Credit_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the member_equity_credit table 
CREATE INDEX Member_Equity_Credit_Equity_ID_Index
	ON lms.member_equity_credit (equity_id DESC)
GO
------------------------------------------------------------------

-- create an index of the member_equity_credit table 
CREATE INDEX Member_Equity_Credit_Reflected_Date_Index
	ON lms.member_equity_credit (reflected_date DESC)
GO
------------------------------------------------------------------

-- create an index of the member_equity_credit table 
CREATE INDEX Member_Equity_Credit_Receipt_Date_Index
	ON lms.member_equity_credit (receipt_date DESC)
GO
------------------------------------------------------------------

-- create an index of the member_equity_credit table 
CREATE INDEX Member_Equity_Credit_Created_On_Index
	ON lms.member_equity_credit (created_on DESC)
GO
------------------------------------------------------------------

-- create an index of the member_equity_credit table 
CREATE INDEX Member_Equity_Credit_Created_By_Index
	ON lms.member_equity_credit (created_by DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Member_Equity_Credit_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Member_Equity_Credit_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Member_Equity_Credit_Trigger_Insert
GO

CREATE TRIGGER lms.Member_Equity_Credit_Trigger_Insert
	ON  lms.member_equity_credit
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @equity_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @is_migrated_entry bit

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @created_by varchar (50)

	DECLARE @migrated_entry_string varchar (20)
	
	SELECT 
		@equity_id = i.equity_id,
		@sysid_member = i.sysid_member,
		@reflected_date = i.reflected_date,
		@receipt_date = i.receipt_date,
		@receipt_no = i.receipt_no,

		@credit_amount = i.credit_amount,

		@remarks = i.remarks,

		@amount_tendered = i.amount_tendered,

		@bank = i.bank,
		@check_no = i.check_no,

		@is_migrated_entry = i.is_migrated_entry,

		@sysid_account_credit = i.sysid_account_credit,

		@created_by = i.created_by
	FROM INSERTED AS i

	IF (@is_migrated_entry = 1)
	BEGIN
		SET @migrated_entry_string = 'YES'
	END
	ELSE
	BEGIN
		SET @migrated_entry_string = 'NO'
	END

	SET @transaction_done = 'CREATED a new member''s equity credit ' + 
							'[Credit ID: ' + ISNULL(CONVERT(varchar, @equity_id), '') +
							'][Member ID: ' + ISNULL((SELECT mbi.member_id
															FROM 
																lms.member_information AS mbi
															WHERE 
																mbi.sysid_member = @sysid_member), '') +
							'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
															FROM 
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															WHERE 
																mbi.sysid_member = @sysid_member), '') +
							'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
							'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
							'][Receipt No.: ' + ISNULL(@receipt_no, '') +

							'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
				
							'][Remarks: ' + ISNULL(@remarks, '') + 
							
							'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

							'][Bank: ' + ISNULL(@bank, '') +
							'][Check No.: ' + ISNULL(@check_no, '') +
							
							'][Is Migrated Entry: ' + ISNULL(@migrated_entry_string, '') +

							'][Credit Entry: ' + ISNULL((SELECT
																coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
															FROM
																lms.chart_of_accounts AS coa
															INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
															WHERE
																(coa.sysid_account = @sysid_account_credit)), '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-----------------------------------------------------------------

--verifies that the trigger "Member_Equity_Credit_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Member_Equity_Credit_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Member_Equity_Credit_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Member_Equity_Credit_Trigger_Instead_Update
	ON  lms.member_equity_credit
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @equity_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @is_migrated_entry bit

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @edited_by varchar (50)
	
	DECLARE @reflected_date_b datetime
	DECLARE @receipt_date_b datetime
	DECLARE @receipt_no_b varchar (50)

	DECLARE @credit_amount_b decimal (12, 2)

	DECLARE @remarks_b varchar (100)

	DECLARE @amount_tendered_b decimal (12, 2)

	DECLARE @bank_b varchar (50)
	DECLARE @check_no_b varchar (50)

	DECLARE @is_migrated_entry_b bit

	DECLARE @sysid_account_credit_b varchar (50)

	DECLARE @has_update bit

	DECLARE @migrated_entry_string varchar (20)
	DECLARE @migrated_entry_string_b varchar (20)

	DECLARE member_equity_credit_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.equity_id, i.sysid_member, i.reflected_date, i.receipt_date, i.receipt_no, i.credit_amount,
				i.remarks, i.amount_tendered, i.bank, i.check_no, i.is_migrated_entry, i.sysid_account_credit, i.edited_by
			FROM INSERTED AS i

	OPEN member_equity_credit_update_cursor

	FETCH NEXT FROM member_equity_credit_update_cursor
		INTO @equity_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
				@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@reflected_date_b = mqc.reflected_date,
			@receipt_date_b = mqc.receipt_date,
			@receipt_no_b = mqc.receipt_no,

			@credit_amount_b = mqc.credit_amount,

			@remarks_b = mqc.remarks,

			@amount_tendered_b = mqc.amount_tendered,

			@bank_b = mqc.bank,
			@check_no_b = mqc.check_no,

			@is_migrated_entry_b = mqc.is_migrated_entry,

			@sysid_account_credit_b = mqc.sysid_account_credit
		FROM
			lms.member_equity_credit AS mqc
		WHERE
			mqc.equity_id = @equity_id

		SET @transaction_done = ''
		SET @has_update = 0
		
		IF (NOT ISNULL(CONVERT(varchar, @reflected_date, 101), '') = ISNULL(CONVERT(varchar, @reflected_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date Before: ' + ISNULL(CONVERT(varchar, @reflected_date_b, 101), '') + ']' +
														'[Reflected Date After: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, @receipt_date, 101), '') = ISNULL(CONVERT(varchar, @receipt_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date Before: ' + ISNULL(CONVERT(varchar, @receipt_date_b, 101), '') + ']' +
														'[Receipt Date After: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
		END

		IF NOT ISNULL(@receipt_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@receipt_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No. Before: ' + ISNULL(@receipt_no_b, '') + ']' +
														'[Receipt No. After: ' + ISNULL(@receipt_no, '') + ']'
			SET @has_update = 1
		END		
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No.: ' + ISNULL(@receipt_no, '') + ']'
		END

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00') +  ']' +
														'[Credit Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') +  ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount Tendered Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00') +  ']' +
														'[Amount Tendered After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@bank COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@bank_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Before: ' + ISNULL(@bank_b, '') +  ']' +
														'[Bank After: ' + ISNULL(@bank, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@check_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@check_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check No. Before: ' + ISNULL(@check_no_b, '') +  ']' +
														'[Check No. After: ' + ISNULL(@check_no, '') +  ']'
			SET @has_update = 1
		END	

		IF (NOT @is_migrated_entry = @is_migrated_entry_b)
		BEGIN

			IF (@is_migrated_entry = 1)
			BEGIN
				SET @migrated_entry_string = 'YES'
			END
			ELSE
			BEGIN
				SET @migrated_entry_string = 'NO'
			END

			IF (@is_migrated_entry_b = 1)
			BEGIN
				SET @migrated_entry_string_b = 'YES'
			END
			ELSE
			BEGIN
				SET @migrated_entry_string_b = 'NO'
			END

			SET @transaction_done = @transaction_done + '[Is Migrated Entry Before: ' + ISNULL(@migrated_entry_string_b, '') + ']' +
														'[Is Migrated Entry After: ' + ISNULL(@migrated_entry_string, '') + ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(@sysid_account_credit COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_credit_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Entry Before: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit_b)), '') +  ']' +
														'[Credit Entry After: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit)), '') +  ']'
			SET @has_update = 1
		END	

		IF @has_update = 1
		BEGIN

			UPDATE lms.member_equity_credit SET
				reflected_date = @reflected_date,
				receipt_date = @receipt_date,
				receipt_no = @receipt_no,

				credit_amount = @credit_amount,

				remarks = @remarks,

				amount_tendered = @amount_tendered,

				bank = @bank,
				check_no = @check_no,

				is_migrated_entry = @is_migrated_entry,

				sysid_account_credit = @sysid_account_credit,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				equity_id = @equity_id

			SET @transaction_done = 'UPDATED a member''s equity credit ' + 
									'[Credit ID: ' + ISNULL(CONVERT(varchar, @equity_id), '') +
									'][Member ID: ' + ISNULL((SELECT mbi.member_id
																	FROM 
																		lms.member_information AS mbi
																	WHERE 
																		mbi.sysid_member = @sysid_member), '') +
									'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																	FROM 
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	WHERE 
																		mbi.sysid_member = @sysid_member), '') +
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
			UPDATE lms.member_equity_credit SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				equity_id = @equity_id

		END	

		FETCH NEXT FROM member_equity_credit_update_cursor
			INTO @equity_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
					@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @edited_by


	END

	CLOSE member_equity_credit_update_cursor
	DEALLOCATE member_equity_credit_update_cursor

GO
-------------------------------------------------------------------

--verifies that the trigger "Member_Equity_Credit_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Member_Equity_Credit_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Member_Equity_Credit_Trigger_Delete
GO

CREATE TRIGGER lms.Member_Equity_Credit_Trigger_Delete
	ON  lms.member_equity_credit
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @equity_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @is_migrated_entry bit

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @deleted_by varchar (50)

	DECLARE @migrated_entry_string varchar (20)

	DECLARE member_equity_credit_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.equity_id, d.sysid_member, d.reflected_date, d.receipt_date, d.receipt_no, d.credit_amount,
				d.remarks, d.amount_tendered, d.bank, d.check_no, d.is_migrated_entry, d.sysid_account_credit, d.edited_by
			FROM 
				DELETED AS d

	OPEN member_equity_credit_delete_cursor

	FETCH NEXT FROM member_equity_credit_delete_cursor
		INTO @equity_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
				@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SET @transaction_done = 'DELETED a member''s equity credit ' + 
								'[Credit ID: ' + ISNULL(CONVERT(varchar, @equity_id), '') +
								'][Member ID: ' + ISNULL((SELECT mbi.member_id
																FROM 
																	lms.member_information AS mbi
																WHERE 
																	mbi.sysid_member = @sysid_member), '') +
								'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																FROM 
																	lms.person_information AS pri
																INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																WHERE 
																	mbi.sysid_member = @sysid_member), '') +
								'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
								'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
								'][Receipt No.: ' + ISNULL(@receipt_no, '') +

								'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
					
								'][Remarks: ' + ISNULL(@remarks, '') + 
								
								'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

								'][Bank: ' + ISNULL(@bank, '') +
								'][Check No.: ' + ISNULL(@check_no, '') +
							
								'][Is Migrated Entry: ' + ISNULL(@migrated_entry_string, '') +

								'][Credit Entry: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account_credit)), '') +
								']'


		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done	

		FETCH NEXT FROM member_equity_credit_delete_cursor
		INTO @equity_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
				@remarks, @amount_tendered, @bank, @check_no, @is_migrated_entry, @sysid_account_credit, @deleted_by


	END

	CLOSE member_equity_credit_delete_cursor
	DEALLOCATE member_equity_credit_delete_cursor	

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertMemberEquityCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertMemberEquityCredit')
   DROP PROCEDURE lms.InsertMemberEquityCredit
GO

CREATE PROCEDURE lms.InsertMemberEquityCredit

	@sysid_member varchar (50) = '',
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@credit_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@is_migrated_entry bit = 0,

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR (lms.IsCashierSystemUserInfo(@created_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, GETDATE()) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.member_equity_credit
		(
			sysid_member,
			reflected_date,
			receipt_date,
			receipt_no,

			credit_amount,

			remarks,

			amount_tendered,

			bank,
			check_no,

			is_migrated_entry,

			sysid_account_credit,

			created_by
		)
		VALUES
		(
			@sysid_member,
			@reflected_date,
			@receipt_date,
			@receipt_no,

			@credit_amount,

			@remarks,

			@amount_tendered,

			@bank,
			@check_no,

			@is_migrated_entry,

			@sysid_account_credit,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a new member equity credit', 'Member Equity Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertMemberEquityCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateMemberEquityCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateMemberEquityCredit')
   DROP PROCEDURE lms.UpdateMemberEquityCredit
GO

CREATE PROCEDURE lms.UpdateMemberEquityCredit

	@equity_id bigint = 0,
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@credit_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@is_migrated_entry bit = 0,

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR (lms.IsCashierSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, (SELECT
																	created_on
																FROM
																	lms.member_equity_credit
																WHERE
																	(equity_id = @equity_id))) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.member_equity_credit SET
			reflected_date = @reflected_date,
			receipt_date = @receipt_date,
			receipt_no = @receipt_no,

			credit_amount = @credit_amount,

			remarks = @remarks,

			amount_tendered = @amount_tendered,

			bank = @bank,
			check_no = @check_no,

			is_migrated_entry = @is_migrated_entry,

			sysid_account_credit = @sysid_account_credit,

			edited_by = @edited_by
		WHERE
			equity_id = @equity_id
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a member equity credit', 'Member Equity Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateMemberEquityCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteMemberEquityCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteMemberEquityCredit')
   DROP PROCEDURE lms.DeleteMemberEquityCredit
GO

CREATE PROCEDURE lms.DeleteMemberEquityCredit

	@equity_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR (lms.IsCashierSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, 
												(SELECT
														created_on
													FROM
														lms.member_equity_credit
													WHERE
														(equity_id = @equity_id))) = 0)
	BEGIN

		IF EXISTS (SELECT equity_id FROM lms.member_equity_credit WHERE equity_id = @equity_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.member_equity_credit SET
				edited_by = @deleted_by
			WHERE
				equity_id = @equity_id

			DELETE FROM lms.member_equity_credit WHERE equity_id = @equity_id

		END
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a member equity credit', 'Member Equity Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteMemberEquityCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberListMemberEquityCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberListMemberEquityCredit')
   DROP PROCEDURE lms.SelectBySysIDMemberListMemberEquityCredit
GO

CREATE PROCEDURE lms.SelectBySysIDMemberListMemberEquityCredit

	@sysid_member_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			mqc.equity_id AS equity_id,
			mqc.sysid_member AS sysid_member,
			mqc.reflected_date AS reflected_date,
			mqc.receipt_date AS receipt_date,
			mqc.created_on AS received_date,
			mqc.receipt_no AS receipt_no,
			mqc.credit_amount AS credit_amount,
			mqc.remarks AS remarks,
			mqc.amount_tendered AS amount_tendered,
			mqc.bank AS bank,
			mqc.check_no AS check_no,
			mqc.is_migrated_entry AS is_migrated_entry,
			
			--scc.sysid_account_credit
			coa.sysid_account AS sysid_account_credit,
			coa.account_code AS account_code,
			coa.account_name AS account_name,
			coa.is_debit_side_increase AS is_debit_side_increase,
			coa.is_active_account AS is_active_account,

			--coa.accounting_category_id
			acg.accounting_category_id AS accounting_category_id,
			acg.category_description AS category_description
		FROM
			lms.member_equity_credit AS mqc
		INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = mqc.sysid_member
		INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = mqc.sysid_account_credit
		INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
		ORDER BY
			mqc.receipt_date DESC, mqc.reflected_date DESC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query a member equity credit', 'Member Equity Credit'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberListMemberEquityCredit TO db_lmsusers
GO
-------------------------------------------------------------


-- ###################################################END TABLE "member_equity_credit" OBJECTS######################################################






-- ################################################TABLE "in_house_hospitalization_credit" OBJECTS######################################################
-- verifies if the in_house_hospitalization_credit table exists
IF OBJECT_ID('lms.in_house_hospitalization_credit', 'U') IS NOT NULL
	DROP TABLE lms.in_house_hospitalization_credit
GO

CREATE TABLE lms.in_house_hospitalization_credit 			
(
	hospitalization_credit_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT In_House_Hospitalization_Credit_Hospitalization_Credit_ID_PK PRIMARY KEY (hospitalization_credit_id),
	sysid_member varchar (50) NOT NULL
		CONSTRAINT In_House_Hospitalization_Credit_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	reflected_date datetime NOT NULL
		CONSTRAINT In_House_Hospitalization_Credit_Reflected_Date_CK CHECK (CONVERT(varchar, reflected_date, 109) LIKE '%12:00:00:000AM'),
	receipt_date datetime NOT NULL
		CONSTRAINT In_House_Hospitalization_Credit_Receipt_Date_CK CHECK (CONVERT(varchar, receipt_date, 109) LIKE '%12:00:00:000AM'),
	receipt_no varchar (50) NOT NULL,

	credit_amount decimal (12, 2) NOT NULL,

	remarks varchar (100) NULL,

	amount_tendered decimal (12, 2) NULL,

	bank varchar (50) NULL,
	check_no varchar (50) NULL,

	sysid_account_credit varchar (50) NOT NULL
		CONSTRAINT In_House_Hospitalization_Credit_SysID_Account_Credit_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT In_House_Hospitalization_Credit_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT In_House_Hospitalization_Credit_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT In_House_Hospitalization_Credit_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the in_house_hospitalization_credit table 
CREATE INDEX In_House_Hospitalization_Credit_Hospitalization_Credit_ID_Index
	ON lms.in_house_hospitalization_credit (hospitalization_credit_id DESC)
GO
------------------------------------------------------------------

-- create an index of the in_house_hospitalization_credit table 
CREATE INDEX In_House_Hospitalization_Credit_Reflected_Date_Index
	ON lms.in_house_hospitalization_credit (reflected_date DESC)
GO
------------------------------------------------------------------

-- create an index of the in_house_hospitalization_credit table 
CREATE INDEX In_House_Hospitalization_Credit_Receipt_Date_Index
	ON lms.in_house_hospitalization_credit (receipt_date DESC)
GO
------------------------------------------------------------------

-- create an index of the in_house_hospitalization_credit table 
CREATE INDEX In_House_Hospitalization_Credit_Created_On_Index
	ON lms.in_house_hospitalization_credit (created_on DESC)
GO
------------------------------------------------------------------

-- create an index of the in_house_hospitalization_credit table 
CREATE INDEX In_House_Hospitalization_Credit_Created_By_Index
	ON lms.in_house_hospitalization_credit (created_by DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "In_House_Hospitalization_Credit_Trigger_Insert" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Credit_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Credit_Trigger_Insert
GO

CREATE TRIGGER lms.In_House_Hospitalization_Credit_Trigger_Insert
	ON  lms.in_house_hospitalization_credit
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @hospitalization_credit_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@hospitalization_credit_id = i.hospitalization_credit_id,
		@sysid_member = i.sysid_member,
		@reflected_date = i.reflected_date,
		@receipt_date = i.receipt_date,
		@receipt_no = i.receipt_no,

		@credit_amount = i.credit_amount,

		@remarks = i.remarks,

		@amount_tendered = i.amount_tendered,

		@bank = i.bank,
		@check_no = i.check_no,

		@sysid_account_credit = i.sysid_account_credit,

		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new in-house hospitalization credit ' + 
							'[Credit ID: ' + ISNULL(CONVERT(varchar, @hospitalization_credit_id), '') +
							'][Member ID: ' + ISNULL((SELECT mbi.member_id
															FROM 
																lms.member_information AS mbi
															WHERE 
																mbi.sysid_member = @sysid_member), '') +
							'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
															FROM 
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															WHERE 
																mbi.sysid_member = @sysid_member), '') +
							'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
							'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
							'][Receipt No.: ' + ISNULL(@receipt_no, '') +

							'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
				
							'][Remarks: ' + ISNULL(@remarks, '') + 
							
							'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

							'][Bank: ' + ISNULL(@bank, '') +
							'][Check No.: ' + ISNULL(@check_no, '') +

							'][Credit Entry: ' + ISNULL((SELECT
																coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
															FROM
																lms.chart_of_accounts AS coa
															INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
															WHERE
																(coa.sysid_account = @sysid_account_credit)), '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-----------------------------------------------------------------

--verifies that the trigger "In_House_Hospitalization_Credit_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Credit_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Credit_Trigger_Instead_Update
GO

CREATE TRIGGER lms.In_House_Hospitalization_Credit_Trigger_Instead_Update
	ON  lms.in_house_hospitalization_credit
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @hospitalization_credit_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @edited_by varchar (50)
	
	DECLARE @reflected_date_b datetime
	DECLARE @receipt_date_b datetime
	DECLARE @receipt_no_b varchar (50)

	DECLARE @credit_amount_b decimal (12, 2)

	DECLARE @remarks_b varchar (100)

	DECLARE @amount_tendered_b decimal (12, 2)

	DECLARE @bank_b varchar (50)
	DECLARE @check_no_b varchar (50)

	DECLARE @sysid_account_credit_b varchar (50)

	DECLARE @has_update bit

	DECLARE in_house_hospitalization_credit_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.hospitalization_credit_id, i.sysid_member, i.reflected_date, i.receipt_date, i.receipt_no, i.credit_amount,
				i.remarks, i.amount_tendered, i.bank, i.check_no, i.sysid_account_credit, i.edited_by
			FROM INSERTED AS i

	OPEN in_house_hospitalization_credit_update_cursor

	FETCH NEXT FROM in_house_hospitalization_credit_update_cursor
		INTO @hospitalization_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
				@remarks, @amount_tendered, @bank, @check_no, @sysid_account_credit, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@reflected_date_b = ihc.reflected_date,
			@receipt_date_b = ihc.receipt_date,
			@receipt_no_b = ihc.receipt_no,

			@credit_amount_b = ihc.credit_amount,

			@remarks_b = ihc.remarks,

			@amount_tendered_b = ihc.amount_tendered,

			@bank_b = ihc.bank,
			@check_no_b = ihc.check_no,

			@sysid_account_credit_b = ihc.sysid_account_credit
		FROM
			lms.in_house_hospitalization_credit AS ihc
		WHERE
			ihc.hospitalization_credit_id = @hospitalization_credit_id

		SET @transaction_done = ''
		SET @has_update = 0
		
		IF (NOT ISNULL(CONVERT(varchar, @reflected_date, 101), '') = ISNULL(CONVERT(varchar, @reflected_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date Before: ' + ISNULL(CONVERT(varchar, @reflected_date_b, 101), '') + ']' +
														'[Reflected Date After: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, @receipt_date, 101), '') = ISNULL(CONVERT(varchar, @receipt_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date Before: ' + ISNULL(CONVERT(varchar, @receipt_date_b, 101), '') + ']' +
														'[Receipt Date After: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
		END

		IF NOT ISNULL(@receipt_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@receipt_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No. Before: ' + ISNULL(@receipt_no_b, '') + ']' +
														'[Receipt No. After: ' + ISNULL(@receipt_no, '') + ']'
			SET @has_update = 1
		END		
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No.: ' + ISNULL(@receipt_no, '') + ']'
		END

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount_b), 1), '0.00') +  ']' +
														'[Credit Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') +  ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount Tendered Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00') +  ']' +
														'[Amount Tendered After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@bank COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@bank_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Before: ' + ISNULL(@bank_b, '') +  ']' +
														'[Bank After: ' + ISNULL(@bank, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@check_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@check_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check No. Before: ' + ISNULL(@check_no_b, '') +  ']' +
														'[Check No. After: ' + ISNULL(@check_no, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@sysid_account_credit COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_credit_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Entry Before: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit_b)), '') +  ']' +
														'[Credit Entry After: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit)), '') +  ']'
			SET @has_update = 1
		END	

		IF @has_update = 1
		BEGIN

			UPDATE lms.in_house_hospitalization_credit SET
				reflected_date = @reflected_date,
				receipt_date = @receipt_date,
				receipt_no = @receipt_no,

				credit_amount = @credit_amount,

				remarks = @remarks,

				amount_tendered = @amount_tendered,

				bank = @bank,
				check_no = @check_no,

				sysid_account_credit = @sysid_account_credit,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				hospitalization_credit_id = @hospitalization_credit_id

			SET @transaction_done = 'UPDATED an in-house hospitalization credit ' + 
									'[Credit ID: ' + ISNULL(CONVERT(varchar, @hospitalization_credit_id), '') +
									'][Member ID: ' + ISNULL((SELECT mbi.member_id
																	FROM 
																		lms.member_information AS mbi
																	WHERE 
																		mbi.sysid_member = @sysid_member), '') +
									'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																	FROM 
																		lms.person_information AS pri
																	INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																	WHERE 
																		mbi.sysid_member = @sysid_member), '') +
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
			UPDATE lms.in_house_hospitalization_credit SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				hospitalization_credit_id = @hospitalization_credit_id

		END	

		FETCH NEXT FROM in_house_hospitalization_credit_update_cursor
			INTO @hospitalization_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
					@remarks, @amount_tendered, @bank, @check_no, @sysid_account_credit, @edited_by


	END

	CLOSE in_house_hospitalization_credit_update_cursor
	DEALLOCATE in_house_hospitalization_credit_update_cursor

GO
-------------------------------------------------------------------

--verifies that the trigger "In_House_Hospitalization_Credit_Trigger_Delete" already exist
IF OBJECT_ID ('lms.In_House_Hospitalization_Credit_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.In_House_Hospitalization_Credit_Trigger_Delete
GO

CREATE TRIGGER lms.In_House_Hospitalization_Credit_Trigger_Delete
	ON  lms.in_house_hospitalization_credit
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @hospitalization_credit_id bigint
	DECLARE @sysid_member varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @credit_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @deleted_by varchar (50)

	DECLARE in_house_hospitalization_credit_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.hospitalization_credit_id, d.sysid_member, d.reflected_date, d.receipt_date, d.receipt_no, d.credit_amount,
				d.remarks, d.amount_tendered, d.bank, d.check_no, d.sysid_account_credit, d.edited_by
			FROM 
				DELETED AS d

	OPEN in_house_hospitalization_credit_delete_cursor

	FETCH NEXT FROM in_house_hospitalization_credit_delete_cursor
		INTO @hospitalization_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
				@remarks, @amount_tendered, @bank, @check_no, @sysid_account_credit, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SET @transaction_done = 'DELETED an in-house hospitalization credit ' + 
								'[Credit ID: ' + ISNULL(CONVERT(varchar, @hospitalization_credit_id), '') +
								'][Member ID: ' + ISNULL((SELECT mbi.member_id
																FROM 
																	lms.member_information AS mbi
																WHERE 
																	mbi.sysid_member = @sysid_member), '') +
								'][Member Name: ' + ISNULL((SELECT pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																FROM 
																	lms.person_information AS pri
																INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																WHERE 
																	mbi.sysid_member = @sysid_member), '') +
								'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
								'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
								'][Receipt No.: ' + ISNULL(@receipt_no, '') +

								'][Credit Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @credit_amount), 1), '0.00') +
					
								'][Remarks: ' + ISNULL(@remarks, '') + 
								
								'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

								'][Bank: ' + ISNULL(@bank, '') +
								'][Check No.: ' + ISNULL(@check_no, '') +

								'][Credit Entry: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account_credit)), '') +
								']'


		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done	

		FETCH NEXT FROM in_house_hospitalization_credit_delete_cursor
			INTO @hospitalization_credit_id, @sysid_member, @reflected_date, @receipt_date, @receipt_no, @credit_amount,
					@remarks, @amount_tendered, @bank, @check_no, @sysid_account_credit, @deleted_by


	END

	CLOSE in_house_hospitalization_credit_delete_cursor
	DEALLOCATE in_house_hospitalization_credit_delete_cursor	

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertInHouseHospitalizationCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertInHouseHospitalizationCredit')
   DROP PROCEDURE lms.InsertInHouseHospitalizationCredit
GO

CREATE PROCEDURE lms.InsertInHouseHospitalizationCredit

	@sysid_member varchar (50) = '',
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@credit_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR (lms.IsCashierSystemUserInfo(@created_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, GETDATE()) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		INSERT INTO lms.in_house_hospitalization_credit
		(
			sysid_member,
			reflected_date,
			receipt_date,
			receipt_no,

			credit_amount,

			remarks,

			amount_tendered,

			bank,
			check_no,

			sysid_account_credit,

			created_by
		)
		VALUES
		(
			@sysid_member,
			@reflected_date,
			@receipt_date,
			@receipt_no,

			@credit_amount,

			@remarks,

			@amount_tendered,

			@bank,
			@check_no,

			@sysid_account_credit,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a new in-house hospitalization credit', 'In-House Hospitalization Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertInHouseHospitalizationCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateInHouseHospitalizationCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateInHouseHospitalizationCredit')
   DROP PROCEDURE lms.UpdateInHouseHospitalizationCredit
GO

CREATE PROCEDURE lms.UpdateInHouseHospitalizationCredit

	@hospitalization_credit_id bigint = 0,
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@credit_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR (lms.IsCashierSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, (SELECT
																	created_on
																FROM
																	lms.in_house_hospitalization_credit
																WHERE
																	(hospitalization_credit_id = @hospitalization_credit_id))) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.in_house_hospitalization_credit SET
			reflected_date = @reflected_date,
			receipt_date = @receipt_date,
			receipt_no = @receipt_no,

			credit_amount = @credit_amount,

			remarks = @remarks,

			amount_tendered = @amount_tendered,

			bank = @bank,
			check_no = @check_no,

			sysid_account_credit = @sysid_account_credit,

			edited_by = @edited_by
		WHERE
			hospitalization_credit_id = @hospitalization_credit_id
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update an in-house hospitalization credit', 'In-House Hospitalization Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateInHouseHospitalizationCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteInHouseHospitalizationCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteInHouseHospitalizationCredit')
   DROP PROCEDURE lms.DeleteInHouseHospitalizationCredit
GO

CREATE PROCEDURE lms.DeleteInHouseHospitalizationCredit

	@hospitalization_credit_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR (lms.IsCashierSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, 
												(SELECT
														created_on
													FROM
														lms.in_house_hospitalization_credit
													WHERE
														(hospitalization_credit_id = @hospitalization_credit_id))) = 0)
	BEGIN

		IF EXISTS (SELECT hospitalization_credit_id FROM lms.in_house_hospitalization_credit WHERE hospitalization_credit_id = @hospitalization_credit_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.in_house_hospitalization_credit SET
				edited_by = @deleted_by
			WHERE
				hospitalization_credit_id = @hospitalization_credit_id

			DELETE FROM lms.in_house_hospitalization_credit WHERE hospitalization_credit_id = @hospitalization_credit_id

		END
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete an in-house hospitalization credit', 'In-House Hospitalization Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteInHouseHospitalizationCredit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectBySysIDMemberListInHouseHospitalizationCredit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectBySysIDMemberListInHouseHospitalizationCredit')
   DROP PROCEDURE lms.SelectBySysIDMemberListInHouseHospitalizationCredit
GO

CREATE PROCEDURE lms.SelectBySysIDMemberListInHouseHospitalizationCredit

	@sysid_member_list nvarchar (MAX) = '',

	@system_user_id varchar (50) = ''
		
AS

	IF (lms.IsActiveSystemUserInfo(@system_user_id) = 1)
	BEGIN

		SELECT
			ihc.hospitalization_credit_id AS hospitalization_credit_id,
			ihc.sysid_member AS sysid_member,
			ihc.reflected_date AS reflected_date,
			ihc.receipt_date AS receipt_date,
			ihc.created_on AS received_date,
			ihc.receipt_no AS receipt_no,
			ihc.credit_amount AS credit_amount,
			ihc.remarks AS remarks,
			ihc.amount_tendered AS amount_tendered,
			ihc.bank AS bank,
			ihc.check_no AS check_no,
			
			--ihc.sysid_account_credit
			coa.sysid_account AS sysid_account_credit,
			coa.account_code AS account_code,
			coa.account_name AS account_name,
			coa.is_debit_side_increase AS is_debit_side_increase,
			coa.is_active_account AS is_active_account,

			--coa.accounting_category_id
			acg.accounting_category_id AS accounting_category_id,
			acg.category_description AS category_description
		FROM
			lms.in_house_hospitalization_credit AS ihc
		INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = ihc.sysid_member
		INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = ihc.sysid_account_credit
		INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
		ORDER BY
			ihc.receipt_date DESC, ihc.reflected_date DESC
		
	END
	ELSE
	BEGIN				
		
		EXECUTE lms.ShowErrorMsg 'Query an in-house hospitalization credit', 'In-House Hospitalization Credit'
		
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectBySysIDMemberListInHouseHospitalizationCredit TO db_lmsusers
GO
-------------------------------------------------------------


-- ##############################################END TABLE "in_house_hospitalization_credit" OBJECTS######################################################





-- ################################################TABLE "miscellaneous_income" OBJECTS######################################################
-- verifies if the miscellaneous_income table exists
IF OBJECT_ID('lms.miscellaneous_income', 'U') IS NOT NULL
	DROP TABLE lms.miscellaneous_income
GO

CREATE TABLE lms.miscellaneous_income 			
(
	payment_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Miscellaneous_Income_Payment_ID_PK PRIMARY KEY (payment_id),
	received_from varchar (150) NOT NULL,
	sysid_member varchar (50) NULL
		CONSTRAINT Miscellaneous_Income_SysID_Member_FK FOREIGN KEY REFERENCES lms.member_information(sysid_member) ON UPDATE NO ACTION,
	sysid_collector varchar (50) NULL
		CONSTRAINT Miscellaneous_Income_SysID_Collector_FK FOREIGN KEY REFERENCES lms.collector_information(sysid_collector) ON UPDATE NO ACTION,
	reflected_date datetime NOT NULL
		CONSTRAINT Miscellaneous_Income_Reflected_Date_CK CHECK (CONVERT(varchar, reflected_date, 109) LIKE '%12:00:00:000AM'),
	receipt_date datetime NOT NULL
		CONSTRAINT Miscellaneous_Income_Receipt_Date_CK CHECK (CONVERT(varchar, receipt_date, 109) LIKE '%12:00:00:000AM'),
	receipt_no varchar (50) NOT NULL,

	miscellaneous_amount decimal (12, 2) NOT NULL,

	remarks varchar (100) NULL,

	discount_amount decimal (12, 2) NULL,
	amount_tendered decimal (12, 2) NULL,

	bank varchar (50) NULL,
	check_no varchar (50) NULL,

	sysid_account_credit varchar (50) NOT NULL
		CONSTRAINT Miscellaneous_Income_SysID_Account_Credit_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Miscellaneous_Income_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Miscellaneous_Income_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Miscellaneous_Income_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the miscellaneous_income table 
CREATE INDEX Miscellaneous_Income_Payment_ID_Index
	ON lms.miscellaneous_income (payment_id DESC)
GO
------------------------------------------------------------------

-- create an index of the miscellaneous_income table 
CREATE INDEX Miscellaneous_Income_Reflected_Date_Index
	ON lms.miscellaneous_income (reflected_date DESC)
GO
------------------------------------------------------------------

-- create an index of the miscellaneous_income table 
CREATE INDEX Miscellaneous_Income_Receipt_Date_Index
	ON lms.miscellaneous_income (receipt_date DESC)
GO
------------------------------------------------------------------

-- create an index of the miscellaneous_income table 
CREATE INDEX Miscellaneous_Income_Created_On_Index
	ON lms.miscellaneous_income (created_on DESC)
GO
------------------------------------------------------------------

-- create an index of the miscellaneous_income table 
CREATE INDEX Miscellaneous_Income_Created_By_Index
	ON lms.miscellaneous_income (created_by DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Miscellaneous_Income_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Miscellaneous_Income_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Miscellaneous_Income_Trigger_Insert
GO

CREATE TRIGGER lms.Miscellaneous_Income_Trigger_Insert
	ON  lms.miscellaneous_income
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @payment_id bigint
	DECLARE @received_from varchar (150)
	DECLARE @sysid_member varchar (50)
	DECLARE @sysid_collector varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @miscellaneous_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @discount_amount decimal (12, 2)
	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@payment_id = i.payment_id,
		@received_from = i.received_from,
		@sysid_member = i.sysid_member,
		@sysid_collector = i.sysid_collector,
		@reflected_date = i.reflected_date,
		@receipt_date = i.receipt_date,
		@receipt_no = i.receipt_no,

		@miscellaneous_amount = i.miscellaneous_amount,

		@remarks = i.remarks,

		@discount_amount = i.discount_amount,
		@amount_tendered = i.amount_tendered,

		@bank = i.bank,
		@check_no = i.check_no,

		@sysid_account_credit = i.sysid_account_credit,

		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new miscellaneous income ' + 
							'[Payment ID: ' + ISNULL(CONVERT(varchar, @payment_id), '') +
							'][Received From: ' + ISNULL((SELECT '(' + mbi.member_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
															FROM 
																lms.person_information AS pri
															INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
															WHERE 
																mbi.sysid_member = @sysid_member), 
													ISNULL((SELECT '(' + cli.employee_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
															FROM 
																lms.person_information AS pri
															INNER JOIN lms.collector_information AS cli ON cli.sysid_person = pri.sysid_person
															WHERE 
																cli.sysid_collector = @sysid_collector), ISNULL(@received_from, ''))) +
							'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
							'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
							'][Receipt No.: ' + ISNULL(@receipt_no, '') +

							'][Miscellaneous Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @miscellaneous_amount), 1), '0.00') +
				
							'][Remarks: ' + ISNULL(@remarks, '') + 
							
							'][Discount Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @discount_amount), 1), '0.00') +
							'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

							'][Bank: ' + ISNULL(@bank, '') +
							'][Check No.: ' + ISNULL(@check_no, '') +

							'][Credit Entry: ' + ISNULL((SELECT
																coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
															FROM
																lms.chart_of_accounts AS coa
															INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
															WHERE
																(coa.sysid_account = @sysid_account_credit)), '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-----------------------------------------------------------------

--verifies that the trigger "Miscellaneous_Income_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Miscellaneous_Income_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Miscellaneous_Income_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Miscellaneous_Income_Trigger_Instead_Update
	ON  lms.miscellaneous_income
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @payment_id bigint
	DECLARE @received_from varchar (150)
	DECLARE @sysid_member varchar (50)
	DECLARE @sysid_collector varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @miscellaneous_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @discount_amount decimal (12, 2)
	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @edited_by varchar (50)	
	
	DECLARE @received_from_b varchar (150)	
	DECLARE @sysid_member_b varchar (50)
	DECLARE @sysid_collector_b varchar (50)
	DECLARE @reflected_date_b datetime
	DECLARE @receipt_date_b datetime
	DECLARE @receipt_no_b varchar (50)

	DECLARE @miscellaneous_amount_b decimal (12, 2)

	DECLARE @remarks_b varchar (100)

	DECLARE @discount_amount_b decimal (12, 2)
	DECLARE @amount_tendered_b decimal (12, 2)

	DECLARE @bank_b varchar (50)
	DECLARE @check_no_b varchar (50)

	DECLARE @sysid_account_credit_b varchar (50)

	DECLARE @has_update bit

	DECLARE miscellaneous_income_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.payment_id, i.received_from, i.sysid_member, i.sysid_collector, i.reflected_date, i.receipt_date, i.receipt_no, i.miscellaneous_amount,
				i.remarks, i.discount_amount, i.amount_tendered, i.bank, i.check_no, i.sysid_account_credit, i.edited_by
			FROM INSERTED AS i

	OPEN miscellaneous_income_update_cursor

	FETCH NEXT FROM miscellaneous_income_update_cursor
		INTO @payment_id, @received_from, @sysid_member, @sysid_collector, @reflected_date, @receipt_date, @receipt_no, @miscellaneous_amount,
				@remarks, @discount_amount, @amount_tendered, @bank, @check_no, @sysid_account_credit, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@received_from_b = mci.received_from,
			@reflected_date_b = mci.reflected_date,
			@receipt_date_b = mci.receipt_date,
			@receipt_no_b = mci.receipt_no,

			@miscellaneous_amount_b = mci.miscellaneous_amount,

			@remarks_b = mci.remarks,

			@discount_amount_b = mci.discount_amount,
			@amount_tendered_b = mci.amount_tendered,

			@bank_b = mci.bank,
			@check_no_b = mci.check_no,

			@sysid_account_credit_b = mci.sysid_account_credit
		FROM
			lms.miscellaneous_income AS mci
		WHERE
			mci.payment_id = @payment_id

		SET @transaction_done = ''
		SET @has_update = 0

		IF (NOT ISNULL(@received_from COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@received_from_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')) OR
			(NOT ISNULL(@sysid_member COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_member_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')) OR
			(NOT ISNULL(@sysid_collector COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_collector_b COLLATE SQL_Latin1_General_CP1_CS_AS, ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Received From Before: ' + ISNULL((SELECT '(' + mbi.member_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																								FROM 
																									lms.person_information AS pri
																								INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																								WHERE 
																									mbi.sysid_member = @sysid_member_b), 
																						ISNULL((SELECT '(' + cli.employee_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																								FROM 
																									lms.person_information AS pri
																								INNER JOIN lms.collector_information AS cli ON cli.sysid_person = pri.sysid_person
																								WHERE 
																									cli.sysid_collector = @sysid_collector_b), ISNULL(@received_from_b, ''))) + ']' +
														'[Received From After: ' + ISNULL((SELECT '(' + mbi.member_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																								FROM 
																									lms.person_information AS pri
																								INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																								WHERE 
																									mbi.sysid_member = @sysid_member), 
																						ISNULL((SELECT '(' + cli.employee_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																								FROM 
																									lms.person_information AS pri
																								INNER JOIN lms.collector_information AS cli ON cli.sysid_person = pri.sysid_person
																								WHERE 
																									cli.sysid_collector = @sysid_collector), ISNULL(@received_from, ''))) + ']'
			SET @has_update = 1
		END		
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Received From: ' + ISNULL((SELECT '(' + mbi.member_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																						FROM 
																							lms.person_information AS pri
																						INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																						WHERE 
																							mbi.sysid_member = @sysid_member), 
																				ISNULL((SELECT '(' + cli.employee_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																						FROM 
																							lms.person_information AS pri
																						INNER JOIN lms.collector_information AS cli ON cli.sysid_person = pri.sysid_person
																						WHERE 
																							cli.sysid_collector = @sysid_collector), ISNULL(@received_from, ''))) + ']'
		END
		
		IF (NOT ISNULL(CONVERT(varchar, @reflected_date, 101), '') = ISNULL(CONVERT(varchar, @reflected_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date Before: ' + ISNULL(CONVERT(varchar, @reflected_date_b, 101), '') + ']' +
														'[Reflected Date After: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') + ']'
		END

		IF (NOT ISNULL(CONVERT(varchar, @receipt_date, 101), '') = ISNULL(CONVERT(varchar, @receipt_date_b, 101), ''))
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date Before: ' + ISNULL(CONVERT(varchar, @receipt_date_b, 101), '') + ']' +
														'[Receipt Date After: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
			SET @has_update = 1
		END
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') + ']'
		END

		IF NOT ISNULL(@receipt_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@receipt_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No. Before: ' + ISNULL(@receipt_no_b, '') + ']' +
														'[Receipt No. After: ' + ISNULL(@receipt_no, '') + ']'
			SET @has_update = 1
		END		
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Receipt No.: ' + ISNULL(@receipt_no, '') + ']'
		END

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @miscellaneous_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @miscellaneous_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Miscellaneous Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @miscellaneous_amount_b), 1), '0.00') +  ']' +
														'[Miscellaneous Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @miscellaneous_amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(@remarks COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@remarks_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Remarks Before: ' + ISNULL(@remarks_b, '') +  ']' +
														'[Remarks After: ' + ISNULL(@remarks, '') +  ']'
			SET @has_update = 1
		END	

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @discount_amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @discount_amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Discounted Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @discount_amount_b), 1), '0.00') +  ']' +
														'[Discounted Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @discount_amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount Tendered Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered_b), 1), '0.00') +  ']' +
														'[Amount Tendered After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@bank COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@bank_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Bank Before: ' + ISNULL(@bank_b, '') +  ']' +
														'[Bank After: ' + ISNULL(@bank, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@check_no COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@check_no_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Check No. Before: ' + ISNULL(@check_no_b, '') +  ']' +
														'[Check No. After: ' + ISNULL(@check_no, '') +  ']'
			SET @has_update = 1
		END		

		IF NOT ISNULL(@sysid_account_credit COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_credit_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Credit Entry Before: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit_b)), '') +  ']' +
														'[Credit Entry After: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_credit)), '') +  ']'
			SET @has_update = 1
		END	

		IF @has_update = 1
		BEGIN

			UPDATE lms.miscellaneous_income SET
				received_from = @received_from,
				sysid_member = @sysid_member,
				sysid_collector = @sysid_collector,
				reflected_date = @reflected_date,
				receipt_date = @receipt_date,
				receipt_no = @receipt_no,

				miscellaneous_amount = @miscellaneous_amount,

				remarks = @remarks,

				discount_amount = @discount_amount,
				amount_tendered = @amount_tendered,

				bank = @bank,
				check_no = @check_no,

				sysid_account_credit = @sysid_account_credit,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				payment_id = @payment_id

			SET @transaction_done = 'UPDATED a miscellaneous income ' + 
									'[Payment ID: ' + ISNULL(CONVERT(varchar, @payment_id), '') +
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
			UPDATE lms.miscellaneous_income SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				payment_id = @payment_id

		END	

		FETCH NEXT FROM miscellaneous_income_update_cursor
			INTO @payment_id, @received_from, @sysid_member, @sysid_collector, @reflected_date, @receipt_date, @receipt_no, @miscellaneous_amount,
					@remarks, @discount_amount, @amount_tendered, @bank, @check_no, @sysid_account_credit, @edited_by


	END

	CLOSE miscellaneous_income_update_cursor
	DEALLOCATE miscellaneous_income_update_cursor

GO
-------------------------------------------------------------------

--verifies that the trigger "Miscellaneous_Income_Trigger_Delete" already exist
IF OBJECT_ID ('lms.Miscellaneous_Income_Trigger_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Miscellaneous_Income_Trigger_Delete
GO

CREATE TRIGGER lms.Miscellaneous_Income_Trigger_Delete
	ON  lms.miscellaneous_income
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @payment_id bigint
	DECLARE @received_from varchar (150)
	DECLARE @sysid_member varchar (50)
	DECLARE @sysid_collector varchar (50)
	DECLARE @reflected_date datetime
	DECLARE @receipt_date datetime
	DECLARE @receipt_no varchar (50)

	DECLARE @miscellaneous_amount decimal (12, 2)

	DECLARE @remarks varchar (100)

	DECLARE @discount_amount decimal (12, 2)
	DECLARE @amount_tendered decimal (12, 2)

	DECLARE @bank varchar (50)
	DECLARE @check_no varchar (50)

	DECLARE @sysid_account_credit varchar (50)

	DECLARE @deleted_by varchar (50)

	DECLARE miscellaneous_income_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.payment_id, d.received_from, d.sysid_member, d.sysid_collector, d.reflected_date, d.receipt_date, d.receipt_no, d.miscellaneous_amount,
				d.remarks, d.discount_amount, d.amount_tendered, d.bank, d.check_no, d.sysid_account_credit, d.edited_by
			FROM 
				DELETED AS d

	OPEN miscellaneous_income_delete_cursor

	FETCH NEXT FROM miscellaneous_income_delete_cursor
		INTO @payment_id, @received_from, @sysid_member, @sysid_collector, @reflected_date, @receipt_date, @receipt_no, @miscellaneous_amount,
				@remarks, @discount_amount, @amount_tendered, @bank, @check_no, @sysid_account_credit, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SET @transaction_done = 'DELETED a miscellaneous income ' + 
								'[Payment ID: ' + ISNULL(CONVERT(varchar, @payment_id), '') +
								'][Received From: ' + ISNULL((SELECT '(' + mbi.member_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																FROM 
																	lms.person_information AS pri
																INNER JOIN lms.member_information AS mbi ON mbi.sysid_person = pri.sysid_person
																WHERE 
																	mbi.sysid_member = @sysid_member), 
														ISNULL((SELECT '(' + cli.employee_id + ') ' + pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') 
																FROM 
																	lms.person_information AS pri
																INNER JOIN lms.collector_information AS cli ON cli.sysid_person = pri.sysid_person
																WHERE 
																	cli.sysid_collector = @sysid_collector), ISNULL(@received_from, ''))) +
								'][Reflected Date: ' + ISNULL(CONVERT(varchar, @reflected_date, 101), '') +
								'][Receipt Date: ' + ISNULL(CONVERT(varchar, @receipt_date, 101), '') +
								'][Receipt No.: ' + ISNULL(@receipt_no, '') +

								'][Miscellaneous Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @miscellaneous_amount), 1), '0.00') +
					
								'][Remarks: ' + ISNULL(@remarks, '') + 
								
								'][Discount Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @discount_amount), 1), '0.00') +
								'][Amount Tendered: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_tendered), 1), '0.00') +

								'][Bank: ' + ISNULL(@bank, '') +
								'][Check No.: ' + ISNULL(@check_no, '') +

								'][Credit Entry: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account_credit)), '') +
								']'


		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done	

		FETCH NEXT FROM miscellaneous_income_delete_cursor
			INTO @payment_id, @received_from, @sysid_member, @sysid_collector, @reflected_date, @receipt_date, @receipt_no, @miscellaneous_amount,
					@remarks, @discount_amount, @amount_tendered, @bank, @check_no, @sysid_account_credit, @deleted_by


	END

	CLOSE miscellaneous_income_delete_cursor
	DEALLOCATE miscellaneous_income_delete_cursor	

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertMiscellaneousIncome" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertMiscellaneousIncome')
   DROP PROCEDURE lms.InsertMiscellaneousIncome
GO

CREATE PROCEDURE lms.InsertMiscellaneousIncome

	@received_from varchar (150) = '',
	@sysid_member varchar (50) = '',
	@sysid_collector varchar (50) = '',
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@miscellaneous_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@discount_amount decimal (12, 2) = 0.00,
	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR (lms.IsCashierSystemUserInfo(@created_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, GETDATE()) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		IF (NOT @sysid_member IS NULL)
		BEGIN
			SET @sysid_collector = NULL
		END
		ELSE IF (NOT @sysid_collector IS NULL)
		BEGIN
			SET @sysid_member = NULL
		END

		INSERT INTO lms.miscellaneous_income
		(
			received_from,
			sysid_member,
			sysid_collector,
			reflected_date,
			receipt_date,
			receipt_no,

			miscellaneous_amount,

			remarks,

			discount_amount,
			amount_tendered,

			bank,
			check_no,

			sysid_account_credit,

			created_by
		)
		VALUES
		(
			@received_from,
			@sysid_member,
			@sysid_collector,
			@reflected_date,
			@receipt_date,
			@receipt_no,

			@miscellaneous_amount,

			@remarks,

			@discount_amount,
			@amount_tendered,

			@bank,
			@check_no,

			@sysid_account_credit,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a new miscellaneous income', 'Miscellaneous Income'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertMiscellaneousIncome TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateMiscellaneousIncome" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateMiscellaneousIncome')
   DROP PROCEDURE lms.UpdateMiscellaneousIncome
GO

CREATE PROCEDURE lms.UpdateMiscellaneousIncome

	@payment_id bigint = 0,
	@received_from varchar (150) = '',
	@sysid_member varchar (50) = '',
	@sysid_collector varchar (50) = '',
	@reflected_date datetime,
	@receipt_date datetime,
	@receipt_no varchar (50) = '',

	@miscellaneous_amount decimal (12, 2) = 0.00,

	@remarks varchar (100) = '',

	@discount_amount decimal (12, 2) = 0.00,
	@amount_tendered decimal (12, 2) = 0.00,

	@bank varchar (50) = '',
	@check_no varchar (50) = '',

	@sysid_account_credit varchar (50) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR (lms.IsCashierSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(@receipt_date, (SELECT
																	created_on
																FROM
																	lms.miscellaneous_income
																WHERE
																	(payment_id = @payment_id))) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		IF (NOT @sysid_member IS NULL)
		BEGIN
			SET @sysid_collector = NULL
		END
		ELSE IF (NOT @sysid_collector IS NULL)
		BEGIN
			SET @sysid_member = NULL
		END

		UPDATE lms.miscellaneous_income SET
			received_from = @received_from,
			sysid_member = @sysid_member,
			sysid_collector = @sysid_collector,
			reflected_date = @reflected_date,
			receipt_date = @receipt_date,
			receipt_no = @receipt_no,

			miscellaneous_amount = @miscellaneous_amount,

			remarks = @remarks,

			discount_amount = @discount_amount,
			amount_tendered = @amount_tendered,

			bank = @bank,
			check_no = @check_no,

			sysid_account_credit = @sysid_account_credit,

			edited_by = @edited_by
		WHERE
			payment_id = @payment_id
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a miscellaneous income', 'Miscellaneous Income'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateMiscellaneousIncome TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteMiscellaneousIncome" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteMiscellaneousIncome')
   DROP PROCEDURE lms.DeleteMiscellaneousIncome
GO

CREATE PROCEDURE lms.DeleteMiscellaneousIncome

	@payment_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR (lms.IsCashierSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, 
												(SELECT
														created_on
													FROM
														lms.miscellaneous_income
													WHERE
														(payment_id = @payment_id))) = 0)
	BEGIN

		IF EXISTS (SELECT payment_id FROM lms.miscellaneous_income WHERE payment_id = @payment_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.miscellaneous_income SET
				edited_by = @deleted_by
			WHERE
				payment_id = @payment_id

			DELETE FROM lms.miscellaneous_income WHERE payment_id = @payment_id

		END
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a share capital credit', 'Share Capital Credit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteMiscellaneousIncome TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByQueryStringDateStartEndMiscellaneousIncome" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByQueryStringDateStartEndMiscellaneousIncome')
   DROP PROCEDURE lms.SelectByQueryStringDateStartEndMiscellaneousIncome
GO

CREATE PROCEDURE lms.SelectByQueryStringDateStartEndMiscellaneousIncome
	
	@query_string varchar (50) = '',
	@date_start datetime,
	@date_end datetime,

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR 
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
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

			SELECT
				mci.payment_id AS payment_id,
				mci.received_from AS received_from,
				mci.sysid_member AS sysid_member,
				mci.sysid_collector AS sysid_collector,
				mci.reflected_date AS reflected_date,
				mci.receipt_date AS receipt_date,
				mci.created_on AS received_date,
				mci.receipt_no AS receipt_no,
				mci.remarks AS remarks,
				mci.miscellaneous_amount AS miscellaneous_amount,
				mci.discount_amount AS discount_amount,
				mci.amount_tendered AS amount_tendered,
				mci.bank AS bank,
				mci.check_no AS check_no,
				coa.sysid_account AS sysid_account_credit,
				coa.account_code AS account_code,
				coa.account_name AS account_name
			FROM
				lms.miscellaneous_income AS mci
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = mci.sysid_account_credit
			WHERE
				(mci.received_from LIKE @query_string) OR 
				((REPLACE(mci.received_from, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.receipt_no LIKE @query_string) OR 
				((REPLACE(mci.receipt_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.remarks LIKE @query_string) OR 
				((REPLACE(mci.remarks, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.bank LIKE @query_string) OR 
				((REPLACE(mci.bank, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.check_no LIKE @query_string) OR 
				((REPLACE(mci.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))
			ORDER BY
				mci.reflected_date ASC, mci.received_from ASC, coa.account_code ASC

		END
		ELSE IF (NOT ISNULL(@query_string, '') = '%*%') AND ((NOT @date_start IS NULL) AND (NOT @date_end IS NULL))		-- (01)
		BEGIN

			SELECT
				mci.payment_id AS payment_id,
				mci.received_from AS received_from,
				mci.sysid_member AS sysid_member,
				mci.sysid_collector AS sysid_collector,
				mci.reflected_date AS reflected_date,
				mci.receipt_date AS receipt_date,
				mci.created_on AS received_date,
				mci.receipt_no AS receipt_no,
				mci.remarks AS remarks,
				mci.miscellaneous_amount AS miscellaneous_amount,
				mci.discount_amount AS discount_amount,
				mci.amount_tendered AS amount_tendered,
				mci.bank AS bank,
				mci.check_no AS check_no,
				coa.sysid_account AS sysid_account_credit,
				coa.account_code AS account_code,
				coa.account_name AS account_name
			FROM
				lms.miscellaneous_income AS mci
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = mci.sysid_account_credit
			WHERE
				((mci.received_from LIKE @query_string) OR 
				((REPLACE(mci.received_from, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.receipt_no LIKE @query_string) OR 
				((REPLACE(mci.receipt_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.remarks LIKE @query_string) OR 
				((REPLACE(mci.remarks, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.bank LIKE @query_string) OR 
				((REPLACE(mci.bank, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(mci.check_no LIKE @query_string) OR 
				((REPLACE(mci.check_no, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_code LIKE @query_string) OR 
				((REPLACE(coa.account_code, ' ', '')) LIKE REPLACE(@query_string, ' ', '')) OR
				(coa.account_name LIKE @query_string) OR 
				((REPLACE(coa.account_name, ' ', '')) LIKE REPLACE(@query_string, ' ', ''))) AND
				((mci.reflected_date BETWEEN @date_start AND @date_end) OR
				(mci.created_on BETWEEN @date_start AND @date_end))	
			ORDER BY
				mci.reflected_date ASC, mci.received_from ASC, coa.account_code ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND ((@date_start IS NULL) OR (@date_end IS NULL))				-- (10)	
		BEGIN

			SELECT
				mci.payment_id AS payment_id,
				mci.received_from AS received_from,
				mci.sysid_member AS sysid_member,
				mci.sysid_collector AS sysid_collector,
				mci.reflected_date AS reflected_date,
				mci.receipt_date AS receipt_date,
				mci.created_on AS received_date,
				mci.receipt_no AS receipt_no,
				mci.remarks AS remarks,
				mci.miscellaneous_amount AS miscellaneous_amount,
				mci.discount_amount AS discount_amount,
				mci.amount_tendered AS amount_tendered,
				mci.bank AS bank,
				mci.check_no AS check_no,
				coa.sysid_account AS sysid_account_credit,
				coa.account_code AS account_code,
				coa.account_name AS account_name
			FROM
				lms.miscellaneous_income AS mci
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = mci.sysid_account_credit
			ORDER BY
				mci.reflected_date ASC, mci.received_from ASC, coa.account_code ASC

		END
		ELSE IF (ISNULL(@query_string, '') = '%*%') AND ((NOT @date_start IS NULL) AND (NOT @date_end IS NULL))		-- (11)
		BEGIN

			SELECT
				mci.payment_id AS payment_id,
				mci.received_from AS received_from,
				mci.sysid_member AS sysid_member,
				mci.sysid_collector AS sysid_collector,
				mci.reflected_date AS reflected_date,
				mci.receipt_date AS receipt_date,
				mci.created_on AS received_date,
				mci.receipt_no AS receipt_no,
				mci.remarks AS remarks,
				mci.miscellaneous_amount AS miscellaneous_amount,
				mci.discount_amount AS discount_amount,
				mci.amount_tendered AS amount_tendered,
				mci.bank AS bank,
				mci.check_no AS check_no,
				coa.sysid_account AS sysid_account_credit,
				coa.account_code AS account_code,
				coa.account_name AS account_name
			FROM
				lms.miscellaneous_income AS mci
			INNER JOIN lms.chart_of_accounts AS coa ON coa.sysid_account = mci.sysid_account_credit
			WHERE
				((mci.reflected_date BETWEEN @date_start AND @date_end) OR
				(mci.created_on BETWEEN @date_start AND @date_end))	
			ORDER BY
				mci.reflected_date ASC, mci.received_from ASC, coa.account_code ASC

		END

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a miscellaneous income', 'Miscellaneous Income'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByQueryStringDateStartEndMiscellaneousIncome TO db_lmsusers
GO
-------------------------------------------------------------


-- ##############################################END TABLE "miscellaneous_income" OBJECTS######################################################





-- ################################################TABLE "breakdown_bank_deposit" OBJECTS######################################################
-- verifies if the breakdown_bank_deposit table exists
IF OBJECT_ID('lms.breakdown_bank_deposit', 'U') IS NOT NULL
	DROP TABLE lms.breakdown_bank_deposit
GO

CREATE TABLE lms.breakdown_bank_deposit 			
(
	breakdown_id bigint NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION
		CONSTRAINT Breakdown_Bank_Deposit_Breakdown_ID_PK PRIMARY KEY (breakdown_id),
	date_start datetime NOT NULL
		CONSTRAINT Breakdown_Bank_Deposit_Date_Start_CK CHECK (CONVERT(varchar, date_start, 109) LIKE '%12:00:00:000AM'),
	date_end datetime NOT NULL
		CONSTRAINT Breakdown_Bank_Deposit_Date_End_CK CHECK (CONVERT(varchar, date_end, 109) LIKE '%11:59:59:000PM'),
	amount decimal (12, 2) NOT NULL,
	sysid_account varchar (50) NOT NULL
		CONSTRAINT Breakdown_Bank_Deposit_SysID_Account_FK FOREIGN KEY REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION,

	created_on datetime NOT NULL DEFAULT (GETDATE()),
	created_by varchar (50) NOT NULL
		CONSTRAINT Breakdown_Bank_Deposit_Created_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,
	edited_on datetime NULL,
	edited_by varchar (50) NULL	
		CONSTRAINT Breakdown_Bank_Deposit_Edited_By_FK FOREIGN KEY REFERENCES lms.system_user_info(system_user_id) ON UPDATE NO ACTION,

	unique_id uniqueidentifier ROWGUIDCOL NOT NULL DEFAULT NEWSEQUENTIALID()
		CONSTRAINT Breakdown_Bank_Deposit_Unique_ID_UQ UNIQUE (unique_id)
	
) ON [PRIMARY]
GO
--------------------------------------------------------

-- create an index of the breakdown_bank_deposit table 
CREATE INDEX Breakdown_Bank_Deposit_Breakdown_ID_Index
	ON lms.breakdown_bank_deposit (breakdown_id DESC)
GO
------------------------------------------------------------------

-- create an index of the breakdown_bank_deposit table 
CREATE INDEX Breakdown_Bank_Deposit_Date_Start_Index
	ON lms.breakdown_bank_deposit (date_start DESC)
GO
------------------------------------------------------------------

-- create an index of the breakdown_bank_deposit table 
CREATE INDEX Breakdown_Bank_Deposit_Date_End_Index
	ON lms.breakdown_bank_deposit (date_end DESC)
GO
------------------------------------------------------------------

--verifies that the trigger "Breakdown_Bank_Deposit_Trigger_Insert" already exist
IF OBJECT_ID ('lms.Breakdown_Bank_Deposit_Trigger_Insert','TR') IS NOT NULL
   DROP TRIGGER lms.Breakdown_Bank_Deposit_Trigger_Insert
GO

CREATE TRIGGER lms.Breakdown_Bank_Deposit_Trigger_Insert
	ON  lms.breakdown_bank_deposit
	FOR INSERT
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @breakdown_id bigint
	DECLARE @date_start datetime
	DECLARE @date_end datetime
	DECLARE @amount decimal (12, 2)
	DECLARE @sysid_account varchar (50)

	DECLARE @created_by varchar (50)
	
	SELECT 
		@breakdown_id = i.breakdown_id,
		@date_start = i.date_start,
		@date_end = i.date_end,
		@amount = i.amount,
		@sysid_account = i.sysid_account,

		@created_by = i.created_by
	FROM INSERTED AS i

	SET @transaction_done = 'CREATED a new breakdown of bank deposit ' + 
							'[Breakdown ID: ' + ISNULL(CONVERT(varchar, @breakdown_id), '') +
							'][Date Start: ' + ISNULL(CONVERT(varchar, @date_start, 101), '') +
							'][Date End: ' + ISNULL(CONVERT(varchar, @date_end, 101), '') +
							'][Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount), 1), '0.00') +
							'][Account Entry: ' + ISNULL((SELECT
																coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
															FROM
																lms.chart_of_accounts AS coa
															INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
															WHERE
																(coa.sysid_account = @sysid_account)), '') +
							']'

	IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
	BEGIN
		SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @created_by
	END
			
	EXECUTE lms.InsertTransactionLog @created_by, @network_information, @transaction_done	

GO
-----------------------------------------------------------------

--verifies that the trigger "Breakdown_Bank_Deposit_Trigger_Instead_Update" already exist
IF OBJECT_ID ('lms.Breakdown_Bank_Deposit_Trigger_Instead_Update','TR') IS NOT NULL
   DROP TRIGGER lms.Breakdown_Bank_Deposit_Trigger_Instead_Update
GO

CREATE TRIGGER lms.Breakdown_Bank_Deposit_Trigger_Instead_Update
	ON  lms.breakdown_bank_deposit
	INSTEAD OF UPDATE
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @breakdown_id bigint
	DECLARE @date_start datetime
	DECLARE @date_end datetime
	DECLARE @amount decimal (12, 2)
	DECLARE @sysid_account varchar (50)

	DECLARE @edited_by varchar (50)
	
	DECLARE @amount_b decimal (12, 2)
	DECLARE @sysid_account_b varchar (50)

	DECLARE @has_update bit

	DECLARE breakdown_bank_deposit_update_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT i.breakdown_id, i.date_start, i.date_end, i.amount, i.sysid_account, i.edited_by
			FROM INSERTED AS i

	OPEN breakdown_bank_deposit_update_cursor

	FETCH NEXT FROM breakdown_bank_deposit_update_cursor
		INTO @breakdown_id, @date_start, @date_end, @amount, @sysid_account, @edited_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SELECT
			@amount_b = bbd.amount,
			@sysid_account_b = bbd.sysid_account
		FROM
			lms.breakdown_bank_deposit AS bbd
		WHERE
			bbd.breakdown_id = @breakdown_id

		SET @transaction_done = ''
		SET @has_update = 0

		IF NOT ISNULL(CONVERT(varchar, CONVERT(money, @amount), 1), '0.00') = ISNULL(CONVERT(varchar, CONVERT(money, @amount_b), 1), '0.00')
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount Before: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount_b), 1), '0.00') +  ']' +
														'[Amount After: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount), 1), '0.00') +  ']'
			SET @has_update = 1
		END	
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount), 1), '0.00') +  ']'
		END

		IF NOT ISNULL(@sysid_account COLLATE SQL_Latin1_General_CP1_CS_AS, '') = ISNULL(@sysid_account_b COLLATE SQL_Latin1_General_CP1_CS_AS, '')
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Entry Before: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account_b)), '') +  ']' +
														'[Account Entry After: ' + ISNULL((SELECT
																								coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																							FROM
																								lms.chart_of_accounts AS coa
																							INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																							WHERE
																								(coa.sysid_account = @sysid_account)), '') +  ']'
			SET @has_update = 1
		END		
		ELSE
		BEGIN
			SET @transaction_done = @transaction_done + '[Account Entry: ' + ISNULL((SELECT
																							coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																						FROM
																							lms.chart_of_accounts AS coa
																						INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																						WHERE
																							(coa.sysid_account = @sysid_account)), '') +  ']'
		END

		IF @has_update = 1
		BEGIN

			UPDATE lms.breakdown_bank_deposit SET
				amount = @amount,
				sysid_account = @sysid_account,

				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				breakdown_id = @breakdown_id

			SET @transaction_done = 'UPDATED a breakdown of bank deposit ' + 
									'[Breakdown ID: ' + ISNULL(CONVERT(varchar, @breakdown_id), '') +
									'][Date Start: ' + ISNULL(CONVERT(varchar, @date_start, 101), '') +
									'][Date End: ' + ISNULL(CONVERT(varchar, @date_end, 101), '') +
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
			UPDATE lms.breakdown_bank_deposit SET
				edited_on = GETDATE(),
				edited_by = @edited_by
			WHERE
				breakdown_id = @breakdown_id

		END	

		FETCH NEXT FROM breakdown_bank_deposit_update_cursor
			INTO @breakdown_id, @date_start, @date_end, @amount, @sysid_account, @edited_by


	END

	CLOSE breakdown_bank_deposit_update_cursor
	DEALLOCATE breakdown_bank_deposit_update_cursor

GO
-------------------------------------------------------------------

--verifies that the trigger "Breakdown_Bank_Deposit_Trigger_Instead_Delete" already exist
IF OBJECT_ID ('lms.Breakdown_Bank_Deposit_Trigger_Instead_Delete','TR') IS NOT NULL
   DROP TRIGGER lms.Breakdown_Bank_Deposit_Trigger_Instead_Delete
GO

CREATE TRIGGER lms.Breakdown_Bank_Deposit_Trigger_Instead_Delete
	ON  lms.breakdown_bank_deposit
	FOR DELETE 
	NOT FOR REPLICATION
AS 

	DECLARE @network_information varchar (MAX)
	DECLARE @transaction_done varchar(MAX)

	DECLARE @breakdown_id bigint
	DECLARE @date_start datetime
	DECLARE @date_end datetime
	DECLARE @amount decimal (12, 2)
	DECLARE @sysid_account varchar (50)
	
	DECLARE @deleted_by varchar (50)

	DECLARE breakdown_bank_deposit_delete_cursor CURSOR LOCAL FORWARD_ONLY STATIC READ_ONLY 
		FOR SELECT d.breakdown_id, d.date_start, d.date_end, d.amount, d.sysid_account, d.edited_by
			FROM 
				DELETED AS d

	OPEN breakdown_bank_deposit_delete_cursor

	FETCH NEXT FROM breakdown_bank_deposit_delete_cursor
		INTO @breakdown_id, @date_start, @date_end, @amount, @sysid_account, @deleted_by

	WHILE @@FETCH_STATUS = 0
	BEGIN

		SET @transaction_done = 'DELETED a breakdown of bank deposit ' + 
								'[Breakdown ID: ' + ISNULL(CONVERT(varchar, @breakdown_id), '') +
								'][Date Start: ' + ISNULL(CONVERT(varchar, @date_start, 101), '') +
								'][Date End: ' + ISNULL(CONVERT(varchar, @date_end, 101), '') +
								'][Amount: ' + ISNULL(CONVERT(varchar, CONVERT(money, @amount), 1), '0.00') +
								'][Account Entry: ' + ISNULL((SELECT
																	coa.account_code + ' - ' + coa.account_name + ' (' + acg.category_description + ')'
																FROM
																	lms.chart_of_accounts AS coa
																INNER JOIN lms.accounting_category AS acg ON acg.accounting_category_id = coa.accounting_category_id
																WHERE
																	(coa.sysid_account = @sysid_account)), '') +
								']'

		IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE NAME = '##lms_network_information_table')
		BEGIN
			SELECT @network_information = network_information FROM ##lms_network_information_table WHERE system_user_id = @deleted_by
		END
				
		EXECUTE lms.InsertTransactionLog @deleted_by, @network_information, @transaction_done	

		FETCH NEXT FROM breakdown_bank_deposit_delete_cursor
			INTO @breakdown_id, @date_start, @date_end, @amount, @sysid_account, @deleted_by


	END

	CLOSE breakdown_bank_deposit_delete_cursor
	DEALLOCATE breakdown_bank_deposit_delete_cursor	

GO
-----------------------------------------------------------------

-- verifies if the procedure "InsertBreakdownBankDeposit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'InsertBreakdownBankDeposit')
   DROP PROCEDURE lms.InsertBreakdownBankDeposit
GO

CREATE PROCEDURE lms.InsertBreakdownBankDeposit

	@date_start datetime,
	@date_end datetime,
	@amount decimal (12, 2) = 0.00,
	@sysid_account varchar (50) = '',

	@network_information varchar (MAX) = '',
	@created_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@created_by) = 1) OR (lms.IsCashierSystemUserInfo(@created_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, GETDATE()) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @created_by, @network_information

		
		INSERT INTO lms.breakdown_bank_deposit
		(
			date_start,
			date_end,
			amount,
			sysid_account,

			created_by
		)
		VALUES
		(
			@date_start,
			@date_end,
			@amount,
			@sysid_account,

			@created_by
		)		
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Create a new breakdown of bank deposit', 'Breakdown of Bank Deposit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.InsertBreakdownBankDeposit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "UpdateBreakdownBankDeposit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'UpdateBreakdownBankDeposit')
   DROP PROCEDURE lms.UpdateBreakdownBankDeposit
GO

CREATE PROCEDURE lms.UpdateBreakdownBankDeposit

	@breakdown_id bigint = 0,
	@date_start datetime,
	@date_end datetime,
	@amount decimal (12, 2) = 0.00,
	@sysid_account varchar (50) = '',

	@network_information varchar (MAX) = '',
	@edited_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@edited_by) = 1) OR (lms.IsCashierSystemUserInfo(@edited_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, (SELECT
															created_on
														FROM
															lms.breakdown_bank_deposit
														WHERE
															(breakdown_id = @breakdown_id))) = 0)
	BEGIN

		EXECUTE lms.CreateTemporaryTable @edited_by, @network_information

		UPDATE lms.breakdown_bank_deposit SET
			amount = @amount,
			sysid_account = @sysid_account,

			edited_by = @edited_by
		WHERE
			breakdown_id = @breakdown_id
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Update a breakdown of bank deposit', 'Breakdown of Bank Deposit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.UpdateBreakdownBankDeposit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "DeleteBreakdownBankDeposit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'DeleteBreakdownBankDeposit')
   DROP PROCEDURE lms.DeleteBreakdownBankDeposit
GO

CREATE PROCEDURE lms.DeleteBreakdownBankDeposit

	@breakdown_id bigint = 0,

	@network_information varchar (MAX) = '',
	@deleted_by varchar (50) = ''	
		
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@deleted_by) = 1) OR (lms.IsCashierSystemUserInfo(@deleted_by) = 1)) AND
		(lms.IsRecordLockByReflectedCreatedDate(NULL, (SELECT
															created_on
														FROM
															lms.breakdown_bank_deposit
														WHERE
															(breakdown_id = @breakdown_id))) = 0)
	BEGIN

		IF EXISTS (SELECT breakdown_id FROM lms.breakdown_bank_deposit WHERE breakdown_id = @breakdown_id)
		BEGIN

			EXECUTE lms.CreateTemporaryTable @deleted_by, @network_information

			UPDATE lms.breakdown_bank_deposit SET
				edited_by = @deleted_by
			WHERE
				breakdown_id = @breakdown_id

			DELETE FROM lms.breakdown_bank_deposit WHERE breakdown_id = @breakdown_id

		END
		
	END
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Delete a breakdown of bank deposit', 'Breakdown of Bank Deposit'
	END
	
GO
---------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.DeleteBreakdownBankDeposit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit')
   DROP PROCEDURE lms.SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit
GO

CREATE PROCEDURE lms.SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit
	
	@date_start datetime,
	@date_end datetime,
	@is_consolidated bit = 0,

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR 
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
	BEGIN
	
		--NOTE: should not use INSERT... SELECT because this will called in another function

		WITH cte_breakdown_bank_deposit(breakdown_id, date_start, date_end, amount, sysid_account) AS
		(
			SELECT	
				bbd.breakdown_id AS breakdown_id,
				bbd.date_start AS date_start,
				bbd.date_end AS date_end,
				bbd.amount AS amount,
				bbd.sysid_account AS sysid_account
			FROM
				lms.breakdown_bank_deposit AS bbd
			WHERE
				((bbd.date_start BETWEEN @date_start AND @date_end) AND
				(bbd.date_end BETWEEN @date_start AND @date_end)) AND
				(((@is_consolidated = 0) AND (bbd.created_by = @system_user_id)) OR
				(@is_consolidated = 1))
		)

		SELECT
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			bbp.breakdown_id AS breakdown_id,
			bbp.date_start AS date_start,
			bbp.date_end AS date_end,
			bbp.amount AS amount
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		INNER JOIN cte_breakdown_bank_deposit AS bbp ON bbp.sysid_account = coa.sysid_account
		ORDER BY
			account_code_summary ASC, account_code ASC

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a breakdown of bank deposit', 'Breakdown of Bank Deposit'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit')
   DROP PROCEDURE lms.SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit
GO

CREATE PROCEDURE lms.SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit
	
	@date_start datetime,
	@date_end datetime,
	@is_consolidated bit = 0,

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR 
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
	BEGIN

		DECLARE @breakdown_bank_deposit_detailed TABLE (table_id bigint IDENTITY(1, 1) NOT NULL PRIMARY KEY,
												sysid_account varchar (50) NOT NULL,
												account_code varchar (50) NOT NULL,
												account_name varchar (150) NOT NULL,
												sysid_account_summary varchar (50) NULL,
												account_code_summary varchar (50) NULL,
												account_name_summary varchar (150) NULL,
												breakdown_id bigint NOT NULL,
												date_start datetime NOT NULL,
												date_end datetime NOT NULL,
												amount decimal (12, 2) NOT NULL)


		INSERT INTO @breakdown_bank_deposit_detailed (sysid_account, account_code, account_name, sysid_account_summary, account_code_summary,
				account_name_summary, breakdown_id, date_start, date_end, amount)
		EXECUTE 
				lms.SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit @date_start, @date_end, @is_consolidated, @system_user_id

		SELECT
			summary_coa.account_code AS account_code_summary,						
			summary_coa.account_name AS account_name_summary,
			coa.account_code AS account_code_subsidiary,
			coa.account_name AS account_name_subsidiary,
			summary_bbd.amount AS total_amount
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		INNER JOIN
		(
			SELECT
				sum_bbd.sysid_account AS sysid_account,
				SUM(sum_bbd.amount) AS amount
			FROM
				@breakdown_bank_deposit_detailed AS sum_bbd
			GROUP BY
				sum_bbd.sysid_account
		) AS summary_bbd ON summary_bbd.sysid_account = coa.sysid_account
		ORDER BY
			account_code_summary ASC

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query a breakdown of bank deposit', 'Breakdown of Bank Deposit'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome')
   DROP PROCEDURE lms.SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome
GO

CREATE PROCEDURE lms.SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome
	
	@date_start datetime,
	@date_end datetime,
	@is_consolidated bit = 0,

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR 
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
	BEGIN
	
		--NOTE: should not use INSERT... SELECT because this will called in another function

		DECLARE @sniff_date_start datetime
		DECLARE @sniff_date_end datetime
		DECLARE @sniff_is_consolidated bit
		DECLARE @sniff_system_user_id varchar(50)

		SET @sniff_date_start = @date_start
		SET @sniff_date_end = @date_end
		SET @sniff_is_consolidated = @is_consolidated
		SET @sniff_system_user_id = @system_user_id;

		WITH cte_regular_loan_payments(payment_id, received_from, sysid_member, sysid_regular, received_date, receipt_no, amount, 
				sysid_account_credit, is_miscellaneous_income) AS
		(
			SELECT	--REGULAR LOAN PAYMENTS
				rlp.payment_id AS payment_id,
				pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')' AS received_from,
				rli.sysid_member AS sysid_member,
				rlp.sysid_regular AS sysid_regular,
				rlp.created_on AS received_date,
				rlp.receipt_no AS receipt_no,
				rlp.payment_amount AS amount,
				rlp.sysid_account_credit AS sysid_account_credit,
				'false' AS is_miscellaneous_income
			FROM
				lms.regular_loan_payments AS rlp
			INNER JOIN lms.regular_loan_information AS rli ON rli.sysid_regular = rlp.sysid_regular
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = rli.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				(NOT rlp.sysid_account_credit IS NULL) AND
				(rlp.receipt_date BETWEEN @sniff_date_start AND @sniff_date_end) AND
				(((@sniff_is_consolidated = 0) AND (rlp.created_by = @sniff_system_user_id)) OR
				(@sniff_is_consolidated = 1))
		),
		cte_share_capital_credit(payment_id, received_from, sysid_member, received_date, receipt_no, amount, 
				sysid_account_credit, is_miscellaneous_income) AS
		(
			SELECT	--SHARE CAPITAL CREDIT
				scc.capital_credit_id AS payment_id,
				pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')' AS received_from,
				scc.sysid_member AS sysid_member,
				scc.created_on AS received_date,
				scc.receipt_no AS receipt_no,
				scc.credit_amount AS amount,
				scc.sysid_account_credit AS sysid_account_credit,
				'false' AS is_miscellaneous_income
			FROM
				lms.share_capital_credit AS scc
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = scc.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				(NOT scc.sysid_account_credit IS NULL) AND
				(scc.receipt_date BETWEEN @sniff_date_start AND @sniff_date_end) AND
				(scc.is_migrated_entry = 0) AND
				(((@sniff_is_consolidated = 0) AND (scc.created_by = @sniff_system_user_id)) OR
				(@sniff_is_consolidated = 1))
		),
		cte_member_equity_credit(payment_id, received_from, sysid_member, received_date, receipt_no, amount, 
				sysid_account_credit, is_miscellaneous_income) AS
		(
			SELECT	--MEMBER EQUITY CREDIT
				mqc.equity_id AS payment_id,
				pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')' AS received_from,
				mqc.sysid_member AS sysid_member,
				mqc.created_on AS received_date,
				mqc.receipt_no AS receipt_no,
				mqc.credit_amount AS amount,
				mqc.sysid_account_credit AS sysid_account_credit,
				'false' AS is_miscellaneous_income
			FROM
				lms.member_equity_credit AS mqc
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = mqc.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				(NOT mqc.sysid_account_credit IS NULL) AND
				(mqc.receipt_date BETWEEN @sniff_date_start AND @sniff_date_end) AND
				(mqc.is_migrated_entry = 0) AND
				(((@sniff_is_consolidated = 0) AND (mqc.created_by = @sniff_system_user_id)) OR
				(@sniff_is_consolidated = 1))
		),
		cte_in_house_hospitalization_credit(payment_id, received_from, sysid_member, received_date, receipt_no, amount, 
				sysid_account_credit, is_miscellaneous_income) AS
		(
			SELECT	--IN-HOUSE HOSPITALIZATION CREDIT
				ihc.hospitalization_credit_id AS payment_id,
				pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')' AS received_from,
				ihc.sysid_member AS sysid_member,
				ihc.created_on AS received_date,
				ihc.receipt_no AS receipt_no,
				ihc.credit_amount AS amount,
				ihc.sysid_account_credit AS sysid_account_credit,
				'false' AS is_miscellaneous_income
			FROM
				lms.in_house_hospitalization_credit AS ihc
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = ihc.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				(NOT ihc.sysid_account_credit IS NULL) AND
				(ihc.receipt_date BETWEEN @sniff_date_start AND @sniff_date_end) AND
				(((@sniff_is_consolidated = 0) AND (ihc.created_by = @sniff_system_user_id)) OR
				(@sniff_is_consolidated = 1))
		),
		cte_miscellaneous_income(payment_id, received_from, sysid_member, sysid_collector, received_date, receipt_no, amount, 
				sysid_account_credit, is_miscellaneous_income) AS
		(
			SELECT	--MISCELLANEOUS INCOME RELATED TO A MEMBER
				mci.payment_id AS payment_id,
				pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') + '  (' + mbi.member_id + ')' AS received_from,
				mci.sysid_member AS sysid_member,
				NULL AS sysid_collector,
				mci.created_on AS received_date,
				mci.receipt_no AS receipt_no,
				mci.miscellaneous_amount AS amount,
				mci.sysid_account_credit AS sysid_account_credit,
				'true' AS is_miscellaneous_income
			FROM
				lms.miscellaneous_income AS mci
			LEFT JOIN lms.member_information AS mbi ON mbi.sysid_member = mci.sysid_member
			LEFT JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			WHERE
				(NOT mci.sysid_account_credit IS NULL) AND
				(NOT mci.sysid_member IS NULL) AND
				(mci.sysid_collector IS NULL) AND
				(mci.receipt_date BETWEEN @sniff_date_start AND @sniff_date_end) AND
				(((@sniff_is_consolidated = 0) AND (mci.created_by = @sniff_system_user_id)) OR
				(@sniff_is_consolidated = 1))
			UNION ALL
			SELECT	--MISCELLANEOUS INCOME RELATED TO AN EMPLOYEE
				mci.payment_id AS payment_id,
				pri.last_name + ', ' + pri.first_name + ' ' + ISNULL(pri.middle_name, '') + '  (' + cli.employee_id + ')' AS received_from,
				NULL AS sysid_member,
				mci.sysid_collector AS sysid_collector,
				mci.created_on AS received_date,
				mci.receipt_no AS receipt_no,
				mci.miscellaneous_amount AS amount,
				mci.sysid_account_credit AS sysid_account_credit,
				'true' AS is_miscellaneous_income
			FROM
				lms.miscellaneous_income AS mci
			LEFT JOIN lms.collector_information AS cli ON cli.sysid_collector = mci.sysid_collector
			LEFT JOIN lms.person_information AS pri ON pri.sysid_person = cli.sysid_person
			WHERE
				(NOT mci.sysid_account_credit IS NULL) AND
				(mci.sysid_member IS NULL) AND
				(NOT mci.sysid_collector IS NULL) AND
				(mci.receipt_date BETWEEN @sniff_date_start AND @sniff_date_end) AND
				(((@sniff_is_consolidated = 0) AND (mci.created_by = @sniff_system_user_id)) OR
				(@sniff_is_consolidated = 1))
			UNION ALL
			SELECT	--MISCELLANEOUS INCOME NOT RELATED TO A MEMBER OR AN EMPLOYEE
				mci.payment_id AS payment_id,
				mci.received_from AS received_from,
				NULL AS sysid_member,
				NULL AS sysid_collector,
				mci.created_on AS received_date,
				mci.receipt_no AS receipt_no,
				mci.miscellaneous_amount AS amount,
				mci.sysid_account_credit AS sysid_account_credit,
				'true' AS is_miscellaneous_income
			FROM
				lms.miscellaneous_income AS mci
			WHERE
				(NOT mci.sysid_account_credit IS NULL) AND
				(mci.sysid_member IS NULL) AND
				(mci.sysid_collector IS NULL) AND
				(mci.receipt_date BETWEEN @sniff_date_start AND @sniff_date_end) AND
				(((@sniff_is_consolidated = 0) AND (mci.created_by = @sniff_system_user_id)) OR
				(@sniff_is_consolidated = 1))
		)

		SELECT	--REGULAR LOAN PAYMENTS ON A MEMBER WITH OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			oei.office_employer_id AS office_employer_id,
			oei.office_employer_name AS office_employer_name,
			oei.office_employer_acronym AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_regular_loan_payments AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(NOT pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--REGULAR LOAN PAYMENTS ON A MEMBER WITHOUT OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			NULL AS office_employer_id,
			NULL AS office_employer_name,
			NULL AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_regular_loan_payments AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--SHARE CAPITAL CREDIT ON A MEMBER WITH OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			oei.office_employer_id AS office_employer_id,
			oei.office_employer_name AS office_employer_name,
			oei.office_employer_acronym AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_share_capital_credit AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(NOT pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--SHARE CAPITAL CREDIT ON A MEMBER WITHOUT OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			NULL AS office_employer_id,
			NULL AS office_employer_name,
			NULL AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_share_capital_credit AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--MEMEBER EQUITY CREDIT ON A MEMBER WITH OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			oei.office_employer_id AS office_employer_id,
			oei.office_employer_name AS office_employer_name,
			oei.office_employer_acronym AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_member_equity_credit AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(NOT pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--MEMEBER EQUITY CREDIT ON A MEMBER WITHOUT OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			NULL AS office_employer_id,
			NULL AS office_employer_name,
			NULL AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_member_equity_credit AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--IN-HOUSE HOSPITALIZATION CREDIT ON A MEMBER WITH OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			oei.office_employer_id AS office_employer_id,
			oei.office_employer_name AS office_employer_name,
			oei.office_employer_acronym AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_in_house_hospitalization_credit AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(NOT pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--IN-HOUSE HOSPITALIZATION CREDIT ON A MEMBER WITHOUT OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			NULL AS office_employer_id,
			NULL AS office_employer_name,
			NULL AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_in_house_hospitalization_credit AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(pri.office_employer_id IS NULL)
		UNION ALL
		SELECT	--MISCELLANEOUS INCOME ON A MEMBER WITH OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			oei.office_employer_id AS office_employer_id,
			oei.office_employer_name AS office_employer_name,
			oei.office_employer_acronym AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_miscellaneous_income AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		LEFT JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		LEFT JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(NOT pri.office_employer_id IS NULL) AND
			(NOT pmi.sysid_member IS NULL)
		UNION ALL
		SELECT	--MISCELLANEOUS INCOME ON A MEMBER WITHOUT OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_member AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			NULL AS office_employer_id,
			NULL AS office_employer_name,
			NULL AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_miscellaneous_income AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		LEFT JOIN lms.member_information AS mbi ON mbi.sysid_member = pmi.sysid_member
		LEFT JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(pri.office_employer_id IS NULL) AND
			(NOT pmi.sysid_member IS NULL)
		UNION ALL
		SELECT	--MISCELLANEOUS INCOME ON AN EMPLOYEE WITH OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_collector AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			oei.office_employer_id AS office_employer_id,
			oei.office_employer_name AS office_employer_name,
			oei.office_employer_acronym AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_miscellaneous_income AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		LEFT JOIN lms.collector_information AS cli ON cli.sysid_collector = pmi.sysid_collector
		LEFT JOIN lms.person_information AS pri ON pri.sysid_person = cli.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(NOT pri.office_employer_id IS NULL) AND
			(NOT pmi.sysid_collector IS NULL)
		UNION ALL
		SELECT	--MISCELLANEOUS INCOME ON AN EMPLOYEE WITHOUT OFFICE/EMPLOYER
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			pmi.sysid_collector AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			NULL AS office_employer_id,
			NULL AS office_employer_name,
			NULL AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_miscellaneous_income AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		LEFT JOIN lms.collector_information AS cli ON cli.sysid_collector = pmi.sysid_collector
		LEFT JOIN lms.person_information AS pri ON pri.sysid_person = cli.sysid_person
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = pri.office_employer_id
		WHERE
			(pri.office_employer_id IS NULL) AND
			(NOT pmi.sysid_collector IS NULL)
		UNION ALL
		SELECT	--MISCELLANEOUS INCOME NOT RELATED TO A MEMBER OR AN EMPLOYEE
			coa.sysid_account AS sysid_account,
			coa.account_code AS account_code,
			coa.account_name AS account_name,	
			summary_coa.sysid_account AS sysid_account_summary,
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			pmi.received_from AS received_from,
			NULL AS sysid_member_collector,	
			pmi.received_date AS received_date,
			pmi.receipt_no AS receipt_no,		
			pmi.amount AS amount,
			pmi.is_miscellaneous_income AS is_miscellaneous_income,

			--pri.office_employer_id
			NULL AS office_employer_id,
			NULL AS office_employer_name,
			NULL AS office_employer_acronym			
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account		
		INNER JOIN cte_miscellaneous_income AS pmi ON pmi.sysid_account_credit = coa.sysid_account
		WHERE
			(pmi.sysid_member IS NULL) AND
			(pmi.sysid_collector IS NULL)
		ORDER BY
			pmi.receipt_no ASC, pmi.received_date ASC
	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query payments, credits and miscellaneous income', 'Payments, Credits, and Miscellaneous Income'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome')
   DROP PROCEDURE lms.SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome
GO

CREATE PROCEDURE lms.SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome
	
	@date_start datetime,
	@date_end datetime,
	@is_consolidated bit = 0,

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR 
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
	BEGIN

		DECLARE @cash_receipts_detailed TABLE (table_id bigint IDENTITY(1, 1) NOT NULL PRIMARY KEY,
												sysid_account varchar (50) NULL,
												account_code varchar (50) NOT NULL,
												account_name varchar (150) NOT NULL,
												sysid_account_summary varchar (50) NULL,
												account_code_summary varchar (50) NULL,
												account_name_summary varchar (150) NULL,
												received_from varchar (150) NOT NULL,
												sysid_member_collector varchar (50) NULL,	
												received_date datetime NOT NULL,
												receipt_no varchar (50) NOT NULL,		
												amount decimal (12, 2) NOT NULL,
												is_miscellaneous_income bit NOT NULL,
												office_employer_id varchar (50) NULL,
												office_employer_name varchar (150) NULL,
												office_employer_acronym varchar (20) NULL)


		INSERT INTO @cash_receipts_detailed (sysid_account, account_code, account_name, sysid_account_summary, account_code_summary,
				account_name_summary, received_from, sysid_member_collector, received_date, receipt_no, amount, is_miscellaneous_income, office_employer_id, 
				office_employer_name, office_employer_acronym)
		EXECUTE 
				lms.SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome @date_start, @date_end, @is_consolidated, @system_user_id

		SELECT	--SUMMARY OF PAYMENTS BY OFFICE EMPLOYER ID AND NOT A MISCELLANEOUS INCOME
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			oei.office_employer_acronym AS office_employer_acronym,
			coa.account_code AS account_code_subsidiary,
			coa.account_name AS account_name_subsidiary,
			summary_crd.amount AS total_amount,
			'false' AS is_miscellaneous_income
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		INNER JOIN
		(
			SELECT
				sum_crd.office_employer_id AS office_employer_id,
				sum_crd.sysid_account AS sysid_account,
				SUM(sum_crd.amount) AS amount
			FROM
				@cash_receipts_detailed AS sum_crd
			WHERE
				(NOT sum_crd.office_employer_id IS NULL) AND
				(NOT sum_crd.office_employer_acronym IS NULL) AND
				(sum_crd.is_miscellaneous_income = 0)
			GROUP BY
				sum_crd.office_employer_id, sum_crd.sysid_account
		) AS summary_crd ON summary_crd.sysid_account = coa.sysid_account
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = summary_crd.office_employer_id
		WHERE
			(NOT summary_crd.office_employer_id IS NULL)
		UNION ALL
		SELECT	--SUMMARY OF PAYMENTS WITHOUT OFFICE/EMPLOYER AND NOT A MISCELLANEOUS INCOME
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			NULL AS office_employer_acronym,
			coa.account_code AS account_code_subsidiary,
			coa.account_name AS account_name_subsidiary,
			summary_crd.amount AS total_amount,
			'false' AS is_miscellaneous_income
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		INNER JOIN
		(
			SELECT
				sum_crd.office_employer_id AS office_employer_id,
				sum_crd.sysid_account AS sysid_account,
				SUM(sum_crd.amount) AS amount
			FROM
				@cash_receipts_detailed AS sum_crd
			WHERE
				(sum_crd.office_employer_id IS NULL) AND
				(sum_crd.office_employer_acronym IS NULL) AND
				(sum_crd.is_miscellaneous_income = 0)
			GROUP BY
				sum_crd.office_employer_id, sum_crd.sysid_account
		) AS summary_crd ON summary_crd.sysid_account = coa.sysid_account
		UNION ALL
		SELECT	--SUMMARY OF PAYMENTS BY OFFICE EMPLOYER ID AND IS A MISCELLANEOUS INCOME
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			oei.office_employer_acronym AS office_employer_acronym,
			coa.account_code AS account_code_subsidiary,
			coa.account_name AS account_name_subsidiary,
			summary_crd.amount AS total_amount,
			'true' AS is_miscellaneous_income
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		INNER JOIN
		(
			SELECT
				sum_crd.office_employer_id AS office_employer_id,
				sum_crd.sysid_account AS sysid_account,
				SUM(sum_crd.amount) AS amount
			FROM
				@cash_receipts_detailed AS sum_crd
			WHERE
				(NOT sum_crd.office_employer_id IS NULL) AND
				(NOT sum_crd.office_employer_acronym IS NULL) AND
				(sum_crd.is_miscellaneous_income = 1)
			GROUP BY
				sum_crd.office_employer_id, sum_crd.sysid_account
		) AS summary_crd ON summary_crd.sysid_account = coa.sysid_account
		LEFT JOIN lms.office_employer_information AS oei ON oei.office_employer_id = summary_crd.office_employer_id
		WHERE
			(NOT summary_crd.office_employer_id IS NULL)
		UNION ALL
		SELECT	--SUMMARY OF PAYMENTS WITHOUT OFFICE/EMPLOYER AND IS A MISCELLANEOUS INCOME
			summary_coa.account_code AS account_code_summary,
			summary_coa.account_name AS account_name_summary,
			NULL AS office_employer_acronym,
			coa.account_code AS account_code_subsidiary,
			coa.account_name AS account_name_subsidiary,
			summary_crd.amount AS total_amount,
			'true' AS is_miscellaneous_income
		FROM
			lms.chart_of_accounts AS coa
		LEFT JOIN lms.chart_of_accounts AS summary_coa ON summary_coa.sysid_account = coa.summary_account
		INNER JOIN
		(
			SELECT
				sum_crd.office_employer_id AS office_employer_id,
				sum_crd.sysid_account AS sysid_account,
				SUM(sum_crd.amount) AS amount
			FROM
				@cash_receipts_detailed AS sum_crd
			WHERE
				(sum_crd.office_employer_id IS NULL) AND
				(sum_crd.office_employer_acronym IS NULL) AND
				(sum_crd.is_miscellaneous_income = 1)
			GROUP BY
				sum_crd.office_employer_id, sum_crd.sysid_account
		) AS summary_crd ON summary_crd.sysid_account = coa.sysid_account
		ORDER BY
			is_miscellaneous_income ASC, account_code_summary ASC, office_employer_acronym ASC

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query payments, credits and miscellaneous income', 'Payments, Credits, and Miscellaneous Income'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome TO db_lmsusers
GO
-------------------------------------------------------------

-- verifies if the procedure "SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices" exist
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_SCHEMA = N'lms' AND SPECIFIC_NAME = N'SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices')
   DROP PROCEDURE lms.SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices
GO

CREATE PROCEDURE lms.SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices
	
	@sysid_member_list nvarchar (MAX) = '',
	@date_start datetime,
	@date_end datetime,

	@system_user_id varchar(50) = ''
	
AS

	IF ((lms.IsSystemAdminSystemUserInfo(@system_user_id) = 1) OR 
		(lms.IsCashierSystemUserInfo(@system_user_id) = 1))
	BEGIN

		DECLARE @member_billing_statement TABLE (sysid_member varchar (50) NOT NULL PRIMARY KEY,
												last_name varchar (50) NOT NULL,
												first_name varchar (50) NOT NULL,
												middle_name varchar (50) NULL DEFAULT (''),
												office_employer_id varchar (50) NULL,
												share_capital_amount decimal (15, 2) NOT NULL,
												hospitalization_amount decimal (15, 2) NULL DEFAULT (0.00),
												birthday_principal decimal (15, 2) NULL DEFAULT (0.00),
												birthday_interest decimal (15, 2) NULL DEFAULT (0.00),
												contingency_principal decimal (15, 2) NULL DEFAULT (0.00),
												contingency_interest decimal (15, 2) NULL DEFAULT (0.00),
												salary_principal decimal (15, 2) NULL DEFAULT (0.00),
												salary_interest decimal (15, 2) NULL DEFAULT (0.00),
												medical_principal decimal (15, 2) NULL DEFAULT (0.00),
												medical_interest decimal (15, 2) NULL DEFAULT (0.00),
												special_principal decimal (15, 2) NULL DEFAULT (0.00),
												special_interest decimal (15, 2) NULL DEFAULT (0.00))


		--GET THE MEMBER SHARE CAPITAL INFORMATION
		INSERT INTO @member_billing_statement (sysid_member, last_name, first_name, middle_name, office_employer_id, share_capital_amount)
			SELECT
				sci.sysid_member AS sysid_member,
				pri.last_name AS last_name,
				pri.first_name AS first_name,
				pri.middle_name AS middle_name,
				pri.office_employer_id AS office_employer_id,
				sci.premium_amount_due AS premium_amount_due			
			FROM
				lms.share_capital_information AS sci
			INNER JOIN lms.member_information AS mbi ON mbi.sysid_member = sci.sysid_member
			INNER JOIN lms.person_information AS pri ON pri.sysid_person = mbi.sysid_person
			INNER JOIN
			(
				SELECT
					t_sci.sysid_member AS sysid_member,
					MAX(t_sci.effectivity_date) AS effectivity_date
				FROM 
					lms.share_capital_information AS t_sci			
				INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = t_sci.sysid_member
				WHERE
					(t_sci.is_precluded_withdrawal = 0) AND
					(t_sci.is_precluded_retirement = 0) AND
					(t_sci.effectivity_date <= @date_end)
				GROUP BY
					t_sci.sysid_member
			) AS inner_sci ON inner_sci.sysid_member = sci.sysid_member AND inner_sci.effectivity_date = sci.effectivity_date		

		--GET THE MEMBER'S HOSPITALIZATION
		UPDATE @member_billing_statement SET
			hospitalization_amount = ihi.premium_amount_due
		FROM
			@member_billing_statement AS mbs
		INNER JOIN lms.in_house_hospitalization_information AS ihi ON ihi.sysid_member = mbs.sysid_member
		INNER JOIN
		(
			SELECT
				t_ihi.sysid_member AS sysid_member,
				MAX(t_ihi.effectivity_date) AS effectivity_date
			FROM
				lms.in_house_hospitalization_information AS t_ihi			
			INNER JOIN lms.IterateListToTable (@sysid_member_list, ',') AS smel_list ON smel_list.var_str = t_ihi.sysid_member
			WHERE
				(t_ihi.effectivity_date <= @date_end)
			GROUP BY
				t_ihi.sysid_member
		) AS inner_ihi ON inner_ihi.sysid_member = ihi.sysid_member AND inner_ihi.effectivity_date = ihi.effectivity_date


		
		--GET THE MEMBER'S BIRTHDAY LOAN
		UPDATE @member_billing_statement SET
			mbs.birthday_principal = sum_loan.principal_paid,
			mbs.birthday_interest = sum_loan.interest_paid
		FROM
			@member_billing_statement AS mbs
		INNER JOIN
		(
			SELECT
				sum_rli.sysid_member AS sysid_member,
				SUM(regular_loan.principal_paid) AS principal_paid,
				SUM(regular_loan.interest_paid) AS interest_paid
			FROM
				lms.regular_loan_information AS sum_rli
			INNER JOIN
			(
				SELECT  --ACTIVE LOANS BASED ON A GIVEN DATE
					t_rla.sysid_regular AS sysid_regular,
							--determine if the amortization amount minus payments is still greater than the principal to be paid 
							--(no overage payments per amortization schedule)
					CASE WHEN ((ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) > 
										(ISNULL(t_rla.principal_paid, 0)))
							THEN 
								ISNULL(t_rla.principal_paid, 0) 
							ELSE
								(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0))
							END AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID001') AND --Birthday Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID001') AND --Birthday Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(t_rla.payment_date_to BETWEEN @date_start AND @date_end) AND
					(amortization_amount.max_payment_date_to > @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				UNION ALL
				SELECT  --LOANS WITH MISSED PAYMENTS
					t_rla.sysid_regular AS sysid_regular,
					(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID001') AND --Birthday Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID001') AND --Birthday Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(amortization_amount.max_payment_date_to < @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				
			) AS regular_loan ON regular_loan.sysid_regular = sum_rli.sysid_regular
			GROUP BY
				sum_rli.sysid_member

		) AS sum_loan ON sum_loan.sysid_member = mbs.sysid_member


		--GET THE MEMBER'S CONTINGENCY LOAN
		UPDATE @member_billing_statement SET
			mbs.contingency_principal = sum_loan.principal_paid,
			mbs.contingency_interest = sum_loan.interest_paid
		FROM
			@member_billing_statement AS mbs
		INNER JOIN
		(
			SELECT
				sum_rli.sysid_member AS sysid_member,
				SUM(regular_loan.principal_paid) AS principal_paid,
				SUM(regular_loan.interest_paid) AS interest_paid
			FROM
				lms.regular_loan_information AS sum_rli
			INNER JOIN
			(
				SELECT  --ACTIVE LOANS BASED ON A GIVEN DATE
					t_rla.sysid_regular AS sysid_regular,
							--determine if the amortization amount minus payments is still greater than the principal to be paid 
							--(no overage payments per amortization schedule)
					CASE WHEN ((ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) > 
										(ISNULL(t_rla.principal_paid, 0)))
							THEN 
								ISNULL(t_rla.principal_paid, 0) 
							ELSE
								(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0))
							END AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID002') AND --Contingency Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID002') AND --Contingency Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(t_rla.payment_date_to BETWEEN @date_start AND @date_end) AND
					(amortization_amount.max_payment_date_to > @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				UNION ALL
				SELECT  --LOANS WITH MISSED PAYMENTS
					t_rla.sysid_regular AS sysid_regular,
					(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID002') AND --Contingency Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID002') AND --Contingency Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(amortization_amount.max_payment_date_to < @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				
			) AS regular_loan ON regular_loan.sysid_regular = sum_rli.sysid_regular
			GROUP BY
				sum_rli.sysid_member

		) AS sum_loan ON sum_loan.sysid_member = mbs.sysid_member


		--GET THE MEMBER'S SALARY LOAN
		UPDATE @member_billing_statement SET
			mbs.salary_principal = sum_loan.principal_paid,
			mbs.salary_interest = sum_loan.interest_paid
		FROM
			@member_billing_statement AS mbs
		INNER JOIN
		(
			SELECT
				sum_rli.sysid_member AS sysid_member,
				SUM(regular_loan.principal_paid) AS principal_paid,
				SUM(regular_loan.interest_paid) AS interest_paid
			FROM
				lms.regular_loan_information AS sum_rli
			INNER JOIN
			(
				SELECT  --ACTIVE LOANS BASED ON A GIVEN DATE
					t_rla.sysid_regular AS sysid_regular,
							--determine if the amortization amount minus payments is still greater than the principal to be paid 
							--(no overage payments per amortization schedule)
					CASE WHEN ((ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) > 
										(ISNULL(t_rla.principal_paid, 0)))
							THEN 
								ISNULL(t_rla.principal_paid, 0) 
							ELSE
								(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0))
							END AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID003') AND --Salary Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID003') AND --Salary Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(t_rla.payment_date_to BETWEEN @date_start AND @date_end) AND
					(amortization_amount.max_payment_date_to > @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				UNION ALL
				SELECT  --LOANS WITH MISSED PAYMENTS
					t_rla.sysid_regular AS sysid_regular,
					(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID003') AND --Salary Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID003') AND --Salary Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(amortization_amount.max_payment_date_to < @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				
			) AS regular_loan ON regular_loan.sysid_regular = sum_rli.sysid_regular
			GROUP BY
				sum_rli.sysid_member

		) AS sum_loan ON sum_loan.sysid_member = mbs.sysid_member

		--GET THE MEMBER'S MEDICAL LOAN
		UPDATE @member_billing_statement SET
			mbs.medical_principal = sum_loan.principal_paid,
			mbs.medical_interest = sum_loan.interest_paid
		FROM
			@member_billing_statement AS mbs
		INNER JOIN
		(
			SELECT
				sum_rli.sysid_member AS sysid_member,
				SUM(regular_loan.principal_paid) AS principal_paid,
				SUM(regular_loan.interest_paid) AS interest_paid
			FROM
				lms.regular_loan_information AS sum_rli
			INNER JOIN
			(
				SELECT  --ACTIVE LOANS BASED ON A GIVEN DATE
					t_rla.sysid_regular AS sysid_regular,
							--determine if the amortization amount minus payments is still greater than the principal to be paid 
							--(no overage payments per amortization schedule)
					CASE WHEN ((ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) > 
										(ISNULL(t_rla.principal_paid, 0)))
							THEN 
								ISNULL(t_rla.principal_paid, 0) 
							ELSE
								(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0))
							END AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID004') AND --Medical Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID004') AND --Medical Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(t_rla.payment_date_to BETWEEN @date_start AND @date_end) AND
					(amortization_amount.max_payment_date_to > @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				UNION ALL
				SELECT  --LOANS WITH MISSED PAYMENTS
					t_rla.sysid_regular AS sysid_regular,
					(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID004') AND --Medical Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID004') AND --Medical Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(amortization_amount.max_payment_date_to < @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				
			) AS regular_loan ON regular_loan.sysid_regular = sum_rli.sysid_regular
			GROUP BY
				sum_rli.sysid_member

		) AS sum_loan ON sum_loan.sysid_member = mbs.sysid_member

		--GET THE MEMBER'S SPECIAL LOAN
		UPDATE @member_billing_statement SET
			mbs.special_principal = sum_loan.principal_paid,
			mbs.special_interest = sum_loan.interest_paid
		FROM
			@member_billing_statement AS mbs
		INNER JOIN
		(
			SELECT
				sum_rli.sysid_member AS sysid_member,
				SUM(regular_loan.principal_paid) AS principal_paid,
				SUM(regular_loan.interest_paid) AS interest_paid
			FROM
				lms.regular_loan_information AS sum_rli
			INNER JOIN
			(
				SELECT  --ACTIVE LOANS BASED ON A GIVEN DATE
					t_rla.sysid_regular AS sysid_regular,
							--determine if the amortization amount minus payments is still greater than the principal to be paid 
							--(no overage payments per amortization schedule)
					CASE WHEN ((ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) > 
										(ISNULL(t_rla.principal_paid, 0)))
							THEN 
								ISNULL(t_rla.principal_paid, 0) 
							ELSE
								(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0))
							END AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID005') AND --Special Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID005') AND --Special Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(t_rla.payment_date_to BETWEEN @date_start AND @date_end) AND
					(amortization_amount.max_payment_date_to > @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				UNION ALL
				SELECT  --LOANS WITH MISSED PAYMENTS
					t_rla.sysid_regular AS sysid_regular,
					(ISNULL(amortization_amount.payment_amount, 0) - ISNULL(loan_payments.payment_amount, 0)) AS principal_paid,
					t_rla.interest_paid AS interest_paid
				FROM
					lms.regular_loan_amortization AS t_rla
				INNER JOIN lms.regular_loan_information AS t_rli ON t_rli.sysid_regular = t_rla.sysid_regular
				INNER JOIN
				(
					SELECT --get the summary of all scheduled payment amount
						inner_rla.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_rla.principal_paid), 0) + ISNULL(SUM(inner_rla.interest_paid), 0) AS payment_amount,
						MAX(inner_rla.payment_date_to) AS max_payment_date_to
					FROM
						lms.regular_loan_amortization AS inner_rla
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_rla.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID005') AND --Special Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_rla.sysid_regular

				) AS amortization_amount ON amortization_amount.sysid_regular = t_rli.sysid_regular
				LEFT JOIN 
				(
					SELECT --get the summary of all payments made
						inner_tlp.sysid_regular AS sysid_regular,
						ISNULL(SUM(inner_tlp.payment_amount), 0) + ISNULL(SUM(inner_tlp.rebate_amount), 0) + ISNULL(SUM(inner_rlc.charge_amount), 0) AS payment_amount
					FROM
						lms.regular_loan_payments AS inner_tlp
					INNER JOIN lms.regular_loan_information AS inner_rli ON inner_rli.sysid_regular = inner_tlp.sysid_regular
					LEFT JOIN lms.regular_loan_charges AS inner_rlc ON inner_rlc.sysid_regular_forwarded = inner_tlp.sysid_regular
					WHERE
						(inner_rli.regular_loan_type_id = 'RLTID005') AND --Special Loan
						(inner_rli.is_straight_loan = 1) AND
						(inner_rli.sysid_member IN (SELECT sysid_member FROM @member_billing_statement))
						--no comparison with the given date so that even if the report generated is on the previous month than the server date and time,
						--the procedure will return the actual/current status of the loan
					GROUP BY
						inner_tlp.sysid_regular

				) AS loan_payments ON loan_payments.sysid_regular = t_rli.sysid_regular
				WHERE
					(amortization_amount.max_payment_date_to < @date_start) AND
					(ISNULL(amortization_amount.payment_amount, 0) > ISNULL(loan_payments.payment_amount, 0))
				
			) AS regular_loan ON regular_loan.sysid_regular = sum_rli.sysid_regular
			GROUP BY
				sum_rli.sysid_member

		) AS sum_loan ON sum_loan.sysid_member = mbs.sysid_member

		
		SELECT
			mbs.sysid_member AS sysid_member,
			mbs.last_name AS last_name,
			mbs.first_name AS first_name,
			mbs.middle_name AS middle_name,
			mbs.office_employer_id AS office_employer_id,
			mbs.share_capital_amount AS share_capital_amount,
			mbs.hospitalization_amount AS hospitalization_amount,
			mbs.birthday_principal AS birthday_principal,
			mbs.birthday_interest AS birthday_interest,
			mbs.contingency_principal AS contingency_principal,
			mbs.contingency_interest AS contingency_interest,
			mbs.salary_principal AS salary_principal,
			mbs.salary_interest AS salary_interest,
			mbs.medical_principal AS medical_principal,
			mbs.medical_interest AS medical_interest,
			mbs.special_principal AS special_principal,
			mbs.special_interest AS special_interest
		FROM
			@member_billing_statement AS mbs
		ORDER BY
			mbs.last_name ASC, mbs.first_name ASC, mbs.middle_name ASC
		

	END	
	ELSE
	BEGIN
		EXECUTE lms.ShowErrorMsg 'Query member services', 'Member Services'
	END
	
GO
------------------------------------------------------------

-- grant permission on the stored procedure
GRANT EXECUTE ON lms.SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices TO db_lmsusers
GO
-------------------------------------------------------------


-- ##############################################END TABLE "breakdown_bank_deposit" OBJECTS######################################################







-- ######################################RESTORE DEPENDENT TABLE CONSTRAINTS#############################################################

--verifies if the Bank_Information_SysID_Acccount_FK constraint exists
IF OBJECT_ID('lms.bank_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.bank_information WITH NOCHECK
	ADD CONSTRAINT Bank_Information_SysID_Acccount_FK FOREIGN KEY (sysid_account) REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Information_SysID_InHouseDebit_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_information', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_information WITH NOCHECK
	ADD CONSTRAINT Disbursement_Voucher_Information_SysID_InHouseDebit_FK FOREIGN KEY (sysid_inhousedebit) REFERENCES lms.in_house_hospitalization_debit(sysid_inhousedebit) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

--verifies if the Disbursement_Voucher_Entry_SysID_Account_FK constraint exists
IF OBJECT_ID('lms.disbursement_voucher_entry', 'U') IS NOT NULL
BEGIN
	ALTER TABLE lms.disbursement_voucher_entry WITH NOCHECK
	ADD CONSTRAINT Disbursement_Voucher_Entry_SysID_Account_FK  FOREIGN KEY (sysid_account) REFERENCES lms.chart_of_accounts(sysid_account) ON UPDATE NO ACTION
END
GO
-----------------------------------------------------

-- ###################################END RESTORE DEPENDENT TABLE CONSTRAINTS############################################################






-- ############################################INITIAL DATABASE INFORMATION#############################################################
----lms.loan_charges_information
--INSERT INTO lms.loan_charges_information(sysid_loancharges, loan_charges_description, created_by)
--	SELECT 'SYSLCI001', 'Prepaid Interest', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--	UNION ALL
--	SELECT 'SYSLCI002', 'Deferred Interest Income', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--	UNION ALL
--	SELECT 'SYSLCI003', 'Loan Guarantee Fund', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--	UNION ALL
--	SELECT 'SYSLCI004', 'Unpaid Interest', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--	UNION ALL
--	SELECT 'SYSLCI005', 'Service Charge', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--	UNION ALL
--	SELECT 'SYSLCI006', 'General Reserved Fund', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--	UNION ALL
--	SELECT 'SYSLCI007', 'Notarization Fee', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--GO
--
----lms.loan_additions_information
--INSERT INTO lms.loan_additions_information(sysid_loanadditions, loan_additions_description, created_by)
--	SELECT 'SYSLAI001', 'Rebates', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--	UNION ALL
--	SELECT 'SYSLAI002', 'Others', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
--GO

--lms.accounting_category
INSERT INTO lms.accounting_category(accounting_category_id, category_description, category_no)
	SELECT 'ACID01', 'Accounting Element', 1
	UNION
	SELECT 'ACID02', 'Classification', 2
	UNION
	SELECT 'ACID03', 'Controlling Account', 3
	UNION
	SELECT 'ACID04', 'Subsidiary Account', 4
	GO

--lms.hospitalization_include_coverage
INSERT INTO lms.hospitalization_include_coverage(sysid_includecoverage, include_coverage_description, created_by)
	SELECT 'SYSHIC001', 'Hospital Bill', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSHIC002', 'Services and Medicines Procured Outside', '#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
GO


-- ##########################################END INITIAL DATABASE INFORMATION#############################################################







-- ########################################FOR CODE DEBUGGING########################################################################

--lms.chart_of_accounts
INSERT INTO lms.chart_of_accounts(sysid_account, accounting_category_id, account_code, account_name, summary_account, is_debit_side_increase, is_active_account, created_by)
	SELECT 'SYSCOA00001','ACID01','1000-0000','ASSETS',NULL,1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00002','ACID02','1100-0000','CURRENT ASSETS','SYSCOA00001',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00003','ACID03','1110-0000','CASH','SYSCOA00002',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00004','ACID04','1110-0001','Cash on Hand','SYSCOA00003',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00005','ACID03','1120-0000','CASH IN BANK','SYSCOA00002',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00006','ACID01','2000-0000','LIABILITIES',NULL,0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00007','ACID02','2100-0000','CURRENT LIABILITIES','SYSCOA00006',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00008','ACID04','1110-0002','Petty Cash Fund-General','SYSCOA00003',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00009','ACID04','1110-0003','Petty Cash Fund-HAP','SYSCOA00003',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00010','ACID01','3000-0000','EQUITY',NULL,0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00011','ACID01','4000-0000','REVENUES',NULL,0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00012','ACID01','5000-0000','OPERATING EXPENSES',NULL,0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00013','ACID02','2200-0000','LONG TERM LIABILITIES','SYSCOA00006',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00014','ACID04','2200-0001','Loans Payable - City Government','SYSCOA00013',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00015','ACID04','2200-0002','Deferred Interest Income','SYSCOA00013',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00016','ACID04','2200-0003','Loan Guarantee Fund','SYSCOA00013',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00017','ACID04','2200-0004','Reserved for General Fund','SYSCOA00013',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00018','ACID04','4000-0001','Realized Interest','SYSCOA00011',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00019','ACID04','4000-0002','Service Fee','SYSCOA00011',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00020','ACID04','4000-0003','Membership Fee','SYSCOA00011',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00021','ACID04','4000-0004','Other Income - Interest on bank deposits','SYSCOA00011',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00022','ACID04','2100-0002','Fund in Trust - HAP','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00023','ACID04','2100-0001','Due from HAP','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00024','ACID04','2100-0003','Fund in Trust - AXA','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00025','ACID04','2100-0004','Fund in Trust - Appliance','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00026','ACID04','2100-0005','Fund in Trust - Pagibig','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00027','ACID04','2100-0006','Fund in Trust - S S S','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00028','ACID04','2100-0007','Fund in Trust - Cebu CFI','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00029','ACID04','2100-0008','Fund in Trust - PHCCI','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00030','ACID04','2100-0009','Tax Withheld - Staff','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00031','ACID04','2100-0010','Due to Members','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00032','ACID04','2100-0011','Special Savings','SYSCOA00007',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00033','ACID03','1140-0000','ACCOUNTS RECEIVABLE','SYSCOA00002',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00034','ACID03','1301-0000','ACCUMULATED DEPRECIATION','SYSCOA00002',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00035','ACID02','1200-0000','NON-CURRENT ASSETS','SYSCOA00001',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00036','ACID04','1140-0001','Salary Loan','SYSCOA00033',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00037','ACID04','1140-0002','Contingency Loan','SYSCOA00033',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00038','ACID04','1140-0003','Birthday Loan','SYSCOA00033',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00039','ACID04','1200-0001','Property & Equipment','SYSCOA00035',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00040','ACID04','2200-0005','Reserved for Notarial','SYSCOA00013',0,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00041','ACID04','1120-0001','Cash in Bank - DBP','SYSCOA00041',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	UNION ALL
	SELECT 'SYSCOA00042','ACID04','1120-0001','DBP','SYSCOA00005',1,1,'#Tuy@i*2sz@kUw-2!us%WBxYzwP#'
	GO



-- ######################################END FOR CODE DEBUGGING########################################################################
