CREATE TABLE [dbo].[Bestelde onderdelen]
(
	[Bestel_id] INT Identity NOT NULL, 
    [Onderdeel_id] INT NOT NULL, 
    [Onderdelencode_leverancier] VARCHAR(MAX) NULL, 
    [Aantal] INT NULL
	PRIMARY KEY ([Onderdeel_id], [Bestel_id]), 
)
