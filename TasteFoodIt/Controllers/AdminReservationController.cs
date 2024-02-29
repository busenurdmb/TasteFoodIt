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
        //[HttpGet]
        //public ActionResult CreateReservation()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult CreateReservation(Reservation Reservation)
        //{
        //    context.Reservations.Add(Reservation);
        //    context.SaveChanges();
        //    return RedirectToAction("ReservationList");

        //}
        public ActionResult DeleteReservation(int id)
        {
            var values = context.Reservations.Find(id);
            context.Reservations.Remove(values);
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
            value.Name = Reservation.Name;
            value.Email = Reservation.Email;
            value.ReservationStatus = Reservation.ReservationStatus;
            value.Time = Reservation.Time;
            context.SaveChanges();
            return RedirectToAction("ReservationList");

        }
    }
}