using TransportManagement.Strategies;
using TransportManagement.Types;

namespace TransportManagement
{
    public class TransportManager
    {
        private readonly TransportType _type;
        private readonly ICostStrategy _strategy;

        public TransportManager(TransportType type, ICostStrategy strategy)
        {
            _type = type;
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public string Process(double distance)
        {
            var transport = TransportFactory.Create(_type, distance, _strategy);

            var cost = transport.CalculateCost();
            return string.Format("The cost of {0} transport for the distance of {1} miles and tax {2} is {3}.", _type, transport.Distance, _strategy.GetType().Name.Replace("Strategy", ""), cost);
        }
    }
}
