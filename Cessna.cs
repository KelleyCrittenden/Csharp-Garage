// This File creates a template for making a Cessna object, Sub/Child Class of vehicle

using System;

namespace Vehicle
{
    // Class name with 1 Parent Class and 1 Interface
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        // Properties specific to Cessna Object
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        // Method Refuel Tank, needs to have name of method and name of property and what action the method does to the property, when this method is called it changes Current Tank Percentage Property to 100
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        // Over riding methods that are on the Parent/Base Class. Methods that console a string with the color property of instantiated Cessna object in program.cs
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Wooosh");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna turns Right");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna doesn't stop");
        }
    }
}