using System;
namespace DesignPatterns.State
{
    public interface State
    {
        public void OnHome();
        public void OnLock();
    }
}

