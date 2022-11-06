namespace DesignPatterns.Observer
{
    // AKA observable / class that will be observed by other observers (clients)
    public class Subject
    {
        protected List<Observer> Observers = new List<Observer>();

        public Subject()
        {
        }

        public void Add(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Remove(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in Observers)
            {
                observer.Update();
            }
        }
    }
}