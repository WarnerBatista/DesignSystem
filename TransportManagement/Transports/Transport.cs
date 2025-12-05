using TransportManagement.Strategies;

namespace TransportManagement.Transports
{
    public abstract class Transport
    {
        public double Distance { get; set; }
        protected ICostStrategy Strategy;

        public Transport(double distance, ICostStrategy strategy)
        {
            Distance = distance;
            Strategy = strategy;
        }

        public abstract double CalculateCost();
    }
}
