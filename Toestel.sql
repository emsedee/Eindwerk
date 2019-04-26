CREATE TABLE [dbo].[Toestel]
(
	[Toestel_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Naam] VARCHAR(50) NULL, 
    [Merk] VARCHAR(50) NULL, 
    [Keuring] DATETIME NULL, 
    [Ouderdom] INT NULL, 
    [Omschrijving] VARCHAR(MAX) NULL, 
    [Formaat] INT NULL, 
    [Maximum gewicht] INT NULL, 
    [Type matras] VARCHAR(50) NULL, 
    [Type aandrijving] VARCHAR(50) NULL, 
    [Opplooibaar] BIT NULL, 
    [Verstelbaar] BIT NULL, 
    [Materie] VARCHAR(50) NULL, 
    [DatumAfschrijving] DATETIME NULL, 
    [Locatie_id] INT NULL, 
    [Soort toestel] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Toestel_Locatie] FOREIGN KEY ([Locatie_id]) REFERENCES [Locatie]([Locatie_id])
)
