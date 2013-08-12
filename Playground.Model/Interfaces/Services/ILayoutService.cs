using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Concrete;

namespace Playground.Model.Interfaces
{
    public interface ILayoutService
    {
        Menu GetMenu(string MenuType);
    }
}
