namespace DesignPatterns.Iterator;

public class Song
{
    public string Name { get; set; }
    public string Band { get; set; }
    public int YearReleased { get; set; }

    public Song(string name, string band, int yearReleased)
    {
        Name = name;
        Band = band;
        YearReleased = yearReleased;
    }
}