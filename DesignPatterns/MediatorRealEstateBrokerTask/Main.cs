namespace DesignPatterns.MediatorRealEstateBrokerTask
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
            RealEstateApp.Run();
        }
    }

    public class RealEstateApp
    {
        public static void Run()
        {
            RealEstateBroker broker = new RealEstateBroker();
            
            Notary notary = new Notary(broker);
            Seller seller = new Seller(broker);
            Buyer buyer = new Buyer(broker);
            Bank bank = new Bank(broker);

            broker.Notary = notary;
            broker.Seller = seller;
            broker.Buyer = buyer;
            broker.Bank = bank;
            
            seller.Action();
            buyer.Action();
            notary.Action();
            bank.Action();
        }
    }

    public abstract class Mediator
    {
        public abstract void Process(Colleague colleague);
    }
    
    public class RealEstateBroker : Mediator
    {
        public Notary Notary { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
        public Bank Bank { get; set; }
        
        public override void Process(Colleague colleague)
        {
            if (colleague == Seller) {
                Seller.Sell();
            } else if (colleague == Buyer) {
                Buyer.Buy();
            } else if (colleague == Notary) {
                Notary.Confirm();
            } else if (colleague == Bank) {
                Bank.MakeTransaction();
            }
        }
    }

    public abstract class Colleague
    {
        protected Mediator Mediator { get; }

        protected Colleague(Mediator m) {
            Mediator = m;
        }

        public void Action()
        {
            Mediator.Process(this);
        }
    }

    public class Notary : Colleague
    {
        public Notary(Mediator m) : base(m)
        {
        }
        
        public void Confirm()
        {
            Console.WriteLine("Notary confirmed transaction");
        }
    }
    
    public class Seller : Colleague
    {
        public Seller(Mediator m) : base(m)
        {
        }
        
        public void Sell()
        {
            Console.WriteLine("Seller put house for sale");
        }
    }
    
    public class Buyer : Colleague
    {
        public Buyer(Mediator m) : base(m)
        {
        }
        
        public void Buy()
        {
            Console.WriteLine("Buyer bought the house!");
            //Mediator.Process("Buyer bought the house!");
        }
    }
    
    public class Bank : Colleague
    {
        public Bank(Mediator m) : base(m)
        {
        }
        
        public void MakeTransaction()
        {
            Console.WriteLine("Transaction was made to the bank");
        }
    }
}

