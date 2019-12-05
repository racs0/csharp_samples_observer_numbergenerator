using NumberGenerator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGenerator.ConsoleApp.Observer
{
    class CountView : IObserver
    {
        private int _counter = 0;

        public void Update(int nextNumber)
        {
            _counter++;
            Console.WriteLine($"{nameof(CountView)}: {_counter}");
        }
    }
}
