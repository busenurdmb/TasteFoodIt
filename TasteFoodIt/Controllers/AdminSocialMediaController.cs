using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entity;

namespace TasteFoodIt.Controllers
{
    public class AdminSocialMediaController : Controller
    {
        // GET: AdminSocialMedia
        TasteContext context = new TasteContext();
        
        public ActionResult SocialMediaList()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var value = context.SocialMedias.Find(socialMedia.SocialMediaId);
            value.PlatformName = socialMedia.PlatformName;
            value.IconUrl = socialMedia.IconUrl;
            value.RedirectUrl = socialMedia.RedirectUrl;
            value.Status = socialMedia.Status;
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public ActionResult StatusChangeSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            if (value.Status == true)
            {
                value.Status = false;
            }
            else
            {
                value.Status = true;
            }
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}