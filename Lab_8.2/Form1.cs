using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private readonly string[] answers = new string[]
        {
            "It is certain", "It is decidedly so", "Without a doubt",
            "Yes — definitely", "You may rely on it",

            "As I see it, yes", "Most likely", "Outlook good",
            "Signs point to yes", "Yes",

            "Reply hazy, try again", "Ask again later", "Better not tell you now",
            "Cannot predict now", "Concentrate and ask again",

            "Don’t count on it", "My reply is no", "My sources say no",
            "Outlook not so good", "Very doubtful"
            };

        private void button1_Click(object sender, EventArgs e)
        {
            Answer.Text = answers[random.Next(answers.Length)];
            Answer.Left = (this.ClientSize.Width - Answer.Width) / 2;
        }
    }
}
