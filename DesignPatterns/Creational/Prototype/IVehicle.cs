namespace DesignPatterns.Creational.Prototype
{
    internal interface IVehicle
    {
        void Start();

        void Stop();

        void TurnLightsOn();

        void TurnLightsOff();

        void Refuel(double addedFuel);
    }
}
