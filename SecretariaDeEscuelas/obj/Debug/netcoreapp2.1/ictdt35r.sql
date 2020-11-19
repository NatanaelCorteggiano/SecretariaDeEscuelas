IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);

GO

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

GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(128) NOT NULL,
    [ProviderKey] nvarchar(128) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(128) NOT NULL,
    [Name] nvarchar(128) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'00000000000000_CreateIdentitySchema', N'2.1.14-servicing-32113');

GO

CREATE TABLE [Institutos] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    CONSTRAINT [PK_Institutos] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201116203604_Institutos', N'2.1.14-servicing-32113');

GO

CREATE TABLE [Carreras] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [InstitutoId] int NOT NULL,
    CONSTRAINT [PK_Carreras] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Carreras_Institutos_InstitutoId] FOREIGN KEY ([InstitutoId]) REFERENCES [Institutos] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Carreras_InstitutoId] ON [Carreras] ([InstitutoId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201116204843_Carreras', N'2.1.14-servicing-32113');

GO

DROP INDEX [IX_Carreras_InstitutoId] ON [Carreras];

GO

CREATE TABLE [Materias] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    CONSTRAINT [PK_Materias] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [CarreraMateria] (
    [CarreraId] int NOT NULL,
    [MateriaId] int NOT NULL,
    CONSTRAINT [PK_CarreraMateria] PRIMARY KEY ([CarreraId], [MateriaId]),
    CONSTRAINT [FK_CarreraMateria_Carreras_CarreraId] FOREIGN KEY ([CarreraId]) REFERENCES [Carreras] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CarreraMateria_Materias_MateriaId] FOREIGN KEY ([MateriaId]) REFERENCES [Materias] ([Id]) ON DELETE CASCADE
);

GO

CREATE UNIQUE INDEX [IX_Carreras_InstitutoId] ON [Carreras] ([InstitutoId]);

GO

CREATE INDEX [IX_CarreraMateria_MateriaId] ON [CarreraMateria] ([MateriaId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201118180721_CarrerasMaterias', N'2.1.14-servicing-32113');

GO

ALTER TABLE [CarreraMateria] DROP CONSTRAINT [FK_CarreraMateria_Carreras_CarreraId];

GO

ALTER TABLE [CarreraMateria] DROP CONSTRAINT [FK_CarreraMateria_Materias_MateriaId];

GO

ALTER TABLE [CarreraMateria] DROP CONSTRAINT [PK_CarreraMateria];

GO

EXEC sp_rename N'[CarreraMateria]', N'CarrerasMaterias';

GO

EXEC sp_rename N'[CarrerasMaterias].[IX_CarreraMateria_MateriaId]', N'IX_CarrerasMaterias_MateriaId', N'INDEX';

GO

ALTER TABLE [Materias] ADD [MaestroId] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [CarrerasMaterias] ADD CONSTRAINT [PK_CarrerasMaterias] PRIMARY KEY ([CarreraId], [MateriaId]);

GO

CREATE TABLE [Maestros] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Apellido] nvarchar(max) NULL,
    CONSTRAINT [PK_Maestros] PRIMARY KEY ([Id])
);

GO

CREATE INDEX [IX_Materias_MaestroId] ON [Materias] ([MaestroId]);

GO

ALTER TABLE [CarrerasMaterias] ADD CONSTRAINT [FK_CarrerasMaterias_Carreras_CarreraId] FOREIGN KEY ([CarreraId]) REFERENCES [Carreras] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [CarrerasMaterias] ADD CONSTRAINT [FK_CarrerasMaterias_Materias_MateriaId] FOREIGN KEY ([MateriaId]) REFERENCES [Materias] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Materias] ADD CONSTRAINT [FK_Materias_Maestros_MaestroId] FOREIGN KEY ([MaestroId]) REFERENCES [Maestros] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201118194718_Maestros', N'2.1.14-servicing-32113');

GO

CREATE TABLE [Estudiantes] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Apellido] nvarchar(max) NULL,
    CONSTRAINT [PK_Estudiantes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [MateriasEstudiantes] (
    [MateriaId] int NOT NULL,
    [EstudianteId] int NOT NULL,
    CONSTRAINT [PK_MateriasEstudiantes] PRIMARY KEY ([MateriaId], [EstudianteId]),
    CONSTRAINT [FK_MateriasEstudiantes_Estudiantes_EstudianteId] FOREIGN KEY ([EstudianteId]) REFERENCES [Estudiantes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MateriasEstudiantes_Materias_MateriaId] FOREIGN KEY ([MateriaId]) REFERENCES [Materias] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_MateriasEstudiantes_EstudianteId] ON [MateriasEstudiantes] ([EstudianteId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201119002201_MateriasEstudiantes', N'2.1.14-servicing-32113');

GO

ALTER TABLE [MateriasEstudiantes] DROP CONSTRAINT [PK_MateriasEstudiantes];

GO

ALTER TABLE [MateriasEstudiantes] ADD [CalificacionId] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [MateriasEstudiantes] ADD CONSTRAINT [PK_MateriasEstudiantes] PRIMARY KEY ([MateriaId], [EstudianteId], [CalificacionId]);

GO

CREATE TABLE [Calificaciones] (
    [Id] int NOT NULL IDENTITY,
    [Nota] float NOT NULL,
    [EstudianteId] int NOT NULL,
    CONSTRAINT [PK_Calificaciones] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Calificaciones_Estudiantes_EstudianteId] FOREIGN KEY ([EstudianteId]) REFERENCES [Estudiantes] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_MateriasEstudiantes_CalificacionId] ON [MateriasEstudiantes] ([CalificacionId]);

GO

CREATE INDEX [IX_Calificaciones_EstudianteId] ON [Calificaciones] ([EstudianteId]);

GO

ALTER TABLE [MateriasEstudiantes] ADD CONSTRAINT [FK_MateriasEstudiantes_Calificaciones_CalificacionId] FOREIGN KEY ([CalificacionId]) REFERENCES [Calificaciones] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201119175529_Calificaciones', N'2.1.14-servicing-32113');

GO

