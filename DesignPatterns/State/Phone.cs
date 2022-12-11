using System;
using DesignPatterns.State.states;

namespace DesignPatterns.State
{
    public class Phone
    {
        private State state { get; set; }

        public Phone()
        {
            state = new OffState(this);
        }

        public void SetState(State state)
        {
            this.state = state;
        }

        public void PressHomeButton()
        {
            this.state.OnHome();
        }

        public void PressLockButton()
        {
            this.state.OnLock();
        }
    }
}

