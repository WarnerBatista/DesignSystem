namespace TransportManagement.Strategies
{
    public class PremiumStrategy : ICostStrategy
    {
        public double Calculate(double distance) => distance * 2.0;
    }
}
