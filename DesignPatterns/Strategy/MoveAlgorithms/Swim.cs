namespace DesignPatterns.Strategy.MoveAlgorithms
{
    public class Swim : MoveStrategy
    {
        public Swim()
        {
        }

        public override string Move()
        {
            return "Swimming";
        }
    }
}

