namespace DesignPatterns.FlyWeight;

public class BookType
{
    private string Type;
    private string Distributor;
    private string OtherData;

    public BookType(string type, string distributor, string otherData)
    {
        Type = type;
        Distributor = distributor;
        OtherData = otherData;
    }
}