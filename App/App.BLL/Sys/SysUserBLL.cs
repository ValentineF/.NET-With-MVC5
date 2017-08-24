using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using App.Models;
using App.Common;
using System.Transactions;
using App.Models.Sys;
using App.IBLL;
using App.IDAL;
using App.BLL.Core;

namespace App.BLL
{
    public partial class SysUserBLL : ISysUserBLL
    {
        DBContainer db = new DBContainer();

        public override bool IsExist(string id)
        {
            if (db.SysUser.SingleOrDefault(a => a.Id == id) != null)
            {
                return true;
            }
            return false;
        }

        public IQueryable<P_Sys_GetRoleByUserId_Result> GetRoleByUserId(ref GridPager pager, string userId)
        {
            IQueryable<P_Sys_GetRoleByUserId_Result> queryData = m_Rep.GetRoleByUserId(db, userId);
            pager.totalRows = queryData.Count();
            return queryData.Skip((pager.page - 1) * pager.rows).Take(pager.rows);
        }
        public bool UpdateSysRoleSysUser(string userId, string[] roleIds)
        {
            try
            {
                m_Rep.UpdateSysRoleSysUser(userId, roleIds);
                return true;

            }
            catch (Exception ex)
            {
                ExceptionHandler.WriteException(ex);
                return false;
            }

        }
    }
}
