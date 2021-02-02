CREATE DATABASE Restaurant_Manager

GO

USE Restaurant_Manager

GO 

CREATE TABLE tblEmployee(
employeeID NVARCHAR(10) PRIMARY KEY,
name NVARCHAR(50),
adress NVARCHAR(30),
birthday DATE,
sdt NVARCHAR(11))

ALTER TABLE dbo.tblEmployee ADD cmnd nvarchar(12)

GO 

CREATE TABLE tblAccount(
employeeID NVARCHAR(10) PRIMARY KEY FOREIGN KEY REFERENCES dbo.tblEmployee(employeeID) ON DELETE CASCADE ON UPDATE CASCADE,
password NVARCHAR(20),
role NVARCHAR(10),
office NVARCHAR(20))

GO 

CREATE TABLE tblLoginHistory(
employeeID NVARCHAR(10) FOREIGN KEY REFERENCES dbo.tblEmployee(employeeID) ON DELETE CASCADE ON UPDATE CASCADE,
dateTimeLogin DATETIME,
dateTimeLogout DATETIME)

GO 

CREATE TABLE tblEvaluate(
employeeID NVARCHAR(10) PRIMARY KEY FOREIGN KEY REFERENCES dbo.tblEmployee(employeeID) ON DELETE CASCADE ON UPDATE CASCADE,
times INT,
monthOfYear NVARCHAR(7))

GO
 
CREATE FUNCTION AutoCreateCustomerID()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(customerID) FROM dbo.tblCustomer) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(customerID, 3)) FROM dbo.tblCustomer
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

GO
 
CREATE TABLE tblCustomer(
customerID NVARCHAR(6) PRIMARY KEY DEFAULT dbo.AutoCreateCustomerID(),
name NVARCHAR(30),
sdt NVARCHAR(11),
regularCustomer INT)

GO 

CREATE TABLE tblTable(
tableID NVARCHAR(10) PRIMARY KEY,
tier INT,
peoples INT)

GO 

CREATE TABLE tblTableStatus(
tableID NVARCHAR(10) PRIMARY KEY FOREIGN KEY REFERENCES dbo.tblTable(tableID) ON DELETE CASCADE ON UPDATE CASCADE,
status NVARCHAR(20))

GO

CREATE TABLE tblSelectTable(
customerID NVARCHAR(6) FOREIGN KEY REFERENCES dbo.tblCustomer(customerID) ON DELETE CASCADE ON UPDATE CASCADE,
tableID NVARCHAR(10) PRIMARY KEY FOREIGN KEY REFERENCES dbo.tblTable(tableID) ON DELETE CASCADE ON UPDATE CASCADE,
status INT) 

GO

CREATE TABLE tblCategory(
categoryID NVARCHAR(10) PRIMARY KEY,
name NVARCHAR(30))

GO

CREATE TABLE tblFood(
foodID NVARCHAR(10) PRIMARY KEY,
categoryID NVARCHAR(10) FOREIGN KEY REFERENCES dbo.tblCategory(categoryID) ON DELETE CASCADE ON UPDATE CASCADE,
name NVARCHAR(30),
price FLOAT,
unit NVARCHAR(10),
avatarPath NVARCHAR(30))


---Trigger---
DROP TRIGGER After_tblTable_Add

CREATE TRIGGER After_tblTable_Add
ON tblTable
AFTER INSERT
AS 
BEGIN
	DECLARE @tableID NVARCHAR(10)
	SELECT @tableID=INSERTED.tableID 
	FROM INSERTED,dbo.tblTable 
	WHERE INSERTED.tableID=dbo.tblTable.tableID
	INSERT INTO dbo.tblTableStatus
	        ( tableID, status )
	VALUES  ( @tableID, -- tableID - nvarchar(10)
	          N'Rảnh'  -- status - nvarchar(20)
	          ) 
END  
