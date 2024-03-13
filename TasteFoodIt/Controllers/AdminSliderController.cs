using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminSliderController : Controller
    {
        // GET: AdminSlider
        TasteContext context = new TasteContext();

        public ActionResult SliderList()
        {
            ViewBag.name = "Slider";
            //string PageName = "Chef";
            //TempData["Page"] = PageName;
            var values = context.Sliders.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSlider()
        {
            ViewBag.name = "Slider";
            return View();
        }
        [HttpPost]
        public ActionResult CreateSlider(Slider Slider)
        {
            context.Sliders.Add(Slider);
            context.SaveChanges();
            return RedirectToAction("SliderList");

        }
        public ActionResult DeleteSlider(int id)
        {
            var values = context.Sliders.Find(id);
            context.Sliders.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SliderList");
        }
        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            ViewBag.name = "Slider";
            var value = context.Sliders.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSlider(Slider Slider)
        {

            var value = context.Sliders.Find(Slider.SliderID);
            value.Title = Slider.Title;
            value.Title2 = Slider.Title2;
            value.ResturantName = Slider.ResturantName;
            if (Slider.ImageUrl != null)
            {
                value.ImageUrl = "/Templates/tasteit-master/images/" + Slider.ImageUrl;
            }

            context.SaveChanges();
            return RedirectToAction("SliderList");

        }
    }
}