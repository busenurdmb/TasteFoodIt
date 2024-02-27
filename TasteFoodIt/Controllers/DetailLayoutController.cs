using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    
    public class DetailLayoutController : Controller
    {
        TasteContext context = new TasteContext();

        // GET: DetailLayout
        public ActionResult Index()
        {
            return View();
        }
     
        public PartialViewResult PartialDetailPage()
        {
            ViewBag.Page = TempData["Page"];
           return PartialView();
        }
       


    }
}