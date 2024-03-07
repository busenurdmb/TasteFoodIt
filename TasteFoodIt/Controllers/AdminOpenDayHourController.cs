using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminOpenDayHourController : Controller
    {
        // GET: AdminOpenDayHour
        TasteContext context = new TasteContext();
        // GET: OpenDayHour
        public ActionResult OpenDayHourList()
        {
            var value = context.openDayHours.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateOpenDayHour()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOpenDayHour(OpenDayHour openDayHour)
        {
            context.openDayHours.Add(openDayHour);
            context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }

        [HttpGet]
        public ActionResult UpdateOpenDayHour(int id)
        {
            var value = context.openDayHours.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateOpenDayHour(OpenDayHour openDayHour)
        {
            var value = context.openDayHours.Find(openDayHour.OpenDayHourID);
            value.DayName = openDayHour.DayName;
            value.OpenHourRange = openDayHour.OpenHourRange;
            context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }

        public ActionResult DeleteOpenDayHour(int id)
        {
            var value = context.openDayHours.Find(id);
            context.openDayHours.Remove(value);
            context.SaveChanges();
            return RedirectToAction("OpenDayHourList");
        }
    }
}