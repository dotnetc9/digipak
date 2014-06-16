using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PepakDigital.Controllers
{
    public class LogoutController : Controller
    {
        //
        // GET: /Logout/
        public ActionResult Index()
        {
            if (Session["User"] != null)
            {
                Session["User"] = null;
                return RedirectToAction(null, "Home");
            }
            else
                return View();
        }
	}
}