using DesignPatterns.Factory.factories;

namespace DesignPatterns.Factory
{
    /*
     * Factory pattern AKA Factory Method Pattern
     *
     * Type: Creational
     *
     * Intent: Define an interface for creating an object, but let subclasses
     * decide which class to instantiate. Factory method lets a class defer
     * instantiation to subclasses.
     */
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            IPlaneFactory fastPlaneFactory = new FastPlaneFactory();
            IPlaneFactory fighterPlaneFactory = new FighterPlaneFactory();
            IPlaneFactory tankPlaneFactory = new TankPlaneFactory();

            AbstractPlane fastPlane = fastPlaneFactory.CreatePlane();
            AbstractPlane figterPlane = fighterPlaneFactory.CreatePlane();
            AbstractPlane tankPlane = tankPlaneFactory.CreatePlane();

            Console.WriteLine("fastPlane: " + fastPlane.ToString());
            Console.WriteLine("figterPlane: " + figterPlane.ToString());
            Console.WriteLine("tankPlane: " + tankPlane.ToString());
        }
    }
}

