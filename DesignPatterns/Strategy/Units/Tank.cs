using DesignPatterns.Strategy.MoveAlgorithms;

namespace DesignPatterns.Strategy.Units
{
    public class Tank : Unit
    {
        public Tank(MoveStrategy moveStrategy) : base(moveStrategy) {}
    }
}

