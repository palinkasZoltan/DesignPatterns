namespace DesignPatterns.Structural.Decorator
{
    internal class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component) 
        { 
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
