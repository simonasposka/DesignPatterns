using DesignPatterns.Builder.Engines;

namespace DesignPatterns.Builder
{
    public interface Builder
    {
        public void Reset();
        public void SetName(string name);
        public void SetSeats(int number);
        public void SetMaxSpeed(int number);
        public void SetEngine(Engine engine);
        public void SetColor(string color);
    }
}

