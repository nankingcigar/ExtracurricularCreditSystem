use CEC
go

if object_id('College') > 0
	drop table College

if object_id('Lookup') > 0
	drop table [Lookup]

if object_id('LookupCategory') > 0
	drop table LookupCategory

if object_id('AuditLog') > 0
	drop table AuditLog

if object_id('RoleUser') > 0
	drop table RoleUser

if object_id('Role') > 0
	drop table [Role]

if object_id('User') > 0
	drop table [User]

if object_id('AuthenticationSource') > 0
	drop table AuthenticationSource


-- TODO:  Add drop table(s) script as above
go

create table AuthenticationSource
(
	Id int identity(1, 1) constraint PK_AuthenticationSource_Id primary key nonclustered,
	[Name] nvarchar(64) not null
)

create table [User]
(
	Id bigint identity(1, 1) constraint PK_User_Id primary key,
	AuthenticationSourceId int constraint FK_User_AuthenticationSourceId foreign key references AuthenticationSource(Id),
	[Name] nvarchar(64) not null,
	DisplayName nvarchar(16),
	[No] nvarchar(64),
	[Password] nvarchar(256),
	Phone nvarchar(16),
	Email nvarchar(128),
	IsActive bit constraint DK_User_IsActive default(1) not null
)

create table [Role]
(
	Id int identity(1, 1) constraint PK_Role_Id primary key,
	[Name] nvarchar(64) not null,
	DisplayName nvarchar(16),
	IsStatic bit constraint DK_Role_IsStatic default(0) not null,
	IsDefault bit constraint DK_Role_IsDefault default(0) not null,
	IsMutex bit constraint DK_Role_IsMutex default(0) not null
)

create table [RoleUser]
(
	Id bigint identity(1, 1) constraint PK_RoleUser_Id primary key nonclustered,
	RoleId int constraint FK_RoleUser_RoleId foreign key references [Role](Id) not null,
	UserId bigint constraint FK_RoleUser_UserId foreign key references [User](Id) not null
)

create table [AuditLog]
(
	Id bigint identity(1, 1) constraint PK_AuditLog_Id primary key,
	UserId bigint,
	ServiceName nvarchar(256),
	MethodName nvarchar(256),
	[Parameters] nvarchar(1024),
	ExecutionTime datetime not null,
	ExecutionDuration int not null,
	ClientIpAddress nvarchar(64),
	ClientName nvarchar(128),
	BrowserInfo nvarchar(256),
	Exception nvarchar(2000),
	ImpersonatorUserId bigint,
	CustomData nvarchar(2000)
)

create table LookupCategory
(
	Id int identity(1, 1) constraint PK_LookupCategory_Id primary key,
	[Name] nvarchar(64) not null,
	[DisplayName] nvarchar(16),
	[Description] nvarchar(256) 
)

create table [Lookup]
(
	Id int identity(1, 1) constraint PK_Lookup_Id primary key,
	LookupCategoryId int constraint FK_Lookup_LookupCategoryId foreign key references [LookupCategory](Id) not null,
	[Name] nvarchar(64) not null,
	[DisplayName] nvarchar(16),
	[Description] nvarchar(256)
)

create table College
(
	Id int identity(1, 1) constraint PK_College_Id primary key,
	[Name] nvarchar(64) not null,
	[DisplayName] nvarchar(16)
)
go

-- TODO:  Add create table(s) script as above
go