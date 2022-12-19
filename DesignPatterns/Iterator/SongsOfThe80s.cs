using System.Collections;

namespace DesignPatterns.Iterator;

public class SongsOfThe80s : SongIterator
{
    protected Song[] BestSongs;
    private int _index = 0;

    public SongsOfThe80s()
    {
        BestSongs = new Song[3];
        AddSong("Roam", "B 52s", 1989);
        AddSong("Cruel Summer", "Bananarama", 1984);
        AddSong("Head Over Heels", "Tears For Fears", 1985);
    }

    public void AddSong(string songName, String bandName, int yearReleased)
    {
        var song = new Song(songName, bandName, yearReleased);
        BestSongs[_index] = song;
        _index += 1;
    }

    public IEnumerator GetEnumerator()
    {
        return BestSongs.GetEnumerator();
    }
}