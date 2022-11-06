using DesignPatterns.Bridge.Views;
using DesignPatterns.Bridge.Resources;

namespace DesignPatterns.Bridge
{
    public class Main
    {
        /*
         * Bridge pattern
         *
         * Type: Structural
         *
         * Intent: lets you split a large class or a set of closely related 
         * classes into two separate hierarchies: abstraction and implementation, 
         * which can be developed independently of each other.
         */
        public Main()
        {
        }

        public static void Run()
        {
            var artistResource = new ArtistResource(
                new Artist(
                    "Michael",
                    "Jackson",
                    "King of Pop",
                    "https://tinyurl.com/5n6kmn9y"
                )
            );

            var bookResource = new BookResource(
                new Book(
                    "Harry Potter",
                    "Harry Potter and the Philosopher's Stone is a 1997 fantasy novel...",
                    "https://tinyurl.com/52yhzpda"
                )
            );

            // LongFormView with ArtistResource
            View longFormView1 = new LongFormView(artistResource);
            Console.WriteLine("view = " + longFormView1.GetHtml());

            // LongFormView with BookResource
            View longFormView2 = new LongFormView(bookResource);
            Console.WriteLine("\nview = " + longFormView2.GetHtml());

            // ShortFormView with ArtistResource
            View shortFormView1 = new ShortFormView(artistResource);
            Console.WriteLine("\nview = " + shortFormView1.GetHtml());

            // ShortFormView with BookResource
            View shortFormView2 = new ShortFormView(bookResource);
            Console.WriteLine("\nview = " + shortFormView2.GetHtml());
        }
    }
}