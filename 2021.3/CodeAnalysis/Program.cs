
var vehicles = new List<Vehicle>
{
    new Boat(), new Car(), new Motorcycle()
};

foreach (var vehicle in vehicles)
{
    // Debug, Navigate To on vehicle, jump to correct class
    Console.WriteLine(vehicle.ToString());
}

public class Vehicle { }

public class Car : Vehicle { }

public class Motorcycle : Vehicle { }

public class Boat : Vehicle { }