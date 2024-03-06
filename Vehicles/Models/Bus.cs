namespace Vehicles.Models;

public class Bus : Vehicle
{
    private const double FuelConsumptionModifier = 1.4;
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }
    public override string Drive(double distance)
    {
        if (FuelQuantity < distance * (FuelConsumption + FuelConsumptionModifier))
        {
            throw new ArgumentException($"{GetType().Name} needs refueling");
        }
        FuelQuantity -= distance * (FuelConsumption + FuelConsumptionModifier);
        return $"{GetType().Name} travelled {distance} km";
    }
    public string DriveEmpty(double distance)
    {
        if (FuelQuantity < distance * FuelConsumption)
        {
            throw new ArgumentException($"{GetType().Name} needs refueling");
        }
        FuelQuantity -= distance * FuelConsumption;
        return $"{GetType().Name} travelled {distance} km";
    }

}
