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
    public class ViewGHsController : Controller
    {
        private WebTraSua db = new WebTraSua();

        // GET: Admin/ViewGHs
        public ActionResult Index()
        {
            return View(db.ViewGHs.ToList());
        }

        // GET: Admin/ViewGHs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewGH viewGH = db.ViewGHs.Find(id);
            if (viewGH == null)
            {
                return HttpNotFound();
            }
            return View(viewGH);
        }

        // GET: Admin/ViewGHs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ViewGHs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGioHang,TenSanPham,LinkAnhSP,Size,Duong,Da,Topping,DonGia,SoLuong,TenNguoiDung,SDT,DiaChi,HinhThucThanhToan,NgayThang")] ViewGH viewGH)
        {
            if (ModelState.IsValid)
            {
                db.ViewGHs.Add(viewGH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viewGH);
        }

        // GET: Admin/ViewGHs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewGH viewGH = db.ViewGHs.Find(id);
            if (viewGH == null)
            {
                return HttpNotFound();
            }
            return View(viewGH);
        }

        // POST: Admin/ViewGHs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGioHang,TenSanPham,LinkAnhSP,Size,Duong,Da,Topping,DonGia,SoLuong,TenNguoiDung,SDT,DiaChi,HinhThucThanhToan,NgayThang")] ViewGH viewGH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viewGH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewGH);
        }

        // GET: Admin/ViewGHs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewGH viewGH = db.ViewGHs.Find(id);
            if (viewGH == null)
            {
                return HttpNotFound();
            }
            return View(viewGH);
        }

        // POST: Admin/ViewGHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ViewGH viewGH = db.ViewGHs.Find(id);
            db.ViewGHs.Remove(viewGH);
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
