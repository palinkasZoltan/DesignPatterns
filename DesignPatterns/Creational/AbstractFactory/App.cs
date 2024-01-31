using DesignPatterns.Creational.AbstractFactory.Button;
using DesignPatterns.Creational.AbstractFactory.Checkbox;
using DesignPatterns.Creational.AbstractFactory.Factory;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class App
    {
        private IGUIFactory _factory;

        private ICustomButton _button;

        private ICustomCheckbox _checkbox;

        public App(IGUIFactory factory)
        {
            _factory = factory;
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}
