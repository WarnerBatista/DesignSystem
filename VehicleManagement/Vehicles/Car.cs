namespace VehicleManagement.Vehicles
{
    internal class Car : Vehicle
    {
        public int Passengers { get; set; }

        public Car(string licensePlate, int capacity, int passengers) : base(licensePlate, capacity)
        {
            Passengers = passengers;
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * (0.1 + Passengers * 0.01);
        }
    }
}
