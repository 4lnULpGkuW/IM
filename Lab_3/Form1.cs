using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < NUM_CELLS; i++)
            {
                dataGridView1.Columns.Add("", "");
            }
        }

        private int genNum;
        private bool[] curGen = new bool[NUM_CELLS + 2];
        private bool[] rules = new bool[8];

        const int NUM_CELLS = 16;

        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            dataGridView1.Rows.Clear();
            genNum = 0;
            for (int i = 0; i < NUM_CELLS; i++)
                if (random.NextDouble() <= 0.5)
                    curGen[i + 1] = true;
                else
                    curGen[i + 1] = false;

            curGen[0] = curGen[NUM_CELLS];
            curGen[NUM_CELLS + 1] = curGen[1];

            SetRule();
            timer1.Start();
        }

        private void SetRule()
        {
            string binNum = Convert.ToString((short)Rule.Value, 2);
            int length = binNum.Length;

            for (int i = 0; i < 8 - length; i++)
                binNum = '0' + binNum;

            for (int i = 0; i < 8; i++)
                if (binNum[i] == '1')
                    rules[i] = true;
                else
                    rules[i] = false;

        }

        private void Draw()
        {
            dataGridView1.Rows.Add();
            for (int i = 0; i < NUM_CELLS; i++)
                if (curGen[i + 1])
                    dataGridView1[i, genNum].Style.BackColor = Color.Blue;
        }

        private int GetKey(int i)
        {
            int comb = 0;

            if (curGen[i - 1]) comb += 4;
            if (curGen[i]) comb += 2;
            if (curGen[i + 1]) comb += 1;

            return comb;
        }
        private void NextGen()
        {
            bool[] newGen = new bool[NUM_CELLS + 2];
            for (int i = 0; i < NUM_CELLS; i++)
            {
                var key = GetKey(i + 1);
                newGen[i + 1] = rules[key];
            }
            newGen[0] = newGen[NUM_CELLS];
            newGen[NUM_CELLS + 1] = newGen[1];

            curGen = newGen;
            genNum++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            NextGen();
        }
    }
}
