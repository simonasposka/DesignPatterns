using DesignPatterns.Strategy.MoveAlgorithms;

namespace DesignPatterns.Strategy.Units
{
    public abstract class Unit
    {
        protected MoveStrategy MoveStrategy { get; set; }

        public Unit(MoveStrategy moveAlgorithm)
        {
            SetMoveStrategy(moveAlgorithm);
        }

        public void SetMoveStrategy(MoveStrategy moveAlgorithm)
        {
            MoveStrategy = moveAlgorithm;
        }

        public MoveStrategy? GetMoveStrategy()
        {
            return MoveStrategy;
        }
    }
}

