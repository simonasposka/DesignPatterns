using DesignPatterns.Strategy.MoveAlgorithms;

namespace DesignPatterns.Strategy.Units
{
    public class Ship : Unit
    {
        public Ship(MoveStrategy moveStrategy) : base(moveStrategy) {}
    }
}

