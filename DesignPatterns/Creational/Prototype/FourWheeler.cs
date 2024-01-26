namespace DesignPatterns.Creational.Prototype
{
    internal class FourWheeler : IVehicle, IClonable
    {
        private bool _isRunning = false;

        private bool _areLightsOn = false;

        public double Fuel { get; set; } = 0;

        public double BrakeFluid { get; set; } = 0;

        public string LicensePlate { get; }

        public FourWheeler(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        public void Start()
        {
            _isRunning = true;
        }

        public void Stop()
        {
            _isRunning = false;
            _areLightsOn = false;
        }

        public void TurnLightsOff()
        {
            _areLightsOn = false;
        }

        public void TurnLightsOn()
        {
            _areLightsOn = true;
        }

        public void Refuel(double addedFuel)
        {
            Fuel += addedFuel;
        }

        public IClonable Clone()
        {
            return this.MemberwiseClone() as IClonable;
        }
    }
}
