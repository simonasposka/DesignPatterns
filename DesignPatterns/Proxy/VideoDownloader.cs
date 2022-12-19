namespace DesignPatterns.Proxy;

public interface VideoDownloader
{
    public Video GetVideo(string videoName);
}