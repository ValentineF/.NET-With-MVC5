using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.BLL;
using App.DAL;
using App.IBLL;
using App.IDAL;
using Microsoft.Practices.Unity;

namespace App.Core
{
    public class DependencyRegisterType
    {
        //系统注入
        public static void Container_Sys(ref UnityContainer container)
        {
            container.RegisterType<ISysSampleBLL,SysSampleBLL>();//样例
            container.RegisterType<ISysSampleRepository, SysSampleRepository>();

            container.RegisterType<IHomeBLL, HomeBLL>();//HomeBLL
            container.RegisterType<IHomeRepository, HomeRepository>();

            container.RegisterType<ISysExceptionBLL, SysExceptionBLL>();//SysExceptionBLL
            container.RegisterType<ISysExceptionRepository, SysExceptionRepository>();

            container.RegisterType<ISysLogBLL, SysLogBLL>();//SysLogBLL
            container.RegisterType<ISysLogRepository, SysLogRepository>();

            container.RegisterType<IAccountBLL, AccountBLL>();//AccountBLL
            container.RegisterType<IAccountRepository, AccountRepository>();

            container.RegisterType<ISysUserBLL, SysUserBLL>();//SysUserBLL
            container.RegisterType<ISysUserRepository, SysUserRepository>();

            container.RegisterType<ISysModuleBLL, SysModuleBLL>();//SysModuleBLL
            container.RegisterType<ISysModuleRepository, SysModuleRepository>();

            container.RegisterType<ISysModuleOperateBLL, SysModuleOperateBLL>();//SysModuleOperateBLL
            container.RegisterType<ISysModuleOperateRepository, SysModuleOperateRepository>();

            container.RegisterType<ISysRoleBLL, SysRoleBLL>();//SysModuleOperateBLL
            container.RegisterType<ISysRoleRepository, SysRoleRepository>();

            container.RegisterType<ISysRightBLL, SysRightBLL>();//SysRightBLL
            container.RegisterType<ISysRightRepository, SysRightRepository>();
        }
    }
}