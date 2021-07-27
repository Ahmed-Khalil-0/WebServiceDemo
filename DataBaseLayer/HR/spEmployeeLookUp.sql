CREATE PROCEDURE [dbo].[spEmployeeLookUp]
	@id int
AS 
	SELECT * from HR.Employees where empid = @id;
GO
