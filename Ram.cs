using System;

namespace Vehicle
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

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