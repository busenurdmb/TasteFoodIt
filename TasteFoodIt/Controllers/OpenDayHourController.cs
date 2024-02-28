using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class OpenDayHourController : Controller
    {
        // GET: OpenDayHour
        TasteContext context = new TasteContext();

        public ActionResult OpenDayHourList()
        {
            var values = context.openDayHours.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateOpenDayHour()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOpenDayHour(OpenDayHour OpenDayHour)
        {
            context.openDayHours.Add(OpenDayHour);
            context.SaveChanges();
            return RedirectToAction("OpenDayHourList");

        }
        public ActionResult DeleteOpenDayHour(int id)
        {
            var values = context.openDayHours.Find(id);
            context.openDayHours.Remove(values);
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
        public ActionResult UpdateOpenDayHour(OpenDayHour OpenDayHour)
        {
            var value = context.openDayHours.Find(OpenDayHour.OpenDayHourID);
            value.DayName= OpenDayHour.DayName;
            value.OpenHourRange = OpenDayHour.OpenHourRange;
             context.SaveChanges();
            return RedirectToAction("OpenDayHourList");

        }
    }
}