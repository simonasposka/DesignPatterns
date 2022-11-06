using System;
using DesignPatterns.Builder.Engines;

namespace DesignPatterns.Builder
{
    public class Director
    {
        public Director()
        {
        }

        public Car MakeSUV(CarBuilder builder)
        {
            builder.SetName("Toyota");
            builder.SetColor("Green");
            builder.SetEngine(new EcoEngine());
            builder.SetSeats(4);
            builder.SetMaxSpeed(150);

            return builder.GetCar();
        }

        public Car MakeSportsCar(CarBuilder builder)
        {
            builder.SetName("Porshe");
            builder.SetColor("Red");
            builder.SetEngine(new SportEngine());
            builder.SetSeats(2);
            builder.SetMaxSpeed(350);

            return builder.GetCar();
        }
    }
}

