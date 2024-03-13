using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminDashboardController : Controller
    {
        TasteContext context = new TasteContext();
        // GET: Dashboard

        public ActionResult Index()
        {
            var value = context.Products.ToList();
            
            ViewBag.v1 = context.Categories.Count();
            ViewBag.v2 = context.Products.Count();
            ViewBag.v3 = context.Chef.Count();
            ViewBag.v4 = context.Reservations.Where(x=>x.ReservationStatus=="true").Count();
            return View();
        }
        public PartialViewResult chartjs()
        {

            return PartialView();
        }
        public PartialViewResult Chart()
        {
            var value = context.Products.ToList();
            return PartialView(value);
        }
        public PartialViewResult progresbar()
        {
            ViewBag.mesaj = context.Contacts.Count();
            ViewBag.rezevasyon = context.Reservations.Count();
            ViewBag.müşteri = context.Testimonials.Count();
            ViewBag.social = context.SocialMedias.Count();
            ViewBag.productprice = Convert.ToInt32(context.Products.Max(x => x.Price));

            //ViewBag.productprice =  context.Products.Max(x => x.Price);
            return PartialView();
        }
        public PartialViewResult Rezervasyon()
        {
            var value = context.Reservations.Take(5).ToList();
            return PartialView(value);
        }
        public PartialViewResult Mesajlar()
        {
            var value = context.Contacts.Take(5).ToList();
            return PartialView(value);
        }

    }
   
}