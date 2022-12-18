using DesignPatterns.Mediator.Mediators;

namespace DesignPatterns.Mediator.Users;

public class MerylLynch : AbstractUser
{
    public MerylLynch(IMediator mediator) : base(mediator)
    {
        Console.WriteLine("MerylLynch signed up with with stock exchange!");
    }
}