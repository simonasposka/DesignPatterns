using DesignPatterns.Strategy.MoveAlgorithms;
using DesignPatterns.Strategy.Units;

namespace DesignPatterns.State
{
    public class Main
    {
        /*
         * State pattern
         *
         * Type: Behavioral
         *
         * Intent: lets an object alter its behavior when its internal state changes.
         * It appears as if the object changed its class.
         */
        public Main()
        {
        }

        public static void Run()
        {
            Phone phone = new Phone();

            phone.PressHomeButton(); // OffState -> LockedState
            phone.PressHomeButton(); // LockedState -> UnlockedState
            phone.PressHomeButton(); // UnlockedState -> Go To Home Screen

            phone.PressLockButton(); // UnlockedState -> LockedState
            phone.PressHomeButton(); // LockedState -> UnlockedState

            phone.PressLockButton(); // UnlockedState -> LockedState
            phone.PressLockButton(); // LockedState -> OffState
        }
    }
}

