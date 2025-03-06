using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._1
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
            if (random.Next(2) > 0)
                Answer.Text = "Yes";
            else
                Answer.Text = "No";
            Answer.Left = (this.ClientSize.Width - Answer.Width) / 2;
        }
    }
}
