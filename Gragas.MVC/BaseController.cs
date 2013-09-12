using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gragas.MVC
{
    public class BaseController : Controller
    {
        const string AR_SCOPE_NAME = "ar.session";
        protected Castle.ActiveRecord.SessionScope Scope { get; private set; }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.User = User;
            if (!HttpContext.Items.Contains(AR_SCOPE_NAME))
            {
                Scope = new Castle.ActiveRecord.SessionScope(Castle.ActiveRecord.FlushAction.Never);
                HttpContext.Items.Add(AR_SCOPE_NAME, this.Scope);
                base.OnActionExecuting(filterContext);
            }
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            if (this.HttpContext.Items.Contains(AR_SCOPE_NAME) && Scope != null)
            {
                Scope.Dispose();
            }
        }
    }
}