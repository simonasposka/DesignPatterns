namespace DesignPatterns.ChainOfResponsibility;

public class ValidRoleHandler : Handler
{
    public override bool Handle(string username, string password)
    {
        if (username == "admin_username")
        {
            Console.WriteLine("Loading admin page...");
            return true;
        }

        Console.WriteLine("Loading default page...");
        return HandleNext(username, password);
    }
}