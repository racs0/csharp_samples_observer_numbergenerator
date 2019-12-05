using NumberGenerator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NumberGenerator.Logic
{
    public class MyNumberGenerator : IObservable
    {
        private const int RANDOM_MIN_VALUE = 1;
        private const int RANDOM_MAX_VALUE = 10;

        private readonly IList<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            else
            {
                throw new InvalidOperationException("Observer is already attached!");
            }
        }

        public void Detach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            else
            {
                throw new InvalidOperationException("Observer is not attached!");
            }
        }

        public void StartGeneration()
        {
            Random random = new Random();

            while (true)
            {
                int nextNumber = random.Next(RANDOM_MIN_VALUE, RANDOM_MAX_VALUE + 1);
                NewNumberGenerated(nextNumber);
                Console.WriteLine("--------------------------------");
                Task.Delay(500).Wait();
            }
        }

        private void NewNumberGenerated(int nextNumber)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(nextNumber);
            }
        }
    }
}
