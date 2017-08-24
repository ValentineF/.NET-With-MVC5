using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Common;
using App.Models;
using Microsoft.Practices.Unity;
using App.IBLL;
using App.Models.Sys;
using App.Web.Core;

namespace App.Web.Controllers
{
    public class SysLogController : Controller
    {
        //
        // GET: /SysLog/
        [Dependency]
        public ISysLogBLL LogBLL { get; set; }
        ValidationErrors errors = new ValidationErrors();


        public ActionResult Index()
        {

            return View();

        }

        public JsonResult GetList(GridPager pager, string queryStr)
        {
            List<SysLogModel> list = LogBLL.GetList(ref pager, queryStr);
            var json = new
            {
                total = pager.totalRows,
                rows = (from r in list
                        select new SysLogModel()
                        {

                            Id = r.Id,
                            Operator = r.Operator,
                            Message = r.Message,
                            Result = r.Result,
                            Type = r.Type,
                            Module = r.Module,
                            CreateTime = r.CreateTime

                        }).ToArray()

            };

            return Json(json);
        }


        #region 详细

        public ActionResult Details(string id)
        {
            SysLogModel info = LogBLL.GetById(id);
            return View(info);
        }

        #endregion

        #region 删除
        [HttpPost]
        public JsonResult Delete(string id)
        {
            SysLogModel model = LogBLL.GetById(id);
            if (!string.IsNullOrWhiteSpace(id))
            {
                if (LogBLL.Delete(ref errors, id))
                {
                    //LogHandler.WriteServiceLog(model.Operator, model.Message, model.Result, model.Type, model.Module);
                    LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Message, "成功", "删除", "Log");
                    return Json(JsonHandler.CreateMessage(1, "删除成功"), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Message + "," + ErrorCol, "失败", "删除", "Log");
                    //LogHandler.WriteServiceLog(model.Operator, model.Message, model.Result, model.Type, model.Module);
                    return Json(JsonHandler.CreateMessage(0, "删除失败" + ErrorCol), JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(JsonHandler.CreateMessage(0, "删除失败", "无效的实体"), JsonRequestBehavior.AllowGet);
            }


        }
        #endregion
    }
}