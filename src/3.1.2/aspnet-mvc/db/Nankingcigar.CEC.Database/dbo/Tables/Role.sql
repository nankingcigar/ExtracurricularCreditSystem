CREATE TABLE [dbo].[Role] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (64) NOT NULL,
    [DisplayName] NVARCHAR (16) NULL,
    [IsStatic]    BIT           CONSTRAINT [DK_Role_IsStatic] DEFAULT ((0)) NOT NULL,
    [IsDefault]   BIT           CONSTRAINT [DK_Role_IsDefault] DEFAULT ((0)) NOT NULL,
    [IsMutex]     BIT           CONSTRAINT [DK_Role_IsMutex] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Role_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

