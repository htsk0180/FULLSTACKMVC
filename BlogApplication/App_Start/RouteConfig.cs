using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BlogApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
               name: "Kategoriler",
               url: "Kategori/{CategoryLink}",
               defaults: new { controller = "Category", action = "Index", CategoryLink = UrlParameter.Optional }
           );


            routes.MapRoute(
               name: "Makaleler",
               url: "Makale/{PostLink}",
               defaults: new { controller = "Home", action = "Detail", PostLink = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
