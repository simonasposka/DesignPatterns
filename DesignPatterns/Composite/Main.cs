namespace DesignPatterns.Composite
{
    public class Main
    {
        /*
         * Composite pattern
         *
         * Type: Structural
         *
         * Intent: Compose objects into tree structures to represent part-whole hierarchies.
         * Composite lets clients treat individual objects and compositions of objects uniformly
         */
        public Main()
        {
        }

        public static void Run()
        {
            var deliveryService = new AmazonDeliveryService();
            
            deliveryService.SetupOrder(
                new CompositeBox(
                    new VideoGame("COD", 100)
                )
            );

            Console.WriteLine(deliveryService.CalculateOrderPrice());
        }
    }
}

