using System.Collections;

namespace DesignPatterns.Iterator;

public class SongsOfThe90s : SongIterator
{
    Dictionary<int, Song> BestSongs;
    private int _hashKey = 0;

    public SongsOfThe90s()
    {
        BestSongs = new Dictionary<int, Song>();
        
        AddSong("Losing My Religion", "REM", 1991);
        AddSong("Creep", "Radiohead", 1993);
        AddSong("Walk on the Ocean", "Toad The Wet Sprocket", 1991);
    }

    public void AddSong(string songName, String bandName, int yearReleased)
    {
        var song = new Song(songName, bandName, yearReleased);
        BestSongs.Add(_hashKey, song);
        _hashKey += 1;
    }

    public IEnumerator GetEnumerator()
    {
        return BestSongs.Values.GetEnumerator();
    }
}