USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_GetRoleByUserId]    Script Date: 2017/8/10 10:14:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[P_Sys_GetRoleByUserId]
@UserId varchar(50)
as
begin
--读取用户所包含的角色
select a.*,ISNULL(b.SysUserId,0) as flag from SysRole a left join
    SysRoleSysUser b 
    on a.Id = b.SysRoleId
    and b.SysUserId = @UserId
    order by b.SysUserId desc
end 
GO

