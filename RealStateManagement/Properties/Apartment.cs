using RealStateManagement.Strategies;

namespace RealStateManagement.Properties
{
    internal class Apartment : Property
    {
        public int FloorNumber { get; set; }

        public Apartment(double basePrice, double size, IRentStrategy rentStrategy, int floorNumber) : base(basePrice, size, rentStrategy)
        {
            FloorNumber = floorNumber;
        }

        public override double CalculateRent() => RentStrategy.Calculate(BasePrice, Size) + (FloorNumber * 2);
    }
}
