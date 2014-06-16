using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PepakDigital;

namespace PepakDigital.Controllers
{
    public class LoginAdminController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        //
        // GET: /LoginAdmin/
        /// <summary>
        /// Default action name
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Second action where we receive session value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(UserDigipak data)
        {
            bool cocok = db.UserDigipak.Any(p => p.Username == data.Username && p.Password == data.Password);
            if (cocok)
            {
                // Assign value into session
                Session["User"] = data.Username;
                // Redirect view
                return RedirectToAction(null,"Admin");
            }
            else
                return RedirectToAction("Index");
        }
	}
}