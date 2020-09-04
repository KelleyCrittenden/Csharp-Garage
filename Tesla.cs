using System;

namespace Vehicle
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()

        {
            CurrentChargePercentage = 100;
        }

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