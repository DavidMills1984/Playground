using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground.Model.Interfaces
{
    public interface IMenuItem
    {
        string Action { get; set; }
        string Controller { get; set; }
        string Title { get; set; }
        List<IMenuItem> SubItems { get; set; }
    }
}
