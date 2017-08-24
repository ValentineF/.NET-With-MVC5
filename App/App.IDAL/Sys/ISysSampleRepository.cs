using App.Models;
using System.Linq;
namespace App.IDAL
{
    public partial interface ISysSampleRepository
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        IQueryable<SysSample> GetList(DBContainer db);

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="entity">主键ID</param>
        int Delete(string id);


        /// <summary>
        /// 获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        SysSample GetById(string id);
        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        bool IsExist(string id);
    }
}