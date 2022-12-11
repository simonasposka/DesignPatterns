using System;
namespace DesignPatterns.State.states
{
    public class LockedState : State
    {
        private Phone phone;

        public LockedState(Phone phone)
        {
            this.phone = phone;
        }

        public void OnHome()
        {
            Console.WriteLine("LockedState -> UnlockedState");
            phone.SetState(new UnlockedState(this.phone));
        }

        public void OnLock()
        {
            Console.WriteLine("LockedState -> OffState");
            phone.SetState(new OffState(this.phone));
        }
    }
}

