using DesignPatterns.Builder.Engines;

namespace DesignPatterns.Builder
{
    public class Car
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public int MaxSpeed { get; set; }
        public Engine Engine { get; set; }
        public string Color { get; set; }

        public Car()
        {
        }

        public override string ToString()
        {
            return $"Name: {Name}, Seats: {Seats}, MaxSpeed: {MaxSpeed}, Engine: {Engine}, Color: {Color}";
        }
    }
}

