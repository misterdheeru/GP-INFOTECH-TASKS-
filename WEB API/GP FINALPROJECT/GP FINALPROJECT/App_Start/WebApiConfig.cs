using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GP_FINALPROJECT
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            #region Enabling Cross
            // Web API configuration and services

            var cors = new EnableCorsAttribute("*", "*", "*");  // PM> Install-Package Microsoft.AspNet.WebApi.Cors 
            config.EnableCors(cors);

            // Web API routes
            #endregion

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
