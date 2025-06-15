using Lab_14;
using System.Collections.Generic;

public class BankOffice
{
    public List<Consultant> Consultants { get; }
    public Queue<ClientData> ClientQueue { get; }
    public int ServedClientsCount { get; private set; }
    public double CurrentTime { get; set; }

    public BankOffice()
    {
        Consultants = new List<Consultant>();
        ClientQueue = new Queue<ClientData>();
        ServedClientsCount = 0;
        CurrentTime = 0;
    }

    public void IncrementServedCount()
    {
        ServedClientsCount++;
    }
}