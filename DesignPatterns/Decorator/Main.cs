using DesignPatterns.Decorator.Beverages;
using DesignPatterns.Decorator.Decorators;

namespace DesignPatterns.Decorator
{
    /*
     * Decorator pattern, AKA: Wrapper, Augmentor, Extender
     *
     * Type: Structural
     *
     * Intent: Attach additional responsibilities to an object dynamically.
     * Decorators provide a flexible alternative to subclassing for extending
     * functionality.
     */
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            Beverage coffee = new CaramelDecorator(new Espresso());
            Console.WriteLine(coffee.ToString());
            // description: Espresso, with caramel, cost: 3

            Beverage coffeeWithCaramelAndSoyMilk = new CaramelDecorator(new SoyMilkDecorator(new Espresso()));
            Console.WriteLine(coffeeWithCaramelAndSoyMilk.ToString());
            // description: Espresso, with soy milk, with caramel, cost: 4

            Beverage tea = new SoyMilkDecorator(new Tea());
            Console.WriteLine(tea.ToString());
            // description: Tea, with soy milk, cost: 3
        }
    }
}