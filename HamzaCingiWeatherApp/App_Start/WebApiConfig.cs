using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HamzaCingiWeatherApp
{
    public static class WebApiConfig
    {        
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear(); //Json Dönmesi için.
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }               
            );
        }
    }
}
