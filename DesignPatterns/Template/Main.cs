namespace DesignPatterns.Template
{
    public class Main
    {
        /*
         * Template pattern
         *
         * Type: Behavioral
         *
         * Intent:
         * 1. Break down the algorithm into a series of methods.
         * 2. Put a series of calls to these methods or steps inside a single "template method".
         * 3. The steps may be abstract, or have some default implementation inside the parent class.
         * 4. To use the algorithm, the client must provide its own subclass and implement all abstract steps.
         */
        public Main()
        {
        }

        public static void Run()
        {
            BaseGameLoader diabloLoader = new DiabloLoader();
            diabloLoader.Load();

            BaseGameLoader battlefieldLoader = new BattlefieldLoader();
            battlefieldLoader.Load();
        }
    }
}

