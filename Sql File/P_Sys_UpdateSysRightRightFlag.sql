USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_UpdateSysRightRightFlag]    Script Date: 2017/8/10 10:15:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[P_Sys_UpdateSysRightRightFlag]
@moduleId varchar(200),@roleId varchar(200)
as
begin
--计算上级模块的rightflag标识
declare @count int
--第一层：由操作权限项计算模块权限
select @count=COUNT(*) from SysRightOperate where RightId=@roleId+@moduleId and IsValid=1

if(@count>0)
begin
    update SysRight set Rightflag=1 where ModuleId=@moduleId and RoleId=@roleId
end
else
begin
    update SysRight set Rightflag=0 where ModuleId=@moduleId and RoleId=@roleId
end
--计算下一层
declare @parentId varchar(50)
set @parentId=@moduleId

while(@parentId<>'0')
begin
    select @parentid=ParentId from SysModule where Id=@parentId
    if (@parentId is null)
    begin
        return
    end
    
    select @count=COUNT(*) from SysRight where ModuleId in
        (select Id from SysModule where ParentId=@parentId)
        and RoleId =@roleId
        and Rightflag=1
    
    if(@count>0)
    begin
        update SysRight set Rightflag=1 where ModuleId=@parentId and RoleId=@roleId
    end
    else
    begin
        update SysRight set Rightflag=0 where ModuleId=@parentId and RoleId=@roleId
    end
end
end
GO

