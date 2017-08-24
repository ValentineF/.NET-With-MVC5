using System;
using System.Linq;
using App.Models;
using App.IDAL;

namespace App.DAL
{
    public partial class SysExceptionRepository : IDisposable, ISysExceptionRepository
    {
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="db">数据库</param>
        /// <returns>集合</returns>
        public IQueryable<SysException> GetList(DBContainer db)
        {
            IQueryable<SysException> list = db.SysException.AsQueryable();
            return list;
        }


        /// <summary>
        /// 根据ID获取一个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SysException GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysException.SingleOrDefault(a => a.Id == id);
            }
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
                SysException entity = db.SysException.SingleOrDefault(a => a.Id == id);
                db.Set<SysException>().Remove(entity);
                return Convert.ToInt32(db.SaveChanges() > 0);
            }
        }

        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysException entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }

    }
}