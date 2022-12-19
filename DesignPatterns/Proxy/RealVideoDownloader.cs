namespace DesignPatterns.Proxy;

public class RealVideoDownloader : VideoDownloader
{
    public Video GetVideo(string videoName)
    {
        Console.WriteLine("Connecting to https://youtube.com/");
        Console.WriteLine("Downloading video");
        Console.WriteLine("Retrieveing video metadata");
        Console.WriteLine(videoName + " video was successfully downloaded");
        return new Video(videoName);
    }
}