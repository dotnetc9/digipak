using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PepakDigital.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            if (Session["User"] != null)
            {
                ViewBag.sesi = Session["User"];
                return View();
            }
            else
                return RedirectToAction(null,"LoginAdmin");
        }
	}
}