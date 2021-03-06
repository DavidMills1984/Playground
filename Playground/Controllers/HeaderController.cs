﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Playground.Model.Interfaces;

namespace Playground.WebUI.Controllers
{
    public class HeaderController : BaseController
    {
        //
        // GET: /Header/
        private IHeaderRepository headerRepo;

        public HeaderController(IHeaderRepository repo)
        {
            headerRepo = repo;
        }

        //Render partial view Header
        public PartialViewResult Header()
        {
            return PartialView(headerRepo);
        }

    }
}
