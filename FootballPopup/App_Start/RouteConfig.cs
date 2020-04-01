using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FootballPopup
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // it's more typical to pass in parameters as route data
            // (http://localhost:xxxx/HelloWorld/Welcome?name=Scott&numtimes=4)
            // http://localhost:xxx/HelloWorld/Welcome/1?name=Scott
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // You could also add a route to pass both the name and numtimes in parameters as route data in the URL
            // localhost:XXX/HelloWorld/Welcome/Scott/3
            routes.MapRoute(
             name: "Hello",
             url: "{controller}/{action}/{name}/{id}"
            );
        }
    }
}
