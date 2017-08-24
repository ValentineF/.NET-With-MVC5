using App.Models;
using System.Linq;
namespace App.IDAL
{
    public partial interface ISysUserRepository
    {
        IQueryable<SysUser> GetList(DBContainer db);
        int Delete(string id);
        void Delete(DBContainer db, string[] deleteCollection);
        SysUser GetById(string id);
        bool IsExist(string id);
        IQueryable<P_Sys_GetRoleByUserId_Result> GetRoleByUserId(DBContainer db, string userId);
        void UpdateSysRoleSysUser(string userId, string[] roleIds);
    }
}