using DesignPatterns.Strategy.MoveAlgorithms;
using DesignPatterns.Strategy.Units;

namespace DesignPatterns.Strategy
{
    public class Main
    {
        /*
         * Strategy pattern
         *
         * Type: Behavioral
         *
         * Intent: Define a family of algorithms, encapsulate each one, and
         * make them interchangeable. Strategy lets the algorithm vary
         * independently from clients that use it..
         */
        public Main()
        {
        }

        public static void Run()
        {
            Unit plane = new Plane(new Fly());
            Unit ship = new Ship(new Swim());
            Unit tank = new Tank(new Drive());

            Console.WriteLine();
            Console.WriteLine($"plane move: {plane.GetMoveStrategy().Move()}");
            Console.WriteLine($"ship move: {ship.GetMoveStrategy().Move()}");
            Console.WriteLine($"tank move: {tank.GetMoveStrategy().Move()}");

            // Set new strategy
            plane.SetMoveStrategy(new Swim());
            Console.WriteLine($"updated plane move: {plane.GetMoveStrategy().Move()}");
        }
    }
}

