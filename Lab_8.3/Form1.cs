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

namespace Lab_8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            double[] probs = new double[5];
            int[] num = new int[5];

            int trls = (int)trials.Value;

            probs[0] = (double)prob1.Value;
            probs[1] = (double)prob2.Value;
            probs[2] = (double)prob3.Value;
            probs[3] = (double)prob4.Value;
            probs[4] = 1;

            for (int i = 0; i < 4; i++)
            {
                probs[4] -= probs[i];
            }

            prob5.Text = probs[4].ToString();

            for (int i = 0; i < trls; i++)
            {
                double randVal = random.NextDouble(),
                    val = 0;
                for (int k = 0; k < 5; k++)
                {
                    val += probs[k];
                    if (randVal < val)
                    {
                        num[k]++;
                        break;
                    }
                }
            }

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < 5; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, num[i] / (double)trls);
            }
        }
    }
}
