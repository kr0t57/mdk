-- 1
ALTER PROCEDURE AddNewAuthor
	@LastName NVARCHAR(50),	
	@FirstName NVARCHAR(50),
	@Country NVARCHAR(30) = '������'
AS
INSERT INTO Author (LastName, FirstName, Country)
VALUES(@LastName, @FirstName, @Country);

EXEC AddNewAuthor '����������', '���������';