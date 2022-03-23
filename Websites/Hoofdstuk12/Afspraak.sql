CREATE TABLE [dbo].[Table]
(
	[Item_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Dag] DATE NOT NULL, 
    [Tijd] CHAR(5) NOT NULL, 
    [Bericht] VARCHAR(512) NOT NULL
)
