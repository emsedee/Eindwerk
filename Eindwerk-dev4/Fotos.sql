CREATE TABLE [dbo].[Fotos]
(
	[Foto_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Interventie_id] INT NOT NULL, 
    [image] IMAGE NULL, 
    CONSTRAINT [FK_Fotos_Interventies] FOREIGN KEY ([Interventie_id]) REFERENCES [Interventies]([Interventie_id])
)
