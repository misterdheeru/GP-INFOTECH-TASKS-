using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace gp_crudwithLisst
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);



            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(

            name: "yeardropdown",
            routeTemplate: "api/DropDowns/Year"

           );

            config.Routes.MapHttpRoute(

                 name: "programfordegree",
                 routeTemplate: "api/DropDowns/Program/Degree"


                );


            config.Routes.MapHttpRoute(

                 name: "programforbtech",
                 routeTemplate: "api/DropDowns/Program/Btech"


                );


            config.Routes.MapHttpRoute(

                   name: "clgbtech",
                   routeTemplate: "api/DropDowns/Colleges/Btech"


                  );


            config.Routes.MapHttpRoute(

            name: "clgdegree",
            routeTemplate: "api/DropDowns/Colleges/Degree"

           );

            config.Routes.MapHttpRoute(

                 name: "university",
                 routeTemplate: "api/DropDowns/university"

                );


            config.Routes.MapHttpRoute(

                   name: "CityTwo",
                   routeTemplate: "api/DropDowns/City/Two"

                  );

            config.Routes.MapHttpRoute(

             name: "CityOne",
             routeTemplate: "api/DropDowns/City/One"


          );

            config.Routes.MapHttpRoute(

                       name: "States",
                       routeTemplate: "api/DropDowns/States"

                     );

            config.Routes.MapHttpRoute(

                name: "Countrys",
                routeTemplate: "api/DropDowns/Countrys"

              );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/Students/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}