//File for Interface, No Logic, Always Public

namespace Vehicle
{

    public interface IGasVehicle
    {

        // Inherit public from Interface
        // Property among different classes that we can group objects by
        int CurrentTankPercentage { get; set; }

        // Method Defining what the class should do, not how... action of method located on class
        public void RefuelTank();

    }
}