using System;
using DesignPatterns.Builder.Engines;

namespace DesignPatterns.Builder
{
    public class CarBuilder : Builder
    {
        protected Car Car { get; set; } = new Car();

        public CarBuilder()
        {
        }

        public void Reset()
        {
            Car = new Car();
        }

        public void SetName(string name)
        {
            Car.Name = name;
        }

        public void SetSeats(int number)
        {
            Car.Seats = number;
        }

        public void SetMaxSpeed(int number)
        {
            Car.MaxSpeed = number;
        }

        public void SetEngine(Engine engine)
        {
            Car.Engine = engine;
        }

        public void SetColor(string color)
        {
            Car.Color = color;
        }

        public Car GetCar()
        {
            var result = Car;
            Reset();
            return result;
        }
    }
}

