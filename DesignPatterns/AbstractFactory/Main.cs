using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.UI;

namespace DesignPatterns.AbstractFactory
{
    /*
     * Abstract Factory
     *
     * Type: Creational
     *
     * Intent: Provide an interface for creating families of related or
     * dependent objects without specifying their concrete classes.
     */
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            // Light Theme
            AbstractUIFactory lightThemeFactory = new LightThemeFactory();

            UIElement lightThemeButton = lightThemeFactory.CreateButton("Close");
            UIElement lightThemeModal = lightThemeFactory.CreateModal();

            // Prints: DarkButton & LightModal
            Console.WriteLine("Light Theme");
            Console.WriteLine("lightThemeButton: " + lightThemeButton);
            Console.WriteLine("lightThemeModal: " + lightThemeModal);

            // Dark Theme
            AbstractUIFactory darkThemeFactory = new DarkThemeFactory();

            UIElement darkThemeButton = darkThemeFactory.CreateButton("Close");
            UIElement darkThemeModal = darkThemeFactory.CreateModal();

            // Prints: DarkButton & LightModal
            Console.WriteLine("\nDark Theme");
            Console.WriteLine("darkThemeButton: " + darkThemeButton);
            Console.WriteLine("darkThemeModal: " + darkThemeModal);
        }
    }
}

