namespace DesignPatterns.Structural.Composite
{
    internal class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        public void ClientCode2(Component comp1, Component comp2)
        {
            if (comp1.IsComposite())
            {
                comp1.Add(comp2);
            }

            Console.WriteLine($"RESULT: {comp1.Operation()}\n");
        }
    }
}
