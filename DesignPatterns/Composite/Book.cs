namespace DesignPatterns.Composite;

public class Book : Product
{
    public Book(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override int CalculatePrice()
    {
        return Price;
    }
}