﻿using DublinFoodReivew.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DublinFoodReivew.Controllers
{
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "French")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);
        }
    }
}