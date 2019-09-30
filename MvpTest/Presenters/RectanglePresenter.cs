using MvpTest.Models;
using MvpTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpTest.Presenters
{
    public class RectanglePresenter
    {
        private readonly IRectangle view;

        public RectanglePresenter(IRectangle view)
        {
            this.view = view;
        }
        public void ClaculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Breadth = double.Parse(view.BreadthText);
            rectangle.Lenght = double.Parse(view.LengthText);
            view.AreaText = rectangle.CalculateArea().ToString();



        }
    }
}
