using System;
using App.Models;
using System.Linq;
namespace App.IDAL
{
    public partial interface ISysExceptionRepository
    {

        int Delete(string id);
        IQueryable<SysException> GetList(DBContainer db);
        SysException GetById(string id);
        bool IsExist(string id);
    }
}