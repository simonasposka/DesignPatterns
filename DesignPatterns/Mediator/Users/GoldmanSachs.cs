using DesignPatterns.Mediator.Mediators;

namespace DesignPatterns.Mediator.Users;

public class GoldmanSachs : AbstractUser
{
    public GoldmanSachs(IMediator mediator) : base(mediator)
    {
        Console.WriteLine("GoldmanSachs signed up with with stock exchange!");
    }
}