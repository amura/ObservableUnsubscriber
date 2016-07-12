# ObservableUnsubscriber
A very simple generic observable unsubscriber class

Usage inside the observable Subscribe method:

 public IDisposable Subscribe(IObserver<bool> observer)
 {
 			if(!_observers.Contains(observer))
 				 _observers.Add(observer);
 			return new ObservableUnsubscriber<IObserver<bool>>(_observers, observer);
 	}



