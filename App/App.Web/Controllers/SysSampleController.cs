using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using App.Common;
using App.IBLL;
using App.Models.Sys;
using Microsoft.Practices.Unity;
using App.Web.Core;

namespace App.Web.Controllers
{
    public class SysSampleController : BaseController
    {

        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public ISysSampleBLL SampleBLL { get; set; }

        [SupportFilter(ActionName = "Index")]
        public ActionResult Index()
        {

            return View();
        }

        [SupportFilter(ActionName = "Index")]
        public JsonResult GetList(GridPager pager, string queryStr)
        {
            List<SysSampleModel> list = SampleBLL.GetList(ref pager,queryStr);
            var json = new
            {
                total = pager.totalRows,
                rows = (from r in list
                        select new SysSampleModel()
                        {

                            Id = r.Id,
                            Name = r.Name,
                            Age = r.Age,
                            Bir = r.Bir,
                            Photo = r.Photo,
                            Note = r.Note,
                            CreateTime = r.CreateTime,

                        }).ToArray()

            };

            return Json(json, JsonRequestBehavior.AllowGet);
        }
        ValidationErrors errors = new ValidationErrors();

        #region 创建
        [SupportFilter(ActionName = "Create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [SupportFilter(ActionName = "Create")]
        public JsonResult Create(SysSampleModel model)
        {
            if (SampleBLL.Create(ref errors, model))
            {
                LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Name, "成功", "创建", "样例程序");
                return Json(JsonHandler.CreateMessage(1, "插入成功"), JsonRequestBehavior.AllowGet);
            }
            else
            {
                string ErrorCol = errors.Error;
                LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Name + "," + ErrorCol, "失败", "创建", "样例程序");
                return Json(JsonHandler.CreateMessage(0, "插入失败" + ErrorCol), JsonRequestBehavior.AllowGet);
            }

        }
        #endregion

        #region 修改
        [SupportFilter(ActionName = "Edit")]
        public ActionResult Edit(string id)
        {

            SysSampleModel entity = SampleBLL.GetById(id);
            return View(entity);
        }

        [HttpPost]
        [SupportFilter(ActionName = "Edit")]
        public JsonResult Edit(SysSampleModel model)
        {
            if (SampleBLL.Edit(ref errors, model))
            {
                LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Name, "成功", "修改", "样例程序");
                return Json(JsonHandler.CreateMessage(1, "修改成功"), JsonRequestBehavior.AllowGet);
            }
            else
            {
                string ErrorCol = errors.Error;
                LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Name + "," + ErrorCol, "失败", "修改", "样例程序");
                return Json(JsonHandler.CreateMessage(0, "修改失败" + ErrorCol), JsonRequestBehavior.AllowGet);
            }

        }
        #endregion

        #region 详细
        [SupportFilter(ActionName = "Details")]
        public ActionResult Details(string id)
        {
            SysSampleModel entity = SampleBLL.GetById(id);
            return View(entity);
        }

        #endregion

        #region 删除
        [HttpPost]
        [SupportFilter(ActionName = "Delete")]
        public JsonResult Delete(string id)
        {
            SysSampleModel model = SampleBLL.GetById(id);
            if (!string.IsNullOrWhiteSpace(id))
            {
                if (SampleBLL.Delete(ref errors, id))
                {
                    LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Name, "成功", "删除", "样例程序");
                    return Json(JsonHandler.CreateMessage(1, "删除成功"), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog("虚拟用户", "Id:" + model.Id + ",Name:" + model.Name + "," + ErrorCol, "失败", "删除", "样例程序");
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