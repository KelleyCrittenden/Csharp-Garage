using System;
using System.Collections.Generic;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            // using classes to instantiate new obejcts
            Zero fxs = new Zero();
            fxs.BatteryKWh = 77.7;
            fxs.MainColor = "Blue";
            fxs.MaximumOccupancy = "1";
            fxs.CurrentChargePercentage = 10;

            Zero fx = new Zero();
            fxs.BatteryKWh = 77.7;
            fxs.MainColor = "Purple";
            fxs.MaximumOccupancy = "1";
            fx.CurrentChargePercentage = 15;

            Tesla modelS = new Tesla();
            modelS.BatteryKWh = 101.1;
            modelS.MainColor = "Black";
            modelS.MaximumOccupancy = "5";
            modelS.CurrentChargePercentage = 20;

            Ram SLT = new Ram();
            SLT.FuelCapacity = 99.9;
            SLT.MainColor = "Red";
            SLT.MaximumOccupancy = "4";

            Cessna mx410 = new Cessna();
            mx410.FuelCapacity = 88.8;
            mx410.MainColor = "White";
            mx410.MaximumOccupancy = "8";

            // using interface to create list 

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                // objects to be used in list
                fx,
                fxs,
                modelS
            };
            // looping over with for each to grab the current charge off obejct. 
            // Writing out current charge percentage from objects
            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }
            // looping over with for each to grab the current charge off obejct and apply the Charge Battery method to it. 

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This method should charge the vehicle to 100%
                ev.ChargeBattery();
            }
            // looping over with for each to grab the New current tank percentage off obejct. 
            // Writing out the new current charge percentage from object
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }
            Console.WriteLine("-------");

            /***********************************************/

            // using interface to create list 

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()

            {
                // objects to be used in list
                SLT,
                mx410
            };

            // looping over with for each to grab the current tank percentage off obejct. 
            // Writing out current tank percentage from objects

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
            // looping over with for each to grab the current charge off obejct and apply the Refuel Tank method to it.
            foreach (IGasVehicle gv in gasVehicles)
            {
                // This Method should completely refuel the gas tank
                gv.RefuelTank();
            }
            // looping over with for each to grab the New current tank percentage off obejct. 
            // Writing out the new current charge percentage from object
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
            Console.WriteLine("-------");

            // Calling methods on instantiated objects

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine("-------");

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine("-------");

            fx.Drive();
            fx.Turn();
            fx.Stop();
            Console.WriteLine("-------");

            SLT.Drive();
            SLT.Turn();
            SLT.Stop();
            Console.WriteLine("-------");

            mx410.Turn();
            mx410.Drive();
            mx410.Stop();

        }
    }
}