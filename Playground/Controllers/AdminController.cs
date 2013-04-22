using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Playground.WebUI.Controllers
{
    public class AdminController : BaseController
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Menus()
        {
            return View("MenuAdmin");
        }

    }
}
