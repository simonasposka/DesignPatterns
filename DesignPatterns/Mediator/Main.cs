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
            var nyseMediator = new StockMediator();

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
        }
    }
}

