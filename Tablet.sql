CREATE TABLE [dbo].[Tablet]
(
	[Tablet_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Prijs] INT NULL, 
    [Merk] VARCHAR(50) NULL, 
    [BesturingsSysteeem] VARCHAR(50) NULL, 
    [SchermType] VARCHAR(50) NULL, 
    [Resolutie] INT NULL 
)
