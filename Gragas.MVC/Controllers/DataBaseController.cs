using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gragas.Model.Manager;

namespace Gragas.MVC.Controllers
{
    public class DataBaseController : BaseController
    {
        public ActionResult CreateSchemaUpdate()
        {
            var script = new DataBase().GenerateUpdateSchema();
            ViewBag.ScriptUpdate = script.Replace("\n", "<br />");
            return View();
        }
    }
}
