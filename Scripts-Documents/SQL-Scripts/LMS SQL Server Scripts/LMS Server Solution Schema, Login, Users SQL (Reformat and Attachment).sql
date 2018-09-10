/********************************************************/
/* This SQL Statements is used for the					*/
/* 		Loan Management System (LMS)					*/
/*Programmed by: Judyll Mark T. Agan					*/
/*Date created: March 09, 2010							*/
/********************************************************/


-- ###################################################DATABASE SCHEMA, LOGINS, USERS, ROLES#############################################################

-- Drop a login
IF EXISTS (SELECT * FROM sys.server_principals WHERE TYPE IN ('S', 'U', 'G') AND NAME = 'Lm$D3vL06inG3t$uMC@$h')
BEGIN
	DROP LOGIN Lm$D3vL06inG3t$uMC@$h
END
GO
----------------------------------------------------

USE db_lmsdev_03092010
GO

-- Create a login
CREATE LOGIN Lm$D3vL06inG3t$uMC@$h
	WITH PASSWORD = '85@z_uW*xM+2$c1zTK',
	DEFAULT_DATABASE = db_lmsdev_03092010
GO
--------------------------------

-- Alter a user exclusive for the current login
ALTER USER L3d63r4l0@nc@lcuL@2rU$er WITH LOGIN = Lm$D3vL06inG3t$uMC@$h
GO
----------------------------------------------

-- ###################################################END DATABASE SCHEMA, LOGINS, USERS, ROLES#######################################################