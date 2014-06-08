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
    public class ParamasastraUserJawaController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /ParamasastraUserJawa/
        public ActionResult Index(string cariData)
        {
            var paramasastra = db.Paramasastra.Include(p => p.Kategori);
            {
                paramasastra = paramasastra.Where(kata => kata.Ngoko.ToUpper().Contains(cariData.ToUpper())
                    || kata.Ngoko.ToUpper().Contains(cariData.ToUpper()) || kata.Madya.ToUpper().Contains(cariData.ToUpper())
                    || kata.Madya.ToUpper().Contains(cariData.ToUpper()) || kata.Inggil.ToUpper().Contains(cariData.ToUpper())
                    || kata.Inggil.ToUpper().Contains(cariData.ToUpper()));
            }
            return View(paramasastra.ToList());
        }
    }
}
