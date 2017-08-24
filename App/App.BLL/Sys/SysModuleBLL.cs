using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.IBLL;
using Microsoft.Practices.Unity;
using App.IDAL;
using App.Models;
using App.BLL.Core;
using App.Common;
using System.Transactions;
using App.Models.Sys;
namespace App.BLL
{
    public partial class SysModuleBLL : ISysModuleBLL
    {
        DBContainer db = new DBContainer();
        public List<SysModuleModel> GetList(string parentId)
        {
            IQueryable<SysModule> queryData = null;
            queryData = m_Rep.GetList(db).Where(a => a.ParentId == parentId).OrderBy(a => a.Sort);
            return CreateModelList(ref queryData);
        }

        public List<SysModule> GetModuleBySystem(string parentId)
        {

            return m_Rep.GetModuleBySystem(db, parentId).ToList();
        }

        public override bool Create(ref ValidationErrors errors, SysModuleModel model)
        {
            try
            {
                SysModule entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Suggestion.PrimaryRepeat);
                    return false;
                }
                entity = new SysModule();
                entity.Id = model.Id;
                entity.Name = model.Name;
                entity.EnglishName = model.EnglishName;
                entity.ParentId = model.ParentId;
                entity.Url = model.Url;
                entity.Iconic = model.Iconic;
                entity.Sort = model.Sort;
                entity.Remark = model.Remark;
                entity.Enable = model.Enable;
                entity.CreatePerson = model.CreatePerson;
                entity.CreateTime = model.CreateTime;
                entity.IsLast = model.IsLast;
                if (m_Rep.Create(entity))
                {
                    //分配给角色
                    db.P_Sys_InsertSysRight();
                    return true;
                }
                else
                {
                    errors.Add(Suggestion.InsertFail);
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHandler.WriteException(ex);
                return false;
            }


        }

        public override bool Delete(ref ValidationErrors errors, string id)
        {
            try
            {
                //检查是否有下级
                if (db.SysModule.AsQueryable().Where(a => a.SysModule2.Id == id).Count() > 0)
                {
                    errors.Add("有下属关联，请先删除下属！");
                    return false;
                }
                m_Rep.Delete(db, id);
                if (db.SaveChanges() > 0)
                {
                    //清理无用的项
                    db.P_Sys_ClearUnusedRightOperate();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHandler.WriteException(ex);
                return false;
            }
        }

    }
}