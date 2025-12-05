namespace VehicleManagement.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string licensePlate, int capacity, bool hasSideCar) : base(licensePlate, capacity)
        {
            HasSideCar = hasSideCar;
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * (HasSideCar ? 0.05 : 0.03);
        }
    }
}
