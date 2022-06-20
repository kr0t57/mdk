-- 4
ALTER PROCEDURE AddNewOrderAndComposition
	@Login VARCHAR(20),
	@IdBook INT,
	@Quantity TINYINT
AS
DECLARE @CustomerId INT, @CurrentOrderId INT;
SET @CustomerId = (SELECT IdCustomer
				  FROM Customer
				  WHERE Customer.Login = @Login);
INSERT INTO Orders (IdCustomer)
VALUES(@CustomerId);
SET @CurrentOrderId = SCOPE_IDENTITY();
INSERT INTO Composition (IdOrder, IdBook, Quantity)
VALUES(@CurrentOrderId, @IdBook, @Quantity)
SELECT Orders.IdOrder
	   ,Orders.DateTime
	   ,Customer.Login
	   ,Book.Title
	   ,Book.Price
	   ,Composition.Quantity
	   ,Book.Price * Composition.Quantity AS PRICE
FROM Orders
	JOIN Composition ON Orders.IdOrder = Composition.IdOrder
	JOIN Book ON Composition.IdBook = Book.IdBook
	JOIN Customer ON Orders.IdCustomer = Customer.IdCustomer
WHERE Orders.IdOrder = @CurrentOrderId;

EXEC AddNewOrderAndComposition 'PeckovaD', 13, 10;