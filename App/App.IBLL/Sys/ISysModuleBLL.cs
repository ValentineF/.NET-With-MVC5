using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Models;
using App.Common;
using App.Models.Sys;

namespace App.IBLL
{
    public partial interface ISysModuleBLL
    {
        List<SysModuleModel> GetList(string parentId);
        List<SysModule> GetModuleBySystem(string parentId);
    }
}