using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using App.Models;
using App.Common;
using App.Models.Sys;
using App.IBLL;
using App.IDAL;
using App.BLL.Core;

namespace App.BLL
{
    public partial class SysSampleBLL : ISysSampleBLL
    {
        DBContainer db = new DBContainer();
        [Dependency]
        public ISysSampleRepository Rep { get; set; }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pager">JQgrid分页</param>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>列表</returns>
        public override List<SysSampleModel> GetList(ref GridPager pager, string queryStr)
        {

            IQueryable<SysSample> queryData = null;
            queryData = Rep.GetList(db);
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = queryData.Where(x => x.Id == queryStr);
            }
            //排序
            queryData = LinqHelper.DataSorting(queryData, pager.sort, pager.order);
            return CreateModelList(ref pager, ref queryData);
        }
        private List<SysSampleModel> CreateModelList(ref GridPager pager, ref IQueryable<SysSample> queryData)
        {

            pager.totalRows = queryData.Count();
            if (pager.totalRows > 0)
            {
                if (pager.page <= 1)
                {
                    queryData = queryData.Take(pager.rows);
                }
                else
                {
                    queryData = queryData.Skip((pager.page - 1) * pager.rows).Take(pager.rows);
                }
            }
            List<SysSampleModel> modelList = (from r in queryData
                                              select new SysSampleModel
                                              {
                                                  Id = r.Id,
                                                  Name = r.Name,
                                                  Age = r.Age,
                                                  Bir = r.Bir,
                                                  Photo = r.Photo,
                                                  Note = r.Note,
                                                  CreateTime = r.CreateTime,

                                              }).ToList();

            return modelList;
        }



        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否存在</returns>
        public override bool IsExist(string id)
        {
            if (db.SysSample.SingleOrDefault(a => a.Id == id) != null)
            {
                return true;
            }
            return false;
        }
    }
}