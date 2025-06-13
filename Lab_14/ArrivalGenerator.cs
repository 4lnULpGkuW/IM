namespace Lab_14
{
    public class ArrivalGenerator : Agent
    {
        private double nextArrivalTime;
        private readonly double lambda;
        public ClientData LastClientArrived { get; private set; }

        public ArrivalGenerator(double lambdaRate) : base()
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
            this.LastClientArrived = new ClientData(currentTime);
            this.nextArrivalTime = currentTime + ExpRandomValue(this.lambda);
        }

        public override string GetStatus()
        {
            return $"Next arrival at {nextArrivalTime:F2}";
        }
    }
}