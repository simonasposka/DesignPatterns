namespace DesignPatterns.Iterator;

public class DJ
{
    private SongIterator IteratorSongs70S { get; }
    private SongIterator IteratorSongs80S { get; }
    private SongIterator IteratorSongs90S { get; }

    public DJ(SongIterator iteratorSongs70S, SongIterator iteratorSongs80S, SongIterator iteratorSongs90S)
    {
        IteratorSongs70S = iteratorSongs70S;
        IteratorSongs80S = iteratorSongs80S;
        IteratorSongs90S = iteratorSongs90S;
    }

    public void ShowSongs()
    {
        Console.WriteLine("Songs of the 70s:");
        PrintSongs(IteratorSongs70S);
        
        Console.WriteLine("Songs of the 80s:");
        PrintSongs(IteratorSongs80S);
        
        Console.WriteLine("Songs of the 90s:");
        PrintSongs(IteratorSongs90S);
    }

    protected void PrintSongs(SongIterator songsIterator)
    {
        var iterator = songsIterator.GetEnumerator();
        
        while (iterator.MoveNext())
        {
            Song song = (Song) iterator.Current;
            Console.WriteLine("Song: " + song.Name + ", Band: " + song.Band + ", release year: " + song.YearReleased);
        }
    }
}