namespace DesignPatterns.FlyWeight
{
    /*
     * Flyweight Pattern
     *
     * Type: Structural
     *
     * Intent: Use sharing to support large numbers of fine-grained objects efficiently
     */
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            var booksToInsert = 10_000_000;
            var bookTypes = 2;
            
            Store store = new Store();
            
            for (int i = 0; i < booksToInsert / bookTypes; i++)
            {
                store.StoreBook("book:" + i, i, "Action", "Follet", "Stuff");
                store.StoreBook("book:" + i, i, "Fantasy", "Ingram", "Extra");
            }

            //store.DisplayBooks();

            Console.WriteLine(booksToInsert + " Books inserted");
            Console.WriteLine("Memory usage:");
            Console.WriteLine("Total: " + (booksToInsert * 20 + bookTypes * 30) / 1024 / 1024 + " MB (instead of " + (booksToInsert * 50) / 1024 / 1024 + " MB)");
        }
    }
}

