using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Models;
using App.IDAL;
using System.Data;
using System.Data.Entity;

namespace App.DAL
{
    public partial class SysModuleRepository : IDisposable, ISysModuleRepository
    {
        public IQueryable<SysModule> GetList(DBContainer db)
        {
            IQueryable<SysModule> list = db.SysModule.AsQueryable();
            return list;
        }

        public IQueryable<SysModule> GetModuleBySystem(DBContainer db, string parentId)
        {
            return db.SysModule.Where(a => a.ParentId == parentId).AsQueryable();
        }

        public void Delete(DBContainer db, string id)
        {
            SysModule entity = db.SysModule.SingleOrDefault(a => a.Id == id);
            if (entity != null)
            {

                //删除SysRight表数据
                var sr = db.SysRight.AsQueryable().Where(a => a.ModuleId == id);
                foreach (var o in sr)
                {
                    //删除SysRightOperate表数据
                    var sro = db.SysRightOperate.AsQueryable().Where(a => a.RightId == o.Id);
                    foreach (var o2 in sro)
                    {
                        db.Set<SysRightOperate>().Remove(o2);
                    }
                    db.Set<SysRight>().Remove(o);
                }
                //删除SysModuleOperate数据
                var smo = db.SysModuleOperate.AsQueryable().Where(a => a.ModuleId == id);
                foreach (var o3 in smo)
                {
                    db.Set<SysModuleOperate>().Remove(o3);
                }
                db.Set<SysModule>().Remove(entity);
            }
        }

        public SysModule GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysModule.SingleOrDefault(a => a.Id == id);
            }
        }

        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysModule entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }
    }
}