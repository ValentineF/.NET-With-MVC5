using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Models;
using App.Common;
using App.Models.Sys;

namespace App.IBLL
{
    public partial interface ISysRoleBLL
    {

        IQueryable<P_Sys_GetUserByRoleId_Result> GetUserByRoleId(ref GridPager pager, string roleId);
        bool UpdateSysRoleSysUser(string roleId, string[] userIds);
    }
}