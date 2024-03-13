using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        TasteContext context = new TasteContext();
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
        //[HttpPost]
        //public PartialViewResult PartialReservationBookYourTable(Reservation reservation)
        //{
        //    reservation.ReservationStatus = "Rezervasyon Alındı";
        //    context.Reservations.Add(reservation);
        //    context.SaveChanges();
        //    ViewBag.v = "true";
        //    return PartialView();
        //}
        [HttpPost]
        public JsonResult CreateReservation(Reservation reservation)
        {
            reservation.ReservationStatus = "Rezervasyon Alındı";
            //reservation.ReservationDate
            context.Reservations.Add(reservation);
            context.SaveChanges();
            ViewBag.v = "true";
            return Json(reservation, JsonRequestBehavior.AllowGet);
        }



    }
}