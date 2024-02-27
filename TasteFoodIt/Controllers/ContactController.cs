using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasteFoodIt.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            string PageName = "İletişim";
            TempData["Page"] = PageName;
            return View();
        }
        public PartialViewResult PartialContactİnformation()
        {
            return PartialView();
        }
        public PartialViewResult PartialContactUs()
        {
            return PartialView();
        }
    }
}