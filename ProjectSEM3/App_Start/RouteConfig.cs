using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectSEM3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // BotDetect requests must not be routed

            routes.IgnoreRoute("{*botdetect}",
              new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

            routes.MapRoute(
               name: "Dessert",
               url: "dessert/{metatile}-{id}",
               defaults: new { controller = "Product", action = "ProductcategoryDessert", id = UrlParameter.Optional },
               namespaces: new string[] { "ProjectSEM3.Controllers" }

           );
            routes.MapRoute(
               name: "Desserts",
               url: "dessert/",
               defaults: new { controller = "Product", action = "ProductcategoryDessert", id = UrlParameter.Optional },
               namespaces: new string[] { "ProjectSEM3.Controllers" }

           );
            routes.MapRoute(
              name: "feedback",
              url: "feed-back/",
              defaults: new { controller = "Feedback", action = "Index", id = UrlParameter.Optional },
              namespaces: new string[] { "ProjectSEM3.Controllers" }

          );
            routes.MapRoute(
            name: "chi tiết bài viết",
            url: "bai-viet/{metatile}-{id}",
            defaults: new { controller = "Content", action = "Detail", id = UrlParameter.Optional },
            namespaces: new string[] { "ProjectSEM3.Controllers" }

        );
            routes.MapRoute(
        name: "danh mục",
        url: "danh-muc/{metatile}-{id}",
        defaults: new { controller = "Product", action = "ProductCategory", id = UrlParameter.Optional },
        namespaces: new string[] { "ProjectSEM3.Controllers" }

    );
            routes.MapRoute(
            name: "Danh mục bài viết",
            url: "bai-viet/danh-muc/{metatile}-{id}",
            defaults: new { controller = "Content", action = "Category", id = UrlParameter.Optional },
            namespaces: new string[] { "ProjectSEM3.Controllers" }

        );
            routes.MapRoute(
           name: " bài viết",
           url: "bai-viet/",
           defaults: new { controller = "Content", action = "Index", id = UrlParameter.Optional },
           namespaces: new string[] { "ProjectSEM3.Controllers" }

       );

            routes.MapRoute(
               name: "Book",
               url: "books/{metatile}-{id}",
               defaults: new { controller = "Product", action = "ProductcategoryBook", id = UrlParameter.Optional },
               namespaces: new string[] { "ProjectSEM3.Controllers" }

           );
            routes.MapRoute(
              name: "Books",
              url: "books/",
              defaults: new { controller = "Product", action = "ProductcategoryBook", id = UrlParameter.Optional },
              namespaces: new string[] { "ProjectSEM3.Controllers" }

          );
            routes.MapRoute(
              name: "Ice-Cream",
              url: "ice-cream/{metatile}-{id}",
              defaults: new { controller = "Product", action = "ProductcategoryCream", id = UrlParameter.Optional },
              namespaces: new string[] { "ProjectSEM3.Controllers" }

          );
            routes.MapRoute(
              name: "Ice-Creams",
              url: "ice-cream/",
              defaults: new { controller = "Product", action = "ProductcategoryCream", id = UrlParameter.Optional },
              namespaces: new string[] { "ProjectSEM3.Controllers" }

          );
            routes.MapRoute(
                name: "DetailProduct",
                url: "chi-tiet/{metatile}-{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
                namespaces: new string[] { "ProjectSEM3.Controllers" }

            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ProjectSEM3.Controllers" }

            );
        }
    }
}
