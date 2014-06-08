﻿using System;
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
    public class KewanController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /Kewan/
        public ActionResult Index()
        {
            var kewan = db.Kewan.Include(k => k.Kategori);
            return View(kewan.ToList());
        }

        // GET: /Kewan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kewan kewan = db.Kewan.Find(id);
            if (kewan == null)
            {
                return HttpNotFound();
            }
            return View(kewan);
        }

        // GET: /Kewan/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis");
            return View();
        }

        // POST: /Kewan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="KewanId,JenengKewan,AnakeKewan,KategoriId")] Kewan kewan)
        {
            if (ModelState.IsValid)
            {
                db.Kewan.Add(kewan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", kewan.KategoriId);
            return View(kewan);
        }

        // GET: /Kewan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kewan kewan = db.Kewan.Find(id);
            if (kewan == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", kewan.KategoriId);
            return View(kewan);
        }

        // POST: /Kewan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="KewanId,JenengKewan,AnakeKewan,KategoriId")] Kewan kewan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kewan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "Jenis", kewan.KategoriId);
            return View(kewan);
        }

        // GET: /Kewan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kewan kewan = db.Kewan.Find(id);
            if (kewan == null)
            {
                return HttpNotFound();
            }
            return View(kewan);
        }

        // POST: /Kewan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kewan kewan = db.Kewan.Find(id);
            db.Kewan.Remove(kewan);
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
