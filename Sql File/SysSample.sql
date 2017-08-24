USE [AppDB]
GO

/****** Object:  Table [dbo].[SysSample]    Script Date: 2017/8/10 10:12:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysSample](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL,
	[Bir] [datetime] NULL,
	[Photo] [varchar](50) NULL,
	[Note] [text] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_SysSample] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

