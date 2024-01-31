namespace DesignPatterns.Creational.AbstractFactory.Button
{
    internal class WinButton : ICustomButton
    {
        public void Paint()
        {
            Console.WriteLine("Paint Windows button.");
        }
    }
}
