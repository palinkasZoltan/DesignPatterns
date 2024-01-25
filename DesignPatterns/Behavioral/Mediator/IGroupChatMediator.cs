namespace DesignPatterns.Behavioral.Mediator
{
    internal interface IGroupChatMediator
    {
        void SendMessage(string message, User user);

        void RegisterUser(User user);
    }
}
