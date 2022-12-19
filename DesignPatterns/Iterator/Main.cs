using System.Collections;

namespace DesignPatterns.Iterator
{
    public class Main
    {
        /*
         * Iterator pattern
         *
         * Type: Behavioral
         *
         * Intent: Provide a way to access the elements of an aggregate object sequentially without exposing its
         * underlying representation.
         */
        public Main()
        {
        }

        public static void Run()
        {
            var songs70s = new SongsOfThe70s();
            var songs80s = new SongsOfThe80s();
            var songs90s = new SongsOfThe90s();

            var dj = new DJ(songs70s, songs80s, songs90s);
            
            dj.ShowSongs();
        }
    }
}

