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
        internal double lambda_clientFlow;
        internal double mu_serviceIntensity;
        internal int N_consultants;

        internal List<Consultant> consultants;
        internal Queue<ClientData> clientQueue;
        internal List<ClientData> allClientsEverCreated;

        private ArrivalGenerator arrivalGeneratorAgent;
        private List<Agent> eventSchedulingAgents;

        private double currentTime;
        private int servedClientsCount;

        public Form1()
        {
            InitializeComponent();
            consultants = new List<Consultant>();
            clientQueue = new Queue<ClientData>();
            allClientsEverCreated = new List<ClientData>();
            eventSchedulingAgents = new List<Agent>();
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
                lambda_clientFlow = (double)ClientFlow.Value;
                mu_serviceIntensity = (double)ServiceIntensity.Value;
                N_consultants = (int)NumOfConsultants.Value;

                if (lambda_clientFlow <= 0 || mu_serviceIntensity <= 0 || N_consultants <= 0)
                {
                    MessageBox.Show("Please enter positive values for flow, intensity, and number of consultants.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InitializeSimulation();

                timer1.Start();
                button1.Text = "Stop Simulation";
            }
        }

        private void InitializeSimulation()
        {
            Agent.ResetActiveAgentIds();
            ClientData.ResetClientIds();
            currentTime = 0;
            servedClientsCount = 0;

            consultants.Clear();
            clientQueue.Clear();
            allClientsEverCreated.Clear();
            eventSchedulingAgents.Clear();

            for (int i = 0; i < N_consultants; i++)
            {
                var c = new Consultant(mu_serviceIntensity);
                consultants.Add(c);
                eventSchedulingAgents.Add(c);
            }

            arrivalGeneratorAgent = new ArrivalGenerator(lambda_clientFlow);
            eventSchedulingAgents.Add(arrivalGeneratorAgent);

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

            UpdateUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double minNextEventTime = double.MaxValue;
            Agent nextAgentToProcess = null;

            foreach (Agent agent in eventSchedulingAgents)
            {
                double agentEventTime = agent.GetNextEventTime();
                if (agentEventTime < minNextEventTime)
                {
                    minNextEventTime = agentEventTime;
                    nextAgentToProcess = agent;
                }
            }

            if (nextAgentToProcess == null || minNextEventTime == double.MaxValue)
            {
                timer1.Stop();
                button1.Text = "Start Simulation";
                MessageBox.Show($"Simulation ended at time {currentTime:F2}.", "Simulation Status");
                return;
            }

            currentTime = minNextEventTime;
            nextAgentToProcess.ProcessEvent(currentTime);

            if (nextAgentToProcess is ArrivalGenerator generator)
            {
                ClientData newClient = generator.LastClientArrived;
                allClientsEverCreated.Add(newClient);

                Consultant freeConsultant = consultants.FirstOrDefault(c => c.State == ConsultantState.Free);
                if (freeConsultant != null)
                {
                    freeConsultant.StartService(newClient, currentTime);
                }
                else
                {
                    newClient.Status = ClientStatus.WaitingInQueue;
                    clientQueue.Enqueue(newClient);
                }
            }
            else if (nextAgentToProcess is Consultant consultant)
            {
                servedClientsCount++;
                consultant.LastClientServed.Status = ClientStatus.Served_Departed;

                if (clientQueue.Count > 0)
                {
                    ClientData nextClient = clientQueue.Dequeue();
                    consultant.StartService(nextClient, currentTime);
                }
            }

            UpdateUI();
        }
        private void UpdateUI()
        {
            Served.Text = servedClientsCount.ToString();
            Queued.Text = clientQueue.Count.ToString();
            Time.Text = String.Format("{0:0.00}", currentTime);

            dataGridView1.Rows.Clear();

            foreach (var consultant in consultants)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["EntityType"].Value = "Consultant";
                dataGridView1.Rows[rowIndex].Cells["EntityID"].Value = consultant.Id;
                dataGridView1.Rows[rowIndex].Cells["EntityStatus"].Value = consultant.GetStatus();
            }

            if (arrivalGeneratorAgent != null)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["EntityType"].Value = "ArrivalGen";
                dataGridView1.Rows[rowIndex].Cells["EntityID"].Value = arrivalGeneratorAgent.Id;
                dataGridView1.Rows[rowIndex].Cells["EntityStatus"].Value = arrivalGeneratorAgent.GetStatus();
            }

            foreach (var client in clientQueue)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["EntityType"].Value = "Client";
                dataGridView1.Rows[rowIndex].Cells["EntityID"].Value = client.Id;
                dataGridView1.Rows[rowIndex].Cells["EntityStatus"].Value = client.GetStatus();
            }
        }
    }
}