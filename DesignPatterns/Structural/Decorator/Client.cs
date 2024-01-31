namespace DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public void ClientMethod(Component component)
        {
            Console.WriteLine("RESULT:" + component.Operation());
        }
    }
}
