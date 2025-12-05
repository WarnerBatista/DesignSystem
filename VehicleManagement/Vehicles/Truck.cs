namespace VehicleManagement.Vehicles
{
    internal class Truck : Vehicle
    {
        public int CargoWeight { get; set; }

        public Truck(string licensePlate, int capacity, int cargoWeight) : base(licensePlate, capacity)
        {
            CargoWeight = cargoWeight;
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * (0.2 + CargoWeight * 0.01);
        }
    }
}
