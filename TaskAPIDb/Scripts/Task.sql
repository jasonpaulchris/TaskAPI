﻿create table [dbo].[Task]
(
	[TaskId] bigint identity(1, 1) not null,
	[Subject] nvarchar(100) not null,
	[StartDate] DateTime2(7) null,
	[DueDate] DateTime2(7) null,
	[CompletedDate] DateTime2(7) null,
	[StatusId] bigint not null,
	[CreatedDate] datetime2(7) not null,
	[CreatedUserId] bigint not null,
	[ts] rowversion not null,
	primary key clustered([TaskId] ASC),
	foreign key([StatusId]) references [dbo].[Status] (StatusId),
	foreign key([CreatedUserId]) references [dbo].[User] ([UserId]),
	);
f
