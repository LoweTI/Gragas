using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gragas.Model.Hebara;
using Gragas.Model.Eagle;
using Gragas.Model.Manager;

namespace Gragas.MVC.Controllers
{
    public class DataBaseController : Controller
    {
        public ActionResult CreateSchemaUpdate()
        {
            var script = new DataBase().GenerateUpdateSchema();
            ViewBag.ScriptUpdate = script.Replace("\n", "<br />");
            return View();
        }

        //private ActionResult View()
        //{
        //    return View();
        //    throw new NotImplementedException();
        //}
    }
}