using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PepakDigital;

namespace PepakDigital.Controllers
{
    public class WayangController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /Wayang/
        public ActionResult Index()
        {
            var wayang = db.Wayang.Include(w => w.Kategori);
            return View(wayang.ToList());
        }

        // GET: /Wayang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wayang wayang = db.Wayang.Find(id);
            if (wayang == null)
            {
                return HttpNotFound();
            }
            return View(wayang);
        }

        // GET: /Wayang/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis");
            return View();
        }

        // POST: /Wayang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="WayangId,JenengWayang,GambarURL,KategoriId")] Wayang wayang)
        {
            if (ModelState.IsValid)
            {
                db.Wayang.Add(wayang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", wayang.KategoriId);
            return View(wayang);
        }

        // GET: /Wayang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wayang wayang = db.Wayang.Find(id);
            if (wayang == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", wayang.KategoriId);
            return View(wayang);
        }

        // POST: /Wayang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="WayangId,JenengWayang,GambarURL,KategoriId")] Wayang wayang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wayang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", wayang.KategoriId);
            return View(wayang);
        }

        // GET: /Wayang/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wayang wayang = db.Wayang.Find(id);
            if (wayang == null)
            {
                return HttpNotFound();
            }
            return View(wayang);
        }

        // POST: /Wayang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wayang wayang = db.Wayang.Find(id);
            db.Wayang.Remove(wayang);
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
