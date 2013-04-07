using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;

namespace Playground.Data.Concrete
{
    public class LayoutRepository : ILayoutRepository
    {
        public IMenu Menu { get; set; }

        public LayoutRepository()
        {
            this.Menu = new Menu();

        }

    }
}
