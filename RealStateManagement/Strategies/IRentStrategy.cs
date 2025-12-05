namespace RealStateManagement.Strategies
{
    internal interface IRentStrategy
    {
        double Calculate(double basePrice, double size);
    }
}
