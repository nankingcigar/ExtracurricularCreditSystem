CREATE TABLE [dbo].[RoleUser] (
    [Id]     BIGINT IDENTITY (1, 1) NOT NULL,
    [RoleId] INT    NOT NULL,
    [UserId] BIGINT NOT NULL,
    CONSTRAINT [PK_RoleUser_Id] PRIMARY KEY NONCLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RoleUser_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([Id]),
    CONSTRAINT [FK_RoleUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

