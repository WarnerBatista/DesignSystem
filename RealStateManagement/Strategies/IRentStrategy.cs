namespace RealStateManagement.Strategies
{
    public interface IRentStrategy
    {
        double Calculate(double basePrice, double size);
    }
}
