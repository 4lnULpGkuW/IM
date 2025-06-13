namespace Lab_14
{
    public enum ConsultantState { Free, Busy }

    public class Consultant : Agent
    {
        public ConsultantState State { get; private set; }
        public ClientData CurrentClient { get; private set; }
        public ClientData LastClientServed { get; private set; }
        private double serviceCompletionTime;
        private readonly double mu_intensity;

        public Consultant(double serviceIntensity) : base()
        {
            State = ConsultantState.Free;
            serviceCompletionTime = double.MaxValue;
            this.mu_intensity = serviceIntensity;
        }

        public void StartService(ClientData client, double currentTime)
        {
            CurrentClient = client;
            State = ConsultantState.Busy;
            client.Status = ClientStatus.BeingServed;
            serviceCompletionTime = currentTime + ExpRandomValue(this.mu_intensity);
        }

        public override double GetNextEventTime()
        {
            return serviceCompletionTime;
        }

        public override void ProcessEvent(double currentTime)
        {
            this.LastClientServed = this.CurrentClient;
            this.CurrentClient = null;
            this.State = ConsultantState.Free;
            this.serviceCompletionTime = double.MaxValue;
        }

        public override string GetStatus()
        {
            if (State == ConsultantState.Busy && CurrentClient != null)
            {
                return $"Consultant {Id}: Busy with Client {CurrentClient.Id}";
            }
            return $"Consultant {Id}: {State.ToString()}";
        }
    }
}