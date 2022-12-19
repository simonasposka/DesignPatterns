namespace DesignPatterns.Proxy.Example2
{
    public class Example2
    {
        /*
         * Proxy pattern
         *
         * Type: Structural
         *
         * Intent: Provide a surrogate or placeholder for another object to control access to it
         */
        public Example2()
        {
        }

        public static void Run()
        {
            Internet internet = new ProxyInternet();
            
            internet.ConnectTo("google.com"); // Opened connection to: google.com
            internet.ConnectTo("banned.com"); // Access denied!
        }
    }
}

