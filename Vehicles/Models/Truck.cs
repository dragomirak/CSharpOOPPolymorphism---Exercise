namespace Vehicles.Models;

public class Truck : Vehicle
{
    private const double FuelConsumptionModifier = 1.6;
    private const double RefuelModifier = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption + FuelConsumptionModifier, tankCapacity)
    {
    }

    public override void Refuel(double fuelAmount)
    {
        if (fuelAmount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (FuelQuantity + fuelAmount > TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
        }

        FuelQuantity += fuelAmount * RefuelModifier;
    }
}
