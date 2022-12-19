namespace DesignPatterns.FlyWeight;

public class BookFactory
{ 
    private static Dictionary<string, BookType> BookTypes = new();

    public static BookType GetBookType(string type, string distributor, string otherData)
    {
        if (!BookTypes.ContainsKey(type))
        {
            BookTypes.Add(type, new BookType(type, distributor, otherData));
        }

        return BookTypes[type];
    }
}