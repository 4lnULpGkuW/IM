using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double[] Dur = new double[3];
        public double[] Freq = new double[3];
        double[,] Matrix = { { -0.4, 0.3, 0.1 }, { 0.4, -0.8, 0.4 }, { 0.1, 0.4, -0.5 } };
        Random random = new Random();
        double time;
        int state, changes;

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                chart1.Series[0].Points.Clear();
                state = comboBox1.SelectedIndex;
                time = 0; changes = 0;
                Dur = new double[3];
                Freq = new double[3];
                timer1.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "sunny";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double lambda = -Matrix[state, state];
            double timeNext = time + -Math.Log(1 - random.NextDouble()) / lambda;

            double ran = random.NextDouble();
            int stateNext = state;
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i != state)
                {
                    sum += Matrix[state, i] / lambda;
                    if (ran < sum)
                    {
                        stateNext = i;
                        changes++;
                        break;
                    }
                }
            }

            Dur[state] += timeNext - time;

            state = stateNext;
            time = timeNext;

            ShowRes();
        }
        private void ShowRes()
        {
            double sumOfDur = Dur.Sum();
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 3; i++)
            {
                Freq[i] = Dur[i] / sumOfDur;
                chart1.Series[0].Points.AddXY(i, Freq[i]);
            }

            Day.Text = time.ToString("F2");
            Change.Text = changes.ToString();
        }
    }
}
