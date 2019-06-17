CREATE TABLE [dbo].[Onderdelencode]
(
	[Leveranciers_id] INT NOT NULL, 
    [Onderdeel_id] INT NOT NULL, 
    [Onderdelencode_leverancier] NVARCHAR(MAX) NULL, 
    [Aankoopprijs] INT NULL,
	PRIMARY KEY ([Leveranciers_id], [Onderdeel_id]), 
)
