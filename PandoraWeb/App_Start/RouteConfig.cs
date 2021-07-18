using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PandoraWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            ///
            /// 
            ///
            routes.MapRoute(
                name: "tim-manh-kieu",
                url: "tim-manh-kieu",
                defaults: new { controller = "Puzzle", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ghep-kieu",
                url: "ghep-kieu",
                defaults: new { controller = "Puzzle", action = "Puzzle2", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ruoc-bich-nu",
                url: "ruoc-bich-nu",
                defaults: new { controller = "Puzzle", action = "Puzzle3", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "xep-hinh-nhan",
                url: "xep-hinh-nhan",
                defaults: new { controller = "Puzzle", action = "Puzzle4", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "di-tim-la-thuoc",
                url: "di-tim-la-thuoc",
                defaults: new { controller = "Puzzle", action = "Puzzle5", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "xep-tranh",
                url: "xep-tranh",
                defaults: new { controller = "Puzzle", action = "Puzzle6", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "cau-co",
                url: "cau-co",
                defaults: new { controller = "Puzzle", action = "Puzzle7", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "thoat-khoi-phong-cam",
                url: "thoat-khoi-phong-cam",
                defaults: new { controller = "Puzzle", action = "Puzzle8", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "tu-thuoc",
                url: "tu-thuoc",
                defaults: new { controller = "Puzzle", action = "Puzzle9", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "xac-dinh-can-chi",
                url: "xac-dinh-can-chi",
                defaults: new { controller = "Puzzle", action = "Puzzle10", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "thuoc-dan",
                url: "thuoc-dan",
                defaults: new { controller = "Puzzle", action = "Puzzle11", id = UrlParameter.Optional }
            );
            ///
            ///

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
