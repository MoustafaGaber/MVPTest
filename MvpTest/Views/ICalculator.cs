using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpTest.Views
{
   public interface ICalculator
    {
        string TxtNumberOne { get; set; }
        string TxtNumberTow { get; set; }
        string TxtResult { get; set; }


    }
}
