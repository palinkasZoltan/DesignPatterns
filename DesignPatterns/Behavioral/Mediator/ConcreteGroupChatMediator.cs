using System.Linq;

namespace DesignPatterns.Behavioral.Mediator
{
    internal class ConcreteGroupChatMediator : IGroupChatMediator
    {
        private List<User> Users = new List<User>();

        public void RegisterUser(User user)
        {
            if (!Users.Contains(user))
            {
                Users.Add(user);
                user.Mediator = this;
            }
        }

        public void SendMessage(string message, User user)
        {
            Users.Where(currentUser => currentUser != user).ToList().ForEach(user => user.Receive(message));
            //foreach (User u in Users)
            //{
            //    if (u != user)
            //    {
            //        u.Receive(message);
            //    }
            //}
        }
    }
}
