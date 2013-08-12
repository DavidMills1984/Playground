using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;

namespace Playground.Model.Concrete
{
    public class MenuItem
    {
        public virtual string Action { get; set; }
        public virtual string Controller { get; set; }
        public virtual string Title { get; set; }
        public virtual List<MenuItem> SubItems { get; set; }
    }
}
