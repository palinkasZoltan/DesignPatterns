namespace DesignPatterns.Structural.Bridge
{
    internal class RemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if(_device.IsEnabled())
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }
        }

        public void VolumeDown()
        {
            if (_device.IsEnabled())
            {
                _device.SetVolume(_device.GetVolume() - 10);
            }
        }

        public void VolumeUp()
        {
            if (_device.IsEnabled())
            {
                _device.SetVolume(_device.GetVolume() + 10);
            }
        }

        public void ChannelDown()
        {
            if (_device.IsEnabled())
            {
                _device.SetChannel(_device.GetChannel() - 1);
            }
        }

        public void ChannelUp()
        {
            if (_device.IsEnabled())
            {
                _device.SetChannel(_device.GetChannel() + 1);
            }
        }
    }
}
