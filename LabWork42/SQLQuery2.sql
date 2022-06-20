-- 2
CREATE PROCEDURE UpdatePrices
	@Rubles DECIMAL(6, 2),
	@Genre NVARCHAR(10)
AS
UPDATE Book
SET Price = Price + @Rubles
WHERE Genre = @Genre;

EXEC UpdatePrices 150, 'проза';