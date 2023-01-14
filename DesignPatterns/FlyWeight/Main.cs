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
            // var booksToInsert = 10_000_000;
            // var bookTypes = 2;
            //
            // Store store = new Store();
            //
            // for (int i = 0; i < booksToInsert / bookTypes; i++)
            // {
            //     store.StoreBook("book:" + i, i, "Action", "Follet", "Stuff");
            //     store.StoreBook("book:" + i, i, "Fantasy", "Ingram", "Extra");
            // }
            //
            // //store.DisplayBooks();
            //
            // Console.WriteLine(booksToInsert + " Books inserted");
            // Console.WriteLine("Memory usage:");
            // Console.WriteLine("Total: " + (booksToInsert * 20 + bookTypes * 30) / 1024 / 1024 + " MB (instead of " + (booksToInsert * 50) / 1024 / 1024 + " MB)");

            /** Second example */
            var document = "AAZZBBZB";
            char[] chars = document.ToCharArray();
            
            CharacterFactory factory = new CharacterFactory();
            
            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }

    class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character = null;
            
            if (characters.ContainsKey(key)) {
                character = characters[key];
            } else {
                switch (key) {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    //...
                    case 'Z': character = new CharacterZ(); break;
                }
                
                characters.Add(key, character);
            }
            
            return character;
        }
    }

    public abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;
        public abstract void Display(int pointSize);   
    }

    public class CharacterA : Character
    {
        // Constructor
        public CharacterA()
        {
            symbol = 'A';
            height = 100;
            width = 120;
            ascent = 70;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(symbol + " (pointsize " + this.pointSize + ")");
        }
    }
    
    public class CharacterB : Character
    {
        // Constructor
        public CharacterB()
        {
            symbol = 'B';
            height = 100;
            width = 140;
            ascent = 72;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol + " (pointsize " + this.pointSize + ")");
        }
    }
    
    public class CharacterZ : Character
    {
        // Constructor
        public CharacterZ()
        {
            symbol = 'Z';
            height = 100;
            width = 100;
            ascent = 68;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol + " (pointsize " + this.pointSize + ")");
        }
    }
}

