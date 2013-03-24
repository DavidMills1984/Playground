using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground.Model.Interfaces
{
    interface IMenuItem
    {
        public string Reference { get; set; }
        public string Title { get; set; }
        public List<IMenuItem> SubItems { get; set; }
    }
}
