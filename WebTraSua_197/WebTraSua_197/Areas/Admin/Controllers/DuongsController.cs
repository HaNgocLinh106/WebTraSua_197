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
    public class DuongsController : Controller
    {
        private WebTraSua db = new WebTraSua();

        // GET: Admin/Duongs
        public ActionResult Index()
        {
            return View(db.Duongs.ToList());
        }

        // GET: Admin/Duongs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duong duong = db.Duongs.Find(id);
            if (duong == null)
            {
                return HttpNotFound();
            }
            return View(duong);
        }

        // GET: Admin/Duongs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Duongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDuong,Duong1")] Duong duong)
        {
            if (ModelState.IsValid)
            {
                db.Duongs.Add(duong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duong);
        }

        // GET: Admin/Duongs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duong duong = db.Duongs.Find(id);
            if (duong == null)
            {
                return HttpNotFound();
            }
            return View(duong);
        }

        // POST: Admin/Duongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDuong,Duong1")] Duong duong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duong);
        }

        // GET: Admin/Duongs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duong duong = db.Duongs.Find(id);
            if (duong == null)
            {
                return HttpNotFound();
            }
            return View(duong);
        }

        // POST: Admin/Duongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Duong duong = db.Duongs.Find(id);
            db.Duongs.Remove(duong);
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
