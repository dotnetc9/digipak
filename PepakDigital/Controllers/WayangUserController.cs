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
    public class WayangUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /WayangUser/
        public ActionResult Index()
        {
            var wayang = db.Wayang.Include(w => w.Kategori);
            return View(wayang.ToList());
        }

       
    }
}
