namespace VehicleManagement.Vehicles
{
    internal abstract class Vehicle
    {
        public string LicensePlate { get; set; } = string.Empty;
        public int Capacity { get; set; }

        protected Vehicle(string licensePlate, int capacity)
        {
            LicensePlate = licensePlate;
            Capacity = capacity;
        }

        public abstract double CalculateFuelConsumption(double distance);
    }
}
