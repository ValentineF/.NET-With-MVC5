using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Models;

namespace App.IDAL
{
    public partial interface ISysRoleRepository
    {

        IQueryable<SysRole> GetList(DBContainer db);

        int Delete(string id);

        SysRole GetById(string id);
        bool IsExist(string id);
        IQueryable<SysUser> GetRefSysUser(DBContainer db, string id);
        IQueryable<P_Sys_GetUserByRoleId_Result> GetUserByRoleId(DBContainer db, string roleId);
        void UpdateSysRoleSysUser(string roleId, string[] userIds);
    }

}