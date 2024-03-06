using System;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using Vehicles.Models;

namespace Vehicles;

public class StartUp
{
    static void Main()
    {
        string[] carTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] truckTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] busTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Car car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
        Truck truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));
        Bus bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            try
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(double.Parse(command[2])));
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                }
                else if (command[0] == "DriveEmpty")
                {
                    Console.WriteLine(bus.DriveEmpty(double.Parse(command[2])));
                }

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


        }

        Console.WriteLine($"Car: {car.FuelQuantity:f2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
    }
}
















