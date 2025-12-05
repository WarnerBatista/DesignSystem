namespace RealStateManagement.Strategies
{
    internal class StandardRentStrategy : IRentStrategy
    {
        public double Calculate(double basePrice, double size) => basePrice * size;
    }
}
