CREATE PROCEDURE [dbo].[spInsertEmployee]
	@Empid int out,
	@FirstName NVARCHAR (10),
	@LastName nVarchar(20),
	@Title NVARCHAR (30),
	@TitleOfCourtesy NVARCHAR (25),
	@BirthDate      DATETIME   ,  
	@HireDate       DATETIME    , 
	@Address        NVARCHAR (60),
	@City          NVARCHAR (15),
	@Region         NVARCHAR (15),
	@Country         NVARCHAR (15),
	@PostalCode    NVARCHAR (10),
	@Mgrid           INT,
	@Phone          NVARCHAR (24)
AS
	INSERT INTO [HR].[Employees] (lastname, firstname,title, titleofcourtesy, birthdate, hiredate, [address],city,region,postalcode, country, phone,mgrid) 
		values(@LastName, @FirstName,@Title,@TitleOfCourtesy,@BirthDate,@HireDate,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Mgrid)
	
Go
