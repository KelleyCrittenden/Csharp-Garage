// This File creates a template for making a Ram object. 

using System;

namespace Vehicle
{
    // Class name with 2 interfaces attatched
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {

        // Properties specific to Ram Object
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        // Method Refuel Tank, needs to have name of method and name of property and what action the method does to the property, when this method is called it changes Current Tank Percentage Property to 100

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        // Methods that console a string with the color property of instantiated Ram object in program.cs

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Ram turns Right");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram doesn't stop");
        }

    }
}