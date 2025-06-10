IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250224021547_Initial Migration'
)
BEGIN
    CREATE TABLE [Difficulties] (
        [Id] uniqueidentifier NOT NULL,
        [Challenge] int NOT NULL,
        CONSTRAINT [PK_Difficulties] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250224021547_Initial Migration'
)
BEGIN
    CREATE TABLE [Locations] (
        [Id] uniqueidentifier NOT NULL,
        [Code] nvarchar(max) NOT NULL,
        [WalkLocation] int NOT NULL,
        [LocationImageUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_Locations] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250224021547_Initial Migration'
)
BEGIN
    CREATE TABLE [Walks] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [LengthInMiles] float NOT NULL,
        [LocationImageUrl] nvarchar(max) NULL,
        [DifficultyId] uniqueidentifier NOT NULL,
        [LocationId] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_Walks] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Walks_Difficulties_DifficultyId] FOREIGN KEY ([DifficultyId]) REFERENCES [Difficulties] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Walks_Locations_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [Locations] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250224021547_Initial Migration'
)
BEGIN
    CREATE INDEX [IX_Walks_DifficultyId] ON [Walks] ([DifficultyId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250224021547_Initial Migration'
)
BEGIN
    CREATE INDEX [IX_Walks_LocationId] ON [Walks] ([LocationId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250224021547_Initial Migration'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250224021547_Initial Migration', N'8.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250514003957_Adding Images Table'
)
BEGIN
    CREATE TABLE [Images] (
        [Id] uniqueidentifier NOT NULL,
        [FileName] nvarchar(max) NOT NULL,
        [FileDescription] nvarchar(max) NULL,
        [FileExtension] nvarchar(max) NOT NULL,
        [FileSizeInBytes] bigint NOT NULL,
        [FilePath] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Images] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250514003957_Adding Images Table'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250514003957_Adding Images Table', N'8.0.14');
END;
GO

COMMIT;
GO

