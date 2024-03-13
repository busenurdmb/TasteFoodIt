using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasteFoodIt.Controllers
{
    [AllowAnonymous]
    public class ChefController : Controller
    {
        // GET: Chef
        public ActionResult Index()
        {
            //ViewBag.Page = "Chef";
            string PageName = "Chef";
            TempData["Page"] = PageName;
            return View();
        }
    }
}