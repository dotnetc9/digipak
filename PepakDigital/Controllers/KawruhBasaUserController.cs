using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PepakDigital;
using PagedList;

namespace PepakDigital.Controllers
{
    public class KawruhBasaUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /KawruhBasaUser/
        public ActionResult Index(string sortData, string Filter_Value, int? Page_No)
        {
            ViewBag.CurrentSortOrder = sortData;
            ViewBag.SortingName = String.IsNullOrEmpty(sortData) ? "Urut_Kawruh" : "";
            var kawruhbasa = db.KawruhBasa.Include(k => k.Kategori);

            switch (sortData)
            {
                case "Urut_Kawruh":
                    kawruhbasa = kawruhbasa.OrderByDescending(kawruh => kawruh.Tembung);
                    break;
                default:
                    kawruhbasa = kawruhbasa.OrderBy(kawruh => kawruh.Tembung);
                    break;
            }

            int Size_Of_Page = 10;
            int No_Of_Page = (Page_No ?? 1);
            return View(kawruhbasa.ToPagedList(No_Of_Page, Size_Of_Page));
        }
    }
}
