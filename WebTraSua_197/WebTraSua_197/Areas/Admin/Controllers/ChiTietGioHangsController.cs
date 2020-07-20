using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebTraSua_197.Models.EF;

namespace WebTraSua_197.Areas.Admin.Controllers
{
    public class ChiTietGioHangsController : Controller
    {
        private WebTraSua db = new WebTraSua();

        // GET: Admin/ChiTietGioHangs
        public ActionResult Index()
        {
            var chiTietGioHangs = db.ChiTietGioHangs.Include(c => c.GioHang).Include(c => c.SanPham);
            return View(chiTietGioHangs.ToList());
        }

        // GET: Admin/ChiTietGioHangs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietGioHang chiTietGioHang = db.ChiTietGioHangs.Find(id);
            if (chiTietGioHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietGioHang);
        }

        // GET: Admin/ChiTietGioHangs/Create
        public ActionResult Create()
        {
            ViewBag.MaGioHang = new SelectList(db.GioHangs, "MaGioHang", "HinhThucThanhToan");
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "TenSanPham");
            return View();
        }

        // POST: Admin/ChiTietGioHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChiTietGioHang,MaGioHang,MaSanPham,Duong,Da,Topping,DonGia,SoLuong")] ChiTietGioHang chiTietGioHang)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietGioHangs.Add(chiTietGioHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaGioHang = new SelectList(db.GioHangs, "MaGioHang", "HinhThucThanhToan", chiTietGioHang.MaGioHang);
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "TenSanPham", chiTietGioHang.MaSanPham);
            return View(chiTietGioHang);
        }

        // GET: Admin/ChiTietGioHangs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietGioHang chiTietGioHang = db.ChiTietGioHangs.Find(id);
            if (chiTietGioHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaGioHang = new SelectList(db.GioHangs, "MaGioHang", "HinhThucThanhToan", chiTietGioHang.MaGioHang);
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "TenSanPham", chiTietGioHang.MaSanPham);
            return View(chiTietGioHang);
        }

        // POST: Admin/ChiTietGioHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChiTietGioHang,MaGioHang,MaSanPham,Duong,Da,Topping,DonGia,SoLuong")] ChiTietGioHang chiTietGioHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietGioHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaGioHang = new SelectList(db.GioHangs, "MaGioHang", "HinhThucThanhToan", chiTietGioHang.MaGioHang);
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "TenSanPham", chiTietGioHang.MaSanPham);
            return View(chiTietGioHang);
        }

        // GET: Admin/ChiTietGioHangs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietGioHang chiTietGioHang = db.ChiTietGioHangs.Find(id);
            if (chiTietGioHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietGioHang);
        }

        // POST: Admin/ChiTietGioHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ChiTietGioHang chiTietGioHang = db.ChiTietGioHangs.Find(id);
            db.ChiTietGioHangs.Remove(chiTietGioHang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
