CREATE TABLE [dbo].[Sys_Log]
(
	[LogId] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [LogName] NVARCHAR(50) NOT NULL, 
    [ModuleId] INT NOT NULL, 
    [ModuleName] NVARCHAR(50) NOT NULL, 
    [ErrorMsg] NVARCHAR(500) NULL, 
    [ErrorStack] TEXT NULL, 
    [ExtraData] TEXT NULL, 
    [CreatedDate] DATETIME NOT NULL
)
