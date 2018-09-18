CREATE TABLE [dbo].[AuthenticationSource] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_AuthenticationSource_Id] PRIMARY KEY NONCLUSTERED ([Id] ASC)
);



