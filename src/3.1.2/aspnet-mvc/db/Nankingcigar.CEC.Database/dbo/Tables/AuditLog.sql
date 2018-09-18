CREATE TABLE [dbo].[AuditLog] (
    [Id]                 BIGINT          IDENTITY (1, 1) NOT NULL,
    [UserId]             BIGINT          NULL,
    [ServiceName]        NVARCHAR (256)  NULL,
    [MethodName]         NVARCHAR (256)  NULL,
    [Parameters]         NVARCHAR (1024) NULL,
    [ExecutionTime]      DATETIME        NOT NULL,
    [ExecutionDuration]  INT             NOT NULL,
    [ClientIpAddress]    NVARCHAR (64)   NULL,
    [ClientName]         NVARCHAR (128)  NULL,
    [BrowserInfo]        NVARCHAR (256)  NULL,
    [Exception]          NVARCHAR (2000) NULL,
    [ImpersonatorUserId] BIGINT          NULL,
    [CustomData]         NVARCHAR (2000) NULL,
    CONSTRAINT [PK_AuditLog_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);



