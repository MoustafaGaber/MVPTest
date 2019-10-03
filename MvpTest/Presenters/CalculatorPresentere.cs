using MvpTest.Models;
using MvpTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvpTest.Presenters
{
    public class CalculatorPresentere
    {
        private readonly ICalculator view;

        public CalculatorPresentere(ICalculator view)
        {
            this.view = view;
        }
        Calculator calculator = new Calculator();
        //create method to connect between Model and it`s view
        public void ConnectBetweenModelAndView()
        {
            calculator.NumberOne = int.Parse(view.TxtNumberOne);
            calculator.NumberTow = int.Parse(view.TxtNumberTow);

        }

        public void CalcSum()
        {
            ConnectBetweenModelAndView();
            view.TxtResult = calculator.CalculateSummation().ToString();

        }
        public void CalcSub()
        {
            ConnectBetweenModelAndView();
            view.TxtResult = calculator.CalculateSubstraction().ToString();

        }

        public void Calcmulti()
        {
            ConnectBetweenModelAndView();
            view.TxtResult = calculator.CalculateMultiplication().ToString();

        }

        public void CalcDivid()
        {
            ConnectBetweenModelAndView();
            if(calculator.NumberTow==0)
            {
                MessageBox.Show("Error Division By 0");
            }
            else
            {
                view.TxtResult = calculator.CalculateDivision().ToString();

            }

        }
    }
}
