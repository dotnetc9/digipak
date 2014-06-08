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
    public class ParamasastraUserIndoController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /ParamasastraUserIndo/
        public ActionResult Index(string cariData)
        {
            var paramasastra = db.Paramasastra.Include(p => p.Kategori);
            {
                paramasastra = paramasastra.Where(kata => kata.Indonesia.ToUpper().Contains(cariData.ToUpper())
                    || kata.Indonesia.ToUpper().Contains(cariData.ToUpper()));
            }
            return View(paramasastra.ToList());
        }
    }
}
