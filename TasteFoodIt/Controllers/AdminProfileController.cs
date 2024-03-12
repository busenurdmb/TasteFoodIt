using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasteFoodIt.Controllers
{
    public class AdminProfileController : Controller
    {
        // GET: AdminProfile
        public ActionResult Index()
        {
            ViewBag.name = "Profil";
            ViewBag.v = Session["a"];
            return View();
        }
    }
}