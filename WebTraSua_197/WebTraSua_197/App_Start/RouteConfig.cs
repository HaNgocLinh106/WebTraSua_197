﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebTraSua_197
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Danh mục sản phẩm",
            url: "danh-muc/{metatitle}-{MaDanhMuc}",
            defaults: new { controller = "SanPham", action = "SanPham", id = UrlParameter.Optional },
            namespaces: new[] { "WebTraSua_197.Controllers" }
        );
            routes.MapRoute(
      name: "Chi tiết sản phẩm",
      url: "chi-tiet-san-pham/{metatitle}-{MaSanPham}",
      defaults: new { controller = "SanPham", action = "ChiTietSanPham", id = UrlParameter.Optional },
      namespaces: new[] { "WebTraSua_197.Controllers" }
  );
            routes.MapRoute(
    name: "Thanh toán",
    url: "thanh-toan",
    defaults: new { controller = "Cart", action = "ThanhToan", id = UrlParameter.Optional },
    namespaces: new[] { "WebTraSua_197.Controllers" }
);

            routes.MapRoute(
         name: "Thanh toán thành công",
         url: "hoan-thanh",
         defaults: new { controller = "Cart", action = "ThanhCong", id = UrlParameter.Optional },
         namespaces: new[] { "WebTraSua_197.Controllers" }
     );
            routes.MapRoute(
            name: "Tài khoản",
            url: "tai-khoan",
            defaults: new { controller = "User", action = "TaiKhoan", id = UrlParameter.Optional },
            namespaces: new[] { "WebTraSua_197.Controllers" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
