USE [AppDB]
GO

/****** Object:  Table [dbo].[SysRole]    Script Date: 2017/8/10 10:12:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysRole](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Description] [varchar](4000) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[CreatePerson] [varchar](200) NOT NULL,
 CONSTRAINT [PK_SysRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

