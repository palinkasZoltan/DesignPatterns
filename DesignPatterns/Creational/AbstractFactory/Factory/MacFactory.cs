using DesignPatterns.Creational.AbstractFactory.Button;
using DesignPatterns.Creational.AbstractFactory.Checkbox;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    internal class MacFactory : IGUIFactory
    {
        public ICustomButton CreateButton()
        {
            return new MacButton();
        }

        public ICustomCheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
