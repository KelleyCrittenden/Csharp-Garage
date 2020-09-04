using System;
using System.Collections.Generic;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.CurrentChargePercentage = 10;

            Zero fx = new Zero();
            fx.CurrentChargePercentage = 15;

            Tesla modelS = new Tesla();
            modelS.CurrentChargePercentage = 20;

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This method should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram,
                cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This Method should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            // Tesla modelS = new Tesla();
            // modelS.BatteryKWh = 101.1;
            // modelS.MainColor = "Black";
            // modelS.MaximumOccupancy = "5";

            // Ram SLT = new Ram();
            // SLT.FuelCapacity = 99.9;
            // SLT.MainColor = "Red";
            // SLT.MaximumOccupancy = "4";

            // Cessna mx410 = new Cessna();
            // mx410.FuelCapacity = 88.8;
            // mx410.MainColor = "White";
            // mx410.MaximumOccupancy = "8";

            // Zero fxs = new Zero();
            // fxs.BatteryKWh = 77.7;
            // fxs.MainColor = "Blue";
            // fxs.MaximumOccupancy = "1";

            // modelS.Drive();
            // modelS.Turn();
            // modelS.Stop();
            // Console.WriteLine("-------");

            // fxs.Drive();
            // fxs.Turn();
            // fxs.Stop();
            // Console.WriteLine("-------");

            // SLT.Drive();
            // SLT.Turn();
            // SLT.Stop();
            // Console.WriteLine("-------");

            // mx410.Turn();
            // mx410.Drive();
            // mx410.Stop();

        }
    }
}