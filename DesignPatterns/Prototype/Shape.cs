namespace DesignPatterns.Prototype
{
    public abstract class Shape : IPrototype
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public Shape(int x, int y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public abstract IPrototype Clone();
    }
}

