using DesignPatterns.Creational.AbstractFactory.Button;
using DesignPatterns.Creational.AbstractFactory.Checkbox;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    internal interface IGUIFactory
    {
        ICustomButton CreateButton();

        ICustomCheckbox CreateCheckbox();
    }
}
