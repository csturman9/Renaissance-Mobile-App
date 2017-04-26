using Spring.Context.Support;
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
    public class WebApiApplication : SpringMvcApplication 
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            DependencyResolver.SetResolver(new SpringDependencyResolver(ContextRegistry.GetContext()));
        }
    }
}
