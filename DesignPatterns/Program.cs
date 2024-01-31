using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Factory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //FourWheeler fw = new FourWheeler("ABC000");
            //fw.CreateInnerVehicle();
            //Console.WriteLine(fw.vehicleHashCode);
            //FourWheeler clone = (FourWheeler)fw.Clone();
            //Console.WriteLine(clone.vehicleHashCode);

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

            //IGroupChatMediator groupChatMediator = new ConcreteGroupChatMediator();

            //User Ram = new ConcreteUser("Ram");
            //User Dave = new ConcreteUser("Dave");
            //User Smith = new ConcreteUser("Smith");
            //User Rajesh = new ConcreteUser("Rajesh");
            //User Sam = new ConcreteUser("Sam");
            //User Pam = new ConcreteUser("Pam");
            //User Anurag = new ConcreteUser("Anurag");
            //User John = new ConcreteUser("John");

            //groupChatMediator.RegisterUser(Ram);
            //groupChatMediator.RegisterUser(Dave);
            //groupChatMediator.RegisterUser(Smith);
            //groupChatMediator.RegisterUser(Rajesh);
            //groupChatMediator.RegisterUser(Sam);
            //groupChatMediator.RegisterUser(Pam);
            //groupChatMediator.RegisterUser(Anurag);
            //groupChatMediator.RegisterUser(John);

            //Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            //Console.WriteLine();

            //Rajesh.Send("What is Design Patterns? Please explain ");

            #endregion

            #region Adapter pattern test code

            #endregion

            #region Bridge pattern test code

            //Tv tv = new Tv();
            //RemoteControl rc = new RemoteControl(tv);

            //rc.TogglePower();
            //rc.VolumeUp();

            //Radio radio = new Radio();
            //AdvancedRemoteControl arc = new AdvancedRemoteControl(radio);

            //arc.TogglePower();
            //arc.Mute();

            #endregion

            #region Builder pattern test code

            //Director director = new Director();
            //ConcreteBuilder builder = new ConcreteBuilder();
            //director.Builder = builder;

            //Console.WriteLine("Standard basic product:");
            //director.BuildMinimalViableProduct();
            //Console.WriteLine(builder.Build().ListParts());

            //Console.WriteLine("Standard full featured product:");
            //director.BuildFullFeaturedProduct();
            //Console.WriteLine(builder.Build().ListParts());

            //Console.WriteLine("Custom product:");
            //builder.BuildPartA();
            //builder.BuildPartC();
            //Console.Write(builder.Build().ListParts());

            #endregion

            #region Iterator pattern test code

            //WordsCollection collection = new WordsCollection();
            //collection.AddItem("First");
            //collection.AddItem("Second");
            //collection.AddItem("Third");

            //Console.WriteLine("Straight traversal:");

            //foreach (var element in collection)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine("\nReverse traversal:");

            //collection.ReverseDirection();

            //foreach (var element in collection)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region Strategy pattern test code

            //var context = new Context();

            //Console.WriteLine("Client: Strategy is set to normal sorting.");
            //context.SetStrategy(new StraightSortStrategy());
            //context.DoSomeBusinessLogic();

            //Console.WriteLine();

            //Console.WriteLine("Client: Strategy is set to reverse sorting.");
            //context.SetStrategy(new ReverseSortStrategy());
            //context.DoSomeBusinessLogic();

            #endregion

            #region Memento pattern test code

            //Originator originator = new Originator("Super-duper-super-puper-super.");
            //CareTaker caretaker = new CareTaker(originator);

            //caretaker.Backup();
            //originator.DoSomething();

            //caretaker.Backup();
            //originator.DoSomething();

            //caretaker.Backup();
            //originator.DoSomething();

            //Console.WriteLine();
            //caretaker.ShowHistory();

            //Console.WriteLine("\nClient: Now, let's rollback!\n");
            //caretaker.Undo();

            //Console.WriteLine("\n\nClient: Once more!\n");
            //caretaker.Undo();

            //Console.WriteLine();

            #endregion

            #region Decorator pattern test code

            //Client client = new Client();

            //ConcreteComponent simple = new ConcreteComponent();
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientMethod(simple);
            //Console.WriteLine();

            //ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            //ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            //Console.WriteLine("Client: Now I've got a decorated component:");
            //client.ClientMethod(decorator2);

            #endregion

            #region Abstract Factory pattern test code

            //MacFactory macFactory = new MacFactory();
            //WinFactory winFactory = new WinFactory();
            //App winApp = new App(winFactory);
            //App macApp = new App(macFactory);

            //Console.WriteLine("Starting win app.");
            //winApp.Paint();
            //Console.WriteLine("\nStarting mac app.");
            //macApp.Paint();

            #endregion

            #region Composite pattern test code

            Structural.Composite.Client client = new Structural.Composite.Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);

            #endregion
        }
    }
}