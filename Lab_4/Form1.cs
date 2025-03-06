using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitField();
        }

        private Graphics graphics;
        private int res, steps;
        private bool[,] field;
        private int rows, cols;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                StartGame();
            else
                timer1.Stop();
        }
        private void InitField()
        {
            steps = 0;
            res = (int)CellSize.Value;
            rows = pictureBox1.Height / res;
            cols = pictureBox1.Width / res;
            field = new bool[cols, rows];
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.Beige);
            steps = 0;
            Steps.Text = Convert.ToString(steps);
        }
        private void StartGame()
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            steps++;
            Steps.Text = Convert.ToString(steps);
            NewGen();
            DrawField();
        }
        private int CountNeighbours(int x, int y)
        {
            int count = -Convert.ToInt32(field[x, y]);
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    count += Convert.ToInt32(field[col, row]);
                }
            }
            return count;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            InitField();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            InitField();

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(5) == 0;
                }
            }

            DrawField();
        }
        private bool CheckCell(int x, int y)
        {
            int nbrs = CountNeighbours(x, y);
            if (nbrs == 3)
            {
                return true;
            }
            if (field[x, y] && nbrs == 2)
            {
                return true;
            }
            return false;
        }
        private void DrawField()
        {
            graphics.Clear(Color.Beige);
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (field[x, y])
                        graphics.FillRectangle(Brushes.Tomato, x * res, y * res, res - 1, res - 1);
                }
            }
            pictureBox1.Refresh();
        }
        private void NewGen()
        {
            var newField = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    newField[x, y] = CheckCell(x, y);
                }
            }
            field = newField;   
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                var coursorCheck = x >= 0 && y >= 0 && x < cols && y < rows;
                if (coursorCheck)
                {
                    if (e.Button == MouseButtons.Left)
                        field[x, y] = true;
                    else
                        field[x, y] = false;
                }
                DrawField();
            }
        }
    }
}
