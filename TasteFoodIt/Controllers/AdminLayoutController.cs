using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminLayoutController : Controller
    {
        TasteContext tasteContext = new TasteContext();
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            ViewBag.isim = Session["name"];
            ViewBag.img = Session["img"];
            ViewBag.notificationIsreadByFalseCount= tasteContext.Notifications.Where(x=>x.IsRead=="false").Count();
           var value= tasteContext.Notifications.Where(x=>x.IsRead== "false").ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialMessage()
        {

            ViewBag.contactIsreadByFalseCount = tasteContext.Contacts.Where(x => x.IsRead == false).Count();
            var value = tasteContext.Contacts.Where(x => x.IsRead == false).ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public ActionResult NotificationStatusChangeToTrue(int id)
        {
            var values = tasteContext.Notifications.Find(id);
            values.IsRead ="true";
            tasteContext.SaveChanges();
            return RedirectToAction("ProductList", "AdminProduct");
;        }
    }
}