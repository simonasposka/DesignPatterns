using DesignPatterns.Mediator.Mediators;

namespace DesignPatterns.Mediator.Users;

public abstract class AbstractUser
{
    private IMediator Mediator { get; }
    public int UserCode { get; set; }

    protected AbstractUser(IMediator mediator)
    {
        Mediator = mediator;
        mediator.AddUser(this);
    }

    public void CreateSaleOffer(string stockSymbol, int amountOfShares)
    {
        Mediator.CreateSaleOffer(stockSymbol, amountOfShares, UserCode);
    }
    
    public void CreateBuyOffer(string stockSymbol, int amountOfShares)
    {
        Mediator.CreateBuyOffer(stockSymbol, amountOfShares, UserCode);
    }
}