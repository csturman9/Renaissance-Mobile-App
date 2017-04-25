using log4net.Config;
using NHibernate;
using Spring.Context;
using Spring.Context.Support;
using Spring.Core.IO;
using Spring.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rennaisance_WebService
{
    public class WebApiApplication : SpringMvcApplication //System.Web.HttpApplication
    {       
        protected void Application_Start()
        {
            XmlConfigurator.Configure();

            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);

            DependencyResolver.SetResolver(new SpringDependencyResolver(ContextRegistry.GetContext()));
        }
    }
}
