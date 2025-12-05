using VehicleManagement;
using VehicleManagement.Vehicles;

var fleetManager = new FleetManager();

var truck = new Truck("1234", 3, 10000);
var car = new Car("4321", 5, 4);
var motorcycleWithSideCar = new Motorcycle("1432", 3, true);
var motorcycle = new Motorcycle("3421", 2, false);

fleetManager.AddVehicle(truck);
fleetManager.AddVehicle(car);
fleetManager.AddVehicle(motorcycleWithSideCar);
fleetManager.AddVehicle(motorcycle);

fleetManager.ReportFuelConsumption(100);