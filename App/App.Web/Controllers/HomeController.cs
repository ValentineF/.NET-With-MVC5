using App.IBLL;
using App.Models;
using App.Models.Sys;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [Dependency]
        public IHomeBLL HomeBLL { get; set; }
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取导航菜单
        /// </summary>
        /// <param name="id">所属</param>
        /// <returns>树</returns>
        public JsonResult GetTree(string id)
        {
            if (Session["Account"] != null)
            {
                AccountModel account = (AccountModel)Session["Account"];
                List<SysModule> menus = HomeBLL.GetMenuByPersonId(account.Id, id);
                var jsonData = (
                        from m in menus
                        select new
                        {
                            id = m.Id,
                            text = m.Name,
                            value = m.Url,
                            showcheck = false,
                            complete = false,
                            isexpand = false,
                            checkstate = 0,
                            hasChildren = m.IsLast ? false : true,
                            Icon = m.Iconic
                        }
                    ).ToArray();
                return Json(jsonData, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("0", JsonRequestBehavior.AllowGet);
            }
        }

    }
}