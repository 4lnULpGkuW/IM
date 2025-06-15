using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class Form1 : Form
    {
        private BankOffice office;
        private List<Agent> eventSchedulingAgents;
        private double currentTime;
        private Agent agentForNextEvent;
        private double nextEventTime;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Start Simulation";
            }
            else
            {
                double lambda = (double)ClientFlow.Value;
                double mu = (double)ServiceIntensity.Value;
                int n = (int)NumOfConsultants.Value;

                if (lambda <= 0 || mu <= 0 || n <= 0)
                {
                    MessageBox.Show("Please enter positive values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InitializeSimulation(lambda, mu, n);

                timer1.Start();
                button1.Text = "Stop Simulation";
            }
        }

        private void InitializeSimulation(double lambda, double mu, int n)
        {
            this.office = new BankOffice();
            this.eventSchedulingAgents = new List<Agent>();

            Agent.ResetActiveAgentIds();
            ClientData.ResetClientIds();

            for (int i = 0; i < n; i++)
            {
                var consultant = new Consultant(mu, this.office);
                this.office.Consultants.Add(consultant);
                this.eventSchedulingAgents.Add(consultant);
            }

            var generator = new ArrivalGenerator(lambda, this.office);
            this.eventSchedulingAgents.Add(generator);

            if (dataGridView1.ColumnCount == 0)
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].HeaderText = "Entity Type";
                dataGridView1.Columns[0].Name = "EntityType";
                dataGridView1.Columns[1].HeaderText = "ID";
                dataGridView1.Columns[1].Name = "EntityID";
                dataGridView1.Columns[2].HeaderText = "Status";
                dataGridView1.Columns[2].Name = "EntityStatus";
            }

            FindNextEvent();
            UpdateUI();
        }
        private void FindNextEvent()
        {
            double minTime = double.MaxValue;
            this.agentForNextEvent = null;

            foreach (Agent agent in eventSchedulingAgents)
            {
                double agentEventTime = agent.GetNextEventTime();
                if (agentEventTime < minTime)
                {
                    minTime = agentEventTime;
                    this.nextEventTime = agentEventTime;
                    this.agentForNextEvent = agent;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            office.CurrentTime += 0.01;
            if (office.CurrentTime >= this.nextEventTime)
            {
                agentForNextEvent.ProcessEvent(nextEventTime);
                FindNextEvent();
            }
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (office == null) return;

            Served.Text = office.ServedClientsCount.ToString();
            Queued.Text = office.ClientQueue.Count.ToString();
            Time.Text = String.Format("{0:0.00}", office.CurrentTime);

            dataGridView1.Rows.Clear();

            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 200;

            foreach (var consultant in office.Consultants)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = "Consultant";
                row.Cells[1].Value = consultant.Id;
                row.Cells[2].Value = consultant.GetStatus();
                dataGridView1.Rows.Add(row);
            }

            foreach (var client in office.ClientQueue)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = "Client";
                row.Cells[1].Value = client.Id;
                row.Cells[2].Value = client.GetStatus();
                dataGridView1.Rows.Add(row);
            }
        }
    }
}