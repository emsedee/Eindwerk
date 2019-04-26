CREATE TABLE [dbo].[Kennisgebieden]
(
	[Specialisatie_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Korte omschrijving] VARCHAR(50) NULL, 
    [Lange omschrijving] VARCHAR(MAX) NULL, 
    [Soort kennisgebied] NCHAR(10) NULL
)
