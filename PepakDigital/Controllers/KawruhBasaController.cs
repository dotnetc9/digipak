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
    public class KawruhBasaController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /KawruhBasa/
        public ActionResult Index()
        {
            var kawruhbasa = db.KawruhBasa.Include(k => k.Kategori);
            return View(kawruhbasa.ToList());
        }

        // GET: /KawruhBasa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KawruhBasa kawruhbasa = db.KawruhBasa.Find(id);
            if (kawruhbasa == null)
            {
                return HttpNotFound();
            }
            return View(kawruhbasa);
        }

        // GET: /KawruhBasa/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis");
            return View();
        }

        // POST: /KawruhBasa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="KawruhBasaId,Tembung,PodhoTegese,KosokBalen,KategoriId")] KawruhBasa kawruhbasa)
        {
            if (ModelState.IsValid)
            {
                db.KawruhBasa.Add(kawruhbasa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", kawruhbasa.KategoriId);
            return View(kawruhbasa);
        }

        // GET: /KawruhBasa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KawruhBasa kawruhbasa = db.KawruhBasa.Find(id);
            if (kawruhbasa == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", kawruhbasa.KategoriId);
            return View(kawruhbasa);
        }

        // POST: /KawruhBasa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="KawruhBasaId,Tembung,PodhoTegese,KosokBalen,KategoriId")] KawruhBasa kawruhbasa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kawruhbasa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", kawruhbasa.KategoriId);
            return View(kawruhbasa);
        }

        // GET: /KawruhBasa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KawruhBasa kawruhbasa = db.KawruhBasa.Find(id);
            if (kawruhbasa == null)
            {
                return HttpNotFound();
            }
            return View(kawruhbasa);
        }

        // POST: /KawruhBasa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KawruhBasa kawruhbasa = db.KawruhBasa.Find(id);
            db.KawruhBasa.Remove(kawruhbasa);
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
