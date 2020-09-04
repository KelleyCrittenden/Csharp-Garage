// This File creates a template for making a Zero object. 

using System;

namespace Vehicle
{
    // Class name with 1 Parent Class and 1 Interface
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        // Properties that are specific to the Zero Object
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        // Method Charge Battery, needs to have name of method and name of property and what action the method does to the property, when this method is called it changes the current battery percentage property to 100
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        // Methods that console a string with the color property of instantiated zero object in program.cs
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero turns Left");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero doesn't stop");
        }
    }
}