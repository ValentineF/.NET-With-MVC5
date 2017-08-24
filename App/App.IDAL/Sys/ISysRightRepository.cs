using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Models;
using App.Models.Sys;

namespace App.IDAL
{
    public partial interface ISysRightRepository
    {
        List<permModel> GetPermission(string accountid, string controller);
        //更新
        int UpdateRight(SysRightOperateModel model);
        //按选择的角色及模块加载模块的权限项
        List<P_Sys_GetRightByRoleAndModule_Result> GetRightByRoleAndModule(string roleId, string moduleId);
    }
}