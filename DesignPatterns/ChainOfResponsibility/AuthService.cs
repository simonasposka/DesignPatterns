namespace DesignPatterns.ChainOfResponsibility;

public class AuthService
{
    public Handler Handler { get; }

    public AuthService(Handler handler)
    {
        Handler = handler;
    }

    public bool LogIn(string username, string password)
    {
        if (Handler.Handle(username, password))
        {
            Console.WriteLine("Authorization was successfull");
            return true;
        }

        return false;
    }
}