namespace RealStateManagement.Strategies
{
    public class StandardRentStrategy : IRentStrategy
    {
        public double Calculate(double basePrice, double size) => basePrice * size;
    }
}
