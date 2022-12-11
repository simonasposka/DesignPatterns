using System;
namespace DesignPatterns.State.states
{
    public class UnlockedState : State
    {
        private Phone phone;

        public UnlockedState(Phone phone)
        {
            this.phone = phone;
        }

        public void OnHome()
        {
            Console.WriteLine("UnlockedState -> Go To Home Screen");
        }

        public void OnLock()
        {
            Console.WriteLine("UnlockedState -> LockedState");
            phone.SetState(new LockedState(this.phone));
        }
    }
}

