using RealStateManagement.Strategies;

namespace RealStateManagement.Properties
{
    public abstract class Property
    {
        public string Address { get; set; } = string.Empty;
        public double BasePrice { get; set; }
        public double Size { get; set; }

        protected IRentStrategy RentStrategy { get; set; }

        protected Property(double basePrice, double size, IRentStrategy rentStrategy)
        {
            BasePrice = basePrice;
            Size = size;
            RentStrategy = rentStrategy;
        }

        public abstract double CalculateRent();
    }
}
