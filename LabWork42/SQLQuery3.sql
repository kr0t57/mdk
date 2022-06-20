-- 3
ALTER PROCEDURE AddNewOrder
	@Login VARCHAR(20),
	@LastOrderId INT OUTPUT
AS
DECLARE @CustomerId INT;
SET @CustomerId = (SELECT IdCustomer
				  FROM Customer
				  WHERE Customer.Login = @Login);
INSERT INTO Orders (IdCustomer)
VALUES(@CustomerId);
SET @LastOrderId = SCOPE_IDENTITY();

DECLARE @Last INT;
EXEC AddNewOrder 'PeckovaD', @Last OUTPUT;

SELECT @Last;
