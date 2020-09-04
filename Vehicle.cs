// This is a Base/Parent Class for All Vehicles, contains properties that are redundant in all Sub/Child Classes

using System;

namespace Vehicle
{
    public class Vehicle
    {
        // Properties that are shared with Sub/Child classes
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        // Methods that can be used on Sub/Child Classes
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine("U-Turn");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Complete Stop");
        }

    }
}