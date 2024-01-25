namespace DesignPatterns.Behavioral.Mediator
{
    internal abstract class User
    {
        protected string Name;

        public IGroupChatMediator Mediator { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }
}
