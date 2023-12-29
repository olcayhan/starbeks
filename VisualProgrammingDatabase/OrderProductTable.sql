CREATE TABLE [dbo].[OrderProduct]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(20) NULL, 
    [Piece] INT NULL, 
    [Price] FLOAT NULL, 
    [OrderID] INT NULL,
)
