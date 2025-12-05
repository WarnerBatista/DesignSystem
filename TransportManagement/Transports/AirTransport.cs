using TransportManagement.Strategies;

namespace TransportManagement.Transports
{
    public class AirTransport : Transport
    {
        private const int BaseFee = 100;

        public AirTransport(double distance, ICostStrategy strategy) : base(distance, strategy)
        {
        }

        public override double CalculateCost() => Strategy.Calculate(Distance) + BaseFee;
    }
}
