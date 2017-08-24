using System;
using System.Linq;
using App.Models;
using App.IDAL;
using System.Data;

namespace App.DAL
{
    public partial class SysLogRepository : IDisposable, ISysLogRepository
    {
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="db">数据库</param>
        /// <returns>集合</returns>
        public IQueryable<SysLog> GetList(DBContainer db)
        {
            IQueryable<SysLog> list = db.SysLog.AsQueryable();
            return list;
        }

        /// <summary>
        /// 删除对象集合
        /// </summary>
        /// <param name="db">数据库</param>
        /// <param name="entity">集合</param>
        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysLog entity = db.SysLog.SingleOrDefault(a => a.Id == id);
                db.Set<SysLog>().Remove(entity);
                return Convert.ToInt32(db.SaveChanges() > 0);
            }
        }
        /// <summary>
        /// 根据ID获取一个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SysLog GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysLog.SingleOrDefault(a => a.Id == id);
            }
        }

        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysLog entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }
    }
}