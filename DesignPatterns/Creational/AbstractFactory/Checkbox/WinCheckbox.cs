namespace DesignPatterns.Creational.AbstractFactory.Checkbox
{
    internal class WinCheckbox : ICustomCheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Paint Windows checkbox.");
        }
    }
}
