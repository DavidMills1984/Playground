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
        public PartialViewResult Menu()
        {
            MenuViewModel menuItems = new MenuViewModel(repository.Menu);

            return PartialView(menuItems);
        }
    }
}
