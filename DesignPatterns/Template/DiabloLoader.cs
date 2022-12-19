namespace DesignPatterns.Template;

public class DiabloLoader : BaseGameLoader
{
    protected override byte[] LoadLocalData()
    {
        Console.WriteLine("Loading Diablo files...");
        return new byte[5]; // random data
    }

    protected override void CreateObjects(byte[] data)
    {
        Console.WriteLine("Creating Diablo objects...");
    }

    protected override void DownloadAdditionalFiles()
    {
        Console.WriteLine("Downloading Diablo sounds...");
    }

    protected override void InitializeProfiles()
    {
        Console.WriteLine("Loading Diablo Profiles");
    }

    protected override void Hooks()
    {
        Console.WriteLine("Calling Diablo hook logic...");
    }
}