using System.ComponentModel;
using System.Drawing;
using System.Net;

namespace DesignPatterns.Prototype
{
    public class Main
    {
        /*
         * Prototype pattern
         *
         * Type: Creational
         *
         * Intent: Specify the kinds of objects to create using a
         * prototypical instance, and create new objects by copying this
         * prototype.
         */
        public Main()
        {
        }

        public static void Run()
        {
            var rectangle = new Rectangle(0, 0, "black", 3, 3);
            Console.WriteLine("rectangle: " + rectangle.ToString());
            // x = 0, y = 0, color = black, width = 3, height = 3, address = 58225482

            var copy = rectangle.Clone();
            copy.X = 1;
            copy.Y = 3;
            copy.Color = "brown";
            Console.WriteLine("copy:      " + copy.ToString());
            // x = 1, y = 3, color = brown, width = 3, height = 3, address = 18643596

            var circle = new Circle(0, 0, "white", 5);
            Console.WriteLine("\ncircle: " + circle.ToString());
            // x = 0, y = 0, color = white, radius = 5, address = 33574638

            var circleCopy = circle.Clone();
            circleCopy.Color = "black";
            Console.WriteLine("copy:   " + circleCopy.ToString());
            // x = 0, y = 0, color = black, radius = 5, address = 33736294
        }
    }
}

