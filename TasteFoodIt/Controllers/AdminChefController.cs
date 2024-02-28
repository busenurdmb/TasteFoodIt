﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminChefController : Controller
    {
        // GET: AdminChef
        TasteContext context = new TasteContext();

        public ActionResult ChefList()
        {
            var values = context.Chef.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateChef()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateChef(Chef Chef)
        {
            context.Chef.Add(Chef);
            context.SaveChanges();
            return RedirectToAction("ChefList");

        }
        public ActionResult DeleteChef(int id)
        {
            var values = context.Chef.Find(id);
            context.Chef.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ChefList");
        }
        [HttpGet]
        public ActionResult UpdateChef(int id)
        {
            var value = context.Chef.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateChef(Chef Chef)
        {
            var value = context.Chef.Find(Chef.ChefId);
            value.NameSurname =Chef.NameSurname;
            value.Title =Chef.Title;
            value.ImageUrl =Chef.ImageUrl;
            value.Description = Chef.Description;
           context.SaveChanges();
            return RedirectToAction("ChefList");

        }
    }
}