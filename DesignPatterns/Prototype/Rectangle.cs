namespace DesignPatterns.Prototype
{
    // Concrete Prototype 1
    public class Rectangle : Shape
    {
        private int Width { get; set; }
        private int Height { get; set; }

        public Rectangle(
            int x, int y, string color, int width, int height
        ) : base(x, y, color)
        {
            Width = width;
            Height = height;
        }

        public override Rectangle Clone()
        {
            return (Rectangle)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"x = {X}, y = {Y}, color = {Color}, width = {Width}, height = {Height}, address = {GetHashCode()}";
        }
    }
}

