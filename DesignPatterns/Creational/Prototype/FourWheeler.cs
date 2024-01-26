namespace DesignPatterns.Creational.Prototype
{
    internal class FourWheeler : IVehicle, IClonable
    {
        private bool _isRunning = false;

        private bool _areLightsOn = false;

        private FourWheeler _vehicle;

        public int vehicleHashCode { get => _vehicle.GetHashCode(); }

        public double Fuel { get; set; } = 0;

        public double BrakeFluid { get; set; } = 0;

        public string LicensePlate { get; }

        public FourWheeler(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        public void CreateInnerVehicle()
        {
            _vehicle = new FourWheeler("ABC111");
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

        //public IClonable DeepCopy()
        //{
        //    // All of the reference types must be ICLonable
        //    FourWheeler
        //}
    }
}
