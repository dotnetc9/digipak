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
    public class KawruhBasaUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /KawruhBasaUser/
        public ActionResult Index()
        {
            var kawruhbasa = db.KawruhBasa.Include(k => k.Kategori);
            return View(kawruhbasa.ToList());
        }
    }
}
