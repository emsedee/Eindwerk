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
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET TEMPORAL_HISTORY_RETENTION ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Bestelde onderdelen]...';


GO
CREATE TABLE [dbo].[Bestelde onderdelen] (
    [Bestel_id]                  INT           NOT NULL,
    [Onderdeel_id]               INT           NOT NULL,
    [Onderdelencode_leverancier] VARCHAR (MAX) NULL,
    [Aantal]                     INT           NULL,
    PRIMARY KEY CLUSTERED ([Onderdeel_id] ASC, [Bestel_id] ASC)
);


GO
PRINT N'Creating [dbo].[Bestellingen]...';


GO
CREATE TABLE [dbo].[Bestellingen] (
    [Bestel_id]       INT        IDENTITY (1, 1) NOT NULL,
    [Besteldatum]     NCHAR (10) NULL,
    [LeveringsDatum]  NCHAR (10) NULL,
    [Leveranciers_id] INT        NOT NULL,
    [Personeels_id]   INT        NOT NULL,
    [Factuur_id]      INT        NOT NULL,
    [Interventie_id]  INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Bestel_id] ASC)
);


GO
PRINT N'Creating [dbo].[Betrokkenheid]...';


GO
CREATE TABLE [dbo].[Betrokkenheid] (
    [Interventie_id] INT      NOT NULL,
    [Personeels_id]  INT      NOT NULL,
    [Begin]          DATETIME NULL,
    [Einde]          DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Interventie_id] ASC, [Personeels_id] ASC)
);


GO
PRINT N'Creating [dbo].[Competentie]...';


GO
CREATE TABLE [dbo].[Competentie] (
    [Personeels_id]    INT        NOT NULL,
    [Specialisatie_id] INT        NOT NULL,
    [Niveau]           NCHAR (10) NULL,
    [Niveau_id]        INT        NULL,
    [Datum verworven]  DATETIME   NULL,
    PRIMARY KEY CLUSTERED ([Personeels_id] ASC, [Specialisatie_id] ASC)
);


GO
PRINT N'Creating [dbo].[Facturen]...';


GO
CREATE TABLE [dbo].[Facturen] (
    [Factuur_id]  INT      NOT NULL,
    [Datum]       DATETIME NULL,
    [VervalDatum] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Factuur_id] ASC)
);


GO
PRINT N'Creating [dbo].[Fotos]...';


GO
CREATE TABLE [dbo].[Fotos] (
    [Foto_id]        INT NOT NULL,
    [Interventie_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Foto_id] ASC)
);


GO
PRINT N'Creating [dbo].[Interventie competenties]...';


GO
CREATE TABLE [dbo].[Interventie competenties] (
    [Interventie_id]   INT NOT NULL,
    [Personeels_id]    INT NOT NULL,
    [Specialisatie_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Interventie_id] ASC, [Specialisatie_id] ASC, [Personeels_id] ASC)
);


GO
PRINT N'Creating [dbo].[Interventies]...';


GO
CREATE TABLE [dbo].[Interventies] (
    [Interventie_id]              INT           NOT NULL,
    [Complexiteit]                VARCHAR (50)  NULL,
    [Meldingsdatum]               DATETIME      NULL,
    [Omschrijving]                VARCHAR (MAX) NULL,
    [Einddatum]                   DATETIME      NULL,
    [duur]                        DATETIME      NULL,
    [Verwachtteoplossingstermijn] DATETIME      NULL,
    [Omschrijving oplossing]      VARCHAR (MAX) NULL,
    [Personeels_id]               INT           NULL,
    [Prioriteit_id]               INT           NULL,
    [Toestel_id]                  INT           NULL,
    [Bestel_id]                   INT           NULL,
    [Soort interventie]           NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Interventie_id] ASC)
);


GO
PRINT N'Creating [dbo].[Kennisgebieden]...';


GO
CREATE TABLE [dbo].[Kennisgebieden] (
    [Specialisatie_id]   INT           NOT NULL,
    [Korte omschrijving] VARCHAR (50)  NULL,
    [Lange omschrijving] VARCHAR (MAX) NULL,
    [Soort kennisgebied] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Specialisatie_id] ASC)
);


GO
PRINT N'Creating [dbo].[Leverancier]...';


GO
CREATE TABLE [dbo].[Leverancier] (
    [Leveranciers_id] INT           NOT NULL,
    [Naam]            VARCHAR (50)  NULL,
    [Telefoon]        VARCHAR (50)  NULL,
    [Email]           VARCHAR (50)  NULL,
    [Website]         VARCHAR (MAX) NULL,
    [Straat]          VARCHAR (50)  NULL,
    [Huisnummer]      VARCHAR (50)  NULL,
    [Postcode]        VARCHAR (50)  NULL,
    [Stad]            VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Leveranciers_id] ASC)
);


GO
PRINT N'Creating [dbo].[Locatie]...';


GO
CREATE TABLE [dbo].[Locatie] (
    [Locatie_id]       INT        NOT NULL,
    [VoorraadPlaatsen] NCHAR (10) NULL,
    [Oppervlakte]      NCHAR (10) NULL,
    [Soort Ruimte]     NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Locatie_id] ASC)
);


GO
PRINT N'Creating [dbo].[Niveau]...';


GO
CREATE TABLE [dbo].[Niveau] (
    [Niveau_id] INT          NOT NULL,
    [Beginner]  VARCHAR (50) NULL,
    [Ervaren]   VARCHAR (50) NULL,
    [Expert]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Niveau_id] ASC)
);


GO
PRINT N'Creating [dbo].[Onderdelen]...';


GO
CREATE TABLE [dbo].[Onderdelen] (
    [Toestel_id]         INT           NOT NULL,
    [Onderdeel_id]       INT           NOT NULL,
    [Kleur]              VARCHAR (50)  NULL,
    [Omschrijving]       VARCHAR (MAX) NULL,
    [Formaat]            INT           NULL,
    [Gewicht]            INT           NULL,
    [Parentonderdeel_ID] INT           NULL,
    PRIMARY KEY CLUSTERED ([Toestel_id] ASC, [Onderdeel_id] ASC)
);


GO
PRINT N'Creating [dbo].[Onderdelencode]...';


GO
CREATE TABLE [dbo].[Onderdelencode] (
    [Leveranciers_id]            INT            NOT NULL,
    [Onderdeel_id]               INT            NOT NULL,
    [Onderdelencode_leverancier] NVARCHAR (MAX) NULL,
    [Aankoopprijs]               INT            NULL,
    PRIMARY KEY CLUSTERED ([Leveranciers_id] ASC, [Onderdeel_id] ASC)
);


GO
PRINT N'Creating [dbo].[Personeelsleden]...';


GO
CREATE TABLE [dbo].[Personeelsleden] (
    [Personeels_id]       INT            IDENTITY (1, 1) NOT NULL,
    [Naam]                VARCHAR (50)   NULL,
    [Voornaam]            VARCHAR (50)   NULL,
    [Gsm Nummer]          NVARCHAR (MAX) NULL,
    [Emailadres]          VARBINARY (50) NULL,
    [Foto]                IMAGE          NULL,
    [Soort Personeelslid] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Personeels_id] ASC)
);


GO
PRINT N'Creating [dbo].[Prioriteit]...';


GO
CREATE TABLE [dbo].[Prioriteit] (
    [Prioriteit_id] INT        NOT NULL,
    [Gewoon]        NCHAR (10) NULL,
    [Dringend]      NCHAR (10) NULL,
    [Zeer Dringen]  NCHAR (10) NULL,
    [Hoog Dringend] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Prioriteit_id] ASC)
);


GO
PRINT N'Creating [dbo].[Tablet]...';


GO
CREATE TABLE [dbo].[Tablet] (
    [Tablet_id]          INT          NOT NULL,
    [Processorsnelheid]  INT          NULL,
    [Ramgeheugen]        INT          NULL,
    [OpslageCapaciteit]  INT          NULL,
    [Prijs]              INT          NULL,
    [Merk]               VARCHAR (50) NULL,
    [BesturingsSysteeem] VARCHAR (50) NULL,
    [OpslagCapaciteit]   INT          NULL,
    [SchermType]         VARCHAR (50) NULL,
    [Resolutie]          INT          NULL,
    [Formaat]            INT          NULL,
    [Kleur]              VARCHAR (50) NULL,
    [ProcessorKernen]    INT          NULL,
    [Gewicht]            INT          NULL,
    PRIMARY KEY CLUSTERED ([Tablet_id] ASC)
);


GO
PRINT N'Creating [dbo].[TabletPersoneelsLeden]...';


GO
CREATE TABLE [dbo].[TabletPersoneelsLeden] (
    [Tablet_id]     INT NOT NULL,
    [Personeels_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Tablet_id] ASC, [Personeels_id] ASC)
);


GO
PRINT N'Creating [dbo].[Toestel]...';


GO
CREATE TABLE [dbo].[Toestel] (
    [Toestel_id]        INT           NOT NULL,
    [Naam]              VARCHAR (50)  NULL,
    [Merk]              VARCHAR (50)  NULL,
    [Keuring]           DATETIME      NULL,
    [Ouderdom]          INT           NULL,
    [Omschrijving]      VARCHAR (MAX) NULL,
    [Formaat]           INT           NULL,
    [Maximum gewicht]   INT           NULL,
    [Type matras]       VARCHAR (50)  NULL,
    [Type aandrijving]  VARCHAR (50)  NULL,
    [Opplooibaar]       BIT           NULL,
    [Verstelbaar]       BIT           NULL,
    [Materie]           VARCHAR (50)  NULL,
    [DatumAfschrijving] DATETIME      NULL,
    [Locatie_id]        INT           NULL,
    [Soort toestel]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Toestel_id] ASC)
);


GO
PRINT N'Creating [dbo].[Voorraad]...';


GO
CREATE TABLE [dbo].[Voorraad] (
    [Onderdeel_id] INT NOT NULL,
    [Locatie_id]   INT NOT NULL,
    [Aantal]       INT NULL,
    PRIMARY KEY CLUSTERED ([Onderdeel_id] ASC, [Locatie_id] ASC)
);


GO
PRINT N'Creating [dbo].[FK_Bestellingen_Leverancier]...';


GO
ALTER TABLE [dbo].[Bestellingen]
    ADD CONSTRAINT [FK_Bestellingen_Leverancier] FOREIGN KEY ([Leveranciers_id]) REFERENCES [dbo].[Leverancier] ([Leveranciers_id]);


GO
PRINT N'Creating [dbo].[FK_Bestellingen_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Bestellingen]
    ADD CONSTRAINT [FK_Bestellingen_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Creating [dbo].[FK_Bestellingen_Facturen]...';


GO
ALTER TABLE [dbo].[Bestellingen]
    ADD CONSTRAINT [FK_Bestellingen_Facturen] FOREIGN KEY ([Factuur_id]) REFERENCES [dbo].[Facturen] ([Factuur_id]);


GO
PRINT N'Creating [dbo].[FK_Bestellingen_Interventies]...';


GO
ALTER TABLE [dbo].[Bestellingen]
    ADD CONSTRAINT [FK_Bestellingen_Interventies] FOREIGN KEY ([Interventie_id]) REFERENCES [dbo].[Interventies] ([Interventie_id]);


GO
PRINT N'Creating [dbo].[FK_Competentie_Niveau]...';


GO
ALTER TABLE [dbo].[Competentie]
    ADD CONSTRAINT [FK_Competentie_Niveau] FOREIGN KEY ([Niveau_id]) REFERENCES [dbo].[Niveau] ([Niveau_id]);


GO
PRINT N'Creating [dbo].[FK_Fotos_Interventies]...';


GO
ALTER TABLE [dbo].[Fotos]
    ADD CONSTRAINT [FK_Fotos_Interventies] FOREIGN KEY ([Interventie_id]) REFERENCES [dbo].[Interventies] ([Interventie_id]);


GO
PRINT N'Creating [dbo].[FK_Interventie competenties_Interventies]...';


GO
ALTER TABLE [dbo].[Interventie competenties]
    ADD CONSTRAINT [FK_Interventie competenties_Interventies] FOREIGN KEY ([Interventie_id]) REFERENCES [dbo].[Interventies] ([Interventie_id]);


GO
PRINT N'Creating [dbo].[FK_Interventie competenties_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Interventie competenties]
    ADD CONSTRAINT [FK_Interventie competenties_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Creating [dbo].[FK_Interventie competenties_Kennisgebieden]...';


GO
ALTER TABLE [dbo].[Interventie competenties]
    ADD CONSTRAINT [FK_Interventie competenties_Kennisgebieden] FOREIGN KEY ([Specialisatie_id]) REFERENCES [dbo].[Kennisgebieden] ([Specialisatie_id]);


GO
PRINT N'Creating [dbo].[FK_Interventies_Personeelsleden]...';


GO
ALTER TABLE [dbo].[Interventies]
    ADD CONSTRAINT [FK_Interventies_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Creating [dbo].[FK_Interventies_Prioriteit]...';


GO
ALTER TABLE [dbo].[Interventies]
    ADD CONSTRAINT [FK_Interventies_Prioriteit] FOREIGN KEY ([Prioriteit_id]) REFERENCES [dbo].[Prioriteit] ([Prioriteit_id]);


GO
PRINT N'Creating [dbo].[FK_Interventies_Toestel]...';


GO
ALTER TABLE [dbo].[Interventies]
    ADD CONSTRAINT [FK_Interventies_Toestel] FOREIGN KEY ([Toestel_id]) REFERENCES [dbo].[Toestel] ([Toestel_id]);


GO
PRINT N'Creating [dbo].[FK_Interventies_Bestellingen]...';


GO
ALTER TABLE [dbo].[Interventies]
    ADD CONSTRAINT [FK_Interventies_Bestellingen] FOREIGN KEY ([Bestel_id]) REFERENCES [dbo].[Bestellingen] ([Bestel_id]);


GO
PRINT N'Creating [dbo].[FK_Onderdelen_Toestel]...';


GO
ALTER TABLE [dbo].[Onderdelen]
    ADD CONSTRAINT [FK_Onderdelen_Toestel] FOREIGN KEY ([Toestel_id]) REFERENCES [dbo].[Toestel] ([Toestel_id]);


GO
PRINT N'Creating [dbo].[FK_TabletPersoneelsLeden_Tablet]...';


GO
ALTER TABLE [dbo].[TabletPersoneelsLeden]
    ADD CONSTRAINT [FK_TabletPersoneelsLeden_Tablet] FOREIGN KEY ([Tablet_id]) REFERENCES [dbo].[Tablet] ([Tablet_id]);


GO
PRINT N'Creating [dbo].[FK_TabletPersoneelsLeden_Personeelsleden]...';


GO
ALTER TABLE [dbo].[TabletPersoneelsLeden]
    ADD CONSTRAINT [FK_TabletPersoneelsLeden_Personeelsleden] FOREIGN KEY ([Personeels_id]) REFERENCES [dbo].[Personeelsleden] ([Personeels_id]);


GO
PRINT N'Creating [dbo].[FK_Toestel_Locatie]...';


GO
ALTER TABLE [dbo].[Toestel]
    ADD CONSTRAINT [FK_Toestel_Locatie] FOREIGN KEY ([Locatie_id]) REFERENCES [dbo].[Locatie] ([Locatie_id]);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c005943f-4164-4709-ae4a-d5f5b1e39e72')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c005943f-4164-4709-ae4a-d5f5b1e39e72')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '1551734d-c5fa-4c0a-afae-9c4e59319b0d')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('1551734d-c5fa-4c0a-afae-9c4e59319b0d')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '909f58e6-32e8-4c91-b8fa-a2bdba0be44a')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('909f58e6-32e8-4c91-b8fa-a2bdba0be44a')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '1eb21ba1-8067-4ba5-b9db-b36680cf20be')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('1eb21ba1-8067-4ba5-b9db-b36680cf20be')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a1a9039f-db73-47cf-9887-2ff85f582410')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a1a9039f-db73-47cf-9887-2ff85f582410')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '05bd2d23-ea65-43e5-a972-1347c9816f41')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('05bd2d23-ea65-43e5-a972-1347c9816f41')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'b538cd4e-62da-4b16-a06e-5cdee03d3ca4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('b538cd4e-62da-4b16-a06e-5cdee03d3ca4')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'd0eb8c39-a523-44ab-801a-28e72fe8e9de')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('d0eb8c39-a523-44ab-801a-28e72fe8e9de')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c09b2272-44ca-4ee8-b4a4-c44065c63c26')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c09b2272-44ca-4ee8-b4a4-c44065c63c26')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f08814e4-2f40-46ff-9c62-8f7330593195')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f08814e4-2f40-46ff-9c62-8f7330593195')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'deabbcbc-89f2-4f8a-8795-3b22a5894258')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('deabbcbc-89f2-4f8a-8795-3b22a5894258')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '12ac103b-7222-48a9-8ee7-015cbca1dd12')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('12ac103b-7222-48a9-8ee7-015cbca1dd12')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'dfb234b2-b0e0-4d2c-9760-431b993a2796')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('dfb234b2-b0e0-4d2c-9760-431b993a2796')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ad886eae-62ab-4a16-9cfe-8e941f092ba1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ad886eae-62ab-4a16-9cfe-8e941f092ba1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f0db6b54-fcd3-4ed1-82df-23c564efdb93')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f0db6b54-fcd3-4ed1-82df-23c564efdb93')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'cd7f57f0-98b4-40fe-a149-050ccf66f1ed')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('cd7f57f0-98b4-40fe-a149-050ccf66f1ed')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a3a0b49e-54e6-4cef-88b7-e4fd7e4949f6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a3a0b49e-54e6-4cef-88b7-e4fd7e4949f6')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '58f17355-b879-4932-9340-6b876a31ddda')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('58f17355-b879-4932-9340-6b876a31ddda')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '9f3fe3c6-e0d9-4733-ab5e-cddb2374545a')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('9f3fe3c6-e0d9-4733-ab5e-cddb2374545a')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '00c0393d-06c2-4f35-998c-449d4b25f0d5')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('00c0393d-06c2-4f35-998c-449d4b25f0d5')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c1d10888-0051-435c-9f02-a55b23b79379')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c1d10888-0051-435c-9f02-a55b23b79379')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '994d3a98-e4ce-4158-82ba-578d746bccea')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('994d3a98-e4ce-4158-82ba-578d746bccea')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f9a3d722-657f-43d4-b780-9a2d7a3cb28d')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f9a3d722-657f-43d4-b780-9a2d7a3cb28d')

GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
