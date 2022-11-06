namespace DesignPatterns.Command
{
    /*
     * Command pattern
     *
     * Type: Behavioral
     *
     * Intent: Encapsulate a request as an object, thereby letting you
     * parameterize clients with different requests, queue or log requests,
     * and support undoable operations.
     */
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            var calculator = new Calculator();
            calculator.SelectNumber(1);
            calculator.Add();
            calculator.SelectNumber(1);
            calculator.Add(); // 2
            calculator.SelectNumber(9);
            calculator.Add(); // 11
            calculator.SelectNumber(5);
            calculator.Subtract(); // 6

            Console.WriteLine($"value = {calculator.Value}");
        }
    }
}