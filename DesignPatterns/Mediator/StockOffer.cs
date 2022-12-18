namespace DesignPatterns.Mediator;

public class StockOffer
{
    public int SharesAmount { get; }
    public int UserCode { get; }
    public string StockSymbol { get; }

    public StockOffer(int sharesAmount, int userCode, string stockSymbol)
    {
        SharesAmount = sharesAmount;
        UserCode = userCode;
        StockSymbol = stockSymbol;
    }
}