CREATE TABLE [dbo].[Country]
(
	[Country_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Capital] VARCHAR(50) NOT NULL, 
    [Language] VARCHAR(50) NOT NULL
)
