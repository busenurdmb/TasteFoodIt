using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminTestimonialController : Controller
    {
        // GET: AdminTestimonial
        TasteContext context = new TasteContext();

        public ActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial Testimonial)
        {
            context.Testimonials.Add(Testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");

        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = context.Testimonials.Find(id);
            context.Testimonials.Remove(values);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            var value = context.Testimonials.Find(Testimonial.TestimonialId);
            value.NameSurname= Testimonial.NameSurname;
            value.Title = Testimonial.Title;
            value.ImageUrl = Testimonial.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("TestimonialList");

        }
    }
}