using System;
namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton Instance { get; set; }

        private Singleton()
        {
        }

        public static Singleton GetSingleton()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }

            return Instance;
        }
    }
}

