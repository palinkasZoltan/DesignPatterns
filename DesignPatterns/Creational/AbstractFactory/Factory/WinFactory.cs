using DesignPatterns.Creational.AbstractFactory.Button;
using DesignPatterns.Creational.AbstractFactory.Checkbox;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    internal class WinFactory : IGUIFactory
    {
        public ICustomButton CreateButton()
        {
            return new WinButton();
        }

        public ICustomCheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
