using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminAddressController : Controller
    {
        // GET: AdminAddress
        TasteContext context = new TasteContext();
      
        public ActionResult AddressList()
        {
            var values = context.Addresses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAddress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAddress(Address Address)
        {
            context.Addresses.Add(Address);
            context.SaveChanges();
            return RedirectToAction("AddressList");

        }
        public ActionResult DeleteAddress(int id)
        {
            var values = context.Addresses.Find(id);
            context.Addresses.Remove(values);
            context.SaveChanges();
            return RedirectToAction("AddressList");
        }
        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            var value = context.Addresses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAddress(Address Address)
        {
            var value = context.Addresses.Find(Address.AddressId);
            value.Description = Address.Description;
            value.Email = Address.Email;
            value.Phone = Address.Phone;
            
            context.SaveChanges();
            return RedirectToAction("AddressList");

        }
    }
}