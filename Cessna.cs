using System;

namespace Vehicle
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {

        }

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