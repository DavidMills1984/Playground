﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;

namespace Playground.Data.Concrete
{
    public class MenuItem : IMenuItem
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Title { get; set; }
        public List<IMenuItem> SubItems { get; set; }
    }
}
