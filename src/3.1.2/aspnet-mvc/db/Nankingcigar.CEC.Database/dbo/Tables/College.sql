CREATE TABLE [dbo].[College] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (64) NOT NULL,
    [DisplayName] NVARCHAR (16) NULL,
    CONSTRAINT [PK_College_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

