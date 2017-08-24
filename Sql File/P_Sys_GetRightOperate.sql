USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_GetRightOperate]    Script Date: 2017/8/10 10:14:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:        <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[P_Sys_GetRightOperate]
@userId varchar(50),@url varchar(200)
AS
--取模块的当前用户操作权限
select distinct KeyCode,IsValid from SysRightOperate where RightId in(
select a.id from SysRight a, SysModule b where RoleId in(
    select SysRoleId from SysRoleSysUser where SysUserId =@userId)
    and a.ModuleId = b.Id
    and b.Url =@url)
    and IsValid=1



GO

