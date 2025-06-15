using System.Linq;

namespace Lab_14
{
    public class ArrivalGenerator : Agent
    {
        private double nextArrivalTime;
        private readonly double lambda;

        public ArrivalGenerator(double lambdaRate, BankOffice office) : base(office)
        {
            this.lambda = lambdaRate;
            this.nextArrivalTime = ExpRandomValue(this.lambda);
        }

        public override double GetNextEventTime()
        {
            return nextArrivalTime;
        }

        public override void ProcessEvent(double currentTime)
        {
            var newClient = new ClientData(currentTime);
            newClient.Status = ClientStatus.WaitingInQueue;
            this.office.ClientQueue.Enqueue(newClient);
            this.nextArrivalTime = currentTime + ExpRandomValue(this.lambda);
        }

        public override string GetStatus()
        {
            return $"Next arrival at {nextArrivalTime:F2}";
        }
    }
}