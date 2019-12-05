using NumberGenerator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGenerator.Logic
{
    public class ObservableController : IObservable
    {
        IList<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (_observers.Contains(observer))
            {
                throw new InvalidOperationException("Observer is already attached!");
            }

            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (!_observers.Contains(observer))
            {
                throw new InvalidOperationException("Observer was not attached!");
            }

            _observers.Remove(observer);
        }
    }
}
