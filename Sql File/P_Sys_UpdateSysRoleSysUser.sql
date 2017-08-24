USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_UpdateSysRoleSysUser]    Script Date: 2017/8/10 10:15:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[P_Sys_UpdateSysRoleSysUser]
@roleId varchar(50),@userId varchar(50)
AS
--更新角色用户中间关系表
BEGIN
    insert into SysRoleSysUser(SysRoleId,SysUserId)
        values(@roleId,@userId)
END
GO

