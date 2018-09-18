CREATE TABLE [dbo].[LookupCategory] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (64)  NOT NULL,
    [DisplayName] NVARCHAR (16)  NULL,
    [Description] NVARCHAR (256) NULL,
    CONSTRAINT [PK_LookupCategory_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);



