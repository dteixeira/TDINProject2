CREATE TABLE [dbo].[Delivery]
(
	[DeliveryID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookID] INT NOT NULL, 
    [BookTitle] NVARCHAR(256) NOT NULL, 
    [BookAuthor] NVARCHAR(256) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Completed] BIT NOT NULL, 
    [OrderID] UNIQUEIDENTIFIER NOT NULL
)
