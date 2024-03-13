using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

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
            return RedirectToAction("NotificationList", "AdminNotification");
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
        [HttpGet]
        public ActionResult CreateNotification()
        {
            ViewBag.name = "Bildirimler";

            return View();
        }
        [HttpPost]
        public ActionResult CreateNotification(Notification Notification)
        {

            Notification.IsRead = "false";
            Notification.Date= DateTime.Now;
            context.Notifications.Add(Notification);
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }

        [HttpGet]
        public ActionResult UpdateNotification(int id)
        {
            ViewBag.name = "Bildirimler";

            var value = context.Notifications.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateNotification(Notification Notification)
        {
         
           
            var value = context.Notifications.Find(Notification.NotificationId);
            value.Description = Notification.Description;
            value.NotificationIcon = Notification.NotificationIcon;
            value.IsRead = "True";
            value.IconCirleColor = Notification.IconCirleColor;
            value.Date=DateTime.Now;
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }

        public ActionResult DeleteNotification(int id)
        {
            var value = context.Notifications.Find(id);
            context.Notifications.Remove(value);
            context.SaveChanges();
            return RedirectToAction("NotificationList");
        }


    }
}