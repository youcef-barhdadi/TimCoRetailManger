CREATE TABLE [dbo].[Inventory]
( 
	[Id] INT NOT NULL PRIMARY KEY IDENTITY ,
	[ProdcutID] INT NOT NULL  FOREIGN KEY  REFERENCES  [Product](Id) ,
	[Quantity] INT NOT NULL DEFAULT 1,
	[PurchasePrice] MONEY NOT NULL ,
	[PurchaseDate] DATETIME2 NOT NULL DEFAULT getutcdate(),
 )
