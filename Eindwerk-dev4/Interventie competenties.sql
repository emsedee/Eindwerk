CREATE TABLE [dbo].[Interventie competenties]
(
	[Interventie_id] INT NOT NULL, 

    [Personeels_id] INT NOT NULL, 

    [Specialisatie_id] INT NOT NULL, 
	PRIMARY KEY ([Interventie_id], [Specialisatie_id],[Personeels_id]), 
    CONSTRAINT [FK_Interventie competenties_Interventies] FOREIGN KEY ([Interventie_id]) REFERENCES [Interventies]([Interventie_id]), 
    CONSTRAINT [FK_Interventie competenties_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [Personeelsleden]([Personeels_id]), 
    CONSTRAINT [FK_Interventie competenties_Kennisgebieden] FOREIGN KEY ([Specialisatie_id]) REFERENCES [Kennisgebieden]([Specialisatie_id]), 
)
