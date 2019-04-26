CREATE TABLE [dbo].[Prioriteit]
(
	[Prioriteit_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Gewoon] NCHAR(10) NULL, 
    [Dringend] NCHAR(10) NULL, 
    [Zeer Dringen] NCHAR(10) NULL, 
    [Hoog Dringend] NCHAR(10) NULL
)
