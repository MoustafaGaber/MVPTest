using MvpTest.Views;
using MvpTest.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvpTest
{
    public partial class Form1 : Form,IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText { get => textBox1.Text; set => textBox1.Text=value; }
        public string BreadthText { get => textBox2.Text; set => textBox2.Text = value; }
        public string AreaText { get => label3.Text; set => label3.Text = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.ClaculateArea();
        }
    }
}
