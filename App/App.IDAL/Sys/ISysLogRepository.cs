using System;
using App.Models;
using System.Linq;
namespace App.IDAL
{
    public partial interface ISysLogRepository
    {
        int Delete(string id);
        IQueryable<SysLog> GetList(DBContainer db);
        SysLog GetById(string id);
        bool IsExist(string id);
    }
}