//File for Interface

namespace Vehicle
{

    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; set; }

        public void ChargeBattery();

    }
}