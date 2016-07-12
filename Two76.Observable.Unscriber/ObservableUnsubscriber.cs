using System;
using System.Collections.Generic;

namespace Two76.Observable.Unscriber
{
    public class ObservableUnsubscriber<T> : IDisposable
    {
        private readonly List<T> _observers;
        private readonly T _observer;

        public ObservableUnsubscriber(List<T> observers, T observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {                   
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}