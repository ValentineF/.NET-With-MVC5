//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using App.Models;
using App.Models.Sys;
using App.Common;
using Microsoft.Practices.Unity;
using System.Transactions;
using App.IBLL;
using App.IDAL;
using App.BLL;
using App.BLL.Core;
namespace App.BLL
{
	public partial class SysRoleBLL: Virtual_SysRoleBLL,ISysRoleBLL
	{
        
	}
	public class Virtual_SysRoleBLL
	{
        [Dependency]
        public ISysRoleRepository m_Rep { get; set; }

		public virtual List<SysRoleModel> GetList(ref GridPager pager, string queryStr)
        {
            IQueryable<SysRole> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
								a=>(a.Id!=null && a.Id.Contains(queryStr))
								|| (a.Name!=null && a.Name.Contains(queryStr))
								|| (a.Description!=null && a.Description.Contains(queryStr))
								
								|| (a.CreatePerson!=null && a.CreatePerson.Contains(queryStr))
								);
            }
            else
            {
                queryData = m_Rep.GetList();
            }
            pager.totalRows = queryData.Count();
            //排序
            queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
            return CreateModelList(ref queryData);
        }

        public virtual List<SysRoleModel> CreateModelList(ref IQueryable<SysRole> queryData)
        {
            List<SysRoleModel> modelList = (from r in queryData
                                              select new SysRoleModel
                                              {
													Id = r.Id,
													Name = r.Name,
													Description = r.Description,
													CreateTime = r.CreateTime,
													CreatePerson = r.CreatePerson,
          
                                              }).ToList();
            return modelList;
        }

        public virtual bool Create(ref ValidationErrors errors, SysRoleModel model)
        {
            try
            {
                SysRole entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Suggestion.PrimaryRepeat);
                    return false;
                }
                entity = new SysRole();
               				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.Description = model.Description;
				entity.CreateTime = model.CreateTime;
				entity.CreatePerson = model.CreatePerson;
  
                if (m_Rep.Create(entity))
                {
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



         public virtual bool Delete(ref ValidationErrors errors, string id)
        {
            try
            {
                if (m_Rep.Delete(id) == 1)
                {
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

        public virtual bool Delete(ref ValidationErrors errors, string[] deleteCollection)
        {
            try
            {
                if (deleteCollection != null)
                {
                    using (TransactionScope transactionScope = new TransactionScope())
                    {
                        if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
                        {
                            transactionScope.Complete();
                            return true;
                        }
                        else
                        {
                            Transaction.Current.Rollback();
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHandler.WriteException(ex);
                return false;
            }
        }

		
       

        public virtual bool Edit(ref ValidationErrors errors, SysRoleModel model)
        {
            try
            {
                SysRole entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add(Suggestion.Disable);
                    return false;
                }
                              				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.Description = model.Description;
				entity.CreateTime = model.CreateTime;
				entity.CreatePerson = model.CreatePerson;
 


                if (m_Rep.Edit(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Suggestion.EditFail);
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

      

        public virtual SysRoleModel GetById(string id)
        {
            if (IsExist(id))
            {
                SysRole entity = m_Rep.GetById(id);
                SysRoleModel model = new SysRoleModel();
                              				model.Id = entity.Id;
				model.Name = entity.Name;
				model.Description = entity.Description;
				model.CreateTime = entity.CreateTime;
				model.CreatePerson = entity.CreatePerson;
 
                return model;
            }
            else
            {
                return null;
            }
        }

        public virtual bool IsExist(string id)
        {
            return m_Rep.IsExist(id);
        }
		  public void Dispose()
        { 
            
        }

	}
}
