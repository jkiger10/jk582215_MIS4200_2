﻿using System.Web;
using System.Web.Mvc;

namespace jk582215_MIS4200_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
