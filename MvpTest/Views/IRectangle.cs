﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpTest.Views
{
    public interface IRectangle
    {
         string LengthText { get; set; }
         string BreadthText { get; set; }
         string AreaText { get; set; }

    }
}
