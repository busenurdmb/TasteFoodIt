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
    public class ContactController : Controller
    {
        TasteContext context = new TasteContext();
        // GET: Contact
        public ActionResult Index()
        {
            string PageName = "İletişim";
            TempData["Page"] = PageName;
            return View();
        }
        public PartialViewResult PartialContactİnformation()
        {
            return PartialView();
        }
        public PartialViewResult PartialContactUs()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult Add(Contact p)
        {
            if (ModelState.IsValid)
            {
                p.SendDate = DateTime.Now;
                p.IsRead = false;
                var value = context.Contacts.Add(p);
                context.SaveChanges();
                return Json("OK"); // Başarılı bir şekilde eklendiğinde "OK" yanıtı döndürülür
            }
            // Eğer model geçersizse, hata mesajlarıyla birlikte hata yanıtı döndürülür
            return Json("Model validation failed.");
        }
    }
}