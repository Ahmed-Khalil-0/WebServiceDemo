CREATE PROCEDURE [dbo].[spMembershipAuth]
	@UserName NVARCHAR(100)
AS
	SELECT [UserName], [Password] from dbo.Membership where UserName = @UserName
Go
