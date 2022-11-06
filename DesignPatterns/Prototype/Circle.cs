namespace DesignPatterns.Prototype
{
    // Concrete Prototype 2
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(
            int x, int y, string color, int radius
        ) : base (x, y, color)
        {
            Radius = radius;
        }

        public override Circle Clone()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"x = {X}, y = {Y}, color = {Color}, radius = {Radius}, address = {GetHashCode()}";
        }
    }
}

