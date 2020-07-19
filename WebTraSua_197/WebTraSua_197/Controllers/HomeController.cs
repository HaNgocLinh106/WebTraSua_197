using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraSua_197.Models.Fun;

namespace WebTraSua_197.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TimKiem(string search)
        {
            var model = new SanPhamF().TimKiemSP(search);
            return View(model);
        }

        public PartialViewResult PhanHoi()
        {
            var model = new PhanHoiF().ListPH(4);
            return PartialView(model);
        }
    }
}