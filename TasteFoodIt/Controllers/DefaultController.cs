using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    //Anasayfa
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}