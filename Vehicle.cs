using System;

namespace Vehicle
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

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