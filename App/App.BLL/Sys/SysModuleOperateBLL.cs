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
    public partial class SysModuleOperateBLL : ISysModuleOperateBLL
    {
        DBContainer db = new DBContainer();

        public override List<SysModuleOperateModel> GetList(ref GridPager pager, string mid)
        {

            IQueryable<SysModuleOperate> queryData = m_Rep.GetList(db).Where(a => a.ModuleId == mid);
            pager.totalRows = queryData.Count();
            queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
            return CreateModelList(ref queryData);
        }

        public override bool IsExist(string id)
        {
            if (db.SysModuleOperate.SingleOrDefault(a => a.Id == id) != null)
            {
                return true;
            }
            return false;
        }
    }
}
