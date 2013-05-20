﻿CREATE TABLE [dbo].[Delivery]
(
	[DeliveryID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderID] UNIQUEIDENTIFIER NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Accepted] BIT NOT NULL, 
    CONSTRAINT [FK_Delivery_ToOrder] FOREIGN KEY ([OrderID]) REFERENCES [Order]([OrderID]) ON DELETE CASCADE
)
