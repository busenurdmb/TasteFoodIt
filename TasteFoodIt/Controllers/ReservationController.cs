using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasteFoodIt.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult Index()
        {
            string PageName = "Rezervasyon";
            TempData["Page"] = PageName;
            return View();
        }
        public PartialViewResult PartialReservationBookYourTable()
        {
            return PartialView();
        }
    }
}