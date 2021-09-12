CREATE PROCEDURE [dbo].[spMembershipAuth]
	@param1 nvarchar
AS
	SELECT [UserName], [Password] from dbo.Membership where UserName = @param1
Go
