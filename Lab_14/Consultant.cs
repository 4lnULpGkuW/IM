namespace Lab_14
{
    public enum ConsultantState { Free, Busy }

    public class Consultant : Agent
    {
        public ConsultantState State { get; private set; }
        public ClientData CurrentClient { get; private set; }
        private double serviceCompletionTime;
        private readonly double mu_intensity;

        public Consultant(double serviceIntensity, BankOffice office) : base(office)
        {
            State = ConsultantState.Free;
            this.mu_intensity = serviceIntensity;
            serviceCompletionTime = double.MaxValue;
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
            if (State == ConsultantState.Busy)
                return serviceCompletionTime;
            if (office.ClientQueue.Count > 0)
                return office.CurrentTime;
            return double.MaxValue;
        }

        public override void ProcessEvent(double currentTime)
        {
            if (State == ConsultantState.Busy)
            {
                this.CurrentClient.Status = ClientStatus.Served_Departed;
                this.office.IncrementServedCount();
                this.CurrentClient = null;
                this.State = ConsultantState.Free;
                this.serviceCompletionTime = double.MaxValue;
            }

            if (this.office.ClientQueue.Count > 0)
            {
                ClientData nextClient = this.office.ClientQueue.Dequeue();
                this.StartService(nextClient, currentTime);
            }
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