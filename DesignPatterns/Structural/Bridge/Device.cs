namespace DesignPatterns.Structural.Bridge
{
    internal abstract class Device : IDevice
    {
        protected int _volume;

        protected int _channel;

        protected bool _enabled = false;

        public void Disable()
        {
            _enabled = false;
            Console.WriteLine("Device switched off.");
        }

        public void Enable()
        {
            _enabled = true;
            Console.WriteLine("Device switched on.");
        }

        public int GetChannel()
        {
            Console.WriteLine("Channel: " + _channel);
            return _channel;
        }

        public int GetVolume()
        {
            Console.WriteLine("Volume: " + _volume);
            return _volume;
        }

        public bool IsEnabled() => _enabled;

        public void SetChannel(int channel)
        {
            _channel = channel;
            Console.WriteLine("New channel: " + channel);
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine("New volume: " + volume);
        }
    }
}
