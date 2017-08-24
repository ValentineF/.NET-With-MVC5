USE [AppDB]
GO

/****** Object:  StoredProcedure [dbo].[P_Sys_InsertSysRight]    Script Date: 2017/8/10 10:15:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[P_Sys_InsertSysRight]
as
--将设置好的模块分配到角色组
    insert into SysRight(Id,ModuleId,RoleId,Rightflag)
        select distinct b.Id+a.Id,a.Id,b.Id,0 from SysModule a,SysRole b
        where a.Id+b.Id not in(select ModuleId+RoleId from SysRight)
        
        
        
    
GO

