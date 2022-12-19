namespace DesignPatterns.Template;

public abstract class BaseGameLoader
{
    public void Load()
    {
        byte[] data = LoadLocalData();
        CreateObjects(data);
        DownloadAdditionalFiles();
        CleanTempFiles();
        InitializeProfiles();
        Hooks();
    }

    protected abstract byte[] LoadLocalData();
    protected abstract void CreateObjects(byte[] data);
    protected abstract void DownloadAdditionalFiles();

    protected void CleanTempFiles()
    {
        Console.WriteLine("Cleaning temporary files...");
    }
    
    protected abstract void InitializeProfiles();
    protected abstract void Hooks();
}