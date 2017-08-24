using App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.IBLL
{
    public interface IBaseBLL<T> : IDisposable
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="queryStr"></param>
        /// <returns></returns>
        List<T> GetList(ref GridPager pager, string queryStr);
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Create(ref ValidationErrors errors, T model);
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(ref ValidationErrors errors, string id);
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="deleteCollection"></param>
        /// <returns></returns>
        bool Delete(ref ValidationErrors errors, string[] deleteCollection);
        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Edit(ref ValidationErrors errors, T model);
        /// <summary>
        /// 根据ID获得一个Model实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(string id);
        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsExist(string id);
    }
}
