CREATE TABLE [dbo].[User] (
    [Id]                     BIGINT         IDENTITY (1, 1) NOT NULL,
    [AuthenticationSourceId] INT            NULL,
    [Name]                   NVARCHAR (64)  NOT NULL,
    [DisplayName]            NVARCHAR (16)  NULL,
    [No]                     NVARCHAR (64)  NULL,
    [Password]               NVARCHAR (256) NULL,
    [Phone]                  NVARCHAR (16)  NULL,
    [Email]                  NVARCHAR (128) NULL,
    [IsActive]               BIT            CONSTRAINT [DK_User_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_User_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_AuthenticationSourceId] FOREIGN KEY ([AuthenticationSourceId]) REFERENCES [dbo].[AuthenticationSource] ([Id])
);



