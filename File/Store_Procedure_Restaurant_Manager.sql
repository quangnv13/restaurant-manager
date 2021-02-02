CREATE PROC Confirm_Login @employeeID NVARCHAR(10),@password NVARCHAR(20)
						  AS
						  BEGIN
							   SELECT * FROM dbo.tblAccount
							   WHERE employeeID=@employeeID AND password=@password
						  END
Confirm_Login @employeeID='NV001',@password='123'

CREATE PROC GetAllInfoEmployee @employeeID NVARCHAR(10)
						AS 
						BEGIN
							SELECT name,role,office,cmnd FROM dbo.tblEmployee,dbo.tblAccount
							WHERE tblAccount.employeeID=dbo.tblEmployee.employeeID 
							AND dbo.tblEmployee.employeeID=@employeeID
						END
GetAllInfoEmployee @employeeID='NV001'

CREATE PROC GetAllTier
						AS 
						BEGIN
							SELECT tier FROM dbo.tblTable
							GROUP BY tier
						END
GetAllTier

CREATE PROC GetAllInfoTable
						AS 
						BEGIN
							SELECT dbo.tblTable.tableID,tier,peoples,status FROM dbo.tblTable,dbo.tblTableStatus
							WHERE dbo.tblTable.tableID=dbo.tblTableStatus.tableID
						END
						
GetAllInfoTable

CREATE PROC GetAllInfoTableTier @tier int
						AS 
						BEGIN
							SELECT dbo.tblTable.tableID,tier,peoples,status FROM dbo.tblTable,dbo.tblTableStatus
							WHERE dbo.tblTable.tableID=dbo.tblTableStatus.tableID
							AND tier=@tier
						END
						
GetAllInfoTableTier @tier=2  