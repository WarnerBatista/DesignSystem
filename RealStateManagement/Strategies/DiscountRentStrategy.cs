namespace RealStateManagement.Strategies
{
    public class DiscountRentStrategy : IRentStrategy
    {
        public double Calculate(double basePrice, double size) => basePrice * size * 0.8;
    }
}
