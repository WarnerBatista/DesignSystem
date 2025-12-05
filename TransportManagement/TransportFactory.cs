using TransportManagement.Strategies;
using TransportManagement.Transports;
using TransportManagement.Types;

namespace TransportManagement
{
    public static class TransportFactory
    {
        public static Transport Create(TransportType type, double distance, ICostStrategy strategy)
        {
            return type switch
            {
                TransportType.Air => new AirTransport(distance, strategy),
                TransportType.Sea => new SeaTransport(distance, strategy),
                TransportType.Road => new RoadTransport(distance, strategy),
                _ => throw new ArgumentException("Invalid transport type")
            };
        }
    }
}
