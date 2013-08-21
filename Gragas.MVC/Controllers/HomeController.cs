using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gragas.Model.Manager;

namespace Gragas.MVC.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {            
            return View();
        }
    }
}
