using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxJson.Models;

namespace AjaxJson.Controllers
{
    public class jsonController : Controller
    {
        // GET: json
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ObtenerPersona()
        {
            List<persona> lst;
            using (ajaxJsonEntities db = new ajaxJsonEntities())
            {
                lst = (from d in db.persona select d).ToList();
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }
}