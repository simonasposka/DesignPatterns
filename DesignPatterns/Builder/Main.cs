using DesignPatterns.Builder.Engines;

namespace DesignPatterns.Builder
{
    /*
     * Builder pattern 
     *
     * Type: Creational
     *
     * Intent: Separate the construction of a complex object from
     * its representation so that the same construction process can
     * create different representations.
     */
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            // Manually create a car
            CarBuilder carBuilder = new CarBuilder();
            carBuilder.SetName("Toyota");
            carBuilder.SetColor("Green");
            carBuilder.SetEngine(new EcoEngine());
            carBuilder.SetSeats(4);
            carBuilder.SetMaxSpeed(150);
            var car = carBuilder.GetCar();

            Console.WriteLine("car: " + car);
            // car: Name: Toyota, Seats: 4, MaxSpeed: 150, Engine: EcoEngine, Color: Green

            // Create car using Director
            var director = new Director();
            var sportsCar = director.MakeSportsCar(new CarBuilder());
            Console.WriteLine("sportsCar: " + sportsCar);
            // sportsCar: Name: Porshe, Seats: 2, MaxSpeed: 350, Engine: SportEngine, Color: Red

            var suvCar = director.MakeSUV(new CarBuilder());
            Console.WriteLine("suvCar: " + suvCar);
            // suvCar: Name: Toyota, Seats: 4, MaxSpeed: 150, Engine: EcoEngine, Color: Green
        }
    }
}

