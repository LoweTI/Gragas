using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gragas.Model.Hebara;
using Gragas.Model.Eagle;

namespace Gragas.MVC.Controllers
{
    public class BilletController : Controller
    {
        public ActionResult CheckLastDay()
        {
            var dateInitial = DateTime.Now.AddDays(-1).Date;
            var endDate = dateInitial.AddDays(1);
            var informations = new Dictionary<string, int>();

            var billetsReadInHebara = BilletLegacy.Queryable.Where(i => i.ValidationDate >= dateInitial && i.ValidationDate < endDate).Count();
            informations.Add("Hebara:", billetsReadInHebara);

            var billetsSyncEagle = BilletEagle.Queryable.Where(i => i.ValidationDate >= dateInitial && i.ValidationDate < endDate && i.LoterjStartDate == null).Count();
            informations.Add("Eagle:", billetsSyncEagle);

            ViewBag.DateCheck = dateInitial.ToString("dd/MM/yyyy");
            return View(informations);
        }

    }
}
