USE [AppDB]
GO

/****** Object:  Table [dbo].[SysModule]    Script Date: 2017/8/10 10:11:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysModule](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[EnglishName] [varchar](200) NULL,
	[ParentId] [varchar](50) NULL,
	[Url] [varchar](200) NULL,
	[Iconic] [varchar](200) NULL,
	[Sort] [int] NULL,
	[Remark] [varchar](4000) NULL,
	[Enable] [bit] NULL,
	[CreatePerson] [varchar](200) NULL,
	[CreateTime] [datetime] NULL,
	[IsLast] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_SysModule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SysModule]  WITH NOCHECK ADD  CONSTRAINT [FK_SysModule_SysModule] FOREIGN KEY([ParentId])
REFERENCES [dbo].[SysModule] ([Id])
GO

ALTER TABLE [dbo].[SysModule] NOCHECK CONSTRAINT [FK_SysModule_SysModule]
GO

