using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Team
        {
            public string Name { get; set; }
            public double Luck { get; set; }
            public int Score { get; set; }
            public Team(string name, double luck)
            {
                Name = name; Luck = luck; Score = 0; 
            }

        }

        Random random = new Random();
        List<Team> teams = new List<Team>();
        private void Form1_Load(object sender, EventArgs e)
        {
            teams.Add(new Team("Team AAA", 2.1));
            teams.Add(new Team("Team BBB", 1.9));
            teams.Add(new Team("Team CCC", 1.7));
            teams.Add(new Team("Team DDD", 1.5));
            teams.Add(new Team("Team EEE", 1.3));
            teams.Add(new Team("Team FFF", 1.1));
            teams.Add(new Team("Team GGG", 0.9));
            teams.Add(new Team("Team HHH", 0.7));
        }
        private void button1_Click(object sender, EventArgs e)
        {

            List<Team> shuffledTeams = teams.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < shuffledTeams.Count - 1; i += 2)
            {
                Team first = shuffledTeams[i];
                Team second = shuffledTeams[i + 1];

                first.Score += GeneratePoints(first.Luck);
                second.Score += GeneratePoints(second.Luck);
            }

            ShowGrid();
        }

        private int GeneratePoints(double luck)
        {
            int m = 0;
            double L = Math.Exp(-luck);
            double p = 1.0;

            do
            {
                m++;
                p *= random.NextDouble();
            } while (p > L);

            return m - 1;
        }
        private void ShowGrid()
        {

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "POS";
            dataGridView1.Columns[1].HeaderText = "Team";
            dataGridView1.Columns[2].HeaderText = "Score";

            foreach (Team t in teams.OrderByDescending(t => t.Score).ToList())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, t.Name, t.Score);
            }
        }
    }
}
