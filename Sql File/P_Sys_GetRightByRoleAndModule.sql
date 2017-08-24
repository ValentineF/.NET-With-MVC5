USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_GetRightByRoleAndModule]    Script Date: 2017/8/10 10:14:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[P_Sys_GetRightByRoleAndModule]
@roleId varchar(50),@moduleId varchar(50)
as
--按选择的角色及模块加载模块的权限项
begin
select a.Id,a.Name,a.KeyCode,a.ModuleId,ISNULL(b.IsValid,0) as isvalid,a.Sort,@roleId+@moduleId as RightId
    from SysModuleOperate a
    left outer join(
        select c.Id,a.IsValid from SysRightOperate a,SysRight b, SysModuleOperate c
        where RightId in
        (select Id From SysRight where RoleId =@roleId and ModuleId =@moduleId)
         and a.RightId=b.Id
         and b.ModuleId=c.ModuleId
         and a.KeyCode =c.KeyCode) b
     on a.Id = b.Id
     where a.ModuleId =@moduleId
end
GO

