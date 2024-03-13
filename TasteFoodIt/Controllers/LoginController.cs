using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        TasteContext context=new TasteContext();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values = context.Admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username,false);
                Session["username"]=values.Username;
                Session["id"] = values.AdminId;
                Session["surname"] = values.Surname;
                Session["name"] = values.Name;
                Session["email"] = values.Email;
                Session["tel"] = values.Tel;
                Session["password"] = values.Password;
                Session["img"] = values.ImageUrl;


                return RedirectToAction("Index", "AdminProfile");
            }
            return View();

           
        }
      
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Index", "Default"); // veya başka bir sayfaya yönlendirme yapabilirsiniz.
        }

    }
}