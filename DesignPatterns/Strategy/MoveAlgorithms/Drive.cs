namespace DesignPatterns.Strategy.MoveAlgorithms
{
    public class Drive : MoveStrategy
    {
        public Drive()
        {
        }

        public override string Move()
        {
            return "Driving";
        }
    }
}

