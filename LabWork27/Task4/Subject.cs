using System.Collections.Generic;

namespace Task4
{
    public sealed class Subject
    {
        private List<Observer> _observers = new();
        private int _state;

        public int State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyAllObservers();
            }
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
