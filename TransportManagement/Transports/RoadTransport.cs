using TransportManagement.Strategies;

namespace TransportManagement.Transports
{
    public class RoadTransport : Transport
    {
        private const int BaseFee = 100;

        public RoadTransport(double distance, ICostStrategy strategy) : base(distance, strategy)
        {
        }

        public override double CalculateCost() => Strategy.Calculate(Distance) + BaseFee;
    }
}
