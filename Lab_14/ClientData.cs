namespace Lab_14
{
    public enum ClientStatus { Arrived, WaitingInQueue, BeingServed, Served_Departed }

    public class ClientData
    {
        private static int nextId = 0;
        public int Id { get; private set; }
        public ClientStatus Status { get; set; }
        public double ArrivalTime { get; private set; }

        public ClientData(double arrivalTime)
        {
            Id = System.Threading.Interlocked.Increment(ref nextId);
            ArrivalTime = arrivalTime;
            Status = ClientStatus.Arrived;
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