using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraSua_197.Models.Fun;

namespace WebTraSua_197.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult SanPham(long MaDanhMuc)
        {
            var danhmuc = new DanhMucF().DanhMucSP(MaDanhMuc);
            ViewBag.SanPham = new DanhMucF().ListAllSP(danhmuc.MaDanhMuc);
            return View(MaDanhMuc);
        }
        public ActionResult AllSanPham()
        {
            var model = new SanPhamF().ListAllSP();
            return View(model);
        }
        [ChildActionOnly]
        public PartialViewResult DanhMuc()
        {
            var model = new DanhMucF().ListAll();
            return PartialView(model);
        }
        public ActionResult ListSanPham()
        {
            var model = new SanPhamF().ListSP(3);
            return PartialView(model);
        }
        public PartialViewResult ListSanPhamLQ()
        {
            var model = new SanPhamF().ListSP(3);
            return PartialView(model);
        }
        public ActionResult ChiTietSanPham(long MaSanPham)
        {
            var spOD = new SanPhamF().Detail(MaSanPham);
            ViewBag.Detail = new SanPhamF().Detail(spOD.MaSanPham);
            ViewBag.ListDetail = new SanPhamF().ListDetail(spOD.MaSanPham);
            ViewBag.Topping = new SanPhamF().Topping();
            ViewBag.Duong = new SanPhamF().Duong();
            ViewBag.Da = new SanPhamF().Da();
            return View(spOD);
        }
    }
}