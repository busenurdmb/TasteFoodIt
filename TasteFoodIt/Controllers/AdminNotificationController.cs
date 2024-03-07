using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminNotificationController : Controller
    {
        TasteContext context=new TasteContext();
        // GET: AdminNotification
        public ActionResult NotificationList()
        {
            var value = context.Notifications.ToList();
            return View(value);
        }
        public ActionResult StatusChangeNotification(int id)
        {
            var value = context.Notifications.Find(id);
            if (value.IsRead == "true")
            {
                value.IsRead = "false";
            }
            else
            {
                value.IsRead = "true";
            }
            context.SaveChanges();
            return RedirectToAction("NotificationList","AdminNotification");
        }
        public ActionResult NotificationIsReadTrue(int id)
        {
            var value = context.Notifications.Find(id);
            value.IsRead = "true";
            context.SaveChanges();
            return RedirectToAction("NotificanList");
        }
        public ActionResult NotificationIsReadFalse(int id)
        {
            var value = context.Notifications.Find(id);
            value.IsRead = "false";
            context.SaveChanges();
            return RedirectToAction("NotificanList");
        }
    }
}