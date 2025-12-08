using RealStateManagement.Strategies;

namespace RealStateManagement.Properties
{
    public class OfficeSpace : Property
    {
        public int NumberOfDesks { get; set; }

        public OfficeSpace(double basePrice, double size, IRentStrategy rentStrategy, int numberOfDesks) : base(basePrice, size, rentStrategy)
        {
            NumberOfDesks = numberOfDesks;
        }

        public override double CalculateRent() => RentStrategy.Calculate(BasePrice, Size) + (NumberOfDesks * 5);
    }
}
