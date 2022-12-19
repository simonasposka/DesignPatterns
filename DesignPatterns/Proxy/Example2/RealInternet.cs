namespace DesignPatterns.Proxy.Example2;

public class RealInternet : Internet
{
    public void ConnectTo(string host)
    {
        Console.WriteLine("Opened connection to: " + host);
    }
}