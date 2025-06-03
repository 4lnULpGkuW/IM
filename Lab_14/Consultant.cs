namespace Lab_14
{
    public enum ConsultantState { Free, Busy }

    public class Consultant : Agent
    {
        public ConsultantState State { get; private set; }
        public ClientData CurrentClient { get; private set; }
        private double serviceCompletionTime;
        private double mu_intensity;

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
            client.BeginService(currentTime);
            serviceCompletionTime = currentTime + ExpRandomValue(this.mu_intensity);
        }

        public override double GetNextEventTime()
        {
            return serviceCompletionTime;
        }

        public override void ProcessEvent(double currentTime, Form1 context)
        {
            if (State == ConsultantState.Busy && CurrentClient != null)
            {
                ClientData servedClient = CurrentClient;
                servedClient.CompleteService(currentTime);
                context.IncrementServedClientsCount();

                CurrentClient = null;
                State = ConsultantState.Free;
                serviceCompletionTime = double.MaxValue;

                if (context.clientQueue.Count > 0)
                {
                    ClientData clientFromQueue = context.clientQueue.Dequeue();
                    StartService(clientFromQueue, currentTime);
                }
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