using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateCredit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double S = Convert.ToDouble(summaTB.Text);
            double P = Convert.ToDouble(procentTB.Text) / (100 * 12);
            double N = Convert.ToDouble(termTB.Text);
            double x = S * (P + (P / (Math.Pow((1 + P), N) - 1)));
            double I = S * P;
            double sumWithProcent = x * N;
            double resultSum = x * N;
            double procentValue = resultSum - S;

            monthlyTB.Text = x.ToString();
            procentITB.Text = I.ToString();
            resultSumTB.Text = resultSum.ToString();
            procentValueTB.Text = procentValue.ToString();
        }
    }
}
