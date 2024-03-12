using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminProductController : Controller
    {
      
        TasteContext context = new TasteContext();
        // GET: AdminProduct
        [Authorize]
        public ActionResult ProductList()
        {
            ViewBag.name = "Ürün";
            //var categories = (from x in context.Categories
            //                  select new
            //                  {
            //                      CategoryName = x.CategoryName,
            //                      CategoryId = x.CategoryId
            //                  }).ToList();

            //ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
            
            var values = context.Products.ToList();
            
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            ViewBag.name = "Ürün";
            List<SelectListItem> category = (from x in context.Categories.ToList()
                                             select new
                                             SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.Category = category;

            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Product Product)
        {

            Product.CategoryId = Product.Category.CategoryId;
            context.Products.Add(Product);
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }
        public ActionResult DeleteProduct(int id)
        {
            var values = context.Products.Find(id);
            context.Products.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> category = (from x in context.Categories.ToList()
                                             select new
                                             SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.Category = category;
            var value = context.Products.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product Product)
        {
            var value = context.Products.Find(Product.ProductId);
            value.ProductName = Product.ProductName;
            value.Description = Product.Description;
            if (Product.ImageUrl != null)
            {
            value.ImageUrl = "/Templates/tasteit-master/images/"+ Product.ImageUrl;
            }
            value.IsActive = Product.IsActive;
            value.CategoryId = Product.Category.CategoryId;
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }
    }
}