using RealStateManagement.Properties;

namespace RealStateManagement
{
    internal class RealStateManager
    {
        private List<Property> _properties { get; set; } = new();

        public void AddProperty(Property property)
        {
            _properties.Add(property);
        }

        public void ReportRents()
        {
            foreach (var property in _properties)
            {
                var rent = property.CalculateRent();

                Console.WriteLine("The rent for {0} is {1}", property.GetType().Name, rent);
            }
        }
    }
}
