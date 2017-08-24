USE [AppDB]
GO

/****** Object:  Table [dbo].[SysRightOperate]    Script Date: 2017/8/10 10:12:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysRightOperate](
	[Id] [varchar](200) NOT NULL,
	[RightId] [varchar](200) NOT NULL,
	[KeyCode] [varchar](200) NOT NULL,
	[IsValid] [bit] NOT NULL,
 CONSTRAINT [PK_SysRightOperate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SysRightOperate]  WITH CHECK ADD  CONSTRAINT [FK_SysRightOperate_SysRight] FOREIGN KEY([RightId])
REFERENCES [dbo].[SysRight] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SysRightOperate] CHECK CONSTRAINT [FK_SysRightOperate_SysRight]
GO

