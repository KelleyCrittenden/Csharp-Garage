//File for Interface

namespace Vehicle
{

    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }

        public void RefuelTank();

    }
}