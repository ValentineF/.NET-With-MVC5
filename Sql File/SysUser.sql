USE [AppDB]
GO

/****** Object:  Table [dbo].[SysUser]    Script Date: 2017/8/10 10:13:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysUser](
	[Id] [varchar](50) NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[TrueName] [varchar](200) NULL,
	[Card] [varchar](50) NULL,
	[MobileNumber] [varchar](200) NULL,
	[PhoneNumber] [varchar](200) NULL,
	[QQ] [varchar](50) NULL,
	[EmailAddress] [varchar](200) NULL,
	[OtherContact] [varchar](200) NULL,
	[Province] [varchar](200) NULL,
	[City] [varchar](200) NULL,
	[Village] [varchar](200) NULL,
	[Address] [varchar](200) NULL,
	[State] [bit] NULL,
	[CreateTime] [datetime] NULL,
	[CreatePerson] [varchar](200) NULL,
	[Sex] [varchar](10) NULL,
	[Birthday] [datetime] NULL,
	[JoinDate] [datetime] NULL,
	[Marital] [varchar](10) NULL,
	[Political] [varchar](50) NULL,
	[Nationality] [varchar](20) NULL,
	[Native] [varchar](20) NULL,
	[School] [varchar](50) NULL,
	[Professional] [varchar](100) NULL,
	[Degree] [varchar](20) NULL,
	[DepId] [varchar](50) NOT NULL,
	[PosId] [varchar](50) NOT NULL,
	[Expertise] [varchar](3000) NULL,
	[JobState] [varchar](20) NULL,
	[Photo] [varchar](200) NULL,
	[Attach] [varchar](200) NULL,
 CONSTRAINT [PK_SysUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'MobileNumber'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'婚姻' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Marital'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'党派' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Political'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Nationality'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'籍贯' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Native'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'毕业学校' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'School'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'就读专业' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Professional'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学历' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Degree'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'DepId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'PosId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'个人简介' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Expertise'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'在职状况' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'JobState'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'照片' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Photo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'附件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Attach'
GO

