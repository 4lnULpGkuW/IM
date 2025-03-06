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

namespace Lab_2
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

        const double k = 0.02;
        int days, dayCounter;
        Random rnd = new Random();

        decimal CNYval, INRval;
        private void timer1_Tick(object sender, EventArgs e)
        {
            CNYval = CNYval * (decimal)(1 + k * (rnd.NextDouble() - 0.5));
            INRval = INRval * (decimal)(1 + k * (rnd.NextDouble() - 0.5));
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
            CNYval = (decimal)CNY.Value;
            INRval = (decimal)INR.Value;

            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.AddXY(dayCounter, CNYval);
                chart1.Series[1].Points.AddXY(dayCounter, INRval);
                timer1.Start();
            }
        }
    }
}
