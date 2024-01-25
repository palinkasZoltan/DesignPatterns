using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Observer;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Observer pattern test code
            //BaggageHandler provider = new();
            //ArrivalsMonitor observer1 = new("BaggageClaimMonitor1");
            //ArrivalsMonitor observer2 = new("SecurityExit");

            //provider.BaggageStatus(712, "Detroit", 3);
            //observer1.Subscribe(provider);

            //provider.BaggageStatus(712, "Kalamazoo", 3);
            //provider.BaggageStatus(400, "New York-Kennedy", 1);
            //provider.BaggageStatus(712, "Detroit", 3);
            //observer2.Subscribe(provider);

            //provider.BaggageStatus(511, "San Francisco", 2);
            //provider.BaggageStatus(712);
            //observer2.Unsubscribe();

            //provider.BaggageStatus(400);
            //provider.LastBaggageClaimed();
            #endregion

            #region Mediator pattern test code

            IGroupChatMediator groupChatMediator = new ConcreteGroupChatMediator();

            User Ram = new ConcreteUser("Ram");
            User Dave = new ConcreteUser("Dave");
            User Smith = new ConcreteUser("Smith");
            User Rajesh = new ConcreteUser("Rajesh");
            User Sam = new ConcreteUser("Sam");
            User Pam = new ConcreteUser("Pam");
            User Anurag = new ConcreteUser("Anurag");
            User John = new ConcreteUser("John");

            groupChatMediator.RegisterUser(Ram);
            groupChatMediator.RegisterUser(Dave);
            groupChatMediator.RegisterUser(Smith);
            groupChatMediator.RegisterUser(Rajesh);
            groupChatMediator.RegisterUser(Sam);
            groupChatMediator.RegisterUser(Pam);
            groupChatMediator.RegisterUser(Anurag);
            groupChatMediator.RegisterUser(John);

            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();

            Rajesh.Send("What is Design Patterns? Please explain ");

            #endregion
        }
    }
}