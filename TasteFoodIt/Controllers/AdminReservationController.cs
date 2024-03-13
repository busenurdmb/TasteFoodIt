using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminReservationController : Controller
    {
        // GET: AdminReservation
        TasteContext context = new TasteContext();

        public ActionResult ReservationList()
        {
            ViewBag.name = "Rezervasyon";
            var values = context.Reservations.ToList();
            return View(values);
        }
    
        public ActionResult DeleteReservation(int id)
        {
            var values = context.Reservations.Find(id);
            values.ReservationStatus = "İptal Edildi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
        public ActionResult OnaylandıReservation(int id)
        {
            var values = context.Reservations.Find(id);
            values.ReservationStatus = "Onaylandı";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
        public ActionResult BekletReservation(int id)
        {
            var values = context.Reservations.Find(id);
            values.ReservationStatus = "Beklet";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
        [HttpGet]
        public ActionResult UpdateReservation(int id)
        {
            var value = context.Reservations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateReservation(Reservation Reservation)
        {
            var value = context.Reservations.Find(Reservation.ReservationId);
            value.ReservationStatus = Reservation.ReservationStatus;
            context.SaveChanges();
            return RedirectToAction("ReservationList");

        }
    }
}