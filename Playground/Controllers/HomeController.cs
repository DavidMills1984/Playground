﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Playground.WebUI.Controllers;

namespace Playground.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Gallery()
        {
            return View("Gallery");
        }
    }
}
