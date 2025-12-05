using RealStateManagement.Properties;
using RealStateManagement.Strategies;

namespace RealStateManagement
{
    internal static class PropertyFactory
    {
        public static Property Create(PropertyType type, double basePrice, double size, IRentStrategy strategy, object extraData)
        {
            return type switch
            {
                PropertyType.Apartment => new Apartment(basePrice, size, strategy, (int)extraData),
                PropertyType.House => new House(basePrice, size, strategy, (bool)extraData),
                PropertyType.Office => new OfficeSpace(basePrice, size, strategy, (int)extraData),
                _ => throw new NotSupportedException()
            };
        }
    }
}
