using DesignPatterns.Mediator.Users;

namespace DesignPatterns.Mediator.Mediators;

public interface IMediator
{
    public void AddUser(AbstractUser user);

    public void CreateSaleOffer(string stockSymbol, int amount, int userCode);
    public void CreateBuyOffer(string stockSymbol, int amount, int userCode);
}