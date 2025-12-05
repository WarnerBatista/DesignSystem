using TransportManagement.Strategies;

namespace TransportManagement.Transports
{
    public class SeaTransport : Transport
    {
        private const int BaseFee = 50;

        public SeaTransport(double distance, ICostStrategy strategy) : base(distance, strategy)
        {
        }

        public override double CalculateCost() => Strategy.Calculate(Distance) + BaseFee;
    }
}
