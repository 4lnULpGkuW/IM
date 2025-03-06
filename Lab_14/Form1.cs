using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double lambda, mu;
        int n;
        double queue, busy, served, curTime;
        private Random rnd = new Random();
        private double ExpRandomValue(double rate)
        {
            return -Math.Log(rnd.NextDouble()) / rate;
        }
        private double NextEventTime(double currentTime)
        {
            double arrivalTime = ExpRandomValue(lambda);
            double serviceTime = (busy > 0) ? ExpRandomValue(mu * busy) : double.MaxValue;

            if (arrivalTime < serviceTime)
            {
                if (busy < n) busy++;
                else queue++;

                return currentTime + arrivalTime;
            }
            else
            {
                if (queue > 0) queue--;
                else busy--;

                served++;
                return currentTime + serviceTime;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            curTime = NextEventTime(curTime);

            Served.Text = served.ToString();
            Queued.Text = queue.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Consultant";
            dataGridView1.Columns[1].HeaderText = "Client";

            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = "Consultant";
                dataGridView1.Rows[i].Cells[1].Value = (i < busy) ? "Busy" : "Free";
            }

            for (int i = 0; i < queue; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[n + i].Cells[1].Value = "Queued";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                lambda = (double)ClientFlow.Value;
                mu = (double)ServiceIntensity.Value;
                n = (int)NumOfConsultants.Value;
                queue = 0; busy = 0; served = 0; curTime = 0;
                timer1.Start();
            }
        }
    }
}
