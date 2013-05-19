CREATE TRIGGER [CreateStockTrigger]
ON [Book]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @BookID int
	SET @BookID = (SELECT [BookID] FROM inserted)
	INSERT INTO [Stock] ([BookID], [Copies]) VALUES (@BookID, 10)
END
