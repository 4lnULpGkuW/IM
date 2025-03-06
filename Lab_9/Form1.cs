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

namespace Lab_9
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

            double[] empProbs = new double[5];
            double avg = 0, var = 0, empAvg = 0, empVar = 0, chi = 0;

            for (int i = 0; i < 5; i++)
            {
                empProbs[i] = num[i] / (double)trls;
                chart1.Series[0].Points.AddXY(i + 1, empProbs[i]);
                avg += (i + 1) * probs[i];
                var += (i + 1) * (i + 1) * probs[i] - ((i + 1) * probs[i]) * ((i + 1) * probs[i]);
                empAvg += (i + 1) * empProbs[i];
                empVar += (i + 1) * (i + 1) * empProbs[i] - ((i + 1) * empProbs[i]) * ((i + 1) * empProbs[i]);
                chi += num[i] * num[i] / ((double)trls * probs[i]);
            }
            chi -= (double)trls;

            Average.Text = avg.ToString("F2");
            Variance.Text = var.ToString("F2");
            errAverage.Text = (Math.Abs(empAvg - avg) / avg * 100).ToString("F2") + "%";
            errVariance.Text = (Math.Abs(empVar - var) / var * 100).ToString("F2") + "%";
            Chi.Text = chi.ToString("F2");

            if (chi < 9.488)
                concl.Text = "✅";
            else
                concl.Text = "❌";
        }
    }
}
