using VehicleManagement.Vehicles;

namespace VehicleManagement
{
    internal class FleetManager
    {
        private List<Vehicle> _vehicles { get; set; } = new();

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public void ReportFuelConsumption(double distance)
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                var consumption = vehicle.CalculateFuelConsumption(distance);

                Console.WriteLine("The consumption of fuel from {0}: {1} is {2} Liters", vehicle.GetType().Name, vehicle.LicensePlate, consumption);
            }
        }
    }
}
