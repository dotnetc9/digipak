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
    public class HanacarakaController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /Hanacaraka/
        public ActionResult Index()
        {
            var hanacaraka = db.Hanacaraka.Include(h => h.Kategori);
            return View(hanacaraka.ToList());
        }

        // GET: /Hanacaraka/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hanacaraka hanacaraka = db.Hanacaraka.Find(id);
            if (hanacaraka == null)
            {
                return HttpNotFound();
            }
            return View(hanacaraka);
        }

        // GET: /Hanacaraka/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis");
            return View();
        }

        // POST: /Hanacaraka/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="HanacarakaId,Aksara,GambarURL,KategoriId")] Hanacaraka hanacaraka)
        {
            if (ModelState.IsValid)
            {
                db.Hanacaraka.Add(hanacaraka);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", hanacaraka.KategoriId);
            return View(hanacaraka);
        }

        // GET: /Hanacaraka/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hanacaraka hanacaraka = db.Hanacaraka.Find(id);
            if (hanacaraka == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", hanacaraka.KategoriId);
            return View(hanacaraka);
        }

        // POST: /Hanacaraka/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="HanacarakaId,Aksara,GambarURL,KategoriId")] Hanacaraka hanacaraka)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hanacaraka).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", hanacaraka.KategoriId);
            return View(hanacaraka);
        }

        // GET: /Hanacaraka/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hanacaraka hanacaraka = db.Hanacaraka.Find(id);
            if (hanacaraka == null)
            {
                return HttpNotFound();
            }
            return View(hanacaraka);
        }

        // POST: /Hanacaraka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hanacaraka hanacaraka = db.Hanacaraka.Find(id);
            db.Hanacaraka.Remove(hanacaraka);
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
