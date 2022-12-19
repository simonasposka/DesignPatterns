namespace DesignPatterns.Composite;

public class VideoGame : Product
{
    public VideoGame(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override int CalculatePrice()
    {
        return Price;
    }
}