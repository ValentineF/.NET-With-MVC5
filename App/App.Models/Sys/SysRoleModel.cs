using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace App.Models.Sys
{
    public partial class SysRoleModel
    {
        public List<string> UserName { get; set; }//拥有的用户

        public string Flag { get; set; }//用户分配角色
    }
}