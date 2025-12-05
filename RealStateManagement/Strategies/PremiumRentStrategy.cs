namespace RealStateManagement.Strategies
{
    internal class PremiumRentStrategy : IRentStrategy
    {
        public double Calculate(double basePrice, double size) => basePrice * size * 1.5;
    }
}
