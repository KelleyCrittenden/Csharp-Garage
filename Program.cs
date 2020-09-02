using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla electricCar = new Tesla();
            electricCar.BatteryKWh = 101.1;
            electricCar.MainColor = "Black";
            electricCar.MaximumOccupancy = "5";

            Ram offRoadTruck = new Ram();
            offRoadTruck.FuelCapacity = 99.9;
            offRoadTruck.MainColor = "Red";
            offRoadTruck.MaximumOccupancy = "4";

            Cessna plane = new Cessna();
            plane.FuelCapacity = 88.8;
            plane.MainColor = "White";
            plane.MaximumOccupancy = "8";

            Zero electricMotorcycle = new Zero();
            electricMotorcycle.BatteryKWh = 77.7;
            electricMotorcycle.MainColor = "Blue";
            electricMotorcycle.MaximumOccupancy = "1";

            electricCar.Drive();
            electricCar.Turn();
            electricCar.Stop();
            Console.WriteLine("-------");

            electricMotorcycle.Drive();
            electricMotorcycle.Turn();
            electricMotorcycle.Stop();
            Console.WriteLine("-------");

            offRoadTruck.Drive();
            offRoadTruck.Turn();
            offRoadTruck.Stop();
            Console.WriteLine("-------");

            plane.Turn();
            plane.Drive();
            plane.Stop();

        }
    }
}