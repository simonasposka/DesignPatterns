namespace DesignPatterns.Singleton
{
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            var instance1 = Singleton.GetSingleton();
            var instance2 = Singleton.GetSingleton();
            var instance3 = Singleton.GetSingleton();

            Console.WriteLine("instance1: " + instance1.GetHashCode());
            Console.WriteLine("instance2: " + instance2.GetHashCode());
            Console.WriteLine("instance3: " + instance3.GetHashCode());
        }
    }
}

