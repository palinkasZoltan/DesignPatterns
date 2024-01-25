namespace DesignPatterns.Structural.Bridge
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void Mute()
        {
            _device.SetVolume(0);
            Console.WriteLine("Device is muted.");
        }
    }
}
