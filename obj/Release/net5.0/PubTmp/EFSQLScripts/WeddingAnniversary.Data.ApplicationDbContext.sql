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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'00000000000000_CreateIdentitySchema', N'5.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE TABLE [guestLists] (
        [Id] int NOT NULL IDENTITY,
        CONSTRAINT [PK_guestLists] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE TABLE [notes] (
        [Id] int NOT NULL IDENTITY,
        [Use] nvarchar(50) NULL,
        CONSTRAINT [PK_notes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE TABLE [schedules] (
        [Id] int NOT NULL IDENTITY,
        CONSTRAINT [PK_schedules] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE TABLE [guests] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NULL,
        [Surname] nvarchar(50) NULL,
        [Email] nvarchar(100) NULL,
        [AllowedPusOne] bit NOT NULL,
        [GuestListId] int NOT NULL,
        [RSVP] bit NOT NULL,
        [PlusOne] bit NULL,
        [PlusOneName] nvarchar(50) NULL,
        [PlusOneSurname] nvarchar(50) NULL,
        [NotesId] int NULL,
        CONSTRAINT [PK_guests] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_guests_guestLists_GuestListId] FOREIGN KEY ([GuestListId]) REFERENCES [guestLists] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_guests_notes_NotesId] FOREIGN KEY ([NotesId]) REFERENCES [notes] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE TABLE [noteItems] (
        [Id] int NOT NULL IDENTITY,
        [NotesId] int NOT NULL,
        [NoteValue] nvarchar(max) NULL,
        CONSTRAINT [PK_noteItems] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_noteItems_notes_NotesId] FOREIGN KEY ([NotesId]) REFERENCES [notes] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE TABLE [invitations] (
        [Id] int NOT NULL IDENTITY,
        [OwnerEmail] nvarchar(max) NULL,
        [InvitationIntro] nvarchar(max) NULL,
        [OurStory] nvarchar(max) NULL,
        [ScheduleId] int NULL,
        [Venue] nvarchar(max) NULL,
        [VenueLocation] nvarchar(max) NULL,
        [VenueWebsite] nvarchar(max) NULL,
        [WeddingDate] datetime2 NOT NULL,
        [RSVPDate] datetime2 NOT NULL,
        CONSTRAINT [PK_invitations] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_invitations_schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [schedules] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE TABLE [scheduleItems] (
        [Id] int NOT NULL IDENTITY,
        [ScheduleId] int NOT NULL,
        [ItemName] nvarchar(50) NULL,
        [ItemDescription] nvarchar(50) NULL,
        [ItemTime] nvarchar(50) NULL,
        [NotesId] int NULL,
        [GuestListId] int NULL,
        CONSTRAINT [PK_scheduleItems] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_scheduleItems_guestLists_GuestListId] FOREIGN KEY ([GuestListId]) REFERENCES [guestLists] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_scheduleItems_notes_NotesId] FOREIGN KEY ([NotesId]) REFERENCES [notes] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_scheduleItems_schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [schedules] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE INDEX [IX_guests_GuestListId] ON [guests] ([GuestListId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE INDEX [IX_guests_NotesId] ON [guests] ([NotesId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE INDEX [IX_invitations_ScheduleId] ON [invitations] ([ScheduleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE INDEX [IX_noteItems_NotesId] ON [noteItems] ([NotesId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE INDEX [IX_scheduleItems_GuestListId] ON [scheduleItems] ([GuestListId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE INDEX [IX_scheduleItems_NotesId] ON [scheduleItems] ([NotesId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    CREATE INDEX [IX_scheduleItems_ScheduleId] ON [scheduleItems] ([ScheduleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727190228_addAll')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210727190228_addAll', N'5.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727202010_addedWeddingName')
BEGIN
    ALTER TABLE [invitations] ADD [WeddingName] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210727202010_addedWeddingName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210727202010_addedWeddingName', N'5.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210729223726_addNoteIdToInvitation')
BEGIN
    ALTER TABLE [invitations] ADD [NotesId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210729223726_addNoteIdToInvitation')
BEGIN
    CREATE INDEX [IX_invitations_NotesId] ON [invitations] ([NotesId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210729223726_addNoteIdToInvitation')
BEGIN
    ALTER TABLE [invitations] ADD CONSTRAINT [FK_invitations_notes_NotesId] FOREIGN KEY ([NotesId]) REFERENCES [notes] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210729223726_addNoteIdToInvitation')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210729223726_addNoteIdToInvitation', N'5.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210730205523_RemovedUseFromNotes')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[notes]') AND [c].[name] = N'Use');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [notes] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [notes] DROP COLUMN [Use];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210730205523_RemovedUseFromNotes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210730205523_RemovedUseFromNotes', N'5.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    ALTER TABLE [scheduleItems] DROP CONSTRAINT [FK_scheduleItems_guestLists_GuestListId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    ALTER TABLE [scheduleItems] DROP CONSTRAINT [FK_scheduleItems_notes_NotesId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    DROP INDEX [IX_scheduleItems_GuestListId] ON [scheduleItems];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    DROP INDEX [IX_scheduleItems_NotesId] ON [scheduleItems];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[scheduleItems]') AND [c].[name] = N'GuestListId');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [scheduleItems] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [scheduleItems] DROP COLUMN [GuestListId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[scheduleItems]') AND [c].[name] = N'NotesId');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [scheduleItems] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [scheduleItems] DROP COLUMN [NotesId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    ALTER TABLE [invitations] ADD [GuestListId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    ALTER TABLE [invitations] ADD [GuestsOnly] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    CREATE INDEX [IX_invitations_GuestListId] ON [invitations] ([GuestListId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    ALTER TABLE [invitations] ADD CONSTRAINT [FK_invitations_guestLists_GuestListId] FOREIGN KEY ([GuestListId]) REFERENCES [guestLists] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210731011359_MovedGuestListIdToInvitation')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210731011359_MovedGuestListIdToInvitation', N'5.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210811184737_RemovedNotesFromGuest')
BEGIN
    ALTER TABLE [guests] DROP CONSTRAINT [FK_guests_notes_NotesId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210811184737_RemovedNotesFromGuest')
BEGIN
    DROP INDEX [IX_guests_NotesId] ON [guests];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210811184737_RemovedNotesFromGuest')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[guests]') AND [c].[name] = N'NotesId');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [guests] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [guests] DROP COLUMN [NotesId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210811184737_RemovedNotesFromGuest')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210811184737_RemovedNotesFromGuest', N'5.0.9');
END;
GO

COMMIT;
GO

