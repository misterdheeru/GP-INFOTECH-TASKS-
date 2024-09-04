using Microsoft.AspNetCore.Cors;
using System.Web.Http;


namespace gp_studentscrudFileUpload
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable CORS for all domains, headers, and methods
 

            // Enable attribute-based routing
            config.MapHttpAttributeRoutes();

            // Configure the default API route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
