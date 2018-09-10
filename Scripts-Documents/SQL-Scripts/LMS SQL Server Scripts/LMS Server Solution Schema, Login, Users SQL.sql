/********************************************************/
/* This SQL Statements is used for the					*/
/* 		Loan Management System (LMS)					*/
/*Programmed by: Judyll Mark T. Agan					*/
/*Date created: March 09, 2010							*/
/********************************************************/

USE db_lmsdev_03092010
GO

-- ###################################################DATABASE SCHEMA, LOGINS, USERS, ROLES#############################################################
-- Drop a schema
IF EXISTS (SELECT * FROM sys.schemas WHERE NAME = 'lms')
BEGIN
	DROP SCHEMA lms
END
GO
---------------------------------------------

-- Drop a role
IF EXISTS (SELECT * FROM sys.database_principals WHERE TYPE IN ('R') AND NAME = 'db_lmsusers')
BEGIN
--	ALTER AUTHORIZATION ON SCHEMA::db_denydatareader TO db_denydatareader
--	ALTER AUTHORIZATION ON SCHEMA::db_denydatawriter TO db_denydatawriter
	EXEC sp_droprolemember db_lmsusers, L3d63r4l0@nc@lcuL@2rU$er
	DROP ROLE db_lmsusers
END
GO
--------------------------------------------

-- Drop a user
IF EXISTS (SELECT * FROM sys.database_principals WHERE TYPE IN ('S') AND NAME = 'L3d63r4l0@nc@lcuL@2rU$er') 
BEGIN
	DROP USER L3d63r4l0@nc@lcuL@2rU$er
END
GO
---------------------------------------------------

-- Drop a login
IF EXISTS (SELECT * FROM sys.server_principals WHERE TYPE IN ('S', 'U', 'G') AND NAME = 'Lm$D3vL06inG3t$uMC@$h')
BEGIN
	DROP LOGIN Lm$D3vL06inG3t$uMC@$h
END
GO
----------------------------------------------------

-- Create a login
CREATE LOGIN Lm$D3vL06inG3t$uMC@$h
	WITH PASSWORD = '85@z_uW*xM+2$c1zTK',
	DEFAULT_DATABASE = db_lmsdev_03092010
GO
--------------------------------

-- Create a user exclusive for the current login
CREATE USER L3d63r4l0@nc@lcuL@2rU$er FOR LOGIN Lm$D3vL06inG3t$uMC@$h WITH DEFAULT_SCHEMA = lms
GO
----------------------------------------------

-- Create a schema assigning it to a user
CREATE SCHEMA lms AUTHORIZATION L3d63r4l0@nc@lcuL@2rU$er
GO
------------------------------------------------

-- Create a role for the authorized user
CREATE ROLE db_lmsusers AUTHORIZATION L3d63r4l0@nc@lcuL@2rU$er
GO
------------------------------------------------

-- Adds a role member for the created role
EXEC sp_addrolemember db_denydatareader, db_lmsusers
EXEC sp_addrolemember db_denydatawriter, db_lmsusers
EXEC sp_addrolemember db_lmsusers, L3d63r4l0@nc@lcuL@2rU$er
GO

-- system views
SELECT * FROM sys.server_principals WHERE TYPE IN ('S', 'U', 'G') AND NAME = 'Lm$D3vL06inG3t$uMC@$h'
SELECT * FROM sys.database_principals WHERE TYPE IN ('S', 'U', 'G') AND NAME = 'L3d63r4l0@nc@lcuL@2rU$er'
SELECT * FROM sys.database_principals WHERE TYPE IN ('R') AND NAME = 'db_lmsusers'
SELECT * FROM sys.schemas
GO

SELECT * FROM sys.master_files
SELECT * FROM sys.servers
SELECT * FROM tempdb..sysobjects
GO
-- ###################################################END DATABASE SCHEMA, LOGINS, USERS, ROLES#######################################################