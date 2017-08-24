using System;
using System.Linq;
using App.Models;
using System.Data;
using App.IDAL;

namespace App.DAL
{
    public partial class SysModuleOperateRepository : ISysModuleOperateRepository, IDisposable
    {

        public IQueryable<SysModuleOperate> GetList(DBContainer db)
        {
            IQueryable<SysModuleOperate> list = db.SysModuleOperate.AsQueryable();
            return list;
        }

        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysModuleOperate entity = db.SysModuleOperate.SingleOrDefault(a => a.Id == id);
                if (entity != null)
                {
                    db.Set<SysModuleOperate>().Remove(entity);
                }
                return db.SaveChanges();
            }
        }

        public SysModuleOperate GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysModuleOperate.SingleOrDefault(a => a.Id == id);
            }
        }

        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysModuleOperate entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }

    }
}