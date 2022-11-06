using DesignPatterns.Strategy.MoveAlgorithms;

namespace DesignPatterns.Strategy.Units
{
    public class Plane : Unit
    {
        public Plane(MoveStrategy moveStrategy) : base(moveStrategy) { }
    }
}
