// This File creates a template for making a Tesla object, Sub/Child Class of vehicle

using System;

namespace Vehicle
{
    // Class name with 1 Parent Class and 1 Interface
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        // Properties specific to Tesla Object
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        // Method Charge Battery, needs to have name of method and name of property and what action the method does to the property, when this method is called it changes the current battery percentage property to 100
        public void ChargeBattery()

        {
            CurrentChargePercentage = 100;
        }

        //Over riding methods that are on the Parent/Base Class. Methods that console a string with the color property of instantiated tesla object in program.cs
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla turns Left");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla stops");
        }
    }
}