using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Models;

namespace App.IDAL
{
    public partial interface ISysModuleRepository
    {
        IQueryable<SysModule> GetList(DBContainer db);
        IQueryable<SysModule> GetModuleBySystem(DBContainer db, string parentId);

        void Delete(DBContainer db, string id);

        SysModule GetById(string id);
        bool IsExist(string id);
    }
}