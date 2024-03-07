using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminDashboardController : Controller
    {
        TasteContext context = new TasteContext();
        // GET: Dashboard

        public ActionResult Index()
        {
            ViewBag.v1 = context.Categories.Count();
            ViewBag.v2 = context.Products.Count();
            ViewBag.v3 = context.Chef.Count();
            ViewBag.v4 = context.Reservations.Where(x=>x.ReservationStatus=="true").Count();
            return View();
        }
    }
}