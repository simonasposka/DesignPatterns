using System.Collections;

namespace DesignPatterns.Iterator;

public interface SongIterator
{
    public IEnumerator GetEnumerator();
}