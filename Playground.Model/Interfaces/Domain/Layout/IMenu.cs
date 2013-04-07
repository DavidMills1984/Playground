using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground.Model.Interfaces
{
    public interface IMenu
    {
        List<IMenuItem> Items { get; }
    }
}
