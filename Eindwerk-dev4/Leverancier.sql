CREATE TABLE [dbo].[Leverancier]
(
	[Leveranciers_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Naam] VARCHAR(50) NULL, 
    [Telefoon] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Website] VARCHAR(MAX) NULL, 
    [Straat] VARCHAR(50) NULL, 
    [Huisnummer] VARCHAR(50) NULL, 
    [Postcode] VARCHAR(50) NULL, 
    [Stad] VARCHAR(50) NULL
)
