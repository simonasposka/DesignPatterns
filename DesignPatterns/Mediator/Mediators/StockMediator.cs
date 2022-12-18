using DesignPatterns.Mediator.Users;

namespace DesignPatterns.Mediator.Mediators;

public class StockMediator : IMediator
{
    private List<AbstractUser> Users { get; } = new();
    private List<StockOffer> BuyOffers { get; } = new();
    private List<StockOffer> SellOffers { get; } = new();
    
    private int UserCode { get; set; } = 0;
    
    public void AddUser(AbstractUser user)
    {
        Users.Add(user);
        UserCode += 1;
        user.UserCode = UserCode;
    }
    
    public void CreateSaleOffer(string stockSymbol, int amount, int userCode)
    {
        bool isStockSold = false;
            
        foreach (var offer in BuyOffers)
        {
            if (offer.StockSymbol == stockSymbol && offer.SharesAmount == amount)
            {
                Console.WriteLine(amount + " shares of " + stockSymbol + " sold to user with id " + offer.UserCode);
                BuyOffers.Remove(offer);
                isStockSold = true;
            }

            if (isStockSold)
            {
                break;
            }
        }

        if (!isStockSold)
        {
            Console.WriteLine(amount + " shares of " + stockSymbol + " added to inventory");
            StockOffer newOffering = new StockOffer(amount, userCode, stockSymbol);
            SellOffers.Add(newOffering);
        }
    }

    public void CreateBuyOffer(string stockSymbol, int amount, int userCode)
    {
        bool isStockBought = false;

        foreach (var offer in SellOffers)
        {
            if (offer.StockSymbol == stockSymbol && offer.SharesAmount == amount)
            {
                Console.WriteLine(amount + " shares of " + stockSymbol + " bought by user with id" + offer.UserCode);
                SellOffers.Remove(offer);
                isStockBought = true;
            }

            if (isStockBought)
            {
                break;
            }
        }

        if (!isStockBought)
        {
            Console.WriteLine(amount + " shares of " + stockSymbol + " added to inventory");
            StockOffer newOffering = new StockOffer(amount, userCode, stockSymbol);
            BuyOffers.Add(newOffering);
        }
    }

    public void PrintAllOfferings()
    {
        Console.WriteLine("Stocks Sell Offers:");
        foreach (var offer in SellOffers)
        {
            Console.WriteLine(offer.SharesAmount + " amount of " + offer.StockSymbol);
        }
        
        Console.WriteLine("Stock Buy Offers:");
        
        foreach (var offer in BuyOffers)
        {
            Console.WriteLine(offer.SharesAmount + " amount of " + offer.StockSymbol);
        }
    }
}