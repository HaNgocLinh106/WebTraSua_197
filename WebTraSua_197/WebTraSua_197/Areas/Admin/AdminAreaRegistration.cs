using System.Web.Mvc;

namespace WebTraSua_197.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller="HomeAdmin", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_Danhmucs",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "DanhMucs", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_SanPhams",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "SanPhams", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_QuanTriViens",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "QuanTriViens", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_NguoiDungs",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "NguoiDungs", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_DonHangs",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "ViewGHs", id = UrlParameter.Optional }
            );
        }
    }
}