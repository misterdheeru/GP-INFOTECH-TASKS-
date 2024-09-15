 using System.Web.Http;
 


namespace gp_studentscrudFileUpload
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            #region TRANSFER DATA TO ANGULAR OR OTHER API CALLS 

            var cors = new System.Web.Http.Cors.EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            #endregion


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
