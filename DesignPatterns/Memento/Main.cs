
namespace DesignPatterns.Memento
{
    public class Main
    {
        /*
         * Memento pattern
         *
         * Type: Behavioral
         *
         * Intent: Without violating encapsulation, capture and externalize an object's internal state so
         * that the object can be restored to this state later.
         */
        public Main()
        {
        }

        public static void Run()
        {
            var editor = new Editor();
            editor.Write("Hello"); // Hello
            editor.Write(","); // ,
            editor.Write("World"); // world
            editor.Undo(); // World
            editor.Undo(); // ,
            editor.Undo(); // Hello
        }
    }
}

