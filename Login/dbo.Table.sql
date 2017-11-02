CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [firstName] VARCHAR(100) NOT NULL, 
    [middleName] VARCHAR(100) NULL, 
    [lastName] VARCHAR(100) NOT NULL, 
    [address] VARCHAR(100) NOT NULL, 
    [city] VARCHAR(50) NOT NULL, 
    [state] VARCHAR(50) NOT NULL, 
    [zip] INT NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [username] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [homePhoneNumber] INT NULL, 
    [cellPhoneNumber] INT NULL, 
    [file] VARCHAR(300) NULL, 
    [major] VARCHAR(50) NULL
)
