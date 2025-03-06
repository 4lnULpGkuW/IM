namespace Lab_11
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.errVariance = new System.Windows.Forms.Label();
            this.errAverage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labVariance = new System.Windows.Forms.Label();
            this.labAverage = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SampleSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Variance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Mean = new System.Windows.Forms.NumericUpDown();
            this.Chi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(291, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(497, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Chi);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.errVariance);
            this.panel1.Controls.Add(this.errAverage);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.labVariance);
            this.panel1.Controls.Add(this.labAverage);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SampleSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Variance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Mean);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 294);
            this.panel1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "ChiSquared";
            // 
            // errVariance
            // 
            this.errVariance.AutoSize = true;
            this.errVariance.Location = new System.Drawing.Point(210, 215);
            this.errVariance.Name = "errVariance";
            this.errVariance.Size = new System.Drawing.Size(26, 16);
            this.errVariance.TabIndex = 45;
            this.errVariance.Text = "0%";
            // 
            // errAverage
            // 
            this.errAverage.AutoSize = true;
            this.errAverage.Location = new System.Drawing.Point(210, 180);
            this.errAverage.Name = "errAverage";
            this.errAverage.Size = new System.Drawing.Size(26, 16);
            this.errAverage.TabIndex = 44;
            this.errAverage.Text = "0%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 43;
            this.label14.Text = "err.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "err.";
            // 
            // labVariance
            // 
            this.labVariance.AutoSize = true;
            this.labVariance.Location = new System.Drawing.Point(126, 215);
            this.labVariance.Name = "labVariance";
            this.labVariance.Size = new System.Drawing.Size(14, 16);
            this.labVariance.TabIndex = 41;
            this.labVariance.Text = "0";
            // 
            // labAverage
            // 
            this.labAverage.AutoSize = true;
            this.labAverage.Location = new System.Drawing.Point(126, 180);
            this.labAverage.Name = "labAverage";
            this.labAverage.Size = new System.Drawing.Size(14, 16);
            this.labAverage.TabIndex = 40;
            this.labAverage.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 39;
            this.label16.Text = "Variance";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "Average";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample size";
            // 
            // SampleSize
            // 
            this.SampleSize.Location = new System.Drawing.Point(116, 106);
            this.SampleSize.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.SampleSize.Name = "SampleSize";
            this.SampleSize.Size = new System.Drawing.Size(120, 22);
            this.SampleSize.TabIndex = 4;
            this.SampleSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variance";
            // 
            // Variance
            // 
            this.Variance.Location = new System.Drawing.Point(116, 67);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(120, 22);
            this.Variance.TabIndex = 2;
            this.Variance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mean";
            // 
            // Mean
            // 
            this.Mean.Location = new System.Drawing.Point(116, 30);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(120, 22);
            this.Mean.TabIndex = 0;
            // 
            // Chi
            // 
            this.Chi.AutoSize = true;
            this.Chi.Location = new System.Drawing.Point(126, 248);
            this.Chi.Name = "Chi";
            this.Chi.Size = new System.Drawing.Size(14, 16);
            this.Chi.TabIndex = 47;
            this.Chi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Mean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SampleSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Variance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label errVariance;
        private System.Windows.Forms.Label errAverage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labVariance;
        private System.Windows.Forms.Label labAverage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Chi;
    }
}

