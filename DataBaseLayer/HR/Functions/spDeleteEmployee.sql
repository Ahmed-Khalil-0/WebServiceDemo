CREATE PROCEDURE [dbo].[spDeleteEmployee]
	@id int
AS
	Delete from HR.Employees where empid = @id
GO
