using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double mean, var, empMean, empVar, errMean, errVar,
            chiSquare, binWidth, min, max;
        int samples, bins;
        List<double> xi = new List<double>();
        List<int> observedFreq;
        List<double> expectedFreq;
        private void button1_Click_1(object sender, EventArgs e)
        {
            mean = (double)Mean.Value;
            var = (double)Variance.Value;
            samples = (int)SampleSize.Value;

            GenNormDist();
            CalcStat();
            CalcChiSqr();
            ShowRes();
        }
        private void GenNormDist()
        {
            xi.Clear();
            Normal normalDist = new Normal(mean, Math.Sqrt(var));
            xi.AddRange(normalDist.Samples().Take(samples));
        }
        private void CalcStat()
        {
            empMean = xi.Average();
            empVar = xi.Select(x => x * x).Average() - empMean * empMean;

            errMean = Math.Abs(empMean - mean) / mean;
            errVar = Math.Abs(empVar - var) / var;
        }
        private void CalcChiSqr()
        {
            min = xi.Min();
            max = xi.Max();
            bins = (int)Math.Sqrt(samples);
            binWidth = (max - min) / bins;

            observedFreq = new List<int>(new int[bins]);
            expectedFreq = new List<double>(new double[bins]);

            foreach (var x in xi)
            {
                int bin = (int)((x - min) / binWidth);
                if (bin >= 0 && bin < bins)
                    observedFreq[bin]++;
            }

            for (int i = 0; i < bins; i++)
            {
                double binStart = min + i * binWidth;
                double binEnd = binStart + binWidth;
                expectedFreq[i] = (Normal.CDF(mean, Math.Sqrt(var), binEnd) - Normal.CDF(mean, Math.Sqrt(var), binStart)) * samples;
            }

            chiSquare = 0;
            for (int i = 0; i < bins; i++)
            {
                if (expectedFreq[i] > 0)
                    chiSquare += Math.Pow(observedFreq[i] - expectedFreq[i], 2) / expectedFreq[i];
            }
        }
        private void ShowRes()
        {
            labAverage.Text = Math.Round(empMean, 2).ToString();
            labVariance.Text = Math.Round(empVar, 2).ToString();
            errAverage.Text = $"{Math.Round(errMean * 100, 1)}%";
            errVariance.Text = $"{Math.Round(errVar * 100, 1)}%";
            Chi.Text = $"{Math.Round(chiSquare, 2)}";

            chart1.Series.Clear();

            var histSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Histogram")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue
            };

            for (int i = 0; i < bins; i++)
            {
                double binStart = min + i * binWidth;
                double binEnd = binStart + binWidth;
                histSeries.Points.AddXY((binStart + binEnd) / 2, observedFreq[i]);
            }

            chart1.Series.Add(histSeries);
        }
    }
}
