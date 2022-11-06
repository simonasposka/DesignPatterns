namespace DesignPatterns.Factory
{
    public abstract class AbstractPlane
    {
        public int Speed { get; set; } = 100;
        public int Health { get; set; } = 100;
        public int Damage { get; set; } = 100;

        public AbstractPlane() { }

        public override string ToString()
        {
            return "Speed: " + Speed + "; Health: " + Health + "; Damage: " + Damage;
        }
    }
}

