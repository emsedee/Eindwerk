CREATE TABLE [dbo].[Voorraad]
(
	[Onderdeel_id] INT NOT NULL,
    [Locatie_id] INT NOT NULL, 
	PRIMARY KEY ([Onderdeel_id], [Locatie_id]), 
    [Aantal] INT NULL
)
