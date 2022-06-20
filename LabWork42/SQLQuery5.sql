-- 5
ALTER PROCEDURE AddNewAuthorOrUpdate
	@LastName NVARCHAR(50),	
	@FirstName NVARCHAR(50),
	@Country NVARCHAR(30)
AS
IF NOT EXISTS (SELECT *
		   FROM Author
		   WHERE LastName = @LastName AND FirstName = @FirstName)
BEGIN
	INSERT INTO Author (LastName, FirstName, Country)
	VALUES(@LastName, @FirstName, @Country);
END
ELSE
BEGIN
	UPDATE Author
	SET Country = @Country
	WHERE LastName = @LastName AND FirstName = @FirstName;
END

EXEC AddNewAuthorOrUpdate 'Пушкин2', 'Сергей', 'РОССИЯ';
