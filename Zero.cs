using System;

namespace Vehicle
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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