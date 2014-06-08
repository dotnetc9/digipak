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
    public class HanacarakaUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /HanacarakaUser/
        public ActionResult Index()
        {
            var hanacaraka = db.Hanacaraka.Include(h => h.Kategori);
            return View(hanacaraka.ToList());
        }
    }
}
