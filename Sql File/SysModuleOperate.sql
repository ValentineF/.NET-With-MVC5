USE [AppDB]
GO

/****** Object:  Table [dbo].[SysModuleOperate]    Script Date: 2017/8/10 10:11:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysModuleOperate](
	[Id] [varchar](200) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[KeyCode] [varchar](200) NOT NULL,
	[ModuleId] [varchar](50) NOT NULL,
	[IsValid] [bit] NOT NULL,
	[Sort] [int] NOT NULL,
 CONSTRAINT [PK_SysModuleOperate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SysModuleOperate]  WITH CHECK ADD  CONSTRAINT [FK_SysModuleOperate_SysModule] FOREIGN KEY([ModuleId])
REFERENCES [dbo].[SysModule] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SysModuleOperate] CHECK CONSTRAINT [FK_SysModuleOperate_SysModule]
GO

