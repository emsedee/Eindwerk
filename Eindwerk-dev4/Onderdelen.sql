CREATE TABLE [dbo].[Onderdelen]
(
	[Toestel_id] INT NOT NULL, 
    [Onderdeel_id] INT NOT NULL, 
    [Kleur] VARCHAR(50) NULL, 
    [Omschrijving] VARCHAR(MAX) NULL, 
    [Formaat] INT NULL, 
    [Gewicht] INT NULL, 
	[Parentonderdeel_ID] INT NULL, 
    PRIMARY KEY ([Toestel_id], [Onderdeel_id]), 
    CONSTRAINT [FK_Onderdelen_Toestel] FOREIGN KEY ([Toestel_id]) REFERENCES [Toestel]([Toestel_id])
)
