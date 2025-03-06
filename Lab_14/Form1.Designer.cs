namespace Lab_14
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Served = new System.Windows.Forms.Label();
            this.Queued = new System.Windows.Forms.Label();
            this.ClientFlow = new System.Windows.Forms.NumericUpDown();
            this.NumOfConsultants = new System.Windows.Forms.NumericUpDown();
            this.ServiceIntensity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfConsultants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ServiceIntensity);
            this.panel1.Controls.Add(this.NumOfConsultants);
            this.panel1.Controls.Add(this.ClientFlow);
            this.panel1.Controls.Add(this.Queued);
            this.panel1.Controls.Add(this.Served);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 270);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of consultants";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client flow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service intensity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Served";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Queued";
            // 
            // Served
            // 
            this.Served.AutoSize = true;
            this.Served.Location = new System.Drawing.Point(189, 156);
            this.Served.Name = "Served";
            this.Served.Size = new System.Drawing.Size(14, 16);
            this.Served.TabIndex = 6;
            this.Served.Text = "0";
            // 
            // Queued
            // 
            this.Queued.AutoSize = true;
            this.Queued.Location = new System.Drawing.Point(189, 191);
            this.Queued.Name = "Queued";
            this.Queued.Size = new System.Drawing.Size(14, 16);
            this.Queued.TabIndex = 7;
            this.Queued.Text = "0";
            // 
            // ClientFlow
            // 
            this.ClientFlow.DecimalPlaces = 2;
            this.ClientFlow.Location = new System.Drawing.Point(192, 49);
            this.ClientFlow.Name = "ClientFlow";
            this.ClientFlow.Size = new System.Drawing.Size(79, 22);
            this.ClientFlow.TabIndex = 8;
            this.ClientFlow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NumOfConsultants
            // 
            this.NumOfConsultants.Location = new System.Drawing.Point(192, 84);
            this.NumOfConsultants.Name = "NumOfConsultants";
            this.NumOfConsultants.Size = new System.Drawing.Size(79, 22);
            this.NumOfConsultants.TabIndex = 9;
            this.NumOfConsultants.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ServiceIntensity
            // 
            this.ServiceIntensity.DecimalPlaces = 2;
            this.ServiceIntensity.Location = new System.Drawing.Point(192, 119);
            this.ServiceIntensity.Name = "ServiceIntensity";
            this.ServiceIntensity.Size = new System.Drawing.Size(79, 22);
            this.ServiceIntensity.TabIndex = 10;
            this.ServiceIntensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start/Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfConsultants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ServiceIntensity;
        private System.Windows.Forms.NumericUpDown NumOfConsultants;
        private System.Windows.Forms.NumericUpDown ClientFlow;
        private System.Windows.Forms.Label Queued;
        private System.Windows.Forms.Label Served;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}

