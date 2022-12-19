namespace DesignPatterns.Proxy.Example2;

public class ProxyInternet : Internet
{
    private List<String> BannedSites = new();
    private Internet RealInternet;

    public ProxyInternet()
    {
        RealInternet = new RealInternet();
        BannedSites.Add("banned.com");
    }

    public void ConnectTo(string host)
    {
        if (BannedSites.Contains(host))
        {
            Console.WriteLine("Access denied!");
            return;
        }

        RealInternet.ConnectTo(host);
    }
}