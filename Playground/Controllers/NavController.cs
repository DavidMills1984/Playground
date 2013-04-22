using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Playground.Model.Interfaces;
using Playground.WebUI.Models.Concrete;

namespace Playground.WebUI.Controllers
{
    public class NavController : BaseController
    {
        private ILayoutRepository repository;

        public NavController(ILayoutRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Home()
        {
            MenuViewModel menuItems = new MenuViewModel(repository.UserSideMenu);

            return PartialView("Menu", menuItems);
        }

        public PartialViewResult Admin()
        {
            MenuViewModel menuItems = new MenuViewModel(repository.AdminSideMenu);

            return PartialView("Menu", menuItems);
        }
    }
}
