using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Playground.Model.Interfaces;

namespace Playground.WebUI.Models.Concrete
{
    public class MenuViewModel
    {
        private IMenu menuModel;

        public List<IMenuItem> MenuItems { get; set; }
        
        public MenuViewModel(IMenu menu)
        {
            menuModel = menu;
            MenuItems = menuModel.Items;
        }
    }
}