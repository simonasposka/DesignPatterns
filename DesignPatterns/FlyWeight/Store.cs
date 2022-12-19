namespace DesignPatterns.FlyWeight;

public class Store
{
    private List<Book> Books = new();

    public void StoreBook(string name, int price, string type, string distributor, string otherData)
    {
        BookType bookType = BookFactory.GetBookType(type, distributor, otherData);
        Books.Add(new Book(name, price, bookType));
    }
}