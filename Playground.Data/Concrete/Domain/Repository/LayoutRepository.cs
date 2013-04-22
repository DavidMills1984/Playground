using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;

namespace Playground.Data.Concrete
{
    public class LayoutRepository : ILayoutRepository
    {
        public IMenu UserSideMenu { get; set; }
        public IMenu AdminSideMenu { get; set; }

        public LayoutRepository()
        {
            this.UserSideMenu = new Menu("UserSideMenu");
            this.AdminSideMenu = new Menu("AdminSideMenu");

        }

    }
}
