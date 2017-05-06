using RennaisanceWebService.HibernateClasses;
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
    public class WebApiApplication : HttpApplication //SpringMvcApplication 
    {
        protected SessionHelper _sessionHelper = null;

        

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //DependencyResolver.SetResolver(new SpringDependencyResolver(ContextRegistry.GetContext()));
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            _sessionHelper = new SessionHelper();
            _sessionHelper.OpenSession();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            _sessionHelper = new SessionHelper();
            _sessionHelper.CloseSession();
        }
    }
}
