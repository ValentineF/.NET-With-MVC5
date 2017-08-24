using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using App.Common;
using App.Models;
using App.IBLL;
using App.Models.Sys;
using Microsoft.Practices.Unity;
using App.Web.Core;

namespace App.Admin.Controllers
{
    public class SysExceptionController : Controller
    {
        //
        // GET: /SysException/
        [Dependency]
        public ISysExceptionBLL ExceptionBLL { get; set; }
        ValidationErrors errors = new ValidationErrors();

        public ActionResult Index()
        {

            return View();

        }

        public JsonResult GetList(GridPager pager, string queryStr)
        {
            List<SysExceptionModel> list = ExceptionBLL.GetList(ref pager, queryStr);
            var json = new
            {
                total = pager.totalRows,
                rows = (from r in list
                        select new SysException()
                        {
                            Id = r.Id,
                            HelpLink = r.HelpLink,
                            Message = r.Message,
                            Source = r.Source,
                            StackTrace = r.StackTrace,
                            TargetSite = r.TargetSite,
                            Data = r.Data,
                            CreateTime = r.CreateTime
                        }).ToArray()

            };
            return Json(json);
        }


        #region 详细

        public ActionResult Details(string id)
        {

            SysExceptionModel info = ExceptionBLL.GetById(id);
            return View(info);
        }

        #endregion

        #region 删除
        [HttpPost]
        public JsonResult Delete(string id)
        {
            SysExceptionModel model = ExceptionBLL.GetById(id);
            if (!string.IsNullOrWhiteSpace(id))
            {
                if (ExceptionBLL.Delete(ref errors, id))
                {
                    LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Data, "成功", "删除", "Exception");
                    return Json(JsonHandler.CreateMessage(1, "删除成功"), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Data + "," + ErrorCol, "失败", "删除", "Exception");
                    return Json(JsonHandler.CreateMessage(0, "删除失败" + ErrorCol), JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(JsonHandler.CreateMessage(0, "删除失败", "无效的实体"), JsonRequestBehavior.AllowGet);
            }


        }
        #endregion

        public ActionResult Error()
        {

            BaseException ex = new BaseException();
            return View(ex);
        }

    }



}