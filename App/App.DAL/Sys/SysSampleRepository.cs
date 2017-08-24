using System;
using System.Linq;
using App.IDAL;
using App.Models;
using System.Data;
using System.Data.Entity;

namespace App.DAL
{
    public partial class SysSampleRepository : ISysSampleRepository, IDisposable
    {
        /// <summary>
        /// 获取列表
        ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        public IQueryable<SysSample> GetList(DBContainer db)
        {
            IQueryable<SysSample> list = db.SysSample.AsQueryable();
            return list;
        }
        /// <summary>
        /// 删除一个实体
        ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">主键ID</param>
        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = db.SysSample.SingleOrDefault(a => a.Id == id);
                db.Set<SysSample>().Remove(entity);
                return Convert.ToInt32(db.SaveChanges() > 0);
            }
        }

        /// <summary>
        /// 获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public SysSample GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysSample.SingleOrDefault(a => a.Id == id);
            }
        }
        /// <summary>
        /// 判断一个实体是否存在
        ///</summary>
        /// <param name="id">id</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }
    }
}