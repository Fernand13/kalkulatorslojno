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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(input1.Text);
            double lastValue = Convert.ToDouble(input2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "Sum":
                result = firstValue + lastValue;
                break;

                case "Min":
                result = firstValue - lastValue;
                break;

                case "Mul":
                result = firstValue * lastValue;
                break;

                case "Div":
                result = firstValue / lastValue;
                break;

                default:
                throw new Exception("Неизвестная операция");
            }

            Answer.Text = result.ToString();
        }
    }
}
