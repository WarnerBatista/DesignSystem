using RealStateManagement.Strategies;

namespace RealStateManagement.Properties
{
    internal class House : Property
    {
        public bool HasGarden { get; set; }

        public House(double basePrice, double size, IRentStrategy rentStrategy, bool hasGarden) : base(basePrice, size, rentStrategy)
        {
            HasGarden = hasGarden;
        }

        public override double CalculateRent() => RentStrategy.Calculate(BasePrice, Size) + (HasGarden ? 50 : 0);
    }
}
