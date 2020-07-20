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
    public class DasController : Controller
    {
        private WebTraSua db = new WebTraSua();

        // GET: Admin/Das
        public ActionResult Index()
        {
            return View(db.Das.ToList());
        }

        // GET: Admin/Das/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Da da = db.Das.Find(id);
            if (da == null)
            {
                return HttpNotFound();
            }
            return View(da);
        }

        // GET: Admin/Das/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Das/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDa,Da1")] Da da)
        {
            if (ModelState.IsValid)
            {
                db.Das.Add(da);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(da);
        }

        // GET: Admin/Das/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Da da = db.Das.Find(id);
            if (da == null)
            {
                return HttpNotFound();
            }
            return View(da);
        }

        // POST: Admin/Das/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDa,Da1")] Da da)
        {
            if (ModelState.IsValid)
            {
                db.Entry(da).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(da);
        }

        // GET: Admin/Das/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Da da = db.Das.Find(id);
            if (da == null)
            {
                return HttpNotFound();
            }
            return View(da);
        }

        // POST: Admin/Das/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Da da = db.Das.Find(id);
            db.Das.Remove(da);
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
