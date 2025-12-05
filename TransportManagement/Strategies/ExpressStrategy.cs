namespace TransportManagement.Strategies
{
    public class ExpressStrategy : ICostStrategy
    {
        public double Calculate(double distance) => distance * 1.0;

    }
}
