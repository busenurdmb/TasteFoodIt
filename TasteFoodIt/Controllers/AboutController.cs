using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AboutController : Controller
    {
        TasteContext context = new TasteContext();
        // GET: About
        public ActionResult Index()
        {
            //ViewBag.Page = "About";
            string PageName = "About";
            TempData["Page"] = PageName;
            return View();
        }
        public PartialViewResult PartialAboutStatistic()
        {
            ViewBag.FoodCount = context.Products.Count();
            
            return PartialView();
        }
    
    }
}