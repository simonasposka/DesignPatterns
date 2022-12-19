namespace DesignPatterns.ChainOfResponsibility;

public class UserExistsHandler : Handler
{
    private Database Database;

    public UserExistsHandler(Database database)
    {
        Database = database;
    }

    public override bool Handle(string username, string password)
    {
        if (!Database.IsValidUser(username))
        {
            Console.WriteLine("This username is not registered");
            return false;
        }

        return HandleNext(username, password);
    }
}