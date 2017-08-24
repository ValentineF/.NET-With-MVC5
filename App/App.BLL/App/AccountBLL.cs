using System.Linq;
using System.Text;
using App.IBLL;
using App.BLL.Core;
using Microsoft.Practices.Unity;
using App.IDAL;
using App.Models;
using App.Common;
namespace App.BLL
{
    public class AccountBLL : IAccountBLL
    {
        [Dependency]
        public IAccountRepository AccountRepository { get; set; }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public SysUser Login(string username, string pwd)
        {
            return AccountRepository.Login(username, pwd);
        }
    }
}