namespace DesignPatterns.Proxy;

public class ProxyVideoDownloader : VideoDownloader
{
    private VideoDownloader RealVideoDownloader = new RealVideoDownloader();
    private Dictionary<String, Video> Cache = new();

    public Video GetVideo(string videoName)
    {
        if (!Cache.ContainsKey(videoName))
        {
            Cache.Add(videoName, RealVideoDownloader.GetVideo(videoName));
            Console.WriteLine(videoName + " was added to cache");
        }

        return Cache[videoName];
    }
}