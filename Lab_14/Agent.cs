using System;

namespace Lab_14
{
    public abstract class Agent
    {
        public int Id { get; protected set; }
        protected static int nextAgentId = 0;
        protected BankOffice office;

        public Agent(BankOffice officeContext)
        {
            Id = ++nextAgentId;
            this.office = officeContext;
        }

        public abstract double GetNextEventTime();
        public abstract void ProcessEvent(double currentTime);
        public abstract string GetStatus();

        public static void ResetActiveAgentIds()
        {
            nextAgentId = 0;
        }

        protected static Random rndShared = new Random();
        protected double ExpRandomValue(double rate)
        {
            if (rate <= 0) return double.MaxValue;
            return -Math.Log(rndShared.NextDouble()) / rate;
        }
    }
}