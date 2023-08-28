CREATE TABLE [dbo].[Item]
(
	[ItemID] INT NOT NULL PRIMARY KEY Identity(1,1),
	[CategoryID] INT NOT NULL,
	[Name] NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(100) NULL
)
