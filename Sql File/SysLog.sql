USE [AppDB]
GO

/****** Object:  Table [dbo].[SysLog]    Script Date: 2017/8/10 10:11:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysLog](
	[Id] [varchar](50) NOT NULL,
	[Operator] [varchar](50) NULL,
	[Message] [varchar](500) NULL,
	[Result] [varchar](20) NULL,
	[Type] [varchar](20) NULL,
	[Module] [varchar](20) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_SysLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

