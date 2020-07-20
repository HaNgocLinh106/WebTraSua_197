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
    public class PhanHoisController : Controller
    {
        private WebTraSua db = new WebTraSua();

        // GET: Admin/PhanHois
        public ActionResult Index()
        {
            return View(db.PhanHois.ToList());
        }

        // GET: Admin/PhanHois/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhanHoi phanHoi = db.PhanHois.Find(id);
            if (phanHoi == null)
            {
                return HttpNotFound();
            }
            return View(phanHoi);
        }

        // GET: Admin/PhanHois/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PhanHois/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhanHoi,TenNguoiPhanHoi,NoiDung,NgayPhanHoi")] PhanHoi phanHoi)
        {
            if (ModelState.IsValid)
            {
                db.PhanHois.Add(phanHoi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phanHoi);
        }

        // GET: Admin/PhanHois/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhanHoi phanHoi = db.PhanHois.Find(id);
            if (phanHoi == null)
            {
                return HttpNotFound();
            }
            return View(phanHoi);
        }

        // POST: Admin/PhanHois/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhanHoi,TenNguoiPhanHoi,NoiDung,NgayPhanHoi")] PhanHoi phanHoi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phanHoi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phanHoi);
        }

        // GET: Admin/PhanHois/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhanHoi phanHoi = db.PhanHois.Find(id);
            if (phanHoi == null)
            {
                return HttpNotFound();
            }
            return View(phanHoi);
        }

        // POST: Admin/PhanHois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhanHoi phanHoi = db.PhanHois.Find(id);
            db.PhanHois.Remove(phanHoi);
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
