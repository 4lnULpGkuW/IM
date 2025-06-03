using System.Linq;

namespace Lab_14
{
    public class ArrivalGenerator : Agent
    {
        private double nextArrivalTime;
        private double lambda;

        public ArrivalGenerator(double lambdaRate) : base()
        {
            this.lambda = lambdaRate;
            this.nextArrivalTime = ExpRandomValue(this.lambda);
        }

        public override double GetNextEventTime()
        {
            return nextArrivalTime;
        }

        public override void ProcessEvent(double currentTime, Form1 context)
        {
            ClientData newClient = new ClientData(currentTime);
            context.AddNewClientToList(newClient);

            Consultant freeConsultant = context.consultants.FirstOrDefault(c => c.State == ConsultantState.Free);
            if (freeConsultant != null)
            {
                freeConsultant.StartService(newClient, currentTime);
            }
            else
            {
                newClient.EnterQueue();
                context.clientQueue.Enqueue(newClient);
            }
            this.nextArrivalTime = currentTime + ExpRandomValue(this.lambda);
        }

        public override string GetStatus()
        {
            return $"Generates next client at {nextArrivalTime:F2}";
        }
    }
}