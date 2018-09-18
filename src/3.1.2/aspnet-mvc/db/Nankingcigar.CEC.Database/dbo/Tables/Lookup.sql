CREATE TABLE [dbo].[Lookup] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [LookupCategoryId] INT            NOT NULL,
    [Name]             NVARCHAR (64)  NOT NULL,
    [DisplayName]      NVARCHAR (16)  NULL,
    [Description]      NVARCHAR (256) NULL,
    CONSTRAINT [PK_Lookup_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Lookup_LookupCategoryId] FOREIGN KEY ([LookupCategoryId]) REFERENCES [dbo].[LookupCategory] ([Id])
);

