namespace DesignPatterns.Template;

public class BattlefieldLoader : BaseGameLoader
{
    protected override byte[] LoadLocalData()
    {
        Console.WriteLine("Loading Battlefield files...");
        return new byte[10]; // random data
    }

    protected override void CreateObjects(byte[] data)
    {
        Console.WriteLine("Creating Battlefield objects...");
    }

    protected override void DownloadAdditionalFiles()
    {
        Console.WriteLine("Downloading Diablo skins & sounds...");
    }

    protected override void InitializeProfiles()
    {
        Console.WriteLine("Loading Battlefield Profiles");
    }

    protected override void Hooks()
    {
        // Empty method is called hook
    }
}