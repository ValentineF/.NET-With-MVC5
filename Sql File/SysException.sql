USE [AppDB]
GO

/****** Object:  Table [dbo].[SysException]    Script Date: 2017/8/10 10:11:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysException](
	[Id] [varchar](50) NOT NULL,
	[HelpLink] [varchar](500) NULL,
	[Message] [varchar](500) NULL,
	[Source] [varchar](500) NULL,
	[StackTrace] [text] NULL,
	[TargetSite] [varchar](500) NULL,
	[Data] [varchar](500) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_SysException] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

