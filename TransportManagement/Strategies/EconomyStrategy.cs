namespace TransportManagement.Strategies
{
    public class EconomyStrategy : ICostStrategy
    {
        public double Calculate(double distance) => distance * 0.5;

    }
}
