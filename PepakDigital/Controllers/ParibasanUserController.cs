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
    public class ParibasanUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /ParibasanUser/
        public ActionResult Index()
        {
            var paribasan = db.Paribasan.Include(p => p.Kategori);
            return View(paribasan.ToList());
        }

      
    }
}
