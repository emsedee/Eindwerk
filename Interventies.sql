CREATE TABLE [dbo].[Interventies]
(
	[Interventie_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Complexiteit] VARCHAR(50) NULL, 
    [Meldingsdatum] DATETIME NULL, 
    [Omschrijving] VARCHAR(MAX) NULL, 
    [Einddatum] DATETIME NULL, 
    [duur] DATETIME NULL, 
    [Verwachtteoplossingstermijn] DATETIME NULL, 
    [Omschrijving oplossing] VARCHAR(MAX) NULL, 
    [Personeels_id] INT NULL, 
    [Prioriteit_id] INT NULL, 
    [Toestel_id] INT NULL, 
    [Bestel_id] INT NULL, 
    [Soort interventie] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Interventies_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [Personeelsleden]([Personeels_id]), 
    CONSTRAINT [FK_Interventies_Prioriteit] FOREIGN KEY ([Prioriteit_id]) REFERENCES [Prioriteit]([Prioriteit_id]), 
    CONSTRAINT [FK_Interventies_Toestel] FOREIGN KEY ([Toestel_id]) REFERENCES [Toestel]([Toestel_id]), 
    CONSTRAINT [FK_Interventies_Bestellingen] FOREIGN KEY ([Bestel_id]) REFERENCES [Bestellingen]([Bestel_id])
)
