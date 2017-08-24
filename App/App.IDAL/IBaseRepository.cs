using System;
using System.Linq;
using System.Linq.Expressions;

namespace App.IDAL
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Create(T model);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Edit(T model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Delete(T model);

        /// <summary>
        /// 按主键删除
        /// </summary>
        /// <param name="keyValues"></param>
        int Delete(params object[] keyValues);

        /// <summary>
        /// 按ID获取数据
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        T GetById(params object[] keyValues);

        /// <summary>
        /// 获得所有数据
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetList();

        /// <summary>
        /// 根据表达式获取数据
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        IQueryable<T> GetList(Expression<Func<T, bool>> whereLambda);

        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <param name="whereLambda"></param>
        /// <param name="isAsc"></param>
        /// <param name="orderByLambda"></param>
        /// <returns></returns>
        IQueryable<T> GetList<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, bool>> orderByLambda);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsExist(object id);

        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}
