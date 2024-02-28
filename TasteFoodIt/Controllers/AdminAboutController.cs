using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminAboutController : Controller
    {
        // GET: AdminAbout
        TasteContext context = new TasteContext();
      
        public ActionResult AboutList()
        {
            ViewBag.name = "Hakkımda";
            //string PageName = "Chef";
            //TempData["Page"] = PageName;
            var values = context.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            ViewBag.name = "Hakkımda";
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(About About)
        {
            context.Abouts.Add(About);
            context.SaveChanges();
            return RedirectToAction("AboutList");

        }
        public ActionResult DeleteAbout(int id)
        {
            var values = context.Abouts.Find(id);
            context.Abouts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            ViewBag.name = "Hakkımda";
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About About)
        {
          
            var value = context.Abouts.Find(About.AboutID);
            value.Title = About.Title;
            value.Description = About.Description;
            if (About.ImageUrl != null)
            {
                value.ImageUrl = "/Templates/tasteit-master/images/" + About.ImageUrl;
            }
           
            context.SaveChanges();
            return RedirectToAction("AboutList");

        }
    }
}