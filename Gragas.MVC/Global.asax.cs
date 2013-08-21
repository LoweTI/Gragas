using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.ActiveRecord;
using Gragas.Model.Repository;
using Gragas.Model.Hebara;
using Gragas.Model.Eagle;
using Castle.ActiveRecord.Framework.Config;

namespace Gragas.MVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Type[] types = {
                                //Gragas
                                typeof(Server),
                                //Hebara
                                typeof(BilletLegacy),
                                typeof(SecondConnection<>),
                                //Eagle
                                typeof(BilletEagle),
                                typeof(ThirdConnection<>)
                            };

            if (!ActiveRecordStarter.IsInitialized)
                ActiveRecordStarter.Initialize(ActiveRecordSectionHandler.Instance, types);
        }
    }
}