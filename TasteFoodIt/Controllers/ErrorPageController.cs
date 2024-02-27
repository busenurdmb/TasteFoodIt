using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasteFoodIt.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult Page404()
        {
            return View();
        }
        public ActionResult Page403()
        {
            return View();
        }
        public ActionResult Page500()
        {
            return View();
        }
    }
}