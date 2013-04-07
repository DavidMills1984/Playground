using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;

namespace Playground.Data.Concrete
{
    public class LayoutRepository : ILayoutRepository
    {
        public IMenu Menu { get; private set; }

        public LayoutRepository()
        {
            Menu = new Menu();
        }
    }
}
