using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    [AllowAnonymous]
    //Anasayfa
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext();
        // GET: Default
        public ActionResult Index()
        {
            var value = context.Sliders.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbarInfo()
        {
            ViewBag.phone = context.Addresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = context.Addresses.Select(x => x.Email).FirstOrDefault();
            ViewBag.description = context.Addresses.Select(x => x.Description).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialNavbarInfoSocialMedia()
        {
            var value = context.SocialMedias.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialNavbar()
        {

            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            var value = context.Sliders.ToList();
            return PartialView(value);
        
        }
        public PartialViewResult PartialAbout()
        {
            ViewBag.title = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = context.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.ImageUrl = context.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            
          var value = context.Products.ToList();
          return PartialView(value);
        }
        public PartialViewResult PartialMenufirstrow()
        {
            var value = context.Products.ToList();
            return PartialView(value);
            
        }
        public PartialViewResult PartialTestimonial()
        {

            var value = context.Testimonials.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialChef()
        {
            var value = context.Chef.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialInfo()
        {
            return PartialView();
        }
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialOpenDayHour()
        {
            var value = context.openDayHours.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialSocialMedia()
        {
            var value = context.SocialMedias.ToList();
            return PartialView(value);
        }
    }
}