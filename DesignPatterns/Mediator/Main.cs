using DesignPatterns.Mediator.Mediators;
using DesignPatterns.Mediator.Users;

namespace DesignPatterns.Mediator
{
    public class Main
    {
        /*
         * Mediator pattern
         *
         * Type: Behavioral
         *
         * Intent: The Mediator design pattern defines an object that encapsulates how a set of objects interact.
         * Mediator promotes loose coupling by keeping objects from referring to each other explicitly,
         * and it lets you vary their interaction independently.
         */

        public static void Run()
        {
            // Example 1
            /*var nyseMediator = new StockMediator();

            var broker1 = new GoldmanSachs(nyseMediator);
            var broker2 = new MerylLynch(nyseMediator);

            broker1.CreateSaleOffer("GOOG", 100); // 100 shares of GOOG added to inventory
            broker1.CreateSaleOffer("MSFT", 50);  // 50 shares of MSFT added to inventory
            
            broker2.CreateBuyOffer("GOOG", 100);  // 100 shares of GOOG bought by user with id:1
            broker2.CreateBuyOffer("MSFT", 50);   // 50 shares of MSFT bought by user with id:1
            broker2.CreateSaleOffer("META", 20);  // 20 shares of META added to inventory

            broker1.CreateBuyOffer("META", 20);   // 20 shares of META bought by user with id:2
            broker1.CreateBuyOffer("META", 20);   // 20 shares of META added to inventory
            nyseMediator.PrintAllOfferings();
            // Stocks Sell Offers:
            // Stock Buy Offers:
            // 20 amount of META
            */
            
            // Example 2
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 c2 = new ConcreteColleague2(mediator);

            mediator.Collegue1 = c1;
            mediator.Collegue2 = c2;
            
            c1.Send("hi");
            c2.Send("zdarova");
        }
    }

    public abstract class Mediator
    {
        public abstract void Send(String message, Colleague colleague);
    }

    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Collegue1 { get; set; }
        public ConcreteColleague2 Collegue2 { get; set; }
        
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Collegue1)
            {
                Collegue2.Notify(message);
            } else {
                Collegue1.Notify(message);
            }
        }
    }

    public abstract class Colleague
    {
        protected Mediator mediator;
        protected Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(String message)
        {
            mediator.Send(message, this);
        }

        public void Notify(String message)
        {
            Console.WriteLine("ConcreteColleague1 gets message: " + message);
        }
    }
    
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(String message)
        {
            mediator.Send(message, this);
        }

        public void Notify(String message)
        {
            Console.WriteLine("ConcreteColleague2 gets message: " + message);
        }
    }
}

