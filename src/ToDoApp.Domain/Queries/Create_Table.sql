﻿CREATE TABLE [dbo].[Todo]
(
	[Id] int not null identity,
	[Text] varchar(255) not null,
	[IsCompleted] bit not null
	CONSTRAINT PK_Todo PRIMARY KEY([Id])
)

