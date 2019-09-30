using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpTest.Models
{
    public class Rectangle
    {
        public double Lenght { get; set; }
        public double Breadth { get; set; }

        public double CalculateArea()
        {
            return Lenght * Breadth;
        }
    }
}
