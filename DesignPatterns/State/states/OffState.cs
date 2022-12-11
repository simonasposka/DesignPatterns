using System;
namespace DesignPatterns.State.states
{
    public class OffState : State
    {
        private Phone phone;

        public OffState(Phone phone)
        {
            this.phone = phone;
        }

        public void OnHome()
        {
            Console.WriteLine("OffState -> LockedState");
            this.phone.SetState(new LockedState(this.phone));
        }

        public void OnLock()
        {
            Console.WriteLine("OffState -> Do nothing");
        }
    }
}

