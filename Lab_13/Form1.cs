using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LabelFormat = "F2";
            chart1.Series[1].IsValueShownAsLabel = true;
            chart1.Series[1].LabelFormat = "F2";
        }

        const double drift = 0.01;
        const double volatility = 0.02;
        const double k = drift - 0.5 * volatility * volatility;
        int days, dayCounter;
        Random rnd = new Random();

        double CNYval, INRval;
        private void timer1_Tick(object sender, EventArgs e)
        {
            double a1 = rnd.NextDouble();
            double a2 = rnd.NextDouble();
            double GBM = Math.Sqrt(-2.0 * Math.Log(a1)) * Math.Cos(2.0 * Math.PI * a2);


            CNYval = CNYval * Math.Exp(k + volatility * GBM);
            INRval = INRval * Math.Exp(k + volatility * GBM);

            chart1.Series[0].Points.AddXY(dayCounter, CNYval);
            chart1.Series[1].Points.AddXY(dayCounter, INRval);
            dayCounter++;            
            if (days == dayCounter) { timer1.Stop(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dayCounter = 0;
            days = (int)Days.Value;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            CNYval = (double)CNY.Value;
            INRval = (double)INR.Value;

            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.AddXY(dayCounter, CNYval);
                chart1.Series[1].Points.AddXY(dayCounter, INRval);
                timer1.Start();
            }
        }
    }
}
