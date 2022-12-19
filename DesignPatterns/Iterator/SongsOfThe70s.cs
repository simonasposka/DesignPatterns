using System.Collections;

namespace DesignPatterns.Iterator;

public class SongsOfThe70s : SongIterator
{
    protected List<Song> BestSongs;

    public SongsOfThe70s()
    {
        BestSongs = new List<Song>();
        
        AddSong("Imagine", "John Lennon", 1971);
        AddSong("American Pie", "Don McLean", 1971);
        AddSong("I Will Survive", "Gloria Gaynor", 1979);
    }

    public void AddSong(string name, string brand, int yearReleased)
    {
        var song = new Song(name, brand, yearReleased);
        BestSongs.Add(song);
    }

    public IEnumerator GetEnumerator()
    {
        return BestSongs.GetEnumerator();
    }
}