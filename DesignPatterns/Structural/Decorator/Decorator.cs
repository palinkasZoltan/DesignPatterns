namespace DesignPatterns.Structural.Decorator
{
    abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override string Operation()
        {
            if(this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
