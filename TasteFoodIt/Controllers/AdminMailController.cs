using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminMailController : Controller
    {
        // GET: Mail
        TasteContext context = new TasteContext();

        public ActionResult ContactList()
        {
            ViewBag.name = "Gelen Mailler";
            var values = context.Mails.ToList();
            return View(values);
        }
        [HttpPost]
        public JsonResult CreateMail(Mail  mail)
        {
            mail.Status = false;
            //reservation.ReservationDate
            context.Mails.Add(mail);
            context.SaveChanges();
            //ViewBag.v = "true";
            return Json(mail, JsonRequestBehavior.AllowGet);
        }
    }
}