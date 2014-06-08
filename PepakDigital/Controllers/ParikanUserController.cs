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
    public class ParikanUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /ParikanUser/
        public ActionResult Index()
        {
            var parikan = db.Parikan.Include(p => p.Kategori);
            return View(parikan.ToList());
        }

    
    }
}
