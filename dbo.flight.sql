CREATE TABLE [dbo].[flight]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Flight Code] NVARCHAR(MAX) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Age] NVARCHAR(50) NOT NULL, 
    [NID] NVARCHAR(MAX) NOT NULL, 
    [Nationality] NVARCHAR(MAX) NOT NULL, 
    [Destination] NVARCHAR(MAX) NOT NULL, 
    [Date] DATETIME NOT NULL
)
