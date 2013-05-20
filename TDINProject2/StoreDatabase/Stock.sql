﻿CREATE TABLE [dbo].[Stock]
(
	[StockID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookID] INT UNIQUE NOT NULL, 
    [Copies] INT NOT NULL, 
    CONSTRAINT [FK_Stock_ToBook] FOREIGN KEY ([BookID]) REFERENCES [Book]([BookID]) ON DELETE CASCADE
)
