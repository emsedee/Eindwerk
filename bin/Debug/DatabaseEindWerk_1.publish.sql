﻿/*
Deployment script for DatabaseEindWerk

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DatabaseEindWerk"
:setvar DefaultFilePrefix "DatabaseEindWerk"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Dropping [dbo].[FK_Bestellingen_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Bestellingen] DROP CONSTRAINT [FK_Bestellingen_Personeelsleden];


GO
PRINT N'Dropping [dbo].[FK_Interventie competenties_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Interventie competenties] DROP CONSTRAINT [FK_Interventie competenties_Personeelsleden];


GO
PRINT N'Dropping [dbo].[FK_Interventies_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Interventies] DROP CONSTRAINT [FK_Interventies_Personeelsleden];


GO
PRINT N'Dropping [dbo].[FK_TabletPersoneelsLeden_Personeelsleden]...';


GO
ALTER TABLE [dbo].[TabletPersoneelsLeden] DROP CONSTRAINT [FK_TabletPersoneelsLeden_Personeelsleden];


GO
PRINT N'Starting rebuilding table [dbo].[Personeelsleden]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Personeelsleden] (
    [Personeels_id]       INT            IDENTITY (1, 1) NOT NULL,
    [Naam]                VARCHAR (50)   NULL,
    [Voornaam]            VARCHAR (50)   NULL,
    [Gsm Nummer]          NVARCHAR (MAX) NULL,
    [Emailadres]          NVARCHAR (MAX) NULL,
    [Foto]                IMAGE          NULL,
    [Soort Personeelslid] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Personeels_id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Personeelsleden])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Personeelsleden] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Personeelsleden] ([Personeels_id], [Naam], [Voornaam], [Gsm Nummer], [Emailadres], [Foto], [Soort Personeelslid])
        SELECT   [Personeels_id],
                 [Naam],
                 [Voornaam],
                 [Gsm Nummer],
                 [Emailadres],
                 [Foto],
                 [Soort Personeelslid]
        FROM     [dbo].[Personeelsleden]
        ORDER BY [Personeels_id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Personeelsleden] OFF;
    END

DROP TABLE [dbo].[Personeelsleden];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Personeelsleden]', N'Personeelsleden';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creating [dbo].[FK_Bestellingen_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Bestellingen] WITH NOCHECK
    ADD CONSTRAINT [FK_Bestellingen_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Creating [dbo].[FK_Interventie competenties_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Interventie competenties] WITH NOCHECK
    ADD CONSTRAINT [FK_Interventie competenties_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Creating [dbo].[FK_Interventies_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Interventies] WITH NOCHECK
    ADD CONSTRAINT [FK_Interventies_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Creating [dbo].[FK_TabletPersoneelsLeden_Personeelsleden]...';


GO
ALTER TABLE [dbo].[TabletPersoneelsLeden] WITH NOCHECK
    ADD CONSTRAINT [FK_TabletPersoneelsLeden_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Bestellingen] WITH CHECK CHECK CONSTRAINT [FK_Bestellingen_Personeelsleden];

ALTER TABLE [dbo].[Interventie competenties] WITH CHECK CHECK CONSTRAINT [FK_Interventie competenties_Personeelsleden];

ALTER TABLE [dbo].[Interventies] WITH CHECK CHECK CONSTRAINT [FK_Interventies_Personeelsleden];

ALTER TABLE [dbo].[TabletPersoneelsLeden] WITH CHECK CHECK CONSTRAINT [FK_TabletPersoneelsLeden_Personeelsleden];


GO
PRINT N'Update complete.';


GO
