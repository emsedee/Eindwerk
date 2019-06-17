CREATE TABLE [dbo].[Competentie]
(
	[Personeels_id] INT NOT NULL IDENTITY,
    [Specialisatie_id] INT NOT NULL, 
	PRIMARY KEY ([Personeels_id], [Specialisatie_id]), 
    [Niveau] NCHAR(10) NULL, 
    [Niveau_id] INT NULL, 
    [Datum verworven] DATETIME NULL, 
    CONSTRAINT [FK_Competentie_Niveau] FOREIGN KEY ([Niveau_id]) REFERENCES [Niveau]([Niveau_id])
	
)
