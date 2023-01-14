namespace DesignPatterns.Proxy
{
    public class Main
    {
        /*
         * Proxy pattern
         *
         * Type: Structural
         *
         * Intent: Provide a surrogate or placeholder for another object to control access to it
         */
        public Main()
        {
        }

        public static void Run()
        {
            var videoDownloader = new ProxyVideoDownloader();
            videoDownloader.GetVideo("fifa highlights");
            videoDownloader.GetVideo("fifa highlights"); // retrieved from cache
            videoDownloader.GetVideo("nba highlights");
        }
    }
}

