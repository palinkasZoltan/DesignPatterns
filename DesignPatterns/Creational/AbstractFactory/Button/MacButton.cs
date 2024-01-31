namespace DesignPatterns.Creational.AbstractFactory.Button
{
    internal class MacButton : ICustomButton
    {
        public void Paint()
        {
            Console.WriteLine("Paint Mac button.");
        }
    }
}
