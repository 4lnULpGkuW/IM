using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int capacity, threshold, demand, supply, day, arrivals, shortage;
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                return;
            }
            day = 0;
            capacity = (int)numericUpDownCapacity.Value;
            threshold = (int)((double)capacity / 10.0 * (double)trackBarThreshold.Value);
            demand = (int)numericUpDownDemand.Value;
            supply = random.Next(0, capacity);
            foreach (var i in chart1.Series ) { i.Points.Clear(); }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            day++;

            chart1.Series[2].Points.AddXY(day, arrivals);
            labelArrivals.Text = arrivals.ToString();

            int dailyDemand = random.Next(demand / 2, demand * 2);
            int shipments;
            if (supply + arrivals >= shortage + dailyDemand)
                shipments = shortage + dailyDemand;
            else
                shipments = supply + arrivals;
            supply += arrivals - (shortage + dailyDemand);
            if (supply < 0)
            {
                shortage = -supply;
                supply = 0;
            }
            else shortage = 0;
            if (supply < threshold || shortage > 0)
                arrivals = random.Next(threshold, capacity + shortage);
            else arrivals = 0;

            chart1.Series[0].Points.AddXY(day, supply);
            chart1.Series[1].Points.AddXY(day, shipments);

            labelSupply.Text = supply.ToString();
            labelShipments.Text = shipments.ToString();
        }
    }
}
