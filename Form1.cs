using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Sum_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(input1.Text);
            double lastValue = Convert.ToDouble(input2.Text);
            double result = firstValue + lastValue;
            Answer.Text = result.ToString();
        }

        private void Min_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(input1.Text);
            double lastValue = Convert.ToDouble(input2.Text);
            double result = firstValue - lastValue;
            Answer.Text = result.ToString();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(input1.Text);
            double lastValue = Convert.ToDouble(input2.Text);
            double result = firstValue * lastValue;
            Answer.Text = result.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(input1.Text);
            double lastValue = Convert.ToDouble(input2.Text);
            double result = firstValue / lastValue;
            Answer.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
