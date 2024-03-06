namespace Vehicles.Models;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
        TankCapacity = tankCapacity;
    }

    public double FuelQuantity
    {
        get => fuelQuantity;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel quantity must be a positive number");
            }
            fuelQuantity = value;
        }
    }
    public double FuelConsumption
    {
        get => fuelConsumption;
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Fuel consumption must be a positive number");
            }

            fuelConsumption = value;
        }
    }
    public double TankCapacity
    {
        get => tankCapacity;
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Tank capacity must be a positive number");
            }
            tankCapacity = value;
            if (FuelQuantity > TankCapacity)
            {
                FuelQuantity = 0;
            }
        }
    }


    public virtual string Drive(double distance)
    {
        if (FuelQuantity < distance * FuelConsumption)
        {
            throw new ArgumentException($"{GetType().Name} needs refueling");
        }
        FuelQuantity -= distance * FuelConsumption;
        return $"{GetType().Name} travelled {distance} km";
    }
    public virtual void Refuel(double fuelAmount)
    {
        if (fuelAmount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (FuelQuantity + fuelAmount > TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
        }

        FuelQuantity += fuelAmount;
    }

}
