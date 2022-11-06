namespace DesignPatterns.Strategy.MoveAlgorithms
{
    public class Fly : MoveStrategy
    {
        public Fly()
        {
        }

        public override string Move()
        {
            return "Flying";
        }
    }
}

