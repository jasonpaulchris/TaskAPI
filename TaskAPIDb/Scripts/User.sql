create table [dbo].[User](
[UserId] BIGINT IDENTITY(1,1) not null,
[Firstname][nvarchar](50) not null,
[Lastname][nvarchar](50) not null,
[Username][Nvarchar](50) not null,
[ts] [rowversion] not null,
constraint [PK_User] primary key([UserId])
);