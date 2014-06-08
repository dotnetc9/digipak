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
    public class ParamasastraUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /ParamasastraUser/
        public ActionResult Index(string sortData, string Filter_Value, int? Page_No)
        {
            ViewBag.CurrentSortOrder = sortData;
            ViewBag.SortingName = String.IsNullOrEmpty(sortData) ? "Urut_Ngoko" : "";
            var paramasastra = db.Paramasastra.Include(p => p.Kategori);

            switch (sortData)
            {
                case "Urut_Ngoko":
                    paramasastra = paramasastra.OrderByDescending(kata => kata.Ngoko);
                    break;
                default:
                    paramasastra = paramasastra.OrderBy(kata => kata.Ngoko);
                    break;
            }

            int Size_Of_Page = 10;
            int No_Of_Page = (Page_No ?? 1);
            return View(paramasastra.ToPagedList(No_Of_Page, Size_Of_Page));
        }
    }
}
