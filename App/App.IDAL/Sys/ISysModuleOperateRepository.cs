using App.Models;
using System.Linq;
namespace App.IDAL
{
    public partial interface ISysModuleOperateRepository
    {
        IQueryable<SysModuleOperate> GetList(DBContainer db);

        int Delete(string id);
        SysModuleOperate GetById(string id);
        bool IsExist(string id);
    }
}