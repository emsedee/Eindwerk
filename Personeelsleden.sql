CREATE TABLE [dbo].[Personeelsleden]
(
	[Personeels_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Naam] VARCHAR(50) NULL, 
    [Voornaam] VARCHAR(50) NULL, 
    [Gsm Nummer] NVARCHAR(MAX) NULL, 
    [Emailadres] NVARCHAR(MAX) NULL, 
    [Foto] IMAGE NULL, 
    [Soort Personeelslid] NVARCHAR(50) NULL
)
