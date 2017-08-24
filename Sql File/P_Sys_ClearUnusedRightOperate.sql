USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_ClearUnusedRightOperate]    Script Date: 2017/8/10 10:13:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[P_Sys_ClearUnusedRightOperate]
as
--清理权限中的无用项目
delete from SysRightOperate where Id not in(
    select a.RoleId+a.ModuleId+b.KeyCode from SysRight a,SysModuleOperate b
        where a.ModuleId = b.ModuleId
)
GO

