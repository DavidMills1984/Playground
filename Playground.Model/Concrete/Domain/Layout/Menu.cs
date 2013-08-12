using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;


namespace Playground.Model.Concrete
{
    public class Menu
    {
        public virtual List<MenuItem> Items { get; set; }
    }
}
