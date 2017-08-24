using System.Collections.Generic;
using App.Common;
using App.Models.Sys;
using App.Models;
using System.Linq;

namespace App.IBLL
{
    public partial interface ISysUserBLL
    {
        bool UpdateSysRoleSysUser(string userId, string[] roleIds);
        IQueryable<P_Sys_GetRoleByUserId_Result> GetRoleByUserId(ref GridPager pager, string userId);
    }
}
