﻿using System.Web;
using System.Web.Mvc;

namespace TasteFoodIt
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Proje bazında Authorization işlemi için
            filters.Add(new AuthorizeAttribute());

        }
    }
}
