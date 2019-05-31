create table [dbo].[Status] (
[StatusId] BIGINT IDENTITY(1,1) not null,
[Name] nvarchar(100) not null,
[ordinal] int not null,
[ts] rowversion not null,
primary key clustered ([StatusId] ASC)
);

