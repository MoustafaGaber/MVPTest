using MvpTest.Presenters;
using MvpTest.Views;
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
    public partial class frmCalaculator : Form,ICalculator
    {
        public frmCalaculator()
        {
            InitializeComponent();
        }

        public string TxtNumberOne { get => txtNumberOne.Text; set => txtNumberOne.Text=value; }
        public string TxtNumberTow { get => txtNumberTow.Text; set => txtNumberTow.Text = value;  }
        public string TxtResult { get => txtResult.Text; set => txtResult.Text = value; }

        CalculatorPresentere presenter;

        private void button1_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresentere(this);
            presenter.CalcSum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresentere(this);
            presenter.CalcSub();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresentere(this);
            presenter.Calcmulti();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresentere(this);
            presenter.CalcDivid();
        }
    }
}
