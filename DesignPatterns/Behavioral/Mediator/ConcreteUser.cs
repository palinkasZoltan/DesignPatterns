namespace DesignPatterns.Behavioral.Mediator
{
    internal class ConcreteUser : User
    {
        public ConcreteUser(string Name) : base(Name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": Received Message:" + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": Sending Message=" + message + "\n");
            Mediator.SendMessage(message, this);
        }
    }
}
