CREATE TABLE [dbo].[Betrokkenheid]
(
	[Interventie_id] INT NOT NULL
	PRIMARY KEY  ([Interventie_id], [Personeels_id]) IDENTITY, 
    [Personeels_id] INT NOT NULL, 
    [Begin] DATETIME NULL, 
    [Einde] DATETIME NULL, 
)
