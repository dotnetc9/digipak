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
    public class KewanUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /KewanUser/
        public ActionResult Index()
        {
            var kewan = db.Kewan.Include(k => k.Kategori);
            return View(kewan.ToList());
        }
    }
}
