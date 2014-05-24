using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Log4netDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        ILogger _logger = new Log4netErrorLogger();

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/log4net.config")));
        }


        protected void Application_Error()
        {
            var request = HttpContext.Current.Request;
            var platform = request.Browser.Platform;
            var browser = request.Browser.Browser;
            var company = "Company";
            var user = "User";

            var errors = HttpContext.Current.AllErrors;
            foreach (var exception in errors)
            {
                //_logger.Write(exception.Message);
                _logger.Write(new LogMessage(exception.Message, platform, browser, company, user));
            }
        }
    }
}
