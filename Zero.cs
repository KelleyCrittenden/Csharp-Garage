using System;

namespace Vehicle
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

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