namespace Lab_9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.concl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Chi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errVariance = new System.Windows.Forms.Label();
            this.errAverage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Variance = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trials = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.prob5 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.concl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Chi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.errVariance);
            this.panel1.Controls.Add(this.errAverage);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Variance);
            this.panel1.Controls.Add(this.Average);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.trials);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.prob5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prob4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prob3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prob2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prob1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 426);
            this.panel1.TabIndex = 0;
            // 
            // concl
            // 
            this.concl.AutoSize = true;
            this.concl.Location = new System.Drawing.Point(215, 376);
            this.concl.Name = "concl";
            this.concl.Size = new System.Drawing.Size(14, 16);
            this.concl.TabIndex = 36;
            this.concl.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "<   9.48";
            // 
            // Chi
            // 
            this.Chi.AutoSize = true;
            this.Chi.Location = new System.Drawing.Point(119, 376);
            this.Chi.Name = "Chi";
            this.Chi.Size = new System.Drawing.Size(14, 16);
            this.Chi.TabIndex = 34;
            this.Chi.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "ChiSquared";
            // 
            // errVariance
            // 
            this.errVariance.AutoSize = true;
            this.errVariance.Location = new System.Drawing.Point(173, 343);
            this.errVariance.Name = "errVariance";
            this.errVariance.Size = new System.Drawing.Size(26, 16);
            this.errVariance.TabIndex = 32;
            this.errVariance.Text = "0%";
            // 
            // errAverage
            // 
            this.errAverage.AutoSize = true;
            this.errAverage.Location = new System.Drawing.Point(173, 308);
            this.errAverage.Name = "errAverage";
            this.errAverage.Size = new System.Drawing.Size(26, 16);
            this.errAverage.TabIndex = 31;
            this.errAverage.Text = "0%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "err.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "err.";
            // 
            // Variance
            // 
            this.Variance.AutoSize = true;
            this.Variance.Location = new System.Drawing.Point(94, 343);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(14, 16);
            this.Variance.TabIndex = 28;
            this.Variance.Text = "0";
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(94, 308);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(14, 16);
            this.Average.TabIndex = 27;
            this.Average.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Variance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Average";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trials
            // 
            this.trials.Location = new System.Drawing.Point(91, 230);
            this.trials.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.trials.Name = "trials";
            this.trials.Size = new System.Drawing.Size(120, 22);
            this.trials.TabIndex = 11;
            this.trials.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trials";
            // 
            // prob5
            // 
            this.prob5.DecimalPlaces = 2;
            this.prob5.Enabled = false;
            this.prob5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob5.Location = new System.Drawing.Point(91, 192);
            this.prob5.Name = "prob5";
            this.prob5.Size = new System.Drawing.Size(120, 22);
            this.prob5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prob 5";
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 2;
            this.prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob4.Location = new System.Drawing.Point(91, 155);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(120, 22);
            this.prob4.TabIndex = 7;
            this.prob4.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prob 4";
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 2;
            this.prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob3.Location = new System.Drawing.Point(91, 116);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(120, 22);
            this.prob3.TabIndex = 5;
            this.prob3.Value = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prob 3";
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 2;
            this.prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob2.Location = new System.Drawing.Point(91, 78);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(120, 22);
            this.prob2.TabIndex = 3;
            this.prob2.Value = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prob 2";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 2;
            this.prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob1.Location = new System.Drawing.Point(91, 39);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(120, 22);
            this.prob1.TabIndex = 1;
            this.prob1.Value = new decimal(new int[] {
            33,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(265, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(523, 426);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown trials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown prob5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label concl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Chi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errVariance;
        private System.Windows.Forms.Label errAverage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Variance;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

