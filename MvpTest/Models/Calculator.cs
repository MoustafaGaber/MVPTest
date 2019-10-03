using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpTest.Models
{
    public class Calculator
    {
        public int NumberOne { get; set; }
        public int NumberTow { get; set; }

        public int CalculateSummation()
        {
            return NumberOne + NumberTow;
        }

        public int CalculateSubstraction()
        {
            return NumberOne - NumberTow;
        }

        public int CalculateMultiplication()
        {
            return NumberOne * NumberTow;
        }

        public int CalculateDivision()
        {
            return NumberOne / NumberTow;
        }
    }
}
