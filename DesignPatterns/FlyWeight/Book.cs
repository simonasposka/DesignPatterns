namespace DesignPatterns.FlyWeight;

public class Book
{
    private String Name;
    private int Price;
    private BookType BookType;
    
    public Book(string name, int price, BookType type)
    {
        Name = name;
        Price = price;
        BookType = type;
    }
}