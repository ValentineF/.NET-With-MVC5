USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_DeleteSysRoleSysUserByUserId]    Script Date: 2017/8/10 10:14:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[P_Sys_DeleteSysRoleSysUserByUserId]
@userId varchar(50)
AS
--更新角色用户中间关系表,前删除关联
BEGIN
    delete SysRoleSysUser where SysUserId=@userId
END
GO

