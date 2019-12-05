using NumberGenerator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NumberGenerator.Logic
{
    public class MyNumberGenerator : IObservable
    {
        private const int RANDOM_MIN_VALUE = 1;

        public void Attach(IObserver observer) => _observableController.Attach(observer);
        public void Detach(IObserver observer) => _observableController.Detach(observer);

        private const int RANDOM_MAX_VALUE = 10;
        private const int MSECONDS_TO_SLEEP = 750;
        private readonly int _nrOfGenerations;

        private readonly ObservableController _observableController;

        public MyNumberGenerator(int nrOfGenerations)
        {
            _nrOfGenerations = nrOfGenerations;
            _observableController = new ObservableController();
        }


        public void Start()
        {
            Random random = new Random();
            for (int i = 0; i < _nrOfGenerations; i++)
            {
                int newNumber = random.Next(RANDOM_MIN_VALUE, RANDOM_MAX_VALUE + 1);
                OnNewNumber(newNumber);
                Task.Delay(MSECONDS_TO_SLEEP).Wait();
                Console.WriteLine("-----------------------------");
            }
        }

        private void OnNewNumber(int newNumber)
        {
            foreach (IObserver observer in _observers)
            {
                // TextView benachrichten
                // CounterView benachrichten
                // BarView beanchrichten
                // SumView benachrichten
                observer.Update(newNumber);
            }
        }
    }
}
