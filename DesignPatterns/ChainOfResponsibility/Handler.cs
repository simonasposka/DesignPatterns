namespace DesignPatterns.ChainOfResponsibility;

public abstract class Handler
{
    private Handler? Next = null;

    protected Handler()
    {
    }

    public Handler SetNextHandler(Handler next)
    {
        Next = next;
        return next;
    }
    
    public abstract bool Handle(string username, string password);

    protected bool HandleNext(string username, string password)
    {
        if (Next == null)
        {
            return true;
        }

        return Next.Handle(username, password);
    } 

}