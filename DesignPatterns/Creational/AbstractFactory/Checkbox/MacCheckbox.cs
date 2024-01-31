namespace DesignPatterns.Creational.AbstractFactory.Checkbox
{
    internal class MacCheckbox : ICustomCheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Paint Mac checkbox.");
        }
    }
}
