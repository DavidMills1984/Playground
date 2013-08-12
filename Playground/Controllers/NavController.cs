using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Playground.Model.Interfaces;
using Playground.Model.Concrete;


namespace Playground.WebUI.Controllers
{
    public class NavController : BaseController
    {
        private ILayoutService _LayoutService;

        /// <summary>
        /// Contructor for a controller which defines logic to be used and views to
        /// return to user for all navigation operations
        /// </summary>
        /// <param name="layoutService"></param>
        public NavController(ILayoutService layoutService)
        {
            _LayoutService = layoutService;
        }

        /// <summary>
        /// Returns a partial view containing menu items needed for the users side menu
        /// </summary>
        /// <returns></returns>
        public PartialViewResult Home()
        {
            Menu menu = _LayoutService.GetMenu("UserSideMenu");

            return PartialView("Menu", menu);
        }
        
        /// <summary>
        /// Returns a partial view containing menu items needed for the admin menu
        /// </summary>
        /// <returns></returns>
        public PartialViewResult Admin()
        {
            Menu menu = _LayoutService.GetMenu("AdminSideMenu");

            return PartialView("Menu", menu);
        }
    }
}
