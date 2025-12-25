CREATE TABLE [dbo].[userinfo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FullName] NVARCHAR(MAX) NOT NULL, 
    [email] NCHAR(10) NOT NULL, 
    [Npass] NCHAR(10) NOT NULL
)
