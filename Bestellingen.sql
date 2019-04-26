CREATE TABLE [dbo].[Bestellingen]
(
	[Bestel_id] INT  NOT NULL PRIMARY KEY IDENTITY, 
    [Besteldatum] NCHAR(10) NULL, 
    [LeveringsDatum] NCHAR(10) NULL, 
    [Leveranciers_id] INT NOT NULL, 
    [Personeels_id] INT NOT NULL, 
    [Factuur_id] INT NOT NULL, 
    [Interventie_id] INT NOT NULL, 
    CONSTRAINT [FK_Bestellingen_Leverancier] FOREIGN KEY ([Leveranciers_id]) REFERENCES [Leverancier]([Leveranciers_id]), 
    CONSTRAINT [FK_Bestellingen_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [Personeelsleden]([Personeels_id]),
	CONSTRAINT [FK_Bestellingen_Facturen] FOREIGN KEY ([Factuur_id]) REFERENCES [Facturen]([Factuur_id]),
	CONSTRAINT [FK_Bestellingen_Interventies] FOREIGN KEY ([Interventie_id]) REFERENCES [Interventies]([Interventie_id]),

)
