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
    public class KewanUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /KewanUser/
        public ActionResult Index(string sortData, string Filter_Value, int? Page_No)
        {
            ViewBag.CurrentSortOrder = sortData;
            ViewBag.SortingName = String.IsNullOrEmpty(sortData) ? "Urut_Kewan" : "";
            var kewan = db.Kewan.Include(k => k.Kategori);
            
            switch (sortData)
            {
                case "Urut_Kewan":
                    kewan = kewan.OrderByDescending(hewan => hewan.JenengKewan);
                    break;
                default:
                    kewan = kewan.OrderBy(hewan => hewan.JenengKewan);
                    break;
            }

            int Size_Of_Page = 10;
            int No_Of_Page = (Page_No ?? 1);
            return View(kewan.ToPagedList(No_Of_Page, Size_Of_Page));       
        }

            
    }
}
