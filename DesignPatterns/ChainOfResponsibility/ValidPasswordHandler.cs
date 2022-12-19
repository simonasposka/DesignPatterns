namespace DesignPatterns.ChainOfResponsibility;

public class ValidPasswordHandler : Handler
{
    private Database Database;

    public ValidPasswordHandler(Database database)
    {
        Database = database;
    }

    public override bool Handle(string username, string password)
    {
        if (!Database.IsValidPassword(username, password))
        {
            Console.WriteLine("Wrong password");
            return false;
        }

        return HandleNext(username, password);
    }
}