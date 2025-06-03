namespace Lab_14
{
    public enum ClientStatus { Arrived, WaitingInQueue, BeingServed, Served_Departed }

    public class ClientData
    {
        private static int nextId = 0;
        public int Id { get; private set; }
        public ClientStatus Status { get; private set; }
        public double ArrivalTime { get; private set; }
        public double ServiceStartTime { get; private set; }
        public double ServiceEndTime { get; private set; }

        public ClientData(double arrivalTime)
        {
            Id = System.Threading.Interlocked.Increment(ref nextId);
            ArrivalTime = arrivalTime;
            Status = ClientStatus.Arrived;
            ServiceStartTime = -1;
            ServiceEndTime = -1;
        }

        public void EnterQueue()
        {
            Status = ClientStatus.WaitingInQueue;
        }

        public void BeginService(double currentTime)
        {
            Status = ClientStatus.BeingServed;
            ServiceStartTime = currentTime;
        }

        public void CompleteService(double currentTime)
        {
            Status = ClientStatus.Served_Departed;
            ServiceEndTime = currentTime;
        }

        public string GetStatus()
        {
            return Status.ToString();
        }

        public static void ResetClientIds()
        {
            nextId = 0;
        }
    }
}